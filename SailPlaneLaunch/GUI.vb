Imports SailPlaneLaunch.InputArray
Imports System.Threading
Imports System.Windows.Forms.DataVisualization.Charting
Imports System.Linq
Imports System.IO

Public Class GUI
    Dim deb As Debugger
    Private trd As Thread
    Public chartCounter As Integer
    Private plotLastXParam As String = ""
    Private plotLastYParam As String = ""
    Private currentRun As RunLog = Nothing
    Private Sub GUI_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        If My.Settings("lastVersion") <> Application.ProductVersion Then
            Dim rn As ReleaseNotes = New ReleaseNotes
            rn.setBody(True)
            If rn.getBody <> "" Then
                rn.Show(Me)
            End If
            My.Settings("lastVersion") = Application.ProductVersion
            My.Settings.Save()
        End If
    End Sub
    Private Sub GUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Sailplane launch simulator " + Application.ProductVersion
        CheckForIllegalCrossThreadCalls = False
        


        If My.Settings.mustUpgrade Then
            My.Settings.Upgrade()
            My.Settings.mustUpgrade = False
            My.Settings.Save()
            
        End If
        Me.KeyPreview = True
        Me.Text = "Sail plane launch simulator v." + Application.ProductVersion
        'RaiseEvent Button1.Click

        initGUI()
        loadSettings()

        populateVaryCombo()
        sensitivityChart.Series.RemoveAt(0)

        Try
            If Deployment.Application.ApplicationDeployment.CurrentDeployment.IsFirstRun Or My.Settings.reCoeffValue = "" Then
                loadDefaultSettings()
                Welcome.Show(Me)
                Welcome.Focus()
                Welcome.BringToFront()
            End If
        Catch
        End Try

        'ParametersOut.initOutLists()
        'parametersIn.initAll()
        'Simulate.simulate()
        'LabelTest.Text = last("phase")
    End Sub

    Private Sub initGUI()
        plotLastVal.Text = ""
        chartCounter = 1
        'inputs tabs
        initInputs()
        For Each ii As Item In inputs.getAll
            Dim tabPage As TabPage = CType(Me.Tabs.Controls(ii._paramType.ToString), TabPage)
            Dim flow As FlowLayoutPanel = CType(tabPage.Controls("FlowLayoutPanel" + ii._paramType.ToString), FlowLayoutPanel)
            Dim ir As New InputRow(ii)

            flow.Controls.Add(ir)
        Next

        'output tab
        initOutputs()
        For Each ii As Item In outputs.getAllItems
            Dim tabPage As TabPage = CType(Me.Tabs.Controls(ii._paramType.ToString), TabPage)
            Dim flow As FlowLayoutPanel = CType(tabPage.Controls("FlowLayoutPanel" + ii._paramType.ToString), FlowLayoutPanel)
            Dim ir As New InputRow(ii)
            ir.value.Visible = False
            flow.Controls.Add(ir)
        Next

        For Each c As Control In Tools.FindAllChildren(Tabs)
            If c.GetType() Is GetType(InputRow) Then
                Dim ir As InputRow = CType(c, InputRow)
                AddHandler ir.value.LostFocus, AddressOf saveRow
                AddHandler ir.unit.LostFocus, AddressOf saveRow
            End If
        Next
    End Sub

    Private Sub saveRow(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim c As Control = CType(sender, Control)
        Dim ir As InputRow = CType(c.Parent.Parent, InputRow)

        My.Settings(getSettingPrefix(ir) + ir.inputName + "Value") = ir.value.Text
        My.Settings(getSettingPrefix(ir) + ir.inputName + "Unit") = ir.unit.SelectedItem
        My.Settings.Save()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        simulateGo(Nothing)

    End Sub

    Public Sub simulateGo(debugger As Debugger, Optional modifier As Double = 1, Optional modifyItemName As String = "", Optional explicitValue As Boolean = False)

        If plotLogAdd.Checked And RunLogHandler.constains(plotLogName.Text) Then
            MessageBox.Show("Name of the log already exists!", "Duplicated name", MessageBoxButtons.OK, MessageBoxIcon.Error)
            plotLogName.Focus()
            Return
        End If

        ParametersOut.initOutLists()
        parametersIn.initAllValues(modifier, modifyItemName, explicitValue)
        If debugger Is Nothing Then
            Simulate.simulate(False, Nothing)
        Else
            trd = New Thread(Sub() Simulate.simulate(True, debugger))

            trd.IsBackground = True
            trd.Start()

            'Simulate.simulate(True, debugger)
        End If

        If plotLogAdd.Checked Then
            Dim runName As String = RunLogHandler.addLog(outputs, plotLogName.Text)
            plotLogCombo.Items.Add(runName)
            plotLogCombo.SelectedItem = runName
            currentRun = RunLogHandler.lastLog
        Else
            currentRun = New RunLog(outputs, "")
        End If

        If simulateComboX.SelectedItem = Nothing Or simulateComboY.SelectedItem = Nothing Then
            resetCombo()
        End If

        simulateCombo_SelectedIndexChanged(Nothing, System.EventArgs.Empty)




        'LabelTest.Text = last("phase")
    End Sub

    Public Sub resetCombo()
        simulateComboY.Items.Clear()
        For Each s As String In outputs.getAllNames
            simulateComboY.Items.Add(s)
        Next
        simulateComboY.SelectedItem = "groundSpeedX"


        simulateComboX.Items.Clear()
        For Each s As String In outputs.getAllNames
            simulateComboX.Items.Add(s)
        Next
        simulateComboX.SelectedItem = "time"
    End Sub
    Private Sub setupExportSettings_Click(sender As Object, e As EventArgs) Handles setupExportSettings.Click
        SaveFileExportSettings.Filter = "Settings files (*.sailplane)|*.sailplane"
        If SaveFileExportSettings.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            If Saving.exportSettings(SaveFileExportSettings.FileName) Then
                MessageBox.Show("Settings saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                MessageBox.Show("Error occured while saving settings.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If
        End If
    End Sub

    Private Sub setupImportSettings_Click(sender As Object, e As EventArgs) Handles setupImportSettings.Click
        Dim iRet As Integer = MessageBox.Show("The current settings will be lost. Would you like to save them first?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If iRet = DialogResult.Yes Then
            setupExportSettings_Click(setupExportSettings, EventArgs.Empty)
        End If

        OpenFileImportSettings.Filter = "Settings files (*.sailplane)|*.sailplane"
        If OpenFileImportSettings.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

            Saving.importSettings(OpenFileImportSettings.FileName)
            loadSettings()
            MessageBox.Show("Done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub GUI_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        'For Each c As Control In Tools.FindAllChildren(Tabs)
        '    If c.GetType() Is GetType(InputRow) Then
        '        Dim ir As InputRow = CType(c, InputRow)
        '        My.Settings(ir.inputName + "Value") = ir.value.Text
        '        My.Settings(ir.inputName + "Unit") = ir.unit.SelectedItem
        '    End If
        'Next
        My.Settings.Save()
    End Sub

    Private Sub loadSettings()
        Dim notEmpty As Integer = 0
        For Each value As Configuration.SettingsPropertyValue In My.Settings.PropertyValues
            If value.PropertyValue.ToString() <> "" Then
                notEmpty += 1
            End If
        Next

        'If notEmpty > 7 Then
        For Each c As Control In Tools.FindAllChildren(Tabs)
            If c.GetType() Is GetType(InputRow) Then

                Dim ir As InputRow = CType(c, InputRow)
                Try
                    ir.value.Text = My.Settings(getSettingPrefix(c) + ir.inputName + "Value")
                    ir.unit.SelectedItem = My.Settings(getSettingPrefix(c) + ir.inputName + "Unit")
                Catch
                    MessageBox.Show("Add to Settings two entries:outNAMEValue and outNAMEUnit, e.g. outtimeValue, outtimeUnit to solve this problem.")
                End Try
            End If
        Next
        varyParameter.SelectedItem = My.Settings.varyParameter
        plotLogName.Enabled = plotLogAdd.Checked
        'End If
    End Sub

    Private Sub simulateCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles simulateComboY.SelectedIndexChanged
        plotLastVal.Text = lastDesiredUnit(simulateComboY.SelectedItem).ToString("0.####")
        If simulateComboX.SelectedItem <> Nothing Then
            plotCreateChart(simulateComboX.SelectedItem.ToString, simulateComboY.SelectedItem.ToString)
        End If
        plotLastYParam = simulateComboY.SelectedItem.ToString

    End Sub

    Private Sub simulateComboX_SelectedIndexChanged(sender As Object, e As EventArgs) Handles simulateComboX.SelectedIndexChanged
        plotCreateChart(simulateComboX.SelectedItem.ToString, simulateComboY.SelectedItem.ToString)
        plotLastXParam = simulateComboX.SelectedItem.ToString

    End Sub

    Private Sub plotCreateChart(xParam As String, yParam As String)
        Dim MyColors() As Color = {Color.Red, Color.Green, Color.Blue}
        Dim area As ChartArea = Chart1.ChartAreas(0)
        Dim series As Series

        'hold on
        If plotLogCompare.Checked And CheckBoxHoldOn.Checked Then
            If currentRun Is Nothing Then
                MessageBox.Show("Please choose a valid run log", "Invalid log", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Chart1.Series.IsUniqueName(currentRun.name + " " + yParam) Then 'to prevent adding the same item twice
                Return
            End If
            chartCounter += 1
            series = New Series("SERIES" & currentRun.name & chartCounter)
        ElseIf plotLogCompare.Checked And Not CheckBoxHoldOn.Checked Then
            If currentRun Is Nothing Then
                MessageBox.Show("Please choose a valid run log", "Invalid log", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If

            If Not Chart1.Series.IsUniqueName(currentRun.name + " " + yParam) Then 'to prevent adding the same item twice
                Return
            End If
            If plotLastXParam <> xParam Or plotLastYParam <> yParam Then
                Chart1.Series.Clear()
                chartCounter = 0
            Else
                chartCounter += 1
            End If

            series = New Series("SERIES" & currentRun.name & chartCounter)
            ElseIf CheckBoxHoldOn.Checked Then
                If plotLastXParam <> xParam Then
                    Chart1.Series.Clear()
                    chartCounter = 0

                Else
                    If Not Chart1.Series.IsUniqueName(currentRun.name + " " + yParam) Then 'to prevent adding the same item twice
                        Return
                    End If

                    chartCounter += 1
                End If
                series = New Series("SERIES" & currentRun.name & chartCounter)
            ElseIf Not CheckBoxHoldOn.Checked Then
                Chart1.Series.Clear()
                chartCounter = 0
                series = New Series("SERIES" & currentRun.name & chartCounter)

            End If

            series.ChartType = SeriesChartType.Line
            Chart1.Series.Add(series)

            Dim i As Integer = 0
            For Each d As Double In currentRun.log.allValuesDesiredUnit(simulateComboY.SelectedItem)
                series.Points.AddXY(currentRun.log.getValDesiredUnit(xParam, i), d)
                i += 1
            Next

            With series
                .Name = currentRun.name + " " + yParam
                If chartCounter >= MyColors.Count Then
                    .Color = RandomRGBColor()
                Else
                    .Color = MyColors(chartCounter)
                End If
            End With

            With area
                .AxisY.LabelStyle.Angle = -90
                .AxisX.Title = xParam + "[" + currentRun.log.paramUnit(xParam) + "]"
                .AxisY.Title = yParam + "[" + currentRun.log.paramUnit(yParam) + "]"
            End With

            area.RecalculateAxesScale()
    End Sub
    Private m_Rnd As New Random
    Public Function RandomRGBColor() As Color
        Return Color.FromArgb(255, _
            m_Rnd.Next(0, 255), _
            m_Rnd.Next(0, 255), _
            m_Rnd.Next(0, 255))
    End Function

    Private Sub simulateDebug_Click(sender As Object, e As EventArgs) Handles simulateDebug.Click

        deb = New Debugger
        deb.Show(Me)
        simulateGo(deb)
    End Sub

    Private Function getSettingPrefix(c As Control) As String
        If c.Parent.Name = "FlowLayoutPanelOutSetup" Then
            Return "out"
        Else
            Return ""
        End If
    End Function

  
    Private Sub SensitivityRun_Click(sender As Object, e As EventArgs) Handles sensitivityRun.Click
        Sensitivity.run()
    End Sub


    Private Sub varyGo_Click(sender As Object, e As EventArgs) Handles varyGo.Click
        Varying.run()
    End Sub

    Private Sub populateVaryCombo()
        For Each s As String In inputs.getAllNames
            varyParameter.Items.Add(s)
        Next
        varyParameter.SelectedItem = "preTensionOfLine"
    End Sub

    Private Sub setupReport_Click(sender As Object, e As EventArgs) Handles setupReport.Click
        Trello.Show(Me)
    End Sub

    'to modify the pdf, just replace it in the Solution Explorer or on the disk 
    Private Sub setupHelp_Click(sender As Object, e As EventArgs) Handles setupHelp.Click, plotHelp.Click
        Dim thisExe As System.Reflection.Assembly
        thisExe = System.Reflection.Assembly.GetExecutingAssembly()
        Dim newFilePath As String = Path.GetTempPath() + "Sailplane_Launch_Help.pdf"
        Using newFile As Stream = New System.IO.FileStream(newFilePath, IO.FileMode.Create)
            thisExe.GetManifestResourceStream("SailPlaneLaunch.Sailplane_Launch_Help.pdf").CopyTo(newFile)
        End Using
        System.Diagnostics.Process.Start(newFilePath)
    End Sub


    Private Sub setupDefault_Click(sender As Object, e As EventArgs) Handles setupDefault.Click
        Dim iRet As Integer = MessageBox.Show("The current settings will be lost. Would you like to save them first?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)

        If iRet = DialogResult.Yes Then
            setupExportSettings_Click(setupExportSettings, EventArgs.Empty)
        End If

        loadDefaultSettings()
        loadSettings()
        MessageBox.Show("Done.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)

    End Sub

    Private Sub CheckBoxZooming_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxZooming.CheckedChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub plotLogAdd_CheckedChanged(sender As Object, e As EventArgs) Handles plotLogAdd.CheckedChanged
        plotLogName.Enabled = plotLogAdd.Checked
    End Sub

    Private Sub plotLogCombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles plotLogCombo.SelectedIndexChanged
        plotLogCompare.Enabled = True
        If plotLogCombo.Items.Count = 0 Then
            currentRun = Nothing
        Else
            currentRun = RunLogHandler.getLog(plotLogCombo.SelectedItem)
        End If

        If simulateComboX.SelectedItem = Nothing Or simulateComboY.SelectedItem = Nothing Then
            Return
        End If
        plotLastXParam = simulateComboX.SelectedItem.ToString
        plotLastVal.Text = last(simulateComboY.SelectedItem).ToString("0.####")
        plotCreateChart(simulateComboX.SelectedItem.ToString, simulateComboY.SelectedItem.ToString)
    End Sub

    Private Sub setupWelcome_Click(sender As Object, e As EventArgs) Handles setupWelcome.Click
        Welcome.Show(Me)
        Welcome.Focus()
        Welcome.BringToFront()
    End Sub

    Private Sub setupUninstall_Click(sender As Object, e As EventArgs) Handles setupUninstall.Click
        MessageBox.Show("To uninstall the application, please use 'Add/Remove program' feature in 'Programs and Features' in Control Panel.", "Uninstall instructions", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub setupRelease_Click(sender As Object, e As EventArgs) Handles setupRelease.Click
        Dim rn As ReleaseNotes = New ReleaseNotes
        rn.setBody(False)
            rn.Show(Me)
    End Sub


    Private Sub sensitivityComparison_SelectedIndexChanged(sender As Object, e As EventArgs) Handles sensitivityComparison.SelectedIndexChanged
        Sensitivity.redraw()
    End Sub

    Private Sub TableLayoutPanel3_Paint(sender As Object, e As PaintEventArgs) Handles TableLayoutPanel3.Paint

    End Sub
End Class

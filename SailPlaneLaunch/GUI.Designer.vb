<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GUI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea3 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend3 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim LegendItem1 As System.Windows.Forms.DataVisualization.Charting.LegendItem = New System.Windows.Forms.DataVisualization.Charting.LegendItem()
        Dim LegendItem2 As System.Windows.Forms.DataVisualization.Charting.LegendItem = New System.Windows.Forms.DataVisualization.Charting.LegendItem()
        Dim Series3 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(GUI))
        Me.Tabs = New System.Windows.Forms.TabControl()
        Me.Setup = New System.Windows.Forms.TabPage()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.CheckBoxZooming = New System.Windows.Forms.CheckBox()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.setupRelease = New System.Windows.Forms.Button()
        Me.setupUninstall = New System.Windows.Forms.Button()
        Me.setupWelcome = New System.Windows.Forms.Button()
        Me.setupReport = New System.Windows.Forms.Button()
        Me.setupHelp = New System.Windows.Forms.Button()
        Me.FlowLayoutPanelSetup = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.setupDefault = New System.Windows.Forms.Button()
        Me.setupImportSettings = New System.Windows.Forms.Button()
        Me.setupExportSettings = New System.Windows.Forms.Button()
        Me.ComboBoxLaunchMethod = New System.Windows.Forms.ComboBox()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.PlaneParameters = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelPlaneParameters = New System.Windows.Forms.FlowLayoutPanel()
        Me.WinchParameters = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelWinchParameters = New System.Windows.Forms.FlowLayoutPanel()
        Me.LineParameters = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelLineParameters = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlightParameters = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelFlightParameters = New System.Windows.Forms.FlowLayoutPanel()
        Me.FlightConditions = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelFlightConditions = New System.Windows.Forms.FlowLayoutPanel()
        Me.OutSetup = New System.Windows.Forms.TabPage()
        Me.FlowLayoutPanelOutSetup = New System.Windows.Forms.FlowLayoutPanel()
        Me.Plot = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.simulateDebug = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.plotLogCompare = New System.Windows.Forms.CheckBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.plotLogCombo = New System.Windows.Forms.ComboBox()
        Me.plotLogName = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.plotLogAdd = New System.Windows.Forms.CheckBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.simulateComboX = New System.Windows.Forms.ComboBox()
        Me.LabelTest = New System.Windows.Forms.Label()
        Me.CheckBoxHoldOn = New System.Windows.Forms.CheckBox()
        Me.plotLastVal = New System.Windows.Forms.Label()
        Me.simulateComboY = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.plotHelp = New System.Windows.Forms.Button()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Vary = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel4 = New System.Windows.Forms.TableLayoutPanel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.varyParameter = New System.Windows.Forms.ComboBox()
        Me.varyGo = New System.Windows.Forms.Button()
        Me.varySteps = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.varyMin = New System.Windows.Forms.NumericUpDown()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.varyMax = New System.Windows.Forms.NumericUpDown()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.varyChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.SensitivityTab = New System.Windows.Forms.TabPage()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.FlowLayoutPanel2 = New System.Windows.Forms.FlowLayoutPanel()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.sensitivityRun = New System.Windows.Forms.Button()
        Me.sensitivityComparison = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.TableLayoutPanel3 = New System.Windows.Forms.TableLayoutPanel()
        Me.sensitivityChart = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.sensitivityTable = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SaveFileExportSettings = New System.Windows.Forms.SaveFileDialog()
        Me.OpenFileImportSettings = New System.Windows.Forms.OpenFileDialog()
<<<<<<< .mine
        Me.Label17 = New System.Windows.Forms.Label()
        Me.TextBoxSensitivityVariance = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
=======
>>>>>>> .r69
        Me.Tabs.SuspendLayout()
        Me.Setup.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.PlaneParameters.SuspendLayout()
        Me.WinchParameters.SuspendLayout()
        Me.LineParameters.SuspendLayout()
        Me.FlightParameters.SuspendLayout()
        Me.FlightConditions.SuspendLayout()
        Me.OutSetup.SuspendLayout()
        Me.Plot.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Vary.SuspendLayout()
        Me.TableLayoutPanel4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.varyMin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.varyMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.varyChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SensitivityTab.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.FlowLayoutPanel2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TableLayoutPanel3.SuspendLayout()
        CType(Me.sensitivityChart, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.sensitivityTable.SuspendLayout()
        Me.SuspendLayout()
        '
        'Tabs
        '
        Me.Tabs.Controls.Add(Me.Setup)
        Me.Tabs.Controls.Add(Me.PlaneParameters)
        Me.Tabs.Controls.Add(Me.WinchParameters)
        Me.Tabs.Controls.Add(Me.LineParameters)
        Me.Tabs.Controls.Add(Me.FlightParameters)
        Me.Tabs.Controls.Add(Me.FlightConditions)
        Me.Tabs.Controls.Add(Me.OutSetup)
        Me.Tabs.Controls.Add(Me.Plot)
        Me.Tabs.Controls.Add(Me.Vary)
        Me.Tabs.Controls.Add(Me.SensitivityTab)
        Me.Tabs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Tabs.Location = New System.Drawing.Point(0, 0)
        Me.Tabs.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Tabs.Name = "Tabs"
        Me.Tabs.SelectedIndex = 0
        Me.Tabs.Size = New System.Drawing.Size(1287, 668)
        Me.Tabs.TabIndex = 0
        '
        'Setup
        '
        Me.Setup.Controls.Add(Me.PictureBox1)
        Me.Setup.Controls.Add(Me.CheckBoxZooming)
        Me.Setup.Controls.Add(Me.GroupBox5)
        Me.Setup.Controls.Add(Me.FlowLayoutPanelSetup)
        Me.Setup.Controls.Add(Me.GroupBox7)
        Me.Setup.Controls.Add(Me.ComboBoxLaunchMethod)
        Me.Setup.Controls.Add(Me.Label38)
        Me.Setup.Location = New System.Drawing.Point(4, 25)
        Me.Setup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Setup.Name = "Setup"
        Me.Setup.Size = New System.Drawing.Size(1279, 639)
        Me.Setup.TabIndex = 6
        Me.Setup.Text = "Setup"
        Me.Setup.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.SailPlaneLaunch.My.Resources.Resources.ico
        Me.PictureBox1.Location = New System.Drawing.Point(3, 240)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(361, 274)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 71
        Me.PictureBox1.TabStop = False
        '
        'CheckBoxZooming
        '
        Me.CheckBoxZooming.AutoSize = True
        Me.CheckBoxZooming.Location = New System.Drawing.Point(309, 18)
        Me.CheckBoxZooming.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxZooming.Name = "CheckBoxZooming"
        Me.CheckBoxZooming.Size = New System.Drawing.Size(85, 21)
        Me.CheckBoxZooming.TabIndex = 70
        Me.CheckBoxZooming.Text = "Zooming"
        Me.CheckBoxZooming.UseVisualStyleBackColor = True
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.setupRelease)
        Me.GroupBox5.Controls.Add(Me.setupUninstall)
        Me.GroupBox5.Controls.Add(Me.setupWelcome)
        Me.GroupBox5.Controls.Add(Me.setupReport)
        Me.GroupBox5.Controls.Add(Me.setupHelp)
        Me.GroupBox5.Location = New System.Drawing.Point(855, 36)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox5.Size = New System.Drawing.Size(216, 331)
        Me.GroupBox5.TabIndex = 69
        Me.GroupBox5.TabStop = False
        '
        'setupRelease
        '
        Me.setupRelease.Location = New System.Drawing.Point(48, 260)
        Me.setupRelease.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupRelease.Name = "setupRelease"
        Me.setupRelease.Size = New System.Drawing.Size(121, 52)
        Me.setupRelease.TabIndex = 71
        Me.setupRelease.Text = "Release notes"
        Me.setupRelease.UseVisualStyleBackColor = True
        '
        'setupUninstall
        '
        Me.setupUninstall.Location = New System.Drawing.Point(48, 201)
        Me.setupUninstall.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupUninstall.Name = "setupUninstall"
        Me.setupUninstall.Size = New System.Drawing.Size(121, 52)
        Me.setupUninstall.TabIndex = 70
        Me.setupUninstall.Text = "Uninstall instructions"
        Me.setupUninstall.UseVisualStyleBackColor = True
        '
        'setupWelcome
        '
        Me.setupWelcome.Location = New System.Drawing.Point(48, 23)
        Me.setupWelcome.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupWelcome.Name = "setupWelcome"
        Me.setupWelcome.Size = New System.Drawing.Size(121, 52)
        Me.setupWelcome.TabIndex = 69
        Me.setupWelcome.Text = "Welcome Message"
        Me.setupWelcome.UseVisualStyleBackColor = True
        '
        'setupReport
        '
        Me.setupReport.Location = New System.Drawing.Point(48, 82)
        Me.setupReport.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupReport.Name = "setupReport"
        Me.setupReport.Size = New System.Drawing.Size(121, 52)
        Me.setupReport.TabIndex = 67
        Me.setupReport.Text = "Report a bug/suggestion"
        Me.setupReport.UseVisualStyleBackColor = True
        '
        'setupHelp
        '
        Me.setupHelp.Location = New System.Drawing.Point(48, 142)
        Me.setupHelp.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupHelp.Name = "setupHelp"
        Me.setupHelp.Size = New System.Drawing.Size(121, 52)
        Me.setupHelp.TabIndex = 68
        Me.setupHelp.Text = "HELP"
        Me.setupHelp.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelSetup
        '
        Me.FlowLayoutPanelSetup.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelSetup.Location = New System.Drawing.Point(11, 49)
        Me.FlowLayoutPanelSetup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanelSetup.Name = "FlowLayoutPanelSetup"
        Me.FlowLayoutPanelSetup.Size = New System.Drawing.Size(516, 145)
        Me.FlowLayoutPanelSetup.TabIndex = 66
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.setupDefault)
        Me.GroupBox7.Controls.Add(Me.setupImportSettings)
        Me.GroupBox7.Controls.Add(Me.setupExportSettings)
        Me.GroupBox7.Location = New System.Drawing.Point(12, 202)
        Me.GroupBox7.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox7.Size = New System.Drawing.Size(365, 85)
        Me.GroupBox7.TabIndex = 57
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Settings"
        '
        'setupDefault
        '
        Me.setupDefault.Location = New System.Drawing.Point(251, 27)
        Me.setupDefault.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupDefault.Name = "setupDefault"
        Me.setupDefault.Size = New System.Drawing.Size(100, 42)
        Me.setupDefault.TabIndex = 2
        Me.setupDefault.Text = "Default"
        Me.setupDefault.UseVisualStyleBackColor = True
        '
        'setupImportSettings
        '
        Me.setupImportSettings.Location = New System.Drawing.Point(131, 27)
        Me.setupImportSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupImportSettings.Name = "setupImportSettings"
        Me.setupImportSettings.Size = New System.Drawing.Size(100, 42)
        Me.setupImportSettings.TabIndex = 1
        Me.setupImportSettings.Text = "Import"
        Me.setupImportSettings.UseVisualStyleBackColor = True
        '
        'setupExportSettings
        '
        Me.setupExportSettings.Location = New System.Drawing.Point(12, 27)
        Me.setupExportSettings.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.setupExportSettings.Name = "setupExportSettings"
        Me.setupExportSettings.Size = New System.Drawing.Size(100, 42)
        Me.setupExportSettings.TabIndex = 0
        Me.setupExportSettings.Text = "Export"
        Me.setupExportSettings.UseVisualStyleBackColor = True
        '
        'ComboBoxLaunchMethod
        '
        Me.ComboBoxLaunchMethod.FormattingEnabled = True
        Me.ComboBoxLaunchMethod.Items.AddRange(New Object() {"Rolling on ground", "Thrown in the air"})
        Me.ComboBoxLaunchMethod.Location = New System.Drawing.Point(136, 16)
        Me.ComboBoxLaunchMethod.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBoxLaunchMethod.Name = "ComboBoxLaunchMethod"
        Me.ComboBoxLaunchMethod.Size = New System.Drawing.Size(153, 24)
        Me.ComboBoxLaunchMethod.TabIndex = 56
        Me.ComboBoxLaunchMethod.Text = "Rolling on ground"
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(8, 20)
        Me.Label38.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(106, 17)
        Me.Label38.TabIndex = 54
        Me.Label38.Text = "Launch method"
        '
        'PlaneParameters
        '
        Me.PlaneParameters.Controls.Add(Me.FlowLayoutPanelPlaneParameters)
        Me.PlaneParameters.Location = New System.Drawing.Point(4, 25)
        Me.PlaneParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.PlaneParameters.Name = "PlaneParameters"
        Me.PlaneParameters.Size = New System.Drawing.Size(1279, 639)
        Me.PlaneParameters.TabIndex = 2
        Me.PlaneParameters.Text = "PlaneParameters"
        Me.PlaneParameters.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelPlaneParameters
        '
        Me.FlowLayoutPanelPlaneParameters.Location = New System.Drawing.Point(11, 5)
        Me.FlowLayoutPanelPlaneParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanelPlaneParameters.Name = "FlowLayoutPanelPlaneParameters"
        Me.FlowLayoutPanelPlaneParameters.Size = New System.Drawing.Size(516, 496)
        Me.FlowLayoutPanelPlaneParameters.TabIndex = 85
        '
        'WinchParameters
        '
        Me.WinchParameters.Controls.Add(Me.FlowLayoutPanelWinchParameters)
        Me.WinchParameters.Location = New System.Drawing.Point(4, 25)
        Me.WinchParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.WinchParameters.Name = "WinchParameters"
        Me.WinchParameters.Size = New System.Drawing.Size(1279, 639)
        Me.WinchParameters.TabIndex = 3
        Me.WinchParameters.Text = "WinchParameters"
        Me.WinchParameters.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelWinchParameters
        '
        Me.FlowLayoutPanelWinchParameters.Location = New System.Drawing.Point(11, 5)
        Me.FlowLayoutPanelWinchParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanelWinchParameters.Name = "FlowLayoutPanelWinchParameters"
        Me.FlowLayoutPanelWinchParameters.Size = New System.Drawing.Size(612, 496)
        Me.FlowLayoutPanelWinchParameters.TabIndex = 51
        '
        'LineParameters
        '
        Me.LineParameters.Controls.Add(Me.FlowLayoutPanelLineParameters)
        Me.LineParameters.Location = New System.Drawing.Point(4, 25)
        Me.LineParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.LineParameters.Name = "LineParameters"
        Me.LineParameters.Size = New System.Drawing.Size(1279, 639)
        Me.LineParameters.TabIndex = 5
        Me.LineParameters.Text = "LineParameters"
        Me.LineParameters.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelLineParameters
        '
        Me.FlowLayoutPanelLineParameters.Location = New System.Drawing.Point(11, 5)
        Me.FlowLayoutPanelLineParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanelLineParameters.Name = "FlowLayoutPanelLineParameters"
        Me.FlowLayoutPanelLineParameters.Size = New System.Drawing.Size(559, 496)
        Me.FlowLayoutPanelLineParameters.TabIndex = 69
        '
        'FlightParameters
        '
        Me.FlightParameters.Controls.Add(Me.FlowLayoutPanelFlightParameters)
        Me.FlightParameters.Location = New System.Drawing.Point(4, 25)
        Me.FlightParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlightParameters.Name = "FlightParameters"
        Me.FlightParameters.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlightParameters.Size = New System.Drawing.Size(1279, 639)
        Me.FlightParameters.TabIndex = 1
        Me.FlightParameters.Text = "FlightParameters"
        Me.FlightParameters.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelFlightParameters
        '
        Me.FlowLayoutPanelFlightParameters.FlowDirection = System.Windows.Forms.FlowDirection.TopDown
        Me.FlowLayoutPanelFlightParameters.Location = New System.Drawing.Point(11, 7)
        Me.FlowLayoutPanelFlightParameters.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanelFlightParameters.Name = "FlowLayoutPanelFlightParameters"
        Me.FlowLayoutPanelFlightParameters.Size = New System.Drawing.Size(516, 494)
        Me.FlowLayoutPanelFlightParameters.TabIndex = 41
        '
        'FlightConditions
        '
        Me.FlightConditions.Controls.Add(Me.FlowLayoutPanelFlightConditions)
        Me.FlightConditions.Location = New System.Drawing.Point(4, 25)
        Me.FlightConditions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlightConditions.Name = "FlightConditions"
        Me.FlightConditions.Size = New System.Drawing.Size(1279, 639)
        Me.FlightConditions.TabIndex = 4
        Me.FlightConditions.Text = "FlightConditions"
        Me.FlightConditions.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelFlightConditions
        '
        Me.FlowLayoutPanelFlightConditions.Location = New System.Drawing.Point(11, 4)
        Me.FlowLayoutPanelFlightConditions.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanelFlightConditions.Name = "FlowLayoutPanelFlightConditions"
        Me.FlowLayoutPanelFlightConditions.Size = New System.Drawing.Size(611, 496)
        Me.FlowLayoutPanelFlightConditions.TabIndex = 55
        '
        'OutSetup
        '
        Me.OutSetup.Controls.Add(Me.FlowLayoutPanelOutSetup)
        Me.OutSetup.Location = New System.Drawing.Point(4, 25)
        Me.OutSetup.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OutSetup.Name = "OutSetup"
        Me.OutSetup.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.OutSetup.Size = New System.Drawing.Size(1279, 639)
        Me.OutSetup.TabIndex = 7
        Me.OutSetup.Text = "Out setup"
        Me.OutSetup.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanelOutSetup
        '
        Me.FlowLayoutPanelOutSetup.AutoScroll = True
        Me.FlowLayoutPanelOutSetup.Location = New System.Drawing.Point(11, 7)
        Me.FlowLayoutPanelOutSetup.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanelOutSetup.Name = "FlowLayoutPanelOutSetup"
        Me.FlowLayoutPanelOutSetup.Size = New System.Drawing.Size(771, 496)
        Me.FlowLayoutPanelOutSetup.TabIndex = 0
        '
        'Plot
        '
        Me.Plot.Controls.Add(Me.TableLayoutPanel1)
        Me.Plot.Location = New System.Drawing.Point(4, 25)
        Me.Plot.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Plot.Name = "Plot"
        Me.Plot.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Plot.Size = New System.Drawing.Size(1279, 639)
        Me.Plot.TabIndex = 0
        Me.Plot.Text = "Plot"
        Me.Plot.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.FlowLayoutPanel1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.Chart1, 0, 1)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 2
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1271, 631)
        Me.TableLayoutPanel1.TabIndex = 8
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.GroupBox2)
        Me.FlowLayoutPanel1.Controls.Add(Me.plotHelp)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1263, 196)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.simulateDebug)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(267, 186)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Run"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(8, 23)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Run"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'simulateDebug
        '
        Me.simulateDebug.Location = New System.Drawing.Point(8, 59)
        Me.simulateDebug.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.simulateDebug.Name = "simulateDebug"
        Me.simulateDebug.Size = New System.Drawing.Size(100, 28)
        Me.simulateDebug.TabIndex = 4
        Me.simulateDebug.Text = "Debug"
        Me.simulateDebug.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GroupBox6)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.simulateComboX)
        Me.GroupBox2.Controls.Add(Me.LabelTest)
        Me.GroupBox2.Controls.Add(Me.CheckBoxHoldOn)
        Me.GroupBox2.Controls.Add(Me.plotLastVal)
        Me.GroupBox2.Controls.Add(Me.simulateComboY)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 4)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(769, 186)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Chart options"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.plotLogCompare)
        Me.GroupBox6.Controls.Add(Me.Label11)
        Me.GroupBox6.Controls.Add(Me.plotLogCombo)
        Me.GroupBox6.Controls.Add(Me.plotLogName)
        Me.GroupBox6.Controls.Add(Me.Label10)
        Me.GroupBox6.Controls.Add(Me.plotLogAdd)
        Me.GroupBox6.Location = New System.Drawing.Point(348, 65)
        Me.GroupBox6.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox6.Size = New System.Drawing.Size(413, 105)
        Me.GroupBox6.TabIndex = 13
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Run log"
        '
        'plotLogCompare
        '
        Me.plotLogCompare.AutoSize = True
        Me.plotLogCompare.Enabled = False
        Me.plotLogCompare.Location = New System.Drawing.Point(15, 60)
        Me.plotLogCompare.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plotLogCompare.Name = "plotLogCompare"
        Me.plotLogCompare.Size = New System.Drawing.Size(87, 21)
        Me.plotLogCompare.TabIndex = 15
        Me.plotLogCompare.Text = "Compare"
        Me.plotLogCompare.UseVisualStyleBackColor = True
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(144, 64)
        Me.Label11.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(34, 17)
        Me.Label11.TabIndex = 14
        Me.Label11.Text = "Run"
        '
        'plotLogCombo
        '
        Me.plotLogCombo.FormattingEnabled = True
        Me.plotLogCombo.Location = New System.Drawing.Point(192, 60)
        Me.plotLogCombo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plotLogCombo.Name = "plotLogCombo"
        Me.plotLogCombo.Size = New System.Drawing.Size(220, 24)
        Me.plotLogCombo.TabIndex = 13
        '
        'plotLogName
        '
        Me.plotLogName.Location = New System.Drawing.Point(192, 23)
        Me.plotLogName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plotLogName.Name = "plotLogName"
        Me.plotLogName.Size = New System.Drawing.Size(220, 22)
        Me.plotLogName.TabIndex = 11
        '
        'Label10
        '
        Me.Label10.Location = New System.Drawing.Point(131, 20)
        Me.Label10.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 37)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Optional name"
        '
        'plotLogAdd
        '
        Me.plotLogAdd.AutoSize = True
        Me.plotLogAdd.Location = New System.Drawing.Point(15, 26)
        Me.plotLogAdd.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.plotLogAdd.Name = "plotLogAdd"
        Me.plotLogAdd.Size = New System.Drawing.Size(94, 21)
        Me.plotLogAdd.TabIndex = 10
        Me.plotLogAdd.Text = "Add to log"
        Me.plotLogAdd.UseVisualStyleBackColor = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(8, 65)
        Me.Label9.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(116, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Parameter: x axis"
        '
        'simulateComboX
        '
        Me.simulateComboX.FormattingEnabled = True
        Me.simulateComboX.Location = New System.Drawing.Point(132, 62)
        Me.simulateComboX.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.simulateComboX.Name = "simulateComboX"
        Me.simulateComboX.Size = New System.Drawing.Size(160, 24)
        Me.simulateComboX.TabIndex = 9
        '
        'LabelTest
        '
        Me.LabelTest.AutoSize = True
        Me.LabelTest.Location = New System.Drawing.Point(8, 30)
        Me.LabelTest.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelTest.Name = "LabelTest"
        Me.LabelTest.Size = New System.Drawing.Size(117, 17)
        Me.LabelTest.TabIndex = 2
        Me.LabelTest.Text = "Parameter: y axis"
        '
        'CheckBoxHoldOn
        '
        Me.CheckBoxHoldOn.AutoSize = True
        Me.CheckBoxHoldOn.Location = New System.Drawing.Point(363, 31)
        Me.CheckBoxHoldOn.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.CheckBoxHoldOn.Name = "CheckBoxHoldOn"
        Me.CheckBoxHoldOn.Size = New System.Drawing.Size(79, 21)
        Me.CheckBoxHoldOn.TabIndex = 5
        Me.CheckBoxHoldOn.Text = "Hold on"
        Me.CheckBoxHoldOn.UseVisualStyleBackColor = True
        '
        'plotLastVal
        '
        Me.plotLastVal.AutoSize = True
        Me.plotLastVal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.plotLastVal.Location = New System.Drawing.Point(79, 151)
        Me.plotLastVal.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.plotLastVal.Name = "plotLastVal"
        Me.plotLastVal.Size = New System.Drawing.Size(84, 20)
        Me.plotLastVal.TabIndex = 7
        Me.plotLastVal.Text = "LastValue"
        '
        'simulateComboY
        '
        Me.simulateComboY.FormattingEnabled = True
        Me.simulateComboY.Location = New System.Drawing.Point(132, 26)
        Me.simulateComboY.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.simulateComboY.Name = "simulateComboY"
        Me.simulateComboY.Size = New System.Drawing.Size(160, 24)
        Me.simulateComboY.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(8, 154)
        Me.Label8.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(61, 17)
        Me.Label8.TabIndex = 6
        Me.Label8.Text = "Last val:"
        '
        'plotHelp
        '
        Me.plotHelp.Location = New System.Drawing.Point(1056, 10)
        Me.plotHelp.Margin = New System.Windows.Forms.Padding(4, 10, 4, 4)
        Me.plotHelp.Name = "plotHelp"
        Me.plotHelp.Size = New System.Drawing.Size(112, 52)
        Me.plotHelp.TabIndex = 69
        Me.plotHelp.Text = "HELP"
        Me.plotHelp.UseVisualStyleBackColor = True
        '
        'Chart1
        '
        ChartArea1.AxisX.LabelStyle.Format = "0.###"
        ChartArea1.AxisY.LabelStyle.Format = "0.###"
        ChartArea1.BackColor = System.Drawing.Color.White
        ChartArea1.CursorX.IsUserEnabled = True
        ChartArea1.CursorX.IsUserSelectionEnabled = True
        ChartArea1.CursorY.IsUserEnabled = True
        ChartArea1.CursorY.IsUserSelectionEnabled = True
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Me.Chart1.Dock = System.Windows.Forms.DockStyle.Fill
        Legend1.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend1)
        Me.Chart1.Location = New System.Drawing.Point(4, 208)
        Me.Chart1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Chart1.Name = "Chart1"
        Series1.ChartArea = "ChartArea1"
        Series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series1.Legend = "Legend1"
        Series1.Name = "Series1"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Size = New System.Drawing.Size(1263, 419)
        Me.Chart1.TabIndex = 0
        Me.Chart1.Text = "Chart1"
        '
        'Vary
        '
        Me.Vary.Controls.Add(Me.TableLayoutPanel4)
        Me.Vary.Location = New System.Drawing.Point(4, 25)
        Me.Vary.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Vary.Name = "Vary"
        Me.Vary.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Vary.Size = New System.Drawing.Size(1279, 639)
        Me.Vary.TabIndex = 9
        Me.Vary.Text = "Varying"
        Me.Vary.UseVisualStyleBackColor = True
        '
<<<<<<< .mine
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.varyChart, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(4, 4)
        Me.TableLayoutPanel4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(1271, 631)
        Me.TableLayoutPanel4.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.varyParameter)
        Me.Panel1.Controls.Add(Me.varyGo)
        Me.Panel1.Controls.Add(Me.varySteps)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.varyMin)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.varyMax)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(880, 4)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(387, 224)
        Me.Panel1.TabIndex = 13
        '
        'varyParameter
        '
        Me.varyParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.varyParameter.FormattingEnabled = True
        Me.varyParameter.Location = New System.Drawing.Point(120, 4)
        Me.varyParameter.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.varyParameter.Name = "varyParameter"
        Me.varyParameter.Size = New System.Drawing.Size(160, 24)
        Me.varyParameter.TabIndex = 5
        '
=======
        'TableLayoutPanel4
        '
        Me.TableLayoutPanel4.ColumnCount = 2
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel4.Controls.Add(Me.Panel1, 1, 0)
        Me.TableLayoutPanel4.Controls.Add(Me.varyChart, 0, 0)
        Me.TableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel4.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel4.Name = "TableLayoutPanel4"
        Me.TableLayoutPanel4.RowCount = 1
        Me.TableLayoutPanel4.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel4.Size = New System.Drawing.Size(951, 511)
        Me.TableLayoutPanel4.TabIndex = 14
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.varyParameter)
        Me.Panel1.Controls.Add(Me.varyGo)
        Me.Panel1.Controls.Add(Me.varySteps)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.varyMin)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.varyMax)
        Me.Panel1.Controls.Add(Me.Label5)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Location = New System.Drawing.Point(658, 3)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(290, 182)
        Me.Panel1.TabIndex = 13
        '
        'varyParameter
        '
        Me.varyParameter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.varyParameter.FormattingEnabled = True
        Me.varyParameter.Location = New System.Drawing.Point(90, 3)
        Me.varyParameter.Name = "varyParameter"
        Me.varyParameter.Size = New System.Drawing.Size(121, 21)
        Me.varyParameter.TabIndex = 5
        '
>>>>>>> .r69
        'varyGo
        '
        Me.varyGo.Location = New System.Drawing.Point(9, 172)
        Me.varyGo.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.varyGo.Name = "varyGo"
        Me.varyGo.Size = New System.Drawing.Size(100, 28)
        Me.varyGo.TabIndex = 12
        Me.varyGo.Text = "Go"
        Me.varyGo.UseVisualStyleBackColor = True
        '
<<<<<<< .mine
        'varySteps
        '
        Me.varySteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SailPlaneLaunch.My.MySettings.Default, "varySteps", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.varySteps.Location = New System.Drawing.Point(120, 103)
        Me.varySteps.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.varySteps.Name = "varySteps"
        Me.varySteps.Size = New System.Drawing.Size(132, 22)
        Me.varySteps.TabIndex = 4
        Me.varySteps.Text = Global.SailPlaneLaunch.My.MySettings.Default.varySteps
        '
=======
        'varySteps
        '
        Me.varySteps.DataBindings.Add(New System.Windows.Forms.Binding("Text", Global.SailPlaneLaunch.My.MySettings.Default, "varySteps", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.varySteps.Location = New System.Drawing.Point(90, 84)
        Me.varySteps.Name = "varySteps"
        Me.varySteps.Size = New System.Drawing.Size(100, 20)
        Me.varySteps.TabIndex = 4
        Me.varySteps.Text = Global.SailPlaneLaunch.My.MySettings.Default.varySteps
        '
>>>>>>> .r69
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(184, 71)
        Me.Label7.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 17)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "-"
        '
<<<<<<< .mine
        'varyMin
        '
        Me.varyMin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.SailPlaneLaunch.My.MySettings.Default, "varyMin", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.varyMin.Location = New System.Drawing.Point(9, 68)
        Me.varyMin.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.varyMin.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.varyMin.Name = "varyMin"
        Me.varyMin.Size = New System.Drawing.Size(160, 22)
        Me.varyMin.TabIndex = 9
        '
=======
        'varyMin
        '
        Me.varyMin.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.SailPlaneLaunch.My.MySettings.Default, "varyMin", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.varyMin.Location = New System.Drawing.Point(7, 55)
        Me.varyMin.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.varyMin.Name = "varyMin"
        Me.varyMin.Size = New System.Drawing.Size(120, 20)
        Me.varyMin.TabIndex = 9
        '
>>>>>>> .r69
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(5, 107)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(44, 17)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Steps"
        '
<<<<<<< .mine
        'varyMax
        '
        Me.varyMax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.SailPlaneLaunch.My.MySettings.Default, "varyMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.varyMax.Location = New System.Drawing.Point(215, 68)
        Me.varyMax.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.varyMax.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.varyMax.Name = "varyMax"
        Me.varyMax.Size = New System.Drawing.Size(160, 22)
        Me.varyMax.TabIndex = 10
        '
=======
        'varyMax
        '
        Me.varyMax.DataBindings.Add(New System.Windows.Forms.Binding("Value", Global.SailPlaneLaunch.My.MySettings.Default, "varyMax", True, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged))
        Me.varyMax.Location = New System.Drawing.Point(161, 55)
        Me.varyMax.Maximum = New Decimal(New Integer() {10000000, 0, 0, 0})
        Me.varyMax.Name = "varyMax"
        Me.varyMax.Size = New System.Drawing.Size(120, 20)
        Me.varyMax.TabIndex = 10
        '
>>>>>>> .r69
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 48)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 17)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Range"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(5, 7)
        Me.Label4.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 17)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Parameter"
        '
        'varyChart
        '
        ChartArea2.AxisX.LabelStyle.Format = "0.###"
        ChartArea2.AxisY.LabelStyle.Format = "0.###"
        ChartArea2.Name = "ChartArea1"
        Me.varyChart.ChartAreas.Add(ChartArea2)
        Me.varyChart.Dock = System.Windows.Forms.DockStyle.Fill
        Legend2.Name = "Legend1"
        Me.varyChart.Legends.Add(Legend2)
        Me.varyChart.Location = New System.Drawing.Point(4, 4)
        Me.varyChart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.varyChart.Name = "varyChart"
        Series2.ChartArea = "ChartArea1"
        Series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.varyChart.Series.Add(Series2)
        Me.varyChart.Size = New System.Drawing.Size(868, 623)
        Me.varyChart.TabIndex = 1
        Me.varyChart.Text = "Chart3"
        '
        'SensitivityTab
        '
        Me.SensitivityTab.Controls.Add(Me.TableLayoutPanel2)
        Me.SensitivityTab.Location = New System.Drawing.Point(4, 25)
        Me.SensitivityTab.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.SensitivityTab.Name = "SensitivityTab"
        Me.SensitivityTab.Size = New System.Drawing.Size(1279, 639)
        Me.SensitivityTab.TabIndex = 8
        Me.SensitivityTab.Text = "Sensitivity"
        Me.SensitivityTab.UseVisualStyleBackColor = True
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.FlowLayoutPanel2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.TableLayoutPanel3, 0, 1)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle())
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(1279, 639)
        Me.TableLayoutPanel2.TabIndex = 12
        '
        'FlowLayoutPanel2
        '
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox3)
        Me.FlowLayoutPanel2.Controls.Add(Me.GroupBox4)
        Me.FlowLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FlowLayoutPanel2.Location = New System.Drawing.Point(4, 4)
        Me.FlowLayoutPanel2.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.FlowLayoutPanel2.Name = "FlowLayoutPanel2"
        Me.FlowLayoutPanel2.Size = New System.Drawing.Size(1271, 123)
        Me.FlowLayoutPanel2.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label18)
        Me.GroupBox3.Controls.Add(Me.TextBoxSensitivityVariance)
        Me.GroupBox3.Controls.Add(Me.Label17)
        Me.GroupBox3.Controls.Add(Me.ComboBox1)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.sensitivityRun)
        Me.GroupBox3.Controls.Add(Me.sensitivityComparison)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Location = New System.Drawing.Point(4, 4)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox3.Size = New System.Drawing.Size(455, 100)
        Me.GroupBox3.TabIndex = 0
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Sensitivity"
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(273, 68)
        Me.ComboBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox1.TabIndex = 4
        Me.ComboBox1.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(183, 71)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Input"
        Me.Label2.Visible = False
        '
        'sensitivityRun
        '
        Me.sensitivityRun.Location = New System.Drawing.Point(8, 27)
        Me.sensitivityRun.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sensitivityRun.Name = "sensitivityRun"
        Me.sensitivityRun.Size = New System.Drawing.Size(100, 28)
        Me.sensitivityRun.TabIndex = 10
        Me.sensitivityRun.Text = "Run"
        Me.sensitivityRun.UseVisualStyleBackColor = True
        '
        'sensitivityComparison
        '
        Me.sensitivityComparison.FormattingEnabled = True
        Me.sensitivityComparison.Location = New System.Drawing.Point(273, 30)
        Me.sensitivityComparison.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sensitivityComparison.Name = "sensitivityComparison"
        Me.sensitivityComparison.Size = New System.Drawing.Size(160, 24)
        Me.sensitivityComparison.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(183, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Comparison"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label3)
        Me.GroupBox4.Controls.Add(Me.ComboBox3)
        Me.GroupBox4.Location = New System.Drawing.Point(467, 4)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox4.Size = New System.Drawing.Size(493, 100)
        Me.GroupBox4.TabIndex = 1
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "GroupBox4"
        Me.GroupBox4.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 23)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Phase"
        '
        'ComboBox3
        '
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(112, 20)
        Me.ComboBox3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(160, 24)
        Me.ComboBox3.TabIndex = 8
        '
        'TableLayoutPanel3
        '
        Me.TableLayoutPanel3.ColumnCount = 2
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle())
        Me.TableLayoutPanel3.Controls.Add(Me.sensitivityChart, 0, 0)
        Me.TableLayoutPanel3.Controls.Add(Me.sensitivityTable, 1, 0)
        Me.TableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel3.Location = New System.Drawing.Point(4, 135)
        Me.TableLayoutPanel3.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TableLayoutPanel3.Name = "TableLayoutPanel3"
        Me.TableLayoutPanel3.RowCount = 1
        Me.TableLayoutPanel3.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel3.Size = New System.Drawing.Size(1271, 500)
        Me.TableLayoutPanel3.TabIndex = 1
        '
        'sensitivityChart
        '
        ChartArea3.AxisX.LabelStyle.Format = "0.###"
        ChartArea3.AxisY.LabelStyle.Format = "0.###"
        ChartArea3.Name = "ChartArea1"
        Me.sensitivityChart.ChartAreas.Add(ChartArea3)
        Me.sensitivityChart.Dock = System.Windows.Forms.DockStyle.Fill
        LegendItem1.Color = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        LegendItem1.Name = "+30%"
        LegendItem2.Color = System.Drawing.Color.LightBlue
        LegendItem2.Name = "-30%"
        Legend3.CustomItems.Add(LegendItem1)
        Legend3.CustomItems.Add(LegendItem2)
        Legend3.Name = "Legend2"
        Me.sensitivityChart.Legends.Add(Legend3)
        Me.sensitivityChart.Location = New System.Drawing.Point(4, 4)
        Me.sensitivityChart.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.sensitivityChart.Name = "sensitivityChart"
        Series3.ChartArea = "ChartArea1"
        Series3.Legend = "Legend2"
        Series3.Name = "Series1"
        Me.sensitivityChart.Series.Add(Series3)
<<<<<<< .mine
        Me.sensitivityChart.Size = New System.Drawing.Size(793, 492)
=======
        Me.sensitivityChart.Size = New System.Drawing.Size(592, 399)
>>>>>>> .r69
        Me.sensitivityChart.TabIndex = 12
        Me.sensitivityChart.Text = "Chart2"
        '
        'sensitivityTable
        '
        Me.sensitivityTable.AutoScroll = True
        Me.sensitivityTable.AutoSize = True
        Me.sensitivityTable.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.sensitivityTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.[Single]
        Me.sensitivityTable.ColumnCount = 5
<<<<<<< .mine
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 187.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68.0!))
=======
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 140.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50.0!))
        Me.sensitivityTable.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 51.0!))
>>>>>>> .r69
        Me.sensitivityTable.Controls.Add(Me.Label16, 4, 0)
        Me.sensitivityTable.Controls.Add(Me.Label15, 3, 0)
        Me.sensitivityTable.Controls.Add(Me.Label14, 2, 0)
        Me.sensitivityTable.Controls.Add(Me.Label13, 1, 0)
        Me.sensitivityTable.Controls.Add(Me.Label12, 0, 0)
<<<<<<< .mine
        Me.sensitivityTable.Location = New System.Drawing.Point(805, 4)
        Me.sensitivityTable.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
=======
        Me.sensitivityTable.Location = New System.Drawing.Point(601, 3)
>>>>>>> .r69
        Me.sensitivityTable.Name = "sensitivityTable"
        Me.sensitivityTable.RowCount = 1
        Me.sensitivityTable.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
<<<<<<< .mine
        Me.sensitivityTable.Size = New System.Drawing.Size(462, 19)
=======
        Me.sensitivityTable.Size = New System.Drawing.Size(347, 15)
>>>>>>> .r69
        Me.sensitivityTable.TabIndex = 13
        '
        'Label16
        '
<<<<<<< .mine
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(397, 1)
        Me.Label16.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(33, 17)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Max"
=======
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label16.Location = New System.Drawing.Point(298, 1)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(27, 13)
        Me.Label16.TabIndex = 4
        Me.Label16.Text = "Max"
>>>>>>> .r69
        '
        'Label15
        '
<<<<<<< .mine
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(329, 1)
        Me.Label15.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(53, 17)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Normal"
=======
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label15.Location = New System.Drawing.Point(247, 1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 13)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Normal"
>>>>>>> .r69
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
<<<<<<< .mine
        Me.Label14.Location = New System.Drawing.Point(261, 1)
        Me.Label14.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
=======
        Me.Label14.Location = New System.Drawing.Point(196, 1)
>>>>>>> .r69
        Me.Label14.Name = "Label14"
<<<<<<< .mine
        Me.Label14.Size = New System.Drawing.Size(30, 17)
=======
        Me.Label14.Size = New System.Drawing.Size(24, 13)
>>>>>>> .r69
        Me.Label14.TabIndex = 2
        Me.Label14.Text = "Min"
        '
        'Label13
        '
<<<<<<< .mine
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(193, 1)
        Me.Label13.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(41, 17)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Delta"
=======
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label13.Location = New System.Drawing.Point(145, 1)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(32, 13)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Delta"
>>>>>>> .r69
        '
        'Label12
        '
<<<<<<< .mine
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(5, 1)
        Me.Label12.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Name"
=======
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label12.Location = New System.Drawing.Point(4, 1)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(35, 13)
        Me.Label12.TabIndex = 0
        Me.Label12.Text = "Name"
>>>>>>> .r69
        '
<<<<<<< .mine
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(8, 71)
        Me.Label17.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(64, 17)
        Me.Label17.TabIndex = 11
        Me.Label17.Text = "Variance"
        '
        'TextBoxSensitivityVariance
        '
        Me.TextBoxSensitivityVariance.Location = New System.Drawing.Point(79, 69)
        Me.TextBoxSensitivityVariance.Name = "TextBoxSensitivityVariance"
        Me.TextBoxSensitivityVariance.Size = New System.Drawing.Size(70, 22)
        Me.TextBoxSensitivityVariance.TabIndex = 12
        Me.TextBoxSensitivityVariance.Text = "30"
        '
=======
>>>>>>> .r69
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(156, 72)
        Me.Label18.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(20, 17)
        Me.Label18.TabIndex = 13
        Me.Label18.Text = "%"
        '
        'GUI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1287, 668)
        Me.Controls.Add(Me.Tabs)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "GUI"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sail plane launch simulator v0.1"
        Me.Tabs.ResumeLayout(False)
        Me.Setup.ResumeLayout(False)
        Me.Setup.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox7.ResumeLayout(False)
        Me.PlaneParameters.ResumeLayout(False)
        Me.WinchParameters.ResumeLayout(False)
        Me.LineParameters.ResumeLayout(False)
        Me.FlightParameters.ResumeLayout(False)
        Me.FlightConditions.ResumeLayout(False)
        Me.OutSetup.ResumeLayout(False)
        Me.Plot.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Vary.ResumeLayout(False)
        Me.TableLayoutPanel4.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.varyMin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.varyMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.varyChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SensitivityTab.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.FlowLayoutPanel2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.TableLayoutPanel3.ResumeLayout(False)
        Me.TableLayoutPanel3.PerformLayout()
        CType(Me.sensitivityChart, System.ComponentModel.ISupportInitialize).EndInit()
        Me.sensitivityTable.ResumeLayout(False)
        Me.sensitivityTable.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Tabs As System.Windows.Forms.TabControl
    Friend WithEvents Plot As System.Windows.Forms.TabPage
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Chart1 As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents FlightParameters As System.Windows.Forms.TabPage
    Friend WithEvents LabelTest As System.Windows.Forms.Label
    Friend WithEvents PlaneParameters As System.Windows.Forms.TabPage
    Friend WithEvents WinchParameters As System.Windows.Forms.TabPage
    Friend WithEvents FlightConditions As System.Windows.Forms.TabPage
    Friend WithEvents LineParameters As System.Windows.Forms.TabPage
    Friend WithEvents Setup As System.Windows.Forms.TabPage
    Friend WithEvents ComboBoxLaunchMethod As System.Windows.Forms.ComboBox
    Friend WithEvents Label38 As System.Windows.Forms.Label
    Friend WithEvents GroupBox7 As System.Windows.Forms.GroupBox
    Friend WithEvents setupImportSettings As System.Windows.Forms.Button
    Friend WithEvents setupExportSettings As System.Windows.Forms.Button
    Friend WithEvents SaveFileExportSettings As System.Windows.Forms.SaveFileDialog
    Friend WithEvents OpenFileImportSettings As System.Windows.Forms.OpenFileDialog
    Friend WithEvents FlowLayoutPanelFlightParameters As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelPlaneParameters As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelWinchParameters As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelFlightConditions As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelLineParameters As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents FlowLayoutPanelSetup As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents simulateComboY As System.Windows.Forms.ComboBox
    Friend WithEvents simulateDebug As System.Windows.Forms.Button
    Friend WithEvents OutSetup As System.Windows.Forms.TabPage
    Friend WithEvents FlowLayoutPanelOutSetup As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents CheckBoxHoldOn As System.Windows.Forms.CheckBox
    Friend WithEvents SensitivityTab As System.Windows.Forms.TabPage
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents sensitivityRun As System.Windows.Forms.Button
    Friend WithEvents Vary As System.Windows.Forms.TabPage
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents varyParameter As System.Windows.Forms.ComboBox
    Friend WithEvents varySteps As System.Windows.Forms.TextBox
    Friend WithEvents varyChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents varyMax As System.Windows.Forms.NumericUpDown
    Friend WithEvents varyMin As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents varyGo As System.Windows.Forms.Button
    Friend WithEvents plotLastVal As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents FlowLayoutPanel2 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents TableLayoutPanel3 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents sensitivityChart As System.Windows.Forms.DataVisualization.Charting.Chart
    Friend WithEvents setupReport As System.Windows.Forms.Button
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents simulateComboX As System.Windows.Forms.ComboBox
    Friend WithEvents setupHelp As System.Windows.Forms.Button
    Friend WithEvents plotHelp As System.Windows.Forms.Button
    Friend WithEvents setupDefault As System.Windows.Forms.Button
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents CheckBoxZooming As System.Windows.Forms.CheckBox
    Friend WithEvents plotLogAdd As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents plotLogCombo As System.Windows.Forms.ComboBox
    Friend WithEvents plotLogName As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents plotLogCompare As System.Windows.Forms.CheckBox
    Friend WithEvents setupWelcome As System.Windows.Forms.Button
    Friend WithEvents setupUninstall As System.Windows.Forms.Button
    Friend WithEvents setupRelease As System.Windows.Forms.Button
    Public WithEvents sensitivityComparison As System.Windows.Forms.ComboBox
    Public WithEvents sensitivityTable As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents TableLayoutPanel4 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
<<<<<<< .mine
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents TextBoxSensitivityVariance As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
=======
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
>>>>>>> .r69

End Class

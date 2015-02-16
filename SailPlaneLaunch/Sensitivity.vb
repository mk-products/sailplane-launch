Imports System.Windows.Forms.DataVisualization.Charting
Module Sensitivity
    Dim testItems As New List(Of TestItem)
    Dim currentRow As Integer
    Dim numberFormat As String = "0.####"
    Dim variance As Integer


    Public Sub run()
        

        Dim variancePlus, varianceMinus As Double
        variance = CInt(GUI.TextBoxSensitivityVariance.Text)
        variancePlus = 1 + variance / 100
        varianceMinus = 1 - variance / 100

        GUI.Cursor = Cursors.WaitCursor
        testItems.Clear()
        Progress.clearBar()
        Progress.showWindow(GUI)

        GUI.simulateGo(Nothing)

        ' change this to what thats given in dropdown list(y by default)
        Dim normal As New Dictionary(Of String, Double)
        For Each i As Item In outputs.getAllItems
            ' If i._paramType = ParametersTypes.FlightParameters Then
            normal.Add(i._name, last(i._name))
            ' End If
        Next

        Dim currentStep As Integer = 1, maxStep As Integer = inputs.Dict.Count * 2 + 1
        Progress.setBarDecimal(currentStep / maxStep)
        For Each pair As KeyValuePair(Of String, Item) In inputs.Dict

            Dim item As Item = pair.Value
            Dim name As String = pair.Key
            Dim testItem As TestItem = New TestItem(item)   'stores item, min, max and delta

            Progress.setInfo("Processing " + name + "...")

            For Each i As Item In outputs.getAllItems
                testItem.normal.Add(i._name, normal(i._name))
            Next
            'values are read from gui each time u run simulatego (no need to reset values),
            ' so we need to pass which parameter to modify and how much
            GUI.simulateGo(Nothing, varianceMinus, testItem.item._name)
            For Each i As Item In outputs.getAllItems
                testItem.min.Add(i._name, last(i._name))
            Next
            currentStep += 1
            Progress.setBarDecimal(currentStep / maxStep)

            GUI.simulateGo(Nothing, variancePlus, testItem.item._name)
            For Each i As Item In outputs.getAllItems
                testItem.max.Add(i._name, last(i._name))
            Next
            currentStep += 1
            Progress.setBarDecimal(currentStep / maxStep)

            For Each i As Item In outputs.getAllItems

                testItem.delta.Add(i._name, Math.Abs(testItem.min(i._name) - testItem.max(i._name)))
            Next

            testItems.Add(testItem)


            Console.WriteLine(testItem.item._name)
        Next



        If GUI.sensitivityComparison.SelectedItem = Nothing Then
            GUI.sensitivityComparison.Items.Clear()
            For Each s As String In outputs.getAllNames
                GUI.sensitivityComparison.Items.Add(s)
            Next
            GUI.sensitivityComparison.SelectedItem = "y"
        End If
        redraw()

        Progress.hideWindow()
        GUI.Cursor = Cursors.Default
    End Sub

    Public Sub redraw()
        currentRow = 0
        Dim param As String = GUI.sensitivityComparison.SelectedItem

        Dim testItemsSorted = testItems.OrderByDescending(Function(i) i.delta(param))
        'textbox
        Dim maxXAxis As Double = Double.MinValue
        Dim minXAxis As Double = Double.MaxValue

        GUI.sensitivityTable.SuspendLayout()
        GUI.sensitivityTable.Controls.Clear()
        GUI.sensitivityTable.RowStyles.Clear()

        addTitle("Name", "Delta", "Min", "Normal", "Max")
        For Each ti As TestItem In testItemsSorted
            addRow(ti.item._name, ti.delta(param), ti.min(param), ti.normal(param), ti.max(param))
            'Console.Write(ti.item._name & vbTab & ti.delta.ToString(numberFormat) & vbTab & ti.max.ToString(numberFormat) & vbTab & ti.min.ToString(numberFormat) & vbCrLf)
            If ti.min(param) > maxXAxis Then
                maxXAxis = ti.min(param)
            End If
            If ti.max(param) > maxXAxis Then
                maxXAxis = ti.max(param)
            End If
            If ti.max(param) < minXAxis Then
                minXAxis = ti.max(param)
            End If
            If ti.min(param) < minXAxis Then
                minXAxis = ti.min(param)
            End If
        Next
        Dim vertScrollWidth As Integer = SystemInformation.VerticalScrollBarWidth
        GUI.sensitivityTable.Padding = New Padding(0, 0, vertScrollWidth, 0)
        GUI.sensitivityTable.ResumeLayout()

        'chart
        Dim showSameValues As Boolean = False
        testItemsSorted = testItems.OrderBy(Function(i) i.delta(param))

        Dim chart As Chart = GUI.sensitivityChart
        chart.Series.Clear()
        chart.ChartAreas(0).AxisX.Interval = 1  'to show all labels
        chart.ChartAreas(0).AxisY.Minimum = minXAxis - 1
        chart.ChartAreas(0).AxisY.Maximum = maxXAxis + 1
        chart.Legends(0).CustomItems(0).Name = "+" & CStr(variance) & "%"
        chart.Legends(0).CustomItems(1).Name = "-" & CStr(variance) & "%"

        Dim series As Series = New Series("y")
        series.ChartType = SeriesChartType.RangeBar
        series.YValuesPerPoint = 2
        series.CustomProperties = "DrawSideBySide=True"
        series.IsVisibleInLegend = False

        'Chart1.Series["Series1"].Legend = "Legend2";

        Dim pointCount As Integer = 0
        For Each ti As TestItem In testItemsSorted
            If Not showSameValues And (ti.min(param) = ti.normal(param) And ti.max(param) = ti.normal(param)) Then  'not to show values for which y stays the same
                Continue For
            End If

            series.Points.AddXY(pointCount, ti.min(param), ti.normal(param))
            series.Points(series.Points.Count - 1).AxisLabel = ti.item._name
            series.Points(series.Points.Count - 1).Color = Color.LightBlue
            series.Points.AddXY(pointCount, ti.normal(param), ti.max(param))
            series.Points(series.Points.Count - 1).AxisLabel = ti.item._name
            series.Points(series.Points.Count - 1).Color = Color.DarkRed

            pointCount += 1

        Next

        GUI.sensitivityChart.Series.Add(series)
    End Sub

    Public Sub addTitle(name As String, delta As String, min As String, normal As String, max As String)
        AddAutoSizeRow()
        GUI.sensitivityTable.Controls.Add(addLabel(name), 0, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(delta), 1, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(min), 2, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(normal), 3, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(max), 4, currentRow)
        currentRow += 1
    End Sub
    Public Sub addRow(name As String, delta As Double, min As Double, normal As Double, max As Double)
        AddAutoSizeRow()
        GUI.sensitivityTable.Controls.Add(addLabel(name), 0, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(delta.ToString(numberFormat)), 1, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(min.ToString(numberFormat)), 2, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(normal.ToString(numberFormat)), 3, currentRow)
        GUI.sensitivityTable.Controls.Add(addLabel(max.ToString(numberFormat)), 4, currentRow)
        currentRow += 1
    End Sub

    Public Function addLabel(text As String) As Label
        Dim label As Label = New Label
        label.Text = text
        Return label
    End Function

    Public Sub AddAutoSizeRow()
        GUI.sensitivityTable.RowStyles.Add(New RowStyle(SizeType.AutoSize))
        GUI.sensitivityTable.RowCount = GUI.sensitivityTable.RowStyles.Count
    End Sub



End Module

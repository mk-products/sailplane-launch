Imports System.Windows.Forms.DataVisualization.Charting
Module Varying
    Public Sub run()
        My.Settings.varyParameter = GUI.varyParameter.SelectedItem
        GUI.Cursor = Cursors.WaitCursor
        Dim min As Double = GUI.varyMin.Value
        Dim max As Double = GUI.varyMax.Value
        Dim steps As Double = -1
        Dim param As String = GUI.varyParameter.SelectedItem
        Dim ys As List(Of Double) = New List(Of Double)
        Dim vals As List(Of Double) = New List(Of Double)

        If Not Double.TryParse(GUI.varySteps.Text, steps) Then
            MessageBox.Show("Wrong steps value.")
            GUI.Cursor = Cursors.Default
            Return
        End If

        Progress.clearBar()
        Progress.showWindow(GUI)



        'count increase value
        Dim inc As Double = (max - min) / steps

        Dim currentVal As Double = min
        Dim currentStep = 0
        While currentVal < max
            GUI.simulateGo(Nothing, currentVal, param, True)
            vals.Add(currentVal)
            ys.Add(last("y"))
            currentVal += inc
            currentStep += 1
            Progress.setBarDecimal(currentStep / steps)

        End While

        Dim series As Series = New Series()

        For i As Integer = 0 To ys.Count - 1
            series.Points.AddXY(vals(i), ys(i))
        Next
        GUI.varyChart.Series.Clear()
        GUI.varyChart.Series.Add(series)
        GUI.varyChart.ChartAreas(0).AxisY.Title = "y[m]"
        GUI.varyChart.ChartAreas(0).AxisX.Title = param & "[" & inputs.paramUnit(param) & "]"
        GUI.varyChart.Series(0).ChartType = SeriesChartType.Line
        GUI.Cursor = Cursors.Default
        Progress.hideWindow()

    End Sub
End Module

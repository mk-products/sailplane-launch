Public Class Debugger
    Public Property pause As Integer = 1
    Private iterations As Integer = 0
    Private phaseDebug As Integer = 0
    Private nextPhase As Boolean = False
    Private debuggerLastState As Boolean = False

    Private Sub debuggerNext_Click(sender As Object, e As EventArgs) Handles debuggerNext.Click
        pause += 1
        nextPhase = False
        debuggerLastState = True
    End Sub

    Public Sub iterationMade()
        
            iterations += 1
            pause -= 1
            updateIterations()

        If nextPhase And phaseDebug > last("phase") Then

            pause = 1


        End If

    End Sub

    Public Function isPause()
        'Console.Write(pause)
        If pause = 0 Then
            Return True
        End If
        Return False
    End Function

    Sub updateIterations()
        debuggerIterations.Text = "Iterations: " + iterations.ToString
    End Sub
    Sub paused(names As List(Of String), inputs As List(Of Item))
        updateIterations()
        DebuggerTextBox.Text = ""
        DebuggerTextBox.Text += "************************************************************" & Environment.NewLine
        DebuggerTextBox.Text += "********************VELOCITIES******************************" & Environment.NewLine
        DebuggerTextBox.Text += "************************************************************" & Environment.NewLine

        Dim key As String
        ' Get value.
        Dim value As Double

        For Each name As String In names
            ' Get key.
            key = name
            ' Get value.
            If debuggerLastState Then
                value = outputs.last2DesiredUnit(key)
            Else
                value = outputs.lastDesiredUnit(key)
            End If

            DebuggerTextBox.Text += key + ": " + value.ToString & " " & outputs.paramUnit(key) & Environment.NewLine
        Next

        DebuggerTextBoxInputs.Text = ""
        For Each item As Item In inputs
            DebuggerTextBoxInputs.Text += item._label + "/" + item._name + ": " + item._value.ToString & " " & item._unit.ToString & Environment.NewLine
        Next

        DebuggerTextBoxInputs.Text += "Next phase  " & phaseDebug & Environment.NewLine
        DebuggerTextBoxInputs.Text += "Next phase bool  " & nextPhase & Environment.NewLine
    End Sub

    Sub done()
        debuggerIterations.Text = "FINISHED"
    End Sub


    Private Sub DebuggerContinueButton_Click(sender As Object, e As EventArgs) Handles DebuggerContinueButton.Click
        'Simulate.debug = False
        pause = -100
    End Sub

    Private Sub DebuggerStop_Click(sender As Object, e As EventArgs) Handles DebuggerStop.Click
        pause = 1
    End Sub

    Private Sub DebuggerNextPhase_Click(sender As Object, e As EventArgs) Handles DebuggerNextPhase.Click
        phaseDebug += 1
        pause += 1
        nextPhase = True
    End Sub

    Private Sub debuggerLast_Click(sender As Object, e As EventArgs) Handles debuggerLast.Click
        debuggerLastState = True
    End Sub
End Class
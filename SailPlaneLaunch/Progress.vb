Public Class Progress
    'how to use:
    'Progress.clearBar()
    'Progress.showWindow(GUI)
    'Progress.setBarDecimal(0.1)
    'or
    'Progress.setBarPercent(10)
    'Progress.hideWindow

    Private lastVal = -2
    Public Sub clearBar()
        Bar.Value = 0
        info.Text = ""
    End Sub
    Public Sub setBarMax(max As Integer)
        Bar.Maximum = max
    End Sub
    Public Sub setBar(no As Integer)
        Bar.Value = no
    End Sub
    Public Sub setBarPercent(percent As Integer)
        If percent <> lastVal Then
            lastVal = percent
            Bar.Value = (percent / 100) * Bar.Maximum
            Application.DoEvents()
        End If
    End Sub
    Public Sub setBarDecimal(dec As Double)
        setBarPercent(dec * 100)
    End Sub
    Public Sub increase()
        Bar.Increment(1)
    End Sub
    Public Sub setInfo(text As String)
        info.Text = text
    End Sub

    Public Sub hideBar()
        Bar.Visible = False
    End Sub

    Public Sub showBar()
        Bar.Visible = True
    End Sub

    Public Sub showWindow(own As System.Windows.Forms.IWin32Window)
        If Me.Visible = False Then
            Me.Show(own)
        End If

        Me.BringToFront()
        Me.CenterToParent()
    End Sub

    Public Sub hideWindow()
        Me.Hide()
        GUI.Focus()
        GUI.BringToFront()
    End Sub

End Class
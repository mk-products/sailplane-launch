'-to add new release note: 
'0. copy old resource file, e.g. 2.0.0.13.txt
'1. name it as current_version.txt
'2. edit
'3. drag'n'drop to batchGUI>Properties>Resources


Public Class ReleaseNotes

    Public Function getBody() As String
        Return body.Text
    End Function
    Public Sub setBody(last As Boolean)

        Dim content As String = My.Resources.ResourceManager.GetString("ReleaseNotes")
        If last Then
            Dim ver As String = Application.ProductVersion
            If InStrRev(content, ver) <= 0 Then
                body.Text = ""
                Return
            End If
            Dim nex As Integer = content.IndexOf("RELEASE NOTES", 15)
            If nex > 0 Then
                content = content.Substring(0, content.IndexOf("RELEASE NOTES", 15))
            End If

            body.Text = content
        Else
            body.Text = content
        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub ReleaseNotes_Shown(sender As Object, e As EventArgs) Handles MyBase.Shown
        body.DeselectAll()
    End Sub
End Class
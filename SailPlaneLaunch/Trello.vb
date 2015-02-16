Imports System.Net.Mail

Public Class Trello

    Private Sub Trello_Load(sender As Object, e As EventArgs) Handles MyBase.Shown
        Me.BringToFront()
        Me.CenterToParent()
        For Each c As Control In GUI.Tabs.Controls
            trelloTab.Items.Add(c.Text)
        Next

        clearForm()
        trelloName.Text = SystemInformation.UserName

    End Sub

    Private Sub trelloCancel_Click(sender As Object, e As EventArgs) Handles trelloCancel.Click
        Me.Hide()
    End Sub

    Private Sub clearForm()
        trelloType.SelectedIndex = 0
        trelloImportance.SelectedIndex = 0
        trelloTab.SelectedIndex = 0
        trelloDescription.Text = ""
        trelloDetails.Text = ""
        trelloName.Text = ""
    End Sub

    Private Sub trelloSend_Click(sender As Object, e As EventArgs) Handles trelloSend.Click
        If trelloName.Text = "" Then
            MessageBox.Show("Please type in your name.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If trelloDescription.Text = "" Then
            MessageBox.Show("Please type in the description.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If
        Cursor.Current = Cursors.WaitCursor

        Dim res As String = sendToTrello()

        If res = "Message was sent." Then
            MessageBox.Show(res, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            clearForm()
        Else
            MessageBox.Show(res, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
        Cursor.Current = Cursors.Default
        Me.Hide()
        GUI.Focus()
    End Sub

    Private Function sendToTrello() As String
        Dim Recipients As New List(Of String)
        Recipients.Add("mateuszjadczyk+b8sxwjuiebgkf79knpne@boards.trello.com")
        Dim FromEmailAddress As String = "mkproductsinfo@gmail.com"
        Dim Subject As String = "#" + trelloImportance.SelectedItem + " " + trelloType.SelectedItem + "-" + trelloTab.SelectedItem + ":" + trelloDescription.Text
        Dim Body As String = trelloDetails.Text + " By: " + trelloName.Text
        Return SendEmail(Recipients, FromEmailAddress, Subject, Body)
    End Function

    Function SendEmail(ByVal Recipients As List(Of String), _
                      ByVal FromAddress As String, _
                      ByVal Subject As String, _
                      ByVal Body As String, _
                      Optional ByVal UserName As String = "mkproductsinfo@gmail.com", _
                      Optional ByVal Password As String = "jmfwcO4}P>", _
                      Optional ByVal Server As String = "smtp.gmail.com", _
                      Optional ByVal Port As Integer = 587, _
                      Optional ByVal Attachments As List(Of String) = Nothing) As String
        Dim Email As New MailMessage()
        Try
            Dim SMTPServer As New SmtpClient
            If Not Attachments Is Nothing Then
                For Each Attachment As String In Attachments
                    Email.Attachments.Add(New Attachment(Attachment))
                Next
            End If
            Email.From = New MailAddress(FromAddress)
            For Each Recipient As String In Recipients
                Email.To.Add(Recipient)
            Next
            Email.Subject = Subject
            Email.Body = Body
            SMTPServer.Host = Server
            SMTPServer.Port = Port
            SMTPServer.Credentials = New System.Net.NetworkCredential(UserName, Password)
            SMTPServer.EnableSsl = True
            SMTPServer.Send(Email)
            Email.Dispose()
            Return "Message was sent."
        Catch ex As SmtpException
            Email.Dispose()
            Return "Sending message Failed. Smtp Error."
        Catch ex As ArgumentOutOfRangeException
            Email.Dispose()
            Return "Sending message Failed. Check Port Number."
        Catch Ex As InvalidOperationException
            Email.Dispose()
            Return "Sending message Failed. Check Port Number."
        End Try
    End Function


End Class
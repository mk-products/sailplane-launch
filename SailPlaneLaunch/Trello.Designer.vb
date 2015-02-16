<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Trello
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
        Me.trelloType = New System.Windows.Forms.ComboBox()
        Me.trelloTab = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.trelloDescription = New System.Windows.Forms.TextBox()
        Me.trelloImportance = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.trelloDetails = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.trelloName = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.trelloSend = New System.Windows.Forms.Button()
        Me.trelloCancel = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'trelloType
        '
        Me.trelloType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.trelloType.FormattingEnabled = True
        Me.trelloType.Items.AddRange(New Object() {"Bug", "Suggestion"})
        Me.trelloType.Location = New System.Drawing.Point(158, 36)
        Me.trelloType.Name = "trelloType"
        Me.trelloType.Size = New System.Drawing.Size(121, 21)
        Me.trelloType.TabIndex = 0
        '
        'trelloTab
        '
        Me.trelloTab.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.trelloTab.FormattingEnabled = True
        Me.trelloTab.Location = New System.Drawing.Point(158, 65)
        Me.trelloTab.Name = "trelloTab"
        Me.trelloTab.Size = New System.Drawing.Size(121, 21)
        Me.trelloTab.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label8.Location = New System.Drawing.Point(70, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(39, 19)
        Me.Label8.TabIndex = 9
        Me.Label8.Text = "Type"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label1.Location = New System.Drawing.Point(70, 64)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 19)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Tab"
        '
        'trelloDescription
        '
        Me.trelloDescription.Location = New System.Drawing.Point(12, 151)
        Me.trelloDescription.Multiline = True
        Me.trelloDescription.Name = "trelloDescription"
        Me.trelloDescription.Size = New System.Drawing.Size(395, 54)
        Me.trelloDescription.TabIndex = 11
        '
        'trelloImportance
        '
        Me.trelloImportance.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.trelloImportance.FormattingEnabled = True
        Me.trelloImportance.Items.AddRange(New Object() {"1", "2", "3", "4"})
        Me.trelloImportance.Location = New System.Drawing.Point(158, 93)
        Me.trelloImportance.Name = "trelloImportance"
        Me.trelloImportance.Size = New System.Drawing.Size(121, 21)
        Me.trelloImportance.TabIndex = 12
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label2.Location = New System.Drawing.Point(70, 92)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Importance"
        '
        'trelloDetails
        '
        Me.trelloDetails.Location = New System.Drawing.Point(12, 236)
        Me.trelloDetails.Multiline = True
        Me.trelloDetails.Name = "trelloDetails"
        Me.trelloDetails.Size = New System.Drawing.Size(395, 109)
        Me.trelloDetails.TabIndex = 14
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label3.Location = New System.Drawing.Point(8, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(135, 19)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Name and surname"
        '
        'trelloName
        '
        Me.trelloName.Location = New System.Drawing.Point(158, 10)
        Me.trelloName.Name = "trelloName"
        Me.trelloName.Size = New System.Drawing.Size(215, 20)
        Me.trelloName.TabIndex = 16
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 19)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Subject"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 214)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 19)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Description"
        '
        'trelloSend
        '
        Me.trelloSend.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.trelloSend.Location = New System.Drawing.Point(237, 370)
        Me.trelloSend.Name = "trelloSend"
        Me.trelloSend.Size = New System.Drawing.Size(77, 32)
        Me.trelloSend.TabIndex = 19
        Me.trelloSend.Text = "Send"
        Me.trelloSend.UseVisualStyleBackColor = True
        '
        'trelloCancel
        '
        Me.trelloCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.trelloCancel.Location = New System.Drawing.Point(332, 370)
        Me.trelloCancel.Name = "trelloCancel"
        Me.trelloCancel.Size = New System.Drawing.Size(75, 32)
        Me.trelloCancel.TabIndex = 20
        Me.trelloCancel.Text = "Cancel"
        Me.trelloCancel.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(286, 97)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "(4 - most important)"
        '
        'Trello
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.trelloCancel
        Me.ClientSize = New System.Drawing.Size(419, 416)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.trelloCancel)
        Me.Controls.Add(Me.trelloSend)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.trelloName)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.trelloDetails)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.trelloImportance)
        Me.Controls.Add(Me.trelloDescription)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.trelloTab)
        Me.Controls.Add(Me.trelloType)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Trello"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Reporting"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents trelloType As System.Windows.Forms.ComboBox
    Friend WithEvents trelloTab As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents trelloDescription As System.Windows.Forms.TextBox
    Friend WithEvents trelloImportance As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents trelloDetails As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents trelloName As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents trelloSend As System.Windows.Forms.Button
    Friend WithEvents trelloCancel As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

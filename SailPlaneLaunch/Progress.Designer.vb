<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Progress
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
        Me.Bar = New System.Windows.Forms.ProgressBar()
        Me.info = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Bar
        '
        Me.Bar.Location = New System.Drawing.Point(12, 34)
        Me.Bar.Name = "Bar"
        Me.Bar.Size = New System.Drawing.Size(256, 23)
        Me.Bar.TabIndex = 0
        '
        'info
        '
        Me.info.AutoSize = True
        Me.info.Font = New System.Drawing.Font("Calibri", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(238, Byte))
        Me.info.Location = New System.Drawing.Point(13, 67)
        Me.info.Name = "info"
        Me.info.Size = New System.Drawing.Size(0, 15)
        Me.info.TabIndex = 1
        '
        'Progress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(280, 92)
        Me.ControlBox = False
        Me.Controls.Add(Me.info)
        Me.Controls.Add(Me.Bar)
        Me.Name = "Progress"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Progress"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Public WithEvents Bar As System.Windows.Forms.ProgressBar
    Friend WithEvents info As System.Windows.Forms.Label
End Class

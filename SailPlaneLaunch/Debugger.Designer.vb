<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Debugger
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
        Me.DebuggerTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DebuggerNextPhase = New System.Windows.Forms.Button()
        Me.DebuggerStop = New System.Windows.Forms.Button()
        Me.DebuggerContinueButton = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.debuggerIterations = New System.Windows.Forms.TextBox()
        Me.debuggerNext = New System.Windows.Forms.Button()
        Me.DebuggerTextBoxInputs = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.debuggerLast = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'DebuggerTextBox
        '
        Me.DebuggerTextBox.Dock = System.Windows.Forms.DockStyle.Left
        Me.DebuggerTextBox.Location = New System.Drawing.Point(0, 0)
        Me.DebuggerTextBox.Margin = New System.Windows.Forms.Padding(4)
        Me.DebuggerTextBox.Multiline = True
        Me.DebuggerTextBox.Name = "DebuggerTextBox"
        Me.DebuggerTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.DebuggerTextBox.Size = New System.Drawing.Size(484, 743)
        Me.DebuggerTextBox.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.debuggerLast)
        Me.GroupBox1.Controls.Add(Me.DebuggerNextPhase)
        Me.GroupBox1.Controls.Add(Me.DebuggerStop)
        Me.GroupBox1.Controls.Add(Me.DebuggerContinueButton)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.debuggerIterations)
        Me.GroupBox1.Controls.Add(Me.debuggerNext)
        Me.GroupBox1.Location = New System.Drawing.Point(16, -1)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(1005, 37)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        '
        'DebuggerNextPhase
        '
        Me.DebuggerNextPhase.Location = New System.Drawing.Point(696, 9)
        Me.DebuggerNextPhase.Margin = New System.Windows.Forms.Padding(4)
        Me.DebuggerNextPhase.Name = "DebuggerNextPhase"
        Me.DebuggerNextPhase.Size = New System.Drawing.Size(131, 28)
        Me.DebuggerNextPhase.TabIndex = 5
        Me.DebuggerNextPhase.Text = "NextPhase"
        Me.DebuggerNextPhase.UseVisualStyleBackColor = True
        '
        'DebuggerStop
        '
        Me.DebuggerStop.Location = New System.Drawing.Point(557, 9)
        Me.DebuggerStop.Margin = New System.Windows.Forms.Padding(4)
        Me.DebuggerStop.Name = "DebuggerStop"
        Me.DebuggerStop.Size = New System.Drawing.Size(131, 28)
        Me.DebuggerStop.TabIndex = 4
        Me.DebuggerStop.Text = "Stop"
        Me.DebuggerStop.UseVisualStyleBackColor = True
        '
        'DebuggerContinueButton
        '
        Me.DebuggerContinueButton.Location = New System.Drawing.Point(419, 9)
        Me.DebuggerContinueButton.Margin = New System.Windows.Forms.Padding(4)
        Me.DebuggerContinueButton.Name = "DebuggerContinueButton"
        Me.DebuggerContinueButton.Size = New System.Drawing.Size(131, 28)
        Me.DebuggerContinueButton.TabIndex = 3
        Me.DebuggerContinueButton.Text = "Continue"
        Me.DebuggerContinueButton.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(893, 15)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Input constants"
        '
        'debuggerIterations
        '
        Me.debuggerIterations.Location = New System.Drawing.Point(241, 11)
        Me.debuggerIterations.Margin = New System.Windows.Forms.Padding(4)
        Me.debuggerIterations.Name = "debuggerIterations"
        Me.debuggerIterations.Size = New System.Drawing.Size(169, 22)
        Me.debuggerIterations.TabIndex = 1
        '
        'debuggerNext
        '
        Me.debuggerNext.Location = New System.Drawing.Point(8, 9)
        Me.debuggerNext.Margin = New System.Windows.Forms.Padding(4)
        Me.debuggerNext.Name = "debuggerNext"
        Me.debuggerNext.Size = New System.Drawing.Size(131, 28)
        Me.debuggerNext.TabIndex = 0
        Me.debuggerNext.Text = "Next iteration"
        Me.debuggerNext.UseVisualStyleBackColor = True
        '
        'DebuggerTextBoxInputs
        '
        Me.DebuggerTextBoxInputs.Dock = System.Windows.Forms.DockStyle.Left
        Me.DebuggerTextBoxInputs.Location = New System.Drawing.Point(484, 0)
        Me.DebuggerTextBoxInputs.Margin = New System.Windows.Forms.Padding(4, 62, 4, 4)
        Me.DebuggerTextBoxInputs.Multiline = True
        Me.DebuggerTextBoxInputs.Name = "DebuggerTextBoxInputs"
        Me.DebuggerTextBoxInputs.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.DebuggerTextBoxInputs.Size = New System.Drawing.Size(516, 743)
        Me.DebuggerTextBoxInputs.TabIndex = 2
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.Controls.Add(Me.DebuggerTextBoxInputs)
        Me.Panel1.Controls.Add(Me.DebuggerTextBox)
        Me.Panel1.Location = New System.Drawing.Point(16, 43)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(4)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1005, 743)
        Me.Panel1.TabIndex = 3
        '
        'debuggerLast
        '
        Me.debuggerLast.Location = New System.Drawing.Point(147, 9)
        Me.debuggerLast.Margin = New System.Windows.Forms.Padding(4)
        Me.debuggerLast.Name = "debuggerLast"
        Me.debuggerLast.Size = New System.Drawing.Size(131, 28)
        Me.debuggerLast.TabIndex = 6
        Me.debuggerLast.Text = "Last Iteration"
        Me.debuggerLast.UseVisualStyleBackColor = True
        '
        'Debugger
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1045, 801)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.GroupBox1)
        Me.DoubleBuffered = True
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Debugger"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Debugger"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents DebuggerTextBox As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents debuggerNext As System.Windows.Forms.Button
    Friend WithEvents debuggerIterations As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents DebuggerTextBoxInputs As System.Windows.Forms.TextBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents DebuggerContinueButton As System.Windows.Forms.Button
    Friend WithEvents DebuggerStop As System.Windows.Forms.Button
    Friend WithEvents DebuggerNextPhase As System.Windows.Forms.Button
    Friend WithEvents debuggerLast As System.Windows.Forms.Button
End Class

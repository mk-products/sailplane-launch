<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputRow
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.label = New System.Windows.Forms.Label()
        Me.unit = New System.Windows.Forms.ComboBox()
        Me.value = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'label
        '
        Me.label.AutoSize = True
        Me.label.Location = New System.Drawing.Point(3, 0)
        Me.label.Name = "label"
        Me.label.Size = New System.Drawing.Size(0, 13)
        Me.label.TabIndex = 3
        '
        'unit
        '
        Me.unit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.unit.FormattingEnabled = True
        Me.unit.Location = New System.Drawing.Point(313, 3)
        Me.unit.Name = "unit"
        Me.unit.Size = New System.Drawing.Size(52, 21)
        Me.unit.TabIndex = 5
        '
        'value
        '
        Me.value.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.value.Location = New System.Drawing.Point(233, 3)
        Me.value.Name = "value"
        Me.value.Size = New System.Drawing.Size(74, 20)
        Me.value.TabIndex = 4
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 230.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 80.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.value, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.label, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.unit, 2, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(3, 3)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(442, 33)
        Me.TableLayoutPanel1.TabIndex = 6
        '
        'InputRow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 0, 3, 0)
        Me.Name = "InputRow"
        Me.Size = New System.Drawing.Size(492, 30)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents label As System.Windows.Forms.Label
    Friend WithEvents value As System.Windows.Forms.TextBox
    Friend WithEvents unit As System.Windows.Forms.ComboBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel

End Class

Imports SailPlaneLaunch.InputArray

Public Class InputRow
    Public Property inputName As String
    Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub
    Sub New(input As Item)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.inputName = input._name
        Me.label.Text = input._label
        Me.value.Text = input._value
        Me.unit.Items.AddRange(UnitsCategories(input._unitType.ToString).ToArray)
        Me.unit.SelectedItem = convertToNiceUnit(input._unit.ToString)

        Dim ToolTip1 As ToolTip = New ToolTip()
        ToolTip1.SetToolTip(Me.label, input._name)


    End Sub

    Private Sub value_TextChanged(sender As Object, e As EventArgs) Handles value.TextChanged

    End Sub

    Private Sub unit_SelectedIndexChanged(sender As Object, e As EventArgs) Handles unit.SelectedIndexChanged
    End Sub
End Class

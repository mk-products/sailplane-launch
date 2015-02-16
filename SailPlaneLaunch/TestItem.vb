Public Class TestItem
    Public Property min As New Dictionary(Of String, Double)
    Public Property max As New Dictionary(Of String, Double)
    Public Property delta As New Dictionary(Of String, Double)
    Public Property normal As New Dictionary(Of String, Double)
    Public Property item As Item

    Public Sub New(it As Item)
        Me.item = it
    End Sub
End Class

Public Class RunLog
    Public Property log As OutputArray
    Public Property name As String

    Public Sub New(_log As OutputArray, _name As String)
        Me.log = _log
        Me.name = _name
    End Sub
End Class

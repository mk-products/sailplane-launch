Public Module RunLogHandler
    Public Property log As New Dictionary(Of String, RunLog)

    Dim defaultNamesCount As Integer = 0
    Public Function addLog(array As OutputArray, Optional name As String = "") As String
        If name = "" Then
            name = "Run " & defaultNamesCount
            defaultNamesCount += 1
        End If
        log.Add(name, New RunLog(array, name))
        Return name
    End Function

    Public Function getLogArray(name As String) As OutputArray
        Return log(name).log
    End Function

    Public Function getLog(name As String) As RunLog
        Return log(name)
    End Function

    Public Function getAllNames() As List(Of String)
        Dim list As New List(Of String)
        For Each v In log.Values
            list.Add(v.name)
        Next
        Return list
    End Function

    Public Function getAllItems() As List(Of RunLog)
        Dim list As New List(Of RunLog)
        For Each v In log.Values
            list.Add(v)
        Next
        Return list
    End Function

    Public Function constains(name As String) As Boolean
        Return log.ContainsKey(name)
    End Function

    Public Function lastLog() As RunLog
        Return log.ElementAt(log.Count - 1).Value
    End Function
End Module

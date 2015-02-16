
Public Class OutputArray
    

    Private dic As New Dictionary(Of String, List(Of Item))


    Public Sub add(name As String, value As Double, valueUnit As AllUnits, unitType As UnitsTypes, label As String, paramType As ParametersTypes, toolTip As String)
        dic.Add(name, New List(Of Item))
        dic(name).Add(New Item(name, value, valueUnit, unitType, label, paramType, toolTip))
    End Sub

    'Public Function getBasicVal(name As String) As Double
    '    Return Units.convertToBasic(dic(name)._value, dic(name)._unit)
    'End Function

    Public Function getAllNames() As List(Of String)
        Dim list As New List(Of String)
        For Each v In dic.Values
            list.Add(v(0)._name)
        Next
        Return list
    End Function

    Public Function getAllItems() As List(Of Item)
        Dim list As New List(Of Item)
        For Each v In dic.Values
            list.Add(v(0))
        Next
        Return list
    End Function

    Public Sub add(paramName As String, value As Double)
        Dim firstItem As Item = dic(paramName)(0)
        dic(paramName).Add(New Item(paramName, value, firstItem._unit, firstItem._unitType, firstItem._label, firstItem._paramType, firstItem._toolTip))
    End Sub

    Public Function getValDesiredUnit(paramName As String, index As Integer)
        Return convertValDesiredUnit(dic(paramName)(index))
    End Function

    Public Sub setZeroVal(paramName As String, value As Double)
        dic(paramName)(0)._value = value
    End Sub

    Public Function allValuesDesiredUnit(paramName As String) As List(Of Double)
        Dim list As New List(Of Double)
        For Each item As Item In dic(paramName)
            list.Add(convertValDesiredUnit(item))
        Next
        Return list
    End Function

    Public Function last(paramName As String) As Double
        Return dic(paramName)(dic(paramName).Count - 1)._value
    End Function

    Public Function last(paramName As String, value As Double)
        dic(paramName)(dic(paramName).Count - 1)._value = value
    End Function

    Public Function lastDesiredUnit(paramName As String) As Double
        Return convertValDesiredUnit(dic(paramName)(dic(paramName).Count - 1))
    End Function

    Public Function last2DesiredUnit(paramName As String) As Double
        Return convertValDesiredUnit(dic(paramName)(dic(paramName).Count - 2))
    End Function

    Public Function paramUnit(paramName As String) As String
        Return dic(paramName)(dic(paramName).Count - 1)._unit.ToString
    End Function

    Public Function last2(paramName As String) As Double
        If dic(paramName).Count < 3 Then
            last2 = dic(paramName).Item(0)._value
        Else
            last2 = dic(paramName).Item(dic(paramName).Count - 2)._value
        End If
    End Function

    Public Function convertValDesiredUnit(item As Item) As Double
        Return FormatNumber(Units.convertToDesired(item._value, item._unit), 5)
    End Function

    Public Function constains(paramName As String) As Boolean
        Return dic.ContainsKey(paramName)
    End Function

    Public Sub resetAll()
        outputs = New OutputArray
        'dic.Clear()
        'Dim pair As KeyValuePair(Of String, List(Of Item))
        'For Each pair In dic
        '    pair.Value.Clear()
        'Next
        initOutputs()
    End Sub

End Class

'Add parameters for new tabs here
Public Enum ParametersTypes
    FlightParameters
    WinchParameters
    PlaneParameters
    LineParameters
    FlightConditions
    Setup
    OutSetup
End Enum

Public Class InputArray
    Private dic As New Dictionary(Of String, Item)


    Public Sub add(name As String, value As Double, valueUnit As AllUnits, unitType As UnitsTypes, label As String, paramType As ParametersTypes, toolTip As String)
        dic.Add(name, New Item(name, value, valueUnit, unitType, label, paramType, toolTip))
    End Sub

    Public Function getBasicVal(name As String) As Double
        Return Units.convertToBasic(dic(name)._value, dic(name)._unit)
    End Function

    Public Function getAll() As List(Of Item)
        Dim list As New List(Of Item)
        For Each v In dic.Values
            list.Add(v)
        Next
        Return list
    End Function

    Public Property Dict As Dictionary(Of String, Item)
        Get
            Return dic
        End Get
        Set(value As Dictionary(Of String, Item))
            dic = value
        End Set
    End Property

    Public Function getAllNames() As List(Of String)
        Dim list As New List(Of String)
        For Each v In dic.Values
            list.Add(v._name)
        Next
        Return list
    End Function

    Public Function paramUnit(paramName As String) As String
        Return dic(paramName)._unit.ToString
    End Function



End Class

Public Class Item
        Public Property _name As String
        Public Property _value As Double
        Public Property _unit As AllUnits
        Public Property _label As String
        Public Property _unitType As UnitsTypes
    Public Property _paramType As ParametersTypes
    Public Property _toolTip As String


    Public Sub New(name As String, value As Double, unit As AllUnits, unitType As UnitsTypes, label As String, paramType As ParametersTypes, toolTip As String)
        Me._name = name

        'value stored in basic units
        Me._value = value
        Me._unit = unit
        Me._label = label
        Me._unitType = unitType
        Me._paramType = paramType
        Me._toolTip = toolTip
    End Sub
End Class

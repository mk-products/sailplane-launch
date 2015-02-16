Module Weather
    Function horisontalSpeed(ByVal _windspeed As Double, ByVal _y As Double) As Double
        Return _windspeed * (_y / 2) ^ (1 / 7)
    End Function

    Function verticalSpeed(ByVal _thermicSpeed As Double, ByVal _thermicCeil As Double, ByVal _y As Double) As Double
        If _y > _thermicCeil Then
            Return _thermicSpeed
        Else
            Return _y / _thermicCeil * _thermicSpeed
        End If

    End Function
End Module

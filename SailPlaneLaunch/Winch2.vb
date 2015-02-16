Module Winch
    Dim layersOnDrum As Double
    Dim momentOnDrum As Double
    Dim _dt As Double
    Dim omega As Double
    Dim drumDiameter As Double


    Sub init()
        layersOnDrum = 1
    End Sub

    'Returns the length of wire which the winch collects during 1 dt
    'If the torque is bigger than the stall torque, It is assumed that
    'the winch stops and does not reverse
    Function Swinch(_lineForce as Double , _drumDiameter as Double , _winchStallTorque as Double , _winchZeroSpeed,  _momentOnWinchDrum as Double ...
                    ,  _dt as Double ) as double 

        momentOnDrum = momentOnWinchDrum(_lineForce, _drumDiameter)  ' Torque acting on the cylinder [Nm]

        omega = radPerS(speedOfWinchDrum(_winchStallTorque, _winchZeroSpeed), momentOnDrum) ' Rotational speed of the winch [rad/s]

        Swinch = omega * (_drumDiameter / 2) * _dt ' The amount of line the winch collects [m]

        'lw.append(lw[-1]+S as Double ) as double

    End Function

    Function momentOnWinchDrum(ByVal _lineForce As Double, ByVal _drumDiameter As Double) As Double
        momentOnWinchDrum = _lineForce * _drumDiameter / 2  ' Torque acting on the cylinder [Nm]
    End Function


    Function speedOfWinchDrum(ByVal _winchStallTorque As Double, ByVal _winchZeroSpeed As Double, ByVal _momentOnWinchDrum As Double) As Double
        speedOfWinchDrum =  rpm(Math.min(Math.max(0,(1- _momentOnWinchDrum/_winchStallTorque )),1 )  *Dim _winchZeroSpeed as Double ) as double ' Rotational speed of the winch [rpm]
    End Function

    'Returns the spring constant of the line
    'As the line is shortened will the springconstant increase
    'Assumes the constant is reduced inverse to the relative length
    ' Springcoefficient of the line [N] E*pi*d^2/4
    Function kLine(ByVal E, ByVal lineDiameter As Double) As Double
        kLine = E * Math.PI * lineDiameter ^ 2 / 4
    End Function

    'Returns the actual length of the line
    Function lineLength(ByVal x As Double, ByVal y As Double, ByVal L0 As Double) As Double

        lineLength = Math.Sqrt(x ^ 2 + y ^ 2) + L0
    End Function

    Function deltaLineForce(ByVal _lineLength As Double, ByVal _deltaLineLength As Double, ByVal _kLine As Double) As Double
        deltaLineForce = _deltaLineLength / _lineLength * _kLine
    End Function

    'Returns the force in the line
    '    dF = (dL + winchspeed ) / k
    Function lineForce(ByVal _phase As Double, ByVal _lineForceOld As Double, ByVal _deltaLineForce As Double) As Double

        If _phase >= 4 Then
            lineForce = 0
        Else
            lineForce = Math.Max(0, (_lineForceOld + _deltaLineForce))
        End If
    End Function

    Function deltaLineLength(ByVal lineLengthOld As Double, ByVal x As Double, ByVal y As Double, ByVal L0) As Double
        deltaLineLength = lineLength(x, y, L0) - lineLengthOld
    End Function

    Function lineDiameter(ByVal phase, ByVal D0, ByVal l0, ByVal deltaL As Double) As Double
        If phase >= 4 Then
            lineDiameter = D0
        Else
            lineDiameter = D0 'np.sqrt(l0/(l0+deltaL as Double ) as double as Double ) as double*D0
        End If
    End Function


    Function drumDiameter2(ByVal lineOnDrum As Double, ByVal _drumDiameter As Double, ByVal _drumWidth As Double) As Double
        'global drumDiameter,layersOnDrum

        If lineOnDrum > 5000 * layersOnDrum Then
            layersOnDrum = layersOnDrum + 1
            drumDiameter = _drumDiameter + lineDiameter

            drumDiameter2 = _drumDiameter
        End If
    End Function
End Module

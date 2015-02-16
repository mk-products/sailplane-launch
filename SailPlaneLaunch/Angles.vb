
Module Angles

    Public integral As Double
    Dim tempKim As Object

    Public Function calcVelAng()
        '"""
        'Returns the angle of the velocity vector of the plane
        '"""
        If last("phase") = 2 Then
            calcVelAng = Math.Atan2(last("v"), last("groundSpeedX"))
        ElseIf last("phase") = 3 Then
            calcVelAng = diveAngle
        ElseIf last("phase") = 4 Then
            calcVelAng = val("climbAngle")
        Else
            calcVelAng = 0
        End If

    End Function

    Public Function calcLoadFactor()
        Dim r, zentAcc, loadVector As Double
        loadVector = 50
        r = Math.Sqrt(last("x") ^ 2 + last("y") ^ 2)
        zentAcc = last("velocity") ^ 2 / r ' Should this be ground velocity?
        calcLoadFactor = (last("Flift") + loadVector * zentAcc) / g() * planeMass

    End Function

    Public Function calcAttAng()
        '"""
        'Returns the angle of attack for the plane
        '"""

        If last("phase") = 2 Then
            calcAttAng = rad(8)
        Else
            calcAttAng = 0
        End If
        'If last("u") = 0 And last("v") = 0 Then ' If the plane is stationary the attack angle should be zero
        '    calcAttAng = 0
        'Else
        '    calcAttAng = last("gamma") - last("velAng")
        'End If
    End Function

    Public Function calcGamma()
        '"""
        'Returns the plane angle.
        'Assumes the plane flies with gamma0 degrees towards the line all the time
        '"""

        calcGamma = last("psi") +last("velAng")+last("attAng")
        'Dim gammaMyR, goal As Double

        'tempKim = deg(last("gamma"))


        'If last("phase") = 2 Then
        '    gammaMyR = val("gammaR0") ' radius of bottom of launch
        'ElseIf last("phase") = 3 Then
        '    gammaMyR = val("gammaR1") ' radius of top of zoom
        'ElseIf (last("phase") = 4) Then
        '    gammaMyR = val("gammaR2") ' radius of bottom of zoom
        'Else
        '    gammaMyR = val("gammaR3") ' radius of flatten
        'End If


        'goal = 0

        'If last("phase") = 0 Then
        '    If alt >= 2 Then
        '        goal = val("gamma0") + val("setpointAOA") ' Included to simplify things for the governor
        '    Else
        '        goal = 0 'gamma0
        '    End If
        'End If

        '' rolling on ground
        'If last("phase") = 1 Then
        '    goal = 0 'gamma0
        'End If

        ''
        'If last("phase") = 2 Then
      
        '    goal = gammaDesired() - last("psi")
       

        'End If

        'If last("phase") = 3 Then
        '    'If alt = 3 Then
        '    'goal = val("climbAngle")
        '    'Else
        '    goal = -last("psi")
        '    'End If
        'End If

        'If last("phase") = 4 Then
        '    goal = val("climbAngle")
        'End If

        'If last("phase") = 5 Then
        '    goal = 0
        'End If

        'If goal < last("gamma") Then

        '    calcGamma = Math.Max(goal, last("gamma") - gammaMyR * val("dt"))
        'ElseIf (goal > last("gamma")) Then

        '    calcGamma = Math.Min(goal, last("gamma") + gammaMyR * val("dt"))

        'Else
        '    calcGamma = last("gamma")
        'End If

    End Function

    Public Function calcPsi()
        '"""
        'Returns the line angle
        '"""
        calcPsi = Math.Atan2(last("y"), (-last("x")))
    End Function

    Public Function gammaDesired()
        Dim errorAng, derivative, gammaDesiredAngle, previousErrorAng As Double
        Dim Kp, Ki, Kd As Double

        Kp = 1.1
        Ki = 0
        Kd = 0

        tempKim = last("gamma")
        errorAng = val("setpointAOA") - calcAttAng()

        tempKim = deg(errorAng)
        integral = integral + (deg(errorAng) * val("dt"))
        derivative = deg(errorAng - previousErrorAng) / val("dt")

        gammaDesiredAngle = gammaDesiredAngle + rad(Kp * deg(errorAng) + Ki * integral + Kd * derivative)

        previousErrorAng = errorAng
        If gammaDesiredAngle > rad(95) Then
            gammaDesiredAngle = rad(95)
        End If
        If gammaDesiredAngle < rad(50) Then
            gammaDesiredAngle = rad(50)
        End If


        gammaDesired = gammaDesiredAngle


    End Function

End Module

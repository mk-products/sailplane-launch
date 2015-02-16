Module LnD


    Public Function Flift(ByVal cl As Double, ByVal velocity As Double, ByVal rho As Double, ByVal wingArea As Double)
        '"""
        'Returns the lift force of the plane based on the input velocity
        '    Flift = cl * v ^ 2 * rho * wingArea / 2
        '"""
        If last("phase") <= 2 Then
            Flift = cl * velocity * Math.Abs(velocity) * rho * wingArea / 2
        Else
            Flift = 0
        End If
    End Function


    Public Function Fdrag(ByVal cd As Double, ByVal velocity As Double, ByVal rho As Double, ByVal wingArea As Double)
        '"""
        'Returns the grad force of the plane based on the input velocity
        '    Flift = cd * v ^ 2 * rho * wingArea / 2
        '"""

        Fdrag = cd * velocity * Math.Abs(velocity) * rho * wingArea / 2

    End Function
    Public Function lineArea(ByVal diameter As Double, ByVal length As Double, ByVal beta As Double)
        lineArea = diameter * length / 3 '*np.sin(rad(_beta))/3

    End Function
    Public Function FlineDrag(ByVal cd As Double, ByVal velocity As Double, ByVal rho As Double, ByVal lineArea As Double, ByVal phase As Double)
        '"""
        'Returns the drag force of the line based on the input velocity
        '    Flift = cd * v ^ 2 * rho * lineArea / 2
        '"""
        'No drag when flying towards pulley
        If phase >= 3 Then
            FlineDrag = 0
        Else
            FlineDrag = cd * velocity * Math.Abs(velocity) * rho * lineArea / 2
        End If

    End Function
    Public Function velocityMin(ByVal flapPos)
        velocityMin = 9

        ' Drag formulas
    End Function
    Public Function calcCd(ByVal AR As Double, ByVal cdInducedFactor As Double, ByVal cl As Double, ByVal cdParasiticSpeedFlap As Double, ByVal cdParasiticStartFlap As Double, ByVal speedFlapPos As Double, ByVal startFlapPos As Double, ByVal flapPos As Double, ByVal Re As Double, ByVal refRe As Double, ByVal ReCoeff As Double, ByVal cdInference As Double)
        '"""
        'Returns the total drag coefficient
        '"""
        Dim cli, cdp, cdf As Double
        cli = cdInduced(AR, cdInducedFactor, cl)
        cdp = cdParasitic(cdParasiticSpeedFlap, cdParasiticStartFlap, speedFlapPos, startFlapPos, flapPos, Re, refRe, ReCoeff)
        cdf = cdInterference(cdInference, Re, refRe, ReCoeff)

        calcCd = cli + cdp + cdf

    End Function
    Public Function cdParasitic(ByVal cdParasiticSpeedFlap As Double, ByVal cdParasiticStartFlap As Double, ByVal speedFlapPos As Double, ByVal startFlapPos As Double, ByVal flapPos As Double, ByVal Re As Double, ByVal refRe As Double, ByVal ReCoeff As Double)
        '"""
        'Returns the parasitic drag coefficient
        '"""
        '-2.5 0.025 drag coeff speed flap
        '  10 0.04  drag coeff start flap
        Dim x1, x2, y1, y2 As Double
        y1 = cdParasiticSpeedFlap
        x1 = speedFlapPos
        y2 = cdParasiticStartFlap
        x2 = startFlapPos
        cdParasitic = (y2 - y1) / (x2 - x1) * (flapPos - x1) + y1

    End Function
    Public Function cdInterference(ByVal cdInference As Double, ByVal Re As Double, ByVal refRe As Double, ByVal ReCoeff As Double)
        '"""
        'Returns the interference drag coefficient
        '"""
        cdInterference = cdInference * (refRe / Re) ^ ReCoeff

    End Function
    Public Function cdInduced(ByVal AR As Double, ByVal cdInducedFactor As Double, ByVal cl As Double)
        '"""
        'Returns the induced drag coefficient
        '"""
        ' 0.95 < cdInducedFactor < 1
        cdInduced = cl ^ 2 / (Math.PI * AR * cdInducedFactor)

    End Function
    Public Function cdLine()
        cdLine = 0.69

        ' Lift formulas
    End Function
    Public Function calcCl(ByVal attAng As Double, ByVal clAlphaCoeff As Double, ByVal speedFlapPos As Double, ByVal startFlapPos As Double, ByVal speedFlapCl0 As Double, ByVal startFlapCl0 As Double, ByVal flapPos As Double)
        '"""
        'Returns the lift coefficient
        '"""
        calcCl = clAlpha(clAlphaCoeff) * attAng + calcClO(speedFlapPos, startFlapPos, speedFlapCl0, startFlapCl0, flapPos)

    End Function
    Public Function clAlpha(ByVal clAlphaCoeff As Double)
        Return 2 * Math.PI * clAlphaCoeff

    End Function
    Public Function calcClO(ByVal speedFlapPos As Double, ByVal startFlapPos As Double, ByVal speedFlapCl0 As Double, ByVal startFlapCl0 As Double, ByVal flapPos As Double)
        '-2.5 0.111 stall occurs at 10deg
        '10 0.9 stall occurs at 5deg
        Dim x1, x2, y1, y2 As Double
        y1 = speedFlapCl0
        x1 = speedFlapPos
        y2 = startFlapCl0
        x2 = startFlapPos
        calcClO = (y2 - y1) / (x2 - x1) * (flapPos - x1) + y1

        ' These are just for control or future uses
    End Function
    Public Function clAlpha2()
        '0deg 0.278
        '3.5deg 0.615
        Dim x1, x2, y1, y2 As Double
        y1 = 0.278
        x1 = 0
        y2 = 0.615
        x2 = 3.3
        clAlpha2 = (y2 - y1) / (x2 - x1) * 180 / Math.PI
    End Function

    Public Function clCD()
        ''    cl[0 0.1 0.2 0.3 0.4 0.5 0.6 0.7 0.8 0.9 1.0 ]
        ''    cdp_n5_Re150000 = [.0127 .0113 .0108 .0108 .0107 0.0106 .0113 .0123 .0153 .0215 .0320]
        ''    cdp_n0_Re200000 = [.0113 0.0098 .0088 .0085 .0084  .0088 .0098 .0115 .0145  .0185 .00265]
        ''    cdp_n_25_Re300000 = [.0098 0.0078 .0073 .0078 0.0090 .0113 0.0170 0.0220]

        ' at 5deg flap cwTot~0.049 at 0 deg 0.031
        clCD = 3
    End Function




End Module

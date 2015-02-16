Module Forces

    Dim s As Double
    Dim deltaLineForceMy As Double
    Dim gravityForce As Object

    Private Property tempKim As Object

    Sub sumForces()
        '"""
        'Calculates the resulting forces acting on the plane
        '"""
        add("horisontalWindSpeed", horisontalSpeed(val("windSpeed"), last("y")))
        add("verticalWindSpeed", verticalSpeed(val("thermic"), val("thermicCeil"), last("y")))

        add("airSpeedX", last("groundSpeedX") + last("horisontalWindSpeed"))
        add("airSpeedY", last("v") + last("verticalWindSpeed"))

        add("groundSpeed", Math.Sqrt(last("groundSpeedX") ^ 2 + last("v") ^ 2))
        add("airSpeed", Math.Sqrt(last("airSpeedX") ^ 2 + last("airSpeedY") ^ 2))



        If last("phase") > 1 Then
            add("psi", calcPsi())
            add("velAng", calcVelAng())
            add("attAng", calcAttAng())
            add("gamma", calcGamma())

            ' on ground all angles can be set to 0
        Else
            add("psi", 0)
            add("velAng", 0)
            add("attAng", 0)
            add("gamma", 0)

        End If

  
        add("rho", densityWithHumidity(val("humidity"), val("pressureAtGround"), val("tempAtGround"), last("y")))
        add("temperature", temperature(last("y"), val("tempAtGround")))
        add("nu", dynamicViscosity(last("temperature")))
        add("Re", reynoldsNumber(last("nu"), last("airSpeed"), meanChoord))


        add("clTotal", calcCl(last("attAng"), val("clAlphaCoeff"), val("speedFlapPos"), val("startFlapPos"), val("speedFlapCl0"), val("startFlapCl0"), last("flapPos")))
        add("cdTotal", calcCd(val("AR"), val("cdInducedFactor"), last("clTotal"), val("cdParasiticSpeedFlap"), val("cdParasiticStartFlap"), val("speedFlapPos"), val("startFlapPos"), last("flapPos"), last("Re"), val("refRe"), val("reCoeff"), val("cdInference")))
        add("cdLine", cdLine())

        add("lengthToPlaneFromPulley", lengthToPlaneFromPulley(last("x"), last("y")))
        If online Then
            add("totalLineLength", lineLength(last("x"), last("y"), val("distanceToPulley")))
            'add("drumDiameter", drumDiameter(last("drumDiameter")))
            add("drumDiameter", drumDiameter2(last("lineOnWinch"), last("drumDiameter"), val("drumLength"), last("lineDiameter")))
            add("momentOnWinchDrum", momentOnWinchDrum(last("lineForce"), last("drumDiameter")))
            add("s", Swinch(last("lineForce"), last("drumDiameter"), val("wst"), val("wzs"), last("momentOnWinchDrum"), val("dt")))
            add("lineOnWinch", last("lineOnWinch") + last("s"))
            add("deltaLineLength", last("totalLineLength") - last2("totalLineLength") + last("s"))

            'add("lineDiameter", lineDiameter(last("phase"), val("lineDiameter"), last("totalLineLength"), last("deltaLineLength")))
            add("lineDiameter", lineDiameter2(last("phase"), val("lineDiameter"), val("poissonRatio"), val("EModule"), last("lineForce")))

            add("kLine", kLine(val("EModule"), last("lineDiameter")))
            deltaLineForceMy = deltaLineForce(last("totalLineLength"), last("deltaLineLength"), last("kLine"))
            add("lineForce", lineForce(last("phase"), last("lineForce"), deltaLineForceMy))

            add("lineArea", lineArea(last("lineDiameter"), last("lengthToPlaneFromPulley"), last("gamma")))
        Else
            add("totalLineLength", last("totalLineLength"))
            add("momentOnWinchDrum", 0.0)
            add("lineOnWinch", last("lineOnWinch"))
            add("deltaLineLength", 0.0)
            add("lineDiameter", val("lineDiameter"))
            add("kLine", last("kLine"))
            add("lineForce", 0)
            add("drumDiameter", last("drumDiameter"))

            add("lineArea", last("lineArea"))
        End If


        If last("phase") >= 1 Then
            gravityForce = g() * planeMass
            add("fDrag", Fdrag(last("cdTotal"), last("airSpeed"), last("rho"), wingArea))
            add("fLift", Flift(last("clTotal"), last("airSpeed"), last("rho"), wingArea))
            add("lineDrag", FlineDrag(val("lineDragCoefficient"), last("airSpeed"), last("rho"), last("lineArea"), last("phase")))
        

        Else
            add("fDrag", 0)
            add("fLift", 0)
            add("lineDrag", 0)
            gravityForce = 0
        End If

        add("fTotalDrag", last("fDrag") + last("lineDrag"))
        add("fx", -last("fTotalDrag") * Math.Cos(last("velAng")) + last("lineForce") * Math.Cos(last("psi")) - last("fLift") * Math.Sin(last("velAng")))
        add("fy", -last("fTotalDrag") * Math.Sin(last("velAng")) - last("lineForce") * Math.Sin(last("psi")) + last("fLift") * Math.Cos(last("velAng")) - gravityForce)

    End Sub


End Module

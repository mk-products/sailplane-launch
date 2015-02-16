Imports SailPlaneLaunch.InputArray
Imports System.Globalization

Module parametersIn

    Public inputs As New InputArray
    'extra in gui, thermalflap position


    Public wingArea As Double
    Public planeMass As Double

    Public velocityMinimum As Object
    Public flapPosPhase5 As Double
    Public flapPosPhase4 As Double
    Public flapPosPhase3 As Double
    Public flapPosPhase2 As Double
    Public flapPosPhase1 As Double
    Public flapPosPhase0 As Double

    Public setpointAOA As Double

    Public alt As Integer

    Public meanChoord As Double




    'Configure input fields here !
    'Don't forget to add entries to app.config if you add new fields
    Public Sub initInputs()

        Dim currentParamType As ParametersTypes
        'FLIGHT PARAMETERS
        currentParamType = ParametersTypes.FlightParameters
        inputs.add("preTensionOfLine", 1.0, AllUnits.N, UnitsTypes.Force, "Pre tension of line", currentParamType, "Pre tension of line")  'force
        inputs.add("takeOffSpeed", 1.0, AllUnits.ms, UnitsTypes.Speed, "Take off speed", currentParamType, "")  'speed
        inputs.add("launchAngle", 1.0, AllUnits.deg, UnitsTypes.Degree, "Launch Angle", currentParamType, "")  'speed
        inputs.add("setpointAOA", 1.0, AllUnits.deg, UnitsTypes.Degree, "Set desired angle of attack", currentParamType, "")  'speed
        inputs.add("startFlapPos", 1.0, AllUnits.deg, UnitsTypes.Degree, "Start flap position", currentParamType, "")  'distance
        inputs.add("speedFlapPos", 1.0, AllUnits.deg, UnitsTypes.Degree, "Speed flap position", currentParamType, "")  'distance
        inputs.add("diveStartAngle", 1.0, AllUnits.deg, UnitsTypes.Degree, "Dive start angle", currentParamType, "")  'deg
        inputs.add("climbAngle", 1.0, AllUnits.deg, UnitsTypes.Degree, "Climb angle", currentParamType, "")  'distance

        'inputs.add("gammaR0", 1.0, AllUnits.radPers, UnitsTypes.Omega, "Gamma R0", currentParamType)  'distance
        'inputs.add("gammaR1", 1.0, AllUnits.radPers, UnitsTypes.Omega, "Gamma R1", currentParamType)  'distance
        'inputs.add("gammaR2", 1.0, AllUnits.radPers, UnitsTypes.Omega, "Gamma R2", currentParamType)  'distance
        'inputs.add("gammaR3", 1.0, AllUnits.radPers, UnitsTypes.Omega, "Gamma R3", currentParamType)  'distance


        'PLANE PARAMETERS
        currentParamType = ParametersTypes.PlaneParameters
        inputs.add("wingSpan", 1.0, AllUnits.mm, UnitsTypes.Distance, "Wingspan", currentParamType, "")  'distance
        inputs.add("wingLoading", 1.0, AllUnits.gPerdm2, UnitsTypes.WeightPerArea, "Wing loading", currentParamType, "")  'distance
        inputs.add("AR", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Aspect ratio", currentParamType, "")
        inputs.add("refRe", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Reference Re number", currentParamType, "")
        inputs.add("cdInference", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cd for interference drag", currentParamType, "")
        inputs.add("cdInducedFactor", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cd for induced drag", currentParamType, "")
        inputs.add("cdParasiticSpeedFlap", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cd for parasitic drag with speed flap setting", currentParamType, "")
        inputs.add("cdParasiticStartFlap", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cd for parasitic drag with start flap setting", currentParamType, "")
        inputs.add("clAlphaCoeff", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cl alpha coefficient", currentParamType, "")
        inputs.add("maxLoadFactor", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Max load factor", currentParamType, "")
        inputs.add("speedFlapCl0", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cl at speed flap setting", currentParamType, "")
        inputs.add("startFlapCl0", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Cl at start flip", currentParamType, "")
        inputs.add("reCoeff", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Re Number coefficient", currentParamType, "")

        'WINCH PARAMETERS
        currentParamType = ParametersTypes.WinchParameters
        inputs.add("drumDiameter", 1.0, AllUnits.mm, UnitsTypes.Distance, "Drum diameter", currentParamType, "")  'distance
        inputs.add("drumLength", 1.0, AllUnits.mm, UnitsTypes.Distance, "Drum length", currentParamType, "")  'distance
        inputs.add("wst", 1.0, AllUnits.Nm, UnitsTypes.Torque, "Winch stall torque", currentParamType, "")  'torque
        inputs.add("wzs", 1.0, AllUnits.rpm, UnitsTypes.Revolutions, "Winch zero speed", currentParamType, "")  'revolutions
        inputs.add("distanceToPulley", 1.0, AllUnits.mm, UnitsTypes.Distance, "Distancetopulley", currentParamType, "")  'distance

        'FLIGHT CONDITIONS
        currentParamType = ParametersTypes.FlightConditions
        inputs.add("windSpeed", 1.0, AllUnits.ms, UnitsTypes.Speed, "Wind speed", currentParamType, "")  'speed
        inputs.add("thermicCeil", 1.0, AllUnits.mm, UnitsTypes.Distance, "Thermic Ceil height", currentParamType, "")  'distance
        inputs.add("thermic", 1.0, AllUnits.ms, UnitsTypes.Speed, "Thermic velocity", currentParamType, "")  'speed
        inputs.add("tempAtGround", 1.0, AllUnits.C, UnitsTypes.Temperature, "Temperature at ground", currentParamType, "")    'temp
        inputs.add("pressureAtGround", 1.0, AllUnits.Pa, UnitsTypes.Pressure, "Pressure at ground", currentParamType, "")  'pressure
        inputs.add("humidity", 1.0, AllUnits.percent, UnitsTypes.Other, "Humidity", currentParamType, "")  'percent

        'LINE PARAMETERS
        currentParamType = ParametersTypes.LineParameters
        inputs.add("lineDiameter", 1.0, AllUnits.m, UnitsTypes.Distance, "Line diameter", currentParamType, "")  'distance
        inputs.add("totalLineLength", 1.0, AllUnits.m, UnitsTypes.Distance, "Total line length", currentParamType, "")  'distance
        inputs.add("EModule", 1.0, AllUnits.GPa, UnitsTypes.Stress, "Youngs modulus", currentParamType, "")  'pressure
        inputs.add("poissonRatio", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Poisson ratio", currentParamType, "")
        inputs.add("lineDragCoefficient", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Line drag coefficient", currentParamType, "")
        inputs.add("parachuteDragCoeffcient", 1.0, AllUnits.dl, UnitsTypes.Dimensionless, "Parachute drag coefficient", currentParamType, "")  'distance
        inputs.add("parachuteArea", 1.0, AllUnits.mmPow2, UnitsTypes.Area, "Parachute area", currentParamType, "")  'area

        'SETUP PARAMETERS
        currentParamType = ParametersTypes.Setup
        inputs.add("dt", 20, AllUnits.s, UnitsTypes.Time, "Delta time", currentParamType, "")  'distance
        inputs.add("maxT", 10, AllUnits.s, UnitsTypes.Time, "Max simulation time", currentParamType, "")  'distance

        'For Each ii As Item In inputs.getAll
        '    Console.WriteLine("<setting name=""" + ii._name + "Value"" serializeAs=""String"">")
        '    Console.WriteLine("<value/>")
        '    Console.WriteLine("</setting>")

        '    Console.WriteLine("<setting name=""" + ii._name + "Unit"" serializeAs=""Integer"">")
        '    Console.WriteLine("<value/>")
        '    Console.WriteLine("</setting>")

        'Next

    End Sub

    Public Sub initAllValues(Optional modifier As Double = 1, Optional modifyItemName As String = "", Optional explicitValue As Boolean = False)
        For Each c As Control In Tools.FindAllChildren(GUI.Tabs)
            If c.GetType() Is GetType(InputRow) Then
                Dim ir As InputRow = CType(c, InputRow)
                If ir.Parent.Name <> "FlowLayoutPanelOutSetup" Then
                    For Each ii As Item In inputs.getAll
                        If ii._name = ir.inputName Then
                            Dim dbl As Double
                            Dim success As Boolean = Double.TryParse(ir.value.Text, NumberStyles.Any, Globalization.CultureInfo.InvariantCulture, dbl)
                            If success Then
                                ii._value = dbl
                                ii._unit = DirectCast([Enum].Parse(GetType(AllUnits), parseNiceUnit(ir.unit.SelectedItem)), AllUnits)
                            Else
                                MessageBox.Show("Wrong value for field: " + ir.label.Text, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            End If

                        End If
                    Next
                End If
            End If
        Next

        'set constant variables
        For Each ii As Item In inputs.getAll
            If outputs.constains(ii._name) Then
                outputs.setZeroVal(ii._name, val(ii._name))
            End If
        Next


        initPlaneParameters()
        initFlightParameters()
        initWinchParameters()
        initLineParameters()
        initFlightConditionsParameters()
        initSetupParameters()
        modifyParameter(modifier, modifyItemName, explicitValue)
    End Sub

    Public Sub modifyParameter(modifier As Double, modifyItemName As String, Optional explicitValue As Boolean = False)
        
        If modifyItemName <> "" Then
            If explicitValue Then
                inputs.Dict(modifyItemName)._value = modifier
            Else
                inputs.Dict(modifyItemName)._value *= modifier
            End If
        End If
            'For Each pair As KeyValuePair(Of String, Item) In inputs.Dict
            'Dim item As Item = pair.Value
            'Dim name As String = pair.Key

            'item._value *= 1.3 'if this doesnt work, try pair.Value._value *= 1.3
            'Next

    End Sub

    Public Sub initPlaneParameters()

        '********* PLANE PARAMETERS *******************************




        'Derived parameters.....
        wingArea = val("wingSpan") ^ 2 / val("AR")                                            ' Planform area of the plane [m^2]
        planeMass = val("wingLoading") * wingArea                                      ' Mass of plane [kg]
        meanChoord = wingArea / val("wingSpan")                                        ' Mean choord


        '    ' Not implemented...
        'ReCoeff = float(paraMeterArray['ReCoeff'])
        '    Re = float(150000)
    End Sub

    Public Sub initFlightParameters()





        '"""
        '******** LAUNCHCONFIGURATION IN PHASE 0*****************************
        '"""

        flapPosPhase0 = val("speedFlapPos")

        '"""
        '******** LAUNCHCONFIGURATION IN PHASE 1, in alt2 mode used as init...
        '"""

        flapPosPhase1 = val("startFlapPos")

        '"""
        '******** LAUNCHCONFIGURATION IN PHASE 2*****************************
        '"""

        flapPosPhase2 = val("startFlapPos")

        '"""
        '******** LAUNCHCONFIGURATION IN PHASE 3*****************************
        '"""
        flapPosPhase3 = val("speedFlapPos")

        '"""
        '******** LAUNCHCONFIGURATION IN PHASE 4*****************************
        '"""

        flapPosPhase4 = val("speedFlapPos") ' CHECK ME

        '"""
        '******** LAUNCHCONFIGURATION IN PHASE 5 *****************************
        '"""
        flapPosPhase5 = val("speedFlapPos")

        'velocityMinimum = velocityMin(flapPosPhase5)

    End Sub

    Public Sub initWinchParameters()
        outputs.setZeroVal("x", -val("distanceToPulley"))

    End Sub


    Public Sub initLineParameters()



    End Sub

    Public Sub initFlightConditionsParameters()


    End Sub

    Public Sub initSetupParameters()

        If GUI.ComboBoxLaunchMethod.SelectedItem.ToString = "Rolling on ground" Then
            alt = 1
            'outputs.setZeroVal("u", 0)
            'outputs.setZeroVal("v", 0)
            'outputs.setZeroVal("phase", 0)
        Else
            alt = 2
            'outputs.setZeroVal("phase", 0)
            'outputs.setZeroVal("u", Math.Cos(rad(val("gamma0"))) * val("takeOffSpeed"))
            'outputs.setZeroVal("v", Math.Sin(rad(val("gamma0"))) * val("takeOffSpeed"))
            'outputs.setZeroVal("gamma", val("gamma0"))
        End If



    End Sub

    Function parseParameter(ByVal tb As TextBox) As Double
        Return convertToBasic(CDbl(Val(tb.Text)), findUnit(tb))
    End Function

    Function findUnit(ByVal tb As TextBox) As String
        Dim unitComboName = tb.Name.Substring(7)
        unitComboName = "ComboBox" + unitComboName
        For Each c As Control In GUI.FindAllChildren()
            If c.Name = unitComboName Then
                Return c.Text
            End If
        Next
    End Function

    Public Function val(s As String)
        Return inputs.getBasicVal(s)
    End Function


End Module

Module ParametersOut

    Public outputs As New OutputArray
    
    'Public _windSpeed As List(Of Double)

    'Important are:
    ' UnitsTypes because they determine combo boxes in Out Setup;
    ' Units - default value for combo box (first time only, as settings are saved)

    'while adding a new output, add to Settings 2 entries:outNAMEValue and outNAMEUnit, e.g. outtimeUnit, outtimeUnit
    Public Sub initOutputs()
        outputs.add("time", 0, AllUnits.s, UnitsTypes.Time, "time", ParametersTypes.OutSetup, "")
        outputs.add("groundSpeedX", 0, AllUnits.ms, UnitsTypes.Speed, "groundSpeedX", ParametersTypes.OutSetup, "")
        outputs.add("v", 0, AllUnits.ms, UnitsTypes.Speed, "v", ParametersTypes.OutSetup, "")
        outputs.add("ax", 0, AllUnits.mPers2, UnitsTypes.Acceleration, "ax", ParametersTypes.OutSetup, "")
        outputs.add("ay", 0, AllUnits.mPers2, UnitsTypes.Acceleration, "ay", ParametersTypes.OutSetup, "")
        outputs.add("x", 0, AllUnits.m, UnitsTypes.Distance, "x", ParametersTypes.OutSetup, "")
        outputs.add("y", 0, AllUnits.m, UnitsTypes.Distance, "y", ParametersTypes.OutSetup, "")
        outputs.add("fx", 0, AllUnits.N, UnitsTypes.Force, "fx", ParametersTypes.OutSetup, "")
        outputs.add("fy", 0, AllUnits.N, UnitsTypes.Force, "fy", ParametersTypes.OutSetup, "")
        outputs.add("totalLineLength", 0, AllUnits.m, UnitsTypes.Distance, "totalLineLength", ParametersTypes.OutSetup, "")
        outputs.add("airSpeed", 0, AllUnits.ms, UnitsTypes.Speed, "airSpeed", ParametersTypes.OutSetup, "")
        outputs.add("clTotal", 0, AllUnits.dl, UnitsTypes.Dimensionless, "clTotal", ParametersTypes.OutSetup, "")
        outputs.add("cdTotal", 0, AllUnits.dl, UnitsTypes.Dimensionless, "cdTotal", ParametersTypes.OutSetup, "")
        outputs.add("fDrag", 0, AllUnits.N, UnitsTypes.Force, "fDrag", ParametersTypes.OutSetup, "")
        outputs.add("fLift", 0, AllUnits.N, UnitsTypes.Force, "fLift", ParametersTypes.OutSetup, "")
        outputs.add("lineForce", 0, AllUnits.N, UnitsTypes.Force, "lineForce", ParametersTypes.OutSetup, "")
        outputs.add("kLine", 0, AllUnits.dl, UnitsTypes.Dimensionless, "kLine", ParametersTypes.OutSetup, "")
        outputs.add("lineDiameter", 0, AllUnits.m, UnitsTypes.Distance, "lineDiameter", ParametersTypes.OutSetup, "")
        outputs.add("lineOnWinch", 0, AllUnits.m, UnitsTypes.Distance, "lineOnWinch", ParametersTypes.OutSetup, "")
        outputs.add("lengthToPlaneFromPulley", 0, AllUnits.m, UnitsTypes.Distance, "lengthToPlaneFromPulley", ParametersTypes.OutSetup, "")
        outputs.add("lineArea", 0, AllUnits.mPow2, UnitsTypes.Area, "lineArea", ParametersTypes.OutSetup, "")
        outputs.add("lineDrag", 0, AllUnits.kg, UnitsTypes.Force, "lineDrag", ParametersTypes.OutSetup, "")
        outputs.add("fTotalDrag", 0, AllUnits.kg, UnitsTypes.Force, "fTotalDrag", ParametersTypes.OutSetup, "")
        outputs.add("deltaLineLength", 0, AllUnits.m, UnitsTypes.Distance, "deltaLineLength", ParametersTypes.OutSetup, "")
        outputs.add("windSpeed", 0, AllUnits.ms, UnitsTypes.Speed, "windSpeed", ParametersTypes.OutSetup, "")
        outputs.add("airSpeedX", 0, AllUnits.ms, UnitsTypes.Speed, "airSpeedX", ParametersTypes.OutSetup, "")
        outputs.add("airSpeedY", 0, AllUnits.ms, UnitsTypes.Speed, "airSpeedY", ParametersTypes.OutSetup, "")
        outputs.add("groundSpeed", 0, AllUnits.ms, UnitsTypes.Speed, "groundSpeed", ParametersTypes.OutSetup, "")
        outputs.add("phase", 0, AllUnits.dl, UnitsTypes.Dimensionless, "phase", ParametersTypes.OutSetup, "")
        outputs.add("gamma", 0, AllUnits.deg, UnitsTypes.Degree, "gamma", ParametersTypes.OutSetup, "")
        outputs.add("rho", 0, AllUnits.kgPerm3, UnitsTypes.WeightPerVolume, "rho", ParametersTypes.OutSetup, "")
        outputs.add("psi", 0, AllUnits.deg, UnitsTypes.Degree, "psi", ParametersTypes.OutSetup, "")
        outputs.add("velAng", 0, AllUnits.deg, UnitsTypes.Degree, "velAng", ParametersTypes.OutSetup, "")
        outputs.add("attAng", 0, AllUnits.deg, UnitsTypes.Degree, "attAng", ParametersTypes.OutSetup, "")
        outputs.add("temperature", 0, AllUnits.C, UnitsTypes.Temperature, "temperature", ParametersTypes.OutSetup, "")
        outputs.add("nu", 0, AllUnits.dl, UnitsTypes.Dimensionless, "nu", ParametersTypes.OutSetup, "")
        outputs.add("Re", 0, AllUnits.dl, UnitsTypes.Dimensionless, "Re", ParametersTypes.OutSetup, "")
        outputs.add("flapPos", 0, AllUnits.dl, UnitsTypes.Dimensionless, "flapPos", ParametersTypes.OutSetup, "")
        outputs.add("cdLine", 0, AllUnits.dl, UnitsTypes.Dimensionless, "cdLine", ParametersTypes.OutSetup, "")
        outputs.add("momentOnWinchDrum", 0, AllUnits.Nm, UnitsTypes.Torque, "momentOnWinchDrum", ParametersTypes.OutSetup, "")
        outputs.add("drumDiameter", 0, AllUnits.m, UnitsTypes.Distance, "drumDiameter", ParametersTypes.OutSetup, "")
        outputs.add("s", 0, AllUnits.m, UnitsTypes.Distance, "s", ParametersTypes.OutSetup, "")
        outputs.add("horisontalWindSpeed", 0, AllUnits.ms, UnitsTypes.Speed, "horisontalWindSpeed", ParametersTypes.OutSetup, "")
        outputs.add("verticalWindSpeed", 0, AllUnits.ms, UnitsTypes.Speed, "verticalWindSpeed", ParametersTypes.OutSetup, "")

    End Sub

    Public Sub initAllValues()

    End Sub


    Public Sub initOutLists()
        outputs.resetAll()

        For Each c As Control In Tools.FindAllChildren(GUI.Tabs)
            If c.GetType() Is GetType(InputRow) Then
                Dim ir As InputRow = CType(c, InputRow)
                For Each ii As Item In outputs.getAllItems
                    If ii._name = ir.inputName And ii._paramType = ParametersTypes.OutSetup Then
                            ii._unit = DirectCast([Enum].Parse(GetType(AllUnits), parseNiceUnit(ir.unit.SelectedItem)), AllUnits)
                    End If
                Next
            End If
        Next
    End Sub

End Module

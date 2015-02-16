'Adding Unit:
'If unit is of new type, add this type to UnitsTypes, e.g. Time
'Then add unit to AllUnits, e.g. min, and add entry to UnitsCategories
' Next edit convertToBasic and convertToBasicUnit functions by adding proper mappings

Public Enum UnitsTypes
    Speed
    Acceleration
    Distance
    Pressure
    Torque
    Revolutions
    Area
    Other
    Degree
    Force
    Temperature
    Time
    Dimensionless
    Omega
    WeightPerArea
    WeightPerVolume
    Stress
End Enum


Public Enum AllUnits
    'distance
    m
    mm
    inch
    'speed
    kph
    mph
    ms 'meters/s

    mPers2
    'pressure
    hPa
    Pa
    psi
    atm
    bar
    GPa
    MPa
    'degree
    deg
    rad
    'torque
    Nm
    Nmm
    kgcm
    'area
    mPow2
    mmPow2
    m2
    inchPow2
    'revolutions
    rpm
    'force
    kg
    N
    lb
    'temperature
    C
    K
    'time
    s
    min
    hour
    'other
    percent
    none
    ' Dimensionless
    dl
    'Omega
    radPers
    degPers
    'WeightPerArea
    gPerdm2
    kgPerdm2
    kgPerm2

    'WeightPerVolume
    gPerdm3
    kgPerdm3
    kgPerm3
End Enum

Public Module Units
    'Here u can use ^, / etc.
    Public UnitsCategories As New Dictionary(Of String, List(Of String)) _
   From { _
      {"Speed", New List(Of String) From {"kph", "mph", "ms"}}, _
    {"Acceleration", New List(Of String) From {"m/s2"}}, _
    {"Distance", New List(Of String) From {"m", "mm", "inch"}}, _
    {"Pressure", New List(Of String) From {"hPa", "Pa", "psi", "atm", "bar", "GPa", "MPa"}}, _
    {"Torque", New List(Of String) From {"Nm", "Nmm", "kgcm"}}, _
    {"Revolutions", New List(Of String) From {"rpm", "radPers"}}, _
    {"Area", New List(Of String) From {"mm^2", "m^2", "inch^2"}}, _
    {"Other", New List(Of String) From {"percent", "none"}}, _
    {"Degree", New List(Of String) From {"deg", "rad"}}, _
    {"Force", New List(Of String) From {"kg", "N", "lb"}}, _
    {"Temperature", New List(Of String) From {"C", "K"}}, _
    {"Dimensionless", New List(Of String) From {"-"}}, _
    {"Omega", New List(Of String) From {"radPers", "degPers"}}, _
    {"WeightPerArea", New List(Of String) From {"g/dm2", "kg/dm2", "kg/m2"}}, _
    {"WeightPerVolume", New List(Of String) From {"g/dm3", "kg/dm3", "kg/m3"}}, _
    {"Stress", New List(Of String) From {"MPa", "GPa", "N/m2", "N/mmPow2"}},
    {"Time", New List(Of String) From {"s", "min", {"hour"}}} _
}

    'basic unit is m; m/s; Pa; rad; Nm; m^2;rpm; C;N;radPers

    Function convertToBasic(value As Double, unit As AllUnits) As Double
        Dim result As Double = value
        Select Case unit
            'length
            Case AllUnits.m 'basic
            Case AllUnits.mm
                result = mmToM(value)
            Case AllUnits.inch
                result = inchToM(value)

                'speed
            Case AllUnits.kph
                result = kphToMs(value)
            Case AllUnits.mph
                result = mphToMs(value)
            Case AllUnits.ms 'basic

                'pressure
            Case AllUnits.hPa
                result = hPaToPa(value)
            Case AllUnits.Pa 'basic
            Case AllUnits.psi
                result = psiToPa(value)
            Case AllUnits.atm
                result = atmToPa(value)
            Case AllUnits.bar
                result = barToPa(value)
            Case AllUnits.GPa
                result = gpaToPa(value)
            Case AllUnits.MPa
                result = mpaToPa(value)

                'degree
            Case AllUnits.deg
                result = rad(value)
            Case AllUnits.rad 'basic

                'omega
            Case AllUnits.degPers
                result = rad2PerS(value)
            Case AllUnits.radPers 'basic

                'torque
            Case AllUnits.Nm 'basic

            Case AllUnits.Nmm
                result = Nmm2Nm(value)
            Case AllUnits.kgcm
                result = kgcm2Nm(value)

                'area
            Case AllUnits.mmPow2
                result = mmPow2TomPow2(value)
            Case AllUnits.mPow2 'basic
            Case AllUnits.inchPow2
                result = inchPow2TomPow2(value)

                'revolutions
            Case AllUnits.rpm
                result = radPerS(value)
                'force
            Case AllUnits.kg
                result = kg2N(value)
            Case AllUnits.N
            Case AllUnits.lb
                result = lb2N(value)


                'temperature
            Case AllUnits.C
                result = CToK(value)
            Case AllUnits.K 'basic
                'other
            Case AllUnits.percent
                result = result * 0.01
                'time
            Case AllUnits.s
            Case AllUnits.min
                result = MinToS(value)
            Case AllUnits.hour
                result = HourToS(value)
            Case AllUnits.mPers2

            Case AllUnits.gPerdm2
                result = gPerdm2TokgPerm2(value)

            Case AllUnits.none

            Case Else

        End Select

        Return result

    End Function

    Function convertToBasicUnit(unit As AllUnits)
        Dim basicUnit As AllUnits
        Select Case unit
            Case AllUnits.rpm, AllUnits.radPers, AllUnits.degPers
                basicUnit = AllUnits.radPers

            Case AllUnits.inch, AllUnits.mm
                basicUnit = AllUnits.m

            Case AllUnits.kph, AllUnits.mph
                basicUnit = AllUnits.ms

            Case AllUnits.hPa, AllUnits.psi, AllUnits.atm, AllUnits.bar, AllUnits.GPa
                basicUnit = AllUnits.Pa


            Case AllUnits.percent
                basicUnit = AllUnits.none

            Case AllUnits.C
                basicUnit = AllUnits.K

            Case AllUnits.mmPow2, AllUnits.inchPow2
                basicUnit = AllUnits.mPow2

            Case AllUnits.Nmm, AllUnits.kgcm
                basicUnit = AllUnits.Nm

            Case AllUnits.kg, AllUnits.N, AllUnits.lb
                basicUnit = AllUnits.N

            Case AllUnits.deg
                basicUnit = AllUnits.rad

            Case AllUnits.min, AllUnits.hour
                basicUnit = AllUnits.s

            Case AllUnits.none
                basicUnit = AllUnits.none

            Case AllUnits.dl
                basicUnit = AllUnits.dl

            Case AllUnits.gPerdm2, AllUnits.kgPerdm2, AllUnits.kgPerm2
                basicUnit = AllUnits.kgPerm2

            Case AllUnits.gPerdm2, AllUnits.kgPerdm2
                basicUnit = AllUnits.kgPerm3

            Case AllUnits.radPers
                basicUnit = AllUnits.radPers

            Case AllUnits.mPers2
                basicUnit = AllUnits.radPers

            Case Else

        End Select

        Return basicUnit
    End Function

    Function convertToDesired(value As Double, unit As AllUnits) As Double
        Select Case unit
            Case AllUnits.C
                Return KToC(value)
            Case Else
                Return (1 / convertToBasic(1, unit)) * value
        End Select


    End Function
    'Returns the argument in degrees
    Function deg(ByVal a As Double)
        deg = a * 180 / Math.PI
    End Function

    'Returns the argument in degrees
    Function degPers(ByVal a As Double)
        degPers = a * 180 / Math.PI
    End Function

    'Returns the argument in radians
    Function rad(ByVal a As Double) As Double
        rad = a / 180 * Math.PI
    End Function

    'Returns the argument in rpm
    Function rpm(ByVal a As Double) As Double
        rpm = a * 30 / Math.PI
    End Function
    'Returns the argument in rad/s, rpm as input
    Function radPerS(ByVal a) As Double
        radPerS = a * Math.PI / 30
    End Function

    'Returns the argument in rad/s, degPers as input
    Function rad2PerS(ByVal a) As Double
        rad2PerS = a / 180 * Math.PI
    End Function

    Function mmToM(v As Double) As Double
        Return v * 0.001
    End Function

    Function inchToM(v As Double) As Double
        Return v * 0.0254
    End Function

    Function kphToMs(v As Double) As Double
        Return v * 0.277778
    End Function

    Function mphToMs(v As Double) As Double
        Return v * 0.44704
    End Function

    Function hPaToPa(v As Double) As Double
        Return v * 100
    End Function

    Function gpaToPa(v As Double) As Double
        Return v * 1000000000.0
    End Function

    Function mpaToPa(v As Double) As Double
        Return v * 1000000.0
    End Function

    Function psiToPa(v As Double) As Double
        Return v * 6894.75728
    End Function

    Function atmToPa(v As Double) As Double
        Return v * 101325.01
    End Function

    Function barToPa(v As Double) As Double
        Return v * 100000
    End Function

    Function MinToS(v As Double) As Double
        Return v * 60
    End Function

    Function HourToS(v As Double) As Double
        Return v * 60 * 60
    End Function

    Function CToK(v As Double) As Double
        Return v + 273.15
    End Function

    Function KToC(v As Double) As Double
        Return v - 273.15
    End Function

    Function mmPow2TomPow2(v As Double) As Double
        Return v * 0.000001
    End Function

    Function inchPow2TomPow2(v As Double) As Double
        Return v * 0.00064516
    End Function

    Function Nmm2Nm(v As Double) As Double
        Return v / 1000
    End Function

    Function kgcm2Nm(v As Double) As Double
        Return v * 0.0980665
    End Function

    Function kg2N(v As Double) As Double
        Return v * 9.80665
    End Function

    Function lb2N(v As Double) As Double
        Return v * 4.44822162825
    End Function
    Function gPerdm2TokgPerm2(v As Double) As Double
        Return v * 0.1 'double check
    End Function

    Function parseNiceUnit(s As String)
        Return s.Replace("/", "Per").Replace("-", "dl").Replace("^", "Pow")
    End Function

    Function convertToNiceUnit(s As String)
        Return s.Replace("Per", "/").Replace("dl", "-").Replace("Pow", "^")
    End Function

    'Function parseNiceUnit(ByRef array As String())
    '    For Each s As String In array
    '        s = parseNiceUnit(s)
    '    Next

    '    Return array
    'End Function
End Module

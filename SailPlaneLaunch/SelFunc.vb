Module SelFunc
    '    #-------------------------------------------------------------------------------
    '# Name: selFunc
    '# Purpose: Contains a selection of simple functions
    '#
    '# Author: Petter
    '#
    '# Created: 14.05.2012
    '# Copyright: (c) Petter 2012
    '# Licence: <your licence>
    '#-------------------------------------------------------------------------------


    Function temperature(ByVal y, ByVal T0)
        temperature = T0 - 0.0065 * y
    End Function

    Function pressure(ByVal p0, ByVal T0, ByVal y)
        pressure = p0 * (1 - 0.0065 * y / T0) ^ (g() / (287.058 * 0.0065))
    End Function

    Function density(ByVal p0 As Double, ByVal T0 As Double, ByVal y As Double)
        density = pressure(p0, T0, y) / (287.058 * temperature(y, T0))
    End Function

    Function g()
        g = 9.80665
    End Function

    Function p0ISA()
        p0ISA = 101325
    End Function

    Function T0ISA()
        T0ISA = 288.15
    End Function

    Function pSat(ByVal T)
        pSat = (6.1078 * 10 ^ (7.5 * (T - 273.15) / ((T - 273.15) + 237.3))) * 100
    End Function

    Function pVapour(ByVal T0 As Double, ByVal y As Double, ByVal humidity As Double)
        pVapour = humidity * pSat(temperature(y, T0))
    End Function

    Function pDry(ByVal humidity As Double, ByVal p0 As Double, ByVal T0 As Double, ByVal y As Double)
        pDry = pressure(p0, T0, y) - pVapour(T0, y, humidity)
    End Function

    Function densityWithHumidity(ByVal humidity As Double, ByVal p0 As Double, ByVal T0 As Double, ByVal y As Double)
        densityWithHumidity = (pressure(p0, T0, y) / (287.058 * temperature(y, T0))) * (1 + humidity) / (1 + humidity * 461.495 / 287.058)
    End Function

    Function dynamicViscosity(ByVal T As Double)
        dynamicViscosity = 1.51204129 * T ^ (3 / 2) / (T + 120)
    End Function

    Function kinematicViscocity(ByVal myVisc As Double, ByVal rho As Double)
        kinematicViscocity = myVisc / rho
    End Function

    Function reynoldsNumber(ByVal nu As Double, ByVal velocity As Double, ByVal c As Double)
        reynoldsNumber = 150000 'c * velocity / nu
    End Function

    'Function  setFigureNumber():
    '    global figureNumber
    '        figureNumber = figureNumber + 1

    'Function  getFigureNumber():
    '        Return figureNumber

    'Function  getDateString():
    '        collection = datetime.now()
    '    myString = collection.isoformat() #collection.year + collection.month +collection.day
    '        myString = re.sub("\:", "-", myString)
    '        myString = re.sub("\.", "MS", myString)
    '        Return myString

    'Function  writeDict(_dictonary,_fileName):
    '    f = open(_fileName,'w')
    '        temp = str(_dictonary)
    '        temp = re.sub(",", "\n", temp)
    '        f.write(str(temp))
    '        f.close()

    'Function  readDict(_dictonary,_fileName):
    '    f = open(_fileName,'r')
    '        my_dict = eval1(f.read())
    '        f.close()

    'Function  eval1(x):
    '        Try : Return eval(x)
    'except:     Return x
    '    A = { eval1(y[0]) : eval1(y[1]) for y in [x.split() for x in open(filename).readlines()] }



    Function vThermic(ByVal height As Double, ByVal heightThermicCeil As Double, ByVal vThermicCeil As Double)
        '    """
        '    Returns the thermic windspeed
        '    """
        vThermic = vThermicCeil / heightThermicCeil * height
    End Function


    Function lengthToPlaneFromPulley(ByVal x As Double, ByVal y As Double)
        '"""
        'Returns the actual length of the line
        '"""
        lengthToPlaneFromPulley = Math.Sqrt(x ^ 2 + y ^ 2)
    End Function

    Public Function last(ByVal para As String) As Double
        Return outputs.last(para)
    End Function

    Public Function lastDesiredUnit(ByVal para As String) As Double
        Return outputs.lastDesiredUnit(para)
    End Function

    Public Function last2(ByVal para As String) As Double
        last2 = outputs.last2(para)
    End Function

    Public Sub add(paramName As String, value As Double)
        outputs.add(paramName, value)
    End Sub

    Public Sub last(paramName As String, value As Double)
        outputs.last(paramName, value)
    End Sub
End Module

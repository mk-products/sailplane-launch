Imports System.Threading

Module Simulate
    Public online As Boolean

    Public debug As Boolean
    Private debugger As Debugger
    Public diveAngle As Double
    Public dt As Object



    Public Sub simulate(_debug As Boolean, _debugger As Debugger)

        Dim CounterKim As Integer
        Dim bugFix As Boolean
        bugFix = False
        CounterKim = 0
        debug = _debug
        debugger = _debugger
        online = True
        lengthSoFar = 0
        'alt = 2
        '"""
        'Runs the simulation
        '"""
        Dim iterations As Integer = 0

        Console.WriteLine("iterations " & iterations)
        dt = val("dt")
        While last("time") <= val("maxT") And last("y") >= -10.0 And last("phase") < 5 And last("y") <= 500.0


            '"""
            'Each last("phase") of the launch determines how the plane should behave
            '    0 Preload the wire. The plane is stationary and the winch starts to tention the wire
            '    1 Takeoff. The plane is released and starts to accelerate along the ground. This last("phase") starts when the line reaches the wanted preforce
            '    2 Liftoff and climb. The plane increases the angle of attack and leaves the ground. This last("phase") starts when the takeoffspeed (v0) is reached
            '    3 Dive. At the peak height the plane starts to dive against the pulley to increase its energy
            '    4 Climb. The winch is released and the plane starts to climb.
            '    5 Climb is ended and plane is flying straight ahead with thermic setting.

            '"""

            ' Change phases


            ' Check if Pre tensioning of line is completed
            If last("lineForce") > val("preTensionOfLine") And last("phase") = 0 Then
                'dt = val("dt") / 100
                If alt >= 2 Then ' Alt 2 does not contain any takeoff along the ground
                    add("phase", 2)
                    last("groundSpeedX", Math.Cos(val("launchAngle")) * val("takeOffSpeed")) ' Plane velocity in x direction [m/s]
                    last("v", Math.Sin(val("launchAngle")) * val("takeOffSpeed"))   ' Plane velocity in y direction [m/s]
                    last("gamma", val("launchAngle"))  ' Angle between plane and ground [deg]

                Else
                    add("phase", 1)
                End If
            End If


            ' Check if we reached take of speed
            If last("airSpeed") > val("takeOffSpeed") And last("phase") = 1 Then
                add("phase", 2)
            End If


            'CHeck if we reached angle to start zooming
            If last("psi") > val("diveStartAngle") And last("phase") = 2 Then
                add("phase", 3)

                If Not GUI.CheckBoxZooming.Checked Then
                    last("phase", 4)
                    online = False

                    last("groundSpeedX", Math.Cos(val("climbAngle")) * last("airSpeed")) ' Plane velocity in x direction [m/s]
                    last("v", Math.Sin(val("climbAngle")) * last("airSpeed"))   ' Plane velocity in y direction [m/s]
                    bugFix = False
                Else
                    diveAngle = -last("psi")
                End If


                'dt = val("dt")
            End If
            'val("dt") = val("dt")/5


            ' Reached bottom of zoom
            If (last("y") < 100 Or last("lineForce") < 0) And last("phase") = 3 Then
                add("phase", 4)
                online = False

                last("groundSpeedX", Math.Cos(val("climbAngle")) * last("airSpeed")) ' Plane velocity in x direction [m/s]
                last("v", Math.Sin(val("climbAngle")) * last("airSpeed"))   ' Plane velocity in y direction [m/s]
                bugFix = False
            End If


            'Reached top of launch
            '
            If (last("airSpeed") < velocityMin(last("flapPos")) * 1.1 Or ((last("y") - last2("y")) <= 0 And bugFix)) And last("phase") >= 4 And last("phase") < 5 Then
                last("phase", 5)
            End If

            If (last("gamma") <= 0 And last("phase") >= 5) Then
                last("phase", 6)
            End If


            euler() ' call the desired solver
            bugFix = True


            'Debugging mode
            If (debug) Then
                debugger.iterationMade()
                If debugger.isPause Then
                    debugger.paused(outputs.getAllNames, inputs.getAll)
                End If
                While (debugger.isPause)
                    Thread.Sleep(500)
                End While
            End If

            iterations = iterations + 1
            If iterations Mod 1000 = 0 Then
                Console.WriteLine("iterations " & iterations)
            End If

        End While

        If (debug) Then
            debugger.done()
        End If



    End Sub

  
    'E.append(_y[-1]*g()*planemass+0.5*pm*_velocity[-1]^2) add some energy calculations aswell??Kinetic potensinal, winch and whats stored in line..



End Module

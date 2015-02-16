Module Solver



    Sub euler()
        '"""
        'Calculates the new position of the plane using forward Euler iteration
        'Does not allow the plane to go below y=0 as this is ground level
        '"""
        sumForces()

        ' Pretension
        If last("phase") = 0 Then
            add("groundSpeedX", 0)
            add("v", 0)
            add("ax", 0)
            add("ay", 0)

            'Rolling on ground
        ElseIf last("phase") = 1 And alt = 1 Then
            add("ax", last("fx") / planeMass)
            add("ay", last("fy") / planeMass)
            add("groundSpeedX", last("groundSpeedX") + last("ax") * dt)
            add("v", 0)

            ' All other cases
        Else
            add("ax", last("fx") / planeMass)
            add("ay", last("fy") / planeMass)
            add("groundSpeedX", last("groundSpeedX") + last("ax") * dt)
            add("v", last("v") + last("ay") * dt)
        End If


        add("x", last("x") + last("groundSpeedX") * dt)
        add("y", Math.Max(last("y") + last("v") * dt, 0)) 'To make sure y always is positive
        add("time", last("time") + val("dt"))

    End Sub
End Module

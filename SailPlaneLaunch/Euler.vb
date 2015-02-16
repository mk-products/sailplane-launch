Module Euler
    '"""
    'Calculates the new position of the plane using forward Euler iteration
    'Does not allow the plane to go below y=0 as this is ground level
    '"""
    Function Euler()

        If phase = 0 Then
            sumForces()
            _u.Add(0)
            _v.Add(0)
            _ax.Add(0)
            _ay.Add(0)
        ElseIf phase = 1 And alt = 1 Then
            sumForces()
            _ax.Add(_fx(_fx.Count - 1) / pm)
            _ay.Add(_fy(_fy.Count - 1) / pm)
            _u.Add(_u(_u.Count - 1) + _ax(_ax.Count - 1) * dt)
            _v.Add(0)

        Else
            sumForces()
            _ax.Add(_fx(_fx.Count - 1) / pm)
            _ay.Add(_fy(_fy.Count - 1) / pm)
            _u.Add(_u(_u.Count - 1) + _ax(_ax.Count - 1) * dt)
            _v.Add(_v(_v.Count - 1) + _ay(_ay.Count - 1) * dt)
        End If

        _x.Add(_x(_x.Count - 1) + _u(_u.Count - 1) * dt)
        _y.add(Math.Max(_y(_y.Count - 1) + _v(_v.Count - 1) * dt),0)) ' To make sure y always is positive

    End Function
End Module

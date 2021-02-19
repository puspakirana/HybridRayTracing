Public Class mainForm

    Public bmp As Bitmap
    Dim grp As Graphics
    Dim R0, LS As Vector
    Public ka, kd, ks, specN As Double
    Dim Ilight As Color = Color.White
    Dim brgColor As Color = Color.Black

    Public whole As World
    Public nSphere, nMirror As Integer
    Public solid, mirror As Material

    Dim value As Double

    Private Sub mainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        bmp = New Bitmap(displayBox.Width, displayBox.Height)
        grp = Graphics.FromImage(bmp)

        ka = 0.5
        kd = 0.5
        ks = 0.5
        specN = 5

        R0 = New Vector(0, 0, 200)
        LS = New Vector(0, 500, 200)

        solid = New Material(0)
        mirror = New Material(0.9)

        whole = New World
        whole.init = Nothing

        nSphere = 1
        nMirror = 1

        value = 5

        draw()

    End Sub

    Sub draw()
        grp.Clear(Color.Black)
        Dim i, j As Double
        Dim pixel As New Vector(0, 0, 0)

        For i = 0 To bmp.Width - 1
            For j = 0 To bmp.Height - 1
                pixel.PScreen(i, j, 0)
                Dim Rd As Vector = (pixel - R0).normalize()
                Dim pxlColor As Color
                pxlColor = findIntensity(R0, Rd)
                bmp.SetPixel(i, j, pxlColor)
            Next
        Next

        displayBox.Image = bmp

    End Sub

    Function findIntensity(R0 As Vector, Rd As Vector)
        Dim smth As Ray = whole.compareIntersection(R0, Rd, Nothing)
        If smth.IsExposed Then
            Dim c As Color = getIntensity(smth, Rd, 0)
            Return c
        End If
        Return brgColor
    End Function

    Function getIntensity(smth As Ray, Rd As Vector, depth As Integer) As Color
        Dim Ldis As Double
        Ldis = (LS - smth.position).length()

        'ambient
        Dim cR As Double = smth.clr.R * ka
        Dim cG As Double = smth.clr.G * ka
        Dim cB As Double = smth.clr.B * ka

        Dim Iamb As Color = Color.FromArgb(cR, cG, cB)

        'diffuse
        Dim L As Vector = (LS - smth.position).normalize()
        Dim LdotN As Double = L.dotProduct(smth.normal)

        'specular
        Dim V As Vector = (R0 - smth.position).normalize()
        Dim R As Vector = smth.normal * (2 * LdotN) - L
        Dim VdotR As Double = V.dotProduct(R)

        If LdotN > 0 Then
            cR += Ilight.R * kd * LdotN
            cG += Ilight.G * kd * LdotN
            cB += Ilight.B * kd * LdotN
            If VdotR > 0 Then
                cR += Ilight.R * ks * (VdotR ^ specN)
                cG += Ilight.G * ks * (VdotR ^ specN)
                cB += Ilight.B * ks * (VdotR ^ specN)
            End If
        End If


        If depth < 2 Then
            'Reflection
            If smth.elmt.material.reflection > 0 Then
                Dim NdotRd As Double = smth.normal.dotProduct(Rd)
                Dim Rf As Vector = Rd + (smth.normal * -2 * NdotRd)
                Dim Reflection As Ray = whole.compareIntersection(smth.position, Rf, smth.elmt.idNum)
                If Reflection.IsExposed AndAlso Reflection.intersection >= 0 Then
                    Reflection.clr = getIntensity(Reflection, Rf, depth + 1)
                Else
                    Reflection.clr = brgColor
                End If
                cR = cR + smth.elmt.material.reflection * Reflection.clr.R
                cG = cG + smth.elmt.material.reflection * Reflection.clr.G
                cB = cB + smth.elmt.material.reflection * Reflection.clr.B
            End If
        End If

        'THE SHADOW
        Dim shadow As Ray
        shadow = whole.compareIntersection(smth.position, L, smth.elmt.idNum)
        If shadow.IsExposed AndAlso shadow.elmt IsNot smth.elmt Then
            cR = Iamb.R
            cG = Iamb.G
            cB = Iamb.B
        End If

        'If Not shadow.IsExposed Then
        '    If LdotN > 0 Then
        '        cR += Ilight.R * kd * LdotN
        '        cG += Ilight.G * kd * LdotN
        '        cB += Ilight.B * kd * LdotN
        '        If VdotR > 0 Then
        '            cR += Ilight.R * ks * (VdotR ^ specN)
        '            cG += Ilight.G * ks * (VdotR ^ specN)
        '            cB += Ilight.B * ks * (VdotR ^ specN)
        '        End If
        '    End If
        'End If

        If cR > 255 Then
            cR = 255
        ElseIf cR < 0 Then
            cR = 0
        End If
        If cG > 255 Then
            cG = 255
        ElseIf cG < 0 Then
            cG = 0
        End If
        If cB > 255 Then
            cB = 255
        ElseIf cB < 0 Then
            cB = 0
        End If

        Dim Itot As Color = Color.FromArgb(CInt(cR), CInt(cG), CInt(cB))
        Return Itot

    End Function

    Private Sub btnSphere_Click(sender As Object, e As EventArgs) Handles btnSphere.Click
        sphereForm.Show()
    End Sub

    Private Sub btnMirror_Click(sender As Object, e As EventArgs) Handles btnMirror.Click
        mirrorForm.Show()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        ka = 0.5
        tbKA.Text = 0.5
        kd = 0.5
        tbKD.Text = 0.5
        ks = 0.5
        tbKS.Text = 0.5
        specN = 5
        tbSpecN.Text = 5

        R0 = New Vector(0, 0, 200)
        LS = New Vector(0, 500, 200)

        solid = New Material(0)
        mirror = New Material(0.9)
        tbKRef.Text = 0.9

        whole = New World
        whole.init = Nothing

        nSphere = 1
        nMirror = 1

        value = 5
        tbValue.Text = 5

        tbAngle.Text = 30

        listObject.Items.Clear()
        listObject.Items.Add("Light")

        draw()
    End Sub

    Private Sub btnChange_Click(sender As Object, e As EventArgs) Handles btnChange.Click
        ka = CDbl(tbKA.Text)
        kd = CDbl(tbKD.Text)
        ks = CDbl(tbKS.Text)
        specN = CDbl(tbSpecN.Text)
        mirror.reflection = CDbl(tbKRef.Text)
        draw()

    End Sub

    'TRANSLATE OBJECT

    Private Sub btnRight_Click(sender As Object, e As EventArgs) Handles btnRight.Click
        value = CDbl(tbValue.Text)
        If listObject.SelectedIndex >= 0 Then
            Dim slct As String
            Dim delta As New Vector(value, 0, 0)
            slct = listObject.SelectedItem
            If slct = "Light" Then
                LS += delta
            Else
                whole.translate(slct, delta)
            End If
            draw()
        End If
    End Sub

    Private Sub btnLeft_Click(sender As Object, e As EventArgs) Handles btnLeft.Click
        value = CDbl(tbValue.Text)
        If listObject.SelectedIndex >= 0 Then
            Dim slct As String
            Dim delta As New Vector(-value, 0, 0)
            slct = listObject.SelectedItem
            If slct = "Light" Then
                LS += delta
            Else
                whole.translate(slct, delta)
            End If
            draw()
        End If
    End Sub

    Private Sub btnDown_Click(sender As Object, e As EventArgs) Handles btnDown.Click
        value = CDbl(tbValue.Text)
        If listObject.SelectedIndex >= 0 Then
            Dim slct As String
            Dim delta As New Vector(0, -value, 0)
            slct = listObject.SelectedItem
            If slct = "Light" Then
                LS += delta
            Else
                whole.translate(slct, delta)
            End If
            draw()
        End If
    End Sub

    Private Sub btnUp_Click(sender As Object, e As EventArgs) Handles btnUp.Click
        value = CDbl(tbValue.Text)
        If listObject.SelectedIndex >= 0 Then
            Dim slct As String
            Dim delta As New Vector(0, value, 0)
            slct = listObject.SelectedItem
            If slct = "Light" Then
                LS += delta
            Else
                whole.translate(slct, delta)
            End If
            draw()
        End If
    End Sub

    Private Sub btnForward_Click(sender As Object, e As EventArgs) Handles btnForward.Click
        value = CDbl(tbValue.Text)
        If listObject.SelectedIndex >= 0 Then
            Dim slct As String
            Dim delta As New Vector(0, 0, value)
            slct = listObject.SelectedItem
            If slct = "Light" Then
                LS += delta
            Else
                whole.translate(slct, delta)
            End If
            draw()
        End If
    End Sub

    Private Sub btnBackward_Click(sender As Object, e As EventArgs) Handles btnBackward.Click
        value = CDbl(tbValue.Text)
        If listObject.SelectedIndex >= 0 Then
            Dim slct As String
            Dim delta As New Vector(0, 0, -value)
            slct = listObject.SelectedItem
            If slct = "Light" Then
                LS += delta
            Else
                whole.translate(slct, delta)
            End If
            draw()
        End If
    End Sub

    'ROTATE MIRROR
    Private Sub btnRotateX_Click(sender As Object, e As EventArgs) Handles btnRotateX.Click
        If listObject.SelectedIndex >= 0 Then
            Dim angle As Double = CDbl(tbAngle.Text) Mod 360
            angle = Math.PI * angle / 180
            Dim slct As String = listObject.SelectedItem
            Dim axis As Char = "x"
            whole.rotate(slct, angle, axis)
            draw()
        End If
    End Sub

    Private Sub btnRotateY_Click(sender As Object, e As EventArgs) Handles btnRotateY.Click
        If listObject.SelectedIndex >= 0 Then
            Dim angle As Double = CDbl(tbAngle.Text) Mod 360
            angle = Math.PI * angle / 180
            Dim slct As String = listObject.SelectedItem
            Dim axis As Char = "y"
            whole.rotate(slct, angle, axis)
            draw()
        End If
    End Sub

    Private Sub btnRotateZ_Click(sender As Object, e As EventArgs) Handles btnRotateZ.Click
        If listObject.SelectedIndex >= 0 Then
            Dim angle As Double = CDbl(tbAngle.Text) Mod 360
            angle = Math.PI * angle / 180
            Dim slct As String = listObject.SelectedItem
            Dim axis As Char = "z"
            whole.rotate(slct, angle, axis)
            draw()
        End If
    End Sub


End Class

Public Class World
    Public init As TObject

    Sub insert(abc As TObject)
        If IsNothing(init) Then
            init = abc
        Else
            Dim temp As TObject
            temp = init
            While Not IsNothing(temp.nxt)
                temp = temp.nxt
            End While
            temp.nxt = abc
        End If
    End Sub

    Public Function compareIntersection(R0 As Vector, Rd As Vector, thg As String) As Ray
        Dim this As New Ray
        'max value of intersection
        this.intersection = Double.PositiveInfinity

        If IsNothing(init) Then
            Return this
        Else
            Dim temp As TObject
            temp = init
            While Not IsNothing(temp)
                If Not temp.idNum.Equals(thg) Then
                    Dim smth As Ray = temp.findIntersection(R0, Rd)
                    If smth.IsExposed AndAlso smth.intersection < this.intersection AndAlso smth.intersection >= 0 Then
                        this = smth
                    End If
                End If
                temp = temp.nxt
            End While
        End If

        Return this
    End Function

    Sub translate(idObj As String, delta As Vector)
        Dim obj As String() = idObj.Split(" "c)
        Dim temp As TObject
        temp = init

        While Not IsNothing(temp)
            If temp.idNum = idObj Then
                If obj(0) = "Sphere" Then
                    temp.center = temp.center + delta
                ElseIf obj(0) = "Mirror" Then
                    Dim temp2 As Mirror
                    temp2 = temp
                    temp2.P1 = temp2.P1 + delta
                    temp2.P2 = temp2.P2 + delta
                    temp2.P3 = temp2.P3 + delta
                End If
            End If
            temp = temp.nxt
        End While
    End Sub

    Function rotate(idObj As String, angle As Double, axis As Char)
        Dim obj As String() = idObj.Split(" "c)
        Dim temp As TObject
        temp = init

        While Not IsNothing(temp)
            If temp.idNum = idObj Then
                If obj(0) = "Mirror" Then
                    Dim temp2 As Mirror
                    temp2 = temp
                    If axis = "x" Then
                        temp2.P1 = xRotation(angle, temp2.P1, temp2.center)
                        temp2.P2 = xRotation(angle, temp2.P2, temp2.center)
                        temp2.P3 = xRotation(angle, temp2.P3, temp2.center)
                    ElseIf axis = "y" Then
                        temp2.P1 = yRotation(angle, temp2.P1, temp2.center)
                        temp2.P2 = yRotation(angle, temp2.P2, temp2.center)
                        temp2.P3 = yRotation(angle, temp2.P3, temp2.center)
                    ElseIf axis = "z" Then
                        temp2.P1 = zRotation(angle, temp2.P1, temp2.center)
                        temp2.P2 = zRotation(angle, temp2.P2, temp2.center)
                        temp2.P3 = zRotation(angle, temp2.P3, temp2.center)
                    End If
                End If
            End If
            temp = temp.nxt
        End While

        Return temp
    End Function

    Function xRotation(angle As Double, v As Vector, ctr As Vector) As Vector
        Dim rX(3, 3) As Double
        rX = New Double(3, 3) {{1, 0, 0, 0},
                               {0, Math.Cos(angle), Math.Sin(angle), 0},
                               {0, -Math.Sin(angle), Math.Cos(angle), 0},
                               {0, 0, 0, 1}}
        v.x = v.x - ctr.x
        v.y = v.y - ctr.y
        v.z = v.z - ctr.z

        Dim temp As Vector
        temp = pointMatrixMultiplication(v, rX)

        temp.x = temp.x + ctr.x
        temp.y = temp.y + ctr.y
        temp.z = temp.z + ctr.z

        Return temp

    End Function

    Function yRotation(angle As Double, v As Vector, ctr As Vector) As Vector
        Dim rY(3, 3) As Double
        rY = New Double(3, 3) {{Math.Cos(angle), 0, -Math.Sin(angle), 0},
                               {0, 1, 0, 0},
                               {Math.Sin(angle), 0, Math.Cos(angle), 0},
                               {0, 0, 0, 1}}
        v.x = v.x - ctr.x
        v.y = v.y - ctr.y
        v.z = v.z - ctr.z

        Dim temp As Vector
        temp = pointMatrixMultiplication(v, rY)

        temp.x = temp.x + ctr.x
        temp.y = temp.y + ctr.y
        temp.z = temp.z + ctr.z

        Return temp

    End Function

    Function zRotation(angle As Double, v As Vector, ctr As Vector) As Vector
        Dim rZ(3, 3) As Double
        rZ = New Double(3, 3) {{Math.Cos(angle), Math.Sin(angle), 0, 0},
                               {-Math.Sin(angle), Math.Cos(angle), 0, 0},
                               {0, 0, 1, 0},
                               {0, 0, 0, 1}}
        v.x = v.x - ctr.x
        v.y = v.y - ctr.y
        v.z = v.z - ctr.z

        Dim temp As Vector
        temp = pointMatrixMultiplication(v, rZ)

        temp.x = temp.x + ctr.x
        temp.y = temp.y + ctr.y
        temp.z = temp.z + ctr.z

        Return temp

    End Function

    Function pointMatrixMultiplication(Pnt As Vector, M(,) As Double) As Vector
        Dim temp As New Vector(0, 0, 0)
        Dim w As Double
        temp.x = Pnt.x * M(0, 0) + Pnt.y * M(1, 0) + Pnt.z * M(2, 0) + 1 * M(3, 0)
        temp.y = Pnt.x * M(0, 1) + Pnt.y * M(1, 1) + Pnt.z * M(2, 1) + 1 * M(3, 1)
        temp.z = Pnt.x * M(0, 2) + Pnt.y * M(1, 2) + Pnt.z * M(2, 2) + 1 * M(3, 2)
        w = Pnt.x * M(0, 3) + Pnt.y * M(1, 3) + Pnt.z * M(2, 3) + 1 * M(3, 3)

        temp.x = temp.x / w
        temp.y = temp.y / w
        temp.z = temp.z / w

        Return temp

    End Function

End Class

Public Class Mirror
    Inherits TObject

    Public P1, P2, P3 As Vector 'Points of Mirror

    Public Sub New(id As String, sfc As Material, pos As Vector, pt1 As Vector, pt2 As Vector, pt3 As Vector, clr As Color)
        idNum = id
        material = sfc
        center = pos
        P1 = pt1
        P2 = pt2
        P3 = pt3
        objColor = clr
        nxt = Nothing
    End Sub

    Public Overrides Function findIntersection(R0 As Vector, Rd As Vector) As Ray

        Dim smth As New Ray

        Dim v0 As Vector = P2 - P1
        Dim v1 As Vector = P3 - P1

        smth.normal = v0.crossProduct(v1).normalize()

        Dim D As Double = -(smth.normal.x * P1.x + smth.normal.y * P1.y + smth.normal.z * P1.z)

        Dim Q As Vector = Rd + R0

        smth.intersection = -(smth.normal.dotProduct(Q) + D) / smth.normal.dotProduct(Rd)


        Dim Pn As Vector = R0 + (Rd * smth.intersection) 'a point inside polygon

        Dim v2 As Vector = Pn - P1

        'Barrycentric Coordinates
        Dim C As Double = (v0.dotProduct(v0) * v1.dotProduct(v1)) - (v0.dotProduct(v1) * v0.dotProduct(v1))

        Dim n2 As Double = (v1.dotProduct(v1) * v2.dotProduct(v0) - v0.dotProduct(v1) * v2.dotProduct(v1)) / C
        Dim n3 As Double = (v0.dotProduct(v0) * v2.dotProduct(v1) - v0.dotProduct(v1) * v2.dotProduct(v0)) / C
        Dim n1 As Double = 1 - n2 - n3


        If (n1 >= 0 And n1 <= 1) And (n2 >= 0 And n2 <= 1) And (n3 >= 0 And n3 <= 1) Then
            smth.position = P1 * n1 + P2 * n2 + P3 * n3
            smth.normal = v0.crossProduct(v1).normalize()
            smth.clr = objColor
            smth.elmt = Me
            smth.IsExposed = True
        Else
            smth.IsExposed = False
        End If

        Return smth
    End Function
End Class

Public Class Sphere
    Inherits TObject

    Public r As Double 'sphere radius

    Public Sub New(id As String, sfc As Material, ctr As Vector, rad As Double, clr As Color)
        idNum = id
        material = sfc
        center = ctr
        r = rad
        objColor = clr
        nxt = Nothing
    End Sub

    Public Overrides Function findIntersection(R0 As Vector, Rd As Vector) As Ray
        Dim smth As New Ray

        Dim S As Vector = center - R0
        Dim td As Double = S.dotProduct(Rd)
        Dim d2 As Double = S.dotProduct(S) - td ^ 2
        Dim PQ2 As Double = r * r - d2

        If PQ2 >= 0 Then
            smth.intersection = td - Math.Sqrt(PQ2) 't = td - PQ
            If smth.intersection > 0 Then
                smth.position = R0 + Rd * smth.intersection 'point P = R0 - Rd * t
                smth.normal = (smth.position - center).normalize() 'normalized normal vector
                smth.clr = objColor
                smth.elmt = Me
                smth.IsExposed = True
            Else
                smth.IsExposed = False
            End If
        Else
                smth.IsExposed = False
        End If

        Return smth
    End Function

End Class

Public MustInherit Class TObject
    Public MustOverride Function findIntersection(R0 As Vector, Rd As Vector) As Ray

    Public idNum As String 'object id
    Public material As Material
    Public center As Vector
    Public objColor As Color
    Public nxt As TObject
    
End Class

Public Class Ray
    Public position As Vector 'P point
    Public normal As Vector 'normal vector
    Public intersection As Double 't
    Public clr As Color 'object color
    Public elmt As TObject 'object
    Public IsExposed As Boolean
End Class

Public Class Material
    Public reflection As Double
    'Public refraction As Double
    Public Sub New(reflection As Double)
        Me.reflection = reflection
        'Me.refraction = refraction
    End Sub
End Class

Public Class Vector

    Public x, y, z As Double

    Public Sub New(x As Double, y As Double, z As Double)
        Me.x = x
        Me.y = y
        Me.z = z
    End Sub

    'Vector And Vector
    Public Shared Operator +(v1 As Vector, v2 As Vector) As Vector
        Return New Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z)
    End Operator
    Public Shared Operator -(v1 As Vector, v2 As Vector) As Vector
        Return New Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z)
    End Operator
    Public Shared Operator *(v1 As Vector, v2 As Vector) As Vector
        Return New Vector(v1.x * v2.x, v1.y * v2.y, v1.z * v2.z)
    End Operator

    'Vector And Scalar
    Public Shared Operator *(v As Vector, s As Double) As Vector
        Return New Vector(v.x * s, v.y * s, v.z * s)
    End Operator
    Public Shared Operator /(v As Vector, s As Double) As Vector
        Return New Vector(v.x / s, v.y / s, v.z / s)
    End Operator

    Public Function dotProduct(v As Vector) As Double
        Return Me.x * v.x + Me.y * v.y + Me.z * v.z
    End Function

    Public Function crossProduct(v As Vector) As Vector
        Return New Vector(Me.y * v.z - Me.z * v.y, Me.z * v.x - Me.x * v.z, Me.x * v.y - Me.y * v.x)
    End Function

    Public Function normalize() As Vector
        Dim n As Double = Math.Sqrt(x * x + y * y + z * z)
        Return New Vector(x / n, y / n, z / n)
    End Function

    Public Function length() As Double
        Return Math.Sqrt(x * x + y * y + z * z)
    End Function

    Public Function PScreen(i As Integer, j As Integer, k As Integer) As Vector
        x = i - mainForm.bmp.Width / 2
        y = (j - mainForm.bmp.Height / 2) * -1
        z = 0

        Return New Vector(x, y, z)
    End Function

End Class


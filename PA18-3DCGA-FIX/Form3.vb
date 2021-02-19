Public Class mirrorForm
    Dim col As Color = Color.White
    Dim mtr As Material

    Private Sub mirrorForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnColorMirror.BackColor = col
    End Sub

    Private Sub btnColorMirror_Click(sender As Object, e As EventArgs) Handles btnColorMirror.Click
        If mirrorColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            col = mirrorColor.Color
            btnColorMirror.BackColor = col
        End If
    End Sub

    Private Sub btnCreateMirror_Click(sender As Object, e As EventArgs) Handles btnCreateMirror.Click
        Dim x, y, z As Double
        Dim wmax, wmin, lmax, lmin As Double
        Dim ctr As New Vector(0, 0, 0)

        x = CDbl(tbMirrorX.Text)
        y = CDbl(tbMirrorY.Text)
        z = CDbl(tbMirrorZ.Text)

        wmax = CDbl(tbMirrorWmax.Text)
        wmin = CDbl(tbMirrorWmin.Text)
        lmax = CDbl(tbMirrorLmax.Text)
        lmin = CDbl(tbMirrorLmin.Text)

        Dim position As New Vector(x, y, z)
        Dim p1, p2, p3, p4 As Vector


        If rbUp.Checked Then
            p1 = New Vector(wmax, 0, lmax)
            p2 = New Vector(wmin, 0, lmax)
            p3 = New Vector(wmin, 0, lmin)
            p4 = New Vector(wmax, 0, lmin)
        End If

        If rbFront.Checked Then
            p1 = New Vector(wmax, lmax, 0)
            p2 = New Vector(wmin, lmax, 0)
            p3 = New Vector(wmin, lmin, 0)
            p4 = New Vector(wmax, lmin, 0)
        End If

        If rbRight.Checked Then
            p1 = New Vector(0, lmax, wmax)
            p2 = New Vector(0, lmax, wmin)
            p3 = New Vector(0, lmin, wmin)
            p4 = New Vector(0, lmin, wmax)
        End If

        mtr = mainForm.mirror

        Dim id As String = "Mirror " + mainForm.nMirror.ToString
        Dim Mr1 As New Mirror(id, mtr, ctr, p1, p2, p3, col)
        mainForm.whole.insert(Mr1)
        Dim Mr2 As New Mirror(id, mtr, ctr, p1, p3, p4, col)
        mainForm.whole.insert(Mr2)

        mainForm.whole.translate(id, position)

        mainForm.nMirror += 1
        mainForm.draw()

        mainForm.listObject.Items.Add(id)

        Me.Close()

    End Sub

End Class
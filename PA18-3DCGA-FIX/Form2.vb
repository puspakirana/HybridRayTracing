Public Class sphereForm
    Dim col As Color = Color.Red
    Dim mtr As Material

    Private Sub sphereForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btnColorSphere.BackColor = col
    End Sub

    Private Sub btnColorSphere_Click(sender As Object, e As EventArgs) Handles btnColorSphere.Click
        If sphereColor.ShowDialog <> Windows.Forms.DialogResult.Cancel Then
            col = sphereColor.Color
            btnColorSphere.BackColor = col
        End If
    End Sub

    Private Sub btnAddSphere_Click(sender As Object, e As EventArgs) Handles btnAddSphere.Click

        Dim x, y, z As Double

        x = CDbl(tbSphereX.Text)
        y = CDbl(tbSphereY.Text)
        z = CDbl(tbSphereZ.Text)

        Dim ctr As New Vector(x, y, z)
        Dim r As Double = CDbl(tbSphereR.Text)

        mtr = mainForm.solid

        Dim id As String = "Sphere " + mainForm.nSphere.ToString
        Dim Sp As New Sphere(id, mtr, ctr, r, col)

        mainForm.whole.insert(Sp)


        mainForm.nSphere += 1
        mainForm.draw()
        mainForm.listObject.Items.Add(id)

        Me.Close()

    End Sub

End Class
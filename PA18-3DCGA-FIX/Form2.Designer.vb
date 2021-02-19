<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class sphereForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbSphereX = New System.Windows.Forms.TextBox()
        Me.tbSphereY = New System.Windows.Forms.TextBox()
        Me.tbSphereZ = New System.Windows.Forms.TextBox()
        Me.tbSphereR = New System.Windows.Forms.TextBox()
        Me.btnColorSphere = New System.Windows.Forms.Button()
        Me.btnAddSphere = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sphereColor = New System.Windows.Forms.ColorDialog()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbSphereX
        '
        Me.tbSphereX.Location = New System.Drawing.Point(36, 22)
        Me.tbSphereX.Name = "tbSphereX"
        Me.tbSphereX.Size = New System.Drawing.Size(100, 20)
        Me.tbSphereX.TabIndex = 0
        Me.tbSphereX.Text = "0"
        '
        'tbSphereY
        '
        Me.tbSphereY.Location = New System.Drawing.Point(36, 60)
        Me.tbSphereY.Name = "tbSphereY"
        Me.tbSphereY.Size = New System.Drawing.Size(100, 20)
        Me.tbSphereY.TabIndex = 1
        Me.tbSphereY.Text = "0"
        '
        'tbSphereZ
        '
        Me.tbSphereZ.Location = New System.Drawing.Point(36, 95)
        Me.tbSphereZ.Name = "tbSphereZ"
        Me.tbSphereZ.Size = New System.Drawing.Size(100, 20)
        Me.tbSphereZ.TabIndex = 2
        Me.tbSphereZ.Text = "0"
        '
        'tbSphereR
        '
        Me.tbSphereR.Location = New System.Drawing.Point(36, 28)
        Me.tbSphereR.Name = "tbSphereR"
        Me.tbSphereR.Size = New System.Drawing.Size(100, 20)
        Me.tbSphereR.TabIndex = 3
        Me.tbSphereR.Text = "25"
        '
        'btnColorSphere
        '
        Me.btnColorSphere.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnColorSphere.FlatAppearance.BorderSize = 0
        Me.btnColorSphere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorSphere.Location = New System.Drawing.Point(183, 19)
        Me.btnColorSphere.Name = "btnColorSphere"
        Me.btnColorSphere.Size = New System.Drawing.Size(75, 23)
        Me.btnColorSphere.TabIndex = 4
        Me.btnColorSphere.Text = "Color"
        Me.btnColorSphere.UseVisualStyleBackColor = False
        '
        'btnAddSphere
        '
        Me.btnAddSphere.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnAddSphere.FlatAppearance.BorderSize = 0
        Me.btnAddSphere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAddSphere.Location = New System.Drawing.Point(183, 59)
        Me.btnAddSphere.Name = "btnAddSphere"
        Me.btnAddSphere.Size = New System.Drawing.Size(75, 23)
        Me.btnAddSphere.TabIndex = 5
        Me.btnAddSphere.Text = "Create"
        Me.btnAddSphere.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(14, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "X"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(10, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "r"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(14, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Z"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 60)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(14, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Y"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.tbSphereX)
        Me.GroupBox1.Controls.Add(Me.tbSphereY)
        Me.GroupBox1.Controls.Add(Me.tbSphereZ)
        Me.GroupBox1.Location = New System.Drawing.Point(6, 7)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(154, 126)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Position"
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.Transparent
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tbSphereR)
        Me.GroupBox2.Location = New System.Drawing.Point(6, 137)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(154, 64)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Properties"
        '
        'sphereForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(277, 212)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnAddSphere)
        Me.Controls.Add(Me.btnColorSphere)
        Me.Name = "sphereForm"
        Me.Text = "New Sphere"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbSphereX As TextBox
    Friend WithEvents tbSphereY As TextBox
    Friend WithEvents tbSphereZ As TextBox
    Friend WithEvents tbSphereR As TextBox
    Friend WithEvents btnColorSphere As Button
    Friend WithEvents btnAddSphere As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents sphereColor As ColorDialog
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class

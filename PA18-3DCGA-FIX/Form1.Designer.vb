<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class mainForm
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
        Me.btnSphere = New System.Windows.Forms.Button()
        Me.listObject = New System.Windows.Forms.ListBox()
        Me.tbKA = New System.Windows.Forms.TextBox()
        Me.tbKD = New System.Windows.Forms.TextBox()
        Me.tbKS = New System.Windows.Forms.TextBox()
        Me.btnChange = New System.Windows.Forms.Button()
        Me.tbSpecN = New System.Windows.Forms.TextBox()
        Me.btnMirror = New System.Windows.Forms.Button()
        Me.btnRight = New System.Windows.Forms.Button()
        Me.kalabel = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.kslabel = New System.Windows.Forms.Label()
        Me.kdlabel = New System.Windows.Forms.Label()
        Me.btnLeft = New System.Windows.Forms.Button()
        Me.btnDown = New System.Windows.Forms.Button()
        Me.btnUp = New System.Windows.Forms.Button()
        Me.btnBackward = New System.Windows.Forms.Button()
        Me.btnForward = New System.Windows.Forms.Button()
        Me.btnRotateX = New System.Windows.Forms.Button()
        Me.btnRotateY = New System.Windows.Forms.Button()
        Me.btnRotateZ = New System.Windows.Forms.Button()
        Me.tbAngle = New System.Windows.Forms.TextBox()
        Me.tbKRef = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.tbValue = New System.Windows.Forms.TextBox()
        Me.displayBox = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        CType(Me.displayBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnSphere
        '
        Me.btnSphere.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnSphere.FlatAppearance.BorderSize = 0
        Me.btnSphere.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnSphere.Location = New System.Drawing.Point(8, 35)
        Me.btnSphere.Name = "btnSphere"
        Me.btnSphere.Size = New System.Drawing.Size(75, 23)
        Me.btnSphere.TabIndex = 1
        Me.btnSphere.Text = "Sphere"
        Me.btnSphere.UseVisualStyleBackColor = False
        '
        'listObject
        '
        Me.listObject.FormattingEnabled = True
        Me.listObject.Items.AddRange(New Object() {"Light"})
        Me.listObject.Location = New System.Drawing.Point(12, 21)
        Me.listObject.Name = "listObject"
        Me.listObject.Size = New System.Drawing.Size(142, 303)
        Me.listObject.TabIndex = 2
        '
        'tbKA
        '
        Me.tbKA.Location = New System.Drawing.Point(64, 27)
        Me.tbKA.Name = "tbKA"
        Me.tbKA.Size = New System.Drawing.Size(100, 20)
        Me.tbKA.TabIndex = 3
        Me.tbKA.Text = "0.5"
        '
        'tbKD
        '
        Me.tbKD.Location = New System.Drawing.Point(64, 50)
        Me.tbKD.Name = "tbKD"
        Me.tbKD.Size = New System.Drawing.Size(100, 20)
        Me.tbKD.TabIndex = 4
        Me.tbKD.Text = "0.5"
        '
        'tbKS
        '
        Me.tbKS.Location = New System.Drawing.Point(64, 72)
        Me.tbKS.Name = "tbKS"
        Me.tbKS.Size = New System.Drawing.Size(100, 20)
        Me.tbKS.TabIndex = 5
        Me.tbKS.Text = "0.5"
        '
        'btnChange
        '
        Me.btnChange.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnChange.FlatAppearance.BorderSize = 0
        Me.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnChange.Location = New System.Drawing.Point(92, 158)
        Me.btnChange.Name = "btnChange"
        Me.btnChange.Size = New System.Drawing.Size(75, 23)
        Me.btnChange.TabIndex = 6
        Me.btnChange.Text = "Change"
        Me.btnChange.UseVisualStyleBackColor = False
        '
        'tbSpecN
        '
        Me.tbSpecN.Location = New System.Drawing.Point(64, 94)
        Me.tbSpecN.Name = "tbSpecN"
        Me.tbSpecN.Size = New System.Drawing.Size(100, 20)
        Me.tbSpecN.TabIndex = 7
        Me.tbSpecN.Text = "5"
        '
        'btnMirror
        '
        Me.btnMirror.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnMirror.FlatAppearance.BorderSize = 0
        Me.btnMirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMirror.Location = New System.Drawing.Point(90, 35)
        Me.btnMirror.Name = "btnMirror"
        Me.btnMirror.Size = New System.Drawing.Size(75, 23)
        Me.btnMirror.TabIndex = 8
        Me.btnMirror.Text = "Mirror"
        Me.btnMirror.UseVisualStyleBackColor = False
        '
        'btnRight
        '
        Me.btnRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnRight.FlatAppearance.BorderSize = 0
        Me.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRight.Location = New System.Drawing.Point(254, 50)
        Me.btnRight.Name = "btnRight"
        Me.btnRight.Size = New System.Drawing.Size(75, 23)
        Me.btnRight.TabIndex = 9
        Me.btnRight.Text = "Right"
        Me.btnRight.UseVisualStyleBackColor = False
        '
        'kalabel
        '
        Me.kalabel.AutoSize = True
        Me.kalabel.Location = New System.Drawing.Point(13, 29)
        Me.kalabel.Name = "kalabel"
        Me.kalabel.Size = New System.Drawing.Size(48, 13)
        Me.kalabel.TabIndex = 10
        Me.kalabel.Text = "Ambient:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 95)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(16, 13)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "n:"
        '
        'kslabel
        '
        Me.kslabel.AutoSize = True
        Me.kslabel.Location = New System.Drawing.Point(12, 73)
        Me.kslabel.Name = "kslabel"
        Me.kslabel.Size = New System.Drawing.Size(52, 13)
        Me.kslabel.TabIndex = 12
        Me.kslabel.Text = "Specular:"
        '
        'kdlabel
        '
        Me.kdlabel.AutoSize = True
        Me.kdlabel.Location = New System.Drawing.Point(13, 51)
        Me.kdlabel.Name = "kdlabel"
        Me.kdlabel.Size = New System.Drawing.Size(43, 13)
        Me.kdlabel.TabIndex = 13
        Me.kdlabel.Text = "Diffuse:"
        '
        'btnLeft
        '
        Me.btnLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnLeft.FlatAppearance.BorderSize = 0
        Me.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnLeft.Location = New System.Drawing.Point(76, 50)
        Me.btnLeft.Name = "btnLeft"
        Me.btnLeft.Size = New System.Drawing.Size(75, 23)
        Me.btnLeft.TabIndex = 14
        Me.btnLeft.Text = "Left"
        Me.btnLeft.UseVisualStyleBackColor = False
        '
        'btnDown
        '
        Me.btnDown.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnDown.FlatAppearance.BorderSize = 0
        Me.btnDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDown.Location = New System.Drawing.Point(166, 109)
        Me.btnDown.Name = "btnDown"
        Me.btnDown.Size = New System.Drawing.Size(75, 23)
        Me.btnDown.TabIndex = 15
        Me.btnDown.Text = "Down"
        Me.btnDown.UseVisualStyleBackColor = False
        '
        'btnUp
        '
        Me.btnUp.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnUp.FlatAppearance.BorderSize = 0
        Me.btnUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnUp.Location = New System.Drawing.Point(166, 22)
        Me.btnUp.Name = "btnUp"
        Me.btnUp.Size = New System.Drawing.Size(75, 23)
        Me.btnUp.TabIndex = 16
        Me.btnUp.Text = "Up"
        Me.btnUp.UseVisualStyleBackColor = False
        '
        'btnBackward
        '
        Me.btnBackward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnBackward.FlatAppearance.BorderSize = 0
        Me.btnBackward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackward.Location = New System.Drawing.Point(166, 50)
        Me.btnBackward.Name = "btnBackward"
        Me.btnBackward.Size = New System.Drawing.Size(75, 23)
        Me.btnBackward.TabIndex = 17
        Me.btnBackward.Text = "Backward"
        Me.btnBackward.UseVisualStyleBackColor = False
        '
        'btnForward
        '
        Me.btnForward.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnForward.FlatAppearance.BorderSize = 0
        Me.btnForward.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnForward.Location = New System.Drawing.Point(166, 80)
        Me.btnForward.Name = "btnForward"
        Me.btnForward.Size = New System.Drawing.Size(75, 23)
        Me.btnForward.TabIndex = 18
        Me.btnForward.Text = "Forward"
        Me.btnForward.UseVisualStyleBackColor = False
        '
        'btnRotateX
        '
        Me.btnRotateX.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRotateX.FlatAppearance.BorderSize = 0
        Me.btnRotateX.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateX.Location = New System.Drawing.Point(50, 46)
        Me.btnRotateX.Name = "btnRotateX"
        Me.btnRotateX.Size = New System.Drawing.Size(75, 23)
        Me.btnRotateX.TabIndex = 19
        Me.btnRotateX.Text = "X Rotation"
        Me.btnRotateX.UseVisualStyleBackColor = False
        '
        'btnRotateY
        '
        Me.btnRotateY.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRotateY.FlatAppearance.BorderSize = 0
        Me.btnRotateY.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateY.Location = New System.Drawing.Point(146, 46)
        Me.btnRotateY.Name = "btnRotateY"
        Me.btnRotateY.Size = New System.Drawing.Size(75, 23)
        Me.btnRotateY.TabIndex = 20
        Me.btnRotateY.Text = "Y Rotation"
        Me.btnRotateY.UseVisualStyleBackColor = False
        '
        'btnRotateZ
        '
        Me.btnRotateZ.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.btnRotateZ.FlatAppearance.BorderSize = 0
        Me.btnRotateZ.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnRotateZ.Location = New System.Drawing.Point(238, 46)
        Me.btnRotateZ.Name = "btnRotateZ"
        Me.btnRotateZ.Size = New System.Drawing.Size(75, 23)
        Me.btnRotateZ.TabIndex = 21
        Me.btnRotateZ.Text = "Z Rotation"
        Me.btnRotateZ.UseVisualStyleBackColor = False
        '
        'tbAngle
        '
        Me.tbAngle.Location = New System.Drawing.Point(52, 20)
        Me.tbAngle.Name = "tbAngle"
        Me.tbAngle.Size = New System.Drawing.Size(39, 20)
        Me.tbAngle.TabIndex = 22
        Me.tbAngle.Text = "30"
        '
        'tbKRef
        '
        Me.tbKRef.Location = New System.Drawing.Point(81, 119)
        Me.tbKRef.Name = "tbKRef"
        Me.tbKRef.Size = New System.Drawing.Size(84, 20)
        Me.tbKRef.TabIndex = 23
        Me.tbKRef.Text = "0.9"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 122)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 13)
        Me.Label5.TabIndex = 24
        Me.Label5.Text = "kReflection:"
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btnReset.FlatAppearance.BorderSize = 0
        Me.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnReset.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnReset.Location = New System.Drawing.Point(42, 75)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(85, 31)
        Me.btnReset.TabIndex = 25
        Me.btnReset.Text = "Reset"
        Me.btnReset.UseVisualStyleBackColor = False
        '
        'tbValue
        '
        Me.tbValue.Location = New System.Drawing.Point(76, 26)
        Me.tbValue.Name = "tbValue"
        Me.tbValue.Size = New System.Drawing.Size(42, 20)
        Me.tbValue.TabIndex = 26
        Me.tbValue.Text = "5"
        '
        'displayBox
        '
        Me.displayBox.BackColor = System.Drawing.Color.Black
        Me.displayBox.Location = New System.Drawing.Point(13, 13)
        Me.displayBox.Name = "displayBox"
        Me.displayBox.Size = New System.Drawing.Size(581, 577)
        Me.displayBox.TabIndex = 0
        Me.displayBox.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnSphere)
        Me.GroupBox1.Controls.Add(Me.btnMirror)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Location = New System.Drawing.Point(608, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(172, 122)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add Objects"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.listObject)
        Me.GroupBox2.Location = New System.Drawing.Point(798, 19)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(164, 336)
        Me.GroupBox2.TabIndex = 28
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Object List"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbKA)
        Me.GroupBox3.Controls.Add(Me.kalabel)
        Me.GroupBox3.Controls.Add(Me.kdlabel)
        Me.GroupBox3.Controls.Add(Me.tbKD)
        Me.GroupBox3.Controls.Add(Me.tbKRef)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.kslabel)
        Me.GroupBox3.Controls.Add(Me.tbKS)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbSpecN)
        Me.GroupBox3.Controls.Add(Me.btnChange)
        Me.GroupBox3.Location = New System.Drawing.Point(608, 158)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(172, 197)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Lighting"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label1)
        Me.GroupBox4.Controls.Add(Me.tbValue)
        Me.GroupBox4.Controls.Add(Me.btnForward)
        Me.GroupBox4.Controls.Add(Me.btnBackward)
        Me.GroupBox4.Controls.Add(Me.btnUp)
        Me.GroupBox4.Controls.Add(Me.btnDown)
        Me.GroupBox4.Controls.Add(Me.btnLeft)
        Me.GroupBox4.Controls.Add(Me.btnRight)
        Me.GroupBox4.Location = New System.Drawing.Point(614, 363)
        Me.GroupBox4.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox4.Size = New System.Drawing.Size(334, 141)
        Me.GroupBox4.TabIndex = 30
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Object Translation"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 28)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 27
        Me.Label1.Text = "Distance:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(10, 21)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(37, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Angle:"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.Label3)
        Me.GroupBox5.Controls.Add(Me.tbAngle)
        Me.GroupBox5.Controls.Add(Me.btnRotateX)
        Me.GroupBox5.Controls.Add(Me.btnRotateY)
        Me.GroupBox5.Controls.Add(Me.btnRotateZ)
        Me.GroupBox5.Location = New System.Drawing.Point(614, 517)
        Me.GroupBox5.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox5.Size = New System.Drawing.Size(334, 84)
        Me.GroupBox5.TabIndex = 31
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Mirror Rotation"
        '
        'mainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(973, 614)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.displayBox)
        Me.Name = "mainForm"
        Me.Text = "Hybrid Ray Tracing"
        CType(Me.displayBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSphere As Button
    Friend WithEvents listObject As ListBox
    Friend WithEvents tbKA As TextBox
    Friend WithEvents tbKD As TextBox
    Friend WithEvents tbKS As TextBox
    Friend WithEvents btnChange As Button
    Friend WithEvents tbSpecN As TextBox
    Friend WithEvents btnMirror As Button
    Friend WithEvents btnRight As Button
    Friend WithEvents kalabel As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents kslabel As Label
    Friend WithEvents kdlabel As Label
    Friend WithEvents btnLeft As Button
    Friend WithEvents btnDown As Button
    Friend WithEvents btnUp As Button
    Friend WithEvents btnBackward As Button
    Friend WithEvents btnForward As Button
    Friend WithEvents btnRotateX As Button
    Friend WithEvents btnRotateY As Button
    Friend WithEvents btnRotateZ As Button
    Friend WithEvents tbAngle As TextBox
    Friend WithEvents tbKRef As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnReset As Button
    Friend WithEvents tbValue As TextBox
    Friend WithEvents displayBox As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox5 As GroupBox
End Class

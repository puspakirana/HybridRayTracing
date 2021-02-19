<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mirrorForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.tbMirrorWmax = New System.Windows.Forms.TextBox()
        Me.tbMirrorWmin = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbMirrorZ = New System.Windows.Forms.TextBox()
        Me.tbMirrorY = New System.Windows.Forms.TextBox()
        Me.tbMirrorX = New System.Windows.Forms.TextBox()
        Me.mirrorColor = New System.Windows.Forms.ColorDialog()
        Me.btnColorMirror = New System.Windows.Forms.Button()
        Me.btnCreateMirror = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbMirrorLmax = New System.Windows.Forms.TextBox()
        Me.tbMirrorLmin = New System.Windows.Forms.TextBox()
        Me.rbUp = New System.Windows.Forms.RadioButton()
        Me.rbFront = New System.Windows.Forms.RadioButton()
        Me.rbRight = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbMirrorWmax
        '
        Me.tbMirrorWmax.Location = New System.Drawing.Point(91, 27)
        Me.tbMirrorWmax.Name = "tbMirrorWmax"
        Me.tbMirrorWmax.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorWmax.TabIndex = 0
        Me.tbMirrorWmax.Text = "50"
        '
        'tbMirrorWmin
        '
        Me.tbMirrorWmin.Location = New System.Drawing.Point(91, 53)
        Me.tbMirrorWmin.Name = "tbMirrorWmin"
        Me.tbMirrorWmin.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorWmin.TabIndex = 2
        Me.tbMirrorWmin.Text = "-50"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Width max:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Width min:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(17, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Y:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 85)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(17, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Z:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(17, 13)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "X:"
        '
        'tbMirrorZ
        '
        Me.tbMirrorZ.Location = New System.Drawing.Point(29, 82)
        Me.tbMirrorZ.Name = "tbMirrorZ"
        Me.tbMirrorZ.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorZ.TabIndex = 8
        Me.tbMirrorZ.Text = "0"
        '
        'tbMirrorY
        '
        Me.tbMirrorY.Location = New System.Drawing.Point(29, 56)
        Me.tbMirrorY.Name = "tbMirrorY"
        Me.tbMirrorY.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorY.TabIndex = 7
        Me.tbMirrorY.Text = "-100"
        '
        'tbMirrorX
        '
        Me.tbMirrorX.Location = New System.Drawing.Point(29, 30)
        Me.tbMirrorX.Name = "tbMirrorX"
        Me.tbMirrorX.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorX.TabIndex = 6
        Me.tbMirrorX.Text = "0"
        '
        'btnColorMirror
        '
        Me.btnColorMirror.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnColorMirror.FlatAppearance.BorderSize = 0
        Me.btnColorMirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnColorMirror.Location = New System.Drawing.Point(222, 206)
        Me.btnColorMirror.Name = "btnColorMirror"
        Me.btnColorMirror.Size = New System.Drawing.Size(75, 23)
        Me.btnColorMirror.TabIndex = 12
        Me.btnColorMirror.Text = "Color"
        Me.btnColorMirror.UseVisualStyleBackColor = False
        '
        'btnCreateMirror
        '
        Me.btnCreateMirror.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btnCreateMirror.FlatAppearance.BorderSize = 0
        Me.btnCreateMirror.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCreateMirror.Location = New System.Drawing.Point(313, 206)
        Me.btnCreateMirror.Name = "btnCreateMirror"
        Me.btnCreateMirror.Size = New System.Drawing.Size(75, 23)
        Me.btnCreateMirror.TabIndex = 13
        Me.btnCreateMirror.Text = "Create"
        Me.btnCreateMirror.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(8, 108)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(62, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Length min:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(7, 83)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Length max:"
        '
        'tbMirrorLmax
        '
        Me.tbMirrorLmax.Location = New System.Drawing.Point(91, 80)
        Me.tbMirrorLmax.Name = "tbMirrorLmax"
        Me.tbMirrorLmax.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorLmax.TabIndex = 16
        Me.tbMirrorLmax.Text = "50"
        '
        'tbMirrorLmin
        '
        Me.tbMirrorLmin.Location = New System.Drawing.Point(91, 105)
        Me.tbMirrorLmin.Name = "tbMirrorLmin"
        Me.tbMirrorLmin.Size = New System.Drawing.Size(100, 20)
        Me.tbMirrorLmin.TabIndex = 17
        Me.tbMirrorLmin.Text = "-50"
        '
        'rbUp
        '
        Me.rbUp.AutoSize = True
        Me.rbUp.Location = New System.Drawing.Point(12, 24)
        Me.rbUp.Name = "rbUp"
        Me.rbUp.Size = New System.Drawing.Size(39, 17)
        Me.rbUp.TabIndex = 18
        Me.rbUp.Text = "Up"
        Me.rbUp.UseVisualStyleBackColor = True
        '
        'rbFront
        '
        Me.rbFront.AutoSize = True
        Me.rbFront.Checked = True
        Me.rbFront.Location = New System.Drawing.Point(70, 24)
        Me.rbFront.Name = "rbFront"
        Me.rbFront.Size = New System.Drawing.Size(49, 17)
        Me.rbFront.TabIndex = 19
        Me.rbFront.TabStop = True
        Me.rbFront.Text = "Front"
        Me.rbFront.UseVisualStyleBackColor = True
        '
        'rbRight
        '
        Me.rbRight.AutoSize = True
        Me.rbRight.Location = New System.Drawing.Point(134, 24)
        Me.rbRight.Name = "rbRight"
        Me.rbRight.Size = New System.Drawing.Size(50, 17)
        Me.rbRight.TabIndex = 20
        Me.rbRight.Text = "Right"
        Me.rbRight.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbUp)
        Me.GroupBox1.Controls.Add(Me.rbRight)
        Me.GroupBox1.Controls.Add(Me.rbFront)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 172)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(197, 57)
        Me.GroupBox1.TabIndex = 21
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Orientation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.tbMirrorX)
        Me.GroupBox2.Controls.Add(Me.tbMirrorY)
        Me.GroupBox2.Controls.Add(Me.tbMirrorZ)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(222, 20)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(166, 141)
        Me.GroupBox2.TabIndex = 21
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Position"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.tbMirrorWmin)
        Me.GroupBox3.Controls.Add(Me.tbMirrorWmax)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.tbMirrorLmin)
        Me.GroupBox3.Controls.Add(Me.Label2)
        Me.GroupBox3.Controls.Add(Me.tbMirrorLmax)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 20)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox3.Size = New System.Drawing.Size(197, 141)
        Me.GroupBox3.TabIndex = 22
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Properties"
        '
        'mirrorForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(401, 243)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnCreateMirror)
        Me.Controls.Add(Me.btnColorMirror)
        Me.Name = "mirrorForm"
        Me.Text = "New Mirror"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents tbMirrorWmax As TextBox
    Friend WithEvents tbMirrorWmin As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents tbMirrorZ As TextBox
    Friend WithEvents tbMirrorY As TextBox
    Friend WithEvents tbMirrorX As TextBox
    Friend WithEvents mirrorColor As ColorDialog
    Friend WithEvents btnColorMirror As Button
    Friend WithEvents btnCreateMirror As Button
    Friend WithEvents Label7 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbMirrorLmax As TextBox
    Friend WithEvents tbMirrorLmin As TextBox
    Friend WithEvents rbUp As RadioButton
    Friend WithEvents rbFront As RadioButton
    Friend WithEvents rbRight As RadioButton
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
End Class

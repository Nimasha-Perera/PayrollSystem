<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employeeEdit
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
        Me.Button3 = New System.Windows.Forms.Button()
        Me.txtDob = New System.Windows.Forms.DateTimePicker()
        Me.txtDoj = New System.Windows.Forms.DateTimePicker()
        Me.empgender = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.empphoto = New System.Windows.Forms.PictureBox()
        Me.empsalary = New System.Windows.Forms.TextBox()
        Me.empdepartment = New System.Windows.Forms.TextBox()
        Me.empcat = New System.Windows.Forms.TextBox()
        Me.emptelno = New System.Windows.Forms.TextBox()
        Me.empaddress = New System.Windows.Forms.TextBox()
        Me.emplastname = New System.Windows.Forms.TextBox()
        Me.empfirstname = New System.Windows.Forms.TextBox()
        Me.empno = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(1007, 522)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 58
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(324, 508)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(246, 22)
        Me.txtDob.TabIndex = 57
        '
        'txtDoj
        '
        Me.txtDoj.Location = New System.Drawing.Point(324, 596)
        Me.txtDoj.Name = "txtDoj"
        Me.txtDoj.Size = New System.Drawing.Size(246, 22)
        Me.txtDoj.TabIndex = 56
        '
        'empgender
        '
        Me.empgender.FormattingEnabled = True
        Me.empgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.empgender.Location = New System.Drawing.Point(324, 417)
        Me.empgender.Name = "empgender"
        Me.empgender.Size = New System.Drawing.Size(246, 24)
        Me.empgender.TabIndex = 55
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(213, 44)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(154, 36)
        Me.Label13.TabIndex = 54
        Me.Label13.Text = "Employee "
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(859, 619)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 51)
        Me.Button2.TabIndex = 53
        Me.Button2.Text = "Delete"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(704, 619)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 51)
        Me.Button1.TabIndex = 52
        Me.Button1.Text = "Edit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'empphoto
        '
        Me.empphoto.Location = New System.Drawing.Point(808, 254)
        Me.empphoto.Name = "empphoto"
        Me.empphoto.Size = New System.Drawing.Size(274, 249)
        Me.empphoto.TabIndex = 51
        Me.empphoto.TabStop = False
        '
        'empsalary
        '
        Me.empsalary.Location = New System.Drawing.Point(808, 181)
        Me.empsalary.Name = "empsalary"
        Me.empsalary.Size = New System.Drawing.Size(274, 22)
        Me.empsalary.TabIndex = 50
        '
        'empdepartment
        '
        Me.empdepartment.Location = New System.Drawing.Point(808, 126)
        Me.empdepartment.Name = "empdepartment"
        Me.empdepartment.Size = New System.Drawing.Size(274, 22)
        Me.empdepartment.TabIndex = 49
        '
        'empcat
        '
        Me.empcat.Location = New System.Drawing.Point(324, 553)
        Me.empcat.Name = "empcat"
        Me.empcat.Size = New System.Drawing.Size(246, 22)
        Me.empcat.TabIndex = 48
        '
        'emptelno
        '
        Me.emptelno.Location = New System.Drawing.Point(324, 459)
        Me.emptelno.Name = "emptelno"
        Me.emptelno.Size = New System.Drawing.Size(246, 22)
        Me.emptelno.TabIndex = 47
        '
        'empaddress
        '
        Me.empaddress.Location = New System.Drawing.Point(324, 274)
        Me.empaddress.Multiline = True
        Me.empaddress.Name = "empaddress"
        Me.empaddress.Size = New System.Drawing.Size(246, 110)
        Me.empaddress.TabIndex = 46
        '
        'emplastname
        '
        Me.emplastname.Location = New System.Drawing.Point(324, 224)
        Me.emplastname.Name = "emplastname"
        Me.emplastname.Size = New System.Drawing.Size(246, 22)
        Me.emplastname.TabIndex = 45
        '
        'empfirstname
        '
        Me.empfirstname.Location = New System.Drawing.Point(324, 179)
        Me.empfirstname.Name = "empfirstname"
        Me.empfirstname.Size = New System.Drawing.Size(246, 22)
        Me.empfirstname.TabIndex = 44
        '
        'empno
        '
        Me.empno.Location = New System.Drawing.Point(324, 136)
        Me.empno.Name = "empno"
        Me.empno.Size = New System.Drawing.Size(246, 22)
        Me.empno.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(671, 254)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 42
        Me.Label12.Text = "Photo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(670, 184)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 41
        Me.Label11.Text = "salary"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(667, 129)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 40
        Me.Label10.Text = "Department"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(216, 601)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "Date of Join"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(216, 558)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Category"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 513)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 37
        Me.Label7.Text = "Date of Birth"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(216, 464)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 36
        Me.Label6.Text = "Tel No"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(216, 420)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Gender"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(216, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 34
        Me.Label4.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(216, 229)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 33
        Me.Label3.Text = "LastName"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(216, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "FirstName"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(216, 141)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "EmpNo"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(674, 580)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 59
        Me.Button4.Text = "First"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(794, 580)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 60
        Me.Button5.Text = "<<"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(904, 580)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 61
        Me.Button6.Text = ">>"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Location = New System.Drawing.Point(1007, 580)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(75, 23)
        Me.Button7.TabIndex = 62
        Me.Button7.Text = "Last"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'Button8
        '
        Me.Button8.Location = New System.Drawing.Point(992, 619)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(90, 51)
        Me.Button8.TabIndex = 63
        Me.Button8.Text = "Cancel"
        Me.Button8.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(667, 44)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(129, 36)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Label14"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'employeeEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1202, 719)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.txtDob)
        Me.Controls.Add(Me.txtDoj)
        Me.Controls.Add(Me.empgender)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.empphoto)
        Me.Controls.Add(Me.empsalary)
        Me.Controls.Add(Me.empdepartment)
        Me.Controls.Add(Me.empcat)
        Me.Controls.Add(Me.emptelno)
        Me.Controls.Add(Me.empaddress)
        Me.Controls.Add(Me.emplastname)
        Me.Controls.Add(Me.empfirstname)
        Me.Controls.Add(Me.empno)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "employeeEdit"
        Me.Text = "employeeEdit"
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents txtDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents empgender As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents empphoto As System.Windows.Forms.PictureBox
    Friend WithEvents empsalary As System.Windows.Forms.TextBox
    Friend WithEvents empdepartment As System.Windows.Forms.TextBox
    Friend WithEvents empcat As System.Windows.Forms.TextBox
    Friend WithEvents emptelno As System.Windows.Forms.TextBox
    Friend WithEvents empaddress As System.Windows.Forms.TextBox
    Friend WithEvents emplastname As System.Windows.Forms.TextBox
    Friend WithEvents empfirstname As System.Windows.Forms.TextBox
    Friend WithEvents empno As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents Button8 As System.Windows.Forms.Button
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

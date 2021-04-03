<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class employee
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.empno = New System.Windows.Forms.TextBox()
        Me.empfirstname = New System.Windows.Forms.TextBox()
        Me.emplastname = New System.Windows.Forms.TextBox()
        Me.empaddress = New System.Windows.Forms.TextBox()
        Me.emptelno = New System.Windows.Forms.TextBox()
        Me.empcat = New System.Windows.Forms.TextBox()
        Me.empdepartment = New System.Windows.Forms.TextBox()
        Me.empsalary = New System.Windows.Forms.TextBox()
        Me.empphoto = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.empgender = New System.Windows.Forms.ComboBox()
        Me.txtDoj = New System.Windows.Forms.DateTimePicker()
        Me.txtDob = New System.Windows.Forms.DateTimePicker()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(180, 150)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "EmpNo"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(180, 193)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "FirstName"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(180, 238)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "LastName"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(180, 288)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Address"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(180, 429)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(180, 473)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(50, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Tel No"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(177, 522)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(87, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Date of Birth"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(180, 567)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(65, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Category"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(180, 610)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(84, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Date of Join"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(580, 150)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Department"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(580, 193)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(46, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "salary"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(580, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(45, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Photo"
        '
        'empno
        '
        Me.empno.Location = New System.Drawing.Point(288, 145)
        Me.empno.Name = "empno"
        Me.empno.Size = New System.Drawing.Size(246, 22)
        Me.empno.TabIndex = 12
        '
        'empfirstname
        '
        Me.empfirstname.Location = New System.Drawing.Point(288, 188)
        Me.empfirstname.Name = "empfirstname"
        Me.empfirstname.Size = New System.Drawing.Size(246, 22)
        Me.empfirstname.TabIndex = 13
        '
        'emplastname
        '
        Me.emplastname.Location = New System.Drawing.Point(288, 233)
        Me.emplastname.Name = "emplastname"
        Me.emplastname.Size = New System.Drawing.Size(246, 22)
        Me.emplastname.TabIndex = 14
        '
        'empaddress
        '
        Me.empaddress.Location = New System.Drawing.Point(288, 283)
        Me.empaddress.Multiline = True
        Me.empaddress.Name = "empaddress"
        Me.empaddress.Size = New System.Drawing.Size(246, 110)
        Me.empaddress.TabIndex = 15
        '
        'emptelno
        '
        Me.emptelno.Location = New System.Drawing.Point(288, 468)
        Me.emptelno.Name = "emptelno"
        Me.emptelno.Size = New System.Drawing.Size(246, 22)
        Me.emptelno.TabIndex = 17
        '
        'empcat
        '
        Me.empcat.Location = New System.Drawing.Point(288, 562)
        Me.empcat.Name = "empcat"
        Me.empcat.Size = New System.Drawing.Size(246, 22)
        Me.empcat.TabIndex = 19
        '
        'empdepartment
        '
        Me.empdepartment.Location = New System.Drawing.Point(679, 145)
        Me.empdepartment.Name = "empdepartment"
        Me.empdepartment.Size = New System.Drawing.Size(274, 22)
        Me.empdepartment.TabIndex = 21
        '
        'empsalary
        '
        Me.empsalary.Location = New System.Drawing.Point(679, 188)
        Me.empsalary.Name = "empsalary"
        Me.empsalary.Size = New System.Drawing.Size(274, 22)
        Me.empsalary.TabIndex = 22
        '
        'empphoto
        '
        Me.empphoto.Location = New System.Drawing.Point(679, 265)
        Me.empphoto.Name = "empphoto"
        Me.empphoto.Size = New System.Drawing.Size(274, 249)
        Me.empphoto.TabIndex = 23
        Me.empphoto.TabStop = False
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(679, 576)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 51)
        Me.Button1.TabIndex = 24
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(851, 576)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 51)
        Me.Button2.TabIndex = 25
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Navy
        Me.Label13.Location = New System.Drawing.Point(490, 55)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(314, 36)
        Me.Label13.TabIndex = 26
        Me.Label13.Text = "Employee Registration"
        '
        'empgender
        '
        Me.empgender.FormattingEnabled = True
        Me.empgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.empgender.Location = New System.Drawing.Point(288, 426)
        Me.empgender.Name = "empgender"
        Me.empgender.Size = New System.Drawing.Size(246, 24)
        Me.empgender.TabIndex = 27
        '
        'txtDoj
        '
        Me.txtDoj.Location = New System.Drawing.Point(288, 605)
        Me.txtDoj.Name = "txtDoj"
        Me.txtDoj.Size = New System.Drawing.Size(246, 22)
        Me.txtDoj.TabIndex = 28
        '
        'txtDob
        '
        Me.txtDob.Location = New System.Drawing.Point(288, 517)
        Me.txtDob.Name = "txtDob"
        Me.txtDob.Size = New System.Drawing.Size(246, 22)
        Me.txtDob.TabIndex = 29
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(878, 531)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 30
        Me.Button3.Text = "Browse"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'employee
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1220, 712)
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
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "employee"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Employee Register"
        CType(Me.empphoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents empno As System.Windows.Forms.TextBox
    Friend WithEvents empfirstname As System.Windows.Forms.TextBox
    Friend WithEvents emplastname As System.Windows.Forms.TextBox
    Friend WithEvents empaddress As System.Windows.Forms.TextBox
    Friend WithEvents emptelno As System.Windows.Forms.TextBox
    Friend WithEvents empcat As System.Windows.Forms.TextBox
    Friend WithEvents empdepartment As System.Windows.Forms.TextBox
    Friend WithEvents empsalary As System.Windows.Forms.TextBox
    Friend WithEvents empphoto As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents empgender As System.Windows.Forms.ComboBox
    Friend WithEvents txtDoj As System.Windows.Forms.DateTimePicker
    Friend WithEvents txtDob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

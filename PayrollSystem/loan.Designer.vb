<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class loan
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
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtempno = New System.Windows.Forms.ComboBox()
        Me.txtinamount = New System.Windows.Forms.TextBox()
        Me.txttotalamount = New System.Windows.Forms.TextBox()
        Me.txtinterest = New System.Windows.Forms.TextBox()
        Me.txtamount = New System.Windows.Forms.TextBox()
        Me.txtempname = New System.Windows.Forms.TextBox()
        Me.txtcategory = New System.Windows.Forms.TextBox()
        Me.txtdept = New System.Windows.Forms.TextBox()
        Me.txtauthor = New System.Windows.Forms.TextBox()
        Me.txtissue = New System.Windows.Forms.DateTimePicker()
        Me.txteffect = New System.Windows.Forms.DateTimePicker()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.txtinstall = New System.Windows.Forms.TextBox()
        Me.txtbal = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txttot = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtdes = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(52, 109)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Emp no"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(52, 155)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Emp Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(52, 201)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Category"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(52, 244)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(82, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Department"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(52, 298)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Issue Date"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(52, 348)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(94, 17)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Effected Date"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(52, 398)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(50, 17)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Author"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(52, 446)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(115, 17)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Long Description"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(52, 499)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 17)
        Me.Label9.TabIndex = 8
        Me.Label9.Text = "Loan Amount"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(52, 546)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(89, 17)
        Me.Label10.TabIndex = 9
        Me.Label10.Text = "Interest Rate"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(513, 150)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 17)
        Me.Label11.TabIndex = 10
        Me.Label11.Text = "Interest Amount"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(513, 206)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 17)
        Me.Label12.TabIndex = 11
        Me.Label12.Text = "Total Amount"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(513, 329)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(59, 17)
        Me.Label15.TabIndex = 14
        Me.Label15.Text = "Balance"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(513, 267)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(75, 17)
        Me.Label16.TabIndex = 15
        Me.Label16.Text = "Installment"
        '
        'txtempno
        '
        Me.txtempno.FormattingEnabled = True
        Me.txtempno.Location = New System.Drawing.Point(191, 102)
        Me.txtempno.Name = "txtempno"
        Me.txtempno.Size = New System.Drawing.Size(260, 24)
        Me.txtempno.TabIndex = 16
        '
        'txtinamount
        '
        Me.txtinamount.Location = New System.Drawing.Point(691, 150)
        Me.txtinamount.Name = "txtinamount"
        Me.txtinamount.Size = New System.Drawing.Size(224, 22)
        Me.txtinamount.TabIndex = 17
        '
        'txttotalamount
        '
        Me.txttotalamount.Location = New System.Drawing.Point(691, 201)
        Me.txttotalamount.Name = "txttotalamount"
        Me.txttotalamount.Size = New System.Drawing.Size(224, 22)
        Me.txttotalamount.TabIndex = 18
        '
        'txtinterest
        '
        Me.txtinterest.Location = New System.Drawing.Point(191, 546)
        Me.txtinterest.Name = "txtinterest"
        Me.txtinterest.Size = New System.Drawing.Size(260, 22)
        Me.txtinterest.TabIndex = 19
        '
        'txtamount
        '
        Me.txtamount.Location = New System.Drawing.Point(191, 494)
        Me.txtamount.Name = "txtamount"
        Me.txtamount.Size = New System.Drawing.Size(260, 22)
        Me.txtamount.TabIndex = 20
        '
        'txtempname
        '
        Me.txtempname.Location = New System.Drawing.Point(191, 150)
        Me.txtempname.Name = "txtempname"
        Me.txtempname.Size = New System.Drawing.Size(260, 22)
        Me.txtempname.TabIndex = 21
        '
        'txtcategory
        '
        Me.txtcategory.Location = New System.Drawing.Point(191, 196)
        Me.txtcategory.Name = "txtcategory"
        Me.txtcategory.Size = New System.Drawing.Size(260, 22)
        Me.txtcategory.TabIndex = 22
        '
        'txtdept
        '
        Me.txtdept.Location = New System.Drawing.Point(191, 244)
        Me.txtdept.Name = "txtdept"
        Me.txtdept.Size = New System.Drawing.Size(260, 22)
        Me.txtdept.TabIndex = 23
        '
        'txtauthor
        '
        Me.txtauthor.Location = New System.Drawing.Point(191, 395)
        Me.txtauthor.Name = "txtauthor"
        Me.txtauthor.Size = New System.Drawing.Size(260, 22)
        Me.txtauthor.TabIndex = 25
        '
        'txtissue
        '
        Me.txtissue.Location = New System.Drawing.Point(191, 293)
        Me.txtissue.Name = "txtissue"
        Me.txtissue.Size = New System.Drawing.Size(260, 22)
        Me.txtissue.TabIndex = 26
        '
        'txteffect
        '
        Me.txteffect.Location = New System.Drawing.Point(191, 343)
        Me.txteffect.Name = "txteffect"
        Me.txteffect.Size = New System.Drawing.Size(260, 22)
        Me.txteffect.TabIndex = 27
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(516, 102)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(306, 21)
        Me.CheckBox1.TabIndex = 28
        Me.CheckBox1.Text = "Interest Calculation for the amount of Bonus"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'txtinstall
        '
        Me.txtinstall.Location = New System.Drawing.Point(691, 262)
        Me.txtinstall.Name = "txtinstall"
        Me.txtinstall.Size = New System.Drawing.Size(224, 22)
        Me.txtinstall.TabIndex = 29
        '
        'txtbal
        '
        Me.txtbal.Location = New System.Drawing.Point(691, 324)
        Me.txtbal.Name = "txtbal"
        Me.txtbal.Size = New System.Drawing.Size(224, 22)
        Me.txtbal.TabIndex = 30
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(513, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(107, 43)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = "Cal"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(828, 392)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 49)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "OK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(983, 109)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(453, 237)
        Me.DataGridView1.TabIndex = 33
        '
        'txttot
        '
        Me.txttot.Location = New System.Drawing.Point(1199, 377)
        Me.txttot.Name = "txttot"
        Me.txttot.Size = New System.Drawing.Size(237, 22)
        Me.txttot.TabIndex = 34
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(980, 382)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Total"
        '
        'txtdes
        '
        Me.txtdes.FormattingEnabled = True
        Me.txtdes.Location = New System.Drawing.Point(191, 439)
        Me.txtdes.Name = "txtdes"
        Me.txtdes.Size = New System.Drawing.Size(260, 24)
        Me.txtdes.TabIndex = 36
        '
        'loan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1483, 671)
        Me.Controls.Add(Me.txtdes)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txttot)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtbal)
        Me.Controls.Add(Me.txtinstall)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.txteffect)
        Me.Controls.Add(Me.txtissue)
        Me.Controls.Add(Me.txtauthor)
        Me.Controls.Add(Me.txtdept)
        Me.Controls.Add(Me.txtcategory)
        Me.Controls.Add(Me.txtempname)
        Me.Controls.Add(Me.txtamount)
        Me.Controls.Add(Me.txtinterest)
        Me.Controls.Add(Me.txttotalamount)
        Me.Controls.Add(Me.txtinamount)
        Me.Controls.Add(Me.txtempno)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
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
        Me.Name = "loan"
        Me.Text = "loan"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents txtempno As System.Windows.Forms.ComboBox
    Friend WithEvents txtinamount As System.Windows.Forms.TextBox
    Friend WithEvents txttotalamount As System.Windows.Forms.TextBox
    Friend WithEvents txtinterest As System.Windows.Forms.TextBox
    Friend WithEvents txtamount As System.Windows.Forms.TextBox
    Friend WithEvents txtempname As System.Windows.Forms.TextBox
    Friend WithEvents txtcategory As System.Windows.Forms.TextBox
    Friend WithEvents txtdept As System.Windows.Forms.TextBox
    Friend WithEvents txtauthor As System.Windows.Forms.TextBox
    Friend WithEvents txtissue As System.Windows.Forms.DateTimePicker
    Friend WithEvents txteffect As System.Windows.Forms.DateTimePicker
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents txtinstall As System.Windows.Forms.TextBox
    Friend WithEvents txtbal As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents txttot As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txtdes As System.Windows.Forms.ComboBox
End Class

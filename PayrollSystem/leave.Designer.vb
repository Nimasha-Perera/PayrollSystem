<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class leave
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
        Me.txtcasual = New System.Windows.Forms.NumericUpDown()
        Me.txtannual = New System.Windows.Forms.NumericUpDown()
        Me.txtmedical = New System.Windows.Forms.NumericUpDown()
        Me.txtyear = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.txtcasual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtannual, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtmedical, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(169, 134)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(94, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Casual Leave"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(169, 202)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Annual Leave"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(169, 272)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(99, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Medical Leave"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(169, 340)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(38, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Year"
        '
        'txtcasual
        '
        Me.txtcasual.Location = New System.Drawing.Point(350, 129)
        Me.txtcasual.Name = "txtcasual"
        Me.txtcasual.Size = New System.Drawing.Size(157, 22)
        Me.txtcasual.TabIndex = 4
        '
        'txtannual
        '
        Me.txtannual.Location = New System.Drawing.Point(350, 197)
        Me.txtannual.Name = "txtannual"
        Me.txtannual.Size = New System.Drawing.Size(157, 22)
        Me.txtannual.TabIndex = 5
        '
        'txtmedical
        '
        Me.txtmedical.Location = New System.Drawing.Point(350, 267)
        Me.txtmedical.Name = "txtmedical"
        Me.txtmedical.Size = New System.Drawing.Size(157, 22)
        Me.txtmedical.TabIndex = 6
        '
        'txtyear
        '
        Me.txtyear.Location = New System.Drawing.Point(350, 335)
        Me.txtyear.Name = "txtyear"
        Me.txtyear.Size = New System.Drawing.Size(157, 22)
        Me.txtyear.TabIndex = 7
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(172, 417)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 46)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(384, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(102, 46)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Cancel"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'leave
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(793, 691)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtyear)
        Me.Controls.Add(Me.txtmedical)
        Me.Controls.Add(Me.txtannual)
        Me.Controls.Add(Me.txtcasual)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "leave"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "leave"
        CType(Me.txtcasual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtannual, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtmedical, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtcasual As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtannual As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtmedical As System.Windows.Forms.NumericUpDown
    Friend WithEvents txtyear As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
End Class

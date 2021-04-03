<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeRegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeEditToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AllowanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeductionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LeaveDetailsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmployeeLeavesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.EmployeeDetailsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(650, 28)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.EmployeeRegistrationToolStripMenuItem, Me.EmployeeEditToolStripMenuItem, Me.AllowanceToolStripMenuItem, Me.DeductionToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(42, 24)
        Me.FileToolStripMenuItem.Text = "file"
        '
        'EmployeeRegistrationToolStripMenuItem
        '
        Me.EmployeeRegistrationToolStripMenuItem.Name = "EmployeeRegistrationToolStripMenuItem"
        Me.EmployeeRegistrationToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EmployeeRegistrationToolStripMenuItem.Text = "Employee registration"
        '
        'EmployeeEditToolStripMenuItem
        '
        Me.EmployeeEditToolStripMenuItem.Name = "EmployeeEditToolStripMenuItem"
        Me.EmployeeEditToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.EmployeeEditToolStripMenuItem.Text = "Employee edit"
        '
        'AllowanceToolStripMenuItem
        '
        Me.AllowanceToolStripMenuItem.Name = "AllowanceToolStripMenuItem"
        Me.AllowanceToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.AllowanceToolStripMenuItem.Text = "Allowance"
        '
        'DeductionToolStripMenuItem
        '
        Me.DeductionToolStripMenuItem.Name = "DeductionToolStripMenuItem"
        Me.DeductionToolStripMenuItem.Size = New System.Drawing.Size(230, 26)
        Me.DeductionToolStripMenuItem.Text = "Deduction"
        '
        'EmployeeDetailsToolStripMenuItem
        '
        Me.EmployeeDetailsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LeaveDetailsToolStripMenuItem, Me.EmployeeLeavesToolStripMenuItem})
        Me.EmployeeDetailsToolStripMenuItem.Name = "EmployeeDetailsToolStripMenuItem"
        Me.EmployeeDetailsToolStripMenuItem.Size = New System.Drawing.Size(87, 24)
        Me.EmployeeDetailsToolStripMenuItem.Text = "Employee"
        '
        'LeaveDetailsToolStripMenuItem
        '
        Me.LeaveDetailsToolStripMenuItem.Name = "LeaveDetailsToolStripMenuItem"
        Me.LeaveDetailsToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.LeaveDetailsToolStripMenuItem.Text = "leave details"
        '
        'EmployeeLeavesToolStripMenuItem
        '
        Me.EmployeeLeavesToolStripMenuItem.Name = "EmployeeLeavesToolStripMenuItem"
        Me.EmployeeLeavesToolStripMenuItem.Size = New System.Drawing.Size(195, 26)
        Me.EmployeeLeavesToolStripMenuItem.Text = "employee leaves"
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 441)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Main"
        Me.Text = "Main"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeRegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeEditToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AllowanceToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeductionToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LeaveDetailsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmployeeLeavesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

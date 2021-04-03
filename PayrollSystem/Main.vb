Public Class Main

    Private Sub EmployeeRegistrationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeRegistrationToolStripMenuItem.Click
        Dim em As employee = New employee
        em.MdiParent = Me
        em.Show()



    End Sub

    Private Sub EmployeeEditToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeEditToolStripMenuItem.Click
        Dim em As employeeEdit = New employeeEdit
        em.MdiParent = Me
        em.Show()
    End Sub

    Private Sub AllowanceToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllowanceToolStripMenuItem.Click
        Dim em As allowance_details = New allowance_details
        em.MdiParent = Me
        em.Show()
    End Sub

    Private Sub DeductionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeductionToolStripMenuItem.Click
        Dim em As Deduction_details = New Deduction_details
        em.MdiParent = Me
        em.Show()
    End Sub

    Private Sub LeaveDetailsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeaveDetailsToolStripMenuItem.Click
        Dim em As leave = New leave
        em.MdiParent = Me
        em.Show()
    End Sub

    Private Sub EmployeeLeavesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EmployeeLeavesToolStripMenuItem.Click
        Dim em As leave_details = New leave_details
        em.MdiParent = Me
        em.Show()
    End Sub
End Class
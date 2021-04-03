Imports System.Data.SqlClient



Public Class leave_details
    Dim rdead As SqlDataReader
    Dim i As Integer
    Dim casual, annual, medical, nopay As Decimal
    Dim reason As String
    Dim ds As DataSet

    Private Sub binding()
        ConnDb()

        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from employee_details", con)
        Dim da1 As SqlDataAdapter = New SqlDataAdapter("select * from leavedetails", con)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter("select * from leave", con)
        ds = New DataSet
        da.Fill(ds, "employee_details")
        da1.Fill(ds, "leavedetails")
        da2.Fill(ds, "leave")




    End Sub





    Private Sub leave_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        binding()
        txtempid.Items.Clear()
        txtempid.DataSource = ds.Tables("employee_details")
        txtempid.DisplayMember = ("empno")
        txtfromdate.Value = Today
        txttodate.Value = Today
        con.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtempid.SelectedIndexChanged
        If (txtempid.Text = "System.Data.DataRowView") Then
            Exit Sub
        End If

        Try

      


        con.Close()
        Dim cmd As SqlCommand = New SqlCommand
        cmd.Connection = con
        cmd.CommandText = ("Select * from employee_details where empno='" & txtempid.Text.Trim & "'")
        con.Open()
        rdead = cmd.ExecuteReader
        Do While rdead.Read
            txtempname.Text = rdead.GetValue(1) & " " & rdead.GetValue(2)
            txtcategory.Text = rdead.GetValue(7)
            txtdept.Text = rdead.GetValue(9)
                con.Close()
                Exit Try
        Loop
        MessageBox.Show("Invalid Employee Code")
        txtempid.Text = ""
        txtempid.Focus()
        con.Close()


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try






        Try
            Dim cmdcas As SqlCommand = New SqlCommand
            cmdcas.Connection = con
            cmdcas.CommandText = "select casual from leave where empid= '" & txtempid.Text.Trim & "' And lastyear ='" & CStr(Year(Today)) & "'"
            con.Open()
            rdead = cmdcas.ExecuteReader
            Do While rdead.Read
                casual = rdead.GetValue(0)

                If (casual > 0) Then
                    RadioButton1.Enabled = True
                Else
                    RadioButton1.Enabled = False
                End If
                con.Close()
                Exit Do
            Loop
            con.Close()

            Dim cmdannual As SqlCommand = New SqlCommand
            cmdannual.Connection = con
            cmdannual.CommandText = "select annual from leave where empid= '" & txtempid.Text.Trim & "' And lastyear ='" & CStr(Year(Today)) & "'"
            con.Open()
            rdead = cmdannual.ExecuteReader
            Do While rdead.Read
                annual = rdead.GetValue(0)

                If (annual > 0) Then
                    RadioButton2.Enabled = True
                Else
                    RadioButton2.Enabled = False
                End If
                con.Close()
                Exit Do
            Loop
            con.Close()

            Dim cmdmedical As SqlCommand = New SqlCommand
            cmdmedical.Connection = con
            cmdmedical.CommandText = "select medical from leave where empid= '" & txtempid.Text.Trim & "' And lastyear ='" & CStr(Year(Today)) & "'"
            con.Open()
            rdead = cmdmedical.ExecuteReader
            Do While rdead.Read
                medical = rdead.GetValue(0)

                If (medical > 0) Then
                    RadioButton3.Enabled = True
                Else
                    RadioButton3.Enabled = False
                End If
                con.Close()
                Exit Do
            Loop
            con.Close()



            Dim cmdnopay As SqlCommand = New SqlCommand
            cmdnopay.Connection = con
            cmdnopay.CommandText = "select nopay from leave where empid= '" & txtempid.Text.Trim & "' And lastyear ='" & CStr(Year(Today)) & "'"
            con.Open()
            rdead = cmdnopay.ExecuteReader
            Do While rdead.Read
                nopay = rdead.GetValue(0)

                
                con.Close()
                Exit Do
            Loop
            con.Close()






        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try








    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim balleave As Decimal
        Try
            If (RadioButton1.Checked = True) Then
                balleave = casual - CDec(txtdays.Text)

                If (balleave < 0) Then
                    MessageBox.Show("You Have A casual Leave" & casual & "Days Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If

            ElseIf (RadioButton2.Checked = True) Then
                balleave = annual - CDec(txtdays.Text)

                If (balleave < 0) Then
                    MessageBox.Show("You Have a annual Leave" & annual & "Days Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


            ElseIf (RadioButton3.Checked = True) Then
                balleave = medical - CDec(txtdays.Text)

                If (balleave < 0) Then
                    MessageBox.Show("You Have a annual Leave" & medical & "Days Only", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    Exit Sub
                End If


            ElseIf (RadioButton4.Checked = True) Then
                balleave = nopay - CDec(txtdays.Text)






              
                End If






         







        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try



            Dim comloan As SqlCommand = New SqlCommand
            comloan.Connection = con
            If (RadioButton1.Checked = True) Then
                comloan.CommandText = "Update leave set casual=@casual where empid = @empid and lastyear='" & CStr(Year(Today)) & "'"
                comloan.Parameters.Add("@casual", balleave)


            ElseIf (RadioButton2.Checked = True) Then
                comloan.CommandText = "Update leave set annual=@annual where empid = @empid and lastyear='" & CStr(Year(Today)) & "'"
                comloan.Parameters.Add("@annual", balleave)

            ElseIf (RadioButton3.Checked = True) Then
                comloan.CommandText = "Update leave set medical=@medical where empid = @empid and lastyear='" & CStr(Year(Today)) & "'"
                comloan.Parameters.Add("@medical", balleave)

            ElseIf (RadioButton4.Checked = True) Then
                comloan.CommandText = "Update leave set nopay=@nopay where empid = @empid and lastyear='" & CStr(Year(Today)) & "'"
                comloan.Parameters.Add("@nopay", balleave)

            End If
            comloan.Parameters.Add("@empid", txtempid.Text)
            con.Open()
            comloan.ExecuteNonQuery()
            con.Close()





        Catch ex As Exception



            MessageBox.Show("Please select the leave Type ", "Error ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub



        End Try



        Try
            Dim com1 As SqlCommand = New SqlCommand
            com1.Connection = con
            com1.CommandText = "insert into leavedetails (empid,empname,category,dept,reason,fromdate,todate,nodays)values (@empid,@empname,@category,@dept,@reason,@fromdate,@todate,@nodays) "
            com1.Parameters.Add("@empid", txtempid.Text)
            com1.Parameters.Add("@empname", txtempname.Text)
            com1.Parameters.Add("@category", txtcategory.Text)
            com1.Parameters.Add("@dept", txtdept.Text)
            com1.Parameters.Add("@reason", reason)
            com1.Parameters.Add("@fromdate", txtfromdate.Value)
            com1.Parameters.Add("@todate", txttodate.Value)
            com1.Parameters.Add("@nodays", DateDiff(DateInterval.Day, txtfromdate.Value.Date, txttodate.Value))
            con.Open()

            com1.ExecuteNonQuery()
            con.Close()





        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Leave Accepted", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)








    End Sub

    Private Sub txtempname_TextChanged(sender As Object, e As EventArgs) Handles txtempname.TextChanged

    End Sub

    Private Sub txtfromdate_ValueChanged(sender As Object, e As EventArgs) Handles txtfromdate.ValueChanged
        txtdays.Text = DateDiff(DateInterval.Day, txtfromdate.Value.Date, txttodate.Value)
    End Sub

    Private Sub txttodate_ValueChanged(sender As Object, e As EventArgs) Handles txttodate.ValueChanged
        txtdays.Text = DateDiff(DateInterval.Day, txtfromdate.Value.Date, txttodate.Value)
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If (RadioButton2.Checked = True) Then
            reason = "annual"
        End If
    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If (RadioButton3.Checked = True) Then
            reason = "medical"
        End If
    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If (RadioButton4.Checked = True) Then
            reason = "nopay"
        End If
    End Sub
End Class
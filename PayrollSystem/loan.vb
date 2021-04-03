
Imports System.Data.SqlClient




Public Class loan
    Dim ds As DataSet
    Dim ds1 As DataSet
    Dim dread As SqlDataReader
    Dim amo As Decimal



    Private Sub binding()
        ConnDb()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from employee_details", con)
        Dim da1 As SqlDataAdapter = New SqlDataAdapter("select * from temp_loan", con)
        Dim da2 As SqlDataAdapter = New SqlDataAdapter("select * from loan_details", con)
        Dim da3 As SqlDataAdapter = New SqlDataAdapter("select amount,installment_date from temp_loan", con)
        ds = New DataSet
        ds1 = New DataSet
        da.Fill(ds, "employee_details")
        da1.Fill(ds, "temp_loan")
        da2.Fill(ds, "loan_details")
        da3.Fill(ds1, "temp_loan")


        Try
            txtempno.Items.Clear()

            Dim cmd As SqlCommand = New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "select loandes from loan_details"
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtdes.Items.Add(dread.GetValue(0))
            Loop
            txtempno.Items.Clear()
            txtempno.DataSource = ds.Tables("employee_details")
            txtempno.DisplayMember = ("empno")

        Catch ex As Exception
            con.Close()
            MessageBox.Show(ex.Message)
        End Try




    End Sub


    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub loan_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        binding()
    End Sub

    Private Sub txtempno_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtempno.SelectedIndexChanged
        Try

       
        If (txtempno.Text = "System.data.DataRowView") Then
            Exit Sub






        End If
        con.Close()
        Dim com As SqlCommand = New SqlCommand
        con.Open()
        com.Connection = con
        com.CommandText = "select  * from employee_details where empno= '" & txtempno.Text.Trim & "'"



        dread = com.ExecuteReader
        Do While dread.Read
            txtempname.Text = (dread.GetValue(1))
            txtcategory.Text = (dread.GetValue(7))
            txtdept.Text = (dread.GetValue(9))

        Loop
        con.Close()

        

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        con.Close()


        Dim com1 As SqlCommand = New SqlCommand
        con.Open()
        com1.Connection = con
        com1.CommandText = "select* from loan_details where (balance > 0) and empid= '" & txtempno.Text.Trim & "'"



        dread = com1.ExecuteReader
        If (dread.Read) Then
            MessageBox.Show("Already get the loan this employee")
        Else
        End If
        con.Close()



      
       






    End Sub

    Private Sub txtempname_TextChanged(sender As Object, e As EventArgs) Handles txtempname.TextChanged

    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged
        txttotalamount.Text = txtamount.Text
        txtbal.Text = txtamount.Text
    End Sub

    Private Sub txtbal_TextChanged(sender As Object, e As EventArgs) Handles txtbal.TextChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If (CheckBox1.Checked = True) Then
            txtinamount.Text = CDec(txtamount.Text) * CDec(txtinterest.Text) / 100
            txtbal.Text = CDec(txtamount.Text) + CDec(txtinamount.Text)
            txttotalamount.Text = CDec(txtamount.Text) + CDec(txtinamount.Text)
        End If




    End Sub

    Private Sub txtinamount_TextChanged(sender As Object, e As EventArgs) Handles txtinamount.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim i As Integer
        Try
            amo = CDec(txtbal.Text) / CDec(txtinstall.Text)
            MessageBox.Show(amo)
        Catch ex As Exception

        End Try


        If (ds.Tables("temp_loan").Rows.Count <> 0) Then
            Try
                ConnDb()
                Dim com As SqlCommand = New SqlCommand
                com.Connection = con
                com.CommandText = "Delete from temp_loan"
                con.Open()
                com.ExecuteNonQuery()
                con.Close()





            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            binding()
        End If



        For i = 0 To Val(txtinstall.Text) - 1
            Dim com As SqlCommand = New SqlCommand
            com.Connection = con
            com.CommandText = "insert into temp_loan (installment_date,amount)values(@installment_date,@amount)"
            com.Parameters.Add("@installment_date", txteffect.Value.AddMonths(1).AddDays(-1).AddMonths(i))
            com.Parameters.Add("@amount", amo)

            con.Open()
            com.ExecuteNonQuery()
            con.Close()
        Next
        txttot.Text = 0
        DataGridView1.DataSource = ds1.Tables("temp_loan")
        For i = 0 To Val(txtinstall.Text) - 1
            txttot.Text = Val(txttot.Text) + DataGridView1.SelectedCells(0).Value.ToString()
        Next

    End Sub
End Class

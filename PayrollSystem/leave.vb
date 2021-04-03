
Imports System.Data.SqlClient



Public Class leave

    Dim ds As DataSet
    Dim dread As SqlDataAdapter

    Private Sub binding()
        ConnDb()
        Dim da As SqlDataAdapter = New SqlDataAdapter("select * from leave", con)
        Dim da1 As SqlDataAdapter = New SqlDataAdapter("select * from employee_details", con)
        ds = New DataSet
        da.Fill(ds, "leave")
        da1.Fill(ds, "employee_details")





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        For x = 0 To ds.Tables("employee_details").Rows.Count - 1

            Dim cmd As SqlCommand = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = " insert into leave(empid,casual,annual,medical,nopay,lastyear)values(@empid,@casual,@annual,@medical,@nopay,@lastyear)"
            cmd.Parameters.Add("@empid", ds.Tables("employee_details").Rows(x).Item(0))
            cmd.Parameters.Add("@casual", txtcasual.Value)
            cmd.Parameters.Add("@annual", txtannual.Value)
            cmd.Parameters.Add("@medical", txtmedical.Value)
            cmd.Parameters.Add("@nopay", 0)
            cmd.Parameters.Add("@lastyear", txtyear.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()


        Next


        binding()
        MessageBox.Show("leaves registered successfully")


    End Sub

    Private Sub leave_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        binding()
        txtyear.Text = CStr(Year(Today))
    End Sub
End Class
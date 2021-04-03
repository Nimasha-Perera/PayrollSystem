Imports System.Data.SqlClient
Imports System.IO



Public Class allowance_details

   
    Dim da As SqlDataAdapter
    Dim da1 As SqlDataAdapter
    Dim cmd As SqlCommand
    Dim dread As SqlDataReader
    Dim ds As DataSet




    Private Sub Binding()
        ConnDb()
        da = New SqlDataAdapter("Select * from employee_details", con)
        da1 = New SqlDataAdapter("Select * from allowance_details", con)
        ds = New DataSet



        da.Fill(ds, "employee_details")
        da1.Fill(ds, "allowance_details")


        Try
            Fixcombo.Items.Clear()
            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = ("Select distinct allowance_type from allowance_details")
            dread = cmd.ExecuteReader
            Do While dread.Read
                Fixcombo.Items.Add(dread.GetValue(0))
                depallo.Items.Add(dread.GetValue(0))
                catallo.Items.Add(dread.GetValue(0))
                txtinallo.Items.Add(dread.GetValue(0))
            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        'Department
        Try

            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = ("Select distinct department from employee_details")
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtdept.Items.Add(dread.GetValue(0))
                txtcatdept.Items.Add(dread.GetValue(0))
            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try




        'Category
        Try

            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = ("Select distinct category from employee_details")
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtcategory.Items.Add(dread.GetValue(0))
                'txtincat.Items.Add(dread.GetValue(0))
            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try



        'indv
        Try

            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = ("Select distinct empno from employee_details")
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtempid.Items.Add(dread.GetValue(0))
            Loop
            con.Close()

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        DataGridView1.DataSource = ds.Tables("allowance_details")
        DataGridView2.DataSource = ds.Tables("allowance_details")
        DataGridView3.DataSource = ds.Tables("allowance_details")
        DataGridView4.DataSource = ds.Tables("allowance_details")






    End Sub


    Private Sub allowance_details_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Binding()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Fixcombo.SelectedIndexChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim x As Integer
        For x = 0 To ds.Tables("employee_details").Rows.Count - 1

            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date) "
            cmd.Parameters.Add("@allowance_type", Fixcombo.Text)
            cmd.Parameters.Add("@amount", txtamount.Text)
            cmd.Parameters.Add("@empno", ds.Tables("employee_details").Rows(x).Item(0))
            cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            con.Close()




        Next

        MessageBox.Show("Allowance added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Binding()



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Fixcombo.Items.Clear()
        txtamount.Clear()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim x As Integer
        For x = 0 To ds.Tables("employee_details").Rows.Count - 1
            If (txtdept.Text = ds.Tables("employee_details").Rows(x).Item(9)) Then



                cmd = New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "Insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date) "
                cmd.Parameters.Add("@allowance_type", depallo.Text)
                cmd.Parameters.Add("@amount", txtdamo.Text)
                cmd.Parameters.Add("@empno", ds.Tables("employee_details").Rows(x).Item(0))
                cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()







            End If





        Next

        MessageBox.Show("Allowance added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Binding()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        depallo.Items.Clear()
        txtdamo.Clear()
        txtdept.Items.Clear()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles catallo.SelectedIndexChanged

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim x As Integer
        For x = 0 To ds.Tables("employee_details").Rows.Count - 1
            If (txtcatdept.Text = ds.Tables("employee_details").Rows(x).Item(9) And txtcategory.Text = ds.Tables("employee_details").Rows(x).Item(7)) Then



                cmd = New SqlCommand
                cmd.Connection = con
                cmd.CommandText = "insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date)"
                cmd.Parameters.Add("@allowance_type", catallo.Text)
                cmd.Parameters.Add("@amount", txtcatamo.Text)
                cmd.Parameters.Add("@empno", ds.Tables("employee_details").Rows(x).Item(0))
                cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
                con.Open()
                cmd.ExecuteNonQuery()
                con.Close()

            End If

        Next

        MessageBox.Show("allowance added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Binding()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub depallo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles depallo.SelectedIndexChanged

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click

    End Sub

    Private Sub txtempid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtempid.SelectedIndexChanged
        Try
            cmd = New SqlCommand
            con.Open()
            cmd.Connection = con
            cmd.CommandText = "Select firstname,category from employee_details where empno='" & txtempid.Text & "'"
            dread = cmd.ExecuteReader
            Do While dread.Read
                txtempname.Text = dread.GetValue(0)
                txtincat.Text = dread.GetValue(1)

            Loop

            con.Close()




        Catch ex As Exception

        End Try


    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        Try
            cmd = New SqlCommand
            cmd.Connection = con
            cmd.CommandText = "Insert into allowance_details(allowance_type,amount,empno,allo_date) values(@allowance_type,@amount,@empno,@allo_date) "
            cmd.Parameters.Add("@allowance_type", txtinallo.Text)
            cmd.Parameters.Add("@amount", txtinamount.Text)
            cmd.Parameters.Add("@empno", txtempid.Text)
            cmd.Parameters.Add("@allo_date", DateTimePicker1.Text)
            con.Open()
            cmd.ExecuteNonQuery()
            MessageBox.Show("Allowance added", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Binding()
            con.Close()


        Catch ex As Exception

        End Try
    End Sub

    Private Sub txtamount_TextChanged(sender As Object, e As EventArgs) Handles txtamount.TextChanged

    End Sub

    Private Sub txtcategory_SelectedIndexChanged(sender As Object, e As EventArgs) Handles txtcategory.SelectedIndexChanged

    End Sub
End Class
Imports System.Data.SqlClient





Public Class Form1


    Dim dr As SqlDataReader
    Dim cmd As SqlCommand
    Dim username, password As String
    Dim sql As String

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        username = txtusername.Text
        password = txtpassword.Text
        If (username = "" And password = "") Then
            MessageBox.Show("Enter the username and password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            ConnDb()
            con.Open()
            sql = "select * from login where username= '" & username & "' and password= '" & password & "'"
            cmd = New SqlCommand(sql, con)
            dr = cmd.ExecuteReader

            If (dr.Read = True) Then

                Dim f2 As Main = New Main
                f2.Show()
                Me.Hide()

            Else
                MessageBox.Show("Login Failed!!!!!!!!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

            End If
        End If
        con.Close()

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
    End Sub
End Class

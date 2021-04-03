
Imports System.Data.SqlClient




Module Conn





    Public con As SqlConnection

    Public Sub ConnDb()
        Try
            con = New SqlConnection("server=DESKTOP-N5R9P6S; database=compayroll; user id=nims; password=1234;")


        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub






End Module

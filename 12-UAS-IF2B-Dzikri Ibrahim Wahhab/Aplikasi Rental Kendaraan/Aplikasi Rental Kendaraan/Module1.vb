Imports MySql.Data.MySqlClient
Module Module1
    Public CONN As MySqlConnection
    Public CMD As MySqlCommand
    Public RD As MySqlDataReader
    Public DA As MySqlDataAdapter
    Public DS As DataSet
    Public STR As String

    Public Sub koneksi()
        Try
            STR = "server=localhost;user id=root;password=123456789;database=dbrentalkendaraan"
            CONN = New MySqlConnection(STR)

            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Koneksi gagal: " & ex.Message)
        End Try
    End Sub
End Module
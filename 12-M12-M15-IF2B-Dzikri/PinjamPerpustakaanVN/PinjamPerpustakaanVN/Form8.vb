Imports CrystalDecisions.Shared
Imports MySql.Data.MySqlClient
Public Class Form8
    Private Sub CrystalReportViewer1_Load(sender As Object, e As EventArgs) Handles CrystalReportViewer1.Load

        Dim connectionInfo As New ConnectionInfo()
        connectionInfo.ServerName = "localhost"
        ConnectionInfo.DatabaseName = "dbperpustakaan"
        ConnectionInfo.UserID = "root"
        ConnectionInfo.Password = "123456789"
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim report As New CrCariPerTanggal()
        Dim tanggal As Date = DateTime.Now.Date

        report.SetParameterValue("TanggalPinjam", tanggal)
        CrystalReportViewer1.ReportSource = report
    End Sub
End Class
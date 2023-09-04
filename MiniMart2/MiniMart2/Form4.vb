Imports System.Data.SqlClient

Public Class Form4
    Sub customerlistreport()
        DataModule.ConnectToServer()
        Dim da As New SqlDataAdapter("select *from cust", DataModule.con)
        Dim ds As New DataSet1()
        da.Fill(ds, "Cust")
        DataModule.closeconnection()
        Dim rpt As New CrystalReport2()
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub


    Sub customerTablelistreport()
        DataModule.ConnectToServer()
        Dim da As New SqlDataAdapter("select *from custTable", DataModule.con)
        Dim ds As New DataSet1()
        da.Fill(ds, "CustTable")
        DataModule.closeconnection()
        Dim rpt As New CrystalReport1()
        rpt.SetDataSource(ds)
        CrystalReportViewer1.ReportSource = rpt
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
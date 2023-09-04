
Imports System.Data.SqlClient
Imports System.IO
Module DataModule
    Public user As String
    Public con As New SqlConnection()
    Sub ConnectToServer()
        Dim f As New FileInfo("../../Database/MiniMartDB.mdf")
        con.ConnectionString = "server=.\sqlexpress;AttachDBFilename=" & f.FullName & ";integrated security=true;user instance=true"
        con.Open()
    End Sub
    Sub closeconnection()
        con.Close()
    End Sub
    Sub ExecuteCommand(ByVal sql As String)
        ConnectToServer()
        Dim cmd As New SqlCommand(sql, con)
        cmd.ExecuteNonQuery()
        closeconnection()
    End Sub
    Function gettable(ByVal sql As String) As DataTable
        ConnectToServer()
        Dim da As New SqlDataAdapter(sql, con)
        Dim dt As New DataTable()
        da.Fill(dt)
        closeconnection()
        Return dt
    End Function

    Sub FillCombo(ByVal cmb As ComboBox, ByVal sql As String, ByVal displayfield As String, ByVal valuefield As String)
        Dim dt = gettable(sql)
        cmb.DataSource = dt
        cmb.DisplayMember = displayfield
        cmb.ValueMember = valuefield
    End Sub

    Sub FillListView(ByVal lv As ListView, ByVal sql As String)
        Dim dt = gettable(sql)
        lv.Items.Clear()
        For Each row As DataRow In dt.Rows
            Dim lt As New ListViewItem(row(0).ToString())
            For j = 1 To dt.Columns.Count - 1
                lt.SubItems.Add(row(j).ToString())
            Next
            lv.Items.Add(lt)

        Next
    End Sub



End Module

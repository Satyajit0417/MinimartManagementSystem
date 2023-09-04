Public Class CompanyForm
    Dim cname As String
    Sub Refreshgrid()
        Dim dt = DataModule.gettable("Select * from  Company")
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Save" Then
            Dim sql As String
            sql = String.Format("insert into Company values('{0}')", TextBox1.Text)
            MsgBox(sql)
            DataModule.ExecuteCommand(sql)
            MessageBox.Show("Company record is saved")
            Refreshgrid()
        Else
            Dim sql As String
            sql = String.Format("update  Company set CompanyName='{0}' where CompanyName='{1}'", TextBox1.Text, cname)
            MsgBox(sql)
            DataModule.ExecuteCommand(sql)
            MessageBox.Show(" Company record is updated")
            Refreshgrid()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox1.Clear()
        Button1.Text = "Save"
        TextBox1.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        TextBox1.Text = DataGridView1.CurrentRow.Cells(0).Value
        cname = TextBox1.Text
        Button1.Text = "Update"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Do you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim CompanyName = DataGridView1.CurrentRow.Cells(0).Value
            DataModule.ExecuteCommand("delete from Company where CompanyName='" & CompanyName & "'")
            Refreshgrid()
            MessageBox.Show("Company record is deleted")
        End If
    End Sub

    Private Sub CompanyForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refreshgrid()
    End Sub
End Class
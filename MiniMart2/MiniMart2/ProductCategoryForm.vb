Public Class ProductCategoryForm
    Dim id As Integer
    Sub Refreshgrid()
        Dim dt = DataModule.gettable("Select * from  ProductCategory")
        DataGridView1.DataSource = dt
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If Button1.Text = "Save" Then
            Dim sql As String
            sql = String.Format("insert into  ProductCategory (CategoryName) values('{0}')", TextBox2.Text)
            'MsgBox(sql)
            DataModule.ExecuteCommand(sql)
            MessageBox.Show("Product category record is saved")
            Refreshgrid()
        Else
            Dim sql As String
            sql = String.Format("update  ProductCategory set CategoryName='{0}' where CategoryId={1}", TextBox2.Text, id)
            'MsgBox(sql)
            DataModule.ExecuteCommand(sql)
            MessageBox.Show(" Product category record is updated")
            Refreshgrid()
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TextBox2.Clear()
        Button1.Text = "Save"
        TextBox2.Focus()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        id = DataGridView1.CurrentRow.Cells(0).Value
        TextBox2.Text = DataGridView1.CurrentRow.Cells(1).Value
        Button1.Text = "Update"
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        If MessageBox.Show("Do you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim CategoryID = DataGridView1.CurrentRow.Cells(0).Value
            DataModule.ExecuteCommand("delete from ProductCategory where CategoryID=" & CategoryID)
            Refreshgrid()
            MessageBox.Show("Product category record is deleted")
        End If
    End Sub

    Private Sub ProductCategoryForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Refreshgrid()
    End Sub
End Class
Public Class SupplierForm

    Sub Refreshgrid()
        Dim dt = DataModule.gettable("Select * from  ProductCategory")
        DataGridView1.DataSource = dt
    End Sub
 

    Private Sub DeleteButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Do you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim SupplierNo = DataGridView1.CurrentRow.Cells(0).Value
            DataModule.ExecuteCommand("delete from SupplierTable where SupplierNo=" & SupplierNo)
            Refreshgrid()
            MessageBox.Show("Supplier record is deleted")
        End If
    End Sub

    Private Sub SNoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SNoTextBox.TextChanged

    End Sub

    Private Sub SaveButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If SaveButton.Text = "Save" Then
            Dim sql As String
            sql = String.Format("insert into Supplier (SupplierNo,SupplierName,CompanyName,Address,MobileNumber,Email) values({0},'{1}','{2}','{3}',{4},{5})", SNoTextBox.Text, NameTextBox.Text, CNameComboBox.SelectedValue, AddressTextBox.Text, MNumberTextBox.Text, EmailTextBox.Text)
            MsgBox(sql)
            DataModule.ExecuteCommand(sql)
            MessageBox.Show("Supplier record is saved")
            Refreshgrid()
        End If
    End Sub

    Private Sub EditButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        SNoTextBox.Text = DataGridView1.CurrentRow.Cells(0).Value
        NameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        CNameComboBox.Text = DataGridView1.CurrentRow.Cells(2).Value
        AddressTextBox.Text = DataGridView1.CurrentRow.Cells(3).Value
        MNumberTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value
        EmailTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value
        SaveButton.Text = "Update"
    End Sub
End Class



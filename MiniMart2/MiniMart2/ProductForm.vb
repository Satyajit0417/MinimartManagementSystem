Public Class ProductForm

    Private Property Clear As String

    Sub Refreshgrid()
        Dim dt = DataModule.gettable("Select * from  Product")
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowseButton.Click
        HSNForm.Show()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SaveButton.Click
        If SaveButton.Text = "Save" Then
            Dim sql As String
            sql = String.Format("insert into  Product (ProductName,CategoryID,CompanyName,Unit,HSNcode,Price) values('{0}',{1},'{2}','{3}',{4},{5})", NameTextBox.Text, CategoryComboBox.SelectedValue, CompanyComboBox.SelectedValue, UnitTextBox.Text, HSNTextBox.Text, PriceTextBox.Text)
            MsgBox(sql)
            DataModule.ExecuteCommand(sql)
            MessageBox.Show("Product record is saved")
            Refreshgrid()
        End If
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ResetButton.Click
        CodeTextBox.Text = "[AUTO]"
        NameTextBox.Clear()
        UnitTextBox.Clear()
        HSNTextBox.Clear()
        PriceTextBox.Clear()
        SaveButton.Text = "Save"
        NameTextBox.Focus()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EditButton.Click
        CodeTextBox.Text = DataGridView1.CurrentRow.Cells(0).Value
        NameTextBox.Text = DataGridView1.CurrentRow.Cells(1).Value
        CategoryComboBox.Text = DataGridView1.CurrentRow.Cells(2).Value
        CompanyComboBox.Text = DataGridView1.CurrentRow.Cells(3).Value
        UnitTextBox.Text = DataGridView1.CurrentRow.Cells(4).Value
        HSNTextBox.Text = DataGridView1.CurrentRow.Cells(5).Value
        PriceTextBox.Text = DataGridView1.CurrentRow.Cells(6).Value
        SaveButton.Text = "Update"
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DeleteButton.Click
        If MessageBox.Show("Do you want to Delete?", "Confirm Delete", MessageBoxButtons.YesNo) = Windows.Forms.DialogResult.Yes Then
            Dim ProductID = DataGridView1.CurrentRow.Cells(0).Value
            DataModule.ExecuteCommand("delete from Product where ProductId=" & ProductID)
            Refreshgrid()
            MessageBox.Show("Product record is deleted")
        End If
    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter
        Refreshgrid()
        FillCombo(CategoryComboBox, "select * from ProductCategory", "CategoryName", "CategoryId")
        FillCombo(CompanyComboBox, "select * from Company", "CompanyName", "CompanyName")
    End Sub

   

End Class
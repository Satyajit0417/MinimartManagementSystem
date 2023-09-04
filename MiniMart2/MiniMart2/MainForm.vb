Public Class MainForm

    Private Sub LogoutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles LogoutToolStripMenuItem.Click
        Close()
        LoginForm.Show()
        LoginForm.TextBox1.Clear()
        LoginForm.TextBox2.Clear()
        LoginForm.TextBox1.Focus()

    End Sub

    Private Sub ExittToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExittToolStripMenuItem.Click
        Close()
    End Sub

   
    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        AboutForm.Show()
    End Sub

    Private Sub FilteredStockToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FilteredStockToolStripMenuItem.Click
        HSNForm.Show()
    End Sub

    Private Sub RemoteSupportToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RemoteSupportToolStripMenuItem.Click
        ChangePasswordForm.Show()
    End Sub

    Private Sub ItemMasterToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ItemMasterToolStripMenuItem.Click
        ProductCategoryForm.Show()
    End Sub

    Private Sub BillToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BillToolStripMenuItem.Click
        CompanyForm.Show()
    End Sub

    Private Sub ModeOfPToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ModeOfPToolStripMenuItem.Click
        Productform.show()
    End Sub

    Private Sub Button18_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button18.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

    End Sub

    Private Sub DateTimePicker1_ValueChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DateTimePicker1.ValueChanged

    End Sub

    Private Sub PurchaseOrderToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PurchaseOrderToolStripMenuItem.Click
        PurchaseOrderForm.Show()
    End Sub

    Private Sub SupplierToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SupplierToolStripMenuItem.Click
        SupplierForm.Show()

    End Sub
End Class
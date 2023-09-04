Public Class ChangePasswordForm
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim opass = TextBox1.Text
        Dim npass = TextBox2.Text
        Dim cnpass = TextBox3.Text
        If String.IsNullOrEmpty(opass) Or String.IsNullOrEmpty(npass) Or String.IsNullOrEmpty(cnpass) Then
            MessageBox.Show("All Fields are required")
            Return
        End If
        Dim dt = DataModule.gettable("select * from login where usrename='" & DataModule.user & "' and password='" & opass & "'")
        If dt.Rows.Count = 0 Then
            MessageBox.Show("Old Password is wrong")
            Return
        End If
        If npass <> cnpass Then
            MessageBox.Show("Password Mismatch")
            Return
        End If
        DataModule.ExecuteCommand("Update login set password= '" & npass & " 'where username=' " & DataModule.user & " ' ")
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox1.Focus()
        Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

    End Sub
End Class
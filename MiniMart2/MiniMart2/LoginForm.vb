Public Class LoginForm
    Dim path = "E:\IMAGES\"
    Dim arry() = {"deposite.jpg", "images.jpg"}
    Dim index = 0

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim user = TextBox1.Text
        Dim pass = TextBox2.Text
        Dim sql As String
        sql = String.Format("Select * from Login where username ='{0}' and password='{1}'", user, pass)
        'MsgBox(Sql)
        Dim dt = DataModule.gettable(sql)
        'MsgBox(dt.rows.count)
        If dt.Rows.Count = 1 Then
            'End If
            'If user = "kiran" AndAlso pass = "kiran" Then
            Hide()
            MainForm.Show()
        Else
            MessageBox.Show("Login Failed...Try again...Invalid entry")
        End If
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        End
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Text = Now()
        PictureBox1.Image = Image.FromFile(path & arry(index))
        index += 1
        If index >= arry.length Then
            index = 0
        End If
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub
End Class






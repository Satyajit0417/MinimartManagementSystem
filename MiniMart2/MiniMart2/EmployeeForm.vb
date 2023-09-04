Imports System.Data.SqlClient
Imports System.IO
Public Class EmployeeForm
    Dim fname As String
    Dim filemodified = False

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        Dim sql As String
        sql = String.Format("select EmpID,EmpName,EmailID,MobileNumber,Photo,from employeetable where {0} ike '%{1}%'", ComboBox1.Text, TextBox1.Text)
        DataGridView1.DataSource = DataModule.gettable(sql)

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        TabControl1.SelectedIndex = 1
        GroupBox1.Text = "Add New Employee"
        NameTextBox.Focus()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        TabControl1.SelectedIndex = 1
        GroupBox1.Text = "Edit An Existing Employee"
        NameTextBox.Focus()
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        refreshgrid()
    End Sub
    Sub refreshgrid()
        Dim dt = DataModule.gettable("select EmpID,EmpName,EmailID,MobileNumber,Photo from employeetable")
        DataGridView1.DataSource = dt

    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        DataModule.ConnectToServer()
        If Button6.Text = "Save" Then
            Dim cmd As New SqlCommand("insert into Employeetable(EmpName,Empaddress,Gender,Maritalstatus,Qualification,Birthdate,Joindate,Mobilenumber,EmailID,Salary,Photo)values(@EmpName,@Empaddress,@Gender,@Maritalstatus,@Qualification,@Birthdate,@Joindate,@Mobilenumber,@EmailID,@Salary,@Photo)", DataModule.con)
            cmd.Parameters.AddWithValue("@EmpName", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@EmpAddress", AddTextBox.Text)
            Dim gender As String
            If MRadioButton.Checked Then
                gender = "Male"
            Else
                gender = "Female"

            End If
            Dim Mstatus As String
            If MRRadioButton.Checked Then
                Mstatus = "Married"
            Else
                Mstatus = "Unmarried"
            End If
            cmd.Parameters.AddWithValue("@Gender", gender)
            cmd.Parameters.AddWithValue("@Maritalstatus", Mstatus)
            cmd.Parameters.AddWithValue("@Qualification", QualTextBox.Text)
            cmd.Parameters.AddWithValue("@BirthDate", BDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@JoinDate", JDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@EmailID", ETextBox.Text)
            cmd.Parameters.AddWithValue("@mobileNumber", MBTextBox.Text)
            cmd.Parameters.AddWithValue("@Salary", STextBox.Text)
            Dim hb = ""
            For Each item In HobbiesCheckedListBox.CheckedItems
                hb = hb & item & ","
            Next
            cmd.Parameters.AddWithValue("@Hobbies", hb)
            Dim b() As Byte = File.ReadAllBytes(fname)
            cmd.Parameters.AddWithValue("@Photo", b)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Information Is Saved")
        Else
            Dim cmd As New SqlCommand()
            cmd.Connection = DataModule.con
            If filemodified Then
                cmd.CommandText = ("Update Employeetable Set Empname=@Empname,Empaddress=@Empaddress,Gender=@Gender,Maritalstatus=@Maritalstatus,Qualification=@Qualification,Birthdate=@Birthdate,Joindate=@Joindate,Mobilenumber=@Mobilenumber,EmailID=@EmailID,Salary=@Salary,Hobbies=@Hobbies,Photo=@Photo where EmpID=@EmpID")
                Dim b() As Byte = File.ReadAllBytes(fname)
                cmd.Parameters.AddWithValue("@Photo", b)
            Else
                cmd.CommandText = ("Update Employeetable Set EmpName=@Empname,Empaddress=@Empaddress,Gender=@Gender,Maritalstatus=@Maritalstatus,Qualification=@Qualification,Birthdate=@Birthdate,Joindate=@Joindate,Mobilenumber=@Mobilenumber,EmailID=@EmailID,Salary=@Salary,Hobbies=@Hobbies,Photo=@Photo where EmpID=@EmpID")
            End If
            cmd.Parameters.AddWithValue("@EmpName", NameTextBox.Text)
            cmd.Parameters.AddWithValue("@EmpAddress", AddTextBox.Text)
            Dim Gender As String
            If MRadioButton.Checked Then
                Gender = "Male"
            Else
                Gender = "Female"
            End If
            Dim Mstatus As String
            If MRRadioButton.Checked Then
                Mstatus = "Married"
            Else
                Mstatus = "Unmarried"
            End If
            cmd.Parameters.AddWithValue("@Gender", Gender)
            cmd.Parameters.AddWithValue("@Maritalstatus", Mstatus)
            cmd.Parameters.AddWithValue("@Qualification", QualTextBox.Text)
            cmd.Parameters.AddWithValue("@BirthDate", BDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@JoinDate", JDateTimePicker.Value)
            cmd.Parameters.AddWithValue("@EmailID", ETextBox.Text)
            cmd.Parameters.AddWithValue("@mobileNumber", MBTextBox.Text)
            cmd.Parameters.AddWithValue("@Salary", STextBox.Text)
            Dim hb = ""
            For Each item In HobbiesCheckedListBox.CheckedItems
                hb = hb & item & ","
            Next
            cmd.Parameters.AddWithValue("@Hobbies", hb)
            ' Dim b() As Byte = File.ReadAllBytes(fname)
            cmd.Parameters.AddWithValue("@EmpID", EmpTextBox.Text)
            cmd.ExecuteNonQuery()
            MessageBox.Show("Employee Information Is Updated")
        End If
        DataModule.closeconnection()
        refreshgrid()

        TabControl1.SelectedIndex = 0
    End Sub


    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            fname = OpenFileDialog1.FileName
            PictureBox1.Image = Image.FromFile(fname)
            filemodified = True
        End If
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        EmpTextBox.Text = "[AUTO]"
        NameTextBox.Clear()
        AddTextBox.Clear()
        MRadioButton.Checked = False
        FRadioButton.Checked = False
        MRRadioButton.Checked = False
        UMRadioButton.Checked = False
        QualTextBox.Clear()
        BDateTimePicker.Value = Now
        JDateTimePicker.Value = Now
        MBTextBox.Clear()
        ETextBox.Clear()
        STextBox.Clear()
        For j = 0 To HobbiesCheckedListBox.Items.Count - 1
            HobbiesCheckedListBox.SetItemChecked(j, False)
        Next
        PictureBox1.Image = Nothing
        NameTextBox.Focus()
    End Sub

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub NameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NameTextBox.TextChanged

    End Sub
End Class
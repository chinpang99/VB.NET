Imports System.Data.OleDb
Public Class Form_Log_In
    Dim cnnOLEDB As New OleDbConnection
    Private Sub btnLogIn_Click(sender As Object, e As EventArgs) Handles btnLogIn.Click
        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Assignment-Db.accdb")
        Dim cmd As OleDbCommand = New OleDbCommand("SELECT * FROM tbl_users WHERE Login_Username = '" & txtUsername.Text & "' AND [Password] = '" & txtPassword.Text & "' ", con)
        con.Open()
        Dim dr As OleDbDataReader = cmd.ExecuteReader()

        If (dr.Read() = True) Then ' If the record can be queried, it means passing verification, then open MainPage form.   
            MessageBox.Show("Log In Successful", "Log In Successful", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Form_MainPage.Show()
            Me.Hide()
        Else
            MessageBox.Show("Invalid name or password!", "Invalid", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub chkShowPassword_CheckedChanged(sender As Object, e As EventArgs) Handles chkShowPassword.CheckedChanged
        If chkShowPassword.Checked = True Then
            txtPassword.UseSystemPasswordChar = False
        Else
            txtPassword.UseSystemPasswordChar = True
        End If
    End Sub

    Private Sub Form_Log_In_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtPassword.UseSystemPasswordChar = True
        txtUsername.Focus()
    End Sub

End Class
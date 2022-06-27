Imports System.Data.SqlClient
Public Class Login
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Private Sub Usernametxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usernametxt.Enter
        'Username Text Disapper
        Dim username As String = Usernametxt.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Usernametxt.Text = ""
            Usernametxt.ForeColor = Color.Black
        End If
    End Sub
    Private Sub Usernametxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Usernametxt.Leave
        'Username Text Appear
        Dim username As String = Usernametxt.Text
        If username.Trim().ToLower() = "username" Or username.Trim() = "" Then
            Usernametxt.Text = "username"
            Usernametxt.ForeColor = Color.DarkGray
        End If
    End Sub
    Private Sub Passwordtxt_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles Passwordtxt.Enter
        'Password Text Disapper
        Dim Pass As String = Passwordtxt.Text
        If Pass.Trim().ToLower() = "password" Or Pass.Trim() = "" Then
            Passwordtxt.Text = ""
            Passwordtxt.ForeColor = Color.Black
            Passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Passwordtxt_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles Passwordtxt.Leave
        'Password Text Appear
        Dim Pass As String = Passwordtxt.Text
        If Pass.Trim().ToLower() = "password" Or Pass.Trim() = "" Then
            Passwordtxt.Text = "Password"
            Passwordtxt.ForeColor = Color.Black
            Passwordtxt.UseSystemPasswordChar = True
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True "
        Dim sql As String = "select count(*) from Login where User_Name=@User_Name and Password=@Password"
        Using Conn As New SqlConnection(str)
            Using cmd As New SqlCommand(sql, Conn)
                Conn.Open()
                cmd.Parameters.AddWithValue("@User_Name", Usernametxt.Text)
                cmd.Parameters.AddWithValue("@Password", Passwordtxt.Text)
                Dim value = cmd.ExecuteScalar()
                If value > 0 Then
                    MessageBox.Show("Login sucessfully!")
                    Me.Hide()
                    Splash_Screen.Show()
                Else
                    MessageBox.Show("Incorrect Email or Password")
                End If
            End Using
        End Using
    End Sub

   
    Private Sub Usernametxt_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Usernametxt.TextChanged

    End Sub
End Class
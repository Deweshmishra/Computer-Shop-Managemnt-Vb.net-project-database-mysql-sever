Imports System.IO
Imports System.Data.SqlClient
Imports System.Data.Sql
Imports System.Configuration
Public Class Registration
    Dim connectionString As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True"
    Dim cn As New SqlConnection(connectionString)
    Dim cmd As New SqlCommand
    Dim dr As SqlDataAdapter
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        If TextBox6.Text.Trim() = TextBox7.Text.Trim() Then
            Dim str As String = "Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True"
            Dim sql As String = "INSERT INTO Login (Name,Middle_Name,Sur_Name,User_Name,Gender,Password) values (@Name,@Middle_Name,@Sur_Name,@User_Name,@Gender,@Password)"
            Using Conn As New SqlConnection(str)
                Using cmd As New SqlCommand(sql, Conn)
                    Conn.Open()
                    'cmd.Parameters.AddWithValue("@User_Id", TextBox1.Text)
                    cmd.Parameters.AddWithValue("@Name", TextBox2.Text)
                    cmd.Parameters.AddWithValue("@Middle_Name", TextBox3.Text)
                    cmd.Parameters.AddWithValue("@Sur_Name", TextBox4.Text)
                    cmd.Parameters.AddWithValue("@User_Name", TextBox5.Text)
                    cmd.Parameters.AddWithValue("@Gender", Gender.Text)
                    cmd.Parameters.AddWithValue("@Password", TextBox6.Text)
                    Dim value = cmd.ExecuteScalar()
                    If value > 0 Then
                        MessageBox.Show("Signup sucessfully!")
                    Else
                        MessageBox.Show("Signup Unsucessfully!")
                    End If
                End Using
            End Using
        Else
            MsgBox("confirmation password do not match")
        End If
        blank()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        blank()
    End Sub

    Sub blank()
        'TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        TextBox5.Text = ""
        Gender.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
    End Sub



    Private Sub TextBox5_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Enter
        Dim Enter As String = TextBox5.Text
        If Enter.Trim().ToLower() = "please enter key press" Or Enter.Trim() = "" Then
            TextBox5.Text = ""
            TextBox5.ForeColor = Color.Black
        End If
    End Sub

    Private Sub TextBox5_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox5.KeyDown
        If e.KeyCode = Keys.Enter Then
            TextBox5.Text = TextBox2.Text + TextBox3.Text
        End If
    End Sub

    Private Sub TextBox5_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox5.Leave
        Dim Enter As String = TextBox5.Text
        If Enter.Trim().ToLower() = "please enter key press" Or Enter.Trim() = "" Then
            TextBox5.Text = "please enter key press"
            TextBox5.ForeColor = Color.DarkGray
        End If
    End Sub







    Private Sub TextBox3_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Enter
        Dim OP As String = TextBox3.Text
        If OP.Trim().ToLower() = "optional" Or OP.Trim() = "" Then
            TextBox3.Text = ""
            TextBox3.ForeColor = Color.Black

        End If
    End Sub

    Private Sub TextBox3_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        Dim OP As String = TextBox3.Text
        If OP.Trim().ToLower() = "optional" Or OP.Trim() = "" Then
            TextBox3.Text = "optional"
            TextBox3.ForeColor = Color.DarkGray

        End If
    End Sub



    Private Sub Registration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComputershopDatabaseDataSet2.Registration' table. You can move, or remove it, as needed.
        Gender.Items.Add("Male")
        Gender.Items.Add("Female")
        Gender.Items.Add("Other")
    End Sub


    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            TextBox6.UseSystemPasswordChar = False
            TextBox7.UseSystemPasswordChar = False
        Else
            TextBox6.UseSystemPasswordChar = True
            TextBox7.UseSystemPasswordChar = True
        End If
    End Sub


    Private Sub TextBox2_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox2.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub TextBox3_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox3_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox3.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox4.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub Gender_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Gender.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub TextBox6_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox6.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub TextBox7_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles TextBox7.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub Add_New_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Add_New.Click

    End Sub
End Class
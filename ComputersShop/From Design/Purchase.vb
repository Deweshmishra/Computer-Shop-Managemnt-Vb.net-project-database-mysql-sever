Imports System.Data.SqlClient
Public Class Purchase
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Private Sub Purchase_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Enabled The TextBox'
        P_Name.Enabled = False
        Brand.Enabled = False
        Warranty.Enabled = False
        Ram.Enabled = False
        hdd.Enabled = False
        Storage.Enabled = False
        Processor.Enabled = False
        dates.Enabled = False
        Services.Enabled = False
        D_Name.Enabled = False
        D_State.Enabled = False
        Quantity.Enabled = False
        Price.Enabled = False
        Total.Enabled = False
        'Disabled The Button'
        Save.Enabled = False
        Updates.Enabled = False
        DELETE.Enabled = False
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub
    Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        cmd = New SqlCommand("insert into Stock values('" + P_Name.Text + "','" + Brand.Text + "','" + Warranty.Text + "','" + Ram.Text + "','" + hdd.Text + "','" + Storage.Text + "','" + Processor.Text + "','" + dates.Text + "','" + Services.Text + "','" + D_Name.Text + "','" + D_State.Text + "','" + Quantity.Text + "','" + Price.Text + "','" + Total.Text + "')", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record saved!")
    End Sub
    Private Sub Quantity_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Quantity.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim a, b, c As Double
            a = Quantity.Text
            b = Price.Text
            Total.Text = c
            c = a + b
        End If
    End Sub
    Private Sub Price_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Price.KeyDown
        If e.KeyCode = Keys.Enter Then
            Dim a, b, c As Double
            a = Quantity.Text
            b = Price.Text
            Total.Text = c
            Total.Text = a + b
        End If
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Updates.Click
        cmd = New SqlCommand("update  Stock  set Brand='" + Brand.Text + "',Warranty='" + Warranty.Text + "',Ram='" + Ram.Text + "',Hdd_Sdd='" + hdd.Text + "',Storage='" + Storage.Text + "',Processor='" + Processor.Text + "',Date='" + dates.Text + "',S_Code='" + Services.Text + "',V_Name='" + D_Name.Text + "',V_State='" + D_State.Text + "',Quantity'" + Quantity.Text + "',Price='" + Price.Text + "',Total='" + Total.Text + "' where P_Name ='" + P_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("records updated!")
        'Call cleardata()
    End Sub

   
    Private Sub DELETE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles DELETE.Click
        cmd = New SqlCommand("delete from Stock where P_Name='" + P_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record deleted!")
    End Sub
    Private Sub Brand_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Brand.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub Quantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Quantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub Price_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Price.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub Total_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Total.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub D_Name_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D_Name.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub D_State_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles D_State.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        'Enabled The TextBox'
        P_Name.Enabled = True
        Brand.Enabled = True
        Warranty.Enabled = True
        Ram.Enabled = True
        hdd.Enabled = True
        Storage.Enabled = True
        Processor.Enabled = True
        dates.Enabled = True
        Services.Enabled = True
        D_Name.Enabled = True
        D_State.Enabled = True
        Quantity.Enabled = True
        Price.Enabled = True
        Total.Enabled = True
        'Disabled The Button'
        Save.Enabled = True
        Updates.Enabled = True
        DELETE.Enabled = True
        AddNew.Enabled = False
    End Sub
End Class
Imports System.Data.SqlClient
Public Class Employee
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Enabled The TextBox'
        E_Name.Enabled = False
        F_Name.Enabled = False
        DateTimePicker1.Enabled = False
        Aadhar.Enabled = False
        Mobile_Number.Enabled = False
        Email_id.Enabled = False
        DateTimePicker2.Enabled = False
        State.Enabled = False
        Pincode.Enabled = False
        gender.Enabled = False
        Address.Enabled = False
        Salary.Enabled = False
        Status.Enabled = False
        'Enabled The Button'
        Btn_Save.Enabled = False
        Btn_Update.Enabled = False
        Btn_Delete.Enabled = False
        Btn_Search.Enabled = False
        'TODO: This line of code loads data into the 'ComputershopDatabaseDataSet1.Employee' table. You can move, or remove it, as needed.
        Me.EmployeesTableAdapter.Fill(Me.ComputersShopDataSet1.Employees)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub
  
    Public Sub cleardata()
        E_Name.Text = ""
        F_Name.Text = ""
        Aadhar.Text = ""
        Mobile_Number.Text = ""
        Email_id.Text = ""
        State.Text = ""
        Pincode.Text = ""
        Address.Text = ""
        Salary.Text = ""
        Status.Text = ""
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        cmd = New SqlCommand("select * from Employees where Employee_Name='" + E_Name.Text + "'", cn)
        dr = cmd.ExecuteReader
        If dr.Read Then
            MsgBox("Record found")
        Else
            MsgBox("record does not exist")
        End If
        DataGridView1.DataSource = dr
        dr.Close()
        ds = New DataSet
        tables = ds.Tables
        da = New SqlDataAdapter("select * from Employees where Employee_Name='" + E_Name.Text + "'", cn)
        da.Fill(ds, "additem")
        '
        Dim dt As New DataTable()
        da.Fill(dt)
        DataGridView1.DataSource = dt
        '
        Dim view1 As New DataView(tables(0))
        bs.DataSource = view1
        DataGridView1.DataSource = view1
    End Sub
    Public Sub disp_data()
        cmd = cn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Employees"
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ' TextBox1.Text = row.Cells(0).Value.ToString
            E_Name.Text = row.Cells(1).Value.ToString
            F_Name.Text = row.Cells(2).Value.ToString
            DateTimePicker1.Text = row.Cells(3).Value.ToString
            Aadhar.Text = row.Cells(4).Value.ToString
            Mobile_Number.Text = row.Cells(5).Value.ToString
            Email_id.Text = row.Cells(6).Value.ToString
            DateTimePicker2.Text = row.Cells(7).Value.ToString
            State.Text = row.Cells(8).Value.ToString
            Pincode.Text = row.Cells(9).Value.ToString
            genders = row.Cells(10).Value.ToString
            Address.Text = row.Cells(11).Value.ToString
            Salary.Text = row.Cells(12).Value.ToString
            Status.Text = row.Cells(13).Value.ToString
        End If
    End Sub
    Private Sub TextBox2_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles E_Name.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub TextBox3_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles F_Name.KeyPress
        If Not Char.IsLetter(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub

    Private Sub TextBox4_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Aadhar.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub TextBox7_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles Pincode.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
    Private Sub Btn_Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Save.Click
        cmd = New SqlCommand("insert into Employees values('" + E_Name.Text + "','" + F_Name.Text + "','" + DateTimePicker1.Text + "','" + Aadhar.Text + "','" + Mobile_Number.Text + "','" + Email_id.Text + "','" + DateTimePicker2.Text + "','" + State.Text + "','" + Pincode.Text + "','" + gender.Text + "','" + Address.Text + "','" + Salary.Text + "','" + Status.Text + "')", cn)
        cmd.ExecuteNonQuery()
        disp_data()
        MsgBox("record saved!")
        cleardata()
    End Sub
    Private Sub btn_Addnew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_Addnew.Click
        'Enabled The TextBox'
        E_Name.Enabled = True
        F_Name.Enabled = True
        DateTimePicker1.Enabled = True
        Aadhar.Enabled = True
        Mobile_Number.Enabled = True
        Email_id.Enabled = True
        DateTimePicker2.Enabled = True
        State.Enabled = True
        Pincode.Enabled = True
        gender.Enabled = False
        Address.Enabled = True
        Salary.Enabled = True
        Status.Enabled = True
        'Enabled The Button'
        Btn_Save.Enabled = True
        Btn_Update.Enabled = True
        Btn_Delete.Enabled = True
        Btn_Search.Enabled = True
    End Sub
    Private Sub Btn_Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Update.Click
        cmd = New SqlCommand("update  Employees  set Father_Name='" + F_Name.Text + "',Date_of_Birth='" + DateTimePicker1.Text + "',Aadhar_Card_No='" + Aadhar.Text + "',Mobile_Number='" + Mobile_Number.Text + "',Email_id='" + Email_id.Text + "',Date_Of_Joing='" + DateTimePicker2.Text + "',State='" + State.Text + "',Pincode='" + Pincode.Text + "',Gender='" + gender.Text + "',Address='" + Address.Text + "',Salary='" + Salary.Text + "',Status='" + Status.Text + "' where Employee_Name ='" + E_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        disp_data()
        MsgBox("records updated!")
        Call cleardata()
    End Sub
    Private Sub Btn_Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btn_Delete.Click
        cmd = New SqlCommand("delete from Employees where Employee_Name='" + E_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        disp_data()
        MsgBox("record deleted!")
        Call cleardata()
    End Sub

    Private Sub SearchName_Enter(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchName.Enter
        'Username Text Disapper
        Dim Search_Name As String = SearchName.Text
        If Search_Name.Trim().ToLower() = "searchname" Or Search_Name.Trim() = "" Then
            SearchName.Text = ""
            SearchName.ForeColor = Color.Gray
        End If
    End Sub

    Private Sub SearchName_Leave(ByVal sender As Object, ByVal e As System.EventArgs) Handles SearchName.Leave
        'Username Text Apper
        Dim Search_Name As String = SearchName.Text
        If Search_Name.Trim().ToLower() = "searchname" Or Search_Name.Trim() = "" Then
            SearchName.Text = "searchname"
            SearchName.ForeColor = Color.Gray
        End If
    End Sub
End Class

 
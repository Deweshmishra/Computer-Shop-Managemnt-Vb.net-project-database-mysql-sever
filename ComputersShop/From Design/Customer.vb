Imports System.Data.SqlClient
Public Class Customer
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim genders As String
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
  

    Private Sub Customer_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Deabled The TextBox'
        C_Name.Enabled = False
        Aadhar_Card.Enabled = False
        Mobile_No.Enabled = False
        Email_Id.Enabled = False
        Gender.Enabled = False
        DateTimePicker1.Enabled = False
        City.Enabled = False
        State.Enabled = False
        Pin_Code.Enabled = False
        Aadress.Enabled = False
        'Dsabled The Button'
        Save.Enabled = False
        Updates.Enabled = False
        Delete.Enabled = False
        'TODO: This line of code loads data into the 'CustomerReportDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.CustomerReportDataSet.Customer)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub

  Private Sub Save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        cmd = New SqlCommand("insert into Customer values('" + C_Name.Text + "','" + Aadhar_Card.Text + "','" + Mobile_No.Text + "','" + Email_Id.Text + "','" + Gender.Text + "','" + DateTimePicker1.Text + "','" + State.Text + "','" + City.Text + "','" + Pin_Code.Text + "','" + Aadress.Text + "')", cn)
        cmd.ExecuteNonQuery()
        disp_data()
        MsgBox("record saved!")
    End Sub
    Private Sub Updatess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Updates.Click
        cmd = New SqlCommand("update  Customer  set C_Name='" + C_Name.Text + "',Aadhar_Card_No='" + Aadhar_Card.Text + "',Mobile_No='" + Mobile_No.Text + "',Email_Id='" + Email_Id.Text + "',Gender='" + Gender.Text + "',Date_Of_Birth='" + DateTimePicker1.Text + "',State='" + State.Text + "',City='" + City.Text + "',Pin_Code='" + City.Text + "',Aadress='" + Aadress.Text + "'", cn)
        cmd.ExecuteNonQuery()
        disp_data()
        MsgBox("records updated!")
    End Sub
    Public Sub disp_data()
        cmd = cn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select * from Customer"
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
            C_Name.Text = row.Cells(1).Value.ToString
            Aadhar_Card.Text = row.Cells(2).Value.ToString
            Mobile_No.Text = row.Cells(3).Value.ToString
            Email_Id.Text = row.Cells(4).Value.ToString
            Gender.Text = row.Cells(5).Value.ToString
            DateTimePicker1.Text = row.Cells(6).Value.ToString
            State.Text = row.Cells(7).Value.ToString
            City.Text = row.Cells(8).Value.ToString
            Pin_Code.Text = row.Cells(9).Value.ToString
            Aadress.Text = row.Cells(10).Value.ToString
        End If
    End Sub
    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        cmd = New SqlCommand("delete from Customer where C_Name='" + C_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        disp_data()
        MsgBox("record deleted!")
    End Sub
    Private Sub sea_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Btnsearch.Click
        cmd = cn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " Select * from Customer where C_Name='" + Search.Text + " ' "
        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub AddNew_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AddNew.Click
        'Enabled The TextBox'
        C_Name.Enabled = True
        Aadhar_Card.Enabled = True
        Mobile_No.Enabled = True
        Email_Id.Enabled = True
        Gender.Enabled = True
        DateTimePicker1.Enabled = True
        City.Enabled = True
        State.Enabled = True
        Pin_Code.Enabled = True
        Aadress.Enabled = True
        'Enabled The Button'
        Save.Enabled = True
        Updates.Enabled = True
        Delete.Enabled = True
        Search.Enabled = True
    End Sub

   
End Class
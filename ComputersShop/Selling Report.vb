Imports System.Data.SqlClient
Public Class Selling_Report
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Private Sub Selling_Report_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesReportsForBillDataSet.Sales' table. You can move, or remove it, as needed.
        Me.SalesTableAdapter.Fill(Me.SalesReportsForBillDataSet.Sales)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim form As New Billing

        form.p_id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        form.Products_name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        form.S_brand.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        form.S_Warranty.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        form.S_Ram.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        form.S_Hdd.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        form.S_Storage.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        form.S_Processor.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        form.S_Services.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        form.S_Quantity.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        form.S_Sub_Total.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        form.S_Cname.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        form.S_Address.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        form.S_Date.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        form.S_Quantity.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        form.S_GST.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
        form.S_Services_Charge.Text = DataGridView1.CurrentRow.Cells(16).Value.ToString
        form.S_Total.Text = DataGridView1.CurrentRow.Cells(17).Value.ToString
        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = cn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = "Select  * from Sales Where P_Name='" + P_Name.Text + "' OR Date ='" + DateTimePicker1.Text + "'"

        cmd.ExecuteNonQuery()
        Dim dt As New DataTable()
        Dim da As New SqlDataAdapter(cmd)
        da.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

   
End Class
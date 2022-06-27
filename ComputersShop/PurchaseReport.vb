Imports System.Data.SqlClient
Public Class PurchaseReport
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Private Sub PurchaseReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'PurchaseReportSalelDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.PurchaseReportSalelDataSet.Stock)

        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub

    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim form As New Sales

        'form.Vendor_Id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        form.P_Name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        form.Brand.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        form.Warranty.Text = DataGridView1.CurrentRow.Cells(3).Value.ToString
        form.Ram.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        form.hdd.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        form.Storage.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        form.Processor.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        form.Service.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        form.P_Quantity.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        form.Price.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        cmd = cn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " Select * from Stock where P_Name='" + P_Name.Text + " ' "
        cmd.ExecuteNonQuery()
    End Sub
End Class
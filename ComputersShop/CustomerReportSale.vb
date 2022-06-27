Imports System.Data.SqlClient
Public Class CustomerReportSale
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs)
        Dim form As New Sales

        'form.Vendor_Id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        form.Customer.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString

        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub CustomerReportSale_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SalesCustomerReportNewDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter1.Fill(Me.SalesCustomerReportNewDataSet.Customer)
        'TODO: This line of code loads data into the 'CustomerRepoertsaleDataSet.Customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.CustomerRepoertsaleDataSet.Customer)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub

    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim form As New Sales

        'form.Vendor_Id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        form.Customer.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        form.Aadhar.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        Me.Hide()
        form.ShowDialog()
    End Sub
End Class
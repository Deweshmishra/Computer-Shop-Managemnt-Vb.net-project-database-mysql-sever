Imports System.Data.SqlClient
Public Class VendorReport
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Private Sub DataGridView1_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        Dim form As New Vendors

        'form.Vendor_Id.Text = DataGridView1.CurrentRow.Cells(0).Value.ToString
        form.First_Name.Text = DataGridView1.CurrentRow.Cells(1).Value.ToString
        form.Last_Name.Text = DataGridView1.CurrentRow.Cells(2).Value.ToString
        'form.DOB.Text = DataGridView1.CurrentRow.Cells(3).Value.ToShortTimeString
        form.Gender.Text = DataGridView1.CurrentRow.Cells(4).Value.ToString
        form.Aadhar_No.Text = DataGridView1.CurrentRow.Cells(5).Value.ToString
        form.Pan_Card_No.Text = DataGridView1.CurrentRow.Cells(6).Value.ToString
        form.Mobile_No.Text = DataGridView1.CurrentRow.Cells(7).Value.ToString
        form.Email.Text = DataGridView1.CurrentRow.Cells(8).Value.ToString
        form.State.Text = DataGridView1.CurrentRow.Cells(9).Value.ToString
        form.City.Text = DataGridView1.CurrentRow.Cells(10).Value.ToString
        form.Pincode.Text = DataGridView1.CurrentRow.Cells(11).Value.ToString
        form.Address.Text = DataGridView1.CurrentRow.Cells(12).Value.ToString
        form.Account_No.Text = DataGridView1.CurrentRow.Cells(13).Value.ToString
        form.Bank_Address.Text = DataGridView1.CurrentRow.Cells(14).Value.ToString
        form.IFSC_Code.Text = DataGridView1.CurrentRow.Cells(15).Value.ToString
        Me.Hide()
        form.ShowDialog()
    End Sub

    Private Sub VendorReport_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'VendorReportDataSetNew.VendorTable' table. You can move, or remove it, as needed.
        Me.VendorTableTableAdapter.Fill(Me.VendorReportDataSetNew.VendorTable)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub
End Class
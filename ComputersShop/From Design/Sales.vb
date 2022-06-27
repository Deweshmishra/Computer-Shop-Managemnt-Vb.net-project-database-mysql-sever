Imports System.Data.SqlClient
Public Class Sales
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim qr As New SqlCommand
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Sales_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'ComputersShopSALESREPORTDataSet2.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter2.Fill(Me.ComputersShopSALESREPORTDataSet2.Stock)
        'Enabled The TextBox'
        P_Name.Enabled = False
        BRAND.Enabled = False
        Warranty.Enabled = False
        Ram.Enabled = False
        HDD.Enabled = False
        Storage.Enabled = False
        Processor.Enabled = False
        Service.Enabled = False
        P_Quantity.Enabled = False
        Price.Enabled = False
        'TODO: This line of code loads data into the 'SalesPurchaseReportDataSet.Stock' table. You can move, or remove it, as needed.
        Me.StockTableAdapter.Fill(Me.SalesPurchaseReportDataSet.Stock)
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub
    Private Sub Product_Button_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Product_Button.Click
        cmd = cn.CreateCommand()
        cmd.CommandType = CommandType.Text
        cmd.CommandText = " Select * from Stock where P_Name='" + P_Name.Text + " ' "
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.Hide()
        CustomerReportSale.Show()
    End Sub
    Private Function IsFormValid() As Boolean
        If (P_Name.Text.Trim() = String.Empty) Then
            MsgBox("Name Is Requird", MsgBoxStyle.Critical)
            BRAND.Clear()
            Warranty.Clear()
            Return False
        End If
        Return True
    End Function
    Private Sub DataGridView1_CellContentClick_1(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
            ' TextBox1.Text = row.Cells(0).Value.ToString
            P_Name.Text = row.Cells(1).Value.ToString
            BRAND.Text = row.Cells(2).Value.ToString
            Warranty.Text = row.Cells(3).Value.ToString
            Ram.Text = row.Cells(4).Value.ToString
            HDD.Text = row.Cells(5).Value.ToString
            Storage.Text = row.Cells(6).Value.ToString
            Processor.Text = row.Cells(7).Value.ToString
            Service.Text = row.Cells(8).Value.ToString
            P_Quantity.Text = row.Cells(9).Value.ToString
            Price.Text = row.Cells(10).Value.ToString
        End If
    End Sub
    Private Sub TextBox24_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles recived.KeyUp
        Dim tot, rcash, num As Integer
        tot = Val(Total_Amount.Text)
        rcash = Val(recived.Text)
        If rcash = tot Then
            Change.Text = 0
        ElseIf rcash > tot Then
            num = rcash - tot
            Change.Text = num.ToString()
        ElseIf rcash < tot Then
            num = rcash - tot
            Change.Text = num.ToString()
        End If

    End Sub
    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        cmd = New SqlCommand("Insert into Sales Values('" + P_Name.Text + " ',' " + BRAND.Text + "','" + Warranty.Text + "','" + Ram.Text + "','" + HDD.Text + "','" + Storage.Text + "','" + Processor.Text + "','" + Service.Text + "','" + P_Quantity.Text + "','" + Price.Text + "','" + Customer.Text + "','" + Aadhar.Text + "','" + DateTimePicker1.Text + "','" + S_Quantity.Text + "','" + S_Price.Text + "','" + Gst.Text + "','" + Services_charge.Text + "','" + Total_Amount.Text + "')", cn)
        cmd.ExecuteNonQuery()
        updatestock()
        Me.Hide()
        Selling_Report.Show()
        MsgBox("Successfully Sales")
    End Sub
    Public Sub updatestock()
        Dim a As String
        a = Val(P_Quantity.Text) - Val(S_Quantity.Text)
        cmd = New SqlCommand("update  Stock  set Quantity='" + a + "' where P_Name ='" + P_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
    End Sub
    Private Sub S_Price_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles S_Price.TextChanged
        Dim tot, rcash, num As Integer
        tot = Val(S_Quantity.Text)
        rcash = Val(S_Price.Text)
        If rcash = tot Then
            Gst.Text = 0
        ElseIf rcash < tot Then
            num = rcash * tot
            Gst.Text = num.ToString()
            Total_Amount.Text = S_Price.Text + Gst.Text
        ElseIf rcash > tot Then
            num = rcash * tot
            Gst.Text = num.ToString()
            Total_Amount.Text = S_Price.Text + Gst.Text
        End If
    End Sub
    Private Sub S_Quantity_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles S_Quantity.KeyPress
        If Not Char.IsNumber(e.KeyChar) And Not e.KeyChar = Chr(Keys.Delete) And Not e.KeyChar = Chr(Keys.Back) And Not e.KeyChar = Chr(Keys.Space) Then
            e.Handled = True
            MessageBox.Show("This Filed Accept Letter Only")
        End If
    End Sub
End Class
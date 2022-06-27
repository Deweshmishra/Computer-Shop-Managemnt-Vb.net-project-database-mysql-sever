Imports System.Data.SqlClient
Public Class Vendors
    Dim cmd As New SqlCommand
    Dim cn As New SqlConnection
    Dim genders As String
    Dim dr As SqlDataReader
    Dim ds As DataSet
    Dim tables As DataTableCollection
    Dim bs As New BindingSource
    Dim da As New SqlDataAdapter
    Private Sub Vendors_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Gender.Items.Add("Male")
        Gender.Items.Add("Female")
        Gender.Items.Add("Other")
        State.Items.Add("Bhilai")
        State.Items.Add("Raipur")
        State.Items.Add("Rajnadgaon")
        cn = New SqlConnection("Data Source=.\SQLEXPRESS;AttachDbFilename=D:\ComputerShop\ComputersShop\ComputersShop\ComputersShop\ComputersShop.mdf;Integrated Security=True;User Instance=True")
        cn.Open()
    End Sub
    Public Sub cleardata()
        First_Name.Text = ""
        Last_Name.Text = ""
        DOB.Text = ""
        Gender.Text = ""
        Aadhar_No.Text = ""
        Pan_Card_No.Text = ""
        Mobile_No.Text = ""
        Email.Text = ""
        State.Text = ""
        City.Text = ""
        Pincode.Text = ""
        Address.Text = ""
        Account_No.Text = ""
        Bank_Address.Text = ""
        IFSC_Code.Text = ""
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Save.Click
        cmd = New SqlCommand("insert into VendorTable values('" + First_Name.Text + "','" + Last_Name.Text + "','" + DOB.Text + "','" + Gender.Text + "','" + Aadhar_No.Text + "','" + Pan_Card_No.Text + "','" + Mobile_No.Text + "','" + Email.Text + "','" + State.Text + "','" + City.Text + "','" + Pincode.Text + "','" + Address.Text + "','" + Account_No.Text + "','" + Bank_Address.Text + "','" + IFSC_Code.Text + "')", cn)
        cmd.ExecuteNonQuery()
        Call cleardata()
        MsgBox("record saved!")
    End Sub

    Private Sub Update_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Updates.Click
        cmd = New SqlCommand("update  VendorTable  set Last_Name='" + Last_Name.Text + "',DOB='" + DOB.Text + "',Gender='" + Gender.Text + "',Aadhar_Card_Number='" + Aadhar_No.Text + "',Pan_Card_Number='" + Pan_Card_No.Text + "',Mobile_Number='" + Mobile_No.Text + "',Email='" + Email.Text + "',State='" + State.Text + "',City='" + City.Text + "',Pincode='" + Pincode.Text + "',Address='" + Address.Text + "',Account_Number='" + Account_No.Text + "',Bank_Number='" + Bank_Address.Text + "',IFSC_Code='" + IFSC_Code.Text + "' where First_Name ='" + First_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("records updated!")
        Call cleardata()
    End Sub



    Private Sub Delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Delete.Click
        cmd = New SqlCommand("delete from VendorTable where First_Name='" + First_Name.Text + "'", cn)
        cmd.ExecuteNonQuery()
        MsgBox("record deleted!")
        Call cleardata()
    End Sub

    Private Sub View_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles View.Click
        Me.Hide()
        VendorReport.Show()
    End Sub

    Private Sub Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clear.Click
        Call cleardata()
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Sales
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Sales))
        Me.P_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BRAND = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Warranty = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ram = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.HDD = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Storage = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Processor = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Service = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.P_Quantity = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBox9 = New System.Windows.Forms.TextBox()
        Me.Product_Button = New System.Windows.Forms.Button()
        Me.Customer = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Change = New System.Windows.Forms.TextBox()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.recived = New System.Windows.Forms.TextBox()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Total_Amount = New System.Windows.Forms.TextBox()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Services_charge = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.S_Price = New System.Windows.Forms.TextBox()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Gst = New System.Windows.Forms.TextBox()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.S_Quantity = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.SalesPurchaseReportDataSet = New ComputersShop.SalesPurchaseReportDataSet()
        Me.StockBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter = New ComputersShop.SalesPurchaseReportDataSetTableAdapters.StockTableAdapter()
        Me.SalesReportsDataSEt = New ComputersShop.SalesReportsDataSEt()
        Me.StockBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.StockTableAdapter1 = New ComputersShop.SalesReportsDataSEtTableAdapters.StockTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.PidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.BrandDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.WarrantyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RamDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HddSddDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StorageDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QuantityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StockBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComputersShopSALESREPORTDataSet2 = New ComputersShop.ComputersShopSALESREPORTDataSet2()
        Me.Aadhar = New System.Windows.Forms.TextBox()
        Me.p = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.StockTableAdapter2 = New ComputersShop.ComputersShopSALESREPORTDataSet2TableAdapters.StockTableAdapter()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SalesPurchaseReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesReportsDataSEt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ComputersShopSALESREPORTDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'P_Name
        '
        Me.P_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Name.Location = New System.Drawing.Point(157, 52)
        Me.P_Name.Name = "P_Name"
        Me.P_Name.Size = New System.Drawing.Size(190, 26)
        Me.P_Name.TabIndex = 106
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(27, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 105
        Me.Label2.Text = " Products Name"
        '
        'BRAND
        '
        Me.BRAND.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BRAND.Location = New System.Drawing.Point(157, 83)
        Me.BRAND.Name = "BRAND"
        Me.BRAND.Size = New System.Drawing.Size(190, 26)
        Me.BRAND.TabIndex = 108
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(32, 88)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "Brand"
        '
        'Warranty
        '
        Me.Warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warranty.Location = New System.Drawing.Point(157, 114)
        Me.Warranty.Name = "Warranty"
        Me.Warranty.Size = New System.Drawing.Size(190, 26)
        Me.Warranty.TabIndex = 110
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(29, 119)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 109
        Me.Label3.Text = "Warranty"
        '
        'Ram
        '
        Me.Ram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ram.Location = New System.Drawing.Point(157, 144)
        Me.Ram.Name = "Ram"
        Me.Ram.Size = New System.Drawing.Size(190, 26)
        Me.Ram.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(29, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "RAM"
        '
        'HDD
        '
        Me.HDD.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.HDD.Location = New System.Drawing.Point(157, 174)
        Me.HDD.Name = "HDD"
        Me.HDD.Size = New System.Drawing.Size(190, 26)
        Me.HDD.TabIndex = 114
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(29, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 113
        Me.Label5.Text = "HDD/SDD"
        '
        'Storage
        '
        Me.Storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Storage.Location = New System.Drawing.Point(157, 205)
        Me.Storage.Name = "Storage"
        Me.Storage.Size = New System.Drawing.Size(190, 26)
        Me.Storage.TabIndex = 116
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(29, 210)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Storage"
        '
        'Processor
        '
        Me.Processor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processor.Location = New System.Drawing.Point(157, 235)
        Me.Processor.Name = "Processor"
        Me.Processor.Size = New System.Drawing.Size(190, 26)
        Me.Processor.TabIndex = 118
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(29, 240)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 117
        Me.Label7.Text = "Processor"
        '
        'Service
        '
        Me.Service.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Service.Location = New System.Drawing.Point(512, 52)
        Me.Service.Name = "Service"
        Me.Service.Size = New System.Drawing.Size(190, 26)
        Me.Service.TabIndex = 120
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(384, 57)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(98, 19)
        Me.Label8.TabIndex = 119
        Me.Label8.Text = "Services Code"
        '
        'P_Quantity
        '
        Me.P_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Quantity.Location = New System.Drawing.Point(512, 85)
        Me.P_Quantity.Name = "P_Quantity"
        Me.P_Quantity.Size = New System.Drawing.Size(190, 26)
        Me.P_Quantity.TabIndex = 122
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(384, 90)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(60, 19)
        Me.Label9.TabIndex = 121
        Me.Label9.Text = "Quantity"
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(512, 118)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(190, 26)
        Me.Price.TabIndex = 124
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(384, 123)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(40, 19)
        Me.Label10.TabIndex = 123
        Me.Label10.Text = "Price"
        '
        'TextBox9
        '
        Me.TextBox9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox9.Location = New System.Drawing.Point(781, 74)
        Me.TextBox9.Name = "TextBox9"
        Me.TextBox9.Size = New System.Drawing.Size(141, 26)
        Me.TextBox9.TabIndex = 125
        '
        'Product_Button
        '
        Me.Product_Button.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Product_Button.Location = New System.Drawing.Point(957, 72)
        Me.Product_Button.Name = "Product_Button"
        Me.Product_Button.Size = New System.Drawing.Size(127, 27)
        Me.Product_Button.TabIndex = 126
        Me.Product_Button.Text = "Search"
        Me.Product_Button.UseVisualStyleBackColor = False
        '
        'Customer
        '
        Me.Customer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Customer.Location = New System.Drawing.Point(512, 167)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(190, 26)
        Me.Customer.TabIndex = 129
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(379, 171)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(109, 19)
        Me.Label11.TabIndex = 128
        Me.Label11.Text = "Customer Name"
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button6.Location = New System.Drawing.Point(159, 84)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(99, 42)
        Me.Button6.TabIndex = 149
        Me.Button6.Text = "CUSTOMER"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Location = New System.Drawing.Point(765, 49)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(335, 66)
        Me.GroupBox2.TabIndex = 150
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Products Details Search"
        '
        'GroupBox4
        '
        Me.GroupBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GroupBox4.Controls.Add(Me.DateTimePicker1)
        Me.GroupBox4.Controls.Add(Me.Label12)
        Me.GroupBox4.Controls.Add(Me.Change)
        Me.GroupBox4.Controls.Add(Me.Label28)
        Me.GroupBox4.Controls.Add(Me.Label27)
        Me.GroupBox4.Controls.Add(Me.recived)
        Me.GroupBox4.Controls.Add(Me.Button9)
        Me.GroupBox4.Controls.Add(Me.Label26)
        Me.GroupBox4.Controls.Add(Me.Total_Amount)
        Me.GroupBox4.Controls.Add(Me.Label25)
        Me.GroupBox4.Controls.Add(Me.Services_charge)
        Me.GroupBox4.Controls.Add(Me.Label23)
        Me.GroupBox4.Controls.Add(Me.S_Price)
        Me.GroupBox4.Controls.Add(Me.Label24)
        Me.GroupBox4.Controls.Add(Me.Gst)
        Me.GroupBox4.Controls.Add(Me.Label22)
        Me.GroupBox4.Controls.Add(Me.S_Quantity)
        Me.GroupBox4.Controls.Add(Me.Label21)
        Me.GroupBox4.Location = New System.Drawing.Point(765, 146)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(335, 367)
        Me.GroupBox4.TabIndex = 152
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Payment"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(169, 30)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(150, 26)
        Me.DateTimePicker1.TabIndex = 169
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(12, 277)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(55, 19)
        Me.Label12.TabIndex = 168
        Me.Label12.Text = "Change"
        '
        'Change
        '
        Me.Change.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Change.Location = New System.Drawing.Point(169, 271)
        Me.Change.Name = "Change"
        Me.Change.Size = New System.Drawing.Size(150, 26)
        Me.Change.TabIndex = 167
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(13, 318)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(135, 39)
        Me.Label28.TabIndex = 166
        Me.Label28.Text = "Note :- One time Payment " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Record Cannot Be Deleted" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "So Carry Full"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.Location = New System.Drawing.Point(12, 245)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(58, 19)
        Me.Label27.TabIndex = 165
        Me.Label27.Text = "Recived"
        '
        'recived
        '
        Me.recived.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.recived.Location = New System.Drawing.Point(169, 239)
        Me.recived.Name = "recived"
        Me.recived.Size = New System.Drawing.Size(150, 26)
        Me.recived.TabIndex = 164
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button9.Location = New System.Drawing.Point(169, 318)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(150, 43)
        Me.Button9.TabIndex = 151
        Me.Button9.Text = "Check Out"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.Location = New System.Drawing.Point(12, 210)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(90, 19)
        Me.Label26.TabIndex = 163
        Me.Label26.Text = "Total Amount"
        '
        'Total_Amount
        '
        Me.Total_Amount.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total_Amount.Location = New System.Drawing.Point(169, 204)
        Me.Total_Amount.Name = "Total_Amount"
        Me.Total_Amount.Size = New System.Drawing.Size(150, 26)
        Me.Total_Amount.TabIndex = 162
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label25.Location = New System.Drawing.Point(12, 174)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(108, 19)
        Me.Label25.TabIndex = 161
        Me.Label25.Text = "Services Charge"
        '
        'Services_charge
        '
        Me.Services_charge.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Services_charge.Location = New System.Drawing.Point(169, 169)
        Me.Services_charge.Name = "Services_charge"
        Me.Services_charge.Size = New System.Drawing.Size(150, 26)
        Me.Services_charge.TabIndex = 160
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.Location = New System.Drawing.Point(12, 137)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(59, 19)
        Me.Label23.TabIndex = 159
        Me.Label23.Text = "Gst%24"
        '
        'S_Price
        '
        Me.S_Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_Price.Location = New System.Drawing.Point(169, 101)
        Me.S_Price.Name = "S_Price"
        Me.S_Price.Size = New System.Drawing.Size(150, 26)
        Me.S_Price.TabIndex = 158
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.Location = New System.Drawing.Point(12, 103)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(83, 19)
        Me.Label24.TabIndex = 157
        Me.Label24.Text = "Selling Price"
        '
        'Gst
        '
        Me.Gst.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gst.Location = New System.Drawing.Point(169, 134)
        Me.Gst.Name = "Gst"
        Me.Gst.Size = New System.Drawing.Size(150, 26)
        Me.Gst.TabIndex = 156
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(12, 72)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(60, 19)
        Me.Label22.TabIndex = 155
        Me.Label22.Text = "Quantity"
        '
        'S_Quantity
        '
        Me.S_Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.S_Quantity.Location = New System.Drawing.Point(169, 68)
        Me.S_Quantity.Name = "S_Quantity"
        Me.S_Quantity.Size = New System.Drawing.Size(150, 26)
        Me.S_Quantity.TabIndex = 154
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(12, 39)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(38, 19)
        Me.Label21.TabIndex = 153
        Me.Label21.Text = "Date"
        '
        'SalesPurchaseReportDataSet
        '
        Me.SalesPurchaseReportDataSet.DataSetName = "SalesPurchaseReportDataSet"
        Me.SalesPurchaseReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource
        '
        Me.StockBindingSource.DataMember = "Stock"
        Me.StockBindingSource.DataSource = Me.SalesPurchaseReportDataSet
        '
        'StockTableAdapter
        '
        Me.StockTableAdapter.ClearBeforeFill = True
        '
        'SalesReportsDataSEt
        '
        Me.SalesReportsDataSEt.DataSetName = "SalesReportsDataSEt"
        Me.SalesReportsDataSEt.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'StockBindingSource1
        '
        Me.StockBindingSource1.DataMember = "Stock"
        Me.StockBindingSource1.DataSource = Me.SalesReportsDataSEt
        '
        'StockTableAdapter1
        '
        Me.StockTableAdapter1.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.PidDataGridViewTextBoxColumn, Me.PNameDataGridViewTextBoxColumn, Me.BrandDataGridViewTextBoxColumn, Me.WarrantyDataGridViewTextBoxColumn, Me.RamDataGridViewTextBoxColumn, Me.HddSddDataGridViewTextBoxColumn, Me.StorageDataGridViewTextBoxColumn, Me.ProcessorDataGridViewTextBoxColumn, Me.SCodeDataGridViewTextBoxColumn, Me.QuantityDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.StockBindingSource2
        Me.DataGridView1.Location = New System.Drawing.Point(36, 290)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(709, 223)
        Me.DataGridView1.TabIndex = 153
        '
        'PidDataGridViewTextBoxColumn
        '
        Me.PidDataGridViewTextBoxColumn.DataPropertyName = "P_id"
        Me.PidDataGridViewTextBoxColumn.HeaderText = "P_id"
        Me.PidDataGridViewTextBoxColumn.Name = "PidDataGridViewTextBoxColumn"
        Me.PidDataGridViewTextBoxColumn.ReadOnly = True
        '
        'PNameDataGridViewTextBoxColumn
        '
        Me.PNameDataGridViewTextBoxColumn.DataPropertyName = "P_Name"
        Me.PNameDataGridViewTextBoxColumn.HeaderText = "P_Name"
        Me.PNameDataGridViewTextBoxColumn.Name = "PNameDataGridViewTextBoxColumn"
        '
        'BrandDataGridViewTextBoxColumn
        '
        Me.BrandDataGridViewTextBoxColumn.DataPropertyName = "Brand"
        Me.BrandDataGridViewTextBoxColumn.HeaderText = "Brand"
        Me.BrandDataGridViewTextBoxColumn.Name = "BrandDataGridViewTextBoxColumn"
        '
        'WarrantyDataGridViewTextBoxColumn
        '
        Me.WarrantyDataGridViewTextBoxColumn.DataPropertyName = "Warranty"
        Me.WarrantyDataGridViewTextBoxColumn.HeaderText = "Warranty"
        Me.WarrantyDataGridViewTextBoxColumn.Name = "WarrantyDataGridViewTextBoxColumn"
        '
        'RamDataGridViewTextBoxColumn
        '
        Me.RamDataGridViewTextBoxColumn.DataPropertyName = "Ram"
        Me.RamDataGridViewTextBoxColumn.HeaderText = "Ram"
        Me.RamDataGridViewTextBoxColumn.Name = "RamDataGridViewTextBoxColumn"
        '
        'HddSddDataGridViewTextBoxColumn
        '
        Me.HddSddDataGridViewTextBoxColumn.DataPropertyName = "Hdd_Sdd"
        Me.HddSddDataGridViewTextBoxColumn.HeaderText = "Hdd_Sdd"
        Me.HddSddDataGridViewTextBoxColumn.Name = "HddSddDataGridViewTextBoxColumn"
        '
        'StorageDataGridViewTextBoxColumn
        '
        Me.StorageDataGridViewTextBoxColumn.DataPropertyName = "Storage"
        Me.StorageDataGridViewTextBoxColumn.HeaderText = "Storage"
        Me.StorageDataGridViewTextBoxColumn.Name = "StorageDataGridViewTextBoxColumn"
        '
        'ProcessorDataGridViewTextBoxColumn
        '
        Me.ProcessorDataGridViewTextBoxColumn.DataPropertyName = "Processor"
        Me.ProcessorDataGridViewTextBoxColumn.HeaderText = "Processor"
        Me.ProcessorDataGridViewTextBoxColumn.Name = "ProcessorDataGridViewTextBoxColumn"
        '
        'SCodeDataGridViewTextBoxColumn
        '
        Me.SCodeDataGridViewTextBoxColumn.DataPropertyName = "S_Code"
        Me.SCodeDataGridViewTextBoxColumn.HeaderText = "S_Code"
        Me.SCodeDataGridViewTextBoxColumn.Name = "SCodeDataGridViewTextBoxColumn"
        '
        'QuantityDataGridViewTextBoxColumn
        '
        Me.QuantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.HeaderText = "Quantity"
        Me.QuantityDataGridViewTextBoxColumn.Name = "QuantityDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'StockBindingSource2
        '
        Me.StockBindingSource2.DataMember = "Stock"
        Me.StockBindingSource2.DataSource = Me.ComputersShopSALESREPORTDataSet2
        '
        'ComputersShopSALESREPORTDataSet2
        '
        Me.ComputersShopSALESREPORTDataSet2.DataSetName = "ComputersShopSALESREPORTDataSet2"
        Me.ComputersShopSALESREPORTDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Aadhar
        '
        Me.Aadhar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aadhar.Location = New System.Drawing.Point(512, 201)
        Me.Aadhar.Name = "Aadhar"
        Me.Aadhar.Size = New System.Drawing.Size(190, 26)
        Me.Aadhar.TabIndex = 155
        '
        'p
        '
        Me.p.AutoSize = True
        Me.p.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.p.Location = New System.Drawing.Point(379, 205)
        Me.p.Name = "p"
        Me.p.Size = New System.Drawing.Size(89, 19)
        Me.p.TabIndex = 154
        Me.p.Text = "Aadhar Card"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(-239, -1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1767, 29)
        Me.Label15.TabIndex = 156
        Me.Label15.Text = resources.GetString("Label15.Text")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button6)
        Me.GroupBox1.Location = New System.Drawing.Point(366, 151)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(371, 133)
        Me.GroupBox1.TabIndex = 157
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "CUSTOMER DETAILS"
        '
        'StockTableAdapter2
        '
        Me.StockTableAdapter2.ClearBeforeFill = True
        '
        'Sales
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1138, 554)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Aadhar)
        Me.Controls.Add(Me.p)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Customer)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Product_Button)
        Me.Controls.Add(Me.TextBox9)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.P_Quantity)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Service)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Processor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Storage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.HDD)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ram)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Warranty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.BRAND)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P_Name)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Sales"
        Me.Text = "Sales"
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.SalesPurchaseReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesReportsDataSEt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StockBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ComputersShopSALESREPORTDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents P_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents BRAND As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Warranty As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ram As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents HDD As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Storage As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Processor As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Service As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents P_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Price As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TextBox9 As System.Windows.Forms.TextBox
    Friend WithEvents Product_Button As System.Windows.Forms.Button
    Friend WithEvents Customer As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents S_Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents recived As System.Windows.Forms.TextBox
    Friend WithEvents Button9 As System.Windows.Forms.Button
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents Total_Amount As System.Windows.Forms.TextBox
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Services_charge As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents S_Price As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents Gst As System.Windows.Forms.TextBox
    Friend WithEvents SalesPurchaseReportDataSet As ComputersShop.SalesPurchaseReportDataSet
    Friend WithEvents StockBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter As ComputersShop.SalesPurchaseReportDataSetTableAdapters.StockTableAdapter
    Friend WithEvents SalesReportsDataSEt As ComputersShop.SalesReportsDataSEt
    Friend WithEvents StockBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter1 As ComputersShop.SalesReportsDataSEtTableAdapters.StockTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents PidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents BrandDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents WarrantyDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RamDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents HddSddDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StorageDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ProcessorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents QuantityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Aadhar As System.Windows.Forms.TextBox
    Friend WithEvents p As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Change As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents ComputersShopSALESREPORTDataSet2 As ComputersShop.ComputersShopSALESREPORTDataSet2
    Friend WithEvents StockBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents StockTableAdapter2 As ComputersShop.ComputersShopSALESREPORTDataSet2TableAdapters.StockTableAdapter
End Class

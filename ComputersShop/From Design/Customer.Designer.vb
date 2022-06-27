<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Customer))
        Me.C_Name = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Aadhar_Card = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Mobile_No = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Email_Id = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Gender = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.State = New System.Windows.Forms.ComboBox()
        Me.City = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Pin_Code = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Aadress = New System.Windows.Forms.TextBox()
        Me.Aadres = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Delete = New System.Windows.Forms.Button()
        Me.Updates = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.Search = New System.Windows.Forms.TextBox()
        Me.Btnsearch = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNameDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharCardNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNoDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIdDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinCodeDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadressDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerReportDataSet = New ComputersShop.CustomerReportDataSet()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomersDataSet2 = New ComputersShop.CustomersDataSet2()
        Me.CIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharCardNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GenderDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StateDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PinCodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.CustomerTableAdapter = New ComputersShop.CustomersDataSet2TableAdapters.CustomerTableAdapter()
        Me.CustomerTableAdapter1 = New ComputersShop.CustomerReportDataSetTableAdapters.CustomerTableAdapter()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerReportDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomersDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'C_Name
        '
        Me.C_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.C_Name.Location = New System.Drawing.Point(204, 49)
        Me.C_Name.Name = "C_Name"
        Me.C_Name.Size = New System.Drawing.Size(220, 26)
        Me.C_Name.TabIndex = 50
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(22, 54)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(124, 20)
        Me.Label2.TabIndex = 49
        Me.Label2.Text = "Customer Name"
        '
        'Aadhar_Card
        '
        Me.Aadhar_Card.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aadhar_Card.Location = New System.Drawing.Point(204, 91)
        Me.Aadhar_Card.Name = "Aadhar_Card"
        Me.Aadhar_Card.Size = New System.Drawing.Size(220, 26)
        Me.Aadhar_Card.TabIndex = 52
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 96)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(123, 20)
        Me.Label1.TabIndex = 51
        Me.Label1.Text = "Aadhar Card No"
        '
        'Mobile_No
        '
        Me.Mobile_No.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Mobile_No.Location = New System.Drawing.Point(204, 134)
        Me.Mobile_No.Name = "Mobile_No"
        Me.Mobile_No.Size = New System.Drawing.Size(220, 26)
        Me.Mobile_No.TabIndex = 54
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(22, 139)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(115, 20)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "Mobile Number"
        '
        'Email_Id
        '
        Me.Email_Id.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Email_Id.Location = New System.Drawing.Point(204, 177)
        Me.Email_Id.Name = "Email_Id"
        Me.Email_Id.Size = New System.Drawing.Size(220, 26)
        Me.Email_Id.TabIndex = 56
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(22, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(71, 20)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Email_Id"
        '
        'Gender
        '
        Me.Gender.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Gender.FormattingEnabled = True
        Me.Gender.Items.AddRange(New Object() {"Male", "Female", "Other"})
        Me.Gender.Location = New System.Drawing.Point(204, 218)
        Me.Gender.Name = "Gender"
        Me.Gender.Size = New System.Drawing.Size(220, 28)
        Me.Gender.TabIndex = 57
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(22, 224)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(63, 20)
        Me.Label5.TabIndex = 58
        Me.Label5.Text = "Gender"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(474, 95)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 20)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "State"
        '
        'State
        '
        Me.State.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.State.FormattingEnabled = True
        Me.State.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Assam" & Global.Microsoft.VisualBasic.ChrW(9), "Bihar" & Global.Microsoft.VisualBasic.ChrW(9), "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9), "Goa" & Global.Microsoft.VisualBasic.ChrW(9), "Gujarat" & Global.Microsoft.VisualBasic.ChrW(9), "Haryana" & Global.Microsoft.VisualBasic.ChrW(9), "Himachal ", "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9), "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9), "Kerala" & Global.Microsoft.VisualBasic.ChrW(9), "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9), "Manipur", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9), "Mizoram" & Global.Microsoft.VisualBasic.ChrW(9), "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9), "Odisha", "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Rajasthan" & Global.Microsoft.VisualBasic.ChrW(9), "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Tripura", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "Gairsain", "West Bengal"})
        Me.State.Location = New System.Drawing.Point(598, 91)
        Me.State.Name = "State"
        Me.State.Size = New System.Drawing.Size(220, 28)
        Me.State.TabIndex = 59
        '
        'City
        '
        Me.City.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.City.Location = New System.Drawing.Point(598, 137)
        Me.City.Name = "City"
        Me.City.Size = New System.Drawing.Size(220, 26)
        Me.City.TabIndex = 62
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(474, 139)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 20)
        Me.Label7.TabIndex = 61
        Me.Label7.Text = "City"
        '
        'Pin_Code
        '
        Me.Pin_Code.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Pin_Code.Location = New System.Drawing.Point(598, 177)
        Me.Pin_Code.Name = "Pin_Code"
        Me.Pin_Code.Size = New System.Drawing.Size(220, 26)
        Me.Pin_Code.TabIndex = 64
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(474, 180)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(73, 20)
        Me.Label8.TabIndex = 63
        Me.Label8.Text = "Pin Code"
        '
        'Aadress
        '
        Me.Aadress.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aadress.Location = New System.Drawing.Point(598, 220)
        Me.Aadress.Multiline = True
        Me.Aadress.Name = "Aadress"
        Me.Aadress.Size = New System.Drawing.Size(220, 68)
        Me.Aadress.TabIndex = 66
        '
        'Aadres
        '
        Me.Aadres.AutoSize = True
        Me.Aadres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Aadres.Location = New System.Drawing.Point(474, 220)
        Me.Aadres.Name = "Aadres"
        Me.Aadres.Size = New System.Drawing.Size(68, 20)
        Me.Aadres.TabIndex = 65
        Me.Aadres.Text = "Aadress"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Delete)
        Me.GroupBox2.Controls.Add(Me.Updates)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Controls.Add(Me.AddNew)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(853, 48)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 157)
        Me.GroupBox2.TabIndex = 67
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buttons"
        '
        'Delete
        '
        Me.Delete.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Delete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Delete.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Delete.Location = New System.Drawing.Point(8, 125)
        Me.Delete.Name = "Delete"
        Me.Delete.Size = New System.Drawing.Size(130, 29)
        Me.Delete.TabIndex = 32
        Me.Delete.Text = "DELETE"
        Me.Delete.UseVisualStyleBackColor = False
        '
        'Updates
        '
        Me.Updates.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Updates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updates.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Updates.Location = New System.Drawing.Point(7, 90)
        Me.Updates.Name = "Updates"
        Me.Updates.Size = New System.Drawing.Size(130, 29)
        Me.Updates.TabIndex = 31
        Me.Updates.Text = "UPDATE"
        Me.Updates.UseVisualStyleBackColor = False
        '
        'Save
        '
        Me.Save.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Save.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Save.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Save.Location = New System.Drawing.Point(8, 55)
        Me.Save.Name = "Save"
        Me.Save.Size = New System.Drawing.Size(130, 29)
        Me.Save.TabIndex = 30
        Me.Save.Text = "SAVE"
        Me.Save.UseVisualStyleBackColor = False
        '
        'AddNew
        '
        Me.AddNew.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.AddNew.Location = New System.Drawing.Point(7, 20)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(130, 29)
        Me.AddNew.TabIndex = 29
        Me.AddNew.Text = "ADD NEW"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'Search
        '
        Me.Search.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Search.Location = New System.Drawing.Point(26, 270)
        Me.Search.Name = "Search"
        Me.Search.Size = New System.Drawing.Size(220, 26)
        Me.Search.TabIndex = 68
        '
        'Btnsearch
        '
        Me.Btnsearch.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Btnsearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btnsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Btnsearch.Location = New System.Drawing.Point(268, 267)
        Me.Btnsearch.Name = "Btnsearch"
        Me.Btnsearch.Size = New System.Drawing.Size(156, 29)
        Me.Btnsearch.TabIndex = 33
        Me.Btnsearch.Text = "SEARCH"
        Me.Btnsearch.UseVisualStyleBackColor = False
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIdDataGridViewTextBoxColumn1, Me.CNameDataGridViewTextBoxColumn1, Me.AadharCardNoDataGridViewTextBoxColumn1, Me.MobileNoDataGridViewTextBoxColumn1, Me.EmailIdDataGridViewTextBoxColumn1, Me.GenderDataGridViewTextBoxColumn1, Me.DateOfBirthDataGridViewTextBoxColumn1, Me.StateDataGridViewTextBoxColumn1, Me.CityDataGridViewTextBoxColumn1, Me.PinCodeDataGridViewTextBoxColumn1, Me.AadressDataGridViewTextBoxColumn1})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(26, 317)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(974, 181)
        Me.DataGridView1.TabIndex = 69
        '
        'CIdDataGridViewTextBoxColumn1
        '
        Me.CIdDataGridViewTextBoxColumn1.DataPropertyName = "C_Id"
        Me.CIdDataGridViewTextBoxColumn1.HeaderText = "C_Id"
        Me.CIdDataGridViewTextBoxColumn1.Name = "CIdDataGridViewTextBoxColumn1"
        Me.CIdDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'CNameDataGridViewTextBoxColumn1
        '
        Me.CNameDataGridViewTextBoxColumn1.DataPropertyName = "C_Name"
        Me.CNameDataGridViewTextBoxColumn1.HeaderText = "C_Name"
        Me.CNameDataGridViewTextBoxColumn1.Name = "CNameDataGridViewTextBoxColumn1"
        '
        'AadharCardNoDataGridViewTextBoxColumn1
        '
        Me.AadharCardNoDataGridViewTextBoxColumn1.DataPropertyName = "Aadhar_Card_No"
        Me.AadharCardNoDataGridViewTextBoxColumn1.HeaderText = "Aadhar_Card_No"
        Me.AadharCardNoDataGridViewTextBoxColumn1.Name = "AadharCardNoDataGridViewTextBoxColumn1"
        '
        'MobileNoDataGridViewTextBoxColumn1
        '
        Me.MobileNoDataGridViewTextBoxColumn1.DataPropertyName = "Mobile_No"
        Me.MobileNoDataGridViewTextBoxColumn1.HeaderText = "Mobile_No"
        Me.MobileNoDataGridViewTextBoxColumn1.Name = "MobileNoDataGridViewTextBoxColumn1"
        '
        'EmailIdDataGridViewTextBoxColumn1
        '
        Me.EmailIdDataGridViewTextBoxColumn1.DataPropertyName = "Email_Id"
        Me.EmailIdDataGridViewTextBoxColumn1.HeaderText = "Email_Id"
        Me.EmailIdDataGridViewTextBoxColumn1.Name = "EmailIdDataGridViewTextBoxColumn1"
        '
        'GenderDataGridViewTextBoxColumn1
        '
        Me.GenderDataGridViewTextBoxColumn1.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn1.Name = "GenderDataGridViewTextBoxColumn1"
        '
        'DateOfBirthDataGridViewTextBoxColumn1
        '
        Me.DateOfBirthDataGridViewTextBoxColumn1.DataPropertyName = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn1.HeaderText = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn1.Name = "DateOfBirthDataGridViewTextBoxColumn1"
        '
        'StateDataGridViewTextBoxColumn1
        '
        Me.StateDataGridViewTextBoxColumn1.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn1.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn1.Name = "StateDataGridViewTextBoxColumn1"
        '
        'CityDataGridViewTextBoxColumn1
        '
        Me.CityDataGridViewTextBoxColumn1.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn1.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn1.Name = "CityDataGridViewTextBoxColumn1"
        '
        'PinCodeDataGridViewTextBoxColumn1
        '
        Me.PinCodeDataGridViewTextBoxColumn1.DataPropertyName = "Pin_Code"
        Me.PinCodeDataGridViewTextBoxColumn1.HeaderText = "Pin_Code"
        Me.PinCodeDataGridViewTextBoxColumn1.Name = "PinCodeDataGridViewTextBoxColumn1"
        '
        'AadressDataGridViewTextBoxColumn1
        '
        Me.AadressDataGridViewTextBoxColumn1.DataPropertyName = "Aadress"
        Me.AadressDataGridViewTextBoxColumn1.HeaderText = "Aadress"
        Me.AadressDataGridViewTextBoxColumn1.Name = "AadressDataGridViewTextBoxColumn1"
        '
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.CustomerReportDataSet
        '
        'CustomerReportDataSet
        '
        Me.CustomerReportDataSet.DataSetName = "CustomerReportDataSet"
        Me.CustomerReportDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomersDataSet2
        '
        'CustomersDataSet2
        '
        Me.CustomersDataSet2.DataSetName = "CustomersDataSet2"
        Me.CustomersDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CIdDataGridViewTextBoxColumn
        '
        Me.CIdDataGridViewTextBoxColumn.DataPropertyName = "C_Id"
        Me.CIdDataGridViewTextBoxColumn.HeaderText = "C_Id"
        Me.CIdDataGridViewTextBoxColumn.Name = "CIdDataGridViewTextBoxColumn"
        Me.CIdDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CNameDataGridViewTextBoxColumn
        '
        Me.CNameDataGridViewTextBoxColumn.DataPropertyName = "C_Name"
        Me.CNameDataGridViewTextBoxColumn.HeaderText = "C_Name"
        Me.CNameDataGridViewTextBoxColumn.Name = "CNameDataGridViewTextBoxColumn"
        '
        'AadharCardNoDataGridViewTextBoxColumn
        '
        Me.AadharCardNoDataGridViewTextBoxColumn.DataPropertyName = "Aadhar_Card_No"
        Me.AadharCardNoDataGridViewTextBoxColumn.HeaderText = "Aadhar_Card_No"
        Me.AadharCardNoDataGridViewTextBoxColumn.Name = "AadharCardNoDataGridViewTextBoxColumn"
        '
        'MobileNoDataGridViewTextBoxColumn
        '
        Me.MobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No"
        Me.MobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No"
        Me.MobileNoDataGridViewTextBoxColumn.Name = "MobileNoDataGridViewTextBoxColumn"
        '
        'EmailIdDataGridViewTextBoxColumn
        '
        Me.EmailIdDataGridViewTextBoxColumn.DataPropertyName = "Email_Id"
        Me.EmailIdDataGridViewTextBoxColumn.HeaderText = "Email_Id"
        Me.EmailIdDataGridViewTextBoxColumn.Name = "EmailIdDataGridViewTextBoxColumn"
        '
        'GenderDataGridViewTextBoxColumn
        '
        Me.GenderDataGridViewTextBoxColumn.DataPropertyName = "Gender"
        Me.GenderDataGridViewTextBoxColumn.HeaderText = "Gender"
        Me.GenderDataGridViewTextBoxColumn.Name = "GenderDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "Date_Of_Birth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'StateDataGridViewTextBoxColumn
        '
        Me.StateDataGridViewTextBoxColumn.DataPropertyName = "State"
        Me.StateDataGridViewTextBoxColumn.HeaderText = "State"
        Me.StateDataGridViewTextBoxColumn.Name = "StateDataGridViewTextBoxColumn"
        '
        'CityDataGridViewTextBoxColumn
        '
        Me.CityDataGridViewTextBoxColumn.DataPropertyName = "City"
        Me.CityDataGridViewTextBoxColumn.HeaderText = "City"
        Me.CityDataGridViewTextBoxColumn.Name = "CityDataGridViewTextBoxColumn"
        '
        'PinCodeDataGridViewTextBoxColumn
        '
        Me.PinCodeDataGridViewTextBoxColumn.DataPropertyName = "Pin_Code"
        Me.PinCodeDataGridViewTextBoxColumn.HeaderText = "Pin_Code"
        Me.PinCodeDataGridViewTextBoxColumn.Name = "PinCodeDataGridViewTextBoxColumn"
        '
        'AadressDataGridViewTextBoxColumn
        '
        Me.AadressDataGridViewTextBoxColumn.DataPropertyName = "Aadress"
        Me.AadressDataGridViewTextBoxColumn.HeaderText = "Aadress"
        Me.AadressDataGridViewTextBoxColumn.Name = "AadressDataGridViewTextBoxColumn"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(474, 50)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(102, 20)
        Me.Label10.TabIndex = 70
        Me.Label10.Text = "Date Of Birth"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(602, 46)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(215, 26)
        Me.DateTimePicker1.TabIndex = 71
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label9.Location = New System.Drawing.Point(-292, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(1867, 29)
        Me.Label9.TabIndex = 72
        Me.Label9.Text = resources.GetString("Label9.Text")
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1020, 510)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Btnsearch)
        Me.Controls.Add(Me.Search)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Aadress)
        Me.Controls.Add(Me.Aadres)
        Me.Controls.Add(Me.Pin_Code)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.City)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.State)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Gender)
        Me.Controls.Add(Me.Email_Id)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Mobile_No)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Aadhar_Card)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.C_Name)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Customer"
        Me.Text = "Customer"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerReportDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomersDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents C_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Aadhar_Card As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Mobile_No As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Email_Id As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Gender As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents State As System.Windows.Forms.ComboBox
    Friend WithEvents City As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Pin_Code As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Aadress As System.Windows.Forms.TextBox
    Friend WithEvents Aadres As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Delete As System.Windows.Forms.Button
    Friend WithEvents Updates As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents AddNew As System.Windows.Forms.Button
    Friend WithEvents Search As System.Windows.Forms.TextBox
    Friend WithEvents Btnsearch As System.Windows.Forms.Button
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents CustomersDataSet2 As ComputersShop.CustomersDataSet2
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As ComputersShop.CustomersDataSet2TableAdapters.CustomerTableAdapter
    Friend WithEvents CIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadharCardNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinCodeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNameDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadharCardNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNoDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmailIdDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GenderDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents StateDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CityDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents PinCodeDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadressDataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CustomerReportDataSet As ComputersShop.CustomerReportDataSet
    Friend WithEvents CustomerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter1 As ComputersShop.CustomerReportDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents Label9 As System.Windows.Forms.Label
End Class

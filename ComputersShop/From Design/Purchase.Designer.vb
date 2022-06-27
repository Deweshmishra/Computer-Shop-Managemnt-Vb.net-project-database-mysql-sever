<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Purchase
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Purchase))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.P_Name = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Brand = New System.Windows.Forms.ComboBox()
        Me.Warranty = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Ram = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.hdd = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Storage = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Processor = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Services = New System.Windows.Forms.TextBox()
        Me.D_Name = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Quantity = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Price = New System.Windows.Forms.TextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.DELETE = New System.Windows.Forms.Button()
        Me.Updates = New System.Windows.Forms.Button()
        Me.Save = New System.Windows.Forms.Button()
        Me.AddNew = New System.Windows.Forms.Button()
        Me.dates = New System.Windows.Forms.DateTimePicker()
        Me.D_State = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(18, 66)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 19)
        Me.Label2.TabIndex = 103
        Me.Label2.Text = " Products Name"
        '
        'P_Name
        '
        Me.P_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Name.Location = New System.Drawing.Point(146, 61)
        Me.P_Name.Name = "P_Name"
        Me.P_Name.Size = New System.Drawing.Size(190, 26)
        Me.P_Name.TabIndex = 104
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 113)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 19)
        Me.Label1.TabIndex = 105
        Me.Label1.Text = "Brand"
        '
        'Brand
        '
        Me.Brand.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Brand.FormattingEnabled = True
        Me.Brand.Items.AddRange(New Object() {"APPLE", "DELL", "HP", "LENOVO", "ASUS"})
        Me.Brand.Location = New System.Drawing.Point(146, 107)
        Me.Brand.Name = "Brand"
        Me.Brand.Size = New System.Drawing.Size(190, 28)
        Me.Brand.TabIndex = 107
        '
        'Warranty
        '
        Me.Warranty.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Warranty.FormattingEnabled = True
        Me.Warranty.Items.AddRange(New Object() {"6 Months", "1 Year", "1.5 Year", "2 Year", "3 Year"})
        Me.Warranty.Location = New System.Drawing.Point(146, 152)
        Me.Warranty.Name = "Warranty"
        Me.Warranty.Size = New System.Drawing.Size(190, 28)
        Me.Warranty.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(21, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(65, 19)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Warranty"
        '
        'Ram
        '
        Me.Ram.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Ram.FormattingEnabled = True
        Me.Ram.Items.AddRange(New Object() {"2", "4", "6", "8", "12", "16"})
        Me.Ram.Location = New System.Drawing.Point(146, 200)
        Me.Ram.Name = "Ram"
        Me.Ram.Size = New System.Drawing.Size(190, 28)
        Me.Ram.TabIndex = 111
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(21, 206)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 19)
        Me.Label4.TabIndex = 110
        Me.Label4.Text = "RAM"
        '
        'hdd
        '
        Me.hdd.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.hdd.FormattingEnabled = True
        Me.hdd.Items.AddRange(New Object() {"HDD", "SDD"})
        Me.hdd.Location = New System.Drawing.Point(146, 246)
        Me.hdd.Name = "hdd"
        Me.hdd.Size = New System.Drawing.Size(190, 28)
        Me.hdd.TabIndex = 113
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(21, 252)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 19)
        Me.Label5.TabIndex = 112
        Me.Label5.Text = "HDD/SDD"
        '
        'Storage
        '
        Me.Storage.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Storage.FormattingEnabled = True
        Me.Storage.Items.AddRange(New Object() {"500 GB HDD", "1 TB HDD", "500 SDD", "1 TB SDD", "500 SDD,500 HDD"})
        Me.Storage.Location = New System.Drawing.Point(146, 293)
        Me.Storage.Name = "Storage"
        Me.Storage.Size = New System.Drawing.Size(190, 28)
        Me.Storage.TabIndex = 115
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 299)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 114
        Me.Label6.Text = "Storage"
        '
        'Processor
        '
        Me.Processor.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Processor.FormattingEnabled = True
        Me.Processor.Items.AddRange(New Object() {"i3", "i6", "i9"})
        Me.Processor.Location = New System.Drawing.Point(146, 340)
        Me.Processor.Name = "Processor"
        Me.Processor.Size = New System.Drawing.Size(190, 28)
        Me.Processor.TabIndex = 117
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(21, 346)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(70, 19)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Processor"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(420, 63)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 19)
        Me.Label8.TabIndex = 118
        Me.Label8.Text = "Date"
        '
        'Services
        '
        Me.Services.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Services.Location = New System.Drawing.Point(547, 105)
        Me.Services.Name = "Services"
        Me.Services.Size = New System.Drawing.Size(190, 26)
        Me.Services.TabIndex = 119
        '
        'D_Name
        '
        Me.D_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_Name.Location = New System.Drawing.Point(547, 155)
        Me.D_Name.Name = "D_Name"
        Me.D_Name.Size = New System.Drawing.Size(190, 26)
        Me.D_Name.TabIndex = 121
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(420, 113)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 19)
        Me.Label9.TabIndex = 120
        Me.Label9.Text = "Services Code"
        '
        'Quantity
        '
        Me.Quantity.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Quantity.Location = New System.Drawing.Point(546, 250)
        Me.Quantity.Name = "Quantity"
        Me.Quantity.Size = New System.Drawing.Size(190, 26)
        Me.Quantity.TabIndex = 123
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(421, 158)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(83, 19)
        Me.Label10.TabIndex = 122
        Me.Label10.Text = "Delar Name"
        '
        'Price
        '
        Me.Price.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Price.Location = New System.Drawing.Point(546, 298)
        Me.Price.Name = "Price"
        Me.Price.Size = New System.Drawing.Size(190, 26)
        Me.Price.TabIndex = 125
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(421, 203)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 124
        Me.Label11.Text = "Delar State"
        '
        'Total
        '
        Me.Total.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(546, 344)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(190, 26)
        Me.Total.TabIndex = 127
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(420, 249)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 19)
        Me.Label12.TabIndex = 126
        Me.Label12.Text = "Quantity"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(421, 296)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(40, 19)
        Me.Label13.TabIndex = 128
        Me.Label13.Text = "Price"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(421, 344)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(39, 19)
        Me.Label14.TabIndex = 130
        Me.Label14.Text = "Total"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DELETE)
        Me.GroupBox2.Controls.Add(Me.Updates)
        Me.GroupBox2.Controls.Add(Me.Save)
        Me.GroupBox2.Controls.Add(Me.AddNew)
        Me.GroupBox2.Location = New System.Drawing.Point(773, 56)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(147, 157)
        Me.GroupBox2.TabIndex = 132
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buttons"
        '
        'DELETE
        '
        Me.DELETE.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.DELETE.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DELETE.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.DELETE.Location = New System.Drawing.Point(8, 125)
        Me.DELETE.Name = "DELETE"
        Me.DELETE.Size = New System.Drawing.Size(130, 29)
        Me.DELETE.TabIndex = 32
        Me.DELETE.Text = "DELETE"
        Me.DELETE.UseVisualStyleBackColor = False
        '
        'Updates
        '
        Me.Updates.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Updates.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Updates.ForeColor = System.Drawing.SystemColors.ButtonFace
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
        Me.Save.ForeColor = System.Drawing.SystemColors.ButtonFace
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
        Me.AddNew.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AddNew.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.AddNew.Location = New System.Drawing.Point(7, 20)
        Me.AddNew.Name = "AddNew"
        Me.AddNew.Size = New System.Drawing.Size(130, 29)
        Me.AddNew.TabIndex = 29
        Me.AddNew.Text = "ADD NEW"
        Me.AddNew.UseVisualStyleBackColor = False
        '
        'dates
        '
        Me.dates.CalendarFont = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dates.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dates.Location = New System.Drawing.Point(547, 57)
        Me.dates.Name = "dates"
        Me.dates.Size = New System.Drawing.Size(189, 26)
        Me.dates.TabIndex = 133
        '
        'D_State
        '
        Me.D_State.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.D_State.FormattingEnabled = True
        Me.D_State.Items.AddRange(New Object() {"Andhra Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Arunachal Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Assam" & Global.Microsoft.VisualBasic.ChrW(9), "Bihar" & Global.Microsoft.VisualBasic.ChrW(9), "Chhattisgarh" & Global.Microsoft.VisualBasic.ChrW(9), "Goa" & Global.Microsoft.VisualBasic.ChrW(9), "Gujarat" & Global.Microsoft.VisualBasic.ChrW(9), "Haryana" & Global.Microsoft.VisualBasic.ChrW(9), "Himachal ", "Jharkhand" & Global.Microsoft.VisualBasic.ChrW(9), "Karnataka" & Global.Microsoft.VisualBasic.ChrW(9), "Kerala" & Global.Microsoft.VisualBasic.ChrW(9), "Madhya Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Maharashtra" & Global.Microsoft.VisualBasic.ChrW(9), "Manipur", "Meghalaya" & Global.Microsoft.VisualBasic.ChrW(9), "Mizoram" & Global.Microsoft.VisualBasic.ChrW(9), "Nagaland" & Global.Microsoft.VisualBasic.ChrW(9), "Odisha", "Punjab" & Global.Microsoft.VisualBasic.ChrW(9), "Rajasthan" & Global.Microsoft.VisualBasic.ChrW(9), "Sikkim" & Global.Microsoft.VisualBasic.ChrW(9), "Tamil Nadu" & Global.Microsoft.VisualBasic.ChrW(9), "Telangana" & Global.Microsoft.VisualBasic.ChrW(9), "Tripura", "Uttar Pradesh" & Global.Microsoft.VisualBasic.ChrW(9), "Uttarakhand" & Global.Microsoft.VisualBasic.ChrW(9), "Gairsain", "West Bengal"})
        Me.D_State.Location = New System.Drawing.Point(546, 201)
        Me.D_State.Name = "D_State"
        Me.D_State.Size = New System.Drawing.Size(190, 28)
        Me.D_State.TabIndex = 134
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Label15.Location = New System.Drawing.Point(-359, -1)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(1846, 29)
        Me.Label15.TabIndex = 135
        Me.Label15.Text = resources.GetString("Label15.Text")
        '
        'Purchase
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(945, 419)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.D_State)
        Me.Controls.Add(Me.dates)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Total)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Price)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Quantity)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.D_Name)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Services)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Processor)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Storage)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.hdd)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Ram)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Warranty)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Brand)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.P_Name)
        Me.Controls.Add(Me.Label2)
        Me.Name = "Purchase"
        Me.Text = "Purchase"
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents P_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Brand As System.Windows.Forms.ComboBox
    Friend WithEvents Warranty As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Ram As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents hdd As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Storage As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Processor As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Services As System.Windows.Forms.TextBox
    Friend WithEvents D_Name As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Quantity As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Price As System.Windows.Forms.TextBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Total As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents DELETE As System.Windows.Forms.Button
    Friend WithEvents Updates As System.Windows.Forms.Button
    Friend WithEvents Save As System.Windows.Forms.Button
    Friend WithEvents AddNew As System.Windows.Forms.Button
    Friend WithEvents dates As System.Windows.Forms.DateTimePicker
    Friend WithEvents D_State As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerReportSale
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
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerRepoertsaleDataSet = New ComputersShop.CustomerRepoertsaleDataSet()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.P_Name = New System.Windows.Forms.TextBox()
        Me.CustomerTableAdapter = New ComputersShop.CustomerRepoertsaleDataSetTableAdapters.CustomerTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharCardNoDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SalesCustomerReportNewDataSet = New ComputersShop.SalesCustomerReportNewDataSet()
        Me.CustomerTableAdapter1 = New ComputersShop.SalesCustomerReportNewDataSetTableAdapters.CustomerTableAdapter()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerRepoertsaleDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SalesCustomerReportNewDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "Customer"
        Me.CustomerBindingSource.DataSource = Me.CustomerRepoertsaleDataSet
        '
        'CustomerRepoertsaleDataSet
        '
        Me.CustomerRepoertsaleDataSet.DataSetName = "CustomerRepoertsaleDataSet"
        Me.CustomerRepoertsaleDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(255, 23)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(122, 31)
        Me.Button1.TabIndex = 72
        Me.Button1.Text = "Search"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'P_Name
        '
        Me.P_Name.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.P_Name.Location = New System.Drawing.Point(38, 21)
        Me.P_Name.Name = "P_Name"
        Me.P_Name.Size = New System.Drawing.Size(212, 31)
        Me.P_Name.TabIndex = 71
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CIdDataGridViewTextBoxColumn, Me.CNameDataGridViewTextBoxColumn, Me.AadharCardNoDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(-5, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(382, 213)
        Me.DataGridView1.TabIndex = 73
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
        'CustomerBindingSource1
        '
        Me.CustomerBindingSource1.DataMember = "Customer"
        Me.CustomerBindingSource1.DataSource = Me.SalesCustomerReportNewDataSet
        '
        'SalesCustomerReportNewDataSet
        '
        Me.SalesCustomerReportNewDataSet.DataSetName = "SalesCustomerReportNewDataSet"
        Me.SalesCustomerReportNewDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'CustomerReportSale
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(371, 285)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.P_Name)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Name = "CustomerReportSale"
        Me.Text = "CustomerReportSale"
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerRepoertsaleDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SalesCustomerReportNewDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents P_Name As System.Windows.Forms.TextBox
    Friend WithEvents CustomerRepoertsaleDataSet As ComputersShop.CustomerRepoertsaleDataSet
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As ComputersShop.CustomerRepoertsaleDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents SalesCustomerReportNewDataSet As ComputersShop.SalesCustomerReportNewDataSet
    Friend WithEvents CustomerBindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter1 As ComputersShop.SalesCustomerReportNewDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents CIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadharCardNoDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUpCustomerForm
    Inherits R_Win_FrontEnd.R_FormBase

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.CustomerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_GridSearch1 = New R_Win_FrontEnd.R_GridSearch
        Me.R_ReturnLookUp1 = New R_Win_FrontEnd.R_ReturnLookUpAndFind
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(TestWinFrontEnd.lkCustomer)
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, 2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(343, 150)
        Me.DataGridView1.TabIndex = 0
        '
        'CustomerIdDataGridViewTextBoxColumn
        '
        Me.CustomerIdDataGridViewTextBoxColumn.DataPropertyName = "CustomerId"
        Me.CustomerIdDataGridViewTextBoxColumn.HeaderText = "CustomerId"
        Me.CustomerIdDataGridViewTextBoxColumn.Name = "CustomerIdDataGridViewTextBoxColumn"
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        '
        'SexDataGridViewTextBoxColumn
        '
        Me.SexDataGridViewTextBoxColumn.DataPropertyName = "Sex"
        Me.SexDataGridViewTextBoxColumn.HeaderText = "Sex"
        Me.SexDataGridViewTextBoxColumn.Name = "SexDataGridViewTextBoxColumn"
        '
        'R_GridSearch1
        '
        Me.R_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.R_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.R_GridSearch1.Location = New System.Drawing.Point(12, 158)
        Me.R_GridSearch1.Name = "R_GridSearch1"
        Me.R_GridSearch1.R_BindingSource = Me.BindingSource1
        Me.R_GridSearch1.Size = New System.Drawing.Size(282, 30)
        Me.R_GridSearch1.TabIndex = 1
        '
        'R_ReturnLookUp1
        '
        Me.R_ReturnLookUp1.Location = New System.Drawing.Point(193, 230)
        Me.R_ReturnLookUp1.Name = "R_ReturnLookUp1"
        Me.R_ReturnLookUp1.R_BindingSource = Me.BindingSource1
        Me.R_ReturnLookUp1.Size = New System.Drawing.Size(162, 31)
        Me.R_ReturnLookUp1.TabIndex = 2
        '
        'LookUpCustomerForm
        '
        Me.ClientSize = New System.Drawing.Size(362, 267)
        Me.Controls.Add(Me.R_ReturnLookUp1)
        Me.Controls.Add(Me.R_GridSearch1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "LookUpCustomerForm"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_GridSearch1 As R_Win_FrontEnd.R_GridSearch
    Friend WithEvents R_ReturnLookUp1 As R_Win_FrontEnd.R_ReturnLookUpAndFind

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GridSearch
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
        Me.components = New System.ComponentModel.Container
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DateSampleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.NumberSampleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DecimalSampleDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_GridSearch1 = New R_Win_FrontEnd.R_GridSearch
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AllowUserToOrderColumns = True
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.FirstNameDataGridViewTextBoxColumn, Me.DateSampleDataGridViewTextBoxColumn, Me.NumberSampleDataGridViewTextBoxColumn, Me.DecimalSampleDataGridViewTextBoxColumn})
        Me.DataGridView1.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.BindingSource1, "DateSample", True, System.Windows.Forms.DataSourceUpdateMode.OnValidation, Nothing, "D"))
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(12, -1)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(443, 150)
        Me.DataGridView1.TabIndex = 1
        '
        'FirstNameDataGridViewTextBoxColumn
        '
        Me.FirstNameDataGridViewTextBoxColumn.DataPropertyName = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.HeaderText = "FirstName"
        Me.FirstNameDataGridViewTextBoxColumn.Name = "FirstNameDataGridViewTextBoxColumn"
        Me.FirstNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateSampleDataGridViewTextBoxColumn
        '
        Me.DateSampleDataGridViewTextBoxColumn.DataPropertyName = "DateSample"
        Me.DateSampleDataGridViewTextBoxColumn.HeaderText = "DateSample"
        Me.DateSampleDataGridViewTextBoxColumn.Name = "DateSampleDataGridViewTextBoxColumn"
        Me.DateSampleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'NumberSampleDataGridViewTextBoxColumn
        '
        Me.NumberSampleDataGridViewTextBoxColumn.DataPropertyName = "NumberSample"
        Me.NumberSampleDataGridViewTextBoxColumn.HeaderText = "NumberSample"
        Me.NumberSampleDataGridViewTextBoxColumn.Name = "NumberSampleDataGridViewTextBoxColumn"
        Me.NumberSampleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DecimalSampleDataGridViewTextBoxColumn
        '
        Me.DecimalSampleDataGridViewTextBoxColumn.DataPropertyName = "DecimalSample"
        Me.DecimalSampleDataGridViewTextBoxColumn.HeaderText = "DecimalSample"
        Me.DecimalSampleDataGridViewTextBoxColumn.Name = "DecimalSampleDataGridViewTextBoxColumn"
        Me.DecimalSampleDataGridViewTextBoxColumn.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(TestWinFrontEnd.lkGridSearch)
        '
        'R_GridSearch1
        '
        Me.R_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.R_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.R_GridSearch1.Location = New System.Drawing.Point(12, 155)
        Me.R_GridSearch1.Name = "R_GridSearch1"
        Me.R_GridSearch1.R_BindingSource = Me.BindingSource1
        Me.R_GridSearch1.Size = New System.Drawing.Size(348, 30)
        Me.R_GridSearch1.TabIndex = 0
        '
        'GridSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(598, 266)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.R_GridSearch1)
        Me.Name = "GridSearch"
        Me.Text = "GridSearch"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents R_GridSearch1 As R_Win_FrontEnd.R_GridSearch
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DateSampleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NumberSampleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DecimalSampleDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

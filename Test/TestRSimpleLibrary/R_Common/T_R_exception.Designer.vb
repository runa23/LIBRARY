<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_R_exception
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
        Me.Button1 = New System.Windows.Forms.Button
        Me.txtPar1 = New System.Windows.Forms.TextBox
        Me.txtPar2 = New System.Windows.Forms.TextBox
        Me.txtResult = New System.Windows.Forms.TextBox
        Me.txtError = New System.Windows.Forms.TextBox
        Me.Button2 = New System.Windows.Forms.Button
        Me.btnShowException = New System.Windows.Forms.Button
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_ErrorDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.btnErrorDetail = New System.Windows.Forms.DataGridViewButtonColumn
        Me.Panel1 = New System.Windows.Forms.Panel
        Me.ErrorDetailsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ErrorDetailsDataGridView = New System.Windows.Forms.DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_ErrorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.ErrorDetailsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ErrorDetailsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(146, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Devide Direct Exception"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtPar1
        '
        Me.txtPar1.Location = New System.Drawing.Point(181, 14)
        Me.txtPar1.Name = "txtPar1"
        Me.txtPar1.Size = New System.Drawing.Size(100, 20)
        Me.txtPar1.TabIndex = 1
        '
        'txtPar2
        '
        Me.txtPar2.Location = New System.Drawing.Point(288, 13)
        Me.txtPar2.Name = "txtPar2"
        Me.txtPar2.Size = New System.Drawing.Size(100, 20)
        Me.txtPar2.TabIndex = 2
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(395, 13)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(100, 20)
        Me.txtResult.TabIndex = 3
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(12, 71)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(407, 123)
        Me.txtError.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(13, 42)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(146, 23)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Devide Trap Exception"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'btnShowException
        '
        Me.btnShowException.Location = New System.Drawing.Point(12, 212)
        Me.btnShowException.Name = "btnShowException"
        Me.btnShowException.Size = New System.Drawing.Size(145, 23)
        Me.btnShowException.TabIndex = 6
        Me.btnShowException.Text = "Show Exception"
        Me.btnShowException.UseVisualStyleBackColor = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(R_Common.CT_Error)
        '
        'R_ErrorDataGridView
        '
        Me.R_ErrorDataGridView.AllowUserToAddRows = False
        Me.R_ErrorDataGridView.AllowUserToDeleteRows = False
        Me.R_ErrorDataGridView.AutoGenerateColumns = False
        Me.R_ErrorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.R_ErrorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.btnErrorDetail})
        Me.R_ErrorDataGridView.DataSource = Me.BindingSource1
        Me.R_ErrorDataGridView.Location = New System.Drawing.Point(12, 241)
        Me.R_ErrorDataGridView.Name = "R_ErrorDataGridView"
        Me.R_ErrorDataGridView.ReadOnly = True
        Me.R_ErrorDataGridView.Size = New System.Drawing.Size(343, 131)
        Me.R_ErrorDataGridView.TabIndex = 7
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ErrNo"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ErrNo"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ErrDescp"
        Me.DataGridViewTextBoxColumn3.HeaderText = "ErrDescp"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'btnErrorDetail
        '
        Me.btnErrorDetail.HeaderText = "Error Detail"
        Me.btnErrorDetail.Name = "btnErrorDetail"
        Me.btnErrorDetail.ReadOnly = True
        Me.btnErrorDetail.Text = "Detail"
        Me.btnErrorDetail.UseColumnTextForButtonValue = True
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ErrorDetailsDataGridView)
        Me.Panel1.Location = New System.Drawing.Point(13, 388)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(393, 238)
        Me.Panel1.TabIndex = 8
        '
        'ErrorDetailsBindingSource
        '
        Me.ErrorDetailsBindingSource.DataMember = "ErrorDetails"
        Me.ErrorDetailsBindingSource.DataSource = Me.BindingSource1
        '
        'ErrorDetailsDataGridView
        '
        Me.ErrorDetailsDataGridView.AutoGenerateColumns = False
        Me.ErrorDetailsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ErrorDetailsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn4})
        Me.ErrorDetailsDataGridView.DataSource = Me.ErrorDetailsBindingSource
        Me.ErrorDetailsDataGridView.Location = New System.Drawing.Point(12, 3)
        Me.ErrorDetailsDataGridView.Name = "ErrorDetailsDataGridView"
        Me.ErrorDetailsDataGridView.Size = New System.Drawing.Size(300, 220)
        Me.ErrorDetailsDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ErrNo"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ErrNo"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "ErrDescp"
        Me.DataGridViewTextBoxColumn4.HeaderText = "ErrDescp"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.ReadOnly = True
        '
        'T_R_exception
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(629, 678)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.R_ErrorDataGridView)
        Me.Controls.Add(Me.btnShowException)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.txtResult)
        Me.Controls.Add(Me.txtPar2)
        Me.Controls.Add(Me.txtPar1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "T_R_exception"
        Me.Text = "T_R_exception"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_ErrorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        CType(Me.ErrorDetailsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ErrorDetailsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtPar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPar2 As System.Windows.Forms.TextBox
    Friend WithEvents txtResult As System.Windows.Forms.TextBox
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents btnShowException As System.Windows.Forms.Button
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents R_ErrorDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnErrorDetail As System.Windows.Forms.DataGridViewButtonColumn
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents ErrorDetailsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ErrorDetailsBindingSource As System.Windows.Forms.BindingSource
End Class

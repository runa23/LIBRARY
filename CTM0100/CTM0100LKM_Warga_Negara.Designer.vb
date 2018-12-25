<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTM0100LKM_Warga_Negara
    Inherits CT_Win_FrontEnd.CT_FormBase

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
        Me.LKm_warga_negaraDTOCT_DataGridView = New CT_Win_FrontEnd.CT_DataGridView
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.LKm_warga_negaraDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CT_GridSearch1 = New CT_Win_FrontEnd.CT_GridSearch
        Me.CT_ReturnLookUpAndFind1 = New CT_Win_FrontEnd.CT_ReturnLookUpAndFind
        CType(Me.LKm_warga_negaraDTOCT_DataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LKm_warga_negaraDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LKm_warga_negaraDTOCT_DataGridView
        '
        Me.LKm_warga_negaraDTOCT_DataGridView.AllowUserToAddRows = False
        Me.LKm_warga_negaraDTOCT_DataGridView.AllowUserToDeleteRows = False
        Me.LKm_warga_negaraDTOCT_DataGridView.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.LKm_warga_negaraDTOCT_DataGridView.AutoGenerateColumns = False
        Me.LKm_warga_negaraDTOCT_DataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.LKm_warga_negaraDTOCT_DataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.LKm_warga_negaraDTOCT_DataGridView.CT_ConductorSource = Nothing
        Me.LKm_warga_negaraDTOCT_DataGridView.DataSource = Me.LKm_warga_negaraDTOBindingSource
        Me.LKm_warga_negaraDTOCT_DataGridView.Location = New System.Drawing.Point(12, 12)
        Me.LKm_warga_negaraDTOCT_DataGridView.Name = "LKm_warga_negaraDTOCT_DataGridView"
        Me.LKm_warga_negaraDTOCT_DataGridView.ReadOnly = True
        Me.LKm_warga_negaraDTOCT_DataGridView.Size = New System.Drawing.Size(376, 242)
        Me.LKm_warga_negaraDTOCT_DataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "WARGA_NEGARA"
        Me.DataGridViewTextBoxColumn1.HeaderText = "WARGA_NEGARA"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "WARGA_NEGARA_ID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "WARGA_NEGARA_ID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.ReadOnly = True
        '
        'LKm_warga_negaraDTOBindingSource
        '
        Me.LKm_warga_negaraDTOBindingSource.DataSource = GetType(Global.CTM0100.CTM0100SvcRef.LKm_warga_negaraDTO)
        '
        'CT_GridSearch1
        '
        Me.CT_GridSearch1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.CT_GridSearch1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CT_GridSearch1.CT_BindingSource = Me.LKm_warga_negaraDTOBindingSource
        Me.CT_GridSearch1.Location = New System.Drawing.Point(12, 260)
        Me.CT_GridSearch1.Name = "CT_GridSearch1"
        Me.CT_GridSearch1.Size = New System.Drawing.Size(376, 30)
        Me.CT_GridSearch1.TabIndex = 2
        '
        'CT_ReturnLookUpAndFind1
        '
        Me.CT_ReturnLookUpAndFind1.CT_BindingSource = Me.LKm_warga_negaraDTOBindingSource
        Me.CT_ReturnLookUpAndFind1.Location = New System.Drawing.Point(226, 306)
        Me.CT_ReturnLookUpAndFind1.Name = "CT_ReturnLookUpAndFind1"
        Me.CT_ReturnLookUpAndFind1.Size = New System.Drawing.Size(162, 31)
        Me.CT_ReturnLookUpAndFind1.TabIndex = 3
        '
        'CTM0100LKM_Warga_Negara
        '
        Me.ClientSize = New System.Drawing.Size(400, 349)
        Me.Controls.Add(Me.CT_ReturnLookUpAndFind1)
        Me.Controls.Add(Me.CT_GridSearch1)
        Me.Controls.Add(Me.LKm_warga_negaraDTOCT_DataGridView)
        Me.Name = "CTM0100LKM_Warga_Negara"
        CType(Me.LKm_warga_negaraDTOCT_DataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LKm_warga_negaraDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents LKm_warga_negaraDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LKm_warga_negaraDTOCT_DataGridView As CT_Win_FrontEnd.CT_DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CT_GridSearch1 As CT_Win_FrontEnd.CT_GridSearch
    Friend WithEvents CT_ReturnLookUpAndFind1 As CT_Win_FrontEnd.CT_ReturnLookUpAndFind

End Class

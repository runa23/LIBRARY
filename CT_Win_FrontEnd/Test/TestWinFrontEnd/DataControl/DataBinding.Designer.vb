<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DataBinding
    Inherits R_Win_FrontEnd.R_FormBase

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
        Dim CustomerIdLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(DataBinding))
        Me.ParentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnFind = New System.Windows.Forms.Button
        Me.Label1 = New System.Windows.Forms.Label
        Me.cboSex = New System.Windows.Forms.ComboBox
        Me.SexLookUpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_Save1 = New R_Win_FrontEnd.R_Save
        Me.R_Conductor1 = New R_Win_FrontEnd.R_Conductor(Me.components)
        Me.BindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.R_Delete1 = New R_Win_FrontEnd.R_Delete
        Me.R_Edit1 = New R_Win_FrontEnd.R_Edit
        Me.R_Cancel1 = New R_Win_FrontEnd.R_Cancel
        Me.txtLastname = New R_Win_FrontEnd.R_TextBox
        Me.txtFirstName = New R_Win_FrontEnd.R_TextBox
        Me.txtCustID = New R_Win_FrontEnd.R_TextBox
        Me.R_Add1 = New R_Win_FrontEnd.R_Add
        Me.R_DataGridView1 = New R_Win_FrontEnd.R_DataGridView
        Me.CustomerIdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.FirstNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.SexDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn
        Me.R_TextBox1 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox2 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox3 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox4 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox5 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox6 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox7 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox8 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox9 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox10 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox11 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox12 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox13 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox14 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox15 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox16 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox17 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox18 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox19 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox20 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox21 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox22 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox23 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox24 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox25 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox26 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox27 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox28 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox29 = New R_Win_FrontEnd.R_TextBox
        Me.R_TextBox30 = New R_Win_FrontEnd.R_TextBox
        Me.btnReloadGrid = New System.Windows.Forms.Button
        CustomerIdLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        CType(Me.ParentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SexLookUpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_Conductor1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.R_DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CustomerIdLabel
        '
        CustomerIdLabel.AutoSize = True
        CustomerIdLabel.Location = New System.Drawing.Point(13, 143)
        CustomerIdLabel.Name = "CustomerIdLabel"
        CustomerIdLabel.Size = New System.Drawing.Size(66, 13)
        CustomerIdLabel.TabIndex = 0
        CustomerIdLabel.Text = "Customer Id:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(13, 169)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 2
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(13, 195)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 4
        LastNameLabel.Text = "Last Name:"
        '
        'ParentBindingSource
        '
        Me.ParentBindingSource.DataSource = GetType(TestWinFrontEnd.lkCustomer)
        '
        'btnFind
        '
        Me.btnFind.Location = New System.Drawing.Point(259, 133)
        Me.btnFind.Name = "btnFind"
        Me.btnFind.Size = New System.Drawing.Size(75, 23)
        Me.btnFind.TabIndex = 14
        Me.btnFind.Text = "FindRecord"
        Me.btnFind.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(259, 196)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 13)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "R_Display FirstName"
        '
        'cboSex
        '
        Me.cboSex.DataSource = Me.SexLookUpBindingSource
        Me.cboSex.DisplayMember = "Description"
        Me.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboSex.FormattingEnabled = True
        Me.cboSex.Location = New System.Drawing.Point(381, 187)
        Me.cboSex.Name = "cboSex"
        Me.cboSex.Size = New System.Drawing.Size(121, 21)
        Me.cboSex.TabIndex = 17
        Me.cboSex.ValueMember = "ID"
        '
        'SexLookUpBindingSource
        '
        Me.SexLookUpBindingSource.DataSource = GetType(TestWinFrontEnd.SexLookUp)
        '
        'R_Save1
        '
        Me.R_Save1.Image = CType(resources.GetObject("R_Save1.Image"), System.Drawing.Image)
        Me.R_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Save1.Location = New System.Drawing.Point(257, 229)
        Me.R_Save1.Name = "R_Save1"
        Me.R_Save1.R_ConductorSource = Me.R_Conductor1
        Me.R_Save1.Size = New System.Drawing.Size(75, 23)
        Me.R_Save1.TabIndex = 13
        Me.R_Save1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Save1.UseVisualStyleBackColor = True
        '
        'R_Conductor1
        '
        Me.R_Conductor1.R_BindingSource = Me.BindingSource1
        Me.R_Conductor1.R_ParentBindingSource = Me.ParentBindingSource
        Me.R_Conductor1.R_ParentKey = "CustomerId"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = GetType(TestWinFrontEnd.dtoCustomer)
        '
        'R_Delete1
        '
        Me.R_Delete1.Image = CType(resources.GetObject("R_Delete1.Image"), System.Drawing.Image)
        Me.R_Delete1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Delete1.Location = New System.Drawing.Point(176, 230)
        Me.R_Delete1.Name = "R_Delete1"
        Me.R_Delete1.R_ConductorSource = Me.R_Conductor1
        Me.R_Delete1.Size = New System.Drawing.Size(75, 23)
        Me.R_Delete1.TabIndex = 12
        Me.R_Delete1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Delete1.UseVisualStyleBackColor = True
        '
        'R_Edit1
        '
        Me.R_Edit1.Image = CType(resources.GetObject("R_Edit1.Image"), System.Drawing.Image)
        Me.R_Edit1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Edit1.Location = New System.Drawing.Point(95, 230)
        Me.R_Edit1.Name = "R_Edit1"
        Me.R_Edit1.R_ConductorSource = Me.R_Conductor1
        Me.R_Edit1.Size = New System.Drawing.Size(75, 23)
        Me.R_Edit1.TabIndex = 11
        Me.R_Edit1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Edit1.UseVisualStyleBackColor = True
        '
        'R_Cancel1
        '
        Me.R_Cancel1.Image = CType(resources.GetObject("R_Cancel1.Image"), System.Drawing.Image)
        Me.R_Cancel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Cancel1.Location = New System.Drawing.Point(338, 229)
        Me.R_Cancel1.Name = "R_Cancel1"
        Me.R_Cancel1.R_ConductorSource = Me.R_Conductor1
        Me.R_Cancel1.Size = New System.Drawing.Size(75, 23)
        Me.R_Cancel1.TabIndex = 10
        Me.R_Cancel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Cancel1.UseVisualStyleBackColor = True
        '
        'txtLastname
        '
        Me.txtLastname.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "LastName", True))
        Me.txtLastname.Location = New System.Drawing.Point(95, 195)
        Me.txtLastname.Name = "txtLastname"
        Me.txtLastname.R_ConductorSource = Me.R_Conductor1
        Me.txtLastname.R_EnableADD = True
        Me.txtLastname.R_EnableEDIT = True
        Me.txtLastname.Size = New System.Drawing.Size(130, 20)
        Me.txtLastname.TabIndex = 9
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(95, 169)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.R_ConductorSource = Me.R_Conductor1
        Me.txtFirstName.R_EnableADD = True
        Me.txtFirstName.R_EnableEDIT = True
        Me.txtFirstName.Size = New System.Drawing.Size(130, 20)
        Me.txtFirstName.TabIndex = 8
        '
        'txtCustID
        '
        Me.txtCustID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.BindingSource1, "CustomerId", True))
        Me.txtCustID.Location = New System.Drawing.Point(95, 140)
        Me.txtCustID.Name = "txtCustID"
        Me.txtCustID.R_ConductorSource = Me.R_Conductor1
        Me.txtCustID.R_EnableADD = True
        Me.txtCustID.Size = New System.Drawing.Size(130, 20)
        Me.txtCustID.TabIndex = 7
        '
        'R_Add1
        '
        Me.R_Add1.Image = CType(resources.GetObject("R_Add1.Image"), System.Drawing.Image)
        Me.R_Add1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Add1.Location = New System.Drawing.Point(14, 230)
        Me.R_Add1.Name = "R_Add1"
        Me.R_Add1.R_ConductorSource = Me.R_Conductor1
        Me.R_Add1.Size = New System.Drawing.Size(75, 23)
        Me.R_Add1.TabIndex = 6
        Me.R_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Add1.UseVisualStyleBackColor = True
        '
        'R_DataGridView1
        '
        Me.R_DataGridView1.AutoGenerateColumns = False
        Me.R_DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.R_DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CustomerIdDataGridViewTextBoxColumn, Me.FirstNameDataGridViewTextBoxColumn, Me.SexDataGridViewTextBoxColumn})
        Me.R_DataGridView1.DataSource = Me.ParentBindingSource
        Me.R_DataGridView1.Location = New System.Drawing.Point(12, 6)
        Me.R_DataGridView1.Name = "R_DataGridView1"
        Me.R_DataGridView1.R_ConductorSource = Me.R_Conductor1
        Me.R_DataGridView1.R_EnableOTHER = True
        Me.R_DataGridView1.Size = New System.Drawing.Size(352, 117)
        Me.R_DataGridView1.TabIndex = 18
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
        'R_TextBox1
        '
        Me.R_TextBox1.Location = New System.Drawing.Point(14, 300)
        Me.R_TextBox1.Name = "R_TextBox1"
        Me.R_TextBox1.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox1.R_EnableADD = True
        Me.R_TextBox1.R_EnableEDIT = True
        Me.R_TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox1.TabIndex = 19
        '
        'R_TextBox2
        '
        Me.R_TextBox2.Location = New System.Drawing.Point(12, 326)
        Me.R_TextBox2.Name = "R_TextBox2"
        Me.R_TextBox2.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox2.R_EnableADD = True
        Me.R_TextBox2.R_EnableEDIT = True
        Me.R_TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox2.TabIndex = 20
        '
        'R_TextBox3
        '
        Me.R_TextBox3.Location = New System.Drawing.Point(121, 274)
        Me.R_TextBox3.Name = "R_TextBox3"
        Me.R_TextBox3.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox3.R_EnableADD = True
        Me.R_TextBox3.R_EnableEDIT = True
        Me.R_TextBox3.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox3.TabIndex = 21
        '
        'R_TextBox4
        '
        Me.R_TextBox4.Location = New System.Drawing.Point(118, 326)
        Me.R_TextBox4.Name = "R_TextBox4"
        Me.R_TextBox4.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox4.R_EnableADD = True
        Me.R_TextBox4.R_EnableEDIT = True
        Me.R_TextBox4.Size = New System.Drawing.Size(103, 20)
        Me.R_TextBox4.TabIndex = 22
        '
        'R_TextBox5
        '
        Me.R_TextBox5.Location = New System.Drawing.Point(121, 404)
        Me.R_TextBox5.Name = "R_TextBox5"
        Me.R_TextBox5.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox5.R_EnableADD = True
        Me.R_TextBox5.R_EnableEDIT = True
        Me.R_TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox5.TabIndex = 23
        '
        'R_TextBox6
        '
        Me.R_TextBox6.Location = New System.Drawing.Point(121, 300)
        Me.R_TextBox6.Name = "R_TextBox6"
        Me.R_TextBox6.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox6.R_EnableADD = True
        Me.R_TextBox6.R_EnableEDIT = True
        Me.R_TextBox6.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox6.TabIndex = 24
        '
        'R_TextBox7
        '
        Me.R_TextBox7.Location = New System.Drawing.Point(120, 378)
        Me.R_TextBox7.Name = "R_TextBox7"
        Me.R_TextBox7.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox7.R_EnableADD = True
        Me.R_TextBox7.R_EnableEDIT = True
        Me.R_TextBox7.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox7.TabIndex = 25
        '
        'R_TextBox8
        '
        Me.R_TextBox8.Location = New System.Drawing.Point(232, 274)
        Me.R_TextBox8.Name = "R_TextBox8"
        Me.R_TextBox8.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox8.R_EnableADD = True
        Me.R_TextBox8.R_EnableEDIT = True
        Me.R_TextBox8.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox8.TabIndex = 26
        '
        'R_TextBox9
        '
        Me.R_TextBox9.Location = New System.Drawing.Point(14, 352)
        Me.R_TextBox9.Name = "R_TextBox9"
        Me.R_TextBox9.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox9.R_EnableADD = True
        Me.R_TextBox9.R_EnableEDIT = True
        Me.R_TextBox9.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox9.TabIndex = 27
        '
        'R_TextBox10
        '
        Me.R_TextBox10.Location = New System.Drawing.Point(118, 352)
        Me.R_TextBox10.Name = "R_TextBox10"
        Me.R_TextBox10.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox10.R_EnableADD = True
        Me.R_TextBox10.R_EnableEDIT = True
        Me.R_TextBox10.Size = New System.Drawing.Size(103, 20)
        Me.R_TextBox10.TabIndex = 28
        '
        'R_TextBox11
        '
        Me.R_TextBox11.Location = New System.Drawing.Point(235, 326)
        Me.R_TextBox11.Name = "R_TextBox11"
        Me.R_TextBox11.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox11.R_EnableADD = True
        Me.R_TextBox11.R_EnableEDIT = True
        Me.R_TextBox11.Size = New System.Drawing.Size(99, 20)
        Me.R_TextBox11.TabIndex = 29
        '
        'R_TextBox12
        '
        Me.R_TextBox12.Location = New System.Drawing.Point(232, 300)
        Me.R_TextBox12.Name = "R_TextBox12"
        Me.R_TextBox12.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox12.R_EnableADD = True
        Me.R_TextBox12.R_EnableEDIT = True
        Me.R_TextBox12.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox12.TabIndex = 30
        '
        'R_TextBox13
        '
        Me.R_TextBox13.Location = New System.Drawing.Point(12, 378)
        Me.R_TextBox13.Name = "R_TextBox13"
        Me.R_TextBox13.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox13.R_EnableADD = True
        Me.R_TextBox13.R_EnableEDIT = True
        Me.R_TextBox13.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox13.TabIndex = 31
        '
        'R_TextBox14
        '
        Me.R_TextBox14.Location = New System.Drawing.Point(14, 404)
        Me.R_TextBox14.Name = "R_TextBox14"
        Me.R_TextBox14.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox14.R_EnableADD = True
        Me.R_TextBox14.R_EnableEDIT = True
        Me.R_TextBox14.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox14.TabIndex = 32
        '
        'R_TextBox15
        '
        Me.R_TextBox15.Location = New System.Drawing.Point(234, 352)
        Me.R_TextBox15.Name = "R_TextBox15"
        Me.R_TextBox15.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox15.R_EnableADD = True
        Me.R_TextBox15.R_EnableEDIT = True
        Me.R_TextBox15.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox15.TabIndex = 33
        '
        'R_TextBox16
        '
        Me.R_TextBox16.Location = New System.Drawing.Point(15, 274)
        Me.R_TextBox16.Name = "R_TextBox16"
        Me.R_TextBox16.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox16.R_EnableADD = True
        Me.R_TextBox16.R_EnableEDIT = True
        Me.R_TextBox16.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox16.TabIndex = 34
        '
        'R_TextBox17
        '
        Me.R_TextBox17.Location = New System.Drawing.Point(235, 377)
        Me.R_TextBox17.Name = "R_TextBox17"
        Me.R_TextBox17.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox17.R_EnableADD = True
        Me.R_TextBox17.R_EnableEDIT = True
        Me.R_TextBox17.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox17.TabIndex = 35
        '
        'R_TextBox18
        '
        Me.R_TextBox18.Location = New System.Drawing.Point(232, 404)
        Me.R_TextBox18.Name = "R_TextBox18"
        Me.R_TextBox18.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox18.R_EnableADD = True
        Me.R_TextBox18.R_EnableEDIT = True
        Me.R_TextBox18.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox18.TabIndex = 36
        '
        'R_TextBox19
        '
        Me.R_TextBox19.Location = New System.Drawing.Point(348, 274)
        Me.R_TextBox19.Name = "R_TextBox19"
        Me.R_TextBox19.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox19.R_EnableADD = True
        Me.R_TextBox19.R_EnableEDIT = True
        Me.R_TextBox19.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox19.TabIndex = 37
        '
        'R_TextBox20
        '
        Me.R_TextBox20.Location = New System.Drawing.Point(348, 300)
        Me.R_TextBox20.Name = "R_TextBox20"
        Me.R_TextBox20.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox20.R_EnableADD = True
        Me.R_TextBox20.R_EnableEDIT = True
        Me.R_TextBox20.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox20.TabIndex = 38
        '
        'R_TextBox21
        '
        Me.R_TextBox21.Location = New System.Drawing.Point(348, 326)
        Me.R_TextBox21.Name = "R_TextBox21"
        Me.R_TextBox21.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox21.R_EnableADD = True
        Me.R_TextBox21.R_EnableEDIT = True
        Me.R_TextBox21.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox21.TabIndex = 39
        '
        'R_TextBox22
        '
        Me.R_TextBox22.Location = New System.Drawing.Point(348, 352)
        Me.R_TextBox22.Name = "R_TextBox22"
        Me.R_TextBox22.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox22.R_EnableADD = True
        Me.R_TextBox22.R_EnableEDIT = True
        Me.R_TextBox22.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox22.TabIndex = 40
        '
        'R_TextBox23
        '
        Me.R_TextBox23.Location = New System.Drawing.Point(348, 378)
        Me.R_TextBox23.Name = "R_TextBox23"
        Me.R_TextBox23.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox23.R_EnableADD = True
        Me.R_TextBox23.R_EnableEDIT = True
        Me.R_TextBox23.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox23.TabIndex = 41
        '
        'R_TextBox24
        '
        Me.R_TextBox24.Location = New System.Drawing.Point(348, 404)
        Me.R_TextBox24.Name = "R_TextBox24"
        Me.R_TextBox24.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox24.R_EnableADD = True
        Me.R_TextBox24.R_EnableEDIT = True
        Me.R_TextBox24.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox24.TabIndex = 42
        '
        'R_TextBox25
        '
        Me.R_TextBox25.Location = New System.Drawing.Point(454, 274)
        Me.R_TextBox25.Name = "R_TextBox25"
        Me.R_TextBox25.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox25.R_EnableADD = True
        Me.R_TextBox25.R_EnableEDIT = True
        Me.R_TextBox25.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox25.TabIndex = 43
        '
        'R_TextBox26
        '
        Me.R_TextBox26.Location = New System.Drawing.Point(459, 300)
        Me.R_TextBox26.Name = "R_TextBox26"
        Me.R_TextBox26.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox26.R_EnableADD = True
        Me.R_TextBox26.R_EnableEDIT = True
        Me.R_TextBox26.Size = New System.Drawing.Size(95, 20)
        Me.R_TextBox26.TabIndex = 44
        '
        'R_TextBox27
        '
        Me.R_TextBox27.Location = New System.Drawing.Point(454, 352)
        Me.R_TextBox27.Name = "R_TextBox27"
        Me.R_TextBox27.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox27.R_EnableADD = True
        Me.R_TextBox27.R_EnableEDIT = True
        Me.R_TextBox27.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox27.TabIndex = 45
        '
        'R_TextBox28
        '
        Me.R_TextBox28.Location = New System.Drawing.Point(454, 377)
        Me.R_TextBox28.Name = "R_TextBox28"
        Me.R_TextBox28.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox28.R_EnableADD = True
        Me.R_TextBox28.R_EnableEDIT = True
        Me.R_TextBox28.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox28.TabIndex = 46
        '
        'R_TextBox29
        '
        Me.R_TextBox29.Location = New System.Drawing.Point(454, 404)
        Me.R_TextBox29.Name = "R_TextBox29"
        Me.R_TextBox29.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox29.R_EnableADD = True
        Me.R_TextBox29.R_EnableEDIT = True
        Me.R_TextBox29.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox29.TabIndex = 47
        '
        'R_TextBox30
        '
        Me.R_TextBox30.Location = New System.Drawing.Point(454, 326)
        Me.R_TextBox30.Name = "R_TextBox30"
        Me.R_TextBox30.R_ConductorSource = Me.R_Conductor1
        Me.R_TextBox30.R_EnableADD = True
        Me.R_TextBox30.R_EnableEDIT = True
        Me.R_TextBox30.Size = New System.Drawing.Size(100, 20)
        Me.R_TextBox30.TabIndex = 48
        '
        'btnReloadGrid
        '
        Me.btnReloadGrid.Location = New System.Drawing.Point(381, 12)
        Me.btnReloadGrid.Name = "btnReloadGrid"
        Me.btnReloadGrid.Size = New System.Drawing.Size(75, 23)
        Me.btnReloadGrid.TabIndex = 49
        Me.btnReloadGrid.Text = "Reload grid"
        Me.btnReloadGrid.UseVisualStyleBackColor = True
        '
        'DataBinding
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(626, 453)
        Me.Controls.Add(Me.btnReloadGrid)
        Me.Controls.Add(Me.R_TextBox30)
        Me.Controls.Add(Me.R_TextBox29)
        Me.Controls.Add(Me.R_TextBox28)
        Me.Controls.Add(Me.R_TextBox27)
        Me.Controls.Add(Me.R_TextBox26)
        Me.Controls.Add(Me.R_TextBox25)
        Me.Controls.Add(Me.R_TextBox24)
        Me.Controls.Add(Me.R_TextBox23)
        Me.Controls.Add(Me.R_TextBox22)
        Me.Controls.Add(Me.R_TextBox21)
        Me.Controls.Add(Me.R_TextBox20)
        Me.Controls.Add(Me.R_TextBox19)
        Me.Controls.Add(Me.R_TextBox18)
        Me.Controls.Add(Me.R_TextBox17)
        Me.Controls.Add(Me.R_TextBox16)
        Me.Controls.Add(Me.R_TextBox15)
        Me.Controls.Add(Me.R_TextBox14)
        Me.Controls.Add(Me.R_TextBox13)
        Me.Controls.Add(Me.R_TextBox12)
        Me.Controls.Add(Me.R_TextBox11)
        Me.Controls.Add(Me.R_TextBox10)
        Me.Controls.Add(Me.R_TextBox9)
        Me.Controls.Add(Me.R_TextBox8)
        Me.Controls.Add(Me.R_TextBox7)
        Me.Controls.Add(Me.R_TextBox6)
        Me.Controls.Add(Me.R_TextBox5)
        Me.Controls.Add(Me.R_TextBox4)
        Me.Controls.Add(Me.R_TextBox3)
        Me.Controls.Add(Me.R_TextBox2)
        Me.Controls.Add(Me.R_TextBox1)
        Me.Controls.Add(Me.R_DataGridView1)
        Me.Controls.Add(Me.cboSex)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnFind)
        Me.Controls.Add(Me.R_Save1)
        Me.Controls.Add(Me.R_Delete1)
        Me.Controls.Add(Me.R_Edit1)
        Me.Controls.Add(Me.R_Cancel1)
        Me.Controls.Add(Me.txtLastname)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtCustID)
        Me.Controls.Add(Me.R_Add1)
        Me.Controls.Add(CustomerIdLabel)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(LastNameLabel)
        Me.Name = "DataBinding"
        Me.Text = "DataBinding"
        CType(Me.ParentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SexLookUpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_Conductor1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.R_DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BindingSource1 As System.Windows.Forms.BindingSource
    Friend WithEvents R_Conductor1 As R_Win_FrontEnd.R_Conductor
    Friend WithEvents R_Add1 As R_Win_FrontEnd.R_Add
    Friend WithEvents txtCustID As R_Win_FrontEnd.R_TextBox
    Friend WithEvents txtFirstName As R_Win_FrontEnd.R_TextBox
    Friend WithEvents txtLastname As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_Cancel1 As R_Win_FrontEnd.R_Cancel
    Friend WithEvents R_Edit1 As R_Win_FrontEnd.R_Edit
    Friend WithEvents R_Delete1 As R_Win_FrontEnd.R_Delete
    Friend WithEvents R_Save1 As R_Win_FrontEnd.R_Save
    Friend WithEvents ParentBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnFind As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboSex As System.Windows.Forms.ComboBox
    Friend WithEvents SexLookUpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents R_DataGridView1 As R_Win_FrontEnd.R_DataGridView
    Friend WithEvents CustomerIdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SexDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents R_TextBox1 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox2 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox3 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox4 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox5 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox6 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox7 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox8 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox9 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox10 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox11 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox12 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox13 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox14 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox15 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox16 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox17 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox18 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox19 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox20 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox21 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox22 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox23 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox24 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox25 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox26 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox27 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox28 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox29 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents R_TextBox30 As R_Win_FrontEnd.R_TextBox
    Friend WithEvents btnReloadGrid As System.Windows.Forms.Button
End Class

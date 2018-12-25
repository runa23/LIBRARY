<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim EmployeeIDLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim LastNameLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnGetRecord = New System.Windows.Forms.Button
        Me.lstError = New System.Windows.Forms.ListBox
        Me.Label4 = New System.Windows.Forms.Label
        Me.btnAdd = New System.Windows.Forms.Button
        Me.btnSave = New System.Windows.Forms.Button
        Me.btnDelete = New System.Windows.Forms.Button
        Me.EmployeeDTOBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.EmployeeDTOBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton
        Me.EmployeeDTOBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton
        Me.txtEmployeeID = New System.Windows.Forms.TextBox
        Me.txtFirstName = New System.Windows.Forms.TextBox
        Me.txtLastName = New System.Windows.Forms.TextBox
        Me.btnEdit = New System.Windows.Forms.Button
        Me.btnCancel = New System.Windows.Forms.Button
        EmployeeIDLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        LastNameLabel = New System.Windows.Forms.Label
        CType(Me.EmployeeDTOBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeDTOBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmployeeDTOBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'EmployeeIDLabel
        '
        EmployeeIDLabel.AutoSize = True
        EmployeeIDLabel.Location = New System.Drawing.Point(16, 42)
        EmployeeIDLabel.Name = "EmployeeIDLabel"
        EmployeeIDLabel.Size = New System.Drawing.Size(70, 13)
        EmployeeIDLabel.TabIndex = 12
        EmployeeIDLabel.Text = "Employee ID:"
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(16, 68)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 14
        FirstNameLabel.Text = "First Name:"
        '
        'LastNameLabel
        '
        LastNameLabel.AutoSize = True
        LastNameLabel.Location = New System.Drawing.Point(16, 94)
        LastNameLabel.Name = "LastNameLabel"
        LastNameLabel.Size = New System.Drawing.Size(61, 13)
        LastNameLabel.TabIndex = 16
        LastNameLabel.Text = "Last Name:"
        '
        'btnGetRecord
        '
        Me.btnGetRecord.Location = New System.Drawing.Point(271, 42)
        Me.btnGetRecord.Name = "btnGetRecord"
        Me.btnGetRecord.Size = New System.Drawing.Size(75, 23)
        Me.btnGetRecord.TabIndex = 3
        Me.btnGetRecord.Text = "Query"
        Me.btnGetRecord.UseVisualStyleBackColor = True
        '
        'lstError
        '
        Me.lstError.FormattingEnabled = True
        Me.lstError.Location = New System.Drawing.Point(12, 214)
        Me.lstError.Name = "lstError"
        Me.lstError.Size = New System.Drawing.Size(456, 95)
        Me.lstError.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 195)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(29, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Error"
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(20, 154)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnAdd.TabIndex = 9
        Me.btnAdd.Text = "Add"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(215, 154)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(75, 23)
        Me.btnSave.TabIndex = 10
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(393, 154)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(75, 23)
        Me.btnDelete.TabIndex = 11
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'EmployeeDTOBindingSource
        '
        Me.EmployeeDTOBindingSource.DataSource = GetType(TestClient.EmployeeRef.EmployeeDTO)
        '
        'EmployeeDTOBindingNavigator
        '
        Me.EmployeeDTOBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmployeeDTOBindingNavigator.BindingSource = Me.EmployeeDTOBindingSource
        Me.EmployeeDTOBindingNavigator.CountItem = Nothing
        Me.EmployeeDTOBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmployeeDTOBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmployeeDTOBindingNavigatorSaveItem})
        Me.EmployeeDTOBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmployeeDTOBindingNavigator.MoveFirstItem = Nothing
        Me.EmployeeDTOBindingNavigator.MoveLastItem = Nothing
        Me.EmployeeDTOBindingNavigator.MoveNextItem = Nothing
        Me.EmployeeDTOBindingNavigator.MovePreviousItem = Nothing
        Me.EmployeeDTOBindingNavigator.Name = "EmployeeDTOBindingNavigator"
        Me.EmployeeDTOBindingNavigator.PositionItem = Nothing
        Me.EmployeeDTOBindingNavigator.Size = New System.Drawing.Size(602, 25)
        Me.EmployeeDTOBindingNavigator.TabIndex = 12
        Me.EmployeeDTOBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'EmployeeDTOBindingNavigatorSaveItem
        '
        Me.EmployeeDTOBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmployeeDTOBindingNavigatorSaveItem.Enabled = False
        Me.EmployeeDTOBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmployeeDTOBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmployeeDTOBindingNavigatorSaveItem.Name = "EmployeeDTOBindingNavigatorSaveItem"
        Me.EmployeeDTOBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmployeeDTOBindingNavigatorSaveItem.Text = "Save Data"
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDTOBindingSource, "EmployeeID", True))
        Me.txtEmployeeID.Location = New System.Drawing.Point(92, 39)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.Size = New System.Drawing.Size(100, 20)
        Me.txtEmployeeID.TabIndex = 13
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDTOBindingSource, "FirstName", True))
        Me.txtFirstName.Location = New System.Drawing.Point(92, 65)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 15
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmployeeDTOBindingSource, "LastName", True))
        Me.txtLastName.Location = New System.Drawing.Point(92, 91)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 17
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(113, 153)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 18
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(309, 153)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnCancel.TabIndex = 19
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(602, 329)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(EmployeeIDLabel)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(LastNameLabel)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.EmployeeDTOBindingNavigator)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lstError)
        Me.Controls.Add(Me.btnGetRecord)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.EmployeeDTOBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeDTOBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmployeeDTOBindingNavigator.ResumeLayout(False)
        Me.EmployeeDTOBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnGetRecord As System.Windows.Forms.Button
    Friend WithEvents lstError As System.Windows.Forms.ListBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnAdd As System.Windows.Forms.Button
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents EmployeeDTOBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmployeeDTOBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmployeeDTOBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents btnEdit As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

End Class

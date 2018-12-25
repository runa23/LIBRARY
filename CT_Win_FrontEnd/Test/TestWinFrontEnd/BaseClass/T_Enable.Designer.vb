<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_Enable
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
        Me.btnEAdd = New System.Windows.Forms.Button
        Me.btnDAdd = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.btnEEdit = New System.Windows.Forms.Button
        Me.btnDData = New System.Windows.Forms.Button
        Me.btnEData = New System.Windows.Forms.Button
        Me.btnDEdit = New System.Windows.Forms.Button
        Me.Button6 = New System.Windows.Forms.Button
        Me.btnDFind = New System.Windows.Forms.Button
        Me.btnEFind = New System.Windows.Forms.Button
        Me.R_MaskedTextBox1 = New R_Win_FrontEnd.R_MaskedTextBox
        Me.R_Conductor1 = New R_Win_FrontEnd.R_Conductor(Me.components)
        Me.R_Button3 = New R_Win_FrontEnd.R_Button
        Me.R_ListBox1 = New R_Win_FrontEnd.R_ListBox
        Me.R_Button2 = New R_Win_FrontEnd.R_Button
        Me.R_ComboBox1 = New R_Win_FrontEnd.R_ComboBox
        Me.R_Button1 = New R_Win_FrontEnd.R_Button
        Me.R_CheckBox1 = New R_Win_FrontEnd.R_CheckBox
        Me.btnEdit = New R_Win_FrontEnd.R_Button
        Me.txtAdd = New R_Win_FrontEnd.R_TextBox
        Me.btn1 = New R_Win_FrontEnd.R_Button
        Me.SuspendLayout()
        '
        'btnEAdd
        '
        Me.btnEAdd.Location = New System.Drawing.Point(12, 171)
        Me.btnEAdd.Name = "btnEAdd"
        Me.btnEAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnEAdd.TabIndex = 2
        Me.btnEAdd.Text = "EnableAdd"
        Me.btnEAdd.UseVisualStyleBackColor = True
        '
        'btnDAdd
        '
        Me.btnDAdd.Location = New System.Drawing.Point(12, 200)
        Me.btnDAdd.Name = "btnDAdd"
        Me.btnDAdd.Size = New System.Drawing.Size(75, 23)
        Me.btnDAdd.TabIndex = 3
        Me.btnDAdd.Text = "DisableAdd"
        Me.btnDAdd.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(142, 200)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 14
        Me.Button1.Text = "DisableEdit"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnEEdit
        '
        Me.btnEEdit.Location = New System.Drawing.Point(142, 171)
        Me.btnEEdit.Name = "btnEEdit"
        Me.btnEEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEEdit.TabIndex = 13
        Me.btnEEdit.Text = "EnableEdit"
        Me.btnEEdit.UseVisualStyleBackColor = True
        '
        'btnDData
        '
        Me.btnDData.Location = New System.Drawing.Point(453, 200)
        Me.btnDData.Name = "btnDData"
        Me.btnDData.Size = New System.Drawing.Size(75, 23)
        Me.btnDData.TabIndex = 18
        Me.btnDData.Text = "DisableHasData"
        Me.btnDData.UseVisualStyleBackColor = True
        '
        'btnEData
        '
        Me.btnEData.Location = New System.Drawing.Point(453, 171)
        Me.btnEData.Name = "btnEData"
        Me.btnEData.Size = New System.Drawing.Size(75, 23)
        Me.btnEData.TabIndex = 17
        Me.btnEData.Text = "EnableHasData"
        Me.btnEData.UseVisualStyleBackColor = True
        '
        'btnDEdit
        '
        Me.btnDEdit.Location = New System.Drawing.Point(277, 200)
        Me.btnDEdit.Name = "btnDEdit"
        Me.btnDEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnDEdit.TabIndex = 16
        Me.btnDEdit.Text = "DisableOther"
        Me.btnDEdit.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Location = New System.Drawing.Point(277, 171)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(75, 23)
        Me.Button6.TabIndex = 15
        Me.Button6.Text = "EnableOther"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'btnDFind
        '
        Me.btnDFind.Location = New System.Drawing.Point(647, 200)
        Me.btnDFind.Name = "btnDFind"
        Me.btnDFind.Size = New System.Drawing.Size(75, 23)
        Me.btnDFind.TabIndex = 20
        Me.btnDFind.Text = "DisableFind"
        Me.btnDFind.UseVisualStyleBackColor = True
        '
        'btnEFind
        '
        Me.btnEFind.Location = New System.Drawing.Point(647, 171)
        Me.btnEFind.Name = "btnEFind"
        Me.btnEFind.Size = New System.Drawing.Size(75, 23)
        Me.btnEFind.TabIndex = 19
        Me.btnEFind.Text = "EnableFind"
        Me.btnEFind.UseVisualStyleBackColor = True
        '
        'R_MaskedTextBox1
        '
        Me.R_MaskedTextBox1.Location = New System.Drawing.Point(647, 41)
        Me.R_MaskedTextBox1.Name = "R_MaskedTextBox1"
        Me.R_MaskedTextBox1.R_ConductorSource = Me.R_Conductor1
        Me.R_MaskedTextBox1.R_EnableFIND = True
        Me.R_MaskedTextBox1.Size = New System.Drawing.Size(100, 20)
        Me.R_MaskedTextBox1.TabIndex = 12
        '
        'R_Button3
        '
        Me.R_Button3.Location = New System.Drawing.Point(647, 10)
        Me.R_Button3.Name = "R_Button3"
        Me.R_Button3.R_ConductorSource = Me.R_Conductor1
        Me.R_Button3.R_EnableFIND = True
        Me.R_Button3.Size = New System.Drawing.Size(75, 23)
        Me.R_Button3.TabIndex = 11
        Me.R_Button3.Text = "Find"
        Me.R_Button3.UseVisualStyleBackColor = True
        '
        'R_ListBox1
        '
        Me.R_ListBox1.FormattingEnabled = True
        Me.R_ListBox1.Items.AddRange(New Object() {"satu", "dua"})
        Me.R_ListBox1.Location = New System.Drawing.Point(453, 42)
        Me.R_ListBox1.Name = "R_ListBox1"
        Me.R_ListBox1.R_ConductorSource = Me.R_Conductor1
        Me.R_ListBox1.R_EnableHASDATA = True
        Me.R_ListBox1.Size = New System.Drawing.Size(120, 95)
        Me.R_ListBox1.TabIndex = 10
        '
        'R_Button2
        '
        Me.R_Button2.Location = New System.Drawing.Point(453, 11)
        Me.R_Button2.Name = "R_Button2"
        Me.R_Button2.R_ConductorSource = Me.R_Conductor1
        Me.R_Button2.R_EnableHASDATA = True
        Me.R_Button2.Size = New System.Drawing.Size(75, 23)
        Me.R_Button2.TabIndex = 9
        Me.R_Button2.Text = "HasData"
        Me.R_Button2.UseVisualStyleBackColor = True
        '
        'R_ComboBox1
        '
        Me.R_ComboBox1.FormattingEnabled = True
        Me.R_ComboBox1.Location = New System.Drawing.Point(277, 40)
        Me.R_ComboBox1.Name = "R_ComboBox1"
        Me.R_ComboBox1.R_ConductorSource = Me.R_Conductor1
        Me.R_ComboBox1.R_EnableOTHER = True
        Me.R_ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.R_ComboBox1.TabIndex = 8
        '
        'R_Button1
        '
        Me.R_Button1.Location = New System.Drawing.Point(277, 11)
        Me.R_Button1.Name = "R_Button1"
        Me.R_Button1.R_ConductorSource = Me.R_Conductor1
        Me.R_Button1.R_EnableOTHER = True
        Me.R_Button1.Size = New System.Drawing.Size(75, 23)
        Me.R_Button1.TabIndex = 7
        Me.R_Button1.Text = "Other"
        Me.R_Button1.UseVisualStyleBackColor = True
        '
        'R_CheckBox1
        '
        Me.R_CheckBox1.AutoSize = True
        Me.R_CheckBox1.Location = New System.Drawing.Point(142, 44)
        Me.R_CheckBox1.Name = "R_CheckBox1"
        Me.R_CheckBox1.R_ConductorSource = Me.R_Conductor1
        Me.R_CheckBox1.R_EnableEDIT = True
        Me.R_CheckBox1.Size = New System.Drawing.Size(95, 17)
        Me.R_CheckBox1.TabIndex = 6
        Me.R_CheckBox1.Text = "R_CheckBox1"
        Me.R_CheckBox1.UseVisualStyleBackColor = True
        '
        'btnEdit
        '
        Me.btnEdit.Location = New System.Drawing.Point(142, 12)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.R_ConductorSource = Me.R_Conductor1
        Me.btnEdit.R_EnableEDIT = True
        Me.btnEdit.Size = New System.Drawing.Size(75, 23)
        Me.btnEdit.TabIndex = 5
        Me.btnEdit.Text = "Edit"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'txtAdd
        '
        Me.txtAdd.Location = New System.Drawing.Point(13, 42)
        Me.txtAdd.Name = "txtAdd"
        Me.txtAdd.R_ConductorSource = Me.R_Conductor1
        Me.txtAdd.R_EnableADD = True
        Me.txtAdd.Size = New System.Drawing.Size(100, 20)
        Me.txtAdd.TabIndex = 4
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(12, 12)
        Me.btn1.Name = "btn1"
        Me.btn1.R_ConductorSource = Me.R_Conductor1
        Me.btn1.R_EnableADD = True
        Me.btn1.Size = New System.Drawing.Size(75, 23)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Add"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'T_Enable
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(868, 266)
        Me.Controls.Add(Me.btnDFind)
        Me.Controls.Add(Me.btnEFind)
        Me.Controls.Add(Me.btnDData)
        Me.Controls.Add(Me.btnEData)
        Me.Controls.Add(Me.btnDEdit)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnEEdit)
        Me.Controls.Add(Me.R_MaskedTextBox1)
        Me.Controls.Add(Me.R_Button3)
        Me.Controls.Add(Me.R_ListBox1)
        Me.Controls.Add(Me.R_Button2)
        Me.Controls.Add(Me.R_ComboBox1)
        Me.Controls.Add(Me.R_Button1)
        Me.Controls.Add(Me.R_CheckBox1)
        Me.Controls.Add(Me.btnEdit)
        Me.Controls.Add(Me.txtAdd)
        Me.Controls.Add(Me.btnDAdd)
        Me.Controls.Add(Me.btnEAdd)
        Me.Controls.Add(Me.btn1)
        Me.Name = "T_Enable"
        Me.Text = "T_Enable"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents R_Conductor1 As R_Win_FrontEnd.R_Conductor
    Friend WithEvents btn1 As R_Win_FrontEnd.R_Button
    Friend WithEvents btnEAdd As System.Windows.Forms.Button
    Friend WithEvents btnDAdd As System.Windows.Forms.Button
    Friend WithEvents txtAdd As R_Win_FrontEnd.R_TextBox
    Friend WithEvents btnEdit As R_Win_FrontEnd.R_Button
    Friend WithEvents R_CheckBox1 As R_Win_FrontEnd.R_CheckBox
    Friend WithEvents R_Button1 As R_Win_FrontEnd.R_Button
    Friend WithEvents R_ComboBox1 As R_Win_FrontEnd.R_ComboBox
    Friend WithEvents R_Button2 As R_Win_FrontEnd.R_Button
    Friend WithEvents R_ListBox1 As R_Win_FrontEnd.R_ListBox
    Friend WithEvents R_Button3 As R_Win_FrontEnd.R_Button
    Friend WithEvents R_MaskedTextBox1 As R_Win_FrontEnd.R_MaskedTextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnEEdit As System.Windows.Forms.Button
    Friend WithEvents btnDData As System.Windows.Forms.Button
    Friend WithEvents btnEData As System.Windows.Forms.Button
    Friend WithEvents btnDEdit As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents btnDFind As System.Windows.Forms.Button
    Friend WithEvents btnEFind As System.Windows.Forms.Button
End Class

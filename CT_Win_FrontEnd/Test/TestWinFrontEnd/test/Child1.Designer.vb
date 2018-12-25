<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Child1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Child1))
        Me.R_Find1 = New R_Win_FrontEnd.R_Find
        Me.R_Save1 = New R_Win_FrontEnd.R_Save
        Me.R_Edit1 = New R_Win_FrontEnd.R_Edit
        Me.R_Delete1 = New R_Win_FrontEnd.R_Delete
        Me.R_Cancel1 = New R_Win_FrontEnd.R_Cancel
        Me.R_Add1 = New R_Win_FrontEnd.R_Add
        Me.R_LookUp1 = New R_Win_FrontEnd.R_LookUp
        Me.SuspendLayout()
        '
        'R_Find1
        '
        Me.R_Find1.Image = CType(resources.GetObject("R_Find1.Image"), System.Drawing.Image)
        Me.R_Find1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Find1.Location = New System.Drawing.Point(364, 12)
        Me.R_Find1.Name = "R_Find1"
        Me.R_Find1.R_ConductorSource = Nothing
        Me.R_Find1.Size = New System.Drawing.Size(61, 39)
        Me.R_Find1.TabIndex = 6
        Me.R_Find1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Find1.UseVisualStyleBackColor = True
        '
        'R_Save1
        '
        Me.R_Save1.Image = CType(resources.GetObject("R_Save1.Image"), System.Drawing.Image)
        Me.R_Save1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Save1.Location = New System.Drawing.Point(297, 13)
        Me.R_Save1.Name = "R_Save1"
        Me.R_Save1.R_ConductorSource = Nothing
        Me.R_Save1.Size = New System.Drawing.Size(61, 39)
        Me.R_Save1.TabIndex = 5
        Me.R_Save1.Text = "Save"
        Me.R_Save1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Save1.UseVisualStyleBackColor = True
        '
        'R_Edit1
        '
        Me.R_Edit1.Image = CType(resources.GetObject("R_Edit1.Image"), System.Drawing.Image)
        Me.R_Edit1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Edit1.Location = New System.Drawing.Point(230, 13)
        Me.R_Edit1.Name = "R_Edit1"
        Me.R_Edit1.R_ConductorSource = Nothing
        Me.R_Edit1.Size = New System.Drawing.Size(61, 39)
        Me.R_Edit1.TabIndex = 4
        Me.R_Edit1.Text = "Edit"
        Me.R_Edit1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Edit1.UseVisualStyleBackColor = True
        '
        'R_Delete1
        '
        Me.R_Delete1.Image = CType(resources.GetObject("R_Delete1.Image"), System.Drawing.Image)
        Me.R_Delete1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Delete1.Location = New System.Drawing.Point(163, 13)
        Me.R_Delete1.Name = "R_Delete1"
        Me.R_Delete1.R_ConductorSource = Nothing
        Me.R_Delete1.Size = New System.Drawing.Size(61, 39)
        Me.R_Delete1.TabIndex = 3
        Me.R_Delete1.Text = "Delete"
        Me.R_Delete1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Delete1.UseVisualStyleBackColor = True
        '
        'R_Cancel1
        '
        Me.R_Cancel1.Image = CType(resources.GetObject("R_Cancel1.Image"), System.Drawing.Image)
        Me.R_Cancel1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Cancel1.Location = New System.Drawing.Point(96, 13)
        Me.R_Cancel1.Name = "R_Cancel1"
        Me.R_Cancel1.R_ConductorSource = Nothing
        Me.R_Cancel1.Size = New System.Drawing.Size(61, 39)
        Me.R_Cancel1.TabIndex = 2
        Me.R_Cancel1.Text = "Cancel"
        Me.R_Cancel1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Cancel1.UseVisualStyleBackColor = True
        '
        'R_Add1
        '
        Me.R_Add1.Image = CType(resources.GetObject("R_Add1.Image"), System.Drawing.Image)
        Me.R_Add1.ImageAlign = System.Drawing.ContentAlignment.TopCenter
        Me.R_Add1.Location = New System.Drawing.Point(29, 13)
        Me.R_Add1.Name = "R_Add1"
        Me.R_Add1.R_ConductorSource = Nothing
        Me.R_Add1.Size = New System.Drawing.Size(61, 39)
        Me.R_Add1.TabIndex = 1
        Me.R_Add1.Text = "Add New"
        Me.R_Add1.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.R_Add1.UseVisualStyleBackColor = True
        '
        'R_LookUp1
        '
        Me.R_LookUp1.Location = New System.Drawing.Point(29, 72)
        Me.R_LookUp1.Name = "R_LookUp1"
        Me.R_LookUp1.R_ConductorSource = Nothing
        Me.R_LookUp1.R_Field_Description = ""
        Me.R_LookUp1.R_Field_Value = ""
        Me.R_LookUp1.R_TextBox_Description = Nothing
        Me.R_LookUp1.R_TextBox_Value = Nothing
        Me.R_LookUp1.Size = New System.Drawing.Size(26, 23)
        Me.R_LookUp1.TabIndex = 7
        Me.R_LookUp1.UseVisualStyleBackColor = True
        '
        'Child1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(553, 266)
        Me.Controls.Add(Me.R_LookUp1)
        Me.Controls.Add(Me.R_Find1)
        Me.Controls.Add(Me.R_Save1)
        Me.Controls.Add(Me.R_Edit1)
        Me.Controls.Add(Me.R_Delete1)
        Me.Controls.Add(Me.R_Cancel1)
        Me.Controls.Add(Me.R_Add1)
        Me.Name = "Child1"
        Me.Text = "Child1"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents R_Add1 As R_Win_FrontEnd.R_Add
    Friend WithEvents R_Cancel1 As R_Win_FrontEnd.R_Cancel
    Friend WithEvents R_Delete1 As R_Win_FrontEnd.R_Delete
    Friend WithEvents R_Edit1 As R_Win_FrontEnd.R_Edit
    Friend WithEvents R_Save1 As R_Win_FrontEnd.R_Save
    Friend WithEvents R_Find1 As R_Win_FrontEnd.R_Find
    Friend WithEvents R_LookUp1 As R_Win_FrontEnd.R_LookUp
End Class

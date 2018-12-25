<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LookUpButtonForm
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
        Me.TextBox1 = New System.Windows.Forms.TextBox
        Me.TextBox2 = New System.Windows.Forms.TextBox
        Me.R_LookUp1 = New R_Win_FrontEnd.R_LookUp
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(34, 13)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(140, 15)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(100, 20)
        Me.TextBox2.TabIndex = 1
        '
        'R_LookUp1
        '
        Me.R_LookUp1.Location = New System.Drawing.Point(246, 13)
        Me.R_LookUp1.Name = "R_LookUp1"
        Me.R_LookUp1.R_ConductorSource = Nothing
        Me.R_LookUp1.R_Field_Description = "Firstname"
        Me.R_LookUp1.R_Field_Value = "CustomerId"
        Me.R_LookUp1.R_TextBox_Description = Me.TextBox2
        Me.R_LookUp1.R_TextBox_Value = Me.TextBox1
        Me.R_LookUp1.Size = New System.Drawing.Size(31, 23)
        Me.R_LookUp1.TabIndex = 2
        Me.R_LookUp1.UseVisualStyleBackColor = True
        '
        'LookUpButtonForm
        '
        Me.AutoSize = True
        Me.ClientSize = New System.Drawing.Size(641, 266)
        Me.Controls.Add(Me.R_LookUp1)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.TextBox1)
        Me.Name = "LookUpButtonForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents R_LookUp1 As R_Win_FrontEnd.R_LookUp

End Class

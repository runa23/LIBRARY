<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ParentForm
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
        Me.R_Detail1 = New R_Win_FrontEnd.R_Detail
        Me.txtPar1 = New System.Windows.Forms.TextBox
        Me.txtPar2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'R_Detail1
        '
        Me.R_Detail1.Location = New System.Drawing.Point(159, 29)
        Me.R_Detail1.Name = "R_Detail1"
        Me.R_Detail1.R_ConductorSource = Nothing
        Me.R_Detail1.Size = New System.Drawing.Size(75, 23)
        Me.R_Detail1.TabIndex = 0
        Me.R_Detail1.Text = "R_Detail1"
        Me.R_Detail1.UseVisualStyleBackColor = True
        '
        'txtPar1
        '
        Me.txtPar1.Location = New System.Drawing.Point(31, 31)
        Me.txtPar1.Name = "txtPar1"
        Me.txtPar1.Size = New System.Drawing.Size(100, 20)
        Me.txtPar1.TabIndex = 1
        '
        'txtPar2
        '
        Me.txtPar2.Location = New System.Drawing.Point(31, 58)
        Me.txtPar2.Name = "txtPar2"
        Me.txtPar2.Size = New System.Drawing.Size(100, 20)
        Me.txtPar2.TabIndex = 2
        '
        'ParentForm
        '
        Me.ClientSize = New System.Drawing.Size(597, 266)
        Me.Controls.Add(Me.txtPar2)
        Me.Controls.Add(Me.txtPar1)
        Me.Controls.Add(Me.R_Detail1)
        Me.Name = "ParentForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents R_Detail1 As R_Win_FrontEnd.R_Detail
    Friend WithEvents txtPar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPar2 As System.Windows.Forms.TextBox

End Class

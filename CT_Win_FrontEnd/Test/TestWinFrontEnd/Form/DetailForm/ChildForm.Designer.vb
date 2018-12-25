<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ChildForm
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
        Me.txtPar1 = New System.Windows.Forms.TextBox
        Me.txtPar2 = New System.Windows.Forms.TextBox
        Me.SuspendLayout()
        '
        'txtPar1
        '
        Me.txtPar1.Location = New System.Drawing.Point(12, 12)
        Me.txtPar1.Name = "txtPar1"
        Me.txtPar1.Size = New System.Drawing.Size(100, 20)
        Me.txtPar1.TabIndex = 0
        '
        'txtPar2
        '
        Me.txtPar2.Location = New System.Drawing.Point(12, 38)
        Me.txtPar2.Name = "txtPar2"
        Me.txtPar2.Size = New System.Drawing.Size(100, 20)
        Me.txtPar2.TabIndex = 1
        '
        'ChildForm
        '
        Me.ClientSize = New System.Drawing.Size(695, 266)
        Me.Controls.Add(Me.txtPar2)
        Me.Controls.Add(Me.txtPar1)
        Me.Name = "ChildForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtPar1 As System.Windows.Forms.TextBox
    Friend WithEvents txtPar2 As System.Windows.Forms.TextBox

End Class

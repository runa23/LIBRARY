<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CTM0101
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
        Me.CT_Button1 = New CT_Win_FrontEnd.CT_Button
        Me.SuspendLayout()
        '
        'CT_Button1
        '
        Me.CT_Button1.CT_ConductorSource = Nothing
        Me.CT_Button1.Location = New System.Drawing.Point(38, 35)
        Me.CT_Button1.Name = "CT_Button1"
        Me.CT_Button1.Size = New System.Drawing.Size(75, 23)
        Me.CT_Button1.TabIndex = 0
        Me.CT_Button1.Text = "CT_Button1"
        Me.CT_Button1.UseVisualStyleBackColor = True
        '
        'CTM0101
        '
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.CT_Button1)
        Me.Name = "CTM0101"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CT_Button1 As CT_Win_FrontEnd.CT_Button

End Class

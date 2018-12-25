<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GlobalVar
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
        Me.btnSet = New System.Windows.Forms.Button
        Me.btnDisplay = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnSet
        '
        Me.btnSet.Location = New System.Drawing.Point(12, 3)
        Me.btnSet.Name = "btnSet"
        Me.btnSet.Size = New System.Drawing.Size(106, 23)
        Me.btnSet.TabIndex = 0
        Me.btnSet.Text = "Set UserId"
        Me.btnSet.UseVisualStyleBackColor = True
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(12, 44)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(106, 23)
        Me.btnDisplay.TabIndex = 1
        Me.btnDisplay.Text = "Display userId"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'GlobalVar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 266)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.btnSet)
        Me.Name = "GlobalVar"
        Me.Text = "GlobalVar"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnSet As System.Windows.Forms.Button
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
End Class

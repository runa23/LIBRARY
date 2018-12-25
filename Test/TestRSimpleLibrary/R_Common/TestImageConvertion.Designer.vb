<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TestImageConvertion
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
        Me.btnConvertImage = New System.Windows.Forms.Button
        Me.btnConvertBinary = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.SaveFileDialog1 = New System.Windows.Forms.SaveFileDialog
        Me.btnFromFile = New System.Windows.Forms.Button
        Me.btnFomByte = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnConvertImage
        '
        Me.btnConvertImage.Location = New System.Drawing.Point(12, 12)
        Me.btnConvertImage.Name = "btnConvertImage"
        Me.btnConvertImage.Size = New System.Drawing.Size(135, 23)
        Me.btnConvertImage.TabIndex = 0
        Me.btnConvertImage.Text = "Convert image"
        Me.btnConvertImage.UseVisualStyleBackColor = True
        '
        'btnConvertBinary
        '
        Me.btnConvertBinary.Location = New System.Drawing.Point(12, 41)
        Me.btnConvertBinary.Name = "btnConvertBinary"
        Me.btnConvertBinary.Size = New System.Drawing.Size(135, 23)
        Me.btnConvertBinary.TabIndex = 1
        Me.btnConvertBinary.Text = "Covert Binary File"
        Me.btnConvertBinary.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnFromFile
        '
        Me.btnFromFile.Location = New System.Drawing.Point(13, 104)
        Me.btnFromFile.Name = "btnFromFile"
        Me.btnFromFile.Size = New System.Drawing.Size(134, 23)
        Me.btnFromFile.TabIndex = 2
        Me.btnFromFile.Text = "Compress from File"
        Me.btnFromFile.UseVisualStyleBackColor = True
        '
        'btnFomByte
        '
        Me.btnFomByte.Location = New System.Drawing.Point(13, 142)
        Me.btnFomByte.Name = "btnFomByte"
        Me.btnFomByte.Size = New System.Drawing.Size(134, 23)
        Me.btnFomByte.TabIndex = 3
        Me.btnFomByte.Text = "Compress From Byte"
        Me.btnFomByte.UseVisualStyleBackColor = True
        '
        'TestImageConvertion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(480, 266)
        Me.Controls.Add(Me.btnFomByte)
        Me.Controls.Add(Me.btnFromFile)
        Me.Controls.Add(Me.btnConvertBinary)
        Me.Controls.Add(Me.btnConvertImage)
        Me.Name = "TestImageConvertion"
        Me.Text = "TestImageConvertion"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnConvertImage As System.Windows.Forms.Button
    Friend WithEvents btnConvertBinary As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SaveFileDialog1 As System.Windows.Forms.SaveFileDialog
    Friend WithEvents btnFromFile As System.Windows.Forms.Button
    Friend WithEvents btnFomByte As System.Windows.Forms.Button
End Class

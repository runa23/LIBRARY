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
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.btnScanAndGetByte = New System.Windows.Forms.Button
        Me.btnEnroll = New System.Windows.Forms.Button
        Me.btnSearch = New System.Windows.Forms.Button
        Me.lstSearch = New System.Windows.Forms.ListBox
        Me.txtId = New System.Windows.Forms.TextBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.btnSearch2 = New System.Windows.Forms.Button
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer
        Me.RectangleShape1 = New Microsoft.VisualBasic.PowerPacks.RectangleShape
        Me.btnDelete = New System.Windows.Forms.Button
        Me.Button1 = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'btnScanAndGetByte
        '
        Me.btnScanAndGetByte.Location = New System.Drawing.Point(12, 27)
        Me.btnScanAndGetByte.Name = "btnScanAndGetByte"
        Me.btnScanAndGetByte.Size = New System.Drawing.Size(159, 23)
        Me.btnScanAndGetByte.TabIndex = 1
        Me.btnScanAndGetByte.Text = "Scan and Get Byte"
        Me.btnScanAndGetByte.UseVisualStyleBackColor = True
        '
        'btnEnroll
        '
        Me.btnEnroll.Location = New System.Drawing.Point(12, 56)
        Me.btnEnroll.Name = "btnEnroll"
        Me.btnEnroll.Size = New System.Drawing.Size(159, 23)
        Me.btnEnroll.TabIndex = 2
        Me.btnEnroll.Text = "Enroll From Scan Finger"
        Me.btnEnroll.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Location = New System.Drawing.Point(12, 88)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(159, 23)
        Me.btnSearch.TabIndex = 3
        Me.btnSearch.Text = "Search From Scan Finger"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'lstSearch
        '
        Me.lstSearch.FormattingEnabled = True
        Me.lstSearch.Location = New System.Drawing.Point(12, 181)
        Me.lstSearch.Name = "lstSearch"
        Me.lstSearch.Size = New System.Drawing.Size(318, 108)
        Me.lstSearch.TabIndex = 4
        '
        'txtId
        '
        Me.txtId.Location = New System.Drawing.Point(287, 9)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(141, 20)
        Me.txtId.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(265, 12)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Id"
        '
        'btnSearch2
        '
        Me.btnSearch2.Location = New System.Drawing.Point(12, 152)
        Me.btnSearch2.Name = "btnSearch2"
        Me.btnSearch2.Size = New System.Drawing.Size(159, 23)
        Me.btnSearch2.TabIndex = 7
        Me.btnSearch2.Text = "Get and Search Finger"
        Me.btnSearch2.UseVisualStyleBackColor = True
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.RectangleShape1})
        Me.ShapeContainer1.Size = New System.Drawing.Size(510, 310)
        Me.ShapeContainer1.TabIndex = 8
        Me.ShapeContainer1.TabStop = False
        '
        'RectangleShape1
        '
        Me.RectangleShape1.Location = New System.Drawing.Point(3, 13)
        Me.RectangleShape1.Name = "RectangleShape1"
        Me.RectangleShape1.Size = New System.Drawing.Size(178, 110)
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(188, 152)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(129, 23)
        Me.btnDelete.TabIndex = 9
        Me.btnDelete.Text = "Delete by Id"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(268, 55)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(510, 310)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnSearch2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.lstSearch)
        Me.Controls.Add(Me.btnSearch)
        Me.Controls.Add(Me.btnEnroll)
        Me.Controls.Add(Me.btnScanAndGetByte)
        Me.Controls.Add(Me.ShapeContainer1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents btnScanAndGetByte As System.Windows.Forms.Button
    Friend WithEvents btnEnroll As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents lstSearch As System.Windows.Forms.ListBox
    Friend WithEvents txtId As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnSearch2 As System.Windows.Forms.Button
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents RectangleShape1 As Microsoft.VisualBasic.PowerPacks.RectangleShape
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class T_R_Db
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
        Me.btnOpenConnection = New System.Windows.Forms.Button
        Me.txtError = New System.Windows.Forms.TextBox
        Me.btnCloseConnection = New System.Windows.Forms.Button
        Me.btnGetErrorTable = New System.Windows.Forms.Button
        Me.lstResult = New System.Windows.Forms.ListBox
        Me.btnGetErrorDb = New System.Windows.Forms.Button
        Me.btnExecStoreProc = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'btnOpenConnection
        '
        Me.btnOpenConnection.Location = New System.Drawing.Point(12, 12)
        Me.btnOpenConnection.Name = "btnOpenConnection"
        Me.btnOpenConnection.Size = New System.Drawing.Size(141, 23)
        Me.btnOpenConnection.TabIndex = 0
        Me.btnOpenConnection.Text = "Open Connection"
        Me.btnOpenConnection.UseVisualStyleBackColor = True
        '
        'txtError
        '
        Me.txtError.Location = New System.Drawing.Point(12, 249)
        Me.txtError.Multiline = True
        Me.txtError.Name = "txtError"
        Me.txtError.Size = New System.Drawing.Size(801, 123)
        Me.txtError.TabIndex = 5
        '
        'btnCloseConnection
        '
        Me.btnCloseConnection.Location = New System.Drawing.Point(12, 41)
        Me.btnCloseConnection.Name = "btnCloseConnection"
        Me.btnCloseConnection.Size = New System.Drawing.Size(141, 23)
        Me.btnCloseConnection.TabIndex = 6
        Me.btnCloseConnection.Text = "Close Connection"
        Me.btnCloseConnection.UseVisualStyleBackColor = True
        '
        'btnGetErrorTable
        '
        Me.btnGetErrorTable.Location = New System.Drawing.Point(12, 70)
        Me.btnGetErrorTable.Name = "btnGetErrorTable"
        Me.btnGetErrorTable.Size = New System.Drawing.Size(141, 23)
        Me.btnGetErrorTable.TabIndex = 7
        Me.btnGetErrorTable.Text = "Get Error Table"
        Me.btnGetErrorTable.UseVisualStyleBackColor = True
        '
        'lstResult
        '
        Me.lstResult.FormattingEnabled = True
        Me.lstResult.Location = New System.Drawing.Point(12, 130)
        Me.lstResult.Name = "lstResult"
        Me.lstResult.Size = New System.Drawing.Size(801, 108)
        Me.lstResult.TabIndex = 8
        '
        'btnGetErrorDb
        '
        Me.btnGetErrorDb.Location = New System.Drawing.Point(13, 100)
        Me.btnGetErrorDb.Name = "btnGetErrorDb"
        Me.btnGetErrorDb.Size = New System.Drawing.Size(140, 23)
        Me.btnGetErrorDb.TabIndex = 9
        Me.btnGetErrorDb.Text = "Get error Object Db"
        Me.btnGetErrorDb.UseVisualStyleBackColor = True
        '
        'btnExecStoreProc
        '
        Me.btnExecStoreProc.Location = New System.Drawing.Point(171, 12)
        Me.btnExecStoreProc.Name = "btnExecStoreProc"
        Me.btnExecStoreProc.Size = New System.Drawing.Size(128, 23)
        Me.btnExecStoreProc.TabIndex = 10
        Me.btnExecStoreProc.Text = "Exec Store Procedure"
        Me.btnExecStoreProc.UseVisualStyleBackColor = True
        '
        'T_R_Db
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(844, 384)
        Me.Controls.Add(Me.btnExecStoreProc)
        Me.Controls.Add(Me.btnGetErrorDb)
        Me.Controls.Add(Me.lstResult)
        Me.Controls.Add(Me.btnGetErrorTable)
        Me.Controls.Add(Me.btnCloseConnection)
        Me.Controls.Add(Me.txtError)
        Me.Controls.Add(Me.btnOpenConnection)
        Me.Name = "T_R_Db"
        Me.Text = "T_R_Db"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenConnection As System.Windows.Forms.Button
    Friend WithEvents txtError As System.Windows.Forms.TextBox
    Friend WithEvents btnCloseConnection As System.Windows.Forms.Button
    Friend WithEvents btnGetErrorTable As System.Windows.Forms.Button
    Friend WithEvents lstResult As System.Windows.Forms.ListBox
    Friend WithEvents btnGetErrorDb As System.Windows.Forms.Button
    Friend WithEvents btnExecStoreProc As System.Windows.Forms.Button
End Class

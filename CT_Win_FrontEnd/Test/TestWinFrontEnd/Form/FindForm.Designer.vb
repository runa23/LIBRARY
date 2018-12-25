<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FindForm
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
        Me.components = New System.ComponentModel.Container
        Dim CustomerIdLabel As System.Windows.Forms.Label
        Dim FirstNameLabel As System.Windows.Forms.Label
        Dim SexLabel As System.Windows.Forms.Label
        Me.LkCustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CustomerIdTextBox = New System.Windows.Forms.TextBox
        Me.FirstNameTextBox = New System.Windows.Forms.TextBox
        Me.SexTextBox = New System.Windows.Forms.TextBox
        Me.R_Find1 = New R_Win_FrontEnd.R_Find
        CustomerIdLabel = New System.Windows.Forms.Label
        FirstNameLabel = New System.Windows.Forms.Label
        SexLabel = New System.Windows.Forms.Label
        CType(Me.LkCustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LkCustomerBindingSource
        '
        Me.LkCustomerBindingSource.DataSource = GetType(TestWinFrontEnd.lkCustomer)
        '
        'CustomerIdLabel
        '
        CustomerIdLabel.AutoSize = True
        CustomerIdLabel.Location = New System.Drawing.Point(7, 15)
        CustomerIdLabel.Name = "CustomerIdLabel"
        CustomerIdLabel.Size = New System.Drawing.Size(66, 13)
        CustomerIdLabel.TabIndex = 1
        CustomerIdLabel.Text = "Customer Id:"
        '
        'CustomerIdTextBox
        '
        Me.CustomerIdTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LkCustomerBindingSource, "CustomerId", True))
        Me.CustomerIdTextBox.Location = New System.Drawing.Point(79, 12)
        Me.CustomerIdTextBox.Name = "CustomerIdTextBox"
        Me.CustomerIdTextBox.Size = New System.Drawing.Size(100, 20)
        Me.CustomerIdTextBox.TabIndex = 2
        '
        'FirstNameLabel
        '
        FirstNameLabel.AutoSize = True
        FirstNameLabel.Location = New System.Drawing.Point(7, 41)
        FirstNameLabel.Name = "FirstNameLabel"
        FirstNameLabel.Size = New System.Drawing.Size(60, 13)
        FirstNameLabel.TabIndex = 3
        FirstNameLabel.Text = "First Name:"
        '
        'FirstNameTextBox
        '
        Me.FirstNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LkCustomerBindingSource, "FirstName", True))
        Me.FirstNameTextBox.Location = New System.Drawing.Point(79, 38)
        Me.FirstNameTextBox.Name = "FirstNameTextBox"
        Me.FirstNameTextBox.Size = New System.Drawing.Size(100, 20)
        Me.FirstNameTextBox.TabIndex = 4
        '
        'SexLabel
        '
        SexLabel.AutoSize = True
        SexLabel.Location = New System.Drawing.Point(7, 67)
        SexLabel.Name = "SexLabel"
        SexLabel.Size = New System.Drawing.Size(28, 13)
        SexLabel.TabIndex = 5
        SexLabel.Text = "Sex:"
        '
        'SexTextBox
        '
        Me.SexTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.LkCustomerBindingSource, "Sex", True))
        Me.SexTextBox.Location = New System.Drawing.Point(79, 64)
        Me.SexTextBox.Name = "SexTextBox"
        Me.SexTextBox.Size = New System.Drawing.Size(100, 20)
        Me.SexTextBox.TabIndex = 6
        '
        'R_Find1
        '
        Me.R_Find1.Location = New System.Drawing.Point(220, 5)
        Me.R_Find1.Name = "R_Find1"
        Me.R_Find1.R_ConductorSource = Nothing
        Me.R_Find1.Size = New System.Drawing.Size(75, 23)
        Me.R_Find1.TabIndex = 7
        Me.R_Find1.Text = "R_Find1"
        Me.R_Find1.UseVisualStyleBackColor = True
        '
        'FindForm
        '
        Me.ClientSize = New System.Drawing.Size(418, 266)
        Me.Controls.Add(Me.R_Find1)
        Me.Controls.Add(CustomerIdLabel)
        Me.Controls.Add(Me.CustomerIdTextBox)
        Me.Controls.Add(FirstNameLabel)
        Me.Controls.Add(Me.FirstNameTextBox)
        Me.Controls.Add(SexLabel)
        Me.Controls.Add(Me.SexTextBox)
        Me.Name = "FindForm"
        CType(Me.LkCustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LkCustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerIdTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FirstNameTextBox As System.Windows.Forms.TextBox
    Friend WithEvents SexTextBox As System.Windows.Forms.TextBox
    Friend WithEvents R_Find1 As R_Win_FrontEnd.R_Find

End Class

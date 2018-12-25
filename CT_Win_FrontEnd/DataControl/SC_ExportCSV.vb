Imports System.Text
Imports System.IO

Public Class SC_ExportCSV
    Inherits SC_UpdSavBase

#Region "  VARIABLEs  "
    Protected _DataGridView As DataGridView
    Protected _DefaultFileName As String
#End Region

#Region " PROPERTY"
    <System.ComponentModel.Category("SIMARC_ExportCSV")> _
    Public Property SC_DataGridView() As DataGridView
        Get
            Return _DataGridView
        End Get
        Set(ByVal value As DataGridView)
            _DataGridView = value
        End Set
    End Property
    <System.ComponentModel.Category("CTAgro_ExportCSV")> _
    Public Property SC_DefaultFileName() As String
        Get
            Return _DefaultFileName
        End Get
        Set(ByVal value As String)
            _DefaultFileName = value
        End Set
    End Property
#End Region

#Region " METHOD "
    Public Sub NotifyStatus(ByVal poRole As Object, ByVal status As String, ByVal HasData As Boolean)
        If HasData Then
            Me.Enabled = True
        Else
            Me.Enabled = False
        End If
    End Sub
#End Region

    Private Sub SC_ExportCSV_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        If _DataGridView IsNot Nothing Then
            ExportCSV()
        Else
            MsgBox("SC_DataGridView Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub

    Private Sub ExportCSV()
        Dim filePath As String
        Dim delimiter As String = ";"
        Dim sb As New StringBuilder()

        Try

            Dim saveFileDialog1 As New SaveFileDialog()
            saveFileDialog1.Filter = "excel (*.csv)|*.csv"
            saveFileDialog1.FilterIndex = 2
            saveFileDialog1.RestoreDirectory = True
            saveFileDialog1.FileName = _DefaultFileName + " - " + Now.ToString("yyyyMMdd HHmmss")

            If saveFileDialog1.ShowDialog() <> DialogResult.OK Then
                Exit Sub
            End If

            filePath = saveFileDialog1.FileName


            'create columnNames:
            For i As Integer = 0 To _DataGridView.Rows.Count - 1
                Dim array As String() = New String(_DataGridView.Columns.Count - 1) {}
                If i.Equals(0) Then
                    'get column header text from all columns:
                    For j As Integer = 0 To _DataGridView.Columns.Count - 1
                        array(j) = _DataGridView.Columns(j).HeaderText
                    Next
                    sb.AppendLine([String].Join(delimiter, array))
                End If
                'get values from columns for specific row (row[i]):
                For j As Integer = 0 To _DataGridView.Columns.Count - 1
                    If Not _DataGridView.Rows(i).IsNewRow Then
                        array(j) = _DataGridView(j, i).Value.ToString()
                    End If
                Next
                If Not _DataGridView.Rows(i).IsNewRow Then
                    sb.AppendLine([String].Join(delimiter, array))
                End If
            Next
            File.WriteAllText(filePath, sb.ToString())

            MessageBox.Show("Export Done")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class

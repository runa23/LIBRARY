Imports SC_Common
Public Class SC_ErrorForm
    Private _WinHeight As Integer
    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged
        If BindingSource1.Current IsNot Nothing Then
            If CType(BindingSource1.Current, SC_Error).HasErrorDetail Then
                DetailCollapse(False)
                ErrorDetailsBindingSource.DataSource = CType(BindingSource1.Current, SC_Error).ErrorDetails
            Else
                DetailCollapse(True)
            End If
        Else
            DetailCollapse(True)
        End If
    End Sub

    Private Sub DetailCollapse(ByVal plCollapse As Boolean)
        SplitContainer1.Panel2Collapsed = plCollapse
        If plCollapse Then
            Me.Height = SC_ErrorDataGridView.Height + 10
        Else
            Me.Height = _WinHeight
        End If
    End Sub

    Private Sub CT_ErrorForm_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        _WinHeight = Me.Height
        SplitContainer1.Panel2Collapsed = True
    End Sub

    Private Sub CT_ErrorForm_CT_Init_From_Master(ByVal poParameter As Object) Handles Me.SC_Init_From_Master
        If poParameter IsNot Nothing AndAlso TypeOf (poParameter) Is List(Of SC_Error) Then
            Me.BindingSource1.DataSource = poParameter
        End If
    End Sub
End Class

Imports System.ComponentModel

<ToolboxBitmap(GetType(Button))> _
Public Class SC_ReturnLookUpAndFind
    Inherits System.Windows.Forms.UserControl

    Private _BindingSource As BindingSource

#Region "Property"
    <Category("SIMARC_Data_Binding")> _
    Public Property SC_BindingSource() As BindingSource
        Get
            Return _BindingSource
        End Get
        Set(ByVal value As BindingSource)
            _BindingSource = value
        End Set
    End Property
#End Region

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        If _BindingSource IsNot Nothing AndAlso _BindingSource.Count > 0 Then
            If _BindingSource.Current IsNot Nothing Then
                Dim loIFormBase As SC_IFormBase = Nothing
                Try
                    loIFormBase = Me.FindForm
                Catch ex As Exception
                    MsgBox("Form must inherit from SC_FormBase")
                    Me.FindForm.Close()
                End Try
                If TypeOf (loIFormBase.getActionButton()) Is SC_ILookUpAndFindButton Then
                    CType(loIFormBase.getActionButton(), SC_ILookUpAndFindButton)._ReturnLookUpAndFind(_BindingSource.Current)
                End If
                Me.FindForm.Close()
            End If
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        Me.FindForm.Close()
    End Sub
End Class

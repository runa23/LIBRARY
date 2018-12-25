Imports System.ComponentModel
Public Class SC_Detail
    Inherits SC_Button

#Region "VARIABLE"
    Dim _RunAsModal As Boolean = True
#End Region

#Region "EVENT"
    Public Event SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) 'Untuk memberikan Initialisasi Form saat dipanggil
    Public Event SC_After_Open_Form(ByVal poOwnedForm As Form) 'Untuk melakukan sesuatu kalau Form Detail akan ditutup
#End Region

#Region " PROPERTY Local "
    Private _Text As String = "Detail"
    <DefaultValue("Detail")> _
    Public Overrides Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal value As String)
            _Text = value
        End Set
    End Property
#End Region

#Region "PROPERTY"
    <DefaultValue(True)> _
    <Category("SIMARC")> _
    Public Property SC_Run_As_Modal() As Boolean
        Get
            Return _RunAsModal
        End Get
        Set(ByVal value As Boolean)
            _RunAsModal = value
        End Set
    End Property
#End Region

    Private Sub SC_Detail_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim loTargetForm As SC_FormBase = Nothing
        Dim loParameter As Object = Nothing

        RaiseEvent SC_Before_Open_Form(loTargetForm, loParameter)
        If loTargetForm IsNot Nothing Then
            loTargetForm.Show()
            loTargetForm.Owner = Me.FindForm
            loTargetForm.StartPosition = FormStartPosition.CenterScreen
            CType(loTargetForm, SC_IFormBase)._InitFromMaster(loParameter, SC_eFormModel.Detail, Me)
            If _RunAsModal Then
                Me.FindForm.Enabled = False
            End If
        End If

    End Sub
End Class

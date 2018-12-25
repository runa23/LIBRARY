Imports System.ComponentModel
Imports SC_Common

Public Class SC_FormBase
    Inherits Form
    Implements SC_IFormBase

    Private _Form_Model As SC_eFormModel = SC_eFormModel.Detail
    Private _ActionButton As Object
    Private _ButtonName As String = ""

#Region "EVENT"
    Public Event SC_Init_From_Master(ByVal poParameter As Object) 'Untuk memberikan Initialisasi Form saat dipanggil
    Public Event SC_Return_From_Detail(ByVal poOwnedForm As Form, ByVal pcButtonName As String) 'Untuk melakukan sesuatu kalau Form Detail akan ditutup
#End Region

    Public Sub _InitFromMaster(ByVal poParameter As Object, ByVal peFormModel As SC_eFormModel, ByVal poButton As Object) Implements SC_IFormBase._InitFromMaster
        _Form_Model = peFormModel
        _ActionButton = poButton
        If _ActionButton IsNot Nothing Then
            _ButtonName = CType(_ActionButton, Button).Name
        End If
        RaiseEvent SC_Init_From_Master(poParameter)
    End Sub

    Private Sub _ReturnFromDetail(ByVal poOwnedForm As System.Windows.Forms.Form, ByVal pcButtonName As String) Implements SC_IFormBase._ReturnFromDetail
        RaiseEvent SC_Return_From_Detail(poOwnedForm, pcButtonName)
    End Sub
    Public Sub SC_DisplayException(ByVal poException As SC_Exception)
        If poException.Haserror Then
            Try
                Dim form As Form = New SC_ErrorForm
                form.Show()
                form.Owner = Me
                DirectCast(form, SC_IFormBase)._InitFromMaster(poException.GetErrorList, SC_eFormModel.Detail, Nothing)
                Me.Enabled = False
            Catch exception1 As Exception
                ProjectData.SetProjectError(exception1)
                Dim exception As Exception = exception1
                ProjectData.ClearProjectError()
            End Try
        End If
    End Sub


    Private Sub SC_FormBase_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If Me.Owner IsNot Nothing Then
            Me.Owner.Enabled = True
        End If
        If _Form_Model = SC_eFormModel.Detail AndAlso TypeOf (Me.Owner) Is SC_FormBase Then
            CType(Me.Owner, SC_IFormBase)._ReturnFromDetail(Me, _ButtonName)
        End If
    End Sub


    Private Function getActionButton() As Object Implements SC_IFormBase.getActionButton
        Return _ActionButton
    End Function

    Private Function getFormModel() As SC_eFormModel Implements SC_IFormBase.getFormModel
        Return _Form_Model
    End Function

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.StartPosition = FormStartPosition.CenterScreen
    End Sub
End Class

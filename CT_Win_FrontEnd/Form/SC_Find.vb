Imports System.ComponentModel

Public Class SC_Find
    Inherits SC_Button
    Implements SC_ILookUpAndFindButton


#Region "EVENT"
    Public Event SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) 'Untuk memberikan Initialisasi Form saat dipanggil
    Public Event SC_After_Open_Form(ByVal poOwnedForm As Form) 'Untuk melakukan sesuatu kalau Form Detail akan ditutup
    Public Event SC_Return_Find(ByVal poReturnObject As Object)
#End Region

#Region " PROPERTY Local "
    <DefaultValue("Find")> _
    Public Overrides Property Text() As String
        Get
            Return "Find"
        End Get
        Set(ByVal value As String)
        End Set
    End Property
#End Region

#Region "METHOD"
    Private Sub _ReturnLookUpAndFind(ByVal poReturnObject As Object) Implements SC_ILookUpAndFindButton._ReturnLookUpAndFind
        Me.FindForm.Enabled = True
        RaiseEvent SC_Return_Find(poReturnObject)
    End Sub
#End Region

    Private Sub SC_Find_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        Dim loTargetForm As SC_FormBase = Nothing
        Dim loParameter As Object = Nothing

        RaiseEvent SC_Before_Open_Form(loTargetForm, loParameter)
        If loTargetForm IsNot Nothing Then
            loTargetForm.Show()
            loTargetForm.Owner = Me.FindForm
            loTargetForm.StartPosition = FormStartPosition.CenterScreen
            CType(loTargetForm, SC_IFormBase)._InitFromMaster(loParameter, SC_eFormModel.Find, Me)
            Me.FindForm.Enabled = False
        End If
    End Sub


End Class

Imports System.ComponentModel

Public Class SC_LookUp
    Inherits SC_Button
    Implements SC_ILookUpAndFindButton

#Region "EVENT"
    Public Event SC_Before_Open_Form(ByRef poTargetForm As SC_FormBase, ByRef poParameter As Object) 'Untuk memberikan Initialisasi Form saat dipanggil
    Public Event SC_After_Open_Form(ByVal poOwnedForm As Form) 'Untuk melakukan sesuatu kalau Form Detail akan ditutup
    Public Event SC_Return_LookUp(ByVal poReturnObject As Object)
#End Region

#Region " PROPERTY Local "
    <DefaultValue("...")> _
    Public Overrides Property Text() As String
        Get
            Return "..."
        End Get
        Set(ByVal value As String)
        End Set
    End Property
#End Region

#Region " PROPERTY"
    Private _ObjectValue As TextBox = Nothing
    Private _ObjectDescription As TextBox = Nothing
    Private _FieldValue As String = ""
    Private _FieldDescription As String = ""

    <Category("SIMARC_LookUp")> _
    Public Property SC_TextBox_Value() As TextBox
        Get
            Return _ObjectValue
        End Get
        Set(ByVal value As TextBox)
            _ObjectValue = value
        End Set
    End Property

    <Category("SIMARC_LookUp")> _
    Public Property SC_TextBox_Description() As TextBox
        Get
            Return _ObjectDescription
        End Get
        Set(ByVal value As TextBox)
            _ObjectDescription = value
        End Set
    End Property

    <Category("SIMARC_LookUp")> _
    Public Property SC_Field_Value() As String
        Get
            Return _FieldValue
        End Get
        Set(ByVal value As String)
            _FieldValue = value
        End Set
    End Property

    <Category("SIMARC_LookUp")> _
    Public Property SC_Field_Description() As String
        Get
            Return _FieldDescription
        End Get
        Set(ByVal value As String)
            _FieldDescription = value
        End Set
    End Property
#End Region

#Region "METHOD"
    Private Sub _ReturnLookUpAndFind(ByVal poReturnObject As Object) Implements SC_ILookUpAndFindButton._ReturnLookUpAndFind
        Dim lcRtn As String
        Dim llOrgReadOnly As Boolean

        FindForm.Enabled = True

        If _ObjectValue IsNot Nothing AndAlso _FieldValue <> "" Then
            lcRtn = getPropertyValueFromObject(poReturnObject, _FieldValue)
            If lcRtn Is Nothing Then
                MsgBox("field " + _FieldValue + " not found")
            Else
                _ObjectValue.Focus()
                _ObjectValue.Text = lcRtn
            End If
        End If
        If _ObjectDescription IsNot Nothing AndAlso _FieldDescription <> "" Then
            lcRtn = getPropertyValueFromObject(poReturnObject, _FieldDescription)
            If lcRtn Is Nothing Then
                MsgBox("field " + _FieldDescription + " not found")
            Else
                _ObjectDescription.ReadOnly = False
                _ObjectDescription.Focus()
                _ObjectDescription.Text = lcRtn
                _ObjectDescription.ReadOnly = True
            End If
        End If

        RaiseEvent SC_Return_LookUp(poReturnObject)


    End Sub
#End Region

#Region "HELPER"
    Private Function getPropertyValueFromObject(ByVal poObject As Object, ByVal pcProperty As String) As Object
        Dim loRtn As Object = Nothing
        Dim loPropInfos As System.Reflection.PropertyInfo()
        Dim lotype As Type

        lotype = poObject.GetType()
        loPropInfos = lotype.GetProperties()

        For Each loInfo As System.Reflection.PropertyInfo In loPropInfos
            If loInfo.Name.Trim.ToLower = pcProperty.Trim.ToLower Then
                loRtn = loInfo.GetValue(poObject, Nothing)
                Exit For
            End If
        Next

        Return loRtn
    End Function

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

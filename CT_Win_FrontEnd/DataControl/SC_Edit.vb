Imports System.ComponentModel

Public Class SC_Edit
    Inherits SC_UpdSavBase

#Region " PROPERTY Local "
    Private _Text As String = "Edit"
    <DefaultValue("Edit")> _
    Public Overrides Property Text() As String
        Get
            Return _Text
        End Get
        Set(ByVal value As String)
            _Text = value
        End Set
    End Property
#End Region

#Region " METHOD "
    Public Sub NotifyStatus(ByVal poRole As Object, ByVal status As String, ByVal HasData As Boolean)
        If poRole.Edit_Permit = False Then
            Me.Enabled = False
            Exit Sub
        End If

        Select Case LCase(status)
            Case "init"
                Me.Enabled = False
            Case "add"
                Me.Enabled = False
            Case "edit"
                Me.Enabled = False
            Case "normal"
                Me.Enabled = HasData
            Case "save"
                Me.Enabled = HasData
            Case "cancel"
                Me.Enabled = HasData
            Case "remove"
                Me.Enabled = HasData
        End Select
    End Sub


#End Region

#Region " EVENT "
    Private Sub cmd_ADD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If _Conductor IsNot Nothing Then
            _Conductor._EDIT()
        Else
            MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
#End Region

End Class

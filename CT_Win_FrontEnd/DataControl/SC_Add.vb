Imports System.ComponentModel

Public Class SC_Add
    Inherits SC_UpdSavBase

#Region " PROPERTY Local "
    Private _Text As String = "Add New"
    <DefaultValue("Add New")> _
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
        If poRole.Add_Permit = False Then
            Me.Enabled = False
            Exit Sub
        End If

        Select Case LCase(status)
            Case "init"
                Me.Enabled = True
            Case "add"
                Me.Enabled = False
            Case "edit"
                Me.Enabled = False
            Case "normal"
                Me.Enabled = True
            Case "save"
                Me.Enabled = True
            Case "cancel"
                Me.Enabled = True
            Case "remove"
                Me.Enabled = True
        End Select
    End Sub
#End Region

#Region " EVENT "
    Private Sub cmd_ADD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If _Conductor IsNot Nothing Then
            _Conductor._ADD()
        Else
            MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
#End Region

End Class

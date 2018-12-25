Imports System.ComponentModel

Public Class SC_Save
    Inherits SC_UpdSavBase

#Region " PROPERTY Local "
    Private _Text As String = "Save"
    <DefaultValue("Save")> _
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
        Select Case LCase(status)
            Case "init"
                Me.Enabled = False
            Case "add"
                Me.Enabled = True
            Case "edit"
                Me.Enabled = True
            Case "normal"
                Me.Enabled = False
            Case "save"
                Me.Enabled = False
            Case "cancel"
                Me.Enabled = False
            Case "remove"
                Me.Enabled = False

        End Select
    End Sub


#End Region

#Region " EVENT "
    Private Sub cmd_ADD_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Click
        If _Conductor IsNot Nothing Then
            _Conductor._SAVE()
        Else
            MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
        End If
    End Sub
#End Region

End Class

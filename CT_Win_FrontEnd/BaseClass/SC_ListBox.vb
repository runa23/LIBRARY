Imports System.ComponentModel

<ToolboxBitmap(GetType(ListBox))> _
Public Class SC_ListBox
    Inherits System.Windows.Forms.ListBox

#Region "  VARIABLEs  "
    Public _Conductor As SC_Conductor
    Private _ADD As Boolean = False
    Private _EDIT As Boolean = False
    Private _OTHER As Boolean = False
    Private _HASDATA As Boolean = False
    Private _FIND As Boolean = False
#End Region

#Region " PROPERTY Conductor Source  "
    <Category("SIMARC_Source")> _
    Public Property SC_ConductorSource() As SC_Conductor
        Get
            Return _Conductor
        End Get
        Set(ByVal value As SC_Conductor)
            _Conductor = value
        End Set
    End Property

#End Region

#Region "  PROPERTY ENABLE  "
    'Property Enable ADD
    <DefaultValue(False)> _
    <Category("SIMARC_Enable")> _
    Public Property SC_EnableADD() As Boolean
        Get
            Return _ADD
        End Get
        Set(ByVal Value As Boolean)
            If (Not (_Conductor Is Nothing)) Then
                If Not Me.SC_EnableOTHER Then
                    _ADD = Value
                    If _ADD Then
                        _Conductor.CollectADD(Me)
                    End If
                Else
                    MsgBox("You cannot set EnableADD Value as [TRUE] if you already set EnableOTHER property", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
            End If
        End Set
    End Property

    ' Property Enable EDIT
    <DefaultValue(False)> _
    <Category("SIMARC_Enable")> _
    Public Property SC_EnableEDIT() As Boolean
        Get
            Return _EDIT
        End Get
        Set(ByVal Value As Boolean)
            If (Not (_Conductor Is Nothing)) Then
                If Not Me.SC_EnableOTHER Then
                    _EDIT = Value
                    If _EDIT Then
                        _Conductor.CollectEDIT(Me)
                    End If
                Else
                    MsgBox("You cannot set EnableEDIT Value as [TRUE] if you already set EnableOTHER property", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
            End If
        End Set
    End Property

    ' Property Enable OTHER
    <DefaultValue(False)> _
    <Category("SIMARC_Enable")> _
    Public Property SC_EnableOTHER() As Boolean
        Get
            Return _OTHER
        End Get
        Set(ByVal Value As Boolean)
            If (Not (_Conductor Is Nothing)) Then
                'if true add collection 
                If Not Me.SC_EnableADD And Not Me.SC_EnableEDIT Then
                    _OTHER = Value
                    If _OTHER Then
                        _Conductor.CollectOTHER(Me)
                    End If
                Else
                    MsgBox("You cannot set EnableOTHER Value as [TRUE] if you already set EnableADD or EnableEDIT", MsgBoxStyle.Exclamation, "Warning")
                End If
            Else
                MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
            End If
        End Set
    End Property

    <DefaultValue(False)> _
    <Category("SIMARC_Enable")> _
    Public Property SC_EnableHASDATA() As Boolean
        Get
            Return _HASDATA
        End Get
        Set(ByVal Value As Boolean)
            If (Not (_Conductor Is Nothing)) Then
                _HASDATA = Value
                If _HASDATA Then
                    _Conductor.CollectHASDATA(Me)
                End If
            Else
                MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
            End If
        End Set
    End Property

    <DefaultValue(False)> _
<Category("SIMARC_Enable")> _
    Public Property SC_EnableFIND() As Boolean
        Get
            Return _FIND
        End Get
        Set(ByVal Value As Boolean)
            If (Not (_Conductor Is Nothing)) Then
                _FIND = Value
                If _FIND Then
                    _Conductor.CollectFIND(Me)
                End If
            Else
                MsgBox("Conductor Source Can't Empty", MsgBoxStyle.Exclamation, "Warning")
            End If
        End Set
    End Property

#End Region
End Class

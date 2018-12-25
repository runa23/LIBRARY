Imports System.ComponentModel

<ToolboxBitmap(GetType(Button))> _
Public MustInherit Class SC_UpdSavBase
    Inherits System.Windows.Forms.Button

#Region "  VARIABLEs  "
    Protected _Conductor As SC_Conductor
#End Region

#Region " PROPERTY Conductor Source  "
    <Category("SIMARC_Source")> _
    Public Property SC_ConductorSource() As SC_Conductor
        Get
            Return _Conductor
        End Get
        Set(ByVal value As SC_Conductor)
            _Conductor = value
            If _Conductor IsNot Nothing Then
                _Conductor.CollectUPDSAV(Me)
            End If
        End Set
    End Property

#End Region

End Class

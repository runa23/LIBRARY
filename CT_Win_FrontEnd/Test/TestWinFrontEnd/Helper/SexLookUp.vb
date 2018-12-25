Public Class SexLookUp
    Private _SexId As String
    Private _SexDesc As String

    Public Sub New(ByVal pcId As String, ByVal pcDescription As String)
        _SexId = pcId
        _SexDesc = pcDescription
    End Sub

    Public Property ID() As String
        Get
            Return _SexId
        End Get
        Set(ByVal value As String)
            _SexId = value
        End Set
    End Property
    Public Property Description() As String
        Get
            Return _SexDesc
        End Get
        Set(ByVal value As String)
            _SexDesc = value
        End Set
    End Property
End Class

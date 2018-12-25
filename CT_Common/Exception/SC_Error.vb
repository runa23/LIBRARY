<Serializable()> _
Public Class SC_Error

#Region "Variable"
    Private lcErrNo As String
    Private lcErrDescp As String
    Private loErrorDetails As List(Of SC_ErrorDetail)
    Private llHasErrorDetail As Boolean
#End Region

#Region "Property"
    Public ReadOnly Property Key() As String
        Get
            Return lcErrNo + lcErrDescp
        End Get
    End Property
    Public ReadOnly Property ErrNo() As String
        Get
            Return lcErrNo
        End Get
    End Property
    Public ReadOnly Property ErrDescp() As String
        Get
            Return lcErrDescp
        End Get
    End Property
    Public ReadOnly Property ErrorDetails() As List(Of SC_ErrorDetail)
        Get
            Return loErrorDetails
        End Get
    End Property
    Public ReadOnly Property HasErrorDetail() As Boolean
        Get
            Return (loErrorDetails.Count > 0)
        End Get
    End Property
#End Region

#Region "Constructor"
    Public Sub New(ByVal pcErrNo As String, ByVal pcErrDescp As String)
        Me.New(pcErrNo, pcErrDescp, Nothing)
    End Sub
    Public Sub New(ByVal pcErrNo As String, ByVal pcErrDescp As String, ByVal poErrorDetails As List(Of SC_ErrorDetail))
        MyBase.new()
        lcErrNo = pcErrNo
        lcErrDescp = pcErrDescp
        If (poErrorDetails Is Nothing) Then
            Me.loErrorDetails = New List(Of SC_ErrorDetail)()
        Else
            Me.loErrorDetails = poErrorDetails
        End If

    End Sub
#End Region


End Class

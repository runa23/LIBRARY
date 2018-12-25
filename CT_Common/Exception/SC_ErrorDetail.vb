<Serializable()> _
Public Class SC_ErrorDetail
#Region "Variable"
    Private lcErrNo As String
    Private lcErrDescp As String
#End Region 'End Variable

#Region "Properties"
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
#End Region

#Region "Method"
    Public Sub New(ByVal pcErrNo As String, ByVal pcErrDescp As String)
        MyBase.new()
        lcErrNo = pcErrNo
        lcErrDescp = pcErrDescp
    End Sub

#End Region 'End Method

End Class
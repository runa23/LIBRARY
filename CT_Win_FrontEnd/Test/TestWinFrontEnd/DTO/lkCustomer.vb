Public Class lkCustomer
    Private _CustomerID As String
    Private _FirstName As String
    Private _sex As String

    Public Sub New()
        MyBase.New()
    End Sub
    Public Sub New(ByVal pcCustomerId As String, ByVal pcFirstName As String, ByVal pcSex As String)
        _CustomerID = pcCustomerId
        _FirstName = pcFirstName
        _sex = pcSex
    End Sub

    Public Property CustomerId() As String
        Get
            Return _CustomerID
        End Get
        Set(ByVal value As String)
            _CustomerID = value
        End Set
    End Property

    Public Property FirstName() As String
        Get
            Return _FirstName
        End Get
        Set(ByVal value As String)
            _FirstName = value
        End Set
    End Property

    Public Property Sex() As String
        Get
            Return _sex
        End Get
        Set(ByVal value As String)
            _sex = value
        End Set
    End Property

   
End Class

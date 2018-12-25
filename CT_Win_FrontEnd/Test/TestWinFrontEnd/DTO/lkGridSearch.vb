Public Class lkGridSearch
    Private _Firstname As String
    Private _DateSample As Nullable(Of DateTime)
    Private _NumberSample As Integer
    Private _DecimalSample As Decimal

    Public Sub New()

    End Sub

    Public Sub New(ByVal pcFirstName As String, ByVal pdDateSample As DateTime, ByVal pnNumberSample As Integer, ByVal pnDecimal As Decimal)
        _Firstname = pcFirstName
        _DateSample = pdDateSample
        _NumberSample = pnNumberSample
        _DecimalSample = pnDecimal
    End Sub

    Public Property FirstName() As String
        Get
            Return _Firstname
        End Get
        Set(ByVal value As String)
            _Firstname = value
        End Set
    End Property

    Public Property DateSample() As Nullable(Of DateTime)
        Get
            Return _DateSample
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            _DateSample = value
        End Set
    End Property

    Public Property NumberSample() As Integer
        Get
            Return _NumberSample
        End Get
        Set(ByVal value As Integer)
            _NumberSample = value
        End Set
    End Property

    Public Property DecimalSample() As Decimal
        Get
            Return _DecimalSample
        End Get
        Set(ByVal value As Decimal)
            _DecimalSample = value
        End Set
    End Property
End Class

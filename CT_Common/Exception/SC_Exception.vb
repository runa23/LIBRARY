Imports System.Runtime.Serialization
Imports System.ServiceModel
<Serializable()> _
Public Class SC_Exception
    Inherits Exception
#Region "Variable"
    Private loErrors As List(Of SC_Error)
#End Region

#Region "Properties"
    Public ReadOnly Property Haserror() As Boolean
        Get
            Return (loErrors.Count > 0)
        End Get
    End Property
#End Region

#Region "Method"
    Public Sub New()
        MyBase.New()
        loErrors = New List(Of SC_Error)()
    End Sub

    Public Sub New(ByVal poErrors As List(Of SC_Error))
        Me.New()
        If poErrors IsNot Nothing Then
            loErrors = poErrors
        Else
            loErrors = New List(Of SC_Error)()
        End If
    End Sub
    Public ReadOnly Property ErrorList() As List(Of SC_Error)
        Get
            Return loErrors
        End Get
    End Property

    Public Function GetErrorList() As List(Of SC_Error)
        Return loErrors
    End Function


#Region "Add"
    Public Sub Add(ByVal poError As SC_Error)
        loErrors.Add(poError)
    End Sub

    Public Sub Add(ByVal pcErrNo As String, ByVal pcErrDescp As String)
        loErrors.Add(New SC_Error(pcErrNo, pcErrDescp))
    End Sub
    Public Sub Add(ByVal pcErrNo As String, ByVal pcErrDescp As String, ByVal poErrorDetails As List(Of SC_ErrorDetail))
        loErrors.Add(New SC_Error(pcErrNo, pcErrDescp, poErrorDetails))
    End Sub
    Public Sub Add(ByVal pcErrNo As String, ByVal pcErrDescp As String, ByVal pcErrDtNo As String, ByVal pcErrDtDescp As String)
        Dim SCError As SC_Error = New SC_Error(pcErrNo, pcErrDescp)
        SCError.ErrorDetails.Add(New SC_ErrorDetail(pcErrDtNo, pcErrDtDescp))
        Me.Add(SCError)
    End Sub
    Public Sub Add(ByVal poException As Exception)
        Dim number As Integer
        If (TypeOf poException Is SC_Exception) Then
            Me.loErrors.AddRange(DirectCast(poException, SC_Exception).GetErrorList())
        ElseIf (poException IsNot Nothing) Then
            If (poException.TargetSite IsNot Nothing) Then
                number = Information.Err().Number
                Me.Add(number.ToString(), poException.Message, "01", String.Concat("function ", poException.TargetSite.Name, " on object ", poException.TargetSite.DeclaringType.FullName))
            Else
                number = Information.Err().Number
                Me.Add(number.ToString(), poException.Message)
            End If
        End If
    End Sub

#End Region 'End Add

    Public Sub ThrowExceptionIfErrors()
        If loErrors.Count > 0 Then
            Throw Me
        End If
    End Sub

    Public Sub ConvertAndThrowToServiceExceptionIfErrors()
        If (Me.loErrors.Count > 0) Then
            Dim SCServiceException As SC_ServiceExceptions = New SC_ServiceExceptions()
            SCServiceException.Add(Me)
            Throw New FaultException(Of SC_ServiceExceptions)(SCServiceException, "")
        End If
    End Sub

#End Region


End Class

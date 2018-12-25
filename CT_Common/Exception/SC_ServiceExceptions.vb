Imports Microsoft.VisualBasic
Imports Microsoft.VisualBasic.CompilerServices
Imports System
Imports System.Collections.Generic
Imports System.Runtime.Serialization
<DataContract(Name:="SC_ServiceExceptions")> _
Public Class SC_ServiceExceptions
    <DataMember(Name:="Exceptions")> _
    Public Exceptions As List(Of SC_Error)

    Public Sub New()
        MyBase.New()
        Exceptions = New List(Of SC_Error)()
    End Sub

    Public Sub Add(ByVal pcErrNo As String, ByVal pcErrDescp As String)
        Exceptions.Add(New SC_Error(pcErrNo, pcErrDescp))
    End Sub

    Public Sub add(ByVal poException As Exception)
        If (TypeOf poException Is SC_Exception) Then
            Me.Exceptions.AddRange(DirectCast(poException, SC_Exception).GetErrorList())
        ElseIf (poException IsNot Nothing) Then
            Dim number As Integer = Information.Err().Number
            Me.Add(number.ToString(), poException.Message)
        End If
    End Sub
End Class

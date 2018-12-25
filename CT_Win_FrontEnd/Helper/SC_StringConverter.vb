Public Class SC_StringConverter
    Public Shared Function StringToTypedValue(ByVal pcString As String, ByVal poType As Type) As Object
        Dim loRtn As Object = Nothing

        Try
            Select Case poType.Name
                Case GetType(String).Name
                    loRtn = pcString
                Case GetType(Int16).Name
                    loRtn = Int16.Parse(pcString)
                Case GetType(Int32).Name
                    loRtn = Int32.Parse(pcString)
                Case GetType(Int64).Name
                    loRtn = Int64.Parse(pcString)
                Case GetType(Decimal).Name
                    loRtn = Decimal.Parse(pcString)
                Case GetType(Byte).Name
                    loRtn = Byte.Parse(pcString)
                Case GetType(Single).Name
                    loRtn = Single.Parse(pcString)
                Case GetType(Double).Name
                    loRtn = Double.Parse(pcString)
                Case GetType(Date).Name
                    loRtn = Date.Parse(pcString)
                Case GetType(DateTime).Name
                    loRtn = DateTime.Parse(pcString)
                Case GetType(Boolean).Name
                    loRtn = Boolean.Parse(pcString)
            End Select
        Catch ex As Exception
            loRtn = Nothing
        End Try

        Return loRtn
    End Function

End Class

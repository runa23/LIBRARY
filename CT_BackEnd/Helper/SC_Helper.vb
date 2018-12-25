Imports SC_Common
Imports System.Data.Common

Public Class SC_Helper

    Public Function CT_GenerateKey(ByVal pcPrefix As String, ByVal pnPad As Integer, ByVal poConn As DbConnection) As String
        Dim loException As New SC_Exception
        Dim loDb As New SC_Db
        Dim lcCmd As String
        Dim lnCounter As Integer
        Dim loDataTable As DataTable
        Dim lcReturn As String

        Try


            lcCmd = "select counter from SYS_KEYCOUNTER (nolock) where prefix='" + pcPrefix.Trim + "'"
            loDataTable = loDb.SqlExecQuery(lcCmd, poConn, False)
            If loDataTable.Rows.Count > 0 Then
                lnCounter = loDataTable.Rows(0)("counter")
                lnCounter = lnCounter + 1
                lcCmd = "update SYS_KEYCOUNTER set counter=counter+1 where prefix='" + pcPrefix.Trim + "'"
            Else
                lnCounter = 1
                lcCmd = "insert SYS_KEYCOUNTER ("
                lcCmd = lcCmd + "prefix,counter"
                lcCmd = lcCmd + ")values("
                lcCmd = lcCmd + "'" + pcPrefix.Trim + "',1"
                lcCmd = lcCmd + ")"
            End If


            loDb.SqlExecNonQuery(lcCmd, poConn, True)


            lcReturn = pcPrefix.Trim + lnCounter.ToString.PadLeft(pnPad, "0")
            Return lcReturn
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()

    End Function

End Class

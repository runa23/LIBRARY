Imports R_BackEnd
Imports R_Common
Imports System.Data.Common
Public Class T_R_Db
    Private loDbConnection As DbConnection

    Private Sub btnGetConnectionString_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenConnection.Click
        Dim loException As New CT_Exception()
        Dim loDb As New CT_Db()
        Me.txtError.Text = ""
        Try
            loDbConnection = loDb.GetConnection()
            loDbConnection.Open()
        Catch ex As Exception
            loException.Add(ex)
        End Try
        If loException.Haserror Then
            For Each loError As CT_Error In loException.GetErrorList
                Me.txtError.Text = Me.txtError.Text + " " + loError.ErrDescp
            Next
        End If

    End Sub

    Private Sub btnCloseConnection_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCloseConnection.Click
        Dim loException As New CT_Exception()
        Me.txtError.Text = ""
        Try
            If loDbConnection IsNot Nothing Then
                loDbConnection.Close()
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        If loException.Haserror Then
            For Each loError As CT_Error In loException.GetErrorList
                Me.txtError.Text = Me.txtError.Text + " " + loError.ErrDescp
            Next
        End If
    End Sub

    Private Sub btngetErrorTable_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetErrorTable.Click
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loTable As DataTable
        Dim loException As New CT_Exception()

        Me.txtError.Text = ""
        lstResult.Items.Clear()
        Try
            lcCmd = "Select errno,errdescp from ssmerr where ErrNo like '00%'"
            loTable = loDb.SqlExecQuery(lcCmd)
            For Each loRow As DataRow In loTable.Rows
                Me.lstResult.Items.Add(CStr(loRow.Item("errno")).Trim + "-" + CStr(loRow.Item("errdescp")).Trim)
            Next
        Catch ex As Exception
            loException.Add(ex)
        End Try
        If loException.Haserror Then
            For Each loError As CT_Error In loException.GetErrorList
                Me.txtError.Text = Me.txtError.Text + " " + loError.ErrDescp
            Next
        End If
    End Sub

    Private Sub btnGetErrorDb_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetErrorDb.Click
        Dim loDb As New CT_Db()
        Dim loError As CT_Error

        'loError = loDb.GetErrorDb(1, "ALLOCVALID_01")
        loError = loDb.GetErrorDb(1000, "xxxx")
        lstResult.Items.Clear()
        Me.lstResult.Items.Add(loError.ErrNo + "-" + loError.ErrDescp)
        For Each loErrorDt As CT_ErrorDetail In loError.ErrorDetails
            Me.lstResult.Items.Add(loErrorDt.ErrNo + "-" + loErrorDt.ErrDescp)
        Next


    End Sub

    Private Sub btnExecStoreProc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExecStoreProc.Click
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loRtn As List(Of dtoEmployee)


        Try
            lcCmd = "exec getemployee {0}, {1}"
            loRtn = loDb.SQLExecObjectQuery(Of dtoEmployee)(lcCmd, loDb.GetConnection(), True, 3, 7)

            For Each loObject As dtoEmployee In loRtn
                lstResult.Items.Add(loObject.EmployeeID.ToString + "-" + loObject.Firstname)
            Next

        Catch ex As Exception

        End Try

    End Sub
End Class

Public Class dtoEmployee
    Public EmployeeID As Integer
    Public Firstname As String
    Public LastName As String
End Class
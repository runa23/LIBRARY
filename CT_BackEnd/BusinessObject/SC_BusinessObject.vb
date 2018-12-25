Imports SC_Common
Imports System.Transactions
Imports Microsoft.VisualBasic.CompilerServices
Imports SC_BackEnd.My

Public MustInherit Class SC_BusinessObject(Of E As SC_DTOBase)


#Region "Method"
    Public Function SC_GetRecord(ByVal poEntity As E, ByVal poCRUDMode As eCRUDMode) As E
        Dim e As E = Nothing
        Dim SCException As SC_Exception = New SC_Exception()
        Try
            e = Me.SC_Display(poEntity, poCRUDMode, False)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        Return e
    End Function

    Public Function SC_Save(ByVal poEntity As E, ByVal poCRUDMode As eCRUDMode) As E
        Dim e As E
        Dim e1 As E = Nothing
        Dim SCException As SC_Exception = New SC_Exception()
        Try
            Using transactionScope As System.Transactions.TransactionScope = New System.Transactions.TransactionScope(TransactionScopeOption.Required)
                e1 = Nothing
                If (poCRUDMode = eCRUDMode.EditMode) Then
                    e1 = Me.SC_Display(poEntity, poCRUDMode, True)
                    If (e1 Is Nothing) Then
                        SCException.Add("001", "Data not found at database", "001", "CT_Display with Locking not found")
                        SCException.ThrowExceptionIfErrors()
                        e = e1
                        Return e
                    End If
                End If
                Me.SC_Saving(poEntity, e1, poCRUDMode)
                e1 = Me.SC_Display(poEntity, poCRUDMode, False)
                transactionScope.Complete()
            End Using
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        e = e1
        Return e
    End Function

    Public Sub SC_Delete(ByVal poEntity As E)
        Dim SCException As SC_Exception = New SC_Exception()
        Try
            Using transactionScope As System.Transactions.TransactionScope = New System.Transactions.TransactionScope(TransactionScopeOption.Required)
                Me.SC_Deleting(poEntity)
                transactionScope.Complete()
            End Using
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()

    End Sub

#End Region

#Region "Must Override Method"
    Protected MustOverride Function SC_Display(ByVal poEntity As E, ByVal poCRUDMode As eCRUDMode, ByVal plWithLock As Boolean) As E
    Protected MustOverride Sub SC_Saving(ByVal poNewEntity As E, ByVal poOldEntity As E, ByVal poCRUDMode As eCRUDMode)
    Protected MustOverride Sub SC_Deleting(ByVal poEntity As E)
#End Region
End Class

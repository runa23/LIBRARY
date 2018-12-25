Imports R_Common
Imports R_BackEnd
Imports System.Data.Common

Public Class EmployeeService
    Inherits R_BusinessObject(Of EmployeeDTO)

    Implements IEmployeeService

    Protected Overrides Sub R_Deleting(ByVal poEntity As EmployeeDTO)
        Dim loException As New CT_Exception()
        Dim loDb As New CT_Db()
        Dim lcCmd As String


        Try
            lcCmd = "delete Employees where EmployeeId=" + poEntity.EmployeeID.ToString
            loDb.SqlExecNonQuery(lcCmd)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Protected Overrides Function R_Display(ByVal poEntity As EmployeeDTO, ByVal poCRUDMode As R_BackEnd.eCRUDMode, ByVal plWithLock As Boolean) As EmployeeDTO
        Dim loException As New CT_Exception()
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loDto As EmployeeDTO = Nothing


        Try
            lcCmd = "select EmployeeId, FirstName, LastName from Employees"
            lcCmd = lcCmd + IIf(plWithLock, "(updlock) ", "(nolock ) ")
            lcCmd = lcCmd + "where EmployeeId ={0}"
            loDto = loDb.SQLExecObjectQuery(Of EmployeeDTO)(lcCmd, loDb.GetConnection, True, poEntity.EmployeeID).FirstOrDefault
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()

        Return loDto
    End Function

    Protected Overrides Sub R_Saving(ByVal poNewEntity As EmployeeDTO, ByVal poOldEntity As EmployeeDTO, ByVal poCRUDMode As R_BackEnd.eCRUDMode)
        Dim loException As New CT_Exception()
        Dim loDb As New CT_Db()
        Dim lcCmd As String

        Try
            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "select EmployeeId from employees(nolock) where Employeeid=" + poNewEntity.EmployeeID.ToString
                If loDb.SqlExecQuery(lcCmd).Rows.Count > 0 Then
                    'loException.Add("001", "Employee " + poNewEntity.EmployeeID.ToString + " already exists", "001", "coba dengan employee yang lain")
                    loException.Add(loDb.GetErrorDb(2, "ALLOCVALID_01", "", "Employee ID"))
                    Exit Try
                End If

                lcCmd = "insert into employees(EmployeeId,FirstName,LastName) values("
                lcCmd = lcCmd + poNewEntity.EmployeeID.ToString + ","
                lcCmd = lcCmd + "'" + poNewEntity.FirstName.Trim + "',"
                lcCmd = lcCmd + "'" + poNewEntity.LastName.Trim + "')"
            Else
                lcCmd = "update employees set "
                lcCmd = lcCmd + "FirstName='" + poNewEntity.FirstName.Trim + "',"
                lcCmd = lcCmd + "LastName='" + poNewEntity.LastName.Trim + "' "
                lcCmd = lcCmd + "Where EmployeeId=" + poNewEntity.EmployeeID.ToString
            End If
            loDb.SqlExecNonQuery(lcCmd)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()

    End Sub

    Public Sub Svc_R_Delete(ByVal poEntity As EmployeeDTO) Implements R_BackEnd.R_IServicebase(Of EmployeeDTO).Svc_R_Delete
        Dim loException As New CT_Exception()
        Try
            Me.R_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Sub

    Public Function Svc_R_GetRecord(ByVal poEntity As EmployeeDTO, ByVal poCRUDMode As R_BackEnd.eCRUDMode) As EmployeeDTO Implements R_BackEnd.R_IServicebase(Of EmployeeDTO).Svc_R_GetRecord
        Dim loException As New CT_Exception()
        Try
            Return Me.R_GetRecord(poEntity, poCRUDMode)
        Catch ex As CT_Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_R_Save(ByVal poEntity As EmployeeDTO, ByVal poCRUDMode As R_BackEnd.eCRUDMode) As EmployeeDTO Implements R_BackEnd.R_IServicebase(Of EmployeeDTO).Svc_R_Save
        Dim loException As New CT_Exception()
        Try
            Return Me.R_Save(poEntity, poCRUDMode)
        Catch ex As CT_Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

End Class

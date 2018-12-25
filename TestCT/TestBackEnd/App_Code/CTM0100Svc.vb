Imports CT_BackEnd
Imports CT_Common
Imports System.Collections.Generic
Imports System.ServiceModel
Imports System.Threading
Imports System.Data.Common

' NOTE: If you change the class name "CTM0100Svc" here, you must also update the reference to "CTM0100Svc" in Web.config and in the associated .svc file.
Public Class CTM0100Svc
    Inherits CT_BusinessObject(Of m_karyawan01DTO)
    Implements ICTM0100Svc

    Protected Overrides Function CT_Display(ByVal poEntity As m_karyawan01DTO, ByVal poCRUDMode As CT_BackEnd.eCRUDMode, ByVal plWithLock As Boolean) As m_karyawan01DTO
        Dim loException As New CT_Exception
        Dim loDb As New CT_Db
        Dim lcCmd As String
        Dim loDTO As m_karyawan01DTO

        Try
            lcCmd = "select a.*,b.warga_negara "
            lcCmd = lcCmd + "from m_karyawan a "
            lcCmd = lcCmd + IIf(plWithLock, "(updlock) ", "(nolock ) ")
            lcCmd = lcCmd + "left join m_warga_negara b (nolock) on a.warga_negara_id = b.warga_negara_id "
            lcCmd = lcCmd + "where nik ={0}"

            loDTO = loDb.SQLExecObjectQuery(Of m_karyawan01DTO)(lcCmd, loDb.GetConnection, True, poEntity.NIK).FirstOrDefault

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()

        Return loDTO

    End Function

    Protected Overrides Sub CT_Saving(ByVal poNewEntity As m_karyawan01DTO, ByVal poOldEntity As m_karyawan01DTO, ByVal poCRUDMode As CT_BackEnd.eCRUDMode)
        Dim loException As New CT_Exception()
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim loHelper As New CT_Helper
        Dim lcEmpNo As String
        Try
            loConn = loDb.GetConnection

            If poCRUDMode = eCRUDMode.AddMode Then
                lcCmd = "select nik from M_KARYAWAN(nolock) where nik='" + poNewEntity.NIK.Trim + "'"
                If loDb.SqlExecQuery(lcCmd, loConn, False).Rows.Count > 0 Then
                    loException.Add("001", "NIK " + poNewEntity.NIK + " sudah ada", "001", "coba dengan NIK yang lain")
                    Exit Try
                End If

                'Generete EmpNo
                lcEmpNo = Now.ToString("yy")


                poNewEntity.NIK = loHelper.CT_GenerateKey("NIK", 3, loConn)
                lcCmd = "insert into M_KARYAWAN ("
                lcCmd = lcCmd + "NIK,"
                lcCmd = lcCmd + "NAMA,"
                lcCmd = lcCmd + "JENIS_KELAMIN,"
                lcCmd = lcCmd + "JABATAN,"
                lcCmd = lcCmd + "TGL_LAHIR,"
                lcCmd = lcCmd + "JUM_ANAK,"
                lcCmd = lcCmd + "GAPOK,"
                lcCmd = lcCmd + "TUN_TRANSPORT,"
                lcCmd = lcCmd + "WARGA_NEGARA_ID,"
                lcCmd = lcCmd + "KODE_PENDIDIKAN,"
                lcCmd = lcCmd + "CREA_BY,"
                lcCmd = lcCmd + "CREA_DATE,"
                lcCmd = lcCmd + "UPD_BY,"
                lcCmd = lcCmd + "UPD_DATE "
                lcCmd = lcCmd + ")VALUES ("
                lcCmd = lcCmd + "'" + poNewEntity.NIK.Trim + "',"
                lcCmd = lcCmd + "'" + poNewEntity.NAMA.Trim + "',"
                lcCmd = lcCmd + "'" + poNewEntity.JENIS_KELAMIN.Trim + "',"
                lcCmd = lcCmd + "'" + poNewEntity.JABATAN.Trim + "',"
                lcCmd = lcCmd + "'" + poNewEntity.TGL_LAHIR.ToString("yyyyMMdd") + "',"
                lcCmd = lcCmd + "'" + poNewEntity.JUM_ANAK.ToString.Trim + "',"
                lcCmd = lcCmd + "" + poNewEntity.GAPOK.ToString + ","
                lcCmd = lcCmd + "" + poNewEntity.TUN_TRANSPORT.ToString + ","
                lcCmd = lcCmd + "'" + poNewEntity.WARGA_NEGARA_ID.Trim + " ',"
                lcCmd = lcCmd + "'" + poNewEntity.KODE_PENDIDIKAN.Trim + "',"
                lcCmd = lcCmd + "'" + poNewEntity.UPD_BY.Trim + "',"
                lcCmd = lcCmd + "getdate(),"
                lcCmd = lcCmd + "'" + poNewEntity.UPD_BY.Trim + "',"
                lcCmd = lcCmd + "getdate() "
                lcCmd = lcCmd + ")"
            Else
                lcCmd = "update M_KARYAWAN set "
                lcCmd = lcCmd + "NIK = '" + poNewEntity.NIK.Trim + "',"
                lcCmd = lcCmd + "NAMA = '" + poNewEntity.NAMA.Trim + "',"
                lcCmd = lcCmd + "JENIS_KELAMIN = '" + poNewEntity.JENIS_KELAMIN.Trim + "',"
                lcCmd = lcCmd + "JABATAN = '" + poNewEntity.JABATAN.Trim + "',"
                lcCmd = lcCmd + "TGL_LAHIR = '" + poNewEntity.TGL_LAHIR.ToString("yyyyMMdd") + "',"
                lcCmd = lcCmd + "JUM_ANAK = " + poNewEntity.JUM_ANAK.ToString.Trim + ","
                lcCmd = lcCmd + "GAPOK = " + poNewEntity.GAPOK.ToString + ","
                lcCmd = lcCmd + "TUN_TRANSPORT = " + poNewEntity.TUN_TRANSPORT.ToString + ","
                lcCmd = lcCmd + "WARGA_NEGARA_ID = '" + poNewEntity.WARGA_NEGARA_ID.Trim + "',"
                lcCmd = lcCmd + "KODE_PENDIDIKAN = '" + poNewEntity.KODE_PENDIDIKAN.Trim + "',"
                lcCmd = lcCmd + "UPD_BY = '" + poNewEntity.UPD_BY.Trim + "',"
                lcCmd = lcCmd + "UPD_DATE = getdate() "
                lcCmd = lcCmd + "Where NIK='" + poNewEntity.NIK + "'"
            End If
            loDb.SqlExecNonQuery(lcCmd, loConn, True)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Protected Overrides Sub CT_Deleting(ByVal poEntity As m_karyawan01DTO)
        Dim loException As New CT_Exception()
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loConn As DbConnection
        Dim lnTrans As Integer = 0
        Try
            loConn = loDb.GetConnection

            lcCmd = "DELETE M_KARYAWAN where NIK='" + poEntity.NIK + "'"
            loDb.SqlExecNonQuery(lcCmd)

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Public Function GetList() As System.Collections.Generic.List(Of m_karyawan02DTO) Implements ICTM0100Svc.GetList
        Dim loException As New CT_Exception
        Dim loDb As New CT_Db
        Dim lcCmd As String
        Dim loReturn As List(Of m_karyawan02DTO)

        Try

            lcCmd = "select * "
            lcCmd = lcCmd + "from M_KARYAWAN (nolock) "

            loReturn = loDb.SQLExecObjectQuery(Of m_karyawan02DTO)(lcCmd, loDb.GetConnection, True)

            Return loReturn

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

    End Function

    Public Sub Svc_CT_Delete(ByVal poEntity As m_karyawan01DTO) Implements CT_BackEnd.CT_IServicebase(Of m_karyawan01DTO).Svc_CT_Delete
        Dim loException As New CT_Exception

        Try
            Me.CT_Delete(poEntity)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Sub

    Public Function Svc_CT_GetRecord(ByVal poEntity As m_karyawan01DTO, ByVal poCRUDMode As CT_BackEnd.eCRUDMode) As m_karyawan01DTO Implements CT_BackEnd.CT_IServicebase(Of m_karyawan01DTO).Svc_CT_GetRecord
        Dim loException As New CT_Exception
        Try
            Return Me.CT_GetRecord(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function Svc_CT_Save(ByVal poEntity As m_karyawan01DTO, ByVal poCRUDMode As CT_BackEnd.eCRUDMode) As m_karyawan01DTO Implements CT_BackEnd.CT_IServicebase(Of m_karyawan01DTO).Svc_CT_Save
        Dim loException As New CT_Exception

        Try
            Return Me.CT_Save(poEntity, poCRUDMode)
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ConvertAndThrowToServiceExceptionIfErrors()
    End Function

    Public Function GetLKm_warga_negara(ByVal poEntity As LKm_warga_negaraDTO) As System.Collections.Generic.List(Of LKm_warga_negaraDTO) Implements ICTM0100Svc.GetLKm_warga_negara
        Dim loException As New CT_Exception
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loDto As New List(Of LKm_warga_negaraDTO)

        Try

            lcCmd = "select * from M_WARGA_NEGARA (nolock) "
            If poEntity IsNot Nothing Then
                lcCmd = lcCmd + "where WARGA_NEGARA_ID='" + poEntity.WARGA_NEGARA_ID + "'"
            End If
            lcCmd = lcCmd + " Order By 1"
            loDto = loDb.SQLExecObjectQuery(Of LKm_warga_negaraDTO)(lcCmd, loDb.GetConnection, True).ToList

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loDto
    End Function

    Public Function GetLKM_Jabatan() As System.Collections.Generic.List(Of LKm_jabatanDTO) Implements ICTM0100Svc.GetLKm_jabatan
        Dim loException As New CT_Exception
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loDto As New List(Of LKm_jabatanDTO)

        Try

            lcCmd = "select * from M_JABATAN (nolock) "
            lcCmd = lcCmd + " Order By 1"
            loDto = loDb.SQLExecObjectQuery(Of LKm_jabatanDTO)(lcCmd, loDb.GetConnection, True).ToList

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loDto
    End Function

    Public Function GetLKm_pendidikan() As System.Collections.Generic.List(Of LKm_pendidikanDTO) Implements ICTM0100Svc.GetLKm_pendidikan
        Dim loException As New CT_Exception
        Dim loDb As New CT_Db()
        Dim lcCmd As String
        Dim loDto As New List(Of LKm_pendidikanDTO)

        Try

            lcCmd = "select * from M_PENDIDIKAN (nolock) "
            lcCmd = lcCmd + " Order By 1"
            loDto = loDb.SQLExecObjectQuery(Of LKm_pendidikanDTO)(lcCmd, loDb.GetConnection, True).ToList

        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ConvertAndThrowToServiceExceptionIfErrors()

        Return loDto
    End Function


    Public Function GetRole() As list(Of RoleDTO) Implements ICTM0100Svc.GetRole
        Dim loRoleList As New List(Of RoleDTO)
        Dim loRole As New RoleDTO
        With loRole
            .App_Id = "001"
            .Add_Permit = False
            .Edit_Permit = True
            .Delete_Permit = True
            .Read_Permit = True
        End With
        loRoleList.Add(loRole)

        loRole = New RoleDTO
        With loRole
            .App_Id = "002"
            .Add_Permit = False
            .Edit_Permit = True
            .Delete_Permit = True
            .Read_Permit = True
        End With
        loRoleList.Add(loRole)

        Return loRoleList
    End Function
End Class
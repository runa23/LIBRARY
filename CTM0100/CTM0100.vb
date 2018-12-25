Imports CT_Win_FrontEnd
Imports CT_Common
Imports CTM0100.CTM0100SvcRef
Imports System.ServiceModel

Public Class CTM0100

    Private Sub CT_Conductor1_CT_Saving(ByRef poEntity As Object, ByVal peMode As CT_Win_FrontEnd.CT_Conductor.e_Mode) Handles CT_Conductor1.CT_Saving
        With CType(poEntity, m_karyawan01DTO)
            .UPD_BY = "YO"
        End With
    End Sub

    Private Sub CT_Conductor1_CT_ServiceGetRecord(ByVal poEntity As Object, ByRef poEntityResult As Object) Handles CT_Conductor1.CT_ServiceGetRecord
        Dim loKeyEntity As m_karyawan01DTO
        Dim loException As New CT_Exception()
        Dim loService As CTM0100SvcClient

        Try
            'Set key
            loKeyEntity = New m_karyawan01DTO
            With CType(poEntity, m_karyawan02DTO)
                loKeyEntity.NIK = .NIK
            End With

            'Invoke service
            loService = New CTM0100SvcClient
            poEntityResult = loService.Svc_CT_GetRecord(loKeyEntity, eCRUDMode.NormalMode)
            loService.Close()

        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            CT_DisplayException(loException)
        End If
    End Sub

    Private Sub CT_Conductor1_CT_BeforeAdd() Handles CT_Conductor1.CT_BeforeAdd
        NIKCT_TextBox.Focus()
    End Sub

    Private Sub CT_Conductor1_CT_BeforeEdit(ByVal poEntity As Object) Handles CT_Conductor1.CT_BeforeEdit
        NIKCT_TextBox.Focus()
    End Sub

    Private Sub CT_Conductor1_CT_Validation(ByVal poEntity As Object, ByVal peMode As CT_Win_FrontEnd.CT_Conductor.e_Mode) Handles CT_Conductor1.CT_Validation
        Dim loException As New CT_Exception

        Try
            If NIKCT_TextBox.Text = "" Then
                loException.Add("CTV", "NIK tidak boleh kosong")
            End If
            If WARGA_NEGARACT_TextBox.Text.Trim = "" Then
                loException.Add("CTV", "Kode warga negara tidak ditemukan")
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub CT_Conductor1_CT_ServiceSave(ByVal poEntity As Object, ByVal peMode As CT_Win_FrontEnd.CT_Conductor.e_Mode, ByRef poEntityResult As Object) Handles CT_Conductor1.CT_ServiceSave
        Dim loException As New CT_Exception()
        Dim loService As CTM0100SvcClient

        Try
            'Invoke service
            loService = New CTM0100SvcClient
            poEntityResult = loService.Svc_CT_Save(poEntity, IIf(peMode = CT_Win_FrontEnd.CT_Conductor.e_Mode.AddMode, eCRUDMode.AddMode, eCRUDMode.EditMode))
            loService.Close()

        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub CT_Conductor1_CT_ServiceDelete(ByVal poEntity As Object) Handles CT_Conductor1.CT_ServiceDelete
        Dim loException As New CT_Exception()
        Dim loService As CTM0100SvcClient

        Try

            loService = New CTM0100SvcClient
            loService.Svc_CT_Delete(poEntity)
            loService.Close()

        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        End Try

        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub CT_Conductor1_CT_ConvertParentGridEntity(ByVal poEntity As Object, ByRef poParentEntity As Object) Handles CT_Conductor1.CT_ConvertParentGridEntity
        Dim loEntity As m_karyawan01DTO = poEntity
        poParentEntity = New m_karyawan02DTO()

        With CType(poEntity, m_karyawan01DTO)
            poParentEntity.NIK = .NIK
            poParentEntity.NAMA = .NAMA
            poParentEntity.JENIS_KELAMIN = .JENIS_KELAMIN
            poParentEntity.JABATAN = .JABATAN
            poParentEntity.TGL_LAHIR = .TGL_LAHIR
            poParentEntity.JUM_ANAK = .JUM_ANAK
            poParentEntity.GAPOK = .GAPOK
            poParentEntity.TUN_TRANSPORT = .TUN_TRANSPORT
            poParentEntity.CREA_BY = .CREA_BY
            poParentEntity.CREA_DATE = .CREA_DATE
            poParentEntity.UPD_BY = .UPD_BY
            poParentEntity.UPD_DATE = .UPD_DATE
        End With
    End Sub

    Private Sub WARGA_NEGARA_IDCT_LookUp1_CT_Before_Open_Form(ByRef poTargetForm As CT_Win_FrontEnd.CT_FormBase, ByRef poParameter As Object) Handles WARGA_NEGARA_IDCT_LookUp1.CT_Before_Open_Form
        poTargetForm = New CTM0100LKM_Warga_Negara
        poParameter = New List(Of Object)
    End Sub

    Private Sub WARGA_NEGARA_IDCT_TextBox_Validated(ByVal sender As Object, ByVal e As System.EventArgs) Handles WARGA_NEGARA_IDCT_TextBox.Validated
        Dim loException As New CT_Exception
        Dim loLk As New CTM0100LKM_Warga_Negara
        Dim loEntity As New LKm_warga_negaraDTO
        Dim loReturn As LKm_warga_negaraDTO

        Try
            loEntity.WARGA_NEGARA_ID = WARGA_NEGARA_IDCT_TextBox.Text.Trim
            loReturn = loLk.GetLookUpDesc(loEntity)
            If loReturn IsNot Nothing Then
                WARGA_NEGARA_IDCT_LookUp1.CT_TextBox_Description.Text = loReturn.WARGA_NEGARA
            Else
                WARGA_NEGARA_IDCT_LookUp1.CT_TextBox_Description.Text = ""
            End If
            loLk.Close()
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            CT_DisplayException(loException)
        End If
    End Sub


    Private Sub CT_Conductor1_CT_ServiceRefreshList() Handles CT_Conductor1.CT_ServiceRefreshList
        Dim loException As New CT_Exception
        Dim loService As CTM0100SvcClient
        Dim loList As List(Of m_karyawan02DTO)
        Dim loLKm_jabatan As List(Of LKm_jabatanDTO)
        Dim loLKm_pendidikan As List(Of LKm_pendidikanDTO)

        Try

            loService = New CTM0100SvcClient

            loLKm_pendidikan = loService.GetLKm_pendidikan()
            LKmpendidikanDTOBindingSource.DataSource = New CT_BindingListView(Of LKm_pendidikanDTO)(loLKm_pendidikan)

            loLKm_jabatan = loService.GetLKm_jabatan()
            LKMJabatanDTOBindingSource.DataSource = New CT_BindingListView(Of LKm_jabatanDTO)(loLKm_jabatan)

            loList = loService.GetList()
            M_karyawan02DTOBindingSource.DataSource = New CT_BindingListView(Of m_karyawan02DTO)(loList)

            loService.Close()

        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            CT_DisplayException(loException)
        End If
    End Sub

    Private Sub CTM0100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim loException As New CT_Exception
        Dim loService As CTM0100SvcClient
        Dim loInitialize As New _Initiator()

        Try

            loService = New CTM0100SvcClient
            'loInitialize.Set_RoleAppList(loService.GetRole())
            CT_Conductor1.CT_SetRoleApp(CT_GlobalVar.RoleApp("001"))
            loService.Close()

        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            CT_DisplayException(loException)
        End If
    End Sub

End Class

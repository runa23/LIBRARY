Imports CT_Common
Imports CT_Win_FrontEnd
Imports CTM0100.CTM0100SvcRef
Imports System.ServiceModel

Public Class CTM0100LKM_Warga_Negara

    Private Sub CTM0100LKM_Warga_Negara_CT_Init_From_Master(ByVal poParameter As Object) Handles Me.CT_Init_From_Master
        Dim loException As New CT_Exception()
        Dim loClient As CTM0100SvcClient
        Dim loRtn As List(Of LKm_warga_negaraDTO)

        Try

            loClient = New CTM0100SvcClient()
            loRtn = loClient.GetLKm_warga_negara(Nothing)

            Me.LKm_warga_negaraDTOBindingSource.DataSource = New CT_BindingListView(Of LKm_warga_negaraDTO)(loRtn)
        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try

        If loException.Haserror Then
            Me.CT_DisplayException(loException)
        End If

        CT_GridSearch1.Focus()
    End Sub

    Public Function GetLookUpDesc(ByVal poEntity As LKm_warga_negaraDTO) As LKm_warga_negaraDTO
        Dim loException As New CT_Exception()
        Dim loClient As CTM0100SvcClient
        Dim loRtn As LKm_warga_negaraDTO

        Try

            loClient = New CTM0100SvcClient()
            loRtn = loClient.GetLKm_warga_negara(poEntity).FirstOrDefault
            loClient.Close()
            Return loRtn
        Catch ex As FaultException(Of CT_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        Catch ex As Exception
            loException.Add(ex)
        End Try
    End Function
End Class

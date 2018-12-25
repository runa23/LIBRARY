Imports R_Common
Imports System.ServiceModel
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization

Public Class Form1
    Private llAdd As Boolean = False
    Private loOldDto As Object

    Private Sub btnGetRecord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnGetRecord.Click
        Dim loException As New CT_Exception()
        Dim loDto As New EmployeeRef.EmployeeDTO()
        Dim loEmployeeService As EmployeeRef.EmployeeServiceClient

        Me.lstError.Items.Clear()

        Try
            loDto.EmployeeID = CInt(Me.txtEmployeeID.Text)

            loEmployeeService = New EmployeeRef.EmployeeServiceClient()
            loDto = loEmployeeService.Svc_R_GetRecord(loDto, EmployeeRef.eCRUDMode.NormalMode)

            If loDto Is Nothing Then
                Me.EmployeeDTOBindingSource.Clear()
            Else
                Me.EmployeeDTOBindingSource.DataSource = loDto
            End If

            llAdd = False
            loEmployeeService.Close()
            MsgBox("sukses")
        Catch ex As FaultException(Of R_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        End Try
        If loException.Haserror Then
            For Each loerror As CT_Error In loException.GetErrorList
                Me.lstError.Items.Add(loerror.ErrNo + "-" + loerror.ErrDescp)
                If loerror.ErrorDetails.Count > 0 Then
                    For Each loErrDt As CT_ErrorDetail In loerror.ErrorDetails
                        Me.lstError.Items.Add("   " + loErrDt.ErrNo + "-" + loErrDt.ErrDescp)
                    Next
                End If
            Next
        End If

    End Sub



    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click
        Dim loException As New CT_Exception()
        Dim loDto As New EmployeeRef.EmployeeDTO()
        Dim loEmployeeService As EmployeeRef.EmployeeServiceClient

        Me.lstError.Items.Clear()

        Try
            Me.EmployeeDTOBindingSource.EndEdit()
            loDto = Me.EmployeeDTOBindingSource.Current
            loEmployeeService = New EmployeeRef.EmployeeServiceClient()
            loDto = loEmployeeService.Svc_R_Save(loDto, IIf(llAdd, EmployeeRef.eCRUDMode.AddMode, EmployeeRef.eCRUDMode.EditMode))
            Me.EmployeeDTOBindingSource.DataSource = loDto
            loOldDto = Nothing

            llAdd = False
            loEmployeeService.Close()
            MsgBox("sukses")
        Catch ex As FaultException(Of R_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        End Try
        If loException.Haserror Then
            For Each loerror As CT_Error In loException.GetErrorList
                Me.lstError.Items.Add(loerror.ErrNo + "-" + loerror.ErrDescp)
                If loerror.ErrorDetails.Count > 0 Then
                    For Each loErrDt As CT_ErrorDetail In loerror.ErrorDetails
                        Me.lstError.Items.Add("   " + loErrDt.ErrNo + "-" + loErrDt.ErrDescp)
                    Next
                End If
            Next
        End If


    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        Dim loException As New CT_Exception()
        Dim loDto As New EmployeeRef.EmployeeDTO()
        Dim loEmployeeService As EmployeeRef.EmployeeServiceClient

        Me.lstError.Items.Clear()

        Try
            loDto = Me.EmployeeDTOBindingSource.Current

            loEmployeeService = New EmployeeRef.EmployeeServiceClient()
            loEmployeeService.Svc_R_Delete(loDto)

            Me.EmployeeDTOBindingSource.Clear()

            llAdd = False
            loEmployeeService.Close()
            MsgBox("sukses")
        Catch ex As FaultException(Of R_ServiceExceptions)
            loException.ErrorList.AddRange(ex.Detail.Exceptions)
        Catch ex As FaultException
            loException.Add(ex)
        End Try
        If loException.Haserror Then
            For Each loerror As CT_Error In loException.GetErrorList
                Me.lstError.Items.Add(loerror.ErrNo + "-" + loerror.ErrDescp)
                If loerror.ErrorDetails.Count > 0 Then
                    For Each loErrDt As CT_ErrorDetail In loerror.ErrorDetails
                        Me.lstError.Items.Add("   " + loErrDt.ErrNo + "-" + loErrDt.ErrDescp)
                    Next
                End If
            Next
        End If
    End Sub

    Private Sub btnCancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCancel.Click
        If loOldDto Is Nothing Then
            Me.EmployeeDTOBindingSource.Clear()
        Else
            Me.EmployeeDTOBindingSource.DataSource = loOldDto
        End If

    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click
        llAdd = True
        If Me.EmployeeDTOBindingSource.Count > 0 Then
            loOldDto = CloneObject(Me.EmployeeDTOBindingSource.Current)
        Else
            loOldDto = Nothing
        End If

        Me.EmployeeDTOBindingSource.AddNew()
    End Sub

    Private Sub btnEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEdit.Click
        If Me.EmployeeDTOBindingSource.Count > 0 Then
            loOldDto = CloneObject(Me.EmployeeDTOBindingSource.Current)
        Else
            loOldDto = Nothing
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.EmployeeDTOBindingSource.Clear()
    End Sub


    Private Function CloneObject(ByVal poObject As Object) As Object
        Using loMemStream As New MemoryStream()
            Dim loBinaryFormatter As New BinaryFormatter(Nothing, New StreamingContext(StreamingContextStates.Clone))
            loBinaryFormatter.Serialize(loMemStream, poObject)
            loMemStream.Seek(0, SeekOrigin.Begin)
            Return loBinaryFormatter.Deserialize(loMemStream)
        End Using
    End Function

   
End Class

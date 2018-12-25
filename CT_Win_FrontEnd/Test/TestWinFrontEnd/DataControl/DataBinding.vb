Imports R_Common
Imports R_Win_FrontEnd
Public Class DataBinding
    Dim loTemp As lkCustomer

    Private Sub btnReloadGrid_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReloadGrid.Click
        Dim loListCustomers As New List(Of lkCustomer)

        loListCustomers.Add(loTemp)
        Me.R_Conductor1.R_RebindParent()

        Me.ParentBindingSource.DataSource = New R_BindingListView(Of lkCustomer)(loListCustomers)
    End Sub

    Private Sub DataBinding_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Init Combo sex
        Dim loSex As New List(Of SexLookUp)()


        With loSex
            .Add(New SexLookUp("L", "Laki"))
            .Add(New SexLookUp("P", "Perempuan"))
        End With
        cboSex.DataSource = loSex

        Dim loService As New CustomerService()
        Dim loListCustomers As List(Of lkCustomer)
        loListCustomers = loService.GetCustomerLookUp()

        Me.ParentBindingSource.DataSource = New R_BindingListView(Of lkCustomer)(loListCustomers)
        If Me.ParentBindingSource.Count > 0 Then
            loTemp = Me.ParentBindingSource.Current()
        End If
    End Sub

    Private Sub R_Conductor1_R_AfterAdd(ByRef poEntity As Object) Handles R_Conductor1.R_AfterAdd
        CType(poEntity, dtoCustomer).CustomerId = "C_"
    End Sub

    Private Sub R_Conductor1_R_BeforeAdd() Handles R_Conductor1.R_BeforeAdd
        Dim loException As New R_Exception()
        Try
            If MsgBox("apakah akan lanjut", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                loException.Add("01", "BeforeAdd Cancel")
                Exit Try
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()


    End Sub

    Private Sub R_Conductor1_R_BeforeDelete(ByVal poEntity As Object) Handles R_Conductor1.R_BeforeDelete
        Dim loException As New R_Exception()
        Try
            If MsgBox("apakah akan lanjut", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                loException.Add("01", "BeforeDelete Cancel")
                Exit Try
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub R_Conductor1_R_BeforeEdit(ByVal poEntity As Object) Handles R_Conductor1.R_BeforeEdit
        Dim loException As New R_Exception()
        Try
            If MsgBox("apakah akan lanjut", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                loException.Add("01", "BeforeEdit Cancel")
                Exit Try
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub R_Conductor1_R_ServiceDelete(ByVal poEntity As Object) Handles R_Conductor1.R_ServiceDelete
        Dim loException As New R_Exception()
        Try
            If MsgBox("Test throw exception?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                loException.Add("01", "Exception dari ServiceDelete")
                Exit Try
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub R_Conductor1_R_ServiceGetRecord(ByVal poEntity As Object, ByRef poEntityResult As Object) Handles R_Conductor1.R_ServiceGetRecord
        Dim loEntity As lkCustomer = poEntity

        '---simulate run service to get data
        poEntityResult = New dtoCustomer()
        With CType(poEntityResult, dtoCustomer)
            .CustomerId = loEntity.CustomerId
            .FirstName = loEntity.FirstName
            .LastName = loEntity.FirstName + " LastName dari service"
            .Sex = loEntity.Sex
        End With

        MsgBox("get record")
    End Sub

    Private Sub R_Conductor1_R_Display(ByVal poEntity As Object, ByVal peMode As R_Win_FrontEnd.R_Conductor.e_Mode) Handles R_Conductor1.R_Display
        MsgBox("R_display")
        If poEntity Is Nothing Then
            Return
        End If

        If CType(poEntity, dtoCustomer).Sex = "L" Then
            cboSex.SelectedValue = "L"
        ElseIf CType(poEntity, dtoCustomer).Sex = "P" Then
            cboSex.SelectedValue = "P"
        Else
            cboSex.SelectedValue = ""
        End If


    End Sub


    Private Sub R_Conductor1_R_Validation(ByVal poEntity As Object, ByVal peMode As R_Win_FrontEnd.R_Conductor.e_Mode) Handles R_Conductor1.R_Validation
        Dim loException As New R_Exception()
        Try
            MsgBox(IIf(peMode = R_Win_FrontEnd.R_Conductor.e_Mode.AddMode, "Add", "Edit"), , "R_Validation")
            If MsgBox("apakah validation akan lanjut", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                loException.Add("01", "Validation Cancel")
                Exit Try
            End If
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub R_Conductor1_R_Saving(ByRef poEntity As Object, ByVal peMode As R_Win_FrontEnd.R_Conductor.e_Mode) Handles R_Conductor1.R_Saving
        Dim loException As New R_Exception()
        Try
            MsgBox(IIf(peMode = R_Win_FrontEnd.R_Conductor.e_Mode.AddMode, "Add", "Edit"), , "R_Saving")
            If MsgBox("apakah Saving akan lanjut", MsgBoxStyle.OkCancel) = MsgBoxResult.Cancel Then
                loException.Add("01", "Saving Cancel")
                Exit Try
            End If
            CType(poEntity, dtoCustomer).Sex = cboSex.SelectedValue
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub R_Conductor1_R_ServiceSave(ByVal poEntity As Object, ByVal peMode As R_Win_FrontEnd.R_Conductor.e_Mode, ByRef poEntityResult As Object) Handles R_Conductor1.R_ServiceSave
        Dim loException As New R_Exception()
        Try
            MsgBox(IIf(peMode = R_Win_FrontEnd.R_Conductor.e_Mode.AddMode, "Add", "Edit"), , "Service Save")
            If MsgBox("Test Throw di Service Save?", MsgBoxStyle.OkCancel) = MsgBoxResult.Ok Then
                loException.Add("01", "Service Save Throw Error")
                Exit Try
            End If
            poEntityResult = poEntity
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()
    End Sub

    Private Sub btnFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFind.Click
        Dim loDto = New lkCustomer("001", "Gunawan", "L")
        Me.R_Conductor1.R_GetEntity(loDto)
    End Sub


    Private Sub R_Conductor1_R_ConvertParentEntity(ByVal poEntity As Object, ByRef poParentEntity As Object) Handles R_Conductor1.R_ConvertParentGridEntity
        Dim loEntity As dtoCustomer = poEntity
        poParentEntity = New lkCustomer()
        With CType(poParentEntity, lkCustomer)
            .CustomerId = loEntity.CustomerId
            .FirstName = loEntity.FirstName
            .Sex = loEntity.Sex
        End With

    End Sub


End Class
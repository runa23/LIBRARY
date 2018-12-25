Imports System.ComponentModel
Imports SC_Common
Imports System.IO
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Runtime.Serialization

Public Class SC_Conductor
    Implements ISupportInitialize

    Public Enum e_Mode
        None = -1
        NormalMode = 0
        AddMode = 1
        EditMode = 2
    End Enum

#Region " VARIABLES "
    '----Collection -----------
    Private colEnableAdd As New Collection()
    Private colEnableEdit As New Collection()
    Private colEnableOther As New Collection()
    Private colEnableHasData As New Collection()
    Private colFind As New Collection()
    Private colUpdSav As New Collection()

    '----Role-----------------
    Private Role_Permit As New _RolePermitCls

    Public Class _RolePermitCls
        Public Add_Permit As Boolean = True
        Public Edit_Permit As Boolean = True
        Public Delete_Permit As Boolean = True
        Public Read_Permit As Boolean = True
    End Class

    '----- data ---------
    Private CT_mode As e_Mode = e_Mode.None
    Private llRefreshFromParent As Boolean = False 'flag penanda refresh dari parent 
    Private _ProcessStatus As String
    Private _OldEntity As Object
    Private _BindingSource As BindingSource
    Private WithEvents _ParentBindingSource As BindingSource
    Private _ParentKey As String

    '------form ------------
    Private WithEvents _Form As Form = Nothing

    '------ParentBindingSource ------------
    Private llLockParentBindingSource As Boolean = True
    Private llFirstDataSourceChange As Boolean = True

#End Region

#Region " Variable EVENTS "

    Public Event CT_ServiceRefreshList() ' Refresh tab list

    Public Event SC_BeforeAdd()   ' Cek kondisi sebelum Add
    Public Event SC_AfterAdd(ByRef poEntity As Object)     ' untuk Merubah nilai saat didisplay
    Public Event SC_BeforeEdit(ByVal poEntity As Object) ' Cek kondisi sebelum Edit
    Public Event SC_AfterEdit(ByRef poEntity As Object)     ' untuk Merubah nilai saat didisplay edit
    Public Event SC_BeforeDelete(ByVal poEntity As Object) ' Cek kondisi sebelum Delete
    Public Event SC_Validation(ByVal poEntity As Object, ByVal peMode As e_Mode) ' Validasi sebelum Save
    Public Event SC_Saving(ByRef poEntity As Object, ByVal peMode As e_Mode)     ' untuk Merubah saat akan melakukan save
    Public Event SC_AfterSave(ByVal poEntity As Object, ByVal peMode As e_Mode) ' Melakukan action setelah berhasil save

    Public Event SC_EvaluateEntity(ByVal poEntity As Object) ' Evaluasi saat get Entity
    Public Event SC_Display(ByVal poEntity As Object, ByVal peMode As e_Mode) ' Evaluasi saat get Entity

    Public Event SC_ConvertParentGridEntity(ByVal poEntity As Object, ByRef poParentEntity As Object)

    Public Event SC_ServiceGetRecord(ByVal poEntity As Object, ByRef poEntityResult As Object) 'menjalankan Service untuk GetRecord
    Public Event SC_ServiceDelete(ByVal poEntity As Object) 'menjalankan Service untuk Delete
    Public Event SC_ServiceSave(ByVal poEntity As Object, ByVal peMode As e_Mode, ByRef poEntityResult As Object) 'menjalankan Service untuk Save
#End Region

#Region "Property Mode"
    Public ReadOnly Property _Mode() As e_Mode
        Get
            Return CT_mode
        End Get
    End Property
#End Region

#Region " PROPERTY BindingSource  "
    <Category("CTAgro_Data_Binding")> _
    Public Property CT_BindingSource() As BindingSource
        Get
            Return _BindingSource
        End Get
        Set(ByVal value As BindingSource)
            _BindingSource = value
        End Set
    End Property

    <Category("CTAgro_Data_Binding")> _
    Public Property CT_ParentBindingSource() As BindingSource
        Get
            Return _ParentBindingSource
        End Get
        Set(ByVal value As BindingSource)
            _ParentBindingSource = value
        End Set
    End Property

    <Category("CTAgro_Data_Binding")> _
    Public Property CT_ParentKey() As String
        Get
            Return _ParentKey
        End Get
        Set(ByVal value As String)
            _ParentKey = value
        End Set
    End Property

#End Region

#Region " ADD COLLECTION "
    'Collection ADD
    Public Sub CollectADD(ByVal ColObject As Object)
        colEnableAdd.Add(ColObject)
    End Sub
    'Collection EDIT
    Public Sub CollectEDIT(ByVal ColObject As Object)
        colEnableEdit.Add(ColObject)
    End Sub
    'Collection NODATA
    Public Sub CollectHASDATA(ByVal ColObject As Object)
        colEnableHasData.Add(ColObject)
    End Sub
    'Collection OTHERS
    Public Sub CollectOTHER(ByVal ColObject As Object)
        colEnableOther.Add(ColObject)
    End Sub
    'Collection FIND
    Public Sub CollectFIND(ByVal ColObject As Object)
        colFind.Add(ColObject)
    End Sub
    'Collection UPDSAV
    Public Sub CollectUPDSAV(ByVal ColObject As Object)
        colUpdSav.Add(ColObject)
    End Sub
#End Region

#Region "Set Collection"
    Private Sub _SetCol(ByVal status As Boolean, ByVal loColl As Collection)
        For Each objCol In loColl
            If TypeOf (objCol) Is TextBox Or TypeOf (objCol) Is MaskedTextBox Then
                objCol.ReadOnly = Not status
            Else
                objCol.Enabled = status
            End If
        Next
    End Sub

    <Browsable(False)> _
    Public Sub _SetCol_Add(ByVal status As Boolean)
        _SetCol(status, colEnableAdd)
    End Sub
    <Browsable(False)> _
    Public Sub _SetCol_Edit(ByVal status As Boolean)
        _SetCol(status, colEnableEdit)
    End Sub
    <Browsable(False)> _
    Public Sub _SetCol_Hasdata(ByVal status As Boolean)
        _SetCol(status, colEnableHasData)
    End Sub
    <Browsable(False)> _
    Public Sub _SetCol_Other(ByVal status As Boolean)
        _SetCol(status, colEnableOther)
    End Sub
    <Browsable(False)> _
    Public Sub _SetCol_Find(ByVal status As Boolean)
        _SetCol(status, colFind)
    End Sub
    <Browsable(False)> _
    Private Sub _SetCol_UpdSav(ByVal poRole As Object, ByVal Status As String, ByVal NotEmpty As Boolean)
        Dim loRole As New _RolePermitCls
        loRole = Role_Permit
        For Each objCol In colUpdSav
            objCol.NotifyStatus(loRole, Status, NotEmpty)
        Next
    End Sub
#End Region

#Region " External M-E-T-H-O-D "

#Region "Set Role"
    Public Sub CT_SetRoleApp(ByVal poRoleApp As Object)
        With Role_Permit
            .Add_Permit = poRoleApp.Add_Permit
            .Edit_Permit = poRoleApp.Edit_Permit
            .Delete_Permit = poRoleApp.Delete_Permit
            .Read_Permit = poRoleApp.Read_Permit
        End With
    End Sub
#End Region

#Region " Proses CT_GetEntity "
    'Dipanggil dari luar dan tombol find
    Public Sub CT_GetEntity(ByVal poEntity As Object)
        Me._GetEntityInternal(poEntity, True)
    End Sub

#End Region

#Region "Proses rebind Parent"
    'dipanggil dari luar sebelum datasource parent diubah
    Public Sub CT_RebindParent()
        llFirstDataSourceChange = True
        llLockParentBindingSource = True
        CT_mode = e_Mode.None
        _BindingSource.Clear()
        'clone Current data untuk dikirim ke CT_Display
        RaiseEvent SC_Display(CloneCurrentData(), CT_mode)
    End Sub
#End Region

#Region " Proses INIT "
    Public Sub CT_INIT()
        CT_NotifyALL("init")
    End Sub
#End Region
#End Region

#Region "Internal Method"
#Region " CT_NotifyALL (status) "

    Private Sub CT_NotifyALL(ByVal Status As String)
        Dim llHasData As Boolean
        '1. colUpdSav.NotifyStatus(Status,Jika Recount > 0 ) 
        '2. Jalankan Colection Child
        '***************************************************

        'Save Current proses status
        _ProcessStatus = Status
        llHasData = False
        If _BindingSource IsNot Nothing AndAlso _BindingSource.Count > 0 Then
            llHasData = True
        End If

        If _Form IsNot Nothing Then
            _Form.SuspendLayout()
        End If

        _SetCol_UpdSav(Role_Permit, Status, llHasData)
        'Me.RsetCol_ChildMediator(status)
        Select Case LCase(Status)
            Case "init"
                CT_mode = e_Mode.NormalMode
                Me._SetCol_Add(False)
                Me._SetCol_Other(True)
                Me._SetCol_Hasdata(False)
            Case "add"
                CT_mode = e_Mode.AddMode
                Me._SetCol_Add(True)
                Me._SetCol_Other(False)
                Me._SetCol_Hasdata(False)
            Case "edit"
                CT_mode = e_Mode.EditMode
                Me._SetCol_Edit(True)
                Me._SetCol_Other(False)
                Me._SetCol_Hasdata(False)
            Case "remove"
                CT_mode = e_Mode.NormalMode
                Me._SetCol_Add(False)
                Me._SetCol_Other(True)
                Me._SetCol_Hasdata(llHasData)
            Case "save"
                CT_mode = e_Mode.NormalMode
                Me._SetCol_Add(False)
                Me._SetCol_Other(True)
                Me._SetCol_Hasdata(llHasData)
            Case "cancel"
                CT_mode = e_Mode.NormalMode
                Me._SetCol_Add(False)
                Me._SetCol_Other(True)
                Me._SetCol_Hasdata(llHasData)
            Case "normal"
                CT_mode = e_Mode.NormalMode
                Me._SetCol_Add(False)
                Me._SetCol_Other(True)
                Me._SetCol_Hasdata(llHasData)
        End Select

        If _Form IsNot Nothing Then
            _Form.ResumeLayout()
        End If

    End Sub


#End Region

    Private Sub _GetEntityInternal(ByVal poEntity As Object, ByVal plwithValidation As Boolean)
        Dim loException As New SC_Exception()
        Dim loCurrentEntity As Object = Nothing
        Dim loTemporaryEntity As Object = Nothing
        Dim lcOldStatus As String = ""

        Try
            If llRefreshFromParent Then
                llRefreshFromParent = False
                Return
            End If

            'OldStatus kalau ada error
            lcOldStatus = _ProcessStatus
            'clone old data untuk cancel process
            _OldEntity = CloneCurrentData()

            loCurrentEntity = Nothing
            RaiseEvent SC_ServiceGetRecord(poEntity, loCurrentEntity)

            If loCurrentEntity Is Nothing Then
                loException.Add("001", "No Data Found")
                SetCurrentData(loCurrentEntity)
                Exit Try
            End If

            'clone Entity Result untuk dikirim ke CT_Display
            loTemporaryEntity = CloneObject(loCurrentEntity)
            RaiseEvent SC_Display(loTemporaryEntity, CT_mode)

            If plwithValidation Then
                'clone Entity Result untuk dikirim ke CT_EvaluateEntity
                loTemporaryEntity = CloneObject(loCurrentEntity)

                RaiseEvent SC_EvaluateEntity(loTemporaryEntity)
            End If


            SetCurrentData(loCurrentEntity)

            CT_NotifyALL("normal")
        Catch ex As Exception
            loException.Add(ex)
            SetCurrentData(_OldEntity)
            CT_NotifyALL(lcOldStatus)
        End Try
        If loException.Haserror Then
            Me.DisplayException(loException)
        End If
    End Sub
#End Region

#Region "Event"

    Private Sub _ParentBindingSource_DataSourceChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _ParentBindingSource.DataSourceChanged
        If llFirstDataSourceChange Then
            llFirstDataSourceChange = False
            Return
        End If
        llLockParentBindingSource = False
        _ParentBindingSource_CurrentChanged(Nothing, Nothing)
    End Sub

    Private Sub _ParentBindingSource_CurrentChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles _ParentBindingSource.CurrentChanged
        llFirstDataSourceChange = False
        If llLockParentBindingSource = False Then
            If CT_mode = e_Mode.None Then
                Me.CT_INIT()
            End If
            If _ParentBindingSource.Count > 0 Then
                _GetEntityInternal(_ParentBindingSource.Current, False)
            End If
        End If
    End Sub


    Public Sub BeginInit() Implements System.ComponentModel.ISupportInitialize.BeginInit
    End Sub

    Public Sub EndInit() Implements System.ComponentModel.ISupportInitialize.EndInit

        If _Form Is Nothing Then
            Try
                'Check Collection
                If colEnableAdd.Count > 0 Then
                    For Each loObject As Object In colEnableAdd
                        If TypeOf (loObject) Is Control Then
                            _Form = CType(loObject, Control).FindForm()
                            Exit Try
                        End If
                    Next
                ElseIf colEnableEdit.Count > 0 Then
                    For Each loObject As Object In colEnableEdit
                        If TypeOf (loObject) Is Control Then
                            _Form = CType(loObject, Control).FindForm()
                            Exit Try
                        End If
                    Next
                ElseIf colEnableHasData.Count > 0 Then
                    For Each loObject As Object In colEnableHasData
                        If TypeOf (loObject) Is Control Then
                            _Form = CType(loObject, Control).FindForm()
                            Exit Try
                        End If
                    Next
                ElseIf colEnableOther.Count > 0 Then
                    For Each loObject As Object In colEnableOther
                        If TypeOf (loObject) Is Control Then
                            _Form = CType(loObject, Control).FindForm()
                            Exit Try
                        End If
                    Next
                ElseIf colUpdSav.Count > 0 Then
                    For Each loObject As Object In colUpdSav
                        If TypeOf (loObject) Is Control Then
                            _Form = CType(loObject, Control).FindForm()
                            Exit Try
                        End If
                    Next
                End If
            Catch ex As Exception
            End Try

        End If
    End Sub

    Private Sub _Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles _Form.Load
        If CT_mode = e_Mode.None Then
            Me.CT_INIT()
        End If
    End Sub
#End Region

#Region " P-R-O-C-E-S-S "

#Region "REFRESH_PARENT"
    Public Sub _REFRESH_LIST()
        Dim loException As New SC_Exception()

        Try

            RaiseEvent CT_ServiceRefreshList()

        Catch ex As Exception
            loException.Add(ex)
            SetCurrentData(_OldEntity)
        End Try
        If loException.Haserror Then
            Me.DisplayException(loException)
        End If


    End Sub
#End Region

#Region " Proses ADD"
    Public Sub _ADD()
        Dim loException As New SC_Exception()
        Dim loCurrentEntity As Object
        Dim loTemporaryEntity As Object = Nothing
        Dim lcOldStatus As String = ""

        Try
            'OldStatus kalau ada error
            lcOldStatus = _ProcessStatus
            'clone old data untuk cancel process
            _OldEntity = CloneCurrentData()

            RaiseEvent SC_BeforeAdd()

            CT_NotifyALL("add")

            _BindingSource.AddNew()

            'clone Current data untuk dikirim ke CT_Display
            loTemporaryEntity = CloneCurrentData()
            RaiseEvent SC_Display(loTemporaryEntity, CT_mode)

            'dapatkan data untuk dikirim ke CT_AfterAdd
            loCurrentEntity = getCurrentData()

            RaiseEvent SC_AfterAdd(loCurrentEntity)
            SetCurrentData(loCurrentEntity)

        Catch ex As Exception
            loException.Add(ex)
            SetCurrentData(_OldEntity)
            CT_NotifyALL(lcOldStatus)
        End Try
        If loException.Haserror Then
            Me.DisplayException(loException)
        End If


    End Sub
#End Region

#Region " Proses EDIT "

    Public Sub _EDIT()
        Dim loException As New SC_Exception()
        Dim loCurrentEntity As Object
        Dim loTemporaryEntity As Object = Nothing
        Dim lcOldStatus As String = ""

        Try
            'OldStatus kalau ada error
            lcOldStatus = _ProcessStatus
            'clone old data untuk cancel process
            _OldEntity = CloneCurrentData()

            'clone data untuk dikirim ke CT_BeforeEdit
            loCurrentEntity = CloneCurrentData()

            RaiseEvent SC_BeforeEdit(loCurrentEntity)

            CT_NotifyALL("edit")

            RaiseEvent SC_AfterEdit(loCurrentEntity)

            'clone Current data untuk dikirim ke CT_Display
            loTemporaryEntity = CloneCurrentData()
            RaiseEvent SC_Display(loTemporaryEntity, CT_mode)
        Catch ex As Exception
            loException.Add(ex)
            SetCurrentData(_OldEntity)
            CT_NotifyALL(lcOldStatus)
        End Try
        If loException.Haserror Then
            Me.DisplayException(loException)
        End If

    End Sub

#End Region

#Region " Proses CANCEL "
    Public Sub _CANCEL()
        Dim loTemporaryEntity As Object = Nothing

        _BindingSource.CurrencyManager.CancelCurrentEdit()
        SetCurrentData(_OldEntity)
        CT_NotifyALL("cancel")

        'clone Current data untuk dikirim ke CT_Display
        loTemporaryEntity = CloneCurrentData()
        RaiseEvent SC_Display(loTemporaryEntity, CT_mode)
    End Sub
#End Region

#Region " Proses REMOVE  "

    Public Sub _DELETE()
        Dim loException As New SC_Exception()
        Dim loCurrentEntity As Object
        Dim loTemporaryEntity As Object = Nothing
        Dim lcOldStatus As String = ""

        Try
            'OldStatus kalau ada error
            lcOldStatus = _ProcessStatus
            'clone old data untuk cancel process
            _OldEntity = CloneCurrentData()

            'clone data untuk dikirim ke CT_BeforeDelete
            loCurrentEntity = CloneCurrentData()

            RaiseEvent SC_BeforeDelete(loCurrentEntity)

            If MsgBox("Apakah anda yakin akan menghapus data ini", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Delete") = MsgBoxResult.No Then
                SetCurrentData(_OldEntity)
                Exit Try
            End If

            'clone data untuk dikirim ke CT_ServiceDelete
            loCurrentEntity = CloneCurrentData()
            RaiseEvent SC_ServiceDelete(loCurrentEntity)

            _BindingSource.Clear()
            CT_NotifyALL("remove")

            If _ParentBindingSource IsNot Nothing Then
                Dim loParentCurr As Object = Nothing
                Dim loParentList As System.ComponentModel.IBindingList
                Dim lcParentSort As String = ""
                Dim lcParentDirection As String = ""

                llRefreshFromParent = True

                loParentCurr = _ParentBindingSource.Current

                loParentList = CType(_ParentBindingSource, System.ComponentModel.IBindingList)

                lcParentSort = ""
                If loParentList.SortProperty IsNot Nothing Then
                    llRefreshFromParent = True

                    lcParentSort = loParentList.SortProperty.Name
                    lcParentDirection = loParentList.SortDirection.ToString()
                    _ParentBindingSource.RemoveSort()
                End If

                If lcParentSort = "" Then
                    llRefreshFromParent = False
                Else
                    llRefreshFromParent = True
                End If
                _ParentBindingSource.Remove(loParentCurr)

                If lcParentSort <> "" Then
                    llRefreshFromParent = False
                    _ParentBindingSource.Sort = lcParentSort.Trim + IIf(lcParentDirection.StartsWith("Asc"), " Asc", " Desc")
                End If


            End If

            'clone Current data untuk dikirim ke CT_Display
            loTemporaryEntity = CloneCurrentData()
            RaiseEvent SC_Display(loTemporaryEntity, CT_mode)
        Catch ex As Exception
            loException.Add(ex)
            SetCurrentData(_OldEntity)
            CT_NotifyALL(lcOldStatus)
        End Try
        If loException.Haserror Then
            Me.DisplayException(loException)
        End If

    End Sub

#End Region

#Region " Proses SAVE"

    Public Sub _SAVE()
        Dim loException As New SC_Exception()
        Dim loCurrentEntity As Object = Nothing
        Dim loTemporaryEntity As Object = Nothing
        Dim lcOldStatus As String = ""
        Dim leOldMode As e_Mode

        Try
            'OldStatus kalau ada error
            lcOldStatus = _ProcessStatus
            'Old Mode untuk refresh parent
            leOldMode = CT_mode

            _BindingSource.EndEdit()

            'Clone CurrentData untuk proses validation
            loTemporaryEntity = CloneCurrentData()

            RaiseEvent SC_Validation(loTemporaryEntity, CT_mode)

            'Clone CurrentData untuk proses CT_Saving
            loCurrentEntity = CloneCurrentData()

            RaiseEvent SC_Saving(loCurrentEntity, CT_mode)

            'Clone Hasil CT_Saving untuk proses Service Save
            loTemporaryEntity = CloneObject(loCurrentEntity)

            loCurrentEntity = Nothing
            RaiseEvent SC_ServiceSave(loTemporaryEntity, CT_mode, loCurrentEntity)

            If loCurrentEntity Is Nothing Then
                loException.Add("001", "Data Not Found")
                SetCurrentData(loCurrentEntity)
                Exit Try
            End If

            SetCurrentData(loCurrentEntity)

            CT_NotifyALL("save")

            If _ParentBindingSource IsNot Nothing Then
                Dim loParentList As System.ComponentModel.IBindingList
                Dim lcParentSort As String = ""
                Dim lcParentDirection As String = ""
                Dim loParentCurr As Object = Nothing
                Dim loParentOld As Object = Nothing
                Dim loParentPropInfos As System.Reflection.PropertyInfo()
                Dim lcParentKey As String
                Dim loParentKeyValue As Object
                Dim lnParentPos As Integer = -1


                If String.IsNullOrEmpty(_ParentKey) Then
                    loException.Add("001", "Parent key for Conductor cannot empty")
                    loException.ThrowExceptionIfErrors()
                End If

                llRefreshFromParent = True

                'clone untuk dikirim ke CT_ConvertParentEntity
                loTemporaryEntity = CloneCurrentData()
                loParentCurr = CloneCurrentData()

                RaiseEvent SC_ConvertParentGridEntity(loTemporaryEntity, loParentCurr)

                loParentPropInfos = loParentCurr.GetType.GetProperties()
                lcParentKey = ""
                For Each loInfo As System.Reflection.PropertyInfo In loParentPropInfos
                    If loInfo.Name.Trim.ToLower = _ParentKey.Trim.ToLower Then
                        lcParentKey = loInfo.Name
                        loParentKeyValue = loInfo.GetValue(loParentCurr, Nothing)
                        Exit For
                    End If
                Next
                If lcParentKey = "" Then
                    loException.Add("002", "Parent key " + _ParentKey + " for Conductor not found")
                    loException.ThrowExceptionIfErrors()
                End If

                If leOldMode = e_Mode.EditMode Then
                    loParentOld = _ParentBindingSource.Current
                End If


                loParentList = CType(_ParentBindingSource, System.ComponentModel.IBindingList)

                If loParentList.SortProperty IsNot Nothing Then
                    lcParentSort = loParentList.SortProperty.Name
                    lcParentDirection = loParentList.SortDirection.ToString()
                    _ParentBindingSource.RemoveSort()
                End If

                If leOldMode = e_Mode.EditMode Then
                    _ParentBindingSource.Remove(loParentOld)
                End If

                _ParentBindingSource.Add(loParentCurr)

                If lcParentSort <> "" Then
                    _ParentBindingSource.Sort = lcParentSort.Trim + IIf(lcParentDirection.StartsWith("Asc"), " Asc", " Desc")
                End If

                lnParentPos = -1

                If TypeOf (_ParentBindingSource.DataSource) Is SC_ICanFixSearch Then
                    CType(_ParentBindingSource.DataSource, SC_ICanFixSearch).setFixSearch(True)
                End If

                lnParentPos = _ParentBindingSource.Find(lcParentKey, loParentKeyValue)
                If lnParentPos <> -1 Then
                    _ParentBindingSource.Position = lnParentPos
                End If

                If TypeOf (_ParentBindingSource.DataSource) Is SC_ICanFixSearch Then
                    CType(_ParentBindingSource.DataSource, SC_ICanFixSearch).setFixSearch(False)
                End If

            End If

            'clone Current data untuk dikirim ke CT_Display
            loTemporaryEntity = CloneCurrentData()
            RaiseEvent SC_Display(loTemporaryEntity, CT_mode)
            RaiseEvent SC_AfterSave(loTemporaryEntity, leOldMode)
        Catch ex As Exception
            loException.Add(ex)
            CT_NotifyALL(lcOldStatus)
        End Try
        If loException.Haserror Then
            Me.DisplayException(loException)
        End If

    End Sub

#End Region

#End Region


#Region "Helper"
    Private Sub DisplayException(ByVal poException As SC_Exception)
        If poException.Haserror Then
            Try
                Dim loform As Form = New SC_ErrorForm()

                If _Form IsNot Nothing Then
                    loform.Show()
                    loform.Owner = _Form
                End If
                CType(loform, SC_IFormBase)._InitFromMaster(poException.GetErrorList, SC_eFormModel.Detail, Nothing)
                If _Form IsNot Nothing Then
                    _Form.Enabled = False
                End If
            Catch ex As Exception
            End Try
        End If
    End Sub
    Private Function CloneObject(ByVal poObject As Object) As Object
        Using loMemStream As New MemoryStream()
            Dim loBinaryFormatter As New BinaryFormatter(Nothing, New StreamingContext(StreamingContextStates.Clone))
            loBinaryFormatter.Serialize(loMemStream, poObject)
            loMemStream.Seek(0, SeekOrigin.Begin)
            Return loBinaryFormatter.Deserialize(loMemStream)
        End Using
    End Function

    Private Function CloneCurrentData() As Object
        Dim loRtn As Object = Nothing

        If _BindingSource.Count > 0 Then
            loRtn = CloneObject(_BindingSource.Current)
        End If

        Return loRtn
    End Function

    Private Function getCurrentData() As Object
        Dim loRtn As Object = Nothing

        If _BindingSource.Count > 0 Then
            loRtn = _BindingSource.Current
        End If

        Return loRtn
    End Function

    Private Sub SetCurrentData(ByVal loEntity As Object)
        If loEntity Is Nothing Then
            _BindingSource.Clear()
        Else
            _BindingSource.DataSource = loEntity
        End If
    End Sub
#End Region



End Class


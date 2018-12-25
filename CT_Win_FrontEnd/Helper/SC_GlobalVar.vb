Public Class SC_GlobalVar

    Friend Shared _UserId As String = ""
    Friend Shared _UserName As String = ""
    Friend Shared _UserRoleId As String = ""
    Friend Shared _CompanyId As String = ""
    Friend Shared _CompanyName As String = ""
    Friend Shared _CompanyOfficeId As String = ""
    Friend Shared _CompanyOfficeName As String = ""
    Friend Shared _CompanyOfficeMapId As String = ""
    Friend Shared _RoleAppList As List(Of role_appDTO)

    Public Shared ReadOnly Property UserId() As String
        Get
            Return _UserId
        End Get
    End Property
    Public Shared ReadOnly Property UserName() As String
        Get
            Return _UserName
        End Get
    End Property
    Public Shared ReadOnly Property UserRoleId() As String
        Get
            Return _UserRoleId
        End Get
    End Property
    Public Shared ReadOnly Property CompanyId() As String
        Get
            Return _CompanyId
        End Get
    End Property
    Public Shared ReadOnly Property CompanyName() As String
        Get
            Return _CompanyName
        End Get
    End Property
    Public Shared ReadOnly Property CompanyOfficeId() As String
        Get
            Return _CompanyOfficeId
        End Get
    End Property
    Public Shared ReadOnly Property CompanyOfficeName() As String
        Get
            Return _CompanyName
        End Get
    End Property
    Public Shared ReadOnly Property RoleAppList() As List(Of role_appDTO)
        Get
            Return _RoleAppList
        End Get
    End Property
    Public Shared ReadOnly Property RoleApp(ByVal pcAppId As String) As Object
        Get
            Dim loReturn As role_appDTO
            loReturn = (From c In _RoleAppList
                       Where c.App_Id = pcAppId
                       Select c).FirstOrDefault

            Return loReturn
        End Get
    End Property

End Class

Public Class role_appDTO
    Public App_Id As String
    Public Add_Permit As Boolean
    Public Edit_Permit As Boolean
    Public Delete_Permit As Boolean
    Public Read_Permit As Boolean
End Class

Public Interface _IInitiator
    Sub Set_UserId(ByVal pcUserId As String)
    Sub Set_UserName(ByVal pcUserName As String)
    Sub Set_UserRoleId(ByVal pcUserRoleId As String)
    Sub Set_CompanyId(ByVal pcCompanyId As String)
    Sub Set_CompanyName(ByVal pcCompanyName As String)
    Sub Set_CompanyOfficeId(ByVal pcCompanyOfficeId As String)
    Sub Set_CompanyOfficeName(ByVal pcCompanyOfficeName As String)
    Sub Set_CompanyOfficeMapId(ByVal pcCompanyOfficeMapId As String)
    Sub Set_RoleAppList(ByVal poRoleAppList As Object)

End Interface
Public Class _Initiator
    Implements _IInitiator

    Public Sub Set_CompanyId(ByVal pcCompanyId As String) Implements _IInitiator.Set_CompanyId
        SC_GlobalVar._CompanyId = pcCompanyId
    End Sub

    Public Sub Set_CompanyName(ByVal pcCompanyName As String) Implements _IInitiator.Set_CompanyName
        SC_GlobalVar._CompanyName = pcCompanyName
    End Sub


    Public Sub Set_UserId(ByVal pcUserId As String) Implements _IInitiator.Set_UserId
        SC_GlobalVar._UserId = pcUserId
    End Sub

    Public Sub Set_UserName(ByVal pcUserName As String) Implements _IInitiator.Set_UserName
        SC_GlobalVar._UserName = pcUserName
    End Sub

    Public Sub Set_UserRoleId(ByVal pcUserRoleId As String) Implements _IInitiator.Set_UserRoleId
        SC_GlobalVar._UserRoleId = pcUserRoleId
    End Sub

    Public Sub Set_RoleAppList(ByVal poRoleAppList As Object) Implements _IInitiator.Set_RoleAppList
        Dim lolist As New List(Of role_appDTO)
        Dim loDTo As role_appDTO

        For Each row In poRoleAppList
            loDTo = New role_appDTO
            loDTo.App_Id = row.App_Id
            loDTo.Delete_Permit = row.Delete_Permit
            loDTo.Edit_Permit = row.Edit_Permit
            loDTo.Read_Permit = row.Read_Permit
            lolist.Add(loDTo)
        Next

        SC_GlobalVar._RoleAppList = lolist
    End Sub

    Public Sub Set_CompanyOfficeId(ByVal pcCompanyOfficeId As String) Implements _IInitiator.Set_CompanyOfficeId
        SC_GlobalVar._CompanyOfficeId = pcCompanyOfficeId
    End Sub

    Public Sub Set_CompanyOfficeName(ByVal pcCompanyOfficeName As String) Implements _IInitiator.Set_CompanyOfficeName
        SC_GlobalVar._CompanyOfficeName = pcCompanyOfficeName
    End Sub

    Public Sub Set_CompanyOfficeMapId(pcCompanyOfficeMapId As String) Implements _IInitiator.Set_CompanyOfficeMapId
        SC_GlobalVar._CompanyOfficeMapId = pcCompanyOfficeMapId
    End Sub
End Class

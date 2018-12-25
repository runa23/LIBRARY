Imports R_Win_FrontEnd
Public Class LookUpCustomerForm

    Private Sub LookUpCustomerForm_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim loClient As New CustomerService()
        Dim loRtn As List(Of lkCustomer)

        loRtn = loClient.GetCustomerLookUp()

        Me.BindingSource1.DataSource = New R_BindingListView(Of lkCustomer)(loRtn)
    End Sub
End Class

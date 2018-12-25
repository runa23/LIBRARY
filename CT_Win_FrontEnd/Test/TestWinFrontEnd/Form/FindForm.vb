Public Class FindForm

    
    Private Sub R_Find1_R_Before_Open_Form(ByRef poTargetForm As R_Win_FrontEnd.R_FormBase, ByRef poParameter As Object) Handles R_Find1.R_Before_Open_Form
        Dim loForm As New LookUpCustomerForm()
        poTargetForm = loForm
    End Sub

    Private Sub R_Find1_R_Return_Find(ByVal poReturnObject As Object) Handles R_Find1.R_Return_Find
        If TypeOf (poReturnObject) Is lkCustomer Then
            Me.LkCustomerBindingSource.DataSource = poReturnObject
        End If
    End Sub
End Class

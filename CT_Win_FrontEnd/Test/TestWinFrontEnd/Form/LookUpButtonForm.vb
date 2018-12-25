Public Class LookUpButtonForm

    
    
    Private Sub R_LookUp1_R_Before_Open_Form(ByRef poTargetForm As R_Win_FrontEnd.R_FormBase, ByRef poParameter As Object) Handles R_LookUp1.R_Before_Open_Form
        Dim loForm As New LookUpCustomerForm()
        poTargetForm = loForm
    End Sub
End Class

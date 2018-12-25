Public Class ParentForm

   
    Private Sub R_Detail1_R_Before_Open_Form(ByRef poTargetForm As R_Win_FrontEnd.R_FormBase, ByRef poParameter As Object) Handles R_Detail1.R_Before_Open_Form
        Dim loTarget As New ChildForm()
        Dim loParameters As New List(Of Object)()

        loParameters.Add(txtPar1.Text)
        loParameters.Add(txtPar2.Text)
        poTargetForm = loTarget
        poParameter = loParameters
    End Sub

    
    Private Sub ParentForm_R_Return_From_Detail(ByVal poOwnedForm As System.Windows.Forms.Form, ByVal pcButtonName As String) Handles Me.R_Return_From_Detail
        MsgBox("return from " + poOwnedForm.Name + " with action " + pcButtonName)
    End Sub
End Class

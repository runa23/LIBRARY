Public Class ChildForm

    Private Sub ChildForm_R_Init_From_Master(ByVal poParameter As Object) Handles Me.R_Init_From_Master
        txtPar1.Text = poParameter(0)
        txtPar2.Text = poParameter(1)
    End Sub
End Class

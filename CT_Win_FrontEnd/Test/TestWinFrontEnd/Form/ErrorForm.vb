Imports R_Common
Imports R_Win_FrontEnd
Public Class ErrorForm

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim loException As New R_Exception
        Dim loDetails As New List(Of R_ErrorDetail)()
        Dim loform As Form = New R_ErrorForm()

        loException.Add("hd01", "hd-Desc01 qqqqqqqqqqqqqqqqqq ewrrrrrrrreeeeeeeee hjkrftjlhldjhlhsd lkfglkslfgsllglsdf dfgjlksdjlskdfglds dsfjsdjflsdjf   fklifjdslkfldsksdfjsdfj")
        loException.Add("hd02", "hd-Desc02", "dt01", "dt-desc01 kjsfskfv jbnfvxnvbx  xjvk jvbdfnmvnmc jvbxvbmx nnfvgbmfnvmzxnvmx")

        loDetails.Add(New R_ErrorDetail("dt01", "dt_desc01 ksfgsdfrgsfhgh  gjjsfdkvgdfv ,dfn,dfn,dgmnn,dg"))
        loDetails.Add(New R_ErrorDetail("dt02", "dt_desc02 hhjvvfjssdfh  hshfbjshgdhs  kfggkdfgjkjkdsgd  gnfkdjgdjk"))

        loException.Add("hd03", "hd-Desc03", loDetails)

        loform.Show(Me)
        CType(loform, R_IFormBase)._InitFromMaster(loException.GetErrorList, R_eFormModel.Detail, Nothing)
        Me.Enabled = False
    End Sub
End Class

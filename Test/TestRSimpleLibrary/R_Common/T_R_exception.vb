Imports R_Common
Public Class T_R_exception


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.txtResult.Text = ""
        Try
            Me.txtResult.Text = devide(Me.txtPar1.Text, Me.txtPar2.Text)
        Catch ex As Exception
            If TypeOf ex Is CT_Exception Then
                For Each loError As CT_Error In CType(ex, CT_Exception).GetErrorList
                    Me.txtError.Text = Me.txtError.Text + " " + loError.ErrDescp
                Next
            End If
        End Try
    End Sub
    Private Function devide(ByVal par1 As Decimal, ByVal par2 As Decimal) As Decimal
        Dim lnRtn As Decimal = 0
        Dim loException As New CT_Exception()

        Try
            lnRtn = par1 / par2
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()

        Return lnRtn
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.txtResult.Text = ""
        Try
            Me.txtResult.Text = devide1(Me.txtPar1.Text, Me.txtPar2.Text)
        Catch ex As Exception
            If TypeOf ex Is CT_Exception Then
                For Each loError As CT_Error In CType(ex, CT_Exception).GetErrorList
                    Me.txtError.Text = Me.txtError.Text + " " + loError.ErrDescp
                Next
            End If
        End Try
    End Sub

    Private Function devide1(ByVal par1 As Decimal, ByVal par2 As Decimal) As Decimal
        Dim lnRtn As Decimal = 0

        Dim loException As New CT_Exception()
        Try
            If par2 = 0 Then
                loException.Add("001", "pembagi tidak boleh 0")
            End If
            If par2 < 0 Then
                loException.Add("002", "pembagi tidak boleh minus")
            End If

            If par2 < 3 Then
                loException.Add("002", "pembagi tidak boleh lebih kecil dari 3")
            End If
            If par2 > 4 Then
                loException.Add("002", "pembagi tidak boleh lebih besar dari 4")
            End If

            If loException.Haserror Then
                Exit Try
            End If

            lnRtn = par1 / par2
        Catch ex As Exception
            loException.Add(ex)
        End Try
        loException.ThrowExceptionIfErrors()

        Return lnRtn
    End Function

    Private Sub btnShowException_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnShowException.Click
        Dim loException As New CT_Exception
        Dim loDetails As New List(Of CT_ErrorDetail)()

        loException.Add("hd01", "hd-Desc01")
        loException.Add("hd02", "hd-Desc02", "dt01", "dt-desc01")

        loDetails.Add(New CT_ErrorDetail("dt01", "dt_desc01"))
        loDetails.Add(New CT_ErrorDetail("dt02", "dt_desc02"))

        loException.Add("hd03", "hd-Desc03", loDetails)

        Me.BindingSource1.DataSource = loException.GetErrorList()
    End Sub

    Private Sub BindingSource1_CurrentChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BindingSource1.CurrentChanged
        If BindingSource1.Current IsNot Nothing Then
            If CType(BindingSource1.Current, CT_Error).HasErrorDetail Then
                Panel1.Visible = True
                ErrorDetailsBindingSource.DataSource = CType(BindingSource1.Current, CT_Error).ErrorDetails
            Else
                Panel1.Visible = False
            End If
        Else
            Panel1.Visible = False
        End If
    End Sub
End Class
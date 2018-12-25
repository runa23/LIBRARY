Imports R_Common
Public Class Encryption

    Private Sub btnEncrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEncrypt.Click
        txtResult.Text = R_Utility.Encrypt(txtData.Text, txtKey.Text)
    End Sub

    Private Sub btnDecrypt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDecrypt.Click
        MsgBox(R_Utility.Decrypt(txtResult.Text.Trim, txtKey.Text))
    End Sub
End Class
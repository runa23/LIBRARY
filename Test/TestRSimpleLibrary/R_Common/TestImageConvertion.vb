Imports R_Common
Public Class TestImageConvertion

    Private Sub btnConvertImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertImage.Click
        Dim loByte() As Byte

        'get file image
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Get Byte from file
            loByte = CT_Utility.GetImageByteFromFile(OpenFileDialog1.FileName, System.Drawing.Imaging.ImageFormat.Jpeg)
            'convert to file
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CT_Utility.ConvertByteToFile(SaveFileDialog1.FileName, loByte)
            End If

        End If
    End Sub

    Private Sub btnConvertBinary_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnConvertBinary.Click
        Dim loByte() As Byte

        'get file minutiae
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'Get Byte from file
            loByte = CT_Utility.GetByteFromFile(OpenFileDialog1.FileName)
            'convert to file
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CT_Utility.ConvertByteToFile(SaveFileDialog1.FileName, loByte)
            End If

        End If
    End Sub

    Private Sub btnFromFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFromFile.Click
        'get original image
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'compress to file
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CT_Utility.CompressFileToFile(OpenFileDialog1.FileName, SaveFileDialog1.FileName)
            End If

        End If
    End Sub

    Private Sub btnFomByte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFomByte.Click
        Dim loData() As Byte
        Dim lobm As Bitmap

        'get original image
        If OpenFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
            'convert file to byte first
            lobm = CT_Utility.LoadImageFromFile(OpenFileDialog1.FileName)
            loData = CT_Utility.ImageSerialize(lobm, System.Drawing.Imaging.ImageFormat.Jpeg)

            'compress to file
            If SaveFileDialog1.ShowDialog() = Windows.Forms.DialogResult.OK Then
                CT_Utility.CompressByteToFile(loData, SaveFileDialog1.FileName)
            End If

        End If
    End Sub
End Class
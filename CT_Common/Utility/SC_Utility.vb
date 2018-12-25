Imports Microsoft.VisualBasic.CompilerServices
Imports Microsoft.VisualBasic.Devices
Imports Microsoft.VisualBasic.MyServices
Imports System
Imports System.Diagnostics
Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Cryptography
Imports System.Text
Imports SC_Common.My

Public Class SC_Utility
#Region "Encryption"
    Public Shared Function Encrypt(ByVal Data As String, ByVal Key As String) As String
        Dim rijndaelManaged As System.Security.Cryptography.RijndaelManaged = New System.Security.Cryptography.RijndaelManaged() With
        {
            .Mode = CipherMode.CBC,
            .Padding = PaddingMode.PKCS7,
            .KeySize = 128,
            .BlockSize = 128
        }
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(Key)
        Dim numArray(15) As Byte
        Dim length As Integer = CInt(bytes.Length)
        If (length > CInt(numArray.Length)) Then
            length = CInt(numArray.Length)
        End If
        Array.Copy(bytes, numArray, length)
        rijndaelManaged.Key = numArray
        rijndaelManaged.IV = numArray
        Dim cryptoTransform As ICryptoTransform = rijndaelManaged.CreateEncryptor()
        Dim bytes1 As Byte() = Encoding.UTF8.GetBytes(Data)
        Dim upper As String = Convert.ToBase64String(cryptoTransform.TransformFinalBlock(bytes1, 0, CInt(bytes1.Length))).ToUpper()
        Return upper
    End Function
    Public Shared Function EncryptForAndroid(ByVal pcData As String, ByVal pcKey As String) As String
        Dim str As String = Nothing
        Dim mD5CryptoServiceProvider As System.Security.Cryptography.MD5CryptoServiceProvider = New System.Security.Cryptography.MD5CryptoServiceProvider()
        Dim numArray As Byte() = mD5CryptoServiceProvider.ComputeHash(Encoding.ASCII.GetBytes(String.Concat(pcData, pcKey)))
        Dim numArray1 As Byte() = numArray
        Dim num As Integer = 0
        While num < CInt(numArray1.Length)
            Dim num1 As Byte = numArray1(num)
            str = String.Concat(str, num1.ToString("X2"))
            num = num + 1
        End While
        Return str
    End Function

    Public Shared Function Decrypt(ByVal pcData As String, ByVal pcKey As String) As String
        Dim rijndaelManaged As System.Security.Cryptography.RijndaelManaged = New System.Security.Cryptography.RijndaelManaged() With
            {
                .Mode = CipherMode.CBC,
                .Padding = PaddingMode.PKCS7,
                .KeySize = 128,
                .BlockSize = 128
            }
        Dim numArray As Byte() = Convert.FromBase64String(pcData)
        Dim bytes As Byte() = Encoding.UTF8.GetBytes(pcKey)
        Dim numArray1(15) As Byte
        Dim length As Integer = CInt(bytes.Length)
        If (length > CInt(numArray1.Length)) Then
            length = CInt(numArray1.Length)
        End If
        Array.Copy(bytes, numArray1, length)
        rijndaelManaged.Key = numArray1
        rijndaelManaged.IV = numArray1
        Dim numArray2 As Byte() = rijndaelManaged.CreateDecryptor().TransformFinalBlock(numArray, 0, CInt(numArray.Length))
        Return Encoding.UTF8.GetString(numArray2)
    End Function
#End Region

#Region "Serialization"
    Public Shared Function Serialize(ByVal Obj As Object) As Byte()
        Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
        Dim binaryFormatter As System.Runtime.Serialization.Formatters.Binary.BinaryFormatter = New System.Runtime.Serialization.Formatters.Binary.BinaryFormatter()
        binaryFormatter.Serialize(memoryStream, RuntimeHelpers.GetObjectValue(Obj))
        Return memoryStream.ToArray()
    End Function
    Public Shared Function Deserialize(ByVal SerializedData() As Byte) As Object
        Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream(SerializedData)
        Return (New BinaryFormatter()).Deserialize(memoryStream)
    End Function

    Public Shared Function ImageSerialize(ByVal loImage As Image, ByVal loFormat As ImageFormat) As Byte()
        Dim array As Byte() = Nothing
        Try
            Using memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
                loImage.Save(memoryStream, loFormat)
                array = memoryStream.ToArray()
            End Using
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Return array
    End Function

    Public Shared Function ImageDeserialize(ByVal SerializedData As Byte()) As System.Drawing.Image
        Dim image As System.Drawing.Image = Nothing
        Try
            Using memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream(SerializedData, 0, CInt(SerializedData.Length))
                memoryStream.Write(SerializedData, 0, CInt(SerializedData.Length))
                image = System.Drawing.Image.FromStream(memoryStream, True)
            End Using
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            ProjectData.ClearProjectError()
        End Try
        Return image
    End Function

    Public Shared Sub ConvertByteToFile(ByVal pcFile As String, ByVal pbData() As Byte)
        Dim fileStream As System.IO.FileStream = Nothing
        Try
            Try
                If (MyProject.Computer.FileSystem.FileExists(pcFile)) Then
                    MyProject.Computer.FileSystem.DeleteFile(pcFile)
                End If
                fileStream = New System.IO.FileStream(pcFile, FileMode.Create)
                fileStream.Write(pbData, 0, CInt(pbData.Length))
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                Throw New System.Exception("Convert Byte To File Fail")
            End Try
        Finally
            If (fileStream IsNot Nothing) Then
                fileStream.Close()
            End If
        End Try

    End Sub

    Public Shared Function GetByteFromFile(ByVal pcFile As String) As Byte()
        Dim binaryReader As System.IO.BinaryReader = Nothing
        Dim fileStream As System.IO.FileStream = Nothing
        Dim numArray As Byte()
        Try
            Try
                fileStream = New System.IO.FileStream(pcFile, FileMode.Open)
                binaryReader = New System.IO.BinaryReader(fileStream)
                ReDim numArray(CInt((fileStream.Length - CLng(1))) + 1 - 1)
                binaryReader.Read(numArray, 0, Convert.ToInt32(fileStream.Length))
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                numArray = Nothing
                ProjectData.ClearProjectError()
            End Try
        Finally
            If (binaryReader IsNot Nothing) Then
                binaryReader.Close()
            End If
            If (fileStream IsNot Nothing) Then
                fileStream.Close()
            End If
        End Try
        Return numArray
    End Function

    Public Shared Function GetImageByteFromFile(ByVal pcFile As String, ByVal loFormat As ImageFormat) As Byte()
        Dim numArray As Byte()
        Try
            numArray = SC_Utility.ImageSerialize(SC_Utility.LoadImageFromFile(pcFile), loFormat)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            numArray = Nothing
            ProjectData.ClearProjectError()
        End Try
        Return numArray
    End Function

    ' Load a bitmap so it's not locked.
    Public Shared Function LoadImageFromFile(ByVal file_name As String) As System.Drawing.Bitmap
        Dim bitmap As System.Drawing.Bitmap
        Using bitmap1 As System.Drawing.Bitmap = New System.Drawing.Bitmap(file_name)
            bitmap = New System.Drawing.Bitmap(bitmap1)
        End Using
        Return bitmap
    End Function
#End Region

#Region "Compress Image"
    Public Shared Sub CompressFileToFile(ByVal pcSourceFile As String, ByVal pcTargetFile As String, Optional ByVal pnSizeInKb As Double = 2.5)
        Try
            SC_Utility.CompressImageToFile(SC_Utility.LoadImageFromFile(pcSourceFile), pcTargetFile, pnSizeInKb)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Throw exception
        End Try
    End Sub
    Public Shared Sub CompressByteToFile(ByVal poSource() As Byte, ByVal pcTargetFile As String, Optional ByVal pnSizeInKb As Double = 2.5)
        Dim str As String = "D:\CT Agro Indonesia\TEMP\"
        Dim str1 As String = String.Concat(str, "temp__.jpg")
        Try
            If (Not Directory.Exists(str)) Then
                Directory.CreateDirectory(str)
            End If
            SC_Utility.ConvertByteToFile(str1, poSource)
            SC_Utility.CompressFileToFile(str1, pcTargetFile, pnSizeInKb)
            If (MyProject.Computer.FileSystem.FileExists(str1)) Then
                MyProject.Computer.FileSystem.DeleteFile(str1)
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Throw exception
        End Try
    End Sub
    Private Shared Sub CompressImageToFile(ByVal poSourceImage As System.Drawing.Image, ByVal pcTargetFile As String, Optional ByVal pnSizeInKb As Double = 2.5)
        Try
            Dim num As Double = pnSizeInKb * 1024
            Dim flag As Boolean = False
            If (MyProject.Computer.FileSystem.FileExists(pcTargetFile)) Then
                MyProject.Computer.FileSystem.DeleteFile(pcTargetFile)
            End If
            Dim num1 As Integer = 30
            Do
                Dim memoryStream As System.IO.MemoryStream = SC_Utility.SaveJpegIntoStream(poSourceImage, CLng(num1))
                If (CDbl(memoryStream.Length) > num) Then
                    num1 = num1 + -1
                Else
                    MyProject.Computer.FileSystem.WriteAllBytes(pcTargetFile, memoryStream.ToArray(), False)
                    flag = True
                    Exit Do
                End If
            Loop While num1 >= 1
            If (Not flag) Then
                Throw New System.Exception("Compression fail")
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            Throw exception
        End Try
    End Sub


    ' Get a codec's information.
    Private Shared Function GetEncoderInfo(ByVal mimeType As String) As System.Drawing.Imaging.ImageCodecInfo
        Dim imageCodecInfo As System.Drawing.Imaging.ImageCodecInfo
        Dim imageEncoders As System.Drawing.Imaging.ImageCodecInfo() = System.Drawing.Imaging.ImageCodecInfo.GetImageEncoders()
        Dim length As Integer = CInt(imageEncoders.Length)
        Dim num As Integer = 0
        While True
            If (num > length) Then
                imageCodecInfo = Nothing
                Exit While
            ElseIf (Operators.CompareString(imageEncoders(num).MimeType, mimeType, True) <> 0) Then
                num = num + 1
            Else
                imageCodecInfo = imageEncoders(num)
                Exit While
            End If
        End While
        Return imageCodecInfo
    End Function

    ' Save a JPEG in compressed form. 
    ' The compression_level value
    ' should be between 10 and 100.
    Private Shared Sub SaveCompressedJpeg(ByVal image As System.Drawing.Image, ByVal file_name As String, ByVal compression_level As Long)
        Dim encoderParameter As EncoderParameters = New EncoderParameters(1)
        encoderParameter.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, compression_level)
        Dim encoderInfo As ImageCodecInfo = SC_Utility.GetEncoderInfo("image/jpeg")
        image.Save(New MemoryStream(), encoderInfo, encoderParameter)
        image.Save(file_name, encoderInfo, encoderParameter)
    End Sub

    ' Save a JPEG in compressed form into a memory stream. 
    ' The compression_level value
    ' should be between 10 and 100.
    Private Shared Function SaveJpegIntoStream(ByVal image As System.Drawing.Image, ByVal compression_level As Long) As System.IO.MemoryStream
        Dim encoderParameter As EncoderParameters = New EncoderParameters(1)
        encoderParameter.Param(0) = New System.Drawing.Imaging.EncoderParameter(System.Drawing.Imaging.Encoder.Quality, compression_level)
        Dim encoderInfo As ImageCodecInfo = SC_Utility.GetEncoderInfo("image/jpeg")
        Dim memoryStream As System.IO.MemoryStream = New System.IO.MemoryStream()
        image.Save(memoryStream, encoderInfo, encoderParameter)
        Return memoryStream
    End Function
#End Region
End Class

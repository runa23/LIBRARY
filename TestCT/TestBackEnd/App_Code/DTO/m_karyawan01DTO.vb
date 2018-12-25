Imports Microsoft.VisualBasic
Imports CT_BackEnd

<Serializable()> _
Public Class m_karyawan01DTO
    Inherits CT_DTOBase

    Public NIK As String
    Public NAMA As String
    Public JENIS_KELAMIN As String
    Public JABATAN As String
    Public TGL_LAHIR As Date
    Public JUM_ANAK As Integer
    Public GAPOK As Decimal
    Public TUN_TRANSPORT As Decimal
    Public FOTO As Byte()
    Public WARGA_NEGARA_ID As String
    Public WARGA_NEGARA As String
    Public KODE_PENDIDIKAN As String
    Public CREA_BY As String
    Public CREA_DATE As DateTime
    Public UPD_BY As String
    Public UPD_DATE As DateTime

End Class

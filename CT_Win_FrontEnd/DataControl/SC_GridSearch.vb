Imports System.ComponentModel

<ToolboxBitmap(GetType(Button))> _
Public Class SC_GridSearch
    Inherits System.Windows.Forms.UserControl

    Private _BindingSource As BindingSource

#Region "Property"
    <Category("SIMARC_Data_Binding")> _
    Public Property SC_BindingSource() As BindingSource
        Get
            Return _BindingSource
        End Get
        Set(ByVal value As BindingSource)
            _BindingSource = value
        End Set
    End Property
#End Region

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim loList As System.ComponentModel.IBindingList
        Dim loPropInfos As System.ComponentModel.PropertyDescriptorCollection
        Dim lcSort As String
        Dim lcValue As String
        Dim loValue As Object
        Dim loType As Type = Nothing
        Dim lnPos As Integer

        If SC_BindingSource Is Nothing Then
            MsgBox("property CT_BindingSource at " + Me.Name + " cannot empty")
            Return
        End If

        'Cari Sort by
        loList = CType(_BindingSource, System.ComponentModel.IBindingList)
        If loList.SortProperty IsNot Nothing Then
            lcSort = loList.SortProperty.Name
        Else
            MsgBox("Harap melakukan Sorting lebih dahulu")
            Return
        End If

        'cari sort by data type
        loPropInfos = _BindingSource.CurrencyManager.GetItemProperties()
        For Each loInfo As System.ComponentModel.PropertyDescriptor In loPropInfos
            If loInfo.Name.Trim.ToLower = lcSort.Trim.ToLower Then
                loType = loInfo.PropertyType
                Exit For
            End If
        Next

        'Dapatkan dan convert value yg dicari
        lcValue = txtSearch.Text.Trim
        Try
            loValue = SC_StringConverter.StringToTypedValue(lcValue, loType)
        Catch ex As Exception
            loValue = Nothing
        End Try
        If loValue Is Nothing Then
            MsgBox("Pencarian tidak mendukung tipe data " + loType.Name)
            Return
        End If

        'Find
        lnPos = -1
        lnPos = _BindingSource.Find(lcSort, loValue)
        If lnPos <> -1 Then
            _BindingSource.Position = lnPos
        Else
            MsgBox("Proses pencarian tidak menemukan data yang sesuai")
        End If

    End Sub
End Class

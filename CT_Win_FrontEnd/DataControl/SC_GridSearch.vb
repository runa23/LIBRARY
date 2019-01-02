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
        Search()
    End Sub

    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If SC_BindingSource Is Nothing Then
            MsgBox("property SC_BindingSource at " + Me.Name + " cannot empty")
            Exit Sub
        End If
        Select Case e.KeyCode
            Case Keys.Return
                Search()
            Case Keys.Up
                SC_BindingSource.MovePrevious()
            Case Keys.Down
                SC_BindingSource.MoveNext()
        End Select
    End Sub

    Private Sub Search()
        Dim loList As System.ComponentModel.IBindingList
        Dim loPropInfos As System.ComponentModel.PropertyDescriptorCollection
        Dim lcSort As String
        Dim lcValue As String
        Dim loValue As Object
        Dim loType As Type = Nothing

        If String.IsNullOrEmpty(txtSearch.Text.Trim) Then
            _BindingSource.RemoveFilter()
        End If

        If SC_BindingSource Is Nothing Then
            MsgBox("property CT_BindingSource at " + Me.Name + " cannot empty ")
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

        _BindingSource.RemoveFilter()
        _BindingSource.Filter = lcSort.ToString + "=._.='" + lcValue.ToString + "'"
    End Sub
End Class

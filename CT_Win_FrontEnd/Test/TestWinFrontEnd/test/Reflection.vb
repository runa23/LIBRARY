
Public Class Reflection

    Private Sub btnFields_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnFields.Click
        Dim lotype As Type
        Dim loPropInfos As System.Reflection.PropertyInfo()
        Dim loObject As New lkCustomer()


        lotype = loObject.GetType()

        loPropInfos = lotype.GetProperties()


        For Each loInfo As System.Reflection.PropertyInfo In loPropInfos
            Me.ListBox1.Items.Add("prop - " + loInfo.Name)
        Next
    End Sub
End Class
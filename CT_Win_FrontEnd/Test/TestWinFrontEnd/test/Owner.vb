Public Class Owner

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim loChild1 As New Child1()
        loChild1.Show(Me)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim loChild2 As New Child2()
        loChild2.Show(Me)
    End Sub
End Class
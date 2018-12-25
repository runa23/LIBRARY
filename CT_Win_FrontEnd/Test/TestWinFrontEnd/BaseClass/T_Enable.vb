Public Class T_Enable

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEAdd.Click
        Me.R_Conductor1._SetCol_Add(True)
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDAdd.Click
        Me.R_Conductor1._SetCol_Add(False)
    End Sub

    Private Sub btnEEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEEdit.Click
        Me.R_Conductor1._SetCol_Edit(True)
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.R_Conductor1._SetCol_Edit(False)
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Me.R_Conductor1._SetCol_Other(True)
    End Sub

    Private Sub btnDEdit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDEdit.Click
        Me.R_Conductor1._SetCol_Other(False)
    End Sub

    Private Sub btnEData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEData.Click
        Me.R_Conductor1._SetCol_Hasdata(True)
    End Sub

    Private Sub btnDData_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDData.Click
        Me.R_Conductor1._SetCol_Hasdata(False)
    End Sub

    Private Sub btnEFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEFind.Click
        Me.R_Conductor1._SetCol_Find(True)
    End Sub

    Private Sub btnDFind_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDFind.Click
        Me.R_Conductor1._SetCol_Find(False)
    End Sub
End Class
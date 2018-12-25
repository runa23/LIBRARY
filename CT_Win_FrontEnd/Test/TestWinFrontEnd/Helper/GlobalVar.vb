Imports R_Win_FrontEnd
Public Class GlobalVar

    Private Sub btnSet_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSet.Click
        Dim loInitiator As _IInitiator = New _Initiator()

        loInitiator.Set_UserId("Gunawan")
    End Sub

    Private Sub btnDisplay_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDisplay.Click
        MsgBox(R_GlobalVar.UserId)
    End Sub
End Class
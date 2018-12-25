Imports R_Win_FrontEnd
Public Class GridSearch

    Private Sub GridSearch_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim loClient As New GridSearchService()
        Dim loRtn As List(Of lkGridSearch)

        loRtn = loClient.getSample()

        Me.BindingSource1.DataSource = New R_BindingListView(Of lkGridSearch)(loRtn)
    End Sub

    
End Class
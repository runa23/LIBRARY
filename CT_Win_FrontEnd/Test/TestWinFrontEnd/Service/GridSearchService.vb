Public Class GridSearchService
    Public Function getSample() As List(Of lkGridSearch)
        Dim loRtn As New List(Of lkGridSearch)()

        loRtn.Add(New lkGridSearch("01", Now, 1, 1.5))
        loRtn.Add(New lkGridSearch("02", Now, 2, 2.5))
        loRtn.Add(New lkGridSearch("03", Nothing, 3, 3.5))
        loRtn.Add(New lkGridSearch("04", Nothing, 4, 4.5))


        Return loRtn
    End Function
End Class

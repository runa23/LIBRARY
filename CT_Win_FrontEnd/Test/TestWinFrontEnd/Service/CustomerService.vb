Public Class CustomerService
    Public Function GetCustomerLookUp() As List(Of lkCustomer)
        Dim lortn As New List(Of lkCustomer)()
        lortn.Add(New lkCustomer("C01", "Customer01", "L"))
        lortn.Add(New lkCustomer("C02", "Customer02", "L"))
        lortn.Add(New lkCustomer("C03", Nothing, "P"))
        lortn.Add(New lkCustomer("C04", Nothing, "P"))
        Return lortn
    End Function

End Class

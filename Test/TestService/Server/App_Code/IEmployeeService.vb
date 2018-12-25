Imports System.ServiceModel
Imports R_BackEnd

<ServiceContract()> _
Public Interface IEmployeeService
    Inherits R_IServicebase(Of EmployeeDTO)

End Interface

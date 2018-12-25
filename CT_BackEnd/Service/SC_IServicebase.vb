Imports System.ServiceModel
Imports SC_Common

<ServiceContract()> _
Public Interface SC_IServicebase(Of E As SC_DTOBase)
    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function Svc_SC_GetRecord(ByVal poEntity As E, ByVal poCRUDMode As eCRUDMode) As E
    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Function Svc_SC_Save(ByVal poEntity As E, ByVal poCRUDMode As eCRUDMode) As E
    <OperationContract()> _
    <FaultContract(GetType(SC_ServiceExceptions))> _
    Sub Svc_SC_Delete(ByVal poEntity As E)
End Interface

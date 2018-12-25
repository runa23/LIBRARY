Imports System.ServiceModel
Imports System.Collections.Generic
Imports CT_BackEnd
Imports CT_Common

' NOTE: If you change the class name "ICTM0100Svc" here, you must also update the reference to "ICTM0100Svc" in Web.config.
<ServiceContract()> _
Public Interface ICTM0100Svc
    Inherits CT_IServicebase(Of m_karyawan01DTO)

    <OperationContract()> _
    <FaultContract(GetType(CT_ServiceExceptions))> _
    Function GetList() As List(Of m_karyawan02DTO)

    <OperationContract()> _
    <FaultContract(GetType(CT_ServiceExceptions))> _
    Function GetLKm_warga_negara(ByVal poEntity As LKm_warga_negaraDTO) As List(Of LKm_warga_negaraDTO)

    <OperationContract()> _
    <FaultContract(GetType(CT_ServiceExceptions))> _
    Function GetLKm_jabatan() As List(Of LKm_jabatanDTO)

    <OperationContract()> _
    <FaultContract(GetType(CT_ServiceExceptions))> _
    Function GetLKm_pendidikan() As List(Of LKm_pendidikanDTO)

    <OperationContract()> _
    <FaultContract(GetType(CT_ServiceExceptions))> _
    Function GetRole() As List(Of RoleDTO)

End Interface

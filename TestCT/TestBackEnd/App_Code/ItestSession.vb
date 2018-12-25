Imports System.ServiceModel

' NOTE: If you change the class name "ItestSession" here, you must also update the reference to "ItestSession" in Web.config.
<ServiceContract()> _
Public Interface ItestSession

    <OperationContract()> _
    Sub DoWork()

    <OperationContract()> _
    Function Counter() As Integer

End Interface

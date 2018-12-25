' NOTE: If you change the class name "testSession" here, you must also update the reference to "testSession" in Web.config and in the associated .svc file.
<ServiceBehaviorAttribute(InstanceContextMode:=InstanceContextMode.PerSession)> _
Public Class testSession
    Implements ItestSession


    Public Sub DoWork() Implements ItestSession.DoWork

    End Sub

    Public Function Counter() As Integer Implements ItestSession.Counter
        Dim lnCounter As Integer
        lnCounter = lnCounter + 1

        Return lnCounter
    End Function
End Class

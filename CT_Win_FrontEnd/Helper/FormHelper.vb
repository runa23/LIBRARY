Imports System.Runtime.InteropServices

Public Class FormHelper
    <DllImport("user32", EntryPoint:="LockWindowUpdate", ExactSpelling:=True, _
CharSet:=CharSet.Ansi, SetLastError:=True)> _
Public Shared Function NativeLockWindowUpdate(ByVal hWnd As Integer) As Integer
    End Function
End Class

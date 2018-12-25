Imports System.Reflection
Imports System.IO

Public Class MDIMenu

    Private Function DynamicallyLoadedObject(ByVal objectName As String, Optional ByVal args() As Object = Nothing) As Form
        Dim loAsm As Assembly
        Dim lcPath As String
        Dim loType As Type
        Dim returnObj As Object = Nothing

        Dim lcNameSpace As String = Me.GetType().Namespace()

        loType = Assembly.GetExecutingAssembly().GetType(lcNameSpace.Trim + "." + objectName)


        lcPath = My.Application.Info.DirectoryPath + "\" + objectName.Trim + ".dll"
        
        If File.Exists(lcPath) Then
            loAsm = Assembly.LoadFrom(lcPath)
            loType = loAsm.GetType(objectName.Trim + "." + objectName.Trim, False, True)
            If loType Is Nothing Then
                Throw New Exception("Type " + objectName.Trim + "." + objectName.Trim + " - not found")
            End If

        Else
            Throw New Exception(lcPath.Trim + " - not found")
        End If

        returnObj = Activator.CreateInstance(loType, args)

        Return returnObj
    End Function

    Private Sub CT_Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CT_Button1.Click
        Dim loForm As Form

        Try
            loForm = DynamicallyLoadedObject("CTM0100")
        Catch ex As Exception
            Return
        End Try
        loForm.Show()
    End Sub
End Class

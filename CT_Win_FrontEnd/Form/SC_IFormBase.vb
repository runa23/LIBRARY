Public Interface SC_IFormBase
    Sub _InitFromMaster(ByVal poParameter As Object, ByVal peFormModel As SC_eFormModel, ByVal poButton As Object)
    Sub _ReturnFromDetail(ByVal poOwnedForm As Form, ByVal pcButtonName As String)
    Function getFormModel() As SC_eFormModel
    Function getActionButton() As Object
End Interface
Public Enum SC_eFormModel
    Detail = 0
    Find = 2
    LookUp = 1
End Enum

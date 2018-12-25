Imports System.Configuration
Imports SC_Common
Imports System.Data.Common
Imports System.Data.Linq

Public Class SC_Db

#Region "Variable"
    Private Const COMMAND_TIMEOUT As Int16 = 300
#End Region


#Region "Method"
    Public Function GetConnection(Optional ByVal pcProvider As String = "", Optional ByVal pcConnectionString As String = "") As DbConnection
        Dim SCException As SC_Exception = New SC_Exception()
        Dim dbConnection As System.Data.Common.DbConnection = Nothing
        Try
            Dim str As String = Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcConnectionString.Trim(), "", True) = 0, Me.GetConnectionString(), pcConnectionString.Trim()))
            Dim str1 As String = Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcProvider.Trim(), "", True) = 0, Me.GetProvider(), pcProvider.Trim()))
            dbConnection = DbProviderFactories.GetFactory(str1).CreateConnection()
            dbConnection.ConnectionString = str
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        Return dbConnection
    End Function
    Public Function GetCommand(Optional ByVal pcProvider As String = "") As DbCommand
        Dim SCException As SC_Exception = New SC_Exception()
        Dim dbCommand As System.Data.Common.DbCommand = Nothing
        Try
            Dim str As String = Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcProvider.Trim(), "", True) = 0, Me.GetProvider(), pcProvider.Trim()))
            dbCommand = DbProviderFactories.GetFactory(str).CreateCommand()
            dbCommand.CommandTimeout = 300
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        Return dbCommand
    End Function
    Public Function GetParameter(Optional ByVal pcProvider As String = "") As DbParameter
        Dim SCException As SC_Exception = New SC_Exception()
        Dim dbParameter As System.Data.Common.DbParameter = Nothing
        Try
            Dim str As String = Conversions.ToString(Interaction.IIf(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(pcProvider.Trim(), "", True) = 0, Me.GetProvider(), pcProvider.Trim()))
            dbParameter = DbProviderFactories.GetFactory(str).CreateParameter()
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        Return dbParameter
    End Function

#Region "SQLExec Method"
    Public Function SqlExecQuery(ByVal pcStatement As String, Optional ByVal poDbConnection As DbConnection = Nothing, Optional ByVal plAutoCloseConnection As Boolean = True) As DataTable
        Dim dbConnection As System.Data.Common.DbConnection
        Dim SCException As SC_Exception = New SC_Exception()
        Dim dataTable As System.Data.DataTable = Nothing
        Try
            dbConnection = If(poDbConnection IsNot Nothing, poDbConnection, Me.GetConnection("", ""))
            Dim dbCommand As System.Data.Common.DbCommand = dbConnection.CreateCommand()
            dbCommand.CommandText = pcStatement
            dataTable = Me.SqlExecQuery(dbConnection, dbCommand, plAutoCloseConnection)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        Return dataTable
    End Function
    Public Function SqlExecQuery(ByVal poDbConnection As DbConnection, ByVal poDbCommand As DbCommand, Optional ByVal plAutoCloseConnection As Boolean = False) As DataTable
        Dim SCException As SC_Exception = New SC_Exception()
        Dim dataTable As System.Data.DataTable = New System.Data.DataTable()
        Dim dbDataReaders As DbDataReader = Nothing
        Try
            Try
                poDbCommand.Connection = poDbConnection
                poDbCommand.CommandTimeout = 300
                If (poDbConnection.State <> ConnectionState.Open) Then
                    poDbConnection.Open()
                End If
                dbDataReaders = poDbCommand.ExecuteReader()
                dataTable.Load(dbDataReaders, LoadOption.OverwriteChanges)
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                SCException.Add(exception)
                SCException.ErrorList(SCException.ErrorList.Count - 1).ErrorDetails.Add(New SC_ErrorDetail("02", String.Concat("Sql Command=", poDbCommand.CommandText)))
                ProjectData.ClearProjectError()
            End Try
        Finally
            If (If(dbDataReaders Is Nothing OrElse dbDataReaders.IsClosed, False, True)) Then
                dbDataReaders.Close()
            End If
            If (If(Not plAutoCloseConnection OrElse poDbConnection Is Nothing OrElse poDbConnection.State = ConnectionState.Closed, False, True)) Then
                poDbConnection.Close()
            End If
        End Try
        SCException.ThrowExceptionIfErrors()
        Return dataTable
    End Function

    Public Function SqlExecNonQuery(ByVal pcStatement As String, Optional ByVal poDbConnection As DbConnection = Nothing, Optional ByVal plAutoCloseConnection As Boolean = True) As Integer
        Dim dbConnection As System.Data.Common.DbConnection
        Dim num As Integer = 0
        Dim SCException As SC_Exception = New SC_Exception()
        Try
            dbConnection = If(poDbConnection IsNot Nothing, poDbConnection, Me.GetConnection("", ""))
            Dim dbCommand As System.Data.Common.DbCommand = dbConnection.CreateCommand()
            dbCommand.CommandText = pcStatement
            dbCommand.CommandTimeout = 300
            num = Me.SqlExecNonQuery(dbConnection, dbCommand, plAutoCloseConnection)
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            SCException.Add(exception)
            ProjectData.ClearProjectError()
        End Try
        SCException.ThrowExceptionIfErrors()
        Return num
    End Function
    Public Function SqlExecNonQuery(ByVal poDbConnection As DbConnection, ByVal poDbCommand As DbCommand, Optional ByVal plAutoCloseConnection As Boolean = False) As Integer
        Dim num As Integer = 0
        Dim SCException As SC_Exception = New SC_Exception()
        Try
            Try
                poDbCommand.Connection = poDbConnection
                poDbCommand.CommandTimeout = 300
                If (poDbConnection.State <> ConnectionState.Open) Then
                    poDbConnection.Open()
                End If
                num = poDbCommand.ExecuteNonQuery()
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                SCException.Add(exception)
                SCException.ErrorList(SCException.ErrorList.Count - 1).ErrorDetails.Add(New SC_ErrorDetail("02", String.Concat("Sql Command=", poDbCommand.CommandText)))
                ProjectData.ClearProjectError()
            End Try
        Finally
            If (If(Not plAutoCloseConnection OrElse poDbConnection Is Nothing OrElse poDbConnection.State = ConnectionState.Closed, False, True)) Then
                poDbConnection.Close()
            End If
        End Try
        SCException.ThrowExceptionIfErrors()
        Return num
    End Function

    Public Function SQLExecObjectQuery(Of E)(ByVal pcStatement As String, ByVal poDbConnection As DbConnection, ByVal plAutoCloseConnection As Boolean, ByVal ParamArray poParams() As Object) As List(Of E)
        Dim list As List(Of E) = Nothing
        Dim SCException As SC_Exception = New SC_Exception()
        Try
            Try
                If (poDbConnection.State <> ConnectionState.Open) Then
                    poDbConnection.Open()
                End If
                Dim dataContext As System.Data.Linq.DataContext = New System.Data.Linq.DataContext(poDbConnection) With
                {
                    .CommandTimeout = 300
                }
                list = dataContext.ExecuteQuery(Of E)(pcStatement, poParams).ToList()
            Catch exception As System.Exception
                ProjectData.SetProjectError(exception)
                SCException.Add(exception)
                SCException.ErrorList(SCException.ErrorList.Count - 1).ErrorDetails.Add(New SC_ErrorDetail("02", String.Concat("Sql Command=", pcStatement)))
                ProjectData.ClearProjectError()
            End Try
        Finally
            If (If(Not plAutoCloseConnection OrElse poDbConnection Is Nothing OrElse poDbConnection.State = ConnectionState.Closed, False, True)) Then
                poDbConnection.Close()
            End If
        End Try
        SCException.ThrowExceptionIfErrors()
        Return list
    End Function

#End Region

#Region "Error Method"
    Public Function GetErrorDb(ByVal pnDbErrNo As Integer, Optional ByVal pcDbErrDtNo As String = "", Optional ByVal pcPrefix As String = "", Optional ByVal pcSufix As String = "") As SC_Error
        Dim cTError As SC_Error
        Dim str As String = pnDbErrNo.ToString("000")
        Dim str1 As String = " Error Description not found "
        Dim str2 As String = " Error Detail Description not found "
        Try
            Dim str3 As String = String.Concat("Select ErrDescp from ssmErr Where ErrNo='", str, "'")
            Dim dataTable As System.Data.DataTable = Me.SqlExecQuery(str3, Nothing, True)
            If (dataTable.Rows.Count > 0) Then
                str1 = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(String.Concat(pcPrefix.Trim(), " "), dataTable.Rows(0)("ErrDescp")), " "), pcSufix.Trim()))
            End If
            cTError = New SC_Error(str, str1)
            If (Not String.IsNullOrEmpty(pcDbErrDtNo)) Then
                str3 = String.Concat("Select ErrDescp from ssmErrDt Where ErrNo='", pcDbErrDtNo, "'")
                dataTable = Me.SqlExecQuery(str3, Nothing, True)
                If (dataTable.Rows.Count > 0) Then
                    str2 = Conversions.ToString(dataTable.Rows(0)("ErrDescp"))
                End If
                cTError.ErrorDetails.Add(New SC_ErrorDetail(pcDbErrDtNo, str2))
            End If
        Catch exception As System.Exception
            ProjectData.SetProjectError(exception)
            str1 = String.Concat("Exception Error: ", exception.Message)
            cTError = New SC_Error(str, str1)
            ProjectData.ClearProjectError()
        End Try
        Return cTError
    End Function
#End Region

#End Region



#Region "Helper"

#End Region
    Private Function GetConnectionString() As String
        Return ConfigurationManager.ConnectionStrings("SC_ConnectionString").ConnectionString()
    End Function
    Private Function GetProvider() As String
        Return ConfigurationManager.ConnectionStrings("SC_ConnectionString").ProviderName()
    End Function
End Class

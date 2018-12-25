Imports NECSAP.SPID
Imports R_NECHelper
Public Class Form1
    Dim _finger As R_Finger

    Private Sub btnScanAndGetByte_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnScanAndGetByte.Click
        Dim loTenPrint As TenPrint
        Dim lnRtn As Integer
        Dim lcTempDir As String = My.Application.Info.DirectoryPath + "\TempDir"
        Dim lcTempId As String = "TempId"

        Try
            ''prepare directory
            'If My.Computer.FileSystem.DirectoryExists(lcTempDir) = True Then
            '    My.Computer.FileSystem.DeleteDirectory(lcTempDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
            'End If
            'My.Computer.FileSystem.CreateDirectory(lcTempDir)

            ''init TenPrint
            'loTenPrint = New TenPrint()
            'lnRtn = loTenPrint.SPID_TenPrintInit(TENPRINT_DEVICE.TENPRINT_DEVICE_CROSSMATCH_LSCAN, True)
            'If lnRtn <> 0 Then
            '    Throw New Exception("Initialize fail")
            'End If

            ''Get TenPrint
            'lnRtn = loTenPrint.NET_SPID_TenPrint_CaptureSC(lcTempId, "", lcTempDir, "19900101", IntPtr.Zero)
            'If lnRtn <> 0 Then
            '    Throw New Exception("Ten print Scan Fail")
            'End If

            'Get Finger Object
            _finger = R_SPIDHelper.GetFingerFromDirectory(lcTempId, lcTempDir)


        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Try
                If loTenPrint IsNot Nothing Then
                    loTenPrint.SPID_TenPrintExit()
                    loTenPrint = Nothing
                End If
            Catch exc As Exception
            End Try
        End Try
    End Sub

    Private Sub btnEnroll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnEnroll.Click
        Try
            R_FPEngineHelper.EnrollWSQFinger(Me.txtId.Text.Trim.PadLeft(16, "0"), _finger)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click
        Dim loHits As List(Of R_Hit)
        Dim loSearch As R_Search

        Try
            loSearch.MinF1 = R_SPIDHelper.GetSearchFingerByPosition(_finger.pos1, _finger)
            loSearch.MinF2 = R_SPIDHelper.GetSearchFingerByPosition(_finger.pos2, _finger)
            loSearch.MinF3 = R_SPIDHelper.GetSearchFingerByPosition(_finger.pos3, _finger)
            loSearch.MinF4 = R_SPIDHelper.GetSearchFingerByPosition(_finger.pos4, _finger)

            loHits = R_FPEngineHelper.SearchFinger(loSearch)

            lstSearch.Items.Clear()
            For Each loHit As R_Hit In loHits
                lstSearch.Items.Add(loHit.Id + " Score=" + loHit.score.ToString("0000"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub


    Private Sub btnSearch2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch2.Click
        Dim loTenPrint As TenPrint
        Dim lnRtn As Integer
        Dim lcTempDir As String = My.Application.Info.DirectoryPath + "\TempDir"
        Dim lcTempId As String = "TempId"
        Dim loHits As List(Of R_Hit)
        Dim loFinger As R_Finger
        Dim loSearch As R_Search

        Try
            'prepare directory
            'If My.Computer.FileSystem.DirectoryExists(lcTempDir) = True Then
            '    My.Computer.FileSystem.DeleteDirectory(lcTempDir, FileIO.DeleteDirectoryOption.DeleteAllContents)
            'End If
            'My.Computer.FileSystem.CreateDirectory(lcTempDir)

            ''init TenPrint
            'loTenPrint = New TenPrint()
            'lnRtn = loTenPrint.SPID_TenPrintInit(TENPRINT_DEVICE.TENPRINT_DEVICE_CROSSMATCH_LSCAN, True)
            'If lnRtn <> 0 Then
            '    Throw New Exception("Initialize fail")
            'End If

            ''Set Skip Info
            'loTenPrint.NET_SPID_TenPrint_SetParameterInt(TENPRINT_PARAMETER_NAME.PARA_TECAPTURE_SKIP_INFO, _
            '    TENPRINT_CAPTURE_SKIP.SKIP_R_THUMB Or TENPRINT_CAPTURE_SKIP.SKIP_L_THUMB Or _
            '    TENPRINT_CAPTURE_SKIP.SKIP_L_INDEX Or TENPRINT_CAPTURE_SKIP.SKIP_L_MIDDLE Or _
            '    TENPRINT_CAPTURE_SKIP.SKIP_L_RING Or TENPRINT_CAPTURE_SKIP.SKIP_L_LITTLE)

            ''Get TenPrint
            'lnRtn = loTenPrint.NET_SPID_TenPrint_CaptureSC(lcTempId, "", lcTempDir, "19900101", IntPtr.Zero)
            'If lnRtn <> 0 Then
            '    Throw New Exception("Ten print Scan Fail")
            'End If

            'Get Finger Object
            loFinger = R_SPIDHelper.GetFingerFromDirectory(lcTempId, lcTempDir)

            'Init Search object
            loSearch.MinF1 = R_SPIDHelper.GetSearchFingerByPosition(loFinger.pos1, loFinger)
            loSearch.MinF2 = R_SPIDHelper.GetSearchFingerByPosition(loFinger.pos2, loFinger)
            loSearch.MinF3 = R_SPIDHelper.GetSearchFingerByPosition(loFinger.pos3, loFinger)
            loSearch.MinF4 = R_SPIDHelper.GetSearchFingerByPosition(loFinger.pos4, loFinger)

            loHits = R_FPEngineHelper.SearchFinger(loSearch)

            lstSearch.Items.Clear()
            For Each loHit As R_Hit In loHits
                lstSearch.Items.Add(loHit.Id + " Score=" + loHit.score.ToString("0000"))
            Next

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally
            Try
                If loTenPrint IsNot Nothing Then
                    loTenPrint.SPID_TenPrintExit()
                    loTenPrint = Nothing
                End If
            Catch exc As Exception
            End Try
        End Try
    End Sub

    Private Sub btnDelete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDelete.Click
        R_FPEngineHelper.DeleteFinger(Me.txtId.Text.Trim.PadLeft(17, "0"))
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim ldDate As Nullable(Of DateTime)

        ldDate = Now

        If ldDate Is Nothing Then
            MsgBox("null")
        Else
            MsgBox("ada")
        End If
    End Sub
End Class
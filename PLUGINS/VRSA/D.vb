Imports System.Runtime.InteropServices

Public Class D

    Public Declare Auto Function ShowWindow Lib "user32.dll" (hwnd As IntPtr, nCmdShow As Integer) As Boolean
    Public Declare Auto Function FindWindowEx Lib "user32.dll" (parentHandle As IntPtr, childAfter As IntPtr, lclassName As String, windowTitle As String) As IntPtr
    Public Declare Auto Function FindWindow Lib "user32.dll" (lpClassName As String, lpWindowName As String) As IntPtr
    <DllImport("user32.dll")>
    Public Shared Function EndTask(ByVal handle As IntPtr, ByVal n As Boolean, ByVal j As Boolean) As Boolean

    End Function

    Public Shared Sub Hide_TaskBar(ByVal i As Integer)
        ShowWindow(FindWindow("Shell_TrayWnd", Nothing), i)
    End Sub


    <DllImport("user32.dll")>
    Public Shared Function SetParent(ByVal hWndChild As IntPtr, ByVal hWndNewParent As IntPtr) As IntPtr
    End Function
    Public Shared Sub HSDesktopIcons(ByVal l As Boolean)
        If l = True Then

            Dim handle As IntPtr
            Dim progManager As IntPtr = FindWindow("Progman", Nothing)

            'If (progManager) ??

            Dim desktop As IntPtr = FindWindowEx(progManager, IntPtr.Zero, "SHELLDLL_DefView", Nothing)

            'If (desktop) ??
            handle = FindWindowEx(desktop, IntPtr.Zero, "SysListView32", Nothing)

            ShowWindow(handle, 5)


        Else



            Dim handle As IntPtr
            Dim progManager As IntPtr = FindWindow("Progman", Nothing)

            'If (progManager) ??

            Dim desktop As IntPtr = FindWindowEx(progManager, IntPtr.Zero, "SHELLDLL_DefView", Nothing)

            'If (desktop) ??
            handle = FindWindowEx(desktop, IntPtr.Zero, "SysListView32", Nothing)


            ShowWindow(handle, 0)
        End If
    End Sub

End Class

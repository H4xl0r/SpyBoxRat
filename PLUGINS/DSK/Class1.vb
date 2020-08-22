Imports System.Net.Sockets
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class MainCL
    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")

        If h(1) = "|HTB|" Then

            Await Task.Run(Sub() Hide_TaskBar(0))

        ElseIf h(1) = "|STB|" Then

            Await Task.Run(Sub() Hide_TaskBar(1))

        ElseIf h(1) = "|HATB|" Then

            Await Task.Run(Sub() Hide_Applications_TaskBar(0))


        ElseIf h(1) = "|SATB|" Then

            Await Task.Run(Sub() Hide_Applications_TaskBar(1))

        ElseIf h(1) = "|SWAPON|" Then

            Await Task.Run(Sub() SwapMB(True))

        ElseIf h(1) = "|SWAPOFF|" Then

            Await Task.Run(Sub() SwapMB(False))

        ElseIf h(1) = "|HDI|" Then

            HSDesktopIcons(False)

        ElseIf h(1) = "|SDI|" Then

            HSDesktopIcons(True)



        ElseIf h(1) = "|HSI|" Then

            HSStartIcon(False)


        ElseIf h(1) = "|SSI|" Then

            HSStartIcon(True)

        End If

    End Sub
    Public Shared Sub Hide_Applications_TaskBar(ByVal i As Integer)
        Dim value As Integer = CInt(FindWindow("Shell_TrayWnd", Nothing))
        Dim value2 As Integer = CInt(FindWindowEx(CType(value, IntPtr), IntPtr.Zero, "ReBarWindow32", Nothing))
        ShowWindow(CType(value2, IntPtr), i)
    End Sub
    Public Shared Sub Hide_TaskBar(ByVal i As Integer)
        ShowWindow(FindWindow("Shell_TrayWnd", Nothing), i)
    End Sub

    Public Shared Sub SwapMB(ByVal B As Boolean)
        SwapMouseButton(B)
    End Sub
    Public Declare Auto Function ShowWindow Lib "user32.dll" (hwnd As IntPtr, nCmdShow As Integer) As Boolean
    Public Declare Auto Function FindWindowEx Lib "user32.dll" (parentHandle As IntPtr, childAfter As IntPtr, lclassName As String, windowTitle As String) As IntPtr
    Public Declare Auto Function FindWindow Lib "user32.dll" (lpClassName As String, lpWindowName As String) As IntPtr
    Public Declare Function SwapMouseButton Lib "user32.dll" (Swap As Boolean) As Boolean






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

    Public Shared Sub HSStartIcon(ByVal l As Boolean)
        If l = True Then

            Dim progManager As IntPtr = FindWindow("Shell_TrayWnd", Nothing)

            'If (progManager) ??

            Dim desktop As IntPtr = FindWindowEx(progManager, IntPtr.Zero, "Start", Nothing)

            ShowWindow(desktop, 5)
        Else
            Dim progManager As IntPtr = FindWindow("Shell_TrayWnd", Nothing)

            'If (progManager) ??

            Dim desktop As IntPtr = FindWindowEx(progManager, IntPtr.Zero, "Start", Nothing)

            'If (desktop) ??
            'handle = FindWindowEx(desktop, IntPtr.Zero, "SysListView32", Nothing)


            ShowWindow(desktop, 0)

        End If


    End Sub

End Class

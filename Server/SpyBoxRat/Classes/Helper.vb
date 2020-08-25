Imports System.Text

Public Class Helper
    ''CURRENTLY NOT WORKING !!!!!
    Public Shared Async Sub GetFile(ByVal Info As String)


        Dim Splitter As String() = Split(Info, "|DW|")
        Dim o As Byte() = Await Task.Run(Function() Encoding.Default.GetBytes(Splitter(0)))


        IO.File.WriteAllBytes(Splitter(1), o)

    End Sub



    Public Shared Async Function ConvertTB64ASYNC(ByVal o As String) As Task(Of String)

        Dim hj As Byte() = Await Task.Run(Function() IO.File.ReadAllBytes(o))
        Dim iaz As String = Await Task.Run(Function() Convert.ToBase64String(hj))
        Return iaz
    End Function

End Class

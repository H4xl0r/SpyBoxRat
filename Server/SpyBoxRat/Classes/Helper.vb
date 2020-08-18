Imports System.Text

Public Class Helper
    ''CURRENTLY NOT WORKING !!!!!
    Public Shared Async Sub GetFile(ByVal Info As String)


        Dim Splitter As String() = Split(Info, "|DW|")
        Dim o As Byte() = Await Task.Run(Function() Encoding.Default.GetBytes(Splitter(0)))


        IO.File.WriteAllBytes(Splitter(1), o)

    End Sub

End Class

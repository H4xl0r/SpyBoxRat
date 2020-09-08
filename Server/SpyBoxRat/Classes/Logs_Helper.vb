Public Class Logs_Helper
    Public Shared Sub Log(ByVal L As AeroListView, ByVal LOG As String)
        Dim LG As String() = Split(LOG, "||")

        Dim I As New ListViewItem(LG(0))
        I.SubItems.Add(LG(1))

        L.Items.Add(I)
    End Sub
End Class

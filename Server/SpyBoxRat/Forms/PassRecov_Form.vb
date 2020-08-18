Imports System.IO

Public Class PassRecov_Form
    Private Sub PW_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub UcBtnExt1_BtnClick(sender As Object, e As EventArgs) Handles UcBtnExt1.BtnClick
        If SaveFileDialog1.ShowDialog = DialogResult.OK Then
            Using h As New StreamWriter(SaveFileDialog1.FileName)
                For Each i As ListViewItem In ListView1.Items
                    h.WriteLine("Url: " & i.Text & vbNewLine & "Username: " & i.SubItems(1).Text & vbNewLine & "Password: " & i.SubItems(2).Text & vbNewLine & "Browser: " & i.SubItems(3).Text & vbNewLine)
                Next
            End Using
        End If
    End Sub
End Class
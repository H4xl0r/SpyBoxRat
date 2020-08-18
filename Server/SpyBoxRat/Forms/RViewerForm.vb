Public Class RViewerForm
    Private Sub RViewerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Async Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim o As String = "1800" & "|TRDV|"

        Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
        Me.Close()

    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg > 0
            Case m.Msg = &H10

                Dim o As String = "1800" & "|TRDV|"
                Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
        End Select
        MyBase.WndProc(m)
    End Sub


End Class
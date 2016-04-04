Imports System.Runtime.InteropServices

Module Module1
    Public Const WM_NCLBUTTONDOWN As Integer = &HA1
    Public Const HT_CAPTION As Integer = &H2

    <DllImport("user32.dll")>
    Public Function SetWindowText(ByVal hwnd As IntPtr, ByVal windowName As String) As Boolean
    End Function

    <DllImportAttribute("user32.dll")>
    Public Function SendMessage(hWnd As IntPtr, Msg As Integer, wParam As Integer, lParam As Integer) As Integer
    End Function
    <DllImportAttribute("user32.dll")>
    Public Function ReleaseCapture() As Boolean
    End Function
End Module

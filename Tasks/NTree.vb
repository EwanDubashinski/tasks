
Public Class NTree : Inherits TreeView

    Private Declare Unicode Function SetWindowTheme Lib "uxtheme.dll" (hWnd As IntPtr, pszSubAppName As String, pszSubIdList As String) As Integer

    Protected Overrides Sub CreateHandle()
        MyBase.CreateHandle()
        SetWindowTheme(Handle, "Explorer", Nothing)
    End Sub

End Class
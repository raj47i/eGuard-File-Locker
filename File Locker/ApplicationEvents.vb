Namespace My

    ' The following events are availble for MyApplication:
    ' 
    ' Startup: Raised when the application starts, before the startup form is created.
    ' Shutdown: Raised after all application forms are closed.  This event is not raised if the application terminates abnormally.
    ' UnhandledException: Raised if the application encounters an unhandled exception.
    ' StartupNextInstance: Raised when launching a single-instance application and the application is already active. 
    ' NetworkAvailabilityChanged: Raised when the network connection is connected or disconnected.
    Partial Friend Class MyApplication
        Public Passwd As String

        Private Sub MyApplication_Startup(ByVal sender As Object, ByVal e As Microsoft.VisualBasic.ApplicationServices.StartupEventArgs) Handles Me.Startup
            Dim RegKey As Microsoft.Win32.RegistryKey = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE\eGUARD\FileLocker", True)
            If RegKey Is Nothing Then
                RegKey = Microsoft.Win32.Registry.LocalMachine.CreateSubKey("SOFTWARE\eGUARD\FileLocker", Microsoft.Win32.RegistryKeyPermissionCheck.ReadWriteSubTree)
                RegKey.SetValue("Passwd", "DEFAULT")
                MsgBox("Thank you for choosing File Locker.." & vbCrLf & "Your current Password is [DEFAULT].", MsgBoxStyle.Information)
            End If
            Passwd = RegKey.GetValue("Passwd", "", Microsoft.Win32.RegistryValueOptions.None)
            RegKey.Close()
        End Sub


    End Class

End Namespace


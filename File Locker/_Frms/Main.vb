Public Class Main

    Private Const _Password As String = "#12c&n78F_40s*-[{]};:,<?.>,+-/BABY"
    Private Const _LockerZIP As String = "C:\Locker.fl"
    Private _LockerDIR As String = My.Application.Info.DirectoryPath & "\Locker\"
    Private _ClosedState As New System.Uri(My.Application.Info.DirectoryPath & "\DefPage.swf")

#Region "Simple Button Actions...."

    Private Sub cmdShutDown_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdShutDown.Click
        Me.Close()
    End Sub

    Private Sub cmdSettings_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSettings.Click
        My.Forms.Passwd.ShowDialog()
    End Sub

    Private Sub cmdAbout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAbout.Click
        My.Forms.About.ShowDialog()
    End Sub

    Private Sub Set_Open_Close(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenLocker.TextChanged
        If BtnOpenLocker.Text = "Open Locker" Then
            BtnADD.Enabled = False
        Else
            BtnADD.Enabled = True
        End If
    End Sub
    Private Sub BtnOpenLocker_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnOpenLocker.Click
        Try
            If BtnOpenLocker.Text = "Open Locker" Then
                Open_Locker()
                Folder.Navigate(New System.Uri(_LockerDIR))
                BtnOpenLocker.Text = "Close Locker"
            Else
                Close_Locker()
                Folder.Navigate(_ClosedState)
                BtnOpenLocker.Text = "Open Locker"
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Folder.Navigate(_ClosedState)
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Help.ShowHelp(Me.Folder, My.Application.Info.DirectoryPath & "\Manual.CHM", HelpNavigator.TableOfContents)
    End Sub

    Private Sub BtnADD_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnADD.Click
        Dim fod As New OpenFileDialog
        fod.CheckFileExists = True
        fod.CheckPathExists = True
        fod.Filter = "All Files (*.*)|*.*"
        fod.Multiselect = False
        fod.ValidateNames = True
        fod.Title = "Select Files to Lock.."
        If fod.ShowDialog = Windows.Forms.DialogResult.OK Then
            Dim fop As New IO.FileInfo(fod.FileName)
            fop.MoveTo(_LockerDIR & fop.Name)
        End If
        Folder.Refresh()
    End Sub

#End Region

#Region "Close Locker..."

    Public Sub Close_Locker()
        Try
            BackupZIP()
        Catch ex1 As Exception
            MsgBox("Unexpected Error :" & vbCrLf & ex1.Message, MsgBoxStyle.Critical)
            Try
                IO.File.Delete(_LockerZIP)
            Catch ex As Exception
            End Try
        End Try
        Delete_AllFiles()
    End Sub
    Private Sub Delete_AllFiles()
        Try
            If IO.Directory.Exists(_LockerDIR) Then
                Dim s As String
                For Each s In IO.Directory.GetFiles(_LockerDIR)
                    Try
                        IO.File.Delete(s)
                    Catch ex1 As Exception
                    End Try
                Next
            End If
        Catch ex1 As Exception
        End Try
    End Sub

#End Region

#Region "Open Locker..."

    Private Sub Open_Locker()
        If Not IO.Directory.Exists(_LockerDIR) Then
            IO.Directory.CreateDirectory(_LockerDIR)
        End If
        Try
            ExtractZIP()
        Catch ex1 As Exception
            MsgBox("Unexpected Error :" & vbCrLf & ex1.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

#End Region

#Region "Open Files to Locker From ZIP Locker File"

    Private Sub ExtractZIP()
        If IO.File.Exists(_LockerZIP) Then
            Dim zf As New ICSharpCode.SharpZipLib.Zip.ZipInputStream(IO.File.OpenRead(_LockerZIP))
            zf.Password = _Password
            Dim cE As ICSharpCode.SharpZipLib.Zip.ZipEntry = zf.GetNextEntry
            While Not cE Is Nothing
                ExtactFile(_LockerDIR, zf, cE)
                cE = zf.GetNextEntry
            End While
            zf.Close()
            zf.Dispose()
        End If
    End Sub

    Private Sub ExtactFile(ByVal DIR As String, ByVal xF As ICSharpCode.SharpZipLib.Zip.ZipInputStream, _
                                                                  ByVal cE As ICSharpCode.SharpZipLib.Zip.ZipEntry)
        Dim FileName As String = DIR & cE.Name
        Dim buf(512) As Byte
        Dim cF As IO.FileStream = New IO.FileStream(FileName, IO.FileMode.Create, IO.FileAccess.Write)
        Dim nSize As Integer = xF.Read(buf, 0, 512)
        While nSize > 0
            cF.Write(buf, 0, nSize)
            nSize = xF.Read(buf, 0, 512)
        End While
        cF.Close()
        cF.Dispose()
    End Sub

#End Region

#Region "Add Files in Locker to ZIP Locker File"

    Private Sub BackupZIP()
        Dim zF As New ICSharpCode.SharpZipLib.Zip.ZipOutputStream(IO.File.OpenWrite(_LockerZIP))
        zF.Password = _Password
        Dim cFile As String
        For Each cFile In IO.Directory.GetFiles(_LockerDIR, "*", IO.SearchOption.TopDirectoryOnly)
            Dim fi As New IO.FileInfo(cFile)
            AddthisFile(zF, cFile, fi.Name)
        Next
        zF.Finish()
        zF.Close()
    End Sub

    Private Sub AddthisFile(ByVal xF As ICSharpCode.SharpZipLib.Zip.ZipOutputStream, ByVal File As String, ByVal EntryName As String)
        Dim Buf(512) As Byte
        Dim cF As IO.FileStream = New IO.FileStream(File, IO.FileMode.Open, IO.FileAccess.Read)
        Dim cE As New ICSharpCode.SharpZipLib.Zip.ZipEntry(EntryName)
        cE.DateTime = Date.Now
        xF.PutNextEntry(cE)
        Dim nSize As Integer = cF.Read(Buf, 0, 512)
        While nSize > 0
            xF.Write(Buf, 0, nSize)
            nSize = cF.Read(Buf, 0, 512)
        End While
        cF.Close()
        cF.Dispose()
    End Sub

#End Region


End Class
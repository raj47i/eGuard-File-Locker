<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If Me.BtnOpenLocker.Text = "Close Locker" Then
            MsgBox("You must close your locker before quiting.", MsgBoxStyle.Information)
            Exit Sub
        End If
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmdAbout = New System.Windows.Forms.Button
        Me.BtnOpenLocker = New System.Windows.Forms.Button
        Me.cmdShutDown = New System.Windows.Forms.Button
        Me.cmdSettings = New System.Windows.Forms.Button
        Me.BtnADD = New System.Windows.Forms.Button
        Me.Frame1 = New System.Windows.Forms.GroupBox
        Me.Folder = New System.Windows.Forms.WebBrowser
        Me.Button1 = New System.Windows.Forms.Button
        Me.Frame1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmdAbout
        '
        Me.cmdAbout.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdAbout.BackColor = System.Drawing.SystemColors.Control
        Me.cmdAbout.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdAbout.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdAbout.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdAbout.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdAbout.Location = New System.Drawing.Point(323, 342)
        Me.cmdAbout.Name = "cmdAbout"
        Me.cmdAbout.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdAbout.Size = New System.Drawing.Size(44, 25)
        Me.cmdAbout.TabIndex = 16
        Me.cmdAbout.Text = "About"
        Me.cmdAbout.UseVisualStyleBackColor = False
        '
        'BtnOpenLocker
        '
        Me.BtnOpenLocker.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnOpenLocker.BackColor = System.Drawing.SystemColors.Control
        Me.BtnOpenLocker.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnOpenLocker.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnOpenLocker.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnOpenLocker.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnOpenLocker.Location = New System.Drawing.Point(16, 342)
        Me.BtnOpenLocker.Name = "BtnOpenLocker"
        Me.BtnOpenLocker.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnOpenLocker.Size = New System.Drawing.Size(78, 25)
        Me.BtnOpenLocker.TabIndex = 15
        Me.BtnOpenLocker.Text = "Open Locker"
        Me.BtnOpenLocker.UseVisualStyleBackColor = False
        '
        'cmdShutDown
        '
        Me.cmdShutDown.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdShutDown.BackColor = System.Drawing.SystemColors.Control
        Me.cmdShutDown.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdShutDown.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdShutDown.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdShutDown.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdShutDown.Location = New System.Drawing.Point(373, 342)
        Me.cmdShutDown.Name = "cmdShutDown"
        Me.cmdShutDown.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdShutDown.Size = New System.Drawing.Size(40, 25)
        Me.cmdShutDown.TabIndex = 14
        Me.cmdShutDown.Text = "Exit"
        Me.cmdShutDown.UseVisualStyleBackColor = False
        '
        'cmdSettings
        '
        Me.cmdSettings.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.cmdSettings.BackColor = System.Drawing.SystemColors.Control
        Me.cmdSettings.Cursor = System.Windows.Forms.Cursors.Default
        Me.cmdSettings.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.cmdSettings.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmdSettings.ForeColor = System.Drawing.SystemColors.ControlText
        Me.cmdSettings.Location = New System.Drawing.Point(164, 342)
        Me.cmdSettings.Name = "cmdSettings"
        Me.cmdSettings.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.cmdSettings.Size = New System.Drawing.Size(105, 25)
        Me.cmdSettings.TabIndex = 13
        Me.cmdSettings.Text = "Change Password"
        Me.cmdSettings.UseVisualStyleBackColor = False
        '
        'BtnADD
        '
        Me.BtnADD.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.BtnADD.BackColor = System.Drawing.SystemColors.Control
        Me.BtnADD.Cursor = System.Windows.Forms.Cursors.Default
        Me.BtnADD.Enabled = False
        Me.BtnADD.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.BtnADD.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnADD.ForeColor = System.Drawing.SystemColors.ControlText
        Me.BtnADD.Location = New System.Drawing.Point(100, 342)
        Me.BtnADD.Name = "BtnADD"
        Me.BtnADD.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.BtnADD.Size = New System.Drawing.Size(58, 25)
        Me.BtnADD.TabIndex = 11
        Me.BtnADD.Text = "Add File"
        Me.BtnADD.UseVisualStyleBackColor = False
        '
        'Frame1
        '
        Me.Frame1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Frame1.BackColor = System.Drawing.Color.Transparent
        Me.Frame1.Controls.Add(Me.Folder)
        Me.Frame1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Frame1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Frame1.Location = New System.Drawing.Point(10, 10)
        Me.Frame1.Name = "Frame1"
        Me.Frame1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Frame1.Size = New System.Drawing.Size(409, 322)
        Me.Frame1.TabIndex = 10
        Me.Frame1.TabStop = False
        Me.Frame1.Text = "Locker Contents.."
        '
        'Folder
        '
        Me.Folder.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Folder.Location = New System.Drawing.Point(11, 19)
        Me.Folder.Name = "Folder"
        Me.Folder.Size = New System.Drawing.Size(386, 293)
        Me.Folder.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.Button1.BackColor = System.Drawing.SystemColors.Control
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.Button1.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ControlText
        Me.Button1.Location = New System.Drawing.Point(275, 342)
        Me.Button1.Name = "Button1"
        Me.Button1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Button1.Size = New System.Drawing.Size(42, 25)
        Me.Button1.TabIndex = 17
        Me.Button1.Text = "Help"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Main
        '
        Me.AcceptButton = Me.BtnOpenLocker
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.FileLocker.My.Resources.Resources.bk
        Me.CancelButton = Me.Button1
        Me.ClientSize = New System.Drawing.Size(428, 376)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.cmdAbout)
        Me.Controls.Add(Me.BtnOpenLocker)
        Me.Controls.Add(Me.cmdShutDown)
        Me.Controls.Add(Me.cmdSettings)
        Me.Controls.Add(Me.BtnADD)
        Me.Controls.Add(Me.Frame1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "  File Locker v 1.0.0.0"
        Me.Frame1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Public WithEvents cmdAbout As System.Windows.Forms.Button
    Public WithEvents BtnOpenLocker As System.Windows.Forms.Button
    Public WithEvents cmdShutDown As System.Windows.Forms.Button
    Public WithEvents cmdSettings As System.Windows.Forms.Button
    Public WithEvents BtnADD As System.Windows.Forms.Button
    Public WithEvents Frame1 As System.Windows.Forms.GroupBox
    Public WithEvents Folder As System.Windows.Forms.WebBrowser
    Public WithEvents Button1 As System.Windows.Forms.Button
End Class

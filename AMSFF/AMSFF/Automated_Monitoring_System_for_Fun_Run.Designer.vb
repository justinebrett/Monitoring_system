<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Automated_Monitoring_System_for_Fun_Run
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MonitoringToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CreateParticipantsReportToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.InformationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DeleteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RecordToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogoutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TTSL_User = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Waiting = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Time = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Clock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Date = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_today = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_Status = New System.Windows.Forms.ToolStripStatusLabel()
        Me.TSSL_statusmain = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MenuStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.RegistrationToolStripMenuItem1, Me.SearchToolStripMenuItem, Me.DeleteToolStripMenuItem, Me.LogoutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.MonitoringToolStripMenuItem, Me.CreateParticipantsReportToolStripMenuItem})
        Me.FileToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.File
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(53, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.registration
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'MonitoringToolStripMenuItem
        '
        Me.MonitoringToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.monitoring
        Me.MonitoringToolStripMenuItem.Name = "MonitoringToolStripMenuItem"
        Me.MonitoringToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.MonitoringToolStripMenuItem.Text = "Monitoring"
        '
        'CreateParticipantsReportToolStripMenuItem
        '
        Me.CreateParticipantsReportToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.create_report
        Me.CreateParticipantsReportToolStripMenuItem.Name = "CreateParticipantsReportToolStripMenuItem"
        Me.CreateParticipantsReportToolStripMenuItem.Size = New System.Drawing.Size(208, 22)
        Me.CreateParticipantsReportToolStripMenuItem.Text = "Create participants report"
        '
        'RegistrationToolStripMenuItem1
        '
        Me.RegistrationToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InformationToolStripMenuItem})
        Me.RegistrationToolStripMenuItem1.Image = Global.AMSFF.My.Resources.Resources.edit
        Me.RegistrationToolStripMenuItem1.Name = "RegistrationToolStripMenuItem1"
        Me.RegistrationToolStripMenuItem1.Size = New System.Drawing.Size(55, 20)
        Me.RegistrationToolStripMenuItem1.Text = "Edit"
        '
        'InformationToolStripMenuItem
        '
        Me.InformationToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.edit
        Me.InformationToolStripMenuItem.Name = "InformationToolStripMenuItem"
        Me.InformationToolStripMenuItem.Size = New System.Drawing.Size(137, 22)
        Me.InformationToolStripMenuItem.Text = "Information"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordToolStripMenuItem1})
        Me.SearchToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.search
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(70, 20)
        Me.SearchToolStripMenuItem.Text = "Search"
        '
        'RecordToolStripMenuItem1
        '
        Me.RecordToolStripMenuItem1.Image = Global.AMSFF.My.Resources.Resources.update1
        Me.RecordToolStripMenuItem1.Name = "RecordToolStripMenuItem1"
        Me.RecordToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.RecordToolStripMenuItem1.Text = "Record"
        '
        'DeleteToolStripMenuItem
        '
        Me.DeleteToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RecordToolStripMenuItem})
        Me.DeleteToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.delete1
        Me.DeleteToolStripMenuItem.Name = "DeleteToolStripMenuItem"
        Me.DeleteToolStripMenuItem.Size = New System.Drawing.Size(68, 20)
        Me.DeleteToolStripMenuItem.Text = "Delete"
        '
        'RecordToolStripMenuItem
        '
        Me.RecordToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.update
        Me.RecordToolStripMenuItem.Name = "RecordToolStripMenuItem"
        Me.RecordToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.RecordToolStripMenuItem.Text = "Record"
        '
        'LogoutToolStripMenuItem
        '
        Me.LogoutToolStripMenuItem.Image = Global.AMSFF.My.Resources.Resources.login
        Me.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem"
        Me.LogoutToolStripMenuItem.Size = New System.Drawing.Size(73, 20)
        Me.LogoutToolStripMenuItem.Text = "Logout"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TTSL_User, Me.TSSL_Waiting, Me.TSSL_Time, Me.TSSL_Clock, Me.TSSL_Date, Me.TSSL_today, Me.TSSL_Status, Me.TSSL_statusmain})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 638)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1184, 24)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TTSL_User
        '
        Me.TTSL_User.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TTSL_User.Image = Global.AMSFF.My.Resources.Resources.admin
        Me.TTSL_User.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.TTSL_User.Name = "TTSL_User"
        Me.TTSL_User.Size = New System.Drawing.Size(55, 19)
        Me.TTSL_User.Text = "User :"
        '
        'TSSL_Waiting
        '
        Me.TSSL_Waiting.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSSL_Waiting.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TSSL_Waiting.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_Waiting.Name = "TSSL_Waiting"
        Me.TSSL_Waiting.Size = New System.Drawing.Size(63, 19)
        Me.TSSL_Waiting.Text = "Waiting..."
        '
        'TSSL_Time
        '
        Me.TSSL_Time.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_Time.Image = Global.AMSFF.My.Resources.Resources.time
        Me.TSSL_Time.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.TSSL_Time.Name = "TSSL_Time"
        Me.TSSL_Time.Size = New System.Drawing.Size(57, 19)
        Me.TSSL_Time.Text = "Time :"
        '
        'TSSL_Clock
        '
        Me.TSSL_Clock.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSSL_Clock.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TSSL_Clock.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_Clock.Name = "TSSL_Clock"
        Me.TSSL_Clock.Size = New System.Drawing.Size(68, 19)
        Me.TSSL_Clock.Text = "timeofday"
        '
        'TSSL_Date
        '
        Me.TSSL_Date.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_Date.Image = Global.AMSFF.My.Resources.Resources.calendar
        Me.TSSL_Date.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.TSSL_Date.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.TSSL_Date.Name = "TSSL_Date"
        Me.TSSL_Date.Size = New System.Drawing.Size(56, 19)
        Me.TSSL_Date.Text = "Date :"
        '
        'TSSL_today
        '
        Me.TSSL_today.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSSL_today.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TSSL_today.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_today.Name = "TSSL_today"
        Me.TSSL_today.Size = New System.Drawing.Size(42, 19)
        Me.TSSL_today.Text = "today"
        '
        'TSSL_Status
        '
        Me.TSSL_Status.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_Status.Margin = New System.Windows.Forms.Padding(50, 3, 0, 2)
        Me.TSSL_Status.Name = "TSSL_Status"
        Me.TSSL_Status.Size = New System.Drawing.Size(48, 19)
        Me.TSSL_Status.Text = "Status :"
        '
        'TSSL_statusmain
        '
        Me.TSSL_statusmain.BorderSides = CType((((System.Windows.Forms.ToolStripStatusLabelBorderSides.Left Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Top) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Right) _
            Or System.Windows.Forms.ToolStripStatusLabelBorderSides.Bottom), System.Windows.Forms.ToolStripStatusLabelBorderSides)
        Me.TSSL_statusmain.BorderStyle = System.Windows.Forms.Border3DStyle.SunkenOuter
        Me.TSSL_statusmain.Font = New System.Drawing.Font("Segoe WP", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TSSL_statusmain.Name = "TSSL_statusmain"
        Me.TSSL_statusmain.Size = New System.Drawing.Size(70, 19)
        Me.TSSL_statusmain.Text = "Main Form"
        '
        'Timer1
        '
        '
        'Automated_Monitoring_System_for_Fun_Run
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.AMSFF.My.Resources.Resources.background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1184, 662)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.DoubleBuffered = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Automated_Monitoring_System_for_Fun_Run"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Automated_Monitoring_System_for_Fun_Run"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StatusStrip1 As System.Windows.Forms.StatusStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MonitoringToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InformationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DeleteToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RecordToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LogoutToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TTSL_User As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Waiting As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Time As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Clock As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Date As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_today As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_Status As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents TSSL_statusmain As System.Windows.Forms.ToolStripStatusLabel
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents CreateParticipantsReportToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class

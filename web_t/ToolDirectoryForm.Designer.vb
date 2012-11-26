<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolDirectoryForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolDirectoryForm))
        Me.GboxDirectory = New System.Windows.Forms.GroupBox
        Me.bt_offMonitor = New System.Windows.Forms.Button
        Me.bt_onMonitor = New System.Windows.Forms.Button
        Me.txtbox_addMonitorDirectory = New System.Windows.Forms.TextBox
        Me.lbADDdirectory = New System.Windows.Forms.Label
        Me.bt_selectDirectory = New System.Windows.Forms.Button
        Me.txtbox_monitorDirectory = New System.Windows.Forms.TextBox
        Me.lbSelectDirectory = New System.Windows.Forms.Label
        Me.Gboxfile = New System.Windows.Forms.GroupBox
        Me.bt_put = New System.Windows.Forms.Button
        Me.CBbox_infEdit = New System.Windows.Forms.ComboBox
        Me.bt_file_host = New System.Windows.Forms.Button
        Me.Gbox_info = New System.Windows.Forms.GroupBox
        Me.Rtxtbox_info = New System.Windows.Forms.RichTextBox
        Me.fbmonitorDialog = New System.Windows.Forms.FolderBrowserDialog
        Me.FSWatcher = New System.IO.FileSystemWatcher
        Me.GboxDirectory.SuspendLayout()
        Me.Gboxfile.SuspendLayout()
        Me.Gbox_info.SuspendLayout()
        CType(Me.FSWatcher, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GboxDirectory
        '
        Me.GboxDirectory.Controls.Add(Me.bt_offMonitor)
        Me.GboxDirectory.Controls.Add(Me.bt_onMonitor)
        Me.GboxDirectory.Controls.Add(Me.txtbox_addMonitorDirectory)
        Me.GboxDirectory.Controls.Add(Me.lbADDdirectory)
        Me.GboxDirectory.Controls.Add(Me.bt_selectDirectory)
        Me.GboxDirectory.Controls.Add(Me.txtbox_monitorDirectory)
        Me.GboxDirectory.Controls.Add(Me.lbSelectDirectory)
        Me.GboxDirectory.Location = New System.Drawing.Point(1, 0)
        Me.GboxDirectory.Name = "GboxDirectory"
        Me.GboxDirectory.Size = New System.Drawing.Size(755, 123)
        Me.GboxDirectory.TabIndex = 0
        Me.GboxDirectory.TabStop = False
        Me.GboxDirectory.Text = "目录监控"
        '
        'bt_offMonitor
        '
        Me.bt_offMonitor.Location = New System.Drawing.Point(366, 35)
        Me.bt_offMonitor.Name = "bt_offMonitor"
        Me.bt_offMonitor.Size = New System.Drawing.Size(75, 23)
        Me.bt_offMonitor.TabIndex = 6
        Me.bt_offMonitor.Text = "停止监控"
        Me.bt_offMonitor.UseVisualStyleBackColor = True
        '
        'bt_onMonitor
        '
        Me.bt_onMonitor.Location = New System.Drawing.Point(232, 36)
        Me.bt_onMonitor.Name = "bt_onMonitor"
        Me.bt_onMonitor.Size = New System.Drawing.Size(75, 23)
        Me.bt_onMonitor.TabIndex = 5
        Me.bt_onMonitor.Text = "开始监控"
        Me.bt_onMonitor.UseVisualStyleBackColor = True
        '
        'txtbox_addMonitorDirectory
        '
        Me.txtbox_addMonitorDirectory.Location = New System.Drawing.Point(13, 61)
        Me.txtbox_addMonitorDirectory.Multiline = True
        Me.txtbox_addMonitorDirectory.Name = "txtbox_addMonitorDirectory"
        Me.txtbox_addMonitorDirectory.Size = New System.Drawing.Size(715, 56)
        Me.txtbox_addMonitorDirectory.TabIndex = 4
        '
        'lbADDdirectory
        '
        Me.lbADDdirectory.AutoSize = True
        Me.lbADDdirectory.Location = New System.Drawing.Point(11, 46)
        Me.lbADDdirectory.Name = "lbADDdirectory"
        Me.lbADDdirectory.Size = New System.Drawing.Size(59, 12)
        Me.lbADDdirectory.TabIndex = 3
        Me.lbADDdirectory.Text = "追加目录:"
        '
        'bt_selectDirectory
        '
        Me.bt_selectDirectory.Location = New System.Drawing.Point(678, 8)
        Me.bt_selectDirectory.Name = "bt_selectDirectory"
        Me.bt_selectDirectory.Size = New System.Drawing.Size(50, 23)
        Me.bt_selectDirectory.TabIndex = 2
        Me.bt_selectDirectory.Text = "。。。"
        Me.bt_selectDirectory.UseVisualStyleBackColor = True
        '
        'txtbox_monitorDirectory
        '
        Me.txtbox_monitorDirectory.Location = New System.Drawing.Point(130, 8)
        Me.txtbox_monitorDirectory.Name = "txtbox_monitorDirectory"
        Me.txtbox_monitorDirectory.Size = New System.Drawing.Size(542, 21)
        Me.txtbox_monitorDirectory.TabIndex = 1
        '
        'lbSelectDirectory
        '
        Me.lbSelectDirectory.AutoSize = True
        Me.lbSelectDirectory.Location = New System.Drawing.Point(11, 17)
        Me.lbSelectDirectory.Name = "lbSelectDirectory"
        Me.lbSelectDirectory.Size = New System.Drawing.Size(113, 12)
        Me.lbSelectDirectory.TabIndex = 0
        Me.lbSelectDirectory.Text = "请选择需监控的目录"
        '
        'Gboxfile
        '
        Me.Gboxfile.Controls.Add(Me.bt_put)
        Me.Gboxfile.Controls.Add(Me.CBbox_infEdit)
        Me.Gboxfile.Controls.Add(Me.bt_file_host)
        Me.Gboxfile.Location = New System.Drawing.Point(1, 129)
        Me.Gboxfile.Name = "Gboxfile"
        Me.Gboxfile.Size = New System.Drawing.Size(755, 108)
        Me.Gboxfile.TabIndex = 1
        Me.Gboxfile.TabStop = False
        Me.Gboxfile.Text = "文件修订"
        '
        'bt_put
        '
        Me.bt_put.Location = New System.Drawing.Point(678, 79)
        Me.bt_put.Name = "bt_put"
        Me.bt_put.Size = New System.Drawing.Size(50, 23)
        Me.bt_put.TabIndex = 2
        Me.bt_put.Text = "修订"
        Me.bt_put.UseVisualStyleBackColor = True
        '
        'CBbox_infEdit
        '
        Me.CBbox_infEdit.FormattingEnabled = True
        Me.CBbox_infEdit.Items.AddRange(New Object() {"host文件", "boot.ini"})
        Me.CBbox_infEdit.Location = New System.Drawing.Point(6, 82)
        Me.CBbox_infEdit.Name = "CBbox_infEdit"
        Me.CBbox_infEdit.Size = New System.Drawing.Size(666, 20)
        Me.CBbox_infEdit.TabIndex = 1
        '
        'bt_file_host
        '
        Me.bt_file_host.Location = New System.Drawing.Point(13, 21)
        Me.bt_file_host.Name = "bt_file_host"
        Me.bt_file_host.Size = New System.Drawing.Size(75, 23)
        Me.bt_file_host.TabIndex = 0
        Me.bt_file_host.Text = "host文件"
        Me.bt_file_host.UseVisualStyleBackColor = True
        '
        'Gbox_info
        '
        Me.Gbox_info.Controls.Add(Me.Rtxtbox_info)
        Me.Gbox_info.Location = New System.Drawing.Point(1, 242)
        Me.Gbox_info.Name = "Gbox_info"
        Me.Gbox_info.Size = New System.Drawing.Size(755, 160)
        Me.Gbox_info.TabIndex = 2
        Me.Gbox_info.TabStop = False
        Me.Gbox_info.Text = "信息显示"
        '
        'Rtxtbox_info
        '
        Me.Rtxtbox_info.BackColor = System.Drawing.SystemColors.Info
        Me.Rtxtbox_info.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Rtxtbox_info.Location = New System.Drawing.Point(3, 17)
        Me.Rtxtbox_info.Name = "Rtxtbox_info"
        Me.Rtxtbox_info.Size = New System.Drawing.Size(749, 140)
        Me.Rtxtbox_info.TabIndex = 0
        Me.Rtxtbox_info.Text = ""
        '
        'FSWatcher
        '
        Me.FSWatcher.EnableRaisingEvents = True
        Me.FSWatcher.SynchronizingObject = Me
        '
        't_directory
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(757, 402)
        Me.Controls.Add(Me.Gbox_info)
        Me.Controls.Add(Me.Gboxfile)
        Me.Controls.Add(Me.GboxDirectory)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "t_directory"
        Me.Text = "目录监控与文件修订"
        Me.GboxDirectory.ResumeLayout(False)
        Me.GboxDirectory.PerformLayout()
        Me.Gboxfile.ResumeLayout(False)
        Me.Gbox_info.ResumeLayout(False)
        CType(Me.FSWatcher, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GboxDirectory As System.Windows.Forms.GroupBox
    Friend WithEvents Gboxfile As System.Windows.Forms.GroupBox
    Friend WithEvents Gbox_info As System.Windows.Forms.GroupBox
    Friend WithEvents fbmonitorDialog As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbADDdirectory As System.Windows.Forms.Label
    Friend WithEvents bt_selectDirectory As System.Windows.Forms.Button
    Friend WithEvents txtbox_monitorDirectory As System.Windows.Forms.TextBox
    Friend WithEvents lbSelectDirectory As System.Windows.Forms.Label
    Friend WithEvents FSWatcher As System.IO.FileSystemWatcher
    Friend WithEvents bt_offMonitor As System.Windows.Forms.Button
    Friend WithEvents bt_onMonitor As System.Windows.Forms.Button
    Friend WithEvents txtbox_addMonitorDirectory As System.Windows.Forms.TextBox
    Friend WithEvents Rtxtbox_info As System.Windows.Forms.RichTextBox
    Friend WithEvents bt_file_host As System.Windows.Forms.Button
    Friend WithEvents bt_put As System.Windows.Forms.Button
    Friend WithEvents CBbox_infEdit As System.Windows.Forms.ComboBox
End Class

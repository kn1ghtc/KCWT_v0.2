<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolWinPasswordForm
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolWinPasswordForm))
        Me.tv_user = New System.Windows.Forms.TreeView
        Me.GroupBox3 = New System.Windows.Forms.GroupBox
        Me.bt_load = New System.Windows.Forms.Button
        Me.bt_showpass = New System.Windows.Forms.Button
        Me.bt_get_pass = New System.Windows.Forms.Button
        Me.win_pass_youjian = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator
        Me.win_pass_refresh_reg = New System.Windows.Forms.ToolStripMenuItem
        Me.GroupBox3.SuspendLayout()
        Me.win_pass_youjian.SuspendLayout()
        Me.SuspendLayout()
        '
        'tv_user
        '
        Me.tv_user.Location = New System.Drawing.Point(-1, -1)
        Me.tv_user.Name = "tv_user"
        Me.tv_user.Size = New System.Drawing.Size(140, 324)
        Me.tv_user.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.bt_load)
        Me.GroupBox3.Controls.Add(Me.bt_showpass)
        Me.GroupBox3.Controls.Add(Me.bt_get_pass)
        Me.GroupBox3.Location = New System.Drawing.Point(145, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(433, 319)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "密码强度验证"
        '
        'bt_load
        '
        Me.bt_load.Location = New System.Drawing.Point(30, 77)
        Me.bt_load.Name = "bt_load"
        Me.bt_load.Size = New System.Drawing.Size(109, 30)
        Me.bt_load.TabIndex = 5
        Me.bt_load.Text = "装载破解"
        Me.bt_load.UseVisualStyleBackColor = True
        '
        'bt_showpass
        '
        Me.bt_showpass.BackColor = System.Drawing.Color.Chocolate
        Me.bt_showpass.Location = New System.Drawing.Point(0, 160)
        Me.bt_showpass.Name = "bt_showpass"
        Me.bt_showpass.Size = New System.Drawing.Size(406, 153)
        Me.bt_showpass.TabIndex = 4
        Me.bt_showpass.UseVisualStyleBackColor = False
        '
        'bt_get_pass
        '
        Me.bt_get_pass.BackColor = System.Drawing.Color.DimGray
        Me.bt_get_pass.FlatStyle = System.Windows.Forms.FlatStyle.System
        Me.bt_get_pass.Location = New System.Drawing.Point(186, 77)
        Me.bt_get_pass.Name = "bt_get_pass"
        Me.bt_get_pass.Size = New System.Drawing.Size(111, 30)
        Me.bt_get_pass.TabIndex = 3
        Me.bt_get_pass.Text = "获取口令"
        Me.bt_get_pass.UseVisualStyleBackColor = False
        '
        'win_pass_youjian
        '
        Me.win_pass_youjian.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.win_pass_refresh_reg})
        Me.win_pass_youjian.Name = "win_pass_youjian"
        Me.win_pass_youjian.Size = New System.Drawing.Size(119, 32)
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(115, 6)
        '
        'win_pass_refresh_reg
        '
        Me.win_pass_refresh_reg.Name = "win_pass_refresh_reg"
        Me.win_pass_refresh_reg.Size = New System.Drawing.Size(118, 22)
        Me.win_pass_refresh_reg.Text = "刷新用户"
        '
        'win_pass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(583, 322)
        Me.ContextMenuStrip = Me.win_pass_youjian
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.tv_user)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "win_pass"
        Me.Text = "windows密码相关"
        Me.GroupBox3.ResumeLayout(False)
        Me.win_pass_youjian.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents tv_user As System.Windows.Forms.TreeView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents win_pass_youjian As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents win_pass_refresh_reg As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents bt_get_pass As System.Windows.Forms.Button
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents bt_showpass As System.Windows.Forms.Button
    Friend WithEvents bt_load As System.Windows.Forms.Button
End Class

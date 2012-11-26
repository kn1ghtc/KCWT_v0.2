<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolFtpClientForm
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
        Me.lb_server = New System.Windows.Forms.Label
        Me.txt_ser = New System.Windows.Forms.TextBox
        Me.Label2 = New System.Windows.Forms.Label
        Me.lb_user = New System.Windows.Forms.Label
        Me.txt_usr = New System.Windows.Forms.TextBox
        Me.lb_pa = New System.Windows.Forms.Label
        Me.txt_pa = New System.Windows.Forms.TextBox
        Me.bt_login = New System.Windows.Forms.Button
        Me.bt_exit = New System.Windows.Forms.Button
        Me.gb_mess = New System.Windows.Forms.GroupBox
        Me.txt_mess = New System.Windows.Forms.TextBox
        Me.comb_local = New System.Windows.Forms.ComboBox
        Me.pa_ff = New System.Windows.Forms.Panel
        Me.bt_get = New System.Windows.Forms.Button
        Me.bt_put = New System.Windows.Forms.Button
        Me.gb_re = New System.Windows.Forms.GroupBox
        Me.tv_remote = New System.Windows.Forms.TreeView
        Me.gb_lo = New System.Windows.Forms.GroupBox
        Me.tv_local = New System.Windows.Forms.TreeView
        Me.bt_addlo = New System.Windows.Forms.Button
        Me.comb_remote = New System.Windows.Forms.ComboBox
        Me.bt_addre = New System.Windows.Forms.Button
        Me.right_mouse = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.right_mouse_pwd = New System.Windows.Forms.ToolStripMenuItem
        Me.right_mouse_new = New System.Windows.Forms.ToolStripMenuItem
        Me.right_mouse_del = New System.Windows.Forms.ToolStripMenuItem
        Me.gb_mess.SuspendLayout()
        Me.pa_ff.SuspendLayout()
        Me.gb_re.SuspendLayout()
        Me.gb_lo.SuspendLayout()
        Me.right_mouse.SuspendLayout()
        Me.SuspendLayout()
        '
        'lb_server
        '
        Me.lb_server.AutoSize = True
        Me.lb_server.Location = New System.Drawing.Point(6, 7)
        Me.lb_server.Name = "lb_server"
        Me.lb_server.Size = New System.Drawing.Size(41, 12)
        Me.lb_server.TabIndex = 0
        Me.lb_server.Text = "服务器"
        '
        'txt_ser
        '
        Me.txt_ser.Location = New System.Drawing.Point(53, 4)
        Me.txt_ser.Name = "txt_ser"
        Me.txt_ser.Size = New System.Drawing.Size(100, 21)
        Me.txt_ser.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(176, 7)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 12)
        Me.Label2.TabIndex = 2
        '
        'lb_user
        '
        Me.lb_user.AutoSize = True
        Me.lb_user.Location = New System.Drawing.Point(176, 7)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(41, 12)
        Me.lb_user.TabIndex = 3
        Me.lb_user.Text = "用户名"
        '
        'txt_usr
        '
        Me.txt_usr.Location = New System.Drawing.Point(237, 7)
        Me.txt_usr.Name = "txt_usr"
        Me.txt_usr.Size = New System.Drawing.Size(100, 21)
        Me.txt_usr.TabIndex = 4
        '
        'lb_pa
        '
        Me.lb_pa.AutoSize = True
        Me.lb_pa.Location = New System.Drawing.Point(372, 7)
        Me.lb_pa.Name = "lb_pa"
        Me.lb_pa.Size = New System.Drawing.Size(29, 12)
        Me.lb_pa.TabIndex = 5
        Me.lb_pa.Text = "口令"
        '
        'txt_pa
        '
        Me.txt_pa.Location = New System.Drawing.Point(407, 7)
        Me.txt_pa.Name = "txt_pa"
        Me.txt_pa.PasswordChar = Global.Microsoft.VisualBasic.ChrW(35)
        Me.txt_pa.Size = New System.Drawing.Size(100, 21)
        Me.txt_pa.TabIndex = 6
        '
        'bt_login
        '
        Me.bt_login.Location = New System.Drawing.Point(566, 7)
        Me.bt_login.Name = "bt_login"
        Me.bt_login.Size = New System.Drawing.Size(75, 23)
        Me.bt_login.TabIndex = 7
        Me.bt_login.Text = "登陆"
        Me.bt_login.UseVisualStyleBackColor = True
        '
        'bt_exit
        '
        Me.bt_exit.Location = New System.Drawing.Point(681, 7)
        Me.bt_exit.Name = "bt_exit"
        Me.bt_exit.Size = New System.Drawing.Size(75, 23)
        Me.bt_exit.TabIndex = 8
        Me.bt_exit.Text = "退出"
        Me.bt_exit.UseVisualStyleBackColor = True
        '
        'gb_mess
        '
        Me.gb_mess.Controls.Add(Me.txt_mess)
        Me.gb_mess.Location = New System.Drawing.Point(8, 464)
        Me.gb_mess.Name = "gb_mess"
        Me.gb_mess.Size = New System.Drawing.Size(785, 100)
        Me.gb_mess.TabIndex = 9
        Me.gb_mess.TabStop = False
        Me.gb_mess.Text = "消息日志"
        '
        'txt_mess
        '
        Me.txt_mess.Location = New System.Drawing.Point(3, 10)
        Me.txt_mess.Multiline = True
        Me.txt_mess.Name = "txt_mess"
        Me.txt_mess.ReadOnly = True
        Me.txt_mess.Size = New System.Drawing.Size(782, 90)
        Me.txt_mess.TabIndex = 0
        '
        'comb_local
        '
        Me.comb_local.FormattingEnabled = True
        Me.comb_local.Location = New System.Drawing.Point(8, 47)
        Me.comb_local.Name = "comb_local"
        Me.comb_local.Size = New System.Drawing.Size(314, 20)
        Me.comb_local.TabIndex = 11
        '
        'pa_ff
        '
        Me.pa_ff.Controls.Add(Me.bt_get)
        Me.pa_ff.Controls.Add(Me.bt_put)
        Me.pa_ff.Controls.Add(Me.gb_re)
        Me.pa_ff.Controls.Add(Me.gb_lo)
        Me.pa_ff.Location = New System.Drawing.Point(8, 73)
        Me.pa_ff.Name = "pa_ff"
        Me.pa_ff.Size = New System.Drawing.Size(785, 385)
        Me.pa_ff.TabIndex = 12
        '
        'bt_get
        '
        Me.bt_get.Location = New System.Drawing.Point(336, 181)
        Me.bt_get.Name = "bt_get"
        Me.bt_get.Size = New System.Drawing.Size(113, 23)
        Me.bt_get.TabIndex = 15
        Me.bt_get.Text = "下载"
        Me.bt_get.UseVisualStyleBackColor = True
        '
        'bt_put
        '
        Me.bt_put.Location = New System.Drawing.Point(335, 99)
        Me.bt_put.Name = "bt_put"
        Me.bt_put.Size = New System.Drawing.Size(113, 23)
        Me.bt_put.TabIndex = 14
        Me.bt_put.Text = "上传"
        Me.bt_put.UseVisualStyleBackColor = True
        '
        'gb_re
        '
        Me.gb_re.Controls.Add(Me.tv_remote)
        Me.gb_re.Location = New System.Drawing.Point(454, 4)
        Me.gb_re.Name = "gb_re"
        Me.gb_re.Size = New System.Drawing.Size(326, 379)
        Me.gb_re.TabIndex = 1
        Me.gb_re.TabStop = False
        Me.gb_re.Text = "远程目录"
        '
        'tv_remote
        '
        Me.tv_remote.Location = New System.Drawing.Point(1, 11)
        Me.tv_remote.Name = "tv_remote"
        Me.tv_remote.Size = New System.Drawing.Size(325, 368)
        Me.tv_remote.TabIndex = 0
        '
        'gb_lo
        '
        Me.gb_lo.Controls.Add(Me.tv_local)
        Me.gb_lo.Location = New System.Drawing.Point(3, 3)
        Me.gb_lo.Name = "gb_lo"
        Me.gb_lo.Size = New System.Drawing.Size(326, 379)
        Me.gb_lo.TabIndex = 0
        Me.gb_lo.TabStop = False
        Me.gb_lo.Text = "本地目录"
        '
        'tv_local
        '
        Me.tv_local.Location = New System.Drawing.Point(1, 11)
        Me.tv_local.Name = "tv_local"
        Me.tv_local.Size = New System.Drawing.Size(325, 368)
        Me.tv_local.TabIndex = 0
        '
        'bt_addlo
        '
        Me.bt_addlo.Location = New System.Drawing.Point(328, 47)
        Me.bt_addlo.Name = "bt_addlo"
        Me.bt_addlo.Size = New System.Drawing.Size(59, 23)
        Me.bt_addlo.TabIndex = 13
        Me.bt_addlo.Text = "转到"
        Me.bt_addlo.UseVisualStyleBackColor = True
        '
        'comb_remote
        '
        Me.comb_remote.AllowDrop = True
        Me.comb_remote.AutoCompleteCustomSource.AddRange(New String() {"/"})
        Me.comb_remote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.comb_remote.FormattingEnabled = True
        Me.comb_remote.Location = New System.Drawing.Point(407, 47)
        Me.comb_remote.Name = "comb_remote"
        Me.comb_remote.Size = New System.Drawing.Size(314, 20)
        Me.comb_remote.TabIndex = 14
        '
        'bt_addre
        '
        Me.bt_addre.Location = New System.Drawing.Point(727, 45)
        Me.bt_addre.Name = "bt_addre"
        Me.bt_addre.Size = New System.Drawing.Size(61, 23)
        Me.bt_addre.TabIndex = 15
        Me.bt_addre.Text = "添加"
        Me.bt_addre.UseVisualStyleBackColor = True
        '
        'right_mouse
        '
        Me.right_mouse.BackColor = System.Drawing.SystemColors.Control
        Me.right_mouse.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.right_mouse_pwd, Me.right_mouse_new, Me.right_mouse_del})
        Me.right_mouse.Name = "right_mouse"
        Me.right_mouse.Size = New System.Drawing.Size(143, 70)
        Me.right_mouse.Text = "mouse"
        '
        'right_mouse_pwd
        '
        Me.right_mouse_pwd.Name = "right_mouse_pwd"
        Me.right_mouse_pwd.Size = New System.Drawing.Size(152, 22)
        Me.right_mouse_pwd.Text = "显示当前目录"
        '
        'right_mouse_new
        '
        Me.right_mouse_new.Name = "right_mouse_new"
        Me.right_mouse_new.Size = New System.Drawing.Size(152, 22)
        Me.right_mouse_new.Text = "新建目录"
        '
        'right_mouse_del
        '
        Me.right_mouse_del.Name = "right_mouse_del"
        Me.right_mouse_del.Size = New System.Drawing.Size(152, 22)
        Me.right_mouse_del.Text = "删除目录"
        '
        't_fclient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(805, 576)
        Me.Controls.Add(Me.bt_addre)
        Me.Controls.Add(Me.comb_remote)
        Me.Controls.Add(Me.bt_addlo)
        Me.Controls.Add(Me.pa_ff)
        Me.Controls.Add(Me.comb_local)
        Me.Controls.Add(Me.gb_mess)
        Me.Controls.Add(Me.bt_exit)
        Me.Controls.Add(Me.bt_login)
        Me.Controls.Add(Me.txt_pa)
        Me.Controls.Add(Me.lb_pa)
        Me.Controls.Add(Me.txt_usr)
        Me.Controls.Add(Me.lb_user)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_ser)
        Me.Controls.Add(Me.lb_server)
        Me.Name = "t_fclient"
        Me.Text = "t_fclient"
        Me.gb_mess.ResumeLayout(False)
        Me.gb_mess.PerformLayout()
        Me.pa_ff.ResumeLayout(False)
        Me.gb_re.ResumeLayout(False)
        Me.gb_lo.ResumeLayout(False)
        Me.right_mouse.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_server As System.Windows.Forms.Label
    Friend WithEvents txt_ser As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lb_user As System.Windows.Forms.Label
    Friend WithEvents txt_usr As System.Windows.Forms.TextBox
    Friend WithEvents lb_pa As System.Windows.Forms.Label
    Friend WithEvents txt_pa As System.Windows.Forms.TextBox
    Friend WithEvents bt_login As System.Windows.Forms.Button
    Friend WithEvents bt_exit As System.Windows.Forms.Button
    Friend WithEvents gb_mess As System.Windows.Forms.GroupBox
    Friend WithEvents comb_local As System.Windows.Forms.ComboBox
    Friend WithEvents pa_ff As System.Windows.Forms.Panel
    Friend WithEvents gb_lo As System.Windows.Forms.GroupBox
    Friend WithEvents tv_local As System.Windows.Forms.TreeView
    Friend WithEvents bt_get As System.Windows.Forms.Button
    Friend WithEvents bt_put As System.Windows.Forms.Button
    Friend WithEvents gb_re As System.Windows.Forms.GroupBox
    Friend WithEvents tv_remote As System.Windows.Forms.TreeView
    Friend WithEvents bt_addlo As System.Windows.Forms.Button
    Friend WithEvents comb_remote As System.Windows.Forms.ComboBox
    Friend WithEvents bt_addre As System.Windows.Forms.Button
    Friend WithEvents txt_mess As System.Windows.Forms.TextBox
    Friend WithEvents right_mouse As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents right_mouse_pwd As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents right_mouse_new As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents right_mouse_del As System.Windows.Forms.ToolStripMenuItem
End Class

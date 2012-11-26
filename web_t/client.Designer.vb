<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class client
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.t_ipname = New System.Windows.Forms.TextBox
        Me.t_port = New System.Windows.Forms.TextBox
        Me.bt_conn = New System.Windows.Forms.Button
        Me.bt_colse = New System.Windows.Forms.Button
        Me.text_info = New System.Windows.Forms.TextBox
        Me.text_mess = New System.Windows.Forms.TextBox
        Me.bt_send = New System.Windows.Forms.Button
        Me.bt_read_mess = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 20)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(53, 12)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "连接地址"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 52)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(29, 12)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "端口"
        '
        't_ipname
        '
        Me.t_ipname.Location = New System.Drawing.Point(71, 12)
        Me.t_ipname.Name = "t_ipname"
        Me.t_ipname.Size = New System.Drawing.Size(100, 21)
        Me.t_ipname.TabIndex = 2
        '
        't_port
        '
        Me.t_port.Location = New System.Drawing.Point(71, 43)
        Me.t_port.Name = "t_port"
        Me.t_port.Size = New System.Drawing.Size(100, 21)
        Me.t_port.TabIndex = 3
        '
        'bt_conn
        '
        Me.bt_conn.Location = New System.Drawing.Point(242, 9)
        Me.bt_conn.Name = "bt_conn"
        Me.bt_conn.Size = New System.Drawing.Size(75, 23)
        Me.bt_conn.TabIndex = 4
        Me.bt_conn.Text = "开始联机"
        Me.bt_conn.UseVisualStyleBackColor = True
        '
        'bt_colse
        '
        Me.bt_colse.Location = New System.Drawing.Point(242, 41)
        Me.bt_colse.Name = "bt_colse"
        Me.bt_colse.Size = New System.Drawing.Size(75, 23)
        Me.bt_colse.TabIndex = 5
        Me.bt_colse.Text = "停止联机"
        Me.bt_colse.UseVisualStyleBackColor = True
        '
        'text_info
        '
        Me.text_info.Location = New System.Drawing.Point(14, 92)
        Me.text_info.Multiline = True
        Me.text_info.Name = "text_info"
        Me.text_info.Size = New System.Drawing.Size(326, 72)
        Me.text_info.TabIndex = 6
        '
        'text_mess
        '
        Me.text_mess.Location = New System.Drawing.Point(12, 186)
        Me.text_mess.Multiline = True
        Me.text_mess.Name = "text_mess"
        Me.text_mess.Size = New System.Drawing.Size(326, 72)
        Me.text_mess.TabIndex = 7
        '
        'bt_send
        '
        Me.bt_send.Location = New System.Drawing.Point(242, 264)
        Me.bt_send.Name = "bt_send"
        Me.bt_send.Size = New System.Drawing.Size(75, 23)
        Me.bt_send.TabIndex = 8
        Me.bt_send.Text = "发送消息"
        Me.bt_send.UseVisualStyleBackColor = True
        '
        'bt_read_mess
        '
        Me.bt_read_mess.Location = New System.Drawing.Point(55, 264)
        Me.bt_read_mess.Name = "bt_read_mess"
        Me.bt_read_mess.Size = New System.Drawing.Size(75, 23)
        Me.bt_read_mess.TabIndex = 9
        Me.bt_read_mess.Text = "读取消息"
        Me.bt_read_mess.UseVisualStyleBackColor = True
        '
        'client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(398, 289)
        Me.Controls.Add(Me.bt_read_mess)
        Me.Controls.Add(Me.bt_send)
        Me.Controls.Add(Me.text_mess)
        Me.Controls.Add(Me.text_info)
        Me.Controls.Add(Me.bt_colse)
        Me.Controls.Add(Me.bt_conn)
        Me.Controls.Add(Me.t_port)
        Me.Controls.Add(Me.t_ipname)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "client"
        Me.Text = "client"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents t_ipname As System.Windows.Forms.TextBox
    Friend WithEvents t_port As System.Windows.Forms.TextBox
    Friend WithEvents bt_conn As System.Windows.Forms.Button
    Friend WithEvents bt_colse As System.Windows.Forms.Button
    Friend WithEvents text_info As System.Windows.Forms.TextBox
    Friend WithEvents text_mess As System.Windows.Forms.TextBox
    Friend WithEvents bt_send As System.Windows.Forms.Button
    Friend WithEvents bt_read_mess As System.Windows.Forms.Button
End Class

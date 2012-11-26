<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class h_mail
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(h_mail))
        Me.lb_from = New System.Windows.Forms.Label
        Me.txtFrom = New System.Windows.Forms.TextBox
        Me.lb_to = New System.Windows.Forms.Label
        Me.txtTo = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.lbSubject = New System.Windows.Forms.Label
        Me.txtSubject = New System.Windows.Forms.TextBox
        Me.txtData = New System.Windows.Forms.TextBox
        Me.bt_send = New System.Windows.Forms.Button
        Me.txt_attachment = New System.Windows.Forms.TextBox
        Me.ofdialog = New System.Windows.Forms.OpenFileDialog
        Me.bt_attachment = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'lb_from
        '
        Me.lb_from.AutoSize = True
        Me.lb_from.Location = New System.Drawing.Point(11, 13)
        Me.lb_from.Name = "lb_from"
        Me.lb_from.Size = New System.Drawing.Size(41, 12)
        Me.lb_from.TabIndex = 0
        Me.lb_from.Text = "寄件人"
        '
        'txtFrom
        '
        Me.txtFrom.Location = New System.Drawing.Point(57, 12)
        Me.txtFrom.Name = "txtFrom"
        Me.txtFrom.Size = New System.Drawing.Size(178, 21)
        Me.txtFrom.TabIndex = 1
        Me.txtFrom.Text = "knightc@139.com"
        '
        'lb_to
        '
        Me.lb_to.AutoSize = True
        Me.lb_to.Location = New System.Drawing.Point(12, 53)
        Me.lb_to.Name = "lb_to"
        Me.lb_to.Size = New System.Drawing.Size(41, 12)
        Me.lb_to.TabIndex = 2
        Me.lb_to.Text = "收件人"
        '
        'txtTo
        '
        Me.txtTo.Location = New System.Drawing.Point(59, 50)
        Me.txtTo.Name = "txtTo"
        Me.txtTo.Size = New System.Drawing.Size(178, 21)
        Me.txtTo.TabIndex = 3
        Me.txtTo.Text = "cheng-wei3@hnair.com"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 12)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "附件"
        '
        'lbSubject
        '
        Me.lbSubject.AutoSize = True
        Me.lbSubject.Location = New System.Drawing.Point(12, 164)
        Me.lbSubject.Name = "lbSubject"
        Me.lbSubject.Size = New System.Drawing.Size(29, 12)
        Me.lbSubject.TabIndex = 9
        Me.lbSubject.Text = "主题"
        '
        'txtSubject
        '
        Me.txtSubject.Location = New System.Drawing.Point(59, 155)
        Me.txtSubject.Name = "txtSubject"
        Me.txtSubject.Size = New System.Drawing.Size(178, 21)
        Me.txtSubject.TabIndex = 10
        Me.txtSubject.Text = "help me"
        '
        'txtData
        '
        Me.txtData.Location = New System.Drawing.Point(14, 195)
        Me.txtData.Multiline = True
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(598, 167)
        Me.txtData.TabIndex = 11
        Me.txtData.Text = "help me"
        '
        'bt_send
        '
        Me.bt_send.Location = New System.Drawing.Point(530, 374)
        Me.bt_send.Name = "bt_send"
        Me.bt_send.Size = New System.Drawing.Size(81, 20)
        Me.bt_send.TabIndex = 12
        Me.bt_send.Text = "发送"
        Me.bt_send.UseVisualStyleBackColor = True
        '
        'txt_attachment
        '
        Me.txt_attachment.Location = New System.Drawing.Point(57, 94)
        Me.txt_attachment.Name = "txt_attachment"
        Me.txt_attachment.Size = New System.Drawing.Size(178, 21)
        Me.txt_attachment.TabIndex = 13
        '
        'bt_attachment
        '
        Me.bt_attachment.Location = New System.Drawing.Point(241, 92)
        Me.bt_attachment.Name = "bt_attachment"
        Me.bt_attachment.Size = New System.Drawing.Size(32, 23)
        Me.bt_attachment.TabIndex = 14
        Me.bt_attachment.Text = "..."
        Me.bt_attachment.UseVisualStyleBackColor = True
        '
        'h_mail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(624, 401)
        Me.Controls.Add(Me.bt_attachment)
        Me.Controls.Add(Me.txt_attachment)
        Me.Controls.Add(Me.bt_send)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtSubject)
        Me.Controls.Add(Me.lbSubject)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTo)
        Me.Controls.Add(Me.lb_to)
        Me.Controls.Add(Me.txtFrom)
        Me.Controls.Add(Me.lb_from)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "h_mail"
        Me.Text = "联系作者"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lb_from As System.Windows.Forms.Label
    Friend WithEvents txtFrom As System.Windows.Forms.TextBox
    Friend WithEvents lb_to As System.Windows.Forms.Label
    Friend WithEvents txtTo As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents lbSubject As System.Windows.Forms.Label
    Friend WithEvents txtSubject As System.Windows.Forms.TextBox
    Friend WithEvents txtData As System.Windows.Forms.TextBox
    Friend WithEvents bt_send As System.Windows.Forms.Button
    Friend WithEvents txt_attachment As System.Windows.Forms.TextBox
    Friend WithEvents ofdialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents bt_attachment As System.Windows.Forms.Button
End Class

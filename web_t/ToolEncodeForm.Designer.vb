<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolEncodeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolEncodeForm))
        Me.gbox_encode = New System.Windows.Forms.GroupBox
        Me.text_box_encode = New System.Windows.Forms.TextBox
        Me.gbox_decode = New System.Windows.Forms.GroupBox
        Me.text_box_decode = New System.Windows.Forms.TextBox
        Me.combox_entype = New System.Windows.Forms.ComboBox
        Me.bt_encode = New System.Windows.Forms.Button
        Me.gbox_encode.SuspendLayout()
        Me.gbox_decode.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbox_encode
        '
        Me.gbox_encode.Controls.Add(Me.text_box_encode)
        Me.gbox_encode.Location = New System.Drawing.Point(0, 1)
        Me.gbox_encode.Name = "gbox_encode"
        Me.gbox_encode.Size = New System.Drawing.Size(561, 100)
        Me.gbox_encode.TabIndex = 0
        Me.gbox_encode.TabStop = False
        Me.gbox_encode.Text = "原文"
        '
        'text_box_encode
        '
        Me.text_box_encode.Location = New System.Drawing.Point(0, 11)
        Me.text_box_encode.Multiline = True
        Me.text_box_encode.Name = "text_box_encode"
        Me.text_box_encode.Size = New System.Drawing.Size(573, 88)
        Me.text_box_encode.TabIndex = 0
        '
        'gbox_decode
        '
        Me.gbox_decode.Controls.Add(Me.text_box_decode)
        Me.gbox_decode.Location = New System.Drawing.Point(0, 165)
        Me.gbox_decode.Name = "gbox_decode"
        Me.gbox_decode.Size = New System.Drawing.Size(561, 100)
        Me.gbox_decode.TabIndex = 1
        Me.gbox_decode.TabStop = False
        Me.gbox_decode.Text = "密文"
        '
        'text_box_decode
        '
        Me.text_box_decode.Location = New System.Drawing.Point(0, 14)
        Me.text_box_decode.Multiline = True
        Me.text_box_decode.Name = "text_box_decode"
        Me.text_box_decode.Size = New System.Drawing.Size(561, 86)
        Me.text_box_decode.TabIndex = 0
        '
        'combox_entype
        '
        Me.combox_entype.FormattingEnabled = True
        Me.combox_entype.Items.AddRange(New Object() {"gzip", "ungzip", "base64", "un_base64", "url", "un_url", "triple DES 加密", "triple DES 解密", "RSA加密", "RSA解密", "16进制字符串", "ASCII码"})
        Me.combox_entype.Location = New System.Drawing.Point(12, 120)
        Me.combox_entype.Name = "combox_entype"
        Me.combox_entype.Size = New System.Drawing.Size(121, 20)
        Me.combox_entype.TabIndex = 2
        '
        'bt_encode
        '
        Me.bt_encode.Location = New System.Drawing.Point(183, 117)
        Me.bt_encode.Name = "bt_encode"
        Me.bt_encode.Size = New System.Drawing.Size(75, 23)
        Me.bt_encode.TabIndex = 3
        Me.bt_encode.Text = "编码"
        Me.bt_encode.UseVisualStyleBackColor = True
        '
        't_encode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 268)
        Me.Controls.Add(Me.bt_encode)
        Me.Controls.Add(Me.combox_entype)
        Me.Controls.Add(Me.gbox_decode)
        Me.Controls.Add(Me.gbox_encode)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "t_encode"
        Me.Text = "编码规则"
        Me.gbox_encode.ResumeLayout(False)
        Me.gbox_encode.PerformLayout()
        Me.gbox_decode.ResumeLayout(False)
        Me.gbox_decode.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbox_encode As System.Windows.Forms.GroupBox
    Friend WithEvents text_box_encode As System.Windows.Forms.TextBox
    Friend WithEvents gbox_decode As System.Windows.Forms.GroupBox
    Friend WithEvents text_box_decode As System.Windows.Forms.TextBox
    Friend WithEvents combox_entype As System.Windows.Forms.ComboBox
    Friend WithEvents bt_encode As System.Windows.Forms.Button
End Class

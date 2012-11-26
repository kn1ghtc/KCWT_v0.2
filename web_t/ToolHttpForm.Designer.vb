<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToolHttpForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ToolHttpForm))
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.gbox_res_repon = New System.Windows.Forms.GroupBox()
        Me.txtbox_response = New System.Windows.Forms.TextBox()
        Me.gbox_res_stand = New System.Windows.Forms.GroupBox()
        Me.txtbox_httpStand = New System.Windows.Forms.TextBox()
        Me.gbox_res_define = New System.Windows.Forms.GroupBox()
        Me.RtxtboxParameterValues = New System.Windows.Forms.RichTextBox()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.RadioButton2 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.bt_crack_dictionary = New System.Windows.Forms.Button()
        Me.bt_tourl_txt = New System.Windows.Forms.Button()
        Me.bt_tranceto_stand = New System.Windows.Forms.Button()
        Me.bt_select_passdict = New System.Windows.Forms.Button()
        Me.bt_select_userdict = New System.Windows.Forms.Button()
        Me.txtbox_pass_dict = New System.Windows.Forms.TextBox()
        Me.txtbox_user_dict = New System.Windows.Forms.TextBox()
        Me.txtbox_pass = New System.Windows.Forms.TextBox()
        Me.txtbox_user = New System.Windows.Forms.TextBox()
        Me.lb_pass = New System.Windows.Forms.Label()
        Me.lb_user = New System.Windows.Forms.Label()
        Me.lb_crack = New System.Windows.Forms.Label()
        Me.bt_tourl = New System.Windows.Forms.Button()
        Me.method_http = New System.Windows.Forms.ComboBox()
        Me.txtbox_url = New System.Windows.Forms.TextBox()
        Me.lb_url = New System.Windows.Forms.Label()
        Me.ShapeContainer1 = New Microsoft.VisualBasic.PowerPacks.ShapeContainer()
        Me.BrowserShapeClick = New Microsoft.VisualBasic.PowerPacks.OvalShape()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.fileDialog_dict = New System.Windows.Forms.OpenFileDialog()
        Me.LabelHindParameter = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.gbox_res_repon.SuspendLayout()
        Me.gbox_res_stand.SuspendLayout()
        Me.gbox_res_define.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(728, 493)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.gbox_res_repon)
        Me.TabPage1.Controls.Add(Me.gbox_res_stand)
        Me.TabPage1.Controls.Add(Me.gbox_res_define)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(720, 467)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "http编辑"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'gbox_res_repon
        '
        Me.gbox_res_repon.Controls.Add(Me.txtbox_response)
        Me.gbox_res_repon.Location = New System.Drawing.Point(2, 289)
        Me.gbox_res_repon.Name = "gbox_res_repon"
        Me.gbox_res_repon.Size = New System.Drawing.Size(714, 176)
        Me.gbox_res_repon.TabIndex = 2
        Me.gbox_res_repon.TabStop = False
        Me.gbox_res_repon.Text = "响应信息"
        '
        'txtbox_response
        '
        Me.txtbox_response.Location = New System.Drawing.Point(2, 11)
        Me.txtbox_response.Multiline = True
        Me.txtbox_response.Name = "txtbox_response"
        Me.txtbox_response.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtbox_response.Size = New System.Drawing.Size(711, 162)
        Me.txtbox_response.TabIndex = 1
        '
        'gbox_res_stand
        '
        Me.gbox_res_stand.Controls.Add(Me.txtbox_httpStand)
        Me.gbox_res_stand.Location = New System.Drawing.Point(2, 178)
        Me.gbox_res_stand.Name = "gbox_res_stand"
        Me.gbox_res_stand.Size = New System.Drawing.Size(714, 100)
        Me.gbox_res_stand.TabIndex = 1
        Me.gbox_res_stand.TabStop = False
        Me.gbox_res_stand.Text = "标准格式"
        '
        'txtbox_httpStand
        '
        Me.txtbox_httpStand.Location = New System.Drawing.Point(1, 11)
        Me.txtbox_httpStand.Multiline = True
        Me.txtbox_httpStand.Name = "txtbox_httpStand"
        Me.txtbox_httpStand.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtbox_httpStand.Size = New System.Drawing.Size(711, 89)
        Me.txtbox_httpStand.TabIndex = 0
        '
        'gbox_res_define
        '
        Me.gbox_res_define.Controls.Add(Me.LabelHindParameter)
        Me.gbox_res_define.Controls.Add(Me.RtxtboxParameterValues)
        Me.gbox_res_define.Controls.Add(Me.RichTextBox1)
        Me.gbox_res_define.Controls.Add(Me.RadioButton2)
        Me.gbox_res_define.Controls.Add(Me.RadioButton1)
        Me.gbox_res_define.Controls.Add(Me.bt_crack_dictionary)
        Me.gbox_res_define.Controls.Add(Me.bt_tourl_txt)
        Me.gbox_res_define.Controls.Add(Me.bt_tranceto_stand)
        Me.gbox_res_define.Controls.Add(Me.bt_select_passdict)
        Me.gbox_res_define.Controls.Add(Me.bt_select_userdict)
        Me.gbox_res_define.Controls.Add(Me.txtbox_pass_dict)
        Me.gbox_res_define.Controls.Add(Me.txtbox_user_dict)
        Me.gbox_res_define.Controls.Add(Me.txtbox_pass)
        Me.gbox_res_define.Controls.Add(Me.txtbox_user)
        Me.gbox_res_define.Controls.Add(Me.lb_pass)
        Me.gbox_res_define.Controls.Add(Me.lb_user)
        Me.gbox_res_define.Controls.Add(Me.lb_crack)
        Me.gbox_res_define.Controls.Add(Me.bt_tourl)
        Me.gbox_res_define.Controls.Add(Me.method_http)
        Me.gbox_res_define.Controls.Add(Me.txtbox_url)
        Me.gbox_res_define.Controls.Add(Me.lb_url)
        Me.gbox_res_define.Controls.Add(Me.ShapeContainer1)
        Me.gbox_res_define.Location = New System.Drawing.Point(0, 2)
        Me.gbox_res_define.Name = "gbox_res_define"
        Me.gbox_res_define.Size = New System.Drawing.Size(714, 170)
        Me.gbox_res_define.TabIndex = 0
        Me.gbox_res_define.TabStop = False
        Me.gbox_res_define.Text = "原始定义"
        '
        'RtxtboxParameterValues
        '
        Me.RtxtboxParameterValues.Location = New System.Drawing.Point(500, 40)
        Me.RtxtboxParameterValues.Name = "RtxtboxParameterValues"
        Me.RtxtboxParameterValues.Size = New System.Drawing.Size(195, 51)
        Me.RtxtboxParameterValues.TabIndex = 21
        Me.RtxtboxParameterValues.Text = "authenticity_token"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(513, 115)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(195, 51)
        Me.RichTextBox1.TabIndex = 20
        Me.RichTextBox1.Text = ""
        '
        'RadioButton2
        '
        Me.RadioButton2.AutoSize = True
        Me.RadioButton2.Location = New System.Drawing.Point(422, 147)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(83, 16)
        Me.RadioButton2.TabIndex = 19
        Me.RadioButton2.TabStop = True
        Me.RadioButton2.Text = "ErrKeyWord"
        Me.RadioButton2.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(422, 120)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(89, 16)
        Me.RadioButton1.TabIndex = 18
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "TrueKeyWord"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'bt_crack_dictionary
        '
        Me.bt_crack_dictionary.Location = New System.Drawing.Point(282, 53)
        Me.bt_crack_dictionary.Name = "bt_crack_dictionary"
        Me.bt_crack_dictionary.Size = New System.Drawing.Size(92, 23)
        Me.bt_crack_dictionary.TabIndex = 15
        Me.bt_crack_dictionary.Text = "Try Your Best "
        Me.bt_crack_dictionary.UseVisualStyleBackColor = True
        '
        'bt_tourl_txt
        '
        Me.bt_tourl_txt.Location = New System.Drawing.Point(191, 53)
        Me.bt_tourl_txt.Name = "bt_tourl_txt"
        Me.bt_tourl_txt.Size = New System.Drawing.Size(75, 23)
        Me.bt_tourl_txt.TabIndex = 14
        Me.bt_tourl_txt.Text = "文本提交"
        Me.bt_tourl_txt.UseVisualStyleBackColor = True
        '
        'bt_tranceto_stand
        '
        Me.bt_tranceto_stand.Location = New System.Drawing.Point(99, 52)
        Me.bt_tranceto_stand.Name = "bt_tranceto_stand"
        Me.bt_tranceto_stand.Size = New System.Drawing.Size(75, 23)
        Me.bt_tranceto_stand.TabIndex = 13
        Me.bt_tranceto_stand.Text = "转换文本"
        Me.bt_tranceto_stand.UseVisualStyleBackColor = True
        '
        'bt_select_passdict
        '
        Me.bt_select_passdict.Location = New System.Drawing.Point(309, 147)
        Me.bt_select_passdict.Name = "bt_select_passdict"
        Me.bt_select_passdict.Size = New System.Drawing.Size(91, 23)
        Me.bt_select_passdict.TabIndex = 12
        Me.bt_select_passdict.Text = "选择字典文件"
        Me.bt_select_passdict.UseVisualStyleBackColor = True
        '
        'bt_select_userdict
        '
        Me.bt_select_userdict.Location = New System.Drawing.Point(309, 115)
        Me.bt_select_userdict.Name = "bt_select_userdict"
        Me.bt_select_userdict.Size = New System.Drawing.Size(91, 23)
        Me.bt_select_userdict.TabIndex = 11
        Me.bt_select_userdict.Text = "选择字典文件"
        Me.bt_select_userdict.UseVisualStyleBackColor = True
        '
        'txtbox_pass_dict
        '
        Me.txtbox_pass_dict.Location = New System.Drawing.Point(191, 146)
        Me.txtbox_pass_dict.Name = "txtbox_pass_dict"
        Me.txtbox_pass_dict.Size = New System.Drawing.Size(100, 21)
        Me.txtbox_pass_dict.TabIndex = 10
        '
        'txtbox_user_dict
        '
        Me.txtbox_user_dict.Location = New System.Drawing.Point(191, 117)
        Me.txtbox_user_dict.Name = "txtbox_user_dict"
        Me.txtbox_user_dict.Size = New System.Drawing.Size(100, 21)
        Me.txtbox_user_dict.TabIndex = 9
        '
        'txtbox_pass
        '
        Me.txtbox_pass.Location = New System.Drawing.Point(65, 144)
        Me.txtbox_pass.Name = "txtbox_pass"
        Me.txtbox_pass.Size = New System.Drawing.Size(100, 21)
        Me.txtbox_pass.TabIndex = 8
        Me.txtbox_pass.Text = "password"
        '
        'txtbox_user
        '
        Me.txtbox_user.Location = New System.Drawing.Point(65, 117)
        Me.txtbox_user.Name = "txtbox_user"
        Me.txtbox_user.Size = New System.Drawing.Size(100, 21)
        Me.txtbox_user.TabIndex = 7
        Me.txtbox_user.Text = "username"
        '
        'lb_pass
        '
        Me.lb_pass.AutoSize = True
        Me.lb_pass.Location = New System.Drawing.Point(6, 146)
        Me.lb_pass.Name = "lb_pass"
        Me.lb_pass.Size = New System.Drawing.Size(29, 12)
        Me.lb_pass.TabIndex = 6
        Me.lb_pass.Text = "密码"
        '
        'lb_user
        '
        Me.lb_user.AutoSize = True
        Me.lb_user.Location = New System.Drawing.Point(7, 120)
        Me.lb_user.Name = "lb_user"
        Me.lb_user.Size = New System.Drawing.Size(41, 12)
        Me.lb_user.TabIndex = 5
        Me.lb_user.Text = "用户名"
        '
        'lb_crack
        '
        Me.lb_crack.AutoSize = True
        Me.lb_crack.Location = New System.Drawing.Point(6, 87)
        Me.lb_crack.Name = "lb_crack"
        Me.lb_crack.Size = New System.Drawing.Size(701, 12)
        Me.lb_crack.TabIndex = 4
        Me.lb_crack.Text = "-----------------------------------------------------暴力猜测------------------------" & _
            "-------------------------------"
        Me.lb_crack.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'bt_tourl
        '
        Me.bt_tourl.Location = New System.Drawing.Point(8, 51)
        Me.bt_tourl.Name = "bt_tourl"
        Me.bt_tourl.Size = New System.Drawing.Size(75, 23)
        Me.bt_tourl.TabIndex = 3
        Me.bt_tourl.Text = "直接提交"
        Me.bt_tourl.UseVisualStyleBackColor = True
        '
        'method_http
        '
        Me.method_http.FormattingEnabled = True
        Me.method_http.Items.AddRange(New Object() {"GET", "POST", "OPTIONS", "PUT", "DELETE"})
        Me.method_http.Location = New System.Drawing.Point(602, 14)
        Me.method_http.Name = "method_http"
        Me.method_http.Size = New System.Drawing.Size(75, 20)
        Me.method_http.TabIndex = 2
        '
        'txtbox_url
        '
        Me.txtbox_url.Location = New System.Drawing.Point(65, 14)
        Me.txtbox_url.Name = "txtbox_url"
        Me.txtbox_url.Size = New System.Drawing.Size(531, 21)
        Me.txtbox_url.TabIndex = 1
        '
        'lb_url
        '
        Me.lb_url.AutoSize = True
        Me.lb_url.Location = New System.Drawing.Point(6, 17)
        Me.lb_url.Name = "lb_url"
        Me.lb_url.Size = New System.Drawing.Size(53, 12)
        Me.lb_url.TabIndex = 0
        Me.lb_url.Text = "请求页面"
        '
        'ShapeContainer1
        '
        Me.ShapeContainer1.Location = New System.Drawing.Point(3, 17)
        Me.ShapeContainer1.Margin = New System.Windows.Forms.Padding(0)
        Me.ShapeContainer1.Name = "ShapeContainer1"
        Me.ShapeContainer1.Shapes.AddRange(New Microsoft.VisualBasic.PowerPacks.Shape() {Me.BrowserShapeClick})
        Me.ShapeContainer1.Size = New System.Drawing.Size(708, 150)
        Me.ShapeContainer1.TabIndex = 22
        Me.ShapeContainer1.TabStop = False
        '
        'BrowserShapeClick
        '
        Me.BrowserShapeClick.BorderColor = System.Drawing.Color.Navy
        Me.BrowserShapeClick.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BrowserShapeClick.FillGradientColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BrowserShapeClick.FillGradientStyle = Microsoft.VisualBasic.PowerPacks.FillGradientStyle.Central
        Me.BrowserShapeClick.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.LargeCheckerBoard
        Me.BrowserShapeClick.Location = New System.Drawing.Point(682, -1)
        Me.BrowserShapeClick.Name = "BrowserShapeClick"
        Me.BrowserShapeClick.Size = New System.Drawing.Size(19, 17)
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.WebBrowser1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(720, 467)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "浏览器显示"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(36, 65)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(602, 250)
        Me.WebBrowser1.TabIndex = 0
        '
        'fileDialog_dict
        '
        Me.fileDialog_dict.Filter = "(*.*)|*.*"
        '
        'LabelHindParameter
        '
        Me.LabelHindParameter.AutoSize = True
        Me.LabelHindParameter.Location = New System.Drawing.Point(380, 57)
        Me.LabelHindParameter.Name = "LabelHindParameter"
        Me.LabelHindParameter.Size = New System.Drawing.Size(113, 12)
        Me.LabelHindParameter.TabIndex = 23
        Me.LabelHindParameter.Text = "需要额外验证的参数"
        '
        'ToolHttpForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(728, 493)
        Me.Controls.Add(Me.TabControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ToolHttpForm"
        Me.Text = "请求响应"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.gbox_res_repon.ResumeLayout(False)
        Me.gbox_res_repon.PerformLayout()
        Me.gbox_res_stand.ResumeLayout(False)
        Me.gbox_res_stand.PerformLayout()
        Me.gbox_res_define.ResumeLayout(False)
        Me.gbox_res_define.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPage1 As System.Windows.Forms.TabPage
    Friend WithEvents TabPage2 As System.Windows.Forms.TabPage
    Friend WithEvents WebBrowser1 As System.Windows.Forms.WebBrowser
    Friend WithEvents gbox_res_define As System.Windows.Forms.GroupBox
    Friend WithEvents gbox_res_repon As System.Windows.Forms.GroupBox
    Friend WithEvents gbox_res_stand As System.Windows.Forms.GroupBox
    Friend WithEvents method_http As System.Windows.Forms.ComboBox
    Friend WithEvents txtbox_url As System.Windows.Forms.TextBox
    Friend WithEvents lb_url As System.Windows.Forms.Label
    Friend WithEvents lb_crack As System.Windows.Forms.Label
    Friend WithEvents bt_tourl As System.Windows.Forms.Button
    Friend WithEvents lb_pass As System.Windows.Forms.Label
    Friend WithEvents lb_user As System.Windows.Forms.Label
    Friend WithEvents txtbox_pass As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_user As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_pass_dict As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_user_dict As System.Windows.Forms.TextBox
    Friend WithEvents bt_select_passdict As System.Windows.Forms.Button
    Friend WithEvents bt_select_userdict As System.Windows.Forms.Button
    Friend WithEvents fileDialog_dict As System.Windows.Forms.OpenFileDialog
    Friend WithEvents txtbox_response As System.Windows.Forms.TextBox
    Friend WithEvents txtbox_httpStand As System.Windows.Forms.TextBox
    Friend WithEvents bt_crack_dictionary As System.Windows.Forms.Button
    Friend WithEvents bt_tourl_txt As System.Windows.Forms.Button
    Friend WithEvents bt_tranceto_stand As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RadioButton2 As System.Windows.Forms.RadioButton
    Friend WithEvents RadioButton1 As System.Windows.Forms.RadioButton
    Friend WithEvents RtxtboxParameterValues As System.Windows.Forms.RichTextBox
    Friend WithEvents ShapeContainer1 As Microsoft.VisualBasic.PowerPacks.ShapeContainer
    Friend WithEvents BrowserShapeClick As Microsoft.VisualBasic.PowerPacks.OvalShape
    Friend WithEvents LabelHindParameter As System.Windows.Forms.Label
End Class

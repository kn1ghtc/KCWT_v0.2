<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class conf_netscan
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(conf_netscan))
        Me.gbox_adapter = New System.Windows.Forms.GroupBox
        Me.bt_value = New System.Windows.Forms.Button
        Me.cbox_adaattr = New System.Windows.Forms.ComboBox
        Me.cbox_adaname = New System.Windows.Forms.ComboBox
        Me.gbox_adapter.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbox_adapter
        '
        Me.gbox_adapter.Controls.Add(Me.bt_value)
        Me.gbox_adapter.Controls.Add(Me.cbox_adaattr)
        Me.gbox_adapter.Controls.Add(Me.cbox_adaname)
        Me.gbox_adapter.Location = New System.Drawing.Point(2, 1)
        Me.gbox_adapter.Name = "gbox_adapter"
        Me.gbox_adapter.Size = New System.Drawing.Size(533, 105)
        Me.gbox_adapter.TabIndex = 0
        Me.gbox_adapter.TabStop = False
        Me.gbox_adapter.Text = "接口信息"
        '
        'bt_value
        '
        Me.bt_value.Location = New System.Drawing.Point(216, 37)
        Me.bt_value.Name = "bt_value"
        Me.bt_value.Size = New System.Drawing.Size(304, 62)
        Me.bt_value.TabIndex = 3
        Me.bt_value.Text = "获取属性值"
        Me.bt_value.UseVisualStyleBackColor = True
        '
        'cbox_adaattr
        '
        Me.cbox_adaattr.FormattingEnabled = True
        Me.cbox_adaattr.Items.AddRange(New Object() {"描述"})
        Me.cbox_adaattr.Location = New System.Drawing.Point(6, 47)
        Me.cbox_adaattr.Name = "cbox_adaattr"
        Me.cbox_adaattr.Size = New System.Drawing.Size(121, 20)
        Me.cbox_adaattr.TabIndex = 2
        '
        'cbox_adaname
        '
        Me.cbox_adaname.FormattingEnabled = True
        Me.cbox_adaname.Location = New System.Drawing.Point(6, 11)
        Me.cbox_adaname.Name = "cbox_adaname"
        Me.cbox_adaname.Size = New System.Drawing.Size(521, 20)
        Me.cbox_adaname.TabIndex = 1
        '
        'conf_netscan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(534, 266)
        Me.Controls.Add(Me.gbox_adapter)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "conf_netscan"
        Me.Text = "网络刺探配置"
        Me.gbox_adapter.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbox_adapter As System.Windows.Forms.GroupBox
    Friend WithEvents cbox_adaname As System.Windows.Forms.ComboBox
    Friend WithEvents bt_value As System.Windows.Forms.Button
    Friend WithEvents cbox_adaattr As System.Windows.Forms.ComboBox
End Class

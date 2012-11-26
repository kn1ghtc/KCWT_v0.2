Imports System.Net
Imports System.Text
Imports System.IO
Imports System.Threading
Imports System.Net.Dns
Imports System.Net.Sockets
Imports System.Net.NetworkCredential
Imports System.Net.NetworkInformation
Imports winconf
Imports winnet
Imports winsec
Imports Microsoft.Win32
Imports MSXML2



'远程控制-内网代理，键盘记录，文件管理，屏幕，摄像头
'网络刺探-嗅探，端口扫描，密码扫描
'整体培训ppt-webshell、键盘hook、手机、漏洞、sql注入、跨站、嗅探中间人、ips与waf、

Public Class main

    '全局变量声明区
    Dim net As New KCNetDll
    Dim inject As New KCInjectDLL
    Dim keylog As New KCKeylogDLL
        Dim source_ip As String = ""  '状态栏中取本地ip的那一段字符串暂存
        Dim db_frame(,) As String
        Dim method As String = ""
        Dim url As String = ""
        Dim typ As String = ""
        Dim dbtype As String = ""
        Dim kword As String = ""
        Dim ret As String = ""
    'c-s
        Dim iport As Integer
        Private k_listen As Socket
        Private k_endSock As Socket
        Private bteAccept(65536) As Byte
        Private bteSend(65536) As Byte
        Dim hostname As String
        Dim strMiddle As String



        '窗体加载
        Private Sub main_load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

            hostname = GetHostName()
            m_status.Text = hostname
            Dim ipv4_addr As String = ""

            Dim ipaddr As IPAddress

            For Each ipaddr In GetHostAddresses(hostname)

                If ipaddr.IsIPv6LinkLocal = False Then
                    ipv4_addr = ipaddr.ToString
                    Exit For

                End If

            Next

            m_status.Text += "   内网IP地址: " + ipv4_addr
            source_ip = m_status.Text

        End Sub

        '鼠标右键主界面显示远程ip
    Private Sub show_ip_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles show_ip.Click

        Dim remotecont As String = ""
        Dim tmp As String = ""
        Dim tmp_s As String = ""
        Dim i As Integer
        Dim lxmlhttprequest As New XMLHTTP60

        lxmlhttprequest.open("GET", "http://submit.apnic.net/templates/yourip.html", False)
        'whois查询：http://wq.apnic.net/apnic-bin/whois.pl
        lxmlhttprequest.send()
        remotecont = lxmlhttprequest.responseText
        i = InStr(remotecont, "[", CompareMethod.Text) '[<strong>114.242.14.181</strong>]

        If Not i = 0 Then
            tmp_s = Mid(remotecont, i + 9, 15)
            tmp = tmp_s.Split(".")(0) + "." + tmp_s.Split(".")(1) + "." + tmp_s.Split(".")(2) + "." + Replace(Replace(Mid(tmp_s.Split(".")(3), 1, 3), "<", ""), "/", "")
            tmp = "  外网IP地址: " + tmp
        End If

        m_status.Text = source_ip + tmp

    End Sub
        '菜单工具栏--单击调用系统密码界面
        Private Sub tool_winpass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_winpass.Click
        ToolWinPasswordForm.Show()
    End Sub
    '菜单配置栏-单击调用网络刺探配置
    Private Sub menu_conf_net_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles menu_conf_net.Click
        conf_netscan.Show()
    End Sub
    '菜单工具栏-单击调用网络劫持，内网嗅探
    Private Sub tool_hijack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_hijack.Click
        t_hijack.Show()
    End Sub

    '注入分析页面
    '注入测试
    Private Sub bt_injec_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_injec.Click
        Try

            '获取基本注入条件值
            url = Trim(textbox_url.Text)

            If cbox_injec_type.SelectedItem <> Nothing Then
                typ = cbox_injec_type.SelectedItem.ToString
            End If
            If cbox_request.SelectedItem <> Nothing Then
                method = cbox_request.SelectedItem.ToString
            End If
            If cbox_dbtype.SelectedItem <> Nothing Then
                dbtype = cbox_dbtype.SelectedItem.ToString
            End If

            kword = Trim(textbox_keyword.Text)
            '放入类检测是否存在注入
            inject.inject_check(url, method, typ, dbtype, kword, ret)

            '根据检测返回的结果字符串，判断是否存在注入
            If ret.Split(":")(0) = "true" Then
                info_status.Text = "Maybe you can injection sucess!!"
            ElseIf ret.Split(":")(0) = "false" Then
                info_status.Text = "Sorry you cat't injec"
            End If


        Catch ex As Exception
            info_status.Text = ex.Message
        End Try

    End Sub

    '注入分析页面
    '注入获取信息--读取表结构
    Private Sub bt_getinfo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_getinfo.Click
        Dim mysqlAttanch As New mysqlSQL

        Select Case cbox_dbtype.SelectedItem.ToString
            Case "mysql"
                If cbox_injec_type.SelectedItem <> Nothing Then
                    typ = cbox_injec_type.SelectedItem.ToString
                End If
                db_frame = mysqlAttanch.inject_frame_mysql(url, method, typ)

        End Select

        For i = 0 To UBound(db_frame, 1)
            tv_struc.Nodes.Add(db_frame(i, 0))

        Next
    End Sub
    '注入分析页面
    '注入获取信息--获取列值
    Private Sub bt_getvalue_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_getvalue.Click

    End Sub
    '远程控制-键盘记录
    Private Sub bt_record_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_record.Click
        Try

            If bt_record.Text = "开始记录" Then

                Call keylog.EnableKBDHook()
                bt_record.Text = "停止记录"

            Else
                Call keylog.UnHookKBD()
                bt_record.Text = "开始记录"

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    '远程控制-监听-开始监听抛出
    Private Sub bt_startlisten_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_startlisten.Click
        Dim k_thread As New Thread(New ThreadStart(AddressOf startlisten))
        k_thread.Start()

    End Sub

    '远程控制-监听实例
    Public Sub startlisten()
        TextBox.CheckForIllegalCrossThreadCalls = False

        If textbox_port.Text.Length < 1 Then Return
        iport = Integer.Parse(textbox_port.Text)
        k_listen = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
        Dim bindEndPoint As New IPEndPoint(IPAddress.Parse(GetHostAddresses(hostname).GetValue(0).ToString), iport)

        Dim blnconn As Boolean = False

        Try
            k_listen.Bind(bindEndPoint)
            Dim k_asynCallBack As New AsyncCallback(AddressOf acceptEnd)

            k_listen.Listen(iport)
            k_listen.BeginAccept(k_asynCallBack, k_listen)
            textbox_message.Text = "等待联机中。。。。。。" + vbCrLf

            strMiddle += "//server send message..." + vbCrLf

        Catch ex As SocketException
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    '远程控制-监听实例-建立联机
    Private Sub acceptEnd(ByVal k_asynResult As IAsyncResult)

        k_endSock = k_listen.EndAccept(k_asynResult)
        textbox_message.Text += vbCrLf + "已经接受客户端联机要求！！"

    End Sub
    '远程控制-监听关闭
    Private Sub bt_stopconn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_stopconn.Click

        k_listen.Close()

    End Sub

    '远程控制-监听-读取消息线程启动
    Private Sub bt_mess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_mess.Click
        Dim k_thread As New Thread(New ThreadStart(AddressOf receiveStart))
        k_thread.Start()
    End Sub
    '远程控制-监听-读取消息接收数据启动
    Private Sub receiveStart()

        Dim k_asynCallBack As New AsyncCallback(AddressOf receiveData)
        k_endSock.BeginReceive(bteAccept, 0, 65536, 0, k_asynCallBack, k_endSock)
        textbox_message.Text = "开始接收客户端数据内容......"

    End Sub
    '远程控制-监听-读取消息接收数据方法
    Private Sub receiveData(ByVal k_asynResult As IAsyncResult)

        Dim intByte As Integer
        intByte = k_endSock.EndReceive(k_asynResult)
        If intByte > 0 Then
            strMiddle += Encoding.Default.GetString(bteAccept)
            textbox_message.Text += vbCrLf + strMiddle

        End If
        textbox_message.Text += vbCrLf + "接收数据完毕!!"

    End Sub

    '远程控制-监听-回送消息线程启动
    Private Sub bt_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_send.Click

        Dim k_thread As New Thread(New ThreadStart(AddressOf sendStart))
        k_thread.Start()

    End Sub

    '远程控制-监听-回送消息数据启动
    Private Sub sendStart()

        Dim k_asynCallBack As New AsyncCallback(AddressOf sendData)
        bteSend = Encoding.Default.GetBytes(textbox_message.Text)

        k_endSock.BeginSend(bteSend, 0, bteSend.Length, 0, SocketFlags.DontRoute, k_asynCallBack, k_endSock)
        textbox_message.Text += vbCrLf + "开始回传数据。。。。。。"

    End Sub
    '远程控制-监听-回送消息方法
    Private Sub sendData(ByVal k_asynResult As IAsyncResult)

        Dim intSend As Integer
        intSend = k_endSock.EndSend(k_asynResult)
        textbox_message.Text += vbCrLf + "数据传送完成，共传输 " + intSend.ToString + " 个字节！！"

    End Sub
    '菜单工具栏-编码窗口调出
    Private Sub menu_tool_encode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_tool_encode.Click
        ToolEncodeForm.Show()
    End Sub
    '远程控制-监听-测试（客户端呼出测试）
    Private Sub client_test_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles client_test.Click
        client.Show()
    End Sub
    '菜单帮助栏-邮件选项
    Private Sub help_mailto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles help_mailto.Click
        h_mail.Show()
    End Sub
    '菜单帮助栏-线上qq选项
    Private Sub menu_ls_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_ls.Click

        Dim lsbr As New WebBrowser
        lsbr.Navigate("http://wpa.qq.com/msgrd?V=1&Uin=540095317&Exe=QQ&Site=MSNSpaces&Menu=No")

    End Sub
    '菜单配置栏--ftp客户端
    Private Sub menu_conf_ftpclient_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_conf_ftpclient.Click
        ToolFtpClientForm.Show()
    End Sub
    Private Sub menu_conf_ftpserver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_conf_ftpserver.Click
        ToolFtpServerForm.Show()
    End Sub

    Private Sub bt_ip_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_ip.Click
        Try

            CboxIP.Items.Clear()

            For i = 0 To GetHostEntry(txtbox_url2ip.Text).AddressList.Length - 1
                CboxIP.Items.Add(GetHostEntry(txtbox_url2ip.Text).AddressList(i))
            Next
            CboxIP.SelectedItem = CboxIP.Items(index:=0)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub bt_aDns_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_aDns.Click

        Try

            txtboxDNS.Text = ""
            Dim ipaddr As IPAddress = IPAddress.Parse(CboxIP.SelectedItem.ToString)

            txtboxDNS.Text += GetHostEntry(txtbox_url2ip.Text).HostName + vbCrLf


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub tool_menu_monitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_menu_monitor.Click

        ToolDirectoryForm.Show()

    End Sub

    Private Sub menu_tool_request_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_tool_request.Click
        ToolHttpForm.Show()
    End Sub
    '菜单栏-工具-系统密码（显示：功能为获取win系统的用户名及密码密文）
    Private Sub menu_tool_syspass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_tool_syspass.Click
        ToolWinPasswordForm.Show()
    End Sub
    '菜单栏-工具-木马专家（显示：占位）
    Private Sub menu_tool_delmm_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_tool_delmm.Click



    End Sub
    '菜单栏-工具-内网专家（显示：嗅探与劫持）
    Private Sub menu_tool_eth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles menu_tool_eth.Click
        t_hijack.Show()
    End Sub
    '注入检测时的选项，一些特殊情况的配置：如代替空格的编码、更改cookie等绕过注入防护，注入中转，
    '<Script Language=JavaScript>alert(document.cookie="id="+escape("6 and 1=2"));</Script>
    Private Sub bt_options_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_options.Click



    End Sub

    Private Sub Foreach(ByVal ipaddr As IPAddress)
        Throw New NotImplementedException
    End Sub

    Private Sub tool_request_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles tool_request.Click
        ToolHttpForm.Show()

    End Sub
End Class

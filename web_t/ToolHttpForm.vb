Imports System.Net
Imports MSXML2
Imports System.Runtime.InteropServices
Imports System.Text




Public Class ToolHttpForm

    Dim un As Integer = 0
    Dim lxmlHttp As New XMLHTTP60
    Dim lxmlHttpGetParameter As New XMLHTTP60
    Dim ParameterStr As String = ""
    Dim success_user As String = ""
    Dim success_pass As String = ""
    '整理HttpHeader
    Public Const Content_type As String = "Content-Type" '请求对应的多媒体信息
    Public Const Content_lentgh As String = "Content-Length"  '请求的内容长度
    Public Const Accept As String = "Accept" '指定客户端能够接收的内容类型
    Public Const Accept_Charset As String = "Accept-Charset"  '浏览器可以接受的字符编码
    Public Const Accept_Encoding As String = "Accept-Encoding"  '浏览器支持的返回压缩编码类型
    Public Const Accept_Language As String = "Accept-Language"  '浏览器可接受的语言
    Public Const Accept_Ranges As String = "Accept-Ranges"  '可以请求网页实体的一个或多个范围字段
    Public Const Authorization As String = "Authorization"  'HTTP授权证书
    Public Const Cache_Control As String = "Cache-Control"  '指定请求和响应遵循的缓存机制
    Public Const Connection As String = "Connection"  '是否持久连接（http 1.1 默认持久）
    Public Const Cookie As String = "Cookie"  '所有该域名下cookie会一起发送
    Public Const Date_ As String = "Date"  '请求发送的日期时间
    Public Const Expect As String = "Expect"  '请求的特点服务器行为
    Public Const From_ As String = "From"  '
    Public Const Host_ As String = "Host"  '请求的域名和端口
    Public Const If_Match As String = "If-Match"  '
    Public Const If_Modified_Since As String = "If-Modified-Since"  '指定时间后，如果有被修改则成功，否则返回304
    Public Const If_None_Match As String = "If-None-Match"  '如果内容未改变返回304
    Public Const If_Range As String = "If-Range"  '
    Public Const If_Unmodified_Since As String = "If-Unmodified-Since"  '
    Public Const Max_Forwards As String = "Max-Forwards"  '限制信息通过代理和网关传送的时间
    Public Const Pragma As String = "Pragma"  '包含实现特定指令
    Public Const Proxy_Authorization As String = "Proxy-Authorization"  '
    Public Const Range As String = "Range"  '只请求实体一部分，指定范围
    Public Const Referer As String = "Referer"  '
    Public Const Upgrade As String = "Upgrade"  '指定传输协议
    Public Const User_Agent As String = "User-Agent"  '
    Public Const Via As String = "Via"




    '选择用户名字典
    Private Sub bt_select_userdict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_select_userdict.Click
        If fileDialog_dict.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtbox_user_dict.Text = fileDialog_dict.FileName

        End If
    End Sub

    '选择密码字典
    Private Sub bt_select_passdict_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_select_passdict.Click
        If fileDialog_dict.ShowDialog = Windows.Forms.DialogResult.OK Then
            txtbox_pass_dict.Text = fileDialog_dict.FileName

        End If
    End Sub

    '直接提交请求
    Private Sub bt_tourl_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_tourl.Click
        Try
            Dim url As String = txtbox_url.Text
            Dim method As String = method_http.SelectedItem.ToString

            lxmlHttp.open(method, url, False)
            lxmlHttp.send()

            txtbox_response.Text = "HTTP/1.1 " + lxmlHttp.status.ToString + " " + lxmlHttp.statusText + vbCrLf + lxmlHttp.getAllResponseHeaders + vbCrLf + lxmlHttp.responseText
            ' Dim comerror As New COMException

        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub

    '转换为文本型标准格式
    Private Sub bt_tranceto_stand_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_tranceto_stand.Click
        Try

            txtbox_httpStand.Text = User_Agent + ": Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0)" + _
                               vbCrLf + Accept + ": application/json, text/javascript, */*" + _
                               vbCrLf + Accept_Language + ": Accept-Language: zh-cn,zh;q=0.8,en-us;q=0.5,en" + _
                               vbCrLf + Accept_Encoding + ": gzip, deflate" + _
                               vbCrLf + Referer + ": " + _
                               vbCrLf + Cookie + ": "
            Dim url As String = txtbox_url.Text
            Dim method As String = method_http.SelectedItem.ToString
            Dim hostValue As String = (url.Split("?")(0)).Split("/")(2)

            Dim requestValue As String = Trim((url.Split("?")(0)).Replace(url.Split(":")(0) + "://" + hostValue, ""))
            Dim parameterValue As String = url.Split("?")(1)


            txtbox_httpStand.Text = method_http.SelectedItem.ToString + " " + requestValue + _
                                    vbCrLf + Host_ + ": " + hostValue + _
                                    vbCrLf + txtbox_httpStand.Text
            txtbox_httpStand.Text += vbCrLf + vbCrLf + vbCrLf + parameterValue

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '文本标准格式提交
    'UA:IE8:Mozilla/4.0 (compatible; MSIE 8.0; Windows NT 5.1; Trident/4.0)
    'UA:FIRFOX:Mozilla/5.0 (Windows NT 5.1; rv:13.0) Gecko/20100101 Firefox/13.0.1
    Private Sub bt_tourl_txt_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_tourl_txt.Click

        Try
            Dim requestString As String = txtbox_httpStand.Text
            Dim tmp() As String = requestString.Split(vbCrLf)

            Dim hostValue As String = LTrim(tmp(1).Split(":")(1))
            Dim parameterValue As String = tmp(tmp.Length - 1)
            Dim method As String = Trim(tmp(0).Split(" ")(0))
            Dim url As String = LTrim(tmp(0).Split(" ")(1))

            ''
            For i = 3 To tmp.Length - 4
                Dim head0 As String = Trim(tmp(i).Split(":")(0))
                Dim head1 As String = LTrim(tmp(i).Split(":")(1))
                lxmlHttp.setRequestHeader(head0, head1)
            Next

            lxmlHttp.open(method, "http://" + hostValue + url + "?" + parameterValue, False)
            lxmlHttp.send()
            txtbox_response.Text = "HTTP/1.1 " + lxmlHttp.status.ToString + " " + lxmlHttp.statusText + vbCrLf + lxmlHttp.getAllResponseHeaders + vbCrLf + lxmlHttp.responseText

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '进行强力猜测-字典
    Public Sub bt_crack_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_crack_dictionary.Click

        Dim tmpUSER(), tmpPASS()


        Try

            If File.Exists(txtbox_user_dict.Text) And File.Exists(txtbox_pass_dict.Text) Then
                tmpUSER = File.ReadAllLines(txtbox_user_dict.Text)
                tmpPASS = File.ReadAllLines(txtbox_pass_dict.Text)
                For i = 0 To tmpUSER.Length - 1
                    For j = 0 To tmpPASS.Length - 1
                        success_user = tmpUSER(i)
                        success_pass = tmpPASS(j)
                        ' lxmlHttpGetParameter.onreadystatechange = AsynResponseGetParameter()
                        lxmlHttpGetParameter.open("GET", txtbox_url.Text, False)
                        lxmlHttpGetParameter.setRequestHeader(If_Modified_Since, "0")
                        lxmlHttpGetParameter.send()

                        Dim remoteConte As String = ""
                        Dim ih As Integer
                        If lxmlHttpGetParameter.readyState = 4 Then
                            remoteConte = lxmlHttpGetParameter.responseText
                            ih = remoteConte.IndexOf(RtxtboxParameterValues.Text)
                            If Not ih = 0 Then
                                ParameterStr = Mid(remoteConte, ih + 42, 44)
                            End If
                        End If

                        Dim string_url As String = txtbox_url.Text + "?" + txtbox_user.Text + "=" + success_user + "&" + txtbox_pass.Text + "=" + success_pass + "&" + RtxtboxParameterValues.Text + "=" + ParameterStr
                        un = un + 1
                        ' lxmlHttp.onreadystatechange = AsynResponseVerifyValue()
                        lxmlHttp.open("POST", string_url, False)
                        lxmlHttp.send()
                        If lxmlHttp.readyState = 4 Then
                            If lxmlHttp.status = 200 And lxmlHttp.responseText.Contains("部门管理") Then
                                'And lxmlHttp.responseText.Contains("部门管理")
                                txtbox_response.Text += "200  " + txtbox_user.Text + ":= " + success_user + "  " + txtbox_pass.Text + ":= " + success_pass + un.ToString + "  " + ParameterStr + vbCrLf

                            End If
                        End If

                    Next
                Next

            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    '异步响应返回的页面，在提交测试用例前，获取随机的额外验证参数
    Public Function AsynResponseGetParameter()
        Dim remoteConte As String = ""

        Dim i As Integer

        Try
            If lxmlHttpGetParameter.readyState = 4 Then
                remoteConte = lxmlHttpGetParameter.responseText
                i = remoteConte.IndexOf(RtxtboxParameterValues.Text)
                If Not i = 0 Then
                    ParameterStr = Mid(remoteConte, i + 42, 44)
                    '   ParameterStr = ParameterStr.Split("")(4)

                End If


            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    '异步响应验证返回的结果页面：跟正确页面或者错误页面对比，显示成功的测试用例
    Public Function AsynResponseVerifyValue()

        Try
            If lxmlHttp.readyState = 4 Then
                If lxmlHttp.status = 200 And lxmlHttp.responseText.Contains("部门管理") Then
                    'And lxmlHttp.responseText.Contains("部门管理")
                    txtbox_response.Text += "200  " + txtbox_user.Text + ":= " + success_user + "  " + txtbox_pass.Text + ":= " + success_pass + un.ToString + "  " + ParameterStr + vbCrLf

                End If
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Function

    '浏览器里显示响应结果-圆圈
    Private Sub BrowserShapeClick_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BrowserShapeClick.Click

    End Sub
End Class
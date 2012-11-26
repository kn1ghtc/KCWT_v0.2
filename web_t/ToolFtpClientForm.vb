Imports System.Net
Imports System.IO
Imports winnet
Imports System.Net.Sockets

Public Class ToolFtpClientForm

    Dim kc_ftp As New winnet.KCFtpclientDLL



    Private Sub bt_login_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_login.Click
        Dim strUSER As String = txt_usr.Text
        Dim strPASS As String = txt_pa.Text
        Dim strSERVER As String = txt_ser.Text

        'login
        kc_ftp.login_in(strUSER, strPASS, strSERVER)

        txt_mess.Text = kc_ftp.getReturnNameMess
        txt_mess.Text += kc_ftp.getReturnPWDMess


    End Sub

    Private Sub bt_exit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_exit.Click

        Dim strRETURN As String = ""
        strRETURN = kc_ftp.quit(strRETURN)
        txt_mess.Text += vbCrLf + strRETURN


    End Sub

    '远程添加目录-combox
    Private Sub bt_addre_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_addre.Click
        Dim strRETURN As String = kc_ftp.creatDir(Trim(comb_remote.Text))
        txt_mess.Text += vbCrLf + strRETURN

    End Sub

    '右键显示当前工作目录
    Private Sub right_mouse_pwd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right_mouse_pwd.Click
        Dim strRETURN As String = kc_ftp.printdir()
        txt_mess.Text += vbCrLf + strRETURN

    End Sub

    '远程添加目录-right_mouse
    Private Sub right_mouse_new_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right_mouse_new.Click
        Dim strRETURN As String = kc_ftp.creatDir(kc_ftp.printdir() + "newDirectory")
        txt_mess.Text += vbCrLf + strRETURN
    End Sub
    '远程删除目录-right_mouse
    Private Sub right_mouse_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles right_mouse_del.Click
        Dim strRETURN As String = kc_ftp.delDir(kc_ftp.printdir + tv_remote.SelectedNode.Name)
        txt_mess.Text += vbCrLf + strRETURN
    End Sub
    '本地目录变更
    Private Sub bt_addlo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_addlo.Click


    End Sub

    Private Sub bt_put_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_put.Click
        Dim srPath As String
        Dim desPATH As String
        Dim strMESS As String = ""

        If tv_local.SelectedNode.IsSelected = True Then
            srPath = tv_local.SelectedNode.Name
        Else
            srPath = comb_local.Text

        End If

        desPATH = kc_ftp.printdir()




        kc_ftp.UPload(srPath, desPATH, strMESS)
        txt_mess.Text += vbCrLf + strMESS
        MessageBox.Show("文件上传完成！！！")


    End Sub

    Private Sub bt_get_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_get.Click
        Dim srPath As String
        Dim desPATH As String
        Dim strMESS As String = ""

        srPath = kc_ftp.printdir() + tv_remote.SelectedNode.Name
        desPATH = "c:/"


        kc_ftp.Download(srPath, desPATH, strMESS)
        txt_mess.Text += vbCrLf + strMESS
        MessageBox.Show("文件下载完成！！！")

    End Sub
End Class
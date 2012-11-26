Imports System.Text
Imports System.Net.Sockets
Imports System.Net
Imports System.Threading

Public Class client

    Dim k_connSock As Socket
    Dim strMiddle As String
    Dim bteAccept(65536) As Byte
    Dim bteSend(65536) As Byte


    '联机客户端-建立联机线程启动
    Private Sub bt_conn_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_conn.Click
        If t_ipname.Text.Length < 1 Or t_port.Text.Length < 1 Then Return
       
        Dim k_thread As New Thread(New ThreadStart(AddressOf StartConn))
        k_thread.Start()

    End Sub
    '联机客户端-建立联机方法
    Private Sub StartConn()
        Dim intport As Integer = Integer.Parse(t_port.Text)
        Dim bindEndPoint As IPEndPoint
        TextBox.CheckForIllegalCrossThreadCalls = False

        bindEndPoint = New IPEndPoint(IPAddress.Parse(t_ipname.Text), intport)
        k_connSock = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)

        Try

            Dim k_asynCallBack As New AsyncCallback(AddressOf ConnEnd)
            k_connSock.BeginConnect(bindEndPoint, k_asynCallBack, k_connSock)
            text_info.Text = "等待联机响应，开始整理数据......"
            
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub
    '联机客户端-建立联机异步结束返回
    Private Sub ConnEnd(ByVal k_asynResult As IAsyncResult)
        Try
            k_connSock.EndConnect(k_asynResult)
            text_info.Text += vbCrLf + "成功联机到服务器 ！！"


        Catch ex As Exception
            MessageBox.Show(ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try

    End Sub
    '联机客户端-发送数据线程启动
    Private Sub bt_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_send.Click
        Dim k_thread As New Thread(New ThreadStart(AddressOf sendStart))
        k_thread.Start()

    End Sub
    '联机客户端-发送数据方法
    Private Sub sendStart()
        Dim k_asynCallBack As New AsyncCallback(AddressOf sendData)

        bteSend = Encoding.Default.GetBytes(text_mess.Text)
        k_connSock.BeginSend(bteSend, 0, bteSend.Length, SocketFlags.DontRoute, k_asynCallBack, k_connSock)
        text_info.Text += vbCrLf + "开始传送数据到服务器......"


    End Sub
    '联机客户端-发送数据异步返回
    Private Sub sendData(ByVal k_asynResult As IAsyncResult)
        Dim lngSend As Integer
        lngSend = k_connSock.EndSend(k_asynResult)
        text_info.Text += vbCrLf + "数据传送完成，总共传送 " + lngSend.ToString + " 个字节 ！！"
    End Sub

    '联机客户端-读取消息线程启动
    Private Sub bt_read_mess_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_read_mess.Click
        Dim k_thread As New Thread(New ThreadStart(AddressOf readStart))
        k_thread.Start()
    End Sub
    '联机客户端-读取数据方法
    Public Sub readStart()
        Dim k_asynCallBack As New AsyncCallback(AddressOf readData)
        k_connSock.BeginReceive(bteAccept, 0, 65536, 0, k_asynCallBack, k_connSock)

        text_info.Text += vbCrLf + "开始接收读取数据......"
    End Sub

    '联机客户端-读取数据异步返回
    Private Sub readData(ByVal k_asynResult As IAsyncResult)

        Dim lngByte As Integer
        lngByte = k_connSock.EndReceive(k_asynResult)
        If lngByte > 0 Then
            strMiddle += Encoding.Default.GetString(bteAccept)
            text_mess.Text = "" + strMiddle
        End If
        text_info.Text += vbCrLf + "接收服务器返回消息如下"
    End Sub
    Private Sub bt_colse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_colse.Click
        k_connSock.Close()
        MessageBox.Show("结束联线操作")

    End Sub

End Class
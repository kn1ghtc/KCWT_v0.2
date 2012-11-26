Imports System.Net
Imports System.Net.Sockets
Imports System.IO
Imports System.Text

Public Class KCFtpclientDLL


    Private login_namemessage
    Private login_pwdmessage

    Private fclient As TcpClient
    Private dataclient As TcpClient
    Private ftpstream As Stream
    '登录方法
    Public Sub login_in(ByVal user As String, ByVal pwd As String, ByVal serverIP As String)
        Try
            fclient = New TcpClient(serverIP, 21)
            ftpstream = fclient.GetStream

            readstreamUR("")

            login_namemessage = readstreamUR("USER " + user + vbCrLf)
            login_pwdmessage = readstreamUR("PASS " + pwd + vbCrLf)

        Catch ex As Exception
            login_pwdmessage = ex.Message
        End Try


    End Sub
    '返回用户信息
    Public ReadOnly Property getReturnNameMess() As String
        Get
            Return login_namemessage
        End Get
    End Property
    '返回口令信息
    Public ReadOnly Property getReturnPWDMess() As String
        Get
            Return login_pwdmessage
        End Get
    End Property
    '显示当前目录命令
    Public Function printdir() As String
        Dim returnMessage As String = readstream("PWD ")
        returnMessage = "--当前工作目录--" + vbCrLf + returnMessage
        Return returnMessage

    End Function
    '建立目录
    Public Function creatDir(ByVal strDirPath As String) As String
        Dim returnMessage As String = readstreamUR("MKD " + strDirPath)
        returnMessage = "--建立目录--" + vbCrLf + returnMessage
        Return returnMessage
    End Function
    '删除目录
    Public Function delDir(ByVal strDirPath As String) As String
        Dim returnMessage As String = readstreamUR("RMD " + strDirPath)
        returnMessage = "--删除目录--" + vbCrLf + returnMessage
        Return returnMessage
    End Function
    '移到目录
    Public Function moveDir(ByVal strDirPath As String) As String
        Dim returnMessage As String = readstreamUR("CD " + strDirPath)
        returnMessage = "--移到目录--" + vbCrLf + returnMessage
        Return returnMessage
    End Function
    '退出方法
    Public Function quit(ByVal strfile As String) As String
        Try
            Return readstreamUR("BYE ")
        Catch ex As Exception
            Return ex.Message
        End Try

        ftpstream.Close()
        fclient.Close()

    End Function
    '文件上传
    Public Sub UPload(ByVal srPATH As String, ByVal desPATH As String, ByVal returnMESS As String)
        returnMESS = "--上传文件消息--" + vbCrLf
        Try
            Dim upFile As New FileStream(srPATH, FileMode.Open)
            Dim lngFile As Long = upFile.Length
            Dim bteUpFile(lngFile) As Byte

            Dim strMess As String = readstreamUR("PASV ")

            Dim upLoadStream As NetworkStream = getConnTcpClient(strMess)

            If upLoadStream Is Nothing Then
                returnMESS += "数据联机失败"
                Return

            End If

            returnMESS = strMess.Replace(Char.ConvertFromUtf32(0), "")
            returnMESS += readstream("Type 1 ")
            returnMESS += readstream("STOR " + desPATH)

            upLoadStream.Write(bteUpFile, 0, lngFile)

            upLoadStream.Close()
            upLoadStream = Nothing
            Me.dataclient.close()
            Me.dataclient = Nothing
            upFile.Close()
            returnMESS += readstream("")


        Catch ex As Exception
            returnMESS += ex.Message
        End Try

    End Sub
    '文件下载
    Public Sub Download(ByVal srPATH As String, ByVal desPATH As String, ByVal returnMESS As String)
        returnMESS += "--下载文件消息--" + vbCrLf
        Try
            Dim strMESS As String = readstreamUR("PASV")
            Dim downLoadStream As NetworkStream = getConnTcpClient(strMESS)

            If downLoadStream Is Nothing Then
                returnMESS += "数据联机失败"
            End If

            returnMESS = strMESS.Replace(Char.ConvertFromUtf32(0), "")
            returnMESS += readstream("Type 1 ")
            returnMESS += readstream("RETR " + srPATH)

            Dim bteDownFile(36000) As Byte
            Dim lngFile As Long
            Dim DownFile As New FileStream(desPATH, FileMode.Create)
            Do
                lngFile = downLoadStream.Read(bteDownFile, 0, 36000)
                DownFile.Write(bteDownFile, 0, lngFile)
            Loop While lngFile > 0

            downLoadStream.Close()
            downLoadStream = Nothing
            Me.dataclient.close()
            Me.dataclient = Nothing
            DownFile.Close()

            returnMESS += readstream("")

        Catch ex As Exception
            returnMESS += ex.Message
        End Try
    End Sub
    '上传下载时联机数据流获取
    Private Function getConnTcpClient(ByVal strMESS As String) As NetworkStream
        Dim i As Integer
        Dim strIP As String
        Dim strIPS() As String
        Dim strAddress As String
        Dim intPort As Integer

        Try
            strIP = strMESS.Substring(strMESS.IndexOf("(")).Replace("(", "")
            strIPS = strIP.Split(",")
            strIP = ""
            For i = 0 To 3
                strIP += strIPS(i) + "."

            Next
            strAddress = strIP.Substring(0, strIP.Length - 1)
            intPort = Integer.Parse(strIPS(4)) * 256 + Integer.Parse(strIPS(5).Substring(0, strIPS(5).IndexOf(")")))
            dataclient = New TcpClient()
            Dim cIP As New IPEndPoint(IPAddress.Parse(strAddress), intPort)
            dataclient.Connect(cIP)
            Return dataclient.GetStream

        Catch ex As Exception
            Return Nothing
        End Try


    End Function

    '命令执行的核心方法-写入与返回消息-非替换
    Private Function readstreamUR(ByVal cmd As String) As String
        If cmd.Length > 0 Then
            Dim bteSendByte() As Byte = Encoding.ASCII.GetBytes(cmd)
            ftpstream.Write(bteSendByte, 0, bteSendByte.Length)
        End If

        '取得服务器返回信息
        Dim intReturnByteLength As Integer = fclient.ReceiveBufferSize
        Dim bteReturnByte(intReturnByteLength) As Byte
        Dim intread As Integer = ftpstream.Read(bteReturnByte, 0, intReturnByteLength)


        Return Encoding.ASCII.GetString(bteReturnByte) + vbCrLf
    End Function
    '命令执行的核心方法-写入与返回消息-替换
    Private Function readstream(ByVal cmd As String) As String
        Return cmd + readstreamUR(cmd).Replace(Char.ConvertFromUtf32(0), "") + vbCrLf

    End Function

End Class

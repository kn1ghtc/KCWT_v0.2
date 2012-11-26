Imports System.Net
Imports System.Net.NetworkInformation

Public Class KCNetDll
    Public Function ping(ByVal str_ip As String, ByVal ret As String)
        Dim net_ping As New Ping
        Dim net_pinreplay As PingReply = net_ping.Send(str_ip)
        Dim addr As String = net_pinreplay.Address.ToString
        Dim buffer As String = net_pinreplay.Buffer.Length().ToString
        Dim t As String = net_pinreplay.Options.Ttl.ToString
        Dim sta As String = net_pinreplay.Status.ToString


        Select Case ret
            Case "addr"
                ret = addr
            Case "buffer"
                ret = buffer
            Case "t"
                ret = t
            Case "sta"
                ret = sta
        End Select


        Return ret
    End Function
End Class

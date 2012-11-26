Imports System.Text
Imports System.Net.Sockets


Module remote

    Sub Main()
        Dim strhostname As String = "cxx3"
        Dim iport As Integer = 614
        Dim k_client As TcpClient


        Try
            k_client = New TcpClient
            k_client.Connect(strhostname, iport)
            k_client.Client.Send(Encoding.Default.GetBytes("wo kao shou dao meiyou"))
            If k_client.Connected = True Then


                k_client.Client.Send(Encoding.Default.GetBytes("wo kao shou dao meiyou"))
            End If
           
            Console.ReadLine()


        Catch ex As Exception
            Console.WriteLine(ex.Message)

        End Try


    End Sub

End Module

Imports System.Text
Imports System.IO
Imports System.IO.Compression
Imports System.Security
Imports System.Security.Cryptography
Imports winsec


Public Class ToolEncodeForm


    Declare Function rsa_de Lib "libeay32.dll" ()

    '集中响应
    '增加16进制字符串与base64的互换
    Private Sub bt_encode_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_encode.Click
        Select Case Trim(combox_entype.Text.ToString)
            Case "gzip"
                text_box_decode.Text = encode_gzip(text_box_encode.Text.ToString)
            Case "ungzip"
                text_box_decode.Text = decode_gzip(text_box_encode.Text.ToString)
            Case "triple DES 加密"
                text_box_decode.Text = encrypt_3DES(text_box_encode.Text.ToString)

            Case "triple DES 解密"
                text_box_encode.Text = decrypt_3DES(text_box_decode.Text.ToString)
            Case "RSA加密"
                text_box_decode.Text = encrypt_RSA(text_box_encode.Text.ToString)
            Case "RSA解密"
                text_box_decode.Text = decrypt_RSA(text_box_encode.Text.ToString)
            Case "base64"
                text_box_decode.Text = Convert.ToBase64String(ASCIIEncoding.ASCII.GetBytes(text_box_encode.Text))
            Case "un_base64"
                text_box_decode.Text = ASCIIEncoding.ASCII.GetString(Convert.FromBase64String(text_box_encode.Text))

            Case "16进制字符串"
                text_box_decode.Text = Byte_to_Str(Encoding.ASCII.GetBytes(text_box_encode.Text), "16")
            Case "ASCII码"
                text_box_decode.Text = Byte_to_Str(Encoding.ASCII.GetBytes(text_box_encode.Text), "ASCII") + vbCrLf + "ok , another string to ascii" + vbCrLf + _
                string2ascii(text_box_encode.Text)

            Case "url"
                text_box_decode.Text = url2code(text_box_encode.Text)
            Case "un_url"
                text_box_decode.Text = code2url(text_box_encode.Text)
        End Select
    End Sub

    ''
    Private Function encode_gzip(ByVal strSr As String) As String

        Dim finStr As String = ""
        Dim lMemoryStream As New MemoryStream

        Try

            Dim lgzipStream As GZipStream = New GZipStream(lMemoryStream, CompressionMode.Compress, True)
            Dim srByte() As Byte = Encoding.UTF8.GetBytes(strSr)
            lgzipStream.Write(srByte, 0, srByte.Length)
            lgzipStream.Close()

            Dim lBufferData(lMemoryStream.Length - 1) As Byte
            lMemoryStream.Position = 0
            lMemoryStream.Read(lBufferData, 0, lMemoryStream.Length)


            finStr = System.Convert.ToBase64String(lBufferData)
            lMemoryStream.Close()
            'Return finStr
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return finStr

    End Function
    ''
    Private Function decode_gzip(ByVal strSr As String) As String
        Dim finStr As String = ""
        Dim lMemoryStream As New MemoryStream

        Try
            Dim srByte() As Byte = System.Convert.FromBase64String(strSr)
            lMemoryStream.Write(srByte, 0, srByte.Length)

            Dim lBufferData(lMemoryStream.Length - 1) As Byte
            lMemoryStream.Position = 0
            Dim lgzipStream As GZipStream = New GZipStream(lMemoryStream, CompressionMode.Decompress)
            lgzipStream.Read(lBufferData, 0, lMemoryStream.Length)

            finStr = Encoding.UTF8.GetString(lBufferData)
            lgzipStream.Close()
            lMemoryStream.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return finStr

    End Function

    ''
    Private Function encrypt_3DES(ByVal strSr As String) As String
        Dim finStr As String = ""
        Dim tmp() As String
        Dim iv As String = ""
        Dim key As String = ""
        Dim lMemoryStream As New MemoryStream

        If File.Exists("kt.cfg") Then
            tmp = File.ReadAllLines("kt.cfg")

            For i = 0 To tmp.Length - 1
                If tmp(i).Split(":")(0) = "3DES" Then
                    iv = tmp(i).Split(":")(1)
                    key = tmp(i).Split(":")(2)
                End If

            Next
        End If

        Try
            '定义iv，key
            Dim lDESProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
            lDESProvider.IV = ASCIIEncoding.ASCII.GetBytes(iv)
            lDESProvider.Key = ASCIIEncoding.ASCII.GetBytes(key)
            Dim newICryptoTransform As ICryptoTransform = lDESProvider.CreateEncryptor(lDESProvider.Key, lDESProvider.IV)

            '形成加密数据流
            Dim lCryptoStream As CryptoStream = New CryptoStream(lMemoryStream, newICryptoTransform, CryptoStreamMode.Write)
            '写入数据进行加密
            Dim srByte() As Byte = ASCIIEncoding.ASCII.GetBytes(strSr)
            lCryptoStream.Write(srByte, 0, srByte.Length)

            '读取加密后的字符串
            Dim lBufferData(lMemoryStream.Length - 1) As Byte
            lMemoryStream.Position = 0
            lMemoryStream.Read(lBufferData, 0, lMemoryStream.Length)

            finStr = ASCIIEncoding.ASCII.GetString(lBufferData)
            lCryptoStream.Close()
            lMemoryStream.Close()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return finStr
    End Function

    Private Function decrypt_3DES(ByVal strSr As String) As String
        Dim finStr As String = ""
        Dim tmp() As String
        Dim iv As String = ""
        Dim key As String = ""
        Dim lMemoryStream As New MemoryStream

        If File.Exists("kt.cfg") Then
            tmp = File.ReadAllLines("kt.cfg")

            For i = 0 To tmp.Length - 1
                If tmp(i).Split(":")(0) = "3DES" Then
                    iv = tmp(i).Split(":")(1)
                    key = tmp(i).Split(":")(2)
                End If

            Next
        End If

        Try
            '定义iv，key
            Dim lDESProvider As TripleDESCryptoServiceProvider = New TripleDESCryptoServiceProvider()
            lDESProvider.IV = ASCIIEncoding.ASCII.GetBytes(iv)
            lDESProvider.Key = ASCIIEncoding.ASCII.GetBytes(key)
            Dim newICryptoTransform As ICryptoTransform = lDESProvider.CreateDecryptor(lDESProvider.Key, lDESProvider.IV)
            '写入数据进行解密
            Dim srByte() As Byte = ASCIIEncoding.ASCII.GetBytes(strSr)
            lMemoryStream.Write(srByte, 0, srByte.Length)
            '形成解密数据流
            Dim lCryptoStream As CryptoStream = New CryptoStream(lMemoryStream, newICryptoTransform, CryptoStreamMode.Read)


            '读取加密后的字符串
            Dim lBufferData(lMemoryStream.Length - 1) As Byte
            lMemoryStream.Position = 0
            lCryptoStream.Read(lBufferData, 0, lMemoryStream.Length)

            finStr = ASCIIEncoding.ASCII.GetString(lBufferData)

            'Dim rdesStream As New StreamReader(lMemoryStream)
            'finStr = rdesStream.ReadToEnd()

            lCryptoStream.Close()
            'rdesStream.Close()


        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Return finStr
    End Function
    'gopay_test
    'email=cheng-wei3@hnair.com&loginAuthCode=&safeCtl=1&userType=1&password=503E1AA86B9958D8C5C1B0D344C8AC1BE34FED557A6F83B52A47AFFC0AED842D626E25B2300BD22D7E13DFB53B70AC0F4655A2A8C14D24440D8929D0C33332677FD0D624A9BEEE3995A671603E0BB1787A0D90824A840F178F251A631F21918146F0C6C1D108EF3478F7BF37A946383C8ED761199FBB193BD4BF0B5D6847CC65
    Private Function encrypt_RSA(ByVal strSr As String) As String
        Dim finStr As String = ""
        Try
            Dim PublicKey As String = "<RSAKeyValue><Modulus>MIGfMA0GCSqGSIb3DQEBAQUAA4GNADCBiQKBgQDNwZMagZS45+X1Ne3CvmNHo8y5gw6ywadIx5RZMaxPVKphvK9YAzw6T4zOhvWbNouVcGkPGODcEPvOGmm6QJcJEV1/FnShiBxUp45AmNSQLHqZ2qnzQPjc2lGx9l23lRx3+2+GVOJAkcizhrV+JiHSTyNBlgzztEOf3BgjREffuwID</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>"
            '<RSAKeyValue><Modulus>sfEJPz8GzAcfDgSUW0WBXuO3JfoQnZPabcxi80Si8MEDoDuNWcHe9r4oiw+mP3mkCg0g+is2L4kMww1YRVgkWNwz071i0U4ciI24fJNH28w9+4dtT61nul3mhSOVNbg8mRCJwchVE7f/AA32fs69nJDM0e0aFx8dKCbnYELLfz8=</Modulus><Exponent>AQAB</Exponent></RSAKeyValue>
            Dim lRSAProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider
            lRSAProvider.FromXmlString(PublicKey)

            Dim rsaEncryptByte() As Byte = lRSAProvider.Encrypt(Encoding.UTF8.GetBytes(strSr), False)

            finStr = Byte_to_Str(rsaEncryptByte, "16")
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return finStr
    End Function

    Private Function decrypt_RSA(ByVal strSr As String) As String

        Dim finStr As String = ""
        Dim PrivateKey() As Char = "MIICXAIBAAKBgQDNwZMagZS45+X1Ne3CvmNHo8y5gw6ywadIx5RZMaxPVKphvK9YAzw6T4zOhvWbNouVcGkPGODcEPvOGmm6QJcJEV1/FnShiBxUp45AmNSQLHqZ2qnzQPjc2lGx9l23lRx3(+2 + GVOJAkcizhrV + JiHSTyNBlgzztEOf3BgjREffuwIDAQAB)AoGAE32CscAUlm9hGRlCrG/cd6zMd8YyXjx53CsLomdSKzGZ8igtc+jai6t9axLdsRY5oq5DRWrV4gK514wo97umksnGFwg8sbBfKGck/xxRGJjG2QQE7Y61ioT86xcAf/XNYkuDbWfz8H2Q4BwppMQ83xdZYLVaE0ukOf3kcV/BQAECQQDymNDFCyfv6/5+BwZw15N/HSAimAptIhvTtlIuqfxEBUPJ78DB3yf8uea6XlHWQqTuvVrS/sCjXmnb08025jg7AkEA2R+zAWxdWCdlvMT9Zqj9lvR+jJu9ynlXrzUaVw8n7EBv3iENrqr+ycj1KvLYmwVO2hxU//i6v243O7aCvsH+gQJBAK+KgFZ0chubinUrJC/27dWm/5/IoJLDgZs6bFEz00RtAtZWVAZ1MXwgEKJ(+qXz + kFXoUpYmnMIaCUN2CSJWiA0CQF7S)Pi238ogGJKMs8HF(+Ccl8Gywy887R8V499bPhlZDSj0hV7RDD8qOTFKbeCYSh687L)Ir/rEzt42bxFN5IxTIECQBmCvQ6Om+tlvQoyUwxHIhpXLURl/xdmIJL9LPJeTLtq+VnSnE8J8afXB5AkufykeNYPJeuc/etKMsc87B3e62E="
        Try

            Dim lRSAProvider As RSACryptoServiceProvider = New RSACryptoServiceProvider

            ' Dim rsapr As RSAParameters = New RSAParameters
            'Array.Reverse(PrivateKey)

            'lRSAProvider.ImportCspBlob(ASCIIEncoding.ASCII.GetBytes(PrivateKey))
            'xml格式私钥的获取转换问题-dll导入问题

            lRSAProvider.FromXmlString(PrivateKey.ToString)

            Dim rsaDecryptByte() As Byte = lRSAProvider.Decrypt(Convert.FromBase64String(strSr), False)

            finStr = Encoding.UTF8.GetString(rsaDecryptByte)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return finStr

    End Function

    '16进制字符串与字节数组的互换——搭配gopay
    Private Function Byte_to_Str(ByVal srByte() As Byte, ByVal lType As String)
        Dim desStr As New StringBuilder
        Dim lhex As String = ""
        Dim lascii As String = ""
        Try


            Dim i As Integer
            If lType = "16" Then
                For i = 0 To srByte.Length - 1
                    lhex = srByte(i).ToString("X2")
                    If lhex.Length = 1 Then
                        lhex = "0" + lhex
                    End If
                    desStr.Append(lhex)

                Next

            ElseIf lType = "ASCII" Then
                For i = 0 To srByte.Length - 1
                    lascii = Asc(srByte(i))
                    desStr.Append(lascii)

                Next

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Return desStr.ToString
    End Function
    Private Function hexStr_to_Byte(ByVal strSr As String)

        Dim desByte(strSr.Length / 2) As Byte
        Dim i, j As Integer
        Try
            For j = 0 To desByte.Length - 1
                desByte(j) = Convert.ToByte(strSr.Substring(i, 2), 16)

                i += 2

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return desByte

    End Function

    Private Function string2ascii(ByVal strSr As String)
        Dim lascii As String = ""
        Dim i As Integer
        Try
            For i = 0 To strSr.Length - 1
                lascii += Asc(strSr.Substring(i, 1))

            Next
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return lascii
    End Function
    Private Function url2code(ByVal strSr As String)
        Dim strCode As String = ""
        Try
            Dim I As Integer
            Dim tempStr As String
            For I = 1 To Len(strSr)
                If Asc(Mid(strSr, I, 1)) < 0 Then
                    tempStr = CStr(Hex(Asc(Mid(strSr, I, 1))))
                    tempStr = "%" & tempStr.Remove(0, Len(tempStr) - 2)
                    tempStr = "%" & Mid(tempStr, 0, Len(tempStr) - 2) & tempStr
                    strCode += tempStr
                ElseIf (Asc(Mid(strSr, I, 1)) >= 65 And Asc(Mid(strSr, I, 1)) <= 90) Or (Asc(Mid(strSr, I, 1)) >= 97 And Asc(Mid(strSr, I, 1)) <= 122) Then
                    strCode += Mid(strSr, I, 1)
                Else
                    strCode += "%" & Hex(Asc(Mid(strSr, I, 1)))
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try


        Return strCode
    End Function

    Private Function code2url(ByVal strSr As String)
        Dim strUrl As String = ""
        Try
            Dim I As Integer
            For I = 1 To Len(strSr)
                If Mid(strSr, I, 1) = "%" Then
                    If Val("&H" & Mid(strSr, I + 1, 2)) > 127 Then
                        strUrl += Chr(Val("&H" & Mid(strSr, I + 1, 2) & Mid(strSr, I + 4, 2)))
                        I += 5
                    Else
                        strUrl += Chr(Val("&H" & Mid(strSr, I + 1, 2)))
                        I += 2
                    End If
                Else
                    strUrl += Mid(strSr, I, 1)
                End If
            Next

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        Return strUrl

    End Function
End Class
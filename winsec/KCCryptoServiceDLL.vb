Imports System.Security
Imports System.Security.Cryptography
Imports System.Text
Public Class KCCryptoServiceDLL

    Private Function RSA_sign(ByVal strPrivateKey As String, ByVal strSr As String) As String
        Dim RegistrationCode As String = ""

        Dim lRSACryptoServiceProvider As New RSACryptoServiceProvider
        lRSACryptoServiceProvider.FromXmlString(strPrivateKey)

        Dim lSignatureFormatter As RSAPKCS1SignatureFormatter = New RSAPKCS1SignatureFormatter(lRSACryptoServiceProvider)
        lSignatureFormatter.SetHashAlgorithm("SHA1")
        Dim srByte() As Byte = ASCIIEncoding.ASCII.GetBytes(strSr)
        Dim lsha As New SHA1Managed()
        Dim resultByte() As Byte = lsha.ComputeHash(srByte)

        RegistrationCode = System.Convert.ToBase64String(lSignatureFormatter.CreateSignature(resultByte))

        Return RegistrationCode
    End Function

    Private Function RSA_sign_verify(ByVal strPublicKey As String, ByVal RegistrationCode As String, ByVal strSr As String) As Boolean


        Dim lRSACryptoServiceProvider As New RSACryptoServiceProvider
        lRSACryptoServiceProvider.FromXmlString(strPublicKey)


        Dim lSignaturedeFormatter As RSAPKCS1SignatureDeformatter = New RSAPKCS1SignatureDeformatter(lRSACryptoServiceProvider)
        lSignaturedeFormatter.SetHashAlgorithm("SHA1")

        Dim Regin_code_Byte() As Byte = Convert.FromBase64String(RegistrationCode)

        Dim lsha As New SHA1Managed
        Dim srByte() As Byte = lsha.ComputeHash(ASCIIEncoding.ASCII.GetBytes(strSr))

        If lSignaturedeFormatter.VerifySignature(srByte, Regin_code_Byte) Then
            Return True
        Else
            Return False
        End If

    End Function




End Class

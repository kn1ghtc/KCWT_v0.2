Imports System.Net
Imports System.Text
Imports System.IO
Imports MSXML2


''' <summary>
''' 注入点检测与确认，返回注入类型，数据库类型，基本信息，可填充字段
''' author:kn1ghtc
''' QQ:540095317
''' </summary>
''' <remarks></remarks>
Public Class KCInjectDLL

    '注入点检测阶段：判断是否为注入点/注入类型/数据库类型/关键字
    Public Sub inject_check(ByVal url As String, ByVal method As String, ByVal typ As String, ByVal dbtype As String, ByVal kword As String, ByRef ret As String)

        '检测是否存在sql注入的语句，详细分类语句
        Dim SpecialWordInt0 As String = "':having 144=144:having kc=kc:and 144=186:" '原始语句
        Dim SpecialWordInt1 As String = "':having 144=144:having kc=kc:and 144=186:" '对照语句

        Dim SpecialWordStr As String = ""
        Dim SpecialWordSearch As String = ""
        Dim SpecialWordUnion As String = ""
        Dim SpecialWordErr As String = ""



        Dim lxmlhttprequest As New XMLHTTP60
        inject_check_type(typ)


        '默认使用post提交字符
        If method = "" Then
            method = "POST"
        End If
        '循环提交测试字符，获取返回的响应对象与返回结果字符串
        '指定类型按指定类型测试；未指定类型先主动检查类型，然后按检查的类型结果测试；主动检查类型后仍无法注入的，可强制尝试进行全部测试
        For i = 0 To SpecialWordInt0.Split(":").Length - 1
            lxmlhttprequest.open(method, url + "and 1=1", False)
            lxmlhttprequest.send()
            Dim str0 As String = lxmlhttprequest.responseText
            lxmlhttprequest.open(method, url + "and 1=2", False)
            lxmlhttprequest.send()
            Dim str1 As String = lxmlhttprequest.responseText
            If String.Equals(str0, str1) = False Then

                ' If lxmlhttprequest.status = 200 Then
                ret = "true" + ":" + "mysql"

                Exit For

            End If

            ret = "false" + ":" + "mysql"

            '每次返回的先对比状态码，再对比原始响应字符串，任何不满足皆判断为存在注入，设置ret=true
            '  If wresponse.StatusCode=
        Next



    End Sub

    Public Sub inject_check_type(ByVal typ As String)
        Dim lxml As New XMLHTTP60



    End Sub

End Class

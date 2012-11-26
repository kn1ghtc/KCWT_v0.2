Imports MSXML2



Public Class mysqlSQL






    '针对mysql注入的详细利用：基本信息获取；获取数据库框架-库/表/数据
    Public Function inject_frame_mysql(ByVal url As String, ByVal method As String, ByVal typ As String)

        If method = "" Then
            method = "POST"
        End If
        If typ = "" Then
            typ = "string"
        End If

        Select Case typ
            Case "int"

        End Select

        Dim frame(3, 1) As String
        frame(0, 0) = "mysql"
        frame(1, 0) = "user"
        frame(2, 0) = "pass"


        Return frame
    End Function
End Class

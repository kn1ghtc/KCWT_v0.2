Imports System.Windows.Forms
Imports System.Text
Imports System.IO
Imports System.Environment
Imports System.Security.Permissions
Imports Microsoft.VisualBasic



Public Class ToolDirectoryForm

    Public Const hostPath As String = "C:\WINDOWS\system32\drivers\etc\hosts"
    Private Sub bt_selectDirectory_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_selectDirectory.Click
        fbmonitorDialog.Description = "请选择要监控的目录"
        fbmonitorDialog.RootFolder = Environment.SpecialFolder.MyComputer
        Try


            If fbmonitorDialog.ShowDialog = DialogResult.OK Then
                txtbox_monitorDirectory.Text = fbmonitorDialog.SelectedPath
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "目录选择出错")
        End Try
    End Sub
    Private Sub bt_file_host_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_file_host.Click

        Try
            If File.Exists(hostPath) Then
                Dim f() As String = File.ReadAllLines(hostPath)
                For i = 0 To f.Length - 1
                    Rtxtbox_info.Text += f(i) + vbCrLf
                Next

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_put_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_put.Click
        Try
            Select Case CBbox_infEdit.Text

                Case "host文件"
                    Dim f() As String = File.ReadAllLines("kt.cfg")
                    For i = 0 To f.Length - 1
                        If f(i).Split(":")(0) = "host" Then
                            Dim fw As New StreamWriter(hostPath, True)
                            fw.WriteLine(f(i).Split(":")(1) + vbCrLf)
                            fw.Close()
                        End If
                    Next

            End Select
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub bt_offMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_offMonitor.Click
        FSWatcher.Dispose()
    End Sub
    Private Sub bt_onMonitor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_onMonitor.Click
        FSWatcher.Path = txtbox_monitorDirectory.Text
        Try


            AddHandler FSWatcher.Changed, AddressOf FSWatcher_Changed
            AddHandler FSWatcher.Deleted, AddressOf FSWatcher_Changed
            AddHandler FSWatcher.Created, AddressOf FSWatcher_Changed
            AddHandler FSWatcher.Renamed, AddressOf FSWatcher_Renamed
            AddHandler FSWatcher.Disposed, AddressOf FSWatcher_Disposed
            AddHandler FSWatcher.Error, AddressOf FSWatcher_Error
        Catch ex As Exception
            MessageBox.Show(ex.Message, "监控开启错误")
        End Try

    End Sub

    Private Sub FSWatcher_Changed(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FSWatcher.Changed
        Try


            Rtxtbox_info.Text += e.FullPath.ToString + " " + e.ChangeType.ToString + " 于 " + Date.Now + " 余 " + Date.Now.Second.ToString + "秒" + vbCrLf

        Catch ex As Exception
            MessageBox.Show(ex.Message, "监控改动不成功")
        End Try

    End Sub

    Private Sub FSWatcher_Created(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FSWatcher.Created

    End Sub

    Private Sub FSWatcher_Deleted(ByVal sender As Object, ByVal e As System.IO.FileSystemEventArgs) Handles FSWatcher.Deleted

    End Sub

    Private Sub FSWatcher_Disposed(ByVal sender As Object, ByVal e As System.EventArgs) Handles FSWatcher.Disposed

    End Sub

    Private Sub FSWatcher_Error(ByVal sender As Object, ByVal e As System.IO.ErrorEventArgs) Handles FSWatcher.Error

    End Sub

    Private Sub FSWatcher_Renamed(ByVal sender As Object, ByVal e As System.IO.RenamedEventArgs) Handles FSWatcher.Renamed

    End Sub
End Class
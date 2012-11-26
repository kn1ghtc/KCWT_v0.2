Imports System.Net.NetworkInformation


Public Class conf_netscan
    Dim lointer As NetworkInterface() = NetworkInterface.GetAllNetworkInterfaces()
    Private Sub conf_netscan_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Dim i As Integer = 1


        For Each adapter As NetworkInterface In lointer


            cbox_adaname.Items.Add(adapter.Name.ToString)
        Next

    End Sub


    Private Sub bt_value_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bt_value.Click
        Dim i As Integer
        i = cbox_adaname.SelectedIndex
        Select Trim(cbox_adaattr.SelectedItem.ToString)
            Case "描述"
                bt_value.Text = lointer(i).Description.ToString

            Case ""

                bt_value.Text = lointer(i).GetIPProperties.AnycastAddresses.ToString


        End Select
    End Sub
End Class
Public Class Home

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Dim confirm = MsgBox("Yakin menutup aplikasi?", MsgBoxStyle.OkCancel)

        If (confirm = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub ToolStripMenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem3.Click
        User.Show()
    End Sub

    Private Sub ToolStripMenuItem4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem4.Click
        WP.Show()
    End Sub
End Class
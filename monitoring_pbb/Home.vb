Public Class Home

    Private Sub ToolStripMenuItem7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripMenuItem7.Click
        Dim confirm = MsgBox("Yakin menutup aplikasi?", MsgBoxStyle.OkCancel)

        If (confirm = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub
End Class
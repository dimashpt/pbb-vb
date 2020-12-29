Public Class Login

    Dim SQL As String
    Dim DR As OdbcDataReader
    Dim CMD As OdbcCommand

    Private Sub login()
        Dim username = TextBox1.Text
        Dim password = TextBox2.Text

        Try
            SQL = "SELECT * FROM user WHERE username='" & username & "' AND password='" & Md5(password) & "'"
            CMD = New OdbcCommand(SQL, CONN)
            DR = CMD.ExecuteReader()

            If DR.Read = True Then
                Home.Show()
                Me.Hide()
            Else
                MsgBox("Username atau password salah!")
                TextBox2.Text = ""
                TextBox2.Focus()
            End If
        Catch ex As Exception
            MsgBox("Username atau password salah!")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        login()
    End Sub

    Private Sub Login_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
    End Sub

    Private Sub TextBox2_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub

    Private Sub TextBox1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            login()
        End If
    End Sub
End Class

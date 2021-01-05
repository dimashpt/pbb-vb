Public Class User
    Dim SQL As String
    Dim DR As OdbcDataReader
    Dim CMD As OdbcCommand
    Dim DA As OdbcDataAdapter
    Dim DS As DataSet

    Private Sub Edit_Action()
        Button1.Enabled = False
        Button2.Enabled = True
        Button3.Enabled = True
        Button4.Enabled = True
    End Sub

    Private Sub Add_Action()
        Button1.Enabled = True
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = True
    End Sub

    Private Sub Reset_Form()
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        ComboBox1.Text = ""
        Add_Action()
    End Sub

    Private Sub Lihat_Data()
        Dim DG = DataGridView1
        Add_Action()
        Try
            SQL = "SELECT id, nama, username, level FROM user WHERE NOT level='super'"
            DA = New OdbcDataAdapter(SQL, CONN)
            DS = New DataSet

            DS.Clear()
            DA.Fill(DS, "user")
            DG.DataSource = DS.Tables("user")
        Catch ex As Exception
            MsgBox("Ada kesalahan koneksi database - " & ex.Message)
        End Try
    End Sub

    Private Sub Tambah_Data()
        Dim name = TextBox1.Text,
            username = TextBox2.Text,
            password = TextBox3.Text,
            level = ComboBox1.Text

        If name = "" Or username = "" Or password = "" Or level = "" Then
            MsgBox("Anda harus mengisi semua data!")
        Else
            SQL = "INSERT INTO user VALUES (NULL, '" & username & "', '" & Md5(password) & "', '" & name & "', '" & level.ToLower() & "')"
            CMD = New OdbcCommand(SQL, CONN)

            CMD.ExecuteNonQuery()
            Reset_Form()
            Lihat_Data()
        End If
    End Sub

    Private Sub Edit_Data()
        Dim name = TextBox1.Text,
            username = TextBox2.Text,
            password = TextBox3.Text,
            level = ComboBox1.Text,
            id = TextBox4.Text

        If Not password = "" Then
            SQL = "UPDATE user SET username='" & username & "', password='" & Md5(password) & "', nama='" & name & "', level='" & level.ToLower() & "' WHERE id='" & id & "'"
        Else
            SQL = "UPDATE user SET username='" & username & "', nama='" & name & "', level='" & level.ToLower() & "' WHERE id='" & id & "'"
        End If

        CMD = New OdbcCommand(SQL, CONN)

        CMD.ExecuteNonQuery()
        Reset_Form()
        Lihat_Data()
    End Sub

    Private Sub Hapus_Data()
        Dim id = TextBox4.Text

        SQL = "DELETE FROM user WHERE id='" & id & "'"
        CMD = New OdbcCommand(SQL, CONN)

        CMD.ExecuteNonQuery()
        Reset_Form()
        Lihat_Data()
    End Sub

    Private Sub User_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        koneksi()
        Lihat_Data()
        Add_Action()
    End Sub

    Private Sub DataGridView1_CellClick(ByVal sender As Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Edit_Action()
        Dim i As Integer
        i = DataGridView1.CurrentRow.Index
        CMD = New OdbcCommand("SELECT id, nama, username, level FROM user WHERE ID='" & DataGridView1.Item(0, i).Value & "'", CONN)
        DR = CMD.ExecuteReader()
        DR.Read()

        If Not DR.HasRows Then
            TextBox1.Focus()
        Else
            TextBox1.Text = DR.Item("nama")
            TextBox2.Text = DR.Item("username")
            TextBox4.Text = DR.Item("id")
            ComboBox1.Text = DR.Item("level")
            TextBox1.Focus()
        End If
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Tambah_Data()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Edit_Data()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Hapus_Data()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Reset_Form()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Me.Close()
    End Sub

    Private Sub TextBox4_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged

    End Sub
End Class
Public Class WP
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
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        TextBox9.Text = ""
        ComboBox1.Text = ""
        ComboBox2.Text = ""
        ComboBox3.Text = ""
        ComboBox4.Text = ""
        ComboBox5.Text = ""
        ComboBox6.Text = ""
        Add_Action()
    End Sub

    Private Sub Lihat_Data()
        Dim DG = DataGridView1
        Add_Action()
        Try
            SQL = "SELECT npwp, nama_wp, alamat_wp, gender, pekerjaan, hp FROM wajib_pajak WHERE NOT gender='Perempuan'"
            DA = New OdbcDataAdapter(SQL, CONN)
            DS = New DataSet

            DS.Clear()
            DA.Fill(DS, "wajib_pajak")
            DG.DataSource = DS.Tables("wajib_pajak")
        Catch ex As Exception
            MsgBox("Ada kesalahan koneksi database - " & ex.Message)
        End Try
    End Sub

    Private Sub Tambah_Data()
        Dim nama_wp = TextBox2.Text,
            alamat_wp = TextBox3.Text,
            pekerjaan = TextBox4.Text,
            hp = TextBox5.Text,
            npwp = TextBox1.Text
        Dim gender As String
        If CheckBox1.Checked = True Then
            gender = CheckBox1.Text
        Else
            gender = CheckBox2.Text
            End If

        If npwp = "" Or nama_wp = "" Or alamat_wp = "" Or gender = "" Or pekerjaan = "" Or hp = "" Then
        Else
            SQL = "INSERT INTO user VALUES (NULL,'" & nama_wp & "', '" & alamat_wp & "', '" & gender & "', '" & pekerjaan & "', '" & hp & "')"
            CMD = New OdbcCommand(SQL, CONN)

            CMD.ExecuteNonQuery()
            Reset_Form()
            Lihat_Data()
        End If
    End Sub

    Private Sub Edit_Data()
        Dim nama_wp = TextBox2.Text,
            alamat_wp = TextBox3.Text,
            gender = "",
            pekerjaan = TextBox4.Text,
            npwp = TextBox1.Text


        If Not gender = "" Then
            SQL = "UPDATE user SET nama_wp='" & nama_wp & "', alamat_wp='" & alamat_wp & "', gender='" & gender & "', Pekerjaan='" & pekerjaan & "' WHERE NPWP='" & npwp & "'"
        Else
            If CheckBox1.Checked Then
                gender = "laki-laki"
            ElseIf CheckBox2.Checked Then
                gender = "perempuan"
            End If
            SQL = "UPDATE user SET nama_wp='" & nama_wp & "', alamat_wp='" & alamat_wp & "', pekerjaan='" & pekerjaan & "' WHERE NPWP='" & npwp & "'"
        End If

        CMD = New OdbcCommand(SQL, CONN)

        CMD.ExecuteNonQuery()
        Reset_Form()
        Lihat_Data()
    End Sub

    Private Sub Hapus_Data()
        Dim npwp = TextBox1.Text

        SQL = "DELETE FROM user WHERE NPWP='" & npwp & "'"
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
        CMD = New OdbcCommand("SELECT npwp, nama_wp, alamat_wp, gender, pekerjaan, hp FROM wajib_pajak WHERE npwp='" & DataGridView1.Item(0, i).Value & "'", CONN)
        DR = CMD.ExecuteReader()
        DR.Read()

        If Not DR.HasRows Then
            TextBox1.Focus()
        Else
            TextBox1.Text = DR.Item("npwp")
            TextBox2.Text = DR.Item("nama_wp")
            TextBox3.Text = DR.Item("alamat_wp")
            CheckBox1.Text = DR.Item("gender")
            CheckBox2.Text = DR.Item("gender")
            TextBox4.Text = DR.Item("pekerjaan")
            TextBox5.Text = DR.Item("hp")
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

End Class
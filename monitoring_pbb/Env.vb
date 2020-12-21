Imports System.Text

Module Env
    Public CONN As OdbcConnection

    Public Sub koneksi()
        Try
            CONN = New OdbcConnection
            CONN.ConnectionString = "DRIVER={MySQL ODBC 5.3 ANSI Driver}; SERVER=localhost; DATABASE=monitoring_pbb; USER=root; PASSWORD=; OPTION=2;"
            If CONN.State = ConnectionState.Closed Then
                CONN.Open()
            End If
        Catch ex As Exception
            MsgBox("Ada kesalahan saat koneksi ke database! - " & ex.Message)
        End Try
    End Sub

    Public Function Md5(ByVal strToHash As String) As String

        Dim md5Obj As New System.Security.Cryptography.MD5CryptoServiceProvider
        Dim bytesToHash() As Byte = System.Text.Encoding.ASCII.GetBytes(strToHash)

        bytesToHash = md5Obj.ComputeHash(bytesToHash)
        Dim strResult As New StringBuilder

        For Each b As Byte In bytesToHash
            strResult.Append(b.ToString("x2"))
        Next

        Return strResult.ToString
    End Function
End Module

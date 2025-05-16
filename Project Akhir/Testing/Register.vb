Imports MySql.Data.MySqlClient

Public Class register
    Private Sub btnDaftar_Click(sender As Object, e As EventArgs) Handles btnDaftar.Click
        koneksi() ' Panggil koneksi dari Module1

        ' Validasi input
        If txtUsername.Text = "" Or txtPassword.Text = "" Then
            MessageBox.Show("Semua kolom wajib diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        ' Cek apakah username sudah ada
        Dim cekCMD As New MySqlCommand("SELECT * FROM users WHERE username = @username", CONN)
        cekCMD.Parameters.AddWithValue("@username", txtUsername.Text)
        Dim reader As MySqlDataReader = cekCMD.ExecuteReader()

        If reader.HasRows Then
            reader.Close()
            MessageBox.Show("Username sudah terdaftar, silakan gunakan username lain.", "Gagal", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If
        reader.Close()

        ' Simpan data ke database
        Dim simpanCMD As New MySqlCommand("INSERT INTO users (username, password) VALUES (@username, @password)", CONN)
        simpanCMD.Parameters.AddWithValue("@username", txtUsername.Text)
        simpanCMD.Parameters.AddWithValue("@password", txtPassword.Text)

        Try
            simpanCMD.ExecuteNonQuery()
            MessageBox.Show("Registrasi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Clear()
            txtPassword.Clear()
        Catch ex As Exception
            MessageBox.Show("Registrasi gagal: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Login.Show()
        Me.Close()
    End Sub


End Class

Imports MySql.Data.MySqlClient

Public Class Login

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        koneksi() ' Panggil sub koneksi dari Module1

        Dim usernameInput As String = txtUsername.Text.Trim()
        Dim passwordInput As String = txtPassword.Text.Trim()

        ' Cek akun admin
        If usernameInput.ToLower() = "admin" And passwordInput = "admin123" Then
            MessageBox.Show("Login sebagai admin berhasil.", "Admin", MessageBoxButtons.OK, MessageBoxIcon.Information)
            txtUsername.Clear()
            txtPassword.Clear()
            Me.Hide()
            Admin_Panel.Show()
            Exit Sub
        End If

        Try
            Dim query As String = "SELECT * FROM users WHERE username = @username AND password = @password"
            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@username", txtUsername.Text.Trim())
            CMD.Parameters.AddWithValue("@password", txtPassword.Text.Trim())

            RD = CMD.ExecuteReader()

            If RD.HasRows Then
                RD.Read()
                MessageBox.Show("Login berhasil! Selamat datang, " & RD("username").ToString(), "Berhasil", MessageBoxButtons.OK, MessageBoxIcon.Information)

                ' Simpan userID ke variabel global jika dibutuhkan
                userIDLogin = RD("userID").ToString()
                usernameLogin = RD("username").ToString()

                ' Pindah ke form utama
                txtUsername.Clear()
                txtPassword.Clear()
                Me.Hide()
                Beranda.Show()
            Else
                MessageBox.Show("Username atau password salah!", "Gagal Login", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If

        Catch ex As Exception
            MessageBox.Show("Terjadi kesalahan saat login: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If RD IsNot Nothing Then RD.Close()
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Sub btnRegister_Click(sender As Object, e As EventArgs)
        register.Show()
        Me.Hide()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        register.Show()
        Me.Hide()
    End Sub




    'Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    '    Dim frm2 As New register()

    '    frm2.Show()

    'End Sub

End Class


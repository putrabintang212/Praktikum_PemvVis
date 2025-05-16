Imports Microsoft.Win32
Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Panel_Tambah
    Private Sub Panel_Tambah_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbKategori.Items.Add("Keyboard")
        cmbKategori.Items.Add("Mouse")
        cmbKategori.Items.Add("Laptop")
        cmbKategori.SelectedIndex = 0
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"
        If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
            txtPathGambar.Text = OpenFileDialog1.FileName
            picPreview.Image = Image.FromFile(txtPathGambar.Text)
        End If
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaBarang.Text = "" Or cmbKategori.Text = "" Or txtPathGambar.Text = "" Then
            MessageBox.Show("Data tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Try
            koneksi()

            ' Salin gambar ke folder lokal proyek
            Dim namaFile As String = Path.GetFileName(txtPathGambar.Text)
            Dim folderTujuan As String = Application.StartupPath & "\gambar\"
            If Not Directory.Exists(folderTujuan) Then
                Directory.CreateDirectory(folderTujuan)
            End If
            File.Copy(txtPathGambar.Text, folderTujuan & namaFile, True)

            Dim query As String = "INSERT INTO barang (namaBarang, kategori, stok, harga, gambar) 
                               VALUES (@nama, @kategori, @stok, @harga, @gambar)"

            CMD = New MySqlCommand(query, CONN)
            CMD.Parameters.AddWithValue("@nama", txtNamaBarang.Text.Trim())
            CMD.Parameters.AddWithValue("@kategori", cmbKategori.Text.ToLower())
            CMD.Parameters.AddWithValue("@stok", numStok.Value)
            CMD.Parameters.AddWithValue("@harga", txtHarga.Text)
            'CMD.Parameters.AddWithValue("@satuan", txtSatuan.Text.Trim())
            CMD.Parameters.AddWithValue("@gambar", namaFile)

            CMD.ExecuteNonQuery()

            MessageBox.Show("Produk berhasil ditambahkan!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Reset form
            txtNamaBarang.Clear()
            txtPathGambar.Clear()
            'txtSatuan.Clear()
            txtHarga.Text = 0
            numStok.Value = 0
            cmbKategori.SelectedIndex = 0

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Sub btnHapusProduk_Click(sender As Object, e As EventArgs) Handles btnHapusProduk.Click
        Panel_Hapus.Show()
        Me.Hide()
    End Sub

    Private Sub btnLihatProduk_Click(sender As Object, e As EventArgs) Handles btnLihatProduk.Click
        Panel_Lihat.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()

            Me.Close()
        End If
    End Sub

    Private Sub btnEditProduk_Click(sender As Object, e As EventArgs) Handles btnEditProduk.Click
        Panel_Edit.Show()
        Me.Close()
    End Sub

End Class
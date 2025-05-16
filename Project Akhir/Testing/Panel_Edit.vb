Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Panel_Edit
    Private idBarangEdit As Integer

    Private Sub Panel_Edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox kategori untuk input dan filter
        cmbKategori.Items.AddRange(New String() {"Keyboard", "Mouse", "Laptop"})
        cmbKategori.SelectedIndex = 0

        cmbFilter.Items.AddRange(New String() {"Semua", "Keyboard", "Mouse", "Laptop"})
        cmbFilter.SelectedIndex = 0

        TampilData()
    End Sub

    Private Sub btnLihatProduk_Click(sender As Object, e As EventArgs) Handles btnLihatProduk.Click
        Panel_Lihat.Show()
        Me.Close()
    End Sub

    Private Sub btnHapusProduk_Click(sender As Object, e As EventArgs) Handles btnHapusProduk.Click
        Panel_Hapus.Show()
        Me.Close()
    End Sub

    Private Sub btnTambahProduk_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Panel_Tambah.Show()
        Me.Close()
    End Sub

    ' Tampilkan data ke DataGridView
    Sub TampilData(Optional kategoriFilter As String = "")
        koneksi()
        Try
            Dim query As String = "SELECT barangID, namaBarang, kategori, harga, stok, satuan FROM barang"
            If kategoriFilter <> "" AndAlso kategoriFilter <> "Semua" Then
                query &= " WHERE kategori = @kategori"
            End If

            Dim cmd As New MySqlCommand(query, CONN)
            If kategoriFilter <> "" AndAlso kategoriFilter <> "Semua" Then
                cmd.Parameters.AddWithValue("@kategori", kategoriFilter)
            End If

            Dim da As New MySqlDataAdapter(cmd)
            Dim dt As New DataTable
            da.Fill(dt)
            dgvProduk.DataSource = dt
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    ' Filter berdasarkan kategori
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        TampilData(cmbFilter.SelectedItem.ToString())
    End Sub

    ' Browse gambar
    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles btnBrowse.Click
        Dim openFile As New OpenFileDialog
        openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFile.ShowDialog() = DialogResult.OK Then
            txtPathGambar.Text = openFile.FileName
            picPreview.Image = Image.FromFile(openFile.FileName)
        End If
    End Sub

    ' Simpan perubahan
    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtNamaBarang.Text = "" Or cmbKategori.Text = "" Or txtHarga.Text = "" Then
            MessageBox.Show("Pastikan semua data diisi.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        koneksi()
        Try
            Dim namaGambar As String = Path.GetFileName(txtPathGambar.Text)
            Dim folderGambar As String = Application.StartupPath & "\gambar\"
            If Not Directory.Exists(folderGambar) Then
                Directory.CreateDirectory(folderGambar)
            End If

            Dim pathTujuan As String = folderGambar & namaGambar
            If Not File.Exists(pathTujuan) And txtPathGambar.Text <> "" Then
                File.Copy(txtPathGambar.Text, pathTujuan)
            End If

            Dim query As String = "UPDATE barang SET namaBarang = @nama, kategori = @kategori, stok = @stok, harga = @harga, gambar = @gambar WHERE barangID = @id"
            Dim cmd As New MySqlCommand(query, CONN)

            cmd.Parameters.AddWithValue("@nama", txtNamaBarang.Text)
            cmd.Parameters.AddWithValue("@kategori", cmbKategori.Text)
            cmd.Parameters.AddWithValue("@stok", numStok.Value)
            cmd.Parameters.AddWithValue("@harga", txtHarga.Text)
            cmd.Parameters.AddWithValue("@gambar", namaGambar)
            cmd.Parameters.AddWithValue("@id", idBarangEdit)


            cmd.ExecuteNonQuery()
            MessageBox.Show("Data berhasil diperbarui.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tampilkan ulang data
            TampilData(cmbFilter.SelectedItem.ToString())

            ' Bersihkan input
            txtNamaBarang.Clear()
            cmbKategori.SelectedIndex = 0
            txtHarga.Clear()
            numStok.Value = 0
            txtPathGambar.Clear()
            picPreview.Image = Nothing

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan perubahan: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    ' Isi form dari DataGridView ketika diklik
    Private Sub dgvProduk_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvProduk.CellClick
        If e.RowIndex >= 0 Then
            Dim row As DataGridViewRow = dgvProduk.Rows(e.RowIndex)
            Dim idBarang As Integer = Convert.ToInt32(row.Cells("barangID").Value)
            LoadDataEdit(idBarang)
        End If
    End Sub

    ' Fungsi untuk load data berdasarkan barangID
    Public Sub LoadDataEdit(barangID As Integer)
        koneksi()
        idBarangEdit = barangID
        Try
            Dim query As String = "SELECT * FROM barang WHERE barangID = @id"
            Dim cmd As New MySqlCommand(query, CONN)
            cmd.Parameters.AddWithValue("@id", barangID)

            Dim reader As MySqlDataReader = cmd.ExecuteReader()
            If reader.Read() Then
                txtNamaBarang.Text = reader("namaBarang").ToString()
                cmbKategori.Text = reader("kategori").ToString()
                numStok.Value = Convert.ToInt32(reader("stok"))
                txtHarga.Text = reader("harga").ToString()
                txtPathGambar.Text = reader("gambar").ToString()

                Dim pathGambar As String = Application.StartupPath & "\gambar\" & reader("gambar").ToString()
                If File.Exists(pathGambar) Then
                    picPreview.Image = Image.FromFile(pathGambar)
                Else
                    picPreview.Image = Nothing
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat data: " & ex.Message)
        Finally
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()

            Me.Close()
        End If
    End Sub


End Class

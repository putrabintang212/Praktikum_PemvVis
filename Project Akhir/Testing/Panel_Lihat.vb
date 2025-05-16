Imports MySql.Data.MySqlClient

Public Class Panel_Lihat

    Private Sub Panel_Lihat_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Isi ComboBox Filter Kategori
        cmbFilter.Items.Clear()
        cmbFilter.Items.Add("Semua")
        cmbFilter.Items.Add("keyboard")
        cmbFilter.Items.Add("mouse")
        cmbFilter.Items.Add("laptop")
        cmbFilter.SelectedIndex = 0

        ' Tampilkan semua data saat form dibuka
        TampilData()
    End Sub

    Private Sub btnHapusProduk_Click(sender As Object, e As EventArgs) Handles btnHapusProduk.Click
        Panel_Hapus.Show()
        Me.Close()
    End Sub

    Private Sub btnTambahProduk_Click(sender As Object, e As EventArgs) Handles btnTambahProduk.Click
        Panel_Tambah.Show()
        Me.Close()
    End Sub

    ' Menampilkan data berdasarkan kategori (jika ada)
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

    ' Saat filter berubah, tampilkan data berdasarkan kategori yang dipilih
    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        TampilData(cmbFilter.SelectedItem.ToString())
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Panel_Edit.Show()
        Me.Close()
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()

            Me.Close()
        End If
    End Sub

End Class

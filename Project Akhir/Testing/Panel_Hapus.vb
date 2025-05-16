Imports MySql.Data.MySqlClient

Public Class Panel_Hapus

    Private Sub btnTambahProduk_Click(sender As Object, e As EventArgs) Handles btnTambahProduk.Click
        Panel_Tambah.Show()
        Me.Hide()
    End Sub

    Private Sub btnLihatProduk_Click(sender As Object, e As EventArgs) Handles btnLihatProduk.Click
        Panel_Lihat.Show()
        Me.Close()
    End Sub

    Private Sub btnEditProduk_Click(sender As Object, e As EventArgs) Handles btnEditProduk.Click
        Panel_Edit.Show()
        Me.Close()
    End Sub

    Private Sub Panel_Hapus_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbFilter.Items.AddRange(New String() {"Semua", "Keyboard", "Mouse", "Laptop"})
        cmbFilter.SelectedIndex = 0

        TampilData(cmbFilter.SelectedItem.ToString())
    End Sub

    Private Sub cmbFilter_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbFilter.SelectedIndexChanged
        TampilData(cmbFilter.SelectedItem.ToString())
    End Sub


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


    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        If dgvProduk.SelectedRows.Count = 0 Then
            MessageBox.Show("Pilih produk yang ingin dihapus!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim idProduk As Integer = dgvProduk.SelectedRows(0).Cells("barangID").Value

        If MessageBox.Show("Yakin ingin menghapus produk ini?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            koneksi()
            Try
                Dim deleteDetailQuery As String = "DELETE FROM detailtransaksi WHERE barangID = @id"
                Dim cmdDetail As New MySqlCommand(deleteDetailQuery, CONN)
                cmdDetail.Parameters.AddWithValue("@id", idProduk)
                cmdDetail.ExecuteNonQuery()

                Dim query As String = "DELETE FROM barang WHERE barangID = @id"
                CMD = New MySqlCommand(query, CONN)
                CMD.Parameters.AddWithValue("@id", idProduk)
                CMD.ExecuteNonQuery()

                MessageBox.Show("Produk berhasil dihapus.", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)
                TampilData()
            Catch ex As Exception
                MessageBox.Show("Gagal menghapus produk: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                If CONN.State = ConnectionState.Open Then CONN.Close()
            End Try
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()

            Me.Close()
        End If
    End Sub


End Class
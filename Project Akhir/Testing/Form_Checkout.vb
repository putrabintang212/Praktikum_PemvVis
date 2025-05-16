Imports MySql.Data.MySqlClient

Public Class Form_Checkout
    Private daftarBarang As List(Of BarangTerpilih)
    Private totalHarga As Decimal = 0

    ' Menerima data dari Form Beranda
    Public Sub TerimaData(barang As List(Of BarangTerpilih))
        daftarBarang = barang
    End Sub

    Private Sub Form_Checkout_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblUser.Text = usernameLogin
        ListBoxBarang.Items.Clear()
        totalHarga = 0

        For Each item In daftarBarang
            ListBoxBarang.Items.Add($"{item.Nama} x {item.Jumlah} = Rp {item.Subtotal:#,##0.00}")
            totalHarga += item.Subtotal
        Next

        lblTotal.Text = "Total: Rp " & totalHarga.ToString("#,##0.00")
    End Sub


    Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles bayar.Click
        If daftarBarang Is Nothing OrElse daftarBarang.Count = 0 Then
            MessageBox.Show("Tidak ada barang yang dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Return
        End If

        Try
            CONN.Open()

            ' 1. Simpan transaksi
            Dim total As Decimal = daftarBarang.Sum(Function(b) b.Subtotal)
            Dim cmdTrans As New MySqlCommand("INSERT INTO transaksi (userID, tanggal, total) VALUES (@userID, @tanggal, @total); SELECT LAST_INSERT_ID();", CONN)
            cmdTrans.Parameters.AddWithValue("@userID", 1) ' Ganti dengan ID user aktif
            cmdTrans.Parameters.AddWithValue("@tanggal", Date.Today)
            cmdTrans.Parameters.AddWithValue("@total", total)

            Dim transaksiID As Integer = Convert.ToInt32(cmdTrans.ExecuteScalar())

            ' 2. Untuk setiap barang, simpan detail + kurangi stok
            For Each item In daftarBarang
                ' Ambil ID barang berdasarkan nama
                Dim cmdGetID As New MySqlCommand("SELECT barangID, stok FROM barang WHERE namaBarang = @nama", CONN)
                cmdGetID.Parameters.AddWithValue("@nama", item.Nama)
                Dim reader = cmdGetID.ExecuteReader()

                Dim barangID As Integer = 0
                Dim stokTersedia As Integer = 0
                If reader.Read() Then
                    barangID = reader("barangID")
                    stokTersedia = reader("stok")
                End If
                reader.Close()

                ' Validasi stok
                If item.Jumlah > stokTersedia Then
                    MessageBox.Show($"Stok tidak cukup untuk {item.Nama}", "Stok Kurang", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    CONN.Close()
                    Return
                End If

                ' Tambah ke detailtransaksi
                Dim cmdDetail As New MySqlCommand("INSERT INTO detailtransaksi (transaksiID, barangID, jumlah, subTotal) VALUES (@transID, @barangID, @jumlah, @subtotal)", CONN)
                cmdDetail.Parameters.AddWithValue("@transID", transaksiID)
                cmdDetail.Parameters.AddWithValue("@barangID", barangID)
                cmdDetail.Parameters.AddWithValue("@jumlah", item.Jumlah)
                cmdDetail.Parameters.AddWithValue("@subtotal", item.Subtotal)
                cmdDetail.ExecuteNonQuery()

                ' Update stok
                Dim cmdUpdate As New MySqlCommand("UPDATE barang SET stok = stok - @jumlah WHERE barangID = @barangID", CONN)
                cmdUpdate.Parameters.AddWithValue("@jumlah", item.Jumlah)
                cmdUpdate.Parameters.AddWithValue("@barangID", barangID)
                cmdUpdate.ExecuteNonQuery()
            Next

            CONN.Close()

            ' Tampilkan pesan sukses
            MessageBox.Show("Transaksi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

            ' Tampilkan struk
            Dim formStruk As New Struk()
            formStruk.TerimaDataStruk(daftarBarang, total)
            formStruk.ShowDialog()

            ' Tutup form checkout
            Me.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            If CONN.State = ConnectionState.Open Then CONN.Close()
        End Try
    End Sub


    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Beranda.Show()
        Me.Close()
    End Sub


    'Private Sub btnBayar_Click(sender As Object, e As EventArgs) Handles bayar.Click
    '    If daftarBarang Is Nothing OrElse daftarBarang.Count = 0 Then
    '        MessageBox.Show("Tidak ada barang yang dibeli.", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    '        Return
    '    End If



    '    ' Tampilkan pesan sukses
    '    MessageBox.Show("Transaksi berhasil!", "Sukses", MessageBoxButtons.OK, MessageBoxIcon.Information)

    '    ' Panggil Form Struk dan kirim data
    '    Dim formStruk As New Struk()
    '    formStruk.TerimaDataStruk(daftarBarang, totalHarga)
    '    formStruk.ShowDialog()

    '    ' Tutup form checkout
    '    Me.Close()
    'End Sub

    'Private Sub btnKonfirmasi_Click(sender As Object, e As EventArgs) Handles btnKonfirmasi.Click
    '    Try
    '        CONN.Open()

    '        ' 1. Simpan transaksi
    '        Dim total As Decimal = daftarBarang.Sum(Function(b) b.Subtotal)
    '        Dim cmdTrans As New MySqlCommand("INSERT INTO transaksi (userID, tanggal, total) VALUES (@userID, @tanggal, @total); SELECT LAST_INSERT_ID();", CONN)
    '        cmdTrans.Parameters.AddWithValue("@userID", 1) ' ganti dengan ID user aktif
    '        cmdTrans.Parameters.AddWithValue("@tanggal", Date.Today)
    '        cmdTrans.Parameters.AddWithValue("@total", total)

    '        Dim transaksiID As Integer = Convert.ToInt32(cmdTrans.ExecuteScalar())

    '        ' 2. Untuk setiap barang, simpan detail + kurangi stok
    '        For Each item In daftarBarang
    '            ' Ambil ID barang berdasarkan nama
    '            Dim cmdGetID As New MySqlCommand("SELECT barangID, stok FROM barang WHERE namaBarang = @nama", CONN)
    '            cmdGetID.Parameters.AddWithValue("@nama", item.Nama)
    '            Dim reader = cmdGetID.ExecuteReader()

    '            Dim barangID As Integer = 0
    '            Dim stokTersedia As Integer = 0
    '            If reader.Read() Then
    '                barangID = reader("barangID")
    '                stokTersedia = reader("stok")
    '            End If
    '            reader.Close()

    '            ' Validasi stok
    '            If item.Jumlah > stokTersedia Then
    '                MessageBox.Show($"Stok tidak cukup untuk {item.Nama}")
    '                CONN.Close()
    '                Exit Sub
    '            End If

    '            ' Tambah ke detailtransaksi
    '            Dim cmdDetail As New MySqlCommand("INSERT INTO detailtransaksi (transaksiID, barangID, jumlah, subTotal) VALUES (@transID, @barangID, @jumlah, @subtotal)", CONN)
    '            cmdDetail.Parameters.AddWithValue("@transID", transaksiID)
    '            cmdDetail.Parameters.AddWithValue("@barangID", barangID)
    '            cmdDetail.Parameters.AddWithValue("@jumlah", item.Jumlah)
    '            cmdDetail.Parameters.AddWithValue("@subtotal", item.Subtotal)
    '            cmdDetail.ExecuteNonQuery()

    '            ' Update stok
    '            Dim cmdUpdate As New MySqlCommand("UPDATE barang SET stok = stok - @jumlah WHERE barangID = @barangID", CONN)
    '            cmdUpdate.Parameters.AddWithValue("@jumlah", item.Jumlah)
    '            cmdUpdate.Parameters.AddWithValue("@barangID", barangID)
    '            cmdUpdate.ExecuteNonQuery()
    '        Next

    '        CONN.Close()

    '        ' Tampilkan struk
    '        Dim struk As New Struk()
    '        struk.TampilkanStruk(daftarBarang, total)
    '        struk.Show()
    '        Me.Close()

    '    Catch ex As Exception
    '        MessageBox.Show("Gagal menyimpan transaksi: " & ex.Message)
    '        If CONN.State = ConnectionState.Open Then CONN.Close()
    '    End Try
End Class

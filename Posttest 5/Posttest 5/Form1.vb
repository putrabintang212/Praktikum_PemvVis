Imports MySql.Data.MySqlClient

Public Class Form1
    Sub Kosong()
        txtKode.Clear()
        txtMerk.Clear()
        txtTipe.Clear()
        txtTahun.Clear()
        txtHarga.Clear()
        txtKode.Focus()
    End Sub

    Sub tampilMobil()
        DA = New MySqlDataAdapter("select * from tbMobil", CONN)
        DS = New DataSet
        DS.Clear()
        DA.Fill(DS, "mobil")
        DataGridView1.DataSource = DS.Tables("mobil")
        DataGridView1.Refresh()
    End Sub

    Sub CariMobil()
        DA = New MySqlDataAdapter("SELECT * FROM tbMobil WHERE kodeMobil LIKE '%" & txtSearch.Text & "%' OR merk LIKE '%" & txtSearch.Text & "%'", CONN)
        DS = New DataSet
        DA.Fill(DS, "mobil")
        DataGridView1.DataSource = DS.Tables("mobil")
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        koneksi()
        tampilMobil()
        Kosong()
    End Sub

    Private Sub btnSimpan_Click(sender As Object, e As EventArgs) Handles btnSimpan.Click
        If txtKode.Text = "" Or txtMerk.Text = "" Then
            MsgBox("Data belum lengkap!")
            Exit Sub
        End If

        CMD = New MySqlCommand("SELECT * FROM tbMobil WHERE kodeMobil = '" & txtKode.Text & "'", CONN)
        RD = CMD.ExecuteReader
        RD.Read()
        RD.Close()

        If Not RD.HasRows Then
            CMD = New MySqlCommand("INSERT INTO tbMobil VALUES('" & txtKode.Text & "', '" & txtMerk.Text & "', '" & txtTipe.Text & "', " & txtTahun.Text & ", " & txtHarga.Text & ")", CONN)
            CMD.ExecuteNonQuery()
            MsgBox("Data berhasil disimpan")
            tampilMobil()
            Kosong()
        Else
            MsgBox("Kode Mobil sudah ada")
        End If
    End Sub

    Private Sub btnUbah_Click(sender As Object, e As EventArgs) Handles btnUbah.Click
        CMD = New MySqlCommand("UPDATE tbMobil SET merk='" & txtMerk.Text & "', tipe='" & txtTipe.Text & "', tahun=" & txtTahun.Text & ", harga=" & txtHarga.Text & " WHERE kodeMobil='" & txtKode.Text & "'", CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil diubah")
        tampilMobil()
        Kosong()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles btnHapus.Click
        CMD = New MySqlCommand("DELETE FROM tbMobil WHERE kodeMobil='" & txtKode.Text & "'", CONN)
        CMD.ExecuteNonQuery()
        MsgBox("Data berhasil dihapus")
        tampilMobil()
        Kosong()
    End Sub

    Private Sub btnBatal_Click(sender As Object, e As EventArgs) Handles btnBatal.Click
        Kosong()
        tampilMobil()
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim row As DataGridViewRow = DataGridView1.Rows(e.RowIndex)
        txtKode.Text = row.Cells(0).Value.ToString
        txtMerk.Text = row.Cells(1).Value.ToString
        txtTipe.Text = row.Cells(2).Value.ToString
        txtTahun.Text = row.Cells(3).Value.ToString
        txtHarga.Text = row.Cells(4).Value.ToString
    End Sub

    Private Sub txtSearch_TextChanged(sender As Object, e As EventArgs) Handles txtSearch.TextChanged
        CariMobil()
    End Sub
End Class


Public Class Admin_Panel
    Private Sub Admin_Panel_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnTambahProduk_Click(sender As Object, e As EventArgs) Handles btnTambahProduk.Click
        Panel_Tambah.Show()
        Me.Hide()
    End Sub

    Private Sub btnHapusProduk_Click(sender As Object, e As EventArgs) Handles btnHapusProduk.Click
        Panel_Hapus.Show()
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

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
        If result = DialogResult.Yes Then
            Login.Show()

            Me.Close()
        End If
    End Sub
End Class
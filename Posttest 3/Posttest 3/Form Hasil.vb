Public Class Form_Hasil
    Public Sub SetData(nama As String, umur As String, telepon As String, alamat As String,
                        jenisKelamin As String, tanggalLahir As String, hobi As String, fotoPath As String)

        lblNama.Text = nama
        lblUmur.Text = umur
        lblTelp.Text = telepon
        lblAlamat.Text = alamat
        lblGender.Text = jenisKelamin
        lblTgl.Text = tanggalLahir
        lblHobi.Text = hobi

        If fotoPath <> "" Then
            PBhasil.Image = Image.FromFile(fotoPath)
        End If
    End Sub
End Class

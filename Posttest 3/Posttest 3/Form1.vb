Imports System.IO

Public Class Form1
    Dim selectedImagePath As String = ""

    Private Sub txtAngka_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextUmur.KeyPress, TextTelp.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtHuruf_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNama.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsLetter(e.KeyChar) AndAlso Not Char.IsWhiteSpace(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnBrowse_Click(sender As Object, e As EventArgs) Handles UpFoto.Click
        Dim openFileDialog As New OpenFileDialog
        openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp"

        If openFileDialog.ShowDialog() = DialogResult.OK Then
            selectedImagePath = openFileDialog.FileName
            PBox.Image = Image.FromFile(selectedImagePath)
            PBox.SizeMode = PictureBoxSizeMode.StretchImage
        End If
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles Cetak.Click
        If TextNama.Text = "" Or TextUmur.Text = "" Or TextTelp.Text = "" Or TextAlamat.Text = "" Then
            MessageBox.Show("Inputan tidak boleh kosong!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If TglLhr.Value > DateTime.Now Then
            MessageBox.Show("Tanggal lahir tidak valid!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        If Not Laki.Checked AndAlso Not Perempuan.Checked Then
            MessageBox.Show("Pilih jenis kelamin!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If

        Dim selectedHobbies As String = ""
        For Each ctrl As Control In GBHobi.Controls
            If TypeOf ctrl Is CheckBox AndAlso CType(ctrl, CheckBox).Checked Then
                selectedHobbies &= ctrl.Text & " "
            End If
        Next

        If selectedHobbies = "" Then
            MessageBox.Show("Pilih minimal satu hobi!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Exit Sub
        End If



        Dim formHasil As New Form_Hasil()
        formHasil.SetData(
            TextNama.Text, TextUmur.Text, TextTelp.Text, TextAlamat.Text,
            If(Laki.Checked, "Laki-Laki", "Perempuan"),
            TglLhr.Value.ToShortDateString(),
            selectedHobbies.TrimEnd(", "), selectedImagePath
)
        If Not String.IsNullOrEmpty(selectedImagePath) Then
            formHasil.PBhasil.Image = Image.FromFile(selectedImagePath)
            formHasil.PBhasil.SizeMode = PictureBoxSizeMode.StretchImage
        End If
        formHasil.Show()
    End Sub
End Class

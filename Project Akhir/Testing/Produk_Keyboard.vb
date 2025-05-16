Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Produk_Keyboard
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_arc")
    Dim cmd As MySqlCommand
    Dim dr As MySqlDataReader

    Private Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TampilBarang("laptop", "picLaptop", "lblNamaLaptop", "lblHargaLaptop", "lblStokLaptop", "chkLaptop", "numLaptop")
    End Sub

    Sub TampilBarang(kategori As String, picPrefix As String, namaPrefix As String, hargaPrefix As String, stokPrefix As String, chkPrefix As String, numPrefix As String)
        Try
            conn.Open()
            cmd = New MySqlCommand("SELECT * FROM barang WHERE kategori = @kategori", conn)
            cmd.Parameters.AddWithValue("@kategori", kategori)
            dr = cmd.ExecuteReader()

            Dim i As Integer = 1
            Dim folderGambar As String = Path.Combine(Application.StartupPath, "gambar")

            While dr.Read()
                Try
                    Dim pic As PictureBox = CType(Me.Controls(picPrefix & i), PictureBox)
                    Dim lblNama As Label = CType(Me.Controls(namaPrefix & i), Label)
                    Dim lblHarga As Label = CType(Me.Controls(hargaPrefix & i), Label)
                    Dim lblStok As Label = CType(Me.Controls(stokPrefix & i), Label)
                    Dim chk As CheckBox = CType(Me.Controls(chkPrefix & i), CheckBox)
                    Dim num As NumericUpDown = CType(Me.Controls(numPrefix & i), NumericUpDown)

                    ' Bangun path gambar lengkap
                    Dim namaFileGambar As String = dr("gambar").ToString()
                    Dim pathGambar As String = Path.Combine(folderGambar, namaFileGambar)

                    If File.Exists(pathGambar) Then
                        pic.Image = Image.FromFile(pathGambar)
                        pic.SizeMode = PictureBoxSizeMode.Zoom
                    Else
                        pic.Image = Nothing
                    End If

                    lblNama.Text = dr("namaBarang").ToString()
                    lblHarga.Text = "Rp " & Format(CDec(dr("harga")), "#,##0.00")
                    lblStok.Text = "Stok: " & dr("stok").ToString()
                    num.Maximum = dr("stok")
                    num.Value = 1
                    chk.Checked = False
                Catch ex As Exception
                    ' Lewatkan error kontrol yg tidak ditemukan
                End Try

                i += 1
            End While

            dr.Close()
            conn.Close()

        Catch ex As Exception
            MessageBox.Show("Gagal memuat data " & kategori & ": " & ex.Message)
            If dr IsNot Nothing Then dr.Close()
            If conn.State = ConnectionState.Open Then conn.Close()
        End Try
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

    End Sub
End Class
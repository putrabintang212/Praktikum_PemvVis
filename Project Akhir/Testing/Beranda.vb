Imports MySql.Data.MySqlClient
Imports System.IO

Public Class Beranda
    Dim conn As New MySqlConnection("server=localhost;user id=root;password=;database=db_arc")

    Public Sub Beranda_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Public Class Stok
        lblUser.Text = usernameLogin
        Me.AutoScroll = True
        LoadProdukKePanel("laptop", PanelLaptop)
        LoadProdukKePanel("keyboard", PanelKeyboard)
        LoadProdukKePanel("mouse", PanelMouse)
    End Sub


    'Sub LoadProdukKePanel(kategori As String, targetPanel As Panel)
    '    targetPanel.Controls.Clear()

    '    Try
    '        conn.Open()
    '        Dim cmd As New MySqlCommand("SELECT * FROM barang WHERE kategori = @kategori", conn)
    '        cmd.Parameters.AddWithValue("@kategori", kategori)
    '        Dim dr As MySqlDataReader = cmd.ExecuteReader()

    '        Dim x As Integer = 10
    '        Dim y As Integer = 10
    '        Dim lebarBox As Integer = 128
    '        Dim tinggiBox As Integer = 170
    '        Dim margin As Integer = 10

    '        While dr.Read()
    '            ' Kontainer Group
    '            Dim group As New Panel With {
    '                .Size = New Size(lebarBox, tinggiBox),
    '                .Location = New Point(x, y),
    '                .BorderStyle = BorderStyle.FixedSingle
    '            }

    '            ' PictureBox
    '            Dim pic As New PictureBox With {
    '                .Size = New Size(90, 60),
    '                .Location = New Point(5, 5),
    '                .SizeMode = PictureBoxSizeMode.Zoom
    '            }
    '            Dim pathGambar As String = Path.Combine(Application.StartupPath, "gambar", dr("gambar").ToString())
    '            If File.Exists(pathGambar) Then
    '                pic.Image = Image.FromFile(pathGambar)
    '            End If
    '            group.Controls.Add(pic)

    '            ' Label Nama
    '            Dim lblNama As New Label With {
    '                .Text = dr("namaBarang").ToString(),
    '                .Location = New Point(5, 70),
    '                .AutoSize = True
    '            }
    '            group.Controls.Add(lblNama)

    '            ' Label Harga
    '            Dim harga As Decimal = CDec(dr("harga"))
    '            Dim lblHarga As New Label With {
    '                .Text = "Rp " & Format(CDec(dr("harga")), "#,##0.00"),
    '                .Location = New Point(5, 90),
    '                .AutoSize = True,
    '                .Tag = harga
    '            }
    '            group.Controls.Add(lblHarga)

    '            ' CheckBox
    '            Dim chk As New CheckBox With {
    '                .Text = "Beli",
    '                .Location = New Point(5, 110)
    '            }
    '            group.Controls.Add(chk)

    '            ' NumericUpDown
    '            Dim num As New NumericUpDown With {
    '                .Location = New Point(75, 135),
    '                .Width = 40,
    '                .Minimum = 1,
    '                .Maximum = dr("stok"),
    '                .Value = 1
    '            }
    '            group.Controls.Add(num)

    '            ' Label Stok
    '            Dim lblStok As New Label With {
    '                .Text = "Stok: " & dr("stok").ToString(),
    '                .Location = New Point(5, 135),
    '                .AutoSize = True
    '            }
    '            group.Controls.Add(lblStok)

    '            ' Tambahkan ke panel utama
    '            targetPanel.Controls.Add(group)

    '            ' Posisi selanjutnya
    '            x += lebarBox + margin
    '            If x + lebarBox > targetPanel.Width Then
    '                x = 10
    '                y += tinggiBox + margin
    '            End If
    '        End While

    '        dr.Close()
    '        conn.Close()

    '    Catch ex As Exception
    '        MessageBox.Show("Gagal memuat data " & kategori & ": " & ex.Message)
    '        If conn.State = ConnectionState.Open Then conn.Close()
    '    End Try
    'End Sub

    Sub LoadProdukKePanel(kategori As String, targetPanel As Panel)
            targetPanel.Controls.Clear()

            Try
                conn.Open()
                Dim cmd As New MySqlCommand("SELECT * FROM barang WHERE kategori = @kategori", conn)
                cmd.Parameters.AddWithValue("@kategori", kategori)
                Dim dr As MySqlDataReader = cmd.ExecuteReader()

                Dim x As Integer = 10
                Dim y As Integer = 10
                Dim lebarBox As Integer = 128
                Dim tinggiBox As Integer = 170
                Dim margin As Integer = 10

                While dr.Read()
                    Dim group As New Panel With {
                .Size = New Size(lebarBox, tinggiBox),
                .Location = New Point(x, y),
                .BorderStyle = BorderStyle.FixedSingle
                }

                    Dim pic As New PictureBox With {
                .Size = New Size(90, 60),
                .Location = New Point(5, 5),
                .SizeMode = PictureBoxSizeMode.Zoom
            }
                    Dim pathGambar As String = Path.Combine(Application.StartupPath, "gambar", dr("gambar").ToString())
                    If File.Exists(pathGambar) Then
                        pic.Image = Image.FromFile(pathGambar)
                    End If
                    group.Controls.Add(pic)

                    Dim lblNama As New Label With {
                .Text = dr("namaBarang").ToString(),
                .Location = New Point(5, 70),
                .AutoSize = True
            }
                    group.Controls.Add(lblNama)

                    Dim harga As Decimal = CDec(dr("harga"))
                    Dim lblHarga As New Label With {
                .Text = "Rp " & Format(harga, "#,##0.00"),
                .Location = New Point(5, 90),
                .AutoSize = True,
                .Tag = harga
            }
                    group.Controls.Add(lblHarga)

                    Dim stok As Integer = Convert.ToInt32(dr("stok"))

                    ' Tambahkan hanya jika stok > 0
                    If stok > 0 Then
                        Dim chk As New CheckBox With {
                    .Text = "Beli",
                    .Location = New Point(5, 110)
                }
                        group.Controls.Add(chk)

                        Dim num As New NumericUpDown With {
                    .Location = New Point(75, 135),
                    .Width = 40,
                    .Minimum = 1,
                    .Maximum = stok,
                    .Value = 1
                }
                        group.Controls.Add(num)
                    Else
                        ' Menampilkan stok habis jika stok 0
                        Dim lblHabis As New Label With {
                    .Text = "Stok Habis",
                    .ForeColor = Color.Red,
                    .Location = New Point(5, 110),
                    .AutoSize = True
                }
                        group.Controls.Add(lblHabis)
                    End If

                    ' Label stok (tetap ditampilkan)
                    Dim lblStok As New Label With {
                .Text = "Stok: " & stok.ToString(),
                .Location = New Point(5, 135),
                .AutoSize = True
            }
                    group.Controls.Add(lblStok)

                    targetPanel.Controls.Add(group)

                    x += lebarBox + margin
                    If x + lebarBox > targetPanel.Width Then
                        x = 10
                        y += tinggiBox + margin
                    End If
                End While

                dr.Close()
                conn.Close()

            Catch ex As Exception
                MessageBox.Show("Gagal memuat data " & kategori & ": " & ex.Message)
                If conn.State = ConnectionState.Open Then conn.Close()
            End Try
        End Sub


    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click
        Dim daftarBelanja As New List(Of BarangTerpilih)

        ' Ambil data dari panel-panel
        AmbilBarangDipilihDariPanel(PanelLaptop, daftarBelanja)
        AmbilBarangDipilihDariPanel(PanelKeyboard, daftarBelanja)
        AmbilBarangDipilihDariPanel(PanelMouse, daftarBelanja)

        ' Tampilkan form checkout sebagai dialog
        Dim formCheckout As New Form_Checkout()
        formCheckout.TerimaData(daftarBelanja)

        ' Sembunyikan Beranda sementara
        Me.Hide()

        ' Tampilkan form checkout (menunggu hingga selesai)
        formCheckout.ShowDialog()

        ' Tampilkan kembali Form Beranda setelah checkout ditutup
        Me.Show()

        ' Refresh data produk dari database
        LoadProdukKePanel("laptop", PanelLaptop)
        LoadProdukKePanel("keyboard", PanelKeyboard)
        LoadProdukKePanel("mouse", PanelMouse)
    End Sub


    Sub AmbilBarangDipilihDariPanel(panel As Panel, ByRef daftar As List(Of BarangTerpilih))
            For Each container As Control In panel.Controls
                If TypeOf container Is Panel Then
                    Dim grup As Panel = CType(container, Panel)
                    Dim chk As CheckBox = Nothing
                    Dim num As NumericUpDown = Nothing
                    Dim lblNama As Label = Nothing
                    Dim lblHarga As Label = Nothing

                    For Each ctrl As Control In grup.Controls
                        If TypeOf ctrl Is CheckBox Then chk = CType(ctrl, CheckBox)
                        If TypeOf ctrl Is NumericUpDown Then num = CType(ctrl, NumericUpDown)
                        If TypeOf ctrl Is Label AndAlso ctrl.Location.Y = 70 Then lblNama = CType(ctrl, Label)
                        If TypeOf ctrl Is Label AndAlso ctrl.Location.Y = 90 Then lblHarga = CType(ctrl, Label)
                    Next

                    If chk IsNot Nothing AndAlso chk.Checked Then
                        Dim barang As New BarangTerpilih()
                        barang.Nama = lblNama.Text
                        barang.Harga = CDec(lblHarga.Tag)
                        barang.Jumlah = CInt(num.Value)
                        daftar.Add(barang)
                    End If
                End If
            Next
        End Sub

        Sub KurangiStokSetelahSubmit(panel As Panel, daftar As List(Of BarangTerpilih))
            For Each container As Control In panel.Controls
                If TypeOf container Is Panel Then
                    Dim grup As Panel = CType(container, Panel)
                    Dim lblNama As Label = Nothing
                    Dim num As NumericUpDown = Nothing
                    Dim lblStok As Label = Nothing

                    For Each ctrl As Control In grup.Controls
                        If TypeOf ctrl Is Label AndAlso ctrl.Location.Y = 70 Then lblNama = CType(ctrl, Label)
                        If TypeOf ctrl Is Label AndAlso ctrl.Location.Y = 135 Then lblStok = CType(ctrl, Label)
                        If TypeOf ctrl Is NumericUpDown Then num = CType(ctrl, NumericUpDown)
                    Next

                    If lblNama IsNot Nothing AndAlso lblStok IsNot Nothing AndAlso num IsNot Nothing Then
                        For Each item As BarangTerpilih In daftar
                            If item.Nama = lblNama.Text Then
                                Dim stokSekarang As Integer = Integer.Parse(lblStok.Text.Replace("Stok: ", ""))
                                Dim stokBaru As Integer = stokSekarang - item.Jumlah
                                If stokBaru < 0 Then stokBaru = 0
                                lblStok.Text = "Stok: " & stokBaru
                                num.Maximum = stokBaru
                                Exit For
                            End If
                        Next
                    End If
                End If
            Next
        End Sub

        Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
            Dim result As DialogResult = MessageBox.Show("Apakah Anda yakin ingin logout?", "Konfirmasi Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If result = DialogResult.Yes Then
                Login.Show()

                Me.Close()
            End If
        End Sub

End Class


Imports System.Drawing.Printing
Imports System.Reflection
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Struk
    Private daftarBarang As List(Of BarangTerpilih)
    Private totalHarga As Decimal

    Public Sub TerimaDataStruk(data As List(Of BarangTerpilih), total As Decimal)
        daftarBarang = data
        totalHarga = total
    End Sub

    Private Sub Struk_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.ShowDialog()
        Me.Close()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim fontJudul As New Font("Arial", 16, FontStyle.Bold)
        Dim fontIsi As New Font("Arial", 12)
        Dim fontFooter As New Font("Arial", 11, FontStyle.Italic)

        Dim y As Integer = 20
        Dim centerX As Integer = e.MarginBounds.Left + (e.MarginBounds.Width \ 2)


        ' === Gambar Logo di Tengah ===
        Try
            Dim pathLogo As String = Application.StartupPath & "\gambar\logo.png"
            If IO.File.Exists(pathLogo) Then
                Dim logo As Image = Image.FromFile(pathLogo)
                Dim logoWidth As Integer = 506
                Dim logoHeight As Integer = 258
                Dim xLogo As Integer = e.MarginBounds.Left + (e.MarginBounds.Width - logoWidth) \ 2
                e.Graphics.DrawImage(logo, New Rectangle(xLogo, y, logoWidth, logoHeight))
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memuat logo: " & ex.Message)
        End Try

        y += 210 ' 

        ' === Judul ===
        Dim judul As String = "ARC COMPUTER"
        Dim alamat As String = "Jl. Jawa No.123 - Samarinda"

        Dim ukuranJudul As SizeF = e.Graphics.MeasureString(judul, fontJudul)
        Dim ukuranAlamat As SizeF = e.Graphics.MeasureString(alamat, fontIsi)

        e.Graphics.DrawString(judul, fontJudul, Brushes.Black, centerX - ukuranJudul.Width / 2, y)
        y += ukuranJudul.Height + 5
        e.Graphics.DrawString(alamat, fontIsi, Brushes.Black, centerX - ukuranAlamat.Width / 2, y)
        y += ukuranAlamat.Height + 10



        ' === Garis Pembatas ===
        e.Graphics.DrawString("===================================================================", fontIsi, Brushes.Black, e.MarginBounds.Left, y)
        y += 20

        ' === Isi Barang ===
        For Each item In daftarBarang
            e.Graphics.DrawString(item.Nama, fontIsi, Brushes.Black, e.MarginBounds.Left, y)
            y += fontIsi.Height

            Dim qtyText As String = "x" & item.Jumlah
            Dim subTotalText As String = "Rp " & item.Subtotal.ToString("#,##0.00")
            Dim qtyWidth As Single = e.Graphics.MeasureString(qtyText, fontIsi).Width
            Dim subtotalWidth As Single = e.Graphics.MeasureString(subTotalText, fontIsi).Width

            e.Graphics.DrawString(qtyText, fontIsi, Brushes.Black, e.MarginBounds.Left + 20, y)
            e.Graphics.DrawString(subTotalText, fontIsi, Brushes.Black, e.MarginBounds.Right - subtotalWidth, y)
            y += fontIsi.Height + 5
        Next

        y += 5
        e.Graphics.DrawString("===================================================================", fontIsi, Brushes.Black, e.MarginBounds.Left, y)
        y += 20

        Dim waktu As String = "Tanggal: " & DateTime.Now.ToString("dd/MM/yyyy HH:mm")
        e.Graphics.DrawString(waktu, fontIsi, Brushes.Black, e.MarginBounds.Left, y)
        y += 25

        y += 5
        e.Graphics.DrawString("===================================================================", fontIsi, Brushes.Black, e.MarginBounds.Left, y)
        y += 20

        Dim totalText As String = "Total: Rp " & totalHarga.ToString("#,##0.00")
        Dim totalWidth As Single = e.Graphics.MeasureString(totalText, fontJudul).Width
        e.Graphics.DrawString(totalText, fontJudul, Brushes.Black, e.MarginBounds.Right - totalWidth, y)
        y += fontJudul.Height + 20

        Dim ucapan As String = "Terima kasih telah berbelanja!"
        Dim ukuranUcapan As SizeF = e.Graphics.MeasureString(ucapan, fontFooter)
        e.Graphics.DrawString(ucapan, fontFooter, Brushes.Black, centerX - ukuranUcapan.Width / 2, y)
    End Sub
End Class

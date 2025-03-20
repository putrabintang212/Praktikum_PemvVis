Module BookModule
    Public Books As New List(Of String)
End Module

Public Class Form1
    Private Function FindBookIndex(ByVal title As String) As Integer
        Return Books.IndexOf(title)
    End Function

    Private Sub AddBook(ByRef bookList As List(Of String), ByVal title As String)
        If title <> "" AndAlso Not bookList.Contains(title) Then
            bookList.Add(title)
            MessageBox.Show("Buku berhasil ditambahkan!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Judul buku tidak boleh kosong atau sudah ada dalam daftar!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub RemoveBook(ByRef bookList As List(Of String), ByVal title As String)
        Dim index As Integer = FindBookIndex(title)
        If index <> -1 Then
            bookList.RemoveAt(index)
            MessageBox.Show("Buku berhasil dihapus!", "Informasi", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Buku tidak ditemukan!", "Peringatan", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End If
    End Sub

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles tambah.Click
        AddBook(Books, textjudul.Text)
        UpdateList()
    End Sub

    Private Sub btnHapus_Click(sender As Object, e As EventArgs) Handles hapus.Click
        RemoveBook(Books, textjudul.Text)
        UpdateList()
    End Sub

    Private Sub UpdateList()
        list.Items.Clear()
        list.Items.AddRange(Books.ToArray())
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        UpdateList()
    End Sub

End Class

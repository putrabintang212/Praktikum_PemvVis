Public Class Form1
    Dim totalIP As Double = 0
    Dim jumlahSemester As Integer = 0

    Private Sub btnTambah_Click(sender As Object, e As EventArgs) Handles Tambah.Click
        Dim ipSemester As Double
        If Double.TryParse(Me.IPSemester.Text, ipSemester) AndAlso ipSemester >= 0 AndAlso ipSemester <= 4 Then
            totalIP += ipSemester
            jumlahSemester += 1
            Dim ipk As Double = totalIP / jumlahSemester
            Me.IPK.Text = ipk.ToString("F2")
            Me.IPSemester.Clear()
            TampilkanPredikat(ipk)
        Else
            MessageBox.Show("Masukkan nilai IP Semester yang valid (0 - 4).")
        End If
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles Reset.Click
        totalIP = 0
        jumlahSemester = 0
        IPK.Text = "0.00"
        IPSemester.Clear()
        lblPredikat.Text = ""
    End Sub

    Private Sub TampilkanPredikat(ipk As Double)
        If ipk >= 2 AndAlso ipk <= 2.75 Then
            lblPredikat.Text = "Cukup"
        ElseIf ipk > 2.75 AndAlso ipk <= 3 Then
            lblPredikat.Text = "Memuaskan"
        ElseIf ipk > 3 Then
            lblPredikat.Text = "Sangat Memuaskan"
        Else
            lblPredikat.Text = ""
        End If
    End Sub

    Private Sub lblPredikat_Click(sender As Object, e As EventArgs) Handles lblPredikat.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
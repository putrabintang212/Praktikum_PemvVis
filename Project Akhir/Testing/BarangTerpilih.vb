Public Structure BarangTerpilih
    Public Nama As String
    Public Harga As Decimal
    Public Jumlah As Integer

    Public ReadOnly Property Subtotal As Decimal
        Get
            Return Harga * Jumlah
        End Get
    End Property
End Structure

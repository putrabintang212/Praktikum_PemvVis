<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        txtKode = New TextBox()
        txtTahun = New TextBox()
        txtHarga = New TextBox()
        txtTipe = New TextBox()
        txtMerk = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnBatal = New Button()
        DataGridView1 = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        PictureBox1 = New PictureBox()
        Label6 = New Label()
        Label7 = New Label()
        txtSearch = New TextBox()
        Label8 = New Label()
        CType(DataGridView1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtKode
        ' 
        txtKode.Location = New Point(137, 142)
        txtKode.Name = "txtKode"
        txtKode.Size = New Size(125, 27)
        txtKode.TabIndex = 0
        ' 
        ' txtTahun
        ' 
        txtTahun.Location = New Point(393, 176)
        txtTahun.Name = "txtTahun"
        txtTahun.Size = New Size(125, 27)
        txtTahun.TabIndex = 1
        ' 
        ' txtHarga
        ' 
        txtHarga.Location = New Point(393, 209)
        txtHarga.Name = "txtHarga"
        txtHarga.Size = New Size(125, 27)
        txtHarga.TabIndex = 2
        ' 
        ' txtTipe
        ' 
        txtTipe.Location = New Point(137, 213)
        txtTipe.Name = "txtTipe"
        txtTipe.Size = New Size(125, 27)
        txtTipe.TabIndex = 3
        ' 
        ' txtMerk
        ' 
        txtMerk.Location = New Point(137, 180)
        txtMerk.Name = "txtMerk"
        txtMerk.Size = New Size(125, 27)
        txtMerk.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.Location = New Point(23, 283)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(94, 29)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = True
        ' 
        ' btnUbah
        ' 
        btnUbah.Location = New Point(22, 318)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(94, 29)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = True
        ' 
        ' btnHapus
        ' 
        btnHapus.Location = New Point(22, 353)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(94, 29)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = True
        ' 
        ' btnBatal
        ' 
        btnBatal.Location = New Point(23, 388)
        btnBatal.Name = "btnBatal"
        btnBatal.Size = New Size(94, 29)
        btnBatal.TabIndex = 8
        btnBatal.Text = "Batal"
        btnBatal.UseVisualStyleBackColor = True
        ' 
        ' DataGridView1
        ' 
        DataGridView1.BackgroundColor = Color.DimGray
        DataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        DataGridView1.Location = New Point(143, 270)
        DataGridView1.Name = "DataGridView1"
        DataGridView1.RowHeadersWidth = 51
        DataGridView1.Size = New Size(645, 168)
        DataGridView1.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = Color.White
        Label1.Location = New Point(26, 149)
        Label1.Name = "Label1"
        Label1.Size = New Size(87, 20)
        Label1.TabIndex = 10
        Label1.Text = "Kode Mobil"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = Color.White
        Label2.Location = New Point(26, 183)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 20)
        Label2.TabIndex = 11
        Label2.Text = "Merk Mobil"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = Color.White
        Label3.Location = New Point(26, 216)
        Label3.Name = "Label3"
        Label3.Size = New Size(81, 20)
        Label3.TabIndex = 12
        Label3.Text = "Tipe Mobil"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = Color.White
        Label4.Location = New Point(282, 176)
        Label4.Name = "Label4"
        Label4.Size = New Size(90, 20)
        Label4.TabIndex = 13
        Label4.Text = "Tahun Mobil"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = Color.White
        Label5.Location = New Point(279, 212)
        Label5.Name = "Label5"
        Label5.Size = New Size(93, 20)
        Label5.TabIndex = 14
        Label5.Text = "Harga Mobil"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = Color.White
        PictureBox1.Image = My.Resources.Resources.car
        PictureBox1.Location = New Point(-48, -191)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(894, 668)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 15
        PictureBox1.TabStop = False
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = Color.White
        Label6.Font = New Font("Tahoma", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(702, 13)
        Label6.Name = "Label6"
        Label6.Size = New Size(67, 22)
        Label6.TabIndex = 16
        Label6.Text = "Admin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = Color.White
        Label7.Font = New Font("Copperplate Gothic Bold", 18F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(232, 9)
        Label7.Name = "Label7"
        Label7.Size = New Size(353, 34)
        Label7.TabIndex = 17
        Label7.Text = "Star CarShowroom"
        ' 
        ' txtSearch
        ' 
        txtSearch.Location = New Point(663, 237)
        txtSearch.Name = "txtSearch"
        txtSearch.Size = New Size(125, 27)
        txtSearch.TabIndex = 18
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = Color.White
        Label8.Location = New Point(613, 240)
        Label8.Name = "Label8"
        Label8.Size = New Size(35, 20)
        Label8.TabIndex = 19
        Label8.Text = "Cari"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label8)
        Controls.Add(txtSearch)
        Controls.Add(Label7)
        Controls.Add(Label6)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(DataGridView1)
        Controls.Add(btnBatal)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtMerk)
        Controls.Add(txtTipe)
        Controls.Add(txtHarga)
        Controls.Add(txtTahun)
        Controls.Add(txtKode)
        Controls.Add(PictureBox1)
        Name = "Form1"
        Text = "Showroom Mobil"
        CType(DataGridView1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtKode As TextBox
    Friend WithEvents txtTahun As TextBox
    Friend WithEvents txtHarga As TextBox
    Friend WithEvents txtTipe As TextBox
    Friend WithEvents txtMerk As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnBatal As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtSearch As TextBox
    Friend WithEvents Label8 As Label
End Class

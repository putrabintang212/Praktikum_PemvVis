<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Panel_Hapus
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
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnEditProduk = New System.Windows.Forms.Button()
        Me.btnHapusProduk = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btnTambahProduk = New System.Windows.Forms.Button()
        Me.btnLihatProduk = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvProduk = New System.Windows.Forms.DataGridView()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.cmbFilter = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnHapus
        '
        Me.btnHapus.Location = New System.Drawing.Point(719, 586)
        Me.btnHapus.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(116, 37)
        Me.btnHapus.TabIndex = 81
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.btnLogout)
        Me.Panel1.Controls.Add(Me.btnEditProduk)
        Me.Panel1.Controls.Add(Me.btnHapusProduk)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.btnTambahProduk)
        Me.Panel1.Controls.Add(Me.btnLihatProduk)
        Me.Panel1.Controls.Add(Me.PictureBox6)
        Me.Panel1.Controls.Add(Me.PictureBox5)
        Me.Panel1.Controls.Add(Me.PictureBox4)
        Me.Panel1.Controls.Add(Me.PictureBox3)
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(341, 722)
        Me.Panel1.TabIndex = 61
        '
        'btnLogout
        '
        Me.btnLogout.BackColor = System.Drawing.Color.Red
        Me.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(21, 586)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(248, 53)
        Me.btnLogout.TabIndex = 97
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = False
        '
        'btnEditProduk
        '
        Me.btnEditProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnEditProduk.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnEditProduk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEditProduk.Location = New System.Drawing.Point(21, 374)
        Me.btnEditProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnEditProduk.Name = "btnEditProduk"
        Me.btnEditProduk.Size = New System.Drawing.Size(248, 53)
        Me.btnEditProduk.TabIndex = 26
        Me.btnEditProduk.Text = "Edit Produk"
        Me.btnEditProduk.UseVisualStyleBackColor = False
        '
        'btnHapusProduk
        '
        Me.btnHapusProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnHapusProduk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnHapusProduk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapusProduk.Location = New System.Drawing.Point(21, 468)
        Me.btnHapusProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnHapusProduk.Name = "btnHapusProduk"
        Me.btnHapusProduk.Size = New System.Drawing.Size(248, 50)
        Me.btnHapusProduk.TabIndex = 9
        Me.btnHapusProduk.Text = "Hapus Produk"
        Me.btnHapusProduk.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(308, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(35, 722)
        Me.Panel3.TabIndex = 1
        '
        'btnTambahProduk
        '
        Me.btnTambahProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnTambahProduk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnTambahProduk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTambahProduk.Location = New System.Drawing.Point(21, 283)
        Me.btnTambahProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnTambahProduk.Name = "btnTambahProduk"
        Me.btnTambahProduk.Size = New System.Drawing.Size(248, 52)
        Me.btnTambahProduk.TabIndex = 8
        Me.btnTambahProduk.Text = "Tambah Produk"
        Me.btnTambahProduk.UseVisualStyleBackColor = False
        '
        'btnLihatProduk
        '
        Me.btnLihatProduk.BackColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.btnLihatProduk.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLihatProduk.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLihatProduk.Location = New System.Drawing.Point(21, 188)
        Me.btnLihatProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.btnLihatProduk.Name = "btnLihatProduk"
        Me.btnLihatProduk.Size = New System.Drawing.Size(248, 55)
        Me.btnLihatProduk.TabIndex = 7
        Me.btnLihatProduk.Text = "Lihat Produk"
        Me.btnLihatProduk.UseVisualStyleBackColor = False
        '
        'PictureBox6
        '
        Me.PictureBox6.Image = Global.Testing.My.Resources.Resources.Masukkan__6_
        Me.PictureBox6.Location = New System.Drawing.Point(21, 446)
        Me.PictureBox6.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(248, 94)
        Me.PictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox6.TabIndex = 6
        Me.PictureBox6.TabStop = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Testing.My.Resources.Resources.Masukkan__6_
        Me.PictureBox5.Location = New System.Drawing.Point(21, 354)
        Me.PictureBox5.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(248, 94)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 5
        Me.PictureBox5.TabStop = False
        '
        'PictureBox4
        '
        Me.PictureBox4.Image = Global.Testing.My.Resources.Resources.Masukkan__6_
        Me.PictureBox4.Location = New System.Drawing.Point(21, 263)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(248, 94)
        Me.PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox4.TabIndex = 4
        Me.PictureBox4.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Testing.My.Resources.Resources.Masukkan__6_
        Me.PictureBox3.Location = New System.Drawing.Point(21, 170)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(248, 94)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 3
        Me.PictureBox3.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Testing.My.Resources.Resources.Masukkan
        Me.PictureBox2.Location = New System.Drawing.Point(27, 12)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(253, 129)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(506, 66)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(272, 46)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "Hapus Produk"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(1040, 66)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(120, 46)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Panel"
        '
        'dgvProduk
        '
        Me.dgvProduk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvProduk.Location = New System.Drawing.Point(483, 249)
        Me.dgvProduk.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.dgvProduk.Name = "dgvProduk"
        Me.dgvProduk.RowHeadersWidth = 51
        Me.dgvProduk.RowTemplate.Height = 24
        Me.dgvProduk.Size = New System.Drawing.Size(648, 333)
        Me.dgvProduk.TabIndex = 82
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Testing.My.Resources.Resources.Masukkan__7_
        Me.PictureBox7.Location = New System.Drawing.Point(460, 12)
        Me.PictureBox7.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(744, 172)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 62
        Me.PictureBox7.TabStop = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Testing.My.Resources.Resources.Masukkan
        Me.PictureBox1.Location = New System.Drawing.Point(37, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 60
        Me.PictureBox1.TabStop = False
        '
        'cmbFilter
        '
        Me.cmbFilter.FormattingEnabled = True
        Me.cmbFilter.Location = New System.Drawing.Point(694, 219)
        Me.cmbFilter.Margin = New System.Windows.Forms.Padding(4)
        Me.cmbFilter.Name = "cmbFilter"
        Me.cmbFilter.Size = New System.Drawing.Size(160, 24)
        Me.cmbFilter.TabIndex = 98
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(973, 66)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 46)
        Me.Label4.TabIndex = 99
        Me.Label4.Text = "Panel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Arial Black", 19.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(856, 66)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 46)
        Me.Label5.TabIndex = 98
        Me.Label5.Text = "ARC"
        '
        'Panel_Hapus
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1232, 722)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbFilter)
        Me.Controls.Add(Me.dgvProduk)
        Me.Controls.Add(Me.btnHapus)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Panel_Hapus"
        Me.Text = "Panel_Hapus"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvProduk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnHapus As Button
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnEditProduk As Button
    Friend WithEvents btnHapusProduk As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents btnTambahProduk As Button
    Friend WithEvents btnLihatProduk As Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents PictureBox4 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents dgvProduk As DataGridView
    Friend WithEvents btnLogout As Button
    Friend WithEvents cmbFilter As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class

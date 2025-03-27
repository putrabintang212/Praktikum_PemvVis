<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        PBox = New PictureBox()
        UpFoto = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        TextNama = New TextBox()
        TextUmur = New TextBox()
        TextTelp = New TextBox()
        TextAlamat = New TextBox()
        GroupBox1 = New GroupBox()
        Perempuan = New RadioButton()
        Laki = New RadioButton()
        GBHobi = New GroupBox()
        CheckBox12 = New CheckBox()
        CheckBox11 = New CheckBox()
        CheckBox10 = New CheckBox()
        CheckBox7 = New CheckBox()
        CheckBox3 = New CheckBox()
        CheckBox6 = New CheckBox()
        CheckBox5 = New CheckBox()
        CheckBox4 = New CheckBox()
        CheckBox8 = New CheckBox()
        CheckBox2 = New CheckBox()
        CheckBox1 = New CheckBox()
        CheckBox9 = New CheckBox()
        TglLhr = New DateTimePicker()
        Cetak = New Button()
        Panel1 = New Panel()
        CType(PBox, ComponentModel.ISupportInitialize).BeginInit()
        GroupBox1.SuspendLayout()
        GBHobi.SuspendLayout()
        SuspendLayout()
        ' 
        ' PBox
        ' 
        PBox.BorderStyle = BorderStyle.FixedSingle
        PBox.Location = New Point(25, 21)
        PBox.Name = "PBox"
        PBox.Size = New Size(120, 150)
        PBox.TabIndex = 0
        PBox.TabStop = False
        ' 
        ' UpFoto
        ' 
        UpFoto.BackColor = SystemColors.ActiveBorder
        UpFoto.Location = New Point(25, 205)
        UpFoto.Name = "UpFoto"
        UpFoto.Size = New Size(120, 29)
        UpFoto.TabIndex = 1
        UpFoto.Text = "Upload Foto!"
        UpFoto.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(184, 28)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 2
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(184, 64)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 3
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(184, 105)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 4
        Label3.Text = "No. Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(184, 144)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 5
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(184, 188)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 6
        Label5.Text = "Tanggal Lahir"
        ' 
        ' TextNama
        ' 
        TextNama.Location = New Point(287, 28)
        TextNama.Name = "TextNama"
        TextNama.Size = New Size(273, 27)
        TextNama.TabIndex = 7
        ' 
        ' TextUmur
        ' 
        TextUmur.Location = New Point(287, 64)
        TextUmur.Name = "TextUmur"
        TextUmur.Size = New Size(273, 27)
        TextUmur.TabIndex = 8
        ' 
        ' TextTelp
        ' 
        TextTelp.Location = New Point(287, 105)
        TextTelp.Name = "TextTelp"
        TextTelp.Size = New Size(273, 27)
        TextTelp.TabIndex = 9
        ' 
        ' TextAlamat
        ' 
        TextAlamat.Location = New Point(287, 144)
        TextAlamat.Name = "TextAlamat"
        TextAlamat.Size = New Size(273, 27)
        TextAlamat.TabIndex = 10
        ' 
        ' GroupBox1
        ' 
        GroupBox1.Controls.Add(Perempuan)
        GroupBox1.Controls.Add(Laki)
        GroupBox1.Location = New Point(599, 32)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(189, 139)
        GroupBox1.TabIndex = 12
        GroupBox1.TabStop = False
        GroupBox1.Text = "Jenis Kelamin"
        ' 
        ' Perempuan
        ' 
        Perempuan.AutoSize = True
        Perempuan.Location = New Point(24, 65)
        Perempuan.Name = "Perempuan"
        Perempuan.Size = New Size(104, 24)
        Perempuan.TabIndex = 1
        Perempuan.TabStop = True
        Perempuan.Text = "Perempuan"
        Perempuan.UseVisualStyleBackColor = True
        ' 
        ' Laki
        ' 
        Laki.AutoSize = True
        Laki.Location = New Point(24, 35)
        Laki.Name = "Laki"
        Laki.Size = New Size(88, 24)
        Laki.TabIndex = 0
        Laki.TabStop = True
        Laki.Text = "Laki-Laki"
        Laki.UseVisualStyleBackColor = True
        ' 
        ' GBHobi
        ' 
        GBHobi.Controls.Add(CheckBox12)
        GBHobi.Controls.Add(CheckBox11)
        GBHobi.Controls.Add(CheckBox10)
        GBHobi.Controls.Add(CheckBox7)
        GBHobi.Controls.Add(CheckBox3)
        GBHobi.Controls.Add(CheckBox6)
        GBHobi.Controls.Add(CheckBox5)
        GBHobi.Controls.Add(CheckBox4)
        GBHobi.Controls.Add(CheckBox8)
        GBHobi.Controls.Add(CheckBox2)
        GBHobi.Controls.Add(CheckBox1)
        GBHobi.Controls.Add(CheckBox9)
        GBHobi.Location = New Point(221, 258)
        GBHobi.Name = "GBHobi"
        GBHobi.Size = New Size(360, 145)
        GBHobi.TabIndex = 13
        GBHobi.TabStop = False
        GBHobi.Text = "Hobi"
        ' 
        ' CheckBox12
        ' 
        CheckBox12.AutoSize = True
        CheckBox12.Location = New Point(232, 115)
        CheckBox12.Name = "CheckBox12"
        CheckBox12.Size = New Size(73, 24)
        CheckBox12.TabIndex = 11
        CheckBox12.Text = "Eating"
        CheckBox12.UseVisualStyleBackColor = True
        ' 
        ' CheckBox11
        ' 
        CheckBox11.AutoSize = True
        CheckBox11.Location = New Point(232, 85)
        CheckBox11.Name = "CheckBox11"
        CheckBox11.Size = New Size(89, 24)
        CheckBox11.TabIndex = 10
        CheckBox11.Text = "Sleeping"
        CheckBox11.UseVisualStyleBackColor = True
        ' 
        ' CheckBox10
        ' 
        CheckBox10.AutoSize = True
        CheckBox10.Location = New Point(230, 56)
        CheckBox10.Name = "CheckBox10"
        CheckBox10.Size = New Size(95, 24)
        CheckBox10.TabIndex = 9
        CheckBox10.Text = "Travelling"
        CheckBox10.UseVisualStyleBackColor = True
        ' 
        ' CheckBox7
        ' 
        CheckBox7.AutoSize = True
        CheckBox7.Location = New Point(115, 86)
        CheckBox7.Name = "CheckBox7"
        CheckBox7.Size = New Size(92, 24)
        CheckBox7.TabIndex = 6
        CheckBox7.Text = "Fotografi"
        CheckBox7.UseVisualStyleBackColor = True
        ' 
        ' CheckBox3
        ' 
        CheckBox3.AutoSize = True
        CheckBox3.Location = New Point(6, 86)
        CheckBox3.Name = "CheckBox3"
        CheckBox3.Size = New Size(92, 24)
        CheckBox3.TabIndex = 2
        CheckBox3.Text = "Olahraga"
        CheckBox3.UseVisualStyleBackColor = True
        ' 
        ' CheckBox6
        ' 
        CheckBox6.AutoSize = True
        CheckBox6.Location = New Point(115, 56)
        CheckBox6.Name = "CheckBox6"
        CheckBox6.Size = New Size(94, 24)
        CheckBox6.TabIndex = 5
        CheckBox6.Text = "Memasak"
        CheckBox6.UseVisualStyleBackColor = True
        ' 
        ' CheckBox5
        ' 
        CheckBox5.AutoSize = True
        CheckBox5.Location = New Point(115, 27)
        CheckBox5.Name = "CheckBox5"
        CheckBox5.Size = New Size(94, 24)
        CheckBox5.TabIndex = 4
        CheckBox5.Text = "Menyanyi"
        CheckBox5.UseVisualStyleBackColor = True
        ' 
        ' CheckBox4
        ' 
        CheckBox4.AutoSize = True
        CheckBox4.Location = New Point(6, 115)
        CheckBox4.Name = "CheckBox4"
        CheckBox4.Size = New Size(107, 24)
        CheckBox4.TabIndex = 3
        CheckBox4.Text = "Main Game"
        CheckBox4.UseVisualStyleBackColor = True
        ' 
        ' CheckBox8
        ' 
        CheckBox8.AutoSize = True
        CheckBox8.Location = New Point(115, 115)
        CheckBox8.Name = "CheckBox8"
        CheckBox8.Size = New Size(81, 24)
        CheckBox8.TabIndex = 7
        CheckBox8.Text = "Melukis"
        CheckBox8.UseVisualStyleBackColor = True
        ' 
        ' CheckBox2
        ' 
        CheckBox2.AutoSize = True
        CheckBox2.Location = New Point(6, 56)
        CheckBox2.Name = "CheckBox2"
        CheckBox2.Size = New Size(82, 24)
        CheckBox2.TabIndex = 1
        CheckBox2.Text = "Menulis"
        CheckBox2.UseVisualStyleBackColor = True
        ' 
        ' CheckBox1
        ' 
        CheckBox1.AutoSize = True
        CheckBox1.Location = New Point(6, 26)
        CheckBox1.Name = "CheckBox1"
        CheckBox1.Size = New Size(97, 24)
        CheckBox1.TabIndex = 0
        CheckBox1.Text = "Membaca"
        CheckBox1.UseVisualStyleBackColor = True
        ' 
        ' CheckBox9
        ' 
        CheckBox9.AutoSize = True
        CheckBox9.Location = New Point(232, 26)
        CheckBox9.Name = "CheckBox9"
        CheckBox9.Size = New Size(128, 24)
        CheckBox9.TabIndex = 8
        CheckBox9.Text = "Bermain Musik"
        CheckBox9.UseVisualStyleBackColor = True
        ' 
        ' TglLhr
        ' 
        TglLhr.Location = New Point(287, 188)
        TglLhr.Name = "TglLhr"
        TglLhr.Size = New Size(273, 27)
        TglLhr.TabIndex = 14
        ' 
        ' Cetak
        ' 
        Cetak.BackColor = SystemColors.ActiveBorder
        Cetak.Location = New Point(0, 409)
        Cetak.Name = "Cetak"
        Cetak.Size = New Size(802, 43)
        Cetak.TabIndex = 15
        Cetak.Text = "Cetak Kartu!"
        Cetak.UseVisualStyleBackColor = False
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(172, 12)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(409, 222)
        Panel1.TabIndex = 16
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Cetak)
        Controls.Add(TglLhr)
        Controls.Add(GBHobi)
        Controls.Add(GroupBox1)
        Controls.Add(TextAlamat)
        Controls.Add(TextTelp)
        Controls.Add(TextUmur)
        Controls.Add(TextNama)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(UpFoto)
        Controls.Add(PBox)
        Controls.Add(Panel1)
        Name = "Form1"
        Text = "Form1"
        CType(PBox, ComponentModel.ISupportInitialize).EndInit()
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        GBHobi.ResumeLayout(False)
        GBHobi.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents PBox As PictureBox
    Friend WithEvents UpFoto As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TextNama As TextBox
    Friend WithEvents TextUmur As TextBox
    Friend WithEvents TextTelp As TextBox
    Friend WithEvents TextAlamat As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Perempuan As RadioButton
    Friend WithEvents Laki As RadioButton
    Friend WithEvents GBHobi As GroupBox
    Friend WithEvents CheckBox7 As CheckBox
    Friend WithEvents CheckBox3 As CheckBox
    Friend WithEvents CheckBox2 As CheckBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents CheckBox4 As CheckBox
    Friend WithEvents CheckBox5 As CheckBox
    Friend WithEvents CheckBox6 As CheckBox
    Friend WithEvents CheckBox8 As CheckBox
    Friend WithEvents CheckBox9 As CheckBox
    Friend WithEvents CheckBox10 As CheckBox
    Friend WithEvents CheckBox12 As CheckBox
    Friend WithEvents CheckBox11 As CheckBox
    Friend WithEvents TglLhr As DateTimePicker
    Friend WithEvents Cetak As Button
    Friend WithEvents Panel1 As Panel

End Class

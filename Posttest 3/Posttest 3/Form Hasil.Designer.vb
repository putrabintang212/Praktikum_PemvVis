<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form_Hasil
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
        PBhasil = New PictureBox()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        Label6 = New Label()
        Label7 = New Label()
        Panel1 = New Panel()
        lblHobi = New Label()
        lblGender = New Label()
        lblTgl = New Label()
        lblAlamat = New Label()
        lblTelp = New Label()
        lblUmur = New Label()
        lblNama = New Label()
        CType(PBhasil, ComponentModel.ISupportInitialize).BeginInit()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' PBhasil
        ' 
        PBhasil.BorderStyle = BorderStyle.FixedSingle
        PBhasil.Location = New Point(318, 12)
        PBhasil.Name = "PBhasil"
        PBhasil.Size = New Size(120, 150)
        PBhasil.TabIndex = 0
        PBhasil.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(21, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(49, 20)
        Label1.TabIndex = 1
        Label1.Text = "Nama"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(21, 52)
        Label2.Name = "Label2"
        Label2.Size = New Size(45, 20)
        Label2.TabIndex = 2
        Label2.Text = "Umur"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(20, 82)
        Label3.Name = "Label3"
        Label3.Size = New Size(89, 20)
        Label3.TabIndex = 3
        Label3.Text = "No. Telepon"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Location = New Point(18, 112)
        Label4.Name = "Label4"
        Label4.Size = New Size(57, 20)
        Label4.TabIndex = 4
        Label4.Text = "Alamat"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Location = New Point(17, 141)
        Label5.Name = "Label5"
        Label5.Size = New Size(97, 20)
        Label5.TabIndex = 5
        Label5.Text = "Tanggal Lahir"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Location = New Point(18, 171)
        Label6.Name = "Label6"
        Label6.Size = New Size(98, 20)
        Label6.TabIndex = 6
        Label6.Text = "Jenis Kelamin"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Location = New Point(20, 200)
        Label7.Name = "Label7"
        Label7.Size = New Size(42, 20)
        Label7.TabIndex = 7
        Label7.Text = "Hobi"
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ActiveBorder
        Panel1.Controls.Add(Label1)
        Panel1.Controls.Add(Label2)
        Panel1.Controls.Add(Label3)
        Panel1.Controls.Add(Label7)
        Panel1.Controls.Add(lblHobi)
        Panel1.Controls.Add(Label4)
        Panel1.Controls.Add(Label5)
        Panel1.Controls.Add(Label6)
        Panel1.Controls.Add(lblGender)
        Panel1.Controls.Add(lblTgl)
        Panel1.Controls.Add(lblAlamat)
        Panel1.Controls.Add(lblTelp)
        Panel1.Controls.Add(lblUmur)
        Panel1.Controls.Add(lblNama)
        Panel1.Location = New Point(134, 188)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(501, 241)
        Panel1.TabIndex = 8
        ' 
        ' lblHobi
        ' 
        lblHobi.AutoSize = True
        lblHobi.Location = New Point(206, 200)
        lblHobi.Name = "lblHobi"
        lblHobi.Size = New Size(42, 20)
        lblHobi.TabIndex = 6
        lblHobi.Text = "Hobi"
        ' 
        ' lblGender
        ' 
        lblGender.AutoSize = True
        lblGender.Location = New Point(206, 171)
        lblGender.Name = "lblGender"
        lblGender.Size = New Size(98, 20)
        lblGender.TabIndex = 5
        lblGender.Text = "Jenis Kelamin"
        ' 
        ' lblTgl
        ' 
        lblTgl.AutoSize = True
        lblTgl.Location = New Point(206, 141)
        lblTgl.Name = "lblTgl"
        lblTgl.Size = New Size(97, 20)
        lblTgl.TabIndex = 4
        lblTgl.Text = "Tanggal Lahir"
        ' 
        ' lblAlamat
        ' 
        lblAlamat.AutoSize = True
        lblAlamat.Location = New Point(206, 112)
        lblAlamat.Name = "lblAlamat"
        lblAlamat.Size = New Size(57, 20)
        lblAlamat.TabIndex = 3
        lblAlamat.Text = "Alamat"
        ' 
        ' lblTelp
        ' 
        lblTelp.AutoSize = True
        lblTelp.Location = New Point(206, 82)
        lblTelp.Name = "lblTelp"
        lblTelp.Size = New Size(89, 20)
        lblTelp.TabIndex = 2
        lblTelp.Text = "No. Telepon"
        ' 
        ' lblUmur
        ' 
        lblUmur.AutoSize = True
        lblUmur.Location = New Point(206, 52)
        lblUmur.Name = "lblUmur"
        lblUmur.Size = New Size(45, 20)
        lblUmur.TabIndex = 1
        lblUmur.Text = "Umur"
        ' 
        ' lblNama
        ' 
        lblNama.AutoSize = True
        lblNama.Location = New Point(206, 23)
        lblNama.Name = "lblNama"
        lblNama.Size = New Size(49, 20)
        lblNama.TabIndex = 0
        lblNama.Text = "Nama"
        ' 
        ' Form_Hasil
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(PBhasil)
        Controls.Add(Panel1)
        Name = "Form_Hasil"
        Text = "Hasil Kartu"
        CType(PBhasil, ComponentModel.ISupportInitialize).EndInit()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents PBhasil As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents lblHobi As Label
    Friend WithEvents lblGender As Label
    Friend WithEvents lblTgl As Label
    Friend WithEvents lblAlamat As Label
    Friend WithEvents lblTelp As Label
    Friend WithEvents lblUmur As Label
    Friend WithEvents lblNama As Label
End Class

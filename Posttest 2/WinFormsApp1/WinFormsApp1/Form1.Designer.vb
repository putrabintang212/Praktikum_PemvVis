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
        judul = New Label()
        textjudul = New TextBox()
        tambah = New Button()
        hapus = New Button()
        Label2 = New Label()
        list = New ListBox()
        panel = New Panel()
        judul2 = New Label()
        panel.SuspendLayout()
        SuspendLayout()
        ' 
        ' judul
        ' 
        judul.AutoSize = True
        judul.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        judul.Location = New Point(201, 142)
        judul.Name = "judul"
        judul.Size = New Size(112, 25)
        judul.TabIndex = 0
        judul.Text = "Judul Buku:"
        ' 
        ' textjudul
        ' 
        textjudul.Location = New Point(318, 142)
        textjudul.Name = "textjudul"
        textjudul.Size = New Size(200, 27)
        textjudul.TabIndex = 1
        ' 
        ' tambah
        ' 
        tambah.BackColor = Color.DodgerBlue
        tambah.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        tambah.ForeColor = Color.White
        tambah.Location = New Point(524, 77)
        tambah.Name = "tambah"
        tambah.Size = New Size(136, 80)
        tambah.TabIndex = 2
        tambah.Text = "Tambah Buku"
        tambah.UseVisualStyleBackColor = False
        ' 
        ' hapus
        ' 
        hapus.BackColor = Color.DodgerBlue
        hapus.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        hapus.ForeColor = SystemColors.ButtonFace
        hapus.Location = New Point(524, 163)
        hapus.Name = "hapus"
        hapus.Size = New Size(136, 80)
        hapus.TabIndex = 3
        hapus.Text = "Hapus Buku"
        hapus.UseVisualStyleBackColor = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 10.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(365, 246)
        Label2.Name = "Label2"
        Label2.Size = New Size(115, 25)
        Label2.TabIndex = 4
        Label2.Text = "Daftar Buku"
        ' 
        ' list
        ' 
        list.FormattingEnabled = True
        list.Location = New Point(230, 274)
        list.Name = "list"
        list.Size = New Size(380, 164)
        list.TabIndex = 5
        ' 
        ' panel
        ' 
        panel.BackColor = Color.RoyalBlue
        panel.Controls.Add(judul2)
        panel.Dock = DockStyle.Top
        panel.Location = New Point(0, 0)
        panel.Name = "panel"
        panel.Size = New Size(800, 50)
        panel.TabIndex = 6
        ' 
        ' judul2
        ' 
        judul2.AutoSize = True
        judul2.Font = New Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        judul2.ForeColor = Color.White
        judul2.Location = New Point(267, 9)
        judul2.Name = "judul2"
        judul2.Size = New Size(294, 31)
        judul2.TabIndex = 7
        judul2.Text = "Daftar Buku Perpustakaan"
        judul2.TextAlign = ContentAlignment.MiddleCenter
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(hapus)
        Controls.Add(panel)
        Controls.Add(list)
        Controls.Add(Label2)
        Controls.Add(tambah)
        Controls.Add(textjudul)
        Controls.Add(judul)
        Name = "Form1"
        Text = "Daftar Buku Perpustakaan"
        panel.ResumeLayout(False)
        panel.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents judul As Label
    Friend WithEvents textjudul As TextBox
    Friend WithEvents tambah As Button
    Friend WithEvents hapus As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents list As ListBox
    Friend WithEvents panel As Panel
    Friend WithEvents judul2 As Label

End Class

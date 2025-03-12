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
        IPSemester = New TextBox()
        Tambah = New Button()
        Reset = New Button()
        IPK = New TextBox()
        Label1 = New Label()
        label = New Label()
        lblPredikat = New Label()
        SuspendLayout()
        ' 
        ' IPSemester
        ' 
        IPSemester.Location = New Point(355, 91)
        IPSemester.Name = "IPSemester"
        IPSemester.Size = New Size(194, 27)
        IPSemester.TabIndex = 0
        ' 
        ' Tambah
        ' 
        Tambah.Location = New Point(355, 120)
        Tambah.Name = "Tambah"
        Tambah.Size = New Size(94, 29)
        Tambah.TabIndex = 1
        Tambah.Text = "Tambah"
        Tambah.UseVisualStyleBackColor = True
        ' 
        ' Reset
        ' 
        Reset.Location = New Point(455, 120)
        Reset.Name = "Reset"
        Reset.Size = New Size(94, 29)
        Reset.TabIndex = 2
        Reset.Text = "Reset"
        Reset.UseVisualStyleBackColor = True
        ' 
        ' IPK
        ' 
        IPK.Location = New Point(355, 155)
        IPK.Name = "IPK"
        IPK.Size = New Size(194, 27)
        IPK.TabIndex = 3
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(214, 91)
        Label1.Name = "Label1"
        Label1.Size = New Size(86, 20)
        Label1.TabIndex = 4
        Label1.Text = "IP Semester"
        ' 
        ' label
        ' 
        label.AutoSize = True
        label.Location = New Point(214, 163)
        label.Name = "label"
        label.Size = New Size(89, 20)
        label.TabIndex = 5
        label.Text = "IP Kumulatif"
        ' 
        ' lblPredikat
        ' 
        lblPredikat.AutoSize = True
        lblPredikat.Location = New Point(419, 209)
        lblPredikat.Name = "lblPredikat"
        lblPredikat.Size = New Size(63, 20)
        lblPredikat.TabIndex = 6
        lblPredikat.Text = "Predikat"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 451)
        Controls.Add(lblPredikat)
        Controls.Add(label)
        Controls.Add(Label1)
        Controls.Add(IPK)
        Controls.Add(Reset)
        Controls.Add(Tambah)
        Controls.Add(IPSemester)
        Name = "Form1"
        Text = "2309106016_Putra Bintang Pratama"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents IPSemester As TextBox
    Friend WithEvents Tambah As Button
    Friend WithEvents Reset As Button
    Friend WithEvents IPK As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents label As Label
    Friend WithEvents lblPredikat As Label

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Beranda
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblUser = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnLogout = New System.Windows.Forms.Button()
        Me.btnSubmit = New System.Windows.Forms.Button()
        Me.PanelMouse = New System.Windows.Forms.Panel()
        Me.PanelKeyboard = New System.Windows.Forms.Panel()
        Me.PanelLaptop = New System.Windows.Forms.Panel()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1232, 114)
        Me.Panel1.TabIndex = 3
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.White
        Me.PictureBox1.Image = Global.Testing.My.Resources.Resources.Masukkan
        Me.PictureBox1.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(187, 94)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.White
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.lblUser)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1232, 94)
        Me.Panel3.TabIndex = 1
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(802, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 30)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Beranda"
        '
        'lblUser
        '
        Me.lblUser.AutoSize = True
        Me.lblUser.BackColor = System.Drawing.Color.White
        Me.lblUser.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.lblUser.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.lblUser.Location = New System.Drawing.Point(1020, 28)
        Me.lblUser.Name = "lblUser"
        Me.lblUser.Size = New System.Drawing.Size(140, 30)
        Me.lblUser.TabIndex = 13
        Me.lblUser.Text = "Profil User"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnLogout)
        Me.Panel2.Controls.Add(Me.btnSubmit)
        Me.Panel2.Controls.Add(Me.PanelMouse)
        Me.Panel2.Controls.Add(Me.PanelKeyboard)
        Me.Panel2.Controls.Add(Me.PanelLaptop)
        Me.Panel2.Controls.Add(Me.Label9)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.Label7)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 114)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1232, 608)
        Me.Panel2.TabIndex = 43
        '
        'btnLogout
        '
        Me.btnLogout.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogout.Location = New System.Drawing.Point(405, 556)
        Me.btnLogout.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogout.Name = "btnLogout"
        Me.btnLogout.Size = New System.Drawing.Size(120, 39)
        Me.btnLogout.TabIndex = 51
        Me.btnLogout.Text = "Logout"
        Me.btnLogout.UseVisualStyleBackColor = True
        '
        'btnSubmit
        '
        Me.btnSubmit.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSubmit.Location = New System.Drawing.Point(716, 553)
        Me.btnSubmit.Margin = New System.Windows.Forms.Padding(4)
        Me.btnSubmit.Name = "btnSubmit"
        Me.btnSubmit.Size = New System.Drawing.Size(112, 42)
        Me.btnSubmit.TabIndex = 50
        Me.btnSubmit.Text = "Sumbit"
        Me.btnSubmit.UseVisualStyleBackColor = True
        '
        'PanelMouse
        '
        Me.PanelMouse.AutoScroll = True
        Me.PanelMouse.Location = New System.Drawing.Point(840, 164)
        Me.PanelMouse.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelMouse.Name = "PanelMouse"
        Me.PanelMouse.Size = New System.Drawing.Size(392, 384)
        Me.PanelMouse.TabIndex = 54
        '
        'PanelKeyboard
        '
        Me.PanelKeyboard.AutoScroll = True
        Me.PanelKeyboard.Location = New System.Drawing.Point(405, 164)
        Me.PanelKeyboard.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelKeyboard.Name = "PanelKeyboard"
        Me.PanelKeyboard.Size = New System.Drawing.Size(423, 384)
        Me.PanelKeyboard.TabIndex = 53
        '
        'PanelLaptop
        '
        Me.PanelLaptop.AutoScroll = True
        Me.PanelLaptop.Location = New System.Drawing.Point(0, 164)
        Me.PanelLaptop.Margin = New System.Windows.Forms.Padding(4)
        Me.PanelLaptop.Name = "PanelLaptop"
        Me.PanelLaptop.Size = New System.Drawing.Size(397, 384)
        Me.PanelLaptop.TabIndex = 52
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label9.Location = New System.Drawing.Point(1003, 130)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 30)
        Me.Label9.TabIndex = 49
        Me.Label9.Text = "Mouse"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label8.Location = New System.Drawing.Point(571, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(127, 30)
        Me.Label8.TabIndex = 48
        Me.Label8.Text = "Keyboard"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label7.Location = New System.Drawing.Point(128, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(95, 30)
        Me.Label7.TabIndex = 47
        Me.Label7.Text = "Laptop"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label4.Location = New System.Drawing.Point(488, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(237, 30)
        Me.Label4.TabIndex = 46
        Me.Label4.Text = "Your Tech Solution"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.SystemColors.Control
        Me.Label3.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(98, Byte), Integer), CType(CType(160, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(873, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(174, 59)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "COMP"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(240, Byte), Integer), CType(CType(134, Byte), Integer), CType(CType(34, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(721, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(132, 59)
        Me.Label2.TabIndex = 44
        Me.Label2.Text = "ARC"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 30.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(123, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(460, 59)
        Me.Label1.TabIndex = 43
        Me.Label1.Text = "Selamat Datang di"
        '
        'Beranda
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(239, Byte), Integer), CType(CType(241, Byte), Integer), CType(CType(242, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1232, 722)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Beranda"
        Me.Text = "Beranda"
        Me.Panel1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label5 As Label
    Friend WithEvents lblUser As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents PanelMouse As Panel
    Friend WithEvents PanelKeyboard As Panel
    Friend WithEvents PanelLaptop As Panel
    Friend WithEvents btnLogout As Button
    Friend WithEvents btnSubmit As Button
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class

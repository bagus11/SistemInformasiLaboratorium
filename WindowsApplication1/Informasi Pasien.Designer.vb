<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Informasi_Pasien
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.txtNoJKN = New System.Windows.Forms.TextBox()
        Me.cbJK = New System.Windows.Forms.ComboBox()
        Me.tgllahir = New System.Windows.Forms.DateTimePicker()
        Me.txtAlamat = New System.Windows.Forms.TextBox()
        Me.txtUmur = New System.Windows.Forms.TextBox()
        Me.TxtNamaPasien = New System.Windows.Forms.TextBox()
        Me.txtNoRm = New System.Windows.Forms.TextBox()
        Me.txtDokter = New System.Windows.Forms.TextBox()
        Me.txtAsalRujukan = New System.Windows.Forms.TextBox()
        Me.txtLokasiLab = New System.Windows.Forms.TextBox()
        Me.tglOrder = New System.Windows.Forms.DateTimePicker()
        Me.cbStatusPasien = New System.Windows.Forms.ComboBox()
        Me.cbPasien = New System.Windows.Forms.ComboBox()
        Me.cbKetPasien = New System.Windows.Forms.ComboBox()
        Me.txtNoSampel = New System.Windows.Forms.TextBox()
        Me.txtNoLab = New System.Windows.Forms.TextBox()
        Me.txtKetKlinis = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnEdit = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(24, 213)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1224, 296)
        Me.DataGridView1.TabIndex = 55
        '
        'txtNoJKN
        '
        Me.txtNoJKN.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoJKN.Location = New System.Drawing.Point(1091, 56)
        Me.txtNoJKN.Name = "txtNoJKN"
        Me.txtNoJKN.Size = New System.Drawing.Size(157, 24)
        Me.txtNoJKN.TabIndex = 54
        '
        'cbJK
        '
        Me.cbJK.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJK.FormattingEnabled = True
        Me.cbJK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbJK.Location = New System.Drawing.Point(838, 146)
        Me.cbJK.Name = "cbJK"
        Me.cbJK.Size = New System.Drawing.Size(200, 27)
        Me.cbJK.TabIndex = 53
        '
        'tgllahir
        '
        Me.tgllahir.CalendarFont = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgllahir.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgllahir.Location = New System.Drawing.Point(838, 87)
        Me.tgllahir.Name = "tgllahir"
        Me.tgllahir.Size = New System.Drawing.Size(200, 24)
        Me.tgllahir.TabIndex = 52
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(838, 176)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 31)
        Me.txtAlamat.TabIndex = 51
        '
        'txtUmur
        '
        Me.txtUmur.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUmur.Location = New System.Drawing.Point(838, 117)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(200, 24)
        Me.txtUmur.TabIndex = 50
        '
        'TxtNamaPasien
        '
        Me.TxtNamaPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaPasien.Location = New System.Drawing.Point(838, 56)
        Me.TxtNamaPasien.Multiline = True
        Me.TxtNamaPasien.Name = "TxtNamaPasien"
        Me.TxtNamaPasien.Size = New System.Drawing.Size(200, 25)
        Me.TxtNamaPasien.TabIndex = 49
        '
        'txtNoRm
        '
        Me.txtNoRm.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRm.Location = New System.Drawing.Point(838, 27)
        Me.txtNoRm.Name = "txtNoRm"
        Me.txtNoRm.Size = New System.Drawing.Size(200, 24)
        Me.txtNoRm.TabIndex = 48
        '
        'txtDokter
        '
        Me.txtDokter.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDokter.Location = New System.Drawing.Point(494, 117)
        Me.txtDokter.Name = "txtDokter"
        Me.txtDokter.Size = New System.Drawing.Size(200, 24)
        Me.txtDokter.TabIndex = 47
        '
        'txtAsalRujukan
        '
        Me.txtAsalRujukan.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsalRujukan.Location = New System.Drawing.Point(494, 87)
        Me.txtAsalRujukan.Multiline = True
        Me.txtAsalRujukan.Name = "txtAsalRujukan"
        Me.txtAsalRujukan.Size = New System.Drawing.Size(200, 24)
        Me.txtAsalRujukan.TabIndex = 46
        '
        'txtLokasiLab
        '
        Me.txtLokasiLab.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLokasiLab.Location = New System.Drawing.Point(494, 58)
        Me.txtLokasiLab.Name = "txtLokasiLab"
        Me.txtLokasiLab.Size = New System.Drawing.Size(200, 24)
        Me.txtLokasiLab.TabIndex = 45
        '
        'tglOrder
        '
        Me.tglOrder.CalendarFont = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglOrder.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglOrder.Location = New System.Drawing.Point(494, 30)
        Me.tglOrder.Name = "tglOrder"
        Me.tglOrder.Size = New System.Drawing.Size(200, 24)
        Me.tglOrder.TabIndex = 44
        '
        'cbStatusPasien
        '
        Me.cbStatusPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatusPasien.FormattingEnabled = True
        Me.cbStatusPasien.Items.AddRange(New Object() {"Umum", "BPJS"})
        Me.cbStatusPasien.Location = New System.Drawing.Point(148, 148)
        Me.cbStatusPasien.Name = "cbStatusPasien"
        Me.cbStatusPasien.Size = New System.Drawing.Size(195, 27)
        Me.cbStatusPasien.TabIndex = 43
        '
        'cbPasien
        '
        Me.cbPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPasien.FormattingEnabled = True
        Me.cbPasien.Items.AddRange(New Object() {"Hematologi", "Urinalisa", "Kimia Klinik", "Imunologi", "Mikrobiologi", "Imunohematologi", "Sitologi"})
        Me.cbPasien.Location = New System.Drawing.Point(148, 118)
        Me.cbPasien.Name = "cbPasien"
        Me.cbPasien.Size = New System.Drawing.Size(195, 27)
        Me.cbPasien.TabIndex = 42
        '
        'cbKetPasien
        '
        Me.cbKetPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKetPasien.FormattingEnabled = True
        Me.cbKetPasien.Items.AddRange(New Object() {"Rawat Inap", "Rawat Jalan", "Rujukan"})
        Me.cbKetPasien.Location = New System.Drawing.Point(148, 87)
        Me.cbKetPasien.Name = "cbKetPasien"
        Me.cbKetPasien.Size = New System.Drawing.Size(195, 27)
        Me.cbKetPasien.TabIndex = 41
        '
        'txtNoSampel
        '
        Me.txtNoSampel.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSampel.Location = New System.Drawing.Point(148, 58)
        Me.txtNoSampel.Name = "txtNoSampel"
        Me.txtNoSampel.Size = New System.Drawing.Size(195, 24)
        Me.txtNoSampel.TabIndex = 40
        '
        'txtNoLab
        '
        Me.txtNoLab.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLab.Location = New System.Drawing.Point(148, 30)
        Me.txtNoLab.Name = "txtNoLab"
        Me.txtNoLab.Size = New System.Drawing.Size(195, 24)
        Me.txtNoLab.TabIndex = 39
        '
        'txtKetKlinis
        '
        Me.txtKetKlinis.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKetKlinis.Location = New System.Drawing.Point(148, 178)
        Me.txtKetKlinis.Multiline = True
        Me.txtKetKlinis.Name = "txtKetKlinis"
        Me.txtKetKlinis.Size = New System.Drawing.Size(195, 20)
        Me.txtKetKlinis.TabIndex = 38
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(735, 175)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 23)
        Me.Label18.TabIndex = 35
        Me.Label18.Text = "Alamat"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 175)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 34
        Me.Label6.Text = "Keterangan Klinis"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(735, 143)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 23)
        Me.Label17.TabIndex = 33
        Me.Label17.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 146)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 32
        Me.Label5.Text = "Status Pasien"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(735, 116)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 23)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Umur"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(391, 119)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 23)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Dokter"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 116)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 37
        Me.Label4.Text = "Pemeriksaan"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(735, 89)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 23)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "Tanggal Lahir"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(391, 86)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 23)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Asal Rujukan"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "Ket. Pasien"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(735, 55)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 23)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Nama"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(391, 55)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 23)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Lokasi Lab."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 58)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 36
        Me.Label2.Text = "No. Sampel"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1087, 24)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 23)
        Me.Label11.TabIndex = 24
        Me.Label11.Text = "No. JKN/Jamkesmas/KIS"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(735, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 23)
        Me.Label13.TabIndex = 23
        Me.Label13.Text = "No. RM"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(391, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 21
        Me.Label7.Text = "Tanggal"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(20, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "No. Lab"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.btnEdit)
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 540)
        Me.Panel2.TabIndex = 56
        '
        'btnEdit
        '
        Me.btnEdit.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnEdit.Location = New System.Drawing.Point(1163, 165)
        Me.btnEdit.Name = "btnEdit"
        Me.btnEdit.Size = New System.Drawing.Size(85, 31)
        Me.btnEdit.TabIndex = 0
        Me.btnEdit.Text = "EDIT"
        Me.btnEdit.UseVisualStyleBackColor = True
        '
        'Informasi_Pasien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.txtNoJKN)
        Me.Controls.Add(Me.cbJK)
        Me.Controls.Add(Me.tgllahir)
        Me.Controls.Add(Me.txtAlamat)
        Me.Controls.Add(Me.txtUmur)
        Me.Controls.Add(Me.TxtNamaPasien)
        Me.Controls.Add(Me.txtNoRm)
        Me.Controls.Add(Me.txtDokter)
        Me.Controls.Add(Me.txtAsalRujukan)
        Me.Controls.Add(Me.txtLokasiLab)
        Me.Controls.Add(Me.tglOrder)
        Me.Controls.Add(Me.cbStatusPasien)
        Me.Controls.Add(Me.cbPasien)
        Me.Controls.Add(Me.cbKetPasien)
        Me.Controls.Add(Me.txtNoSampel)
        Me.Controls.Add(Me.txtNoLab)
        Me.Controls.Add(Me.txtKetKlinis)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Informasi_Pasien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Informasi_Pasien"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents txtNoJKN As TextBox
    Friend WithEvents cbJK As ComboBox
    Friend WithEvents tgllahir As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents TxtNamaPasien As TextBox
    Friend WithEvents txtNoRm As TextBox
    Friend WithEvents txtDokter As TextBox
    Friend WithEvents txtAsalRujukan As TextBox
    Friend WithEvents txtLokasiLab As TextBox
    Friend WithEvents tglOrder As DateTimePicker
    Friend WithEvents cbStatusPasien As ComboBox
    Friend WithEvents cbPasien As ComboBox
    Friend WithEvents cbKetPasien As ComboBox
    Friend WithEvents txtNoSampel As TextBox
    Friend WithEvents txtNoLab As TextBox
    Friend WithEvents txtKetKlinis As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnEdit As Button
End Class

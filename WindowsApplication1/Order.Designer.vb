<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Order
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btnOrder = New System.Windows.Forms.Button()
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
        Me.txtKetKlinis = New System.Windows.Forms.TextBox()
        Me.txtNoLab = New System.Windows.Forms.TextBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 7)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(56, 23)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "No. Lab"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(81, 23)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "No. Sampel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 23)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Ket. Pasien"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 96)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 23)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Pemeriksaan"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(96, 23)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Status Pasien"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 155)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(122, 23)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Keterangan Klinis"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(383, 10)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(64, 23)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Tanggal"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(383, 35)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(78, 23)
        Me.Label8.TabIndex = 1
        Me.Label8.Text = "Lokasi Lab."
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(383, 66)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(91, 23)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Asal Rujukan"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(383, 99)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(51, 23)
        Me.Label10.TabIndex = 1
        Me.Label10.Text = "Dokter"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(727, 7)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(51, 23)
        Me.Label13.TabIndex = 0
        Me.Label13.Text = "No. RM"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(727, 35)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(50, 23)
        Me.Label14.TabIndex = 1
        Me.Label14.Text = "Nama"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(727, 69)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(98, 23)
        Me.Label15.TabIndex = 1
        Me.Label15.Text = "Tanggal Lahir"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(727, 96)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 23)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Umur"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(727, 123)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(97, 23)
        Me.Label17.TabIndex = 1
        Me.Label17.Text = "Jenis Kelamin"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(727, 155)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(58, 23)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Alamat"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(1079, 4)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(161, 23)
        Me.Label11.TabIndex = 0
        Me.Label11.Text = "No. JKN/Jamkesmas/KIS"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(16, 193)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(1224, 296)
        Me.DataGridView1.TabIndex = 19
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.txtNoJKN)
        Me.Panel2.Controls.Add(Me.btnOrder)
        Me.Panel2.Controls.Add(Me.cbJK)
        Me.Panel2.Controls.Add(Me.txtNoLab)
        Me.Panel2.Controls.Add(Me.tgllahir)
        Me.Panel2.Controls.Add(Me.txtAlamat)
        Me.Panel2.Controls.Add(Me.txtKetKlinis)
        Me.Panel2.Controls.Add(Me.txtUmur)
        Me.Panel2.Controls.Add(Me.txtNoSampel)
        Me.Panel2.Controls.Add(Me.TxtNamaPasien)
        Me.Panel2.Controls.Add(Me.cbKetPasien)
        Me.Panel2.Controls.Add(Me.txtNoRm)
        Me.Panel2.Controls.Add(Me.cbPasien)
        Me.Panel2.Controls.Add(Me.txtDokter)
        Me.Panel2.Controls.Add(Me.cbStatusPasien)
        Me.Panel2.Controls.Add(Me.txtAsalRujukan)
        Me.Panel2.Controls.Add(Me.tglOrder)
        Me.Panel2.Controls.Add(Me.txtLokasiLab)
        Me.Panel2.Location = New System.Drawing.Point(-8, -20)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 540)
        Me.Panel2.TabIndex = 20
        '
        'btnOrder
        '
        Me.btnOrder.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOrder.Location = New System.Drawing.Point(1129, 170)
        Me.btnOrder.Name = "btnOrder"
        Me.btnOrder.Size = New System.Drawing.Size(85, 33)
        Me.btnOrder.TabIndex = 0
        Me.btnOrder.Text = "ORDER"
        Me.btnOrder.UseVisualStyleBackColor = True
        '
        'txtNoJKN
        '
        Me.txtNoJKN.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoJKN.Location = New System.Drawing.Point(1092, 53)
        Me.txtNoJKN.Name = "txtNoJKN"
        Me.txtNoJKN.Size = New System.Drawing.Size(157, 24)
        Me.txtNoJKN.TabIndex = 72
        '
        'cbJK
        '
        Me.cbJK.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbJK.FormattingEnabled = True
        Me.cbJK.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbJK.Location = New System.Drawing.Point(839, 143)
        Me.cbJK.Name = "cbJK"
        Me.cbJK.Size = New System.Drawing.Size(200, 27)
        Me.cbJK.TabIndex = 71
        '
        'tgllahir
        '
        Me.tgllahir.CalendarFont = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgllahir.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tgllahir.Location = New System.Drawing.Point(839, 84)
        Me.tgllahir.Name = "tgllahir"
        Me.tgllahir.Size = New System.Drawing.Size(200, 24)
        Me.tgllahir.TabIndex = 70
        '
        'txtAlamat
        '
        Me.txtAlamat.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAlamat.Location = New System.Drawing.Point(839, 173)
        Me.txtAlamat.Multiline = True
        Me.txtAlamat.Name = "txtAlamat"
        Me.txtAlamat.Size = New System.Drawing.Size(200, 31)
        Me.txtAlamat.TabIndex = 69
        '
        'txtUmur
        '
        Me.txtUmur.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUmur.Location = New System.Drawing.Point(839, 114)
        Me.txtUmur.Name = "txtUmur"
        Me.txtUmur.Size = New System.Drawing.Size(200, 24)
        Me.txtUmur.TabIndex = 68
        '
        'TxtNamaPasien
        '
        Me.TxtNamaPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TxtNamaPasien.Location = New System.Drawing.Point(839, 53)
        Me.TxtNamaPasien.Multiline = True
        Me.TxtNamaPasien.Name = "TxtNamaPasien"
        Me.TxtNamaPasien.Size = New System.Drawing.Size(200, 25)
        Me.TxtNamaPasien.TabIndex = 67
        '
        'txtNoRm
        '
        Me.txtNoRm.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoRm.Location = New System.Drawing.Point(839, 24)
        Me.txtNoRm.Name = "txtNoRm"
        Me.txtNoRm.Size = New System.Drawing.Size(200, 24)
        Me.txtNoRm.TabIndex = 66
        '
        'txtDokter
        '
        Me.txtDokter.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDokter.Location = New System.Drawing.Point(495, 114)
        Me.txtDokter.Name = "txtDokter"
        Me.txtDokter.Size = New System.Drawing.Size(200, 24)
        Me.txtDokter.TabIndex = 65
        '
        'txtAsalRujukan
        '
        Me.txtAsalRujukan.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAsalRujukan.Location = New System.Drawing.Point(495, 84)
        Me.txtAsalRujukan.Multiline = True
        Me.txtAsalRujukan.Name = "txtAsalRujukan"
        Me.txtAsalRujukan.Size = New System.Drawing.Size(200, 24)
        Me.txtAsalRujukan.TabIndex = 64
        '
        'txtLokasiLab
        '
        Me.txtLokasiLab.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLokasiLab.Location = New System.Drawing.Point(495, 55)
        Me.txtLokasiLab.Name = "txtLokasiLab"
        Me.txtLokasiLab.Size = New System.Drawing.Size(200, 24)
        Me.txtLokasiLab.TabIndex = 63
        '
        'tglOrder
        '
        Me.tglOrder.CalendarFont = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglOrder.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tglOrder.Location = New System.Drawing.Point(495, 27)
        Me.tglOrder.Name = "tglOrder"
        Me.tglOrder.Size = New System.Drawing.Size(200, 24)
        Me.tglOrder.TabIndex = 62
        '
        'cbStatusPasien
        '
        Me.cbStatusPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbStatusPasien.FormattingEnabled = True
        Me.cbStatusPasien.Items.AddRange(New Object() {"Umum", "BPJS"})
        Me.cbStatusPasien.Location = New System.Drawing.Point(149, 145)
        Me.cbStatusPasien.Name = "cbStatusPasien"
        Me.cbStatusPasien.Size = New System.Drawing.Size(195, 27)
        Me.cbStatusPasien.TabIndex = 61
        '
        'cbPasien
        '
        Me.cbPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbPasien.FormattingEnabled = True
        Me.cbPasien.Items.AddRange(New Object() {"Hematologi", "Urinalisa", "Kimia Klinik", "Imunologi", "Mikrobiologi", "Imunohematologi", "Sitologi"})
        Me.cbPasien.Location = New System.Drawing.Point(149, 115)
        Me.cbPasien.Name = "cbPasien"
        Me.cbPasien.Size = New System.Drawing.Size(195, 27)
        Me.cbPasien.TabIndex = 60
        '
        'cbKetPasien
        '
        Me.cbKetPasien.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbKetPasien.FormattingEnabled = True
        Me.cbKetPasien.Items.AddRange(New Object() {"Rawat Inap", "Rawat Jalan", "Rujukan"})
        Me.cbKetPasien.Location = New System.Drawing.Point(149, 84)
        Me.cbKetPasien.Name = "cbKetPasien"
        Me.cbKetPasien.Size = New System.Drawing.Size(195, 27)
        Me.cbKetPasien.TabIndex = 59
        '
        'txtNoSampel
        '
        Me.txtNoSampel.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoSampel.Location = New System.Drawing.Point(149, 55)
        Me.txtNoSampel.Name = "txtNoSampel"
        Me.txtNoSampel.Size = New System.Drawing.Size(195, 24)
        Me.txtNoSampel.TabIndex = 58
        '
        'txtKetKlinis
        '
        Me.txtKetKlinis.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtKetKlinis.Location = New System.Drawing.Point(149, 175)
        Me.txtKetKlinis.Multiline = True
        Me.txtKetKlinis.Name = "txtKetKlinis"
        Me.txtKetKlinis.Size = New System.Drawing.Size(195, 20)
        Me.txtKetKlinis.TabIndex = 56
        '
        'txtNoLab
        '
        Me.txtNoLab.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNoLab.Location = New System.Drawing.Point(149, 27)
        Me.txtNoLab.Name = "txtNoLab"
        Me.txtNoLab.Size = New System.Drawing.Size(195, 24)
        Me.txtNoLab.TabIndex = 57
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1252, 501)
        Me.Controls.Add(Me.DataGridView1)
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
        Me.Name = "Order"
        Me.Text = "Order"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnOrder As Button
    Friend WithEvents txtNoJKN As TextBox
    Friend WithEvents cbJK As ComboBox
    Friend WithEvents txtNoLab As TextBox
    Friend WithEvents tgllahir As DateTimePicker
    Friend WithEvents txtAlamat As TextBox
    Friend WithEvents txtKetKlinis As TextBox
    Friend WithEvents txtUmur As TextBox
    Friend WithEvents txtNoSampel As TextBox
    Friend WithEvents TxtNamaPasien As TextBox
    Friend WithEvents cbKetPasien As ComboBox
    Friend WithEvents txtNoRm As TextBox
    Friend WithEvents cbPasien As ComboBox
    Friend WithEvents txtDokter As TextBox
    Friend WithEvents cbStatusPasien As ComboBox
    Friend WithEvents txtAsalRujukan As TextBox
    Friend WithEvents tglOrder As DateTimePicker
    Friend WithEvents txtLokasiLab As TextBox
End Class

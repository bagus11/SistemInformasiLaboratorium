<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class QC
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
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.labelTest = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.btnRefresh = New System.Windows.Forms.Button()
        Me.cbInstrument = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbQCname = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbLotName = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbNamaTest = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnAbaikan = New System.Windows.Forms.Button()
        Me.btnHapus = New System.Windows.Forms.Button()
        Me.btnBatal = New System.Windows.Forms.Button()
        Me.lblBatasAtas = New System.Windows.Forms.Label()
        Me.lblBatasBawah = New System.Windows.Forms.Label()
        Me.lblTarget = New System.Windows.Forms.Label()
        Me.lblRerata = New System.Windows.Forms.Label()
        Me.lblSD = New System.Windows.Forms.Label()
        Me.lblCV = New System.Windows.Forms.Label()
        Me.Panel2.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Controls.Add(Me.cbNamaTest)
        Me.Panel2.Controls.Add(Me.Label4)
        Me.Panel2.Controls.Add(Me.cbLotName)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.cbQCname)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.btnRefresh)
        Me.Panel2.Controls.Add(Me.cbInstrument)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Chart1)
        Me.Panel2.Controls.Add(Me.labelTest)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Location = New System.Drawing.Point(3, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 540)
        Me.Panel2.TabIndex = 59
        '
        'Chart1
        '
        ChartArea2.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.Chart1.Legends.Add(Legend2)
        Me.Chart1.Location = New System.Drawing.Point(9, 36)
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Pastel
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Series1"
        Me.Chart1.Series.Add(Series2)
        Me.Chart1.Size = New System.Drawing.Size(1097, 192)
        Me.Chart1.TabIndex = 59
        Me.Chart1.Text = "Chart1"
        '
        'labelTest
        '
        Me.labelTest.AutoSize = True
        Me.labelTest.BackColor = System.Drawing.Color.PeachPuff
        Me.labelTest.Font = New System.Drawing.Font("Poppins SemiBold", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelTest.ForeColor = System.Drawing.Color.Red
        Me.labelTest.Location = New System.Drawing.Point(3, 5)
        Me.labelTest.Name = "labelTest"
        Me.labelTest.Size = New System.Drawing.Size(111, 28)
        Me.labelTest.TabIndex = 58
        Me.labelTest.Text = "Hemoglobin"
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(565, 253)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(691, 284)
        Me.DataGridView1.TabIndex = 57
        '
        'btnRefresh
        '
        Me.btnRefresh.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRefresh.Location = New System.Drawing.Point(221, 385)
        Me.btnRefresh.Name = "btnRefresh"
        Me.btnRefresh.Size = New System.Drawing.Size(118, 48)
        Me.btnRefresh.TabIndex = 0
        Me.btnRefresh.Text = "REFRESH"
        Me.btnRefresh.UseVisualStyleBackColor = True
        '
        'cbInstrument
        '
        Me.cbInstrument.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbInstrument.FormattingEnabled = True
        Me.cbInstrument.Items.AddRange(New Object() {"001", "002", "003", "004"})
        Me.cbInstrument.Location = New System.Drawing.Point(144, 253)
        Me.cbInstrument.Name = "cbInstrument"
        Me.cbInstrument.Size = New System.Drawing.Size(195, 27)
        Me.cbInstrument.TabIndex = 61
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(16, 255)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(80, 23)
        Me.Label3.TabIndex = 60
        Me.Label3.Text = "Instrument"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(16, 288)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 23)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "QC. Name"
        '
        'cbQCname
        '
        Me.cbQCname.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbQCname.FormattingEnabled = True
        Me.cbQCname.Items.AddRange(New Object() {"Hematologi", "Kimia Klinik", "Mikrobiologi", "Imunoserologi"})
        Me.cbQCname.Location = New System.Drawing.Point(144, 286)
        Me.cbQCname.Name = "cbQCname"
        Me.cbQCname.Size = New System.Drawing.Size(195, 27)
        Me.cbQCname.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(16, 321)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 23)
        Me.Label2.TabIndex = 60
        Me.Label2.Text = "Lot. No"
        '
        'cbLotName
        '
        Me.cbLotName.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbLotName.FormattingEnabled = True
        Me.cbLotName.Items.AddRange(New Object() {"QC01", "QC02", "QC03", "QC04", "QC05", "QC06", "QC07"})
        Me.cbLotName.Location = New System.Drawing.Point(144, 319)
        Me.cbLotName.Name = "cbLotName"
        Me.cbLotName.Size = New System.Drawing.Size(195, 27)
        Me.cbLotName.TabIndex = 61
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(16, 354)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 23)
        Me.Label4.TabIndex = 60
        Me.Label4.Text = "Nama Test"
        '
        'cbNamaTest
        '
        Me.cbNamaTest.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbNamaTest.FormattingEnabled = True
        Me.cbNamaTest.Items.AddRange(New Object() {"Hemoglobin", "Leukosit", "Trombosit", "Eritrosit", "MCV", "MCH", "MCHC", "Eosinofil", "Retilukosit", "Laju Endap Darah"})
        Me.cbNamaTest.Location = New System.Drawing.Point(144, 352)
        Me.cbNamaTest.Name = "cbNamaTest"
        Me.cbNamaTest.Size = New System.Drawing.Size(195, 27)
        Me.cbNamaTest.TabIndex = 61
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnBatal)
        Me.GroupBox1.Controls.Add(Me.btnHapus)
        Me.GroupBox1.Controls.Add(Me.btnAbaikan)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Location = New System.Drawing.Point(345, 247)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 290)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.lblCV)
        Me.GroupBox2.Controls.Add(Me.lblTarget)
        Me.GroupBox2.Controls.Add(Me.lblSD)
        Me.GroupBox2.Controls.Add(Me.lblBatasBawah)
        Me.GroupBox2.Controls.Add(Me.lblRerata)
        Me.GroupBox2.Controls.Add(Me.lblBatasAtas)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(8, 6)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 183)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(81, 23)
        Me.Label5.TabIndex = 60
        Me.Label5.Text = "Batas Atas"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(96, 23)
        Me.Label6.TabIndex = 60
        Me.Label6.Text = "Batas Bawah"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 56)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(53, 23)
        Me.Label8.TabIndex = 60
        Me.Label8.Text = "Target"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(6, 99)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(75, 23)
        Me.Label9.TabIndex = 60
        Me.Label9.Text = "Rata-rata"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(6, 122)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(26, 23)
        Me.Label10.TabIndex = 60
        Me.Label10.Text = "SD"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(6, 145)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(29, 23)
        Me.Label11.TabIndex = 60
        Me.Label11.Text = "CV"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.Control
        Me.Panel1.Location = New System.Drawing.Point(6, 83)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(188, 10)
        Me.Panel1.TabIndex = 61
        '
        'btnAbaikan
        '
        Me.btnAbaikan.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAbaikan.Location = New System.Drawing.Point(44, 195)
        Me.btnAbaikan.Name = "btnAbaikan"
        Me.btnAbaikan.Size = New System.Drawing.Size(118, 29)
        Me.btnAbaikan.TabIndex = 63
        Me.btnAbaikan.Text = "Abaikan"
        Me.btnAbaikan.UseVisualStyleBackColor = True
        '
        'btnHapus
        '
        Me.btnHapus.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHapus.Location = New System.Drawing.Point(44, 225)
        Me.btnHapus.Name = "btnHapus"
        Me.btnHapus.Size = New System.Drawing.Size(118, 29)
        Me.btnHapus.TabIndex = 63
        Me.btnHapus.Text = "Hapus"
        Me.btnHapus.UseVisualStyleBackColor = True
        '
        'btnBatal
        '
        Me.btnBatal.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBatal.Location = New System.Drawing.Point(44, 255)
        Me.btnBatal.Name = "btnBatal"
        Me.btnBatal.Size = New System.Drawing.Size(118, 29)
        Me.btnBatal.TabIndex = 63
        Me.btnBatal.Text = "Batal"
        Me.btnBatal.UseVisualStyleBackColor = True
        '
        'lblBatasAtas
        '
        Me.lblBatasAtas.AutoSize = True
        Me.lblBatasAtas.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatasAtas.Location = New System.Drawing.Point(146, 10)
        Me.lblBatasAtas.Name = "lblBatasAtas"
        Me.lblBatasAtas.Size = New System.Drawing.Size(29, 23)
        Me.lblBatasAtas.TabIndex = 60
        Me.lblBatasAtas.Text = "120"
        '
        'lblBatasBawah
        '
        Me.lblBatasBawah.AutoSize = True
        Me.lblBatasBawah.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBatasBawah.Location = New System.Drawing.Point(146, 33)
        Me.lblBatasBawah.Name = "lblBatasBawah"
        Me.lblBatasBawah.Size = New System.Drawing.Size(30, 23)
        Me.lblBatasBawah.TabIndex = 60
        Me.lblBatasBawah.Text = "010"
        '
        'lblTarget
        '
        Me.lblTarget.AutoSize = True
        Me.lblTarget.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTarget.Location = New System.Drawing.Point(146, 56)
        Me.lblTarget.Name = "lblTarget"
        Me.lblTarget.Size = New System.Drawing.Size(30, 23)
        Me.lblTarget.TabIndex = 60
        Me.lblTarget.Text = "100"
        '
        'lblRerata
        '
        Me.lblRerata.AutoSize = True
        Me.lblRerata.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRerata.Location = New System.Drawing.Point(147, 101)
        Me.lblRerata.Name = "lblRerata"
        Me.lblRerata.Size = New System.Drawing.Size(29, 23)
        Me.lblRerata.TabIndex = 60
        Me.lblRerata.Text = "120"
        '
        'lblSD
        '
        Me.lblSD.AutoSize = True
        Me.lblSD.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSD.Location = New System.Drawing.Point(147, 124)
        Me.lblSD.Name = "lblSD"
        Me.lblSD.Size = New System.Drawing.Size(30, 23)
        Me.lblSD.TabIndex = 60
        Me.lblSD.Text = "010"
        '
        'lblCV
        '
        Me.lblCV.AutoSize = True
        Me.lblCV.Font = New System.Drawing.Font("Poppins", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCV.Location = New System.Drawing.Point(147, 147)
        Me.lblCV.Name = "lblCV"
        Me.lblCV.Size = New System.Drawing.Size(30, 23)
        Me.lblCV.TabIndex = 60
        Me.lblCV.Text = "100"
        '
        'QC
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "QC"
        Me.Text = "QC"
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnRefresh As Button
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents labelTest As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnBatal As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnAbaikan As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbNamaTest As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents cbLotName As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents cbQCname As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents cbInstrument As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents lblCV As Label
    Friend WithEvents lblTarget As Label
    Friend WithEvents lblSD As Label
    Friend WithEvents lblBatasBawah As Label
    Friend WithEvents lblRerata As Label
    Friend WithEvents lblBatasAtas As Label
End Class

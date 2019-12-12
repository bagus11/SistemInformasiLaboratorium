<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cetak
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
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.btnCetakBarcode = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.btnCetakStruk = New System.Windows.Forms.Button()
        Me.btnCetakHasilPemeriksaan = New System.Windows.Forms.Button()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(11, 76)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(578, 228)
        Me.DataGridView1.TabIndex = 57
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView3)
        Me.Panel2.Controls.Add(Me.btnCetakBarcode)
        Me.Panel2.Controls.Add(Me.DataGridView2)
        Me.Panel2.Controls.Add(Me.btnCetakStruk)
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Controls.Add(Me.btnCetakHasilPemeriksaan)
        Me.Panel2.Location = New System.Drawing.Point(1, 4)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1268, 540)
        Me.Panel2.TabIndex = 58
        '
        'DataGridView3
        '
        Me.DataGridView3.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(14, 352)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(578, 185)
        Me.DataGridView3.TabIndex = 61
        '
        'btnCetakBarcode
        '
        Me.btnCetakBarcode.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakBarcode.Location = New System.Drawing.Point(182, 315)
        Me.btnCetakBarcode.Name = "btnCetakBarcode"
        Me.btnCetakBarcode.Size = New System.Drawing.Size(237, 31)
        Me.btnCetakBarcode.TabIndex = 60
        Me.btnCetakBarcode.Text = "Cetak Barcode"
        Me.btnCetakBarcode.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.BackgroundColor = System.Drawing.Color.WhiteSmoke
        Me.DataGridView2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(598, 76)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(656, 447)
        Me.DataGridView2.TabIndex = 59
        '
        'btnCetakStruk
        '
        Me.btnCetakStruk.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakStruk.Location = New System.Drawing.Point(769, 39)
        Me.btnCetakStruk.Name = "btnCetakStruk"
        Me.btnCetakStruk.Size = New System.Drawing.Size(315, 31)
        Me.btnCetakStruk.TabIndex = 58
        Me.btnCetakStruk.Text = "Cetak Struk Pembayaran"
        Me.btnCetakStruk.UseVisualStyleBackColor = True
        '
        'btnCetakHasilPemeriksaan
        '
        Me.btnCetakHasilPemeriksaan.Font = New System.Drawing.Font("Poppins SemiBold", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCetakHasilPemeriksaan.Location = New System.Drawing.Point(182, 39)
        Me.btnCetakHasilPemeriksaan.Name = "btnCetakHasilPemeriksaan"
        Me.btnCetakHasilPemeriksaan.Size = New System.Drawing.Size(237, 31)
        Me.btnCetakHasilPemeriksaan.TabIndex = 0
        Me.btnCetakHasilPemeriksaan.Text = "Cetak Hasil Pemeriksaan"
        Me.btnCetakHasilPemeriksaan.UseVisualStyleBackColor = True
        '
        'Cetak
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.Panel2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Cetak"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cetak"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel2 As Panel
    Friend WithEvents btnCetakHasilPemeriksaan As Button
    Friend WithEvents DataGridView3 As DataGridView
    Friend WithEvents btnCetakBarcode As Button
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents btnCetakStruk As Button
End Class

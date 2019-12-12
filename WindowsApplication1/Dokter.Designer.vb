<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dokter
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
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnKeluar = New System.Windows.Forms.Button()
        Me.btnCari = New System.Windows.Forms.Button()
        Me.btnHasil = New System.Windows.Forms.Button()
        Me.btnInfoPasien = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(551, 115)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(43, 19)
        Me.Label10.TabIndex = 30
        Me.Label10.Text = "Keluar"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(358, 115)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(31, 19)
        Me.Label9.TabIndex = 29
        Me.Label9.Text = "Cari"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(190, 115)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 19)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Hasil"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Poppins", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(40, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 19)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Info Pasien"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Panel2.Location = New System.Drawing.Point(0, 153)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1267, 554)
        Me.Panel2.TabIndex = 16
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.White
        Me.Panel1.Controls.Add(Me.Label10)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label4)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.btnKeluar)
        Me.Panel1.Controls.Add(Me.btnCari)
        Me.Panel1.Controls.Add(Me.btnHasil)
        Me.Panel1.Controls.Add(Me.btnInfoPasien)
        Me.Panel1.Location = New System.Drawing.Point(0, 2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1267, 145)
        Me.Panel1.TabIndex = 15
        '
        'btnKeluar
        '
        Me.btnKeluar.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.log_out__1_
        Me.btnKeluar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnKeluar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnKeluar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnKeluar.Location = New System.Drawing.Point(522, 12)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(95, 100)
        Me.btnKeluar.TabIndex = 20
        Me.btnKeluar.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnKeluar.UseVisualStyleBackColor = False
        '
        'btnCari
        '
        Me.btnCari.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.search
        Me.btnCari.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCari.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCari.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnCari.Location = New System.Drawing.Point(334, 12)
        Me.btnCari.Name = "btnCari"
        Me.btnCari.Size = New System.Drawing.Size(95, 100)
        Me.btnCari.TabIndex = 14
        Me.btnCari.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnCari.UseVisualStyleBackColor = False
        '
        'btnHasil
        '
        Me.btnHasil.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHasil.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.test
        Me.btnHasil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnHasil.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnHasil.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnHasil.Location = New System.Drawing.Point(164, 12)
        Me.btnHasil.Name = "btnHasil"
        Me.btnHasil.Size = New System.Drawing.Size(95, 100)
        Me.btnHasil.TabIndex = 15
        Me.btnHasil.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnHasil.UseVisualStyleBackColor = False
        '
        'btnInfoPasien
        '
        Me.btnInfoPasien.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInfoPasien.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.patient
        Me.btnInfoPasien.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnInfoPasien.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnInfoPasien.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnInfoPasien.Location = New System.Drawing.Point(21, 12)
        Me.btnInfoPasien.Name = "btnInfoPasien"
        Me.btnInfoPasien.Size = New System.Drawing.Size(95, 100)
        Me.btnInfoPasien.TabIndex = 13
        Me.btnInfoPasien.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnInfoPasien.UseVisualStyleBackColor = False
        '
        'Dokter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 727)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Dokter"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dokter"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Private WithEvents btnKeluar As Button
    Private WithEvents btnCari As Button
    Private WithEvents btnHasil As Button
    Private WithEvents btnInfoPasien As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel1 As Panel
End Class

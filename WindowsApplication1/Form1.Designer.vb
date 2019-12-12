<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label4 = New System.Windows.Forms.Label()
        Me.label3 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.label1 = New System.Windows.Forms.Label()
        Me.btnAdmin = New System.Windows.Forms.Button()
        Me.btnTenagaLab = New System.Windows.Forms.Button()
        Me.btnDokter = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label4.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.label4.Location = New System.Drawing.Point(830, 491)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(120, 56)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Admin " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laboratorium"
        Me.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label3
        '
        Me.label3.AutoSize = True
        Me.label3.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label3.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.label3.Location = New System.Drawing.Point(606, 491)
        Me.label3.Name = "label3"
        Me.label3.Size = New System.Drawing.Size(63, 28)
        Me.label3.TabIndex = 14
        Me.label3.Text = "Dokter"
        Me.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Font = New System.Drawing.Font("Poppins", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label2.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.label2.Location = New System.Drawing.Point(308, 491)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(120, 56)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Tenaga " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laboratorium"
        Me.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'label1
        '
        Me.label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Poppins SemiBold", 72.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.ForeColor = System.Drawing.Color.LightSeaGreen
        Me.label1.Location = New System.Drawing.Point(189, 9)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(896, 338)
        Me.label1.TabIndex = 9
        Me.label1.Text = "Sistem Informasi" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Laboratorium"
        Me.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnAdmin
        '
        Me.btnAdmin.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.unauthorized_person
        Me.btnAdmin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnAdmin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnAdmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnAdmin.Location = New System.Drawing.Point(826, 359)
        Me.btnAdmin.Name = "btnAdmin"
        Me.btnAdmin.Size = New System.Drawing.Size(127, 129)
        Me.btnAdmin.TabIndex = 12
        Me.btnAdmin.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnAdmin.UseVisualStyleBackColor = True
        '
        'btnTenagaLab
        '
        Me.btnTenagaLab.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.scientist
        Me.btnTenagaLab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnTenagaLab.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTenagaLab.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnTenagaLab.Location = New System.Drawing.Point(304, 359)
        Me.btnTenagaLab.Name = "btnTenagaLab"
        Me.btnTenagaLab.Size = New System.Drawing.Size(127, 129)
        Me.btnTenagaLab.TabIndex = 11
        Me.btnTenagaLab.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnTenagaLab.UseVisualStyleBackColor = True
        '
        'btnDokter
        '
        Me.btnDokter.BackgroundImage = Global.WindowsApplication1.My.Resources.Resources.doctor
        Me.btnDokter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnDokter.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnDokter.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btnDokter.Location = New System.Drawing.Point(574, 359)
        Me.btnDokter.Name = "btnDokter"
        Me.btnDokter.Size = New System.Drawing.Size(127, 129)
        Me.btnDokter.TabIndex = 10
        Me.btnDokter.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.btnDokter.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.label3)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.btnAdmin)
        Me.Controls.Add(Me.btnTenagaLab)
        Me.Controls.Add(Me.btnDokter)
        Me.Controls.Add(Me.label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form1"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Private WithEvents label4 As Label
    Private WithEvents label3 As Label
    Private WithEvents label2 As Label
    Private WithEvents btnAdmin As Button
    Private WithEvents btnTenagaLab As Button
    Private WithEvents btnDokter As Button
    Private WithEvents label1 As Label
End Class

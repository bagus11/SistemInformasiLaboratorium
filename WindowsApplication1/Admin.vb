Public Class Admin
    Private Sub Admin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Panel2.Controls.Clear()
        Order.TopLevel = False
        Panel2.Controls.Add(Order)
        Order.Show()
    End Sub

    Private Sub btnOnline_Click(sender As Object, e As EventArgs) Handles btnOnline.Click
        Panel2.Controls.Clear()
        Online.TopLevel = False
        Panel2.Controls.Add(Online)
        Online.Show()
    End Sub

    Private Sub btnTenagaLab_Click(sender As Object, e As EventArgs) Handles btnTenagaLab.Click
        Panel2.Controls.Clear()
        Order.TopLevel = False
        Panel2.Controls.Add(Order)
        Order.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub btnInfoPasien_Click(sender As Object, e As EventArgs) Handles btnInfoPasien.Click
        Panel2.Controls.Clear()
        Informasi_Pasien.TopLevel = False
        Panel2.Controls.Add(Informasi_Pasien)
        Informasi_Pasien.Show()
    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        Panel2.Controls.Clear()
        Hasil.TopLevel = False
        Panel2.Controls.Add(Hasil)
        Hasil.Show()
    End Sub

    Private Sub btnWorklist_Click(sender As Object, e As EventArgs) Handles btnWorklist.Click
        Panel2.Controls.Clear()
        Worklist.TopLevel = False
        Panel2.Controls.Add(Worklist)
        Worklist.Show()
    End Sub

    Private Sub btnCetak_Click(sender As Object, e As EventArgs) Handles btnCetak.Click
        Panel2.Controls.Clear()
        Cetak.TopLevel = False
        Panel2.Controls.Add(Cetak)
        Cetak.Show()
    End Sub

    Private Sub btnStatus_Click(sender As Object, e As EventArgs) Handles btnStatus.Click
        Panel2.Controls.Clear()
        WorkStatus.TopLevel = False
        Panel2.Controls.Add(WorkStatus)
        WorkStatus.Show()
    End Sub

    Private Sub btnQc_Click(sender As Object, e As EventArgs) Handles btnQc.Click
        Panel2.Controls.Clear()
        QC.TopLevel = False
        Panel2.Controls.Add(QC)
        QC.Show()
    End Sub

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Panel2.Controls.Clear()
        Cari.TopLevel = False
        Panel2.Controls.Add(Cari)
        Cari.Show()
    End Sub
End Class
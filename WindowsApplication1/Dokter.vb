﻿Public Class Dokter
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub btnHasil_Click(sender As Object, e As EventArgs) Handles btnHasil.Click
        Panel2.Controls.Clear()
        Hasil.TopLevel = False
        Panel2.Controls.Add(Hasil)
        Hasil.Show()
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

    Private Sub btnCari_Click(sender As Object, e As EventArgs) Handles btnCari.Click
        Panel2.Controls.Clear()
        Cari.TopLevel = False
        Panel2.Controls.Add(Cari)
        Cari.Show()
    End Sub
End Class
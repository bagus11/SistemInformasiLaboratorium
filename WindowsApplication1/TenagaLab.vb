Public Class TenagaLab
    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub btnHematologi_Click(sender As Object, e As EventArgs) Handles btnHematologi.Click
        Panel2.Controls.Clear()
        Hematologi.TopLevel = False
        Panel2.Controls.Add(Hematologi)
        Hematologi.Show()
    End Sub

    Private Sub btnKimiaKlinik_Click(sender As Object, e As EventArgs) Handles btnKimiaKlinik.Click
        Panel2.Controls.Clear()
        KimiaKlinik.TopLevel = False
        Panel2.Controls.Add(KimiaKlinik)
        KimiaKlinik.Show()
    End Sub

    Private Sub btnMikrobiologi_Click(sender As Object, e As EventArgs) Handles btnMikrobiologi.Click
        Panel2.Controls.Clear()
        Mikrobiologi.TopLevel = False
        Panel2.Controls.Add(Mikrobiologi)
        Mikrobiologi.Show()
    End Sub

    Private Sub btnImunoserologi_Click(sender As Object, e As EventArgs) Handles btnImunoserologi.Click
        Panel2.Controls.Clear()
        Imunoserologi.TopLevel = False
        Panel2.Controls.Add(Imunoserologi)
        Imunoserologi.Show()
    End Sub

    Private Sub btnKeluar_Click(sender As Object, e As EventArgs) Handles btnKeluar.Click
        Close()
    End Sub
End Class
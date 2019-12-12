Public Class Form1
    Private Sub btnTenagaLab_Click(sender As Object, e As EventArgs) Handles btnTenagaLab.Click
        TenagaLab.Show()
    End Sub

    Private Sub btnDokter_Click(sender As Object, e As EventArgs) Handles btnDokter.Click
        Dokter.Show()
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        Admin.Show()
    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        TenagaLab.Show()
    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        Dokter.Show()
    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click
        Admin.Show()
    End Sub

    'Private Sub button1_Click(sender As Object, e As EventArgs)
    '    Close()
    'End Sub

    'Private Sub button2_Click(sender As Object, e As EventArgs)
    '    Me.WindowState = FormWindowState.Minimized
    'End Sub
End Class

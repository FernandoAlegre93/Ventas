Public Class Ventas
    Dim Cantidad As Double
    Dim Arroz As Double
    Dim Total As Double

    Private Sub rdbtnBolsa_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnBolsa.CheckedChanged
        Arroz = 100
    End Sub

    Private Sub rdbtnLata_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnLata.CheckedChanged
        Arroz = 120
    End Sub

    Private Sub rdbtnVidrio_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rdbtnVidrio.CheckedChanged
        Arroz = 160
    End Sub

    Private Sub btnPro_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPro.Click
        Total = (Arroz * Cantidad)
        txtbx1.Text = Total
    End Sub

    Private Sub txtbx2_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtbx2.TextChanged
        Cantidad = Val(txtbx2.Text)
    End Sub
End Class

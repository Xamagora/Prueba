﻿Public Class MenuCliente

    Private Sub btnCuslogout_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCuslogout.Click

        Me.Hide()
        Inicio.Show()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        Productos.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Me.Hide()
        Ofertas.Show()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        Comprar.Show()

    End Sub
End Class
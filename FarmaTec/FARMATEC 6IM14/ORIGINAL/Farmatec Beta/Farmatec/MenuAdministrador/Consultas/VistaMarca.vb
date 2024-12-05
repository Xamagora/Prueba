﻿Public Class VistaMarca

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        MarcasDataGridView.Visible = False
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasBindingNavigatorSaveItem.Click

        Try
            Me.Validate()
            Me.MarcasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub VistaMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.FarmatecDataSet.Marcas)

    End Sub

    Private Sub MarcasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles MarcasDataGridView.CellContentClick

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        MarcasDataGridView.Visible = True
    End Sub


End Class
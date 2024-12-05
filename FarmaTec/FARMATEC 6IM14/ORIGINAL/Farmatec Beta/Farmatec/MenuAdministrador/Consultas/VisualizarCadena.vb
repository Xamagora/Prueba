Public Class VisualizarCadena

    Private Sub CadenasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadenasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CadenasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub VisualizarCadena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Cadenas' Puede moverla o quitarla según sea necesario.
        Me.CadenasTableAdapter.Fill(Me.FarmatecDataSet.Cadenas)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        CadenasDataGridView.Visible = True

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        CadenasDataGridView.Visible = False
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub CadenasDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles CadenasDataGridView.CellContentClick

    End Sub
End Class
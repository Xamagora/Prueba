Public Class ActualizarProducto

    Private Sub btnReProducto_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnReProducto.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.ProductosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Detalle_de_Pedido' Puede moverla o quitarla según sea necesario.
        Me.Detalle_de_PedidoTableAdapter.Fill(Me.FarmatecDataSet.Detalle_de_Pedido)
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Detalle_de_Pedido' Puede moverla o quitarla según sea necesario.
        Me.Detalle_de_PedidoTableAdapter.Fill(Me.FarmatecDataSet.Detalle_de_Pedido)
        
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.FarmatecDataSet.Productos)

    End Sub

    Private Sub IdMarcaComboBox_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub
End Class
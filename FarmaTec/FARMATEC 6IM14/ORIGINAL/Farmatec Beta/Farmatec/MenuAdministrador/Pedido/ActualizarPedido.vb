Public Class ActualizarPedido

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub PedidosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.PedidosBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ActualizarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FarmatecDataSet.Clientes)
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.FarmatecDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Detalle_de_Pedido' Puede moverla o quitarla según sea necesario.
        Me.Detalle_de_PedidoTableAdapter.Fill(Me.FarmatecDataSet.Detalle_de_Pedido)
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.FarmatecDataSet.Pedidos)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub
End Class
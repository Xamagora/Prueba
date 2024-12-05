Public Class Comprar

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Detalle_de_PedidoBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.Detalle_de_PedidoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub Comprar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.FarmatecDataSet.Productos)
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Detalle_de_Pedido' Puede moverla o quitarla según sea necesario.
        Me.Detalle_de_PedidoTableAdapter.Fill(Me.FarmatecDataSet.Detalle_de_Pedido)

        IdPedidoTextBox.Text = "0001"
        Nombre_del_ProductoTextBox.Text = "AMOXIXILINA"
        Precio_UnitarioTextBox.Text = "20.5"
        CantidadTextBox.Text = "500"
        ImporteTextBox.Text = ""


    End Sub

    Private Sub IdPedidoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IdPedidoTextBox.TextChanged

    End Sub

    Private Sub IdProductoTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Dim c As Double
        c = 500 * 20.5
        ImporteTextBox.Text = c



    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuCliente.Show()
    End Sub

   
    Private Sub ProductosDataGridView_CellContentClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellEventArgs) Handles ProductosDataGridView.CellContentClick

    End Sub
End Class
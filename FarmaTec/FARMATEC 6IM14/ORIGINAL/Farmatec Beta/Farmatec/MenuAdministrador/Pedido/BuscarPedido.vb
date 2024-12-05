Public Class BuscarPedido

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub PedidosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PedidosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PedidosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub BuscarPedido_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Pedidos' Puede moverla o quitarla según sea necesario.
        Me.PedidosTableAdapter.Fill(Me.FarmatecDataSet.Pedidos)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub FechaLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FillByIdPedidoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByIdPedidoToolStripButton.Click
        Try
            Me.PedidosTableAdapter.FillByIdPedido(Me.FarmatecDataSet.Pedidos, ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub FillByFechaPedidoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByFechaPedidoToolStripButton.Click
        Try
            Me.PedidosTableAdapter.FillByFechaPedido(Me.FarmatecDataSet.Pedidos, New System.Nullable(Of Date)(CType(ToolStripTextBox2.Text, Date)))
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillByIdPedidoToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FillByFechaPedidoToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.PedidosTableAdapter.Fill(Me.FarmatecDataSet.Pedidos)
    End Sub
End Class
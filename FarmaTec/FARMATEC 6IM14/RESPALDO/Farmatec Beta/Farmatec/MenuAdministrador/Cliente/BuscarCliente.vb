Public Class BuscarCliente

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()

    End Sub

    Private Sub ClientesBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClientesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ClientesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub BuscarCliente_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Clientes' Puede moverla o quitarla según sea necesario.
        Me.ClientesTableAdapter.Fill(Me.FarmatecDataSet.Clientes)

    End Sub

    Private Sub FillByIdClienteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByIdClienteToolStripButton.Click
        Try
            Me.ClientesTableAdapter.FillByIdCliente(Me.FarmatecDataSet.Clientes, ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillByIdClienteToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.ClientesTableAdapter.Fill(Me.FarmatecDataSet.Clientes)
    End Sub

    Private Sub FillByNombreClienteToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByNombreClienteToolStripButton.Click
        Try
            Me.ClientesTableAdapter.FillByNombreCliente(Me.FarmatecDataSet.Clientes, ToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FillByNombreClienteToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub
End Class
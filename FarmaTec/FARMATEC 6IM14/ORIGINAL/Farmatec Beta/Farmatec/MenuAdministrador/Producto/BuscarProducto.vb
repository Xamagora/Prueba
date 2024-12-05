Public Class BuscarProducto

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub ProductosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub


    Private Sub ProductosBindingNavigatorSaveItem_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub


    Private Sub ProductosBindingNavigatorSaveItem_Click_2(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProductosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.ProductosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub BuscarProducto_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Productos' Puede moverla o quitarla según sea necesario.
        Me.ProductosTableAdapter.Fill(Me.FarmatecDataSet.Productos)

    End Sub

    Private Sub FillByToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByToolStripButton.Click
        Try
            Me.ProductosTableAdapter.FillBy(Me.FarmatecDataSet.Productos, ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillByToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub FillByNombreProdcutoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByNombreProdcutoToolStripButton.Click
        Try
            Me.ProductosTableAdapter.FillByNombreProdcuto(Me.FarmatecDataSet.Productos, ToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        FillByNombreProdcutoToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton4.Click
        Me.ProductosTableAdapter.Fill(Me.FarmatecDataSet.Productos)
    End Sub

    Private Sub ToolStripLabel2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripLabel2.Click

    End Sub
End Class
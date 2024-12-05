Public Class BuscarMarca

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub MarcasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MarcasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.MarcasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub BuscarMarca_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Marcas' Puede moverla o quitarla según sea necesario.
        Me.MarcasTableAdapter.Fill(Me.FarmatecDataSet.Marcas)

    End Sub

    Private Sub FillByIdMarcaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByIdMarcaToolStripButton.Click
        Try
            Me.MarcasTableAdapter.FillByIdMarca(Me.FarmatecDataSet.Marcas, ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillByIdMarcaToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub FillByNombreMarcaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByNombreMarcaToolStripButton.Click
        Try
            Me.MarcasTableAdapter.FillByNombreMarca(Me.FarmatecDataSet.Marcas, ToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FillByNombreMarcaToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.MarcasTableAdapter.Fill(Me.FarmatecDataSet.Marcas)
    End Sub
End Class
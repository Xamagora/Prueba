Public Class BuscarCadena

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub CadenasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadenasBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.CadenasBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub BuscarCadena_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Cadenas' Puede moverla o quitarla según sea necesario.
        Me.CadenasTableAdapter.Fill(Me.FarmatecDataSet.Cadenas)

    End Sub

    Private Sub FillByIdCadenaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByIdCadenaToolStripButton.Click
        Try
            Me.CadenasTableAdapter.FillByIdCadena(Me.FarmatecDataSet.Cadenas, ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillByIdCadenaToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.CadenasTableAdapter.Fill(Me.FarmatecDataSet.Cadenas)
    End Sub

    Private Sub FillByNombreCadenaToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByNombreCadenaToolStripButton.Click
        Try
            Me.CadenasTableAdapter.FillByNombreCadena(Me.FarmatecDataSet.Cadenas, ToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FillByNombreCadenaToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub
End Class
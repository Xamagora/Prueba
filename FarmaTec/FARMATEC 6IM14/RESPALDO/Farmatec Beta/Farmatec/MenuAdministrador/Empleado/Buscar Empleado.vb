Public Class BuscarEmpleado

    Private Sub PictureBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub EmpleadosBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles EmpleadosBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.EmpleadosBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)

    End Sub

    Private Sub BuscarEmpleado_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Empleados' Puede moverla o quitarla según sea necesario.
        Me.EmpleadosTableAdapter.Fill(Me.FarmatecDataSet.Empleados)

    End Sub

    Private Sub CargoLabel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub FillByIdEmpleadoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByIdEmpleadoToolStripButton.Click
        Try
            Me.EmpleadosTableAdapter.FillByIdEmpleado(Me.FarmatecDataSet.Empleados, ToolStripTextBox1.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton1.Click
        FillByIdEmpleadoToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub

    Private Sub ToolStripButton3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton3.Click
        Me.EmpleadosTableAdapter.Fill(Me.FarmatecDataSet.Empleados)
    End Sub

    Private Sub FillByNombreEmpleadoToolStripButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FillByNombreEmpleadoToolStripButton.Click
        Try
            Me.EmpleadosTableAdapter.FillByNombreEmpleado(Me.FarmatecDataSet.Empleados, ToolStripTextBox2.Text)
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripButton2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ToolStripButton2.Click
        FillByNombreEmpleadoToolStripButton.PerformClick()
        ToolStripTextBox1.Text = ""
        ToolStripTextBox2.Text = ""
    End Sub
End Class
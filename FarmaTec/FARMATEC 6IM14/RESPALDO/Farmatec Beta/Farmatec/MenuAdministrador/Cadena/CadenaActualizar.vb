Public Class CadenaActualizar

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
        MenuAdministrador.Show()
    End Sub

    Private Sub CadenasBindingNavigatorSaveItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CadenasBindingNavigatorSaveItem.Click
        Try
            Me.Validate()
            Me.CadenasBindingSource.EndEdit()
            Me.TableAdapterManager.UpdateAll(Me.FarmatecDataSet)
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CadenaActualizar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'TODO: esta línea de código carga datos en la tabla 'FarmatecDataSet.Cadenas' Puede moverla o quitarla según sea necesario.
        Me.CadenasTableAdapter.Fill(Me.FarmatecDataSet.Cadenas)

    End Sub

    Private Sub GroupBox1_Enter(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Nombre_de_la_CadenaTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Nombre_de_la_CadenaTextBox.TextChanged

    End Sub
End Class
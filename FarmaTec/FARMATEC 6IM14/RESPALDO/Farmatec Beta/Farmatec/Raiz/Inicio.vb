Public Class Inicio

    Private Sub Creadores_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Creadores.SelectedIndexChanged

    End Sub

    Private Sub Inicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Creadores.Items.Add("Creadores:")
        Creadores.Items.Add("Diaz Martinez Luis Antonio")
        Creadores.Items.Add("Fabian Gomez Ana Belen")
        Creadores.Items.Add("Fuentes Raya Elizabeth")
        Creadores.Items.Add("Gonzalez Ramos Xaxiry Magaly")
        Creadores.Items.Add("Quiroz Bonilla Gabriel Alejandro")
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnlogin.Click

        ProgressBar1.Visible = True
        Timer1.Start()
        btnlogin.Enabled = False
        lblcargando.Visible = True
        lblcargando.Text = "Iniciando"






    End Sub

    Private Sub ProgressBar1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ProgressBar1.Click
        
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        ProgressBar1.Increment(1)
        If ProgressBar1.Value = 25 Then
            lblcargando.Text = "25%"
        End If

        If ProgressBar1.Value = 50 Then
            lblcargando.Text = "50%"
        End If

        If ProgressBar1.Value = 50 Then
            lblcargando.Text = "50%"
        End If

        If ProgressBar1.Value = 75 Then
            lblcargando.Text = "75%"
        End If

        If ProgressBar1.Value = ProgressBar1.Maximum Then
            Timer1.Stop()
            lblcargando.Text = "100%"
            btnlogin.Enabled = True
            Me.Hide()
            lblcargando.Visible = False
            ProgressBar1.Visible = False
            ProgressBar1.Value = 0.0
            LoginFarmatec.Show()


        End If

    End Sub

    Private Sub btncerrar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncerrar.Click
        End
    End Sub
End Class

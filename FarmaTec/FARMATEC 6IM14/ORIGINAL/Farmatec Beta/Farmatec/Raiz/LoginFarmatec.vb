Public Class LoginFarmatec

    ' TODO: inserte el código para realizar autenticación personalizada usando el nombre de usuario y la contraseña proporcionada 
    ' (Consulte http://go.microsoft.com/fwlink/?LinkId=35339).  
    ' El objeto principal personalizado se puede adjuntar al objeto principal del subproceso actual como se indica a continuación: 
    '     My.User.CurrentPrincipal = CustomPrincipal
    ' donde CustomPrincipal es la implementación de IPrincipal utilizada para realizar la autenticación. 
    ' Posteriormente, My.User devolverá la información de identidad encapsulada en el objeto CustomPrincipal
    ' como el nombre de usuario, nombre para mostrar, etc.

    Private Sub OK_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles OK.Click
        Dim usuario, contraseña As String
        usuario = UsernameTextBox.Text
        contraseña = PasswordTextBox.Text
        If usuario = "Gabriel" And contraseña = "berlin" Then
            Me.Hide()
            MenuAdministrador.Show()

            UsernameTextBox.Clear()
            PasswordTextBox.Clear()
            UsernameTextBox.Focus()
            PasswordTextBox.Focus()
            MsgBox("Bienvenido Al Menú Administrador", 64, "Saludo")

        ElseIf usuario = "Magaly" And contraseña = "xaxiry" Then
                Me.Hide()
                MenuCliente.Show()

                UsernameTextBox.Clear()
                PasswordTextBox.Clear()
                UsernameTextBox.Focus()
            PasswordTextBox.Focus()
            MsgBox("Bienvenido Al Menú Cliente", 64, "Saludo")
        Else
            MsgBox("Tu Contraseña o Usuario es incorrecto", 0 + 16, "Advertencia")



        End If

    End Sub

    Private Sub Cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Cancel.Click
        End
    End Sub

    Private Sub LoginFarmatec_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UsernameTextBox_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles UsernameTextBox.KeyPress
        soloLetras(e)
    End Sub

    Private Sub UsernameTextBox_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles UsernameTextBox.TextChanged

    End Sub
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Inicio
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Inicio))
        Me.lblversion = New System.Windows.Forms.Label()
        Me.Creadores = New System.Windows.Forms.ListBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblfarmatec = New System.Windows.Forms.Label()
        Me.btnlogin = New System.Windows.Forms.Button()
        Me.btncerrar = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.lblcargando = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblversion
        '
        Me.lblversion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblversion.AutoSize = True
        Me.lblversion.BackColor = System.Drawing.Color.Transparent
        Me.lblversion.Font = New System.Drawing.Font("Georgia", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblversion.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.lblversion.Location = New System.Drawing.Point(504, 287)
        Me.lblversion.Name = "lblversion"
        Me.lblversion.Size = New System.Drawing.Size(164, 25)
        Me.lblversion.TabIndex = 0
        Me.lblversion.Text = "Version: 1.0.1 "
        '
        'Creadores
        '
        Me.Creadores.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Creadores.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Creadores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Creadores.Font = New System.Drawing.Font("Modern No. 20", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Creadores.ForeColor = System.Drawing.SystemColors.Window
        Me.Creadores.FormattingEnabled = True
        Me.Creadores.ItemHeight = 15
        Me.Creadores.Location = New System.Drawing.Point(17, 217)
        Me.Creadores.Name = "Creadores"
        Me.Creadores.Size = New System.Drawing.Size(252, 92)
        Me.Creadores.TabIndex = 1
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmatec.My.Resources.Resources.l_farmatec_converted_fw
        Me.PictureBox1.Location = New System.Drawing.Point(17, 23)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(180, 183)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lblfarmatec
        '
        Me.lblfarmatec.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblfarmatec.AutoSize = True
        Me.lblfarmatec.BackColor = System.Drawing.Color.Transparent
        Me.lblfarmatec.Font = New System.Drawing.Font("Modern No. 20", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfarmatec.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.lblfarmatec.Location = New System.Drawing.Point(364, 41)
        Me.lblfarmatec.Name = "lblfarmatec"
        Me.lblfarmatec.Size = New System.Drawing.Size(287, 25)
        Me.lblfarmatec.TabIndex = 3
        Me.lblfarmatec.Text = "FARMATEC S.A DE C.V"
        Me.lblfarmatec.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnlogin
        '
        Me.btnlogin.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btnlogin.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlogin.Location = New System.Drawing.Point(392, 98)
        Me.btnlogin.Name = "btnlogin"
        Me.btnlogin.Size = New System.Drawing.Size(98, 44)
        Me.btnlogin.TabIndex = 4
        Me.btnlogin.Text = "LogIn"
        Me.btnlogin.UseVisualStyleBackColor = False
        '
        'btncerrar
        '
        Me.btncerrar.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.btncerrar.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncerrar.Location = New System.Drawing.Point(496, 98)
        Me.btncerrar.Name = "btncerrar"
        Me.btncerrar.Size = New System.Drawing.Size(99, 44)
        Me.btncerrar.TabIndex = 5
        Me.btncerrar.Text = "Cerrar"
        Me.btncerrar.UseVisualStyleBackColor = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(414, 233)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(181, 23)
        Me.ProgressBar1.TabIndex = 6
        Me.ProgressBar1.Visible = False
        '
        'lblcargando
        '
        Me.lblcargando.AutoSize = True
        Me.lblcargando.BackColor = System.Drawing.Color.Transparent
        Me.lblcargando.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcargando.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.lblcargando.Location = New System.Drawing.Point(490, 193)
        Me.lblcargando.Name = "lblcargando"
        Me.lblcargando.Size = New System.Drawing.Size(0, 24)
        Me.lblcargando.TabIndex = 7
        Me.lblcargando.Visible = False
        '
        'Timer1
        '
        Me.Timer1.Interval = 25
        '
        'Inicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.Fondo1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(717, 321)
        Me.Controls.Add(Me.lblcargando)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.btncerrar)
        Me.Controls.Add(Me.btnlogin)
        Me.Controls.Add(Me.lblfarmatec)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Creadores)
        Me.Controls.Add(Me.lblversion)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Inicio"
        Me.Text = "Inicio"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblversion As System.Windows.Forms.Label
    Friend WithEvents Creadores As System.Windows.Forms.ListBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblfarmatec As System.Windows.Forms.Label
    Friend WithEvents btnlogin As System.Windows.Forms.Button
    Friend WithEvents btncerrar As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents lblcargando As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer

End Class

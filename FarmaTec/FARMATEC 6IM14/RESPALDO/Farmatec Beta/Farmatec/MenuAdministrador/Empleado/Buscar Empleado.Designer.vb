<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarEmpleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarEmpleado))
        Dim IdEmpleadoLabel As System.Windows.Forms.Label
        Dim Nombre_EmpleadoLabel As System.Windows.Forms.Label
        Dim Apellido_PaternoLabel As System.Windows.Forms.Label
        Dim Apellido_MaternoLabel As System.Windows.Forms.Label
        Dim CURPLabel As System.Windows.Forms.Label
        Dim RFCLabel As System.Windows.Forms.Label
        Dim DireccionLabel As System.Windows.Forms.Label
        Dim TelefonoLabel As System.Windows.Forms.Label
        Dim Correo_ElectronicoLabel As System.Windows.Forms.Label
        Dim CargoLabel As System.Windows.Forms.Label
        Dim Codigo_de_AutorizacionLabel As System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.EmpleadosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.EmpleadosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdEmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_EmpleadoTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_PaternoTextBox = New System.Windows.Forms.TextBox()
        Me.Apellido_MaternoTextBox = New System.Windows.Forms.TextBox()
        Me.CURPTextBox = New System.Windows.Forms.TextBox()
        Me.RFCTextBox = New System.Windows.Forms.TextBox()
        Me.DireccionTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonoTextBox = New System.Windows.Forms.TextBox()
        Me.Correo_ElectronicoTextBox = New System.Windows.Forms.TextBox()
        Me.CargoTextBox = New System.Windows.Forms.TextBox()
        Me.Codigo_de_AutorizacionTextBox = New System.Windows.Forms.TextBox()
        Me.EmpleadosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.FillByIdEmpleadoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdEmpleadoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdEmpleadoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIdEmpleadoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByNombreEmpleadoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Nombre_EmpleadoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Nombre_EmpleadoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNombreEmpleadoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpleadosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmatecDataSet = New Farmatec.FarmatecDataSet()
        Me.EmpleadosTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.EmpleadosTableAdapter()
        Me.TableAdapterManager = New Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager()
        IdEmpleadoLabel = New System.Windows.Forms.Label()
        Nombre_EmpleadoLabel = New System.Windows.Forms.Label()
        Apellido_PaternoLabel = New System.Windows.Forms.Label()
        Apellido_MaternoLabel = New System.Windows.Forms.Label()
        CURPLabel = New System.Windows.Forms.Label()
        RFCLabel = New System.Windows.Forms.Label()
        DireccionLabel = New System.Windows.Forms.Label()
        TelefonoLabel = New System.Windows.Forms.Label()
        Correo_ElectronicoLabel = New System.Windows.Forms.Label()
        CargoLabel = New System.Windows.Forms.Label()
        Codigo_de_AutorizacionLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.EmpleadosBindingNavigator.SuspendLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByIdEmpleadoToolStrip.SuspendLayout()
        Me.FillByNombreEmpleadoToolStrip.SuspendLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.Label1.Location = New System.Drawing.Point(287, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(175, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Buscar Empleado"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmatec.My.Resources.Resources.l_farmatec_converted_fw
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(647, 704)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(IdEmpleadoLabel)
        Me.GroupBox1.Controls.Add(Me.IdEmpleadoTextBox)
        Me.GroupBox1.Controls.Add(Nombre_EmpleadoLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_EmpleadoTextBox)
        Me.GroupBox1.Controls.Add(Apellido_PaternoLabel)
        Me.GroupBox1.Controls.Add(Me.Apellido_PaternoTextBox)
        Me.GroupBox1.Controls.Add(Apellido_MaternoLabel)
        Me.GroupBox1.Controls.Add(Me.Apellido_MaternoTextBox)
        Me.GroupBox1.Controls.Add(CURPLabel)
        Me.GroupBox1.Controls.Add(Me.CURPTextBox)
        Me.GroupBox1.Controls.Add(RFCLabel)
        Me.GroupBox1.Controls.Add(Me.RFCTextBox)
        Me.GroupBox1.Controls.Add(DireccionLabel)
        Me.GroupBox1.Controls.Add(Me.DireccionTextBox)
        Me.GroupBox1.Controls.Add(TelefonoLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonoTextBox)
        Me.GroupBox1.Controls.Add(Correo_ElectronicoLabel)
        Me.GroupBox1.Controls.Add(Me.Correo_ElectronicoTextBox)
        Me.GroupBox1.Controls.Add(CargoLabel)
        Me.GroupBox1.Controls.Add(Me.CargoTextBox)
        Me.GroupBox1.Controls.Add(Codigo_de_AutorizacionLabel)
        Me.GroupBox1.Controls.Add(Me.Codigo_de_AutorizacionTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(30, 110)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(705, 314)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'EmpleadosBindingNavigator
        '
        Me.EmpleadosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.EmpleadosBindingNavigator.BindingSource = Me.EmpleadosBindingSource
        Me.EmpleadosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.EmpleadosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.EmpleadosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.EmpleadosBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.EmpleadosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.EmpleadosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.EmpleadosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.EmpleadosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.EmpleadosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.EmpleadosBindingNavigator.Name = "EmpleadosBindingNavigator"
        Me.EmpleadosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.EmpleadosBindingNavigator.Size = New System.Drawing.Size(759, 25)
        Me.EmpleadosBindingNavigator.TabIndex = 4
        Me.EmpleadosBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Mover primero"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Mover anterior"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Posición"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Posición actual"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Mover siguiente"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Mover último"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Agregar nuevo"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Eliminar"
        '
        'EmpleadosBindingNavigatorSaveItem
        '
        Me.EmpleadosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.EmpleadosBindingNavigatorSaveItem.Image = CType(resources.GetObject("EmpleadosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.EmpleadosBindingNavigatorSaveItem.Name = "EmpleadosBindingNavigatorSaveItem"
        Me.EmpleadosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.EmpleadosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdEmpleadoLabel
        '
        IdEmpleadoLabel.AutoSize = True
        IdEmpleadoLabel.Location = New System.Drawing.Point(27, 36)
        IdEmpleadoLabel.Name = "IdEmpleadoLabel"
        IdEmpleadoLabel.Size = New System.Drawing.Size(108, 18)
        IdEmpleadoLabel.TabIndex = 0
        IdEmpleadoLabel.Text = "Id Empleado:"
        '
        'IdEmpleadoTextBox
        '
        Me.IdEmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "IdEmpleado", True))
        Me.IdEmpleadoTextBox.Location = New System.Drawing.Point(218, 33)
        Me.IdEmpleadoTextBox.Name = "IdEmpleadoTextBox"
        Me.IdEmpleadoTextBox.Size = New System.Drawing.Size(119, 25)
        Me.IdEmpleadoTextBox.TabIndex = 1
        '
        'Nombre_EmpleadoLabel
        '
        Nombre_EmpleadoLabel.AutoSize = True
        Nombre_EmpleadoLabel.Location = New System.Drawing.Point(27, 65)
        Nombre_EmpleadoLabel.Name = "Nombre_EmpleadoLabel"
        Nombre_EmpleadoLabel.Size = New System.Drawing.Size(147, 18)
        Nombre_EmpleadoLabel.TabIndex = 2
        Nombre_EmpleadoLabel.Text = "Nombre Empleado:"
        '
        'Nombre_EmpleadoTextBox
        '
        Me.Nombre_EmpleadoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Nombre Empleado", True))
        Me.Nombre_EmpleadoTextBox.Location = New System.Drawing.Point(218, 62)
        Me.Nombre_EmpleadoTextBox.Name = "Nombre_EmpleadoTextBox"
        Me.Nombre_EmpleadoTextBox.Size = New System.Drawing.Size(119, 25)
        Me.Nombre_EmpleadoTextBox.TabIndex = 3
        '
        'Apellido_PaternoLabel
        '
        Apellido_PaternoLabel.AutoSize = True
        Apellido_PaternoLabel.Location = New System.Drawing.Point(27, 94)
        Apellido_PaternoLabel.Name = "Apellido_PaternoLabel"
        Apellido_PaternoLabel.Size = New System.Drawing.Size(139, 18)
        Apellido_PaternoLabel.TabIndex = 4
        Apellido_PaternoLabel.Text = "Apellido Paterno:"
        '
        'Apellido_PaternoTextBox
        '
        Me.Apellido_PaternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido Paterno", True))
        Me.Apellido_PaternoTextBox.Location = New System.Drawing.Point(218, 91)
        Me.Apellido_PaternoTextBox.Name = "Apellido_PaternoTextBox"
        Me.Apellido_PaternoTextBox.Size = New System.Drawing.Size(119, 25)
        Me.Apellido_PaternoTextBox.TabIndex = 5
        '
        'Apellido_MaternoLabel
        '
        Apellido_MaternoLabel.AutoSize = True
        Apellido_MaternoLabel.Location = New System.Drawing.Point(27, 125)
        Apellido_MaternoLabel.Name = "Apellido_MaternoLabel"
        Apellido_MaternoLabel.Size = New System.Drawing.Size(143, 18)
        Apellido_MaternoLabel.TabIndex = 6
        Apellido_MaternoLabel.Text = "Apellido Materno:"
        '
        'Apellido_MaternoTextBox
        '
        Me.Apellido_MaternoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Apellido Materno", True))
        Me.Apellido_MaternoTextBox.Location = New System.Drawing.Point(218, 122)
        Me.Apellido_MaternoTextBox.Name = "Apellido_MaternoTextBox"
        Me.Apellido_MaternoTextBox.Size = New System.Drawing.Size(119, 25)
        Me.Apellido_MaternoTextBox.TabIndex = 7
        '
        'CURPLabel
        '
        CURPLabel.AutoSize = True
        CURPLabel.Location = New System.Drawing.Point(389, 167)
        CURPLabel.Name = "CURPLabel"
        CURPLabel.Size = New System.Drawing.Size(58, 18)
        CURPLabel.TabIndex = 8
        CURPLabel.Text = "CURP:"
        '
        'CURPTextBox
        '
        Me.CURPTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "CURP", True))
        Me.CURPTextBox.Location = New System.Drawing.Point(465, 167)
        Me.CURPTextBox.Name = "CURPTextBox"
        Me.CURPTextBox.Size = New System.Drawing.Size(169, 25)
        Me.CURPTextBox.TabIndex = 9
        '
        'RFCLabel
        '
        RFCLabel.AutoSize = True
        RFCLabel.Location = New System.Drawing.Point(389, 198)
        RFCLabel.Name = "RFCLabel"
        RFCLabel.Size = New System.Drawing.Size(46, 18)
        RFCLabel.TabIndex = 10
        RFCLabel.Text = "RFC:"
        '
        'RFCTextBox
        '
        Me.RFCTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "RFC", True))
        Me.RFCTextBox.Location = New System.Drawing.Point(465, 198)
        Me.RFCTextBox.Name = "RFCTextBox"
        Me.RFCTextBox.Size = New System.Drawing.Size(169, 25)
        Me.RFCTextBox.TabIndex = 11
        '
        'DireccionLabel
        '
        DireccionLabel.AutoSize = True
        DireccionLabel.Location = New System.Drawing.Point(27, 167)
        DireccionLabel.Name = "DireccionLabel"
        DireccionLabel.Size = New System.Drawing.Size(84, 18)
        DireccionLabel.TabIndex = 12
        DireccionLabel.Text = "Direccion:"
        '
        'DireccionTextBox
        '
        Me.DireccionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Direccion", True))
        Me.DireccionTextBox.Location = New System.Drawing.Point(218, 164)
        Me.DireccionTextBox.Name = "DireccionTextBox"
        Me.DireccionTextBox.Size = New System.Drawing.Size(135, 25)
        Me.DireccionTextBox.TabIndex = 13
        '
        'TelefonoLabel
        '
        TelefonoLabel.AutoSize = True
        TelefonoLabel.Location = New System.Drawing.Point(27, 198)
        TelefonoLabel.Name = "TelefonoLabel"
        TelefonoLabel.Size = New System.Drawing.Size(77, 18)
        TelefonoLabel.TabIndex = 14
        TelefonoLabel.Text = "Telefono:"
        '
        'TelefonoTextBox
        '
        Me.TelefonoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Telefono", True))
        Me.TelefonoTextBox.Location = New System.Drawing.Point(218, 195)
        Me.TelefonoTextBox.Name = "TelefonoTextBox"
        Me.TelefonoTextBox.Size = New System.Drawing.Size(135, 25)
        Me.TelefonoTextBox.TabIndex = 15
        '
        'Correo_ElectronicoLabel
        '
        Correo_ElectronicoLabel.AutoSize = True
        Correo_ElectronicoLabel.Location = New System.Drawing.Point(27, 229)
        Correo_ElectronicoLabel.Name = "Correo_ElectronicoLabel"
        Correo_ElectronicoLabel.Size = New System.Drawing.Size(150, 18)
        Correo_ElectronicoLabel.TabIndex = 16
        Correo_ElectronicoLabel.Text = "Correo Electronico:"
        '
        'Correo_ElectronicoTextBox
        '
        Me.Correo_ElectronicoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Correo Electronico", True))
        Me.Correo_ElectronicoTextBox.Location = New System.Drawing.Point(218, 226)
        Me.Correo_ElectronicoTextBox.Name = "Correo_ElectronicoTextBox"
        Me.Correo_ElectronicoTextBox.Size = New System.Drawing.Size(135, 25)
        Me.Correo_ElectronicoTextBox.TabIndex = 17
        '
        'CargoLabel
        '
        CargoLabel.AutoSize = True
        CargoLabel.Location = New System.Drawing.Point(474, 65)
        CargoLabel.Name = "CargoLabel"
        CargoLabel.Size = New System.Drawing.Size(54, 18)
        CargoLabel.TabIndex = 18
        CargoLabel.Text = "Cargo:"
        AddHandler CargoLabel.Click, AddressOf Me.CargoLabel_Click
        '
        'CargoTextBox
        '
        Me.CargoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Cargo", True))
        Me.CargoTextBox.Location = New System.Drawing.Point(534, 65)
        Me.CargoTextBox.Name = "CargoTextBox"
        Me.CargoTextBox.Size = New System.Drawing.Size(100, 25)
        Me.CargoTextBox.TabIndex = 19
        '
        'Codigo_de_AutorizacionLabel
        '
        Codigo_de_AutorizacionLabel.AutoSize = True
        Codigo_de_AutorizacionLabel.Location = New System.Drawing.Point(343, 94)
        Codigo_de_AutorizacionLabel.Name = "Codigo_de_AutorizacionLabel"
        Codigo_de_AutorizacionLabel.Size = New System.Drawing.Size(185, 18)
        Codigo_de_AutorizacionLabel.TabIndex = 20
        Codigo_de_AutorizacionLabel.Text = "Código de Autorizacion:"
        '
        'Codigo_de_AutorizacionTextBox
        '
        Me.Codigo_de_AutorizacionTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.EmpleadosBindingSource, "Codigo de Autorizacion", True))
        Me.Codigo_de_AutorizacionTextBox.Location = New System.Drawing.Point(534, 96)
        Me.Codigo_de_AutorizacionTextBox.Name = "Codigo_de_AutorizacionTextBox"
        Me.Codigo_de_AutorizacionTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Codigo_de_AutorizacionTextBox.TabIndex = 21
        '
        'EmpleadosDataGridView
        '
        Me.EmpleadosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.EmpleadosDataGridView.AutoGenerateColumns = False
        Me.EmpleadosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.EmpleadosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.EmpleadosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11})
        Me.EmpleadosDataGridView.DataSource = Me.EmpleadosBindingSource
        Me.EmpleadosDataGridView.Location = New System.Drawing.Point(30, 477)
        Me.EmpleadosDataGridView.Name = "EmpleadosDataGridView"
        Me.EmpleadosDataGridView.Size = New System.Drawing.Size(705, 221)
        Me.EmpleadosDataGridView.TabIndex = 5
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(74, 22)
        Me.ToolStripLabel1.Text = "ID Empleado"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = Global.Farmatec.My.Resources.Resources.icono_busqueda
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton1.Text = "Buscar"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(51, 22)
        Me.ToolStripLabel2.Text = "Nombre"
        '
        'ToolStripTextBox2
        '
        Me.ToolStripTextBox2.Name = "ToolStripTextBox2"
        Me.ToolStripTextBox2.Size = New System.Drawing.Size(100, 25)
        '
        'ToolStripButton2
        '
        Me.ToolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton2.Image = Global.Farmatec.My.Resources.Resources.icono_busqueda
        Me.ToolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton2.Name = "ToolStripButton2"
        Me.ToolStripButton2.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton2.Text = "Buscar"
        '
        'ToolStripButton3
        '
        Me.ToolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton3.Image = Global.Farmatec.My.Resources.Resources.refresh
        Me.ToolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton3.Name = "ToolStripButton3"
        Me.ToolStripButton3.Size = New System.Drawing.Size(23, 22)
        Me.ToolStripButton3.Text = "Actualizar"
        '
        'FillByIdEmpleadoToolStrip
        '
        Me.FillByIdEmpleadoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdEmpleadoToolStripLabel, Me.IdEmpleadoToolStripTextBox, Me.FillByIdEmpleadoToolStripButton})
        Me.FillByIdEmpleadoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByIdEmpleadoToolStrip.Name = "FillByIdEmpleadoToolStrip"
        Me.FillByIdEmpleadoToolStrip.Size = New System.Drawing.Size(734, 25)
        Me.FillByIdEmpleadoToolStrip.TabIndex = 6
        Me.FillByIdEmpleadoToolStrip.Text = "FillByIdEmpleadoToolStrip"
        Me.FillByIdEmpleadoToolStrip.Visible = False
        '
        'IdEmpleadoToolStripLabel
        '
        Me.IdEmpleadoToolStripLabel.Name = "IdEmpleadoToolStripLabel"
        Me.IdEmpleadoToolStripLabel.Size = New System.Drawing.Size(73, 22)
        Me.IdEmpleadoToolStripLabel.Text = "IdEmpleado:"
        '
        'IdEmpleadoToolStripTextBox
        '
        Me.IdEmpleadoToolStripTextBox.Name = "IdEmpleadoToolStripTextBox"
        Me.IdEmpleadoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByIdEmpleadoToolStripButton
        '
        Me.FillByIdEmpleadoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIdEmpleadoToolStripButton.Name = "FillByIdEmpleadoToolStripButton"
        Me.FillByIdEmpleadoToolStripButton.Size = New System.Drawing.Size(102, 22)
        Me.FillByIdEmpleadoToolStripButton.Text = "FillByIdEmpleado"
        '
        'FillByNombreEmpleadoToolStrip
        '
        Me.FillByNombreEmpleadoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nombre_EmpleadoToolStripLabel, Me.Nombre_EmpleadoToolStripTextBox, Me.FillByNombreEmpleadoToolStripButton})
        Me.FillByNombreEmpleadoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByNombreEmpleadoToolStrip.Name = "FillByNombreEmpleadoToolStrip"
        Me.FillByNombreEmpleadoToolStrip.Size = New System.Drawing.Size(759, 25)
        Me.FillByNombreEmpleadoToolStrip.TabIndex = 7
        Me.FillByNombreEmpleadoToolStrip.Text = "FillByNombreEmpleadoToolStrip"
        Me.FillByNombreEmpleadoToolStrip.Visible = False
        '
        'Nombre_EmpleadoToolStripLabel
        '
        Me.Nombre_EmpleadoToolStripLabel.Name = "Nombre_EmpleadoToolStripLabel"
        Me.Nombre_EmpleadoToolStripLabel.Size = New System.Drawing.Size(112, 22)
        Me.Nombre_EmpleadoToolStripLabel.Text = "Nombre_Empleado:"
        '
        'Nombre_EmpleadoToolStripTextBox
        '
        Me.Nombre_EmpleadoToolStripTextBox.Name = "Nombre_EmpleadoToolStripTextBox"
        Me.Nombre_EmpleadoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByNombreEmpleadoToolStripButton
        '
        Me.FillByNombreEmpleadoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNombreEmpleadoToolStripButton.Name = "FillByNombreEmpleadoToolStripButton"
        Me.FillByNombreEmpleadoToolStripButton.Size = New System.Drawing.Size(136, 22)
        Me.FillByNombreEmpleadoToolStripButton.Text = "FillByNombreEmpleado"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdEmpleado"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre Empleado"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre Empleado"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Apellido Paterno"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Apellido Paterno"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Apellido Materno"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Apellido Materno"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "CURP"
        Me.DataGridViewTextBoxColumn5.HeaderText = "CURP"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "RFC"
        Me.DataGridViewTextBoxColumn6.HeaderText = "RFC"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Direccion"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Direccion"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Telefono"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Telefono"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "Correo Electronico"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Correo Electronico"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "Cargo"
        Me.DataGridViewTextBoxColumn10.HeaderText = "Cargo"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Codigo de Autorizacion"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Codigo de Autorizacion"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'EmpleadosBindingSource
        '
        Me.EmpleadosBindingSource.DataMember = "Empleados"
        Me.EmpleadosBindingSource.DataSource = Me.FarmatecDataSet
        '
        'FarmatecDataSet
        '
        Me.FarmatecDataSet.DataSetName = "FarmatecDataSet"
        Me.FarmatecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'EmpleadosTableAdapter
        '
        Me.EmpleadosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorizaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadenasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_de_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Me.EmpleadosTableAdapter
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuscarEmpleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.FondoAlternativo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(759, 750)
        Me.Controls.Add(Me.FillByNombreEmpleadoToolStrip)
        Me.Controls.Add(Me.FillByIdEmpleadoToolStrip)
        Me.Controls.Add(Me.EmpleadosDataGridView)
        Me.Controls.Add(Me.EmpleadosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarEmpleado"
        Me.Text = "Buscar Empleado"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.EmpleadosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.EmpleadosBindingNavigator.ResumeLayout(False)
        Me.EmpleadosBindingNavigator.PerformLayout()
        CType(Me.EmpleadosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByIdEmpleadoToolStrip.ResumeLayout(False)
        Me.FillByIdEmpleadoToolStrip.PerformLayout()
        Me.FillByNombreEmpleadoToolStrip.ResumeLayout(False)
        Me.FillByNombreEmpleadoToolStrip.PerformLayout()
        CType(Me.EmpleadosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FarmatecDataSet As Farmatec.FarmatecDataSet
    Friend WithEvents EmpleadosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpleadosTableAdapter As Farmatec.FarmatecDataSetTableAdapters.EmpleadosTableAdapter
    Friend WithEvents TableAdapterManager As Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager
    Friend WithEvents EmpleadosBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents EmpleadosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdEmpleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_EmpleadoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_PaternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Apellido_MaternoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CURPTextBox As System.Windows.Forms.TextBox
    Friend WithEvents RFCTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DireccionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents TelefonoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Correo_ElectronicoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CargoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Codigo_de_AutorizacionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents EmpleadosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByIdEmpleadoToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdEmpleadoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdEmpleadoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByIdEmpleadoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByNombreEmpleadoToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Nombre_EmpleadoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Nombre_EmpleadoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByNombreEmpleadoToolStripButton As System.Windows.Forms.ToolStripButton
End Class

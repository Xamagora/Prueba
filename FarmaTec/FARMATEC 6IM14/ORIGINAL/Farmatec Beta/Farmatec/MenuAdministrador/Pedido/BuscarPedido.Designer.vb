<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarPedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarPedido))
        Dim IdPedidoLabel As System.Windows.Forms.Label
        Dim IdClienteLabel As System.Windows.Forms.Label
        Dim FechaLabel As System.Windows.Forms.Label
        Dim HoraLabel As System.Windows.Forms.Label
        Dim Total_PedidoLabel As System.Windows.Forms.Label
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PedidosBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PedidosBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.IdPedidoTextBox = New System.Windows.Forms.TextBox()
        Me.IdClienteTextBox = New System.Windows.Forms.TextBox()
        Me.FechaDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.HoraDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.Total_PedidoTextBox = New System.Windows.Forms.TextBox()
        Me.PedidosDataGridView = New System.Windows.Forms.DataGridView()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.FillByIdPedidoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdPedidoToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdPedidoToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIdPedidoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByFechaPedidoToolStrip = New System.Windows.Forms.ToolStrip()
        Me.FechaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.FechaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByFechaPedidoToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PedidosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmatecDataSet = New Farmatec.FarmatecDataSet()
        Me.PedidosTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.PedidosTableAdapter()
        Me.TableAdapterManager = New Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager()
        IdPedidoLabel = New System.Windows.Forms.Label()
        IdClienteLabel = New System.Windows.Forms.Label()
        FechaLabel = New System.Windows.Forms.Label()
        HoraLabel = New System.Windows.Forms.Label()
        Total_PedidoLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PedidosBindingNavigator.SuspendLayout()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByIdPedidoToolStrip.SuspendLayout()
        Me.FillByFechaPedidoToolStrip.SuspendLayout()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Farmatec.My.Resources.Resources.l_farmatec_converted_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 62)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(275, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(136, 21)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Buscar Pedido"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(584, 594)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(IdPedidoLabel)
        Me.GroupBox1.Controls.Add(Me.IdPedidoTextBox)
        Me.GroupBox1.Controls.Add(IdClienteLabel)
        Me.GroupBox1.Controls.Add(Me.IdClienteTextBox)
        Me.GroupBox1.Controls.Add(FechaLabel)
        Me.GroupBox1.Controls.Add(Me.FechaDateTimePicker)
        Me.GroupBox1.Controls.Add(HoraLabel)
        Me.GroupBox1.Controls.Add(Me.HoraDateTimePicker)
        Me.GroupBox1.Controls.Add(Total_PedidoLabel)
        Me.GroupBox1.Controls.Add(Me.Total_PedidoTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(44, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(657, 223)
        Me.GroupBox1.TabIndex = 5
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'PedidosBindingNavigator
        '
        Me.PedidosBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PedidosBindingNavigator.BindingSource = Me.PedidosBindingSource
        Me.PedidosBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PedidosBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PedidosBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PedidosBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.PedidosBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PedidosBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PedidosBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PedidosBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PedidosBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PedidosBindingNavigator.Name = "PedidosBindingNavigator"
        Me.PedidosBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PedidosBindingNavigator.Size = New System.Drawing.Size(713, 25)
        Me.PedidosBindingNavigator.TabIndex = 6
        Me.PedidosBindingNavigator.Text = "BindingNavigator1"
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
        'PedidosBindingNavigatorSaveItem
        '
        Me.PedidosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PedidosBindingNavigatorSaveItem.Image = CType(resources.GetObject("PedidosBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PedidosBindingNavigatorSaveItem.Name = "PedidosBindingNavigatorSaveItem"
        Me.PedidosBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PedidosBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'IdPedidoLabel
        '
        IdPedidoLabel.AutoSize = True
        IdPedidoLabel.Location = New System.Drawing.Point(12, 66)
        IdPedidoLabel.Name = "IdPedidoLabel"
        IdPedidoLabel.Size = New System.Drawing.Size(86, 18)
        IdPedidoLabel.TabIndex = 0
        IdPedidoLabel.Text = "Id Pedido:"
        '
        'IdPedidoTextBox
        '
        Me.IdPedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdPedido", True))
        Me.IdPedidoTextBox.Location = New System.Drawing.Point(126, 63)
        Me.IdPedidoTextBox.Name = "IdPedidoTextBox"
        Me.IdPedidoTextBox.Size = New System.Drawing.Size(119, 25)
        Me.IdPedidoTextBox.TabIndex = 1
        '
        'IdClienteLabel
        '
        IdClienteLabel.AutoSize = True
        IdClienteLabel.Location = New System.Drawing.Point(12, 97)
        IdClienteLabel.Name = "IdClienteLabel"
        IdClienteLabel.Size = New System.Drawing.Size(88, 18)
        IdClienteLabel.TabIndex = 2
        IdClienteLabel.Text = "Id Cliente:"
        '
        'IdClienteTextBox
        '
        Me.IdClienteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "IdCliente", True))
        Me.IdClienteTextBox.Location = New System.Drawing.Point(126, 94)
        Me.IdClienteTextBox.Name = "IdClienteTextBox"
        Me.IdClienteTextBox.Size = New System.Drawing.Size(119, 25)
        Me.IdClienteTextBox.TabIndex = 3
        '
        'FechaLabel
        '
        FechaLabel.AutoSize = True
        FechaLabel.Location = New System.Drawing.Point(259, 20)
        FechaLabel.Name = "FechaLabel"
        FechaLabel.Size = New System.Drawing.Size(56, 18)
        FechaLabel.TabIndex = 4
        FechaLabel.Text = "Fecha:"
        AddHandler FechaLabel.Click, AddressOf Me.FechaLabel_Click
        '
        'FechaDateTimePicker
        '
        Me.FechaDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "Fecha", True))
        Me.FechaDateTimePicker.Location = New System.Drawing.Point(321, 20)
        Me.FechaDateTimePicker.Name = "FechaDateTimePicker"
        Me.FechaDateTimePicker.Size = New System.Drawing.Size(292, 25)
        Me.FechaDateTimePicker.TabIndex = 5
        '
        'HoraLabel
        '
        HoraLabel.AutoSize = True
        HoraLabel.Location = New System.Drawing.Point(417, 53)
        HoraLabel.Name = "HoraLabel"
        HoraLabel.Size = New System.Drawing.Size(50, 18)
        HoraLabel.TabIndex = 6
        HoraLabel.Text = "Hora:"
        '
        'HoraDateTimePicker
        '
        Me.HoraDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.PedidosBindingSource, "Hora", True))
        Me.HoraDateTimePicker.Location = New System.Drawing.Point(473, 48)
        Me.HoraDateTimePicker.Name = "HoraDateTimePicker"
        Me.HoraDateTimePicker.Size = New System.Drawing.Size(140, 25)
        Me.HoraDateTimePicker.TabIndex = 7
        '
        'Total_PedidoLabel
        '
        Total_PedidoLabel.AutoSize = True
        Total_PedidoLabel.Location = New System.Drawing.Point(328, 139)
        Total_PedidoLabel.Name = "Total_PedidoLabel"
        Total_PedidoLabel.Size = New System.Drawing.Size(108, 18)
        Total_PedidoLabel.TabIndex = 8
        Total_PedidoLabel.Text = "Total Pedido:"
        '
        'Total_PedidoTextBox
        '
        Me.Total_PedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.PedidosBindingSource, "Total_Pedido", True))
        Me.Total_PedidoTextBox.Location = New System.Drawing.Point(300, 160)
        Me.Total_PedidoTextBox.Name = "Total_PedidoTextBox"
        Me.Total_PedidoTextBox.Size = New System.Drawing.Size(200, 25)
        Me.Total_PedidoTextBox.TabIndex = 9
        '
        'PedidosDataGridView
        '
        Me.PedidosDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PedidosDataGridView.AutoGenerateColumns = False
        Me.PedidosDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.PedidosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PedidosDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.PedidosDataGridView.DataSource = Me.PedidosBindingSource
        Me.PedidosDataGridView.Location = New System.Drawing.Point(72, 353)
        Me.PedidosDataGridView.Name = "PedidosDataGridView"
        Me.PedidosDataGridView.Size = New System.Drawing.Size(612, 185)
        Me.PedidosDataGridView.TabIndex = 6
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(58, 22)
        Me.ToolStripLabel1.Text = "ID Pedido"
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
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(38, 22)
        Me.ToolStripLabel2.Text = "Fecha"
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
        'FillByIdPedidoToolStrip
        '
        Me.FillByIdPedidoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdPedidoToolStripLabel, Me.IdPedidoToolStripTextBox, Me.FillByIdPedidoToolStripButton})
        Me.FillByIdPedidoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByIdPedidoToolStrip.Name = "FillByIdPedidoToolStrip"
        Me.FillByIdPedidoToolStrip.Size = New System.Drawing.Size(713, 25)
        Me.FillByIdPedidoToolStrip.TabIndex = 7
        Me.FillByIdPedidoToolStrip.Text = "FillByIdPedidoToolStrip"
        Me.FillByIdPedidoToolStrip.Visible = False
        '
        'IdPedidoToolStripLabel
        '
        Me.IdPedidoToolStripLabel.Name = "IdPedidoToolStripLabel"
        Me.IdPedidoToolStripLabel.Size = New System.Drawing.Size(57, 22)
        Me.IdPedidoToolStripLabel.Text = "IdPedido:"
        '
        'IdPedidoToolStripTextBox
        '
        Me.IdPedidoToolStripTextBox.Name = "IdPedidoToolStripTextBox"
        Me.IdPedidoToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByIdPedidoToolStripButton
        '
        Me.FillByIdPedidoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIdPedidoToolStripButton.Name = "FillByIdPedidoToolStripButton"
        Me.FillByIdPedidoToolStripButton.Size = New System.Drawing.Size(86, 22)
        Me.FillByIdPedidoToolStripButton.Text = "FillByIdPedido"
        '
        'FillByFechaPedidoToolStrip
        '
        Me.FillByFechaPedidoToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FechaToolStripLabel, Me.FechaToolStripTextBox, Me.FillByFechaPedidoToolStripButton})
        Me.FillByFechaPedidoToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByFechaPedidoToolStrip.Name = "FillByFechaPedidoToolStrip"
        Me.FillByFechaPedidoToolStrip.Size = New System.Drawing.Size(713, 25)
        Me.FillByFechaPedidoToolStrip.TabIndex = 8
        Me.FillByFechaPedidoToolStrip.Text = "FillByFechaPedidoToolStrip"
        Me.FillByFechaPedidoToolStrip.Visible = False
        '
        'FechaToolStripLabel
        '
        Me.FechaToolStripLabel.Name = "FechaToolStripLabel"
        Me.FechaToolStripLabel.Size = New System.Drawing.Size(41, 22)
        Me.FechaToolStripLabel.Text = "Fecha:"
        '
        'FechaToolStripTextBox
        '
        Me.FechaToolStripTextBox.Name = "FechaToolStripTextBox"
        Me.FechaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByFechaPedidoToolStripButton
        '
        Me.FillByFechaPedidoToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByFechaPedidoToolStripButton.Name = "FillByFechaPedidoToolStripButton"
        Me.FillByFechaPedidoToolStripButton.Size = New System.Drawing.Size(107, 22)
        Me.FillByFechaPedidoToolStripButton.Text = "FillByFechaPedido"
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdPedido"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdPedido"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "IdCliente"
        Me.DataGridViewTextBoxColumn2.HeaderText = "IdCliente"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Fecha"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Fecha"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Hora"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Hora"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Total_Pedido"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Total_Pedido"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'PedidosBindingSource
        '
        Me.PedidosBindingSource.DataMember = "Pedidos"
        Me.PedidosBindingSource.DataSource = Me.FarmatecDataSet
        '
        'FarmatecDataSet
        '
        Me.FarmatecDataSet.DataSetName = "FarmatecDataSet"
        Me.FarmatecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PedidosTableAdapter
        '
        Me.PedidosTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorizaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadenasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_de_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Me.PedidosTableAdapter
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuscarPedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.FondoAlternativo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(713, 640)
        Me.Controls.Add(Me.FillByFechaPedidoToolStrip)
        Me.Controls.Add(Me.FillByIdPedidoToolStrip)
        Me.Controls.Add(Me.PedidosDataGridView)
        Me.Controls.Add(Me.PedidosBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BuscarPedido"
        Me.Text = "Buscar Pedido"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PedidosBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PedidosBindingNavigator.ResumeLayout(False)
        Me.PedidosBindingNavigator.PerformLayout()
        CType(Me.PedidosDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByIdPedidoToolStrip.ResumeLayout(False)
        Me.FillByIdPedidoToolStrip.PerformLayout()
        Me.FillByFechaPedidoToolStrip.ResumeLayout(False)
        Me.FillByFechaPedidoToolStrip.PerformLayout()
        CType(Me.PedidosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents FarmatecDataSet As Farmatec.FarmatecDataSet
    Friend WithEvents PedidosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents PedidosTableAdapter As Farmatec.FarmatecDataSetTableAdapters.PedidosTableAdapter
    Friend WithEvents TableAdapterManager As Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PedidosBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents PedidosBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents IdPedidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdClienteTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FechaDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents HoraDateTimePicker As System.Windows.Forms.DateTimePicker
    Friend WithEvents Total_PedidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents PedidosDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByIdPedidoToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdPedidoToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdPedidoToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByIdPedidoToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByFechaPedidoToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents FechaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents FechaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByFechaPedidoToolStripButton As System.Windows.Forms.ToolStripButton
End Class

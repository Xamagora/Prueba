<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarMarca
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
        Dim IdMarcaLabel As System.Windows.Forms.Label
        Dim Nombre_MarcaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarMarca))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FarmatecDataSet = New Farmatec.FarmatecDataSet()
        Me.MarcasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MarcasTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.MarcasTableAdapter()
        Me.TableAdapterManager = New Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager()
        Me.ProductosTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.ProductosTableAdapter()
        Me.MarcasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.MarcasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdMarcaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_MarcaTextBox = New System.Windows.Forms.TextBox()
        Me.MarcasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FillByIdMarcaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdMarcaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdMarcaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIdMarcaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByNombreMarcaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Nombre_MarcaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Nombre_MarcaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNombreMarcaToolStripButton = New System.Windows.Forms.ToolStripButton()
        IdMarcaLabel = New System.Windows.Forms.Label()
        Nombre_MarcaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MarcasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MarcasBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.MarcasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.FillByIdMarcaToolStrip.SuspendLayout()
        Me.FillByNombreMarcaToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdMarcaLabel
        '
        IdMarcaLabel.AutoSize = True
        IdMarcaLabel.Location = New System.Drawing.Point(136, 37)
        IdMarcaLabel.Name = "IdMarcaLabel"
        IdMarcaLabel.Size = New System.Drawing.Size(81, 18)
        IdMarcaLabel.TabIndex = 0
        IdMarcaLabel.Text = "Id Marca:"
        '
        'Nombre_MarcaLabel
        '
        Nombre_MarcaLabel.AutoSize = True
        Nombre_MarcaLabel.Location = New System.Drawing.Point(136, 68)
        Nombre_MarcaLabel.Name = "Nombre_MarcaLabel"
        Nombre_MarcaLabel.Size = New System.Drawing.Size(120, 18)
        Nombre_MarcaLabel.TabIndex = 2
        Nombre_MarcaLabel.Text = "Nombre Marca:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Farmatec.My.Resources.Resources.l_farmatec_converted_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 22)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(571, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(256, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(141, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Buscar Marca"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'FarmatecDataSet
        '
        Me.FarmatecDataSet.DataSetName = "FarmatecDataSet"
        Me.FarmatecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MarcasBindingSource
        '
        Me.MarcasBindingSource.DataMember = "Marcas"
        Me.MarcasBindingSource.DataSource = Me.FarmatecDataSet
        '
        'MarcasTableAdapter
        '
        Me.MarcasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorizaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadenasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_de_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Me.MarcasTableAdapter
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'MarcasBindingNavigator
        '
        Me.MarcasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.MarcasBindingNavigator.BindingSource = Me.MarcasBindingSource
        Me.MarcasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.MarcasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.MarcasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.MarcasBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.MarcasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.MarcasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.MarcasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.MarcasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.MarcasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.MarcasBindingNavigator.Name = "MarcasBindingNavigator"
        Me.MarcasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.MarcasBindingNavigator.Size = New System.Drawing.Size(699, 25)
        Me.MarcasBindingNavigator.TabIndex = 3
        Me.MarcasBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(37, 22)
        Me.BindingNavigatorCountItem.Text = "de {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Número total de elementos"
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
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'MarcasBindingNavigatorSaveItem
        '
        Me.MarcasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.MarcasBindingNavigatorSaveItem.Image = CType(resources.GetObject("MarcasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.MarcasBindingNavigatorSaveItem.Name = "MarcasBindingNavigatorSaveItem"
        Me.MarcasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.MarcasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(68, 22)
        Me.ToolStripLabel1.Text = "ID Empledo"
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
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(IdMarcaLabel)
        Me.GroupBox1.Controls.Add(Me.IdMarcaTextBox)
        Me.GroupBox1.Controls.Add(Nombre_MarcaLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_MarcaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(42, 101)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(629, 141)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'IdMarcaTextBox
        '
        Me.IdMarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "IdMarca", True))
        Me.IdMarcaTextBox.Location = New System.Drawing.Point(262, 34)
        Me.IdMarcaTextBox.Name = "IdMarcaTextBox"
        Me.IdMarcaTextBox.Size = New System.Drawing.Size(100, 25)
        Me.IdMarcaTextBox.TabIndex = 1
        '
        'Nombre_MarcaTextBox
        '
        Me.Nombre_MarcaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MarcasBindingSource, "Nombre_Marca", True))
        Me.Nombre_MarcaTextBox.Location = New System.Drawing.Point(262, 65)
        Me.Nombre_MarcaTextBox.Name = "Nombre_MarcaTextBox"
        Me.Nombre_MarcaTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Nombre_MarcaTextBox.TabIndex = 3
        '
        'MarcasDataGridView
        '
        Me.MarcasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MarcasDataGridView.AutoGenerateColumns = False
        Me.MarcasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.MarcasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MarcasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.MarcasDataGridView.DataSource = Me.MarcasBindingSource
        Me.MarcasDataGridView.Location = New System.Drawing.Point(45, 271)
        Me.MarcasDataGridView.Name = "MarcasDataGridView"
        Me.MarcasDataGridView.Size = New System.Drawing.Size(626, 124)
        Me.MarcasDataGridView.TabIndex = 5
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdMarca"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdMarca"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre_Marca"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre_Marca"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'FillByIdMarcaToolStrip
        '
        Me.FillByIdMarcaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdMarcaToolStripLabel, Me.IdMarcaToolStripTextBox, Me.FillByIdMarcaToolStripButton})
        Me.FillByIdMarcaToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByIdMarcaToolStrip.Name = "FillByIdMarcaToolStrip"
        Me.FillByIdMarcaToolStrip.Size = New System.Drawing.Size(699, 25)
        Me.FillByIdMarcaToolStrip.TabIndex = 6
        Me.FillByIdMarcaToolStrip.Text = "FillByIdMarcaToolStrip"
        Me.FillByIdMarcaToolStrip.Visible = False
        '
        'IdMarcaToolStripLabel
        '
        Me.IdMarcaToolStripLabel.Name = "IdMarcaToolStripLabel"
        Me.IdMarcaToolStripLabel.Size = New System.Drawing.Size(53, 22)
        Me.IdMarcaToolStripLabel.Text = "IdMarca:"
        '
        'IdMarcaToolStripTextBox
        '
        Me.IdMarcaToolStripTextBox.Name = "IdMarcaToolStripTextBox"
        Me.IdMarcaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByIdMarcaToolStripButton
        '
        Me.FillByIdMarcaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIdMarcaToolStripButton.Name = "FillByIdMarcaToolStripButton"
        Me.FillByIdMarcaToolStripButton.Size = New System.Drawing.Size(82, 22)
        Me.FillByIdMarcaToolStripButton.Text = "FillByIdMarca"
        '
        'FillByNombreMarcaToolStrip
        '
        Me.FillByNombreMarcaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nombre_MarcaToolStripLabel, Me.Nombre_MarcaToolStripTextBox, Me.FillByNombreMarcaToolStripButton})
        Me.FillByNombreMarcaToolStrip.Location = New System.Drawing.Point(0, 50)
        Me.FillByNombreMarcaToolStrip.Name = "FillByNombreMarcaToolStrip"
        Me.FillByNombreMarcaToolStrip.Size = New System.Drawing.Size(699, 25)
        Me.FillByNombreMarcaToolStrip.TabIndex = 7
        Me.FillByNombreMarcaToolStrip.Text = "FillByNombreMarcaToolStrip"
        Me.FillByNombreMarcaToolStrip.Visible = False
        '
        'Nombre_MarcaToolStripLabel
        '
        Me.Nombre_MarcaToolStripLabel.Name = "Nombre_MarcaToolStripLabel"
        Me.Nombre_MarcaToolStripLabel.Size = New System.Drawing.Size(92, 22)
        Me.Nombre_MarcaToolStripLabel.Text = "Nombre_Marca:"
        '
        'Nombre_MarcaToolStripTextBox
        '
        Me.Nombre_MarcaToolStripTextBox.Name = "Nombre_MarcaToolStripTextBox"
        Me.Nombre_MarcaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByNombreMarcaToolStripButton
        '
        Me.FillByNombreMarcaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNombreMarcaToolStripButton.Name = "FillByNombreMarcaToolStripButton"
        Me.FillByNombreMarcaToolStripButton.Size = New System.Drawing.Size(116, 22)
        Me.FillByNombreMarcaToolStripButton.Text = "FillByNombreMarca"
        '
        'BuscarMarca
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.FondoAlternativo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(699, 468)
        Me.Controls.Add(Me.FillByNombreMarcaToolStrip)
        Me.Controls.Add(Me.FillByIdMarcaToolStrip)
        Me.Controls.Add(Me.MarcasDataGridView)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MarcasBindingNavigator)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "BuscarMarca"
        Me.Tag = ""
        Me.Text = "Buscar Marca"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MarcasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MarcasBindingNavigator.ResumeLayout(False)
        Me.MarcasBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.MarcasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.FillByIdMarcaToolStrip.ResumeLayout(False)
        Me.FillByIdMarcaToolStrip.PerformLayout()
        Me.FillByNombreMarcaToolStrip.ResumeLayout(False)
        Me.FillByNombreMarcaToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents FarmatecDataSet As Farmatec.FarmatecDataSet
    Friend WithEvents MarcasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents MarcasTableAdapter As Farmatec.FarmatecDataSetTableAdapters.MarcasTableAdapter
    Friend WithEvents TableAdapterManager As Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager
    Friend WithEvents MarcasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents MarcasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ProductosTableAdapter As Farmatec.FarmatecDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IdMarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_MarcaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents MarcasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FillByIdMarcaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdMarcaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdMarcaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByIdMarcaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByNombreMarcaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Nombre_MarcaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Nombre_MarcaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByNombreMarcaToolStripButton As System.Windows.Forms.ToolStripButton
End Class

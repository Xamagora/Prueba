<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BuscarCadena
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
        Dim IdCadenaLabel As System.Windows.Forms.Label
        Dim Nombre_de_la_CadenaLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BuscarCadena))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.CadenasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.CadenasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmatecDataSet = New Farmatec.FarmatecDataSet()
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
        Me.CadenasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripTextBox2 = New System.Windows.Forms.ToolStripTextBox()
        Me.ToolStripButton2 = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButton3 = New System.Windows.Forms.ToolStripButton()
        Me.CadenasDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.IdCadenaTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_de_la_CadenaTextBox = New System.Windows.Forms.TextBox()
        Me.FillByIdCadenaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.IdCadenaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.IdCadenaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByIdCadenaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.FillByNombreCadenaToolStrip = New System.Windows.Forms.ToolStrip()
        Me.Nombre_de_la_CadenaToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.Nombre_de_la_CadenaToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.FillByNombreCadenaToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CadenasTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.CadenasTableAdapter()
        Me.TableAdapterManager = New Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager()
        IdCadenaLabel = New System.Windows.Forms.Label()
        Nombre_de_la_CadenaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadenasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CadenasBindingNavigator.SuspendLayout()
        CType(Me.CadenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadenasDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.FillByIdCadenaToolStrip.SuspendLayout()
        Me.FillByNombreCadenaToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdCadenaLabel
        '
        IdCadenaLabel.AutoSize = True
        IdCadenaLabel.Location = New System.Drawing.Point(65, 44)
        IdCadenaLabel.Name = "IdCadenaLabel"
        IdCadenaLabel.Size = New System.Drawing.Size(88, 18)
        IdCadenaLabel.TabIndex = 0
        IdCadenaLabel.Text = "Id Cadena:"
        '
        'Nombre_de_la_CadenaLabel
        '
        Nombre_de_la_CadenaLabel.AutoSize = True
        Nombre_de_la_CadenaLabel.Location = New System.Drawing.Point(65, 75)
        Nombre_de_la_CadenaLabel.Name = "Nombre_de_la_CadenaLabel"
        Nombre_de_la_CadenaLabel.Size = New System.Drawing.Size(169, 18)
        Nombre_de_la_CadenaLabel.TabIndex = 2
        Nombre_de_la_CadenaLabel.Text = "Nombre de la Cadena:"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Farmatec.My.Resources.Resources.l_farmatec_converted_fw
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 62)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(276, 50)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(148, 24)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Buscar Cadena"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(608, 512)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'CadenasBindingNavigator
        '
        Me.CadenasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CadenasBindingNavigator.BindingSource = Me.CadenasBindingSource
        Me.CadenasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CadenasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CadenasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CadenasBindingNavigatorSaveItem, Me.ToolStripSeparator1, Me.ToolStripLabel1, Me.ToolStripTextBox1, Me.ToolStripButton1, Me.ToolStripSeparator2, Me.ToolStripLabel2, Me.ToolStripTextBox2, Me.ToolStripButton2, Me.ToolStripButton3})
        Me.CadenasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CadenasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CadenasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CadenasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CadenasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CadenasBindingNavigator.Name = "CadenasBindingNavigator"
        Me.CadenasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CadenasBindingNavigator.Size = New System.Drawing.Size(720, 25)
        Me.CadenasBindingNavigator.TabIndex = 6
        Me.CadenasBindingNavigator.Text = "BindingNavigator1"
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
        'CadenasBindingSource
        '
        Me.CadenasBindingSource.DataMember = "Cadenas"
        Me.CadenasBindingSource.DataSource = Me.FarmatecDataSet
        '
        'FarmatecDataSet
        '
        Me.FarmatecDataSet.DataSetName = "FarmatecDataSet"
        Me.FarmatecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CadenasBindingNavigatorSaveItem
        '
        Me.CadenasBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.CadenasBindingNavigatorSaveItem.Image = CType(resources.GetObject("CadenasBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.CadenasBindingNavigatorSaveItem.Name = "CadenasBindingNavigatorSaveItem"
        Me.CadenasBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.CadenasBindingNavigatorSaveItem.Text = "Guardar datos"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(61, 22)
        Me.ToolStripLabel1.Text = "ID Cadena"
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
        'CadenasDataGridView
        '
        Me.CadenasDataGridView.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.CadenasDataGridView.AutoGenerateColumns = False
        Me.CadenasDataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption
        Me.CadenasDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CadenasDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2})
        Me.CadenasDataGridView.DataSource = Me.CadenasBindingSource
        Me.CadenasDataGridView.Location = New System.Drawing.Point(50, 241)
        Me.CadenasDataGridView.Name = "CadenasDataGridView"
        Me.CadenasDataGridView.Size = New System.Drawing.Size(628, 236)
        Me.CadenasDataGridView.TabIndex = 6
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "IdCadena"
        Me.DataGridViewTextBoxColumn1.HeaderText = "IdCadena"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Nombre de la Cadena"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Nombre de la Cadena"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(IdCadenaLabel)
        Me.GroupBox1.Controls.Add(Me.IdCadenaTextBox)
        Me.GroupBox1.Controls.Add(Nombre_de_la_CadenaLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_de_la_CadenaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(50, 113)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(612, 117)
        Me.GroupBox1.TabIndex = 7
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Detalles"
        '
        'IdCadenaTextBox
        '
        Me.IdCadenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadenasBindingSource, "IdCadena", True))
        Me.IdCadenaTextBox.Location = New System.Drawing.Point(240, 41)
        Me.IdCadenaTextBox.Name = "IdCadenaTextBox"
        Me.IdCadenaTextBox.Size = New System.Drawing.Size(100, 25)
        Me.IdCadenaTextBox.TabIndex = 1
        '
        'Nombre_de_la_CadenaTextBox
        '
        Me.Nombre_de_la_CadenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadenasBindingSource, "Nombre de la Cadena", True))
        Me.Nombre_de_la_CadenaTextBox.Location = New System.Drawing.Point(240, 72)
        Me.Nombre_de_la_CadenaTextBox.Name = "Nombre_de_la_CadenaTextBox"
        Me.Nombre_de_la_CadenaTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Nombre_de_la_CadenaTextBox.TabIndex = 3
        '
        'FillByIdCadenaToolStrip
        '
        Me.FillByIdCadenaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IdCadenaToolStripLabel, Me.IdCadenaToolStripTextBox, Me.FillByIdCadenaToolStripButton})
        Me.FillByIdCadenaToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByIdCadenaToolStrip.Name = "FillByIdCadenaToolStrip"
        Me.FillByIdCadenaToolStrip.Size = New System.Drawing.Size(712, 25)
        Me.FillByIdCadenaToolStrip.TabIndex = 8
        Me.FillByIdCadenaToolStrip.Text = "FillByIdCadenaToolStrip"
        Me.FillByIdCadenaToolStrip.Visible = False
        '
        'IdCadenaToolStripLabel
        '
        Me.IdCadenaToolStripLabel.Name = "IdCadenaToolStripLabel"
        Me.IdCadenaToolStripLabel.Size = New System.Drawing.Size(60, 22)
        Me.IdCadenaToolStripLabel.Text = "IdCadena:"
        '
        'IdCadenaToolStripTextBox
        '
        Me.IdCadenaToolStripTextBox.Name = "IdCadenaToolStripTextBox"
        Me.IdCadenaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByIdCadenaToolStripButton
        '
        Me.FillByIdCadenaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByIdCadenaToolStripButton.Name = "FillByIdCadenaToolStripButton"
        Me.FillByIdCadenaToolStripButton.Size = New System.Drawing.Size(89, 22)
        Me.FillByIdCadenaToolStripButton.Text = "FillByIdCadena"
        '
        'FillByNombreCadenaToolStrip
        '
        Me.FillByNombreCadenaToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Nombre_de_la_CadenaToolStripLabel, Me.Nombre_de_la_CadenaToolStripTextBox, Me.FillByNombreCadenaToolStripButton})
        Me.FillByNombreCadenaToolStrip.Location = New System.Drawing.Point(0, 25)
        Me.FillByNombreCadenaToolStrip.Name = "FillByNombreCadenaToolStrip"
        Me.FillByNombreCadenaToolStrip.Size = New System.Drawing.Size(720, 25)
        Me.FillByNombreCadenaToolStrip.TabIndex = 9
        Me.FillByNombreCadenaToolStrip.Text = "FillByNombreCadenaToolStrip"
        Me.FillByNombreCadenaToolStrip.Visible = False
        '
        'Nombre_de_la_CadenaToolStripLabel
        '
        Me.Nombre_de_la_CadenaToolStripLabel.Name = "Nombre_de_la_CadenaToolStripLabel"
        Me.Nombre_de_la_CadenaToolStripLabel.Size = New System.Drawing.Size(131, 22)
        Me.Nombre_de_la_CadenaToolStripLabel.Text = "Nombre_de_la_Cadena:"
        '
        'Nombre_de_la_CadenaToolStripTextBox
        '
        Me.Nombre_de_la_CadenaToolStripTextBox.Name = "Nombre_de_la_CadenaToolStripTextBox"
        Me.Nombre_de_la_CadenaToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'FillByNombreCadenaToolStripButton
        '
        Me.FillByNombreCadenaToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.FillByNombreCadenaToolStripButton.Name = "FillByNombreCadenaToolStripButton"
        Me.FillByNombreCadenaToolStripButton.Size = New System.Drawing.Size(123, 22)
        Me.FillByNombreCadenaToolStripButton.Text = "FillByNombreCadena"
        '
        'CadenasTableAdapter
        '
        Me.CadenasTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorizaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadenasTableAdapter = Me.CadenasTableAdapter
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_de_PedidoTableAdapter = Nothing
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'BuscarCadena
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.FondoAlternativo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(720, 558)
        Me.Controls.Add(Me.FillByNombreCadenaToolStrip)
        Me.Controls.Add(Me.FillByIdCadenaToolStrip)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.CadenasDataGridView)
        Me.Controls.Add(Me.CadenasBindingNavigator)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "BuscarCadena"
        Me.Text = "Buscar Cadena"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadenasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CadenasBindingNavigator.ResumeLayout(False)
        Me.CadenasBindingNavigator.PerformLayout()
        CType(Me.CadenasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadenasDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.FillByIdCadenaToolStrip.ResumeLayout(False)
        Me.FillByIdCadenaToolStrip.PerformLayout()
        Me.FillByNombreCadenaToolStrip.ResumeLayout(False)
        Me.FillByNombreCadenaToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FarmatecDataSet As Farmatec.FarmatecDataSet
    Friend WithEvents CadenasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CadenasTableAdapter As Farmatec.FarmatecDataSetTableAdapters.CadenasTableAdapter
    Friend WithEvents TableAdapterManager As Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager
    Friend WithEvents CadenasBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents CadenasBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox1 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton1 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ToolStripLabel2 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents ToolStripTextBox2 As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents ToolStripButton2 As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripButton3 As System.Windows.Forms.ToolStripButton
    Friend WithEvents CadenasDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents IdCadenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Nombre_de_la_CadenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents FillByIdCadenaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents IdCadenaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents IdCadenaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByIdCadenaToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents FillByNombreCadenaToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents Nombre_de_la_CadenaToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Nombre_de_la_CadenaToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents FillByNombreCadenaToolStripButton As System.Windows.Forms.ToolStripButton
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CadenaActualizar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CadenaActualizar))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Nombre_de_la_CadenaTextBox = New System.Windows.Forms.TextBox()
        Me.CadenasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmatecDataSet = New Farmatec.FarmatecDataSet()
        Me.IdCadenaTextBox = New System.Windows.Forms.TextBox()
        Me.CadenasTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.CadenasTableAdapter()
        Me.TableAdapterManager = New Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager()
        Me.CadenasBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.CadenasBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        IdCadenaLabel = New System.Windows.Forms.Label()
        Nombre_de_la_CadenaLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.CadenasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CadenasBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.CadenasBindingNavigator.SuspendLayout()
        Me.SuspendLayout()
        '
        'IdCadenaLabel
        '
        IdCadenaLabel.AutoSize = True
        IdCadenaLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdCadenaLabel.Location = New System.Drawing.Point(52, 38)
        IdCadenaLabel.Name = "IdCadenaLabel"
        IdCadenaLabel.Size = New System.Drawing.Size(88, 18)
        IdCadenaLabel.TabIndex = 0
        IdCadenaLabel.Text = "Id Cadena:"
        '
        'Nombre_de_la_CadenaLabel
        '
        Nombre_de_la_CadenaLabel.AutoSize = True
        Nombre_de_la_CadenaLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_de_la_CadenaLabel.Location = New System.Drawing.Point(278, 42)
        Nombre_de_la_CadenaLabel.Name = "Nombre_de_la_CadenaLabel"
        Nombre_de_la_CadenaLabel.Size = New System.Drawing.Size(169, 18)
        Nombre_de_la_CadenaLabel.TabIndex = 2
        Nombre_de_la_CadenaLabel.Text = "Nombre de la Cadena:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(549, 268)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = Global.Farmatec.My.Resources.Resources.l_farmatec_converted_fw
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 62)
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(195, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(240, 24)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Actualización de Cadena"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.GroupBox1.Controls.Add(Nombre_de_la_CadenaLabel)
        Me.GroupBox1.Controls.Add(Me.Nombre_de_la_CadenaTextBox)
        Me.GroupBox1.Controls.Add(IdCadenaLabel)
        Me.GroupBox1.Controls.Add(Me.IdCadenaTextBox)
        Me.GroupBox1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.GroupBox1.Location = New System.Drawing.Point(12, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(611, 146)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Cadena"
        '
        'Nombre_de_la_CadenaTextBox
        '
        Me.Nombre_de_la_CadenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadenasBindingSource, "Nombre de la Cadena", True))
        Me.Nombre_de_la_CadenaTextBox.Location = New System.Drawing.Point(281, 64)
        Me.Nombre_de_la_CadenaTextBox.Name = "Nombre_de_la_CadenaTextBox"
        Me.Nombre_de_la_CadenaTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Nombre_de_la_CadenaTextBox.TabIndex = 3
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
        'IdCadenaTextBox
        '
        Me.IdCadenaTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.CadenasBindingSource, "IdCadena", True))
        Me.IdCadenaTextBox.Location = New System.Drawing.Point(55, 64)
        Me.IdCadenaTextBox.Name = "IdCadenaTextBox"
        Me.IdCadenaTextBox.Size = New System.Drawing.Size(100, 25)
        Me.IdCadenaTextBox.TabIndex = 1
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
        'CadenasBindingNavigator
        '
        Me.CadenasBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.CadenasBindingNavigator.BindingSource = Me.CadenasBindingSource
        Me.CadenasBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.CadenasBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.CadenasBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.CadenasBindingNavigatorSaveItem})
        Me.CadenasBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.CadenasBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.CadenasBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.CadenasBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.CadenasBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.CadenasBindingNavigator.Name = "CadenasBindingNavigator"
        Me.CadenasBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.CadenasBindingNavigator.Size = New System.Drawing.Size(675, 25)
        Me.CadenasBindingNavigator.TabIndex = 5
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
        'CadenaActualizar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.FondoAlternativo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(675, 314)
        Me.Controls.Add(Me.CadenasBindingNavigator)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "CadenaActualizar"
        Me.Text = "CadenaActualizar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.CadenasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CadenasBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.CadenasBindingNavigator.ResumeLayout(False)
        Me.CadenasBindingNavigator.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
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
    Friend WithEvents Nombre_de_la_CadenaTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IdCadenaTextBox As System.Windows.Forms.TextBox
End Class

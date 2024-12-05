<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Comprar
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
        Dim IdPedidoLabel As System.Windows.Forms.Label
        Dim CantidadLabel As System.Windows.Forms.Label
        Dim Nombre_del_ProductoLabel As System.Windows.Forms.Label
        Dim Precio_UnitarioLabel As System.Windows.Forms.Label
        Dim ImporteLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Comprar))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.IdPedidoTextBox = New System.Windows.Forms.TextBox()
        Me.CantidadTextBox = New System.Windows.Forms.TextBox()
        Me.Nombre_del_ProductoTextBox = New System.Windows.Forms.TextBox()
        Me.Precio_UnitarioTextBox = New System.Windows.Forms.TextBox()
        Me.ImporteTextBox = New System.Windows.Forms.TextBox()
        Me.Detalle_de_PedidoBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FarmatecDataSet = New Farmatec.FarmatecDataSet()
        Me.ProductosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Detalle_de_PedidoTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.Detalle_de_PedidoTableAdapter()
        Me.TableAdapterManager = New Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager()
        Me.ProductosTableAdapter = New Farmatec.FarmatecDataSetTableAdapters.ProductosTableAdapter()
        IdPedidoLabel = New System.Windows.Forms.Label()
        CantidadLabel = New System.Windows.Forms.Label()
        Nombre_del_ProductoLabel = New System.Windows.Forms.Label()
        Precio_UnitarioLabel = New System.Windows.Forms.Label()
        ImporteLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Detalle_de_PedidoBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IdPedidoLabel
        '
        IdPedidoLabel.AutoSize = True
        IdPedidoLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        IdPedidoLabel.Location = New System.Drawing.Point(60, 105)
        IdPedidoLabel.Name = "IdPedidoLabel"
        IdPedidoLabel.Size = New System.Drawing.Size(86, 18)
        IdPedidoLabel.TabIndex = 23
        IdPedidoLabel.Text = "Id Pedido:"
        '
        'CantidadLabel
        '
        CantidadLabel.AutoSize = True
        CantidadLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        CantidadLabel.Location = New System.Drawing.Point(236, 189)
        CantidadLabel.Name = "CantidadLabel"
        CantidadLabel.Size = New System.Drawing.Size(79, 18)
        CantidadLabel.TabIndex = 25
        CantidadLabel.Text = "Cantidad:"
        '
        'Nombre_del_ProductoLabel
        '
        Nombre_del_ProductoLabel.AutoSize = True
        Nombre_del_ProductoLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Nombre_del_ProductoLabel.Location = New System.Drawing.Point(498, 105)
        Nombre_del_ProductoLabel.Name = "Nombre_del_ProductoLabel"
        Nombre_del_ProductoLabel.Size = New System.Drawing.Size(168, 18)
        Nombre_del_ProductoLabel.TabIndex = 26
        Nombre_del_ProductoLabel.Text = "Nombre del Producto:"
        '
        'Precio_UnitarioLabel
        '
        Precio_UnitarioLabel.AutoSize = True
        Precio_UnitarioLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Precio_UnitarioLabel.Location = New System.Drawing.Point(455, 186)
        Precio_UnitarioLabel.Name = "Precio_UnitarioLabel"
        Precio_UnitarioLabel.Size = New System.Drawing.Size(128, 18)
        Precio_UnitarioLabel.TabIndex = 27
        Precio_UnitarioLabel.Text = "Precio Unitario:"
        '
        'ImporteLabel
        '
        ImporteLabel.AutoSize = True
        ImporteLabel.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        ImporteLabel.Location = New System.Drawing.Point(370, 236)
        ImporteLabel.Name = "ImporteLabel"
        ImporteLabel.Size = New System.Drawing.Size(71, 18)
        ImporteLabel.TabIndex = 28
        ImporteLabel.Text = "Importe:"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(12, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(103, 62)
        Me.PictureBox1.TabIndex = 7
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Modern No. 20", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(266, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(266, 23)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Compras"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button2.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.Button2.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(449, 379)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 23
        Me.Button2.Text = "calcular"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(711, 427)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 22
        Me.Button1.Text = "Regresar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'IdPedidoTextBox
        '
        Me.IdPedidoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_de_PedidoBindingSource, "IdPedido", True))
        Me.IdPedidoTextBox.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.IdPedidoTextBox.Location = New System.Drawing.Point(171, 98)
        Me.IdPedidoTextBox.Name = "IdPedidoTextBox"
        Me.IdPedidoTextBox.Size = New System.Drawing.Size(100, 25)
        Me.IdPedidoTextBox.TabIndex = 24
        '
        'CantidadTextBox
        '
        Me.CantidadTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_de_PedidoBindingSource, "Cantidad", True))
        Me.CantidadTextBox.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CantidadTextBox.Location = New System.Drawing.Point(321, 179)
        Me.CantidadTextBox.Name = "CantidadTextBox"
        Me.CantidadTextBox.Size = New System.Drawing.Size(100, 25)
        Me.CantidadTextBox.TabIndex = 26
        '
        'Nombre_del_ProductoTextBox
        '
        Me.Nombre_del_ProductoTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProductosBindingSource, "Nombre del Producto", True))
        Me.Nombre_del_ProductoTextBox.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Nombre_del_ProductoTextBox.Location = New System.Drawing.Point(672, 105)
        Me.Nombre_del_ProductoTextBox.Name = "Nombre_del_ProductoTextBox"
        Me.Nombre_del_ProductoTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Nombre_del_ProductoTextBox.TabIndex = 27
        '
        'Precio_UnitarioTextBox
        '
        Me.Precio_UnitarioTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_de_PedidoBindingSource, "Precio_Unitario", True))
        Me.Precio_UnitarioTextBox.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Precio_UnitarioTextBox.Location = New System.Drawing.Point(589, 183)
        Me.Precio_UnitarioTextBox.Name = "Precio_UnitarioTextBox"
        Me.Precio_UnitarioTextBox.Size = New System.Drawing.Size(100, 25)
        Me.Precio_UnitarioTextBox.TabIndex = 28
        '
        'ImporteTextBox
        '
        Me.ImporteTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.Detalle_de_PedidoBindingSource, "Importe", True))
        Me.ImporteTextBox.Font = New System.Drawing.Font("Modern No. 20", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ImporteTextBox.Location = New System.Drawing.Point(458, 229)
        Me.ImporteTextBox.Name = "ImporteTextBox"
        Me.ImporteTextBox.Size = New System.Drawing.Size(100, 25)
        Me.ImporteTextBox.TabIndex = 29
        '
        'Detalle_de_PedidoBindingSource
        '
        Me.Detalle_de_PedidoBindingSource.DataMember = "Detalle de Pedido"
        Me.Detalle_de_PedidoBindingSource.DataSource = Me.FarmatecDataSet
        '
        'FarmatecDataSet
        '
        Me.FarmatecDataSet.DataSetName = "FarmatecDataSet"
        Me.FarmatecDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ProductosBindingSource
        '
        Me.ProductosBindingSource.DataMember = "Productos"
        Me.ProductosBindingSource.DataSource = Me.FarmatecDataSet
        '
        'Detalle_de_PedidoTableAdapter
        '
        Me.Detalle_de_PedidoTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.AutorizaTableAdapter = Nothing
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.CadenasTableAdapter = Nothing
        Me.TableAdapterManager.ClientesTableAdapter = Nothing
        Me.TableAdapterManager.Detalle_de_PedidoTableAdapter = Me.Detalle_de_PedidoTableAdapter
        Me.TableAdapterManager.EmpleadosTableAdapter = Nothing
        Me.TableAdapterManager.MarcasTableAdapter = Nothing
        Me.TableAdapterManager.PedidosTableAdapter = Nothing
        Me.TableAdapterManager.ProductosTableAdapter = Me.ProductosTableAdapter
        Me.TableAdapterManager.UpdateOrder = Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ProductosTableAdapter
        '
        Me.ProductosTableAdapter.ClearBeforeFill = True
        '
        'Comprar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.BackgroundImage = Global.Farmatec.My.Resources.Resources.FondoAlternativo
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(826, 467)
        Me.Controls.Add(ImporteLabel)
        Me.Controls.Add(Me.ImporteTextBox)
        Me.Controls.Add(Precio_UnitarioLabel)
        Me.Controls.Add(Me.Precio_UnitarioTextBox)
        Me.Controls.Add(Nombre_del_ProductoLabel)
        Me.Controls.Add(Me.Nombre_del_ProductoTextBox)
        Me.Controls.Add(CantidadLabel)
        Me.Controls.Add(Me.CantidadTextBox)
        Me.Controls.Add(IdPedidoLabel)
        Me.Controls.Add(Me.IdPedidoTextBox)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Comprar"
        Me.Text = "Comprar"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Detalle_de_PedidoBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FarmatecDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProductosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents FarmatecDataSet As Farmatec.FarmatecDataSet
    Friend WithEvents Detalle_de_PedidoBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Detalle_de_PedidoTableAdapter As Farmatec.FarmatecDataSetTableAdapters.Detalle_de_PedidoTableAdapter
    Friend WithEvents TableAdapterManager As Farmatec.FarmatecDataSetTableAdapters.TableAdapterManager
    Friend WithEvents ProductosTableAdapter As Farmatec.FarmatecDataSetTableAdapters.ProductosTableAdapter
    Friend WithEvents IdPedidoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents CantidadTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ProductosBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Nombre_del_ProductoTextBox As System.Windows.Forms.TextBox
    Friend WithEvents Precio_UnitarioTextBox As System.Windows.Forms.TextBox
    Friend WithEvents ImporteTextBox As System.Windows.Forms.TextBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.UserBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VBDataSet = New SQLsv.VBDataSet()
        Me.UserTableAdapter = New SQLsv.VBDataSetTableAdapters.userTableAdapter()
        Me.UserBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lbSche = New System.Windows.Forms.Label()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtNom = New System.Windows.Forms.TextBox()
        Me.TxtPrecio = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtCant = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IdDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NombreDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantidadDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecioDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GolosinasBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.KioskitoDataSet1 = New SQLsv.KioskitoDataSet1()
        Me.KioskitoDataSet = New SQLsv.kioskitoDataSet()
        Me.GolosinasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.GolosinasTableAdapter = New SQLsv.kioskitoDataSetTableAdapters.golosinasTableAdapter()
        Me.GolosinasTableAdapter1 = New SQLsv.KioskitoDataSet1TableAdapters.golosinasTableAdapter()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.BTNAjusPrec = New System.Windows.Forms.Button()
        Me.TBAjusPrec = New System.Windows.Forms.TextBox()
        Me.RBBajar = New System.Windows.Forms.RadioButton()
        Me.RBSubir = New System.Windows.Forms.RadioButton()
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VBDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GolosinasBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KioskitoDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KioskitoDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GolosinasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UserBindingSource
        '
        Me.UserBindingSource.DataMember = "user"
        Me.UserBindingSource.DataSource = Me.VBDataSet
        '
        'VBDataSet
        '
        Me.VBDataSet.DataSetName = "VBDataSet"
        Me.VBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'UserTableAdapter
        '
        Me.UserTableAdapter.ClearBeforeFill = True
        '
        'UserBindingSource1
        '
        Me.UserBindingSource1.DataMember = "user"
        Me.UserBindingSource1.DataSource = Me.VBDataSet
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(23, 145)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 28)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "INSERTAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lbSche
        '
        Me.lbSche.AutoSize = True
        Me.lbSche.Location = New System.Drawing.Point(101, 23)
        Me.lbSche.Name = "lbSche"
        Me.lbSche.Size = New System.Drawing.Size(60, 13)
        Me.lbSche.TabIndex = 6
        Me.lbSche.Text = "Id Golosina"
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(86, 39)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.Size = New System.Drawing.Size(220, 20)
        Me.TxtId.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(390, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'TxtNom
        '
        Me.TxtNom.Location = New System.Drawing.Point(375, 39)
        Me.TxtNom.Name = "TxtNom"
        Me.TxtNom.Size = New System.Drawing.Size(223, 20)
        Me.TxtNom.TabIndex = 9
        '
        'TxtPrecio
        '
        Me.TxtPrecio.Location = New System.Drawing.Point(375, 92)
        Me.TxtPrecio.Name = "TxtPrecio"
        Me.TxtPrecio.Size = New System.Drawing.Size(223, 20)
        Me.TxtPrecio.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(390, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "Precio $"
        '
        'TxtCant
        '
        Me.TxtCant.Location = New System.Drawing.Point(86, 92)
        Me.TxtCant.Name = "TxtCant"
        Me.TxtCant.Size = New System.Drawing.Size(220, 20)
        Me.TxtCant.TabIndex = 11
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(101, 76)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Cantidad"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(189, 145)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(155, 28)
        Me.Button2.TabIndex = 14
        Me.Button2.Text = "BUSCAR"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdDataGridViewTextBoxColumn, Me.NombreDataGridViewTextBoxColumn, Me.CantidadDataGridViewTextBoxColumn, Me.PrecioDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.GolosinasBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(23, 189)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(655, 271)
        Me.DataGridView1.TabIndex = 15
        '
        'IdDataGridViewTextBoxColumn
        '
        Me.IdDataGridViewTextBoxColumn.DataPropertyName = "Id"
        Me.IdDataGridViewTextBoxColumn.HeaderText = "Id"
        Me.IdDataGridViewTextBoxColumn.Name = "IdDataGridViewTextBoxColumn"
        '
        'NombreDataGridViewTextBoxColumn
        '
        Me.NombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.HeaderText = "Nombre"
        Me.NombreDataGridViewTextBoxColumn.Name = "NombreDataGridViewTextBoxColumn"
        '
        'CantidadDataGridViewTextBoxColumn
        '
        Me.CantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad"
        Me.CantidadDataGridViewTextBoxColumn.Name = "CantidadDataGridViewTextBoxColumn"
        '
        'PrecioDataGridViewTextBoxColumn
        '
        Me.PrecioDataGridViewTextBoxColumn.DataPropertyName = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.HeaderText = "Precio"
        Me.PrecioDataGridViewTextBoxColumn.Name = "PrecioDataGridViewTextBoxColumn"
        '
        'GolosinasBindingSource1
        '
        Me.GolosinasBindingSource1.DataMember = "golosinas"
        Me.GolosinasBindingSource1.DataSource = Me.KioskitoDataSet1
        '
        'KioskitoDataSet1
        '
        Me.KioskitoDataSet1.DataSetName = "KioskitoDataSet1"
        Me.KioskitoDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'KioskitoDataSet
        '
        Me.KioskitoDataSet.DataSetName = "kioskitoDataSet"
        Me.KioskitoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'GolosinasBindingSource
        '
        Me.GolosinasBindingSource.DataMember = "golosinas"
        Me.GolosinasBindingSource.DataSource = Me.KioskitoDataSet
        '
        'GolosinasTableAdapter
        '
        Me.GolosinasTableAdapter.ClearBeforeFill = True
        '
        'GolosinasTableAdapter1
        '
        Me.GolosinasTableAdapter1.ClearBeforeFill = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(527, 145)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(145, 28)
        Me.Button3.TabIndex = 17
        Me.Button3.Text = "BORRAR"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(361, 145)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(147, 28)
        Me.Button4.TabIndex = 16
        Me.Button4.Text = "ACTUALIZAR"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(741, 323)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "%"
        '
        'BTNAjusPrec
        '
        Me.BTNAjusPrec.Location = New System.Drawing.Point(739, 344)
        Me.BTNAjusPrec.Margin = New System.Windows.Forms.Padding(2)
        Me.BTNAjusPrec.Name = "BTNAjusPrec"
        Me.BTNAjusPrec.Size = New System.Drawing.Size(196, 46)
        Me.BTNAjusPrec.TabIndex = 25
        Me.BTNAjusPrec.Text = "Ajustar Precio"
        Me.BTNAjusPrec.UseVisualStyleBackColor = True
        '
        'TBAjusPrec
        '
        Me.TBAjusPrec.Location = New System.Drawing.Point(767, 320)
        Me.TBAjusPrec.Margin = New System.Windows.Forms.Padding(2)
        Me.TBAjusPrec.Name = "TBAjusPrec"
        Me.TBAjusPrec.Size = New System.Drawing.Size(168, 20)
        Me.TBAjusPrec.TabIndex = 24
        '
        'RBBajar
        '
        Me.RBBajar.AutoSize = True
        Me.RBBajar.Location = New System.Drawing.Point(848, 299)
        Me.RBBajar.Margin = New System.Windows.Forms.Padding(2)
        Me.RBBajar.Name = "RBBajar"
        Me.RBBajar.Size = New System.Drawing.Size(48, 17)
        Me.RBBajar.TabIndex = 23
        Me.RBBajar.Text = "bajar"
        Me.RBBajar.UseVisualStyleBackColor = True
        '
        'RBSubir
        '
        Me.RBSubir.AutoSize = True
        Me.RBSubir.Checked = True
        Me.RBSubir.Location = New System.Drawing.Point(788, 299)
        Me.RBSubir.Margin = New System.Windows.Forms.Padding(2)
        Me.RBSubir.Name = "RBSubir"
        Me.RBSubir.Size = New System.Drawing.Size(47, 17)
        Me.RBSubir.TabIndex = 22
        Me.RBSubir.TabStop = True
        Me.RBSubir.Text = "subir"
        Me.RBSubir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(987, 472)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.BTNAjusPrec)
        Me.Controls.Add(Me.TBAjusPrec)
        Me.Controls.Add(Me.RBBajar)
        Me.Controls.Add(Me.RBSubir)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TxtPrecio)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtCant)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtNom)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.lbSche)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.UserBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VBDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.UserBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GolosinasBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KioskitoDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KioskitoDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GolosinasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents VBDataSet As VBDataSet
    Friend WithEvents UserBindingSource As BindingSource
    Friend WithEvents UserTableAdapter As VBDataSetTableAdapters.userTableAdapter
    Friend WithEvents UserBindingSource1 As BindingSource
    Friend WithEvents Button1 As Button
    Friend WithEvents lbSche As Label
    Friend WithEvents TxtId As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtNom As TextBox
    Friend WithEvents TxtPrecio As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtCant As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents KioskitoDataSet As kioskitoDataSet
    Friend WithEvents GolosinasBindingSource As BindingSource
    Friend WithEvents GolosinasTableAdapter As kioskitoDataSetTableAdapters.golosinasTableAdapter
    Friend WithEvents KioskitoDataSet1 As KioskitoDataSet1
    Friend WithEvents GolosinasBindingSource1 As BindingSource
    Friend WithEvents GolosinasTableAdapter1 As KioskitoDataSet1TableAdapters.golosinasTableAdapter
    Friend WithEvents IdDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NombreDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CantidadDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrecioDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents BTNAjusPrec As Button
    Friend WithEvents TBAjusPrec As TextBox
    Friend WithEvents RBBajar As RadioButton
    Friend WithEvents RBSubir As RadioButton
End Class

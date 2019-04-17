<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmpagos_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmpagos_edit))
        Me.rbfecha = New System.Windows.Forms.RadioButton()
        Me.rbcliente = New System.Windows.Forms.RadioButton()
        Me.rbempleado = New System.Windows.Forms.RadioButton()
        Me.maskfecha = New System.Windows.Forms.MaskedTextBox()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.cmbempleado = New System.Windows.Forms.ComboBox()
        Me.dgvpagos = New System.Windows.Forms.DataGridView()
        Me.Group = New System.Windows.Forms.GroupBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblimporte = New System.Windows.Forms.Label()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.lblempleado = New System.Windows.Forms.Label()
        Me.lblfecha = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.btnborrar = New System.Windows.Forms.Button()
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Group.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'rbfecha
        '
        Me.rbfecha.AutoSize = True
        Me.rbfecha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbfecha.Location = New System.Drawing.Point(19, 22)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(73, 25)
        Me.rbfecha.TabIndex = 0
        Me.rbfecha.TabStop = True
        Me.rbfecha.Text = "Fecha"
        Me.rbfecha.UseVisualStyleBackColor = True
        '
        'rbcliente
        '
        Me.rbcliente.AutoSize = True
        Me.rbcliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbcliente.Location = New System.Drawing.Point(19, 54)
        Me.rbcliente.Name = "rbcliente"
        Me.rbcliente.Size = New System.Drawing.Size(81, 25)
        Me.rbcliente.TabIndex = 1
        Me.rbcliente.TabStop = True
        Me.rbcliente.Text = "Cliente"
        Me.rbcliente.UseVisualStyleBackColor = True
        '
        'rbempleado
        '
        Me.rbempleado.AutoSize = True
        Me.rbempleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.rbempleado.Location = New System.Drawing.Point(19, 86)
        Me.rbempleado.Name = "rbempleado"
        Me.rbempleado.Size = New System.Drawing.Size(105, 25)
        Me.rbempleado.TabIndex = 2
        Me.rbempleado.TabStop = True
        Me.rbempleado.Text = "Empleado"
        Me.rbempleado.UseVisualStyleBackColor = True
        '
        'maskfecha
        '
        Me.maskfecha.Enabled = False
        Me.maskfecha.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskfecha.Location = New System.Drawing.Point(136, 22)
        Me.maskfecha.Mask = "00/00/0000"
        Me.maskfecha.Name = "maskfecha"
        Me.maskfecha.Size = New System.Drawing.Size(83, 26)
        Me.maskfecha.TabIndex = 13
        '
        'cmbcliente
        '
        Me.cmbcliente.Enabled = False
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(137, 53)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(121, 29)
        Me.cmbcliente.TabIndex = 14
        '
        'cmbempleado
        '
        Me.cmbempleado.BackColor = System.Drawing.Color.White
        Me.cmbempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbempleado.Enabled = False
        Me.cmbempleado.FormattingEnabled = True
        Me.cmbempleado.Location = New System.Drawing.Point(137, 89)
        Me.cmbempleado.Name = "cmbempleado"
        Me.cmbempleado.Size = New System.Drawing.Size(176, 29)
        Me.cmbempleado.TabIndex = 15
        '
        'dgvpagos
        '
        Me.dgvpagos.AllowUserToAddRows = False
        Me.dgvpagos.AllowUserToDeleteRows = False
        Me.dgvpagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dgvpagos.BackgroundColor = System.Drawing.Color.White
        Me.dgvpagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvpagos.Location = New System.Drawing.Point(29, 170)
        Me.dgvpagos.Name = "dgvpagos"
        Me.dgvpagos.ReadOnly = True
        Me.dgvpagos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvpagos.Size = New System.Drawing.Size(397, 148)
        Me.dgvpagos.TabIndex = 17
        '
        'Group
        '
        Me.Group.Controls.Add(Me.btnbuscar)
        Me.Group.Controls.Add(Me.cmbempleado)
        Me.Group.Controls.Add(Me.cmbcliente)
        Me.Group.Controls.Add(Me.maskfecha)
        Me.Group.Controls.Add(Me.rbempleado)
        Me.Group.Controls.Add(Me.rbcliente)
        Me.Group.Controls.Add(Me.rbfecha)
        Me.Group.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Group.Location = New System.Drawing.Point(29, 33)
        Me.Group.Name = "Group"
        Me.Group.Size = New System.Drawing.Size(397, 131)
        Me.Group.TabIndex = 18
        Me.Group.TabStop = False
        Me.Group.Text = "Filtrar"
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.White
        Me.btnbuscar.Location = New System.Drawing.Point(302, 43)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(87, 36)
        Me.btnbuscar.TabIndex = 22
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblimporte)
        Me.GroupBox2.Controls.Add(Me.lblcliente)
        Me.GroupBox2.Controls.Add(Me.lblempleado)
        Me.GroupBox2.Controls.Add(Me.lblfecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(29, 324)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(396, 185)
        Me.GroupBox2.TabIndex = 19
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Eliminar Pago"
        '
        'lblimporte
        '
        Me.lblimporte.AutoSize = True
        Me.lblimporte.Location = New System.Drawing.Point(117, 138)
        Me.lblimporte.Name = "lblimporte"
        Me.lblimporte.Size = New System.Drawing.Size(0, 22)
        Me.lblimporte.TabIndex = 7
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Location = New System.Drawing.Point(117, 106)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(0, 22)
        Me.lblcliente.TabIndex = 6
        '
        'lblempleado
        '
        Me.lblempleado.AutoSize = True
        Me.lblempleado.Location = New System.Drawing.Point(117, 72)
        Me.lblempleado.Name = "lblempleado"
        Me.lblempleado.Size = New System.Drawing.Size(0, 22)
        Me.lblempleado.TabIndex = 5
        '
        'lblfecha
        '
        Me.lblfecha.AutoSize = True
        Me.lblfecha.Location = New System.Drawing.Point(117, 41)
        Me.lblfecha.Name = "lblfecha"
        Me.lblfecha.Size = New System.Drawing.Size(0, 22)
        Me.lblfecha.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Importe:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 106)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(70, 22)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Empleado:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 41)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Fecha:"
        '
        'paventana
        '
        Me.paventana.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.paventana.Controls.Add(Me.Label6)
        Me.paventana.Controls.Add(Me.PictureBox5)
        Me.paventana.Controls.Add(Me.pbmin)
        Me.paventana.Controls.Add(Me.pbx)
        Me.paventana.Location = New System.Drawing.Point(0, 0)
        Me.paventana.Name = "paventana"
        Me.paventana.Size = New System.Drawing.Size(452, 30)
        Me.paventana.TabIndex = 21
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Eliminar Pago"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources._8
        Me.PictureBox5.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'pbmin
        '
        Me.pbmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbmin.Image = Global.Peluqueria.My.Resources.Resources.Mesa_de_trabajo_2
        Me.pbmin.Location = New System.Drawing.Point(393, 3)
        Me.pbmin.Name = "pbmin"
        Me.pbmin.Size = New System.Drawing.Size(25, 23)
        Me.pbmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbmin.TabIndex = 9
        Me.pbmin.TabStop = False
        '
        'pbx
        '
        Me.pbx.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbx.Image = Global.Peluqueria.My.Resources.Resources.Mesa_de_trabajo_3
        Me.pbx.Location = New System.Drawing.Point(424, 3)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrar.Enabled = False
        Me.btnborrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.Color.White
        Me.btnborrar.Location = New System.Drawing.Point(29, 515)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(397, 36)
        Me.btnborrar.TabIndex = 23
        Me.btnborrar.Text = "Eliminar Pago"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'frmpagos_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 22.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.fondo_borrarpago
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(451, 563)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.paventana)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Group)
        Me.Controls.Add(Me.dgvpagos)
        Me.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmpagos_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmpagos_borrar"
        CType(Me.dgvpagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Group.ResumeLayout(False)
        Me.Group.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents rbfecha As System.Windows.Forms.RadioButton
    Friend WithEvents rbcliente As System.Windows.Forms.RadioButton
    Friend WithEvents rbempleado As System.Windows.Forms.RadioButton
    Friend WithEvents maskfecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents cmbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents cmbempleado As System.Windows.Forms.ComboBox
    Friend WithEvents dgvpagos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents paventana As System.Windows.Forms.Panel
    Friend WithEvents pbmin As System.Windows.Forms.PictureBox
    Friend WithEvents pbx As System.Windows.Forms.PictureBox
    Friend WithEvents btnbuscar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Private WithEvents Group As System.Windows.Forms.GroupBox
    Friend WithEvents lblimporte As System.Windows.Forms.Label
    Friend WithEvents lblcliente As System.Windows.Forms.Label
    Friend WithEvents lblempleado As System.Windows.Forms.Label
    Friend WithEvents lblfecha As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmresumen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmresumen))
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rbfecha = New System.Windows.Forms.RadioButton()
        Me.msk1 = New System.Windows.Forms.MaskedTextBox()
        Me.rbrangofecha = New System.Windows.Forms.RadioButton()
        Me.msk2 = New System.Windows.Forms.MaskedTextBox()
        Me.btnbuscar = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnexportarres = New System.Windows.Forms.Button()
        Me.lbltotcred = New System.Windows.Forms.Label()
        Me.lbltotdesc = New System.Windows.Forms.Label()
        Me.lbltotdeb = New System.Windows.Forms.Label()
        Me.lbltot = New System.Windows.Forms.Label()
        Me.lbltotef = New System.Windows.Forms.Label()
        Me.lblcanttot = New System.Windows.Forms.Label()
        Me.lblcantcred = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.lblcantdeb = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblcantef = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.lblcantemp = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.dgvResumen = New System.Windows.Forms.DataGridView()
        Me.Desc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Valor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.dgvPagos = New System.Windows.Forms.DataGridView()
        Me.Nro = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Importe = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnexportarlis = New System.Windows.Forms.Button()
        Me.btnListado = New System.Windows.Forms.Button()
        Me.cmbempleados = New System.Windows.Forms.ComboBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.dgvEmp = New System.Windows.Forms.DataGridView()
        Me.Emplead = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CantCortes = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.paventana.Size = New System.Drawing.Size(627, 30)
        Me.paventana.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(31, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(66, 16)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Resumen"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources._3_copia_4
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
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
        Me.pbmin.Location = New System.Drawing.Point(568, 3)
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
        Me.pbx.Location = New System.Drawing.Point(599, 3)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rbfecha)
        Me.GroupBox1.Controls.Add(Me.msk1)
        Me.GroupBox1.Controls.Add(Me.rbrangofecha)
        Me.GroupBox1.Controls.Add(Me.msk2)
        Me.GroupBox1.Controls.Add(Me.btnbuscar)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(17, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(598, 87)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Filtrar"
        '
        'rbfecha
        '
        Me.rbfecha.AutoSize = True
        Me.rbfecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbfecha.Location = New System.Drawing.Point(74, 17)
        Me.rbfecha.Name = "rbfecha"
        Me.rbfecha.Size = New System.Drawing.Size(76, 24)
        Me.rbfecha.TabIndex = 35
        Me.rbfecha.TabStop = True
        Me.rbfecha.Text = "Fecha:"
        Me.rbfecha.UseVisualStyleBackColor = True
        '
        'msk1
        '
        Me.msk1.Enabled = False
        Me.msk1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk1.Location = New System.Drawing.Point(242, 17)
        Me.msk1.Mask = "00/00/0000"
        Me.msk1.Name = "msk1"
        Me.msk1.Size = New System.Drawing.Size(88, 24)
        Me.msk1.TabIndex = 37
        '
        'rbrangofecha
        '
        Me.rbrangofecha.AutoSize = True
        Me.rbrangofecha.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbrangofecha.Location = New System.Drawing.Point(74, 49)
        Me.rbrangofecha.Name = "rbrangofecha"
        Me.rbrangofecha.Size = New System.Drawing.Size(150, 24)
        Me.rbrangofecha.TabIndex = 36
        Me.rbrangofecha.TabStop = True
        Me.rbrangofecha.Text = "Rango de Fecha:"
        Me.rbrangofecha.UseVisualStyleBackColor = True
        '
        'msk2
        '
        Me.msk2.Enabled = False
        Me.msk2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.msk2.Location = New System.Drawing.Point(242, 49)
        Me.msk2.Mask = "00/00/0000"
        Me.msk2.Name = "msk2"
        Me.msk2.Size = New System.Drawing.Size(88, 24)
        Me.msk2.TabIndex = 38
        '
        'btnbuscar
        '
        Me.btnbuscar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnbuscar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnbuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnbuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnbuscar.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbuscar.ForeColor = System.Drawing.Color.White
        Me.btnbuscar.Location = New System.Drawing.Point(476, 30)
        Me.btnbuscar.Name = "btnbuscar"
        Me.btnbuscar.Size = New System.Drawing.Size(100, 36)
        Me.btnbuscar.TabIndex = 34
        Me.btnbuscar.Text = "Buscar"
        Me.btnbuscar.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnexportarres)
        Me.GroupBox2.Controls.Add(Me.lbltotcred)
        Me.GroupBox2.Controls.Add(Me.lbltotdesc)
        Me.GroupBox2.Controls.Add(Me.lbltotdeb)
        Me.GroupBox2.Controls.Add(Me.lbltot)
        Me.GroupBox2.Controls.Add(Me.lbltotef)
        Me.GroupBox2.Controls.Add(Me.lblcanttot)
        Me.GroupBox2.Controls.Add(Me.lblcantcred)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.lblcantdeb)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.lblcantef)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label15)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(17, 129)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(598, 200)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Resumen"
        Me.GroupBox2.Visible = False
        '
        'btnexportarres
        '
        Me.btnexportarres.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnexportarres.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexportarres.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnexportarres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexportarres.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexportarres.ForeColor = System.Drawing.Color.White
        Me.btnexportarres.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnexportarres.Location = New System.Drawing.Point(393, 57)
        Me.btnexportarres.Name = "btnexportarres"
        Me.btnexportarres.Size = New System.Drawing.Size(183, 36)
        Me.btnexportarres.TabIndex = 41
        Me.btnexportarres.Text = "Exportar Resumen"
        Me.btnexportarres.UseVisualStyleBackColor = False
        '
        'lbltotcred
        '
        Me.lbltotcred.AutoSize = True
        Me.lbltotcred.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotcred.Location = New System.Drawing.Point(297, 97)
        Me.lbltotcred.Name = "lbltotcred"
        Me.lbltotcred.Size = New System.Drawing.Size(45, 20)
        Me.lbltotcred.TabIndex = 53
        Me.lbltotcred.Text = "0000"
        '
        'lbltotdesc
        '
        Me.lbltotdesc.AutoSize = True
        Me.lbltotdesc.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotdesc.Location = New System.Drawing.Point(490, 159)
        Me.lbltotdesc.Name = "lbltotdesc"
        Me.lbltotdesc.Size = New System.Drawing.Size(72, 20)
        Me.lbltotdesc.TabIndex = 6
        Me.lbltotdesc.Text = "0000000"
        '
        'lbltotdeb
        '
        Me.lbltotdeb.AutoSize = True
        Me.lbltotdeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotdeb.Location = New System.Drawing.Point(297, 60)
        Me.lbltotdeb.Name = "lbltotdeb"
        Me.lbltotdeb.Size = New System.Drawing.Size(45, 20)
        Me.lbltotdeb.TabIndex = 52
        Me.lbltotdeb.Text = "0000"
        '
        'lbltot
        '
        Me.lbltot.AutoSize = True
        Me.lbltot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltot.Location = New System.Drawing.Point(271, 159)
        Me.lbltot.Name = "lbltot"
        Me.lbltot.Size = New System.Drawing.Size(72, 20)
        Me.lbltot.TabIndex = 5
        Me.lbltot.Text = "0000000"
        '
        'lbltotef
        '
        Me.lbltotef.AutoSize = True
        Me.lbltotef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbltotef.Location = New System.Drawing.Point(297, 27)
        Me.lbltotef.Name = "lbltotef"
        Me.lbltotef.Size = New System.Drawing.Size(45, 20)
        Me.lbltotef.TabIndex = 51
        Me.lbltotef.Text = "0000"
        '
        'lblcanttot
        '
        Me.lblcanttot.AutoSize = True
        Me.lblcanttot.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcanttot.Location = New System.Drawing.Point(128, 159)
        Me.lblcanttot.Name = "lblcanttot"
        Me.lblcanttot.Size = New System.Drawing.Size(72, 20)
        Me.lblcanttot.TabIndex = 4
        Me.lblcanttot.Text = "0000000"
        '
        'lblcantcred
        '
        Me.lblcantcred.AutoSize = True
        Me.lblcantcred.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantcred.Location = New System.Drawing.Point(118, 97)
        Me.lblcantcred.Name = "lblcantcred"
        Me.lblcantcred.Size = New System.Drawing.Size(45, 20)
        Me.lblcantcred.TabIndex = 50
        Me.lblcantcred.Text = "0000"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(371, 159)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 20)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Total con Desc.:"
        '
        'lblcantdeb
        '
        Me.lblcantdeb.AutoSize = True
        Me.lblcantdeb.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantdeb.Location = New System.Drawing.Point(118, 60)
        Me.lblcantdeb.Name = "lblcantdeb"
        Me.lblcantdeb.Size = New System.Drawing.Size(45, 20)
        Me.lblcantdeb.TabIndex = 49
        Me.lblcantdeb.Text = "0000"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(227, 159)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 20)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Total:"
        '
        'lblcantef
        '
        Me.lblcantef.AutoSize = True
        Me.lblcantef.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantef.Location = New System.Drawing.Point(118, 27)
        Me.lblcantef.Name = "lblcantef"
        Me.lblcantef.Size = New System.Drawing.Size(45, 20)
        Me.lblcantef.TabIndex = 48
        Me.lblcantef.Text = "0000"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 159)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(116, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Cantidad Total:"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(209, 97)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(90, 20)
        Me.Label18.TabIndex = 47
        Me.Label18.Text = "Total Cred.:"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(6, 27)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(112, 20)
        Me.Label13.TabIndex = 42
        Me.Label13.Text = "Cant. Efectivo:"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(209, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(86, 20)
        Me.Label17.TabIndex = 46
        Me.Label17.Text = "Total Deb.:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(6, 60)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(102, 20)
        Me.Label14.TabIndex = 43
        Me.Label14.Text = "Cant. Debito:"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(209, 27)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(72, 20)
        Me.Label16.TabIndex = 45
        Me.Label16.Text = "Total Ef.:"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(6, 97)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(106, 20)
        Me.Label15.TabIndex = 44
        Me.Label15.Text = "Cant. Credito:"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(16, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(157, 20)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "Cant. de Empleados:"
        '
        'lblcantemp
        '
        Me.lblcantemp.AutoSize = True
        Me.lblcantemp.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcantemp.Location = New System.Drawing.Point(175, 19)
        Me.lblcantemp.Name = "lblcantemp"
        Me.lblcantemp.Size = New System.Drawing.Size(18, 20)
        Me.lblcantemp.TabIndex = 7
        Me.lblcantemp.Text = "0"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dgvResumen)
        Me.GroupBox3.Controls.Add(Me.dgvPagos)
        Me.GroupBox3.Controls.Add(Me.btnexportarlis)
        Me.GroupBox3.Controls.Add(Me.btnListado)
        Me.GroupBox3.Controls.Add(Me.cmbempleados)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.dgvEmp)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.lblcantemp)
        Me.GroupBox3.Location = New System.Drawing.Point(17, 331)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(598, 219)
        Me.GroupBox3.TabIndex = 28
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'dgvResumen
        '
        Me.dgvResumen.AllowUserToAddRows = False
        Me.dgvResumen.AllowUserToDeleteRows = False
        Me.dgvResumen.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvResumen.BackgroundColor = System.Drawing.Color.White
        Me.dgvResumen.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvResumen.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Desc, Me.Valor})
        Me.dgvResumen.Location = New System.Drawing.Point(20, 134)
        Me.dgvResumen.Name = "dgvResumen"
        Me.dgvResumen.ReadOnly = True
        Me.dgvResumen.Size = New System.Drawing.Size(188, 32)
        Me.dgvResumen.TabIndex = 42
        Me.dgvResumen.Visible = False
        '
        'Desc
        '
        Me.Desc.HeaderText = "Desc"
        Me.Desc.Name = "Desc"
        Me.Desc.ReadOnly = True
        '
        'Valor
        '
        Me.Valor.HeaderText = "Monto"
        Me.Valor.Name = "Valor"
        Me.Valor.ReadOnly = True
        '
        'dgvPagos
        '
        Me.dgvPagos.AllowUserToAddRows = False
        Me.dgvPagos.AllowUserToDeleteRows = False
        Me.dgvPagos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvPagos.BackgroundColor = System.Drawing.Color.White
        Me.dgvPagos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvPagos.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Nro, Me.Fecha, Me.Importe})
        Me.dgvPagos.Location = New System.Drawing.Point(388, 134)
        Me.dgvPagos.Name = "dgvPagos"
        Me.dgvPagos.ReadOnly = True
        Me.dgvPagos.Size = New System.Drawing.Size(188, 32)
        Me.dgvPagos.TabIndex = 41
        Me.dgvPagos.Visible = False
        '
        'Nro
        '
        Me.Nro.HeaderText = "Nro"
        Me.Nro.Name = "Nro"
        Me.Nro.ReadOnly = True
        '
        'Fecha
        '
        Me.Fecha.HeaderText = "Fecha"
        Me.Fecha.Name = "Fecha"
        Me.Fecha.ReadOnly = True
        '
        'Importe
        '
        Me.Importe.HeaderText = "Importe"
        Me.Importe.Name = "Importe"
        Me.Importe.ReadOnly = True
        '
        'btnexportarlis
        '
        Me.btnexportarlis.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnexportarlis.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnexportarlis.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnexportarlis.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexportarlis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexportarlis.ForeColor = System.Drawing.Color.White
        Me.btnexportarlis.Location = New System.Drawing.Point(412, 12)
        Me.btnexportarlis.Name = "btnexportarlis"
        Me.btnexportarlis.Size = New System.Drawing.Size(164, 36)
        Me.btnexportarlis.TabIndex = 40
        Me.btnexportarlis.Text = "Exportar listados"
        Me.btnexportarlis.UseVisualStyleBackColor = False
        '
        'btnListado
        '
        Me.btnListado.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnListado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnListado.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnListado.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnListado.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnListado.ForeColor = System.Drawing.Color.White
        Me.btnListado.Location = New System.Drawing.Point(449, 173)
        Me.btnListado.Name = "btnListado"
        Me.btnListado.Size = New System.Drawing.Size(127, 36)
        Me.btnListado.TabIndex = 39
        Me.btnListado.Text = "Ver Listado"
        Me.btnListado.UseVisualStyleBackColor = False
        '
        'cmbempleados
        '
        Me.cmbempleados.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbempleados.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbempleados.FormattingEnabled = True
        Me.cmbempleados.Location = New System.Drawing.Point(126, 177)
        Me.cmbempleados.Name = "cmbempleados"
        Me.cmbempleados.Size = New System.Drawing.Size(276, 26)
        Me.cmbempleados.TabIndex = 38
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(16, 179)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(93, 20)
        Me.Label12.TabIndex = 30
        Me.Label12.Text = "Empleados:"
        '
        'dgvEmp
        '
        Me.dgvEmp.AllowUserToAddRows = False
        Me.dgvEmp.AllowUserToDeleteRows = False
        Me.dgvEmp.AllowUserToOrderColumns = True
        Me.dgvEmp.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgvEmp.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dgvEmp.BackgroundColor = System.Drawing.Color.White
        Me.dgvEmp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvEmp.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Emplead, Me.CantCortes, Me.Total})
        Me.dgvEmp.Location = New System.Drawing.Point(20, 54)
        Me.dgvEmp.Name = "dgvEmp"
        Me.dgvEmp.ReadOnly = True
        Me.dgvEmp.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dgvEmp.Size = New System.Drawing.Size(556, 112)
        Me.dgvEmp.TabIndex = 8
        '
        'Emplead
        '
        Me.Emplead.HeaderText = "Empleado"
        Me.Emplead.Name = "Emplead"
        Me.Emplead.ReadOnly = True
        '
        'CantCortes
        '
        Me.CantCortes.HeaderText = "Cant. Cortes"
        Me.CantCortes.Name = "CantCortes"
        Me.CantCortes.ReadOnly = True
        '
        'Total
        '
        Me.Total.HeaderText = "Total"
        Me.Total.Name = "Total"
        Me.Total.ReadOnly = True
        '
        'frmresumen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.Resumen
        Me.ClientSize = New System.Drawing.Size(627, 562)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.paventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmresumen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmresumen"
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgvResumen, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvPagos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvEmp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents paventana As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pbmin As PictureBox
    Friend WithEvents pbx As PictureBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnbuscar As Button
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnexportarres As Button
    Friend WithEvents lbltotcred As Label
    Friend WithEvents lbltotdesc As Label
    Friend WithEvents lbltotdeb As Label
    Friend WithEvents lbltot As Label
    Friend WithEvents lbltotef As Label
    Friend WithEvents lblcanttot As Label
    Friend WithEvents lblcantcred As Label
    Friend WithEvents lblcantdeb As Label
    Friend WithEvents lblcantef As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents lblcantemp As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents btnexportarlis As Button
    Friend WithEvents btnListado As Button
    Friend WithEvents cmbempleados As ComboBox
    Friend WithEvents Label12 As Label
    Friend WithEvents dgvEmp As DataGridView
    Friend WithEvents rbfecha As RadioButton
    Friend WithEvents msk1 As MaskedTextBox
    Friend WithEvents rbrangofecha As RadioButton
    Friend WithEvents msk2 As MaskedTextBox
    Friend WithEvents Emplead As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CantCortes As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents dgvResumen As System.Windows.Forms.DataGridView
    Friend WithEvents dgvPagos As System.Windows.Forms.DataGridView
    Friend WithEvents Nro As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Importe As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Desc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Valor As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

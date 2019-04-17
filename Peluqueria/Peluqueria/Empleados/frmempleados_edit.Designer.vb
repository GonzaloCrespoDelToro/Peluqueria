<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmempleados_edit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmempleados_edit))
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtporcentaje = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.txtcontacto = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtnombre = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbempleado = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'paventana
        '
        Me.paventana.BackColor = System.Drawing.Color.FromArgb(CType(CType(237, Byte), Integer), CType(CType(84, Byte), Integer), CType(CType(86, Byte), Integer))
        Me.paventana.Controls.Add(Me.Label7)
        Me.paventana.Controls.Add(Me.PictureBox5)
        Me.paventana.Controls.Add(Me.pbmin)
        Me.paventana.Controls.Add(Me.pbx)
        Me.paventana.Location = New System.Drawing.Point(0, 0)
        Me.paventana.Name = "paventana"
        Me.paventana.Size = New System.Drawing.Size(473, 30)
        Me.paventana.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.Transparent
        Me.Label7.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(31, 6)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(118, 18)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "Editar Empleado"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources._4_copia_3
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 27
        Me.PictureBox5.TabStop = False
        '
        'pbmin
        '
        Me.pbmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbmin.Image = Global.Peluqueria.My.Resources.Resources.Mesa_de_trabajo_2
        Me.pbmin.Location = New System.Drawing.Point(414, 3)
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
        Me.pbx.Location = New System.Drawing.Point(445, 3)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtporcentaje)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnseleccionar)
        Me.GroupBox1.Controls.Add(Me.txtdni)
        Me.GroupBox1.Controls.Add(Me.txtcontacto)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txtnombre)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.cbempleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 227)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar o Elimiar Empleado"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(213, 193)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(22, 21)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "%"
        '
        'txtporcentaje
        '
        Me.txtporcentaje.Enabled = False
        Me.txtporcentaje.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtporcentaje.Location = New System.Drawing.Point(153, 190)
        Me.txtporcentaje.Name = "txtporcentaje"
        Me.txtporcentaje.Size = New System.Drawing.Size(54, 26)
        Me.txtporcentaje.TabIndex = 5
        Me.txtporcentaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.White
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(6, 192)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(99, 22)
        Me.Label6.TabIndex = 33
        Me.Label6.Text = "Porcentaje:"
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnseleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnseleccionar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseleccionar.ForeColor = System.Drawing.Color.White
        Me.btnseleccionar.Location = New System.Drawing.Point(347, 29)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(96, 32)
        Me.btnseleccionar.TabIndex = 1
        Me.btnseleccionar.Text = "Seleccionar"
        Me.btnseleccionar.UseVisualStyleBackColor = False
        '
        'txtdni
        '
        Me.txtdni.Enabled = False
        Me.txtdni.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdni.Location = New System.Drawing.Point(153, 158)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(178, 26)
        Me.txtdni.TabIndex = 4
        '
        'txtcontacto
        '
        Me.txtcontacto.Enabled = False
        Me.txtcontacto.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcontacto.Location = New System.Drawing.Point(153, 126)
        Me.txtcontacto.Name = "txtcontacto"
        Me.txtcontacto.Size = New System.Drawing.Size(178, 26)
        Me.txtcontacto.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 160)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(44, 22)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "DNI:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(86, 22)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Contacto:"
        '
        'txtnombre
        '
        Me.txtnombre.Enabled = False
        Me.txtnombre.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtnombre.Location = New System.Drawing.Point(153, 94)
        Me.txtnombre.Name = "txtnombre"
        Me.txtnombre.Size = New System.Drawing.Size(178, 26)
        Me.txtnombre.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(141, 22)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Nombre Compl.:"
        '
        'cbempleado
        '
        Me.cbempleado.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbempleado.FormattingEnabled = True
        Me.cbempleado.Location = New System.Drawing.Point(153, 30)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Size = New System.Drawing.Size(178, 29)
        Me.cbempleado.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(96, 22)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Empleado:"
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.Enabled = False
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(319, 269)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(140, 32)
        Me.btncancelar.TabIndex = 3
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.White
        Me.btnmodificar.Location = New System.Drawing.Point(165, 269)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(140, 32)
        Me.btnmodificar.TabIndex = 2
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrar.Enabled = False
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.Color.White
        Me.btnborrar.Location = New System.Drawing.Point(9, 269)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(140, 32)
        Me.btnborrar.TabIndex = 1
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'frmempleados_edit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.Empleado_edit
        Me.ClientSize = New System.Drawing.Size(472, 313)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.paventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmempleados_edit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmempleados_edit"
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents paventana As System.Windows.Forms.Panel
    Friend WithEvents pbmin As System.Windows.Forms.PictureBox
    Friend WithEvents pbx As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtnombre As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbempleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents txtcontacto As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnseleccionar As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents Label5 As Label
    Friend WithEvents txtporcentaje As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents PictureBox5 As PictureBox
End Class

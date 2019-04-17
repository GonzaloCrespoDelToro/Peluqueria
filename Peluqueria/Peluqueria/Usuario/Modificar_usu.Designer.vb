<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Modificar_usu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Modificar_usu))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txtpass = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnseleccionar = New System.Windows.Forms.Button()
        Me.txtusu = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbusuario = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnborrar = New System.Windows.Forms.Button()
        Me.btnmodificar = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.GroupBox1.SuspendLayout()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.White
        Me.GroupBox1.Controls.Add(Me.txtpass)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnseleccionar)
        Me.GroupBox1.Controls.Add(Me.txtusu)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbusuario)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 34)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(387, 176)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Modificar o Borrar"
        '
        'txtpass
        '
        Me.txtpass.Enabled = False
        Me.txtpass.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtpass.Location = New System.Drawing.Point(119, 127)
        Me.txtpass.Name = "txtpass"
        Me.txtpass.Size = New System.Drawing.Size(160, 26)
        Me.txtpass.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(7, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 22)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "Contraseña:"
        '
        'btnseleccionar
        '
        Me.btnseleccionar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnseleccionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnseleccionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnseleccionar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnseleccionar.ForeColor = System.Drawing.Color.White
        Me.btnseleccionar.Location = New System.Drawing.Point(285, 37)
        Me.btnseleccionar.Name = "btnseleccionar"
        Me.btnseleccionar.Size = New System.Drawing.Size(96, 32)
        Me.btnseleccionar.TabIndex = 4
        Me.btnseleccionar.Text = "Seleccionar"
        Me.btnseleccionar.UseVisualStyleBackColor = False
        '
        'txtusu
        '
        Me.txtusu.Enabled = False
        Me.txtusu.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtusu.Location = New System.Drawing.Point(119, 90)
        Me.txtusu.Name = "txtusu"
        Me.txtusu.Size = New System.Drawing.Size(160, 26)
        Me.txtusu.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(6, 40)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 22)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Usuario:"
        '
        'cbusuario
        '
        Me.cbusuario.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbusuario.FormattingEnabled = True
        Me.cbusuario.Location = New System.Drawing.Point(118, 37)
        Me.cbusuario.Name = "cbusuario"
        Me.cbusuario.Size = New System.Drawing.Size(160, 29)
        Me.cbusuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.White
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 92)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(74, 22)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Usuario:"
        '
        'btnborrar
        '
        Me.btnborrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnborrar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnborrar.Enabled = False
        Me.btnborrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnborrar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnborrar.ForeColor = System.Drawing.Color.White
        Me.btnborrar.Location = New System.Drawing.Point(12, 216)
        Me.btnborrar.Name = "btnborrar"
        Me.btnborrar.Size = New System.Drawing.Size(112, 32)
        Me.btnborrar.TabIndex = 15
        Me.btnborrar.Text = "Borrar"
        Me.btnborrar.UseVisualStyleBackColor = False
        '
        'btnmodificar
        '
        Me.btnmodificar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnmodificar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnmodificar.Enabled = False
        Me.btnmodificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmodificar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnmodificar.ForeColor = System.Drawing.Color.White
        Me.btnmodificar.Location = New System.Drawing.Point(151, 216)
        Me.btnmodificar.Name = "btnmodificar"
        Me.btnmodificar.Size = New System.Drawing.Size(112, 32)
        Me.btnmodificar.TabIndex = 16
        Me.btnmodificar.Text = "Modificar"
        Me.btnmodificar.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.Enabled = False
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(287, 216)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(112, 32)
        Me.btncancelar.TabIndex = 23
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
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
        Me.paventana.Size = New System.Drawing.Size(408, 30)
        Me.paventana.TabIndex = 25
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(35, 8)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 18)
        Me.Label6.TabIndex = 27
        Me.Label6.Text = "Usuarios"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources._12
        Me.PictureBox5.Location = New System.Drawing.Point(0, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 26
        Me.PictureBox5.TabStop = False
        '
        'pbmin
        '
        Me.pbmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbmin.Image = Global.Peluqueria.My.Resources.Resources.Mesa_de_trabajo_2
        Me.pbmin.Location = New System.Drawing.Point(349, 3)
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
        Me.pbx.Location = New System.Drawing.Point(380, 3)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'Modificar_usu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.FondoModUsu
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(409, 263)
        Me.Controls.Add(Me.paventana)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnmodificar)
        Me.Controls.Add(Me.btnborrar)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Modificar_usu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Modificar_usu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtusu As System.Windows.Forms.TextBox
    Friend WithEvents btnborrar As System.Windows.Forms.Button
    Friend WithEvents btnmodificar As System.Windows.Forms.Button
    Friend WithEvents btnseleccionar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbusuario As System.Windows.Forms.ComboBox
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents paventana As System.Windows.Forms.Panel
    Friend WithEvents pbmin As System.Windows.Forms.PictureBox
    Friend WithEvents pbx As System.Windows.Forms.PictureBox
    Friend WithEvents txtpass As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
End Class

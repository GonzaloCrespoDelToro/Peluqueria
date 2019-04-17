<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPagos_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPagos_alta))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cbcliente = New System.Windows.Forms.ComboBox()
        Me.checkcliente = New System.Windows.Forms.PictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cbempleado = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.maskfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtimporte = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.rbcontado = New System.Windows.Forms.RadioButton()
        Me.rbdebito = New System.Windows.Forms.RadioButton()
        Me.rbcredito = New System.Windows.Forms.RadioButton()
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.checktpago = New System.Windows.Forms.PictureBox()
        Me.checkimporte = New System.Windows.Forms.PictureBox()
        Me.checkfecha = New System.Windows.Forms.PictureBox()
        Me.checkempleado = New System.Windows.Forms.PictureBox()
        Me.btnpago = New System.Windows.Forms.Button()
        Me.btncancelar = New System.Windows.Forms.Button()
        CType(Me.checkcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.checktpago, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkimporte, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkfecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.checkempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 22)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Cliente:"
        '
        'cbcliente
        '
        Me.cbcliente.FormattingEnabled = True
        Me.cbcliente.Location = New System.Drawing.Point(105, 32)
        Me.cbcliente.Name = "cbcliente"
        Me.cbcliente.Size = New System.Drawing.Size(175, 29)
        Me.cbcliente.TabIndex = 7
        '
        'checkcliente
        '
        Me.checkcliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.checkcliente.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.checkcliente.Location = New System.Drawing.Point(292, 32)
        Me.checkcliente.Name = "checkcliente"
        Me.checkcliente.Size = New System.Drawing.Size(26, 26)
        Me.checkcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkcliente.TabIndex = 8
        Me.checkcliente.TabStop = False
        Me.checkcliente.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(96, 22)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Empleado:"
        '
        'cbempleado
        '
        Me.cbempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempleado.FormattingEnabled = True
        Me.cbempleado.Location = New System.Drawing.Point(105, 74)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Size = New System.Drawing.Size(175, 29)
        Me.cbempleado.TabIndex = 10
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(6, 126)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 22)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "Fecha:"
        '
        'maskfecha
        '
        Me.maskfecha.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskfecha.Location = New System.Drawing.Point(105, 122)
        Me.maskfecha.Mask = "00/00/0000"
        Me.maskfecha.Name = "maskfecha"
        Me.maskfecha.Size = New System.Drawing.Size(83, 26)
        Me.maskfecha.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 279)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 22)
        Me.Label4.TabIndex = 13
        Me.Label4.Text = "Importe:"
        '
        'txtimporte
        '
        Me.txtimporte.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtimporte.Location = New System.Drawing.Point(105, 279)
        Me.txtimporte.Name = "txtimporte"
        Me.txtimporte.Size = New System.Drawing.Size(121, 26)
        Me.txtimporte.TabIndex = 14
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(6, 170)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 22)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Tipo de Pago:"
        '
        'rbcontado
        '
        Me.rbcontado.AutoSize = True
        Me.rbcontado.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcontado.Location = New System.Drawing.Point(128, 170)
        Me.rbcontado.Name = "rbcontado"
        Me.rbcontado.Size = New System.Drawing.Size(97, 26)
        Me.rbcontado.TabIndex = 19
        Me.rbcontado.TabStop = True
        Me.rbcontado.Text = "Contado"
        Me.rbcontado.UseVisualStyleBackColor = True
        '
        'rbdebito
        '
        Me.rbdebito.AutoSize = True
        Me.rbdebito.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbdebito.Location = New System.Drawing.Point(128, 202)
        Me.rbdebito.Name = "rbdebito"
        Me.rbdebito.Size = New System.Drawing.Size(82, 26)
        Me.rbdebito.TabIndex = 20
        Me.rbdebito.TabStop = True
        Me.rbdebito.Text = "Debito"
        Me.rbdebito.UseVisualStyleBackColor = True
        '
        'rbcredito
        '
        Me.rbcredito.AutoSize = True
        Me.rbcredito.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbcredito.Location = New System.Drawing.Point(128, 234)
        Me.rbcredito.Name = "rbcredito"
        Me.rbcredito.Size = New System.Drawing.Size(87, 26)
        Me.rbcredito.TabIndex = 21
        Me.rbcredito.TabStop = True
        Me.rbcredito.Text = "Credito"
        Me.rbcredito.UseVisualStyleBackColor = True
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
        Me.paventana.Size = New System.Drawing.Size(363, 30)
        Me.paventana.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 16)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Pagos"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources._7
        Me.PictureBox5.Location = New System.Drawing.Point(3, 0)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(30, 30)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 23
        Me.PictureBox5.TabStop = False
        '
        'pbmin
        '
        Me.pbmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbmin.Image = Global.Peluqueria.My.Resources.Resources.Mesa_de_trabajo_2
        Me.pbmin.Location = New System.Drawing.Point(304, 4)
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
        Me.pbx.Location = New System.Drawing.Point(335, 4)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.checktpago)
        Me.GroupBox1.Controls.Add(Me.checkimporte)
        Me.GroupBox1.Controls.Add(Me.checkfecha)
        Me.GroupBox1.Controls.Add(Me.checkempleado)
        Me.GroupBox1.Controls.Add(Me.rbcredito)
        Me.GroupBox1.Controls.Add(Me.rbdebito)
        Me.GroupBox1.Controls.Add(Me.rbcontado)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.txtimporte)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.maskfecha)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbempleado)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.checkcliente)
        Me.GroupBox1.Controls.Add(Me.cbcliente)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 47)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(343, 321)
        Me.GroupBox1.TabIndex = 24
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Pago"
        '
        'checktpago
        '
        Me.checktpago.Cursor = System.Windows.Forms.Cursors.Default
        Me.checktpago.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.checktpago.Location = New System.Drawing.Point(292, 202)
        Me.checktpago.Name = "checktpago"
        Me.checktpago.Size = New System.Drawing.Size(26, 26)
        Me.checktpago.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checktpago.TabIndex = 25
        Me.checktpago.TabStop = False
        Me.checktpago.Visible = False
        '
        'checkimporte
        '
        Me.checkimporte.Cursor = System.Windows.Forms.Cursors.Default
        Me.checkimporte.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.checkimporte.Location = New System.Drawing.Point(292, 279)
        Me.checkimporte.Name = "checkimporte"
        Me.checkimporte.Size = New System.Drawing.Size(26, 26)
        Me.checkimporte.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkimporte.TabIndex = 24
        Me.checkimporte.TabStop = False
        Me.checkimporte.Visible = False
        '
        'checkfecha
        '
        Me.checkfecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.checkfecha.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.checkfecha.Location = New System.Drawing.Point(292, 122)
        Me.checkfecha.Name = "checkfecha"
        Me.checkfecha.Size = New System.Drawing.Size(26, 26)
        Me.checkfecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkfecha.TabIndex = 23
        Me.checkfecha.TabStop = False
        Me.checkfecha.Visible = False
        '
        'checkempleado
        '
        Me.checkempleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.checkempleado.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.checkempleado.Location = New System.Drawing.Point(292, 74)
        Me.checkempleado.Name = "checkempleado"
        Me.checkempleado.Size = New System.Drawing.Size(26, 26)
        Me.checkempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.checkempleado.TabIndex = 22
        Me.checkempleado.TabStop = False
        Me.checkempleado.Visible = False
        '
        'btnpago
        '
        Me.btnpago.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnpago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnpago.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnpago.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnpago.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnpago.ForeColor = System.Drawing.Color.White
        Me.btnpago.Location = New System.Drawing.Point(12, 386)
        Me.btnpago.Name = "btnpago"
        Me.btnpago.Size = New System.Drawing.Size(161, 40)
        Me.btnpago.TabIndex = 25
        Me.btnpago.Text = "Confirmar Pago"
        Me.btnpago.UseVisualStyleBackColor = False
        '
        'btncancelar
        '
        Me.btncancelar.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btncancelar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btncancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btncancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancelar.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncancelar.ForeColor = System.Drawing.Color.White
        Me.btncancelar.Location = New System.Drawing.Point(194, 386)
        Me.btncancelar.Name = "btncancelar"
        Me.btncancelar.Size = New System.Drawing.Size(161, 40)
        Me.btncancelar.TabIndex = 26
        Me.btncancelar.Text = "Cancelar"
        Me.btncancelar.UseVisualStyleBackColor = False
        '
        'frmPagos_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.Fondo_pagosalta
        Me.ClientSize = New System.Drawing.Size(363, 440)
        Me.Controls.Add(Me.btncancelar)
        Me.Controls.Add(Me.btnpago)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.paventana)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmPagos_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmPagos_alta"
        CType(Me.checkcliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.checktpago, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkimporte, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkfecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.checkempleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cbcliente As System.Windows.Forms.ComboBox
    Friend WithEvents checkcliente As System.Windows.Forms.PictureBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cbempleado As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents maskfecha As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtimporte As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents rbcontado As System.Windows.Forms.RadioButton
    Friend WithEvents rbdebito As System.Windows.Forms.RadioButton
    Friend WithEvents rbcredito As System.Windows.Forms.RadioButton
    Friend WithEvents paventana As System.Windows.Forms.Panel
    Friend WithEvents pbmin As System.Windows.Forms.PictureBox
    Friend WithEvents pbx As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnpago As System.Windows.Forms.Button
    Friend WithEvents btncancelar As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
    Friend WithEvents checkimporte As PictureBox
    Friend WithEvents checkfecha As PictureBox
    Friend WithEvents checkempleado As PictureBox
    Friend WithEvents checktpago As PictureBox
End Class

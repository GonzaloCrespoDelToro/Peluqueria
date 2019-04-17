<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmturnos_alta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmturnos_alta))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbempleado = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.pbempleado = New System.Windows.Forms.PictureBox()
        Me.lbl1 = New System.Windows.Forms.Label()
        Me.pbcliente = New System.Windows.Forms.PictureBox()
        Me.pbtipo = New System.Windows.Forms.PictureBox()
        Me.pbhora = New System.Windows.Forms.PictureBox()
        Me.pbfecha = New System.Windows.Forms.PictureBox()
        Me.cmbcliente = New System.Windows.Forms.ComboBox()
        Me.cmbcorte = New System.Windows.Forms.ComboBox()
        Me.cmbhora = New System.Windows.Forms.ComboBox()
        Me.maskfecha = New System.Windows.Forms.MaskedTextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.btnturno = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pbempleado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbcliente, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbtipo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbhora, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbfecha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbempleado)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.pbempleado)
        Me.GroupBox1.Controls.Add(Me.lbl1)
        Me.GroupBox1.Controls.Add(Me.pbcliente)
        Me.GroupBox1.Controls.Add(Me.pbtipo)
        Me.GroupBox1.Controls.Add(Me.pbhora)
        Me.GroupBox1.Controls.Add(Me.pbfecha)
        Me.GroupBox1.Controls.Add(Me.cmbcliente)
        Me.GroupBox1.Controls.Add(Me.cmbcorte)
        Me.GroupBox1.Controls.Add(Me.cmbhora)
        Me.GroupBox1.Controls.Add(Me.maskfecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 36)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(344, 294)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Nuevo Turno"
        '
        'cbempleado
        '
        Me.cbempleado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbempleado.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbempleado.FormattingEnabled = True
        Me.cbempleado.Location = New System.Drawing.Point(132, 210)
        Me.cbempleado.Name = "cbempleado"
        Me.cbempleado.Size = New System.Drawing.Size(151, 30)
        Me.cbempleado.TabIndex = 32
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(6, 213)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(96, 22)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Empleado:"
        '
        'pbempleado
        '
        Me.pbempleado.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbempleado.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.pbempleado.Location = New System.Drawing.Point(290, 215)
        Me.pbempleado.Name = "pbempleado"
        Me.pbempleado.Size = New System.Drawing.Size(24, 24)
        Me.pbempleado.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbempleado.TabIndex = 30
        Me.pbempleado.TabStop = False
        Me.pbempleado.Visible = False
        '
        'lbl1
        '
        Me.lbl1.AutoSize = True
        Me.lbl1.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl1.ForeColor = System.Drawing.Color.Red
        Me.lbl1.Location = New System.Drawing.Point(35, 255)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(270, 18)
        Me.lbl1.TabIndex = 28
        Me.lbl1.Text = "El empleado ya tiene un turno asignado "
        Me.lbl1.Visible = False
        '
        'pbcliente
        '
        Me.pbcliente.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbcliente.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.pbcliente.Location = New System.Drawing.Point(290, 169)
        Me.pbcliente.Name = "pbcliente"
        Me.pbcliente.Size = New System.Drawing.Size(24, 24)
        Me.pbcliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbcliente.TabIndex = 27
        Me.pbcliente.TabStop = False
        Me.pbcliente.Visible = False
        '
        'pbtipo
        '
        Me.pbtipo.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbtipo.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.pbtipo.Location = New System.Drawing.Point(289, 129)
        Me.pbtipo.Name = "pbtipo"
        Me.pbtipo.Size = New System.Drawing.Size(24, 24)
        Me.pbtipo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbtipo.TabIndex = 26
        Me.pbtipo.TabStop = False
        Me.pbtipo.Visible = False
        '
        'pbhora
        '
        Me.pbhora.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbhora.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.pbhora.Location = New System.Drawing.Point(259, 87)
        Me.pbhora.Name = "pbhora"
        Me.pbhora.Size = New System.Drawing.Size(24, 24)
        Me.pbhora.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbhora.TabIndex = 25
        Me.pbhora.TabStop = False
        Me.pbhora.Visible = False
        '
        'pbfecha
        '
        Me.pbfecha.Cursor = System.Windows.Forms.Cursors.Default
        Me.pbfecha.Image = Global.Peluqueria.My.Resources.Resources.iconfinder_sign_check_299110
        Me.pbfecha.Location = New System.Drawing.Point(234, 43)
        Me.pbfecha.Name = "pbfecha"
        Me.pbfecha.Size = New System.Drawing.Size(24, 24)
        Me.pbfecha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbfecha.TabIndex = 24
        Me.pbfecha.TabStop = False
        '
        'cmbcliente
        '
        Me.cmbcliente.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcliente.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcliente.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcliente.FormattingEnabled = True
        Me.cmbcliente.Location = New System.Drawing.Point(132, 166)
        Me.cmbcliente.Name = "cmbcliente"
        Me.cmbcliente.Size = New System.Drawing.Size(151, 30)
        Me.cmbcliente.Sorted = True
        Me.cmbcliente.TabIndex = 20
        '
        'cmbcorte
        '
        Me.cmbcorte.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend
        Me.cmbcorte.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.cmbcorte.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcorte.FormattingEnabled = True
        Me.cmbcorte.Location = New System.Drawing.Point(132, 125)
        Me.cmbcorte.Name = "cmbcorte"
        Me.cmbcorte.Size = New System.Drawing.Size(151, 30)
        Me.cmbcorte.Sorted = True
        Me.cmbcorte.TabIndex = 19
        '
        'cmbhora
        '
        Me.cmbhora.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbhora.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbhora.FormattingEnabled = True
        Me.cmbhora.Items.AddRange(New Object() {"8:00", "8:30", "9:00", "9:30", "10:00", "10:30", "11:00", "11:30", "12:00", "12:30", "13:00", "13:30", "14:00", "14:30", "15:00", "15:30", "16:00", "16:30", "17:00", "17:30", "18:00", "18:30", "19:00", "19:30", "20:00", "20:30", "21:00", "21:30", "22:00"})
        Me.cmbhora.Location = New System.Drawing.Point(132, 84)
        Me.cmbhora.Name = "cmbhora"
        Me.cmbhora.Size = New System.Drawing.Size(121, 30)
        Me.cmbhora.TabIndex = 18
        '
        'maskfecha
        '
        Me.maskfecha.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.maskfecha.Location = New System.Drawing.Point(132, 43)
        Me.maskfecha.Mask = "00/00/0000"
        Me.maskfecha.Name = "maskfecha"
        Me.maskfecha.Size = New System.Drawing.Size(96, 27)
        Me.maskfecha.TabIndex = 17
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(113, 22)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "Fecha Turno:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(6, 169)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(70, 22)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Cliente:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(6, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 22)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Hora:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(6, 129)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 22)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Tipo de Corte:"
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
        Me.paventana.Size = New System.Drawing.Size(368, 30)
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
        Me.Label6.Size = New System.Drawing.Size(92, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Nuevo Turno"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources._3
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
        Me.pbmin.Location = New System.Drawing.Point(309, 4)
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
        Me.pbx.Location = New System.Drawing.Point(340, 4)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'btnturno
        '
        Me.btnturno.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnturno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnturno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnturno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnturno.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnturno.ForeColor = System.Drawing.Color.White
        Me.btnturno.Location = New System.Drawing.Point(12, 336)
        Me.btnturno.Name = "btnturno"
        Me.btnturno.Size = New System.Drawing.Size(344, 29)
        Me.btnturno.TabIndex = 22
        Me.btnturno.Text = "Nuevo Turno"
        Me.btnturno.UseVisualStyleBackColor = False
        '
        'frmturnos_alta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.Turno_alta
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(368, 377)
        Me.Controls.Add(Me.btnturno)
        Me.Controls.Add(Me.paventana)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Montserrat", 8.249999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmturnos_alta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Nuevo Turno"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pbempleado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbcliente, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbtipo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbhora, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbfecha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents paventana As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pbmin As PictureBox
    Friend WithEvents pbx As PictureBox
    Friend WithEvents maskfecha As MaskedTextBox
    Friend WithEvents cmbcorte As ComboBox
    Friend WithEvents cmbhora As ComboBox
    Friend WithEvents cmbcliente As ComboBox
    Friend WithEvents btnturno As Button
    Friend WithEvents pbfecha As PictureBox
    Friend WithEvents pbcliente As PictureBox
    Friend WithEvents pbtipo As PictureBox
    Friend WithEvents pbhora As PictureBox
    Friend WithEvents cbempleado As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents pbempleado As PictureBox
    Friend WithEvents lbl1 As Label
End Class

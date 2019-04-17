<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmconfback
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmconfback))
        Me.paventana = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        Me.pbmin = New System.Windows.Forms.PictureBox()
        Me.pbx = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnno = New System.Windows.Forms.Button()
        Me.btnsi = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.paventana.SuspendLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.paventana.Size = New System.Drawing.Size(399, 30)
        Me.paventana.TabIndex = 22
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Font = New System.Drawing.Font("Montserrat", 9.749999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(34, 6)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(157, 18)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "Confirmacion Back-Up"
        '
        'PictureBox5
        '
        Me.PictureBox5.Image = Global.Peluqueria.My.Resources.Resources.database_3_
        Me.PictureBox5.Location = New System.Drawing.Point(3, 3)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'pbmin
        '
        Me.pbmin.Cursor = System.Windows.Forms.Cursors.Hand
        Me.pbmin.Image = Global.Peluqueria.My.Resources.Resources.Mesa_de_trabajo_2
        Me.pbmin.Location = New System.Drawing.Point(340, 3)
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
        Me.pbx.Location = New System.Drawing.Point(371, 3)
        Me.pbx.Name = "pbx"
        Me.pbx.Size = New System.Drawing.Size(25, 23)
        Me.pbx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pbx.TabIndex = 8
        Me.pbx.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(40, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(314, 22)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "¿Confirma la Generación de Back-Up?"
        '
        'btnno
        '
        Me.btnno.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnno.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnno.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnno.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnno.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnno.ForeColor = System.Drawing.Color.White
        Me.btnno.Location = New System.Drawing.Point(44, 72)
        Me.btnno.Name = "btnno"
        Me.btnno.Size = New System.Drawing.Size(147, 36)
        Me.btnno.TabIndex = 27
        Me.btnno.Text = "No"
        Me.btnno.UseVisualStyleBackColor = False
        '
        'btnsi
        '
        Me.btnsi.BackColor = System.Drawing.Color.FromArgb(CType(CType(73, Byte), Integer), CType(CType(165, Byte), Integer), CType(CType(209, Byte), Integer))
        Me.btnsi.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnsi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(49, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(196, Byte), Integer))
        Me.btnsi.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsi.Font = New System.Drawing.Font("Montserrat", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsi.ForeColor = System.Drawing.Color.White
        Me.btnsi.Location = New System.Drawing.Point(201, 72)
        Me.btnsi.Name = "btnsi"
        Me.btnsi.Size = New System.Drawing.Size(147, 36)
        Me.btnsi.TabIndex = 28
        Me.btnsi.Text = "Si"
        Me.btnsi.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(0, 117)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(500, 3)
        Me.Panel2.TabIndex = 29
        '
        'frmconfback
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Peluqueria.My.Resources.Resources.Corte_edit
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(399, 120)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.btnsi)
        Me.Controls.Add(Me.btnno)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.paventana)
        Me.Font = New System.Drawing.Font("Montserrat", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(5)
        Me.Name = "frmconfback"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Confirmar"
        Me.paventana.ResumeLayout(False)
        Me.paventana.PerformLayout()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbmin, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pbx, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents paventana As Panel
    Friend WithEvents Label6 As Label
    Friend WithEvents PictureBox5 As PictureBox
    Friend WithEvents pbmin As PictureBox
    Friend WithEvents pbx As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnno As Button
    Friend WithEvents btnsi As Button
    Friend WithEvents Panel2 As Panel
End Class

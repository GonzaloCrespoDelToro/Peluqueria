
Public Class MenuPrin
    Dim acceso As New AccesoSQL
    Dim desplegado As String = ""
    Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
    Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(Date.Today)
    Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
    Dim hora As String = Now.ToLongTimeString
    Dim dia As String = Now.ToShortDateString
    Public fecha As String = ""

    Private Sub MenuPrin_Load(sender As Object, e As EventArgs) Handles MyBase.Load '---------LOAD---------'
        Try
            Timer2.Start()
            TimerFecha.Start()
            lbldia1.Text = StrConv(dayName.ToLower, VbStrConv.ProperCase)
            lblhora.Text = hora
            lbldia.Text = dia
            lblusu.Text = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Empleados WHERE ID = (SELECT Empleado FROM Usuarios WHERE Nombre = '" + Login.usuario + "')")
            If acceso.Ejecutar_Query("ExecuteScalar", "SELECT Admin FROM Usuarios WHERE Nombre = '" + Login.usuario + "'") = "True" Then
                lblusu.ForeColor = Color.FromArgb(29, 110, 227)
                pbuser.Image = Peluqueria.My.Resources.UserAzul
            End If
            lblbackhora.Text = acceso.Ejecutar_Query("ExecuteScalar", "SELECT TOP 1 (FechayHora) FROM Backups ORDER BY ID DESC")
            dgvTurnos.Columns.Add("Hora", "Hora")
            dgvTurnos.Columns.Add("Cliente", "Cliente")
            dgvTurnos.Columns.Add("Corte", "Corte")
            dgvTurnos.Columns.Add("Empleado", "Empleado")
            fecha = Date.Today
            Cargar_Calendario(fecha)
        Catch ex As Exception
            MsgBox("Error al Cargar el Sistema, Por Favor Reiniciar", Title:="ReDim Software")
        End Try

    End Sub

    Sub Cargar_Calendario(ByVal Fecha As String)
        dgvTurnos.Rows.Clear()
        Dim DSTurnos As DataSet = acceso.Consulta_DS("SELECT t.Hora,t.Cliente,tt.Nombre,e.Nombre FROM Turnos t inner join TipoCortes tt on t.TipoCorte = tt.ID inner join Empleados e on t.Empleado = e.ID WHERE Fecha ='" + Fecha + "'", "Turnos")
        For Each Fila As DataRow In DSTurnos.Tables(0).Rows
            dgvTurnos.Rows.Add(Fila.Item(0).ToString, Fila.Item(1).ToString, Fila.Item(2).ToString, Fila.Item(3).ToString)
        Next
        If Chequear_Horario("08:30", Fecha) = False Then
            dgvTurnos.Rows.Add("08:30", "", "", "")
        End If
        If Chequear_Horario("09:00", Fecha) = False Then
            dgvTurnos.Rows.Add("09:00", "", "", "")
        End If
        If Chequear_Horario("09:30", Fecha) = False Then
            dgvTurnos.Rows.Add("09:30", "", "", "")
        End If
        If Chequear_Horario("10:00", Fecha) = False Then
            dgvTurnos.Rows.Add("10:00", "", "", "")
        End If
        If Chequear_Horario("10:30", Fecha) = False Then
            dgvTurnos.Rows.Add("10:30", "", "", "")
        End If
        If Chequear_Horario("11:00", Fecha) = False Then
            dgvTurnos.Rows.Add("11:00", "", "", "")
        End If
        If Chequear_Horario("11:30", Fecha) = False Then
            dgvTurnos.Rows.Add("11:30", "", "", "")
        End If
        If Chequear_Horario("12:00", Fecha) = False Then
            dgvTurnos.Rows.Add("12:00", "", "", "")
        End If
        If Chequear_Horario("12:30", Fecha) = False Then
            dgvTurnos.Rows.Add("12:30", "", "", "")
        End If
        If Chequear_Horario("13:00", Fecha) = False Then
            dgvTurnos.Rows.Add("13:00", "", "", "")
        End If
        If Chequear_Horario("13:30", Fecha) = False Then
            dgvTurnos.Rows.Add("13:30", "", "", "")
        End If
        If Chequear_Horario("14:00", Fecha) = False Then
            dgvTurnos.Rows.Add("14:00", "", "", "")
        End If
        If Chequear_Horario("14:30", Fecha) = False Then
            dgvTurnos.Rows.Add("14:30", "", "", "")
        End If
        If Chequear_Horario("15:00", Fecha) = False Then
            dgvTurnos.Rows.Add("15:00", "", "", "")
        End If
        If Chequear_Horario("15:30", Fecha) = False Then
            dgvTurnos.Rows.Add("15:30", "", "", "")
        End If
        If Chequear_Horario("16:00", Fecha) = False Then
            dgvTurnos.Rows.Add("16:00", "", "", "")
        End If
        If Chequear_Horario("16:30", Fecha) = False Then
            dgvTurnos.Rows.Add("16:30", "", "", "")
        End If
        If Chequear_Horario("17:00", Fecha) = False Then
            dgvTurnos.Rows.Add("17:00", "", "", "")
        End If
        If Chequear_Horario("17:30", Fecha) = False Then
            dgvTurnos.Rows.Add("17:30", "", "", "")
        End If
        If Chequear_Horario("18:00", Fecha) = False Then
            dgvTurnos.Rows.Add("18:00", "", "", "")
        End If
        If Chequear_Horario("18:30", Fecha) = False Then
            dgvTurnos.Rows.Add("18:30", "", "", "")
        End If
        If Chequear_Horario("19:00", Fecha) = False Then
            dgvTurnos.Rows.Add("19:00", "", "", "")
        End If
        If Chequear_Horario("19:30", Fecha) = False Then
            dgvTurnos.Rows.Add("19:30", "", "", "")
        End If
        If Chequear_Horario("20:00", Fecha) = False Then
            dgvTurnos.Rows.Add("20:00", "", "", "")
        End If
        If Chequear_Horario("20:30", Fecha) = False Then
            dgvTurnos.Rows.Add("20:30", "", "", "")
        End If
        If Chequear_Horario("21:00", Fecha) = False Then
            dgvTurnos.Rows.Add("21:00", "", "", "")
        End If
        If Chequear_Horario("21:30", Fecha) = False Then
            dgvTurnos.Rows.Add("21:30", "", "", "")
        End If
        If Chequear_Horario("22:00", Fecha) = False Then
            dgvTurnos.Rows.Add("22:00", "", "", "")
        End If
        dgvTurnos.Sort(dgvTurnos.Columns(0), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Function Chequear_Horario(ByVal Horario As String, ByVal fecha As String) As Boolean
        Dim Hora As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID from Turnos WHERE Fecha='" + fecha + "' and Hora ='" + Horario + "'")
        If Hora <> "" Then
            Return True
        Else
            Return False
        End If
    End Function

#Region "Funciones"
    Sub Deseleccionar(ByVal pa1 As PictureBox)
        If pa1.Name = "pbempleados2" Then
            'pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
            pbturno2.Image = Peluqueria.My.Resources.Resources._1
            pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
            pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
            pbpagos2.Image = Peluqueria.My.Resources.Resources._5
            pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
        ElseIf pa1.Name = "pbturno2" Then
            'pbturno2.Image = Peluqueria.My.Resources.Resources._1
            pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
            pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
            pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
            pbpagos2.Image = Peluqueria.My.Resources.Resources._5
            pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
        ElseIf pa1.Name = "pbgeneral2" Then
            'pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
            pbturno2.Image = Peluqueria.My.Resources.Resources._1
            pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
            pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
            pbpagos2.Image = Peluqueria.My.Resources.Resources._5
            pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
        ElseIf pa1.Name = "pbcliente2" Then
            'pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
            pbturno2.Image = Peluqueria.My.Resources.Resources._1
            pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
            pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
            pbpagos2.Image = Peluqueria.My.Resources.Resources._5
            pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
        ElseIf pa1.Name = "pbpagos2" Then
            'pbpagos2.Image = Peluqueria.My.Resources.Resources._5
            pbturno2.Image = Peluqueria.My.Resources.Resources._1
            pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
            pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
            pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
            pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
        ElseIf pa1.Name = "pbusuarios2" Then
            'pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
            pbturno2.Image = Peluqueria.My.Resources.Resources._1
            pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
            pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
            pbpagos2.Image = Peluqueria.My.Resources.Resources._5
            pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
        End If
    End Sub

    Sub Desplegar_Panel(ByVal pa As Panel, x As Integer)
        If desplegado = "" Then
            Abrir_Panel(pa, x)
        Else
            If desplegado = pa.Name Then
                Cerrar_Panel(pa, x)
            Else
                For Each Panels As Control In Me.Controls
                    If Panels.Name = desplegado Then
                        Cerrar_Panel(Panels, Panels.Width)
                    End If
                Next
                Abrir_Panel(pa, x)
            End If
        End If
    End Sub

    Sub Cerrar_Panel(ByVal pa As Panel, x As Integer)
        pa.Width = 0
        desplegado = ""
        dgvTurnos.Refresh()
    End Sub

    Sub Abrir_Panel(ByVal pa As Panel, x As Integer)
        For i = 0 To x Step 2
            pa.Width = (i)
        Next
        desplegado = pa.Name
    End Sub

    Private Sub MenuPrin_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        If cerrar = False Then
            Login.Close()
        End If
    End Sub
    Sub gerenarbackup()
        Dim Ruta As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Ubicacion FROM Backups_dato")
        Dim Nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Backups_dato")
        Dim Numero As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT TOP 1 (ID) FROM Backups ORDER BY ID DESC")
        acceso.Ejecutar_Query("ExecuteNonQuery", "Backup database Pelu to disk = '" + Ruta + "\" + Nombre + CStr(CInt(Numero) + 1) + ".bak' ")
        Dim hora As String = Date.Now
        acceso.Ejecutar_Query("ExecuteNonQuery", "INSERT INTO Backups VALUES ('" + hora + "')")
        lblbackhora.Text = hora
    End Sub
#End Region

#Region "Clicks"
    Private Sub pbturno2_Click(sender As Object, e As EventArgs) Handles pbturno2.Click
        pbturno_mas.Visible = False
        pbturno_edit.Visible = False
        Deseleccionar(pbturno2)
        Me.Refresh()
        Desplegar_Panel(paturno, 211)
        pbturno_mas.Visible = True
        pbturno_edit.Visible = True
    End Sub

    Private Sub pbusuarios2_Click(sender As Object, e As EventArgs) Handles pbusuarios2.Click
        If lblusu.ForeColor = Color.FromArgb(29, 110, 227) Then
            pbusuario_mas.Visible = False
            pbusuario_edit.Visible = False
            Deseleccionar(pbusuarios2)
            Me.Refresh()
            Desplegar_Panel(pausuarios, 211)
            pbusuario_mas.Visible = True
            pbusuario_edit.Visible = True
        End If
    End Sub

    Private Sub x1_Click(sender As Object, e As EventArgs) Handles x1.Click
        Me.Close()
    End Sub

    Private Sub min1_Click(sender As Object, e As EventArgs) Handles min1.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnnuevousu_Click(sender As Object, e As EventArgs) Handles pbusuario_mas.Click
        Alta_usu.Show()
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles pbusuario_edit.Click
        Modificar_usu.Show()
    End Sub

    Public cerrar As Boolean = False
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles lblcerrar.Click
        Login.Show()
        Login.usuario = ""
        cerrar = True
        Me.Close()
        lblusu.Text = ""
        lblusu.ForeColor = Color.White
        pbuser.Image = My.Resources.user1
    End Sub
    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles pblientes_mas.Click
        frmcliente_alta.Show()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles pbcliente_edit.Click
        frmcleinte_edit.Show()
    End Sub

    Private Sub pbcliente2_Click(sender As Object, e As EventArgs) Handles pbcliente2.Click
        pblientes_mas.Visible = False
        pbcliente_edit.Visible = False
        Deseleccionar(pbcliente2)
        Me.Refresh()
        Desplegar_Panel(pacliente, 211)
        pblientes_mas.Visible = True
        pbcliente_edit.Visible = True
    End Sub

    Private Sub pbpagos2_Click(sender As Object, e As EventArgs) Handles pbpagos2.Click
        pbpagos_alta.Visible = False
        pbpagos_edit.Visible = False
        Deseleccionar(pbpagos2)
        Me.Refresh()
        Desplegar_Panel(papagos, 211)
        pbpagos_alta.Visible = True
        pbpagos_edit.Visible = True
    End Sub

    Private Sub pbgeneral2_Click(sender As Object, e As EventArgs) Handles pbgeneral2.Click
        If lblusu.ForeColor = Color.FromArgb(29, 110, 227) Then
            pbcorte_mas.Visible = False
            pbcorte_edit.Visible = False
            pblistaemp.Visible = False
            pbvercliente.Visible = False
            pbverpagos.Visible = False
            pbresumen.Visible = False
            Deseleccionar(pbgeneral2)
            Me.Refresh()
            Desplegar_Panel(pageneral, 614)
            pbcorte_mas.Visible = True
            pbcorte_edit.Visible = True
            pblistaemp.Visible = True
            pbvercliente.Visible = True
            pbverpagos.Visible = True
            pbresumen.Visible = True
        End If
    End Sub

    Private Sub pbturno_edit_Click(sender As Object, e As EventArgs) Handles pbturno_edit.Click
        frmturnos_edit.Show()
    End Sub

    Private Sub pblistaemp_Click(sender As Object, e As EventArgs) Handles pblistaemp.Click
        frmlistaempl.Show()
    End Sub

    Private Sub pbresumen_Click(sender As Object, e As EventArgs) Handles pbresumen.Click
        frmresumen.Show()
    End Sub

    Private Sub pbverpagos_Click(sender As Object, e As EventArgs) Handles pbverpagos.Click
        frmverpagos.Show()
    End Sub

    Private Sub pbcorte_mas_Click(sender As Object, e As EventArgs) Handles pbcorte_mas.Click
        frmcorte_alta.Show()
    End Sub

    Private Sub pbcorte_edit_Click(sender As Object, e As EventArgs) Handles pbcorte_edit.Click
        frmcorte_edit.Show()
    End Sub

    Private Sub PictureBox3_Click_1(sender As Object, e As EventArgs) Handles pbvercliente.Click
        frmverusu.Show()
    End Sub
    Private Sub pbpagos_alta_Click(sender As Object, e As EventArgs) Handles pbpagos_alta.Click
        frmPagos_alta.Show()
    End Sub

    Private Sub pbpagos_edit_Click(sender As Object, e As EventArgs) Handles pbpagos_edit.Click
        frmpagos_edit.Show()
    End Sub

    Private Sub pbturno_mas_Click(sender As Object, e As EventArgs) Handles pbturno_mas.Click
        frmturnos_alta.Show()
    End Sub

    Private Sub pbempleados2_Click(sender As Object, e As EventArgs) Handles pbempleados2.Click
        If lblusu.ForeColor = Color.FromArgb(29, 110, 227) Then
            pbempleado_mas.Visible = False
            pbempleado_edit.Visible = False
            Deseleccionar(pbempleados2)
            Me.Refresh()
            Desplegar_Panel(paempleado, 211)
            pbempleado_mas.Visible = True
            pbempleado_edit.Visible = True
        End If
    End Sub

    Private Sub pbempleado_mas_Click(sender As Object, e As EventArgs) Handles pbempleado_mas.Click
        frmempleados_alta.Show()
    End Sub

    Private Sub pbempleado_edit_Click(sender As Object, e As EventArgs) Handles pbempleado_edit.Click
        frmempleados_edit.Show()
    End Sub

    Private Sub pbbackup2_Click(sender As Object, e As EventArgs) Handles pbbackup2.Click
        frmconfback.Show()
    End Sub

    Private Sub pbopback2_Click(sender As Object, e As EventArgs) Handles pbopback2.Click
        frmopback.Show()
    End Sub
#End Region

#Region "Timer Fecha"
    Private Sub TimerFecha_Tick(sender As Object, e As EventArgs) Handles TimerFecha.Tick
        Dim hora As String = Now.ToLongTimeString
        'Dim dia As String = Now.ToShortDateString
        lblhora.Text = hora
        'lbldia.Text = dia
    End Sub
#End Region

#Region "Timer Backup"
    Dim flagback As Integer = 0
    Private Sub timerback_Tick(sender As Object, e As EventArgs) Handles TimerBack.Tick
        If flagback < 5 Then
            pbcargando.Visible = True
            pbok.Visible = False
        ElseIf flagback > 4 And flagback < 10 Then
            pbcargando.Visible = False
            pbok.Visible = True
        Else
            timeback(False)
        End If
        flagback += 1
    End Sub

    Sub timeback(ByVal estado As Boolean)
        If estado = True Then
            pbcargando.Visible = True
            TimerBack.Start()
        Else
            TimerBack.Stop()
            TimerBack.Dispose()
            flagback = 0
            pbok.Visible = False
            pbcargando.Visible = False
        End If
    End Sub
#End Region

#Region "MEML - Pulido"
    '-------------------------------------------------------------------------------------------' Backup
    Private Sub Backup_ME(sender As Object, e As EventArgs) Handles pbbackup2.MouseEnter
        pbbackup2.Image = Peluqueria.My.Resources.Resources.database_2_
    End Sub
    Private Sub Backup_ML(sender As Object, e As EventArgs) Handles pbbackup2.MouseLeave
        pbbackup2.Image = Peluqueria.My.Resources.Resources.database
    End Sub
    '-------------------------------------------------------------------------------------------' Opciones Backup
    Private Sub OpcionesBack_ME(sender As Object, e As EventArgs) Handles pbopback2.MouseEnter
        pbopback2.Image = Peluqueria.My.Resources.Resources.settings_1_
    End Sub
    Private Sub OpcionesBack_ML(sender As Object, e As EventArgs) Handles pbopback2.MouseLeave
        pbopback2.Image = Peluqueria.My.Resources.Resources.settings
    End Sub
    '-------------------------------------------------------------------------------------------' Cambio Fecha
    Private Sub CambioFecha_ME(sender As Object, e As EventArgs) Handles pbcambfec2.MouseEnter
        pbcambfec2.Image = Peluqueria.My.Resources.Resources.timetable_1_
    End Sub
    Private Sub CambioFecha_ML(sender As Object, e As EventArgs) Handles pbcambfec2.MouseLeave
        pbcambfec2.Image = Peluqueria.My.Resources.Resources.timetable
    End Sub
    '-------------------------------------------------------------------------------------------' Cliente
    Private Sub Cliente_ME(sender As Object, e As EventArgs) Handles pbcliente2.MouseEnter
        pbcliente2.Image = Peluqueria.My.Resources.Resources._2_copia
    End Sub
    Private Sub Cliente_ML(sender As Object, e As EventArgs) Handles pbcliente2.MouseLeave
        If pacliente.Width = 0 Then
            pbcliente2.Image = Peluqueria.My.Resources.Resources._1_copia
        End If
    End Sub
    '-------------------------------------------------------------------------------------------' Cerrar Sesion
    Private Sub CerrarSesion_ME(sender As Object, e As EventArgs) Handles lblcerrar.MouseEnter
        lblcerrar.ForeColor = Color.FromArgb(49, 49, 49)
    End Sub
    Private Sub CerrarSesion_ML(sender As Object, e As EventArgs) Handles lblcerrar.MouseLeave
        lblcerrar.ForeColor = Color.Black
    End Sub
    '-------------------------------------------------------------------------------------------' Turnos
    Private Sub Turnos_ME(sender As Object, e As EventArgs) Handles pbturno2.MouseEnter
        pbturno2.Image = Peluqueria.My.Resources.Resources._2
    End Sub
    Private Sub Turnos_ML(sender As Object, e As EventArgs) Handles pbturno2.MouseLeave
        If paturno.Width = 0 Then
            pbturno2.Image = Peluqueria.My.Resources.Resources._1
        End If
    End Sub
    '-------------------------------------------------------------------------------------------' Pagos
    Private Sub Pagos_ME(sender As Object, e As EventArgs) Handles pbpagos2.MouseEnter
        pbpagos2.Image = Peluqueria.My.Resources.Resources._6
    End Sub
    Private Sub Pagos_ML(sender As Object, e As EventArgs) Handles pbpagos2.MouseLeave
        If papagos.Width = 0 Then
            pbpagos2.Image = Peluqueria.My.Resources.Resources._5
        End If
    End Sub
    '-------------------------------------------------------------------------------------------' Empleados
    Private Sub Empleados_ME(sender As Object, e As EventArgs) Handles pbempleados2.MouseEnter
        pbempleados2.Image = Peluqueria.My.Resources.Resources._2_copia_2
    End Sub
    Private Sub Empleados_ML(sender As Object, e As EventArgs) Handles pbempleados2.MouseLeave
        If paempleado.Width = 0 Then
            pbempleados2.Image = Peluqueria.My.Resources.Resources._1_copia_2
        End If
    End Sub
    '-------------------------------------------------------------------------------------------' General
    Private Sub General_ME(sender As Object, e As EventArgs) Handles pbgeneral2.MouseEnter
        pbgeneral2.Image = Peluqueria.My.Resources.Resources._14
    End Sub
    Private Sub General_ML(sender As Object, e As EventArgs) Handles pbgeneral2.MouseLeave
        If pageneral.Width = 0 Then
            pbgeneral2.Image = Peluqueria.My.Resources.Resources._13
        End If
    End Sub
    '-------------------------------------------------------------------------------------------' Usuarios
    Private Sub Usuarios_ME(sender As Object, e As EventArgs) Handles pbusuarios2.MouseEnter
        pbusuarios2.Image = Peluqueria.My.Resources.Resources._10
    End Sub
    Private Sub Usuarios_ML(sender As Object, e As EventArgs) Handles pbusuarios2.MouseLeave
        If pausuarios.Width = 0 Then
            pbusuarios2.Image = Peluqueria.My.Resources.Resources._9
        End If
    End Sub

    Private Sub pbcambfec2_Click(sender As Object, e As EventArgs) Handles pbcambfec2.Click
        frmfecha.Show()
    End Sub

    Private Sub paventana_Paint(sender As Object, e As PaintEventArgs) Handles paventana.Paint

    End Sub
#End Region

#Region "Arrastrar Formulario"
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paventana.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paventana.MouseUp
        Arrastre = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paventana.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
#End Region

End Class

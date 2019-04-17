Public Class frmturnos_alta
    Dim acceso As New AccesoSQL

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

    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub

    Private Sub frmturnos_alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DSempleado As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
            For Each Fila As DataRow In DSempleado.Tables(0).Rows
                cbempleado.Items.Add(Fila.Item(0).ToString())
            Next
            Dim DScliente As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Clientes", "Clientes")
            For Each Fila As DataRow In DScliente.Tables(0).Rows
                cmbcliente.Items.Add(Fila.Item(0).ToString())
            Next
            Dim DStipo As DataSet = acceso.Consulta_DS("SELECT Nombre FROM TipoCortes", "TipoCortes")
            For Each Fila As DataRow In DStipo.Tables(0).Rows
                cmbcorte.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub maskfecha_TextChanged(sender As Object, e As EventArgs) Handles maskfecha.TextChanged
        Dim fecha As Date = Nothing
        Try
            fecha = CDate(maskfecha.Text)
        Catch ex As Exception
            fecha = Nothing
        End Try
        If fecha <> Nothing Then
            If IsDate(fecha) Then
                If fecha < Date.Today Then
                    pbfecha.Visible = False
                Else
                    pbfecha.Visible = True
                End If
            Else
                pbfecha.Visible = False
            End If
        Else
            pbfecha.Visible = False
        End If
    End Sub

    Private Sub cmbhora_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbhora.SelectedIndexChanged
        If cmbhora.Text <> "" Then
            pbhora.Visible = True
        End If
    End Sub

    Private Sub cmbcorte_TextChanged(sender As Object, e As EventArgs) Handles cmbcorte.TextChanged
        Dim texto As String = cmbcorte.Text
        If texto <> "" Then
            Dim Res As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre from TipoCortes where Nombre='" + texto + "'")
            If Res <> "" Then
                pbtipo.Visible = True
            Else
                pbtipo.Visible = False
            End If
        Else
            pbtipo.Visible = False
        End If
    End Sub

    Private Sub cmbcliente_TextChanged(sender As Object, e As EventArgs) Handles cmbcliente.TextChanged
        If cmbcliente.Text <> "" Then
            pbcliente.Visible = True
        Else
            pbcliente.Visible = False
        End If
    End Sub


    Private Sub cbempleado_TextChanged(sender As Object, e As EventArgs) Handles cbempleado.TextChanged
        If cbempleado.Text <> "" Then
            pbempleado.Visible = True
        Else
            pbempleado.Visible = False
        End If
    End Sub

    Private Sub btnturno_Click(sender As Object, e As EventArgs) Handles btnturno.Click
        Try
            lbl1.Visible = False
            If pbcliente.Visible = True And pbempleado.Visible = True And pbfecha.Visible = True And pbhora.Visible = True And pbtipo.Visible = True Then
                Dim IDEmp As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Empleados WHERE Nombre ='" + cbempleado.Text + "'")
                Dim HorarioEmp As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Turnos WHERE Empleado ='" + IDEmp + "' and Fecha ='" + maskfecha.Text + "' and Hora ='" + cmbhora.Text + "'")
                If HorarioEmp = "" Then
                    Dim IDCorte As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM TipoCortes WHERE Nombre ='" + cmbcorte.Text + "'")
                    acceso.Ejecutar_Query("ExecuteScalar", "INSERT INTO Turnos VALUES ('" + maskfecha.Text + "','" + cmbhora.Text + "','" + IDCorte + "','" + cmbcliente.Text + "','" + IDEmp + "')")
                    If MenuPrin.fecha = maskfecha.Text Then
                        MenuPrin.Cargar_Calendario(MenuPrin.fecha)
                    End If
                    Cancelar()
                    MsgBox("¡Turno asignado con exito!")
                Else
                    lbl1.Visible = True
                End If
            Else
                MsgBox("Deberan estar correctos todos los campos", Title:="ReDim Software")
            End If
        Catch ex As Exception
            MsgBox("Error al asignar nuevo turno, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Sub Cancelar()
        pbcliente.Visible = False
        pbempleado.Visible = False
        pbfecha.Visible = False
        pbhora.Visible = False
        pbtipo.Visible = False
        cmbcliente.Text = ""
        cmbcorte.Text = ""
        cmbhora.Text = ""
        maskfecha.Text = ""
        cbempleado.Text = ""
        maskfecha.Focus()
    End Sub
End Class
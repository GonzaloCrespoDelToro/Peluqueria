Public Class frmturnos_edit
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

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            If maskfecha.Text <> "" Then
                If IsDate(maskfecha.Text) Then
                    Dim DSturnos As DataSet = acceso.Consulta_DS("SELECT t.ID, t.Hora, tt.Nombre as [Tipo Corte], t.Cliente, e.Nombre as [Empleado] FROM Turnos t INNER JOIN Empleados e ON t.Empleado = e.ID inner join TipoCortes tt on t.TipoCorte = tt.ID WHERE t.Fecha = '" + maskfecha.Text + "' order by t.Hora asc", "Turnos")
                    dgvturnos.DataSource = DSturnos.Tables(0).DefaultView
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al buscar, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Private Sub frmturnos_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvturnos.DefaultCellStyle.Font = New Font("Montserrat", 9)
    End Sub
    Dim idglobal As String = ""
    Private Sub dgvturnos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvturnos.CellClick
        Dim id As String = dgvturnos.CurrentRow.Cells(0).Value
        idglobal = id
        lblcliente.Text = dgvturnos.CurrentRow.Cells(3).Value
        lblempleado.Text = dgvturnos.CurrentRow.Cells(4).Value
        lblfecha.Text = maskfecha.Text
        lblhora.Text = dgvturnos.CurrentRow.Cells(1).Value
        btnborrar.Enabled = True
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Borrar el Turno?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                acceso.Ejecutar_Query("ExecuteNonQuery", "DELETE FROM Turnos WHERE ID = '" + idglobal + "'")
                MsgBox("El turno se elimino con exito", Title:="ReDim Software")
                lblcliente.Text = ""
                lblempleado.Text = ""
                lblfecha.Text = ""
                lblhora.Text = ""
                If maskfecha.Text <> "" Then
                    If IsDate(maskfecha.Text) Then
                        Dim DSturnos As DataSet = acceso.Consulta_DS("SELECT t.ID, t.Hora, tt.Nombre as [Tipo Corte], t.Cliente, e.Nombre as [Empleado] FROM Turnos t INNER JOIN Empleados e ON t.Empleado = e.ID inner join TipoCortes tt on t.TipoCorte = tt.ID WHERE t.Fecha = '" + maskfecha.Text + "' order by t.Hora asc", "Turnos")
                        dgvturnos.DataSource = DSturnos.Tables(0).DefaultView
                    End If
                End If
                btnborrar.Enabled = False
            End If
        Catch ex As Exception
            MsgBox("Error al borrar, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
Public Class frmpagos_edit
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

    Private Sub rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbfecha.CheckedChanged
        If rbfecha.Checked = True Then
            maskfecha.Enabled = True
        Else
            maskfecha.Enabled = False
        End If
    End Sub

    Private Sub rbcliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbcliente.CheckedChanged
        If rbcliente.Checked = True Then
            cmbcliente.Enabled = True
        Else
            cmbcliente.Enabled = False
        End If
    End Sub

    Private Sub rbempleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbempleado.CheckedChanged
        If rbempleado.Checked = True Then
            cmbempleado.Enabled = True
        Else
            cmbempleado.Enabled = False
        End If
    End Sub

    Private Sub frmpagos_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dgvpagos.DefaultCellStyle.Font = New Font("Montserrat", 9)
        Dim DSemp As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
        For Each Fila As DataRow In DSemp.Tables(0).Rows
            cmbempleado.Items.Add(Fila.Item(0).ToString())
        Next

        Dim DScliente As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Clientes", "Clientes")
        For Each fila As DataRow In DScliente.Tables(0).Rows
            cmbcliente.Items.Add(fila.Item(0).ToString())
        Next
    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            dgvpagos.DataSource = Nothing
            dgvpagos.Rows.Clear()
            If rbfecha.Checked = True And maskfecha.Text <> "" Then
                Dim ds As DataSet = acceso.Consulta_DS("select p.ID, e.Nombre as Empleado, p.Cliente, p.tipo as [Tipo Pago], p.Importe, u.Nombre as Usuario From Pagos p inner join Empleados e on p.Empleado = e.ID inner join Usuarios u on p.Usuario  = u.ID WHERE Fecha = '" + maskfecha.Text + "'", "Pagos")
                dgvpagos.DataSource = ds.Tables(0).DefaultView
            ElseIf rbempleado.Checked And cmbempleado.Text <> "" Then
                Dim ID As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Empleados WHERE Nombre = '" + cmbempleado.Text + "'")
                Dim ds As DataSet = acceso.Consulta_DS("SELECT p.ID, p.Cliente, p.Importe, p.Fecha, p.tipo as [Tipo Pago], u.Nombre as Usuario From Pagos p inner join Usuarios u on p.usuario = u.ID WHERE p.Empleado = '" + ID + "'", "Pagos")
                dgvpagos.DataSource = ds.Tables(0).DefaultView
            ElseIf rbcliente.Checked And cmbcliente.Text <> "" Then
                Dim ds As DataSet = acceso.Consulta_DS("SELECT p.ID, p.Importe, p.Fecha, p.Tipo as [Tipo Pago], e.Nombre as Empleado,u.Nombre as Usuario From Pagos p inner join Empleados e on p.Empleado = e.ID inner join Usuarios u on p.Usuario  = u.ID WHERE p.Cliente = '" + cmbcliente.Text + "'", "Pagos")
                dgvpagos.DataSource = ds.Tables(0).DefaultView
            End If
        Catch ex As Exception
            MsgBox("Error al buscar pago, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Borrar el Pago?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                acceso.Ejecutar_Query("ExecuteNonQuery", "DELETE FROM Pagos WHERE ID = '" + idglobal + "'")
                MsgBox("El Pago se elimino con exito", Title:="ReDim Software")
                lblcliente.Text = ""
                lblempleado.Text = ""
                lblfecha.Text = ""
                lblimporte.Text = ""
                rbcliente.Checked = False
                rbempleado.Checked = False
                rbfecha.Checked = False
                maskfecha.Text = ""
                cmbcliente.Text = ""
                dgvpagos.DataSource = Nothing
                dgvpagos.Rows.Clear()
            End If
        Catch ex As Exception
            MsgBox("Error al borrar pago, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub
    Dim idglobal As String
    Private Sub dgvpagos_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvpagos.CellClick
        If rbfecha.Checked = True Then
            Dim id As String = dgvpagos.CurrentRow.Cells(0).Value
            idglobal = id
            lblcliente.Text = dgvpagos.CurrentRow.Cells(2).Value
            lblfecha.Text = maskfecha.Text
            lblempleado.Text = dgvpagos.CurrentRow.Cells(1).Value
            lblimporte.Text = dgvpagos.CurrentRow.Cells(4).Value
            btnborrar.Enabled = True
        ElseIf rbcliente.Checked = True Then
            Dim id As String = dgvpagos.CurrentRow.Cells(0).Value
            idglobal = id
            lblimporte.Text = dgvpagos.CurrentRow.Cells(1).Value
            lblfecha.Text = dgvpagos.CurrentRow.Cells(2).Value
            lblempleado.Text = dgvpagos.CurrentRow.Cells(4).Value
            lblcliente.Text = cmbcliente.Text
            btnborrar.Enabled = True
        ElseIf rbempleado.Checked = True Then
            Dim id As String = dgvpagos.CurrentRow.Cells(0).Value
            idglobal = id
            lblempleado.Text = cmbempleado.Text
            lblcliente.Text = dgvpagos.CurrentRow.Cells(1).Value
            lblimporte.Text = dgvpagos.CurrentRow.Cells(2).Value
            lblfecha.Text = dgvpagos.CurrentRow.Cells(3).Value
            btnborrar.Enabled = True
        End If
    End Sub
End Class
Public Class frmverpagos
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

    Private Sub frmverpagos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DSCliente As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Clientes", "Clientes")
        For Each Fila As DataRow In DSCliente.Tables(0).Rows
            cmbcliente.Items.Add(Fila.Item(0).ToString())
        Next
        Dim DSEmpleado As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
        For Each Fila As DataRow In DSEmpleado.Tables(0).Rows
            cmbempleado.Items.Add(Fila.Item(0).ToString())
        Next
        lblcant.Text = dgvpagos.Rows.Count
    End Sub
    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            Dim Consulta As String = ""
            If rbcliente.Checked = True Then
                If cmbcliente.Text <> "" Then
                    Consulta = "SELECT  p.Tipo, p.Importe, e.Nombre as Empleado, p.Fecha, u.Nombre as Usuario FROM Pagos p INNER JOIN Empleados e ON p.Empleado = e.ID INNER JOIN Usuarios u ON p.Usuario = u.ID WHERE p.Cliente ='" + cmbcliente.Text + "'"
                Else
                    MsgBox("Por favor seleccione un cliente", Title:="ReDim Software")
                    Exit Sub
                End If
            ElseIf rbempleado.Checked = True Then
                If cmbempleado.Text <> "" Then
                    Dim IDEmp As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Empleados WHERE Nombre ='" + cmbempleado.Text + "'")
                    Consulta = "SELECT  p.Tipo, p.Importe, p.Cliente, p.Fecha, u.Nombre as Usuario FROM Pagos p INNER JOIN Usuarios u ON p.Usuario = u.ID WHERE p.Empleado = '" + IDEmp + "'"
                Else
                    MsgBox("Por favor seleccione un Empleado", Title:="ReDim Software")
                    Exit Sub
                End If
            Else
                Consulta = "SELECT p.Tipo, p.Importe, p.Cliente, e.Nombre as Empleado, p.Fecha, u.Nombre as Usuario FROM Pagos p INNER JOIN Empleados e ON p.Empleado = e.ID INNER JOIN Usuarios u ON p.Usuario = u.ID WHERE"
            End If
            If rbfecha.Checked = True And rbcliente.Checked = True Or rbfecha.Checked = True And rbempleado.Checked = True Then
                Consulta = Consulta + " AND Fecha = '" + msk1.Text + "'"
            ElseIf rbfecha.Checked = True Then
                Consulta = "SELECT p.Tipo, p.Importe, p.Cliente, e.Nombre as Empleado, u.Nombre as Usuario FROM Pagos p INNER JOIN Empleados e ON p.Empleado = e.ID INNER JOIN Usuarios u ON p.Usuario = u.ID WHERE p.Fecha ='" + msk1.Text + "'"
            End If
            If rbrangofecha.Checked = True And rbcliente.Checked = True Or rbrangofecha.Checked = True And rbempleado.Checked = True Then
                Consulta = Consulta + " AND Fecha BETWEEN '" + msk1.Text + "' AND '" + msk2.Text + "'"
            ElseIf rbrangofecha.Checked = True Then
                Consulta = "SELECT p.Tipo, p.Importe, p.Cliente, e.Nombre as Empleado, p.Fecha, u.Nombre as Usuario FROM Pagos p INNER JOIN Empleados e ON p.Empleado = e.ID INNER JOIN Usuarios u ON p.Usuario = u.ID WHERE p.Fecha BETWEEN '" + msk1.Text + "' AND '" + msk2.Text + "'"
            End If
            Dim DS As DataSet = acceso.Consulta_DS(Consulta, "Pagos")
            dgvpagos.DataSource = DS.Tables(0).DefaultView
            btncancelar.Enabled = True
            lblcant.Text = dgvpagos.Rows.Count
            Dim dot As Double = 0
            For i = 0 To dgvpagos.Rows.Count - 1
                dot += CDbl(dgvpagos.Rows(i).Cells(1).Value)
            Next
            lbltotal.Text = "$" + CStr(dot)

        Catch ex As Exception
            MsgBox("Error al buscar pagos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub rbcliente_CheckedChanged(sender As Object, e As EventArgs) Handles rbcliente.CheckedChanged
        cmbcliente.Enabled = True
        cmbempleado.Enabled = False
        cmbcliente.Focus()
    End Sub

    Private Sub rbempleado_CheckedChanged(sender As Object, e As EventArgs) Handles rbempleado.CheckedChanged
        cmbcliente.Enabled = False
        cmbempleado.Enabled = True
        cmbempleado.Focus()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        cmbcliente.Enabled = False
        cmbempleado.Enabled = False

    End Sub

    Private Sub rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbfecha.CheckedChanged
        msk1.Enabled = True
        msk2.Enabled = False
        msk1.Focus()
    End Sub

    Private Sub rbrangofecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbrangofecha.CheckedChanged
        msk1.Enabled = True
        msk2.Enabled = True
        msk2.Focus()
    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        msk1.Enabled = False
        msk2.Enabled = False
    End Sub

    Sub cancelar()
        msk2.Enabled = False
        msk1.Enabled = False
        cmbcliente.Enabled = False
        cmbempleado.Enabled = False
        rbcliente.Checked = False
        rbempleado.Checked = False
        rbfecha.Checked = False
        rbrangofecha.Checked = False
        dgvpagos.DataSource = Nothing
        msk1.Text = ""
        msk2.Text = ""
        lbltotal.Text = ""
        lblcant.Text = ""
        cmbcliente.Text = ""
        cmbempleado.Text = ""
        dgvpagos.Rows.Clear()
    End Sub
    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        cancelar()
    End Sub
End Class
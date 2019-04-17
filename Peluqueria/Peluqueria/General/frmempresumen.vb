Public Class frmempleresumen
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

    Private Sub frmlistadoemp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim Empleado As String = frmresumen.empleado
            Dim IDEmp As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID From Empleados WHERE Nombre ='" + Empleado + "'")
            Dim Porc As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Porcentaje From Empleados WHERE Nombre ='" + Empleado + "'")
            Dim Consulta As String = ""
            If frmresumen.fecha1 <> "" And frmresumen.fecha2 <> "" Then
                Consulta = "SELECT CONVERT(VARCHAR(10),Fecha,105), Importe FROM Pagos WHERE Empleado='" + IDEmp + "' and Fecha BETWEEN '" + frmresumen.fecha1 + "' and '" + frmresumen.fecha2 + "'"
            ElseIf frmresumen.fecha1 <> "" Then
                Consulta = "SELECT CONVERT(VARCHAR(10),Fecha,105), Importe FROM Pagos WHERE Empleado='" + IDEmp + "' and Fecha ='" + frmresumen.fecha1 + "'"
            End If
            Dim DS As DataSet = acceso.Consulta_DS(Consulta, "Pagos")
            Dim Nro As Integer = 1
            Dim Total As Double = 0
            dgvPagos.Rows.Add("0", Empleado, "Porc: " + Porc + "%")
            For Each Fila As DataRow In DS.Tables(0).Rows
                dgvPagos.Rows.Add(CStr(Nro), Fila(0).ToString, CStr((CDbl(Fila(1).ToString) * CDbl(Porc)) / 100))
                Total += (CDbl(Fila(1).ToString) * CDbl(Porc) / 100)
                Nro += 1
            Next
            lblTotal.Text = Format(Total, "##,##00.00")
            txtnombre.Text = Empleado
        Catch ex As Exception
            MsgBox("Error al listar datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub

    Private Sub btnexpo_Click(sender As Object, e As EventArgs) Handles btnexpo.Click
        acceso.GridAExcel(dgvPagos)
    End Sub
End Class
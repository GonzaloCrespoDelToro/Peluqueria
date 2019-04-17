Public Class frmresumen
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

    Public fecha1 As String = ""
    Public fecha2 As String = ""
    Public empleado As String = ""
    Private Sub btnListado_Click(sender As Object, e As EventArgs) Handles btnListado.Click
        If cmbempleados.Text <> "" Then
            empleado = cmbempleados.Text
            frmempleresumen.Show()
        End If
    End Sub

    Dim Cant_Ef As Integer = 0
    Dim Cant_Cred As Integer = 0
    Dim Cant_Deb As Integer = 0
    Dim Tot_Ef As Double = 0
    Dim Tot_Cred As Double = 0
    Dim Tot_Deb As Double = 0
    Dim Cant_Tot As Integer = 0
    Dim Tot_Tot As Double = 0
    Dim Tot_Desc As Double = 0

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Try
            Dim Consulta As String = ""
            If rbfecha.Checked = True Then
                If msk1.Text <> "" Then
                    Consulta = "SELECT * FROM Pagos WHERE Fecha = '" + msk1.Text + "'"
                Else
                    Exit Sub
                End If

            ElseIf rbrangofecha.Checked = True Then
                If msk1.Text <> "" And msk2.Text <> "" Then
                    Consulta = "SELECT * FROM Pagos WHERE Fecha BETWEEN '" + msk1.Text + "' AND '" + msk2.Text + "'"
                Else
                    Exit Sub
                End If
            End If
            Dim DS As DataSet = acceso.Consulta_DS(Consulta, "Pagos")
            For Each Fila As DataRow In DS.Tables(0).Rows
                If Fila(4).ToString() = "Contado" Then
                    Cant_Ef += 1
                    Tot_Ef += CDbl(Fila(5).ToString())
                ElseIf Fila(4).ToString() = "Debito" Then
                    Cant_Deb += 1
                    Tot_Deb += CDbl(Fila(5).ToString())
                ElseIf Fila(4).ToString() = "Credito" Then
                    Cant_Cred += 1
                    Tot_Cred += CDbl(Fila(5).ToString())
                End If
                Cant_Tot += 1
                Tot_Tot += CDbl(Fila(5).ToString())
                If Buscar_Emp(Fila(1).ToString()) = False Then
                    dgvEmp.Rows.Add(Fila(1).ToString(), "0", "0")
                End If
                For i = 0 To dgvEmp.Rows.Count - 1
                    If dgvEmp.Rows(i).Cells(0).Value = Fila(1).ToString() Then
                        dgvEmp.Rows(i).Cells(1).Value = CStr(CInt(dgvEmp.Rows(i).Cells(1).Value) + 1)
                        Dim Porc As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Porcentaje FROM Empleados WHERE ID='" + dgvEmp.Rows(i).Cells(0).Value + "'")
                        Dim Desc As String = CStr(CDbl((Fila(5).ToString()) * CDbl(Porc)) / 100)
                        dgvEmp.Rows(i).Cells(2).Value = CStr(CDbl(dgvEmp.Rows(i).Cells(2).Value) + CDbl(Desc))
                        Tot_Desc += CDbl(Desc)
                        Exit For
                    End If

                Next
            Next
            lblcantef.Text = CStr(Cant_Ef)
            lblcantdeb.Text = CStr(Cant_Deb)
            lblcantcred.Text = CStr(Cant_Cred)
            lbltotef.Text = "$" + Format(Tot_Ef, "##,##00.00")
            lbltotdeb.Text = "$" + Format(Tot_Deb, "##,##00.00")
            lbltotcred.Text = "$" + Format(Tot_Cred, "##,##00.00")
            lblcanttot.Text = CStr(Cant_Tot)
            lbltot.Text = "$" + Format(Tot_Tot, "##,##00.00")
            lbltotdesc.Text = "$" + Format(Tot_Desc, "##,##00.00")
            lblcantemp.Text = dgvEmp.Rows.Count
            Try
                For i = 0 To dgvEmp.Rows.Count
                    dgvEmp.Rows(i).Cells(0).Value = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Empleados WHERE ID = '" + dgvEmp.Rows(i).Cells(0).Value + "'")
                    cmbempleados.Items.Add(dgvEmp.Rows(i).Cells(0).Value)
                Next
            Catch ex As Exception

            End Try
            GroupBox2.Visible = True
            GroupBox3.Visible = True

            If rbfecha.Checked = True Then
                fecha1 = msk1.Text
                fecha2 = ""
            ElseIf rbrangofecha.Checked = True Then
                fecha1 = msk1.Text
                fecha2 = msk2.Text
            End If
        Catch ex As Exception
            MsgBox("Error al buscar, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
    Function Buscar_Emp(ByVal Emp As String) As Boolean
        Try
            For i = 0 To dgvEmp.Rows.Count
                If dgvEmp.Rows(i).Cells(0).Value = Emp Then
                    Return True
                End If
            Next
            Return False
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Sub rbfecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbfecha.CheckedChanged
        msk1.Enabled = True
        msk2.Enabled = False
    End Sub

    Private Sub rbrangofecha_CheckedChanged(sender As Object, e As EventArgs) Handles rbrangofecha.CheckedChanged
        msk1.Enabled = True
        msk2.Enabled = True
    End Sub

    Private Sub btnexportarres_Click(sender As Object, e As EventArgs) Handles btnexportarres.Click
        If fecha1 <> "" And fecha2 <> "" Then
            dgvResumen.Rows.Add("Rango Fechas", fecha1 + " - " + fecha2)
        ElseIf fecha1 <> "" Then
            dgvResumen.Rows.Add("Fecha", fecha1)
        End If
        dgvResumen.Rows.Add("Cant. Efectivo", lblcantef.Text)
        dgvResumen.Rows.Add("Cant. Debito", lblcantdeb.Text)
        dgvResumen.Rows.Add("Cant. Credito", lblcantcred.Text)
        dgvResumen.Rows.Add("Cant. Total", lblcanttot.Text)
        dgvResumen.Rows.Add("Total Efectivo", lbltotef.Text)
        dgvResumen.Rows.Add("Total Debito", lbltotdeb.Text)
        dgvResumen.Rows.Add("Total Credito", lbltotcred.Text)
        dgvResumen.Rows.Add("Importe Total", lbltot.Text)
        dgvResumen.Rows.Add("Importe c/Desc", lbltotdesc.Text)
        acceso.GridAExcel(dgvResumen)
        dgvResumen.Rows.Clear()
    End Sub

    Private Sub btnexportarlis_Click(sender As Object, e As EventArgs) Handles btnexportarlis.Click
        Try
            For i = 0 To dgvEmp.Rows.Count
                CargarGridIndividual(dgvEmp.Rows(i).Cells(0).Value)
                acceso.GridAExcel(dgvPagos)
            Next
        Catch ex As Exception
        End Try
    End Sub

    Sub CargarGridIndividual(ByVal Emp As String)
        dgvPagos.Rows.Clear()
        Dim IDEmp As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID From Empleados WHERE Nombre ='" + Emp + "'")
        Dim Porc As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Porcentaje From Empleados WHERE Nombre ='" + Emp + "'")
        Dim Consulta As String = ""
        If fecha1 <> "" And fecha2 <> "" Then
            Consulta = "SELECT CONVERT(VARCHAR(10),Fecha,105), Importe FROM Pagos WHERE Empleado='" + IDEmp + "' and Fecha BETWEEN '" + fecha1 + "' and '" + fecha2 + "'"
        ElseIf fecha1 <> "" Then
            Consulta = "SELECT CONVERT(VARCHAR(10),Fecha,105), Importe FROM Pagos WHERE Empleado='" + IDEmp + "' and Fecha ='" + fecha1 + "'"
        End If
        Dim DS As DataSet = acceso.Consulta_DS(Consulta, "Pagos")
        Dim Nro As Integer = 1
        Dim Total As Double = 0
        dgvPagos.Rows.Add("0", Emp, "Porc.: " + Porc + "%")
        For Each Fila As DataRow In DS.Tables(0).Rows
            dgvPagos.Rows.Add(CStr(Nro), Fila(0).ToString, CStr((CDbl(Fila(1).ToString) * CDbl(Porc)) / 100))
            Total += (CDbl(Fila(1).ToString) * CDbl(Porc) / 100)
            Nro += 1
        Next
    End Sub
End Class
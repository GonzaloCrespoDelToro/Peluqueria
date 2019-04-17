Public Class frmPagos_alta
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

    Private Sub pbmin_Click(sender As Object, e As EventArgs) Handles pbmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmPagos_alta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim DSempleado As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
        For Each Fila As DataRow In DSempleado.Tables(0).Rows
            cbempleado.Items.Add(Fila.Item(0).ToString())
        Next

        Dim DScliente As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Clientes", "Clientes")
        For Each Fila As DataRow In DScliente.Tables(0).Rows
            cbcliente.Items.Add(Fila.Item(0).ToString())
        Next
    End Sub

    Private Sub btnpago_Click(sender As Object, e As EventArgs) Handles btnpago.Click
        Try
            If checkcliente.Visible = True And checkempleado.Visible = True And checkfecha.Visible = True And checktpago.Visible = True And checkimporte.Visible = True Then
                If MessageBox.Show(Me, "¿Confirma cargar el pago? Compruebe que los datos esten correctos", "ReDim Software", MessageBoxButtons.YesNo, MessageBoxIcon.Information) = DialogResult.Yes Then
                    Try
                        Dim Usu As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Usuarios WHERE Nombre ='" + Login.usuario + "'")
                        Dim Cod_Empleado As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Empleados WHERE Nombre='" + cbempleado.Text + "'")
                        Dim TipoPago As String = ""
                        If rbcontado.Checked = True Then
                            TipoPago = "Contado"
                        ElseIf rbcredito.Checked = True Then
                            TipoPago = "Credito"
                        ElseIf rbdebito.Checked = True Then
                            TipoPago = "Debito"
                        End If
                        acceso.Ejecutar_Query("ExecuteNonQuery", "Insert into Pagos Values ('" + Cod_Empleado + "','" + cbcliente.Text + "','" + maskfecha.Text + "','" + TipoPago + "','" + txtimporte.Text + "','" + Usu + "')")
                        Cancelar()
                        MsgBox("¡Pago ingresado con exito!")
                    Catch ex As Exception
                        MsgBox("Ocurrio un error, no se pudo cargar el pago")
                    End Try
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al confirmar pago, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Sub Cancelar()
        checkcliente.Visible = False
        checkempleado.Visible = False
        checkfecha.Visible = False
        checktpago.Visible = False
        checkimporte.Visible = False
        txtimporte.Text = ""
        cbcliente.Text = ""
        maskfecha.Text = ""
        rbcontado.Checked = False
        rbcredito.Checked = False
        rbdebito.Checked = False
    End Sub

    Private Sub cbcliente_TextChanged(sender As Object, e As EventArgs) Handles cbcliente.TextChanged
        If cbcliente.Text <> "" Then
            checkcliente.Visible = True
        Else
            checkcliente.Visible = False
        End If
    End Sub

    'Private Sub cbempleado_TextChanged(sender As Object, e As EventArgs) Handles cbempleado.TextChanged
    '    If cbempleado.Text <> "" Then
    '        cbempleado.Visible = True
    '    Else
    '        cbempleado.Visible = False
    '    End If
    'End Sub

    Private Sub maskfecha_TextChanged(sender As Object, e As EventArgs) Handles maskfecha.TextChanged
        Dim fecha As Date = Nothing
        Try
            fecha = CDate(maskfecha.Text)
        Catch ex As Exception
            fecha = Nothing
        End Try
        If fecha <> Nothing Then
            If IsDate(fecha) Then
                If fecha <= Date.Today Then
                    If fecha > CDate("01/01/2017") Then
                        checkfecha.Visible = True
                    Else
                        checkfecha.Visible = False
                    End If
                Else
                    checkfecha.Visible = False
                End If
            Else
                checkfecha.Visible = False
            End If
        Else
            checkfecha.Visible = False
        End If
    End Sub

    Private Sub rbcontado_CheckedChanged(sender As Object, e As EventArgs) Handles rbcontado.CheckedChanged
        If rbcontado.Checked = True Then
            checktpago.Visible = True
        End If
    End Sub

    Private Sub rbdebito_CheckedChanged(sender As Object, e As EventArgs) Handles rbdebito.CheckedChanged
        If rbdebito.Checked = True Then
            checktpago.Visible = True
        End If
    End Sub

    Private Sub rbcredito_CheckedChanged(sender As Object, e As EventArgs) Handles rbcredito.CheckedChanged
        If rbcredito.Checked = True Then
            checktpago.Visible = True
        End If
    End Sub

    Private Sub txtimporte_TextChanged(sender As Object, e As EventArgs) Handles txtimporte.TextChanged
        If txtimporte.Text.Contains(".") Or txtimporte.Text.Contains(",") Then
            checkimporte.Visible = False
        Else
            Dim Importe As Double = Nothing
            Try
                Importe = CDbl(txtimporte.Text)
            Catch ex As Exception
                Importe = Nothing
            End Try
            If Importe > 0 Then
                If Importe < 999999 Then
                    checkimporte.Visible = True
                Else
                    checkimporte.Visible = False
                End If
            Else
                checkimporte.Visible = False
            End If
        End If

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Cancelar()
    End Sub

    Private Sub cbempleado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbempleado.SelectedIndexChanged
        If cbempleado.Text <> "" Then
            checkempleado.Visible = True
        Else
            checkempleado.Visible = False
        End If
    End Sub
End Class
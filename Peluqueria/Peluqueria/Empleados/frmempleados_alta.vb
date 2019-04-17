Public Class frmempleados_alta
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

    Private Sub btnalta_Click(sender As Object, e As EventArgs) Handles btnalta.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Registrar al Empleado?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Empleados WHERE Nombre = '" + txtnombre.Text + "'")
                If nombre = "" Then
                    If txtcontacto.Text <> "" And txtdni.Text <> "" And txtnombre.Text <> "" And txtporcen.Text <> "" Then
                        If txtporcen.Text <= 100 Then
                            Dim consulta As String = "INSERT INTO Empleados VALUES ('" + txtnombre.Text + "','" + txtdni.Text + "','" + txtcontacto.Text + "','" + txtporcen.Text + "')"
                            acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                            txtcontacto.Text = ""
                            txtdni.Text = ""
                            txtnombre.Text = ""
                            txtporcen.Text = ""
                            MsgBox("Empleado Registrado con Exito", Title:="ReDim Software")
                        Else
                            MsgBox("Porcentaje Ingresado No Valido", Title:="ReDim Software")
                        End If
                    Else
                        MsgBox("Debe Completar Todos los Campos", Title:="ReDim Software")
                    End If
                Else
                    MsgBox("Empleado ya Registrado en la Base de Datos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al registrar empleado, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
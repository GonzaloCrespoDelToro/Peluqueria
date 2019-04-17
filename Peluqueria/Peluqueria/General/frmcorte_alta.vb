Public Class frmcorte_alta
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
            If MessageBox.Show(Me, "¿Seguro que desea Registrar el Tipo de Corte?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM TipoCorte WHERE Nombre = '" + txtcorte.Text + "'")
                If nombre = "" Then
                    If txtcorte.Text <> "" And txtdescr.Text <> "" Then
                        Dim consulta As String = "INSERT INTO TipoCortes VALUES ('" + txtcorte.Text + "', '" + txtdescr.Text + "')"
                        acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                        txtcorte.Text = ""
                        txtdescr.Text = ""
                        MsgBox("Corte Registrado con Exito")
                    Else
                        MsgBox("Debe Completar todos los Campos", Title:="ReDim Software")
                    End If
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al agregar corte, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub pbmin_Click(sender As Object, e As EventArgs) Handles pbmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub
End Class
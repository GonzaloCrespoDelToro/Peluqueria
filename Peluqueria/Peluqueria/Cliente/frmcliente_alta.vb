
Public Class frmcliente_alta
    Dim acceso As New AccesoSQL
    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub

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

    Private Sub btnalta_Click(sender As Object, e As EventArgs) Handles btnalta.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Registrar el cliente?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Clientes WHERE Nombre = '" + txtnombre.Text + "'")
                If nombre = "" Then
                    If txttelefono.Text <> "" And txtnombre.Text <> "" And txttelefono.Text <> "" Then
                        Try
                            Dim consulta As String = "INSERT INTO Clientes VALUES ('" + txtnombre.Text + "', '" + txttelefono.Text + "', '" + txtdirecc.Text + "')"
                            acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                            txtdirecc.Text = ""
                            txtnombre.Text = ""
                            txttelefono.Text = ""
                            MsgBox("Cliente Registrado con exito", Title:="ReDim Software")
                        Catch ex As Exception
                        End Try
                    Else
                        MsgBox("Debe completar todo los campos", Title:="ReDim Software")
                    End If
                Else
                    MsgBox("Nombre Existente en la Base de Datos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al registrar el cliente, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
Public Class frmcorte_edit
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
    Sub cancelar()
        Try
            cmbcorte.Items.Clear()
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM TipoCortes", "Clientes")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cmbcorte.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al actualizar lista de cortes, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub
    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Eliminar el Tipo de Corte?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If cmbcorte.Text <> "" Then
                    Dim consulta As String = "DELETE FROM TipoCortes WHERE Nombre = '" + cmbcorte.Text + "'"
                    acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                    cmbcorte.Text = ""
                    cancelar()
                    MsgBox("El Corte se ha Eliminado con Exito", Title:="ReDim Software")
                Else
                    MsgBox("Debe completar todos los Campos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al borrar corte, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub pbmin_Click(sender As Object, e As EventArgs) Handles pbmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub frmcorte_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM TipoCortes", "Clientes")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cmbcorte.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
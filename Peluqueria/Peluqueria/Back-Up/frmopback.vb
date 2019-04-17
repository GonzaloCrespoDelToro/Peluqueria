Public Class frmopback
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

    'RESTORE
    'Use master
    'Alter database [pelu] Set single_user With rollback immediate
    'restore database pelu from disk = 'C:\Users\gonza\Desktop\Prueba.bak'

    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub

    Private Sub frmopback_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            txtnombre1.Text = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre From Backups_Dato")
            txtruta1.Text = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Ubicacion From Backups_Dato")
            Me.ActiveControl = txtnombre2
        Catch ex As Exception
            MsgBox("Error al visualizar nombre y ubicacion del Back-Up, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Private Sub btnbuscar_Click(sender As Object, e As EventArgs) Handles btnbuscar.Click
        Dim folder As New FolderBrowserDialog
        Dim ruta As String = String.Empty

        If folder.ShowDialog = Windows.Forms.DialogResult.OK Then
            ruta = folder.SelectedPath
            txtruta2.Text = ruta
        End If
    End Sub

    Private Sub btnactualizar_Click(sender As Object, e As EventArgs) Handles btnactualizar.Click
        Try
            If txtnombre2.Text <> "" And txtruta2.Text <> "" Then
                acceso.Ejecutar_Query("ExecuteNonQuery", "UPDATE Backups_Dato SET Nombre = '" + txtnombre2.Text + "', Ubicacion = '" + txtruta2.Text + "'")
                MsgBox("¡Ubicacion actualizada con exito!", Title:="ReDim Software")
                Me.Close()
            End If
        Catch ex As Exception
            MsgBox("Error al actualizar Back-Up, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
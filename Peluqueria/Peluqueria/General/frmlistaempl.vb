Public Class frmlistaempl
    Dim acceso As New AccesoSQL

#Region "Arrastrar Formulario"
    Dim ex, ey As Integer
    Dim Arrastre As Boolean
    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paVentana.MouseDown
        ex = e.X
        ey = e.Y
        Arrastre = True
    End Sub
    Private Sub Form1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paVentana.MouseUp
        Arrastre = False
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles paVentana.MouseMove
        If Arrastre Then Me.Location = Me.PointToScreen(New Point(Me.MousePosition.X - Me.Location.X - ex, Me.MousePosition.Y - Me.Location.Y - ey))
    End Sub
#End Region

    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub

    Private Sub frmlistaempl_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As DataSet = acceso.Consulta_DS("SELECT Nombre, DNI, Contacto, Porcentaje FROM Empleados", "Empleados")
            dgvempleados.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error al mostrar empleados, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
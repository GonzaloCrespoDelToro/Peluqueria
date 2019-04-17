Public Class frmverusu
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

    Private Sub frmverusu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim ds As DataSet = acceso.Consulta_DS("select u.nombre as Usuario, u.Contraseña, u.Admin, e.nombre as Empleado from usuarios u inner join empleados e on u.empleado = e.id", "Usuarios")
            dgvdatos.DataSource = ds.Tables(0).DefaultView
        Catch ex As Exception
            MsgBox("Error al mostrar usuarios, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
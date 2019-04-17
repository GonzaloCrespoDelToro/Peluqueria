Public Class Modificar_usu
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

    Private Sub Modificar_usu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DSu As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Usuarios", "Usuarios")
            For Each Fila As DataRow In DSu.Tables(0).Rows
                cbusuario.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al cargar datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub
    Dim idglobal As String = ""
    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        If cbusuario.Text <> "" Then
            txtpass.Enabled = True
            txtusu.Enabled = True
            cbusuario.Enabled = False
            btnseleccionar.Enabled = False
            btnborrar.Enabled = True
            btncancelar.Enabled = True
            btnmodificar.Enabled = True
            Dim consultarID As String = "SELECT ID FROM Usuarios WHERE Nombre = '" + cbusuario.Text + "'"
            Dim ID As String = acceso.Ejecutar_Query("ExecuteScalar", consultarID)
            idglobal = ID
            txtusu.Text = cbusuario.Text

            Dim consultarpass As String = "SELECT Contraseña FROM Usuarios WHERE ID = " + ID + ""
            txtpass.Text = acceso.Ejecutar_Query("ExecuteScalar", consultarpass)
        End If
    End Sub
    Sub Cancelar()
        cbusuario.Items.Clear()
        cbusuario.Text = ""
        Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Usuarios", "Usuarios")
        For Each Fila As DataRow In DS.Tables(0).Rows
            cbusuario.Items.Add(Fila.Item(0).ToString())
        Next
        txtpass.Enabled = False
        txtusu.Enabled = False

        cbusuario.Enabled = True
        btnseleccionar.Enabled = True
        btnborrar.Enabled = False
        btncancelar.Enabled = False
        btnmodificar.Enabled = False
        txtpass.Text = ""
        txtusu.Text = ""
    End Sub
    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        If MessageBox.Show(Me, "¿Seguro que desea Modificar el Usuario?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If txtusu.Text <> "" And txtpass.Text <> "" And cbusuario.Text <> "" Then
                Dim user As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Usuarios WHERE Nombre = '" + txtusu.Text + "'")
                If user = "" Or txtusu.Text = cbusuario.Text Then
                    Dim consulta As String = "UPDATE Usuarios SET Nombre = '" + txtusu.Text + "', Contraseña = '" + txtpass.Text + "' WHERE Nombre = '" + cbusuario.Text + "'"
                    acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                    Cancelar()
                    MsgBox("El Usuario ha sido Modificado con Exito", Title:="Modificar")
                Else
                    MsgBox("El Usuario ya Existe", Title:="ReDim Software")
                End If
            Else
                MsgBox("Complete Todos los Campos", Title:="ReDim Software")
            End If
        End If
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Cancelar()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        If MessageBox.Show(Me, "¿Seguro que Desea Eliminar Usuario?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
            If txtpass.Text <> "" And txtusu.Text <> "" Then
                Dim consulta As String = "DELETE FROM Usuarios WHERE ID = " + idglobal + " "
                acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                Cancelar()
                MsgBox("El Usuario ha sido Borrado con Exito", Title:="ReDim Software")
            Else
                MsgBox("Complete Todos los Campos", Title:="ReDim Software")
            End If
        End If
    End Sub
End Class
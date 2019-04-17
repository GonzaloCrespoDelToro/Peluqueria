Public Class Alta_usu
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

    Dim admin As String = ""
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Registrar este Usuario?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                Dim usuario As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Usuario WHERE Nombre = '" + txtusu.Text + "'")
                If usuario = "" Then
                    If cbempleados.Text <> "" And txtpass.Text <> "" And txtusu.Text <> "" Then
                        If chadmin.Checked = True Then
                            admin = "1"
                        Else
                            admin = "0"
                        End If
                        Dim ID As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT ID FROM Empleados WHERE Nombre = '" + cbempleados.Text + "'")
                        Dim consulta As String = "INSERT INTO Usuarios VALUES ('" + txtusu.Text + "', '" + txtpass.Text + "','" + admin + "','" + ID + "')"
                        acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                        txtpass.Text = ""
                        txtusu.Text = ""
                        chadmin.Checked = False
                        cbempleados.Text = ""
                        MsgBox("Usuario Registrado con Exito")
                    Else
                        MsgBox("Debe Completar Todos los Campos", Title:="ReDim Software")
                    End If
                Else
                    MsgBox("Nombre de Usuario ya Existe", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al registrar usuario, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub Alta_usu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cbempleados.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
End Class
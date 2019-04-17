Public Class frmempleados_edit
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

    Sub Cancelar()
        Try
            cbempleado.Items.Clear()
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cbempleado.Items.Add(Fila.Item(0).ToString())
            Next
            txtcontacto.Enabled = False
            txtdni.Enabled = False
            txtnombre.Enabled = False
            txtporcentaje.Enabled = False
            cbempleado.Enabled = True
            btnseleccionar.Enabled = True
            btnborrar.Enabled = False
            btncancelar.Enabled = False
            btnmodificar.Enabled = False
            txtcontacto.Text = ""
            txtdni.Text = ""
            txtporcentaje.Text = ""
            txtnombre.Text = ""
            cbempleado.Text = ""
        Catch ex As Exception
            MsgBox("Error al cancelar, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Dim idglobal As String

    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Try
            Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Empleados WHERE Nombre = '" + cbempleado.Text + "'")
            If nombre <> "" Then
                txtnombre.Enabled = True
                txtcontacto.Enabled = True
                txtdni.Enabled = True
                txtporcentaje.Enabled = True
                cbempleado.Enabled = False
                btnseleccionar.Enabled = False
                btnborrar.Enabled = True
                btncancelar.Enabled = True
                btnmodificar.Enabled = True
                Dim consultarID As String = "SELECT ID FROM Empleados WHERE Nombre = '" + cbempleado.Text + "'"
                Dim ID As String = acceso.Ejecutar_Query("ExecuteScalar", consultarID)
                idglobal = ID
                txtnombre.Text = cbempleado.Text

                Dim consultarc As String = "SELECT Contacto FROM Empleados WHERE ID = " + ID + ""
                txtcontacto.Text = acceso.Ejecutar_Query("ExecuteScalar", consultarc)

                Dim consultarDNI As String = "SELECT DNI FROM Empleados WHERE ID = " + ID + ""
                txtdni.Text = acceso.Ejecutar_Query("ExecuteScalar", consultarDNI)

                Dim consultarPor As String = "SELECT Porcentaje FROM Empleados WHERE ID = " + ID + ""
                txtporcentaje.Text = acceso.Ejecutar_Query("ExecuteScalar", consultarPor)
            Else
                MsgBox("El Cliente Seleccionado no Existe en la Base de Datos", Title:="ReDim Software")
            End If
        Catch ex As Exception
            MsgBox("Error al seleccionar un empleado, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Private Sub frmempleados_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Empleados", "Empleados")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cbempleado.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Cancelar()
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea eliminar al Empleado?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If txtcontacto.Text <> "" And txtdni.Text <> "" And txtnombre.Text <> "" And txtporcentaje.Text <> "" Then
                    Dim consulta As String = "DELETE FROM Empleados WHERE ID = " + idglobal + " "
                    acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                    Cancelar()
                    MsgBox("El Empleado ha sido Borrado con Exito", Title:="ReDim Software")
                Else
                    MsgBox("Complete Todos los Campos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al borrar empleado, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Modificar al Empleado?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If txtcontacto.Text <> "" And txtdni.Text <> "" And txtnombre.Text <> "" And txtporcentaje.Text <> "" Then
                    Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Empleado WHERE Nombre = '" + txtnombre.Text + "'")
                    If nombre = "" Or txtnombre.Text = cbempleado.Text Then
                        Dim consulta As String = "UPDATE Empleados SET Nombre = '" + txtnombre.Text + "', DNI = '" + txtdni.Text + "', Contacto = '" + txtcontacto.Text + "', Porcentaje= '" + txtporcentaje.Text + "' WHERE ID = '" + idglobal + "'"
                        acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                        Cancelar()
                        MsgBox("El Empleado ha sido Modificado con Exito", Title:="ReDim Software")
                    Else
                        MsgBox("El Nombre ya Existe", Title:="ReDim Software")
                    End If
                Else
                    MsgBox("Complete Todos los Campos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al modificar empleado, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub
End Class
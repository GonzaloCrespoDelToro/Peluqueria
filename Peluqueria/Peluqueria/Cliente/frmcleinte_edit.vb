Public Class frmcleinte_edit
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

    Sub Cancelar()
        Try
            cbcliente.Items.Clear()
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Clientes", "Clientes")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cbcliente.Items.Add(Fila.Item(0).ToString())
            Next
            txtcontacto.Enabled = False
            txtdireccion.Enabled = False
            txtnombre.Enabled = False
            cbcliente.Enabled = True
            btnseleccionar.Enabled = True
            btnborrar.Enabled = False
            btncancelar.Enabled = False
            btnmodificar.Enabled = False
            txtcontacto.Text = ""
            txtdireccion.Text = ""
            txtnombre.Text = ""
            cbcliente.Text = ""
        Catch ex As Exception
            MsgBox("Error al cancelar, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub
    Private Sub frmcleinte_edit_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            Dim DS As DataSet = acceso.Consulta_DS("SELECT Nombre FROM Clientes", "Clientes")
            For Each Fila As DataRow In DS.Tables(0).Rows
                cbcliente.Items.Add(Fila.Item(0).ToString())
            Next
        Catch ex As Exception
            MsgBox("Error al cargar los datos, por favor reinicie la ventana", Title:="ReDim Software")
        End Try


    End Sub
    Dim IDglobal As String
    Private Sub btnaceptar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Try
            Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Clientes WHERE Nombre = '" + cbcliente.Text + "'")
            If nombre <> "" Then
                txtcontacto.Enabled = True
                txtdireccion.Enabled = True
                txtnombre.Enabled = True
                cbcliente.Enabled = False
                btnseleccionar.Enabled = False
                btnborrar.Enabled = True
                btncancelar.Enabled = True
                btnmodificar.Enabled = True
                Dim consultarID As String = "SELECT ID FROM Clientes WHERE Nombre = '" + cbcliente.Text + "'"
                Dim ID As String = acceso.Ejecutar_Query("ExecuteScalar", consultarID)
                IDglobal = ID
                txtnombre.Text = cbcliente.Text

                Dim consultarC As String = "SELECT Contacto FROM Clientes WHERE ID = " + ID + ""
                txtcontacto.Text = acceso.Ejecutar_Query("ExecuteScalar", consultarC)

                Dim consultarD As String = "SELECT Direccion FROM Clientes WHERE ID = " + ID + ""
                txtdireccion.Text = acceso.Ejecutar_Query("ExecuteScalar", consultarD)
            Else
                MsgBox("El Cliente Seleccionado no Existe en la Base de Datos", Title:="ReDim Software")
            End If
        Catch ex As Exception
            MsgBox("Error al seleccionar cliente, por favor reinicie la ventana", Title:="ReDim Software")
        End Try
    End Sub

    Private Sub btnborrar_Click(sender As Object, e As EventArgs) Handles btnborrar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea eliminar el cliente?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If txtcontacto.Text <> "" And txtdireccion.Text <> "" And txtnombre.Text <> "" Then
                    Dim consulta As String = "DELETE FROM Clientes WHERE ID = " + IDglobal + " "
                    acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                    Cancelar()
                    MsgBox("El Cliente ha sido Borrado con Exito", Title:="ReDim Software")
                Else
                    MsgBox("Complete Todos los Campos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al borrar cliente, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Private Sub btnmodificar_Click(sender As Object, e As EventArgs) Handles btnmodificar.Click
        Try
            If MessageBox.Show(Me, "¿Seguro que desea Modificar el cliente?", "ReDim Software", MessageBoxButtons.YesNo) = DialogResult.Yes Then
                If txtcontacto.Text <> "" And txtdireccion.Text <> "" And txtnombre.Text <> "" Then
                    Dim nombre As String = acceso.Ejecutar_Query("ExecuteScalar", "SELECT Nombre FROM Clientes WHERE Nombre = '" + txtnombre.Text + "'")
                    If nombre = "" Or txtnombre.Text = cbcliente.Text Then
                        Dim consulta As String = "UPDATE Clientes SET Nombre = '" + txtnombre.Text + "', Contacto = '" + txtcontacto.Text + "', Direccion = '" + txtdireccion.Text + "' WHERE ID = '" + IDglobal + "'"
                        acceso.Ejecutar_Query("ExecuteNonQuery", consulta)
                        Cancelar()
                        MsgBox("El Cliente ha sido Modificado con Exito", Title:="Modificar")
                    Else
                        MsgBox("El Nombre ya Existe", Title:="ReDim Software")
                    End If
                Else
                    MsgBox("Complete Todos los Campos", Title:="ReDim Software")
                End If
            End If
        Catch ex As Exception
            MsgBox("Error al modificar cliente, por favor reinicie la ventana", Title:="ReDim Software")
        End Try

    End Sub

    Private Sub btncancelar_Click(sender As Object, e As EventArgs) Handles btncancelar.Click
        Cancelar()
    End Sub
End Class
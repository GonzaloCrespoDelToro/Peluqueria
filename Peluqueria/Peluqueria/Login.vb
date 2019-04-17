Public Class Login
    Dim acceso As New AccesoSQL
    Public usuario As String = ""
    'ARREGLAR CERRAR SESION Y ABRIR UNA NUEVA
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
    Sub Ingresar()
        If txtusu.Text <> "" And txtpass.Text <> "" Then
            Dim consultarusu As String = "SELECT Nombre FROM Usuarios WHERE Nombre = '" + txtusu.Text + "'"
            If acceso.Ejecutar_Query("ExecuteScalar", consultarusu) = txtusu.Text Then
                If acceso.Ejecutar_Query("ExecuteScalar", "SELECT Contraseña FROM Usuarios WHERE Nombre = '" + txtusu.Text + "'") = txtpass.Text Then
                    usuario = txtusu.Text
                    txtusu.Text = ""
                    txtpass.Text = ""
                    MenuPrin.Show()
                    Me.Hide()
                    MenuPrin.cerrar = False
                Else
                    MsgBox("Contraseña Incorrecta", Title:="ReDim Software")
                End If
            Else
                MsgBox("Usuario Incorrecto", Title:="ReDim Software")
            End If
        Else
            MsgBox("Por Favor Ingrese Usuario y Contraseña", Title:="ReDim Software")
        End If
    End Sub

    Private Sub btningresar_Click(sender As Object, e As EventArgs) Handles btningresar.Click
        Ingresar()
    End Sub

    Private Sub pbx_Click_1(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub
    Private Sub pbmin_Click_1(sender As Object, e As EventArgs) Handles pbmin.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub txtpass_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtpass.KeyPress
        Dim key As Short = CShort(Asc(e.KeyChar))
        If key = 13 Then
            e.Handled = True
            Ingresar()
        End If

    End Sub
    Private Sub txtusu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtusu.KeyPress
        Dim key As Short = CShort(Asc(e.KeyChar))
        If key = 13 Then
            e.Handled = True
            Ingresar()
        End If
    End Sub


End Class
Public Class frmconfback

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

    Dim back As Boolean = False
    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub

    Private Sub btnsi_Click(sender As Object, e As EventArgs) Handles btnsi.Click
        MenuPrin.timeback(True)
        back = True
        Me.Close()
    End Sub

    Private Sub btnno_Click(sender As Object, e As EventArgs) Handles btnno.Click
        Me.Close()
    End Sub

    Private Sub frmconfback_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub frmconfback_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Try
            If back = True Then
                MenuPrin.gerenarbackup()
            End If
        Catch ex As Exception
            MsgBox("Error al Generar el Back-Up", Title:="ReDim Software")
        End Try

    End Sub
End Class
Public Class frmfecha
    Private Sub pbx_Click(sender As Object, e As EventArgs) Handles pbx.Click
        Me.Close()
    End Sub
    Private Sub btnseleccionar_Click(sender As Object, e As EventArgs) Handles btnseleccionar.Click
        Dim Fecha As String = CStr(dtfecha.Value.Date)
        Dim myCulture As System.Globalization.CultureInfo = Globalization.CultureInfo.CurrentCulture
        Dim dayOfWeek As DayOfWeek = myCulture.Calendar.GetDayOfWeek(CDate(Fecha))
        Dim dayName As String = myCulture.DateTimeFormat.GetDayName(dayOfWeek)
        MenuPrin.lbldia1.Text = StrConv(dayName.ToLower, VbStrConv.ProperCase)
        MenuPrin.lbldia.Text = Fecha
        MenuPrin.Cargar_Calendario(Fecha)
        Me.Close()
    End Sub

End Class
Imports System.Data.SqlClient
Public Class AccesoSQL
    Dim ComBuilder As SqlCommandBuilder
    Dim DataAdapter As SqlDataAdapter
    Dim DataSet As DataSet
    Shared Conexion As String = "Data Source=DESKTOP-D15UR91\ALLEDA;Initial Catalog=Pelu;Integrated Security=True"
    Dim SQLCON As SqlConnection



    Private Function Conectar() As Boolean
        SQLCON = New SqlConnection(Conexion)
        Try
            If SQLCON.State = ConnectionState.Closed Then
                SQLCON.Open()
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Private Function Desconectar() As Boolean
        Try
            If SQLCON.State = ConnectionState.Open Then
                SQLCON.Close()
                Return True
            Else
                Return True
            End If
        Catch ex As Exception
            Return False
        End Try
    End Function

    Public Function Consulta_DS(ByVal Consulta As String, Tabla As String) As DataSet
        Try
            Conectar()
            DataSet = New DataSet("DVH")
            DataAdapter = New SqlDataAdapter(Consulta, Conexion)
            ComBuilder = New SqlCommandBuilder(DataAdapter)
            DataAdapter.Fill(DataSet, Tabla)
            Desconectar()
            Return DataSet
        Catch ex As Exception
            Return Nothing
        End Try
    End Function


    Public Function Ejecutar_Query(ByVal Tipo As String, Consulta As String) As String
        Try
            Dim CMD As New SqlCommand
            With CMD
                Conectar()
                .Connection = SQLCON
                .CommandType = CommandType.Text
                .CommandText = Consulta
                Dim Valor As String = ""
                If Tipo = "ExecuteScalar" Then
                    Valor = .ExecuteScalar
                ElseIf Tipo = "ExecuteNonQuery" Then
                    Valor = .ExecuteNonQuery
                End If
                Desconectar()
                Return Valor
            End With
        Catch ex As Exception
            Desconectar()
            Return ""
        End Try
    End Function

    Function GridAExcel(ByVal ElGrid As DataGridView) As Boolean
        'Creamos las variables
        Dim exApp As New Microsoft.Office.Interop.Excel.Application
        Dim exLibro As Microsoft.Office.Interop.Excel.Workbook
        Dim exHoja As Microsoft.Office.Interop.Excel.Worksheet
        Try
            'Añadimos el Libro al programa, y la hoja al libro
            exLibro = exApp.Workbooks.Add
            exHoja = exLibro.Worksheets.Add()
            ' ¿Cuantas columnas y cuantas filas?
            Dim NCol As Integer = ElGrid.ColumnCount
            Dim NRow As Integer = ElGrid.RowCount
            'Aqui recorremos todas las filas, y por cada fila todas las columnas y vamos escribiendo.
            For i As Integer = 1 To NCol
                exHoja.Cells.Item(1, i) = ElGrid.Columns(i - 1).Name.ToString
                'exHoja.Cells.Item(1, i).HorizontalAlignment = 3
            Next
            For Fila As Integer = 0 To NRow - 1
                For Col As Integer = 0 To NCol - 1
                    exHoja.Cells.Item(Fila + 2, Col + 1) = ElGrid.Rows(Fila).Cells(Col).Value
                Next
            Next
            'Titulo en negrita, Alineado al centro y que el tamaño de la columna se ajuste al texto
            exHoja.Rows.Item(1).Font.Bold = 1
            exHoja.Rows.Item(1).HorizontalAlignment = 3
            exHoja.Columns.AutoFit()
            'Aplicación visible
            exApp.Application.Visible = True
            exHoja = Nothing
            exLibro = Nothing
            exApp = Nothing
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical, "Error al exportar a Excel")
            Return False
        End Try
        Return True
    End Function

End Class


Imports System.Data ' importar bibliotecas y clases para ado.net
Imports System.Data.SqlClient 'biblioteca en clases para sql server and ado.net



Public Class db_conexion
    Dim mconexion = New SqlConnection 'coneccion a bd
    Dim mcomandos = New SqlCommand 'ejecucion de consultas
    Dim madapter = New SqlDataAdapter 'intermediario entre fuente y app
    Dim ds As New DataSet 'representa una copia de la arquitectura



    Public Sub New()

        Dim cconexion As String
        cconexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database1.mdf;Integrated Security=True"
        mconexion.ConnectionString = cconexion

        mconexion.Open()
    End Sub

    Public Function obtenerdata()
        ds.Clear()
        mcomandos.connection = mconexion

        mcomandos.CommandText = "select * from proveedores"
        madapter.SelectCommand = mcomandos
        madapter.fill(ds, "proveedores")
        Return ds

    End Function


End Class

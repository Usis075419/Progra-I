Imports System.Data ' importar bibliotecas y clases para ado.net
Imports System.Data.SqlClient 'biblioteca en clases para sql server and ado.net

Public Class db_conexion
    Dim mconexion As New SqlConnection 'coneccion a bd
    Dim mcomandos As New SqlCommand 'ejecucion de consultas
    Dim madapter As New SqlDataAdapter 'intermediario entre fuente y app
    Dim ds As New DataSet 'representa una copia de la arquitectura

    Public Sub New()
        Dim cconexion As String
        cconexion = "Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Database2.mdf;Integrated Security=True"
        mconexion.ConnectionString = cconexion
        mconexion.Open()
    End Sub

    Private Function executeSql(ByVal sql As String)
        mcomandos.Connection = mconexion
        mcomandos.CommandText = sql
        Return mcomandos.ExecuteNonQuery()
    End Function
    Public Function obtenerdata()
        ds.Clear()
        mcomandos.Connection = mconexion

        mcomandos.CommandText = "select * from proveedor"
        madapter.SelectCommand = mcomandos
        madapter.Fill(ds, "proveedor")


        mcomandos.CommandText = "select * from NEWUSER"
        madapter.SelectCommand = mcomandos
        madapter.Fill(ds, "NEWUSER")

        mcomandos.CommandText = "select * from ingresos"
        madapter.SelectCommand = mcomandos
        madapter.Fill(ds, "ingresos")
        Return ds
    End Function












    Public Function proveedortabla(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO proveedor (nombre,pais,telefono,correo,direccion,giro) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "','" + datos(5) + "','" + datos(6) + "')"
            Case "modificar"
                sql = "UPDATE proveedor SET nombre='" + datos(1) + "',pais='" + datos(2) + "',telefono='" + datos(3) + "',correo='" + datos(4) + "',direccion='" + datos(5) + "' WHERE idproveedro='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM proveedor WHERE idproveedro='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function






    Public Function newusertabla(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO NEWUSER (nombre,sucursal,contraseña) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "')"
            Case "modificar"
                sql = "UPDATE NEWUSER SET idempleado='" + datos(1) + "',nombre='" + datos(2) + "',sucursal='" + datos(3) + "',nombre='" + datos(4) + "' WHERE idempleado='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM NEWUSER WHERE idempleado='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
    Public Function ningresostabla(ByVal datos As String(), ByVal cambio As String)
        Dim sql, msg As String
        Select Case cambio
            Case "nuevo"
                sql = "INSERT INTO ingresos (producto,fecha,proveedor,productouni) VALUES('" + datos(1) + "','" + datos(2) + "','" + datos(3) + "','" + datos(4) + "')"
            Case "modificar"
                sql = "UPDATE ingresos SET producto='" + datos(1) + "',fecha='" + datos(2) + "',proveedor='" + datos(3) + "',productouni='" + datos(4) + "' WHERE id='" + datos(0) + "'"
            Case "eliminar"
                sql = "DELETE FROM ingresos WHERE id='" + datos(0) + "'"
        End Select
        If (executeSql(sql) > 0) Then
            msg = "exito"
        Else
            msg = "error"
        End If

        Return msg
    End Function
End Class
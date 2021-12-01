Imports System.Data.Odbc

Module Module1

    Public cnn As OdbcConnection
    Public cmd As OdbcCommand
    Public rs As OdbcDataReader
    Public rs1 As OdbcDataReader
    Public rs3 As OdbcDataReader
    Public sql As String           
    Public x As Integer
    Public Monto As Double
   
    Public Function conectar()
        Try

            cnn = New OdbcConnection("DSN=Klaer")
            cnn.Open()
            MsgBox("Conexión exitosa", , "Estado")

        Catch ex As Exception

            MsgBox("Conexión Fallida" & vbNewLine & ex.ToString(), , "Estado")

        End Try
        Return 0
    End Function

    Public Sub Proc(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs = cmd.ExecuteReader
        cmd.Dispose()

    End Sub

    Public Sub Proc1(ByVal sql As String)

        cmd = New OdbcCommand(sql, cnn)
        cmd.CommandType = CommandType.Text
        rs1 = cmd.ExecuteReader
        cmd.Dispose()

    End Sub
End Module

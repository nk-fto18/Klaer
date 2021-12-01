Public Class frmInicio

    Private Sub btnSalir_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSalir.Click
        Me.Close()

    End Sub

    Private Sub btnCompra_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCompra.Click
        Me.Hide()
        frmCompra.Show()
    End Sub

    Private Sub btnIngreso_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnIngreso.Click
        Me.Hide()
        frmIngreso.Show()
    End Sub

    Private Sub btnDevolucion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnDevolucion.Click
        Me.Hide()
        frmDevoluciones.Show()
    End Sub

    Private Sub frmInicio_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Call conectar()
    End Sub

    Private Sub btnCriterios_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnCriterios.Click
        Me.Hide()
        frmCriterios.Show()
    End Sub
End Class

Public Class frmIngreso

    Private Sub btnVolver1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver1.Click
        Me.Close()
        frmInicio.Show()
    End Sub


    Private Sub btnaceptar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnaceptar.Click
        If Txttipo.Text <> "" And txtcant.Text <> "" Then
            sql = ("Update items set cantidad = cantidad + '" & txtcant.Text & "' Where tipo = '" & Txttipo.Text & "' ")
            Proc(sql)

            MsgBox("Ingreso Exitoso")
            Me.Close()
            frmInicio.Show()
        End If

    End Sub



    Private Sub btnVolveremos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolveremos.Click
        Me.Hide()
        frmInicio.Show()
    End Sub
End Class
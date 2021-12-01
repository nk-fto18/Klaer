Public Class frmDevoluciones

    Private Sub btnVolver2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver2.Click
        Me.Close()
        frmInicio.Show()
    End Sub

    Private Sub btnverif_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)


        If (txtrecibo.Text <> "") Then
            sql = "select IDRecibo from recibo where numeroRecibo = '" & txtrecibo.Text & "' "
            Proc(sql)

            
        Else
            MsgBox("Complete los campos vacios.")
        End If

    End Sub

    Private Sub btncambio_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btncambio.Click

        If (txtrecibo.Text <> "" And cmbMotivo.SelectedItem <> "") Then
            sql = ("Select count(*) from recibo where idrecibo = '" & txtrecibo.Text & "' ")
            Proc(sql)
            rs.Read()

            If rs(0) <> 0 Then

                sql = ("Insert into Devolucion Values('', '" & txtrecibo.Text & "', '" & cmbMotivo.SelectedItem & "', Curdate() )")
                Proc(sql)
                MsgBox("Devolucion Exitosa")

            Else

                MsgBox("El NroRecibo No existe")

            End If





        Else
            MsgBox("Complete los campos vacios")
        End If
    End Sub



    Private Sub frmDevoluciones_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class
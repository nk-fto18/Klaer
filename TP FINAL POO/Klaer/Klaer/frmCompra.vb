Public Class frmCompra
 

    Private Sub btnVolver_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnVolver.Click
        Me.Close()
        frmInicio.Show()
    End Sub


    Private Sub btnagregar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnagregar.Click
        If txtCant.Text <> "" And cmbItems.SelectedItem <> "" Then

            lstcompra.Items.Add(cmbItems.SelectedItem)
            lstCant.Items.Add(txtCant.Text)

            

        Else
            MsgBox("No haz seleccionado nada")
        End If

        cmbItems.Text = ""
        txtCant.Text = ""

    End Sub

    Private Sub btnfin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnfin.Click
       

        Dim DniNuevo As String
        Dim NomNuevo As String
        Dim DireNuevo As String



            If (txtdni.Text <> "") Then

            sql = ("select count(*) from cliente where DNI = '" & txtdni.Text & "'")
            Proc(sql)
            rs.Read()

            If rs(0) > 0 Then
                MsgBox("Sos Cliente! ")
            Else
                MsgBox("No Sos Cliente !")
                DniNuevo = InputBox("Nombre: ", "Ingreso")
                NomNuevo = InputBox("Telefono: ", "Ingreso")
                DireNuevo = InputBox("Domicilio: ", "Ingreso")

                sql = ("Insert into Cliente values ('', '" & txtdni.Text & "', '" & DniNuevo & "', '" & NomNuevo & "', '" & DireNuevo & "')")
                Proc(sql)
                MsgBox("Cliente Ingresado")


            End If

            sql = ("Select idcliente from cliente where Dni = '" & txtdni.Text & "'")
            Proc1(sql)
            rs1.Read()

            sql = ("Insert into pedidos values('', '" & rs1(0) & "')")
            Proc(sql)

            For i As Integer = 0 To lstcompra.Items.Count - 1
               

                sql = ("Select max(idPedido) from pedidos")
                Proc(sql)
                rs.Read()

                sql = ("select idproducto from items where tipo = '" & lstcompra.Items(i).ToString & "'")
                Proc1(sql)
                rs1.Read()

                sql = ("insert into detalle Values('', '" & rs(0) & "', '" & rs1(0) & "', '" & lstCant.Items(i) & "')")
                Proc(sql)

                sql = ("select precio from items where idproducto  = '" & rs1(0) & "' ")
                Proc(sql)
                rs.Read()
                Monto = Monto + (rs(0) * lstCant.Items(i))

                sql = ("Update items set cantidad = Cantidad - '" & lstCant.Items(i) & "' Where idProducto = '" & rs1(0) & "' ")
                Proc(sql)
            Next
                Me.Hide()
                frmRecibo.Show()

            Else
                MsgBox("No haz seleccionado nada")
            End If




    End Sub


    Private Sub lblitem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lblitem.Click

    End Sub
End Class
Public Class frmRecibo


    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If cmbFormaPago.SelectedItem <> "" Then

            sql = "select max(IDPedido) from pedidos"
            Proc(sql)
            rs.Read()

            sql = ("Select sum(cantidad) from detalle where idPedido = '" & rs(0) & "' ")
            Proc1(sql)
            rs1.Read()

            sql = ("Insert into recibo Values('', '" & rs(0) & "', '" & cmbFormaPago.SelectedItem.ToString & "', '" & rs1(0) & "', Curdate(), Date_Add(Curdate(), Interval 14 Day))")
            Proc1(sql)

            sql = ("Select Max(idrecibo) from recibo")
            Proc1(sql)
            rs1.Read()

            lstRecibo.Items.Add("Recibo: " & rs1(0))
            lstRecibo.Items.Add("Nro Pedido: " & rs(0))
            lstRecibo.Items.Add("Monto: " & Monto)
            lstRecibo.Items.Add("Forma de Pago: " & cmbFormaPago.SelectedItem.ToString)
            sql = ("Select sum(cantidad) from detalle where idPedido = '" & rs(0) & "' ")
            Proc1(sql)
            rs1.Read()
            lstRecibo.Items.Add("Cantidad Total: " & rs1(0))


        End If

    End Sub

 
    Private Sub frmRecibo_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load
        txtTotal.Text = Monto
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Hide()
        frmInicio.Show()
    End Sub
End Class
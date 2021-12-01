<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmDevoluciones
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmDevoluciones))
        Me.btnVolver2 = New System.Windows.Forms.Button()
        Me.lblrecibo = New System.Windows.Forms.Label()
        Me.txtrecibo = New System.Windows.Forms.TextBox()
        Me.lblmotivo = New System.Windows.Forms.Label()
        Me.btncambio = New System.Windows.Forms.Button()
        Me.cmbMotivo = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'btnVolver2
        '
        Me.btnVolver2.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnVolver2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver2.Location = New System.Drawing.Point(310, 97)
        Me.btnVolver2.Name = "btnVolver2"
        Me.btnVolver2.Size = New System.Drawing.Size(45, 23)
        Me.btnVolver2.TabIndex = 5
        Me.btnVolver2.Text = "Volver"
        Me.btnVolver2.UseVisualStyleBackColor = False
        '
        'lblrecibo
        '
        Me.lblrecibo.AutoSize = True
        Me.lblrecibo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblrecibo.Location = New System.Drawing.Point(12, 20)
        Me.lblrecibo.Name = "lblrecibo"
        Me.lblrecibo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblrecibo.Size = New System.Drawing.Size(142, 19)
        Me.lblrecibo.TabIndex = 6
        Me.lblrecibo.Tag = ""
        Me.lblrecibo.Text = "Número de recibo:"
        '
        'txtrecibo
        '
        Me.txtrecibo.Location = New System.Drawing.Point(160, 20)
        Me.txtrecibo.Name = "txtrecibo"
        Me.txtrecibo.Size = New System.Drawing.Size(195, 20)
        Me.txtrecibo.TabIndex = 7
        '
        'lblmotivo
        '
        Me.lblmotivo.AutoSize = True
        Me.lblmotivo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lblmotivo.Location = New System.Drawing.Point(12, 54)
        Me.lblmotivo.Name = "lblmotivo"
        Me.lblmotivo.Size = New System.Drawing.Size(62, 19)
        Me.lblmotivo.TabIndex = 9
        Me.lblmotivo.Text = "Motivo:"
        '
        'btncambio
        '
        Me.btncambio.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btncambio.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btncambio.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btncambio.Location = New System.Drawing.Point(16, 91)
        Me.btncambio.Name = "btncambio"
        Me.btncambio.Size = New System.Drawing.Size(254, 28)
        Me.btncambio.TabIndex = 11
        Me.btncambio.Text = "Realizar cambio"
        Me.btncambio.UseVisualStyleBackColor = False
        '
        'cmbMotivo
        '
        Me.cmbMotivo.FormattingEnabled = True
        Me.cmbMotivo.Items.AddRange(New Object() {"No le agrado la prenda", "Se rompio el cierre", "No le queda", "Quiere cambiar la prenda"})
        Me.cmbMotivo.Location = New System.Drawing.Point(80, 52)
        Me.cmbMotivo.Name = "cmbMotivo"
        Me.cmbMotivo.Size = New System.Drawing.Size(275, 21)
        Me.cmbMotivo.TabIndex = 12
        '
        'frmDevoluciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(367, 132)
        Me.Controls.Add(Me.cmbMotivo)
        Me.Controls.Add(Me.btncambio)
        Me.Controls.Add(Me.lblmotivo)
        Me.Controls.Add(Me.txtrecibo)
        Me.Controls.Add(Me.lblrecibo)
        Me.Controls.Add(Me.btnVolver2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmDevoluciones"
        Me.Text = "Klaer: Devoluciones"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver2 As System.Windows.Forms.Button
    Friend WithEvents lblrecibo As System.Windows.Forms.Label
    Friend WithEvents txtrecibo As System.Windows.Forms.TextBox
    Friend WithEvents lblmotivo As System.Windows.Forms.Label
    Friend WithEvents btncambio As System.Windows.Forms.Button
    Friend WithEvents cmbMotivo As System.Windows.Forms.ComboBox
End Class

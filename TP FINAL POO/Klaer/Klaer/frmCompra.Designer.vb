<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCompra
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCompra))
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.lblitem = New System.Windows.Forms.Label()
        Me.lblcant = New System.Windows.Forms.Label()
        Me.txtCant = New System.Windows.Forms.TextBox()
        Me.txtdni = New System.Windows.Forms.TextBox()
        Me.lbldni = New System.Windows.Forms.Label()
        Me.btnfin = New System.Windows.Forms.Button()
        Me.btnagregar = New System.Windows.Forms.Button()
        Me.lstcompra = New System.Windows.Forms.ListBox()
        Me.cmbItems = New System.Windows.Forms.ComboBox()
        Me.lstCant = New System.Windows.Forms.ListBox()
        Me.lblcliente = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnVolver
        '
        Me.btnVolver.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnVolver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver.Location = New System.Drawing.Point(318, 287)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(45, 23)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver"
        Me.btnVolver.UseVisualStyleBackColor = False
        '
        'lblitem
        '
        Me.lblitem.AutoSize = True
        Me.lblitem.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblitem.Location = New System.Drawing.Point(15, 13)
        Me.lblitem.Name = "lblitem"
        Me.lblitem.Size = New System.Drawing.Size(138, 19)
        Me.lblitem.TabIndex = 5
        Me.lblitem.Text = "Tipo de prenda:"
        '
        'lblcant
        '
        Me.lblcant.AutoSize = True
        Me.lblcant.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcant.Location = New System.Drawing.Point(199, 13)
        Me.lblcant.Name = "lblcant"
        Me.lblcant.Size = New System.Drawing.Size(88, 19)
        Me.lblcant.TabIndex = 9
        Me.lblcant.Text = "Cantidad:"
        '
        'txtCant
        '
        Me.txtCant.Location = New System.Drawing.Point(204, 35)
        Me.txtCant.Name = "txtCant"
        Me.txtCant.Size = New System.Drawing.Size(119, 20)
        Me.txtCant.TabIndex = 10
        '
        'txtdni
        '
        Me.txtdni.Location = New System.Drawing.Point(19, 256)
        Me.txtdni.Name = "txtdni"
        Me.txtdni.Size = New System.Drawing.Size(119, 20)
        Me.txtdni.TabIndex = 12
        '
        'lbldni
        '
        Me.lbldni.AutoSize = True
        Me.lbldni.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.lbldni.Location = New System.Drawing.Point(15, 234)
        Me.lbldni.Name = "lbldni"
        Me.lbldni.Size = New System.Drawing.Size(96, 19)
        Me.lbldni.TabIndex = 18
        Me.lbldni.Text = "Documento:"
        '
        'btnfin
        '
        Me.btnfin.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnfin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnfin.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfin.Location = New System.Drawing.Point(204, 287)
        Me.btnfin.Name = "btnfin"
        Me.btnfin.Size = New System.Drawing.Size(108, 23)
        Me.btnfin.TabIndex = 22
        Me.btnfin.Text = "Siguiente"
        Me.btnfin.UseVisualStyleBackColor = False
        '
        'btnagregar
        '
        Me.btnagregar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnagregar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnagregar.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.btnagregar.Location = New System.Drawing.Point(19, 158)
        Me.btnagregar.Name = "btnagregar"
        Me.btnagregar.Size = New System.Drawing.Size(343, 32)
        Me.btnagregar.TabIndex = 6
        Me.btnagregar.Text = "Agregar"
        Me.btnagregar.UseVisualStyleBackColor = False
        '
        'lstcompra
        '
        Me.lstcompra.FormattingEnabled = True
        Me.lstcompra.Location = New System.Drawing.Point(19, 62)
        Me.lstcompra.Name = "lstcompra"
        Me.lstcompra.Size = New System.Drawing.Size(159, 82)
        Me.lstcompra.TabIndex = 23
        '
        'cmbItems
        '
        Me.cmbItems.FormattingEnabled = True
        Me.cmbItems.Items.AddRange(New Object() {"Zapatilla", "Remera", "Zapato", "Chomba", "Camisa", "Jean", "Joggin", "Short de Jean", "Tacon", "Vestido"})
        Me.cmbItems.Location = New System.Drawing.Point(19, 35)
        Me.cmbItems.Name = "cmbItems"
        Me.cmbItems.Size = New System.Drawing.Size(134, 21)
        Me.cmbItems.TabIndex = 24
        '
        'lstCant
        '
        Me.lstCant.FormattingEnabled = True
        Me.lstCant.Location = New System.Drawing.Point(204, 62)
        Me.lstCant.Name = "lstCant"
        Me.lstCant.Size = New System.Drawing.Size(159, 82)
        Me.lstCant.TabIndex = 25
        '
        'lblcliente
        '
        Me.lblcliente.AutoSize = True
        Me.lblcliente.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliente.Location = New System.Drawing.Point(15, 205)
        Me.lblcliente.Name = "lblcliente"
        Me.lblcliente.Size = New System.Drawing.Size(67, 19)
        Me.lblcliente.TabIndex = 8
        Me.lblcliente.Text = "Cliente"
        '
        'frmCompra
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(380, 321)
        Me.Controls.Add(Me.lstCant)
        Me.Controls.Add(Me.cmbItems)
        Me.Controls.Add(Me.lstcompra)
        Me.Controls.Add(Me.btnfin)
        Me.Controls.Add(Me.lbldni)
        Me.Controls.Add(Me.txtdni)
        Me.Controls.Add(Me.txtCant)
        Me.Controls.Add(Me.lblcant)
        Me.Controls.Add(Me.lblcliente)
        Me.Controls.Add(Me.btnagregar)
        Me.Controls.Add(Me.lblitem)
        Me.Controls.Add(Me.btnVolver)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCompra"
        Me.Text = "Klaer: Compras"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver As System.Windows.Forms.Button
    Friend WithEvents lblitem As System.Windows.Forms.Label
    Friend WithEvents lblcant As System.Windows.Forms.Label
    Friend WithEvents txtCant As System.Windows.Forms.TextBox
    Friend WithEvents txtdni As System.Windows.Forms.TextBox
    Friend WithEvents lbldni As System.Windows.Forms.Label
    Friend WithEvents btnfin As System.Windows.Forms.Button
    Friend WithEvents btnagregar As System.Windows.Forms.Button
    Friend WithEvents lstcompra As System.Windows.Forms.ListBox
    Friend WithEvents cmbItems As System.Windows.Forms.ComboBox
    Friend WithEvents lstCant As System.Windows.Forms.ListBox
    Friend WithEvents lblcliente As System.Windows.Forms.Label
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIngreso
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmIngreso))
        Me.btnVolver1 = New System.Windows.Forms.Button()
        Me.Lbltipo = New System.Windows.Forms.Label()
        Me.Lblcant = New System.Windows.Forms.Label()
        Me.Txttipo = New System.Windows.Forms.TextBox()
        Me.txtcant = New System.Windows.Forms.TextBox()
        Me.btnaceptar = New System.Windows.Forms.Button()
        Me.btnVolveremos = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnVolver1
        '
        Me.btnVolver1.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnVolver1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolver1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVolver1.Location = New System.Drawing.Point(465, 487)
        Me.btnVolver1.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolver1.Name = "btnVolver1"
        Me.btnVolver1.Size = New System.Drawing.Size(68, 34)
        Me.btnVolver1.TabIndex = 5
        Me.btnVolver1.Text = "Volver"
        Me.btnVolver1.UseVisualStyleBackColor = False
        '
        'Lbltipo
        '
        Me.Lbltipo.AutoSize = True
        Me.Lbltipo.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lbltipo.Location = New System.Drawing.Point(13, 18)
        Me.Lbltipo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lbltipo.Name = "Lbltipo"
        Me.Lbltipo.Size = New System.Drawing.Size(47, 19)
        Me.Lbltipo.TabIndex = 6
        Me.Lbltipo.Text = "Tipo:"
        '
        'Lblcant
        '
        Me.Lblcant.AutoSize = True
        Me.Lblcant.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Lblcant.Location = New System.Drawing.Point(157, 18)
        Me.Lblcant.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Lblcant.Name = "Lblcant"
        Me.Lblcant.Size = New System.Drawing.Size(77, 19)
        Me.Lblcant.TabIndex = 8
        Me.Lblcant.Text = "Cantidad:"
        '
        'Txttipo
        '
        Me.Txttipo.BackColor = System.Drawing.SystemColors.Window
        Me.Txttipo.Location = New System.Drawing.Point(17, 41)
        Me.Txttipo.Margin = New System.Windows.Forms.Padding(4)
        Me.Txttipo.Name = "Txttipo"
        Me.Txttipo.Size = New System.Drawing.Size(113, 27)
        Me.Txttipo.TabIndex = 12
        '
        'txtcant
        '
        Me.txtcant.BackColor = System.Drawing.SystemColors.Window
        Me.txtcant.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtcant.Location = New System.Drawing.Point(161, 41)
        Me.txtcant.Margin = New System.Windows.Forms.Padding(4)
        Me.txtcant.Name = "txtcant"
        Me.txtcant.Size = New System.Drawing.Size(113, 27)
        Me.txtcant.TabIndex = 17
        '
        'btnaceptar
        '
        Me.btnaceptar.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnaceptar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnaceptar.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnaceptar.Location = New System.Drawing.Point(13, 76)
        Me.btnaceptar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnaceptar.Name = "btnaceptar"
        Me.btnaceptar.Size = New System.Drawing.Size(198, 36)
        Me.btnaceptar.TabIndex = 19
        Me.btnaceptar.Text = "Aceptar"
        Me.btnaceptar.UseVisualStyleBackColor = False
        '
        'btnVolveremos
        '
        Me.btnVolveremos.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnVolveremos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnVolveremos.Font = New System.Drawing.Font("Tahoma", 8.25!)
        Me.btnVolveremos.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnVolveremos.Location = New System.Drawing.Point(233, 89)
        Me.btnVolveremos.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVolveremos.Name = "btnVolveremos"
        Me.btnVolveremos.Size = New System.Drawing.Size(45, 23)
        Me.btnVolveremos.TabIndex = 20
        Me.btnVolveremos.Text = "Volver"
        Me.btnVolveremos.UseVisualStyleBackColor = False
        '
        'frmIngreso
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(291, 130)
        Me.Controls.Add(Me.btnVolveremos)
        Me.Controls.Add(Me.btnaceptar)
        Me.Controls.Add(Me.txtcant)
        Me.Controls.Add(Me.Txttipo)
        Me.Controls.Add(Me.Lblcant)
        Me.Controls.Add(Me.Lbltipo)
        Me.Controls.Add(Me.btnVolver1)
        Me.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmIngreso"
        Me.Text = "Klaer: Ingreso de Stock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnVolver1 As System.Windows.Forms.Button
    Friend WithEvents Lbltipo As System.Windows.Forms.Label
    Friend WithEvents Lblcant As System.Windows.Forms.Label
    Friend WithEvents Txttipo As System.Windows.Forms.TextBox
    Friend WithEvents txtcant As System.Windows.Forms.TextBox
    Friend WithEvents btnaceptar As System.Windows.Forms.Button
    Friend WithEvents btnVolveremos As System.Windows.Forms.Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInicio
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInicio))
        Me.btnCompra = New System.Windows.Forms.Button()
        Me.btnIngreso = New System.Windows.Forms.Button()
        Me.btnDevolucion = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.btnCriterios = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnCompra
        '
        Me.btnCompra.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCompra.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCompra.Location = New System.Drawing.Point(115, 85)
        Me.btnCompra.Name = "btnCompra"
        Me.btnCompra.Size = New System.Drawing.Size(137, 45)
        Me.btnCompra.TabIndex = 0
        Me.btnCompra.Text = "Compra"
        Me.btnCompra.UseVisualStyleBackColor = False
        '
        'btnIngreso
        '
        Me.btnIngreso.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnIngreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnIngreso.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnIngreso.Location = New System.Drawing.Point(115, 136)
        Me.btnIngreso.Name = "btnIngreso"
        Me.btnIngreso.Size = New System.Drawing.Size(137, 45)
        Me.btnIngreso.TabIndex = 1
        Me.btnIngreso.Text = "Ingreso stock"
        Me.btnIngreso.UseVisualStyleBackColor = False
        '
        'btnDevolucion
        '
        Me.btnDevolucion.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnDevolucion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnDevolucion.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDevolucion.Location = New System.Drawing.Point(115, 187)
        Me.btnDevolucion.Name = "btnDevolucion"
        Me.btnDevolucion.Size = New System.Drawing.Size(137, 45)
        Me.btnDevolucion.TabIndex = 2
        Me.btnDevolucion.Text = "Devolución"
        Me.btnDevolucion.UseVisualStyleBackColor = False
        '
        'btnSalir
        '
        Me.btnSalir.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnSalir.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSalir.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSalir.Location = New System.Drawing.Point(316, 333)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(39, 23)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = False
        '
        'btnCriterios
        '
        Me.btnCriterios.BackColor = System.Drawing.Color.FromArgb(CType(CType(232, Byte), Integer), CType(CType(203, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.btnCriterios.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCriterios.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriterios.Location = New System.Drawing.Point(115, 238)
        Me.btnCriterios.Name = "btnCriterios"
        Me.btnCriterios.Size = New System.Drawing.Size(137, 45)
        Me.btnCriterios.TabIndex = 4
        Me.btnCriterios.Text = "Criterios"
        Me.btnCriterios.UseVisualStyleBackColor = False
        '
        'frmInicio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(160, Byte), Integer), CType(CType(108, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(367, 368)
        Me.Controls.Add(Me.btnCriterios)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnDevolucion)
        Me.Controls.Add(Me.btnIngreso)
        Me.Controls.Add(Me.btnCompra)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmInicio"
        Me.Text = "Klaer: Indumentaria Juvenil"
        Me.WindowState = System.Windows.Forms.FormWindowState.Minimized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnCompra As System.Windows.Forms.Button
    Friend WithEvents btnIngreso As System.Windows.Forms.Button
    Friend WithEvents btnDevolucion As System.Windows.Forms.Button
    Friend WithEvents btnSalir As System.Windows.Forms.Button
    Friend WithEvents btnCriterios As System.Windows.Forms.Button

End Class

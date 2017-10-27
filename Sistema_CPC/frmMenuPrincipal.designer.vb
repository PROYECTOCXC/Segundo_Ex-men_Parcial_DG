<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMenuPrincipal
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
        Me.imsReportes = New System.Windows.Forms.ToolStripMenuItem()
        Me.imsTransaccion = New System.Windows.Forms.ToolStripMenuItem()
        Me.imsMantenimientoUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.itUsuarios = New System.Windows.Forms.ToolStripMenuItem()
        Me.itClientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.AyudaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.msOpciones = New System.Windows.Forms.MenuStrip()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.lbFecha = New System.Windows.Forms.Label()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.msOpciones.SuspendLayout()
        Me.SuspendLayout()
        '
        'imsReportes
        '
        Me.imsReportes.Name = "imsReportes"
        Me.imsReportes.Size = New System.Drawing.Size(80, 24)
        Me.imsReportes.Text = "Reportes"
        '
        'imsTransaccion
        '
        Me.imsTransaccion.Name = "imsTransaccion"
        Me.imsTransaccion.Size = New System.Drawing.Size(98, 24)
        Me.imsTransaccion.Text = "Transacción"
        '
        'imsMantenimientoUsuarios
        '
        Me.imsMantenimientoUsuarios.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.itUsuarios, Me.itClientes})
        Me.imsMantenimientoUsuarios.Name = "imsMantenimientoUsuarios"
        Me.imsMantenimientoUsuarios.Size = New System.Drawing.Size(122, 24)
        Me.imsMantenimientoUsuarios.Text = "Mantenimiento"
        '
        'itUsuarios
        '
        Me.itUsuarios.Name = "itUsuarios"
        Me.itUsuarios.Size = New System.Drawing.Size(181, 26)
        Me.itUsuarios.Text = "Usuarios"
        '
        'itClientes
        '
        Me.itClientes.Name = "itClientes"
        Me.itClientes.Size = New System.Drawing.Size(181, 26)
        Me.itClientes.Text = "Clientes"
        '
        'AyudaToolStripMenuItem
        '
        Me.AyudaToolStripMenuItem.Name = "AyudaToolStripMenuItem"
        Me.AyudaToolStripMenuItem.Size = New System.Drawing.Size(63, 24)
        Me.AyudaToolStripMenuItem.Text = "Ayuda"
        '
        'msOpciones
        '
        Me.msOpciones.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible
        Me.msOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.msOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.imsTransaccion, Me.imsMantenimientoUsuarios, Me.imsReportes, Me.AyudaToolStripMenuItem})
        Me.msOpciones.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow
        Me.msOpciones.Location = New System.Drawing.Point(0, 0)
        Me.msOpciones.Name = "msOpciones"
        Me.msOpciones.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.msOpciones.Size = New System.Drawing.Size(739, 28)
        Me.msOpciones.TabIndex = 0
        Me.msOpciones.Text = "Opciones"
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.BackColor = System.Drawing.SystemColors.Control
        Me.lbUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbUsuario.Font = New System.Drawing.Font("Lucida Fax", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbUsuario.Location = New System.Drawing.Point(61, 491)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.Size = New System.Drawing.Size(2, 19)
        Me.lbUsuario.TabIndex = 1
        Me.lbUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lbFecha
        '
        Me.lbFecha.AutoSize = True
        Me.lbFecha.BackColor = System.Drawing.SystemColors.Control
        Me.lbFecha.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lbFecha.Font = New System.Drawing.Font("Lucida Fax", 9.0!, CType((System.Drawing.FontStyle.Italic Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbFecha.Location = New System.Drawing.Point(541, 5)
        Me.lbFecha.Name = "lbFecha"
        Me.lbFecha.Size = New System.Drawing.Size(2, 19)
        Me.lbFecha.TabIndex = 2
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(589, 484)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(138, 33)
        Me.btnSalir.TabIndex = 3
        Me.btnSalir.Text = "Salir del Sistema"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'frmMenuPrincipal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(739, 529)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.lbFecha)
        Me.Controls.Add(Me.lbUsuario)
        Me.Controls.Add(Me.msOpciones)
        Me.MaximizeBox = False
        Me.Name = "frmMenuPrincipal"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sistema CoCoCred"
        Me.msOpciones.ResumeLayout(False)
        Me.msOpciones.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents imsReportes As ToolStripMenuItem
    Friend WithEvents imsTransaccion As ToolStripMenuItem
    Friend WithEvents imsMantenimientoUsuarios As ToolStripMenuItem
    Friend WithEvents AyudaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents msOpciones As MenuStrip
    Friend WithEvents lbUsuario As Label
    Friend WithEvents lbFecha As Label
    Friend WithEvents btnSalir As Button
    Friend WithEvents itUsuarios As ToolStripMenuItem
    Friend WithEvents itClientes As ToolStripMenuItem
End Class

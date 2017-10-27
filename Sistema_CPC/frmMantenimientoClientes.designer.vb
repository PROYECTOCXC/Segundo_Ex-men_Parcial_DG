<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMantenimientoClientes
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
        Me.dtgClientes = New System.Windows.Forms.DataGridView()
        Me.gbxInfoCliente = New System.Windows.Forms.GroupBox()
        Me.lbIdentificacion = New System.Windows.Forms.Label()
        Me.txtIdentificacion = New System.Windows.Forms.TextBox()
        Me.lbFechaNacimiento = New System.Windows.Forms.Label()
        Me.dtpFechaNacimiento = New System.Windows.Forms.DateTimePicker()
        Me.lbDireccion = New System.Windows.Forms.Label()
        Me.txtDireccion = New System.Windows.Forms.TextBox()
        Me.lbLimiteCredito = New System.Windows.Forms.Label()
        Me.txtLimiteCredito = New System.Windows.Forms.TextBox()
        Me.lbSalario = New System.Windows.Forms.Label()
        Me.txtSalario = New System.Windows.Forms.TextBox()
        Me.lbApellido2 = New System.Windows.Forms.Label()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.lbApellido1 = New System.Windows.Forms.Label()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnComando = New System.Windows.Forms.Button()
        Me.cbxOpciones = New System.Windows.Forms.ComboBox()
        Me.btnNuevaOpcion = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfoCliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowUserToAddRows = False
        Me.dtgClientes.AllowUserToDeleteRows = False
        Me.dtgClientes.AllowUserToResizeColumns = False
        Me.dtgClientes.AllowUserToResizeRows = False
        Me.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgClientes.BackgroundColor = System.Drawing.SystemColors.Info
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClientes.Location = New System.Drawing.Point(433, 12)
        Me.dtgClientes.MultiSelect = False
        Me.dtgClientes.Name = "dtgClientes"
        Me.dtgClientes.ReadOnly = True
        Me.dtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgClientes.RowTemplate.Height = 24
        Me.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgClientes.Size = New System.Drawing.Size(714, 562)
        Me.dtgClientes.TabIndex = 0
        '
        'gbxInfoCliente
        '
        Me.gbxInfoCliente.Controls.Add(Me.lbIdentificacion)
        Me.gbxInfoCliente.Controls.Add(Me.txtIdentificacion)
        Me.gbxInfoCliente.Controls.Add(Me.lbFechaNacimiento)
        Me.gbxInfoCliente.Controls.Add(Me.dtpFechaNacimiento)
        Me.gbxInfoCliente.Controls.Add(Me.lbDireccion)
        Me.gbxInfoCliente.Controls.Add(Me.txtDireccion)
        Me.gbxInfoCliente.Controls.Add(Me.lbLimiteCredito)
        Me.gbxInfoCliente.Controls.Add(Me.txtLimiteCredito)
        Me.gbxInfoCliente.Controls.Add(Me.lbSalario)
        Me.gbxInfoCliente.Controls.Add(Me.txtSalario)
        Me.gbxInfoCliente.Controls.Add(Me.lbApellido2)
        Me.gbxInfoCliente.Controls.Add(Me.txtApellido2)
        Me.gbxInfoCliente.Controls.Add(Me.lbApellido1)
        Me.gbxInfoCliente.Controls.Add(Me.txtApellido1)
        Me.gbxInfoCliente.Controls.Add(Me.lbNombre)
        Me.gbxInfoCliente.Controls.Add(Me.txtNombre)
        Me.gbxInfoCliente.Location = New System.Drawing.Point(6, 72)
        Me.gbxInfoCliente.Name = "gbxInfoCliente"
        Me.gbxInfoCliente.Size = New System.Drawing.Size(420, 398)
        Me.gbxInfoCliente.TabIndex = 1
        Me.gbxInfoCliente.TabStop = False
        Me.gbxInfoCliente.Text = "Información del Cliente"
        '
        'lbIdentificacion
        '
        Me.lbIdentificacion.AutoSize = True
        Me.lbIdentificacion.Location = New System.Drawing.Point(16, 251)
        Me.lbIdentificacion.Name = "lbIdentificacion"
        Me.lbIdentificacion.Size = New System.Drawing.Size(90, 17)
        Me.lbIdentificacion.TabIndex = 20
        Me.lbIdentificacion.Text = "Identificación"
        '
        'txtIdentificacion
        '
        Me.txtIdentificacion.Location = New System.Drawing.Point(16, 274)
        Me.txtIdentificacion.Name = "txtIdentificacion"
        Me.txtIdentificacion.Size = New System.Drawing.Size(153, 22)
        Me.txtIdentificacion.TabIndex = 4
        '
        'lbFechaNacimiento
        '
        Me.lbFechaNacimiento.AutoSize = True
        Me.lbFechaNacimiento.Location = New System.Drawing.Point(222, 291)
        Me.lbFechaNacimiento.Name = "lbFechaNacimiento"
        Me.lbFechaNacimiento.Size = New System.Drawing.Size(145, 17)
        Me.lbFechaNacimiento.TabIndex = 18
        Me.lbFechaNacimiento.Text = "Fecha de Nacimiento:"
        '
        'dtpFechaNacimiento
        '
        Me.dtpFechaNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFechaNacimiento.Location = New System.Drawing.Point(225, 314)
        Me.dtpFechaNacimiento.MaxDate = New Date(2017, 10, 17, 0, 0, 0, 0)
        Me.dtpFechaNacimiento.Name = "dtpFechaNacimiento"
        Me.dtpFechaNacimiento.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dtpFechaNacimiento.Size = New System.Drawing.Size(142, 22)
        Me.dtpFechaNacimiento.TabIndex = 8
        Me.dtpFechaNacimiento.Value = New Date(2017, 10, 17, 0, 0, 0, 0)
        '
        'lbDireccion
        '
        Me.lbDireccion.AutoSize = True
        Me.lbDireccion.Location = New System.Drawing.Point(208, 112)
        Me.lbDireccion.Name = "lbDireccion"
        Me.lbDireccion.Size = New System.Drawing.Size(71, 17)
        Me.lbDireccion.TabIndex = 16
        Me.lbDireccion.Text = "Dirección:"
        '
        'txtDireccion
        '
        Me.txtDireccion.Location = New System.Drawing.Point(211, 135)
        Me.txtDireccion.Multiline = True
        Me.txtDireccion.Name = "txtDireccion"
        Me.txtDireccion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txtDireccion.Size = New System.Drawing.Size(191, 92)
        Me.txtDireccion.TabIndex = 7
        '
        'lbLimiteCredito
        '
        Me.lbLimiteCredito.AutoSize = True
        Me.lbLimiteCredito.Location = New System.Drawing.Point(211, 44)
        Me.lbLimiteCredito.Name = "lbLimiteCredito"
        Me.lbLimiteCredito.Size = New System.Drawing.Size(111, 17)
        Me.lbLimiteCredito.TabIndex = 14
        Me.lbLimiteCredito.Text = "Límite Crediticio:"
        '
        'txtLimiteCredito
        '
        Me.txtLimiteCredito.Location = New System.Drawing.Point(211, 67)
        Me.txtLimiteCredito.Name = "txtLimiteCredito"
        Me.txtLimiteCredito.Size = New System.Drawing.Size(153, 22)
        Me.txtLimiteCredito.TabIndex = 6
        '
        'lbSalario
        '
        Me.lbSalario.AutoSize = True
        Me.lbSalario.Location = New System.Drawing.Point(16, 323)
        Me.lbSalario.Name = "lbSalario"
        Me.lbSalario.Size = New System.Drawing.Size(90, 17)
        Me.lbSalario.TabIndex = 12
        Me.lbSalario.Text = "Salario Neto:"
        '
        'txtSalario
        '
        Me.txtSalario.Location = New System.Drawing.Point(16, 346)
        Me.txtSalario.Name = "txtSalario"
        Me.txtSalario.Size = New System.Drawing.Size(153, 22)
        Me.txtSalario.TabIndex = 5
        '
        'lbApellido2
        '
        Me.lbApellido2.AutoSize = True
        Me.lbApellido2.Location = New System.Drawing.Point(16, 182)
        Me.lbApellido2.Name = "lbApellido2"
        Me.lbApellido2.Size = New System.Drawing.Size(118, 17)
        Me.lbApellido2.TabIndex = 8
        Me.lbApellido2.Text = "Apellido Materno:"
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(16, 205)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(153, 22)
        Me.txtApellido2.TabIndex = 3
        '
        'lbApellido1
        '
        Me.lbApellido1.AutoSize = True
        Me.lbApellido1.Location = New System.Drawing.Point(16, 112)
        Me.lbApellido1.Name = "lbApellido1"
        Me.lbApellido1.Size = New System.Drawing.Size(116, 17)
        Me.lbApellido1.TabIndex = 6
        Me.lbApellido1.Text = "Apellido Paterno:"
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(16, 135)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(153, 22)
        Me.txtApellido1.TabIndex = 2
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(16, 44)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(62, 17)
        Me.lbNombre.TabIndex = 4
        Me.lbNombre.Text = "Nombre:"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(16, 67)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(153, 22)
        Me.txtNombre.TabIndex = 1
        '
        'btnComando
        '
        Me.btnComando.Location = New System.Drawing.Point(144, 495)
        Me.btnComando.Name = "btnComando"
        Me.btnComando.Size = New System.Drawing.Size(150, 29)
        Me.btnComando.TabIndex = 9
        Me.btnComando.UseVisualStyleBackColor = True
        '
        'cbxOpciones
        '
        Me.cbxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpciones.FormattingEnabled = True
        Me.cbxOpciones.Location = New System.Drawing.Point(183, 28)
        Me.cbxOpciones.Name = "cbxOpciones"
        Me.cbxOpciones.Size = New System.Drawing.Size(201, 24)
        Me.cbxOpciones.TabIndex = 0
        '
        'btnNuevaOpcion
        '
        Me.btnNuevaOpcion.Location = New System.Drawing.Point(298, 545)
        Me.btnNuevaOpcion.Name = "btnNuevaOpcion"
        Me.btnNuevaOpcion.Size = New System.Drawing.Size(122, 29)
        Me.btnNuevaOpcion.TabIndex = 11
        Me.btnNuevaOpcion.Text = "Nueva Opción"
        Me.btnNuevaOpcion.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 545)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(128, 29)
        Me.btnVolver.TabIndex = 12
        Me.btnVolver.Text = "Volver al Menú"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'frmMantenimientoClientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1159, 587)
        Me.Controls.Add(Me.btnNuevaOpcion)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.cbxOpciones)
        Me.Controls.Add(Me.gbxInfoCliente)
        Me.Controls.Add(Me.dtgClientes)
        Me.Controls.Add(Me.btnComando)
        Me.MaximizeBox = False
        Me.Name = "frmMantenimientoClientes"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Clientes"
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfoCliente.ResumeLayout(False)
        Me.gbxInfoCliente.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgClientes As DataGridView
    Friend WithEvents gbxInfoCliente As GroupBox
    Friend WithEvents lbDireccion As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents lbLimiteCredito As Label
    Friend WithEvents txtLimiteCredito As TextBox
    Friend WithEvents lbSalario As Label
    Friend WithEvents txtSalario As TextBox
    Friend WithEvents lbApellido2 As Label
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents lbApellido1 As Label
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents lbNombre As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnComando As Button
    Friend WithEvents cbxOpciones As ComboBox
    Friend WithEvents btnNuevaOpcion As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents lbFechaNacimiento As Label
    Friend WithEvents dtpFechaNacimiento As DateTimePicker
    Friend WithEvents lbIdentificacion As Label
    Friend WithEvents txtIdentificacion As TextBox
End Class

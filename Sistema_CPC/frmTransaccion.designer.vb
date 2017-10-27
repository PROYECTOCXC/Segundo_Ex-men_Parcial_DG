<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTransaccion
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
        Me.dtgCreditos = New System.Windows.Forms.DataGridView()
        Me.btnComando = New System.Windows.Forms.Button()
        Me.btnVolver = New System.Windows.Forms.Button()
        Me.smiNuevoAbono = New System.Windows.Forms.ToolStripMenuItem()
        Me.smiNuevoCredito = New System.Windows.Forms.ToolStripMenuItem()
        Me.mstOpciones = New System.Windows.Forms.MenuStrip()
        Me.dtgClientes = New System.Windows.Forms.DataGridView()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.gbxTransaccion = New System.Windows.Forms.GroupBox()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.lbUsuario = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.lbCliente = New System.Windows.Forms.Label()
        Me.lbSaldoCrediticio = New System.Windows.Forms.Label()
        Me.lbFechaInicial = New System.Windows.Forms.Label()
        Me.lbPlazo = New System.Windows.Forms.Label()
        Me.lbCuotas = New System.Windows.Forms.Label()
        Me.lbMontoPendiente = New System.Windows.Forms.Label()
        Me.lbMontoTotal = New System.Windows.Forms.Label()
        Me.txtSaldoCrediticio = New System.Windows.Forms.TextBox()
        Me.txtFechaInicial = New System.Windows.Forms.TextBox()
        Me.txtPlazo = New System.Windows.Forms.TextBox()
        Me.txtCuotas = New System.Windows.Forms.TextBox()
        Me.txtMontoPendiente = New System.Windows.Forms.TextBox()
        Me.txtMontoTotal = New System.Windows.Forms.TextBox()
        CType(Me.dtgCreditos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.mstOpciones.SuspendLayout()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxTransaccion.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgCreditos
        '
        Me.dtgCreditos.AllowUserToAddRows = False
        Me.dtgCreditos.AllowUserToDeleteRows = False
        Me.dtgCreditos.AllowUserToResizeColumns = False
        Me.dtgCreditos.AllowUserToResizeRows = False
        Me.dtgCreditos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgCreditos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgCreditos.BackgroundColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.dtgCreditos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgCreditos.Location = New System.Drawing.Point(12, 420)
        Me.dtgCreditos.MultiSelect = False
        Me.dtgCreditos.Name = "dtgCreditos"
        Me.dtgCreditos.ReadOnly = True
        Me.dtgCreditos.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dtgCreditos.RowTemplate.Height = 24
        Me.dtgCreditos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgCreditos.Size = New System.Drawing.Size(1280, 194)
        Me.dtgCreditos.TabIndex = 0
        '
        'btnComando
        '
        Me.btnComando.Location = New System.Drawing.Point(210, 292)
        Me.btnComando.Name = "btnComando"
        Me.btnComando.Size = New System.Drawing.Size(190, 29)
        Me.btnComando.TabIndex = 2
        Me.btnComando.UseVisualStyleBackColor = True
        '
        'btnVolver
        '
        Me.btnVolver.Location = New System.Drawing.Point(12, 385)
        Me.btnVolver.Name = "btnVolver"
        Me.btnVolver.Size = New System.Drawing.Size(122, 29)
        Me.btnVolver.TabIndex = 4
        Me.btnVolver.Text = "Volver al Menú"
        Me.btnVolver.UseVisualStyleBackColor = True
        '
        'smiNuevoAbono
        '
        Me.smiNuevoAbono.Name = "smiNuevoAbono"
        Me.smiNuevoAbono.Size = New System.Drawing.Size(113, 24)
        Me.smiNuevoAbono.Text = "Nuevo Abono"
        '
        'smiNuevoCredito
        '
        Me.smiNuevoCredito.Name = "smiNuevoCredito"
        Me.smiNuevoCredito.Size = New System.Drawing.Size(117, 24)
        Me.smiNuevoCredito.Text = "Nuevo Crédito"
        '
        'mstOpciones
        '
        Me.mstOpciones.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.mstOpciones.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.smiNuevoAbono, Me.smiNuevoCredito})
        Me.mstOpciones.Location = New System.Drawing.Point(0, 0)
        Me.mstOpciones.Name = "mstOpciones"
        Me.mstOpciones.Size = New System.Drawing.Size(1304, 28)
        Me.mstOpciones.TabIndex = 0
        Me.mstOpciones.Text = "mstOpciones"
        '
        'dtgClientes
        '
        Me.dtgClientes.AllowUserToAddRows = False
        Me.dtgClientes.AllowUserToDeleteRows = False
        Me.dtgClientes.AllowUserToResizeColumns = False
        Me.dtgClientes.AllowUserToResizeRows = False
        Me.dtgClientes.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgClientes.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgClientes.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.dtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgClientes.Location = New System.Drawing.Point(606, 40)
        Me.dtgClientes.MultiSelect = False
        Me.dtgClientes.Name = "dtgClientes"
        Me.dtgClientes.ReadOnly = True
        Me.dtgClientes.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToDisplayedHeaders
        Me.dtgClientes.RowTemplate.Height = 24
        Me.dtgClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgClientes.Size = New System.Drawing.Size(686, 374)
        Me.dtgClientes.TabIndex = 6
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(250, 354)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(107, 28)
        Me.btnCancelar.TabIndex = 3
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'gbxTransaccion
        '
        Me.gbxTransaccion.Controls.Add(Me.txtUsuario)
        Me.gbxTransaccion.Controls.Add(Me.lbUsuario)
        Me.gbxTransaccion.Controls.Add(Me.txtCliente)
        Me.gbxTransaccion.Controls.Add(Me.lbCliente)
        Me.gbxTransaccion.Controls.Add(Me.lbSaldoCrediticio)
        Me.gbxTransaccion.Controls.Add(Me.lbFechaInicial)
        Me.gbxTransaccion.Controls.Add(Me.lbPlazo)
        Me.gbxTransaccion.Controls.Add(Me.lbCuotas)
        Me.gbxTransaccion.Controls.Add(Me.lbMontoPendiente)
        Me.gbxTransaccion.Controls.Add(Me.lbMontoTotal)
        Me.gbxTransaccion.Controls.Add(Me.txtSaldoCrediticio)
        Me.gbxTransaccion.Controls.Add(Me.txtFechaInicial)
        Me.gbxTransaccion.Controls.Add(Me.txtPlazo)
        Me.gbxTransaccion.Controls.Add(Me.txtCuotas)
        Me.gbxTransaccion.Controls.Add(Me.txtMontoPendiente)
        Me.gbxTransaccion.Controls.Add(Me.txtMontoTotal)
        Me.gbxTransaccion.Location = New System.Drawing.Point(12, 40)
        Me.gbxTransaccion.Name = "gbxTransaccion"
        Me.gbxTransaccion.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.gbxTransaccion.Size = New System.Drawing.Size(588, 221)
        Me.gbxTransaccion.TabIndex = 1
        Me.gbxTransaccion.TabStop = False
        Me.gbxTransaccion.Text = "Datos de la transacción"
        '
        'txtUsuario
        '
        Me.txtUsuario.Enabled = False
        Me.txtUsuario.Location = New System.Drawing.Point(85, 43)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(193, 22)
        Me.txtUsuario.TabIndex = 20
        Me.txtUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbUsuario
        '
        Me.lbUsuario.AutoSize = True
        Me.lbUsuario.Location = New System.Drawing.Point(18, 46)
        Me.lbUsuario.Name = "lbUsuario"
        Me.lbUsuario.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbUsuario.Size = New System.Drawing.Size(61, 17)
        Me.lbUsuario.TabIndex = 19
        Me.lbUsuario.Text = "Usuario:"
        '
        'txtCliente
        '
        Me.txtCliente.Enabled = False
        Me.txtCliente.Location = New System.Drawing.Point(366, 43)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(193, 22)
        Me.txtCliente.TabIndex = 18
        Me.txtCliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbCliente
        '
        Me.lbCliente.AutoSize = True
        Me.lbCliente.Location = New System.Drawing.Point(305, 46)
        Me.lbCliente.Name = "lbCliente"
        Me.lbCliente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbCliente.Size = New System.Drawing.Size(55, 17)
        Me.lbCliente.TabIndex = 17
        Me.lbCliente.Text = "Cliente:"
        '
        'lbSaldoCrediticio
        '
        Me.lbSaldoCrediticio.AutoSize = True
        Me.lbSaldoCrediticio.Location = New System.Drawing.Point(51, 165)
        Me.lbSaldoCrediticio.Name = "lbSaldoCrediticio"
        Me.lbSaldoCrediticio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbSaldoCrediticio.Size = New System.Drawing.Size(110, 17)
        Me.lbSaldoCrediticio.TabIndex = 14
        Me.lbSaldoCrediticio.Text = "Saldo Crediticio:"
        '
        'lbFechaInicial
        '
        Me.lbFechaInicial.AutoSize = True
        Me.lbFechaInicial.Location = New System.Drawing.Point(350, 165)
        Me.lbFechaInicial.Name = "lbFechaInicial"
        Me.lbFechaInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbFechaInicial.Size = New System.Drawing.Size(90, 17)
        Me.lbFechaInicial.TabIndex = 13
        Me.lbFechaInicial.Text = "Fecha Inicial:"
        '
        'lbPlazo
        '
        Me.lbPlazo.AutoSize = True
        Me.lbPlazo.Location = New System.Drawing.Point(124, 128)
        Me.lbPlazo.Name = "lbPlazo"
        Me.lbPlazo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbPlazo.Size = New System.Drawing.Size(102, 17)
        Me.lbPlazo.TabIndex = 12
        Me.lbPlazo.Text = "Plazo (Meses):"
        '
        'lbCuotas
        '
        Me.lbCuotas.AutoSize = True
        Me.lbCuotas.Location = New System.Drawing.Point(384, 128)
        Me.lbCuotas.Name = "lbCuotas"
        Me.lbCuotas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbCuotas.Size = New System.Drawing.Size(56, 17)
        Me.lbCuotas.TabIndex = 10
        Me.lbCuotas.Text = "Cuotas:"
        '
        'lbMontoPendiente
        '
        Me.lbMontoPendiente.AutoSize = True
        Me.lbMontoPendiente.Location = New System.Drawing.Point(322, 91)
        Me.lbMontoPendiente.Name = "lbMontoPendiente"
        Me.lbMontoPendiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbMontoPendiente.Size = New System.Drawing.Size(119, 17)
        Me.lbMontoPendiente.TabIndex = 9
        Me.lbMontoPendiente.Text = "Monto Pendiente:"
        '
        'lbMontoTotal
        '
        Me.lbMontoTotal.AutoSize = True
        Me.lbMontoTotal.Location = New System.Drawing.Point(73, 91)
        Me.lbMontoTotal.Name = "lbMontoTotal"
        Me.lbMontoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbMontoTotal.Size = New System.Drawing.Size(87, 17)
        Me.lbMontoTotal.TabIndex = 8
        Me.lbMontoTotal.Text = "Monto Total:"
        '
        'txtSaldoCrediticio
        '
        Me.txtSaldoCrediticio.Enabled = False
        Me.txtSaldoCrediticio.Location = New System.Drawing.Point(166, 162)
        Me.txtSaldoCrediticio.Name = "txtSaldoCrediticio"
        Me.txtSaldoCrediticio.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtSaldoCrediticio.Size = New System.Drawing.Size(113, 22)
        Me.txtSaldoCrediticio.TabIndex = 5
        Me.txtSaldoCrediticio.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFechaInicial
        '
        Me.txtFechaInicial.Enabled = False
        Me.txtFechaInicial.Location = New System.Drawing.Point(446, 162)
        Me.txtFechaInicial.Name = "txtFechaInicial"
        Me.txtFechaInicial.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtFechaInicial.Size = New System.Drawing.Size(113, 22)
        Me.txtFechaInicial.TabIndex = 4
        Me.txtFechaInicial.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtPlazo
        '
        Me.txtPlazo.Location = New System.Drawing.Point(231, 125)
        Me.txtPlazo.Name = "txtPlazo"
        Me.txtPlazo.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtPlazo.Size = New System.Drawing.Size(47, 22)
        Me.txtPlazo.TabIndex = 3
        '
        'txtCuotas
        '
        Me.txtCuotas.Enabled = False
        Me.txtCuotas.Location = New System.Drawing.Point(446, 125)
        Me.txtCuotas.Name = "txtCuotas"
        Me.txtCuotas.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtCuotas.Size = New System.Drawing.Size(113, 22)
        Me.txtCuotas.TabIndex = 2
        '
        'txtMontoPendiente
        '
        Me.txtMontoPendiente.Enabled = False
        Me.txtMontoPendiente.Location = New System.Drawing.Point(447, 88)
        Me.txtMontoPendiente.Name = "txtMontoPendiente"
        Me.txtMontoPendiente.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMontoPendiente.Size = New System.Drawing.Size(112, 22)
        Me.txtMontoPendiente.TabIndex = 1
        '
        'txtMontoTotal
        '
        Me.txtMontoTotal.Location = New System.Drawing.Point(166, 88)
        Me.txtMontoTotal.Name = "txtMontoTotal"
        Me.txtMontoTotal.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.txtMontoTotal.Size = New System.Drawing.Size(112, 22)
        Me.txtMontoTotal.TabIndex = 0
        '
        'frmTransaccion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1304, 626)
        Me.Controls.Add(Me.gbxTransaccion)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.dtgClientes)
        Me.Controls.Add(Me.btnVolver)
        Me.Controls.Add(Me.btnComando)
        Me.Controls.Add(Me.dtgCreditos)
        Me.Controls.Add(Me.mstOpciones)
        Me.MainMenuStrip = Me.mstOpciones
        Me.MaximizeBox = False
        Me.Name = "frmTransaccion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Transacción"
        CType(Me.dtgCreditos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.mstOpciones.ResumeLayout(False)
        Me.mstOpciones.PerformLayout()
        CType(Me.dtgClientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxTransaccion.ResumeLayout(False)
        Me.gbxTransaccion.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dtgCreditos As DataGridView
    Friend WithEvents btnComando As Button
    Friend WithEvents btnVolver As Button
    Friend WithEvents smiNuevoAbono As ToolStripMenuItem
    Friend WithEvents smiNuevoCredito As ToolStripMenuItem
    Friend WithEvents mstOpciones As MenuStrip
    Friend WithEvents dtgClientes As DataGridView
    Friend WithEvents btnCancelar As Button
    Friend WithEvents gbxTransaccion As GroupBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents lbUsuario As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents lbCliente As Label
    Friend WithEvents lbSaldoCrediticio As Label
    Friend WithEvents lbFechaInicial As Label
    Friend WithEvents lbPlazo As Label
    Friend WithEvents lbCuotas As Label
    Friend WithEvents lbMontoPendiente As Label
    Friend WithEvents lbMontoTotal As Label
    Friend WithEvents txtSaldoCrediticio As TextBox
    Friend WithEvents txtFechaInicial As TextBox
    Friend WithEvents txtPlazo As TextBox
    Friend WithEvents txtCuotas As TextBox
    Friend WithEvents txtMontoPendiente As TextBox
    Friend WithEvents txtMontoTotal As TextBox
End Class

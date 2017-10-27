<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMantenimientoUsuarios
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.dtgUsuarios = New System.Windows.Forms.DataGridView()
        Me.cbxOpciones = New System.Windows.Forms.ComboBox()
        Me.btnNuevaOpcion = New System.Windows.Forms.Button()
        Me.btnRegresar = New System.Windows.Forms.Button()
        Me.gbxInfoUsuario = New System.Windows.Forms.GroupBox()
        Me.lbTipoUsuario = New System.Windows.Forms.Label()
        Me.lbNickName = New System.Windows.Forms.Label()
        Me.lbContraseña = New System.Windows.Forms.Label()
        Me.lbApellido2 = New System.Windows.Forms.Label()
        Me.lbApellido1 = New System.Windows.Forms.Label()
        Me.lbNombre = New System.Windows.Forms.Label()
        Me.cbxTipoUsuario = New System.Windows.Forms.ComboBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.txtNickName = New System.Windows.Forms.TextBox()
        Me.txtApellido2 = New System.Windows.Forms.TextBox()
        Me.txtApellido1 = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.btnComando = New System.Windows.Forms.Button()
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbxInfoUsuario.SuspendLayout()
        Me.SuspendLayout()
        '
        'dtgUsuarios
        '
        Me.dtgUsuarios.AllowUserToAddRows = False
        Me.dtgUsuarios.AllowUserToDeleteRows = False
        Me.dtgUsuarios.AllowUserToResizeColumns = False
        Me.dtgUsuarios.AllowUserToResizeRows = False
        Me.dtgUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.dtgUsuarios.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.dtgUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtgUsuarios.Location = New System.Drawing.Point(410, 12)
        Me.dtgUsuarios.MultiSelect = False
        Me.dtgUsuarios.Name = "dtgUsuarios"
        Me.dtgUsuarios.ReadOnly = True
        Me.dtgUsuarios.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing
        Me.dtgUsuarios.RowTemplate.Height = 24
        Me.dtgUsuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.dtgUsuarios.Size = New System.Drawing.Size(737, 407)
        Me.dtgUsuarios.TabIndex = 0
        '
        'cbxOpciones
        '
        Me.cbxOpciones.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxOpciones.FormattingEnabled = True
        Me.cbxOpciones.Location = New System.Drawing.Point(109, 27)
        Me.cbxOpciones.Name = "cbxOpciones"
        Me.cbxOpciones.Size = New System.Drawing.Size(196, 24)
        Me.cbxOpciones.TabIndex = 0
        '
        'btnNuevaOpcion
        '
        Me.btnNuevaOpcion.Location = New System.Drawing.Point(279, 390)
        Me.btnNuevaOpcion.Name = "btnNuevaOpcion"
        Me.btnNuevaOpcion.Size = New System.Drawing.Size(122, 29)
        Me.btnNuevaOpcion.TabIndex = 9
        Me.btnNuevaOpcion.Text = "Nueva Opción"
        Me.btnNuevaOpcion.UseVisualStyleBackColor = True
        '
        'btnRegresar
        '
        Me.btnRegresar.Location = New System.Drawing.Point(9, 390)
        Me.btnRegresar.Name = "btnRegresar"
        Me.btnRegresar.Size = New System.Drawing.Size(122, 29)
        Me.btnRegresar.TabIndex = 10
        Me.btnRegresar.Text = "Volver al Menú"
        Me.btnRegresar.UseVisualStyleBackColor = True
        '
        'gbxInfoUsuario
        '
        Me.gbxInfoUsuario.Controls.Add(Me.lbTipoUsuario)
        Me.gbxInfoUsuario.Controls.Add(Me.lbNickName)
        Me.gbxInfoUsuario.Controls.Add(Me.lbContraseña)
        Me.gbxInfoUsuario.Controls.Add(Me.lbApellido2)
        Me.gbxInfoUsuario.Controls.Add(Me.lbApellido1)
        Me.gbxInfoUsuario.Controls.Add(Me.lbNombre)
        Me.gbxInfoUsuario.Controls.Add(Me.cbxTipoUsuario)
        Me.gbxInfoUsuario.Controls.Add(Me.txtContraseña)
        Me.gbxInfoUsuario.Controls.Add(Me.txtNickName)
        Me.gbxInfoUsuario.Controls.Add(Me.txtApellido2)
        Me.gbxInfoUsuario.Controls.Add(Me.txtApellido1)
        Me.gbxInfoUsuario.Controls.Add(Me.txtNombre)
        Me.gbxInfoUsuario.Location = New System.Drawing.Point(9, 86)
        Me.gbxInfoUsuario.Name = "gbxInfoUsuario"
        Me.gbxInfoUsuario.Size = New System.Drawing.Size(392, 231)
        Me.gbxInfoUsuario.TabIndex = 5
        Me.gbxInfoUsuario.TabStop = False
        Me.gbxInfoUsuario.Text = "Información del usuario"
        '
        'lbTipoUsuario
        '
        Me.lbTipoUsuario.AutoSize = True
        Me.lbTipoUsuario.Location = New System.Drawing.Point(211, 163)
        Me.lbTipoUsuario.Name = "lbTipoUsuario"
        Me.lbTipoUsuario.Size = New System.Drawing.Size(111, 17)
        Me.lbTipoUsuario.TabIndex = 30
        Me.lbTipoUsuario.Text = "Tipo de usuario:"
        '
        'lbNickName
        '
        Me.lbNickName.AutoSize = True
        Me.lbNickName.Location = New System.Drawing.Point(211, 106)
        Me.lbNickName.Name = "lbNickName"
        Me.lbNickName.Size = New System.Drawing.Size(76, 17)
        Me.lbNickName.TabIndex = 29
        Me.lbNickName.Text = "NickName:"
        '
        'lbContraseña
        '
        Me.lbContraseña.AutoSize = True
        Me.lbContraseña.Location = New System.Drawing.Point(211, 47)
        Me.lbContraseña.Name = "lbContraseña"
        Me.lbContraseña.Size = New System.Drawing.Size(85, 17)
        Me.lbContraseña.TabIndex = 28
        Me.lbContraseña.Text = "Contraseña:"
        '
        'lbApellido2
        '
        Me.lbApellido2.AutoSize = True
        Me.lbApellido2.Location = New System.Drawing.Point(15, 163)
        Me.lbApellido2.Name = "lbApellido2"
        Me.lbApellido2.Size = New System.Drawing.Size(118, 17)
        Me.lbApellido2.TabIndex = 27
        Me.lbApellido2.Text = "Apellido Materno:"
        '
        'lbApellido1
        '
        Me.lbApellido1.AutoSize = True
        Me.lbApellido1.Location = New System.Drawing.Point(15, 106)
        Me.lbApellido1.Name = "lbApellido1"
        Me.lbApellido1.Size = New System.Drawing.Size(116, 17)
        Me.lbApellido1.TabIndex = 26
        Me.lbApellido1.Text = "Apellido Paterno:"
        '
        'lbNombre
        '
        Me.lbNombre.AutoSize = True
        Me.lbNombre.Location = New System.Drawing.Point(18, 47)
        Me.lbNombre.Name = "lbNombre"
        Me.lbNombre.Size = New System.Drawing.Size(62, 17)
        Me.lbNombre.TabIndex = 25
        Me.lbNombre.Text = "Nombre:"
        '
        'cbxTipoUsuario
        '
        Me.cbxTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbxTipoUsuario.FormattingEnabled = True
        Me.cbxTipoUsuario.Location = New System.Drawing.Point(214, 183)
        Me.cbxTipoUsuario.Name = "cbxTipoUsuario"
        Me.cbxTipoUsuario.Size = New System.Drawing.Size(160, 24)
        Me.cbxTipoUsuario.TabIndex = 6
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(214, 70)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.Size = New System.Drawing.Size(160, 22)
        Me.txtContraseña.TabIndex = 4
        '
        'txtNickName
        '
        Me.txtNickName.Location = New System.Drawing.Point(214, 126)
        Me.txtNickName.Name = "txtNickName"
        Me.txtNickName.Size = New System.Drawing.Size(160, 22)
        Me.txtNickName.TabIndex = 5
        '
        'txtApellido2
        '
        Me.txtApellido2.Location = New System.Drawing.Point(18, 183)
        Me.txtApellido2.Name = "txtApellido2"
        Me.txtApellido2.Size = New System.Drawing.Size(160, 22)
        Me.txtApellido2.TabIndex = 3
        '
        'txtApellido1
        '
        Me.txtApellido1.Location = New System.Drawing.Point(18, 126)
        Me.txtApellido1.Name = "txtApellido1"
        Me.txtApellido1.Size = New System.Drawing.Size(160, 22)
        Me.txtApellido1.TabIndex = 2
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(18, 70)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(160, 22)
        Me.txtNombre.TabIndex = 1
        '
        'btnComando
        '
        Me.btnComando.Location = New System.Drawing.Point(124, 338)
        Me.btnComando.Name = "btnComando"
        Me.btnComando.Size = New System.Drawing.Size(160, 29)
        Me.btnComando.TabIndex = 7
        Me.btnComando.UseVisualStyleBackColor = True
        '
        'frmMantenimientoUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(1159, 431)
        Me.Controls.Add(Me.gbxInfoUsuario)
        Me.Controls.Add(Me.btnNuevaOpcion)
        Me.Controls.Add(Me.btnRegresar)
        Me.Controls.Add(Me.cbxOpciones)
        Me.Controls.Add(Me.dtgUsuarios)
        Me.Controls.Add(Me.btnComando)
        Me.MaximizeBox = False
        Me.Name = "frmMantenimientoUsuarios"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mantenimiento de Usuarios"
        CType(Me.dtgUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbxInfoUsuario.ResumeLayout(False)
        Me.gbxInfoUsuario.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents dtgUsuarios As DataGridView
    Friend WithEvents cbxOpciones As ComboBox
    Friend WithEvents btnNuevaOpcion As Button
    Friend WithEvents btnRegresar As Button
    Friend WithEvents gbxInfoUsuario As GroupBox
    Friend WithEvents lbTipoUsuario As Label
    Friend WithEvents lbNickName As Label
    Friend WithEvents lbContraseña As Label
    Friend WithEvents lbApellido2 As Label
    Friend WithEvents lbApellido1 As Label
    Friend WithEvents lbNombre As Label
    Friend WithEvents cbxTipoUsuario As ComboBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtNickName As TextBox
    Friend WithEvents txtApellido2 As TextBox
    Friend WithEvents txtApellido1 As TextBox
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents btnComando As Button
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmLogin
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
        Me.txtNombreUsuario = New System.Windows.Forms.TextBox()
        Me.txtContraseña = New System.Windows.Forms.TextBox()
        Me.lbNombreUsuario = New System.Windows.Forms.Label()
        Me.lbContraseña = New System.Windows.Forms.Label()
        Me.ckbxMostrar = New System.Windows.Forms.CheckBox()
        Me.btnIngresar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'txtNombreUsuario
        '
        Me.txtNombreUsuario.Location = New System.Drawing.Point(177, 53)
        Me.txtNombreUsuario.Name = "txtNombreUsuario"
        Me.txtNombreUsuario.Size = New System.Drawing.Size(218, 22)
        Me.txtNombreUsuario.TabIndex = 0
        Me.txtNombreUsuario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtContraseña
        '
        Me.txtContraseña.Location = New System.Drawing.Point(177, 97)
        Me.txtContraseña.Name = "txtContraseña"
        Me.txtContraseña.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContraseña.Size = New System.Drawing.Size(218, 22)
        Me.txtContraseña.TabIndex = 1
        Me.txtContraseña.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lbNombreUsuario
        '
        Me.lbNombreUsuario.AutoSize = True
        Me.lbNombreUsuario.Location = New System.Drawing.Point(38, 56)
        Me.lbNombreUsuario.Name = "lbNombreUsuario"
        Me.lbNombreUsuario.Size = New System.Drawing.Size(133, 17)
        Me.lbNombreUsuario.TabIndex = 80
        Me.lbNombreUsuario.Text = "Nombre de usuario:"
        '
        'lbContraseña
        '
        Me.lbContraseña.AutoSize = True
        Me.lbContraseña.Location = New System.Drawing.Point(86, 100)
        Me.lbContraseña.Name = "lbContraseña"
        Me.lbContraseña.Size = New System.Drawing.Size(85, 17)
        Me.lbContraseña.TabIndex = 81
        Me.lbContraseña.Text = "Contraseña:"
        '
        'ckbxMostrar
        '
        Me.ckbxMostrar.AutoSize = True
        Me.ckbxMostrar.Location = New System.Drawing.Point(227, 137)
        Me.ckbxMostrar.Name = "ckbxMostrar"
        Me.ckbxMostrar.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.ckbxMostrar.Size = New System.Drawing.Size(168, 21)
        Me.ckbxMostrar.TabIndex = 4
        Me.ckbxMostrar.Text = "Mostrar la contraseña"
        Me.ckbxMostrar.UseVisualStyleBackColor = True
        '
        'btnIngresar
        '
        Me.btnIngresar.Location = New System.Drawing.Point(177, 184)
        Me.btnIngresar.Name = "btnIngresar"
        Me.btnIngresar.Size = New System.Drawing.Size(218, 29)
        Me.btnIngresar.TabIndex = 2
        Me.btnIngresar.Text = "Ingresar"
        Me.btnIngresar.UseVisualStyleBackColor = True
        '
        'frmLogin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(467, 262)
        Me.Controls.Add(Me.btnIngresar)
        Me.Controls.Add(Me.ckbxMostrar)
        Me.Controls.Add(Me.lbContraseña)
        Me.Controls.Add(Me.lbNombreUsuario)
        Me.Controls.Add(Me.txtContraseña)
        Me.Controls.Add(Me.txtNombreUsuario)
        Me.MaximizeBox = False
        Me.Name = "frmLogin"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Inicio de Sesión"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtNombreUsuario As TextBox
    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents lbNombreUsuario As Label
    Friend WithEvents lbContraseña As Label
    Friend WithEvents ckbxMostrar As CheckBox
    Friend WithEvents btnIngresar As Button
End Class

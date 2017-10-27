Public Class frmMantenimientoUsuarios

    Dim indice As Integer
    Public ID As Integer

    Private Sub frmMantenimientoUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub cbxOpciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOpciones.SelectedIndexChanged
        bloqueoCombo()
    End Sub

    Private Sub btnComando_Click(sender As Object, e As EventArgs) Handles btnComando.Click
        comando()
    End Sub

    Private Sub btnRegresar_Click(sender As Object, e As EventArgs) Handles btnRegresar.Click
        regresar()
    End Sub

    Private Sub btnNuevaOpcion_Click(sender As Object, e As EventArgs) Handles btnNuevaOpcion.Click
        nuevaOpcion()
    End Sub

    Private Sub frmMantenimientoUsuarios_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Private Sub dtgUsuarios_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgUsuarios.RowHeaderMouseClick

        indice = dtgUsuarios.CurrentRow.Index
        trasladaRegistros()
    End Sub

    Public Sub inicio()

        cbxOpciones.Items.Clear()
        cbxOpciones.Items.Add("Seleccione una opción")
        cbxOpciones.Items.Add("Agregar")
        cbxOpciones.Items.Add("Modificar")
        cbxOpciones.Items.Add("Eliminar")
        cbxOpciones.SelectedIndex = 0

        cbxTipoUsuario.Items.Clear()
        cbxTipoUsuario.Items.Add("Administrador")
        cbxTipoUsuario.Items.Add("Vendedor")

        gbxInfoUsuario.Enabled = False
        btnComando.Enabled = False
        btnNuevaOpcion.Enabled = False
        dtgUsuarios.Enabled = False
        muestraUsuarios()
    End Sub

    Public Sub bloqueoCombo()

        If (cbxOpciones.SelectedIndex > 0) Then

            dtgUsuarios.Enabled = True
            btnNuevaOpcion.Enabled = True
            cbxOpciones.Enabled = False
            btnComando.Text = cbxOpciones.Text
            If (cbxOpciones.Text.Equals("Agregar")) Then

                gbxInfoUsuario.Enabled = True
                txtNombre.Focus()
                btnComando.Enabled = True
            End If
        Else

            cbxOpciones.Enabled = True
            cbxOpciones.Focus()
        End If
    End Sub

    Public Sub muestraUsuarios()

        ModuloLogica.muestraUsuarios(dtgUsuarios)
        dtgUsuarios.Columns(0).HeaderText = "Código"
        dtgUsuarios.Columns(1).HeaderText = "Nombre"
        dtgUsuarios.Columns(2).HeaderText = "Apellido Paterno"
        dtgUsuarios.Columns(3).HeaderText = "Apellido Materno"
        dtgUsuarios.Columns(4).HeaderText = "NickName"
        dtgUsuarios.Columns(5).HeaderText = "Contraseña"
        dtgUsuarios.Columns(6).HeaderText = "Puesto del Usuario"
        dtgUsuarios.ClearSelection()
    End Sub

    Public Sub regresar()
        Dim menu As New frmMenuPrincipal
        menu.Show()
        Me.Hide()
    End Sub

    Public Sub nuevoUsuario()

        If (validaciones.Equals(True)) Then

            ModuloLogica.agregarUsuario(LTrim(RTrim(txtNombre.Text)), LTrim(RTrim(txtApellido1.Text)), LTrim(RTrim(txtApellido2.Text)), LTrim(RTrim(txtNickName.Text)), LTrim(RTrim(txtContraseña.Text)), cbxTipoUsuario.Text)
        End If
    End Sub

    Public Sub alterarUsuario()

        If (validaciones.Equals(True)) Then

            ModuloLogica.modificarUsuario(ID, LTrim(RTrim(txtNombre.Text)), LTrim(RTrim(txtApellido1.Text)), LTrim(RTrim(txtApellido2.Text)), LTrim(RTrim(txtNickName.Text)), LTrim(RTrim(txtContraseña.Text)), cbxTipoUsuario.Text)
        End If
    End Sub

    Public Sub limpiar()

        txtNombre.Clear()
        txtApellido1.Clear()
        txtApellido2.Clear()
        txtNickName.Clear()
        txtContraseña.Clear()
        cbxTipoUsuario.SelectedIndex = -1
    End Sub

    Public Sub nuevaOpcion()

        inicio()
        limpiar()
    End Sub

    Public Sub quitarUsuario()

        If (validaciones.Equals(True)) Then

            ModuloLogica.eliminarUsuario(ID)
        End If
    End Sub

    Public Sub comando()

        Select Case cbxOpciones.Text

            Case "Agregar"
                nuevoUsuario()

            Case "Modificar"
                alterarUsuario()

            Case "Eliminar"
                quitarUsuario()

        End Select

        muestraUsuarios()
        limpiar()
    End Sub

    Public Sub trasladaRegistros()

        If (cbxOpciones.Text <> "Agregar") Then

            ID = dtgUsuarios.Rows(indice).Cells(0).Value

            txtNombre.Text = dtgUsuarios.Rows(indice).Cells(1).Value
            txtApellido1.Text = dtgUsuarios.Rows(indice).Cells(2).Value
            txtApellido2.Text = dtgUsuarios.Rows(indice).Cells(3).Value
            txtNickName.Text = dtgUsuarios.Rows(indice).Cells(4).Value
            txtContraseña.Text = dtgUsuarios.Rows(indice).Cells(5).Value
            cbxTipoUsuario.Text = dtgUsuarios.Rows(indice).Cells(6).Value
            If (cbxOpciones.Text.Equals("Modificar")) Then

                gbxInfoUsuario.Enabled = True
            End If

            btnComando.Enabled = True
        End If
    End Sub

    Public Function validaciones() As Boolean

        If (LTrim(txtNombre.Text) <> String.Empty And LTrim(txtApellido1.Text) <> String.Empty And LTrim(txtApellido2.Text) <> String.Empty And LTrim(txtNickName.Text) <> String.Empty And LTrim(txtContraseña.Text) <> String.Empty And LTrim(cbxTipoUsuario.Text) <> String.Empty) Then

            If (IsNumeric(txtNombre.Text) Or IsNumeric(txtApellido1.Text) Or IsNumeric(txtApellido2.Text)) Then

                MsgBox("Revise que el formato de los datos a modificar sean correctos e intentelo nuevamente", vbCritical, "Comando NO Ejecutado")
                Return False
            Else

                Return True
            End If

        Else

            MsgBox("Has dejado espacios en blanco, intentalo nuevamente", vbInformation, "Datos Incompletos")
            Return False
        End If
    End Function

End Class
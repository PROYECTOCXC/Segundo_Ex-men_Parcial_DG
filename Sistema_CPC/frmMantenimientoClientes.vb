Public Class frmMantenimientoClientes

    Dim indice As Integer
    Public ID As Integer

    Private Sub frmMantenimientoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dtpFechaNacimiento.MaxDate = Now.Date
        dtpFechaNacimiento.MinDate = "01/01/1900"
        dtpFechaNacimiento.Value = Now.Date
        inicio()
    End Sub

    Private Sub cbxOpciones_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbxOpciones.SelectedIndexChanged
        comportamientoCombo()
    End Sub

    Private Sub btnComando_Click(sender As Object, e As EventArgs) Handles btnComando.Click
        comando()
    End Sub

    Private Sub btnVolver_Click(sender As Object, e As EventArgs) Handles btnVolver.Click
        regresar()
    End Sub

    Private Sub btnNuevaOpcion_Click(sender As Object, e As EventArgs) Handles btnNuevaOpcion.Click
        inicio()
        limpiar()
    End Sub

    Private Sub dtgClientes_RowHeaderMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles dtgClientes.RowHeaderMouseClick

        indice = dtgClientes.CurrentRow.Index
        trasladoRegistros()
    End Sub

    Private Sub frmMantenimientoClientes_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

    Public Sub inicio()

        actualizarClientes()
        cbxOpciones.Items.Clear()
        cbxOpciones.Items.Add("Seleccione una opción")
        cbxOpciones.Items.Add("Agregar")
        cbxOpciones.Items.Add("Modificar")
        cbxOpciones.Items.Add("Eliminar")

        bloqueos()
        cbxOpciones.Focus()
        btnComando.Text = ""
        cbxOpciones.SelectedIndex = 0
    End Sub

    Public Sub comportamientoCombo()

        If (cbxOpciones.SelectedIndex > 0) Then

            dtgClientes.Enabled = True
            cbxOpciones.Enabled = False
            btnComando.Text = cbxOpciones.Text
            btnNuevaOpcion.Enabled = True
            If (cbxOpciones.Text.Equals("Agregar")) Then

                gbxInfoCliente.Enabled = True
                btnComando.Enabled = True
                dtpFechaNacimiento.Enabled = True
            Else

                gbxInfoCliente.Enabled = False
            End If
        Else

            cbxOpciones.Enabled = True
        End If
    End Sub

    Public Sub actualizarClientes()

        ModuloLogica.muestraClientes(dtgClientes)
        dtgClientes.Columns(0).HeaderText = "Código"
        dtgClientes.Columns(1).HeaderText = "Nombre"
        dtgClientes.Columns(2).HeaderText = "Apellido Paterno"
        dtgClientes.Columns(3).HeaderText = "Apellido Materno"
        dtgClientes.Columns(4).HeaderText = "Identificación"
        dtgClientes.Columns(5).HeaderText = "Salario Neto"
        dtgClientes.Columns(6).HeaderText = "Fecha de Nacimiento"
        dtgClientes.Columns(7).HeaderText = "Límite Crediticio"
        dtgClientes.Columns(8).HeaderText = "Dirección"
        dtgClientes.Columns(9).Visible = False
        dtgClientes.Columns(10).Visible = False
        dtgClientes.ClearSelection()
    End Sub

    Public Sub trasladoRegistros()

        If (cbxOpciones.Text <> "Agregar") Then

            ID = dtgClientes.Rows(indice).Cells(0).Value

            txtNombre.Text = dtgClientes.Rows(indice).Cells(1).Value
            txtApellido1.Text = dtgClientes.Rows(indice).Cells(2).Value
            txtApellido2.Text = dtgClientes.Rows(indice).Cells(3).Value
            txtIdentificacion.Text = dtgClientes.Rows(indice).Cells(4).Value
            txtSalario.Text = dtgClientes.Rows(indice).Cells(5).Value
            dtpFechaNacimiento.Value = dtgClientes.Rows(indice).Cells(6).Value
            txtLimiteCredito.Text = dtgClientes.Rows(indice).Cells(7).Value
            txtDireccion.Text = dtgClientes.Rows(indice).Cells(8).Value

            btnComando.Enabled = True
            If (cbxOpciones.Text.Equals("Eliminar")) Then

                gbxInfoCliente.Enabled = False
                dtpFechaNacimiento.Enabled = False
            Else

                gbxInfoCliente.Enabled = True
                dtpFechaNacimiento.Enabled = True
                txtNombre.Focus()
            End If
        End If
    End Sub

    Public Sub limpiar()

        txtNombre.Clear()
        txtApellido1.Clear()
        txtApellido2.Clear()
        txtIdentificacion.Clear()
        txtLimiteCredito.Clear()
        txtSalario.Clear()
        txtDireccion.Clear()
        dtpFechaNacimiento.Value = Now.Date

        If (cbxOpciones.Text.Equals("Agregar")) Then

            txtNombre.Focus()
        End If
    End Sub

    Public Sub regresar()

        Dim menu As New frmMenuPrincipal
        menu.Show()
        Me.Hide()
    End Sub

    Public Sub insertarCliente()

        If (validaciones.Equals(True)) Then

            ModuloLogica.agregarCliente(LTrim(RTrim(txtNombre.Text)), LTrim(RTrim(txtApellido1.Text)), LTrim(RTrim(txtApellido2.Text)), LTrim(RTrim(txtIdentificacion.Text)), LTrim(RTrim(txtSalario.Text)), LTrim(RTrim(dtpFechaNacimiento.Value)), LTrim(RTrim(txtLimiteCredito.Text)), LTrim(RTrim(txtDireccion.Text)))
        End If
    End Sub

    Public Sub modificarCliente()

        If (validaciones.Equals(True)) Then

            ModuloLogica.modificarCliente(ID, LTrim(RTrim(txtNombre.Text)), LTrim(RTrim(txtApellido1.Text)), LTrim(RTrim(txtApellido2.Text)), LTrim(RTrim(txtIdentificacion.Text)), LTrim(RTrim(txtSalario.Text)), LTrim(RTrim(dtpFechaNacimiento.Value)), LTrim(RTrim(txtLimiteCredito.Text)), LTrim(RTrim(txtDireccion.Text)))
        End If
    End Sub

    Public Sub eliminarCliente()

        If (validaciones.Equals(True)) Then

            ModuloLogica.eliminarCliente(ID)
        End If
    End Sub

    Public Function validaciones() As Boolean

        If (LTrim(txtNombre.Text) <> String.Empty And LTrim(txtApellido1.Text) <> String.Empty And LTrim(txtApellido2.Text) <> String.Empty And LTrim(txtIdentificacion.Text) <> String.Empty And LTrim(txtLimiteCredito.Text) <> String.Empty And LTrim(txtSalario.Text) <> String.Empty And LTrim(txtDireccion.Text) <> String.Empty) Then

            If (IsNumeric(txtNombre.Text) Or IsNumeric(txtApellido1.Text) Or IsNumeric(txtApellido2.Text)) Then

                MsgBox("Revise que el formato de los datos a modificar sean correctos e intentelo nuevamente", vbCritical, "Comando NO Ejecutado")
                Return False
            Else

                If (IsNumeric(txtIdentificacion.Text) And IsNumeric(txtLimiteCredito.Text) And IsNumeric(txtSalario.Text)) Then

                    Return True
                Else

                    MsgBox("Revise que el formato de los datos a modificar sean correctos e intentelo nuevamente", vbCritical, "Comando NO Ejecutado")
                    Return False
                End If

            End If

        Else

            MsgBox("Has dejado espacios en blanco, intentalo nuevamente", vbInformation, "Datos Incompletos")
            Return False
        End If
    End Function

    Public Sub comando()

        Select Case cbxOpciones.Text

            Case "Agregar"
                insertarCliente()

            Case "Modificar"
                Me.modificarCliente()

            Case "Eliminar"
                Me.eliminarCliente()

        End Select

        actualizarClientes()
        limpiar()
    End Sub

    Public Sub bloqueos()

        gbxInfoCliente.Enabled = False
        btnNuevaOpcion.Enabled = False
        btnComando.Enabled = False
        dtgClientes.Enabled = False
    End Sub

End Class
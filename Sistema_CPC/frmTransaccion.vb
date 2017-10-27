Public Class frmTransaccion

#Region "Variables"
    Dim evento As Boolean = False

    Dim usuario As String
    Dim idUsu As Integer

    Dim cliente As String
    Dim idCli As Integer

    Dim idCre As Integer

    Dim indiceCliente As Integer
    Dim indiceCredito As Integer

    Dim montoTotal As Double
    Dim montoPendiente As Double
    Dim cuotas As Double
    Dim saldoCrediticio As Double
    Dim nuevoSaldoCrediticio As Double
    Dim plazo As Integer

    Dim fecha As Date
#End Region

#Region "Métodos"
    Public Function calculoCuotas(ByVal monto As Double, ByVal plazo As Integer) As Double

        Dim cuota As Double
        cuota = monto / plazo

        Return cuota
    End Function

    Public Function actualizarSaldoCrediticio(ByVal sCrediticio As Double, ByVal monto As Double) As Double

        Dim saldoCrediticio As Double
        saldoCrediticio = sCrediticio - monto

        Return saldoCrediticio
    End Function

    Public Function calculoSaldoCrediticio(ByVal cuota As Double, ByVal saldoCrediticio As Double) As Double

        Dim sCrediticio As Double
        sCrediticio = saldoCrediticio + cuota

        Return sCrediticio
    End Function

    Public Sub trasladaDatos()

        btnComando.Enabled = True
        If (evento.Equals(True)) Then

            idCli = dtgClientes.Rows(indiceCliente).Cells(0).Value
            txtCliente.Text = dtgClientes.Rows(indiceCliente).Cells(1).Value + " " + dtgClientes.Rows(indiceCliente).Cells(2).Value + " " + dtgClientes.Rows(indiceCliente).Cells(3).Value
            txtSaldoCrediticio.Text = dtgClientes.Rows(indiceCliente).Cells(8).Value
            gbxTransaccion.Enabled = True
            txtMontoTotal.Enabled = True
            txtMontoTotal.Focus()
        Else

            idCre = dtgCreditos.Rows(indiceCredito).Cells(0).Value
            idCli = dtgCreditos.Rows(indiceCredito).Cells(1).Value
            txtCliente.Text = dtgCreditos.Rows(indiceCredito).Cells(2).Value
            txtMontoPendiente.Text = dtgCreditos.Rows(indiceCredito).Cells(4).Value
            txtSaldoCrediticio.Text = dtgCreditos.Rows(indiceCredito).Cells(5).Value
            txtCuotas.Text = dtgCreditos.Rows(indiceCredito).Cells(6).Value
            btnComando.Focus()
        End If

    End Sub

    Public Sub actualizaClientes()

        ModuloLogica.muestraClientes(dtgClientes)
        dtgClientes.Columns(0).HeaderText = "Código"
        dtgClientes.Columns(1).HeaderText = "Nombre"
        dtgClientes.Columns(2).HeaderText = "Apellido Paterno"
        dtgClientes.Columns(3).HeaderText = "Apellido Materno"
        dtgClientes.Columns(4).HeaderText = "Identificación"
        dtgClientes.Columns(5).HeaderText = "Fecha Nacimiento"
        dtgClientes.Columns(6).HeaderText = "Salario Neto"
        dtgClientes.Columns(7).HeaderText = "Límite Crediticio"
        dtgClientes.Columns(8).HeaderText = "Saldo Crediticio"
        dtgClientes.Columns(9).HeaderText = "Dirección"
        dtgClientes.Columns(10).Visible = False
        dtgClientes.ClearSelection()
    End Sub

    Public Sub actualizaCreditos()

        ModuloLogica.muestraCreditos(dtgCreditos)
        dtgCreditos.Columns(0).HeaderText = "Código Crédito"
        dtgCreditos.Columns(1).HeaderText = "Código Cliente"
        dtgCreditos.Columns(2).HeaderText = "Cliente"
        dtgCreditos.Columns(3).HeaderText = "Monto Total"
        dtgCreditos.Columns(4).HeaderText = "Monto Pendiente"
        dtgCreditos.Columns(5).HeaderText = "Saldo Crediticio"
        dtgCreditos.Columns(6).HeaderText = "Cuotas"
        dtgCreditos.Columns(7).HeaderText = "Plazo (Meses)"
        dtgCreditos.Columns(8).HeaderText = "Inicio Crédito"
        dtgCreditos.ClearSelection()
    End Sub

    Public Sub inicio()

        txtFechaInicial.Text = Now.Date
        usuario = ModuloLogica.usuario
        txtUsuario.Text = usuario
        idUsu = ModuloLogica.idUsuario

        actualizaCreditos()
        actualizaClientes()
        limpiar()
        bloqueos()
    End Sub

    Public Sub desbloqueos()

        If (evento.Equals(True)) Then 'Si se presiona la opción de nuevo crédito

            dtgClientes.Enabled = True
            btnComando.Text = "Generar Crédito"
        Else

            dtgCreditos.Enabled = True
            btnComando.Text = "Generar Abono"
            lbMontoTotal.Visible = False
            txtMontoTotal.Visible = False
            lbPlazo.Visible = False
            txtPlazo.Visible = False
        End If

        mstOpciones.Enabled = False
        btnCancelar.Enabled = True
    End Sub

    Public Sub bloqueos()

        gbxTransaccion.Enabled = False
        btnComando.Enabled = False
        btnCancelar.Enabled = False
        dtgClientes.Enabled = False
        dtgCreditos.Enabled = False

        lbMontoTotal.Visible = True
        txtMontoTotal.Visible = True
        lbPlazo.Visible = True
        txtPlazo.Visible = True
    End Sub

    Public Sub limpiar()

        txtMontoTotal.Text = 0
        txtMontoPendiente.Text = 0
        txtPlazo.Text = 0
        txtCuotas.Text = 0
        txtSaldoCrediticio.Text = 0
        txtCliente.Clear()

        indiceCliente = -1
        indiceCredito = -1
    End Sub

    Public Sub generarCredito()

        If IsNumeric(txtMontoTotal.Text) And IsNumeric(txtPlazo.Text) Then

            montoTotal = Convert.ToDouble(txtMontoTotal.Text)
            montoPendiente = Convert.ToDouble(txtMontoPendiente.Text)
            cuotas = Convert.ToInt32(txtCuotas.Text)
            plazo = Convert.ToInt32(txtPlazo.Text)
            fecha = Convert.ToDateTime(txtFechaInicial.Text).Date
            saldoCrediticio = Convert.ToDouble(txtSaldoCrediticio.Text)
            If (montoTotal <> 0 And plazo <> 0) Then

                ModuloLogica.agregarCredito(montoTotal, montoPendiente, cuotas, plazo, fecha, idUsu, idCli, saldoCrediticio)
            Else

                MsgBox("Debes ingresar los datos que se solicitan para poder continuar", vbInformation, "Datos del Crédito Incompletos")
            End If
        Else

            MsgBox("El formato de alguno de los datos es incorrecto, verifique lo que ingresó y corríjalo", vbCritical, "Formato de Datos Incorrecto")
        End If
    End Sub

    Public Sub generarAbono()

        fecha = Convert.ToDateTime(txtFechaInicial.Text).Date
        montoPendiente = Convert.ToDouble(txtMontoPendiente.Text)
        cuotas = Convert.ToDouble(txtCuotas.Text)
        saldoCrediticio = Convert.ToDouble(txtSaldoCrediticio.Text)
        nuevoSaldoCrediticio = calculoSaldoCrediticio(cuotas, saldoCrediticio)
        MsgBox(nuevoSaldoCrediticio)
        ModuloLogica.agregarAbono(idCre, fecha, montoPendiente, idCli, nuevoSaldoCrediticio)
    End Sub
#End Region

#Region "Eventos de controles"
    Private Sub txtMontoTotal_TextChanged(sender As Object, e As EventArgs) Handles txtMontoTotal.TextChanged

        If (txtMontoTotal.Text <> String.Empty) Then

            txtSaldoCrediticio.Text = dtgClientes.Rows(indiceCliente).Cells(8).Value
            montoTotal = Convert.ToDouble(txtMontoTotal.Text)
            saldoCrediticio = Convert.ToDouble(txtSaldoCrediticio.Text)
            If (saldoCrediticio - montoTotal < 0) Then

                MsgBox("El saldo crediticio actual es insuficiente para generar éste crédito", vbCritical, "Saldo Crediticio Insuficiente")
                txtMontoTotal.Text = 0
            Else

                txtMontoPendiente.Text = txtMontoTotal.Text
            End If
        Else
            txtMontoTotal.Text = 0
        End If
    End Sub

    Private Sub dtgClientes_SelectionChanged(sender As Object, e As EventArgs) Handles dtgClientes.SelectionChanged

        indiceCliente = dtgClientes.CurrentRow.Index
        evento = True
        trasladaDatos()
    End Sub

    Private Sub dtgCreditos_SelectionChanged(sender As Object, e As EventArgs) Handles dtgCreditos.SelectionChanged

        indiceCredito = dtgCreditos.CurrentRow.Index
        evento = False
        trasladaDatos()
    End Sub

    Private Sub frmTransaccion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        inicio()
    End Sub

    Private Sub smiNuevoCredito_Click(sender As Object, e As EventArgs) Handles smiNuevoCredito.Click
        evento = True
        desbloqueos()
    End Sub

    Private Sub smiNuevoAbono_Click(sender As Object, e As EventArgs) Handles smiNuevoAbono.Click
        evento = False
        desbloqueos()
    End Sub

    Private Sub txtPlazo_TextChanged(sender As Object, e As EventArgs) Handles txtPlazo.TextChanged

        If (txtMontoTotal.Text <> String.Empty And txtPlazo.Text <> String.Empty) Then

            plazo = Convert.ToInt32(txtPlazo.Text)
            montoTotal = Convert.ToDouble(txtMontoTotal.Text)
            txtCuotas.Text = calculoCuotas(montoTotal, plazo).ToString
        Else

            txtCuotas.Text = 0
            txtPlazo.Text = 0
        End If

    End Sub

    Private Sub txtMontoTotal_Leave(sender As Object, e As EventArgs) Handles txtMontoTotal.Leave

        If (Convert.ToDouble(txtMontoTotal.Text) > 0) Then

            montoTotal = Convert.ToDouble(txtMontoTotal.Text)
            saldoCrediticio = Convert.ToDouble(txtSaldoCrediticio.Text)
            If (saldoCrediticio - montoTotal < 0) Then

                MsgBox("El saldo crediticio actual es insuficiente para generar éste crédito", vbCritical, "Saldo Crediticio Insuficiente")
                txtMontoTotal.Text = 0
            Else

                txtMontoTotal.Enabled = False
                txtMontoPendiente.Text = txtMontoTotal.Text
                txtSaldoCrediticio.Text = actualizarSaldoCrediticio(saldoCrediticio, montoTotal)
            End If
        Else

            txtMontoTotal.Focus()
        End If
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click

        inicio()
        btnCancelar.Enabled = False
        mstOpciones.Enabled = True
    End Sub

    Private Sub btnComando_Click(sender As Object, e As EventArgs) Handles btnComando.Click

        If (btnComando.Text.Equals("Generar Crédito")) Then

            generarCredito()
        Else

            generarAbono()
        End If

        actualizaClientes()
        actualizaCreditos()
        limpiar()
    End Sub
#End Region

End Class
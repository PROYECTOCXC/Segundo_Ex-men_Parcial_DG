Public Class frmMenuPrincipal

    Private Sub frmMenuPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        inicio()
    End Sub

    Private Sub btnSalir_Click(sender As Object, e As EventArgs) Handles btnSalir.Click
        regresar()
    End Sub

    Public Sub inicio()

        lbFecha.Text = ModuloLogica.fecha
        lbUsuario.Text = ModuloLogica.tipoUsuario + ": " + ModuloLogica.usuario
        If (ModuloLogica.restricciones = True) Then

            imsMantenimientoUsuarios.Enabled = False
        End If
    End Sub

    Public Sub regresar()

        Dim login As New frmLogin
        login.Show()
        Me.Hide()
    End Sub

#Region "Reportes"
    'Private Sub imsReportes_Click(sender As Object, e As EventArgs) Handles imsReportes.Click

    '    abrirReportes()
    'End Sub

    'Public Sub abrirReportes()

    '    Dim reportes As New frmReportes
    '    reportes.Show()
    '    Me.Hide()
    'End Sub
#End Region

#Region "Transacción"
    Private Sub imsTransaccion_Click(sender As Object, e As EventArgs) Handles imsTransaccion.Click
        abrirTransaccion()
    End Sub

    Public Sub abrirTransaccion()

        Dim transaccion As New frmTransaccion
        transaccion.Show()
        Me.Hide()
    End Sub
#End Region

#Region "Mantenimiento de usuarios"
    Private Sub itUsuarios_Click(sender As Object, e As EventArgs) Handles itUsuarios.Click
        mantenimientoUsuarios()
    End Sub

    Private Sub itClientes_Click(sender As Object, e As EventArgs) Handles itClientes.Click
        mantenimientoClientes()
    End Sub

    Public Sub mantenimientoUsuarios()

        Dim mantenimientoUsu As New frmMantenimientoUsuarios
        mantenimientoUsu.Show()
        Me.Hide()
    End Sub

    Public Sub mantenimientoClientes()

        Dim mantenimientoCli As New frmMantenimientoClientes
        mantenimientoCli.Show()
        Me.Hide()
    End Sub
#End Region

    Private Sub frmMenuPrincipal_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

End Class
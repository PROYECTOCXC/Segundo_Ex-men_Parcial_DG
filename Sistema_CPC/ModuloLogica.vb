Module ModuloLogica

    Dim BD_CXC As New BD_CPCEntities1
    Dim clsBD As New clsBD_CXCDataContext
    Public idUsuario As Integer

#Region "Variables Login"
    Public usuario As String
    Public tipoUsuario As String
    Public restricciones As Boolean
#End Region

#Region "Variables Menú"
    Public tipoReporte As String
    Public tipoTransaccion As String
    Public fecha As Date = Now.Date
#End Region

    Public Function validaIngreso(ByVal nickname As String, ByVal contraseña As String) As Boolean

        Try

            Dim cuenta = (From dato In BD_CXC.Usu_Usuarios Where dato.Usu_Nick.ToUpper = nickname.ToUpper Select dato).FirstOrDefault
            If (cuenta.Usu_Contraseña.Equals(contraseña)) Then

                usuario = cuenta.Usu_Nombre + " " + cuenta.Usu_Primer_Apellido + " " + cuenta.Usu_Segundo_Apellido
                idUsuario = cuenta.ID
                tipoUsuario = cuenta.Tip_Tipos_Usuarios.Tip_Puesto
                If (tipoUsuario.Equals("Administrador")) Then

                    restricciones = False
                Else

                    restricciones = True
                End If
                Return True
            Else

                MsgBox("La contraseña ingresada no corresponde a la cuenta ingresada, porfavor intentelo nuevamente", vbCritical, "CONTRASEÑA INCORRECTA")
                Return False
            End If

        Catch ex As Exception

            MsgBox("La cuenta ingresada no exíste, porfavor verifique los datos que está ingresando", vbCritical, "CUENTA INCORRECTA")
            Return False
        End Try

    End Function

#Region "Vistas"
    Public Sub muestraClientes(ByVal tabla As Object)

        Dim usuarios = From registros In BD_CXC.Cli_Clientes Select registros
        tabla.DataSource = usuarios.ToList()
    End Sub

    Public Sub muestraUsuarios(ByVal tabla As Object)

        tabla.DataSource = clsBD.muestraUsuarios.ToList()
    End Sub

    Public Sub muestraCreditos(ByVal tabla As Object)

        tabla.DataSource = clsBD.muestraCreditos.ToList()
    End Sub

    Public Sub muestraAbonos(ByVal tabla As Object)

        tabla.DataSource = clsBD.muestraAbonos.ToList()
    End Sub
#End Region

#Region "Mantenimiento"

#Region "De usuarios"
    Public Sub agregarUsuario(ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal nick As String, ByVal contraseña As String, ByVal tipo As String)

        Try

            Dim insert As New Usu_Usuarios

            insert.Usu_Nombre = nombre
            insert.Usu_Primer_Apellido = apellido1
            insert.Usu_Segundo_Apellido = apellido2
            insert.Usu_Nick = nick
            insert.Usu_Contraseña = contraseña
            If (tipo.Equals("Administrador")) Then

                insert.Tip_ID_Tipo_Usuario = 1
            ElseIf (tipo.Equals("Vendedor")) Then

                insert.Tip_ID_Tipo_Usuario = 2
            End If
            BD_CXC.Usu_Usuarios.Add(insert)
            BD_CXC.SaveChanges()
            MsgBox("Usuario registrado con éxito", vbOKOnly, "Comando Ejecutado")

        Catch ex As Exception

            MsgBox("No se pudo registrar el nuevo usuario", vbCritical, "Comando NO Ejecutado")
        End Try
    End Sub

    Public Sub modificarUsuario(ByVal id As Integer, ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal nickname As String, ByVal contraseña As String, ByVal tipo As String)

        Try

            Dim update = (From dato In BD_CXC.Usu_Usuarios Where dato.ID = id Select dato).FirstOrDefault

            update.Usu_Nombre = nombre
            update.Usu_Primer_Apellido = apellido1
            update.Usu_Segundo_Apellido = apellido2
            update.Usu_Nick = nickname
            update.Usu_Contraseña = contraseña
            If (tipo.Equals("Administrador")) Then

                update.Tip_ID_Tipo_Usuario = 1
            ElseIf (tipo.Equals("Vendedor")) Then

                update.Tip_ID_Tipo_Usuario = 2
            End If

            BD_CXC.SaveChanges()
            MsgBox("Usuario modificado", vbOKOnly, "Comando Ejecutado")

        Catch ex As Exception

            MsgBox("Ha ocurrido un error durante la modificación" + vbCrLf + "Revise que el formato de los datos a modificar sean correctos", vbCritical, "Comando NO Ejecutado")
        End Try
    End Sub

    Public Sub eliminarUsuario(ByVal id As Integer)

        Try

            Dim usuario = (From dato In BD_CXC.Usu_Usuarios Where dato.ID = id Select dato).FirstOrDefault
            BD_CXC.Usu_Usuarios.Remove(usuario)
            BD_CXC.SaveChanges()

            MsgBox("Se ha dado de baja a un usuario", vbInformation, "Comando Ejecutado")
        Catch ex As Exception

            MsgBox("Se ha producido un error", vbInformation, "Comando NO Ejecutado")
        End Try
    End Sub
#End Region

#Region "De clientes"
    Public Sub agregarCliente(ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal identificacion As String, ByVal salario As Double, ByVal fechaNacimiento As Date, ByVal limiteCrediticio As Double, ByVal direccion As String)

        Try

            Dim insert As New Cli_Clientes

            insert.Cli_Nombre = nombre
            insert.Cli_Primer_Apellido = apellido1
            insert.Cli_Segundo_Apellido = apellido2
            insert.Cli_Identificacion = identificacion
            insert.Cli_Salario_Neto = salario
            insert.Cli_Fecha_Nacimiento = fechaNacimiento
            insert.Cli_Limite_Crediticio = limiteCrediticio
            insert.Cli_Direccion = direccion

            BD_CXC.Cli_Clientes.Add(insert)
            BD_CXC.SaveChanges()
            MsgBox("Cliente registrado con éxito", vbOKOnly, "Comando Ejecutado")

        Catch ex As Exception

            MsgBox("No se pudo registrar el nuevo cliente", vbCritical, "Comando NO Ejecutado")
        End Try
    End Sub

    Public Sub modificarCliente(ByVal id As Integer, ByVal nombre As String, ByVal apellido1 As String, ByVal apellido2 As String, ByVal identificacion As String, ByVal salario As Double, ByVal fechaNacimiento As Date, ByVal limiteCrediticio As Double, ByVal direccion As String)

        Try

            Dim update = (From dato In BD_CXC.Cli_Clientes Where dato.ID = id Select dato).FirstOrDefault

            update.Cli_Nombre = nombre
            update.Cli_Primer_Apellido = apellido1
            update.Cli_Segundo_Apellido = apellido2
            update.Cli_Identificacion = identificacion
            update.Cli_Salario_Neto = salario
            update.Cli_Fecha_Nacimiento = fechaNacimiento
            update.Cli_Limite_Crediticio = limiteCrediticio
            update.Cli_Direccion = direccion

            BD_CXC.SaveChanges()
            MsgBox("Cliente modificado", vbOKOnly, "Comando Ejecutado")

        Catch ex As Exception

            MsgBox("Ha ocurrido un error durante la modificación" + vbCrLf + "Revise que el formato de los datos a modificar sean correctos", vbCritical, "Comando NO Ejecutado")
        End Try
    End Sub

    Public Sub eliminarCliente(ByVal id As Integer)

        Try

            Dim cliente = (From dato In BD_CXC.Cli_Clientes Where dato.ID = id Select dato).FirstOrDefault
            BD_CXC.Cli_Clientes.Remove(cliente)
            BD_CXC.SaveChanges()

            MsgBox("Se ha dado de baja a un cliente", vbInformation, "Comando Ejecutado")
        Catch ex As Exception

            MsgBox("Se ha producido un error", vbInformation, "Comando NO Ejecutado")
        End Try
    End Sub
#End Region

#End Region

#Region "Transaccion"
    Public Sub agregarCredito(ByVal montoTotal As Double, ByVal montoPendiente As Double, ByVal cuotas As Double, ByVal plazo As Integer, ByVal fecha As Date, ByVal idUsuario As Integer, ByVal idCliente As Integer, ByVal saldoCrediticio As Double)

        Try

            Dim registro As New Cre_Creditos

            registro.Cre_Monto_Total = montoTotal
            registro.Cre_Monto_Pendiente = montoPendiente
            registro.Cre_Cuotas = cuotas
            registro.Cre_Plazo = plazo
            registro.Cre_Fecha_Inicial = fecha
            registro.Usu_ID_Usuario = idUsuario
            registro.Cli_ID_Cliente = idCliente

            BD_CXC.Cre_Creditos.Add(registro)
            BD_CXC.SaveChanges()

            Dim actualizacion = (From dato In BD_CXC.Cli_Clientes Where dato.ID = idCliente Select dato).FirstOrDefault

            actualizacion.Cli_Saldo_Crediticio = saldoCrediticio
            BD_CXC.SaveChanges()

            MsgBox("Crédito agregado con éxito", vbInformation, "Comando Ejecutado")
        Catch ex As Exception

            MsgBox("Error al intentar agregar el crédito, verifique que todos los datos se encuentren correctamente ingresados y vuelva a intentarlo", vbInformation, "Comando NO Ejecutado")
        End Try
    End Sub

    Public Sub agregarAbono(ByVal idCredito As Integer, ByVal fecha As Date, ByVal montoPendiente As Double, ByVal idCliente As Integer, ByVal saldoCrediticio As Double)

        Try

            'Dim registro As New Abo_Abonos

            'registro.Abo_Fecha = fecha
            'registro.Cre_ID_Credito = idCredito

            'BD_CXC.Abo_Abonos.Add(registro)
            'BD_CXC.SaveChanges()

            clsBD.actualizarCredito(idCredito, montoPendiente)
            clsBD.actualizarSaldoCrediticio(idCliente, saldoCrediticio)

            MsgBox("Se ha registrado un abono con éxito", vbInformation, "Comando Ejecutado")
        Catch ex As Exception

            MsgBox("Error al registrar un abono, verifique que todos los datos se encuentren debidamente ingresados y vuelva  intentarlo", vbInformation, "Comando NO Ejecutado")
        End Try
    End Sub
#End Region

End Module

Public Class frmLogin

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        ingresar()
    End Sub

    Private Sub ckbxRecordar_CheckedChanged(sender As Object, e As EventArgs) Handles ckbxMostrar.CheckedChanged
        mostrarContraseña()
    End Sub

    Public Sub limpiar()

        txtNombreUsuario.Clear()
        txtContraseña.Clear()
        ckbxMostrar.Checked = False
        txtNombreUsuario.Focus()
    End Sub

    Public Sub ingresar()

        If (txtNombreUsuario.Text <> String.Empty And txtContraseña.Text <> String.Empty) Then

            If (ModuloLogica.validaIngreso(txtNombreUsuario.Text, txtContraseña.Text) = True) Then

                Dim menu As New frmMenuPrincipal
                Me.Hide()
                menu.Show()
            Else

                limpiar()
            End If
        Else

            MsgBox("Debes ingresar los datos que se solicitan de una cuenta existente actualmente", vbInformation, "DATOS INCOMPLETOS")
        End If

    End Sub

    Public Sub mostrarContraseña()

        If (ckbxMostrar.Checked = True) Then

            txtContraseña.PasswordChar = ""
        Else

            txtContraseña.PasswordChar = "*"
        End If

    End Sub

    Private Sub frmLogin_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        End
    End Sub

End Class

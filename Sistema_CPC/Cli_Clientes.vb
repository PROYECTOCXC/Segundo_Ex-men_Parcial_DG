'------------------------------------------------------------------------------
' <auto-generated>
'     Este código se generó a partir de una plantilla.
'
'     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
'     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Cli_Clientes
    Public Property ID As Integer
    Public Property Cli_Nombre As String
    Public Property Cli_Primer_Apellido As String
    Public Property Cli_Segundo_Apellido As String
    Public Property Cli_Identificacion As String
    Public Property Cli_Fecha_Nacimiento As Date
    Public Property Cli_Salario_Neto As Decimal
    Public Property Cli_Limite_Crediticio As Decimal
    Public Property Cli_Saldo_Crediticio As Decimal
    Public Property Cli_Direccion As String

    Public Overridable Property Cre_Creditos As ICollection(Of Cre_Creditos) = New HashSet(Of Cre_Creditos)

End Class
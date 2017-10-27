﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict On
Option Explicit On

Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Data.Linq
Imports System.Data.Linq.Mapping
Imports System.Linq
Imports System.Linq.Expressions
Imports System.Reflection


<Global.System.Data.Linq.Mapping.DatabaseAttribute(Name:="BD_CPC")>  _
Partial Public Class clsBD_CXCDataContext
	Inherits System.Data.Linq.DataContext
	
	Private Shared mappingSource As System.Data.Linq.Mapping.MappingSource = New AttributeMappingSource()
	
  #Region "Definiciones de métodos de extensibilidad"
  Partial Private Sub OnCreated()
  End Sub
  #End Region
	
	Public Sub New()
		MyBase.New(Global.Sistema_CPC.My.MySettings.Default.BD_CPCConnectionString, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As String, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	Public Sub New(ByVal connection As System.Data.IDbConnection, ByVal mappingSource As System.Data.Linq.Mapping.MappingSource)
		MyBase.New(connection, mappingSource)
		OnCreated
	End Sub
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.actualizarCredito")>  _
	Public Function actualizarCredito(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ID_Credito", DbType:="Int")> ByVal iD_Credito As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Nuevo_Monto_Pendiente", DbType:="Money")> ByVal nuevo_Monto_Pendiente As System.Nullable(Of Decimal)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), iD_Credito, nuevo_Monto_Pendiente)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.actualizarSaldoCrediticio")>  _
	Public Function actualizarSaldoCrediticio(<Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="ID_Cliente", DbType:="Int")> ByVal iD_Cliente As System.Nullable(Of Integer), <Global.System.Data.Linq.Mapping.ParameterAttribute(Name:="Nuevo_Saldo", DbType:="Money")> ByVal nuevo_Saldo As System.Nullable(Of Decimal)) As Integer
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo), iD_Cliente, nuevo_Saldo)
		Return CType(result.ReturnValue,Integer)
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.muestraClientes")>  _
	Public Function muestraClientes() As ISingleResult(Of muestraClientesResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of muestraClientesResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.muestraCreditos")>  _
	Public Function muestraCreditos() As ISingleResult(Of muestraCreditosResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of muestraCreditosResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.muestraUsuarios")>  _
	Public Function muestraUsuarios() As ISingleResult(Of muestraUsuariosResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of muestraUsuariosResult))
	End Function
	
	<Global.System.Data.Linq.Mapping.FunctionAttribute(Name:="dbo.muestraAbonos")>  _
	Public Function muestraAbonos() As ISingleResult(Of muestraAbonosResult)
		Dim result As IExecuteResult = Me.ExecuteMethodCall(Me, CType(MethodInfo.GetCurrentMethod,MethodInfo))
		Return CType(result.ReturnValue,ISingleResult(Of muestraAbonosResult))
	End Function
End Class

Partial Public Class muestraClientesResult
	
	Private _Código As Integer
	
	Private _Cliente As String
	
	Private _Identificación As String
	
	Private _Fecha_de_Nacimiento As Date
	
	Private _Salario_Neto As Decimal
	
	Private _Límite_Crediticio As Decimal
	
	Private _Saldo_Crediticio As Decimal
	
	Private _Dirección As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Código", DbType:="Int NOT NULL")>  _
	Public Property Código() As Integer
		Get
			Return Me._Código
		End Get
		Set
			If ((Me._Código = value)  _
						= false) Then
				Me._Código = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cliente", DbType:="NVarChar(72) NOT NULL", CanBeNull:=false)>  _
	Public Property Cliente() As String
		Get
			Return Me._Cliente
		End Get
		Set
			If (String.Equals(Me._Cliente, value) = false) Then
				Me._Cliente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Identificación", DbType:="NVarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property Identificación() As String
		Get
			Return Me._Identificación
		End Get
		Set
			If (String.Equals(Me._Identificación, value) = false) Then
				Me._Identificación = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Fecha de Nacimiento]", Storage:="_Fecha_de_Nacimiento", DbType:="Date NOT NULL")>  _
	Public Property Fecha_de_Nacimiento() As Date
		Get
			Return Me._Fecha_de_Nacimiento
		End Get
		Set
			If ((Me._Fecha_de_Nacimiento = value)  _
						= false) Then
				Me._Fecha_de_Nacimiento = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Salario Neto]", Storage:="_Salario_Neto", DbType:="Money NOT NULL")>  _
	Public Property Salario_Neto() As Decimal
		Get
			Return Me._Salario_Neto
		End Get
		Set
			If ((Me._Salario_Neto = value)  _
						= false) Then
				Me._Salario_Neto = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Límite Crediticio]", Storage:="_Límite_Crediticio", DbType:="Money NOT NULL")>  _
	Public Property Límite_Crediticio() As Decimal
		Get
			Return Me._Límite_Crediticio
		End Get
		Set
			If ((Me._Límite_Crediticio = value)  _
						= false) Then
				Me._Límite_Crediticio = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Saldo Crediticio]", Storage:="_Saldo_Crediticio", DbType:="Money NOT NULL")>  _
	Public Property Saldo_Crediticio() As Decimal
		Get
			Return Me._Saldo_Crediticio
		End Get
		Set
			If ((Me._Saldo_Crediticio = value)  _
						= false) Then
				Me._Saldo_Crediticio = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Dirección", DbType:="NVarChar(MAX) NOT NULL", CanBeNull:=false)>  _
	Public Property Dirección() As String
		Get
			Return Me._Dirección
		End Get
		Set
			If (String.Equals(Me._Dirección, value) = false) Then
				Me._Dirección = value
			End If
		End Set
	End Property
End Class

Partial Public Class muestraCreditosResult
	
	Private _Código_Crédito As Integer
	
	Private _Código_Cliente As Integer
	
	Private _Cliente As String
	
	Private _Monto_Total As Decimal
	
	Private _Monto_Pendiente As Decimal
	
	Private _Saldo_Crediticio As Decimal
	
	Private _Cuotas As Decimal
	
	Private _Plazo__Meses_ As Integer
	
	Private _Inicio_del_Crédito As Date
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Código Crédito]", Storage:="_Código_Crédito", DbType:="Int NOT NULL")>  _
	Public Property Código_Crédito() As Integer
		Get
			Return Me._Código_Crédito
		End Get
		Set
			If ((Me._Código_Crédito = value)  _
						= false) Then
				Me._Código_Crédito = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Código Cliente]", Storage:="_Código_Cliente", DbType:="Int NOT NULL")>  _
	Public Property Código_Cliente() As Integer
		Get
			Return Me._Código_Cliente
		End Get
		Set
			If ((Me._Código_Cliente = value)  _
						= false) Then
				Me._Código_Cliente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cliente", DbType:="NVarChar(72) NOT NULL", CanBeNull:=false)>  _
	Public Property Cliente() As String
		Get
			Return Me._Cliente
		End Get
		Set
			If (String.Equals(Me._Cliente, value) = false) Then
				Me._Cliente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Monto Total]", Storage:="_Monto_Total", DbType:="Money NOT NULL")>  _
	Public Property Monto_Total() As Decimal
		Get
			Return Me._Monto_Total
		End Get
		Set
			If ((Me._Monto_Total = value)  _
						= false) Then
				Me._Monto_Total = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Monto Pendiente]", Storage:="_Monto_Pendiente", DbType:="Money NOT NULL")>  _
	Public Property Monto_Pendiente() As Decimal
		Get
			Return Me._Monto_Pendiente
		End Get
		Set
			If ((Me._Monto_Pendiente = value)  _
						= false) Then
				Me._Monto_Pendiente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Saldo Crediticio]", Storage:="_Saldo_Crediticio", DbType:="Money NOT NULL")>  _
	Public Property Saldo_Crediticio() As Decimal
		Get
			Return Me._Saldo_Crediticio
		End Get
		Set
			If ((Me._Saldo_Crediticio = value)  _
						= false) Then
				Me._Saldo_Crediticio = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cuotas", DbType:="Money NOT NULL")>  _
	Public Property Cuotas() As Decimal
		Get
			Return Me._Cuotas
		End Get
		Set
			If ((Me._Cuotas = value)  _
						= false) Then
				Me._Cuotas = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Plazo (Meses)]", Storage:="_Plazo__Meses_", DbType:="Int NOT NULL")>  _
	Public Property Plazo__Meses_() As Integer
		Get
			Return Me._Plazo__Meses_
		End Get
		Set
			If ((Me._Plazo__Meses_ = value)  _
						= false) Then
				Me._Plazo__Meses_ = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Inicio del Crédito]", Storage:="_Inicio_del_Crédito", DbType:="Date NOT NULL")>  _
	Public Property Inicio_del_Crédito() As Date
		Get
			Return Me._Inicio_del_Crédito
		End Get
		Set
			If ((Me._Inicio_del_Crédito = value)  _
						= false) Then
				Me._Inicio_del_Crédito = value
			End If
		End Set
	End Property
End Class

Partial Public Class muestraUsuariosResult
	
	Private _Código As Integer
	
	Private _Usuario As String
	
	Private _NickName As String
	
	Private _Contraseña As String
	
	Private _Puesto As String
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Código", DbType:="Int NOT NULL")>  _
	Public Property Código() As Integer
		Get
			Return Me._Código
		End Get
		Set
			If ((Me._Código = value)  _
						= false) Then
				Me._Código = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Usuario", DbType:="NVarChar(72) NOT NULL", CanBeNull:=false)>  _
	Public Property Usuario() As String
		Get
			Return Me._Usuario
		End Get
		Set
			If (String.Equals(Me._Usuario, value) = false) Then
				Me._Usuario = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_NickName", DbType:="NVarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property NickName() As String
		Get
			Return Me._NickName
		End Get
		Set
			If (String.Equals(Me._NickName, value) = false) Then
				Me._NickName = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Contraseña", DbType:="NVarChar(10) NOT NULL", CanBeNull:=false)>  _
	Public Property Contraseña() As String
		Get
			Return Me._Contraseña
		End Get
		Set
			If (String.Equals(Me._Contraseña, value) = false) Then
				Me._Contraseña = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Puesto", DbType:="NVarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property Puesto() As String
		Get
			Return Me._Puesto
		End Get
		Set
			If (String.Equals(Me._Puesto, value) = false) Then
				Me._Puesto = value
			End If
		End Set
	End Property
End Class

Partial Public Class muestraAbonosResult
	
	Private _Cliente As String
	
	Private _Identificación As String
	
	Private _Cuota As Decimal
	
	Private _Monto_Total As Decimal
	
	Private _Monto_Pendiente As Decimal
	
	Private _Fecha_del_Abono As Date
	
	Public Sub New()
		MyBase.New
	End Sub
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cliente", DbType:="NVarChar(72) NOT NULL", CanBeNull:=false)>  _
	Public Property Cliente() As String
		Get
			Return Me._Cliente
		End Get
		Set
			If (String.Equals(Me._Cliente, value) = false) Then
				Me._Cliente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Identificación", DbType:="NVarChar(15) NOT NULL", CanBeNull:=false)>  _
	Public Property Identificación() As String
		Get
			Return Me._Identificación
		End Get
		Set
			If (String.Equals(Me._Identificación, value) = false) Then
				Me._Identificación = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Storage:="_Cuota", DbType:="Money NOT NULL")>  _
	Public Property Cuota() As Decimal
		Get
			Return Me._Cuota
		End Get
		Set
			If ((Me._Cuota = value)  _
						= false) Then
				Me._Cuota = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Monto Total]", Storage:="_Monto_Total", DbType:="Money NOT NULL")>  _
	Public Property Monto_Total() As Decimal
		Get
			Return Me._Monto_Total
		End Get
		Set
			If ((Me._Monto_Total = value)  _
						= false) Then
				Me._Monto_Total = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Monto Pendiente]", Storage:="_Monto_Pendiente", DbType:="Money NOT NULL")>  _
	Public Property Monto_Pendiente() As Decimal
		Get
			Return Me._Monto_Pendiente
		End Get
		Set
			If ((Me._Monto_Pendiente = value)  _
						= false) Then
				Me._Monto_Pendiente = value
			End If
		End Set
	End Property
	
	<Global.System.Data.Linq.Mapping.ColumnAttribute(Name:="[Fecha del Abono]", Storage:="_Fecha_del_Abono", DbType:="Date NOT NULL")>  _
	Public Property Fecha_del_Abono() As Date
		Get
			Return Me._Fecha_del_Abono
		End Get
		Set
			If ((Me._Fecha_del_Abono = value)  _
						= false) Then
				Me._Fecha_del_Abono = value
			End If
		End Set
	End Property
End Class

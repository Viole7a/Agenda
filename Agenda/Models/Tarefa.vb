'------------------------------------------------------------------------------
' <auto-generated>
'     This code was generated from a template.
'
'     Manual changes to this file may cause unexpected behavior in your application.
'     Manual changes to this file will be overwritten if the code is regenerated.
' </auto-generated>
'------------------------------------------------------------------------------

Imports System
Imports System.Collections.Generic

Partial Public Class Tarefa
    Public Property Id As Integer
    Public Property Usuario As Integer
    Public Property Titulo As String
    Public Property TipoTarefa As Integer
    Public Property Descricao As String
    Public Property DataInclusao As Date
    Public Property Prazo As Nullable(Of Date)
    Public Property Status As Integer
    Public Property Progressao As Nullable(Of Decimal)
    Public Property Prioridade As Integer

    Public Overridable Property Prioridade1 As Prioridade
    Public Overridable Property Status1 As Status
    Public Overridable Property TipoTarefa1 As TipoTarefa
    Public Overridable Property Usuario1 As Usuario

End Class

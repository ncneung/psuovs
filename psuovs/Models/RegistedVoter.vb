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

Partial Public Class RegistedVoter
    Public Property AutoID As Integer
    Public Property PSUPassport As String
    Public Property ElectionID As Integer
    Public Property Registed As Nullable(Of Boolean)
    Public Property RegistedDate As Nullable(Of Date)
    Public Property RegistedBy As String
    Public Property ModifiedDate As Nullable(Of Date)
    Public Property ModifiedBy As String
    Public Property Voted As Nullable(Of Boolean)
    Public Property VotedDate As Nullable(Of Date)

    Public Overridable Property ElectionVote As ElectionVote

End Class

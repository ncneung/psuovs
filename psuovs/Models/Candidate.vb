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

Partial Public Class Candidate
    Public Property CandidateID As Integer
    Public Property BallotsID As Integer
    Public Property OrderID As Nullable(Of Integer)
    Public Property CandidateNumber As Nullable(Of Integer)
    Public Property NameTH As String
    Public Property NameEN As String
    Public Property FacID As Nullable(Of Integer)
    Public Property Gender As String

    Public Overridable Property Ballots As Ballots
    Public Overridable Property VoteResult As ICollection(Of VoteResult) = New HashSet(Of VoteResult)

End Class
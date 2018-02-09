Imports PSUOVS
Imports PSUOVS.Models

Public Class clsVoterBK
    Implements IVoterManagement
    Dim _conn As clsConnect = New clsConnect()
    Dim strNoData As String = "No Data"
    Public Function AssignVoter(BallotID As String, passport As String, otherInfo As String) As Object Implements IVoterManagement.AssignVoter
        Throw New NotImplementedException()
    End Function

    Public Function checkVoter(PSUPassport As String) As Boolean Implements IVoterManagement.checkVoter
        Dim strSQL As String = "SELECT * FROM MatchVoterBallots Where PSUPassport = " & "'" & PSUPassport & "'"
        Dim ds As DataSet = _conn.Fill(strSQL, "MatchVoter")
        If ds.Tables("MatchVoter").Rows.Count > 0 Then
            Return True
        Else
            Return False
        End If
        Throw New NotImplementedException()
        '    Dim strSQL As String = "SELECT * from ManageRole Where PSUPassport = " & "'" & strPSUPassport & "'"
        '    Dim result As Role

        '    'Return Sql_Dataset(strSQL)

        '    Dim ds As DataSet = _conn.Fill(strSQL, "role")

        '    If (ds IsNot Nothing) Then
        '        result = New Role()
        '        With result
        '            .RoleID = ds.Tables("role").Rows(0).Item("RoleID")
        '        End With

        '    End If
        '    Return result

        'Dim result As MatchVoterBallots

        'Dim ds As DataSet = _conn.Fill(strSQL, "MatchVoter")

        'If (ds IsNot Nothing) Then
        '    result = New MatchVoterBallots()
        '    With result
        '        .BallotsID = 
        '    End With
        'End If

    End Function

    Public Function GetVoter(passport As String) As VoterDetail Implements IVoterManagement.GetVoter
        'Dim strSql As String = "Select * from V_Voter Where PSUPassport = '" & passport & "' "
        'Dim results As New List(Of VoterDetail)
        'Dim ds As DataSet = _conn.Fill(strSql, "voterdetail")
        'If (ds IsNot Nothing) Then
        '    For Each Voter As DataRow In ds.Tables("voterdetail").Rows
        '        Dim r = New VoterDetail()
        '        With r
        '            r.PSUPassport = Voter.Item("PSUPassport")
        '            r.Genger = Voter.Item("SEX_CODE")
        '            r.NameTH = Voter.Item("STUD_NAME_THAI")
        '            r.SNameTH = Voter.Item("STUD_SNAME_THAI")
        '            r.NameEN = Voter.Item("STUD_NAME_ENG")
        '            r.SNameEN = Voter.Item("STUD_SNAME_ENG")
        '            r.FacNameTH = Voter.Item("FAC_NAME_THAI")
        '        End With
        '    Next
        'End If

        Dim strSql As String = "Select * from V_Voter Where PSUPassport = '" & passport & "' "
        Dim results As VoterDetail
        Dim ds As DataSet = _conn.Fill(strSql, "voterdetail")
        If ds.Tables("voterdetail").Rows.Count > 0 Then
            'If (ds IsNot Nothing) Then



            results = New VoterDetail()
            With results
                .PSUPassport = ds.Tables("voterdetail").Rows(0).Item("PSUPassport")
                .Genger = ds.Tables("voterdetail").Rows(0).Item("SEX_NAME")
                .NameTH = ds.Tables("voterdetail").Rows(0).Item("STUD_NAME_THAI")
                .SNameTH = ds.Tables("voterdetail").Rows(0).Item("STUD_SNAME_THAI")
                .NameEN = ds.Tables("voterdetail").Rows(0).Item("STUD_NAME_ENG")
                .SNameEN = ds.Tables("voterdetail").Rows(0).Item("STUD_SNAME_ENG")
                .FacNameTH = ds.Tables("voterdetail").Rows(0).Item("FAC_NAME_THAI")
                .checkVoter = True

                'If .PSUPassport Is Nothing Then .PSUPassport = strNoData Else .PSUPassport = ds.Tables("voterdetail").Rows(0).Item("PSUPassport")
                'If .Genger Is Nothing Then .Genger = strNoData Else .Genger = ds.Tables("voterdetail").Rows(0).Item("SEX_NAME")
                'If .NameTH Is Nothing Then .NameTH = strNoData Else .NameTH = ds.Tables("voterdetail").Rows(0).Item("STUD_NAME_THAI")
                'If .SNameTH Is Nothing Then .SNameTH = strNoData Else .SNameTH = ds.Tables("voterdetail").Rows(0).Item("STUD_SNAME_THAI")
                'If .NameEN Is Nothing Then .NameEN = strNoData Else .NameEN = ds.Tables("voterdetail").Rows(0).Item("STUD_NAME_ENG")
                'If .SNameEN Is Nothing Then .SNameEN = strNoData Else .SNameEN = ds.Tables("voterdetail").Rows(0).Item("STUD_SNAME_ENG")
                'If .FacNameTH Is Nothing Then .FacNameTH = strNoData Else .FacNameTH = ds.Tables("voterdetail").Rows(0).Item("FAC_NAME_THAI")


            End With
            'End If
        Else
            results = New VoterDetail()
            With results
                .PSUPassport = strNoData
                .Genger = strNoData
                .NameTH = strNoData
                .SNameTH = strNoData
                .NameEN = strNoData
                .SNameEN = strNoData
                .FacNameTH = strNoData
                .checkVoter = False




            End With


        End If
        Return results

        Throw New NotImplementedException()
    End Function
    'Public Function GetVoter2(passport As String) As V_Voter
    '    'วิธีการใช้ model แบบพี่บอล มีคำสั่ง select update insert delete

    '    'select
    '    Dim db As PSUOVSEntities = New PSUOVSEntities()

    '    Dim result = db.V_Voter.Where(Function(v) v.PSUPassport = passport).FirstOrDefault() 'ถ้าจะเอาหลาย row ก็ไม่ต้องใส่ FirstOrDefault

    '    'insert
    '    Dim voter As Voter
    '    voter.PSUPassport = "xxxx"

    '    db.Voter.Add(voter)
    '    db.SaveChanges()

    '    'update
    '    Dim u = db.Voter.Where(Function(v) v.PSUPassport = passport).FirstOrDefault()
    '    u.PSUPassport = "new"

    '    db.SaveChanges()

    '    Return result


    '    'delete
    '    db.Voter.Remove(u)
    '    db.SaveChanges()

    'End Function

    'Public Function GetVoters(ElectionID As String) As IEnumerable(Of Voter) Implements IVoterManagement.GetVoters
    '    Throw New NotImplementedException()
    'End Function

    Public Function Registration(BallotID As String, passport As String, registedBy As String) As Object Implements IVoterManagement.Registration
        Throw New NotImplementedException()
    End Function

    Public Function RemoveVoter(BallotID As String, passport As String) As Object Implements IVoterManagement.RemoveVoter
        Throw New NotImplementedException()
    End Function

    Public Function SetVoted(BallotID As String, passport As String) As Object Implements IVoterManagement.SetVoted
        Throw New NotImplementedException()
    End Function

    Private Function IVoterManagement_GetVoters(ElectionID As String) As IEnumerable(Of Models.Voter) Implements IVoterManagement.GetVoters
        Throw New NotImplementedException()
    End Function
End Class

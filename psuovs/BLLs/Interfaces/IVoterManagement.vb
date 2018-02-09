Public Interface IVoterManagement
    'ข้อมูลจริงของ ผู้ลงคะแนนเสียง เป็นข้อมูลจาก ฐานนักศึกษา หรือ ฐานบุคลากร 
    'ข้อมูลที่เก็บใน DB Table>> EligibleVoter(ballotID(key), passport(key), userInfo, registed as bool, registedDateTime as datetime, registedBy as string , voted as bool, votedDateTime as dateTime)

    'รายชื่อผู้มีสิทธิ์เลือกตั้งใน รายการเลือกตั้งที่กำหนด
    Function GetVoters(ElectionID As String) As IEnumerable(Of V_Voter)
    'ข้อมูลของผู้มีสิทธิ์เลือกตั้ง ดึงข้อมูลจาก ฐานนักศึกษา หรือ ฐานบุคลากร 
    'Function GetVoter(passport As String) As Models.VoterDetail
    Function GetVoter(passport As String) As V_Voter


    'กำหนด ผู้มีสิทธิลงคะแนน กับ บัตรลงคะแนน
    Function AssignVoter(BallotID As String, passport As String, otherInfo As String)
    'เอารายชื่อออกจากบัตรลงคะแนน
    'ไม่สามารถเอารายชื่อออกจากบัตรลงคะแนนหาก มีรายละเอียดว่าได้ลงคะแนนไปแล้ว
    Function RemoveVoter(BallotID As String, passport As String)


    'บันทึกว่า Voter ได้มีการลงทะเบียนก่อนเข้าคูหาแล้ว
    Function Registration(BallotID As String, passport As String, registedBy As String)

    'บันทึกว่า Voter ได้ทำการ ลงคะแนนสียงในบัตรเลือกตั้งแล้ว
    Function SetVoted(BallotID As String, passport As String)

    'หนึ่งเพิ่ม Check ว่ามีรายชื่อมีสิทธิ์ไหม ถ้าไม่มีก็เข้าระบบไม่ได้
    Function checkVoter(ByVal PSUPassport As String) As Boolean


End Interface

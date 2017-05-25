Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports System7.Reports
Imports Base7.Parameter
Imports System.Data
Imports DevExpress.XtraPrinting.Preview
Imports System.Net.Mail
Imports System.IO
Imports System.Runtime.CompilerServices
Imports System.Net
Imports System.Net.Configuration


Public Class PAB120

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        ProgressBar1.Visible = False
        all_chk.Checked = False

        Dim barManager As New PrintBarManager()
        barManager.Form = PrintControl1
        barManager.Initialize(PrintControl1)
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.Open
            '    Me.Open_Form()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub all_chk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles all_chk.CheckedChanged

        g10.CheckRows("chk", all_chk.Checked)

    End Sub


#Region "메일보내기"

    Private Sub btn_send_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_send.Click

        '클라이어트 PC에서 보내기
        If MessageYesNo(" E-Mail을 보내시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        Else

            If email.Text = "" Or p_pw.Text = "" Then
                MessageInfo("[보내는E-Mail / 패스워드]는 필수입니다. 확인해주세요")
                Exit Sub
            End If

            Dim cnt As Integer = 0
            Dim totcnt As Integer = 0
            Dim emp As String = ""

            With g10

                For i = 0 To .RowCount - 1

                    If .Text("chk", i) = "1" And .Text("email", i) <> "" Then

                        Try

                            'If .Text("email", i) = "" Then
                            '    MessageInfo("Mail 정보가 없는 사원이존재합니다.")
                            '    Exit Sub
                            'End If

                            '파일생성
                            HTML_CD(g10.Text("emp_no", i))

                            totcnt = totcnt + 1
                            Dim message = New MailMessage()
                            Dim smtp As New SmtpClient()
                            Dim smtpUser As New System.Net.NetworkCredential()
                            Dim mBody As String = ""


                            smtpUser.UserName = email.Text
                            smtpUser.Password = p_pw.Text
                            smtp.Host = smtphost.Text

                            message.From = New MailAddress(email.Text)
                            message.To.Add(New MailAddress(.Text("email", i)))

                            message.IsBodyHtml = True
                            message.Priority = MailPriority.High

                            message.Subject = (.Text("emp_nm", i)) + "_" + "급여명세서"
                            message.SubjectEncoding = System.Text.Encoding.UTF8

                            message.BodyEncoding = System.Text.Encoding.UTF8 '한글 입력시

                            mBody = mBody + "<STYLE type=text/css>                                      "
                            mBody = mBody + "   .tdCenter {text-align: center; vertical-align: middle;} "
                            mBody = mBody + "   .tdLeft {text-align: left; vertical-align: middle;}     "
                            mBody = mBody + "   .tdRight {text-align: right; vertical-align: middle;}   "
                            mBody = mBody + "   td {font-family:Gulim; font-size:9pt;}   "
                            mBody = mBody + "</STYLE>                                                   "
                            mBody = mBody + "<table width=750 height=30 border=0><tr><td align=center><h2><strong> + 급여명세서  메일+ </strong></h2></td></tr></table>"
                            mBody = mBody + "<br><br>"
                            mBody = mBody + "<table border=0 cellpadding=0 cellspacing=0 style=width: 750px;border-collapse:collapse;>"
                            mBody = mBody + "	<tbody>                                  "
                            mBody = mBody + "		<tr height=30><td colspan=3 align=center>급여명세서입니다. 첨부파일을 다운로드하여 확인하세요</td></tr>                "

                            mBody = mBody + "	</tbody>                                 "
                            mBody = mBody + "</table>                                    "

                            message.Body = mBody

                            message.BodyEncoding = System.Text.Encoding.UTF8

                            message.Attachments.Add(New Attachment("C:\Temp\" + .Text("emp_no", i) + "_" + .Text("emp_nm", i) + ".PDF"))

                            Dim client = New SmtpClient(smtphost.Text, port.Text)

                            If co_mail_yn.Text = "1" Then
                                client.UseDefaultCredentials = False
                            Else
                                client.UseDefaultCredentials = True
                            End If

                            client.DeliveryMethod = SmtpDeliveryMethod.Network
                            client.Credentials = smtpUser
                            client.Send(message)

                            message.Dispose()

                            File.Delete("c:\Temp" & .Text("emp_no", i) + "_" + .Text("emp_nm", i) & i & ".PDF")
                        Catch ex As Exception
                            'MessageInfo(ex)
                            cnt = cnt + 1
                            emp = emp + vbCrLf + "사원 : " + .Text("emp_nm", i) + "(" + .Text("emp_no", i) + ")"
                        End Try
                    End If
                Next
            End With

            If totcnt - cnt > 0 Then
                MessageInfo("메일(" & totcnt - cnt & ")을 발송하였습니다.")
            End If
            If cnt > 0 Then
                Dim err As String = "메일(" & cnt & ")건 발송이 실패하였습니다."
                err = err + emp
                MessageInfo(err)
            End If
        End If

    End Sub

    'Private Sub HTML_Click(sender As System.Object, e As System.EventArgs)
    '    'PDF일괄 저장하기
    '    If MessageYesNo("HTML로 다운받으시겠습니까?") = MsgBoxResult.No Then
    '        Exit Sub
    '    Else

    '        Dim i As Integer
    '        Dim Cnt As Integer = 0

    '        Dim p As OpenParameters = New OpenParameters
    '        Dim p1 As OpenParameters = New OpenParameters

    '        Dim First_Cnt As Integer = 0
    '        Dim Rpt1 As Object = Nothing

    '        Try
    '            For i = 0 To g10.RowCount - 1

    '                If g10.Text("chk", i) = "1" Then

    '                    '1.리포트 데이터 가져오기

    '                    p.Add("@pay_mon", g10.Text("pay_mon", i))
    '                    p.Add("@pay_bc", g10.Text("pay_bc", i))
    '                    p.Add("@pay_sq", pay_sq.Text)
    '                    p.Add("@bs_cd", bs_cd.Text)
    '                    p.Add("@dept_cd", g10.Text("dept_cd", i))
    '                    p.Add("@duty1_bc", g10.Text("duty_bc", i))
    '                    p.Add("@duty2_bc", "")
    '                    p.Add("@emp_no", g10.Text("emp_no", i))
    '                    p.Add("@kind_bc", g10.Text("kind_bc", i))
    '                    p.Add("@prt_order", "1")
    '                    p.Add("@prt_group", "2")

    '                    Dim dSet As DataSet = MyBase.OpenDataSet("pab103_print_pay", p)

    '                    Dim File_Name As String
    '                    File_Name = Dir("c:\Temp", FileAttribute.Directory)
    '                    If Len(File_Name.Trim) <= 0 Then
    '                        MkDir("c:\Temp")
    '                    End If

    '                    Dim reportPath As String = "c:\Temp\"

    '                    If Not IsEmpty(dSet) Then
    '                        '2.데이터셋 보내기
    '                        Rpt1 = New PAB103R_PAY(dSet)

    '                        PrintControl1.PrintingSystem = Rpt1.PrintingSystem
    '                        Rpt1.CreateDocument()
    '                    End If

    '                    'Rpt1.ExportToPdf(reportPath + g10.Text("emp_no", i) + "_" + g10.Text("emp_nm", i) + ".pdf")
    '                    Rpt1.ExportToHTML(reportPath + g10.Text("emp_no", i) + "_" + g10.Text("emp_nm", i) + ".HTML")


    '                End If
    '                Cnt = Cnt + 1

    '            Next i

    '        Catch ex As Exception
    '            MessageError(ex)
    '        End Try

    '    End If

    'End Sub


    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        Print()
    End Sub


    Private Sub Print()


        Dim p As OpenParameters = New OpenParameters

        p.Add("@pay_mon", g10.Text("pay_mon"))
        p.Add("@pay_bc", g10.Text("pay_bc"))
        p.Add("@pay_sq", pay_sq.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@dept_cd", "")
        p.Add("@duty1_bc", "")
        p.Add("@duty2_bc", "")
        p.Add("@emp_no", g10.Text("emp_no"))
        p.Add("@kind_bc", "")


        'System8 적용분
        '  Me.PrintForm("PAB115")

        '1.리포트 데이터 가져오기
        Dim dSet As DataSet = MyBase.OpenDataSet("pab103_print_pay", p)

        If Not IsEmpty(dSet) Then
            '2.데이터셋 보내기
            Dim Rpt1 As New PAB103R_PAY(dSet)

            Rpt1.CreateDocument()

            PrintControl1.PrintingSystem = Rpt1.PrintingSystem
        End If

    End Sub

    Private Sub HTML_CD(empno As String)

        Dim i As Integer
        Dim Cnt As Integer = 0

        Dim p As OpenParameters = New OpenParameters
        Dim p1 As OpenParameters = New OpenParameters

        Dim First_Cnt As Integer = 0
        Dim Rpt1 As Object = Nothing

        Try
            For i = 0 To g10.RowCount - 1

                If g10.Text("chk", i) = "1" Then

                    '1.리포트 데이터 가져오기

                    p.Add("@pay_mon", g10.Text("pay_mon", i))
                    p.Add("@pay_bc", g10.Text("pay_bc", i))
                    p.Add("@pay_sq", pay_sq.Text)
                    p.Add("@bs_cd", bs_cd.Text)
                    p.Add("@dept_cd", g10.Text("dept_cd", i))
                    p.Add("@duty1_bc", g10.Text("duty_bc", i))
                    p.Add("@duty2_bc", "")
                    p.Add("@emp_no", g10.Text("emp_no", i))
                    p.Add("@kind_bc", g10.Text("kind_bc", i))
                    p.Add("@prt_order", "1")
                    p.Add("@prt_group", "2")

                    Dim dSet As DataSet = MyBase.OpenDataSet("pab103_print_pay", p)

                    Dim File_Name As String
                    File_Name = Dir("c:\Temp", FileAttribute.Directory)
                    If Len(File_Name.Trim) <= 0 Then
                        MkDir("c:\Temp")
                    End If

                    Dim reportPath As String = "c:\Temp\"

                    If Not IsEmpty(dSet) Then
                        '2.데이터셋 보내기
                        Rpt1 = New PAB103R_PAY(dSet)

                        PrintControl1.PrintingSystem = Rpt1.PrintingSystem
                        Rpt1.CreateDocument()
                    End If

                    'Rpt1.ExportToPdf(reportPath + g10.Text("emp_no", i) + "_" + g10.Text("emp_nm", i) + ".pdf")
                    Rpt1.ExportToHTML(reportPath + g10.Text("emp_no", i) + "_" + g10.Text("emp_nm", i) + ".HTML")


                End If
                Cnt = Cnt + 1

            Next i

        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub


#End Region

    Public Sub Open_Form()
        Me.Init_Title()
        Me.Disp_Data()

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("PAB120_title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "pay_amt")

    End Sub
#End Region
#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("pay_mon").IsMasterKey = True
            g10.GridColumn("pay_bc").IsMasterKey = True
            g10.GridColumn("pay_kd").IsMasterData = True
            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterData = True
            g10.GridColumn("bs_cd").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True
            g10.GridColumn("nat_cd").IsMasterData = True
            g10.GridColumn("gen_ty").IsMasterData = True
            g10.GridColumn("duty_bc").IsMasterData = True
            g10.GridColumn("rank_bc").IsMasterData = True
            g10.GridColumn("step_bc").IsMasterData = True

            g10.GridColumn("std_amt").IsMasterData = True
            g10.GridColumn("tot_pay_amt").IsMasterData = True
            g10.GridColumn("tot_de").IsMasterData = True
            g10.GridColumn("tot_pay").IsMasterData = True
            g10.GridColumn("ot_amt").IsMasterData = True
            g10.GridColumn("eat_amt").IsMasterData = True
            g10.GridColumn("drv_amt").IsMasterData = True
            g10.GridColumn("tax_amt").IsMasterData = True
            g10.GridColumn("tot_tax_amt").IsMasterData = True
            g10.GridColumn("email").IsMasterData = True
            g10.GridColumn("chk").IsMasterData = True

            'b.gen_ty, b.duty_bc, b.rank_bc, b.step_bc,  
            'ot_amt, eat_amt, drv_amt, tax_amt,tot_tax_amt,
            'Detail 부분
            g10.GridColumn("pay_cd").IsDetailKey = True
            g10.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("PAB120_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

End Class

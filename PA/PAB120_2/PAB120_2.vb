Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System7.ReportView
Imports System7.Reports
Imports System.Net.Mail
Imports System.Data
Imports System.IO
Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Runtime.CompilerServices
Imports System.Net
Imports System.Net.Configuration

Public Class PAB120_2

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ProgressBar1.Visible = False
        all_chk.Checked = False
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
        ProgressBar1.Visible = True
        Dim cnt As Integer = 0
        Try
            With g10
                ProgressBar1.Maximum = .RowCount - 1
                ProgressBar1.Step = 1
                For i = 0 To .RowCount - 1



                    ProgressBar1.PerformStep()


                    If .Text("chk", i) = "1" And .Text("email", i) <> "" Then

                        Dim Message As MailMessage = New MailMessage()
                        'Dim smtp As New SmtpClient("192.168.2.5", 25)
                        Dim smtp As New SmtpClient("mail.interojo.com", 25)

                        'Dim userid As Byte()
                        'Dim userpw As Byte()
                        'Dim domain As Byte()

                        'userid = System.Text.Encoding.UTF8.GetBytes("interMail")
                        'userpw = System.Text.Encoding.UTF8.GetBytes("inter07@")
                        'domain = System.Text.Encoding.UTF8.GetBytes("interojo.co.kr")

                        'userid = System.Text.Encoding.UTF8.GetBytes("interojo2@interojo.com")
                        'userpw = System.Text.Encoding.UTF8.GetBytes("inter07")
                        'domain = System.Text.Encoding.UTF8.GetBytes("interojo.com")


                        Dim smtpUser As New System.Net.NetworkCredential()

                        smtpUser.UserName = "interojo2@interojo.com"   '기존꺼20160707
                        smtpUser.Password = "inter07"
                        smtp.Host = "25"

                        'smtpUser.UserName = Convert.ToBase64String(userid)
                        'smtpUser.Password = Convert.ToBase64String(userpw)
                        ''smtpUser.Domain = "interojo.co.kr"
                        'smtpUser.Domain = "interojo.com"

                        'smtpUser.GetCredential("192.168.2.5", 25, "Windows")

                        Message.From = New MailAddress("interojo2@interojo.com")

                        'Message.To.Add(New MailAddress("urong12@nate.com")) 'test mail

                        Message.To.Add(New MailAddress(.Text("email", i)))

                        Message.IsBodyHtml = True
                        Message.Priority = MailPriority.High
                        Message.Subject = pay_mon.Text + " / " + pay_sq.EditText + "명세서 메일"
                        Message.SubjectEncoding = System.Text.Encoding.UTF8
                        Message.Body = pay_mon.Text + " / " + pay_sq.EditText + "명세서 입니다. 첨부파일을 참고 하세요."

                        Dim body As New ReportDocument

                        Dim p As OpenParameters = New OpenParameters
                        'p.Add("@pay_mon", g10.Text("pay_mon", i))
                        p.Add("@pay_mon", pay_mon.Text)
                        p.Add("@pay_bc", g10.Text("pay_bc", i))
                        p.Add("@pay_sq", pay_sq.Text)
                        p.Add("@bs_cd", co_cd.Text)
                        p.Add("@dept_cd", "")
                        'p.Add("@duty1_bc", g10.Text("duty_bc", i))
                        p.Add("@duty1_bc", "")
                        p.Add("@duty2_bc", "")
                        p.Add("@emp_no", g10.Text("emp_no", i))
                        p.Add("@kind_bc", "")
                        p.Add("@prt_order", "1")
                        p.Add("@prt_group", "2")

                        Dim formCd As String = ""
                        Dim document As ReportDocument = Nothing
                        Dim dSet As DataSet = Link.ReadDataSet("pab120_2_print_detail", p)    'pab103_print_detail

                        If (document Is Nothing) Then
                            formCd = PAB120_2._GetFileName("PAB103_Detail")
                            If (formCd = "") Then
                                Exit Sub
                            End If
                            Dim expression As ReportDocument = DirectCast(PAB120_2._LoadAssembly(formCd, "System7"), ReportDocument)
                            If Information.IsNothing(expression) Then
                                MessageInfo((formCd & ".dll Instance " & ChrW(47484) & " " & ChrW(49373) & ChrW(49457) & ChrW(54624) & " " & ChrW(49688) & " " & ChrW(50630) & ChrW(49845) & ChrW(45768) & ChrW(45796) & "."), Nothing, Nothing)
                                Exit Sub
                            End If
                            document = expression
                        End If

                        If IsEmpty(dSet) Then
                            MessageInfo(ChrW(52636) & ChrW(47141) & ChrW(54624) & " " & ChrW(51088) & ChrW(47308) & ChrW(44032) & " " & ChrW(50630) & ChrW(49845) & ChrW(45768) & ChrW(45796), Nothing, Nothing)
                            Exit Sub
                        End If
                        document.SetDataSource(dSet.Tables.Item(0))


                        Dim CrExportOptions As ExportOptions
                        Dim CrDiskFileDestinationOptions As New  _
                        DiskFileDestinationOptions()
                        Dim CrFormatTypeOptions As New PdfRtfWordFormatOptions()
                        CrDiskFileDestinationOptions.DiskFileName = _
                                                    "c:\" & g10.Text("emp_no", i) & i & ".pdf"
                        CrExportOptions = document.ExportOptions
                        With CrExportOptions
                            .ExportDestinationType = ExportDestinationType.DiskFile
                            .ExportFormatType = ExportFormatType.PortableDocFormat
                            .DestinationOptions = CrDiskFileDestinationOptions
                            .FormatOptions = CrFormatTypeOptions
                        End With
                        document.Export()

                        Message.Attachments.Add(New Net.Mail.Attachment("c:\" & g10.Text("emp_no", i) & i & ".pdf"))

                        Message.BodyEncoding = System.Text.Encoding.UTF8

                        smtp.Host = "mail.interojo.com"
                        smtp.Port = 25
                        smtp.UseDefaultCredentials = False
                        smtp.Credentials = smtpUser
                        smtp.DeliveryMethod = SmtpDeliveryMethod.Network

                        'If SmtpAccess.Connect = 1 Then

                        smtp.Send(Message)

                        cnt = cnt + 1
                        'Declaration
                        'End If

                        Message.Dispose()
                        document.Dispose()

                        document.Close()

                        File.Delete("c:\" & g10.Text("emp_no", i) & i & ".pdf")
                    End If
                Next
            End With
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False

            MessageInfo("메일(" & cnt & ")을 발송하였습니다.")

        Catch ex As Exception
            MessageInfo(ex)
            ProgressBar1.Value = 0
            ProgressBar1.Visible = False
        End Try
    End Sub


    Private Shared Function _GetFileName(ByVal reportCode As String) As String
        Dim str As String
        Dim str2 As String = ""
        Try
            Dim openParams As New OpenParameters
            openParams.Add("@rpt_cd", reportCode, QueryParameterType.Text, QueryParameterKind.Parameter)
            Dim dtSet As DataSet = Link.ReadDataSet("common_get_report_file", openParams)
            If Not IsEmpty(dtSet) Then
                str2 = DataValue(dtSet, "file_nm", 0, False)
            End If
            If (str2 = "") Then
                MessageInfo("Report " & ChrW(51221) & ChrW(48372) & ChrW(44032) & " " & ChrW(46321) & ChrW(47197) & ChrW(46104) & ChrW(50612) & " " & ChrW(51080) & ChrW(51648) & " " & ChrW(50506) & ChrW(49845) & ChrW(45768) & ChrW(45796) & ".", Nothing, Nothing)
                Return ""
            End If
            str = str2
        Catch exception1 As Exception
            Dim excp As Exception = exception1
            MessageError(excp, Nothing, "Main.Report.GetReportFile()")
            str = ""
            Return str
        End Try
        Return str
    End Function

    Private Shared Function _LoadAssembly(ByVal formCd As String, Optional ByVal rootNameSpace As String = "PAB120") As Object
        Dim obj2 As Object
        Dim assembly As Reflection.Assembly
        Try
            [assembly] = Reflection.Assembly.Load(formCd)
            If ([assembly] Is Nothing) Then
                Return Nothing
            End If
        Catch exception1 As FileNotFoundException
            Dim exception As FileNotFoundException = exception1
            MessageInfo((ChrW(54532) & ChrW(47196) & ChrW(44536) & ChrW(47016) & ChrW(51012) & " " & ChrW(52286) & ChrW(51012) & " " & ChrW(49688) & " " & ChrW(50630) & ChrW(49845) & ChrW(45768) & ChrW(45796) & ": " & formCd), Nothing, Nothing)
            obj2 = Nothing
            Return obj2
        Catch exception4 As Exception
            Dim excp As Exception = exception4
            MessageError(excp, Nothing, Nothing)
            obj2 = Nothing
            Return obj2
        End Try
        Dim type As Type = Nothing
        Dim objectValue As Object = Nothing
        Try
            Dim name As String = formCd
            If Not name.StartsWith(rootNameSpace) Then
                name = (rootNameSpace & "." & formCd)
            End If
            type = [assembly].GetType(name)
            If (type Is Nothing) Then
                Return Nothing
            End If
            objectValue = RuntimeHelpers.GetObjectValue(Activator.CreateInstance(type))
        Catch exception5 As Exception
            Dim exception3 As Exception = exception5
            MessageError(exception3, Nothing, Nothing)
        End Try
        Return objectValue
    End Function


#End Region


    Private Sub pay_sq_TextChanged(sender As System.Object, e As System.EventArgs) Handles pay_sq.TextChanged

    End Sub
End Class

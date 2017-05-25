Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Ports

Public Class WI_SA1120_CID2
    'Inherits Form
    Private use_port As String, 상태 As String, ack상태 As String
    Private active_port As SerialPort

    Private startm As Char = Convert.ToChar(&H2) '┐
    Private endn As Char = Convert.ToChar(&H3)   '└

    Private call_yn1 As Char = "N"
    Private call_yn2 As Char = "N"

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()
            Case MenuType.Save
                '저장버튼 클릭시, 아무것도 안하게끔
                'If Me.Save() Then
                '    Me.Open()
                'End If
            Case Else
                MyBase.MenuButton_Click(mty)   '나머지는 기본기능
        End Select

    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub WI_SA1120_CID2_Leave(sender As Object, e As System.EventArgs) Handles Me.Leave  '151120smk 화면을 닫을때, 저장하고&포트닫기

        Me.Save()

        'If 상태 = "열림" Then
        '    active_port.Close()
        '    active_port.Dispose()
        '    상태 = "닫힘"
        'End If

    End Sub

    Private Sub call_number_info_Load(sender As Object, e As EventArgs) Handles Me.Load '메뉴열리면, 조회
        Me.Open("wi_sa1120_cid2_g10")
        초기화()

        '시간 : TimeOfDay.ToString("hh:mm:ss tt") 

    End Sub

    Private Sub 초기화()

        Try
            checkBox_ack.Checked = True
            상태 = "닫힘"

            toolcom.Items.Clear()
            toolcom.Items.Add("포트 선택")

            Dim 활성포트 As String()

            활성포트 = System.IO.Ports.SerialPort.GetPortNames()

            For q As Integer = 0 To 활성포트.Length - 1
                toolcom.Items.Add(활성포트(q).ToString())
            Next

            toolcom.SelectedIndex = 0

            listBox_RX.Items.Add("RX Report")
            listBox_TX.Items.Add("TX Report")

        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try

    End Sub

    '포트 선택
    Private Sub toolcom포트목록_SelectedIndexChanged(sender As Object, e As EventArgs) Handles toolcom.SelectedValueChanged

        Try
            If 상태 = "닫힘" Then
                If toolcom.SelectedIndex = 0 Then
                    use_port = "none"
                    tButton.Text = "포트선택"
                ElseIf toolcom.SelectedIndex > 0 Then
                    use_port = toolcom.Items(toolcom.SelectedIndex).ToString()

                    tButton.Text = use_port & " 열기"
                End If
            End If
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub toolStripButton포트연결_Click(sender As Object, e As EventArgs) Handles tButton.Click
        Try
            If 상태 = "열림" Then
                active_port.Close()
                active_port.Dispose()
                상태 = "닫힘"

                tButton.ForeColor = Color.Black
                tButton.Text = use_port & " 열기"

                toollabel.Text = ""

            Else
                If use_port = "none" Then
                    MessageBox.Show("통신 포트를 선택하세요.")
                Else

                    active_port = New SerialPort()

                    active_port.PortName = use_port
                    active_port.BaudRate = CInt(19200)
                    active_port.DataBits = CInt(8)
                    active_port.Parity = Parity.None
                    active_port.StopBits = StopBits.One

                    active_port.Open()
                    AddHandler active_port.DataReceived, New SerialDataReceivedEventHandler(AddressOf active_port_DataReceived)

                    If active_port.IsOpen Then
                        상태 = "열림"
                        tButton.ForeColor = Color.Red
                        tButton.Text = use_port & " 닫기"
                    Else
                        MessageBox.Show("포트 연결 실패")
                    End If

                End If
            End If
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    ' 수신
    Private Sub active_port_DataReceived(sender As Object, e As SerialDataReceivedEventArgs)

        Me.Invoke(New EventHandler(AddressOf 읽기))
    End Sub


    Private Sub 읽기(s As Object, e As EventArgs)   '동기수신문 : ┐1A, ┐1I01054789632

        Try
            Dim 동기수신문 As String = ""
            동기수신문 = active_port.ReadTo(Convert.ToString(Convert.ToChar(&H3)))    '동기수신문 : ┐1I010837454575(폰번호) , ┐1A


            If 동기수신문.Substring(2, 1) = "I" Then  '전화연결(I) 만 성공
                text1.Text = ToStr(동기수신문.Substring(2, 1))
                text2.Text = ""
                text3.Text = ""

                정보수신표시(동기수신문)
                발신번호표시2(동기수신문)
                call_yn1 = "Y"

            ElseIf 동기수신문.Substring(2, 1) = "S" Then '전화받으면(=수화기들면)(S) ->수주화면 변경 

                text2.Text = ToStr(동기수신문.Substring(2, 1))
                text1.Text = ""
                text3.Text = ""

                If call_yn1 = "Y" Then         '전화가 연결됐을때만 수주변경O <20160212smk>
                    발신번호표시(동기수신문)
                Else                           '전화가 연결된게 아니고, 수화기만 들었을때는 수주변경X
                    'call_yn1 = "N"    '160303
                End If

            Else    '전화끊었을떄(E) & 타인이 받았을때(A) 

                text3.Text = ToStr(동기수신문.Substring(2, 1))
                text1.Text = ""
                text2.Text = ""

                call_yn1 = "N"
            End If




            'If 동기수신문.Length = 29 Then
            '    ' 정상수신
            '    If ack상태 = "ok" Then
            '        ACK전송()
            '    End If

            '    If 동기수신문.Substring(1, 1) = "R" Then
            '        ' ack,err
            '    ElseIf 동기수신문.Substring(1, 1) = "S" Then
            '        ' hook
            '        If 동기수신문.Substring(3, 29 - 3).Trim() = "HOOK ON" Then
            '            정보수신표시(동기수신문)
            '        ElseIf 동기수신문.Substring(3, 29 - 3).Trim() = "HOOK OFF" Then
            '            정보수신표시(동기수신문)
            '        End If
            '    ElseIf 동기수신문.Substring(1, 1) = "P" Then
            '        ' cid info
            '        toollabel.Text = 동기수신문.Substring(3, 26).Trim()
            '    ElseIf 동기수신문.Substring(1, 1) = "C" Then
            '        ' missed call
            '        정보수신표시(동기수신문)
            '    ElseIf 동기수신문.Substring(1, 1) = "I" Then
            '        ' call number
            '        정보수신표시(동기수신문)
            '        발신번호표시(동기수신문)

            '    End If
            'Else
            '    'ERR전송()   '160105 SMK잠깐막음
            'End If

        Catch ex As Exception
            MessageBox.Show("읽기 에러: " & Convert.ToString(ex))   '160106smk 잠깐 읽기에러 씀
        End Try
    End Sub

    Private Sub ACK전송()
        Try
            Dim ack As String = Convert.ToString(startm) & "R"c & "0"c & "ACK                       " & Convert.ToString(endn)
            '"CALL-INFO?                "
            active_port.Write(ack)
            정보송신표시(ack)
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub ERR전송() '원래 막혀 있었음
        'Try
        '    Dim err As String = Convert.ToString(startm) & "R"c & "0"c & "ERR                       " & Convert.ToString(endn)
        '    active_port.Write(err)
        '    정보송신표시(err)
        'Catch ex As Exception
        '    MessageBox.Show("" & Convert.ToString(ex))
        'End Try
    End Sub

    Private Sub 정보수신표시(rxdata As String)  '동기수신문 = rxdata
        Try
            listBox_RX.Items.Add(rxdata)
            'MsgBox("수신표시:" & ToStr(rxdata))
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub 정보송신표시(txdata As String)  '동기수신문 = txdata
        Try
            MsgBox("txdata: " & txdata)
            listBox_TX.Items.Add(txdata)
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub 발신번호표시(readstr As String)   'readstr: ┐1I01012349658  '전화받았을때만(수화기들었을때만) 수주등록화면으로 이동
        Try

            Dim p As New OpenParameters
            p.Add("@tel", g10.Text("phonestr", g10.RowCount - 1))
            Dim Dset As DataSet = OpenDataSet("wi_sa1120_cid2_cust", p)

            If Not IsEmpty(Dset) Then   '거래처가 있을때만, 수주등록화면으로 점프


                'g10.Text("cust_cd", g10.RowIndex) = DataValue(Dset, "cust_cd") '전화수신시, 이미 저장되므로 막기
                'MsgBox(ToStr(readstr))

                Dim menuName As String = "WI_SA1120"
                Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
                ctr.Open2(g10.Text("cust_cd", g10.RowCount - 1))

                Dset = Nothing


            Else     '거래처가 등록되지 않았을때, 
                If readstr.Substring(2, 1) = "S" Then   '수화기를 들어서, 전화받을때만! 

                    '160129용선주요청:팝업창 아예 막기
                    'MsgBox("전화번호 등록이 안된 거래처입니다." & vbCrLf & "거래처 전화번호를 등록하시겠습니까? (※해당 메뉴로 이동됩니다.)")
                    'Dim menuName As String = "BCV100_TEL"
                    'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
                    'ctr.Open2(g10.Text("phonestr", g10.RowCount - 1))
                    'Dset = Nothing

                End If

            End If

        Catch ex As Exception
            MessageBox.Show("발신번호표시 에러: " & Convert.ToString(ex))  '160106smk 잠깐 발신번호표시 에러 씀
        End Try

    End Sub

    Private Sub 발신번호표시2(readstr As String)   '점프기능 없앤 발신번호만 표시 (전화안받았을시) 
        Try
            Dim x As Integer = readstr.Length

            If x > 6 Then   '  ┐1S ,  ┐1E,  ┐1A 이런식으로도 인식이 되어서,, 번호 인식시에만 조건 이동 

                Dim chstr As String = readstr.Substring(1, 1)
                Dim datestr As String = ToDateStr(Today, "yyyy-MM-dd")
                Dim timestr As String = TimeOfDay.ToString("hh:mm tt")
                Dim phonestr As String = readstr.Substring(3, 11)   '번호만 나열 

                phonestr = phonestr.Trim()

                If phonestr.Substring(0, 3) = "010" Then '핸드폰010일때, ┐1I01012349658
                    If phonestr.Length = 11 Then    ' - 추가해주기
                        phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 4) & "-" & phonestr.Substring(7, 4)
                    End If

                ElseIf phonestr.Substring(0, 2) = "02" Then '서울지역
                    If phonestr.Length = 9 Then
                        phonestr = phonestr.Substring(0, 2) & "-" & phonestr.Substring(2, 3) & "-" & phonestr.Substring(5, 4)
                    ElseIf phonestr.Length = 10 Then
                        phonestr = phonestr.Substring(0, 2) & "-" & phonestr.Substring(2, 4) & "-" & phonestr.Substring(6, 4)
                    End If

                Else '기타지역
                    If phonestr.Length = 10 Then
                        phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 3) & "-" & phonestr.Substring(6, 4)
                    ElseIf phonestr.Length = 11 Then
                        phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 4) & "-" & phonestr.Substring(7, 4)
                    End If
                End If

                'Dim 쓰기행 As Integer = g10.RowCount

                g10.AddNewRow()

                g10.Text("chstr") = chstr         '채널
                g10.Text("datestr") = datestr     'datestr.Substring(0, 2) & "-" & datestr.Substring(2, 2) '일자
                g10.Text("timestr") = timestr     'timestr.Substring(0, 2) & ":" & timestr.Substring(2, 2) '시간
                g10.Text("phonestr") = phonestr   '전화번호 

                Dim p As New OpenParameters
                p.Add("@tel", phonestr)
                Dim Dset As DataSet = OpenDataSet("wi_sa1120_cid2_cust", p)

                If Not IsEmpty(Dset) Then

                    g10.Text("cust_cd") = DataValue(Dset, "cust_cd")

                    'If readstr.Substring(2, 1) = "S" Then   '수화기를 들어서, 전화받을때만! 

                    '    '거래처가 있을때만, 수주등록화면으로 점프 (잠깐막고)
                    '    Dim menuName As String = "WI_SA1120"
                    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
                    '    ctr.Open2(g10.Text("cust_cd"))

                    '    Dset = Nothing

                    'End If

                Else     '거래처가 등록되지 않음:원래막힘
                    'If readstr.Substring(2, 1) = "S" Then   '수화기를 들어서, 전화받을때만! 
                    '    MsgBox("전화번호 등록이 안된 거래처입니다." & vbCrLf & "거래처 전화번호를 등록하시겠습니까? (※해당 메뉴로 이동됩니다.)")
                    '    Dim menuName As String = "BCV100_TEL"
                    '    Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
                    '    ctr.Open2(phonestr)

                    '    Dset = Nothing
                    'End If

                End If
                Me.Save()   '160207smk 추가 

            End If

        Catch ex As Exception
            MessageBox.Show("발신번호표시 에러: " & Convert.ToString(ex))  '160106smk 잠깐 발신번호표시 에러 씀
        End Try

    End Sub

    Private Sub 장비정보()
        Try
            If 상태 = "열림" Then
                Dim 장비정보 As String = Convert.ToString(startm) & "P"c & "0"c & "CID-INFO" & Convert.ToString(Convert.ToChar(&H3F)) & "                 " & Convert.ToString(endn)
                'Dim 장비정보 As String = Convert.ToString(startm) & "P"c & "0"c & "CID-INFO" & "C" & "" & Convert.ToString(endn)

                active_port.Write(장비정보)
                정보송신표시(장비정보)

            End If
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub toolButton_Click(sender As System.Object, e As System.EventArgs) Handles toolButton.Click
        Try
            If 상태 = "열림" Then
                장비정보()
            Else
                MessageBox.Show("포트에 연결된 장비가 없습니다.")
            End If
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub


    'Private Sub 발신번호표시(readstr As String)   'readstr: ┐1I01012349658
    '     Try
    '        Dim x As Integer = readstr.Length
    '        Dim chstr As String = readstr.Substring(2, 1)
    '        Dim datestr As String = readstr.Substring(3, 4)
    '        Dim timestr As String = readstr.Substring(7, 4)
    '        Dim phonestr As String = readstr.Substring(11, 18)
    '        phonestr = phonestr.Trim()

    '        ' 
    '        If phonestr.Substring(0, 2) = "02" Then
    '            If phonestr.Length = 9 Then
    '                phonestr = phonestr.Substring(0, 2) & "-" & phonestr.Substring(2, 3) & "-" & phonestr.Substring(5, 4)
    '            ElseIf phonestr.Length = 10 Then
    '                phonestr = phonestr.Substring(0, 2) & "-" & phonestr.Substring(2, 4) & "-" & phonestr.Substring(6, 4)
    '            End If
    '        Else
    '            If phonestr.Length = 10 Then
    '                phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 3) & "-" & phonestr.Substring(6, 4)
    '            ElseIf phonestr.Length = 11 Then
    '                phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 4) & "-" & phonestr.Substring(7, 4)
    '            ElseIf phonestr.Length = 12 Then
    '                phonestr = phonestr.Substring(0, 4) & "-" & phonestr.Substring(4, 4) & "-" & phonestr.Substring(8, 4)
    '            End If
    '        End If

    '        Dim 쓰기행 As Integer = g10.RowCount

    '        g10.AddNewRow()

    '        g10.Text("chstr") = chstr
    '        g10.Text("datestr") = datestr.Substring(0, 2) & "-" & datestr.Substring(2, 2)
    '        g10.Text("timestr") = timestr.Substring(0, 2) & ":" & timestr.Substring(2, 2)
    '        g10.Text("phonestr") = phonestr

    '        Dim p As New OpenParameters
    '        p.Add("@tel", g10.Text("phonestr"))
    '        Dim Dset As DataSet = OpenDataSet("wi_sa1120_cid2_cust", p)

    '        If Not IsEmpty(Dset) Then

    '            g10.Text("cust_cd") = DataValue(Dset, "cust_cd")

    '            '거래처가 있을때만, 수주등록화면으로 점프
    '            Dim menuName As String = "WI_SA1120"
    '            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '            ctr.Open2(g10.Text("cust_cd"))

    '            Dset = Nothing

    '        End If

    '        '151120 smk 위로 옮김
    '        'Dim menuName As String = "WI_SA1120"
    '        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
    '        'ctr.Open2(g10.Text("cust_cd"))

    '    Catch ex As Exception
    '        MessageBox.Show("발신번호표시 에러: " & Convert.ToString(ex))  '160106smk 잠깐 발신번호표시 에러 씀
    '    End Try

    'End Sub




    'Private Sub button1_Click(sender As Object, e As EventArgs)
    '    Try
    '        listBox_RX.Items.Clear()
    '        listBox_TX.Items.Clear()
    '        listBox_RX.Items.Add("RX Report")
    '        listBox_TX.Items.Add("TX Report")

    '        dataGridView_show.Rows.Clear()
    '    Catch ex As Exception
    '        MessageBox.Show("" & Convert.ToString(ex))
    '    End Try
    'End Sub

    'Private Sub toolStripButton장비정보_Click(sender As Object, e As EventArgs) Handles toollabel.Click
    '    Try
    '        If 상태 = "열림" Then
    '            장비정보()
    '        Else
    '            MessageBox.Show("포트에 연결된 장비가 없습니다.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("" & Convert.ToString(ex))
    '    End Try
    'End Sub

    'Private Sub call_number_info_FormClosing(sender As Object, e As FormClosingEventArgs)
    '    Try
    '        If active_port IsNot Nothing Then
    '            active_port.Close()
    '            active_port.Dispose()
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("" & Convert.ToString(ex))
    '    End Try
    'End Sub

    ' 메모리 정보호출문 전송
    'Private Sub toolStripButton메모리호출_Click(sender As Object, e As EventArgs)
    '    Try
    '        If 상태 = "열림" Then
    '            Dim 메모리호출 As String = Convert.ToString(startm) & "C"c & "0"c & "CALL-INFO" & Convert.ToString(Convert.ToChar(&H3F)) & "                " & Convert.ToString(endn)
    '            active_port.Write(메모리호출)
    '            정보송신표시(메모리호출)
    '        Else
    '            MessageBox.Show("연결된 통신 포트가 없습니다.")
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("" & Convert.ToString(ex))
    '    End Try
    'End Sub

    'Private Sub checkBox_ack_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox_ack.CheckedChanged
    '    Try
    '        If checkBox_ack.Checked = True Then
    '            ack상태 = "ok"
    '        Else
    '            ack상태 = "no"
    '        End If
    '    Catch ex As Exception
    '        MessageBox.Show("" & Convert.ToString(ex))
    '    End Try
    'End Sub




End Class

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

Public Class WI_SA1120_CID
    'Inherits Form
    Private use_port As String, 상태 As String, ack상태 As String
    Private active_port As SerialPort

    Private startm As Char = Convert.ToChar(&H2)
    Private endn As Char = Convert.ToChar(&H3)

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub call_number_info_Load(sender As Object, e As EventArgs) Handles Me.Load
        Me.Open("wi_sa1120_cid_g10")

        초기화()

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

    ' 포트 선택
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

    Private Sub 읽기(s As Object, e As EventArgs)
        Try
            Dim 동기수신문 As String = active_port.ReadTo(Convert.ToString(Convert.ToChar(&H3)))

            If 동기수신문.Length = 29 Then
                ' 정상수신
                If ack상태 = "ok" Then
                    ACK전송()
                End If

                If 동기수신문.Substring(1, 1) = "R" Then

                    ' ack,err
                ElseIf 동기수신문.Substring(1, 1) = "S" Then
                    ' hook
                    If 동기수신문.Substring(3, 29 - 3).Trim() = "HOOK ON" Then
                        정보수신표시(동기수신문)
                    ElseIf 동기수신문.Substring(3, 29 - 3).Trim() = "HOOK OFF" Then
                        정보수신표시(동기수신문)
                    End If
                ElseIf 동기수신문.Substring(1, 1) = "P" Then
                    ' cid info
                    toollabel.Text = 동기수신문.Substring(3, 26).Trim()
                ElseIf 동기수신문.Substring(1, 1) = "C" Then
                    ' missed call
                    정보수신표시(동기수신문)
                ElseIf 동기수신문.Substring(1, 1) = "I" Then
                    ' call number
                    정보수신표시(동기수신문)
                    발신번호표시(동기수신문)

                End If
            Else
                ERR전송()
            End If
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

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

    Private Sub ERR전송()
        'Try
        '    Dim err As String = Convert.ToString(startm) & "R"c & "0"c & "ERR                       " & Convert.ToString(endn)
        '    active_port.Write(err)
        '    정보송신표시(err)
        'Catch ex As Exception
        '    MessageBox.Show("" & Convert.ToString(ex))
        'End Try
    End Sub

    Private Sub 정보수신표시(rxdata As String)
        Try
            listBox_RX.Items.Add(rxdata)
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub 정보송신표시(txdata As String)
        Try
            listBox_TX.Items.Add(txdata)
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

    Private Sub 발신번호표시(readstr As String)
        Try
            Dim x As Integer = readstr.Length
            Dim chstr As String = readstr.Substring(2, 1)
            Dim datestr As String = readstr.Substring(3, 4)
            Dim timestr As String = readstr.Substring(7, 4)
            Dim phonestr As String = readstr.Substring(11, 18)
            phonestr = phonestr.Trim()

            ' 
            If phonestr.Substring(0, 2) = "02" Then
                If phonestr.Length = 9 Then
                    phonestr = phonestr.Substring(0, 2) & "-" & phonestr.Substring(2, 3) & "-" & phonestr.Substring(5, 4)
                ElseIf phonestr.Length = 10 Then
                    phonestr = phonestr.Substring(0, 2) & "-" & phonestr.Substring(2, 4) & "-" & phonestr.Substring(6, 4)
                End If
            Else
                If phonestr.Length = 10 Then
                    phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 3) & "-" & phonestr.Substring(6, 4)
                ElseIf phonestr.Length = 11 Then
                    phonestr = phonestr.Substring(0, 3) & "-" & phonestr.Substring(3, 4) & "-" & phonestr.Substring(7, 4)
                ElseIf phonestr.Length = 12 Then
                    phonestr = phonestr.Substring(0, 4) & "-" & phonestr.Substring(4, 4) & "-" & phonestr.Substring(8, 4)
                End If
            End If

            Dim 쓰기행 As Integer = g10.RowCount

            g10.AddNewRow()

            g10.Text("chstr") = chstr
            g10.Text("datestr") = datestr.Substring(0, 2) & "-" & datestr.Substring(2, 2)
            g10.Text("timestr") = timestr.Substring(0, 2) & ":" & timestr.Substring(2, 2)
            g10.Text("phonestr") = phonestr

            Dim p As New OpenParameters
            p.Add("@tel", g10.Text("phonestr"))
            Dim Dset As DataSet = OpenDataSet("wi_sa1120_cid_cust", p)

            If Not IsEmpty(Dset) Then

                g10.Text("cust_cd") = DataValue(Dset, "cust_cd")

                Dset = Nothing

            End If


            Dim menuName As String = "WI_SA1120"
            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            ctr.Open2(g10.Text("cust_cd"))


        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

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

    Private Sub 장비정보()
        Try
            If 상태 = "열림" Then
                Dim 장비정보 As String = Convert.ToString(startm) & "P"c & "0"c & "CID-INFO" & Convert.ToString(Convert.ToChar(&H3F)) & "                 " & Convert.ToString(endn)
                active_port.Write(장비정보)
                정보송신표시(장비정보)
            End If
        Catch ex As Exception
            MessageBox.Show("" & Convert.ToString(ex))
        End Try
    End Sub

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
End Class

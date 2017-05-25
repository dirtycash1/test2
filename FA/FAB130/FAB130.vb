Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Service7
Imports System.IO
Imports System.Text

Public Class FAB130
    Private Sub FAB130_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'apr_dt.TitleBackColor = Color.Transparent
        MessageInfo(FAB130.__Decrypt("WYa5WKxxfL7peg3ar7F9SFBN5iHCxLp9D0BXqc7LgH91BvEiZN/VMOgPbzRZ+e4VwEbOLIMSg9/MG/VrRTHYe2Rk+jFQJZ7GipcRzBf/lUN7Vi5jawj7+m36iByJHPkLpFFdu4EDVHQF9yPZgjRqKA=="))
        'MessageInfo(FAB130.EncryptData("Data Source=192.168.2.5;Initial Catalog=ERP_2;Persist Security Info=True;User ID=sa;Password=inter07@"))
        pas.Text = FAB130.EncryptData("Data Source=121.78.147.119,2743;Initial Catalog=WEBON;Persist Security Info=True;User ID=sa;Password=emax!234")
    End Sub

    Private Shared Function __Decrypt(ByVal p_data As String) As String
        If (p_data = "") Then
            Return ""
        End If
        Dim provider As New Security.Cryptography.DESCryptoServiceProvider
        Dim buffer3 As Byte() = Encoding.ASCII.GetBytes("dnflskfk")
        provider.Key = buffer3
        provider.IV = buffer3
        Dim stream2 As New MemoryStream
        Dim stream As New Security.Cryptography.CryptoStream(stream2, provider.CreateDecryptor, Security.Cryptography.CryptoStreamMode.Write)
        Dim buffer2 As Byte() = Convert.FromBase64String(p_data)
        stream.Write(buffer2, 0, buffer2.Length)
        stream.FlushFinalBlock()
        Dim bytes As Byte() = stream2.GetBuffer
        stream.Close()
        stream2.Close()
        Return Encoding.UTF8.GetString(bytes, 0, bytes.Length)
        stream.Close()
        stream2.Close()
    End Function

    Private Shared Function EncryptData(inName As String) As String

        Dim stream2 As New MemoryStream
        Dim des As New Security.Cryptography.DESCryptoServiceProvider()
        Dim buffer3 As Byte() = Encoding.ASCII.GetBytes("dnflskfk")
        des.Key = buffer3
        des.IV = buffer3
        Dim buffer2 As Byte() = Encoding.UTF8.GetBytes(inName)
        Dim encStream As New Security.Cryptography.CryptoStream(stream2, des.CreateEncryptor, Security.Cryptography.CryptoStreamMode.Write)


        encStream.Write(buffer2, 0, buffer2.Length)
        encStream.FlushFinalBlock()
        Dim bytes As Byte() = stream2.GetBuffer
        encStream.Close()
        stream2.Close()
        Return Convert.ToBase64String(bytes)

    End Function

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open


                MyBase.Open()
                chk_all.Checked = False

                'If stat_bc.Text = "FA350100" Then
                '    btn_apply.Text = "승인 처리"
                'Else
                '    btn_apply.Text = "승인 취소"
                'End If

            Case MenuType.Save
                '    MyBase.Save()
                '    MyBase.Open()

                'Case MenuType.Delete
                '    Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged
        g10.StopOpenEvent = True
        g10.CheckRows("chk", chk_all.Checked)
        g10.StopOpenEvent = False

        If g10.RowCount > 0 Then
            g10.RowIndex = 0
        End If
    End Sub

    'Private Sub chk_prt_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    '    g10.StopOpenEvent = True
    '    g10.CheckRows("prt", chk_prt.Checked)
    '    g10.StopOpenEvent = False

    '    If g10.RowCount > 0 Then
    '        g10.RowIndex = 0
    '    End If
    'End Sub

    '[승인처리/취소]

    '승인일 지정 승인 처리
    'Private Sub btn_apply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_apply.Click
    '    If Not CheckRequired(apr_dt) Then
    '        Exit Sub
    '    End If
    '    Me._Work(apr_dt.Text)
    'End Sub

    '발의일로 승인 처리
    Private Sub btn_apply_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_apply.Click
        Me._Work("")
    End Sub

    Private Sub _Work(aprDate As String)
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If
        If MessageYesNo("발행처리 하시겠습니까 ?") = MsgBoxResult.Yes Then
            For i = 0 To g10.RowCount - 1
                If g10.Text("chk", i) = "1" Then
                    'If g10.Text("sl_gu", i) = "1" Or g10.Text("sl_gu", i) = "2" Then
                    If g10.Text("sl_gu", i) = "FA350100" Or g10.Text("sl_gu", i) = "FA350500" Then
                        MessageInfo("이미 발행된 건이 있습니다.")
                        Exit Sub
                    End If

                    'If aprDate <> "" Then
                    '    If g10.Text("sl_dt", i).Substring(0, 4) <> aprDate.Substring(0, 4) Then
                    '        MessageInfo("전표일과 승인일의 년도가 틀립니다.")
                    '        Exit Sub
                    '    End If
                    '    g10.Text("sl_dt", i) = aprDate
                    'Else
                    '    g10.Text("sl_dt", i) = g10.Text("sl_dt", i)
                    'End If

                    'If g10.Text("amt1", i) <> g10.Text("amt2", i) Then
                    '    MessageInfo("차/대변이 틀린 전표가 존재합니다.")
                    '    Exit Sub
                    'End If
                End If
            Next

            Me._Save("1")
        End If
    End Sub

    Private Sub btn_cancel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_cancel.Click
        If MessageYesNo("발행취소 하시겠습니까 ?") = MsgBoxResult.Yes Then
            Me._Save("0")
        End If
    End Sub

    Private Sub _Save(ByVal ty As String)
        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                g10.Text("sl_gu", i) = ty '발행
            End If
        Next
        If Me.Save() Then
            Me.Open()
            chk_all.Checked = False
        End If
    End Sub


    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        'If g10.Text("sl_gu") = "1" Or g10.Text("sl_gu") = "2" Then
        If g10.Text("sl_gu") = "FA350100" Or g10.Text("sl_gu") = "FA350500" Then
            Dim menuName As String
            menuName = "FAB100"

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(g10.Text("doc_no"))
            End If
        Else
            Exit Sub
        End If

    End Sub

End Class

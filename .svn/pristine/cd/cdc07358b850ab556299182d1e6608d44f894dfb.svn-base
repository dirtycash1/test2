Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HRM200

    'Private Sub MMC100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    '    'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다
    '    Me.New_Form()

    'End Sub

    Private Sub btn_all_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_all.Click

        If MessageYesNo("전체 집계하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim dSet As DataSet = Me.OpenDataSet("hrm200_work")

        If IsEmpty(dSet) Then
            Exit Sub
        End If

        If dSet.Tables(0).Rows.Count > 0 Then
            Dim frmMsg As New frmMessage
            frmMsg.Text = "작업정보"
            frmMsg.AddLine("")
            frmMsg.AddLine("가족정보 중 잘못된 Data가 있습니다.")
            frmMsg.AddLine("")
            frmMsg.SetDataSet(dSet)
            frmMsg.ShowDialog()

            frmMsg.Dispose()
        End If

    End Sub

    Private Sub btn_chk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_chk.Click
        Dim iRow As Integer, iCnt As Integer, sMsg As String = "", tMsg As String = ""

        With g20
            For iRow = 0 To .RowCount - 1
                If .Text("id_no", iRow) <> "" Then
                    iCnt += 1

                    tMsg = ChkRegNo(.Text("id_no", iRow))

                    If tMsg <> "" Then
                        sMsg += .Text("sq_no", iRow) + " 행 " + tMsg + vbLf
                    End If
                End If
            Next
        End With
        If iCnt = 0 Then
            Exit Sub
        End If
        If sMsg = "" Then
            MessageInfo("주민등록번호 OK.")
        Else
            MessageInfo(sMsg)
        End If
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        If Save() Then

            Dim dSet As DataSet = Me.OpenDataSet("hrm200_work_emp")

            If Not IsEmpty(dSet) Then
                If dSet.Tables(0).Rows.Count > 0 Then
                    Dim frmMsg As New frmMessage
                    frmMsg.Text = "작업정보"
                    frmMsg.AddLine("")
                    frmMsg.AddLine("가족정보 중 잘못된 Data가 있습니다.")
                    frmMsg.AddLine("")
                    frmMsg.SetDataSet(dSet)
                    frmMsg.ShowDialog()

                    frmMsg.Dispose()
                End If

                Exit Sub
            End If


            Dim empNo As String = g10.Text("emp_no")

            Me.Open()

            g10.Find("emp_no=" + empNo)
        End If
    End Sub

End Class

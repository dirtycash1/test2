Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM760

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        o_plan_rev.Focus()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                Dim param As OpenParameters = New OpenParameters
                param.Add("@plan_year", "")
                param.Add("@plan_rev", "")
                param.Add("@co_cd", "")
                param.Add("@dept_cd", "")
                Me.Open("fam760_g20", param)

                plan_year.Text = ""
                plan_rev.Text = ""
                co_cd.Text = ""
                dept_cd.Text = ""
                dept_nm.Text = ""
                emp_nm.Text = ""
                emp_no.Text = ""

                Me.Open("fam760_f10")

            Case MenuType.Open
                If CheckRequired(o_plan_year) Then
                    Me.Open()
                End If

            Case MenuType.Save
                If CheckRequired(plan_year, plan_rev, co_cd, dept_nm, emp_nm, work_dt) Then
                    If Me.Save() Then
                        Me.Open()
                    End If
                End If
            Case MenuType.Delete
                Dim dr As DialogResult = MessageBox.Show("계획년도 : " + g10.Text("plan_year") + vbCr +
                                                        "계획차수 : " + g10.Text("plan_rev") + vbCr +
                                                        "법인 : " + g10.Text("co_cd") + vbCr +
                                                        "부서 : " + g10.Text("dept_nm") + vbCr + vbCr +
                                                        "의 인건비 계획을 삭제 하시겠습니까?" + vbCr +
                                                        "([예] 클릭시 데이터베이스에서 데이터가 삭제됩니다.)", "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)

                If dr = DialogResult.Yes Then
                    Dim param As OpenParameters = New OpenParameters
                    param.Add("@plan_year", g10.Text("plan_year"))
                    param.Add("@plan_rev", g10.Text("plan_rev"))
                    param.Add("@co_cd", g10.Text("co_cd"))
                    param.Add("@dept_cd", g10.Text("dept_cd"))
                    Me.Open("fam760_delete", param)
                    Me.Open()
                    MessageBox.Show("데이터가 삭제 되었습니다.", "알림", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g20_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g20.CellValueChanged
        If ColumnName = "bud_amt" Or ColumnName = "work_amt" Then
            g20.Text("cal_amt") = ToDec(g20.Text("work_amt")) - ToDec(g20.Text("bud_amt"))
        End If
    End Sub
End Class

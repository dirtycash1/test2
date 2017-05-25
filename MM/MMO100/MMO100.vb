Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMO100

    Private Sub MMO100_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'Form Load되면서 바로 입력할 수 있게 신규상태로 만든다

        Me.New_Form()

        '출고번호 자동채번 설정
        out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        out_no.CodeDateField = out_dt

    End Sub

    Public Sub New_Form()

        out_no.Text = ""
        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal ty As MenuType)

        Select Case ty

            Case MenuType.Save

                '필수누락 체크 
                If Not Me.WorkSet("mmo100_f10").CheckSaveFields() Then
                    Exit Sub
                End If

                If out_no.Text = "" Then
                    out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEA100에 대한 코딩을 해야 한다
                    out_no.CodeDateField = out_dt
                End If

                '출고등록은 Master-Detail 2개의 Table이 아닌 2개가 합쳐진 하나의 Table로 구성되어있다
                ' 그래서 Form쪽에서는 저장하지 않고 Grid쪽에서 Form쪽의 정보를 받아서 저장한다

                'Binding의 [저장시참조] 로 연결하면 Grid에서 Update가 일어나야만 저장하려한다
                ' 그럴 경우 상단 Form만 Update가 일어나는 경우는 저장되지 않는다

                '그래서 SaveValue()를 사용한다
                ' 상단 Form의 내용을 Grid에 전달해 주어서 Grid가 Update된 것과 같은 효과를 낸다

                g10.SaveValue("out_no", out_no.Text, False)     'False: Grid Row에 변경이 없어도 무조건 Update한다
                g10.SaveValue("out_dt", out_dt.Text, False)
                g10.SaveValue("fac_cd", fac_cd.Text, False)
                g10.SaveValue("wh_cd", wh_cd.Text, False)
                g10.SaveValue("out_bc", out_bc.Text, False)
                g10.SaveValue("dept_cd", dept_cd.Text, False)
                g10.SaveValue("reg_id", reg_id.Text, False)
                'g10.UpdateRow()

                If Not Me.Save() Then
                    '저장에 실패했으면 코드 채번을 반드시 취소한다
                    Me.WorkSet("mmo100_f10").RecoverCodeNo()
                End If

            Case MenuType.New

                Me.New_Form()

            Case Else

                MyBase.MenuButton_Click(ty)

        End Select

    End Sub


End Class

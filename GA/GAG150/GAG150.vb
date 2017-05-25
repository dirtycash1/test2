Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class GAG150

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                If fr_dt.Text = "" And to_dt.Text <> "" Then
                    MsgBox("'거주기간'은 전부 설정이 되거나 설정이 되어있지 않아야 조회가 가능합니다.")
                    Exit Sub
                End If

                If fr_dt.Text <> "" And to_dt.Text = "" Then
                    MsgBox("'거주기간'은 전부 설정이 되거나 설정이 되어있지 않아야 조회가 가능합니다.")
                    Exit Sub
                End If

                MyBase.Open()
                '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '    '사용하려면 재정의 가능하다
                'Case MenuType.Save

                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        Me.Open()

    End Sub

    Private Sub fr_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles fr_dt.TextChanged

        If to_dt.Text <> "" Then
            If fr_dt.Text > to_dt.Text Then
                MsgBox("거주기간 종료날짜 이후의 날짜는 선택할 수 없습니다.")
                fr_dt.Text = to_dt.Text
                Exit Sub
            End If
        End If

    End Sub

    Private Sub to_dt_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles to_dt.TextChanged

        If to_dt.Text = "" Then
            Exit Sub
        End If

        If fr_dt.Text <> "" Then
            If to_dt.Text < fr_dt.Text Then
                MsgBox("거주기간 시작날짜 이전의 날짜는 선택할 수 없습니다.")
                to_dt.Text = fr_dt.Text
                Exit Sub
            End If
        End If

    End Sub

End Class

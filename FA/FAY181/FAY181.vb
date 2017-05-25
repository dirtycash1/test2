Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAY181

    Private Sub FAY181_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.ColumnVisible("dept_nm") = dept_yn.Checked
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me._Open()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub _Open()

        'MsgBox(Calculator("  (22,000*3  /3*(4+ 55.0 *6+(2/1+2)) / 2 -  2   )  "))   '3717998

        '화면 컬럼의 생성
        Me.Init_Title()

        'Data Display
        Me.Disp_Data()

    End Sub

    'Case 2. 년월 기간의 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_mon.Text + "-01"
        Dim toDt As Date = to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String, fldNm As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            fldNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yy-MM")
            arr(0, i) = fldNm            'FieldName
            arr(1, i) = colNm            'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns("tot", arr, "amt")

    End Sub

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("dept_cd").IsMasterKey = True
            g10.GridColumn("acc_cd").IsMasterKey = True
            g10.GridColumn("dept_nm").IsMasterData = True
            g10.GridColumn("acc_nm").IsMasterData = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("mon").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub


    Private Sub dept_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles dept_yn.CheckedChanged
        g10.ColumnVisible("dept_nm") = dept_yn.Checked

        Me._Open()
    End Sub

End Class

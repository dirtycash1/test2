Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAN200


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'g20.ShowRowHeaders = False
        'g20.ShowColumnHeaders = False

        '화면 컬럼의 생성
        Me.Init_Title()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Open
                Me.Open_Form()

            Case MenuType.Save
                MyBase.Save()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private m_EventLock As Boolean

    Public Sub Open_Form()

        m_EventLock = True

        '화면 컬럼의 생성
        Me.Init_Title()

        'Data Display
        Me.Disp_Data()

        m_EventLock = False

        Me.Sum_Data()

    End Sub

    Private Sub merge_yn_CheckedChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles merge_yn.CheckedChanged

        g10.ColumnMerge("rmk_cd") = merge_yn.Checked
        g10.ColumnMerge("rmk_nm") = merge_yn.Checked

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        Me.Sum_Data()
    End Sub

    Private Sub Sum_Data()

        If m_EventLock Then Exit Sub

        Dim m(12) As Integer, n(12) As Integer
        Dim mon As String
        For i = 0 To g10.RowCount - 1
            For j = 1 To 12
                mon = bud_year.Text + "-" + "0" + j.ToString
                If mon.Length = 8 Then mon = mon.Replace("-0", "-")
                If g10.Text("bud_bc", i) = "FA850100" Then
                    m(j - 1) += g10.ToDec(mon, i)
                End If
                If g10.Text("bud_bc", i) = "FA850200" Then
                    n(j - 1) += g10.ToDec(mon, i)
                End If
            Next
        Next

        For j = 1 To 12
            mon = "m" + j.ToString
            g20.RowIndex = 0
            g20.Text(mon, 0) = m(j - 1)

            g20.RowIndex = 1
            g20.Text(mon, 1) = n(j - 1)

            g20.RowIndex = 2
            g20.Text(mon, 2) = n(j - 1) - m(j - 1)

        Next
    End Sub




#Region " 1. Grid 컬럼 초기화 "

    'Unbound Sample: 동적인 Column 생성

    'Case 2. 년월 기간의 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = bud_year.Text + "-01-01"
        Dim toDt As Date = bud_year.Text + "-12-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String, title As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            title = Format(DateAdd(DateInterval.Month, i, frDt), "M월")
            arr(0, i) = colNm            'FieldName
            arr(1, i) = title            'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "amt")

    End Sub


#End Region



#Region " 2. Display "

    'Unbound Sample: Pivot 형식의 Display

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("bs_cd").IsMasterKey = True
            g10.GridColumn("dept_cd").IsMasterKey = True
            g10.GridColumn("acc_cd").IsMasterKey = True
            g10.GridColumn("rmk_cd").IsMasterKey = True
            g10.GridColumn("bud_bc").IsMasterKey = True

            'Detail 부분
            g10.GridColumn("bud_mon").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            g10.GridColumn("co_cd").DefaultText = co_cd.Text
            g10.GridColumn("bs_cd").DefaultText = bs_cd.Text
            g10.GridColumn("dept_cd").DefaultText = dept_cd.Text
            g10.GridColumn("acc_cd").DefaultText = acc_cd.Text

            g10.ReadOnly = False
            g10.AllowAddRows = True
            g10.AddNewRow()


        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region



End Class

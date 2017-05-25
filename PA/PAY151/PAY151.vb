Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PAY151

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        ' g10.ShowRowTotals = False
        ' g10.ShowRowGrandTotals = False

        '  g10.ShowColumnGrandTotals = False


    End Sub



    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            ' Case MenuType.Open
            '  Me.Open_Form()

            'Case MenuType.Save

            '    If Me.Save() Then
            '        '저장후 Open하려면 반드시 저장성공시에 만 Open한다
            '        Me.New_Form()
            '    End If

            Case MenuType.New

                'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
                '  g10.AddNewRow()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal columnFieldIndex As Integer, ByVal columnIndex As Integer, ByVal rowIndex As Integer) Handles g10.DoubleClick

        Dim menuName As String
        menuName = "PAY150"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(g10.Text("app_year", rowIndex), g10.Text("emp_no", rowIndex), g10.Text("emp_nm", rowIndex))
        End If

    End Sub

    'Public Sub Open_Form()

    '    'MsgBox(Calculator("  (22,000*3  /3*(4+ 55.0 *6+(2/1+2)) / 2 -  2   )  "))   '3717998

    '    '화면 컬럼의 생성
    '    Me.Init_Title()

    '    'Data Display
    '    Me.Disp_Data()

    '    '두번째 방법
    '    'Dim dSet As DataSet = Me.OpenDataSet("unbound_g10")
    '    'Me.Disp_Data2(dSet)

    'End Sub


    ''Case 1. DataSet을 이용한 Title 배열
    'Private Sub Init_Title()
    '    '1. 컬럼배열을 만든다
    '    Dim dSet As DataSet = Me.OpenDataSet("pay151_title")
    '    If IsEmpty(dSet) Then
    '        MessageInfo("조회 할 Data가 없습니다")
    '        'g10.Init()
    '        Exit Sub
    '    End If

    '    Dim arr(1, 0) As String, inx As Integer = 0
    '    For Each dRow In dSet.Tables(0).Rows
    '        ReDim Preserve arr(1, inx)      'Array를 증가시킨다

    '        arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
    '        arr(1, inx) = dRow(1)           'Title로 사용된다

    '        inx += 1
    '    Next


    '    g10.InsertArrayColumns(arr)

    'End Sub
    'Private Sub Disp_Data()
    '    Try
    '        'Master 부분
    '        g10.GridColumn("app_year").IsMasterKey = True
    '        g10.GridColumn("emp_no").IsMasterKey = True
    '        g10.GridColumn("emp_nm").IsMasterData = True
    '        g10.GridColumn("bs_cd").IsMasterData = True
    '        g10.GridColumn("dept_nm").IsMasterData = True

    '        'Detail 부분
    '        g10.GridColumn("itm_cd").IsDetailKey = True
    '        g10.GridColumn("val").IsDetailData = True

    '        MyBase.Open()

    '        '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
    '        g10.GridColumn("app_year").DefaultText = app_year.Text

    '    Catch ex As Exception

    '        MessageInfo(ex, "Disp_Data()")

    '    End Try
    'End Sub

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub
End Class

Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class SDD120


    Private Sub SDD120_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '  제품 출하 번호 채번
        'out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'out_no.CodeDateField = out_dt

    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open

    '            'If Not CheckRequired(fac_cd, wh_cd) Then
    '            '    Exit Sub
    '            'End If
    '            MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '            '사용하려면 재정의 가능하다
    '            'Case MenuType.Save
    '            '    'If MyBase.Save() Then

    '            '    ' MyBase.Open()
    '            '    'End If

    '        Case MenuType.Delete
    '            'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

    '        Case MenuType.New
    '            ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

    '        Case MenuType.Print
    '            ' Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If ColumnName = "chk" Then
            If Value = "1" Then
                g10.Text("sal_qty") = g10.Text("rem_qty")
            Else
                g10.Text("sal_qty") = ""
            End If
        End If

    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColumnName = "sal_qty" Then
            If ToDec(Value) > 0 Then
                If ToDec(Value) > g10.ToDec("rem_qty") Then
                    g10.Text("chk") = "0"
                    g10.Text("sal_qty") = "0"
                    MsgBox("출하량보다 매출수량이 클 수 없습니다")
                    Exit Sub
                End If
            End If
        End If
    End Sub

    'Private Sub SimpleButton1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs)

    ' 본 화면에서 바로 출하 처리 할려면 나중에 참조 하기
    '2. 데이타 검정
    'If Not CheckRequired(fac_cd, wh_cd, out_dt) Then
    ' Exit Sub
    ' End If

    ' Me.Save()
    ' Me.Open()

    'End Sub




    Private Sub btn_jump_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_jump.Click


        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        Dim menuName As String = "SDD100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open4(g10.DataSet)



        'Dim iRow As Integer = 0
        'Dim menuName As String = "SDD100"

        ''2. 데이타 검정
        'If Not CheckRequired(cury_bc, sal_dt) Then
        '    Exit Sub
        'End If

        'Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        '' If IsNothing(ctr) Then Exit Sub

        'For iRow = 0 To g10.RowCount - 1
        '    If g10.Text("chk", iRow) = "1" Then
        '        ctr.Open2(g10.Text("out_no", iRow), g10.Text("out_sq", iRow), g10.Text("itm_id", iRow), g10.Text("itm_cd", iRow), g10.Text("itm_nm", iRow), g10.Text("spec", iRow), g10.Text("itm_bc", iRow), g10.Text("out_tot", iRow), g10.Text("std_um", iRow), g10.Text("um_bc", iRow), _
        '                  g10.Text("cust_cd", iRow), g10.Text("cust_nm", iRow), fac_cd.Text, wh_cd.Text, sal_dt.Text, cury_bc.Text)
        '    End If
        'Next

    End Sub


End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEA120

    'Private Sub LEA120_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    '    Me.Open()
    '    ' 자재 납품 번호 채번
    '    dlv_no.CodeNo = "MMB200"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
    '    dlv_no.CodeDateField = dlv_dt
    'End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open

    '            MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '            '사용하려면 재정의 가능하다
    '        Case MenuType.Save
    '            'If MyBase.Save() Then

    '            ' MyBase.Open()
    '            'End If

    '        Case MenuType.Delete
    '            'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

    '        Case MenuType.New
    '            'dlv_no.Text = ""

    '            ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

    '        Case MenuType.Print
    '            ' Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub



    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim custCnt As Integer
        Dim CustCd As String

        If ColumnName = "chk" Then
            If Value = "1" Then
                CustCd = g10.Text("cust_cd")

                '  동일 거래처  체크
                For iRow = 0 To g10.RowCount - 1
                    If CustCd <> g10.Text("cust_cd", iRow) And g10.ToBool("chk", iRow) Then
                        custCnt = ToDec(custCnt) + 1
                    End If
                Next

                If custCnt > 0 Then
                    MsgBox("동일한 거래처만 처리 가능 합니다")
                    g10.UpdateRow()
                    g10.Text("qty") = ""
                    g10.Text("chk", RowIndex) = ""


                    Exit Sub
                End If

                g10.Text("qty") = g10.Text("rem_qty")
            Else
                g10.Text("qty") = ""
            End If

        End If

    End Sub


    Private Sub btn_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_do.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If


        Dim menuName As String = "LEA110"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open3(g10.DataSet)

        'Dim Err_str As String


        'Err_str = ""

        'If in_fac.Text = "" Then
        '    Err_str = Err_str + "입고공장 누락"
        'End If

        'If in_wh.Text = "" Then
        '    Err_str = Err_str + "입고창고 누락"
        'End If
        'If dlv_dt.Text = "" Then
        '    Err_str = Err_str + "입고일자 누락"
        'End If


        'If Err_str <> "" Then
        '    MsgBox(Err_str)
        '    Exit Sub
        'End If

        'If MessageYesNoCancel("납품 등록 하시겠습니까 ?") = MsgBoxResult.Yes Then
        '    Me.Save()
        '    dlv_no.Text = ""
        '    Me.Open()
        'End If
        ''Dim iRow As Integer = 0
        ''Dim menuName As String = "LEA100"
        ''Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ''For iRow = 0 To g10.RowCount - 1
        ''    If g10.Text("chk", iRow) = "1" Then
        ''        ctr.Open2(g10.Text("po_no", iRow), g10.Text("po_sq", iRow), g10.Text("itm_id", iRow), g10.Text("itm_cd", iRow), g10.Text("itm_nm", iRow), g10.Text("spec", iRow), g10.Text("dlv_in_qty", iRow), _
        ''                  g10.Text("cust_cd", iRow), g10.Text("cust_nm", iRow), in_fac.Text, in_wh.Text, dlv_dt.Text)

        ''    End If
        ''Next
    End Sub

End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LES301


    Private Sub LES301_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '  Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                '화면 컬럼의 생성
                Me.Init_Title()
                'Data Display
                Me.Disp_Data()

                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then
                ' MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private startWHColumn As Integer

    Private Sub Init_Title()
        startWHColumn = g10.ColumnCount

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("les301_f10")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "stock_qty")
    End Sub
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("itm_id").IsMasterKey = True

            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("spec").IsMasterData = True
            g10.GridColumn("mng_no").IsMasterData = True

            g10.GridColumn("itm_bc").IsMasterData = True
            g10.GridColumn("um_bc").IsMasterData = True
            g10.GridColumn("grp1_cd").IsMasterData = True
            g10.GridColumn("grp2_cd").IsMasterData = True
            g10.GridColumn("grp3_cd").IsMasterData = True
            g10.GridColumn("model_cd").IsMasterData = True
            g10.GridColumn("spec1").IsMasterData = True
            g10.GridColumn("tot_qty").IsMasterData = True

            'Detail 부분
            g10.GridColumn("wh_cd").IsDetailKey = True
            g10.GridColumn("stock_qty").IsDetailData = True

            MyBase.Open()

            g10.BestFitColumns()

            If chk_wh.Checked Then
                Dim isBlank As Boolean
                For i As Integer = startWHColumn To g10.ColumnCount - 1
                    isBlank = True
                    For iRow = 0 To g10.RowCount - 1
                        If g10.ToDec(i, iRow) <> 0 Then
                            isBlank = False
                            Exit For
                        End If
                    Next
                    g10.ColumnVisible(i) = Not isBlank
                Next
            End If


            '  g10.ColumnVisible("mng_no") = chk_lot.Checked


            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            ' g10.GridColumn("std_dt").DefaultText = std_dt.Text

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub

End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BC_BARCODE
    'Public Overrides Sub Open()

    '    '화면 컬럼의 생성
    '    Me.Init_Title()
    '    MyBase.Open()

    'End Sub


    Private Sub Init_Title()

        ''1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("bc_barcode_title1")
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

            'MsgBox(dRow(0))
            'MsgBox(dRow(1))

        Next

        'g10.InsertArrayColumns(Nothing, arr, "SPEC")
        g10.InsertMultiColumns(arr)
        'g10.InsertArrayColumns(Nothing, arr, "SPEC")


    End Sub



    Private Sub BC_BARCODE_Load(sender As Object, e As EventArgs) Handles Me.Load
        Try
            'Master 부분
            'g10.GridColumn("GD_NM").IsMasterKey = True
            'g10.GridColumn("POWER").IsMasterKey = True
            'g10.GridColumn("GD_CD").IsMasterKey = True   'SMK낱개추가
            'g10.GridColumn("S10_CODE").IsMasterKey = True
            'g10.GridColumn("S30_CODE").IsMasterKey = True
            'g10.GridColumn("S40_CODE").IsMasterKey = True


            g10.GridColumn("CODE").IsMasterKey = True


            'Detail 부분
            g10.GridColumn("CODE").IsDetailKey = True

            g10.GridColumn("ST_YEAR").IsDetailData = True
            'g10.GridColumn("CODE").IsDetailData = True




            'g10.GridColumn("WH_CD").IsDetailKey = True
            'g10.GridColumn("P_QTY").IsDetailData = True  'SMK낱개추가
            'g10.GridColumn("S10_QTY").IsDetailData = True
            'g10.GridColumn("S30_QTY").IsDetailData = True
            'g10.GridColumn("S40_QTY").IsDetailData = True



            'MyBase.Open()
            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("fr_dt").DefaultText = fr_dt.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub



End Class

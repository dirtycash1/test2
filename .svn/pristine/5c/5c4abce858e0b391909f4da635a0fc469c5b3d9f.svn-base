Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAY150

    Public Overrides Sub Open()

        Me.Init_Title()

        Me.Disp_Data()

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("fay150_title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")
            'g10.Init()
            Exit Sub
        End If

        Dim arr(2, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(2, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다
            arr(2, inx) = dRow(2)           'Band Title로 사용된다

            inx += 1
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "end_amt")

    End Sub

    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("cust_cd").IsMasterKey = True
            g10.GridColumn("cust_bc").IsMasterData = True
            g10.GridColumn("cust_nm").IsMasterData = True
            g10.GridColumn("biz_no").IsMasterData = True
            g10.GridColumn("zip_cd").IsMasterData = True
            g10.GridColumn("addr_prt").IsMasterData = True
            g10.GridColumn("tot1").IsMasterData = True
            g10.GridColumn("tot2").IsMasterData = True

            'g10.GridColumn("acc_nm").IsMasterData = True
            'g10.GridColumn("end_amt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("acc_cd").IsDetailKey = True
            g10.GridColumn("end_amt").IsDetailData = True

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

            MyBase.Open()

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub

End Class

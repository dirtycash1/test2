Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class PAU101

    Private dSet As DataSet

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()

                'Case MenuType.Save

                '    If MyBase.Save() Then
                '        MyBase.Open()
                '    End If


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub


    Public Sub Open_Form()

       
        Me.Init_Title()


        Me.Disp_Data()


    End Sub

    Private Sub Init_Title()

        ''1. 컬럼배열을 만든다
        'Dim frDt As Date = fr_mon.Text + "-01"
        'Dim toDt As Date = to_mon.Text + "-01"

        'Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        'Dim arr(1, 0) As String, colNm As String
        'For i = 0 To cnt - 1
        '    ReDim Preserve arr(1, i)     'Array를 증가시킨다

        '    colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
        '    arr(0, i) = colNm                        'FieldName
        '    arr(1, i) = colNm.Substring(5, 2)        'Title
        '    'colNm.Substring(0, 4) + "년 " + colNm.Substring(5, 2) + "월"            'Title
        'Next

        'g10.InsertArrayColumns("ty_nm", arr, "pay_mon")


        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("pau101_title")
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

        g10.InsertArrayColumns("ty_nm", arr, "pay_mon")



    End Sub


    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("emp_no").IsMasterKey = True
            g10.GridColumn("emp_nm").IsMasterData = True
            g10.GridColumn("dept_nm").IsMasterData = True
            g10.GridColumn("ty").IsMasterKey = True
            g10.GridColumn("ty_nm").IsMasterData = True
            g10.GridColumn("tot_amt").IsMasterData = True
            g10.GridColumn("tot_avg").IsMasterData = True



            'Detail 부분
            g10.GridColumn("pay_mon").IsDetailKey = True
            g10.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("pau101_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

End Class

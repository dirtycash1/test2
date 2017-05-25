Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class GAS401
    Private dSet As DataSet
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분
            .GridColumn("pay_mon").IsMasterKey = True
            .GridColumn("tel_bc").IsMasterKey = True

            .GridColumn("tot1_sum").IsMasterData = True
            .GridColumn("tot2_sum").IsMasterData = True
            .GridColumn("tot3_sum").IsMasterData = True
            .GridColumn("tot4_sum").IsMasterData = True
            .GridColumn("tot5_sum").IsMasterData = True
            .GridColumn("tot5_sum").IsMasterData = True

            'Detail 부분
            .GridColumn("bs_cd").IsDetailKey = True

            'Multi Column 으로 정의 시 2개이상의 컬럼이 DetailData 로 정의되어야 한다
            .GridColumn("tel_amt").IsDetailData = True
            .GridColumn("itel_amt").IsDetailData = True
            .GridColumn("tel_sum").IsDetailData = True
            .GridColumn("inet_amt").IsDetailData = True
            .GridColumn("tot_sum").IsDetailData = True
            .GridColumn("pay_amt").IsDetailData = True
        End With
    End Sub

    Public Overrides Sub Open()
        '화면 컬럼의 생성
        Me.Init_Title()
        MyBase.Open()
    End Sub
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("gas401_title")
        If IsEmpty(dSet) Then
            MessageInfo("조회 할 Data가 없습니다")

            Exit Sub
        End If

        Dim arr(1, 0) As String, inx As Integer = 0
        For Each dRow In dSet.Tables(0).Rows
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = dRow(0)           'FieldName 으로 사용된다
            arr(1, inx) = dRow(1)           'Title로 사용된다

            inx += 1
        Next

        g10.InsertMultiColumns(arr)


    End Sub
    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            MyBase.Open()

    '        Case MenuType.Save

    '            If MyBase.Save() Then
    '                MyBase.Open()
    '            End If


    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select
    'End Sub


End Class

Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class COB200

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                Me.Save_Form()

                If Me.Save() Then

                    Me.Open_Form()

                End If

            Case MenuType.New

                fr_mon.Text = ""
                Me.Open_Detail()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()

        MyBase.Open("cob200_g10")

    End Sub

    Public Sub Open_Detail()
        Me.Init_Title()

        Me.Disp_Data()
    End Sub

    Public Sub Save_Form()

        g20.SaveValue("fr_mon", "aa")

        ' 1. Get DataSet
        Dim dSet As DataSet = Me.OpenDataSet("cob200_save_cob200")
        If dSet Is Nothing Then
            Exit Sub
        End If

        ' 2. DataSet Clear
        Dim dRow As DataRow
        For Each dRow In dSet.Tables(0).Rows
            dRow.Delete()
        Next

        ' 3. Add New Row
        g20.UpdateCurrentRow()  '화면내용을 DataSet에 반영
        For i = 0 To g20.RowCount - 1
            dRow = dSet.Tables(0).NewRow
            dRow("fr_mon") = fr_mon.Text
            dRow("co_cd") = co_cd.Text
            dRow("fr_cc") = g20.Text("fr_cc", i)
            dRow("div_cd") = g20.Text("div_cd", i)

            dSet.Tables(0).Rows.Add(dRow)
        Next

    End Sub

    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("cob200_title")
        'If IsEmpty(dSet) Then
        '    MessageInfo("조회 할 Data가 없습니다")
        '    'g10.Init()
        '    Exit Sub
        'End If

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

        g20.InsertArrayColumns("tot", arr, "rt")

    End Sub

    Private m_LockEvent As Boolean

    Private Sub Disp_Data()

        m_LockEvent = True

        Try
            'Master 부분

            'g20.GridColumn("fr_mon").IsMasterKey = True    'Mapping정보에서 저장시참조로 저장
            'g20.GridColumn("co_cd").IsMasterKey = True     'Mapping정보에서 저장시참조로 저장
            g20.GridColumn("fr_cc").IsMasterKey = True

            g20.GridColumn("div_cd").IsMasterData = True
            g20.GridColumn("tot").IsMasterData = True
            g20.GridColumn("rmks").IsMasterData = True

            'Detail 부분
            g20.GridColumn("to_cc").IsDetailKey = True
            g20.GridColumn("rt").IsDetailData = True

            Me.Open("cob200_g20")

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        Finally
            m_LockEvent = False
        End Try

    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        If m_LockEvent Then Exit Sub

        fr_mon.Text = g10.Text("fr_mon")
        Me.Open_Detail()
    End Sub

End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class ESJ100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Init_Title()
        Me.Disp_Data()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Init_Title()
                Me.Disp_Data()

            Case MenuType.Save

                save_chk()

                If Me.Save() Then
                    Me.Init_Title()
                    Me.Disp_Data()
                End If

                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub save_chk()

        If g10.RowCount >= 0 Then
            Dim i As Integer

            If plan_bc.Text = "ES100100" Then
                For i = 0 To g10.RowCount - 1
                    If g10.Text("co_cd", i) = "" Then
                        g10.Text("co_cd", i) = co_cd.Text
                    End If
                    If g10.Text("ty", i) = "" Then
                        g10.Text("ty", i) = "계획"
                    End If
                Next
            End If

            If plan_bc.Text = "ES100300" Then
                For i = 0 To g10.RowCount - 1
                    If g10.Text("co_cd", i) = "" Then
                        g10.Text("co_cd", i) = co_cd.Text
                    End If
                    If g10.Text("ty", i) = "" Then
                        g10.Text("ty", i) = "실적"
                    End If
                Next
            End If
        End If

    End Sub

    Private Sub Init_Title()
        '1. 컬럼배열을 만든다
        Dim frDt As Date = std_year.Text + "-01-01"
        Dim toDt As Date = std_year.Text + "-12-31"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, yyyymm As String, title As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다 

            yyyymm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            title = (i + 1).ToString

            arr(0, i) = yyyymm                      'FieldName
            arr(1, i) = title + "월"                'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "val")

    End Sub

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("grp_bc").IsMasterKey = True
            g10.GridColumn("grp_nm").IsMasterKey = True
            g10.GridColumn("cust_cd").IsMasterKey = True
            g10.GridColumn("cust_nm").IsMasterKey = True
            g10.GridColumn("ty").IsMasterKey = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("std_mon").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

    'Private m_StopEvent As Boolean
    'Private m_Line As Integer = 3

    ''두번째 Display 방법: 수동 Coding
    'Private Sub Disp_Data(ByVal dSet As DataSet)

    '    If IsEmpty(dSet) Then
    '        Exit Sub
    '    End If

    '    'Parameter.MainFrame.ProgBar.Visible = True
    '    'Parameter.MainFrame.ProgBar.Minimum = 1
    '    'Parameter.MainFrame.ProgBar.Maximum = dSet.Tables(0).Rows.Count
    '    'Parameter.MainFrame.ProgBar.Value = 1
    '    'Parameter.MainFrame.ProgBar.Step = 1

    '    Try
    '        Windows.Forms.Cursor.Current = Cursors.WaitCursor

    '        Dim dRow As DataRow, colNm As String, s1 As String = "", s2 As String = ""
    '        Dim iRow As Integer, iCnt As Integer

    '        With g10

    '            '추가와 쓰기가 가능해야 행이 추가 된다
    '            g10.AllowAddRows = True
    '            g10.Editable = True
    '            m_StopEvent = True  '쓸데없는 Event방지

    '            iRow = -m_Line

    '            For Each dRow In dSet.Tables(0).Rows
    '                If s1 <> dRow("grp_nm") Or s2 <> dRow("cust_nm") Then

    '                    'Me.SumRowData() 'Row 합계구하기

    '                    g10.AddNewRow()

    '                    iRow += m_line
    '                    '.Row = iRow

    '                    .Text("grp_nm", iRow) = ToStr(dRow("grp_nm"))
    '                    .Text("cust_nm", iRow) = ToStr(dRow("cust_nm"))

    '                    s1 = ToStr(dRow("grp_nm"))
    '                    s2 = ToStr(dRow("cust_nm"))

    '                End If

    '                colNm = ToStr(dRow("std_mon"))

    '                .Text(colNm, iRow + 0) = ToStr(dRow("pln"))
    '                .Text(colNm, iRow + 1) = ToStr(dRow("act"))
    '                .Text(colNm, iRow + 2) = ToStr(dRow("rt"))

    '                iCnt += 1

    '                'Parameter.MainFrame.ProgBar.Value = iCnt

    '            Next

    '            'Me.SumRowData() 'Row 합계구하기

    '            .UpdateRow()

    '            '이것을 쓰야 수정없이 종료해도 저장질의를 하지 않는다
    '            ' 반드시 .UpdateRow() 를 먼저 쓰야 한다 그렇지 않으면 Row가 사라진다
    '            .DataChanged = False

    '            m_StopEvent = False
    '        End With

    '    Catch ex As Exception
    '        MessageError(ex, , "Display()")

    '    Finally
    '        'Parameter.MainFrame.ProgBar.Visible = False

    '        Me.Cursor = Cursors.Default
    '    End Try

    'End Sub

    Private Sub g10_AddedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.AddedRow
        Me.save_chk()
    End Sub

    Private Sub g10_InsertedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.InsertedRow
        Me.save_chk()
    End Sub

    Private Sub plan_bc_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles plan_bc.TextChanged
        Init_Title()
        Disp_Data()
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        If MessageYesNo(std_year.Text + " ← 해당년의 구매 실적을 집계합니다. 기존실적데이터가 있다면 삭제됩니다. 계속 진행 하시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Dim p As OpenParameters = New OpenParameters

        'p.Add("@work_mon", work_mon.Text)
        'p.Add("@bs_cd", bs_cd.Text)
        'p.Add("@emp_no", emp_no.Text)
        'p.Add("@emp_nm", emp_nm.Text)
        'p.Add("@dept_cd", dept_cd.Text)
        'p.Add("@work_bc", work_bc.Text)


        Me.OpenDataSet("esj100_actsum")

        Init_Title()
        Disp_Data()
    End Sub
End Class

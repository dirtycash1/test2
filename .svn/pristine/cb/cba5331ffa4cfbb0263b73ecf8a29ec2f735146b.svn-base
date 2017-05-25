Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class ESG500
    Private ColChg As Boolean

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            'Case MenuType.New

            Case MenuType.Open
                '화면 컬럼의 생성
                Me.Init_Title()

            Case MenuType.Save
                If Save() Then
                    Me.Init_Title()
                End If

                'Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################
    Private Sub Init_Title()
        If CheckRequired(co_cd, std_mon) = False Then Exit Sub

        Dim dSet As DataSet = OpenDataSet("esg100_f10")

        If IsEmpty(dSet) Then
            g10.Clear()
            g10.Init()
        Else
            '1. 컬럼배열을 만든다
            Dim arr(1, 0) As String, colNm As String, colFNm As String
            Dim dRows As DataRowCollection = DataSetRows(dSet), dRow As DataRow, Row As Integer = -1
            For Each dRow In dRows
                Row += 1
                ReDim Preserve arr(1, Row)     'Array를 증가시킨다
                colNm = CStr(dRow("title").ToString)
                colFNm = CStr(dRow("base_cd").ToString)
                arr(0, Row) = colFNm            'FieldName
                arr(1, Row) = colNm             'Title
            Next

            '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
            ' Ex) g10.InsertColumn("A", arr, "B")
            '     "A" 컬럼이후에 삽입된다
            '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
            '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다
            g10.InsertArrayColumns("prt_nm", arr, "amt")
            Disp_Data()
        End If
    End Sub

    Private Sub Disp_Data()
        Try
            ColChg = True
            'Master 부분
            g10.GridColumn("co_cd").IsMasterKey = True
            g10.GridColumn("std_mon").IsMasterKey = True
            g10.GridColumn("sq_no").IsMasterKey = True
            g10.GridColumn("prt_nm").IsMasterKey = True
            g10.GridColumn("sum_amt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("biz_bc").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()
            g10.AllowSort = False
            g10.DataChanged = False

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        Finally
            ColChg = False
        End Try
    End Sub

    Private Sub g10_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If ColChg Then Exit Sub
        Try

            If ColumnName <> "sum_amt" Then
                With g10
                    Dim SumAmt As Double = 0
                    For Col As Integer = 2 To .ColumnCount - 1

                        If .FieldName(Col).StartsWith("CA") Then
                            SumAmt += .ToDec(Col)
                        End If
                    Next
                    .Text("sum_amt") = SumAmt
                End With
            End If

        Catch ex As Exception
            MessageError(ex)
        Finally
            ColChg = False
        End Try

    End Sub
End Class

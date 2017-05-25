Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LES103

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g10.AllowSort = False
        g10.SelectRow = True
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open
                Open_Form()

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
            If fr_dt.Text > to_dt.Text Then
                MessageWarning("[" & fr_dt.Title & "]을 확인해 주시기 바랍니다.")
                Exit Sub
            End If

            Init_Title()
            MyBase.Open("les103_g10")
            'Disp_Data()

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

        'g10.Clear()
        g10.DataSource = Nothing
        For Each Col As eGridColumn In g10.GridColumns
            If Col.IsDetailData Then
                g10.GridView.Columns.Remove(g10.GridView.Columns.ColumnByFieldName(Col.FieldName))
                g10.GridColumns.Remove(Col.FieldName)
            End If
        Next
        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_dt.Text
        Dim toDt As Date = to_dt.Text

        Dim Days As Integer = DateDiff(DateInterval.Day, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String
        frDt = DateAdd(DateInterval.Day, -1, frDt)
        Dim oCol As eGridColumn = g10.GridColumn("qty")
        Dim nCol As eGridColumn

        For i = 0 To Days
            'ReDim Preserve arr(1, i)     'Array를 증가시킨다 (수량,금액) 2개씩 생성

            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "yyyy-MM-dd")
            nCol = oCol.Clon(colNm, colNm)
            nCol.IsDetailData = True
            g10.AddColumn(nCol)
            'arr(0, i) = colNm   'FieldName
            'arr(1, i) = colNm   'Title
        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        'g10.InsertArrayColumns(Nothing, arr, "qty")

    End Sub

    Private Sub Disp_Data()
        Try
            With g10
                '/*************** 품목 현황
                'Master 부분
                .GridColumn("wh_cd").IsMasterKey = True '창고
                .GridColumn("itm_id").IsMasterKey = True '품목구분
                '.GridColumn("mng_no").IsMasterKey = True '품목구분
                .GridColumn("ty").IsMasterKey = True '입고1/출고2/재고3

                .GridColumn("ty_nm").IsMasterData = True '입고/출고/재고
                .GridColumn("itm_bc").IsMasterData = True '품목구분
                .GridColumn("grp1_cd").IsMasterData = True '중분류
                .GridColumn("grp2_cd").IsMasterData = True '중분류
                .GridColumn("grp3_cd").IsMasterData = True '소분류
                .GridColumn("itm_cd").IsMasterData = True
                .GridColumn("itm_nm").IsMasterData = True
                .GridColumn("spec").IsMasterData = True
                .GridColumn("um_bc").IsMasterData = True
                .GridColumn("model_cd").IsMasterData = True
                .GridColumn("spec1").IsMasterData = True
                .GridColumn("mng_no").IsMasterData = True
                .GridColumn("bas_qty").IsMasterData = True

                'Detail 부분
                .GridColumn("dt").IsDetailKey = True
                .GridColumn("qty").IsDetailData = True

                MyBase.Open("les103_g10")

                .BestFitColumns()
                '  g10.ColumnVisible("mng_no") = chk_lot.Checked

                '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
                ' g10.GridColumn("std_dt").DefaultText = std_dt.Text

            End With

        Catch ex As Exception
            MessageInfo(ex, "Disp_Data()")
        End Try
    End Sub
End Class

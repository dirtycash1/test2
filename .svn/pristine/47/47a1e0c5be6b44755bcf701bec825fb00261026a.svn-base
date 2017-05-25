Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraCharts

Public Class ESK160
    Private StartCol As Integer
    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        g10.SelectRow = True
        StartCol = g10.ColumnCount
        Me.Init_Title()
        Me.Disp_Data()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Init_Title()
                Me.Disp_Data()

            Case MenuType.Save

                'Me.save_Form()

                'Case MenuType.New
            Case MenuType.New
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
#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        If std_mon.Text = "" Then
            std_mon.Text = Now.ToShortDateString
        End If

        '1. 컬럼배열을 만든다
        Dim EndMon As Integer = std_mon.Text.Substring(5, 2)
        Dim StdYear As String = std_mon.Text.Substring(0, 5)
        Dim ColNm As String = "", arr(1, 0) As String, inx As Integer = 0

        For Col As Integer = 1 To EndMon
            ColNm = "0" & Col
            If ColNm.Length > 2 Then ColNm = ColNm.Substring(1, 2)
            ReDim Preserve arr(1, inx)      'Array를 증가시킨다

            arr(0, inx) = StdYear & ColNm           'FieldName 으로 사용된다
            arr(1, inx) = ColNm & "월"           'Title로 사용된다

            inx += 1

        Next

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "tot")

    End Sub
#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("sq").IsMasterKey = True
            g10.GridColumn("cap").IsMasterData = True
            g10.GridColumn("tot").IsMasterData = True

            'Detail 부분
            g10.GridColumn("std_mon").IsDetailKey = True
            g10.GridColumn("amt").IsDetailData = True

            MyBase.Open()

            sbchart()
            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

#Region " 2. char "
    Public Sub sbchart()
        Chart1.Series.Clear()
        Dim Col As Integer


        For Row = 0 To g10.RowCount - 1
            If g10.Text("sq", Row) = "5" Or g10.Text("sq", Row) = "6" Then
                Dim Series As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series("Dosimeter", DevExpress.XtraCharts.ViewType.Line)
                Series.PointOptions.ValueNumericOptions.Format = DevExpress.XtraCharts.NumericFormat.Number
                Series.PointOptions.ValueNumericOptions.Precision = 0
                Series.ArgumentScaleType = DevExpress.XtraCharts.ScaleType.Qualitative
                Series.ValueScaleType = DevExpress.XtraCharts.ScaleType.Numerical
                'Series.ArgumentDataMember = "Name"
                'sr.ValueDataMembers[0] = "CurrentDose"
                Series.PointOptions.PointView = DevExpress.XtraCharts.PointView.Values
                Series.Label.ResolveOverlappingMinIndent = 5
                Series.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
                Series.Name = ToStr(g10.Text("cap", Row))
                Chart1.Series.Add(Series)
                Chart1.SeriesTemplate.Label.ResolveOverlappingMode = DevExpress.XtraCharts.ResolveOverlappingMode.Default
                For Col = StartCol To g10.ColumnCount - 1
                    Dim value As Double = 0
                    If ToStr(g10.Text(Col, Row)) = "" Then
                        value = 0
                    Else
                        value = Int(g10.Text(Col, Row))
                    End If
                    Dim point As New SeriesPoint(ToStr(g10.ColumnTitle(Col)), value)
                    Series.Points.Add(point)
                Next
            End If
        Next
    End Sub
#End Region

    Private Sub FindColumn()
        Dim finder(1) As String
        finder(0) = "fac_nm=" + g10.Text("fac_nm")
        finder(1) = "title=소계"

        g10.Find(finder)    '여러가지 조건으로 행을 찾을 수 있다
    End Sub

End Class

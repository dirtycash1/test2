Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class WP_PR3060
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

                'Case MenuType.Save

                '    Me.save_Form()

                'Case MenuType.New

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub
    Public Sub Open_Form()


        Me.Init_Title()
        Me.Disp_Data()



    End Sub
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
          '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_mon.Text + "-01"
        Dim toDt As Date = to_mon.Text + "-01"

        Dim cnt As Integer = DateDiff(DateInterval.Month, frDt, toDt) + 1
        Dim arr(1, 0) As String, colNm As String
        For i = 0 To cnt - 1
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Month, i, frDt), "yyyy-MM")
            arr(0, i) = colNm            'FieldName
            'arr(1, i) = colNm
            arr(1, i) = colNm.Substring(0, 4) + "년 " + colNm.Substring(5, 2) + "월" 'Title
        Next

        g10.InsertArrayColumns(Nothing, arr, "qty_sum")

    End Sub

    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("kijong_cd").IsMasterKey = True
            g10.GridColumn("kijong_nm").IsMasterData = True
            g10.GridColumn("sq").IsMasterKey = True
            g10.GridColumn("title").IsMasterKey = True
            g10.GridColumn("tot_sum").IsMasterData = True

            'Detail 부분
            g10.GridColumn("std_mon").IsDetailKey = True
            g10.GridColumn("qty_sum").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다


        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub
  
End Class

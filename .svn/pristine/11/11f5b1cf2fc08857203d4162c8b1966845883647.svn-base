Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LES102
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()

                'Case MenuType.Save

                'If Me.Save() Then
                '    Me.Open()
                'End If

                'Case MenuType.New


                'Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()

        Me.Init_Title()
 
        Me.Disp_Data()

    End Sub
#Region " 1. Grid 컬럼 초기화 "

    'Case 3. 일자 기간의 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim frDt As Date = fr_dt.Text
        Dim toDt As Date = to_dt.Text

        Dim cnt As Integer = DateDiff(DateInterval.Day, frDt, toDt)
        Dim arr(1, 0) As String, colNm As String
        For i = 0 To cnt
            ReDim Preserve arr(1, i)     'Array를 증가시킨다

            colNm = Format(DateAdd(DateInterval.Day, i, frDt), "MM-dd")
            arr(0, i) = colNm            'FieldName
            arr(1, i) = colNm            'Title
        Next

        g10.InsertArrayColumns("title", arr, "qty")

    End Sub


#End Region

#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'order by   a.in_dt, a.itm_id, sq_ty  
            'Master 부분
            g10.GridColumn("in_dt").IsMasterData = True
            g10.GridColumn("fac_cd").IsMasterData = True
            g10.GridColumn("model_cd").IsMasterKey = True
            g10.GridColumn("itm_id").IsMasterData = True
            g10.GridColumn("itm_cd").IsMasterData = True
            g10.GridColumn("itm_cd_ty").IsMasterKey = True
            g10.GridColumn("itm_ty").IsMasterData = True
            g10.GridColumn("itm_nm").IsMasterData = True
            g10.GridColumn("title").IsMasterData = True
            g10.GridColumn("base_qty").IsMasterData = True
            g10.GridColumn("tot_qty").IsMasterData = True
            g10.GridColumn("sq_ty").IsMasterKey = True



            'Detail 부분
            g10.GridColumn("dt").IsDetailKey = True
            g10.GridColumn("qty").IsDetailData = True

            MyBase.Open()

            ''화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("in_dt").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

    

#End Region

#Region " 3. Save "

    '첫번째 Save 방법: 기본기능을 이용
    Public Function Save_Form() As Boolean

        MyBase.Save()

    End Function

#End Region


End Class

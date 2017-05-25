Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data


Public Class WP_PR1310

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
        Dim dSet As DataSet = Me.OpenDataSet("wp_pr1310_title")
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

        g10.InsertArrayColumns(Nothing, arr, "pri_qty")

    End Sub

    Private Sub Disp_Data()
        Try
            'Master 부분
            g10.GridColumn("lot_no").IsMasterKey = True
            g10.GridColumn("new_gdcd").IsMasterKey = True
            g10.GridColumn("gd_nm").IsMasterData = True
            g10.GridColumn("tot_sum").IsMasterData = True

            'Detail 부분
            g10.GridColumn("gong_cd").IsDetailKey = True
            g10.GridColumn("pri_qty").IsDetailData = True

            MyBase.Open()

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
          

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

End Class

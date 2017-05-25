Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAB104


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.save_Form()

                'Case MenuType.New
            Case MenuType.New

                fr_mon.Text = Now().Date
                to_mon.Text = Now().Date
               
                pay_bc.Text = ""
                pay_kd.Text = ""



            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()

        ' 지급항목
        Me.Init_Title()
        Me.Disp_Data()
        ' 공제항목
        Me.Init_Title1()
        Me.Disp_Data1()

        Me.Open("pab104_g30")

    End Sub

#Region " 1. Grid 컬럼 초기화 "

    'Case 1. DataSet을 이용한 Title 배열
    Private Sub Init_Title()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("pab104_title")
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

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g10.InsertArrayColumns(Nothing, arr, "pay_amt")

    End Sub
#End Region
#Region " 2. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data()
        Try
            'Master 부분

            g10.GridColumn("pay_mon").IsMasterKey = True
            g10.GridColumn("pay_bc").IsMasterKey = True
            g10.GridColumn("pay_kd").IsMasterKey = True
            g10.GridColumn("cnt").IsMasterKey = True
            g10.GridColumn("bs_cd").IsMasterData = True
            g10.GridColumn("tot_pay_amt").IsMasterData = True
            g10.GridColumn("tot_de").IsMasterData = True
            g10.GridColumn("tot_pay").IsMasterData = True
           

            'Detail 부분
            g10.GridColumn("pay_cd").IsDetailKey = True
            g10.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("pab104_g10")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data()")

        End Try
    End Sub

#End Region

#Region " 3. Grid 컬럼 초기화 "

    'Case 3. DataSet을 이용한 Title 배열
    Private Sub Init_Title1()

        '1. 컬럼배열을 만든다
        Dim dSet As DataSet = Me.OpenDataSet("pab104_title1")
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

        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
        ' Ex) g10.InsertColumn("A", arr, "B")
        '     "A" 컬럼이후에 삽입된다
        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다

        g20.InsertArrayColumns(Nothing, arr, "pay_amt")

    End Sub
#End Region
#Region " 4. Display "

    '첫번째 Display 방법: 기본기능을 이용
    Private Sub Disp_Data1()
        Try
            'Master 부분

            g20.GridColumn("pay_mon").IsMasterKey = True
            g20.GridColumn("pay_bc").IsMasterKey = True
            g20.GridColumn("pay_kd").IsMasterKey = True
            g20.GridColumn("cnt").IsMasterKey = True
            g20.GridColumn("bs_cd").IsMasterData = True
            g20.GridColumn("tot_pay_amt").IsMasterData = True
            g20.GridColumn("tot_de").IsMasterData = True
            g20.GridColumn("tot_pay").IsMasterData = True


            'Detail 부분
            g20.GridColumn("pay_cd").IsDetailKey = True
            g20.GridColumn("pay_amt").IsDetailData = True

            MyBase.Open("pab104_g20")

            '화면에서 Grid가 아닌 필드를 Grid 값으로 연결시키기 위해 Default값을 이용한다
            'g10.GridColumn("work_mon").DefaultText = work_mon.Text

        Catch ex As Exception

            MessageInfo(ex, "Disp_Data1()")

        End Try
    End Sub

#End Region


#Region " 3. Save "

    ''첫번째 Save 방법: 기본기능을 이용
    'Public Function Save_Form() As Boolean

    '    MyBase.Save()

    'End Function

#End Region


  

End Class

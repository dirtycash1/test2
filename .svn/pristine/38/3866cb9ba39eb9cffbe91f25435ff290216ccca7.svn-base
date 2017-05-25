Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAZ735

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        With g10
            'Master 부분
            ' g10.GridColumn("fr_year").IsMasterKey = True
            g10.GridColumn("fr_amt").IsMasterKey = True
            g10.GridColumn("to_amt").IsMasterData = True

            'Detail 부분
            g10.GridColumn("dis_cnt").IsDetailKey = True
            g10.GridColumn("tax1_amt").IsDetailData = True
        End With

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Init_Title2()
                MyBase.Open()
            Case MenuType.Save


                If Me.Save() Then
                    '저장후 Open하려면 반드시 저장성공시에 만 Open한다
                    Init_Title2()
                    MyBase.Open()

                End If

                ' Case MenuType.New



            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    'Private Sub New_Form()
    '    '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
    '    MyBase.Open("paz730_g10")

    '    'Grid에 신규행을 추가
    '    g10.AddNewRow()

    'End Sub

    Private Sub Init_Title2()
        '1. 컬럼배열을 만든다
         Dim arr(1, 0) As String, colNm As String

        For i = 0 To 10
            ReDim Preserve arr(1, i)                'Array를 증가시킨다
            arr(0, i) = i + 1                     'Key     -> { 2011-01, 2011-02, 2011-03,,,,, }
            arr(1, i) = (i + 1).ToString + "인공제"    'Title   -> { 1월, 2월, 3월,,,, }
        Next

        g10.InsertArrayColumns(arr)
        '-------+-----+----+-----+-----+-------
        '  …   | 1월 | 2월 | 3월 | 4월 | …       <- Array 컬럼들이 DetailData 컬럼들로 Display
        '-------+-----+----+-----+-----+-------
        ' ex) g10.InsertArrayColumns(arr)
        ' - Array를 DetailData 컬럼들로 Display 
        ' - 마지막 DetailData 로 정의된 컬럼이후에 Arry Band들이 삽입된다, 
        '       마지막 컬럼의 순서를 조정하여 행삽입 위치조정 가능
    End Sub

End Class

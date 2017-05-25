Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QOZ200
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다

            Case MenuType.Save

                If MyBase.Save("qoz200_f10") Then

                End If

                If g20.RowCount > 0 And Tot_Rat() <> 100 Then
                    MsgBox("총 함유률이 100%가 되어야 합니다")
                    Exit Sub
                End If

                If MyBase.Save("qoz200_g20") Then
                    MyBase.Open("qoz200_g20")
                End If

            Case MenuType.Delete
                Me.WorkSets("qoz200_f10").DeleteRow()   '특정Workset을 삭제
                Me.Open()

            Case MenuType.New
                'Me.WorkSets("hra105_1").AddNew()  '특정Workset 신규처리
                mat_cd.Text = ""
                Me.Open("qoz200_f10")
                Me.Open("qoz200_g20")

            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Function Tot_Rat()

        Dim Tot_rt As Integer

        With g20
            Tot_rt = 0
            For row = 0 To .RowCount - 1
                Tot_rt = ToDec(Tot_rt) + .ToDec("wt_rt", row)
            Next
        End With
        Tot_Rat = Tot_rt
    End Function

End Class

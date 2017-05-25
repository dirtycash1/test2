Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAM723

    Private Sub bud_yearmm_TextChanged(sender As System.Object, e As System.EventArgs) Handles bud_yearmm.TextChanged
        bud_year.Text = Mid(bud_yearmm.Text, 1, 4)
        bud_mon.Text = Mid(bud_yearmm.Text, 6, 2)
    End Sub
    Private Function Tot_Rat()

        Dim Tot_amt As Long

        With g20
            Tot_amt = 0
            For row = 0 To .RowCount - 1
                Tot_amt = ToDec(Tot_amt) + .ToDec("bud2_chamt", row)
            Next
        End With
        Tot_Rat = Tot_amt
    End Function


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다

            Case MenuType.Save
                Dim Current_Budcd As String

                Current_Budcd = g10.Text("bud_cd")

                g20.UpdateRow()
                If g20.RowCount > 0 And Tot_Rat() <> Txt_chamt.Text Then
                    MsgBox("확정 총 예산 금액이 하위부서에 동일하게 분할 등록 되어야 합니다")
                    Exit Sub
                End If


                If MyBase.Save("fam723_g20") Then

                    MyBase.Open("fam723_g10")

                    MyBase.Open("fam723_g20")
                    g10.Find("bud_cd=" + Current_Budcd)
                    g20.Find("bud_cd=" + Current_Budcd)
                End If

     

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_Click(sender As Object, e As System.EventArgs) Handles g10.Click
        Txt_chamt.Text = g10.Text("tot_chamt")
    End Sub
    
    Private Sub g10_Load(sender As System.Object, e As System.EventArgs) Handles g10.Load

    End Sub
End Class

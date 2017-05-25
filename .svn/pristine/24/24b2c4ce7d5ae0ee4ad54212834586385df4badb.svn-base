Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAP100

    
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.New_Form()

            Case MenuType.Save

                Me.Save("PAP100_g10")
                Me.Save("PAP100_g20")


            Case MenuType.New

                Me.New_Form()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("PAP100_g10")
        MyBase.Open("PAP100_g20")

    End Sub


    Private Sub but1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but1.Click
        If MessageYesNo(" 기준정보 삭제후 가져오시겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@std_year", std_year.Text)

        Me.OpenDataSet("PAP100_Work", p)

        New_Form()
    End Sub
End Class

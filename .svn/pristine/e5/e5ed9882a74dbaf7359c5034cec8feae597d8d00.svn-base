Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAP760


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.Open

                Me.Open_Form()

            Case MenuType.Save

                'Me.Save("pap500_g20")

                'Case MenuType.New
                'Case MenuType.New


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Public Sub Open_Form()
      
        Me.Open("pap760_g10")
        Me.Open("pap760_g20")
        Me.Open("pap760_g30")
       
     
    End Sub


    Private Sub but_work_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles but_work.Click
        If MessageYesNo("  기존 급여 인상안 집계 삭제 후 제 계산 합니다. 계속 진행 하겠습니까?", "확인") = MsgBoxResult.No Then
            Exit Sub
        End If

        Dim p As OpenParameters = New OpenParameters

        p.Add("@co_cd", co_cd.Text)
        p.Add("@std_year", std_year.Text)
        Me.OpenDataSet("PAP760_Work", p)

        Open_Form()
    End Sub
  

End Class

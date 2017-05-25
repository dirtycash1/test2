Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAS550

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()

            Case MenuType.Save

                If MyBase.Save() Then
                    MyBase.Open()
                End If


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub


    Private Sub work_btn_Click(sender As System.Object, e As System.EventArgs) Handles work_btn.Click
        If MessageYesNo("해당 데이터가 존재하면 삭제후 생성합니다 계속하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        'Dim p As OpenParameters = New OpenParameters
        'p.Add("@std_month", std_month.Text)
        'p.Add("@bs_cd", bs_cd.Text)
        Me.Save("gas550_g20")

        Me.OpenDataSet("gas550_Work")

        Me.Open()
    End Sub
End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PAY800

    Private Sub PAY800_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MyBase.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()
            Case MenuType.Save

                If Me.Save() Then
                    '        '저장후 Open하려면 반드시 저장성공시에 만 Open한다
                    '        Me.New_Form()
                End If

            Case MenuType.New

                'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
                g10.AddNewRow()
                g20.AddNewRow()
                g30.AddNewRow()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

End Class

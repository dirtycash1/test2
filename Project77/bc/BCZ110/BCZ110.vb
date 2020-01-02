Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCZ110


    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.New_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.New_Form()
            Case MenuType.Save

                If Me.Save() Then
                    '저장후 Open하려면 반드시 저장성공시에 만 Open한다
                    Me.Open()
                End If

            Case MenuType.New

                sch_bc.Text = ""
                sch_nm.Text = ""
                close_yn.Text = "0"

                Me.New_Form()


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("bcz110_g10")

        'Grid에 신규행을 추가
        g10.AddNewRow()

    End Sub



End Class

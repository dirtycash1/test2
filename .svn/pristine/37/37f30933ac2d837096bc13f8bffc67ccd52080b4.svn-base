Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Functions

Public Class GAZ300

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.New_Form()
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                End If

            Case MenuType.New
               
                MyBase.Open("gaz300_g10")


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        MyBase.Open("gaz300_g10")

        'Grid에 신규행을 추가
        g10.AddNewRow()

    End Sub


End Class

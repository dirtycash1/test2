Imports Frame7
Imports Base7
Imports Base7.Shared



Public Class HRA101

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True
        g70.RecordNavigator = True
        g80.RecordNavigator = True
        g90.RecordNavigator = True
        g100.RecordNavigator = True

        Me.New_Form()


    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open              
                Me.New_Form()

            Case MenuType.Save

                If Me.Save() Then
                    Me.New_Form()

                End If

            Case MenuType.New

                Me.New_Form()


            Case MenuType.Print
                'Me.Print()
            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub


    Private Sub New_Form()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Me.Open("hra101")
        Me.Open("hra101_f10")
        Me.Open("hra101_f20")
        Me.Open("hra101_f30")
        Me.Open("hra101_g20")
        Me.Open("hra101_g30")
        Me.Open("hra101_g40")
        Me.Open("hra101_g50")
        Me.Open("hra101_g60")
        Me.Open("hra101_g70")
        Me.Open("hra101_g80")
        Me.Open("hra101_g90")
        Me.Open("hra101_g100")


        'Grid에 신규행을 추가 -> Group 컬럼이 있는 상태에서 추가는 의미없음(어떤그룹 밑에 추가행이 생길지 모름)
        g20.AddNewRow()
        g30.AddNewRow()
        g40.AddNewRow()
        g70.AddNewRow()
        g80.AddNewRow()
        g90.AddNewRow()
        g100.AddNewRow()

    End Sub



End Class

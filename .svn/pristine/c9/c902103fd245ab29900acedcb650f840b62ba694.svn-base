Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class SCM100L
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.AllowSort = False
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                Me.Open_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        system_cd.Text = ""
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Dim P As New OpenParameters
        P.Add("@system_cd", " ")

        MyBase.Open("scm100l_g10", P)
        g10.BestFitColumns()


    End Sub

    Public Sub Open_Form()
        Me.Open("scm100l_g10")
        g10.BestFitColumns()
    End Sub

End Class

Imports Frame7
Imports Base7
Imports Base7.Shared





Public Class MMA101


    Private Sub MMA101_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                ' MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub
    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick

        Dim menuName As String = "MMA100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open3(g10.Text("req_no"), g10.Text("req_dt"), g10.Text("fr_fac"), g10.Text("in_fac"), g10.Text("in_wh"))

    End Sub
   
End Class

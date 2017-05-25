Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class QMS110

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.Open()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Save

                If Me.Save() Then

                    Dim saveNo As String
                    saveNo = g10.Text("spc_no")

                    Me.Open()

                    Dim find(0) As String
                    find(0) = "spc_no=" + saveNo
                    g10.Find(find)

                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

End Class

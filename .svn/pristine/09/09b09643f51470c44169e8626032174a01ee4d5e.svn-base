Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_CO1010

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'EPanel1.SetSplitter(spc_1, spc_1.Panel2)
     
        Me.NewForm()
       

    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()


                'Case MenuType.Save


                '    If MessageYesNo("저장 하시겠습니까?") = MsgBoxResult.No Then
                '        Exit Sub
                '    Else
                '        If MyBase.Save() Then
                '            MyBase.OpenTrigger("wi_co1010_multi")
                '        End If
                '    End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
End Class

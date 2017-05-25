Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class GAJ100

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                Me.Open()
              
            Case MenuType.Save

                If Me.Save() Then

                    Dim saveID As String = g10.Text("itm_cd")

                    Me.Open()

                    g10.Find("itm_cd=" + saveID)


                End If

                'Case MenuType.New

                '    New_Form()

                'Case MenuType.Delete

                '    Me.WorkSet("pmc100_f10").DeleteRow()

                '    MyBase.Open()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
 
End Class

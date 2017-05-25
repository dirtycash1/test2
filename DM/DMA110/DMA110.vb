Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMA110


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.New


            'g10.EditText("itm_bc", 0) = "DM100500"
            'g10.EditText("itm_bc", 1) = "DM100500"
            'g10.EditText("itm_bc", 2) = ""
            'g10.EditText("itm_bc", 3) = "제품"

            Case MenuType.Open
                Me.Open()





            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

End Class

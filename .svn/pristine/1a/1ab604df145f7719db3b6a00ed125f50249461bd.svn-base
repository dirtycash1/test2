Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCA100L

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New

                Me.New_Form()

            Case MenuType.Open

                Me.Open_Form()

                'Case MenuType.Save

                '    If Me.Save() Then
                '        Me.New_Form()
                '    End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub New_Form()

        mdl_cd.Text = ""
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Dim P As New OpenParameters
        P.Add("@mdl_cd", " ")

        MyBase.Open("BCA100L_g10", P)
        'MyBase.Open("BCA100L_g20")
        MyBase.Open("BCA100L_g30", P)
        g10.BestFitColumns()
        g20.BestFitColumns()
        g30.BestFitColumns()
    End Sub

    Private Sub Open_Form()

        If XtraTabControl1.SelectedTabPageIndex = 0 Then
            MyBase.Open("BCA100L_g10")
            g10.BestFitColumns()
        Else
            MyBase.Open("BCA100L_g30")
            g30.BestFitColumns()
        End If
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()

        'MyBase.Open("BCA100L_g20")

    End Sub

    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow
        MyBase.Open("BCA100L_g20")
        g20.BestFitColumns()
    End Sub
End Class

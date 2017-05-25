Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRA111

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'XtraTabControl1.SelectedTabPage = Me.XtraTabPage1

        XtraTabControl1.FirstVisiblePageIndex = 0
        XtraTabControl1.Visible = True
        'Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                Select Case XtraTabControl1.SelectedTabPage.Name
                    Case "XtraTabPage1"
                        Me.Open("hra110_g10")
                    Case "XtraTabPage2"
                        Me.Open("hra110_g20")
                    Case "XtraTabPage3"
                        Me.Open("hra110_g30")
                    Case "XtraTabPage4"
                        Me.Open("hra110_g40")
                    Case "XtraTabPage5"
                        Me.Open("hra110_g50")
                    Case "XtraTabPage6"
                        Me.Open("hra110_g60")
                    Case "XtraTabPage7"
                        Me.Open("hra110_g70")
                    Case "XtraTabPage8"
                        Me.Open("hra110_g80")
                    Case "XtraTabPage9"
                        Me.Open("hra110_g90")
                    Case "XtraTabPage10"
                        Me.Open("hra110_g100")
                End Select

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    'Private Sub New_Form()

    '    'MyBase.Open("hra110_g10")

    '    g10.AddNewRow()

    'End Sub



End Class

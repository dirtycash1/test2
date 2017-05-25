Imports Frame7
Imports Base7
Imports Base7.Shared
'Imports System.Math

Public Class FMA101

    Private Sub fma101_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        MyBase.Open()

        g10.RecordNavigator = True
        g20.RecordNavigator = True
        g30.RecordNavigator = True
        g40.RecordNavigator = True
        g50.RecordNavigator = True
        g60.RecordNavigator = True
        g70.RecordNavigator = True
        g80.RecordNavigator = True
        g90.RecordNavigator = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open

                MyBase.Open()



            Case MenuType.New

                MyBase.Open()



            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
   


    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow


        Select Case XtraTabControl.SelectedTabPageIndex

            Case "0"
                Me.Open("fma101_g20")
            Case "1"
                Me.Open("fma101_g30")
            Case "2"
                Me.Open("fma101_g40")
            Case "3"
                Me.Open("fma101_g50")
            Case "4"
                Me.Open("fma101_g60")
            Case "5"
                Me.Open("fma101_g70")
            Case "6"
                Me.Open("fma101_g80")
            Case "7"
                Me.Open("fma101_g90")

        End Select

    End Sub


    Private Sub XtraTabControl_SelectedPageChanged(sender As Object, e As DevExpress.XtraTab.TabPageChangedEventArgs) Handles XtraTabControl.SelectedPageChanged
        Select Case XtraTabControl.SelectedTabPageIndex

            Case "0"
                Me.Open("fma101_g20")
            Case "1"
                Me.Open("fma101_g30")
            Case "2"
                Me.Open("fma101_g40")
            Case "3"
                Me.Open("fma101_g50")
            Case "4"
                Me.Open("fma101_g60")
            Case "5"
                Me.Open("fma101_g70")
            Case "6"
                Me.Open("fma101_g80")
            Case "7"
                Me.Open("fma101_g90")

        End Select
    End Sub
End Class

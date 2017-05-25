Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_TR2101
    Dim p As New OpenParameters
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        NEW_OPEN()
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
            '    '사용하려면 재정의 가능하다
            Case MenuType.Save

                If Me.Save() Then
                    Me.Open()
                    MsgBox("저장하였습니다.")
                    'If Not Saves() Then Exit Sub
                End If
            Case MenuType.Open
                NEW_OPEN()
                Me.Open()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select
    End Sub

    Private Sub NEW_OPEN()
        p.Clear()
        p.Add("@deli_dt", deli_dt.Text)

        Dim dSet As Data.DataSet = Me.OpenDataSet("wp_tr2101_title", p)
        Dim dRow As DataRow, dRows As DataRowCollection
        dRows = dSet.Tables(0).Rows

        For Each dRow In dRows

            EPanel2.Text = "1 주차 (" + ToStr(dRow("FIRST1")) + "일~" + ToStr(dRow("LAST1")) + "일)"
            EPanel4.Text = "2 주차 (" + ToStr(dRow("FIRST2")) + "일~" + ToStr(dRow("LAST2")) + "일)"
            EPanel3.Text = "3 주차 (" + ToStr(dRow("FIRST3")) + "일~" + ToStr(dRow("LAST3")) + "일)"
            EPanel5.Text = "4 주차 (" + ToStr(dRow("FIRST4")) + "일~" + ToStr(dRow("LAST4")) + "일)"

        Next

    End Sub

End Class

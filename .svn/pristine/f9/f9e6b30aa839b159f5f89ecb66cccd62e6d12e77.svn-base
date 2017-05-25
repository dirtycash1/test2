Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_CO1051

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
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
                End If
                'Case MenuType.New
                '    cust_cd.Text = ""
                '    itm_cd.Text = ""
                '    itm_nm.Text = ""
                '    emp_id.Text = ""
                '    emp_nm.Text = ""

                '    Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    'Private Sub g_multi_DoubleClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g_multi.DoubleClick
    '    Dim popup As New Form1

    '    If g_multi.ColumnIndex <> 0 Then Exit Sub

    '    popup.InitPopup()

    '    If popup.ShowDialog() = DialogResult.OK Then
    '        If popup.ActiveControl.Tag IsNot Nothing Then
    '            Dim pReturn As eGrid = popup.ActiveControl.Tag
    '            'popup.ActiveControl.Tag = Nothing
    '            ' 결과 파라미터를 받아서 처리할경우
    '            For i = 0 To pReturn.RowCount - 1
    '                If pReturn.Text("CHK", i) = "1" Then
    '                    g_multi.AddNewRow()
    '                    g_multi.Text("PRICE_CD") = pReturn.Text("GD_CD", i)
    '                    g_multi.Text("PRICE_NM") = pReturn.Text("GD_NM", i)
    '                End If
    '            Next


    '        Else
    '            ' 결과 파라미터가 없는경우
    '        End If

    '    Else
    '    End If


    'End Sub


End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRR250

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.Open()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
      
                If Me.Save() Then

                    Me.Open()
                End If


            Case MenuType.New

                'f_emp_no.Text = ""
                'f_emp_nm.Text = ""
                'ok_emp.Text = ""
                dept_cd.Text = ""
                Me.Open()

                'Case MenuType.Print

                '    Me.print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub chk_all_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_all.CheckedChanged

        g10.CheckRows("eval_yn", chk_all.Checked)

    End Sub


    'Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

    '    If ColumnName = "chk" Then
    '          Select g10.Text("chk")
    '            Case "1"
    '                g10.Text("ok_emp") = ok_emp.Text
    '            Case "0"
    '                g10.Text("ok_emp") = g10.Text("ok_emp")
    '        End Select
    '    End If

    'End Sub
End Class

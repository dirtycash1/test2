Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCV100_TEL

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

    Public Sub open2(ByVal phonestr As String)

        'Me.Clear()
        'g10.Clear()
        Dim p As New OpenParameters
        p.Add("@cust_cd", "XXXX")
        p.Add("@cust_nm", "XXXX")
        p.Add("@tel", "XXX-xxxx-xxxx")

        Me.Open("bcv100_tel_g10", p)

        g10.Focus()
        g10.AddNewRow()
        g10.Text("TEL", g10.RowIndex) = phonestr

        g10.FocusedRowChanged()
        g10.FocusedFieldName = "CUST_CD"

    End Sub


End Class

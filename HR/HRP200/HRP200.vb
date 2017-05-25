Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class HRP200

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pnlCopy.Visible = False
        'Me.New_Form()
    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            Me.New_Form()
    '        Case MenuType.Save

    '            If Me.Save() Then
    '                Me.New_Form()
    '            End If

    '        Case MenuType.New

    '            'bs_cd.Text = ""
    '            emp_no.Text = ""
    '            emp_nm.Text = ""
    '            fr_dt.Text = ""
    '            to_dt.Text = ""
    '            dept_cd.Text = ""

    '            Me.New_Form()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)
    '    End Select

    'End Sub

    'Private Sub New_Form()
    '    Me.Doc()

    '    MyBase.Open("HRP200_g10")

    '    g10.AddNewRow()

    'End Sub

    'Private Sub Doc()

    '    If pay_kd.Text = "HR130100" Then
    '        g10.ColumnVisible("ypay_amt") = True
    '        g10.ColumnVisible("hpay_amt") = False
    '    Else
    '        g10.ColumnVisible("hpay_amt") = True
    '        g10.ColumnVisible("ypay_amt") = False
    '    End If

    'End Sub
    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        pnlCopy.Visible = Not pnlCopy.Visible
    End Sub

End Class

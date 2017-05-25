Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FMP601

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()

                'Case MenuType.New
                '    f_fr_dt.Text = ""
                '    f_fr_dt.ReadOnly = False
                '    MyBase.Open("fmp100_g20")
                '    MyBase.Open("fmp100_g30")
                'Case MenuType.Save
                '    'If f_fr_dt.Text = "" Then
                '    '    MsgBox("'적용시작일' 선택은 필수입니다.")
                '    '    Exit Sub
                '    'End If

                '    If Me.Save() Then

                '        Dim saveID As String = f_fr_dt.Text 'g10.Text("fr_dt")

                '        MyBase.Open()

                '        g10.Find("fr_dt=" + saveID)


                '    End If
             

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

 
    Private Sub chk_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk.CheckedChanged

        If chk.Text = "1" Then
            g10.ColumnVisible("use_mon") = False
            g10.ColumnVisible("rmks") = False
            g10.ColumnVisible("cid_nm") = False
            g10.ColumnVisible("cdt") = False

            Me.Open()
        Else
            g10.ColumnVisible("use_mon") = True
            g10.ColumnVisible("rmks") = True
            g10.ColumnVisible("cid_nm") = True
            g10.ColumnVisible("cdt") = True
            Me.Open()
        End If
    End Sub


End Class

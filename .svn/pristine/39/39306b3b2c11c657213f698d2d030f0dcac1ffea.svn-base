Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class CAW800

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        g10.AllowSort = False
        g10.AllowFilter = False

    End Sub

    Private m_StopEvent As Boolean

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open()

                m_StopEvent = True
                chk_yn.Checked = False
                m_StopEvent = False


            Case MenuType.Save
                If Not CheckRequired(bs_cd, end_bc) Then
                    Exit Sub
                End If

                If Me.Save() Then
                    Me.Open()

                    m_StopEvent = True
                    chk_yn.Checked = False
                    m_StopEvent = False
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

    Private Sub chk_yn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_yn.CheckedChanged
        If m_StopEvent Then
            Exit Sub
        End If

        g10.CheckRows("end_yn", chk_yn.Checked)
    End Sub


End Class

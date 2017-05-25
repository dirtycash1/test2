Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_CO1200A
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'g_list.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Cancel
                Me.Clear()
            Case MenuType.Save
                
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub

    Private Sub gList_Open(ByVal a As String)
        p.Clear()
        p.Add("@nm_cd", a)

        Me.Open("wi_co1200a_list", p)

    End Sub

    Private Sub gMulti_Open(ByVal a As String)
        p.Clear()
        p.Add("@nm_cd", a)
        Me.Open("wi_co1200a_multi", p)

    End Sub

    'Private Sub gResult_Open(ByVal a As Boolean)
    '    p.Clear()
    '    p.Add("@gd_cd", a)
    '    Me.Open("wi_co1200a_result", p)

    'End Sub

    Private Function Search_Check() As Boolean

        If r_nm_cd.Text = Nothing Then
            MsgBox("제품명을 확인하세요.!")
            r_nm_cd.Focus()

            Return False
        End If

        With g_list
            For i As Integer = 0 To .RowCount - 1
                If .Text("VALUE", i) = "" Then
                    MsgBox("값을 확인하세요.!")
                    g_list.Focus()
                    Return(False)

                End If
            Next
        End With

        With g_multi
            For i As Integer = 0 To .RowCount - 1
                If .Text("CD_FROM", i) = "" Or .Text("CD_TO", i) = "" Then
                    MsgBox("구간값을 확인하세요.!")
                    g_multi.Focus()
                    Return False
                End If
            Next
        End With

        Return True

    End Function

    Private Sub Clear()
        gList_Open("XXX")
        gMulti_Open("XXX")
        'gResult_Open("XXX")
        gMulti_Create(False)

        r_nm_cd.Text = ""
        r_nm_nm.Text = ""
        'r_model_no.Text = ""

    End Sub

    Private Sub gMulti_Create(ByVal a As Boolean)
        Dim bc_from As String = "", bc_to As String = ""
        Dim power_from As String = "", power_to As String = ""

        With g_multi
            '.UpdateRow()
            For i As Integer = 0 To .RowCount - 1

                If .Text("SPEC_CD", i) = "20" Then  'bc
                    bc_from = .Text("CD_FROM", i)
                    bc_to = .Text("CD_TO", i)
                ElseIf .Text("SPEC_CD", i) = "30" Then  'power
                    power_from = .Text("CD_FROM", i)
                    power_to = .Text("CD_TO", i)
                End If

                'If .Text("VALUE", i) = "" Then Continue For
            Next
        End With

        p.Clear()

        p.Add("@model_no", r_model_no.Text)
        p.Add("@gd_nm", r_nm_nm.Text)

        p.Add("@bc_from", bc_from)
        p.Add("@bc_to", bc_to)

        If Not a Then
            p.Add("@bc_from", "XXXXXXXXXXXXXXXXx") 'Clear
            p.Add("@bc_to", "XXXXXXXXXXXXXXXXx") 'Clear
        End If

        p.Add("@power_from", power_from)
        p.Add("@power_to", power_to)

        p.Add("@sale_cd", r_nm_cd.Text)

        Dim spec_cd As String = ""

        p.Add("@10", "")
        p.Add("@40", "")
        p.Add("@50", "")
        p.Add("@60", "")
        p.Add("@70", "")
        p.Add("@80", "")
        p.Add("@90", "")

        With g_list
            For i As Integer = 0 To .RowCount - 1
                spec_cd = "@" + .Text("SPEC_CD", i)
                p.Add(spec_cd, .Text("VALUE", i))
            Next
        End With

        Me.Open("wi_co1200a_result", p)
    End Sub


    Private Sub r_nm_cd_TextChanged(sender As System.Object, oldValue As System.String) Handles r_nm_cd.TextChanged
        gList_Open(r_nm_cd.Text)
        gMulti_Open(r_nm_cd.Text)
    End Sub


    Private Sub btn_search_Click(sender As System.Object, e As System.EventArgs) Handles btn_search.Click
        If Not Search_Check() Then Exit Sub
        gMulti_Create(True)
    End Sub

    Private Sub btn_create_Click(sender As System.Object, e As System.EventArgs) Handles btn_create.Click
        If Not Search_Check() Then Exit Sub

        Select Case MessageYesNo("품목코드 일괄생성하시겠습니까.?")
            Case MsgBoxResult.Yes
                For u = 0 To g_result.RowCount - 1
                    g_result.Text("STTS", u) = "S"
                Next
                'g_result.SaveValue("STTS", "S")
                Me.Save()
                For u = 0 To g_result.RowCount - 1
                    g_result.Text("STTS", u) = ""
                Next
                'g_result.SaveValue("STTS", "")
            Case MsgBoxResult.No

                Exit Sub
        End Select
    End Sub
End Class

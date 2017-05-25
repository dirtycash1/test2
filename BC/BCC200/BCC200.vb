Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCC200

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        '근태단위시간(분)
        unit_tm.AddItem("10", "10")
        unit_tm.AddItem("20", "20")
        unit_tm.AddItem("30", "30")
        unit_tm.AddItem("60", "60")
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.New
                bs_cd.Text = ""
                Me.Open("bcc200_f10")
                Me.Open("bcc200_f20")

            Case MenuType.Save
                If Not Me.WorkSet("bcc200_f10").DataChanged Then
                    Exit Sub
                End If

                If Me.Save() Then
                    Dim sBsCd As String = bs_cd.Text

                    Me.Open()

                    g10.Find("bs_cd=" + sBsCd)
                End If

            Case MenuType.Delete

                Me.WorkSet("bcc200_f10").DeleteRow()

                Me.Open()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub bs_nm_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles bs_nm.TextChanging
        bs_nm1.Text = bs_nm.Text
    End Sub

    Private Sub bs_bnm_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles bs_bnm.TextChanging
        bs_bnm1.Text = bs_bnm.Text
    End Sub

    Private Sub ceo_nm_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles ceo_nm.TextChanging
        ceo_nm1.Text = ceo_nm.Text
    End Sub

    Private Sub addr_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles addr.TextChanging
        addr1.Text = addr.Text
    End Sub

    Private Sub homepage_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles homepage.DoubleClick
        If homepage.Text = "" Then Exit Sub
        ' Navigate to a URL.
        System.Diagnostics.Process.Start(homepage.Text)

    End Sub
End Class

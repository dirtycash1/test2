Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class BCC100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim Mon As Integer
        For Mon = 1 To 12
            set_mon.AddItem(Microsoft.VisualBasic.Right("0" & Mon, 2), Mon)
        Next

        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.New


                PutError("COM_NOT_SELECTED")


                co_cd.Text = ""
                Me.Open("bcc100_f10")
                Me.Open("bcc100_f20")

                'Me.WorkSets("bcc100_f10").AddNew()
                'Me.WorkSets("bcc100_f20").AddNew()

            Case MenuType.Save

                If Not Me.WorkSet("bcc100_f10").DataChanged Then
                    Exit Sub
                End If

                If Me.Save() Then
                    Dim sCocd As String = co_cd.Text

                    Me.Open()

                    g10.Find("co_cd=" + sCocd)
                End If

            Case MenuType.Delete

                Me.WorkSet("bcc100_f10").DeleteRow()

                Me.Open()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub co_nm_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles co_nm.TextChanging
        co_nm1.Text = co_nm.Text
    End Sub

    Private Sub co_bnm_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles co_bnm.TextChanging
        co_bnm1.Text = co_bnm.Text
    End Sub

    Private Sub ceo_nm_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles ceo_nm.TextChanging
        ceo_nm1.Text = ceo_nm.Text
    End Sub

    Private Sub addr_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles addr.TextChanging
        addr1.Text = addr.Text
    End Sub

    Private Sub co_nm_TextChanged(ByVal sender As System.Object, ByVal oldValue As System.String) Handles co_nm.TextChanged

    End Sub
End Class

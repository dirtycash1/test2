Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1420
    Private Sub WI_SA1420_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        sl_no.CodeNo = "WI_SA1420"
        sl_no.CodeDateField = sl_dt

        Me.Find()
        'MyBase.Open()


    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                '    'Me.Open()
                '    'Open_Form()
            Case MenuType.Save

                If MyBase.Save() Then
                    Dim saveID As String = sl_no.Text

                    MyBase.Open()

                    g10.Find("sl_no=" + saveID)
                End If
            Case MenuType.Cancel
                'Me.Clear()

            Case MenuType.Confirm
                'If Not ConFrim() Then Exit Sub

            Case MenuType.Deconfirm
                'If Not DeConFrim() Then Exit Sub

            Case MenuType.Find
                Me.Find()

                'Case MenuType.Print
            Case MenuType.Delete
                Me.WorkSet("WI_SA1420_f10").DeleteRow()
                MyBase.Open()

            Case MenuType.New
                NewForm()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Public Overrides Sub NewForm()
        sl_no.Text = ""
        Me.OpenTrigger("WI_SA1420_g10")
        lot_no.Focus()
    End Sub

    Private Sub Find()
        If Split3.Panel1Collapsed = False Then
            Split3.Panel1Collapsed = True
        Else
            Split3.Panel1Collapsed = False

        End If
    End Sub

   
    
End Class

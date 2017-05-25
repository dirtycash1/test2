Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_PR1140
    Dim pa() As String

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(spc_1, spc_1.Panel2)
     
        Me.NewForm()
       

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Print
                Me.Print()
                Me.Open()
                For i = 0 To g_multi.RowCount - 1
                    If pa(i) = "1" Then
                        g_multi.Text("chk", i) = pa(i)
                    End If
                Next
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub Print()
        Dim pp As OpenParameters = New OpenParameters
        pp.Clear()
        Me.Save()
        For i = 0 To g_multi.RowCount - 1
            ReDim Preserve pa(i)
            pa(i) = g_multi.Text("chk", i)
        Next

        pp.Add("@find_from", find_from.Text)
        pp.Add("@find_to", find_to.Text)
        pp.Add("@find_mate_no", find_mate_no.Text)
        pp.Add("@find_gong_cd", find_gong_cd.Text)
        pp.Add("@find_lot_no", find_lot_no.Text)

        System7.ReportView.LoadView("WI_PR1140", "", "wi_pr1140_print", pp)

    End Sub

    Private Sub chk_all_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles chk_all.CheckedChanged
        If chk_all.Checked Then
            g_multi.CheckRows("chk", True)
        Else
            g_multi.CheckRows("chk", False)
        End If
    End Sub
End Class
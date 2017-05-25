Imports Frame7
Imports Base7
Imports Base7.Shared


Public Class WI_EIS1180

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        Me.NewForm()
       

        img.Visible = False

    End Sub

    Private Sub btn_pic_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_pic.Click
        If img.Visible Then
            img.Visible = False
            Me.SplitContainer4.SplitterDistance = 35
        Else
            img.Visible = True
            Me.SplitContainer4.SplitterDistance = 220
        End If
    End Sub
End Class

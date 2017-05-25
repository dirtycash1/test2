Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WP_SA1142
    Dim p As New OpenParameters

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save

                'If Me.Save() Then
                '    Me.Open()
                'End If


            Case MenuType.Cancel
                'Me.Clear()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub Clear()
        p.Clear()
        p.Add("@cs_cd", "XXX")
        p.Add("@cs_nm", "XXX")

        Me.Open("wp_sa1142_g10", p)

        cs_cd.Text = ""
        cs_nm.Text = ""
    End Sub
    Private Sub Print(ByVal GetOTNo As String)
       

    End Sub
    Private Sub but_pri_Click(sender As System.Object, e As System.EventArgs) Handles but_pri.Click
        With g10
            If .RowCount - 1 >= 0 Then
                If .CheckedRows("CHK") = 0 Then
                    Exit Sub
                Else
                    Dim tb As DataTable, drow As DataRow
                    Dim dset As DataSet = Me.OpenDataSet("wp_sa1142_temp")

                    tb = dset.Tables(0)

                    .UpdateRow()
                    tb.BeginLoadData()
                    For i As Integer = 0 To .RowCount - 1
                        If .ToBool("CHK", i) Then
                            drow = tb.NewRow()
                            drow("OT_NO") = .Text("OT_NO", i)

                            tb.Rows.Add(drow)
                        End If
                    Next
                    tb.EndLoadData()

                    MyBase.Save("wp_sa1142_temp")

                    Dim p As OpenParameters = New OpenParameters
                    p.Add("@CS_CD", cs_cd.Text)
                    'p.Add("@CS_NM", cs_nm.Text)
                    'p.Add("@DELI_PLACE", deli_place.Text)
                    'p.Add("@FROM_DT", from_dt.Text)
                    'p.Add("@TO_DT", to_dt.Text)

                    Dim p1 As OpenParameters = New OpenParameters

                    p1.Add("@CS_CD", cs_cd.Text)
                    'p1.Add("@CS_NM", cs_nm.Text)
                    'p1.Add("@DELI_PLACE", deli_place.Text)
                    'p1.Add("@FROM_DT", from_dt.Text)
                    'p1.Add("@TO_DT", to_dt.Text)

                    System7.ReportView.LoadView("WP_SA1142", "", "wp_sa1142_print", p, Nothing, False, 1, "sub", "wp_sa1142_print_sub", p1) '바로출력

                    Exit Sub
                End If
            Else
                Exit Sub
            End If


        End With
        'For Row As Integer = 0 To g_retrieve.RowCount - 1
        '    If g_retrieve.Text("CHK", Row) = "1" Then
        '        Print(g_retrieve.Text("OT_NO", Row))
        '    End If
        'Next

    End Sub


    Private Sub but_all_Click(sender As System.Object, e As System.EventArgs) Handles but_all.Click

        If g10.RowCount - 1 >= 0 Then
            Dim i As Integer
            Dim c As Integer
            c = 0
            For i = 0 To g10.RowCount - 1
                If g10.Text("CHK", i) = "0" Then
                    c = c + 1
                End If
            Next
            If c = 0 Then
                For i = 0 To g10.RowCount - 1
                    g10.Text("CHK", i) = "0"
                Next
            Else
                For i = 0 To g10.RowCount - 1
                    g10.Text("CHK", i) = "1"
                Next
            End If
        End If
    End Sub
End Class

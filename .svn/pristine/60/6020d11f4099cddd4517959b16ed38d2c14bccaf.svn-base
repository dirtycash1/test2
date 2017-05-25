Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HRP100
    Private m_DSet As DataSet

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pnlCopy.Visible = False
        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        Me.GetRt()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            '    Me.New_Form()

            'Case MenuType.Save

            '    If Me.Save() Then
            '        Me.New_Form()
            '    End If
        

            Case MenuType.New

                emp_no.Text = ""
                Me.OpenTrigger("hrp100_g10")

                'f_bs_cd.Text = ""
                'emp_no.Text = ""
                'emp_nm.Text = ""
                'pay_bc.Text = ""
                'work_bc.Text = ""
                'high_bc.Text = ""
                'step_bc.Text = ""
                'base_amt.Text = ""
                'stat_bc.Text = ""
                'medi_amt.Text = ""
                'pens_amt.Text = ""

                'Me.New_Form()
              


            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    'Private Sub New_Form()

    '    Me.Open("hrp100")
    '    Me.Open("hrp100_g10")
    '    Me.Open("hrp100_g20")
    'Me.Open("hrp100_g30")
    'Me.GetRt()
    '    Me.Open("hrp100_g40")
    '    Me.Open("hra100_g20")
    '    Me.Open("hrp100_g60")

    '    g20.AddNewRow()
    '    g30.AddNewRow()
    '    g40.AddNewRow()
    '    g60.AddNewRow()


    'End Sub

    Private Sub GetRt()
        Try
            '요율표 가져오기
            m_DSet = OpenDataSet("hrp100_rt")

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub



    Private Sub g30_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g30.CellValueChanged
        Try
            If ColumnName = "fr_dt" Then
                If Not IsEmpty(m_DSet) Then
                    Dim RtRows As DataRow() = _
                         m_DSet.Tables(0).Select("fr_year = '" & g30.Text("fr_dt").Substring(0, 4) & "'") '기준년도
                    If RtRows.GetLength(0) > 0 Then
                        g30.Text("medi_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("medi_rt"))))
                        g30.Text("treat_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("treat_rt"))))
                        g30.Text("pens_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("pens_rt"))))
                    End If
                End If
            End If


            If ColumnName = "pens_std" Or ColumnName = "pens_rt" Then
                Dim pens_amt As Double = Int(g30.ToDec("pens_std") * (g30.ToDec("pens_rt") / 1000))
                g30.Text("pens_amt") = pens_amt * 10
            End If

            If ColumnName = "medi_std" Or ColumnName = "medi_rt" Then
                Dim medi_amt As Double = Int(g30.ToDec("medi_std") * (g30.ToDec("medi_rt") / 1000))
                g30.Text("medi_amt") = medi_amt * 10
            End If

            If ColumnName = "medi_amt" Or ColumnName = "medi_rt" Or ColumnName = "treat_rt" Then
                g30.Text("treat_amt") = Rounding(((g30.ToDec("medi_amt") * g30.ToDec("treat_rt") / 100) / 10), 0)
                g30.Text("treat_amt") = g30.Text("treat_amt") * 10

            End If
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub


    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        pnlCopy.Visible = Not pnlCopy.Visible
    End Sub

End Class

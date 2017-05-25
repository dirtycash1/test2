Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HRP300
    Private m_DSet As DataSet

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Me.Open()
        Me.GetRt()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Save
                If Me.Save() Then Me.Open()

            Case MenuType.New
                Me.New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)
        End Select

    End Sub

    Private Sub New_Form()
        bs_cd.Text = ""
        emp_no.Text = ""
        emp_nm.Text = ""
        fr_dt.Text = ""
        to_dt.Text = ""
        fr1_dt.Text = ""
        to1_dt.Text = ""
        dept_cd.Text = ""

        Me.Open()
        Me.GetRt()
    End Sub

    'Private Sub Open_Form()
    '    MyBase.Open("HRP300_g10")
    '    g10.AddNewRow()
    'End Sub

    Private Sub GetRt()
        Try
            '요율표 가져오기
            m_DSet = OpenDataSet("hrp300_rt")

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        Try
            If ColumnName = "fr_dt" Then
                If Not IsEmpty(m_DSet) Then
                    Dim RtRows As DataRow() = _
                         m_DSet.Tables(0).Select("fr_year = '" & g10.Text("fr_dt").Substring(0, 4) & "'") '기준년도
                    If RtRows.GetLength(0) > 0 Then
                        g10.Text("medi_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("medi_rt"))))
                        g10.Text("treat_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("treat_rt"))))
                        g10.Text("pens_rt") = ToDec(RtRows(0)((RtRows(0).Table.Columns("pens_rt"))))
                    End If
                End If
            End If

            Dim Amt As Double = 0
            If ColumnName = "pens_std" Or ColumnName = "pens_rt" Then
                Amt = Int(((g10.ToDec("pens_std") * g10.ToDec("pens_rt")) * 0.001))
                g10.Text("pens_amt") = Amt * 10
            End If

            If ColumnName = "medi_std" Or ColumnName = "medi_rt" Then
                Amt = Int(((g10.ToDec("medi_std") * g10.ToDec("medi_rt")) * 0.001))
                g10.Text("medi_amt") = Amt * 10
            End If

            If ColumnName = "medi_amt" Or ColumnName = "medi_rt" Or ColumnName = "treat_rt" Then
                Amt = Int(((g10.ToDec("medi_amt") * g10.ToDec("treat_rt")) * 0.001))
                g10.Text("treat_amt") = Amt * 10
            End If

            '화진전용
            'If ColumnName = "pens_std" Or ColumnName = "pens_rt" Then
            '    g10.Text("pens_amt") = Rounding((g10.ToDec("pens_std") * g10.ToDec("pens_rt")) * 0.001, 0) * 10
            'End If

            'If ColumnName = "medi_std" Or ColumnName = "medi_rt" Then
            '    g10.Text("medi_amt") = Rounding((g10.ToDec("medi_std") * g10.ToDec("medi_rt")) * 0.001, 0) * 10
            'End If

            'If ColumnName = "medi_amt" Or ColumnName = "medi_rt" Or ColumnName = "treat_rt" Then
            '    g10.Text("treat_amt") = Rounding((g10.ToDec("medi_amt") * g10.ToDec("treat_rt")) * 0.001, 0) * 10
            'End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub


End Class

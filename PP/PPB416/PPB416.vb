Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class PPB416

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        '자재청구 번호 채번
        outr_no.CodeNo = "PPB410"        'Function dbo.[fnCodeNo]안에 코딩을 해야 한다
        outr_no.CodeDateField = outr_dt
        'outr_no.CodeParameterField = bs_cd
        'Open_Form()
        Me.New_Form()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'Open_Form()
                Me.Open()

            Case MenuType.Save
                If MyBase.Save() Then
                    'Open_Form()
                    Me.Open()
                End If

            Case MenuType.New
                Me.New_Form()
                'outr_no.Text = ""
                'Open_Form()

            Case MenuType.Print
                Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select

    End Sub

    Public Sub New_Form()

        outr_no.Text = ""
        'Open_Form()
        MyBase.Open()
        g10.AddNewRow()

    End Sub

    Public Sub Open3(ByVal OUTRNO As String, ByVal OUTRDT As String, ByVal faccd As String, ByVal whcd As String) ' ByVal outwh As String,

        outr_no.Text = OUTRNO
        outr_dt.Text = OUTRDT

        fac_cd.Text = faccd
        'out_wh.Text = outwh
        wh_cd.Text = whcd

        MyBase.Open()


    End Sub

    'Private Sub Open_Form()
    '    Me.Open()
    '    If outr_no.Text = "" Then
    '        wh_cd.Enabled = True
    '        out_wh.Enabled = True
    '        outr_dt.Enabled = True
    '    Else
    '        wh_cd.Enabled = False
    '        out_wh.Enabled = False
    '        outr_dt.Enabled = False
    '    End If
    '    wh_cd.TitleStyle = TitleStyle.Needed
    '    out_wh.TitleStyle = TitleStyle.Needed
    '    outr_dt.TitleStyle = TitleStyle.Needed
    'End Sub

    Private Sub Print()
        If CheckRequired(outr_no) = False Then Exit Sub

        Try
            Dim p As OpenParameters = New OpenParameters
            p.Add("@outr_no", outr_no.Text)
            System7.ReportView.LoadView("PPB415", "", "ppb416_Print", p)

        Catch ex As Exception

        End Try
    End Sub

    'Private Sub g10_CellValueChanging(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object)
    '    If ColumnName = "chk" Then
    '        If Value = "0" Then
    '            g10.Text("wo2_qty", g10.RowIndex) = 0
    '        End If
    '        If Value = "1" Then
    '            If (Val(g10.Text("cal_qty", g10.RowIndex)) - Val(g10.Text("outr_stk", g10.RowIndex))) > 0 Then
    '                g10.Text("wo2_qty", g10.RowIndex) = Val(g10.Text("cal_qty", g10.RowIndex)) - Val(g10.Text("outr_stk", g10.RowIndex))
    '            End If

    '        End If
    '    End If
    'End Sub


    'Private Sub opt_show_TextChanged(ByVal sender As Object, ByVal oldValue As String)
    '    'Me._Open()
    '    MyBase.Open()
    'End Sub

End Class

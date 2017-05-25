Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEJ300
    Private NowDt As String

    Private Sub LEJ300_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If out_dt.DefaultText = "" Then out_dt.DefaultText = Now.ToShortDateString
        NowDt = out_dt.DefaultText
        out_dt.Text = NowDt
        '자재 출고 번호 채번
        out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        out_no.CodeDateField = out_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.Open
                g10.AllowAddRows = False

                If Not CheckRequired(std_month, fac_cd, wh_cd) Then
                    Exit Sub
                End If

                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
                SetOutDt()

            Case MenuType.Save

                Me._Save()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub _Save()
        'out_dt.Text = ToLastDate(std_month.Text + "-01")

        If MyBase.Save() Then
            MyBase.Open()
        End If
    End Sub

    Private s As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10
            If ColumnName = "stock_qty" Or ColumnName = "real_qty" Then
                If .ToBool("chk") Then
                    .Text("cont_qty") = .ToDec("stock_qty") - .ToDec("real_qty")
                End If
            End If
        End With
    End Sub

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim ContQty As Double

        If s Then
            Exit Sub
        End If

        s = True

        If ColumnName = "chk" Then
            If Value = "1" Then
                ContQty = g10.ToDec("stock_qty") - g10.ToDec("real_qty")
                If ContQty <> 0 And g10.ToDec("real_qty") <> 0 Then
                    g10.Text("cont_qty") = ContQty

                Else
                    g10.Text("chk") = "0"
                    g10.Text("real_qty") = "0"
                    g10.Text("cont_qty") = ContQty '"0"
                End If
            Else
                g10.Text("real_qty") = ""
                g10.Text("cont_qty") = ""

            End If
        End If

        If ColumnName = "real_qty" Then
            If Value <> "" Then
                g10.Text("chk") = "1"

            End If
        End If

        s = False

    End Sub

    'Private Sub std_month_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles std_month.TextChanged
    '    out_dt.Text = ToLastDate(std_month.Text + "-01")
    'End Sub

    Private Sub btn_out_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_out.Click
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("션택된 행이 없습니다.")
            Exit Sub
        End If
        If MessageYesNo("재고조정출고 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If
        Me._Save()
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click

        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("션택된 행이 없습니다.")
            Exit Sub
        End If

        If MessageYesNo("재고조정출고를 [취소] 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                g10.Text("ty", i) = "D"
            End If
        Next
        Me._Save()
    End Sub

    Private Sub std_month_TextChanged(sender As Object, e As System.EventArgs) Handles std_month.TextChanged
        SetOutDt()
    End Sub

    Private Sub SetOutDt()
        If ToLastDate(std_month.Text + "-01") > NowDt Then
            out_dt.Text = NowDt
        Else
            out_dt.Text = ToLastDate(std_month.Text + "-01")
        End If
        out_dt.DefaultText = out_dt.Text
    End Sub
End Class

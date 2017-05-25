Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter
Imports System.IO
Imports System.Net
Imports Microsoft.VisualBasic

Public Class MMB200_KRS

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g10.SelectRow = True
        If Parameter.Login.UserKd = "SC700300" Then cust_cd.Enabled = False '외주사용자
        With g20
            .AllowGroup = False
            .AllowSort = False
        End With
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.New
                Me._New()

            Case MenuType.Open
                Me._Open()

            Case MenuType.Save
                '납품번호가 채번되지 않은 경우 Return
                If Not CheckRequired(in_fac, dlv_dt) Then
                    Exit Sub
                End If

                If dlv_no.Text = "" Then
                    NewSave
                Else
                    MyBase.Save()
                End If

                Me._Open()

                If g10.RowCount <= 0 Then
                    dlv_dt.Text = ""
                    dlv_no.Text = ""
                    If dlv_dt.Enabled = False Then dlv_dt.Enabled = True
                End If

            Case MenuType.Print
                Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private Sub _New()
        dlv_dt.Text = ""
        dlv_no.Text = ""
        _Open()

    End Sub

    Private Sub _Open()
        'Dim poNo As String = g10.Text("po_no")
        'Dim poSq As String = g10.Text("po_sq")

        MyBase.Open()

        If dlv_no.Text = "" Then
            If dlv_dt.Enabled = False Then dlv_dt.Enabled = True
        Else
            dlv_dt.Enabled = False
        End If
        'dlv_dt.Text = g10.Text("dlv_dt2")

        'If dlv_dt.Text <> "" Then
        '    g10.ColumnVisible("chk") = False
        'Else
        '    g10.ColumnVisible("chk") = True
        'End If

        'Dim find(1) As String
        'find(0) = "po_no=" + poNo
        'find(1) = "po_sq=" + poSq

        'g10.Find(find)
    End Sub

    Private Function CheckCheckRequired() As Boolean
        If Not CheckRequired(in_fac, dlv_dt) Then
            Return False
        End If

        If Not g10.CheckRequired Then
            Return False
        End If

        'If g10.CheckedRows("chk") <= 0 Then Return False

            Dim isError As Boolean = False
            Dim isExistChked As Boolean = False

            For i = 0 To g10.RowCount - 1
                If g10.GetDataRow(i)("chk") = "1" Then
                    isExistChked = True

                    If (g10.GetDataRow(i)("prod_lot") Is System.DBNull.Value OrElse g10.GetDataRow(i)("prod_lot") = String.Empty) Or
                        (g10.GetDataRow(i)("insp_lot") Is System.DBNull.Value OrElse g10.GetDataRow(i)("insp_lot") = String.Empty) Then
                        isError = True
                        g10.GetDataRow(i)("error") = "1"
                    Else
                        g10.GetDataRow(i)("error") = "0"
                    End If
                End If
            Next

        If isExistChked = False Then
            MessageBox.Show("선택된 데이터가 없습니다.", "확인", MessageBoxButtons.OK)
            Return False
        End If

            If isError Then
                MessageBox.Show("생산/검사Lot번호는 필수입력입니다.", "Error", MessageBoxButtons.OK)
                Return False
            End If

            Return True
    End Function

    Public Sub Open2(ByVal DlvNo As String, DlvDt As String)
        dlv_no.Text = DlvNo
        dlv_dt.Text = DlvDt
        MyBase.Open()
        dlv_dt.Enabled = False
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        If ColumnName = "chk" Then

            If Value = "1" Then
                g10.Text("dlv_qty") = g10.Text("rem_qty")
            Else
                g10.Text("dlv_qty") = ""
            End If

        End If

        If ColumnName = "dlv_qty" Then

            g10.Text("chk") = IIf(Value = "", "0", "1")

        End If

        m_StopEvent = False

    End Sub

    Private Sub NewSave()
        If CheckCheckRequired() = False Then
            Return
        End If

        Dim DlvNo As String = dlv_no.Text

        Try
            If dlv_no.Text = "" Then
                Dim p As OpenParameters = New OpenParameters
                p.Add("@dlv_dt", dlv_dt.Text)
                dlv_no.Text = DataValue(Me.OpenDataSet("mmb_200_getcode", p))
                If dlv_no.Text = "" Then Exit Sub
            End If

            g10.SaveValue("dlv_no", dlv_no.Text)
            Me.Save(g10.WorkSet)

        Catch ex As Exception
            If DlvNo = "" Then dlv_no.Text = ""
            MsgBox(ex)
        End Try
    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click
        NewSave()
        Me._Open()
    End Sub

    Private Sub Print()

        Dim p As OpenParameters = New OpenParameters
        p.Add("@dlv_no", dlv_no.Text)

        System7.ReportView.LoadView("MMB200", "", "MMB200_KRS_Print", p) '거래명세표
        System7.ReportView.LoadView("MMB200_2", "", "MMB200_KRS_Print2", p) '부품식별표

    End Sub

    Private Sub btn_getfont_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_getfont.Click
        If font_nm.Text = "" Or url.Text = "" Then Exit Sub
        Try
            Dim FolderNm As String = Target()
            If FolderNm <> "" Then
                File.WriteAllBytes(FolderNm & "\" & font_nm.Text, DownLoadFile(font_nm.Text))
                MsgBox("성공적으로 복사되었습니다.", MsgBoxStyle.Information)
            End If
        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Sub

    Private Function DownLoadFile(ByVal FileNm As String) As Byte()
        DownLoadFile = Nothing
        Try
            Dim wc As WebClient = New WebClient()
            Dim UrlFile As String = url.Text & FileNm
            Dim buffer As Byte() = wc.DownloadData(UrlFile)
            Return buffer

        Catch ex As Exception

        End Try
    End Function

    Private Function Target() As String
        Target = ""
        Try
            Dim TargetDialog As New FolderBrowserDialog, FolderNm As String
            If TargetDialog.ShowDialog = DialogResult.OK Then
                FolderNm = TargetDialog.SelectedPath
                If FolderNm = "" Then
                    MsgBox("저장될 폴더를 선택하세요", MsgBoxStyle.Exclamation)
                    Return ""
                End If
            Else
                Return ""
            End If

            Return FolderNm

        Catch ex As Exception
            MsgBox(ex)
        End Try
    End Function

    Private Sub btn_div_Click(sender As System.Object, e As System.EventArgs) Handles btn_div.Click
        If g10.RowCount <= 0 Or dlv_no.Text = "" Then Exit Sub
        With g10
            If .Text("coil_chk") <> "1" Then
                MessageWarning("Coil정보만 처리가 가능합니다.")
                Exit Sub
            End If

            If .ToDec("chk_qty") > 0 Then
                MessageWarning("검수진행된 자료가 있으므로 처리가 불가합니다.", )
                Exit Sub
            End If

            'If .ToDec("box_cnt") > 1 Then
            '    MessageWarning("1건으로 발행된 Coil정보만 처리가 가능합니다.", )
            '    Exit Sub
            'End If
            itmcd.Text = .Text("itm_cd")
            itmnm.Text = .Text("itm_nm")
            dlv_sq.Text = .Text("dlv_sq")
            dlv_qty.Text = .ToDec("dlv_qty")
            div_tot.Text = dlv_qty.Text
            div_cnt.Text = .ToDec("box_cnt")

            Open("mmb200_krs_g20")
            .Editable = False
            EPanel2.Visible = True
        End With

    End Sub

    Private Sub CoilDiv()

        Try
            'MyBase.Open()
            With g20
                If div_cnt.ToDec = 0 Or div_cnt.ToDec = .RowCount Then Exit Sub

                Dim Start As Integer = .RowCount

                If Start > div_cnt.ToDec Then
                    .AllowDeleteRows = True
                    For Row As Integer = .RowCount - 1 To div_cnt.ToDec Step -1
                        .DeleteRow(Row)
                    Next
                    .AllowDeleteRows = False
                    Dim Tot As Double = 0
                    For Row As Integer = 0 To .RowCount - 1
                        If .IsDataRow(Row) Then
                            Tot += .ToDec("qty", Row)
                        End If
                    Next
                    div_tot.Text = Tot
                Else
                    .AllowAddRows = True
                    For Row As Integer = Start To div_cnt.ToDec - 1
                        .AddNewRow()
                        .Text("box_no", Row) = dlv_no.Text & dlv_sq.Text & (Row + 1)
                        .Text("dlv_no", Row) = dlv_no.Text
                        .Text("dlv_sq", Row) = dlv_sq.Text
                    Next
                    .AllowAddRows = False
                End If

            End With

        Catch ex As Exception
        Finally
            'EPanel2.Visible = False
            'g10.Editable = True
        End Try

    End Sub

    Private Sub btn_work_Click(sender As System.Object, e As System.EventArgs) Handles btn_work.Click
        CoilDiv()
    End Sub

    Private Sub btn_exit_Click(sender As System.Object, e As System.EventArgs) Handles btn_exit.Click
        EPanel2.Visible = False
        g10.Editable = True
    End Sub

    Private Sub btn_save2_Click(sender As System.Object, e As System.EventArgs) Handles btn_save2.Click

        If g20.DataChanged = True Then
            If QtyCheck() = False Then Exit Sub
        End If

        Try
            If Save("mmb200_krs_g20") Then
                Me._Open()
            End If
        Catch ex As Exception

        Finally
            EPanel2.Visible = False
            g10.Editable = True
        End Try

    End Sub

    Private Function QtyCheck() As Boolean

        Try
            With g20
                Dim DlvQty As Double = 0
                For Row As Integer = 0 To .RowCount - 1
                    DlvQty += .ToDec("qty", Row)
                Next
                If DlvQty <> dlv_qty.ToDec Then
                    MessageWarning("Box당 수량의 합과 납품수량이 서로 다릅니다.")
                    Return False
                End If
            End With
            Return True
        Catch ex As Exception

        Finally

        End Try

    End Function

    Private Sub g20_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        With g20

            If ColumnName = "qty" Then
                Dim Tot As Double = 0
                For Row As Integer = 0 To .RowCount - 1
                    If .IsDataRow(Row) Then
                        Tot += .ToDec("qty", Row)
                    End If
                Next
                div_tot.Text = Tot
            End If

        End With
    End Sub
End Class

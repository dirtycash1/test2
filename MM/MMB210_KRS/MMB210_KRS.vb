Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class MMB210_KRS

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        dlv_no.ForeColor = Color.Black
        itm_cd.ForeColor = Color.Black
        itm_nm.ForeColor = Color.Black
        cust_nm.ForeColor = Color.Black
        um_bc_nm.ForeColor = Color.Black

        qty.ForeColor = Color.Black
        dlv_qty.ForeColor = Color.Black
        rem_qty.ForeColor = Color.Black
        pick_cnt.ForeColor = Color.Black

        dlv_no.Text = ""
        itm_cd.Text = ""
        itm_nm.Text = ""
        cust_nm.Text = ""
        um_bc_nm.Text = ""

        qty.EditValue = 0
        dlv_qty.EditValue = 0
        rem_qty.EditValue = 0
        pick_cnt.EditValue = 0

        box_no.Text = ""
        box_no.Focus()

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Try
            Select Case mty

                Case MenuType.New
                    New_Form()

                Case MenuType.Save
                    Save_Form()
                    'Case MenuType.Delete

                Case Else

                    MyBase.MenuButton_Click(mty)

            End Select

        Catch ex As Exception

        Finally
            box_no.SelectAll()
            box_no.Focus()
        End Try

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            dlv_no.Text = ""
            itm_cd.Text = ""
            itm_nm.Text = ""
            cust_nm.Text = ""
            um_bc_nm.Text = ""

            qty.EditValue = 0
            dlv_qty.EditValue = 0
            rem_qty.EditValue = 0
            pick_cnt.EditValue = 0

            box_no.Text = ""
            box_no.Focus()

            Me.Open()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean
        Try

            If Me.Save("mmb210_g20") = True Then
                Me.Open()
            End If

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub box_no_KeyDown(sender As Object, e As System.Windows.Forms.KeyEventArgs) Handles box_no.KeyDown
        If e.KeyCode = Keys.Enter Then
            SaveBarcode()
        End If
    End Sub

    Private Sub SaveBarcode()
        If box_no.Text = "" Then Exit Sub
        If box_no.Text = "END" Then
            PickingEnd("")
            Exit Sub
        End If

        Try
            Dim p As New OpenParameters
            p.Add("@box_no", box_no.Text)
            p.Add("@dlv_no", dlv_no.Text)

            Dim dSet As DataSet = Me.OpenDataSet("mmb210_save", p)

            If IsEmpty(dSet) Then
                MsgBox("정보를 확인할 수 없습니다.", MsgBoxStyle.Exclamation, "확인")
                Exit Sub
            End If

            Dim Msg As String = DataValue(dSet, "msg")
            If Msg = "OK" Then
                dlv_no.Text = DataValue(dSet, "dlv_no")
                itm_cd.Text = DataValue(dSet, "itm_cd")
                itm_nm.Text = DataValue(dSet, "itm_nm")
                cust_nm.Text = DataValue(dSet, "cust_nm")
                um_bc_nm.Text = DataValue(dSet, "um_bc_nm")

                'qty.Text = DataValue(dSet, "qty")
                'dlv_qty.Text = DataValue(dSet, "dlv_qty")
                'rem_qty.Text = DataValue(dSet, "rem_qty")

                If um_bc_nm.Text = "EA" Or um_bc_nm.Text = "" Then
                    qty.EditValue = Format(ToDec(DataValue(dSet, "qty")), "#,###")
                    dlv_qty.EditValue = Format(ToDec(DataValue(dSet, "dlv_qty")), "#,###")
                    rem_qty.EditValue = Format(ToDec(DataValue(dSet, "rem_qty")), "#,###")
                Else
                    qty.EditValue = Format(ToDec(DataValue(dSet, "qty")), "#,###.##0")
                    dlv_qty.EditValue = Format(ToDec(DataValue(dSet, "dlv_qty")), "#,###.##0")
                    rem_qty.EditValue = Format(ToDec(DataValue(dSet, "rem_qty")), "#,###.##0")
                End If

                pick_cnt.EditValue = DataValue(dSet, "pick_cnt")
                Me.Open()

                'If ToDec(rem_qty.Text) = 0 Then PickingEnd()
            Else
                MsgBox(Msg, MsgBoxStyle.Exclamation, "확인")
            End If

        Catch ex As Exception

        Finally
            box_no.SelectAll()
            'box_no.Text = ""
            box_no.Focus()
        End Try
    End Sub

    Private Sub PickingEnd(Optional Ty As String = "1")
        Try
            Dim tit As String = ""

            If Ty = "1" Then
                tit = "Picking이 완료되었습니다." & vbLf & vbLf & "완결처리하시겠습니까?"
            Else
                tit = "완결처리하시겠습니까?"
            End If

            If MsgBox(tit, MsgBoxStyle.YesNo, "납품완료") = MsgBoxResult.Yes Then
                Dim p As New OpenParameters
                p.Add("@box_no", "END")
                p.Add("@dlv_no", dlv_no.Text)

                Dim dSet As DataSet = Me.OpenDataSet("mmb210_save", p)

                If Not IsEmpty(dSet) Then
                    Dim Msg As String = DataValue(dSet, "msg")
                    If Msg = "OK" Then
                        If DataValue(dSet, "dlv_no") <> "" Then
                            dlv_no.Text = DataValue(dSet, "dlv_no")
                            itm_cd.Text = DataValue(dSet, "itm_cd")
                            itm_nm.Text = DataValue(dSet, "itm_nm")
                            cust_nm.Text = DataValue(dSet, "cust_nm")
                            um_bc_nm.Text = DataValue(dSet, "um_bc_nm")

                            'qty.Text = DataValue(dSet, "qty")
                            'dlv_qty.Text = DataValue(dSet, "dlv_qty")
                            'rem_qty.Text = DataValue(dSet, "rem_qty")

                            If um_bc_nm.Text = "EA" Or um_bc_nm.Text = "" Then
                                qty.EditValue = Format(ToDec(DataValue(dSet, "qty")), "#,###")
                                dlv_qty.EditValue = Format(ToDec(DataValue(dSet, "dlv_qty")), "#,###")
                                rem_qty.EditValue = Format(ToDec(DataValue(dSet, "rem_qty")), "#,###")
                            Else
                                qty.EditValue = Format(ToDec(DataValue(dSet, "qty")), "#,###.##0")
                                dlv_qty.EditValue = Format(ToDec(DataValue(dSet, "dlv_qty")), "#,###.##0")
                                rem_qty.EditValue = Format(ToDec(DataValue(dSet, "rem_qty")), "#,###.##0")
                            End If

                            pick_cnt.EditValue = DataValue(dSet, "pick_cnt")
                            box_no.Text = ""
                            Me.Open()
                        Else
                            New_Form()
                        End If
                    Else
                        MsgBox(Msg, MsgBoxStyle.Exclamation, "확인")
                    End If
                End If
            End If

        Catch ex As Exception
        Finally
            box_no.Focus()
        End Try
    End Sub

End Class


Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAS100

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel1)
        EPanel2.SetSplitter(SplitContainer2, SplitContainer2.Panel1)

        'Me.Open()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            'Case MenuType.New

            '    ast_no.Text = ""
            '    Me.OpenTrigger("fas100_g10")

            Case MenuType.Delete

                If Me.Delete("fas100_f10") = ExcuteResult.Succeeded Then
                    Me.Open("fas100_f10")
                End If

            Case MenuType.Save

                If Me.Save() Then
                    Dim s1 As String = ast_no.Text
                    Dim s2 As String = fac_no.Text

                    Me.Open()

                    If s1 <> "" Then
                        g10.Find("ast_no=" + s1)
                    Else
                        g10.Find("fac_no=" + s2)
                    End If
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Overrides Sub NewForm()

        ast_no.Text = ""
        Me.OpenTrigger("fas100_g10")

    End Sub

    Public Sub NewForm2(ByVal facID As String, ByVal astNo As String, ByVal astNm As String, ByVal getDt As String, ByVal getAmt As String, ByVal modelCd As String)

        Me.NewForm()

        fac_id.Text = facID
        ast_no.Text = astNo
        fac_no.Text = astNo
        ast_nm.Text = astNm
        get_amt.Text = ToDec(getAmt)
        get_dt.Text = getDt
        pjt_no.Text = modelCd

    End Sub


    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        If doc_no.Text <> "" Then
            MessageInfo("이미 전표가 생성되었습니다.")
            Exit Sub
        End If

        If Not CheckRequired(cust_cd, vat_amt, tax_bc, asset_bc) Then
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Me.Save() Then
            Me.Open("fas100_make_doc")
            Me.Open("fas100_f10")
        End If

    End Sub

    Private Sub btn_show_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_show_doc.Click
        If doc_no.Text <> "" Then
            Dim menuName As String
            menuName = "FAB100"

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(doc_no.Text)
            End If
        End If
    End Sub

    Private Sub btn_del_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del_doc.Click
        If doc_no.Text <> "" Then

            If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
                Exit Sub
            End If

            If Me.Save() Then
                Me.Open("fas100_delete_doc")
                Me.Open("fas100_f10")
            End If
        End If
    End Sub

    Private Sub btn_trans_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_trans.Click
        If Not Me.Save Then
            Exit Sub
        End If
        Me.Open("fas100_f10")

        If Not CheckRequired(ast_no, fac_no, acc_cd) Then
            Exit Sub
        End If

        Dim menuName As String
        menuName = "FAS710"

        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(ast_no.Text, fac_no.Text, acc_cd.Text)
        End If
    End Sub

    Private Sub btn_doc2_Click(sender As System.Object, e As System.EventArgs) Handles btn_doc2.Click
        If g20.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g20.SaveValue("ty", "1")
        g20.SaveValue("mdt", Now)

        If Me.Save() Then

            Me.OpenDataSet("fas100_make_doc2")

            g20.Open()
        End If
    End Sub

    Private Sub btn_del2_Click(sender As System.Object, e As System.EventArgs) Handles btn_del2.Click
        If g20.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g20.SaveValue("ty", "2")

        If Me.Save() Then
            g20.Open()
        End If
    End Sub

    Private Sub btn_doc3_Click(sender As System.Object, e As System.EventArgs) Handles btn_doc3.Click
        If g30.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g30.SaveValue("ty", "1")
        g30.SaveValue("mdt", Now)

        If Me.Save() Then

            Me.OpenDataSet("fas100_make_doc3")

            g30.Open()
        End If
    End Sub

    Private Sub btn_del3_Click(sender As System.Object, e As System.EventArgs) Handles btn_del3.Click
        If g30.CheckedRows("chk") = 0 Then
            MessageInfo(GetMessage("COM_NOT_SELECTED"))
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        g30.SaveValue("ty", "2")

        If Me.Save() Then
            g30.Open()
        End If
    End Sub
End Class

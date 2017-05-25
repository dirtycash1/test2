Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class MMB250


    Private Sub MMB250_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '반품(가입고반품) 번호 채번
        out_no.CodeNo = "MMB250"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        out_no.CodeDateField = out_dt

        SplitContainer2.Panel1Collapsed = False

        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                'Open_Form()
                '사용하려면 재정의 가능하다
            Case MenuType.Save

                If MyBase.Save() Then
                    'Open_Form()
                    MyBase.Open()
                End If

            Case MenuType.New
                New_Form()

            Case MenuType.Delete

                If MessageYesNoCancel("주의 : 반품정보를 삭제하시겠습니까 ?. 삭제 후 저장 버튼을 클릭하세요") = MsgBoxResult.No Then
                    Exit Sub
                End If

                Me.WorkSets("mmb250_g10").DeleteRow()    '특정Workset을 삭제

            Case MenuType.Print
                prints()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Public Sub prints()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@out_no", out_no.Text)
        'If lot_no.Text <> "" And stts.Text = "C" Then
        System7.ReportView.LoadView("mmb250", "", "mmb250_print", p, )
        'Else

    End Sub

    'If Not CheckRequired(fac_cd, iqc_dt) Then
    '    Exit Sub
    'End If

    'If MessageYesNoCancel("저장 하시겠습니까 ?") = MsgBoxResult.No Then
    '    Exit Sub
    'End If

    'Public Sub Open_Form()
    '    MyBase.Open()
    'End Sub

    Public Sub New_Form()
        out_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()

    End Sub

    Public Sub Open2(ByVal outNo As String)
        out_no.Text = outNo
        MyBase.Open()

    End Sub


    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        g10.DeleteBlankRow()
        'Dim i As Integer
        'Dim k As Integer, l As Integer

        If g10.Text("itm_cd", 0) = "" Then
            g10.DeleteRow(0)
        End If


        If g20.RowCount >= 0 Then
            Dim i As Integer
            'Dim a As Integer
            'a = 0

            For i = 0 To g20.RowCount - 1
                If g20.Text("chk", i) = "1" And g20.ToDec("rem_qty", i) > 0 Then

                    g10.AddNewRow()
                    'For l = 0 To g20.ColumnCount - 1
                    '    For k = 0 To g10.ColumnCount - 1
                    '        If g20.FieldName(l) = g10.FieldName(k) Then
                    '            g10.Text(g10.FieldName(k), g10.RowIndex) = g20.Text(g10.FieldName(k), i)
                    '        End If
                    '    Next
                    'Next

                    g10.Text("itm_id", i) = g20.Text("itm_id", i)
                    g10.Text("itm_cd", i) = g20.Text("itm_cd", i)
                    g10.Text("fac_cd", i) = g20.Text("in_fac", i)
                    g10.Text("wh_cd", i) = g20.Text("in_wh", i)
                    g10.Text("mng_no", i) = g20.Text("mng_no", i)
                    g10.Text("mng2_no", i) = g20.Text("mng2_no", i)
                    g10.Text("use_bc", i) = g20.Text("use_bc", i)
                    g10.Text("cust_cd", i) = g20.Text("cust_cd", i)
                    g10.Text("cust_nm", i) = g20.Text("cust_nm", i)
                    'g10.Text("um_bc", i) = g20.Text("um_bc", i)
                    'g10.Text("dlv_um", i) = g20.Text("dlv_um", i)
                    g10.Text("dlv_qty", i) = g20.Text("dlv_qty", i)
                    g10.Text("out_qty", i) = g20.Text("rem_qty", i)
                    g10.Text("po_qty", i) = g20.Text("po_qty", i)
                    g10.Text("in_up", i) = g20.Text("dlv_up", i)
                    g10.Text("dlv_no", i) = g20.Text("dlv_no", i)
                    g10.Text("dlv_sq", i) = g20.Text("dlv_sq", i)
                    g10.Text("req_no", i) = g20.Text("req_no", i)
                    g10.Text("req_sq", i) = g20.Text("req_sq", i)
                    'g10.Text("cury_bc", i) = g20.Text("cury_bc", i)
                    'g10.Text("dept_cd", i) = g20.Text("dept_cd", i)
                    'g10.Text("ent_bc", i) = g20.Text("ent_bc", i)
                    g10.Text("po_no", i) = g20.Text("po_no", i)
                    'g10.Text("po_sq", i) = g20.Text("po_sq", i)


                End If
            Next
        End If

        For k = 0 To g10.RowCount - 1
            If g10.Text("itm_cd", k) = "" Then
                g10.DeleteRow(k)
            End If
        Next

    End Sub

    Private Sub chk_CheckedChanged(sender As Object, e As System.EventArgs) Handles chk.CheckedChanged
        MyBase.Open("MMB250_g20")
    End Sub

    Private Sub opt_show_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles opt_show.TextChanged
        Me._Open()
    End Sub

    Private Sub _Open()
        '특별권한자가 아니면 업체코드는 필수 검색조건
        'If Not Me.IsManager Then
        '    If Not CheckRequired(cust_cd) Then
        '        Exit Sub
        '    End If
        'End If

        Dim outNo As String = g10.Text("out_no")
        Dim outSq As String = g10.Text("out_sq")

        MyBase.Open()

        Dim find(1) As String
        find(0) = "out_no=" + outNo
        find(1) = "out_sq=" + outSq

        g10.Find(find)

    End Sub

    Private Sub lchk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk.CheckedChanged
        If chk.Text = "1" Then
            SplitContainer2.Panel1Collapsed = False
        Else
            SplitContainer2.Panel1Collapsed = True
        End If
    End Sub


    Private Sub out_fac_TextChanged(sender As System.Object, e As System.EventArgs) Handles out_fac.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("fac_cd", i) = out_fac.Text
        Next
    End Sub

    Private Sub out_wh_TextChanged(sender As System.Object, e As System.EventArgs) Handles out_wh.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("wh_cd", i) = out_wh.Text
        Next
    End Sub

End Class

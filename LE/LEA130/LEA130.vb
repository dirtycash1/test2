Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEA130


    Private Sub LEA130_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '자재 입고 번호 채번
        in_no.CodeNo = "LEA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        in_no.CodeDateField = in_dt

        SplitContainer2.Panel1Collapsed = True

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
            Case MenuType.Print
                prints()
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Public Sub prints()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@in_no", in_no.Text)
        'If lot_no.Text <> "" And stts.Text = "C" Then
        System7.ReportView.LoadView("LEA130", "", "LEA130_print", p, )
        'Else
    End Sub


    'Public Sub Open_Form()
    '    MyBase.Open()
    'End Sub

    Public Sub New_Form()
        in_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()

    End Sub

    Public Sub Open2(ByVal inNo As String)
        in_no.Text = inNo
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
                If g20.Text("chk", i) = "1" Then

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
                    g10.Text("fac_cd", i) = g20.Text("fac_cd", i)
                    g10.Text("wh_cd", i) = g20.Text("wh_cd", i)
                    g10.Text("mng_no", i) = g20.Text("mng_no", i)
                    g10.Text("mng2_no", i) = g20.Text("mng2_no", i)
                    g10.Text("use_bc", i) = g20.Text("use_bc", i)
                    'g10.Text("in_bc", i) = g20.Text("in_bc", i)
                    g10.Text("um_bc", i) = g20.Text("um_bc", i)
                    g10.Text("dlv_um", i) = g20.Text("dlv_um", i)
                    'g10.Text("um_qty", i) = g20.Text("um_qty", i)
                    g10.Text("in_qty", i) = g20.Text("in_qty", i)
                    g10.Text("rtn_bc", i) = g20.Text("rtn_bc", i)
                    g10.Text("in_up", i) = g20.Text("in_up", i)
                    g10.Text("in_amt", i) = g20.Text("in_amt", i)
                    g10.Text("cust_cd", i) = g20.Text("cust_cd", i)
                    g10.Text("dlv_no", i) = g20.Text("dlv_no", i)
                    g10.Text("dlv_sq", i) = g20.Text("dlv_sq", i)
                    g10.Text("req_no", i) = g20.Text("req_no", i)
                    g10.Text("req_sq", i) = g20.Text("req_sq", i)
                    g10.Text("cury_bc", i) = g20.Text("cury_bc", i)
                    g10.Text("dept_cd", i) = g20.Text("dept_cd", i)
                    g10.Text("ent_bc", i) = g20.Text("ent_bc", i)
                    g10.Text("po_no", i) = g20.Text("po_no", i)
                    g10.Text("po_sq", i) = g20.Text("po_sq", i)


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
        MyBase.Open("LEA130_g20")
    End Sub


    Private Sub Ichk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk.CheckedChanged
        If chk.Text = "1" Then
            SplitContainer2.Panel1Collapsed = False
        Else
            SplitContainer2.Panel1Collapsed = True
        End If
    End Sub

End Class

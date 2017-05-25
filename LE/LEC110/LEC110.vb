Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports MySql.Data.MySqlClient



Public Class LEC110

    Dim p As New OpenParameters
    Private Sub LEC110_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '자재 입고 번호 채번
        in_no.CodeNo = "LEC100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        in_no.CodeDateField = in_dt


        Me.New_Form()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                Open_Form()
                '사용하려면 재정의 가능하다
                'Case MenuType.Save
                '    If MyBase.Save() Then
                '        SMS_sand()
                '        MyBase.Save()
                '        Open_Form()
                '        'MyBase.Save()

                '        'MyBase.Open()
                '    End If

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    

    Public Sub Open_Form()
        union_yn.Text = "0"
        MyBase.Open()
    End Sub

    Public Sub New_Form()
        in_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal inNo As String)
        in_no.Text = inNo
        MyBase.Open()
    End Sub

    Public Sub Open3(ByVal dSet As DataSet)
        Me.New_Form()
        g10.DeleteBlankRow()

        Dim i As Integer = 0
        For Each dRow As DataRow In dSet.Tables(0).Rows
            If ToBool(dRow("chk")) Then

                If i = 0 Then
                    cust_cd.Text = ToStr(dRow("cust_cd"))
                    'in_fac.Text = ToStr(dRow("in_fac"))
                    'wh_cd.Text = ToStr(dRow("in_wh"))
                    ent_bc.Text = "LE900300" '소모품발주입고
                End If

                g10.AddNewRow()
                g10.RowIndex = i
                'g10.Text("so_no") = ToStr(dRow("so_no"))
                g10.Text("use_bc", i) = ToStr(dRow("use_bc"))
                g10.Text("part_cd", i) = ToStr(dRow("part_cd"))
                g10.Text("part_nm", i) = ToStr(dRow("part_nm"))
                g10.Text("part_spec", i) = ToStr(dRow("part_spec"))
                g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
                g10.Text("um_bc") = ToStr(dRow("dlv_um"))
                'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
                g10.Text("um_qty") = ToStr(dRow("qty"))
                g10.Text("in_up") = ToStr(dRow("po_up"))
                g10.Text("po_no", i) = ToStr(dRow("po_no"))
                g10.Text("po_sq", i) = ToStr(dRow("po_sq"))
                g10.Text("req_no", i) = ToStr(dRow("req_no"))
                g10.Text("req_sq", i) = ToStr(dRow("req_sq"))
                g10.Text("po_fac", i) = ToStr(dRow("po_fac"))
                g10.Text("in_fac", i) = ToStr(dRow("in_fac"))
                g10.Text("fr_nm", i) = ToStr(dRow("nm"))
                g10.Text("mobile", i) = ToStr(dRow("mobile"))
                'g10.Text("out_up", i) = ToStr(dRow("so_sq"))
                'g10.Text("out_amt", i) = Outtot * Soup

                i += 1
            End If


        Next


    End Sub

    'Public Sub Open4(ByVal dSet As DataSet)
    '    Me.New_Form()
    '    g10.DeleteBlankRow()

    '    Dim i As Integer = 0
    '    For Each dRow As DataRow In dSet.Tables(0).Rows
    '        If ToBool(dRow("chk")) Then

    '            If i = 0 Then
    '                cust_cd.Text = ToStr(dRow("cust_cd"))
    '                in_fac.Text = ToStr(dRow("in_fac"))
    '                wh_cd.Text = ToStr(dRow("in_wh"))
    '                ent_bc.Text = "LE900500" '긴급납품입고
    '            End If

    '            g10.AddNewRow()
    '            g10.RowIndex = i
    '            'g10.Text("so_no") = ToStr(dRow("so_no"))
    '            'g10.Text("so_sq") = ToStr(dRow("so_sq"))
    '            'g10.Text("itm_id", i) = ToStr(dRow("itm_id"))
    '            g10.Text("itm_cd") = ToStr(dRow("itm_cd"))
    '            'g10.Text("itm_nm", i) = ToStr(dRow("itm_nm"))
    '            'g10.Text("itm_bc", i) = ToStr(dRow("itm_bc"))
    '            'g10.Text("spec", i) = ToStr(dRow("spec"))
    '            'g10.Text("model_cd", i) = ToStr(dRow("model_cd"))
    '            'g10.Text("spec1", i) = ToStr(dRow("spec1"))
    '            'g10.Text("std_um", i) = ToStr(dRow("std_um"))
    '            g10.Text("um_bc") = ToStr(dRow("dlv_um"))
    '            'g10.Text("cury_bc", i) = ToStr(dRow("cury_bc"))
    '            g10.Text("um_qty") = ToStr(dRow("qty"))

    '            g10.Text("po_no", i) = ToStr(dRow("po_no"))
    '            g10.Text("po_sq", i) = ToStr(dRow("po_sq"))
    '            g10.Text("dlv_no", i) = ToStr(dRow("dlv_no"))
    '            g10.Text("dlv_sq", i) = ToStr(dRow("dlv_sq"))

    '            'g10.Text("out_up", i) = ToStr(dRow("so_sq"))
    '            'g10.Text("out_amt", i) = Outtot * Soup

    '            i += 1
    '        End If


    '    Next


    'End Sub

    'Public Sub Open2(ByVal Pono As String, ByVal PoSeq As String, ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Poqty As String, _
    '                 ByVal Custcd As String, ByVal Custnm As String, ByVal Infac As String, ByVal Inwh As String, ByVal Indt As String)

    '    cust_cd.Text = Custcd
    '    cust_nm.Text = Custnm
    '    fac_cd.Text = Infac
    '    wh_cd.Text = Inwh
    '    in_dt.Text = Indt
    '    With g10
    '        Dim jRow As Integer = 0
    '        g10.AddNewRow()
    '        jRow = g10.RowIndex
    '        g10.Text("po_no", jRow) = Pono
    '        g10.Text("po_sq", jRow) = PoSeq
    '        g10.Text("itm_id", jRow) = Itmid
    '        g10.Text("itm_cd", jRow) = Itmcd
    '        g10.Text("itm_nm", jRow) = Itmnm
    '        g10.Text("spec", jRow) = Spec
    '        ' g10.Text("dlv_um", jRow) = Umbc
    '        ' g10.Text("um_bc", jRow) = Std_Umbc
    '        g10.Text("in_qty", jRow) = Poqty
    '        g10.Text("in_bc", jRow) = "LE100100"

    '    End With
    'End Sub

    Private Sub btn_price_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_price.Click

        g10.UpdateRow()

        For i As Integer = 0 To g10.RowCount - 1
            Me.Set_Price(i)
        Next
    End Sub

    Private Sub Set_Price(ByVal rowInx As Integer)
        Dim p As New OpenParameters
        p.Add("@part_cd", g10.Text("part_cd", rowInx))
        p.Add("@part_nm", g10.Text("part_nm", rowInx))
        p.Add("@part_spec", g10.Text("part_spec", rowInx))
        p.Add("@cust_cd", cust_cd.Text)
        'p.Add("@cury_bc", g10.Text("cury_bc", rowInx))
        'p.Add("@po_fac", fac_cd.Text)
        p.Add("@in_dt", in_dt.Text)
        Dim dSet As DataSet = OpenDataSet("lec110_cost", p)

        If Not IsEmpty(dSet) Then
            g10.RowIndex = rowInx
            g10.Text("in_up") = DataValue(dSet, "in_up")
        End If
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        With g10

            If ColumnName = "itm_cd" Then
                Me.Set_Price(RowIndex)
            End If


            If ColumnName = "in_amt" Or ColumnName = "um_qty" Then
                If .ToDec("um_qty") = 0 And .ToDec("in_amt") = 0 Then
                    If .Text("in_sq") <> "" Then
                        .Text("in_sq") = ""
                    End If
                Else
                    If .Text("in_sq") = "" Then
                        .Text("in_sq") = .GetNextNumber("in_sq").ToString
                    End If
                End If
            End If

            If ColumnName = "um_qty" Or ColumnName = "in_up" Then
                .Text("in_amt") = .ToDec("um_qty") * .ToDec("in_up")
            End If

        End With
    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click
        union_yn.Text = "1"

        g10.Open()
    End Sub

    Private Sub in_fac_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_fac.TextChanged
        For i = 0 To g10.RowCount - 1
            g10.Text("in_fac", i) = in_fac.Text
        Next
    End Sub

    

  
    Public Sub SMS_sand()
        If MessageYesNo("SMS 전송 할까요? 의뢰자 : " + g10.Text("fr_nm") + ", 핸드폰 : " + g10.Text("mobile") + "입니다") = MsgBoxResult.No Then
            Exit Sub
        Else
            SMS()
        End If
    End Sub
    Private Sub save1(iint As Integer)
        g10.RowIndex = iint
        p.Add("@po_no", g10.Text("po_no", iint))
        p.Add("@fr_nm", g10.Text("fr_nm", iint))
        p.Add("@mobile", g10.Text("mobile", iint))
        p.Add("@part_nm", g10.Text("part_nm", iint))
        p.Add("@in_up", g10.Text("in_up", iint))
        p.Add("@um_qty", g10.Text("um_qty", iint))
        p.Add("@reg_nm", reg_nm.Text)
        ' p.Add("@S_cont", S_cont.Text)
        ' p.Add("@S_addr", S_addr.Text)
        ' p.Add("@S_admo", S_admo.Text)
        Me.Open("lec110_save1", p)
    End Sub
    Public Sub SMS()

        Dim param_nm As String
        Dim param_mo As String
        Dim param_array1(0 To g10.RowCount) As String
        Dim param_array2(0 To g10.RowCount) As String
        For i2 As Integer = 0 To g10.RowCount - 1
            g10.RowIndex = i2
            param_array1(i2) = g10.Text("part_nm")
            param_array2(i2) = g10.Text("mobile")
        Next



        Dim MySQL_CS As String = "Server=192.168.2.19;" & _
            "Database=naonekp;Uid=ekpnaon;Pwd=@skdhs!;"
        Dim SQL As String


        For i As Integer = 0 To g10.RowCount - 1

            param_nm = param_array1(i)
            param_mo = param_array2(i)


            SQL = "INSERT INTO uds_msg (MSG_TYPE, CMID, REQUEST_TIME, DEST_PHONE, SEND_PHONE, MSG_BODY ) VALUES ("
            SQL = SQL & " 0, date_format(now() ,  '%Y%m%d%H%i%s')+" + Format(i + 1) + ", now(), '" + param_mo + "', '0316128519', '" + param_nm + " 이 입고 되었습니다~!');"


            Dim db = New MySqlConnection(MySQL_CS)
            db.Open()
            Dim COMM = New MySqlCommand(SQL, db)
            COMM.ExecuteNonQuery()

            db.Close()
            save1(i)
        Next


    End Sub
End Class

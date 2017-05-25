Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class LEC100

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim custCnt As Integer
        Dim CustCd As String

        If ColumnName = "chk" Then
            If Value = "1" Then
                CustCd = g10.Text("cust_cd")

                '  동일 거래처  체크
                For iRow = 0 To g10.RowCount - 1
                    If CustCd <> g10.Text("cust_cd", iRow) And g10.ToBool("chk", iRow) Then
                        custCnt = ToDec(custCnt) + 1
                    End If
                Next

                If custCnt > 0 Then
                    MsgBox("동일한 거래처만 처리 가능 합니다")
                    g10.UpdateRow()
                    g10.Text("qty") = ""
                    g10.Text("chk", RowIndex) = ""


                    Exit Sub
                End If

                g10.Text("qty") = g10.Text("rem_qty")
            Else
                g10.Text("qty") = ""
            End If

        End If

    End Sub


    Private Sub btn_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_do.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        ''''''''''''''
        Dim menuName As String = "LEC110"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open3(g10.DataSet)
        ''''''''''''''
        'sms_sand()

        'Dim Err_str As String


        'Err_str = ""

        'If in_fac.Text = "" Then
        '    Err_str = Err_str + "입고공장 누락"
        'End If

        'If in_wh.Text = "" Then
        '    Err_str = Err_str + "입고창고 누락"
        'End If
        'If dlv_dt.Text = "" Then
        '    Err_str = Err_str + "입고일자 누락"
        'End If


        'If Err_str <> "" Then
        '    MsgBox(Err_str)
        '    Exit Sub
        'End If

        'If MessageYesNoCancel("납품 등록 하시겠습니까 ?") = MsgBoxResult.Yes Then
        '    Me.Save()
        '    dlv_no.Text = ""
        '    Me.Open()
        'End If
        ''Dim iRow As Integer = 0
        ''Dim menuName As String = "LEA100"
        ''Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ''For iRow = 0 To g10.RowCount - 1
        ''    If g10.Text("chk", iRow) = "1" Then
        ''        ctr.Open2(g10.Text("po_no", iRow), g10.Text("po_sq", iRow), g10.Text("itm_id", iRow), g10.Text("itm_cd", iRow), g10.Text("itm_nm", iRow), g10.Text("spec", iRow), g10.Text("dlv_in_qty", iRow), _
        ''                  g10.Text("cust_cd", iRow), g10.Text("cust_nm", iRow), in_fac.Text, in_wh.Text, dlv_dt.Text)

        ''    End If
        ''Next
    End Sub
    Private Sub sms_sand()
        If MessageYesNo("SMS 전송 할까요? 의뢰자 : " + g10.Text("nm") + ", 핸드폰 : " + g10.Text("mobile") + "입니다") = MsgBoxResult.No Then
            Exit Sub
        Else
            sms()

        End If
    End Sub
    Private Sub sms()
        'Dim param_nm As String
        ' Dim param_mo As String
        Dim param_array1(0 To g10.RowCount) As String
        Dim param_array2(0 To g10.RowCount) As String
        'For i2 As Integer = 0 To g10.RowCount - 1
        '    g10.RowIndex = i2
        '    param_array1(i2) = g10.Text("part_nm")
        '    param_array2(i2) = g10.Text("mobile")
        'Next



        Dim MySQL_CS As String = "Server=192.168.2.19;" & _
            "Database=naonekp;Uid=ekpnaon;Pwd=@skdhs!;"
        Dim SQL As String


        ' For i As Integer = 0 To g10.RowCount - 1

        ''param_nm = param_array1(i)
        ''param_mo = param_array2(i)

        'If g10.Text("CHK") = "0" Then

        SQL = "INSERT INTO uds_msg (MSG_TYPE, CMID, REQUEST_TIME, DEST_PHONE, SEND_PHONE, MSG_BODY ) VALUES ("
        SQL = SQL & " 0, date_format(now() ,  '%Y%m%d%H%i%s'), now(), '" + g10.Text("mobile") + "', '01029091733', '" + g10.Text("part_nm") + " 을(를) 입고 되었습니다~!');"


        Dim db = New MySqlConnection(MySQL_CS)
        db.Open()
        Dim COMM = New MySqlCommand(SQL, db)
        COMM.ExecuteNonQuery()

        db.Close()
        save1()
        'End If
    End Sub
    Private Sub save1()
        Dim p As New OpenParameters
        p.Add("@po_no", g10.Text("po_no"))
        p.Add("@nm", g10.Text("nm"))
        p.Add("@mobile", g10.Text("mobile"))
        p.Add("@part_cd", g10.Text("part_cd"))
        p.Add("@part_nm", g10.Text("part_nm"))
        p.Add("@cust_nm", g10.Text("cust_nm"))
        p.Add("@po_dt", g10.Text("po_dt"))
        p.Add("@dlv_dt", g10.Text("dlv_dt"))
        p.Add("@po_up", g10.Text("po_up"))
        p.Add("@qty", g10.Text("qty"))

        Me.Open("lec100_sms", p)
    End Sub
    Private Sub po_chk_CheckedChanged(sender As Object, e As System.EventArgs) Handles po_chk.CheckedChanged
        MyBase.Open()
    End Sub

End Class

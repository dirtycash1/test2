Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Public Class FAR310

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim dSet As DataSet = Me.OpenDataSet("far310_mm_yn")
        If Not IsEmpty(dSet) Then
            If DataValue(dSet) = "1" Then
                btn_delete.Enabled = True
                btn_doc.Enabled = True
                btn_open.Enabled = True

                btn_delete1.Enabled = False
                btn_doc1.Enabled = False
                btn_open1.Enabled = False
            Else
                btn_delete.Enabled = False
                btn_doc.Enabled = False
                btn_open.Enabled = False

                btn_delete1.Enabled = True
                btn_doc1.Enabled = True
                btn_open1.Enabled = True

            End If
        End If
        'g10.RowIndex = 0
        'If co_cd.Text = "10" Then
        '    g10.ColumnVisible("sal_famt") = True
        '    g10.ColumnVisible("cury_bc") = True
        'Else
        '    g10.ColumnVisible("sal_famt") = False
        '    g10.ColumnVisible("cury_bc") = False
        'End If

    End Sub
    Private Sub co_cd_TextChanged(sender As Object, e As System.EventArgs) Handles co_cd.TextChanged
        'If co_cd.Text = "10" Then
        '    g10.ColumnVisible("sal_famt") = True
        '    g10.ColumnVisible("cury_bc") = True
        'Else
        '    g10.ColumnVisible("sal_famt") = False
        '    g10.ColumnVisible("cury_bc") = False
        'End If
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Dim I As Double
        Select Case mty
            Case MenuType.Open
                Me.Open()
                For I = 0 To g10.RowCount

                    g10.RowIndex = I
                    g10.Text("chk") = "1"

                Next I

                Dim dSet As DataSet = Me.OpenDataSet("far310_mm_yn")
                If Not IsEmpty(dSet) Then
                    If DataValue(dSet) = "1" Then
                        btn_delete.Enabled = True
                        btn_doc.Enabled = True
                        btn_open.Enabled = True

                        btn_delete1.Enabled = False
                        btn_doc1.Enabled = False
                        btn_open1.Enabled = False
                    Else
                        btn_delete.Enabled = False
                        btn_doc.Enabled = False
                        btn_open.Enabled = False

                        btn_delete1.Enabled = True
                        btn_doc1.Enabled = True
                        btn_open1.Enabled = True

                    End If

                End If

                doc_no.Text = ""

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다
        End Select

    End Sub

#Region "전표 관리"

    '전표보기
    Private Sub btn_open_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open.Click
        If doc_no.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If
        Dim menuName As String
        'menuName = "FAD600"
        menuName = "FAB100"
        '화면을 띄운다
        Dim ctr1 As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr1 IsNot Nothing Then
            ctr1.Open2(doc_no.Text)
        End If

    End Sub

    '전표삭제
    Private Sub btn_delete_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete.Click
        If doc_no.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("far310_delete_doc")
        doc_no.Text = ""

        '작업후 조회한다
        Me.Open()
    End Sub

    '전표생성
    Private Sub btn_doc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc.Click
        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        '전표발행대상 행들을 Table Record에서 구분하기 위해 TimeStamp를 저장한다 Select 문에 mdt 컬럼이 존재해야 한다
        g10.SaveValue("mdt", Format(Now, "yyyy-MM-dd hh:mm:ss.fff"))
        g10.SaveValue("doc_dt", base_dt.Text)



        '먼저 작업내용들을 저장한다 체크('chk') 정보도 저장된다. 저장되는 Table에 'chk' 컬럼이 존재해야 한다 (WorkSet 저장문 참조)
        If Me.Save() Then

            '전표생성 WorkSet을 호출한다 -> 화면에 chk 된 행으로 전표를 생성한다
            Dim dSet As DataSet = Me.OpenDataSet("far310_make_doc")

            '생성한 전표번호를 화면에 나타낸다
            If Not IsEmpty(dSet) Then
                doc_no.Text = DataValue(dSet)
            End If

            '작업후 조회한다
            g10.Open()
        End If
    End Sub
#End Region

    Private Sub g10_Click(sender As Object, e As System.EventArgs) Handles g10.Click
        
        If g10.Text("mm1", g10.RowIndex) = "1" Then
            doc_no.Text = g10.Text("doc_no", g10.RowIndex)
            base_dt.Text = g10.Text("doc_dt", g10.RowIndex)

            btn_delete.Enabled = True
            btn_doc.Enabled = True
            btn_open.Enabled = True

            btn_delete1.Enabled = False
            btn_doc1.Enabled = False
            btn_open1.Enabled = False

        Else
            y_doc_no.Text = g10.Text("doc_no", g10.RowIndex)
            y_base_dt.Text = g10.Text("doc_dt", g10.RowIndex)

            btn_delete.Enabled = False
            btn_doc.Enabled = False
            btn_open.Enabled = False

            btn_delete1.Enabled = True
            btn_doc1.Enabled = True
            btn_open1.Enabled = True

        End If

        Me.Open("far310_g20")
        Me.Open("far310_g30")
        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g20.Text("doc_no", 0))
        p.Add("@doc_sq", g30.Text("doc_sq", 0))
        p.Add("@acc_cd", g30.Text("acc_cd", 0))


        Me.Open("far310_g40", p)
    End Sub
    Private Sub g20_Click(sender As Object, e As System.EventArgs) Handles g20.Click
        doc_no.Text = g20.Text("doc_no", g20.RowIndex)
        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g20.Text("doc_no", g20.RowIndex))
        p.Add("@doc_sq", g30.Text("doc_sq", 0))
        p.Add("@acc_cd", g30.Text("acc_cd", 0))

        Me.Open("far310_g40", p)
    End Sub
    Private Sub g30_Click(sender As Object, e As System.EventArgs) Handles g30.Click
        doc_no.Text = g20.Text("doc_no", g20.RowIndex)
        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g20.Text("doc_no", g20.RowIndex))
        p.Add("@doc_sq", g30.Text("doc_sq", g30.RowIndex))
        p.Add("@acc_cd", g30.Text("acc_cd", g30.RowIndex))

        Me.Open("far310_g40", p)
    End Sub
    Private Sub doc_no_TextChanged(ByVal sender As Object, ByVal oldValue As String)
        Me.Open("far310_g20")
        Me.Open("far310_g30")
        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g20.Text("doc_no", 0))
        p.Add("@doc_sq", g30.Text("doc_sq", 0))
        p.Add("@acc_cd", g30.Text("acc_cd", 0))

        Me.Open("far310_g40", p)
    End Sub
    Private Sub y_doc_no_TextChanged(ByVal sender As Object, ByVal oldValue As String)
        Me.Open("far310_g20")
        Me.Open("far310_g30")
        Dim p As OpenParameters = New OpenParameters
        p.Add("@doc_no", g20.Text("doc_no", 0))
        p.Add("@doc_sq", g30.Text("doc_sq", 0))
        p.Add("@acc_cd", g30.Text("acc_cd", 0))

        Me.Open("far310_g40", p)
    End Sub

    Public Function Nvl(ByVal P_Value, ByVal P_ret) As Decimal
        If TypeOf P_Value Is DBNull OrElse P_Value Is Nothing OrElse P_Value = "" Then
            Nvl = P_ret
        Else
            Nvl = P_Value
        End If

    End Function

    '전표보기
    Private Sub btn_open1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_open1.Click
        If y_doc_no.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If
        Dim menuName As String
        'menuName = "FAD600"
        menuName = "FAB100"
        '화면을 띄운다
        Dim ctr1 As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr1 IsNot Nothing Then
            ctr1.Open2(y_doc_no.Text)
        End If

    End Sub

    '전표삭제
    Private Sub btn_delete1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_delete1.Click
        If y_doc_no.Text = "" Then
            MessageInfo("먼저 전표를 선택하세요.")
            Exit Sub
        End If

        If MessageYesNo("전표를 삭제 하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If

        Me.Open("far310_delete_doc_yy")
        y_doc_no.Text = ""

        '작업후 조회한다
        Me.Open()
    End Sub

    '전표생성
    Private Sub btn_doc1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc1.Click
        If MessageYesNo("전표를 생성하시겠습니까 ?") = MsgBoxResult.No Then
            Exit Sub
        End If
        If g10.CheckedRows("chk") = 0 Then
            MessageInfo("선택된 행이 없습니다.")
            Exit Sub
        End If

        '전표발행대상 행들을 Table Record에서 구분하기 위해 TimeStamp를 저장한다 Select 문에 mdt 컬럼이 존재해야 한다
        'g10.SaveValue("chk", "1")

        g10.SaveValue("mdt", Format(Now, "yyyy-MM-dd hh:mm:ss.fff"))
        g10.SaveValue("doc_dt", y_base_dt.Text)

        '먼저 작업내용들을 저장한다 체크('chk') 정보도 저장된다. 저장되는 Table에 'chk' 컬럼이 존재해야 한다 (WorkSet 저장문 참조)
        If Me.Save() Then

            '전표생성 WorkSet을 호출한다 -> 화면에 chk 된 행으로 전표를 생성한다
            Dim dSet As DataSet = Me.OpenDataSet("far310_make_doc_yy")

            '생성한 전표번호를 화면에 나타낸다
            If Not IsEmpty(dSet) Then
                y_doc_no.Text = DataValue(dSet)
            End If

            '작업후 조회한다
            g10.Open()
        End If
    End Sub

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub
End Class

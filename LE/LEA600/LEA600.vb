Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEA600
    Private Sub LEA600_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

        '세금계산서번호 채번
        doc_no.CodeNo = "FAB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        doc_no.CodeDateField = slip_dt

        Me.New_Form()

    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                New_Form()
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                'MyBase.Open()
                ' End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("lea200_g10").AddNew()  '특정Workset 신규처리
                New_Form()
            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        doc_no.Text = ""
        slip_dt.Text = ""

        Me.Open()
    End Sub



    Private Sub btn_doc_make_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc_make.Click
        Dim Sal_bs As String = "", sumCust As String = "", taxTy As String = ""

        'Dim iCnt As Integer = CheckedGridRow(epfs102f_g1, "chk1")
        Dim itm As String = "", cnt As Decimal = 0, qty As Decimal = 0, up As Decimal = Nothing

        If doc_no.Text <> "" Then
            MessageInfo("이미 매입전표가 발행되었습니다")
            Exit Sub
        End If


        If Not CheckRequired(slip_dt) Then
            Exit Sub
        Else

            Dim p As New OpenParameters

            p = New OpenParameters
            'p.Add("@work_dt", slip_dt.Text)
            'p.Add("@tax_no", slip_dt.Text)
            'p.Add("@work_dt", slip_dt.Text)
            'p.Add("@work_dt", slip_dt.Text)
            'p.Add("@reg_id", slip_dt.Text)

            p.Add("@slip_dt", slip_dt.Text)
            p.Add("@tax_no", g10.Text("tax_no"))
            p.Add("@co_cd", co_cd.Text)
            p.Add("@reg_id", Parameter.Login.RegId)

            Dim Dset As DataSet = OpenDataSet("lea600_doc", p)

            If Not IsEmpty(Dset) Then
                Dset = Nothing
            End If
            Me.New_Form()

            ' If doc_no.Text <> "" Then
            ' Dim menuName As String = "FAB100"
            ' Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            ' ctr.Open2(doc_no.Text)
            ' New_Form()
            'End If


        End If
    End Sub

    Private Sub btn_doc_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_doc_del.Click
        If doc_no.Text <> "" Then
            Dim p As New OpenParameters

            p = New OpenParameters
            p.Add("@doc_no", doc_no.Text)

            Dim Dset As DataSet = OpenDataSet("lea600_doc_del", p)

            If Not IsEmpty(Dset) Then
                Dset = Nothing
            End If
            Me.New_Form()
        Else
            MessageInfo("해당 매입전표번호가 없습니다")
            Exit Sub
        End If
    End Sub
End Class

Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEM100


    Private Sub LEM100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'Me.Open()

        '자재 납품 번호 채번
        ' dlv_no.CodeNo = "MMB200"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        ' dlv_no.CodeDateField = dlv_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                'If MyBase.Save() Then

                ' MyBase.Open()
                'End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

   
    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim Inqty As Integer

        If ColumnName = "chk" Then
            If Value = "1" Then
                Inqty = g10.ToDec("not_inqty")
                If Inqty > 0 Then
                    g10.Text("dlv_in_qty") = Inqty

                Else
                    g10.Text("chk") = "0"
                    g10.Text("dlv_in_qty") = "0"
                End If
            Else
                g10.Text("dlv_in_qty") = "0"
            End If
        End If



    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        Dim iRow As Integer = 0
        Dim menuName As String = "LEM110"

        '2. 데이타 검정
        If Not CheckRequired(out_fac, out_wh, in_fac, in_wh, inout_dt, mov_bc) Then
            Exit Sub
        End If

        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ' If IsNothing(ctr) Then Exit Sub

        For iRow = 0 To g10.RowCount - 1
            If g10.Text("chk", iRow) = "1" Then
                ctr.Open2(g10.Text("itm_id", iRow), g10.Text("itm_cd", iRow), g10.Text("itm_nm", iRow), g10.Text("spec", iRow), g10.Text("out_qty", iRow), g10.Text("um_bc", iRow), _
                          inout_dt.Text, out_fac.Text, out_wh.Text, in_fac.Text, in_wh.Text, mov_bc.Text)
            End If
        Next
    End Sub

End Class

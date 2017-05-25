Imports Frame7
Imports Base7
Imports Base7.Shared




Public Class MMB151


    Private Sub MMB151_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.Open()

        '구매발주번호 자동채번 설정
        po_no.CodeNo = "MMB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        po_no.CodeDateField = po_dt

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save
                If MyBase.Save() Then

                    MyBase.Open()
                End If

            Case MenuType.Delete
                'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

            Case MenuType.New
                ' Me.WorkSets("mmb100_g10").AddNew()  '특정Workset 신규처리

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    

   
    Public Sub Open2(ByVal Repno As String, ByVal ReqSeq As String, ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Poqty As String, _
                     ByVal Umbc As String, ByVal Std_Umbc As String, ByVal Custcd As String, ByVal Custnm As String)

        cust_cd.Text = Custcd
        cust_nm.Text = Custnm
        With g10
            Dim jRow As Integer = 0
            g10.AddNewRow()
            jRow = g10.RowIndex
            g10.Text("req_no", jRow) = Repno
            g10.Text("req_sq", jRow) = ReqSeq
            g10.Text("itm_id", jRow) = Itmid
            g10.Text("itm_cd", jRow) = Itmcd
            g10.Text("itm_nm", jRow) = Itmnm
            g10.Text("spec", jRow) = Spec
            g10.Text("dlv_um", jRow) = Umbc
            g10.Text("um_bc", jRow) = Std_Umbc
            g10.Text("po_qty", jRow) = Poqty
        End With


    End Sub

End Class

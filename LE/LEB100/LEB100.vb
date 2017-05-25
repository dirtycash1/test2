Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEB100


    Private Sub LEB100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '자재 출하 번호 채번
        out_no.CodeNo = "LEB100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        out_no.CodeDateField = out_dt

        Me.New_Form()

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
                Me.New_Form()

            Case MenuType.Print
                ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        out_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal no As String)

        out_no.Text = no
        MyBase.Open()
    End Sub

    'Public Sub Open2(ByVal Sono As String, ByVal SoSq As String, ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Outtot As String, ByVal StdUm As String, ByVal Umbc As String, _
    '                 ByVal CuryBc As String, ByVal Soup As String, ByVal Custcd As String, ByVal CustNm As String, ByVal Outfac As String, ByVal Outwh As String, ByVal Outdt As String)

    '    fac_cd.Text = Outfac
    '    wh_cd.Text = Outwh
    '    out_dt.Text = Outdt
    '    cust_cd.Text = Custcd
    '    cust_nm.Text = CustNm
    '    With g10
    '        Dim jRow As Integer = 0
    '        g10.AddNewRow()
    '        jRow = g10.RowIndex
    '        g10.Text("so_no", jRow) = Sono
    '        g10.Text("so_sq", jRow) = SoSq
    '        g10.Text("itm_id", jRow) = Itmid
    '        g10.Text("itm_cd", jRow) = Itmcd
    '        g10.Text("itm_nm", jRow) = Itmnm
    '        g10.Text("spec", jRow) = Spec
    '        ' g10.Text("dlv_um", jRow) = Umbc
    '        g10.Text("std_um", jRow) = StdUm
    '        g10.Text("um_bc", jRow) = Umbc
    '        g10.Text("cury_bc", jRow) = CuryBc
    '        g10.Text("out_qty", jRow) = Outtot
    '        g10.Text("out_up", jRow) = Soup
    '        g10.Text("out_amt", jRow) = Outtot * Soup
    '    End With
    'End Sub

End Class

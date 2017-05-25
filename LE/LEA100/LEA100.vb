Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEA100


    Private Sub LEA100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        '자재 입고 번호 채번
        in_no.CodeNo = "LEA100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        in_no.CodeDateField = in_dt

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

    Public Sub New_Form()
        in_no.Text = ""
        MyBase.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal inNo As String)
        in_no.Text = inNo
        MyBase.Open()
    End Sub

    'Public Sub Open2(ByVal Pono As String, ByVal PoSeq As String, ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Poqty As String, _
    '                 ByVal Infac As String, ByVal Inwh As String, ByVal Indt As String)
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
    '        g10.Text("um_qty", jRow) = Poqty

    '    End With
    'End Sub

End Class

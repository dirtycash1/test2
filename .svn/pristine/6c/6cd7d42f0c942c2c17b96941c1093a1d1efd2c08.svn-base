Imports Frame7
Imports Base7
Imports Base7.Shared
Public Class LEM170


    Private Sub LEM110_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '품목이동 번호 채번
        mov_no.CodeNo = "LEM100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mov_no.CodeDateField = out_dt

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
        mov_no.Text = ""
        Me.Open()

        g10.AddNewRow()
    End Sub

    Public Sub Open2(ByVal movNo As String)
        mov_no.Text = movNo
        Me.Open()
    End Sub

    'Public Sub Open3(ByVal Itmid As String, ByVal Itmcd As String, ByVal Itmnm As String, ByVal Spec As String, ByVal Poqty As String, ByVal Umbc As String, _
    '                     ByVal InoutDt As String, ByVal Outfac As String, ByVal OutWh As String, ByVal infac As String, ByVal inWh As String, ByVal MovBc As String)

    '    out_dt.Text = InoutDt

    '    out_fac.Text = Outfac
    '    out_wh.Text = OutWh
    '    in_fac.Text = infac
    '    in_wh.Text = inWh
    '    mov_bc.Text = MovBc

    '    With g10
    '        Dim jRow As Integer = 0
    '        g10.AddNewRow()
    '        jRow = g10.RowIndex
    '        g10.Text("itm_id", jRow) = Itmid
    '        g10.Text("itm_cd", jRow) = Itmcd
    '        g10.Text("itm_nm", jRow) = Itmnm
    '        g10.Text("spec", jRow) = Spec
    '        g10.Text("um_bc", jRow) = Umbc
    '        g10.Text("mov_qty", jRow) = Poqty
    '    End With

    'End Sub


End Class

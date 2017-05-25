Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class LEM111


    Private Sub LEM111_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        '품목이동 번호 채번
        mov_no.CodeNo = "LEM100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        mov_no.CodeDateField = out_dt

        Me.New_Form()

        in_fac.Text = "02"
        in_wh.Text = "390"

        If in_fac.Text = "02" Then   ' 20150915 smk 반납유형
            If in_wh.Text = "390" Then   '첫화면에서 자재불량창고이면, 반납유형: 자재불량반납
                ban_type.Text = "LEM1102"
            ElseIf in_wh.Text = "300" Then   '첫화면에서 자재불량창고이면, 반납유형: 자재불량반납
                ban_type.Text = "LEM1101"
            ElseIf in_wh.Text = "395" Then   '첫화면에서 자재불량창고이면, 반납유형: 자재불량반납
                ban_type.Text = "LEM1103"
            Else
                ban_type.Text = ""
            End If
        End If

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

                'Case MenuType.Print
                '    Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub New_Form()
        mov_no.Text = ""
        Me.Open()
        g10.AddNewRow()

        '    If Not CheckRequired(out_fac, out_wh) Then
        '        Exit Sub
        '    End If

    End Sub

    Public Sub Open2(ByVal movNo As String)
        mov_no.Text = movNo
        Me.Open()
    End Sub

    Private Sub ban_type_TextChanged(sender As System.Object, e As System.EventArgs) Handles ban_type.TextChanged   '20150915 smk

        If ban_type.Text = "LEM1101" Then '반납유형: 생산완료반납
            in_fac.Text = "02"
            in_wh.Text = "300"
        ElseIf ban_type.Text = "LEM1102" Then '반납유형 : 자재불량 반납
            in_fac.Text = "02"
            in_wh.Text = "390"
        ElseIf ban_type.Text = "LEM1103" Then '반납유형 : 원.불량반납
            in_fac.Text = "02"
            in_wh.Text = "395"
        End If

    End Sub

    Private Sub in_wh_TextChanged(sender As System.Object, e As System.EventArgs) Handles in_wh.TextChanged

        If in_fac.Text = "02" Then

            If in_wh.Text = "390" Then
                ban_type.Text = "LEM1102"
            ElseIf in_wh.Text = "300" Then
                ban_type.Text = "LEM1101"
            ElseIf in_wh.Text = "395" Then
                ban_type.Text = "LEM1103"
            Else
                ban_type.Text = ""
            End If

        End If
    End Sub


    'Public Sub Open5(ByVal faccd As String, ByVal outwh As String, ByVal inwh As String)

    '    Me.Open()

    '    Dim dset As DataSet = Me.OpenDataSet("lem110_open5")

    '    For Each dRow In dset.Tables(0).Rows

    '        g10.AddNewRow()

    '        g10.Text("itm_cd", g10.RowIndex) = dRow(0)
    '        g10.Text("mov_qty", g10.RowIndex) = dRow(1)

    '    Next

    '    Me.Open("lem110_open5_del")

    '    out_fac.Text = faccd
    '    in_fac.Text = faccd
    '    out_wh.Text = outwh
    '    in_wh.Text = inwh
    'End Sub



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

    '#Region " Print "
    '    Private Sub Print()
    '        Dim p As OpenParameters = New OpenParameters
    '        p.Add("@mov_no", g10.Text("mov_no"))

    '        System7.ReportView.LoadView("LEM111", "", "LEM111_Print", p)
    '    End Sub
    '#End Region



 
End Class

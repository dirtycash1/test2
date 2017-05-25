Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class WI_SA1120

    Private Sub WI_SA1120_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'SC1.Panel1Collapsed = Not chk_show.Checked

        EPanel1.SetSplitter(SC1, SC1.Panel2)

        '수주 번호 채번
        od_no.CodeNo = "WI_SA1120"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        od_no.CodeDateField = od_dt

        Me.NewForm()
        Me.WorkSets("wi_sa1120_head").AddNew()  '특정Workset 신규처리
        Me.WorkSets("wi_sa1120_body").AddNew()  '특정Workset 신규처리



    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                Me.Open_Form()


            Case MenuType.Save
                If Not Check_Save() Then
                    Exit Sub
                End If
                If MyBase.Save() Then
                    MyBase.OpenTrigger("wi_sa1120_list")
                End If

                If MyBase.Save() Then
                    Me.Open_Form()
                End If

            Case MenuType.Delete

            Case MenuType.New
                'New_Form()
                'Me.WorkSets("wi_sa1120_head").AddNew()  '특정Workset 신규처리
                Me.WorkSets("wi_sa1120_body").AddNew()  '특정Workset 신규처리

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Public Sub Open_Form()
        'union_yn.Text = "0"
        Me.Open()
        g_body.AddNewRow()

    End Sub

    Public Sub New_Form()
        od_no.Text = ""

        Me.Open_Form()

    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open

    '            Me.Open_Form()

    '        Case MenuType.Save

    '            Me.SumAmt()

    '            If MyBase.Save() Then
    '                Me.Open_Form()
    '            End If

    '        Case MenuType.Delete
    '            'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

    '        Case MenuType.New
    '            Me.New_Form()
    '            'Me.WorkSets("sdb100_g10").AddNew()  '특정Workset 신규처리

    '        Case MenuType.Print
    '            ' Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    'Public Sub Open_Form()
    '    union_yn.Text = "0"
    '    Me.Open()

    '    g10.AddNewRow()
    'End Sub

    'Public Sub New_Form()
    '    so_no.Text = ""

    '    Me.Open_Form()
    'End Sub


    'Public Sub Open2(ByVal OdNo As String)

    '    od_no.Text = OdNo

    '    Me.Open_Form()

    'End Sub

    Private Function Check_Save() As Boolean
        '거래처 체크
        If Not Me.Check_CsCd() Then
            Return False
        End If

        Return True
    End Function
    Private Function Check_CsCd() As Boolean
        Try

            '납품처코드 체크
            If nacs_cd.Text = "" Then
                nacs_cd.Focus()
                MessageInfo("납품처코드를 입력하세요")
                Return True
            End If
            '거래처코드 체크
            If cs_cd.Text = "" Then
                cs_cd.Focus()
                MessageInfo("거래처코드를 입력하세요")
                Return True
            End If
            '납품처명 체크
            If nacs_nm.Text = "" Then
                nacs_nm.Focus()
                MessageInfo("납품처명를 입력하세요")
                Return True
            End If
            '거래처명 체크
            If cs_nm.Text = "" Then
                cs_nm.Focus()
                MessageInfo("거래처명를 입력하세요")
                Return True
            End If



            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function
    Private Sub btn_find_Click(sender As System.Object, e As System.EventArgs) Handles btn_find.Click
        ' 찾기 리스트 조회
        g_list.Open()
    End Sub

    Private Sub chk_show_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chk_show.CheckedChanged
        SC1.Panel1Collapsed = Not chk_show.Checked
    End Sub

End Class

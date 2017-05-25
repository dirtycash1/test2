Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEM112


    Private Sub LEM112_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
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
                Me.Print()

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

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True


        If ColumnName = "chk" Then


            If Value = "1" Then
                g10.Text("mov_qty") = g10.Text("mov_reqty")

            Else
                g10.Text("mov_qty") = ""
            End If

        End If

        If ColumnName = "mov_qty" Then

            g10.Text("chk") = IIf(Value = "", "0", "1")

        End If


        m_StopEvent = False

    End Sub

    Private Sub btn_srh_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_srh.Click
        Me.Open(g20.WorkSet)
    End Sub


    Private Sub opt_show_TextChanged(ByVal sender As Object, ByVal oldValue As String) Handles opt_show.TextChanged
        Me.Open()
    End Sub

    Private Sub show_btn_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles show_btn.CheckedChanged
        If show_btn.Text = "1" Then
            SplitContainer2.Panel1Collapsed = True

        Else
            SplitContainer2.Panel1Collapsed = False

        End If
    End Sub


#Region " Print "
    Private Sub Print()
        Dim p As OpenParameters = New OpenParameters
        p.Add("@mov_no", g10.Text("mov_no"))

        System7.ReportView.LoadView("LEM101", "", "LEM101_Print", p)
    End Sub
#End Region



    Private Sub g20_DoubleClick(sender As Object, e As System.EventArgs) Handles g20.DoubleClick
        mov_no.Text = g20.Text("mov_no")
        Me.Open()
        'MyBase.Open("lem112_g10")
    End Sub
End Class

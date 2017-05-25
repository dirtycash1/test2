Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Math

Public Class QOA200

    Private Sub QOA200_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.
        r_re_chk2.Checked = True

        'REACH  번호 채번
        re_no.CodeNo = "QOA200"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        re_no.CodeDateField = re_dt
        MyBase.Open("qoa200_f10")
        MyBase.Open("qoa200_g20")

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
                g20.AddNewRow()

            Case MenuType.Print


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick


        g20.AddNewRow()

        ' g20.Text("seq_no") = g20.GetNextNumber("seq_no").ToString


        g20.Text("itm_id") = g10.Text("itm_id", g10.RowIndex)
        g20.Text("itm_cd") = g10.Text("itm_cd", g10.RowIndex)

        g20.Text("itm_qty") = "1"
        g20.Text("itm_wgt") = g10.Text("sub_wgt", g10.RowIndex)
        g20.Text("sub_wgt") = g10.Text("svhc_wgt", g10.RowIndex)
        


    End Sub

    Private Sub g10_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles g10.Load

    End Sub

    Public Sub Open2(ByVal RENo As String)


        re_no.Text = RENo
        MyBase.Open()


    End Sub

End Class

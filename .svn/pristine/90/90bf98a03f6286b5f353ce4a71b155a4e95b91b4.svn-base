Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEA101

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        'RadioButton5.Checked = True

        'Dim date1 As String
        'Dim date2 As String
        'Dim yy As String
        'Dim mm As String
        'Dim dd As String
        'Dim ddd As String

        'yy = Now.Year
        'mm = Now.Month
        'dd = Now.Day
        'If mm = "01" Then


        'End If
        'ddd = dd - 6
        'date1 = yy + "-" + mm + "-" + dd
        'date2 = yy + "-" + mm + "-" + ddd

        'in_dtf.Text = date2
        'in_dtt.Text = date1

    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.Save

            Case MenuType.New

                Me.New_Form()

            Case Else

                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub RadioButton1_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles RadioButton1.MouseClick

        Dim date1 As String
        Dim date2 As String
        Dim yy As String
        Dim mm As String
        Dim dd As String

        yy = Now.Year
        mm = Now.Month
        dd = "01"
        mm = mm - 1
        date1 = yy + "-" + mm + "-" + dd
        date2 = ToLastDate(date1)
        in_dtf.Text = date1
        in_dtf.ReadOnly = True
        in_dtt.Text = date2
        in_dtt.ReadOnly = True

    End Sub


    Private Sub RadioButton5_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton5.Click

        Dim date1 As String
        Dim date2 As String
        Dim yy As String
        Dim mm As String
        Dim dd As String
        Dim ddd As String

        yy = Now.Year
        mm = Now.Month
        dd = Now.Day
        ddd = dd - 6
        date1 = yy + "-" + mm + "-" + dd
        date2 = yy + "-" + mm + "-" + ddd

        in_dtf.Text = date2
        in_dtt.Text = date1

        in_dtf.ReadOnly = False
        in_dtt.ReadOnly = False

    End Sub

    Private Sub RadioButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton2.Click

        Dim date1 As String
        Dim date2 As String
        Dim yy As String
        Dim mm As String
        Dim dd As String

        yy = Now.Year
        mm = Now.Month
        dd = "01"
        date1 = yy + "-" + mm + "-" + dd
        date2 = ToLastDate(date1)
        in_dtf.Text = date1
        in_dtf.ReadOnly = True
        in_dtt.Text = date2
        in_dtt.ReadOnly = True

    End Sub

    Private Sub RadioButton3_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton3.Click

        Dim date1 As String
        Dim yy As String
        Dim mm As String
        Dim dd As String

        yy = Now.Year
        mm = Now.Month
        dd = Now.Day
        dd = dd - 1
        date1 = yy + "-" + mm + "-" + dd

        in_dtf.Text = date1
        in_dtf.ReadOnly = True
        in_dtt.Text = date1
        in_dtt.ReadOnly = True

    End Sub

    Private Sub RadioButton4_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles RadioButton4.Click

        Dim date1 As String
        Dim yy As String
        Dim mm As String
        Dim dd As String

        yy = Now.Year
        mm = Now.Month
        dd = Now.Day
        date1 = yy + "-" + mm + "-" + dd

        in_dtf.Text = date1
        in_dtf.ReadOnly = True
        in_dtt.Text = date1
        in_dtt.ReadOnly = True

    End Sub

    Public Sub New_Form()

        bs_cd.Text = ""
        fac_cd.Text = ""
        wh_cd.Text = ""
        in_no.Text = ""
        cust_cd.Text = ""
        cust_nm.Text = ""
        itm_cd.Text = ""
        itm_nm.Text = ""
        in_dtf.Text = ""
        in_dtt.Text = ""
        itm_bc.Text = ""
        in_bc.Text = ""
        ent_bc.Text = ""

        Me.Open()

        RadioButton5.Checked = True

        Dim date1 As String
        Dim date2 As String
        Dim yy As String
        Dim mm As String
        Dim dd As String
        Dim ddd As String

        yy = Now.Year
        mm = Now.Month
        dd = Now.Day
        If mm = "01" Then


        End If
        ddd = dd - 6
        date1 = yy + "-" + mm + "-" + dd
        date2 = yy + "-" + mm + "-" + ddd

        in_dtf.Text = date2
        in_dtt.Text = date1
        in_dtf.ReadOnly = False
        in_dtt.ReadOnly = False

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = g10.Text("frm_cd"), keyNo As String = ""

        If menuName = "" Then
            Exit Sub
        End If


        If menuName = "LEM130" Then
            '반품이동
            Dim f As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If f IsNot Nothing Then
                f.Open2(g10.Text("in_dt"), g10.Text("cust_cd"), g10.Text("out_fac"), g10.Text("out_wh"))
            End If
            Exit Sub
        ElseIf menuName.StartsWith("LEM") Then
            keyNo = g10.Text("mov_no")
        Else
            keyNo = g10.Text("in_no")
        End If

        'Select Case g10.Text("frm_cd")
        '    Case "LE910100", "LE910500"     '수주출하, 긴급출하
        '        menuName = "LEB160"
        '        keyNo = g10.Text("out_no")
        '    Case "LE910810"                 '이동출하
        '        menuName = "LEM120"
        '        keyNo = g10.Text("mov_no")
        '    Case Else
        '        Exit Select
        'End Select

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(keyNo)
        End If

    End Sub

End Class


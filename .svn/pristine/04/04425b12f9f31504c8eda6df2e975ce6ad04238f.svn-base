Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEB101

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
        fr_dt.Text = date1
        fr_dt.ReadOnly = True
        to_dt.Text = date2
        to_dt.ReadOnly = True

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

        fr_dt.Text = date2
        to_dt.Text = date1

        fr_dt.ReadOnly = False
        to_dt.ReadOnly = False

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
        fr_dt.Text = date1
        fr_dt.ReadOnly = True
        to_dt.Text = date2
        to_dt.ReadOnly = True

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

        fr_dt.Text = date1
        fr_dt.ReadOnly = True
        to_dt.Text = date1
        to_dt.ReadOnly = True

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

        fr_dt.Text = date1
        fr_dt.ReadOnly = True
        to_dt.Text = date1
        to_dt.ReadOnly = True

    End Sub

    Public Sub New_Form()

        bs_cd.Text = ""
        fac_cd.Text = ""
        wh_cd.Text = ""
        out_no.Text = ""
        cust_cd.Text = ""
        cust_nm.Text = ""
        itm_cd.Text = ""
        itm_nm.Text = ""
        fr_dt.Text = ""
        to_dt.Text = ""
        itm_bc.Text = ""
        out_bc.Text = ""
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

        fr_dt.Text = date2
        to_dt.Text = date1
        fr_dt.ReadOnly = False
        to_dt.ReadOnly = False

    End Sub

    Private Sub g10_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String = g10.Text("frm_cd"), keyNo As String = ""

        If menuName = "" Then
            Exit Sub
        End If

        keyNo = g10.Text("sal_no")
        If keyNo = "" Then
            keyNo = g10.Text("mov_no")
        End If
        If keyNo = "" Then
            keyNo = g10.Text("out_no")
        End If

        'If menuName = "LEB100" Then
        '    '반품이동
        '    Dim f As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        '    If f IsNot Nothing Then
        '        keyNo = g10.Text("out_no")
        '    End If
        'End If

        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open2(keyNo)
        End If

    End Sub


End Class


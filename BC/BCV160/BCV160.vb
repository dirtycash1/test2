Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class BCV160

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'Me.Open("bcv100_g10")

        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        Me.New_Form()

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            'Case MenuType.Open
            'Me.Open("bcv100_f1")
            'Me.Open("bcv100_g10")

            Case MenuType.Save
                If Not Check_Save() Then
                    Exit Sub
                End If
                If MyBase.Save() Then
                    MyBase.OpenTrigger("bcv100_g10")
                End If

            Case MenuType.New
                New_Form()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()
        cust_cd.Text = ""
        Open("bcv100_f10")
    End Sub

    Private Sub chk_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles btn_open.Click

        Me.Open()
 
    End Sub

    Private Function Check_Save() As Boolean
        If Not Me.Check_BizNo() Then
            Return False
        End If
        Return True
    End Function


    Private Function Check_BizNo() As Boolean
        Try
            Dim custNm As String, custCd As String
            If biz_no.Text = "" Then
                biz_no.Focus()
                Return True
            End If

            Dim p As OpenParameters = New OpenParameters
            Dim bizNo As String = biz_no.Text.Replace("-", "").Replace(" ", "")
            p.Add("@biz_no", bizNo)
            p.Add("@cust_cd", cust_cd.Text)
            Dim dSet As DataSet = OpenDataSet("bcv100_check_bizno", p)

            If Not IsEmpty(dSet) Then
                custCd = DataValue(dSet, "cust_cd")
                custNm = DataValue(dSet, "cust_nm")
                MessageInfo(" 이미 등록된 사업자번호입니다 [거래처코드 : " + custCd + " : " + custNm + "]")
                Return False
            End If

            Return True

        Catch ex As Exception
            MessageInfo(ex)
        End Try
    End Function


    Private Sub check_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles check.Click
        If biz_no.Text = "" Then
            biz_no.Focus()
            Exit Sub
        End If
        If Me.Check_BizNo() Then
            MessageInfo("OK")
        End If
    End Sub


    Private Sub cust_nm_EditChanged(ByVal sender As Object, ByVal oldValue As String) Handles cust_nm.TextChanged
        If cust_nm.Text <> "" AndAlso prt_nm.Text = "" Then
            prt_nm.Text = cust_nm.Text
        End If
    End Sub

    Private Sub addr1_EditChanged(ByVal sender As Object, ByVal oldValue As String) Handles addr1.TextChanged
        If addr1.Text <> "" AndAlso addr_prt.Text = "" Then
            addr_prt.Text = addr1.Text
        End If
    End Sub

    Private Sub addr_prt_EditChanged(ByVal sender As Object, ByVal oldValue As String) Handles addr_prt.TextChanged
        If addr_prt.Text <> "" AndAlso addr1.Text = "" Then
            addr1.Text = addr_prt.Text
        End If
    End Sub



End Class

Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PAM101

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        g10.RowAutoHeight = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me._Open()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    Private Sub _Open()
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Me.Open()

        Dim dSet As DataSet = Me.OpenDataSet("pam100_items")
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        Parameter.MainFrame.ProgBar.Visible = True
        Parameter.MainFrame.ProgBar.Minimum = 1
        Parameter.MainFrame.ProgBar.Maximum = g10.RowCount
        Parameter.MainFrame.ProgBar.Value = 1
        Parameter.MainFrame.ProgBar.Step = 1

        Dim pCd As String, pNm As String, cCd As String, cNm As String, txt As String, save As String

        For i = 0 To g10.RowCount - 1

            Parameter.MainFrame.ProgBar.Value = i + 1

            txt = g10.Text("comp_text", i)

            If txt <> "" Then
                save = ""
                For Each r As DataRow In dSet.Tables(0).Rows
                    pCd = r.Item("pcd")
                    pNm = r.Item("pnm")

                    cCd = r.Item("cd")
                    cNm = r.Item("nm")

                    If pCd <> save Then
                        txt = txt.Replace("[" + pCd + "]", "[" + pNm + "]")
                    End If
                    txt = txt.Replace("[" + cCd + "]", "[" + cNm + "]")

                    save = pCd
                Next
                g10.Text("comp_text2", i) = txt
            End If

        Next

        Parameter.MainFrame.ProgBar.Visible = False
    End Sub



End Class

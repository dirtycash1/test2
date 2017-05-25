Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class MMB200

    Private Sub Form_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g10.SelectRow = True

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                Me._Open()

            Case MenuType.Save
                If MyBase.Save() Then
                    Me._Open()
                End If

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select
    End Sub

    Private Sub _Open()
        Dim poNo As String = g10.Text("po_no")
        Dim poSq As String = g10.Text("po_sq")

        MyBase.Open()

        Dim find(1) As String
        find(0) = "po_no=" + poNo
        find(1) = "po_sq=" + poSq

        g10.Find(find)
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

        If m_StopEvent Then
            Exit Sub
        End If

        m_StopEvent = True

        If ColumnName = "chk" Then

            If Value = "1" Then
                g10.Text("dlv_qty") = g10.Text("mi_qty")
            Else
                g10.Text("dlv_qty") = ""
            End If

        End If

        If ColumnName = "dlv_qty" Then

            g10.Text("chk") = IIf(Value = "", "0", "1")

        End If

        m_StopEvent = False

    End Sub

    Private Sub btn_save_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save.Click

        If Not CheckRequired(in_fac, in_wh, dlv_dt) Then
            Exit Sub
        End If

        Me.Save(g10.WorkSet)
        Me._Open()

    End Sub

End Class

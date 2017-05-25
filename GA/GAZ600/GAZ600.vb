Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class GAZ600

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        pnlCopy.Visible = False
        bs2_cd.AddItem("%", "All")
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        If m_StopEvent Then Exit Sub
        With g10
            Try
                If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then
                    m_StopEvent = True
                    .Text(ColumnName) = TimeFormat(.Text(ColumnName))
                End If
            Catch ex As Exception
            Finally
                m_StopEvent = False
            End Try
        End With
    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If m_StopEvent Then Exit Sub
        With g20
            Try
                If ColumnName = "fr_tm" Or ColumnName = "to_tm" Then
                    m_StopEvent = True
                    .Text(ColumnName) = TimeFormat(.Text(ColumnName))
                End If
            Catch ex As Exception
            Finally
                m_StopEvent = False
            End Try
        End With
    End Sub

    Private Sub btn_copy_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_copy.Click
        pnlCopy.Visible = Not pnlCopy.Visible
    End Sub

    Private Sub btn_save2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_save2.Click
        If MessageYesNo("To 쪽의 기존 자료는 삭제되고 복사됩니다." + vbLf + vbLf + "복사 하시겠습니까?") = MsgBoxResult.No Then
            Exit Sub
        End If

        If Not CheckRequired(bs_cd, bs2_cd) Then
            Exit Sub
        End If
        Me.Open("gaz600_copy")
    End Sub

End Class

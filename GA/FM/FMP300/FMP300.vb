Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FMP300

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
       
        Me.Open()

        f_fr_dt.ReadOnly = True
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.New
                f_fr_dt.Text = ""
                f_fr_dt.ReadOnly = False

                g20.Open()

            Case MenuType.Save
                If Not CheckRequired(f_fr_dt) Then
                    Exit Sub
                End If
                If Not Me.CheckBeforeSave() Then
                    Exit Sub
                End If

                If Me.Save() Then

                    Dim saveID As String = f_fr_dt.Text 'g10.Text("fr_dt")

                    MyBase.Open()

                    g10.Find("fr_dt=" + saveID)


                End If


            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        f_fr_dt.ReadOnly = True
    End Sub

    'Private Sub g20_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
    '    If ColumnName = "offi_rt" Or ColumnName = "util_rt" Or ColumnName = "fac_rt" Then
    '        If g20.ToDec("offi_rt") <> 0 And g20.ToDec("util_rt") <> 0 And g20.ToDec("fac_rt") <> 0 Then
    '            Dim amt As Double = 0
    '            amt = g20.ToDec("offi_rt") + g20.ToDec("util_rt") + g20.ToDec("fac_rt")
    '            If amt <> 100 Then
    '                MsgBox("산출비율이 100% 되어야 합니다.")
    '                Exit Sub
    '            End If
    '        End If
    '    End If
    'End Sub

    Private Function CheckBeforeSave() As Boolean
        With g20
            .ValidateChildren()
            For i = 0 To .RowCount - 1
                If .ToDec("offi_rt", i) + .ToDec("util_rt", i) + .ToDec("fac_rt", i) <> 100 Then
                    MsgBox("산출비율이 100% 되어야 합니다.")
                    Return False
                End If
            Next
        End With
        Return True
    End Function


End Class

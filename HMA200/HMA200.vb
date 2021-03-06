﻿Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class HMA200

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub


    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                g20.AddNewRow()
            Case MenuType.Save
                If Me.Save() Then
                    Dim param As OpenParameters = New OpenParameters
                    param.Add("@fa_no", g10.Text("fa_no"))
                    Me.Open("hma200_g20", param)
                End If

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g20_CellValueChanged(sender As System.Object, ColumnName As System.String, RowIndex As System.Int32, ByRef Value As System.Object) Handles g20.CellValueChanged
        If ColumnName = "rep_dt" Then
            If g20.RowCount = 0 Then
                Return
            End If
            If g20.Text("rep_dt", RowIndex) <> "" Then
                Dim fr_dt = DateAdd(DateInterval.Month, ToDec(g10.Text("prd")), CType(g20.Text("rep_dt", RowIndex), Date))
                g20.Text("next_dt", RowIndex) = DateAdd(DateInterval.Day, -1, fr_dt)
                g20.Text("to_dt", RowIndex) = DateAdd(DateInterval.Day, -1, fr_dt)
                g20.Text("fr_dt", RowIndex) = g20.Text("rep_dt", RowIndex)
            End If
        End If
    End Sub

    Private Sub g20_ButtonPressed(sender As System.Object, columnName As System.String) Handles g20.ButtonPressed
        Dim obj As Frame7.eGrid = CType(sender, Frame7.eGrid)
        Dim fileName As String
        Dim tempFileName As String

        If columnName = "file_add" Then
            Dim dialog As OpenFileDialog = New OpenFileDialog()
            dialog.Filter = "모든파일(*.*)|*.*"
            dialog.Title = "업로드할 파일을 선택 하세요"
            If dialog.ShowDialog() = DialogResult.OK Then

                fileName = dialog.FileName.Replace(dialog.SafeFileName, g10.Text("fa_no") + "_" + g20.Text("seq_no") + "_" + dialog.SafeFileName)

                System.IO.File.Copy(dialog.FileName, fileName, True)
                tempFileName = [Shared].FileUpload("", fileName, "HMA200")
                System.IO.File.Delete(fileName)
                If tempFileName = String.Empty Then
                    Return
                End If

                g20.Text("file_add") = tempFileName
                g20.Text("file_view") = tempFileName
                g20.Text("file_del") = tempFileName
            End If

        ElseIf columnName = "file_view" Then
            [Shared].FileDownLoad(g20.Text("file_view"), , True)

        ElseIf columnName = "file_del" Then
            If [Shared].FileDelete(g20.Text("file_view"), "HMA200") Then
                g20.Text("file_add") = ""
                g20.Text("file_view") = ""
                g20.Text("file_del") = ""
            End If
        End If
    End Sub

    Private Sub g10_BeforeMoveRow(sender As System.Object, RowIndex As System.Int32, ByRef AllowMove As System.Boolean) Handles g10.BeforeMoveRow

        If g10.DataSet.Tables(0).Rows.Count = 0 Then
            Return
        End If

        If RowIndex < 0 Then
            Return
        End If

        Dim tbl_g20 = g20.DataSet.Tables(0)

        Dim isChanged As Boolean = False
        For i = 0 To tbl_g20.Rows.Count - 1
            If tbl_g20.Rows(i).RowState = Data.DataRowState.Modified Or
            tbl_g20.Rows(i).RowState = Data.DataRowState.Added Or
            tbl_g20.Rows(i).RowState = Data.DataRowState.Deleted Then
                isChanged = True
                Exit For
            End If
        Next

        If isChanged = True Then
            Dim dResult As DialogResult =
                MessageBox.Show("다른 설비 점검내역을 등록 하시려면 현재 입력한 점검 내역을 저장해야 합니다. 지금 저장 하시겠습니까?",
                                "알림", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
            If dResult = DialogResult.Yes Then
                Me.Save()
            Else
            End If
        End If

    End Sub
End Class

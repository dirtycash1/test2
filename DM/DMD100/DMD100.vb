Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Base.ViewInfo
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo

Public Class DMD100

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        EPanel1.SetSplitter(SplitContainer1, SplitContainer1.Panel2)
        EPanel2.SetSplitter(SplitContainer1, SplitContainer1.Panel1)

        New_Form()

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.New
                Me.New_Form()
            Case MenuType.Open
                Me.Open_Form()
            Case MenuType.Save
                Save_Form()
            Case MenuType.Delete
                eco_no.Focus()
                FileDelete()
                MyBase.MenuButton_Click(mty)
                New_Form()

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################


    Private Sub New_Form()
        Try
            eco_no.Text = ""

            Me.OpenTrigger("dmd100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회

            eco_no.Focus()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub


    Private Sub Open_Form()
        Try
            MyBase.Open()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub


    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean
        Try
            ValidateChildren()

            If MyBase.Save() Then
                Me.OpenTrigger("dmd100_g10")
            End If
        Catch ex As Exception
            MessageError(ex)
            Return False
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g20_ButtonPressed(ByVal sender As System.Object, ByVal columnName As System.String) Handles g20.ButtonPressed
        Select Case columnName
            Case "fileInclude"
                FileInclude()
            Case "fileView"
                FIleView()
            Case "fileDelete"
                FileDelete()
        End Select
    End Sub

    Private Sub FileInclude()
        Dim dialog As OpenFileDialog = New OpenFileDialog()
        dialog.Filter = "모든파일(*.*)|*.*"
        dialog.Title = "업로드할 파일을 선택 하세요"
        Dim fileName As String
        Dim tempFileName As String

        If dialog.ShowDialog() = DialogResult.OK Then
            'fileName = eco_no.Text + "_" + g20.Text("seq") + "_" + dialog.SafeFileName
            fileName = dialog.FileName.Replace(dialog.SafeFileName, eco_no.Text + "_" + g20.Text("seq") + "_" + dialog.SafeFileName)
            System.IO.File.Copy(dialog.FileName, fileName, True)
            tempFileName = [Shared].FileUpload("", fileName)
            System.IO.File.Delete(fileName)
            If tempFileName = String.Empty Then
                Return
            End If

            g20.Text("file_nm") = tempFileName
            Save_Form()
        End If

    End Sub

    Private Sub FIleView()
        [Shared].FileDownLoad(g20.Text("file_nm"), , True)
    End Sub

    Private Sub FileDelete()
        If [Shared].FileDelete(g20.Text("file_nm")) Then
            g20.Text("file_nm") = ""
            Save_Form()
        End If
    End Sub

    Private Sub FileSave()
        [Shared].FileDownLoad(g20.Text("file_nm"))
    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As System.Object, ByVal ColumnName As System.String, ByVal RowIndex As System.Int32, ByRef Value As System.Object) Handles g20.CellValueChanged
        If ColumnName <> "end_dt" Then
            Return
        End If

        g20.Text("start_dt") = DateAdd(DateInterval.Day, 1, Convert.ToDateTime(g20.Text("end_dt")))
    End Sub

    Private Sub btn_applyECO_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_applyECO.Click

        If Not g20.CheckRequired Then
            Return
        End If

        If MessageBox.Show("ECO 반영하시겠습니까?", "확인", MessageBoxButtons.YesNo) = DialogResult.No Then
            Return
        End If

        If SetForcedDirtyForSave() = False Then
            Return
        End If

        isClickAppliedECO.Text = 1
        isClickAppliedECO.ValidateChildren()

        Save_Form()

        isClickAppliedECO.Text = 0

    End Sub

    Private Function SetForcedDirtyForSave() As Boolean

        For i = 0 To g20.RowCount - 1
            If g20.Text("bef_citm_id", i) = g20.Text("aft_citm_id", i) AndAlso g20.Text("applied_BOM", i) = 0 Then
                g20.Text("temp_applied_BOM", i) = "1"
            End If
        Next

        Return True

    End Function

    Private Sub g20_AfterMoveRow(ByVal sender As System.Object, ByVal PrevRowIndex As System.Int32, ByVal RowIndex As System.Int32) Handles g20.AfterMoveRow

        If g20.Text("applied_BOM") = "1" AndAlso g20.Text("bef_citm_id") <> g20.Text("aft_citm_id") Then
            SetClounReadOnlyG20(True)
            g20.ColumnReadOnly("temp_applied_BOM") = False
        ElseIf g20.Text("applied_BOM") = "0" AndAlso g20.Text("bef_citm_id") <> g20.Text("aft_citm_id") Then
            SetClounReadOnlyG20(False)
            g20.ColumnReadOnly("temp_applied_BOM") = False
        ElseIf g20.Text("applied_BOM") = "1" AndAlso g20.Text("bef_citm_id") = g20.Text("aft_citm_id") Then
            SetClounReadOnlyG20(True)
            g20.ColumnReadOnly("temp_applied_BOM") = True
        ElseIf g20.Text("applied_BOM") = "0" AndAlso g20.Text("bef_citm_id") = g20.Text("aft_citm_id") Then
            SetClounReadOnlyG20(False)
            g20.ColumnReadOnly("temp_applied_BOM") = True
        Else
            SetClounReadOnlyG20(False)
            g20.ColumnReadOnly("temp_applied_BOM") = True
        End If

    End Sub

    Private Sub SetClounReadOnlyG20(ByVal isReadOnly As Boolean)

        If g20.DataSource Is Nothing Then
            Return
        End If

        g20.ColumnReadOnly("pitm_cd") = isReadOnly
        g20.ColumnReadOnly("pitm_rev") = isReadOnly
        g20.ColumnReadOnly("bef_citm_cd") = isReadOnly
        g20.ColumnReadOnly("aft_citm_cd") = isReadOnly
        g20.ColumnReadOnly("aft_citm_rev") = isReadOnly
        g20.ColumnReadOnly("inv_ty") = isReadOnly
        g20.ColumnReadOnly("mold_ty") = isReadOnly
        g20.ColumnReadOnly("req_dt") = isReadOnly
        g20.ColumnReadOnly("end_dt") = isReadOnly
        g20.ColumnReadOnly("src_bc") = isReadOnly
        g20.ColumnReadOnly("use_bc") = isReadOnly
        g20.ColumnReadOnly("usg_qty") = isReadOnly
        g20.ColumnReadOnly("un_bc") = isReadOnly
        g20.ColumnReadOnly("prc_cd") = isReadOnly
        g20.ColumnReadOnly("fileInclude") = isReadOnly
        g20.ColumnReadOnly("fileDelete") = isReadOnly
    End Sub

End Class

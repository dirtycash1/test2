Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAA250
    Private EndCol As Integer

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        g10.SelectRow = True
        EndCol = g20.FieldName(g20.ColumnCount - 1).Replace("chk", "").Replace("cbo", "").Replace("m", "")
        Me.Open("faa250_g10")

    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    '    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '        Select Case mty

    '            Case MenuType.New

    '            Case MenuType.Save

    '            Case MenuType.Delete

    '            Case Else

    '                MyBase.MenuButton_Click(mty)

    '        End Select

    '    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean

        '        Dim ID As String = asset_id.Text
        Try

            '            If MyBase.Save() Then
            '                If ID = "" Then
            '                    f_asset_id.Text = asset_id.Text
            '                    Me.Open()
            '                Else
            '                    Form_Open()
            '                End If
            '            Else
            '                If ID = "" Then asset_id.Text = ""
            '            End If

        Catch ex As Exception
            '            If ID = "" Then asset_id.Text = ""
            '저장에 실패했으면 코드 채번을 반드시 취소한다
            MessageError(ex)
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################
    Private Sub g10_AfterMoveRow(ByVal sender As Object, ByVal PrevRowIndex As Integer, ByVal RowIndex As Integer) Handles g10.AfterMoveRow

        If g10.Text("user_yn") <> "1" Or g10.Text("user_yn") <> "1" Then
            'g20.ReadOnly = True
            g20.Editable = False
            'g20.AllowInsertRows = False
            'g20.AllowDeleteRows = False
            'g20.AllowAddRows = False
            'g20.AllowAddRows = False
            'g20.all()
        Else
            g20.Editable = True
            'g20.ReadOnly = False
            'g20.AllowInsertRows = True
            'g20.AllowDeleteRows = True
            'g20.AllowAddRows = True
        End If

        Me._SetColumn()

    End Sub

    Private Sub _SetColumn()
        Try
            Dim colNm As String, colNm2 As String, colNm3 As String, Cap As String = "", CodeLst As String = ""
            With g20

                For i As Integer = 1 To EndCol
                    colNm = "m" & i

                    colNm = "m" & i
                    colNm2 = "cbo" & i
                    colNm3 = "chk" & i

                    'If g1.Text(colNm) = "" Then
                    '    g2.ColumnVisible(colNm) = True
                    'Else

                    'End If

                    Cap = ""
                    Cap = g10.Text(colNm)

                    If Cap <> "" Then
                        If Cap.IndexOf("[") > 0 Then
                            Dim Len As Integer = Cap.Length - Cap.IndexOf("[") - 2
                            CodeLst = Cap.Substring(Cap.IndexOf("[") + 1, Len)
                            Cap = Cap.Replace("[" & CodeLst & "]", "")

                            If .ColumnVisible(colNm) Then .ColumnVisible(colNm) = False
                            If CodeLst <> "chk" Then
                                SetCombo(colNm2, CodeLst)
                                'Dim P As New OpenParameters
                                'P.Add("@main_cd", CodeNo)
                                '.SetCombo(colNm2, OpenDataSet("system_codes", P))
                                .ColumnTitle(colNm2) = Cap
                                .ColumnVisible(colNm2) = True
                                .ColumnVisible(colNm3) = False
                            Else
                                .ColumnTitle(colNm3) = Cap
                                .ColumnVisible(colNm3) = True
                                .ColumnVisible(colNm2) = False
                            End If
                        Else
                            'If .ColumnVisible(colNm2) Then .ColumnVisible(colNm2) = False
                            'If .ColumnVisible(colNm3) Then .ColumnVisible(colNm3) = False
                            .ColumnTitle(colNm) = Cap
                            .ColumnVisible(colNm) = True
                            .ColumnVisible(colNm2) = False
                            .ColumnVisible(colNm3) = False
                        End If
                    Else
                        .ColumnVisible(colNm) = False
                        .ColumnVisible(colNm2) = False
                        .ColumnVisible(colNm3) = False
                    End If
                Next

                .BestFitColumns()
            End With

        Catch ex As Exception

        End Try

    End Sub

    'Combo설정
    Private Sub SetCombo(ByVal ColNm As String, ByVal GetCode As String)
        Try
            '콤마로 구분하면 여러개의 콤보를 설정할 수 있다.
            Dim Array() As String = GetCode.Split(",")
            With g20
                .ClearCombo(ColNm)
                For Each Code As String In Array
                    If (Code.IndexOf("-") >= 0 Or Code.IndexOf("~") >= 0) AndAlso Code.Length > 1 Then '임의 설정한 콤보
                        For Each Cd In GetArray(Code)
                            .AddCombo(ColNm, Cd, Cd)
                        Next
                    Else
                        Dim dSet As DataSet = GetDset(Code)
                        If Not IsEmpty(dSet) Then
                            Dim dRows As DataRowCollection = DataSetRows(dSet), dRow As DataRow
                            For Each dRow In dRows
                                If dRow(0) <> "" Then
                                    .AddCombo(ColNm, dRow(0), dRow(1))
                                Else
                                    .AddCombo(ColNm, Code, Code)
                                End If
                            Next
                        End If
                    End If
                Next
            End With
        Catch ex As Exception

        End Try
    End Sub

    Private Function GetArray(ByVal GetCode As String) As String()
        GetArray = Nothing
        Dim FrAscNo As Integer = 0, ToAscNo As Integer = 0
        Dim MidPos As Integer = GetCode.IndexOf("~")
        If MidPos = -1 Then MidPos = GetCode.IndexOf("-")
        If MidPos > 1 Or GetCode.Length <> 3 Then
            Return GetCode.Replace("~", vbTab).Replace("-", vbTab).Split(vbTab)
        Else
            FrAscNo = AscW(GetCode.Substring(0, 1))
            ToAscNo = AscW(GetCode.Substring(2, 1))
            Dim Cd As String = ""
            If FrAscNo > ToAscNo Then
                For AscNo As Integer = ToAscNo To FrAscNo Step -1
                    If Cd <> "" Then Cd &= vbTab
                    Cd &= ChrW(AscNo)
                Next
            Else
                For AscNo As Integer = FrAscNo To ToAscNo
                    If Cd <> "" Then Cd &= vbTab
                    Cd &= ChrW(AscNo)
                Next
            End If
            Return Cd.Split(vbTab)
        End If

    End Function

    'Combo설정을 위한 DataSet가져오기
    Private Function GetDset(ByVal GetCode As String) As DataSet

        GetDset = Nothing
        Try
            Dim P As New OpenParameters
            P.Add("@main_cd", GetCode)
            Return OpenDataSet("system_codes", P)

        Catch ex As Exception

        End Try
    End Function

    'Private Sub g20_AddedRow(sender As Object, RowIndex As Integer) Handles g20.AddedRow
    '    With g20
    '        If .Text("useyn") <> "1" Or .Text("useryn") <> "1" Then .CancelRowChanges()
    '    End With
    'End Sub

    'Private Sub g20_CellValueChanged(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
    '    With g20
    '        If .Text("useyn") <> "1" Or .Text("useryn") <> "1" Then .CancelRowChanges()
    '    End With
    'End Sub
End Class

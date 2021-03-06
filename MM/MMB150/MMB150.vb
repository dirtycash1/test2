﻿Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class MMB150
    Private m_DSet As DataSet

    Private Sub MMB150_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open
                MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다
            Case MenuType.Save

                If MyBase.Save() Then

                    MyBase.Open()
                End If

                'Case MenuType.Delete
                '    'Me.WorkSets("sca100_f10").DeleteRow()   '특정Workset을 삭제

                'Case MenuType.New
                '    ' Me.WorkSets("mma100_g10").AddNew()  '특정Workset 신규처리

                'Case MenuType.Print
                '    ' Me.Print()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub


    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

            
        If ColumnName = "qty" Or ColumnName = "cust_cd" Then

            Dim r As DataSet = Me.OpenDataSet("mmb150_up")
            Dim up As String = DataValue(r)

            g10.Text("up") = up

        End If


 
    End Sub

    Private m_StopEvent As Boolean

   

    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim Poqty As Integer
        Dim iRow, Cust_cnt As Integer, CustCd As String

        If m_StopEvent Then
            Return
        End If

        m_StopEvent = True

        Try
            If ColumnName = "chk" Then
                If Value = "1" Then
                    CustCd = g10.Text("cust_cd")
                    'Poqty = g10.ToDec("req_qty") - g10.ToDec("po_tot")
                    Poqty = g10.ToDec("not_inqty")
                    ' 동일 거래처  체크
                    For iRow = 0 To g10.RowCount - 1
                        If CustCd <> g10.Text("cust_cd", iRow) And g10.Text("chk", iRow) Then
                            Cust_cnt = ToDec(Cust_cnt) + 1
                        End If
                    Next

                    If Cust_cnt > 0 Then
                        MsgBox("동일한 거래처만 발주처리 가능 합니다")
                        g10.UpdateRow()
                        g10.Text("qty") = "0"
                        g10.Text("chk", RowIndex) = "0"
                        Exit Sub
                    End If


                    If Poqty > 0 Then
                        g10.Text("qty") = Poqty

                    Else
                        g10.Text("chk") = "0"
                        g10.Text("qty") = "0"
                    End If
                Else
                    g10.Text("qty") = "0"
                    g10.Text("chk") = "0"
                End If
            End If

            If ColumnName = "qty" Then
                'Poqty = g10.ToDec("req_qty") - g10.ToDec("po_tot")
                Poqty = g10.ToDec("not_inqty")

                ''미발주수량만큼 발주하도록 제한 할 경우
                'If ToDec(Value) > Poqty Then
                '    g10.Text("qty") = Poqty
                '    ' g10.Text("chk") = "0"
                '    MsgBox("미발주 수량만큼 발주처리 가능 합니다")
                '    Exit Sub
                'End If
                If ToDec(Value) <= 0 Then
                    g10.Text("chk") = "0"
                End If


            End If



        Catch ex As Exception
        Finally
            m_StopEvent = False
        End Try
    End Sub


    Private Sub btn_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_do.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        'Jump 설정을 이용한 방법
        'Me.Jump("18")

        '옛날 방법
        Dim menuName As String = "MMB100"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        ctr.Open3(g10.DataSet)

    End Sub

    Private Sub btn_updo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_updo.Click

        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then
                If g10.Text("stat_bc", i) = "MM040100" Or g10.Text("stat_bc", i) = "MM040300" Then
                    g10.Text("stat", i) = "7"

                Else
                    MsgBox("상태구분이 완료인 경우에는 강제완결 처리가 불가 합니다")
                    Exit Sub

                End If

            End If

        Next

        If Me.Save("mmb150_g10") Then
            Me.Open()
        End If


    End Sub

    Private Sub btn_undo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_undo.Click

        For i = 0 To g10.RowCount - 1
            If g10.Text("chk", i) = "1" Then

                If g10.Text("stat_bc", i) = "MM040700" Then
                    g10.Text("stat", i) = "3"
                Else
                    MsgBox("상태구분이 강제완결인 경우에만 취소 가능 합니다")
                    Exit Sub
                End If

            End If
        Next

        If Me.Save("mmb150_g10") Then
            Me.Open()
        End If
    End Sub


End Class

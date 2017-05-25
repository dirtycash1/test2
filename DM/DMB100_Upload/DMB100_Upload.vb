Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports DevExpress.XtraGrid

Public Class DMB100_Upload

    'Private gridBand1 As DevExpress.XtraGrid.Views.BandedGrid.GridBand

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'g10.MainView = g10.CardView
        'Dim C As DevExpress.XtraGrid.Views.Card.CardView = g10.CardView
        'C.CardWidth = 325
        'C.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {g10.GridColumns})
        'C.FocusedCardTopFieldIndex = 0

        'g10.MainView = g10.BandedGridView
        'Me.gridBand1 = New DevExpress.XtraGrid.Views.BandedGrid.GridBand
        'g10.MainView = g10.AdvBandedGridView
        'Me.gridBand1.Caption = "Product"
        'Dim B As DevExpress.XtraGrid.Views.BandedGrid.BandedGridView = g10.AdvBandedGridView
        'B.Bands.AddRange(New DevExpress.XtraGrid.Views.BandedGrid.GridBand() {Me.gridBand1})
        'Me.gridBand1.Columns.Add(g10.GridColumn("aaa"))
        '    'Me.gridBand1.Columns.Add(Me.colCategoryID)
        '    'Me.gridBand1.Columns.Add(Me.colProductID)
        '    'Me.gridBand1.Columns.Add(Me.colSupplierID)
        '    Me.gridBand1.Name = "gridBand1"
        '    Me.gridBand1.Width = 278

        Me.Open()
    End Sub

    Public Sub Init_Form()

    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty
            Case MenuType.Open

                Me.Open()

            Case MenuType.New

                Me.Open()

                g10.AddNewRow()

            Case MenuType.Save

                If Save_Form() Then Me.Open()

            Case MenuType.Delete

                Me._Delete()

                '            Case Else

                '                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub _Delete()
        If MessageYesNo("삭제 하시겠습니까 ?") <> MsgBoxResult.Yes Then Exit Sub
        Me.Open("dmb100_upload_del")
        Me.Open()
    End Sub

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

            Return Me.Save()

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


    Private Sub btn_item_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_item.Click
        Dim dSet As DataSet = OpenDataSet("dmb100_upload_itm")

        If IsEmpty(dSet) Then Exit Sub
        If DataValue(dSet) = "OK" Then
            MessageInfo("성공적으로 작업되었습니다")
            Me.Open_Form()
            Exit Sub
        End If

    End Sub

    Private Sub btn_bom_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_bom.Click
        Dim dSet As DataSet = OpenDataSet("dmb100_upload_bom")

        If IsEmpty(dSet) Then Exit Sub
        If DataValue(dSet) = "OK" Then
            MessageInfo("성공적으로 작업되었습니다")
            Exit Sub
        End If
    End Sub

    Private Sub btn_del_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_del.Click
        If g10.RowCount <= 0 Then Exit Sub

        Me._Delete()
    End Sub
End Class

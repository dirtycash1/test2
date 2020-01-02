Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class BCZ200


    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        Open_Form()
    End Sub


    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Open
                Open_Form()

                '            Case MenuType.Save

                '            Case MenuType.Delete

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    Private Sub New_Form()
        Try
            std_dt.Text = ""
            cury_bc.Text = ""
            Open_Form()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Open_Form()
        Try
            Open()
            'If Me.WorkSet("g10").RowCount <= 0 Then
            '    std_dt.Enabled = True
            '    cury_bc.Enabled = True
            'Else
            '    std_dt.Enabled = False
            '    cury_bc.Enabled = False
            'End If
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

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


    Private Sub btn_get_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_get.Click
        If MessageYesNo("[환율정보]를 웹에서 가져오시겠습니까?") <> MsgBoxResult.Yes Then Exit Sub
        If CheckRequired(std_dt, cury_bc) = False Then Exit Sub

        GetCurry()
    End Sub

    Private Sub GetCurry()
        Try
            Dim dSet As DataSet = OpenDataSet("bcz200_f10")
            Dim dRows As DataRowCollection = Nothing
            Dim Curry As CurrencyReader2 = New CurrencyReader2
            dRows = Curry.Reading2(dSet.Tables(0), dSet.Tables(1), std_dt.Text, cury_bc.Text, , 1) '최초고시환율가져오기
            'If std_dt.Text = Format(Now, "yyyy-MM-dd") Then
            '    Dim Curry As CurrencyReader = New CurrencyReader
            '    dRows = Curry.Reading(dSet.Tables(0), dSet.Tables(1), cury_bc.Text)
            'Else
            '    Dim Curry As CurrencyReader2 = New CurrencyReader2
            '    dRows = Curry.Reading2(dSet.Tables(0), dSet.Tables(1), std_dt.Text, cury_bc.Text)
            'End If


            If dRows.Count > 0 Then
                If Save("bcz200_f10") Then Open_Form()
                'For Each dRow In dRows

                'Next
            End If


            'If Not GetCurrency Is Nothing Then
            '    lbl_DateTime.Text = "기준통화시간 : " & GetCurrency.StdTime
            '    lbl_Currency.Text = GetCurrency.ToString()
            'Else
            '    lbl_DateTime.Text = Nothing
            '    lbl_Currency.Text = "현재 환율정보를 확인 할 수 없습니다."
            'End If

        Catch ex As Exception
            MessageWarning(ex)
        End Try

    End Sub

    'TextEdit1.AllowDrop = True
    'Private Sub TextEdit1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextEdit1.DragDrop
    '    If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '        TextEdit1.Text = e.Data.GetData(DataFormats.FileDrop)(0)
    '    End If
    'End Sub

    'Private Sub TextEdit1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles TextEdit1.DragOver
    '    If e.Data.GetDataPresent(DataFormats.FileDrop.ToString) Then
    '        e.Effect = DragDropEffects.Copy
    '    End If
    'End Sub

    Private Sub btn_link_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_link.Click

        'Dim path As My.Computer.FileSystem.GetFiles("c:\", True, "iexploer.exe")

        Shell("c:\Program Files\Internet Explorer\iexplore.exe http://www.smbs.biz/ExRate/TodayExRate.jsp", AppWinStyle.NormalFocus)

    End Sub
End Class

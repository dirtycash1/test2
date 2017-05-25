Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAB503

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Init_Form()
    End Sub

    Public Sub Init_Form()
        Me.Open()
    End Sub

    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

    '    Select Case mty

    '        'Case MenuType.New
    '        Case MenuType.Open
    '            '화면 컬럼의 생성
    '            Me.Init_Title()

    '            'Case MenuType.Save

    '            'Case MenuType.Delete

    '        Case Else

    '            MyBase.MenuButton_Click(mty)

    '    End Select

    'End Sub

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
    'Private Sub Init_Title()
    '    If CheckRequired(co_cd, fr_mon, to_mon) = False Then Exit Sub

    '    '1. 컬럼배열을 만든다
    '    Dim arr(1, 0) As String, colNm As String, colFNm As String

    '    Dim p As New OpenParameters
    '    p.Add("@co_cd", co_cd.Text)
    '    p.Add("@fr_mon", fr_mon.Text)
    '    p.Add("@to_mon", to_mon.Text)

    '    Dim dSet As DataSet = OpenDataSet("fab503_tit", p)

    '    If Not (IsEmpty(dSet)) Then
    '        Dim i As Integer = -1
    '        For Each dRow As DataRow In dSet.Tables(0).Rows
    '            i += 1
    '            ReDim Preserve arr(1, i)     'Array를 증가시킨다
    '            colNm = dRow.Item("mon")
    '            colFNm = colNm
    '            arr(0, i) = colFNm            'FieldName
    '            arr(1, i) = colNm
    '        Next
    '        '2. 화면에 Array Column을 Unbound로 Insert 또는 Add 한다
    '        ' Ex) g10.InsertColumn("A", arr, "B")
    '        '     "A" 컬럼이후에 삽입된다
    '        '     "A" 자리에 Nothing을 쓰면 Arry Column들이 마지막에 추가된다
    '        '     "B" 컬럼에 설정된 특성으로 Array의 수 만큼 새로운 컬럼을 만든다
    '    End If

    '    If arr(1, 0) = "" Then
    '        g10.Clear()
    '        g10.Init()
    '    Else
    '        g10.InsertArrayColumns("acc_nm", arr, "amt")
    '        Disp_Data()
    '    End If

    'End Sub

    'Private Sub Disp_Data()
    '    Try

    '        'Master 부분
    '        g10.GridColumn("cust_cd").IsMasterKey = True
    '        g10.GridColumn("acc_cd").IsMasterKey = True
    '        g10.GridColumn("cust_nm").IsMasterData = True
    '        g10.GridColumn("acc_nm").IsMasterData = True
    '        g10.GridColumn("ty").IsMasterData = True

    '        'Detail 부분
    '        g10.GridColumn("mon").IsDetailKey = True
    '        g10.GridColumn("amt").IsDetailData = True

    '        MyBase.Open()
    '        g10.AllowSort = False

    '    Catch ex As Exception
    '        MessageInfo(ex, "Disp_Data()")
    '    End Try
    'End Sub

    Private Sub g10_DoubleClick1(sender As Object, columnFieldIndex As Integer, columnIndex As Integer, rowIndex As Integer) Handles g10.DoubleClick
        Dim menuName As String = "FAX110"
        With g10

            If .Text("cust_cd") = "" Then
                Exit Sub
            End If

            'Dim mon As String = ""
            'If IsDate(g10.GridColumn + "-01") Then
            '    mon = g10.FocusedFieldName
            'End If

            Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
            If ctr IsNot Nothing Then
                ctr.Open2(co_cd.Text, .Text("cust_cd"), .Text("acc_cd"), fr_mon.Text)
            End If
        End With
    End Sub
End Class

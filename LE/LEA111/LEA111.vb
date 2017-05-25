Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class LEA111

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load

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
    Private Sub g10_CellValueChanging(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging
        Dim custCnt As Integer
        Dim CustCd As String

        If ColumnName = "chk" Then
            If Value = "1" Then
                CustCd = g10.Text("cust_cd")

                '  동일 거래처  체크
                For iRow = 0 To g10.RowCount - 1
                    If CustCd <> g10.Text("cust_cd", iRow) And g10.ToBool("chk", iRow) Then
                        custCnt = ToDec(custCnt) + 1
                    End If
                Next

                If custCnt > 0 Then
                    MsgBox("동일한 거래처만 처리 가능 합니다")
                    g10.UpdateRow()
                    g10.Text("qty") = ""
                    g10.Text("chk", RowIndex) = ""


                    Exit Sub
                End If

                g10.Text("qty") = g10.Text("rem_qty")
            Else
                g10.Text("qty") = ""
            End If

        End If

    End Sub


    Private Sub btn_do_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_do.Click

        '선택 건수 확인
        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If


        Dim menuName As String = "LEA110"
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)

        ctr.Open4(g10.DataSet)
    End Sub
End Class

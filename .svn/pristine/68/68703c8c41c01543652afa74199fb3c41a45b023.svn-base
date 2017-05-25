Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class DMP100
    Private MoveRow As Boolean

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.New_Form()
        ''품목코드In 자동채번 설정
        'prj_cd.CodeNo = "DMP100"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
    End Sub

    Private Sub SplitContainerControl2_Resize(sender As Object, e As System.EventArgs) Handles SplitContainerControl2.Resize
        Dim Pos As Integer = SplitContainerControl2.Width / 2
        SplitContainerControl2.SplitterPosition = Pos
    End Sub
    '######################################################################################
    '##             ToolBar Function                                                     ##
    '######################################################################################

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New
                New_Form()

            Case MenuType.Save
                Save_Form()

            Case MenuType.Delete
                If Me.Delete("dmp100_f10") = ExcuteResult.Succeeded Then
                    Me.Open("dmp100_g10")
                End If

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            prj_cd.Text = ""

            Me.Open("dmp100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회
            Form_Open()

            prj_cd.Focus()

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Form_Open(Optional ByVal AllChk As Boolean = True)
        Dim P As New OpenParameters
        P.Add("@prj_cd", prj_cd.Text)
        If AllChk Then
            Me.Open("dmp100_f10", P) '기본정보
            Me.Open("dmp100_g20", P) '규격정보
        End If

        Me.Open("dmp100_g50", P) '거래선정보
        Me.Open("dmp100_g30", P) '상세정보

    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean
        Try

            If MyBase.Save() Then
                MoveRow = True
                Me.Open("dmp100_g10")
                Form_Open(False)
            End If

            prj_cd.Focus()

        Catch ex As Exception
            MessageError(ex)
        Finally
            MoveRow = False
        End Try
    End Function


    '######################################################################################
    '##            사용자정의                                                            ##
    '######################################################################################

    '######################################################################################
    '##             Procedure                                                            ##
    '######################################################################################

    Private Sub g10_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g10.AfterMoveRow
        If MoveRow Then Exit Sub
        prj_cd.Text = g10.Text("prj_cd")
        Form_Open()
    End Sub

    Private Sub g30_AfterMoveRow(sender As Object, PrevRowIndex As Integer, RowIndex As Integer) Handles g30.AfterMoveRow
        'Me.Open("dmp100_f20", P) '기본정보
    End Sub
End Class

Imports Frame7
Imports Base7
Imports Base7.Shared
Imports Base7.Parameter

Public Class GAM100

    '######################################################################################
    '##             Form Event                                                           ##
    '######################################################################################

    Private Sub Form_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.New_Form()
    End Sub

    Public Sub Init_Form()

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

            Case Else

                MyBase.MenuButton_Click(mty)

        End Select

    End Sub

    '######################################################################################
    '##            Open                                                                  ##
    '######################################################################################

    Private Sub New_Form()
        Try
            co_cd.Text = ""
            Me.Open("gam100_g10")    'g10을 기점으로 OpenTrigger로 작동하는 모든 Control들 조회
            co_cd.Text = Parameter.Login.CoCd
            co_cd.Focus()
        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Sub Form_Open()
        Try
            Dim P As New OpenParameters
            P.Add("@co_cd", co_cd.Text)
            P.Add("@car_no", g10.Text("car_no"))
            Me.Open("gam100_g20", P) '수리정보
            Me.Open("gam100_g30", P) '보험정보
            Me.Open("gam100_g40", P) '운행정보
        Catch ex As Exception
            MessageError(ex)
        End Try

    End Sub

    '######################################################################################
    '##            Save                                                                  ##
    '######################################################################################

    Private Function Save_Form() As Boolean
        If CheckRequired(co_cd) = False Then Return False
        Try

            If MyBase.Save() Then Form_Open()

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

End Class

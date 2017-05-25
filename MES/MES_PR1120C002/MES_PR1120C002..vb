Imports Frame7
Imports Base7
Imports Base7.Shared

Imports System.Data
Imports System.Windows.Forms
Public Class MES_PR1120C002

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

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)

        Select Case mty

            Case MenuType.New

            Case MenuType.Open
                Me.Open_Form()

            Case MenuType.Save

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

        Catch ex As Exception
            MessageError(ex)
        End Try
    End Sub

    Private Function FindControls(ByVal ctrlc As Panel.ControlCollection, ByVal colNm As String) As Object
        Dim SubCtrl As Object = Nothing

        For Each ctrl As Object In ctrlc
            If InStr(colNm, "Panel") > 0 Then
                If (TypeOf ctrl Is Panel) Then
                    If LCase(ctrl.name) = LCase(colNm) Then
                        Return ctrl
                    End If
                End If
            Else
                If LCase(ctrl.name) = LCase(colNm) Then
                    Return ctrl
                End If
            End If
        Next
        Return Nothing
    End Function

    Private Sub ClearControl()
        Dim sColms As String = "MC_Nm,RunRt,Lot_No,CYCLE_Time,GD_Nm,JOB_Qty,PR_Qty,Tot_Qty,NG_Qty,NG_Rt,PR_Rt"
        Dim Ctrl As Object = Nothing
        Dim PanelContainer As Panel

        For iNo As Integer = 1 To 16
            For Each sColm As String In sColms.Split(",")
                PanelContainer = Me.FindControls(PanelMain.Controls, "Panel" + iNo.ToString())
                If IsNothing(PanelContainer) Then Continue For
                Ctrl = Me.FindControls(PanelContainer.Controls, sColm + iNo.ToString())
                If IsNothing(Ctrl) Then Continue For

                If (TypeOf Ctrl Is ProgressBar) Then
                    Ctrl.Value = 0
                ElseIf (TypeOf Ctrl Is Label) Then
                    If sColm = "MC_Nm" Or sColm = "RunRt" Then
                        Ctrl.Text = "" '기계명
                        Ctrl.BackColor = Color.Transparent
                    Else
                        Ctrl.Text = "" '기계명
                    End If
                End If
            Next
        Next
    End Sub
    Private Sub Open_Form()
        Try
            If Base7.Shared.CheckRequired(BaseDt, FAC_CD, GONG_CD) = False Then
                Return
            End If
            Me.ClearControl()

            Dim sParm As OpenParameters = New OpenParameters
            Dim dSet As DataSet = Nothing
            sParm.Add("@BaseDt", BaseDt.Text)
            sParm.Add("@FAC_CD", FAC_CD.Text)
            sParm.Add("@GONG_CD", GONG_CD.Text)
            dSet = Me.OpenDataSet("MES_PR1120C002_Qry", sParm)

            If IsNothing(dSet) Then Return
            Dim sColms As String = "MC_Nm,RunRt,Lot_No,CYCLE_Time,GD_Nm,JOB_Qty,PR_Qty,Tot_Qty,NG_Qty,NG_Rt,PR_Rt"
            Dim sVal As String = ""
            Dim Ctrl As Object = Nothing
            Dim sRowNo As String = ""
            Dim PanelContainer As Panel

            For Each dRow As DataRow In dSet.Tables(0).Rows
                For Each sColm As String In sColms.Split(",")
                    sVal = ToStr(dRow(sColm))
                    sRowNo = ToStr(dRow("RowNm"))
                    sColm = Trim(sColm) '공백 없이 값을 거져옴

                    'PanelMain
                    PanelContainer = Me.FindControls(PanelMain.Controls, "Panel" + sRowNo)
                    If IsNothing(PanelContainer) Then Continue For
                    If sRowNo = "1" Then
                        PanelContainer = Panel1
                    End If
                    Ctrl = Me.FindControls(PanelContainer.Controls, sColm + sRowNo)
                    If IsNothing(Ctrl) Then Continue For

                    If (TypeOf Ctrl Is ProgressBar) Then
                        Dim iint As Decimal
                        iint = 100
                        If ToDec(sVal) < 100 Then
                            iint = ToDec(sVal)
                        End If
                        ' Ctrl.Value = Math.Round(ToDec(sVal), 0) '' 100 넘어 가면 안됨. 
                        Ctrl.Value = Math.Round(iint, 0) '' 100 넘어 가면 안됨. 
                    ElseIf (TypeOf Ctrl Is Label) Then
                        If sColm = "MC_Nm" Then
                            Ctrl.Text = sVal '기계명
                            Ctrl.ForeColor = Color.White
                            If ToStr(dRow("STOP_Fg")) = "Y" Then '일반중단이면
                                Ctrl.BackColor = Color.Red  '빨강
                            ElseIf ToStr(dRow("STOP_Fg")) = "Z" Then '계획중단이면
                                Ctrl.BackColor = Color.Yellow '노랑
                                Ctrl.ForeColor = Color.Black
                            Else '가동
                                Ctrl.BackColor = Color.DodgerBlue
                            End If
                        ElseIf sColm = "GD_Nm" Then
                            Ctrl.Text = sVal '제품명
                        ElseIf sColm = "Lot_No" Then
                            Ctrl.Text = sVal 'L/N : 
                            'CYCLE_Time
                        ElseIf sColm = "CYCLE_Time" Then 'CYCLE Time
                            If ToDec(sVal) = Truncating(ToDec(sVal), 0) Then
                                Ctrl.Text = ToDec(sVal).ToString("####")
                            Else
                                Ctrl.Text = ToDec(sVal).ToString("##.#0")
                            End If
                        ElseIf sColm = "RunRt" Then '가동율
                            If ToDec(sVal) = 100 Then
                                Ctrl.Text = "가동율 : 100%"
                            Else
                                Ctrl.Text = "가동율 : " + ToDec(sVal).ToString("##.#0") + "%"
                            End If
                            Ctrl.ForeColor = Color.White
                            If ToStr(dRow("STOP_Fg")) = "Y" Then '일반중단이면
                                Ctrl.BackColor = Color.Red  '빨강
                            ElseIf ToStr(dRow("STOP_Fg")) = "Z" Then '계획중단이면
                                Ctrl.BackColor = Color.Yellow '노랑
                                Ctrl.ForeColor = Color.Black
                            Else '가동
                                Ctrl.BackColor = Color.DodgerBlue
                            End If
                        ElseIf sColm = "JOB_Qty" Then '지시량
                            Ctrl.Text = ToDec(sVal).ToString("#,###")
                        ElseIf sColm = "PR_Qty" Then '양품량
                            Ctrl.Text = ToDec(sVal).ToString("#,###")
                        ElseIf sColm = "Tot_Qty" Then '생산량
                            Ctrl.Text = ToDec(sVal).ToString("#,###")
                        ElseIf sColm = "NG_Qty" Then '불   량
                            Ctrl.Text = ToDec(sVal).ToString("#,###")
                        ElseIf sColm = "NG_Rt" Then '불량율
                            Ctrl.Text = ToDec(sVal).ToString("##.#0")
                            'ElseIf sColm = "PR_Rt" Then '진행율
                            '    Ctrl.Value = Convert.ToInt32(sVal)

                        End If


                    End If


                Next
            Next
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

End Class

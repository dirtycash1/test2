Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAB800

    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        doc_mon.Text = Year(Now).ToString

    End Sub

    Public Overrides Sub Open()
        Me._Set_Mng()

        MyBase.Open()

        g10.AddNewRow()
        g20.AddNewRow()

        _Set_Total()
        _Set_Total2()
    End Sub

    Public Overrides Function Save() As Boolean
        If MyBase.Save() Then
            Me.Open()
        End If
    End Function


#Region " Event "

    Private Sub acc_sum_proc_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles acc_sum_proc.Click
        Dim p As New OpenParameters
        Dim dSet As DataSet
        p.Add("@div_cd2", div_cd.Text)
        p.Add("@doc_mon2", doc_mon.Text)
        dSet = Me.OpenDataSet("fab800_work", p)
    End Sub

    Private Sub _Set_Total()
        Dim i As Integer, tot1 As Double, tot2 As Double
        With g10
            If 0 < .RowCount Then
                For i = 0 To .RowCount - 1
                    'If .IsDataRow(iRow) Then
                    tot1 += .ToDec("amt1", i)
                    tot2 += .ToDec("amt2", i)
                    'End If
                Next
            End If
        End With
        amt1.Text = tot1
        amt2.Text = tot2
        gap_amt1.Text = CDec(tot1 - tot2)
    End Sub

    Private Sub _Set_Total2()
        Dim i As Integer, tot1 As Double, tot2 As Double
        With g20
            If 0 < .RowCount Then
                For i = 0 To .RowCount - 1
                    'If .IsDataRow(iRow) Then
                    tot1 += .ToDec("amt1", i)
                    tot2 += .ToDec("amt2", i)
                    'End If
                Next
            End If
        End With
        deb_amt2.Text = tot1
        cre_amt2.Text = tot2
        'gap_amt2.Text = CDec(tot1 - tot2)
    End Sub

    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged
        _Set_Total()
    End Sub

    Private Sub g10_DeletedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g10.DeletedRow
        Me._Set_Total()
    End Sub

    Private m_StopEvent As Boolean

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged
        If m_StopEvent Then
            Exit Sub
        End If
        m_StopEvent = True
        With g20
            If kd.Text = "Combo" Then
                .Text("mng_val") = .Text("mng_val2")
                .Text("mng_dsc") = .EditText("mng_val2")
            End If
        End With
        m_StopEvent = False

        Me._Set_Total2()
    End Sub

    Private Sub g20_DeletedRow(ByVal sender As Object, ByVal RowIndex As Integer) Handles g20.DeletedRow
        Me._Set_Total2()
    End Sub

#End Region

#Region " 관리항목 설정 "

    Private Sub _Set_Mng()
        Dim p As New OpenParameters
        p.Add("@mng_no", mng_no2.Text)

        Dim dSet As DataSet = OpenDataSet("fab800_get_mng", p)

        Dim ty As String = DataValue(dSet, "mng_bc")
        Dim id As String = DataValue(dSet, "popup_id")
        Dim nm As String = mng_no2.EditText

        Me.__Set_Mng_Field(ty, nm, id)
    End Sub

    Private Const m_Mng_Popup = "FA210100"
    Private Const m_Mng_Combo = "FA210200"
    Private Const m_Mng_비고 = "FA210300"
    Private Const m_Mng_수치 = "FA210400"
    Private Const m_Mng_율 = "FA210450"
    Private Const m_Mng_년월일 = "FA210500"
    Private Const m_Mng_년월 = "FA210550"
    Private Const m_Mng_년 = "FA210600"

    Private Sub __Set_Mng_Field(ByVal ty As String, ByVal nm As String, ByVal pid As String)

        Dim f1 As intField, f2 As intField, f3 As intField
        f1 = g20.GridColumn("mng_val")
        f2 = g20.GridColumn("mng_dsc")
        f3 = g20.GridColumn("mng_val2")

        f1.Popup = Nothing
        f1.PopupType = ""

        kd.Visible = False
        kd.Text = ""

        Select Case ty

            Case m_Mng_Popup
                kd.Visible = True
                kd.Text = "Popup"

                f1.PopupType = "Popup"

                Me._Set_Popup(f1, f2, pid)

                g20.ColumnVisible("mng_val") = True
                g20.ColumnVisible("mng_dsc") = True
                g20.ColumnVisible("mng_val2") = False

            Case m_Mng_Combo
                kd.Visible = True
                kd.Text = "Combo"

                Me.__set_Combo(f3, pid)

                g20.ColumnVisible("mng_val") = False
                g20.ColumnVisible("mng_dsc") = False
                g20.ColumnVisible("mng_val2") = True

            Case m_Mng_비고, m_Mng_수치, m_Mng_율, m_Mng_년월일, m_Mng_년월, m_Mng_년

                g20.ColumnVisible("mng_val") = True
                g20.ColumnVisible("mng_dsc") = False
                g20.ColumnVisible("mng_val2") = False

        End Select

    End Sub

    Private Sub __set_Combo(ByVal f1 As intField, ByVal popupID As String)
        Dim p As New OpenParameters
        p.Add("@popup_id", popupID)

        Dim dSet As DataSet = Me.OpenDataSet("fab800_get_combo", p)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        g20.ClearCombo("mng_val2")
        g20.SetCombo("mng_val2", dSet)

        'CType(f1, eCombo).SetCombo(dSet)
    End Sub

    Private Sub _Set_Popup(ByVal f1 As intField, ByVal f2 As intField, ByVal popupID As String)

        Dim dSet As DataSet

        Dim op As New OpenParameters
        op.Add("@mng_no", mng_no2.Text)
        op.Add("@popup_id", popupID)

        dSet = Me.OpenDataSet("get_popup_fields", op)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        'Dim pid = DataValue(dSet, "popup_id")
        Dim subCd = DataValue(dSet, "sub_cd")
        Dim param = DataValue(dSet, "param")
        Dim params = DataValue(dSet, "params")
        Dim out1 = DataValue(dSet, "out1")
        Dim out2 = DataValue(dSet, "out2")
        Dim mainCd = DataValue(dSet, "main_cd")

        If Not (mainCd = "Popup" Or mainCd = "Dynamic") Then
            'MessageInfo(subCd + ": Popup 유형이 [" + mainCd + "] 입니다. [Popup] 이어야 합니다")
            Exit Sub
        End If

        Dim pup As Popup = New Popup
        f1.Popup = pup

        pup.BaseField = f1
        pup.PopupID = popupID
        pup.SubCode = subCd '"HR210"

        '-----------------------
        'Setting input
        '-----------------------
        If params = "" Then
            pup.AddInput(param, f1) '("@dept_cd", t1)
        Else
            Dim arr() As String, p As String, f As String, iFld As intField = Nothing
            arr = Split(params, ",")
            For Each ps As String In arr

                p = Split(ps, "=")(0)
                f = Split(ps, "=")(1)

                If f = "Me" Then            'Field를 체크
                    iFld = f1
                ElseIf p = "@co_cd" Then    'Parameter를 체크
                    iFld = co_cd
                ElseIf p = "@div_cd" Then   'Parameter를 체크
                    iFld = div_cd
                ElseIf p = "@bank_cd" Then  'Parameter를 체크
                    dummy.Text = "%"
                    iFld = dummy
                End If

                If iFld IsNot Nothing Then
                    pup.AddInput(p, iFld)

                    If mainCd = "Dynamic" Then
                        Dim j = New Join()
                        j.FromControl = iFld
                        j.ToControl = f1
                        j.JoinType = JoinType.Indicate
                        Me.Joins.Add(j)
                    End If
                End If
            Next
        End If

        '-----------------------
        'Setting output
        '-----------------------
        pup.AddOutput(out1, f1)
        If f2 IsNot Nothing Then
            pup.AddOutput(out2, f2)
        End If

        If mainCd = "Dynamic" Then
            f1.GetIndicator(Nothing)
        End If

    End Sub

#End Region

End Class

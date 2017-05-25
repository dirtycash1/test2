Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAB501

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case MenuType.Open

                If f1 IsNot Nothing Then
                    mng_val.Text = f1.Text
                Else
                    mng_val.Text = ""
                End If

                MyBase.Open()

            Case MenuType.Save
                Me.Save()

            Case Else
                MyBase.MenuButton_Click(mty)

        End Select

    End Sub


    'Private Sub acc_cd_TextChanging(ByVal sender As Object, ByVal newValue As String, ByVal oldValue As String, ByRef cancel As Boolean) Handles acc_cd.TextChanging
    '    _Disp_Mng_Fields()
    'End Sub

    Private Sub mng_no_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles mng_no.TextChanged
        _Disp_Mng_Fields()
    End Sub


#Region " 관리항목 설정 "

    Private Const m_Mng_Popup = "FA210100"
    Private Const m_Mng_Combo = "FA210200"
    Private Const m_Mng_비고 = "FA210300"
    Private Const m_Mng_수치 = "FA210400"
    Private Const m_Mng_율 = "FA210450"
    Private Const m_Mng_년월일 = "FA210500"
    Private Const m_Mng_년월 = "FA210550"
    Private Const m_Mng_년 = "FA210600"

    Private f1 As Object
    Private f2 As Object

    Private Sub _Disp_Mng_Fields()

        If f1 IsNot Nothing Then f1.Dispose()
        If f2 IsNot Nothing Then f2.Dispose()

        f1 = Nothing
        f2 = Nothing

        If mng_no.Text = "" Then
            Exit Sub
        End If

        Dim p As New OpenParameters
        p.Add("@mng_no", mng_no.Text)

        Dim dSet As DataSet = OpenDataSet("fax100_get_mng", p)

        Dim ty As String = DataValue(dSet, "mng_bc")
        Dim pid As String = DataValue(dSet, "popup_id")
        Dim nm As String = mng_no.EditText


        Me.__New_Mng_Field(ty, nm, pid)


        If f1 IsNot Nothing Then f1.BringToFront()
        If f2 IsNot Nothing Then f2.BringToFront()

    End Sub

    Private Sub __New_Mng_Field(ByVal ty As String, ByVal nm As String, ByVal pid As String)

        Dim x1 As Integer, x2 As Integer, y As Integer = 28

        x1 = mng_val.Location.X
        x2 = x1 + mng_val.Width + 4
        'x1 = 272 '352
        'x2 = x1 + 244
        y = 76 '52

        Select Case ty

            Case m_Mng_Popup

                f1 = New Frame7.eText
                f2 = New Frame7.eText

                Me.___Set_Field_Property(f1, nm, x1, y, mng_val.Width)
                Me.___Set_Field_Property2(f2, nm, x2, y)
                Me.___Set_Popup(f1, f2, pid) '"71")

            Case m_Mng_Combo

                f1 = New Frame7.eCombo
                Me.___Set_Field_Property(f1, nm, x1, y, mng_val.Width)
                Me.___set_Combo(f1, pid)

            Case m_Mng_비고, m_Mng_수치, m_Mng_율

                f1 = New Frame7.eText
                'Dim w As Integer = IIf(ty = m_Mng_비고, 300, 240)
                Me.___Set_Field_Property(f1, nm, x1, y, mng_val.Width)

                If ty = m_Mng_수치 Or ty = m_Mng_율 Then
                    f1.FieldType = FieldType.Decimal
                    f1.RoundDigits = 4
                    f1.RoundType = RoundType.Truncation
                End If

            Case m_Mng_년월일, m_Mng_년월, m_Mng_년

                f1 = New Frame7.eDate
                Me.___Set_Field_Property(f1, nm, x1, y, mng_val.Width)

                If ty = m_Mng_년월일 Then CType(f1, eDate).FormatType = DateFormatType.Day
                If ty = m_Mng_년월 Then CType(f1, eDate).FormatType = DateFormatType.Month
                If ty = m_Mng_년 Then CType(f1, eDate).FormatType = DateFormatType.Year

        End Select

    End Sub

    Private Sub ___Set_Field_Property(ByVal f As Control, ByVal title As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 240)
        Me.EPanel1.Controls.Add(f)

        f.Font = New System.Drawing.Font("Tahoma", 9) '"맑은 고딕", 9)
        f.Location = New System.Drawing.Point(x, y)
        'f.Name = "f" + inx.ToString.Trim
        f.Size = New System.Drawing.Size(w, 21)
        f.TabIndex = 100 + 1
        CType(f, intField).Title = title

    End Sub

    Private Sub ___Set_Field_Property2(ByVal f As Control, ByVal title As String, ByVal x As Integer, ByVal y As Integer, Optional ByVal w As Integer = 200)
        Me.EPanel1.Controls.Add(f)

        f.Font = New System.Drawing.Font("Tahoma", 9) '"맑은 고딕", 9)
        f.Location = New System.Drawing.Point(x, y)
        'f.Name = "n" + inx.ToString.Trim
        f.Size = New System.Drawing.Size(w, 21)
        f.TabIndex = 100 + 2

        f.TabStop = False
        CType(f, eText).TitleWidth = 0
        CType(f, eText).ReadOnly = True
    End Sub

    Private Sub ___Set_Popup(ByVal f1 As intField, ByVal f2 As intField, ByVal popupID As String)

        Dim dSet As DataSet

        Dim p As New OpenParameters
        p.Add("@popup_id", popupID)

        dSet = Me.OpenDataSet("fax100_get_popup", p)
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

        If mainCd <> "Popup" Then
            MessageInfo(subCd + ": Popup 유형이 [" + mainCd + "] 입니다. [Popup] 이어야 합니다")
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
            Dim arr() As String, p1 As String, f As String, iFld As intField = Nothing
            arr = Split(params, ",")
            For Each ps As String In arr

                p1 = Split(ps, "=")(0)
                f = Split(ps, "=")(1)

                If f = "Me" Then
                    iFld = f1
                ElseIf f = "co_cd" Then
                    iFld = co_cd
                ElseIf f = "div_cd" Then
                    iFld = div_cd
                    'ElseIf f = "dept_cd" Then
                    '    iFld = dept_cd
                    'ElseIf f = "Prev" Then
                    '    If 0 < inx Then
                    '        For Each fld As intField In EPanel1.Controls
                    '            If fld.Name = "f" + (inx - 1).ToString.Trim Then
                    '                iFld = fld
                    '                Exit For
                    '            End If
                    '        Next
                    '    End If
                End If

                If iFld IsNot Nothing Then
                    pup.AddInput(p1, iFld)

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

        pup.AddOutput(out1, f1) '("dept_cd", f1)

        pup.AddOutput(out2, f2) '("dept_nm", f2)


    End Sub

    Private Sub ___set_Combo(ByVal f1 As intField, ByVal popupID As String)
        Dim p As New OpenParameters
        p.Add("@popup_id", popupID)

        Dim dSet As DataSet = Me.OpenDataSet("fax100_get_combo", p)
        If IsEmpty(dSet) Then
            Exit Sub
        End If

        CType(f1, eCombo).SetCombo(dSet)
    End Sub

#End Region

    Private Sub g10_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g10.DoubleClick
        Dim menuName As String
        menuName = "FAB116"

        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(g10.Text("doc_no"))
        End If
    End Sub

    Private Sub g20_DoubleClick(sender As System.Object, e As System.EventArgs) Handles g20.DoubleClick
        Dim menuName As String
        menuName = "FAB116"

        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName)
        If ctr IsNot Nothing Then
            ctr.Open2(g20.Text("doc_no"))
        End If
    End Sub
End Class

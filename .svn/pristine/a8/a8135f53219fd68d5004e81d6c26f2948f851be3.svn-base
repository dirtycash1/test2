Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PPM100

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        'Case MenuType.Open
    '        '    MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
    '        '    '사용하려면 재정의 가능하다
    '        'Case MenuType.Save

    '        Case MenuType.New
    '            cust_cd.Text = ""
    '            itm_cd.Text = ""
    '            itm_nm.Text = ""
    '            emp_id.Text = ""
    '            emp_nm.Text = ""

    '            Me.New_Form()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub

    'Public Sub New_Form()
    '    Me.Open()

    'End Sub



    Private Sub g10_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanged

        If ColumnName = "chk" Then
            If g10.Text("chk", g10.RowIndex) = "0" Then
                g10.Text("wo2_qty", g10.RowIndex) = 0
            End If
            If g10.Text("chk", g10.RowIndex) = "1" Then
                g10.Text("wo2_qty", g10.RowIndex) = Val(g10.Text("wo_qty", g10.RowIndex))
            End If
        End If

    End Sub

    Private Sub SimpleButton1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton1.Click

        If g10.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        Dim dTbl As DataTable, dRow As DataRow
        Dim dset As DataSet = Me.OpenDataSet("ppm100_save_data")

        dTbl = dset.Tables(0)
        With g10
            .UpdateRow()

            dTbl.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    dRow = dTbl.NewRow()

                    dRow("itm_id") = .Text("itm_id", i)
                    dRow("wo_dt") = wo_dt.Text
                    dRow("wo_qty") = .Text("wo2_qty", i)
                    dTbl.Rows.Add(dRow)
                End If
            Next
            dTbl.EndLoadData()
        End With

        If Me.Save() Then
            g20.Open()
        End If

    End Sub

    Private Sub g20_CellValueChanged(ByVal sender As Object, ByVal ColumnName As String, ByVal RowIndex As Integer, ByRef Value As Object) Handles g20.CellValueChanged

        If ColumnName = "chk" Then
            If g20.Text("chk", g20.RowIndex) = "0" Then
                g20.Text("mov_qty", g20.RowIndex) = 0
            End If
            If g20.Text("chk", g20.RowIndex) = "1" Then
                g20.Text("mov_qty", g20.RowIndex) = Val(g20.Text("bom_qty", g20.RowIndex))
            End If
        End If

    End Sub

    Private Sub SimpleButton2_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles SimpleButton2.Click

        If g20.CheckedRows("chk") = 0 Then
            Exit Sub
        End If

        Dim dTbl2 As DataTable, dRow As DataRow
        Dim dset2 As DataSet = Me.OpenDataSet("ppm100_mov_data")

        dTbl2 = dset2.Tables(0)
        With g20
            .UpdateRow()

            dTbl2.BeginLoadData()
            For i As Integer = 0 To .RowCount - 1
                If .ToBool("chk", i) Then
                    dRow = dTbl2.NewRow()

                    dRow("itm_id") = .Text("itm_id", i)
                    dRow("wo_dt") = wo_dt.Text
                    dRow("wo_qty") = .Text("mov_qty", i)
                    dTbl2.Rows.Add(dRow)
                End If
            Next
            dTbl2.EndLoadData()
        End With

        MyBase.Save("ppm100_mov_data")

        Dim menuName As String

        menuName = "LEM110"
        '화면을 띄운다
        Dim ctr As Object = Parameter.MainFrame.Frame.CallMenuForm(menuName) 'New FormAttribute(menuName, menuText))
        If ctr IsNot Nothing Then
            ctr.Open5(fac_cd.Text, out_wh.Text, in_wh.Text)
        End If

    End Sub



End Class

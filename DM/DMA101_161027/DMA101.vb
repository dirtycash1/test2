Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports System.Net
Imports System.IO
Imports System.Xml.Serialization

Imports CrystalDecisions.CrystalReports.Engine
Imports CrystalDecisions.Shared
Imports CrystalDecisions.ReportSource
Imports System.Runtime.CompilerServices
Imports System.Text


Public Class DMA101
    Private Sub MMB100_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        ''구매발주번호 자동채번 설정
        'po_no.CodeNo = "DMA101"        'Function dbo.[fnCodeNo]안에 LEB100에 대한 코딩을 해야 한다
        'po_no.CodeDateField = po_dt

        'Me.New_Form()

        SplitContainer2.Panel2Collapsed = True

    End Sub

    'Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
    '    Select Case mty
    '        Case MenuType.Open
    '            Me.Open_Form()

    '        Case MenuType.Save
    '            If MyBase.Save() Then
    '                Me.Open_Form()
    '            End If

    '        Case MenuType.Delete

    '        Case MenuType.New
    '            Me.New_Form()
    '        Case MenuType.Print
    '            Me.Print()

    '        Case Else
    '            MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

    '    End Select

    'End Sub



    '20160613 smk 단가선택 기능
    Private m_StopEvent As Boolean

    Private Sub g10_DoubleClick(sender As Object, e As System.EventArgs) Handles g10.DoubleClick
        'Dim cc As String
        'Dim row_i As Integer

        If m_StopEvent Then
            Return
        End If

        m_StopEvent = True

        Try
            Panel2_collapsed(g10.RowIndex, "1")
            g20_open(g10.RowIndex)

        Catch ex As Exception
        Finally
            m_StopEvent = False
        End Try

    End Sub

    'Private Sub g10_CellValueChanging1(sender As Object, ColumnName As String, RowIndex As Integer, ByRef Value As Object) Handles g10.CellValueChanging

    '    Dim cc As String
    '    Dim row_i As Integer

    '    If m_StopEvent Then
    '        Return
    '    End If

    '    m_StopEvent = True

    '    Try
    '        If ColumnName = "echeck" Then

    '            If Value = "1" Then

    '                For i As Integer = 0 To g10.RowCount - 1
    '                    g10.Text("echeck") = "0"
    '                Next

    '                cc = "1"
    '                g10.Text("echeck") = cc
    '                row_i = RowIndex
    '            Else
    '                cc = "0"
    '                g10.Text("echeck") = cc
    '            End If
    '            Panel2_collapsed(RowIndex, cc)
    '            g20_open(RowIndex)

    '        End If

    '    Catch ex As Exception
    '    Finally
    '        m_StopEvent = False
    '    End Try

    'End Sub

    Private Sub Panel2_collapsed(RowIndex As Integer, cc As String)   'smk 160613
        If cc = "1" Then
            SplitContainer2.Panel2Collapsed = False '나타내기 
        Else
            SplitContainer2.Panel2Collapsed = True  '숨기기 
        End If

    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        SplitContainer2.Panel2Collapsed = True  '숨기기 
    End Sub

    Public Sub g20_open(RowIndex As Integer)
        Dim p20 As OpenParameters = New OpenParameters

        p20.Clear()
        p20.Add("@itm_id", g10.Text("itm_id", RowIndex))

        Me.Open("dma101_g20", p20)
    End Sub
    '20160613 smk 단가선택 기능 END 

    'Private Sub g20_ButtonPressed(sender As System.Object, columnName As System.String)
    '    If columnName = "up_save" Then
    '        g10.Text("po_up") = g20.Text("up")
    '    End If

    'End Sub


    Private Sub g20_ButtonPressed(ByVal sender As Object, ByVal columnName As String) Handles g20.ButtonPressed
        Dim FileID As String = g20.Text("file_id")
        Dim FileNm As String = g20.Text("file_nm")

        If FileNm = "" Then
            Exit Sub
        End If

        Select Case columnName
            'Case "del"

            '    Try
            '        If [Shared].FileDelete(FileID, FileNm) = True Then
            '            g20.AllowDeleteRows = True
            '            g20.DeleteRow(g20.RowIndex)
            '            g20.AllowDeleteRows = False

            '            Me.Save("dma100_g90")
            '        End If
            '    Catch ex As Exception
            '        MessageInfo(ex)
            '    End Try

            Case "show"
                [Shared].FileDownLoad(FileID, FileNm, , True)

                'Case "down"
                '    [Shared].FileDownLoad(FileID, FileNm)

        End Select
    End Sub


 



End Class

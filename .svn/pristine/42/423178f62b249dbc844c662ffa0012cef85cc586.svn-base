Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class PAY700

    Private Sub PAY700_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        MyBase.Open()

    End Sub


    Private Sub btn_sum_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_sum.Click
        Dim p As OpenParameters = New OpenParameters
        Dim dSet As DataSet

        p.Add("@app_year", app_year.Text)
        p.Add("@bs_cd", bs_cd.Text)
        p.Add("@reg_dt", reg_dt.Text)
        p.Add("@reg_uid", Parameter.Login.RegId)

        dSet = OpenDataSet("pay700_work_2011", p)


        If DataValue(dSet) = "OK" Then
            MessageInfo("데이타집계 처리가 완료 되었습니다.")
            MyBase.Open("pay700_g10")
        End If


        'MyBase.Open("pay150_g31")
    End Sub

    Private Sub btn_file_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btn_file.Click
        Dim sFileNm As String, s확장자 As String

        If g10.RowCount <= 0 Then
            MessageInfo("파일생성데이타 존재하지 않습니다.")
            Exit Sub
        End If

        'If DataChk() = False Then Exit Sub

        Dim i As Integer, j As Integer
        '---------------------------------------------------
        '파일명 : 지급조서별구분자 + 사업자등록번호 앞자리 7자리
        '확장자 : 사업자등록번호 뒷자리 3자리
        '---------------------------------------------------
        sFileNm = ""
        s확장자 = ""

        sFileNm = Microsoft.VisualBasic.Left(v_bs_no.Text, 7)
        s확장자 = Microsoft.VisualBasic.Right(v_bs_no.Text, 3)

        SaveFileDialog1.CreatePrompt = True
        SaveFileDialog1.OverwritePrompt = True
        SaveFileDialog1.Title = "원천징수 전산매체 파일 저장하기."
        SaveFileDialog1.Filter = "텍스트 파일(*.*)|*." + sFileNm

        ' "C"   근로소득(갑근)
        ' "CA"  의료비
        ' "H"   기부금
        SaveFileDialog1.FileName = "C" + sFileNm + "." + s확장자

        If SaveFileDialog1.ShowDialog <> System.Windows.Forms.DialogResult.OK Then
            SaveFileDialog1.Dispose()
            Return
        End If

        'btnFile.Enabled = False

        If Err.Number = 1 Then Exit Sub

        If SaveFileDialog1.FileName <> "" Then

            Me.Cursor = Cursors.WaitCursor

            Dim Korean As System.Text.Encoding

            '2바이트완성형코드 (ksc-5601)
            Korean = System.Text.Encoding.GetEncoding(949)
            '     Dim sw As StreamWriter = New StreamWriter(SaveFileDialog1.FileName, False, Korean)

            Dim sw As IO.StreamWriter = New IO.StreamWriter(SaveFileDialog1.FileName, False, Korean)


            For j = 0 To g10.RowCount - 1
                i += 1
                g10.RowIndex = i - 1
                '마지막행에도 한row를 생성해야만,, 마지막데이타를 읽는다
                sw.Write(g10.Text("row", j).Replace("z", "") + vbNewLine)
            Next j

            sw.Close()
            'btnFile.Enabled = True
            Me.Cursor = Cursors.Default
        End If

        '        Catch ex As Exception
        'MessageInfo("File 생성")
        'Me.Cursor = Cursors.Default
        ''btnFile.Enabled = True
        'End Try

    End Sub



End Class

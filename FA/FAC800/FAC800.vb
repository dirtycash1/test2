Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data

Public Class FAC800

    Private Sub FAC800_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        iss2_bc.Text = optiss_bc.EditValue
    End Sub

#Region " Event "
    Private Sub cmdproc_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles cmdproc.Click
        For row = 0 To g10.RowCount - 1
            If g10.Text("chk", row) = "1" Then
                Try
                    ' 오브젝트 생성 관련 변수
                    Dim objSBI, objDTI
                    '--// 세금계산서 전송 성공/실패 여부 관련 변수
                    Dim IntSuccessCnt, IntFailCnt
                    '--/세금계산서 데이터 관련 변수
                    Dim generalInfo, supplierInfo, buyerInfo, brokerInfo, settlementInfo, ItemInfo, dtiMessage, itemCount
                    '--/세금계산서 파일관련 변수
                    Dim dtifilePath, dtifileName, userDN, userInfo, dtiResult, strSBID, strSBPwd, strErrorMsg
                    Dim returnCode, Main_Conv_ID, Issue_ID
                    Dim rValue, byr_id, brk_id
                    'Dim strCertQry, rsCert, userInfoSet, arrayM
                    '//------------------------------------
                    '//	변수 초기화
                    '//------------------------------------
                    IntSuccessCnt = 0
                    IntFailCnt = 0
                    returnCode = Nothing
                    strErrorMsg = Nothing
                    '//------------------------------------
                    '//	SmartBill의 아이디 및 패스워드
                    '//------------------------------------
                    Dim conv_id = Replace(g10.Text("biz_no1", row), "-", "") & Replace(g10.Text("biz_no", row), "-", "") & Replace(Mid(g10.Text("tax_dt", row), 1, 10), "-", "")
                    Dim dSet As DataSet, dRows As DataRowCollection, dRow As DataRow
                    Dim P As New OpenParameters
                    P.Add("@conv_id", conv_id)
                    P.Add("@code_id", "conv")
                    'Command 생성
                    dSet = Me.OpenDataSet("fac800_no", P)
                    dRows = dSet.Tables(0).Rows
                    For Each dRow In dRows
                        conv_id = conv_id & ToStr(dRow("code_no")) & "002"
                    Next
                    Dim Main_Issue_ID = Replace(Mid(g10.Text("tax_dt", row), 1, 10), "-", "") & "41000008" & g10.Text("bill_cd", row)
                    P.Add("@conv_id", Main_Issue_ID)
                    P.Add("@code_id", "iss")
                    'Command 생성
                    dSet = Me.OpenDataSet("fac800_no", P)
                    dRows = dSet.Tables(0).Rows
                    For Each dRow In dRows
                        Main_Issue_ID = Main_Issue_ID & ToStr(dRow("code_no"))
                    Next
                    'cust_nm.Text = Main_Issue_ID

                    strSBID = g10.Text("bill_id", row)                            '// SmartBill ID
                    strSBPwd = g10.Text("bill_pwd", row)               '// SmartBill Password
                    Main_Conv_ID = conv_id '"50581205671234561238201011041234002"        '// Conversation_id
                    ' Conversation_id는 총 35자리로 구성되어 있습니다.
                    ' 1~10번째 자리 :   1233311114					공급자 사업자 번호 
                    ' 11~20번째 자리 : 1234561238					공급받는자 사업자 번호 
                    ' 21~28번째 자리 : 20080410							세금계산서일자(년월일)
                    ' 29~32번째 자리 : 1234											일련번호
                    ' 33~25번째 자리 : 002												API사용시 Default 넘버
                    '2010111241000008u3s00001
                    Issue_ID = Main_Issue_ID                    '"2010110441000008u3s00000"   '// 승인번호
                    ' 승인번호는 총 24자리로 구성되어 있습니다.
                    ' 1-8번째 자리 : 20071218						작성일자
                    ' 9-16번째 자리 : 41000008						국세청등록번호
                    ' 17-19번째 자리 : u3s							업체별코드(스마트빌에서 업체별로 부여한 코드값)
                    ' 20-24번째 자리 : 00000						일련번호(영문자 소문자를 포함할 수 있다.)
                    byr_id = ""                                             '공급받는자 담당자의 스마트빌 아이디(아는경우만 입력)
                    brk_id = ""                                         '	수탁자 담당자의 스마트빌 아이디(아는경우만 입력)					
                    '//-----------------------------------------
                    '//	세금계산서 생성 및 Interface Object 생성
                    '//-----------------------------------------
                    objSBI = CreateObject("SBIHandler.SBIInterface")                                         '// 세금계산서 XML파일 생성 관련 오브젝트
                    objDTI = CreateObject("FSSmartBillDTI.DTIInterface")             '// 세금계산서 전송 관련 오브젝트
                    '//============================================================
                    '//- 세금계산서 발행시 필요한 데이터 -//
                    '//---------------------------------------
                    '//	세금계산서 메인정보 추출
                    '//---------------------------------------
                    '세금계산서종류
                    Dim tax_bc = g10.Text("tax_bc", row)
                    If tax_bc = "FA630280" Or tax_bc = "FA630130" Then
                        tax_bc = "02"
                    Else
                        tax_bc = "01"
                    End If
                    '영수구분
                    Dim tax_kd = g10.Text("tax_kd", row)
                    If tax_kd = "FA600100" Then
                        tax_kd = "01"
                    Else
                        tax_kd = "18"
                    End If

                    '일련번호--세금계산서번호
                    Dim seq_id = g10.Text("tax_no", row) '"SequenceID"
                    '";#;2010-11-04;#;01;#;18;#;SequenceID;#;비고;#;;#;;#;;#;2010110441000008u3s00000;#;50581205671234561238201011041234002;#;"
                    generalInfo = ";#;" & Mid(g10.Text("tax_dt", row), 1, 10) & ";#;" & tax_bc & ";#;" & tax_kd & ";#;" & seq_id & ";#;" & g10.Text("rmks", row) & ";#;;#;;#;" & g10.Text("amend_cd", row) & ";#;" & Issue_ID & ";#;" & Main_Conv_ID & ";#;"
                    '//---------------------------------------
                    '//	공급자정보 추출
                    '//---------------------------------------
                    '"5058120567;#;Orion&Chip;#;;#;OrionJU;#;SoftWare;#;Service;#;SeoulKangGu;#;ITPart;#;Michael;#;02-3473-9009;#;purinkeke@hotmail.com;#;"
                    supplierInfo = Replace(g10.Text("biz_no1", row), "-", "") & ";#;" & g10.Text("ceo_nm", row) & ";#;;#;" & g10.Text("bs_nm", row) & ";#;" & g10.Text("biz_type", row) & ";#;" & g10.Text("biz_kind", row) & ";#;" & g10.Text("addr_prt", row) & ";#;" & g10.Text("bill_dept", row) & ";#;" & g10.Text("bill_nm", row) & ";#;" & g10.Text("bill_tel", row) & ";#;" & g10.Text("bill_email", row) & ";#;"
                    '//---------------------------------------
                    '//	공급받는자정보 추출
                    '//---------------------------------------
                    '"1234561238;#;JangKiHoo;#;;#;OrganizationName;#;BusinessTypeName;#;BusinessClassificationName;#;AddressLine1Text;#;Department;#;PersonName;#;02-3473-9009;#;test@frontiers.co.kr;#;"
                    buyerInfo = Replace(g10.Text("biz_no", row), "-", "") & ";#;" & g10.Text("cust_ceo_nm", row) & ";#;;#;" & g10.Text("cust_nm", row) & ";#;" & g10.Text("cust_biz_type", row) & ";#;" & g10.Text("cust_biz_kind", row) & ";#;" & g10.Text("addr", row) & ";#;" & g10.Text("bill_dept", row) & ";#;" & g10.Text("esero", row) & ";#;" & g10.Text("etel", row) & ";#;" & g10.Text("email", row) & ";#;"

                    '//---------------------------------------
                    '//	수탁자정보 추출 (위수탁 건이 아니기 때문에 공백처리)
                    '//---------------------------------------
                    brokerInfo = ";#;;#;;#;;#;;#;;#;;#;;#;;#;;#;;#;"

                    '//---------------------------------------
                    '//	세금계산서 금액관련 정보 추출
                    '//---------------------------------------
                    '"10;#;0;#;20;#;0;#;2AA;#;0;#;30;#;0;#;100000;#;10000;#;110000;#;"
                    settlementInfo = "10;#;0;#;20;#;0;#;2AA;#;0;#;30;#;0;#;" & g10.Text("item_amt", row) & ";#;" & g10.Text("vat_amt", row) & ";#;" & g10.Text("amt", row) & ";#;"
                    'MsgBox(settlementInfo)
                    '//---------------------------------------
                    '//	품목정보 추출 
                    '//---------------------------------------	
                    ' Item이 4건일 경우
                    'ItemInfo = "1;#;Memory;#;A;#;2004-11-04;#;DescriptionText;#;10;#;100;#;1000;#;100;#;2;#;CPU;#;B;#;2004-11-04;#;DescriptionText;#;20;#;2000;#;40000;#;4000;#;3;#;CDRom;#;C;#;2004-11-04;#;DescriptionText;#;1;#;10000;#;10000;#;1000;#;4;#;Monotor;#;D;#;2004-11-04;#;DescriptionText;#;1;#;300000;#;300000;#;30000;#;"
                    'itemCount = "4"
                    P.Add("@tax_no", g10.Text("tax_no", row))
                    'Command 생성
                    dSet = Me.OpenDataSet("fac800_sql", P)
                    dRows = dSet.Tables(0).Rows
                    Dim int As Integer = 0
                    ItemInfo = Nothing
                    'ItemInfo = "1;#;Memory;#;A;#;2010-11-04;#;DescriptionText;#;10;#;1000;#;100000;#;10000;#;"
                    For Each dRow In dRows
                        int = int + 1
                        ItemInfo = ItemInfo & CStr(int) & ";#;" & ToStr(dRow("item")) & ";#;" & ToStr(dRow("spec")) & ";#;" & Mid(g10.Text("tax_dt", row), 1, 10) & ";#;" & ToStr(dRow("rmks")) & ";#;" & ToStr(dRow("qty")) & ";#;" & ToStr(dRow("up")) & ";#;" & ToStr(dRow("item_amt")) & ";#;" & ToStr(dRow("vat_amt")) & ";#;"
                        ' ToStr(dRow("code")) 
                    Next
                    '	Item이 4건 미만일 경우
                    itemCount = CStr(int)
                    'MsgBox(ItemInfo)
                    '//- 세금계산서 발행시 필요한 데이터 -// 끝.
                    '//============================================================
                    '//---------------------------------------
                    '//	인증서 정보 추출
                    '//---------------------------------------	
                    'userInfoSet = objDTI.getUserInfoForBulk()       '// 인증서 확인 창을 띄웁니다.(인증서 비밀번호)
                    'arrayM = Split(userInfoSet, ";#;")                               '// 인증값을 배열로 받음
                    'userDN = arrayM(1)                                                                  '// 인증정보를 DN값으로 분리
                    'userInfo = arrayM(2)
                    userDN = g10.Text("cert_dn", row)                                                                '// 인증정보를 DN값으로 분리
                    userInfo = g10.Text("cert_info", row)
                    'MsgBox(userInfo)
                    '// 인증정보를 INFO값으로 분리
                    '// 인증서 정보 추출여부 확인
                    If (Len(userDN) = 0) Then
                        MsgBox("인증서 등록에 살패 했습니다.")
                        Exit Sub
                    End If
                    '//---------------------------------------
                    '//	세금계산서 파일 생성
                    '//---------------------------------------	
                    dtiMessage = objDTI.makeDTIFrameWorkForHUBBulkV3(generalInfo, supplierInfo, buyerInfo, brokerInfo, settlementInfo, 4, ItemInfo, itemCount, userInfo, "")
                    dtiResult = Split(dtiMessage, ";#;")        '// 파일생성에 대한 결과를 배열로 받습니다.

                    '//---------------------------------------
                    '//	스마트빌로 전송
                    '//---------------------------------------	
                    ' 세금계산서 XML파일을 생성하지 못했을 시
                    If (Trim(dtiResult(0)) <> "0") Then
                        'response.write("파일생성에 실패 하였습니다.")
                        MsgBox("계산서번호 : " & g10.Text("tax_no", row) & "을 파일생성에 실패 하였습니다.")
                        '// 세금계산서 XML파일이 정상적으로 생성됐을 시
                    Else
                        rValue = Trim(dtiResult(2))

                        dtifilePath = objDTI.getFilePath()                  '// 생성된 파일경로를 받음
                        dtifileName = objDTI.getFileName()          '// 생성된 파일명을 받음
                        returnCode = objSBI.dtiServiceWithoutGUIV3(Main_Conv_ID, "15000", dtifilePath, dtifileName, 0, strSBID, strSBPwd, userDN, rValue, strSBID, byr_id, brk_id, "ARISSUE")
                        strErrorMsg = objSBI.getErrorMsg()      '// 오류 발생시 오류 내용을 받음
                    End If
                    '//---------------------------------------
                    '//	스마트빌로 전송 처리결과 체크
                    '//---------------------------------------	
                    If (returnCode = "30000") Then
                        g10.Text("iss_bc", row) = "FA620100"
                        g10.Text("iss_id", row) = Issue_ID
                        g10.Text("conv_id", row) = Main_Conv_ID
                        If Me.Save() Then
                            MsgBox("계산서번호 : " & g10.Text("tax_no", row) & " 전송성공")
                        End If
                    Else
                        MsgBox("계산서번호 : " & g10.Text("tax_no", row) & " 전송실패")
                        MsgBox("계산서번호 : " & g10.Text("tax_no", row) & " 오류코드 : " & returnCode)
                        MsgBox("계산서번호 : " & g10.Text("tax_no", row) & " 오류메세지 : " & strErrorMsg)
                    End If
                Catch ex As Exception
                    MsgBox("계산서번호 : " & g10.Text("tax_no", row) & " 전송실패")
                End Try
            End If
        Next
        Me.Open()
    End Sub

    Private Sub optiss_bc_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optiss_bc.SelectedIndexChanged
        iss2_bc.Text = optiss_bc.EditValue
    End Sub
#End Region


    Private Sub cmdchk_true_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchk_true.Click
        For i As Integer = 0 To g10.RowCount - 1
            If Len(g10.Text("iss_id", i)) < 1 Then
                g10.Text("chk", i) = "1"
            End If
        Next

    End Sub

    Private Sub cmdchk_fasle_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdchk_fasle.Click
        For i As Integer = 0 To g10.RowCount - 1
            g10.Text("chk", i) = "0"
        Next

    End Sub

End Class

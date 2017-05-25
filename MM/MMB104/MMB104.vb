Imports Frame7
Imports Base7
Imports Base7.Shared
Imports System.Data
Imports MySql.Data.MySqlClient

Public Class MMB104
    Dim p As New OpenParameters
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        'If find_visible2.Checked Then MenuButton_Click(MenuType.Find)
        'Me.Clear()
        Me.Open()

        'MenuButton_Click(MenuType.Find)
    End Sub
    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty
            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub
    Private Sub S_sand_Click(sender As System.Object, e As System.EventArgs) Handles S_sand.Click
        SMS()
        'save1()
        S_cont.Text = ""
        S_addr.Text = ""

    End Sub
    Public Sub save1(iint As Integer)
        G20.RowIndex = iint
        p.Add("@s_nm", G20.Text("s_nm", iint))
        p.Add("@s_mo", G20.Text("s_mo", iint))
        p.Add("@S_cont", S_cont.Text)
        p.Add("@S_addr", S_addr.Text)
        p.Add("@S_admo", S_admo.Text)
        Me.Open("mmb104_save1", p)
    End Sub

    Private Sub SMS()

        Dim param_nm As String
        Dim param_mo As Object
        'Dim param_array1(0 To G20.RowCount) As String
        'Dim param_array2(0 To G20.RowCount) As String
        'For i2 As Integer = 0 To G20.RowCount - 1
        '    G20.RowIndex = i2
        '    param_array1(i2) = G20.Text("s_nm")
        '    param_array2(i2) = G20.Text("s_mo")    
        'Next



        Dim MySQL_CS As String = "Server=192.168.2.19;" & _
            "Database=naonekp;Uid=ekpnaon;Pwd=@skdhs!;"
        Dim SQL As String
        Dim i As Integer
        Dim gparam_mo As String
        gparam_mo = ""

        Dim addr_mo As Object
        Dim gaddr_mo As String
        gaddr_mo = ""
        addr_mo = Split(S_admo.Text, "-")
        For a As Integer = 0 To UBound(addr_mo)

            gaddr_mo = gaddr_mo + addr_mo(a)

        Next a

        Dim str() As String = New String(S_cont.Text.Length) {}


        For a As Integer = 0 To S_cont.Text.Length

            str(a) = S_cont.Text
        Next a

        With G20
            For i = 0 To .RowCount - 1

                param_nm = .Text("s_nm", i)
                param_mo = Split(.Text("s_mo", i), "-")
                'Split(strTest, "-")    
                For a As Integer = 0 To UBound(param_mo)

                    gparam_mo = gparam_mo + param_mo(a)

                Next a



                SQL = "INSERT INTO uds_msg (MSG_TYPE, CMID, REQUEST_TIME, DEST_PHONE, SEND_PHONE, MSG_BODY ) VALUES ("
                SQL = SQL & " 5, date_format(now() ,  '%Y%m%d%H%i%s')+" + Format(i + 1) + " , now() , '" + gparam_mo + "', '" + gaddr_mo + "', ' " + S_cont.Text + "');"


                Dim db = New MySqlConnection(MySQL_CS)
                db.Open()
                Dim COMM = New MySqlCommand(SQL, db)
                COMM.ExecuteNonQuery()
                gparam_mo = ""
                db.Close()
                save1(i)
            Next
        End With

    End Sub

    Private Function a() As Integer
        Throw New NotImplementedException
    End Function

End Class

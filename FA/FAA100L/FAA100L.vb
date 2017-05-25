Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAA100L

    'Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    '    Me.New_Form()
    'End Sub

    Public Overrides Sub MenuButton_Click(ByVal mty As MenuType)
        Select Case mty

            Case MenuType.New
                'New_Form()

            Case MenuType.Open
                'MyBase.Open()   '기본Open()기능을 호출한다 만약 기본이 아닌기능을 
                '사용하려면 재정의 가능하다

                Me.Open_Form()

                'Case MenuType.Save

                '    Me.save_chk()

            Case Else
                MyBase.MenuButton_Click(mty)        '나머지는 기본기능에 맡긴다

        End Select

    End Sub

    Private Sub New_Form()

        sys_cd.Text = ""
        '검색필드에 “” 를  설정(검색되지않는 조건)하고 Open()
        Dim P As New OpenParameters
        P.Add("@sys_cd", " ")

        MyBase.Open("faa100l_g10", P)
        MyBase.Open("faa100l_g20", P)
        Dim P2 As New OpenParameters
        P.Add("@mng_no", " ")
        MyBase.Open("faa100l_g30", P2)

        'g10.BestFitColumns()
        'g20.BestFitColumns()
        'g30.BestFitColumns()

    End Sub

    Public Sub Open_Form()
        Select Case XtraTabControl1.SelectedTabPageIndex
            Case 0
                Me.Open("faa100l_g10")
                'g10.BestFitColumns()
            Case 1
                Me.Open("faa100l_g20")
                'g20.BestFitColumns()
            Case 2
                Me.Open("faa100l_g30")
                'g30.BestFitColumns()
        End Select
    End Sub

    'Public Sub save_chk()

    '    If XtraTabControl1.SelectedTabPageIndex = 0 Then

    '        Me.Save("faa100l_g10")

    '    End If

    '    If XtraTabControl1.SelectedTabPageIndex = 1 Then

    '        Me.Save("faa100l_g20")

    '    End If

    '    If XtraTabControl1.SelectedTabPageIndex = 2 Then

    '        Me.Save("faa100l_g30")

    '    End If

    'End Sub


End Class

Imports Frame7
Imports Base7
Imports Base7.Shared

Public Class FAY900
    Private Sub Me_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        doc_no.CodeNo = "FAY900"
        doc_no.CodeDateField = std_mon
        Me.Open()
    End Sub

    Public Overrides Sub MenuButton_Click(ByVal ty As MenuType)

        Select Case ty
            Case MenuType.Save
                If Me.CheckBeforeSave() Then
                    If Me.Save() Then
                        Me.Open()
                    End If
                End If
                'Case MenuType.New
                '    Me.New_Form()
            Case MenuType.Print
            Case Else
                MyBase.MenuButton_Click(ty)
        End Select

    End Sub

   
#Region " Function "

    Private Sub _Set_Total()
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
        diff.Text = CDec(tot1 - tot2)
    End Sub

    Private Function CheckBeforeSave() As Boolean

        g20.DeleteBlankRow()
        If g20.RowCount = 0 Then
            MessageInfo("전표 행이 없습니다.")
            Return False
        End If

        Me._Set_Total()

        If (diff.ToDec <> 0) Then
            MessageInfo("차대변이 일치 하지 않습니다.")
            Return False
        End If

        If Not Me.WorkSet("fay900_f10").CheckCodeFields Then
            Return False
        End If
        Return True

    End Function

#End Region

End Class

Public Class ImageView
    Private H_org As Long, W_org As Long
    Public Sub LoadPicture(ByVal Img As Image, ByVal title As String)

        Try
            'TrackBar1.Value = (Me.Opacity) * 100

            TrackBar1.Minimum = 100
            TrackBar1.Maximum = 200
            TrackBar1.Value = 100

            If PictureBox1.Height > Img.Height Then PictureBox1.Height = Img.Height
            If PictureBox1.Width > Img.Width Then PictureBox1.Width = Img.Width

            H_org = PictureBox1.Height
            W_org = PictureBox1.Width

            PictureBox1.Image = Img 'Image.FromStream(Img)
            PictureBox1.SizeMode = PictureBoxSizeMode.StretchImage

            'Me.Width = PictureBox1.Width + 4
            'Me.Height = PictureBox1.Height + 100
            'PictureBox1.Left = 2
            'PictureBox1.Top = 2

            TrackBar1.Width = Me.Width
            TrackBar1.Top = Me.Height - 42

            Me.Text += " - " + title

        Catch ex As Exception
            Me.Close()
        End Try
    End Sub

    Private Sub Me_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Me.Dispose()
    End Sub

    Private Sub PictureBox1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.DoubleClick
        Me.Dispose()
    End Sub

    Private Sub PictureBox1_SizeChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles PictureBox1.SizeChanged
        'Me.Width = PictureBox1.Width + 4
        'Me.Height = PictureBox1.Height + 100
        'PictureBox1.Left = 2
        'PictureBox1.Top = 2
        'TrackBar1.Width = Me.Width
        'TrackBar1.Top = Me.Height - 42
    End Sub

    Private Sub trackBar1_Scroll(ByVal sender As Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        Try
            Dim Rt As Double = TrackBar1.Value * 0.01
            Dim W2 As Double = W_org * Rt
            Dim H2 As Double = H_org * Rt

            PictureBox1.Width = W2
            PictureBox1.Height = H2

            PictureBox1.Left = 0
            PictureBox1.Top = 0

            'Me.Opacity = Opac
            'Dim Opac As Double = TrackBar1.Value * 0.01
            'Me.Opacity = Opac
        Catch ex As Exception

        End Try

    End Sub

    Dim saveX As Integer, saveY As Integer
    Dim isMove As Boolean

    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        saveX = e.X
        saveY = e.Y
        isMove = True
        Windows.Forms.Cursor.Current = Cursors.Hand
    End Sub

    Private Sub PictureBox1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseMove
        If isMove = True Then
            PictureBox1.Location = New Point((e.X - saveX + PictureBox1.Left), (e.Y - saveY + PictureBox1.Top))
            '    'PictureBox1.Refresh()
        End If
    End Sub

    Private Sub PictureBox1_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseUp
        isMove = False
        Windows.Forms.Cursor.Current = Cursors.Default
    End Sub


End Class
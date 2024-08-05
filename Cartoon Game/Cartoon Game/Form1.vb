Imports System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar
Imports System.Xml.Schema

Public Class Form1
    Dim score As Integer = 0
    Private Source As PictureBox = Nothing
    Private P As PictureBox() = {pbD0, pbD1, pbD2, pbD3, pbD4, pbD5, pbD6, pbD7, pbD8, pbD9}
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


        Dim P As PictureBox() = {pbD0, pbD1, pbD2, pbD3, pbD4, pbD5, pbD6, pbD7, pbD8, pbD9}
        For Each Pics As PictureBox In P
            Pics.AllowDrop = True
            AddHandler Pics.MouseMove, AddressOf PBs_MouseMove
            AddHandler Pics.DragEnter, AddressOf PBs_DragEnter
            AddHandler Pics.DragDrop, AddressOf PBs_DragDrop
            AddHandler Pics.DragOver, AddressOf PBs_DragOver
        Next

        Dim p1 As PictureBox() = {PB1, PB2, PB3, PB4, PB5, PB6, PB7, PB8, PB9, PB10}
        For Each PB As PictureBox In p1
            AddHandler PB.MouseMove, AddressOf PBs_MouseMove
            AddHandler PB.MouseMove, AddressOf PBs_MouseMove
            AddHandler PB.DragEnter, AddressOf PBs_DragEnter
            AddHandler PB.DragDrop, AddressOf PBs_DragDrop
            AddHandler PB.DragOver, AddressOf PBs_DragOver
        Next
        Form2.Hide()

    End Sub


    Private Sub PBs_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        Dim PB As PictureBox = DirectCast(sender, PictureBox)
        If Not IsNothing(PB.Image) AndAlso e.Button = Windows.Forms.MouseButtons.Left Then
            Source = PB
            PB.DoDragDrop(PB.Image, DragDropEffects.Copy Or DragDropEffects.Move)
        End If
    End Sub

    Private Sub PBs_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub

    Private Sub PBs_DragOver(sender As Object, e As DragEventArgs)
        If e.Data.GetDataPresent(DataFormats.Bitmap) Then
            If My.Computer.Keyboard.CtrlKeyDown Then
                e.Effect = DragDropEffects.Copy
            Else
                e.Effect = DragDropEffects.Move
            End If
        Else
            e.Effect = DragDropEffects.None
        End If
    End Sub


    Private Sub PBs_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs)
        Dim PB As PictureBox = DirectCast(sender, PictureBox)
        Dim tmpImage As Image = PB.Image ' store the current image
        PB.Image = e.Data.GetData(DataFormats.Bitmap) ' change it to the dropped image
        If e.Effect = DragDropEffects.Move Then
            If Not (PB Is Source) Then
                Source.Image = tmpImage ' put the stored image in the source picturebox (swap)
            End If
        End If



        Dim picturebox1, picturebox2, picturebox3, picturebox4, picturebox5,
            picturebox6, picturebox7, picturebox8, picturebox9, picturebox10 As Image

        picturebox1 = My.Resources.Chotta_Bheem
        picturebox2 = My.Resources.Dora
        picturebox3 = My.Resources.Little_Singham
        picturebox4 = My.Resources.Mickey_Mouse
        picturebox5 = My.Resources.Motu
        picturebox6 = My.Resources.Mr_Bean
        picturebox7 = My.Resources.Ninja_Hattori
        picturebox8 = My.Resources.Oggy
        picturebox9 = My.Resources.Shinchan
        picturebox10 = My.Resources.Tun_Tun_Aunty

        Dim pbox1, pbox2, pbox3, pbox4, pbox5, pbox6, pbox7, pbox8, pbox9, pbox10 As Image

        pbox1 = My.Resources.Bheemimg
        pbox2 = My.Resources.Doraimg
        pbox3 = My.Resources.lilSingamimg
        pbox4 = My.Resources.MMimg
        pbox5 = My.Resources.Motuimg
        pbox6 = My.Resources.Beanimg
        pbox7 = My.Resources.Hattoriimg
        pbox8 = My.Resources.Oggyimg
        pbox9 = My.Resources.Shinchanimg
        pbox10 = My.Resources.tun_tunimg

        If ImagesAreTheSame(pbD0.Image, picturebox1) Then

            pbD0.Image = pbox1
            score += 1
            RemoveHandler Me.pbD0.MouseMove, AddressOf PBs_MouseMove
        End If


        If ImagesAreTheSame(pbD1.Image, picturebox2) Then

            pbD1.Image = pbox2
            score += 1
            RemoveHandler Me.pbD1.MouseMove, AddressOf PBs_MouseMove
        End If

        If ImagesAreTheSame(pbD2.Image, picturebox3) Then

            pbD2.Image = pbox3
            score += 1
            RemoveHandler Me.pbD2.MouseMove, AddressOf PBs_MouseMove
        End If


        If ImagesAreTheSame(pbD3.Image, picturebox4) Then

            pbD3.Image = pbox4
            score += 1
            RemoveHandler Me.pbD3.MouseMove, AddressOf PBs_MouseMove
        End If

        If ImagesAreTheSame(pbD4.Image, picturebox5) Then

            pbD4.Image = pbox5
            score += 1
            RemoveHandler Me.pbD4.MouseMove, AddressOf PBs_MouseMove
        End If
        If ImagesAreTheSame(pbD5.Image, picturebox6) Then

            pbD5.Image = pbox6
            score += 1
            RemoveHandler Me.pbD5.MouseMove, AddressOf PBs_MouseMove
        End If
        If ImagesAreTheSame(pbD6.Image, picturebox7) Then

            pbD6.Image = pbox7
            score += 1
            RemoveHandler Me.pbD6.MouseMove, AddressOf PBs_MouseMove
        End If
        If ImagesAreTheSame(pbD7.Image, picturebox8) Then

            pbD7.Image = pbox8
            score += 1
            RemoveHandler Me.pbD7.MouseMove, AddressOf PBs_MouseMove
        End If
        If ImagesAreTheSame(pbD8.Image, picturebox9) Then

            pbD8.Image = pbox9
            score += 1
            RemoveHandler Me.pbD8.MouseMove, AddressOf PBs_MouseMove
        End If
        If ImagesAreTheSame(pbD9.Image, picturebox10) Then
            pbD9.Image = pbox10
            score += 1
            RemoveHandler Me.pbD9.MouseMove, AddressOf PBs_MouseMove
        End If

    End Sub
    Private Sub btnScore_Click(sender As Object, e As EventArgs) Handles btnScore.Click
        lblScore.Text = "Score " & score
        If score = 10 Then
            MsgBox("Congratulations you won!!")
            Me.Close()
        End If
    End Sub

    'Size check ,Form1 close, Restart button
    Private Function ImagesAreTheSame(bmp1 As Bitmap, bmp2 As Bitmap) As Boolean

        ' basic size check
        If bmp1 Is Nothing Then
            Return False
        Else
            If Not bmp1.Size.Equals(bmp2.Size) Then
                ' not the same size
                Return False
            End If


        End If

        ' pixel check
        Dim x, y As Long

        For x = 0 To bmp1.Width - 1
            For y = 0 To bmp1.Height - 1
                If bmp1.GetPixel(x, y) <> bmp2.GetPixel(x, y) Then
                    ' a mismatch has occured
                    Return False
                End If
            Next
        Next

        Return True ' if it gets here then all is okay


    End Function







    Private Sub btnRestart_Click(sender As Object, e As EventArgs) Handles btnRestart.Click
        Me.Close()
    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
    End Sub


End Class
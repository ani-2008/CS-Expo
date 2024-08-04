Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim Score As Integer = 0
        Dim a As String = "a "
        Dim A1, A2, A3, A4, A5, A6, A7, A8 As String
        A1 = TextBox1.Text & TextBox2.Text & TextBox4.Text &
            TextBox3.Text & TextBox8.Text & TextBox7.Text & TextBox6.Text

        A2 = TextBox20.Text & TextBox19.Text & TextBox18.Text & TextBox17.Text &
            TextBox16.Text & TextBox15.Text & TextBox14.Text & TextBox13.Text &
            TextBox11.Text & TextBox10.Text & TextBox9.Text & TextBox30.Text & TextBox29.Text

        A3 = TextBox27.Text & TextBox26.Text & TextBox61.Text & TextBox24.Text &
            TextBox23.Text & TextBox22.Text & TextBox21.Text & TextBox34.Text &
            TextBox33.Text & TextBox32.Text

        A4 = TextBox58.Text & TextBox25.Text & TextBox56.Text & TextBox55.Text &
            TextBox54.Text & TextBox53.Text & TextBox52.Text

        A5 = TextBox35.Text & TextBox28.Text & TextBox45.Text & TextBox51.Text &
            TextBox50.Text & TextBox49.Text & TextBox48.Text & TextBox47.Text &
            TextBox46.Text

        A6 = TextBox72.Text & TextBox73.Text & TextBox70.Text & TextBox67.Text &
            TextBox66.Text & TextBox75.Text & TextBox74.Text & TextBox77.Text &
            TextBox76.Text

        A7 = TextBox65.Text & TextBox83.Text & TextBox99.Text & TextBox98.Text &
            TextBox97.Text & TextBox96.Text & TextBox95.Text & TextBox94.Text &
            TextBox93.Text & TextBox101.Text & TextBox100.Text & TextBox102.Text & TextBox103.Text

        A8 = TextBox91.Text & TextBox90.Text & TextBox89.Text & TextBox88.Text &
            TextBox87.Text & TextBox81.Text
        Dim D9, D10, D11, D12, D13, D14, D15, D16 As String

        D9 = TextBox38.Text & TextBox37.Text & TextBox36.Text
        D10 = TextBox41.Text & TextBox40.Text & TextBox39.Text & TextBox44.Text &
            TextBox43.Text & TextBox42.Text
        D11 = TextBox5.Text & TextBox34.Text & TextBox45.Text
        D12 = TextBox61.Text & TextBox60.Text & TextBox25.Text & TextBox59.Text &
            TextBox57.Text
        D13 = TextBox56.Text & TextBox62.Text & TextBox63.Text & TextBox64.Text &
            TextBox65.Text & TextBox68.Text
        D14 = TextBox86.Text & TextBox85.Text & TextBox84.Text & TextBox83.Text &
            TextBox82.Text & TextBox81.Text
        D15 = TextBox104.Text & TextBox95.Text & TextBox106.Text & TextBox105.Text
        D16 = TextBox48.Text & TextBox71.Text & TextBox70.Text & TextBox69.Text
        If A1.ToLower() = "windows" Then
            Score += 1

        End If
        If A2.ToLower() = "wordprocessor" Then
            Score += 1

        End If
        If A3.ToLower() = "javascript" Then
            Score += 1

        End If
        If A4.ToLower() = "browser" Then
            Score += 1

        End If
        If A5.ToLower() = "antivirus" Then
            Score += 1

        End If
        If A6.ToLower() = "debugging" Then
            Score += 1

        End If
        If A7.ToLower() = "collaborative" Then
            Score += 1

        End If
        If A8.ToLower() = "chrome" Then
            Score += 1


        End If
        If D9.ToLower() = "pdf" Then
            Score += 1

        End If
        If D10.ToLower() = "github" Then
            Score += 1

        End If
        If D11.ToLower() = "git" Then
            Score += 1

        End If
        If D12.ToLower() = "virus" Then
            Score += 1

        End If
        If D13.ToLower() = "office" Then
            Score += 1

        End If
        If D14.ToLower() = "vscode" Then
            Score += 1

        End If
        If D15.ToLower() = "code" Then
            Score += 1

        End If
        If D16.ToLower() = "ruby" Then
            Score += 1

        End If
        MsgBox("Total Points " & Score)

    End Sub



    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Form2.Hide()


    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form2.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub btnHelp_Click(sender As Object, e As EventArgs) Handles btnHelp.Click
        MsgBox("This is cross word puzzle
                You will be having 16 clues
                clues numbered from 1 to 8 are of Across
                clues numbered from 9 to 16 are of Down
                For Each correct answer you would recieve 1 points
                There will be a hint(number of words) for selected clues")
    End Sub


End Class

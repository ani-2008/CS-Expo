Public Class Form2


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim stname As String = TextBox1.Text
        MsgBox("Welcome " & stname)
        Form1.Show()
    End Sub


End Class
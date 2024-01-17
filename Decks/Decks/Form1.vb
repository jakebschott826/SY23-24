Public Class Form1
    Dim records(50) As String
    Dim count As Integer
    Dim current As Integer
    Private Sub NewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NewToolStripMenuItem.Click
        field1.Text = ""
        field2.Text = ""
        field3.Text = ""
        field4.Text = ""
        field5.Text = ""
        PictureBox1.Image = Nothing
    End Sub
    Private Sub SaveToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveToolStripMenuItem.Click
        Dim r As String
        r += field1.Text
        r += "|"
        r += field2.Text
        r += "|"
        r += field3.Text
        r += "|"
        r += field4.Text
        r += "|"
        r += field5.Text
        r += "|"
        r += PictureBox1.ImageLocation
        records(current) = r
        savetofile()
    End Sub
    Sub savetofile()
        Dim outfile As New IO.StreamWriter("Data.txt")
        For index = 0 To count - 1
            outfile.WriteLine(records(index))
        Next
        outfile.Close()
    End Sub
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        PictureBox1.Load(OpenFileDialog1.FileName)
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IO.File.Exists("Data.txt") Then
            Dim infile As New IO.StreamReader("Data.txt")
            While (Not infile.EndOfStream)
                records(count) = infile.ReadLine
                count = count + 1
                showrecord(0)
            End While
            infile.Close()
        End If
    End Sub
    Public Sub showrecord(index As Integer)
        Dim fields() As String
        If records(index) <> Nothing Then
            fields = records(index).Split("|")
            field1.Text = fields(0)
            field2.Text = fields(1)
            field3.Text = fields(2)
            field4.Text = fields(3)
            field5.Text = fields(4)
            If IO.File.Exists(fields(5)) Then
                PictureBox1.Load(fields(5))
            End If
        End If
    End Sub

    Private Sub firstbutton_Click(sender As Object, e As EventArgs) Handles firstbutton.Click
        current = 0
        showrecord(current)

    End Sub

    Private Sub previousbutton_Click(sender As Object, e As EventArgs) Handles previousbutton.Click
        If current > 0 Then
            current = current - 1
        End If
        showrecord(current)
    End Sub

    Private Sub nextbutton_Click(sender As Object, e As EventArgs) Handles nextbutton.Click
        If current < count - 1 Then
            current = current + 1
        End If
        showrecord(current)
    End Sub

    Private Sub lastbutton_Click(sender As Object, e As EventArgs) Handles lastbutton.Click
        current = count - 1
        showrecord(current)
    End Sub
End Class

Imports System.Text.RegularExpressions

Public Class Form1

    Public Value As String

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim Info = MessageBox.Show("Editor for mbal" & vbNewLine & "Create new *.mbal file, save it, run mbal by hand", "Info [mbal editor]")
    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged
        'If RichTextBox1.Text.Contains = "PRINT" Then
        'RichTextBox1.ForeColor = Color.Purple
        'End If

        'Dim tokens As String = "(regex|dim|object|new|string|public|integer|end|auto|double|int|struct|break|else|long|switch|case|enum|register|typedef|char|extern|return|union|const|float|short|unsigned|continue|for|signed|void|default|goto|sizeof|volatile|do|if|static|while|1|2|3|4|5|6|7|8|9|my)"
        Dim myToken As String = "(NULL|FALSE|TRUE|MATH_PI|PRINT|PRINT_RET|INPUT|INPUT_INT|CLEAR|CLS|IS_NUM|IS_STR|IS_LIST|IS_FUN|APPEND|POP|EXTEND|LEN|RUN|VAR|IF|ELSE|THEN|FOR|END|FUN|RETURN)"
        Dim rex As New Regex(myToken)
        Dim mc As MatchCollection = rex.Matches(RichTextBox1.Text)
        Dim StartCursorPosition As Integer = RichTextBox1.SelectionStart
        For Each m As Match In mc
            Dim startIndex As Integer = m.Index
            Dim StopIndex As Integer = m.Length
            RichTextBox1.[Select](startIndex, StopIndex)
            RichTextBox1.SelectionColor = Color.Blue
            RichTextBox1.SelectionStart = StartCursorPosition

            RichTextBox1.SelectionColor = Color.Black
        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Dim proc As Process = New Process

        'proc.StartInfo.FileName = PythonInstall.Text
        'proc.StartInfo.Arguments = mbal.Text

        'proc.StartInfo.UseShellExecute = False
        'proc.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        'proc.StartInfo.CreateNoWindow = False
        'proc.StartInfo.RedirectStandardOutput = True

        'proc.Start()

        'AddHandler proc.OutputDataReceived, AddressOf process_Output_DataReceived

        'proc.BeginOutputReadLine()
        ''proc.WaitForExit()

        'TextBox1.Text = Value
    End Sub

    Private Sub process_Output_DataReceived(sender As Object, e As DataReceivedEventArgs)
        On Error Resume Next
        If e.Data = "" Then

        Else
            Value = e.Data
        End If
    End Sub

    Private Sub OpenFile_Click(sender As Object, e As EventArgs) Handles OpenFile.Click
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            RichTextBox1.Text = My.Computer.FileSystem.ReadAllText(OpenFileDialog1.FileName)
        End If
    End Sub

    Private Sub SaveFile_Click(sender As Object, e As EventArgs) Handles SaveFile.Click
        If SaveFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(SaveFileDialog1.FileName, RichTextBox1.Text, False)
        End If
    End Sub
End Class
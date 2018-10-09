Imports System.IO

Public Class frmEdit

    Private Sub Edit_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        If IO.File.Exists("C:\Voc_Post\PrimaryFile.txt") Then

            Dim ourStreamReader0 As StreamReader
            ourStreamReader0 = IO.File.OpenText("C:\Voc_Post\PrimaryFile.txt")

            txtStopWord.Text = ourStreamReader0.ReadLine
            txtSuffix.Text = ourStreamReader0.ReadLine
            txtPrefix.Text = ourStreamReader0.ReadLine

            'When finished reading from the file, close the StreamReader
            ourStreamReader0.Close()
        Else

            MessageBox.Show("እነዚህን ፋይሎች ሶፍትዌሩን ከጫኑበት ቦታ ያገኙዋቸዋል። " & vbCrLf & "ለምሳሌ: C:\Program Files\Biniam, Girma, Muzeyen and Negasi\Amharic Information Storage and Retrieval System\ ", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If

    End Sub

    Private Sub btnSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSave.Click

        Dim primaryFiles As String

        primaryFiles = "C:\Voc_Post\PrimaryFile.txt"

        'Declare a StreamReader object and read from the file
        Dim primaryStreamWriter As StreamWriter

        Dim OutputToFile As String = String.Empty

        primaryStreamWriter = IO.File.CreateText(primaryFiles)

        OutputToFile = OutputToFile & txtStopWord.Text & vbNewLine
        OutputToFile = OutputToFile & txtSuffix.Text & vbNewLine
        OutputToFile = OutputToFile & txtPrefix.Text & vbNewLine

        'Finally, write the output to the new file
        primaryStreamWriter.WriteLine(OutputToFile.Trim)

        primaryStreamWriter.Close()

        MessageBox.Show("ስራው ተጠናቁአል። ፋይሉ 'PrimaryFile' ተብሎ ተቀምጡአል።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Me.Close()

    End Sub

    Private Sub btnBrowseStopWord_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseStopWord.Click

        With OpenFileDialog1
            .Filter = "Text Files (.txt) | *.txt"
        End With

        'Show the open dialog and if the user clicks the open button load the file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Save the file name in the variable called "filename1"
            txtStopWord.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub btnBrowseSuffix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowseSuffix.Click

        With OpenFileDialog1
            .Filter = "Text Files (.txt) | *.txt"
        End With

        'Show the open dialog and if the user clicks the open button load the file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Save the file name in the variable called "filename1"
            txtSuffix.Text = OpenFileDialog1.FileName

        End If

    End Sub

    Private Sub btnBrowsePrefix_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowsePrefix.Click

        With OpenFileDialog1
            .Filter = "Text Files (.txt) | *.txt"
        End With

        'Show the open dialog and if the user clicks the open button load the file
        If OpenFileDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then

            'Save the file name in the variable called "filename1"
            txtPrefix.Text = OpenFileDialog1.FileName

        End If

    End Sub

End Class
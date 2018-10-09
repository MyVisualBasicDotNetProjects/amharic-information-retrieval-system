'Programming Assignment
'Select the language that interest you and design an IR system for document collection written in that language.
'Form a group of not more than three members

'Construct indexing structure
'	Given text document collection generate index terms and organize them using inverted file indexing, 
'   include TF, DF & CF for each index term and position/location information of terms in each document. 
'	(due date: June 25, 2011)

'Develop Vector space retrieval model 
'   Using Vector space model generate any two queries (with two or more words each) and retrieve relevant
'   documents in ranking order. 
'	(due date: July 04, 2011)


' '' '' '' '' '' '' '' ''               1 ቢኒያም አስናቀ                         GSR/0809/03
' '' '' '' '' '' '' '' ''               2 ግርማ አወቀ                          GSR/0816/03
' '' '' '' '' '' '' '' ''               3 ሙዘይን ከድር                         GSR/0823/03
' '' '' '' '' '' '' '' ''               4 ነጋሲ ገብረእግዚአብሔር                   GSR/0303/02

' '' '' '' '' '' '' '' ''                                           ለዶክተር ሚሊዮን መሸሻ
' '' '' '' '' '' '' '' ''                                            ሰኔ22 ቀን 2003 ዓም

Imports System.IO
Imports System.Configuration

Public Class frmIndexing

#Region "Global Variables are declared here."

    'Declare a StreamReader object and read from the file
    Public Shared myStreamReader As StreamReader

    'Declare an object to store the whole content of the file and 
    'Save the whole content of the file in the variable called "content"
    Public Shared item As Object

    'Declare a string variable to store the content that is read from the file
    Public Shared content As String = String.Empty

    'Private stopListItem As Object
    Public Shared stopList As String
    Public Shared stopWordArray As List(Of String)
    'Private stopWordArray As String()

    Public Shared suffixList As String
    Public Shared suffixListArray As List(Of String)

    Public Shared prefixList As String
    Public Shared prefixListArray As List(Of String)

    Public Shared stringArray As List(Of String)
    Public Shared myNewStringArray As List(Of String)

    Private folderName As String

    Private newFileName As String

    Private word As String

    ' Stores list of filenames in the selected folder
    Public Shared allFiles As New List(Of String)
    Private filename As String
    Private fileContent As String

    Public Shared sadisFidel As New Dictionary(Of String, String)

#End Region

    Public Structure termDocumentName
        Dim term As String
        Dim docName As String
    End Structure

    Private ourVocabularyList As New List(Of termDocumentName)

    ' We created our own structure to store the term with the document name and frequency
    Public Structure structureVocabulary

        Dim term As String
        Dim collectionFrequency As Integer
        Dim documentFrequency As Integer

    End Structure

    Public Structure structurePosting

        Dim termFrequency As List(Of String)
        ' Dim location As List(Of String)

    End Structure

    Public Shared objVocabulary As New List(Of structureVocabulary)
    Public Shared objPosting As New List(Of structurePosting)

    Public Shared voc As New structureVocabulary
    Public Shared post As New structurePosting

    Public Shared normalizingWords As New Dictionary(Of String, String)

    Public Shared Sub InitalizeNormalizer()

        Try
            'normalizingWords.Clear()

            With normalizingWords
                .Add("ዐ", "አ")
                .Add("ዑ", "ኡ")
                .Add("ዒ", "ኢ")
                .Add("ዓ", "ኣ")
                .Add("ዔ", "ኤ")
                .Add("ዕ", "እ")
                .Add("ዖ", "ኦ")

                .Add("ጸ", "ፀ")
                .Add("ጹ", "ፁ")
                .Add("ጺ", "ፂ")
                .Add("ጻ", "ፃ")
                .Add("ጼ", "ፄ")
                .Add("ጽ", "ፅ")
                .Add("ጾ", "ፆ")

                .Add("ሠ", "ሰ")
                .Add("ሡ", "ሱ")
                .Add("ሢ", "ሲ")
                .Add("ሣ", "ሳ")
                .Add("ሤ", "ሴ")
                .Add("ሥ", "ስ")
                .Add("ሦ", "ሶ")

                .Add("ሐ", "ሀ")
                .Add("ሑ", "ሁ")
                .Add("ሒ", "ሂ")
                .Add("ሓ", "ሃ")
                .Add("ሔ", "ሄ")
                .Add("ሕ", "ህ")
                .Add("ሖ", "ሆ")

                .Add("ኀ", "ሀ")
                .Add("ኁ", "ሁ")
                .Add("ኂ", "ሂ")
                .Add("ኃ", "ሃ")
                .Add("ኄ", "ሄ")
                .Add("ኅ", "ህ")
                .Add("ኆ", "ሆ")

                .Add("ሃ", "ሀ")
                .Add("ዉ", "ው")

                .Add("ዓ.ም", "አመተ ምህረት")
                .Add("አአዩ", "አዲስ አበባ ዩኒቨርሲቲ")
                .Add("አ.አ", "አዲስ አበባ")
                .Add("ክ.ከ", "ክፍለ ከተማ")

                .Add("አቢሲኒያ", "ኢትዮጵያ")
                .Add("መኪና", "ተሽከርካሪ")
                .Add("አስተማሪ", "መምህር")

            End With

        Catch ex As Exception
            Exit Sub
        End Try
        
    End Sub

    Public Shared Sub InitializeSadisFidel()

        Try
            With sadisFidel
                .Add("ኮ", "ክ")
                .Add("ቶ", "ት")
                .Add("ኞ", "ኛ")
                .Add("ዎ", "ው")
                .Add("ሮ", "ር")
                .Add("ሎ", "ል")
                .Add("ዶ", "ድ")
                .Add("ሆ", "ህ")
                .Add("ዮ", "ይ")
                .Add("ቆ", "ቅ")
                .Add("ሞ", "ም")
                .Add("ሶ", "ስ")
                .Add("ቦ", "ብ")
                .Add("ቾ", "ች")
                .Add("ኖ", "ን")
                .Add("ኦ", "እ")
                .Add("ዞ", "ዝ")
                .Add("ጦ", "ጥ")

            End With
        Catch ex As Exception
            Exit Sub
        End Try

    End Sub

    Public Shared Sub Initialization()

        Dim sw As String = String.Empty
        Dim sf As String = String.Empty
        Dim pf As String = String.Empty

        Dim ourStreamReader0 As StreamReader
        Try
            ourStreamReader0 = IO.File.OpenText("C:\Voc_Post\PrimaryFile.txt")
            sw = ourStreamReader0.ReadLine
            sf = ourStreamReader0.ReadLine
            pf = ourStreamReader0.ReadLine

            'When finished reading from the file, close the StreamReader
            ourStreamReader0.Close()
        Catch ex As Exception
            MessageBox.Show("ይቅርታ: የ'PrimaryFile' ፋይል አልተገኘም።" & vbCrLf & "እባክዎ ድጋሚ ይምረጡ።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End
        End Try

        stopList = ReadFromFile(sw)
        If stopList.Equals("No") Then

            MessageBox.Show("ይቅርታ: የ'stoplist' ፋይል አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        suffixList = ReadFromFile(sf)
        If suffixList.Equals("No") Then

            MessageBox.Show("ይቅርታ: የ'suffix' ፋይል አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        prefixList = ReadFromFile(pf)
        If prefixList.Equals("No") Then

            MessageBox.Show("ይቅርታ: የ'prefix' ፋይል አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

        Call InitalizeNormalizer()
        Call InitializeSadisFidel()

        'Call stopListReader(Application.StartupPath & "\stoplist.txt")

        'just for trying
        'folderName = "C:\Users\Biniam"

        'txtFolderSelected.Text = folderName

        'allFiles = IO.Directory.GetFiles(folderName, "*.txt").ToList

        'btnPerformIRS.Enabled = True

    End Sub

    Private Sub btnBrowse_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBrowse.Click

        'Show the open dialog and if the user clicks the open button load the file
        If FolderBrowserDialog1.ShowDialog = Windows.Forms.DialogResult.OK Then
            Try
                'Save the file name in the variable called "filename1"
                folderName = FolderBrowserDialog1.SelectedPath
                txtFolderSelected.Text = folderName

                allFiles = IO.Directory.GetFiles(folderName, "*.txt").ToList

                Call SettingsWriter()

                '  btnPerformIRS.Enabled = True

            Catch ex As Exception               'FileNotFoundException
                'If there is any exception related to opening file, display an exception (error) message to the user
                MessageBox.Show("የመረጡት ፎልደር አልተገኘም::", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If

    End Sub

    Private Sub SettingsWriter()

        Dim settingsFileName As String

        If IsNothing(allFiles) = False And allFiles.Count <> 0 Then

            If IO.Directory.Exists("C:\Voc_Post") = False Then

                IO.Directory.CreateDirectory("C:\Voc_Post")

            End If

            settingsFileName = "C:\Voc_Post\Settings.txt"

            'Declare a StreamReader object and read from the file
            Dim settingStreamWriter As StreamWriter

            'Save the whole content of the structure in the variable to be saved on a file
            Dim settingOutputToFile As String = String.Empty

            settingStreamWriter = IO.File.CreateText(settingsFileName)

            settingOutputToFile = settingOutputToFile & allFiles.Count & vbNewLine
            settingOutputToFile = settingOutputToFile & folderName & vbNewLine

            'Finally, write the output to the new file
            settingStreamWriter.WriteLine(settingOutputToFile.Trim)

            settingStreamWriter.Close()

        End If

    End Sub

    Private Sub btnPerformIRS_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnPerformIRS.Click

        If allFiles.Count <> 0 And IsNothing(allFiles) = False Then

            Call Initialization()

            ' To iterate through all the .txt files in the folder
            For k = 0 To allFiles.Count - 1

                filename = allFiles(k)

                If filename.Equals(String.Empty) = False Then

                    fileContent = ReadFromFile(filename)
                    If fileContent.Equals("No") Then

                        MessageBox.Show("ይቅርታ: ፋይሉ አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    ElseIf fileContent.Equals("") Then

                        MessageBox.Show("ይቅርታ ፋይል " & filename & " ሊነበብ አይችልም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

                    Else

                        Call punctuationRemover(fileContent)

                        Call Normalizer(fileContent)

                        stopWordArray = tokenizer(stopList.Trim)
                        suffixListArray = tokenizer(suffixList.Trim)
                        prefixListArray = tokenizer(prefixList.Trim)

                        stringArray = tokenizer(fileContent)

                        myNewStringArray = stopWordRemover(stringArray)

                        Call Stemmer(myNewStringArray)

                        assign(myNewStringArray, filename)

                    End If

                End If
            Next

            Call TF_DF_Calculator(ourVocabularyList)

            Call WriteToFile(objVocabulary, objPosting)

        Else

            MessageBox.Show("እባክዎ ፋይሎቹ የሚገኙነትን ፎልደር ይምረጡ።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub assign(ByVal currentArray As List(Of String), ByVal documentName As String)

        Dim ca As Integer       'ca - iterates through currentArray        
        Dim data As termDocumentName

        '  ourVocabularyList = New List(Of termDocumentName)

        For ca = 0 To currentArray.Count - 1

            data.term = currentArray(ca)
            data.docName = documentName

            ourVocabularyList.Add(data)
            'MsgBox("success")
        Next

        ' Prints the content of 'myVocabulary'
        'For Each voc In ourVocabularyList
        'MsgBox("Final " & vbCrLf & voc.term & " " & voc.docName)
        'Next

    End Sub

    Private Sub TF_DF_Calculator(ByVal myArray As List(Of termDocumentName))

        Dim a, b As Integer
        Dim cf, df As Integer

        Dim valueOfTF As Integer
        Dim valueOfDOC As String

        Dim tf As New List(Of String)
        Dim doc As New List(Of String)                  '= String.Empty

        Dim loc As New List(Of Integer)

        Dim checkedOut As New List(Of String)

        Dim n As Integer             ' n = iterates through the files        ' m = iterates through the vocabulary list
        Dim dn As String = String.Empty

        For a = 0 To myArray.Count - 1      'To pick one word from the list

            tf.Clear()
            doc.Clear()
            cf = 0

            If IsNothing(checkedOut) = False And checkedOut.Contains(myArray(a).term) = False Then
                checkedOut.Add(myArray(a).term)

                For n = 0 To allFiles.Count - 1
                    dn = allFiles(n)

                    valueOfTF = 0
                    valueOfDOC = String.Empty

                    For b = 0 To myArray.Count - 1  'To iterate through the list to check for a match
                        If dn.Equals(myArray(b).docName) Then

                            'TF -> counts the number of occurence of a term in one specific document.
                            If myArray(a).term.Trim.Equals(myArray(b).term.Trim) Then
                                'And myArray(a).docName.Trim.Equals(myArray(b).docName.Trim)
                                valueOfTF += 1
                                valueOfDOC = myArray(b).docName

                            End If
                        End If
                    Next 'b

                    ' Save the location of the term
                    If valueOfTF > 0 Then
                        loc = LocationOfTerm(myArray(a).term, valueOfDOC)
                    End If

                    Dim locationOfTermInOneDocument As String = String.Empty

                    For Each d In loc

                        locationOfTermInOneDocument &= d.ToString & ", "

                    Next

                    locationOfTermInOneDocument = locationOfTermInOneDocument.Substring(0, locationOfTermInOneDocument.Count - 2)

                    If valueOfDOC <> "" Then
                        tf.Add("{" & valueOfDOC.Substring(folderName.Length + 1) & "_*_" & valueOfTF & "~" & locationOfTermInOneDocument & "}")
                    End If

                    cf += valueOfTF

                    'If valueOfDOC.Equals(String.Empty) = False And doc.Contains(valueOfDOC.Substring(folderName.Length + 1)) = False Then
                    'If valueOfDOC = "" Then
                    '    doc.Add(valueOfDOC)
                    'ElseIf doc.Contains(valueOfDOC.Substring(folderName.Length + 1)) = False Then
                    '    doc.Add(valueOfDOC.Substring(folderName.Length + 1))
                    'End If

                Next 'n

                ' Calls DocumentFrequency function by passing the 'term' and saves the retured value in a variable called "df"
                df = DocumentFrequency(myArray(a).term)

                ' idf = InverseDocumentFrequency(df)

                'Insert end of line character
                tf.Insert(tf.Count, "$".Trim)

                post.termFrequency = New List(Of String)(tf)
                '    post.location = New List(Of String)(loc)

                voc.term = myArray(a).term
                voc.collectionFrequency = cf
                voc.documentFrequency = df

                objPosting.Add(post)
                objVocabulary.Add(voc)

            End If     ' If IsNothing(checkedOut) 

            '  tf.RemoveRange(0, tf.Count - 1)
            '  doc.RemoveRange(0, doc.Count - 1)

        Next

    End Sub

    Private Function LocationOfTerm(ByVal myTerm As String, ByVal document As String) As List(Of Integer)

        Dim myLoc As New List(Of Integer)
        'Dim position As New List(Of Integer)

        Dim n As Integer
        'Dim ourFile As String

        ' For k = 0 To document.Count - 1
        ' ourFile = folderName & "\" & document            ' document(k)

        'Call DeNormalizer(myTerm)
        Dim TempStringArray As New List(Of String)
        Dim newContent As String = String.Empty

        If document.Equals(String.Empty) = False Then
            content = ReadFromFile(document)

            If content.Equals("No") = False Then            ' Means if the document is empty or cannot be read

                'Preprocessing
                Normalizer(content)
                TempStringArray = Stemmer(tokenizer(content))

                For Each var In TempStringArray
                    newContent &= var.ToString & " "
                Next

                For n = 0 To content.Length - 1
                    n = newContent.Trim.IndexOf(myTerm, n)      'Two arguments (Value, StartIndex)
                    If n > -1 Or (myLoc.Count <> 0 AndAlso n > myLoc(0)) And document.Substring(folderName.Length + 1) <> "" Then
                        'position.Add(n)
                        myLoc.Add(n)
                    Else
                        Exit For
                    End If
                Next

            End If

        End If
        ' Next

        Return myLoc

    End Function

    Private Function DocumentFrequency(ByVal word As String) As Integer

        Dim dn As String
        Dim dfReturned As Integer

        Dim n, m As Integer             ' n = iterates through the files        ' m = iterates through the vocabulary list

        For n = 0 To allFiles.Count - 1
            dn = allFiles(n)

            For m = 0 To ourVocabularyList.Count - 1
                If ourVocabularyList(m).term.Equals(word) And ourVocabularyList(m).docName.Equals(dn) Then
                    dfReturned += 1
                    Exit For
                End If
            Next

        Next

        Return dfReturned

    End Function

#Region "OLD ReadFromFile"
    'Private Function ReadFromFile(ByVal filename As String) As String

    '    If IO.File.Exists(filename) Then
    '        myStreamReader = IO.File.OpenText(filename)

    '        content = String.Empty

    '        item = myStreamReader.ReadLine

    '        While Not item = Nothing

    '            content = content & item.ToString.Trim & vbNewLine
    '            item = myStreamReader.ReadLine

    '        End While

    '        'When finished reading from the file, close the StreamReader
    '        myStreamReader.Close()

    '        Return content

    '    Else
    '        Return "No"
    '    End If

    'End Function

#End Region

    Public Shared Function ReadFromFile(ByVal filename As String) As String

        If IO.File.Exists(filename) Then
            myStreamReader = IO.File.OpenText(filename)

            content = String.Empty

            item = myStreamReader.ReadToEnd

            content = content & item.ToString.Trim

            'When finished reading from the file, close the StreamReader
            myStreamReader.Close()

            Return content

        Else
            Return "No"
        End If

    End Function

    Public Shared Function stopWordRemover(ByVal contentArray As List(Of String)) As List(Of String)

        Dim i As Integer
        ' To store all the terms that are not in the stoplist file
        Dim con As String = String.Empty

        For i = 0 To contentArray.Count - 1

            ' Checks for:
            ' words that are not contatined in the stoplist,
            ' words that are not " " (blank),
            ' which are not numbers
            ' the length of the word is greaterthan 1
            ' and puts them in a new array which is returned

            If stopWordArray.Contains(contentArray(i)) = False And contentArray(i).Equals("") = False And IsNumeric(contentArray(i)) = False And contentArray(i).Count > 1 Then
                con = con & contentArray(i) & " "
            End If

        Next

        If con.Equals("") = False Then
            myNewStringArray = con.Trim.Split(" ").ToList
        End If

        Return myNewStringArray

    End Function

    Private Function tokenizer(ByVal content As String) As List(Of String)

        Dim separators As Char()
        separators = {" ", vbNewLine}

        Dim mylist, mylist2 As New List(Of String)

        mylist = content.Split(separators).ToList

        For Each l In mylist

            mylist2.Add(l.Trim)

        Next
        'Split the document into single words and return it
        'Return content.Trim.Split(separators).ToList

        'Split the document into single words and return it
        Return mylist2

    End Function

    Public Shared Sub punctuationRemover(ByRef content As String)

        'Declare and Initialize an array that will store the list of punctuation marks in Amharic Language
        Dim punctuations() As String = {"፤", "፣", "፥", "!", ".", ":", "።", "(", ")", "-", "_", "?", "/", "[", "]", ",", "<", ">", ";", "{", "}", "|", "'", Chr(34)}
        ' additional puntuations "&", "*", "`", "~", "-",

        For i = 0 To punctuations.Length - 1
            If punctuations(i).Equals("-") Then
                content = content.Replace(punctuations(i), "")
            Else
                content = content.Replace(punctuations(i), " ")
            End If
        Next

    End Sub

    Public Shared Sub Normalizer(ByRef content As String)

        For Each n In normalizingWords

            content = content.Replace(n.Key, n.Value)

        Next

    End Sub

    Public Shared Function SadisReplacer(ByRef content As String) As String

        For Each n In sadisFidel

            content = content.Replace(n.Key, n.Value)

        Next
        Return content
    End Function

    'Private Sub DeNormalizer(ByRef content As String)

    '    For Each n In normalizingWords

    '        content = content.Replace(n.Value, n.Key)

    '    Next

    'End Sub

    Public Shared Function Stemmer(ByRef myNewStringArray As List(Of String)) As List(Of String)

        If IsNothing(myNewStringArray) = False Then

            ' Iterate through the array - looking for each word
            For k = 0 To myNewStringArray.Count - 1

                prefixStripper(myNewStringArray(k))
                suffixStripper(myNewStringArray(k))

            Next
        End If

        Return myNewStringArray

    End Function

    Public Shared Sub prefixStripper(ByRef word As String)

        ' Iterate through the array - looking fpr each suffix
        For i = 0 To prefixListArray.Count - 1

            ' If the word ends with the array element, remove the suffix
            If (word.Length) > 2 And prefixListArray(i) <> "" Then
                If word.Trim.StartsWith(prefixListArray(i).Trim) Then
                    word = word.Substring(prefixListArray(i).Length)
                End If
            End If

        Next

        ' Display the output
        'For i = 0 To myNewStringArray.Count - 1

        '    MsgBox(myNewStringArray(i))

        'Next

    End Sub

    Public Shared Sub suffixStripper(ByRef word As String)

        ' Iterate through the array - looking fpr each suffix
        For i = 0 To suffixListArray.Count - 1

            ' If the word ends with the array element, remove the suffix
            If (word.Length) > 2 Then

                If word.Trim.EndsWith("ች") Then
                    word = word.Replace("ች", "")
                    word = SadisReplacer(word.Trim)
                ElseIf word.Trim.EndsWith(suffixListArray(i).Trim) Then
                    word = word.Substring(0, word.Trim.Length - suffixListArray(i).Trim.Count)
                    'word = word.Substring(0, suffixListArray(i).Trim.Count)

                End If

            End If

        Next
    End Sub

    Private vocFileName, postFileName As String

    Private Sub WriteToFile(ByVal sv As List(Of structureVocabulary), ByVal sp As List(Of structurePosting))

        'Finally save the contents of the structures to a file

        If IsNothing(sv) = False And IsNothing(sp) = False And sv.Count <> 0 And sp.Count <> 0 Then

            If IO.Directory.Exists("C:\Voc_Post") = False Then

                IO.Directory.CreateDirectory("C:\Voc_Post")

            End If
            ' folderName & \Voc_Post
            'vocFileName = folderName & "\Voc_Post\VocabularyFile.txt"

            Try
                vocFileName = "C:\Voc_Post\VocabularyFile.txt"
                postFileName = "C:\Voc_Post\PostingFile.txt"
            Catch ex As Exception
                'vocFileName = "C:\VocabularyFile.txt"
                'postFileName = "C:\PostingFile.txt"
            End Try

            'Declare a StreamReader object and read from the file
            Dim vocStreamWriter, postStreamWriter As StreamWriter

            'Save the whole content of the structure in the variable to be saved on a file
            Dim VocOutputToFile As String = String.Empty
            Dim postOutputToFile As String = String.Empty

            ' Vocabulary File

            '    If IO.File.Exists(vocFileName) Then
            'vocStreamWriter = IO.File.AppendText(vocFileName)
            'Else
            vocStreamWriter = IO.File.CreateText(vocFileName)
            VocOutputToFile = "ስርወ ቃል" & vbTab & vbTab & vbTab & vbTab & "|" & "ዲ:ኤፍ" & vbTab & "|" & "ሲ:ኤፍ" & vbTab & vbCrLf   'Create Line Feed
            VocOutputToFile &= "=========================================" & vbCrLf
            'End If

            For Each ov In objVocabulary
                VocOutputToFile = VocOutputToFile & ov.term & vbTab & vbTab & vbTab & vbTab & ov.documentFrequency & vbTab & ov.collectionFrequency & vbTab & vbNewLine
            Next

            ' Posting File

            'If IO.File.Exists(postFileName) Then
            'postStreamWriter = IO.File.AppendText(postFileName)
            'Else
            postStreamWriter = IO.File.CreateText(postFileName)
            postOutputToFile = "የዶክመንቱ ስም   >   ቲ:ኤፍ   >   እና የስርወ ቃሉ መገኛ ቦታ" & vbCrLf
            postOutputToFile &= "=======================================" & vbCrLf
            'End If

            For Each op In objPosting

                Dim strTF As String = String.Empty
                'Dim strDN As String = String.Empty
                ' Dim strLOC As String = String.Empty

                For Each t In op.termFrequency
                    strTF = strTF & t.ToString & ", "
                Next

                'For Each l In op.location
                '    strLOC = l.ToString & ", " & strLOC
                'Next

                postOutputToFile = postOutputToFile & strTF.Substring(0, strTF.Count - 2) & vbTab & vbNewLine
            Next

            'MsgBox(VocOutputToFile)
            'MsgBox(postOutputToFile)

            'Finally, write the output to the new file
            vocStreamWriter.WriteLine(VocOutputToFile.Trim)
            postStreamWriter.WriteLine(postOutputToFile.Trim)

            vocStreamWriter.Close()
            postStreamWriter.Close()

            MessageBox.Show("ስራው ተጠናቁአል። ፋይሎቹ 'Vocabulary file' እና 'Posting file' ተብለው ተቀምጠዋል።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnOpenOutputFile.Enabled = True

        End If

    End Sub

#Region "Not Important"
    'Remove all non alphanumeric characters
    'System.Text.RegularExpressions.Regex.Replace(stringtochange, "[aa-zA-Z0-(_ .+]", "")
#End Region

    Private Sub AboutTheProgammersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTheProgammersToolStripMenuItem.Click

        Dim ourForm As New frmTeamMembers
        ourForm.Show()

    End Sub

    Private Sub btnOpenOutputFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenOutputFile.Click

        Dim indexFile As String = String.Empty

        indexFile = ReadFromFile(vocFileName)
        frmOutput.txtVocabularyFile.Text = indexFile

        indexFile = ReadFromFile(postFileName)
        frmOutput.txtPostingFile.Text = indexFile

        frmOutput.Show()

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        txtFolderSelected.Text = String.Empty

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        End

    End Sub

    Private Sub ዋናፋይሎችንማስተካከያToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ዋናፋይሎችንማስተካከያToolStripMenuItem.Click

        frmEdit.Show()

    End Sub

    Private Sub SearchToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles SearchToolStripMenuItem.Click

        Dim srch As New frmSearching
        srch.Show()
        Me.Hide()

    End Sub

    'Private Sub frmIndexing_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    SearchToolStripMenuItem_Click(Nothing, Nothing)
    '    Me.Hide()
    '    frmSearching.Activate()

    'End Sub

End Class

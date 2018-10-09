'              1 ቢኒያም አስናቀ                         GSR/0809/03
'              2 ግርማ አወቀ                          GSR/0816/03
'              3 ሙዘይን ከድር                         GSR/0823/03
'              4 ነጋሲ ገብረእግዚአብሔር                   GSR/0303/02

'  '' ''                                           ለዶክተር ሚሊዮን መሸሻ
' '' ''                                            ሰኔ22 ቀን 2003 ዓም

Imports System.IO
Imports System.Configuration

Imports AmharicIRS.frmIndexing
Imports Microsoft.Office.Interop.Word

Public Class frmSearching

    Private inputQuery As New List(Of String)
    Private vocFile, postFile As String
    Private vocFileContent, postFileContent As String

    Structure strQueryTermfrequency

        Dim term As String
        Dim tf As Integer

    End Structure

    Dim objQueryTermFrequency As New List(Of strQueryTermfrequency)
    Dim qtf As New strQueryTermfrequency

    Private Sub TF_Calculator(ByVal ourQuery As List(Of String))

        Dim a, b As Integer
        Dim valueOfTF As Integer
        Dim tf As New List(Of String)
        Dim checkedOut As New List(Of String)
        Dim dn As String = String.Empty

        For a = 0 To ourQuery.Count - 1      'To pick one word from the list
            tf.Clear()

            If IsNothing(checkedOut) = False And checkedOut.Contains(ourQuery(a)) = False And ourQuery(a).Equals("") = False Then
                checkedOut.Add(ourQuery(a))

                valueOfTF = 0
                For b = 0 To ourQuery.Count - 1  'To iterate through the list to check for a match
                    'TF -> counts the number of occurence of a term in one specific document.
                    If ourQuery(a).Trim.Equals(ourQuery(b).Trim) Then
                        valueOfTF += 1
                    End If
                Next 'b

                qtf.term = ourQuery(a)
                qtf.tf = valueOfTF

                objQueryTermFrequency.Add(qtf)

                Dim max As Integer = 0

                ' Find maxumum frequency of a term
                For Each m In objQueryTermFrequency
                    If ourQuery(a).Equals(m.term) And max < m.tf Then
                        max = m.tf
                    End If
                Next

                ' Normalize TF of a term by dividing the tf by the maximum frequency calculated by the above for...loop
                For Each m In objQueryTermFrequency
                    If ourQuery(a).Equals(m.term) Then
                        m.tf = m.tf / max
                    End If
                Next


                'qtf.tf = valueOfTF / max


                'For Each e In objQueryTermFrequency

                '    e.tf = e.tf / max

                'Next

            End If     ' If IsNothing(checkedOut) 

        Next

    End Sub

    Private Function InverseDocumentFrequency(ByVal df As Integer) As Double

        Dim freq As Integer = 0
        Dim idf As Double = 0
        Dim max As Integer = 0

        If ContentOfVocabulary.Equals("No") = False And ContentOfVocabulary.Equals("") = False Then

            max = Val(ContentOfVocabulary(0))

        End If

        freq = max / df
        idf = Format(Math.Log10(freq), "0.000")

        Return idf

    End Function

    Private Function DocumentTermWeighting(ByVal ourTerm As String, ByVal tf As Double, ByVal idf As Double) As Double

        Dim termWeight As Double = 0

        Dim maxTF As Integer = 0

        ' To calculate Normalized TF
        For Each m In ps
            If m.term.Equals(ourTerm) And maxTF < m.tf Then
                maxTF = m.tf
            End If
        Next

        termWeight = Format((tf / maxTF) * idf, "0.0000")

        Return termWeight

    End Function

    Private Function QueryTermWeighting(ByVal tf As Double, ByVal idf As Double) As Double

        Dim termWeight As Double = 0

        'termWeight = Format(tf * idf, "0.0000")
        termWeight = Format((0.5 + (0.5 * tf)) * idf, "0.0000")

        Return termWeight

    End Function

    Public Structure strTermDocumentMatrix

        Dim term As String
        Dim document As String
        Dim weight As Double

    End Structure

    Dim objTermDocumentMatrix As New List(Of strTermDocumentMatrix)
    Dim tdm As New strTermDocumentMatrix

    Private Sub CalculateDocumentWeight()

        Dim termIDF, termWeight As Double

        For a As Integer = 0 To objVocabulary.Count - 1
            '    For b As Integer = 0 To ps.Count - 1
            'If objTermDocumentMatrix.Contains(objVocabulary(a).term) = False Then
            termIDF = InverseDocumentFrequency(objVocabulary(a).documentFrequency)
            termWeight = DocumentTermWeighting(objVocabulary(a).term, ps(a).tf, termIDF)
            ' ps.Item(a).loc(a) = a
            tdm.term = ps(a).term
            tdm.document = ps(a).doc
            tdm.weight = termWeight

            objTermDocumentMatrix.Add(tdm)
            'End If

            'Next
        Next

        'For Each t In objTermDocumentMatrix

        '    MsgBox("CalculateDocumentWeight" & t.term & " " & t.weight & " " & t.document)

        'Next

    End Sub

    Private Sub CalculateQueryWeight()

        Dim queryIDF, queryWeight As Double

        For Each q In objQueryTermFrequency
            For Each v In objVocabulary

                If q.term.Equals(String.Empty) = False Then

                    If v.term.Trim.Equals(q.term.Trim) Then

                        queryIDF = InverseDocumentFrequency(v.documentFrequency)
                        queryWeight = QueryTermWeighting(q.tf, queryIDF)

                        tdm.term = q.term
                        tdm.document = "Query"
                        tdm.weight = queryWeight

                        objTermDocumentMatrix.Add(tdm)

                    End If
                End If

            Next

        Next

        'For Each t In objTermDocumentMatrix

        '    MsgBox("CalculateQueryWeight" & t.term & " " & t.weight & " " & t.document)

        'Next

    End Sub

    Dim ContentOfVocabulary As String = String.Empty

    Private Sub OpenVocabularyFile()

        vocFile = "C:\Voc_Post\VocabularyFile.txt"

        If vocFile.Equals(String.Empty) = False Then

            vocFileContent = ReadFromFile(vocFile)

            If vocFileContent.Equals("No") Then
                MessageBox.Show("ይቅርታ: ፋይሉ አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf vocFileContent.Equals("") Then
                MessageBox.Show("ይቅርታ ፋይሉ ሊነበብ አይችልም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                LineTokenizer(vocFileContent)

            End If
        End If

        'To read the number of documents in the index file and to read the foldername
        ContentOfVocabulary = ReadFromFile("C:VOC_POST\Settings.txt")

    End Sub

    Private Sub OpenPostingFile()

        postFile = "C:\Voc_Post\PostingFile.txt"

        If postFile.Equals(String.Empty) = False Then

            postFileContent = ReadFromFile(postFile)

            If postFileContent.Equals("No") Then
                MessageBox.Show("ይቅርታ: ፋይሉ አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ElseIf postFileContent.Equals("") Then
                MessageBox.Show("ይቅርታ ፋይሉ ሊነበብ አይችልም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Else

                'Call Normalizer(postFileContent)

                '  Call SadisReplacer(vocFileContent)

                'stringArray = LineTokenizer2(postFileContent)
                LineTokenizer2(postFileContent)

                'For Each s In stringArray

                '    MsgBox(s)

                'Next

            End If
        End If

    End Sub

    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

        If txtQuery.Text.Trim.Equals(String.Empty) = True Or txtQuery.Text.Length < 2 Then

            MessageBox.Show("እባክዎ ትክክለኛ መጠይቅ ያስገቡ።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuery.Text = String.Empty
            txtQuery.Focus()

        ElseIf txtQuery.Text.Trim.Length >= 100 Then

            MessageBox.Show("ይቅርታ ከ100 ፊደል በላይ ማስገባት አይችሉም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtQuery.Focus()

        Else

            Call Initialization()

            objVocabulary.Clear()
            objTermDocumentMatrix.Clear()
            objResultOfCOS.Clear()
            objQueryTermFrequency.Clear()

            Call OpenVocabularyFile()
            Call OpenPostingFile()

            If IsNothing(stopWordArray) = True Then
                stopWordArray = tokenizer(stopList.Trim)
            End If

            If IsNothing(suffixListArray) = True Then
                suffixListArray = tokenizer(suffixList.Trim)
            End If

            If IsNothing(prefixListArray) = True Then
                prefixListArray = tokenizer(prefixList.Trim)
            End If

            ' Pre-Processing

            Dim ourQuery As String = txtQuery.Text.Trim

            Call punctuationRemover(ourQuery)

            Call Normalizer(ourQuery)

            'Call SadisReplacer(txtQuery.Text)

            ' Store the query terms in a list
            inputQuery = tokenizer(ourQuery)

            inputQuery = stopWordRemover(inputQuery)

            If IsNothing(inputQuery) = False Then

                Call Stemmer(inputQuery)

                Call TF_Calculator(inputQuery)

                Call CalculateQueryWeight()

                Call CalculateDocumentWeight()

                Dim listQuery, listDocument As New List(Of Double)
                'listQuery.Add(objTermDocumentMatrix("Query").weight)

                For Each x In objTermDocumentMatrix

                    If x.document = "Query" Then

                        listQuery.Add(x.weight)

                    End If

                Next

                Dim doc1 As String
                Dim numerator As Double

                Dim checkedOut As New List(Of String)

                For i As Integer = 0 To objTermDocumentMatrix.Count - 1

                    doc1 = objTermDocumentMatrix(i).document

                    numerator = 0
                    listDocument.Clear()

                    If IsNothing(checkedOut) = False And checkedOut.Contains(doc1) = False And doc1.Equals("Query") = False Then

                        checkedOut.Add(doc1)

                        For Each eachDocument In objTermDocumentMatrix

                            If doc1.Equals(eachDocument.document) Then

                                If eachDocument.weight <> 0.0 Then
                                    listDocument.Add(eachDocument.weight)
                                End If

                                For Each x In objTermDocumentMatrix
                                    If x.document = "Query" And x.document.Equals(eachDocument.document) = False And x.term.Equals(eachDocument.term) Then
                                        numerator += x.weight * eachDocument.weight
                                    End If
                                Next

                            End If
                        Next
                        rCos.docName = doc1
                        rCos.cos = Format(Calculate_COS_SIMILARITY(listDocument, listQuery, numerator), "0.000")

                        objResultOfCOS.Add(rCos)
                    End If
                Next

                lstBoxOutput.Items.Clear()
                lstBoxCos.Items.Clear()

                '  Dim p =
                'From c In objResultOfCOS Order By c.cos Descending Select c()
                'objSortedResultOfCOS = From g In objResultOfCOS Order By g.cos Descending Select g.docName

                objResultOfCOS.Sort()
                objResultOfCOS.Reverse()

                For Each s In objResultOfCOS

                    If s.cos <> 0.0 And s.cos > 0.1 Then

                        If s.docName.Equals("Query") = False Then

                            lstBoxOutput.Items.Add(s.docName)
                            lstBoxCos.Items.Add(s.cos)

                        End If
                    End If

                Next

                If lstBoxOutput.Items.Count = 0 Then

                    MessageBox.Show("ይቅርታ: ከመጠይቅዎ ጋር የሚስማማ ፋይል አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtQuery.Text = String.Empty
                    txtQuery.Focus()
                End If
            Else

                MessageBox.Show("ይቅርታ: ከመጠይቅዎ ጋር የሚስማማ ፋይል አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtQuery.Text = String.Empty
                txtQuery.Focus()

            End If

            End If

    End Sub

    Public Structure strResultOfCOS
        Implements IComparable

        Dim docName As String
        Dim cos As Double

        Public Function CompareTo(ByVal obj As Object) As Integer _
              Implements System.IComparable.CompareTo
            Return Me.cos.CompareTo(CType(obj.cos, Double))
        End Function

    End Structure

    Dim objResultOfCOS As New List(Of strResultOfCOS)
    Dim rCos As New strResultOfCOS

    Private Function Calculate_COS_SIMILARITY(ByVal doc As List(Of Double), ByVal que As List(Of Double), ByVal top As Double) As Double

        Dim cos As Double = 0.0
        Dim num, den, denDoc, denQue As Double

        num = top

        If num = 0.0 Then

            Return 0.0

        Else

            For i As Integer = 0 To doc.Count - 1

                denDoc += doc(i) * doc(i)

            Next

            For i As Integer = 0 To que.Count - 1

                denQue += que(i) * que(i)

            Next

            den = Math.Sqrt(denDoc * denQue)

            cos = num / den
            Return cos

        End If

    End Function

    Private Function tokenizer(ByVal content As String) As List(Of String)

        Dim separators As Char()
        separators = {vbTab, vbNewLine, " "}

        Dim mylist, mylist2 As New List(Of String)

        mylist = content.Substring(content.LastIndexOf("=") + 1).Split(separators).ToList

        For Each l In mylist

            If l.Equals("") = False Then
                mylist2.Add(l.Trim)
            End If

        Next
        'Split the document into single words and return it
        'Return content.Trim.Split(separators).ToList

        'Split the document into single words and return it
        Return mylist2

    End Function

    Private Sub LineTokenizer(ByVal content As String)

        Dim separators As Char()
        separators = {vbTab}

        Dim mylist As New List(Of String)

        mylist = content.Substring(content.LastIndexOf("=") + 1).Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList

        For l = 0 To mylist.Count - 1 Step 3

            voc.term = mylist(l).Trim
            voc.documentFrequency = mylist(l + 1).Trim
            voc.collectionFrequency = mylist(l + 2).Trim

            objVocabulary.Add(voc)

        Next

        'For Each d In objVocabulary

        '    MsgBox("NEW: " & d.term & d.documentFrequency & d.collectionFrequency)

        'Next

    End Sub

    Structure newPostingStructure

        Dim tf As Integer
        Dim term As String
        Dim doc As String
        Dim loc As List(Of Integer)

    End Structure

    Private ps As New List(Of newPostingStructure)
    Dim pv As New newPostingStructure

    Private Sub LineTokenizer2(ByVal content As String)

        Dim separators As Char()
        separators = {"{", "_*_", "~", "'", "}", ","}

        Dim mylist As New List(Of String)
        post = New structurePosting

        mylist = content.Substring(content.LastIndexOf("=") + 1).Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList

        Dim h As Integer = 0

        Dim vn As Integer = 0           ' vn -> vocabulary number

        Dim loc As New List(Of Integer)

        For e As Integer = 0 To mylist.Count - 1 Step 1

            loc.Clear()

            If mylist(e).Trim.Equals(String.Empty) = False Then

                If mylist(e).EndsWith(".txt") Then

                    pv.doc = mylist(e)

                    pv.term = objVocabulary(vn).term
                    h = 0
                    If mylist(e + 1).Trim.Equals("*") Then

                        pv.tf = mylist(e + 2)
                        e += 2
                        If IsNumeric(mylist(e)) Then

                            loc.Add(CType(mylist(e + 1), Integer))
                            e += 1
                            While mylist((e + 1) + h).Equals(" ") = False And mylist((e + 1) + h).Trim.EndsWith(".txt") = False And mylist((e + 1) + h).Trim.Equals("$") = False And mylist((e + 1) + h).Trim.Equals("*") = False

                                loc.Add(CType(mylist(e + 1 + h), Integer))
                                h += 1
                                '  e += 1

                            End While

                        End If

                        If mylist(e + 1).Trim.Equals("$") = True Or mylist((e + 1) + h).Trim.Equals("$") = True Then

                            ' pv.term = objVocabulary(vn).term
                            vn += 1

                        End If

                    End If

                    pv.loc = New List(Of Integer)(loc)
                    ps.Add(pv)

                End If
            End If

        Next

    End Sub

    'Private Sub frmSearching_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    '    txtQuery.Text = String.Empty
    '    txtQuery.Focus()

    '    Me.Activate()
    'End Sub

    Private Sub IndexingToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles IndexingToolStripMenuItem.Click

        Dim srch As New frmIndexing
        srch.Show()
        Me.Hide()

    End Sub

    Private Sub lstBoxOutput_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBoxOutput.SelectedIndexChanged

        lstBoxCos.SelectedIndex = lstBoxOutput.SelectedIndex

        txtSampleText.Text = String.Empty
        txtSampleText.DeselectAll()
        txtSampleText.SelectionColor = Color.Black
        WriteOnSampleText()

    End Sub

    Private Sub WriteOnSampleText()

        If lstBoxOutput.SelectedItem.Equals(String.Empty) = False Then

            Dim indexFile As String = String.Empty
            Dim folder As String = ContentOfVocabulary.Substring(3)
            indexFile = ReadFromFile(folder & "\" & lstBoxOutput.SelectedItem)

            Dim ourStartPosition As Integer = 0

            If indexFile.Equals("No") Then

                MessageBox.Show("ይቅርታ: የመረጡት ፋይል አልተገኘም::", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else

                txtSampleText.Text = indexFile.Trim

                ourStartPosition = txtSampleText.Find(txtQuery.Text.Trim.Split(" ")(0))

                Try
                    txtSampleText.Text = txtSampleText.Text.Substring(txtSampleText.Text.IndexOf(" ", ourStartPosition - 10), ourStartPosition + 15)
                Catch ex As Exception
                    txtSampleText.Text = txtSampleText.Text.Substring(ourStartPosition)

                End Try

                Call findAndHighlightForSample()

            End If

        Else

            MessageBox.Show("እባክዎን ከዝርዝሩ ውስጥ አንድ ፋይል ይምረጡ።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If

    End Sub

    Private Sub NewToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NewToolStripMenuItem.Click

        txtQuery.Text = String.Empty
        txtSampleText.Text = String.Empty
        lstBoxCos.Items.Clear()
        lstBoxOutput.Items.Clear()

    End Sub

    Private Sub ዋናፋይሎችንማስተካከያToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ዋናፋይሎችንማስተካከያToolStripMenuItem.Click

        frmEdit.Show()

    End Sub

    Private Sub AboutTheProgammersToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutTheProgammersToolStripMenuItem.Click

        Dim ourForm As New frmTeamMembers
        ourForm.Show()

    End Sub

    Private Sub ExitToolStripMenuItem1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitToolStripMenuItem1.Click

        End

    End Sub

    Private Sub btnOpenOutputFile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOpenOutputFile.Click

            Dim indexFile As String = String.Empty
            Dim folder As String = ContentOfVocabulary.Substring(3)
            indexFile = ReadFromFile(folder & "\" & lstBoxOutput.SelectedItem)

        If indexFile.Equals("No") Then

            MessageBox.Show("እባክዎን ከዝርዝሩ ውስጥ አንድ ፋይል ይምረጡ።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else

            frmOurNotePad.txtNotePad2.Text = indexFile.Trim
            frmOurNotePad.txtNotePad.Text = indexFile.Trim

            Call findAndHighlight()

            frmOurNotePad.Show()
            frmOurNotePad.Activate()

        End If
    End Sub

    Dim start As Integer = 0
    Dim indexOfSearchText As Integer = 0
    Dim startindex As Integer = 0
    Dim freq As Integer = 0

    Private fileName As String
    Dim richTextcontent As String

    Structure strQuery
        Dim query As String
        Dim qf As Integer
    End Structure

    Dim queryStr As New strQuery
    Dim queryList As New List(Of strQuery)

    Private Sub findAndHighlight()

        Dim ourWord As String = txtQuery.Text.Trim
        richTextcontent = frmOurNotePad.txtNotePad.Text

        Dim QList As List(Of String) = tokenizer(richTextcontent)

        QList = Stemmer(QList)

        For Each termq In ourWord.Trim.Split(" ")
            For Each b In QList
                If termq.Trim.Equals(b.Trim) Then
                    freq += 1
                End If
            Next

            queryStr.query = termq.Trim
            queryStr.qf = freq

            'if the query contains duplicate terms count them only once
            If queryList.Contains(queryStr) = False Then

                queryList.Add(queryStr)

            End If

            freq = 0
            termq = String.Empty

        Next

        For i = 0 To queryList.Count - 1

            Dim queryTerm As String = queryList(i).query
            Dim queryFreq As Integer = queryList(i).qf

            start = 0
            startindex = 0

            For t = 0 To queryFreq - 1

                If queryTerm.Length > 0 Then

                    startindex = FindMyText(queryTerm.Trim, start, frmOurNotePad.txtNotePad.Text.Length)

                End If

                'If string was found in the RichTextBox, highlight it 
                If startindex > -1 Then

                    ' Set the highlight color as red
                    frmOurNotePad.txtNotePad.SelectionBackColor = Color.Yellow

                    ' Find the end index. End Index = number of characters in textbox 
                    Dim endindex As Integer = queryTerm.Length

                    ' Highlight the search string 
                    frmOurNotePad.txtNotePad.Select(startindex, endindex)

                    ' mark the start position after the position of last search string 
                    start = startindex + endindex

                End If
            Next
        Next

        queryList.Clear()

    End Sub

    Public Function FindMyText(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer

        ' Unselect the previously searched string 
        'If searchStart > 0 AndAlso searchEnd > 0 AndAlso indexOfSearchText >= 0 Then

        '    'rtbNega.Undo()

        'End If

        ' Set the return value to -1 by default. 
        Dim retVal As Integer = -1

        ' A valid starting index should be specified. 
        ' if indexOfSearchText = -1, the end of search 
        If searchStart >= 0 Then   'AndAlso indexOfSearchText >= 0

            ' A valid ending index 
            If searchEnd > searchStart OrElse searchEnd = -1 Then

                ' Find the position of search string in RichTextBox 
                indexOfSearchText = frmOurNotePad.txtNotePad.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)

                ' Determine whether the text was found in richTextBox1. 
                If indexOfSearchText <> -1 Then
                    ' Return the index to the specified search text.
                    retVal = indexOfSearchText
                End If

            End If

        End If

        Return retVal

    End Function

    Private Sub findAndHighlightForSample()

        Dim ourWord As String = txtQuery.Text

        For i = 0 To ourWord.Split(" ").ToList.Count

            For Each query In ourWord.Split(" ")

                If query.Equals(String.Empty) = False Then

                    start = 0
                    startindex = 0

                    'If txtSearch.Text.Length > 0 Then
                    If query.Trim.Length > 0 Then

                        startindex = FindMyTextForSample(query.Trim, start, txtSampleText.Text.Length)

                    End If

                    'If string was found in the RichTextBox, highlight it 

                    If startindex > -1 Then

                        ' Set the highlight color as red
                        txtSampleText.SelectionBackColor = Color.Yellow

                        ' Find the end index. End Index = number of characters in textbox 
                        Dim endindex As Integer = query.Length

                        ' Highlight the search string 
                        txtSampleText.Select(startindex, endindex)

                        ' mark the start position after the position of last search string 
                        start = startindex + endindex

                    End If

                End If
            Next
        Next

    End Sub

    Public Function FindMyTextForSample(ByVal txtToSearch As String, ByVal searchStart As Integer, ByVal searchEnd As Integer) As Integer

        ' Set the return value to -1 by default. 
        Dim retVal As Integer = -1

        ' A valid starting index should be specified. 
        ' if indexOfSearchText = -1, the end of search 
        If searchStart >= 0 Then   'AndAlso indexOfSearchText >= 0

            ' A valid ending index 
            If searchEnd > searchStart OrElse searchEnd = -1 Then

                ' Find the position of search string in RichTextBox 
                indexOfSearchText = txtSampleText.Find(txtToSearch, searchStart, searchEnd, RichTextBoxFinds.None)

                ' Determine whether the text was found in richTextBox1. 
                If indexOfSearchText <> -1 Then
                    ' Return the index to the specified search text.
                    retVal = indexOfSearchText
                End If

            End If

        End If

        Return retVal

    End Function

    Private Sub txtQuery_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtQuery.TextChanged

        ' Reset the richtextbox when user changes the search string
        start = 0
        indexOfSearchText = 0

    End Sub

    Private Sub lstBoxCos_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles lstBoxCos.SelectedIndexChanged

        lstBoxOutput.SelectedIndex = lstBoxCos.SelectedIndex

    End Sub

End Class
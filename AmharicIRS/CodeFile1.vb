
'Dim temp As String = String.Empty

'        #sort descendigly to rank documents-selction sort
'for i in range(0, len(sim)):
'            largest = i
'    for j in range((i+1),len(sim)):
'        if sim[j]>sim[largest]:
'                    largest = j
'    temp=sim[i]
'    sim[i]=sim[largest]
'    sim([largest] = temp)

'    #arrange the document id as well when sorting
'    temp=corpusfile[i]
'    corpusfile[i]=corpusfile[largest]
'    corpusfile([largest] = temp)

'Dim firstDoc As String = String.Empty
'Dim firstCos As Double = 0.0

'For q As Integer = 0 To objResultOfCOS.Count - 1

'    firstDoc = objResultOfCOS(q).docName
'    firstCos = objResultOfCOS(q).cos

'    For w As Integer = 1 To objResultOfCOS.Count - 1

'        If objResultOfCOS(w).cos > objResultOfCOS(q).cos Then

'            firstDoc = objResultOfCOS(w).docName
'            firstCos = objResultOfCOS(w).cos

'        End If

'    Next

'    sCos.cos = firstCos
'    sCos.docName = firstDoc

'    objSortedResultOfCOS.Add(sCos)

'Next

'For Each s In objSortedResultOfCOS
'    ' MsgBox("After COS sort:  " & s.docName & " _ " & s.cos)
'    If s.docName.Equals("Query") Then

'        lstBoxOutput.Items.Add(s.docName)

'    End If

'    'For Each a In objResultOfCOS
'    '    If s.cos < a.cos Then
'    '        lstBoxOutput.Items.Add(s.docName)
'    '    End If
'    'Next
'Next

'For Each var In objTermDocumentMatrix
'    doc1 = var.document
'    For Each docu In var
'        If doc1.Equals(docu) Then
'            listDocument.Add(var.weight)
'        End If
'    Next

'    rCos.docName = var.document
'    rCos.cos = Calculate_COS_SIMILARITY(listDocument, listQuery)

'Next
'MsgBox("Bin" & objTermDocumentMatrix("Query").weight)



''              1 ቢኒያም አስናቀ                         GSR/0809/03
''              2 ነጋሲ ገብረእግዚአብሔር                   GSR/0303/02
''              3 ግርማ አወቀ                          GSR/0816/03
''              4 ሙዘይን ከድር                         GSR/0823/03

''  '' ''                                           ለዶክተር ሚሊዮን መሸሻ
'' '' ''                                            ሰኔ22 ቀን 2003 ዓም


'Imports System.IO
'Imports System.Configuration

'Imports AmharicIRS.frmIndexing

'Public Class frmSearching

'    Private queryTerms As New List(Of String)

'    Private vocFile, postFile As String
'    Private vocFileContent, postFileContent As String

'    Private Sub btnSearch_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSearch.Click

'        ' Store the query terms in a list
'        queryTerms = txtQuery.Text.Split(" ").ToList

'        'If allFiles.Count <> 0 And IsNothing(allFiles) = False Then

'        '    ' To iterate through all the .txt files in the folder
'        '    For k = 0 To allFiles.Count - 1

'        '        filename = allFiles(k)

'        vocFile = "C:\Voc_Post\VocabularyFile.txt"
'        postFile = "C:\Voc_Post\PostingFile.txt"

'        If vocFile.Equals(String.Empty) = False Then

'            vocFileContent = ReadFromFile(vocFile)

'            If vocFileContent.Equals("No") Then
'                MessageBox.Show("ይቅርታ: ፋይሉ አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            ElseIf vocFileContent.Equals("") Then
'                MessageBox.Show("ይቅርታ ፋይሉ ሊነበብ አይችልም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Else

'                Call Normalizer(vocFileContent)

'                'stringArray = LineTokenizer(vocFileContent)
'                'LineTokenizer(vocFileContent)

'                'For Each s In stringArray

'                '    MsgBox(s)

'                'Next

'            End If
'        End If


'        If postFile.Equals(String.Empty) = False Then

'            postFileContent = ReadFromFile(postFile)

'            If postFileContent.Equals("No") Then
'                MessageBox.Show("ይቅርታ: ፋይሉ አልተገኘም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            ElseIf postFileContent.Equals("") Then
'                MessageBox.Show("ይቅርታ ፋይሉ ሊነበብ አይችልም።", "የአማርኛ ኢሪሲ", MessageBoxButtons.OK, MessageBoxIcon.Error)
'            Else

'                Call Normalizer(postFileContent)

'                'stringArray = LineTokenizer2(postFileContent)
'                ' LineTokenizer2(postFileContent)

'                For Each s In stringArray

'                    MsgBox(s)

'                Next

'            End If
'        End If

'        '    Next
'        'End If



'    End Sub

'    Private Function tokenizer(ByVal content As String) As List(Of String)

'        Dim separators As Char()
'        separators = {vbTab, vbNewLine}

'        Dim mylist, mylist2 As New List(Of String)

'        mylist = content.Substring(content.LastIndexOf("=") + 1).Split(separators).ToList

'        For Each l In mylist

'            If l.Equals("") = False Then
'                mylist2.Add(l.Trim)
'            End If

'        Next
'        'Split the document into single words and return it
'        'Return content.Trim.Split(separators).ToList

'        'Split the document into single words and return it
'        Return mylist2

'    End Function

'    Private Sub LineTokenizer(ByVal content As String)

'        Dim separators As Char()
'        separators = {vbTab}

'        Dim mylist As New List(Of String)

'        mylist = content.Substring(content.LastIndexOf("=") + 1).Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList

'        For l = 0 To mylist.Count - 1 Step 3

'            voc.term = mylist(l).Trim
'            voc.documentFrequency = mylist(l + 1).Trim
'            voc.collectionFrequency = mylist(l + 2).Trim

'            objVocabulary.Add(voc)

'        Next

'        'For Each d In objVocabulary

'        '    MsgBox("NEW: " & d.term & d.documentFrequency & d.collectionFrequency)

'        'Next

'    End Sub

'    Structure newPostingStructure

'        Dim tf As List(Of Integer)
'        Dim doc As List(Of String)
'        Dim loc As List(Of Integer)

'    End Structure

'    Private ps As New List(Of newPostingStructure)
'    Dim pv As New newPostingStructure

'    'Private Sub LineTokenizer2(ByVal content As String)

'    '    Dim separators As Char()
'    '    separators = {"{", "_*_", "~", "'", "}"}

'    '    Dim mylist As New List(Of String)
'    '    post = New structurePosting

'    '    mylist = content.Substring(content.LastIndexOf("=") + 1).Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList

'    '    For l = 0 To mylist.Count - 1 Step 3

'    '        If mylist(l).Trim.Equals(String.Empty) = False Then
'    '            pv.term = (mylist(l))
'    '            'post.termFrequency = New List(Of String)(tf)
'    '            objPosting.Add(post)

'    '        End If

'    '    Next

'    '    For Each d In objPosting
'    '        For Each f In d.termFrequency
'    '            MsgBox("NEW: " & f)
'    '        Next

'    '    Next
'    'End Sub

'    Private Function InverseDocumentFrequency(ByVal df As Integer) As Double


'        Dim freq As Integer = 0
'        Dim idf As Double = 0
'        Dim max As Integer

'        ' max = allFiles.Count

'        Try
'            freq = max / df
'            idf = Format(Math.Log(freq, 2), "0.0000")
'        Catch ex As Exception

'        End Try

'        Return idf

'    End Function

'    Private Function TermWeighting(ByVal tf As Double, ByVal idf As Double) As Double

'        Dim termWeight As Double = 0

'        termWeight = Format(tf * idf, "0.0000")

'        Return termWeight

'    End Function

'    Private Sub frmSearching_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
'        Me.Activate()
'    End Sub
'End Class
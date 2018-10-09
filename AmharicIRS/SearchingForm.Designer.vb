<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSearching
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnOpenOutputFile = New System.Windows.Forms.Button()
        Me.btnSearch = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtQuery = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IndexingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ማስተካከያToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ዋናፋይሎችንማስተካከያToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheProgammersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lstBoxOutput = New System.Windows.Forms.ListBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.lstBoxCos = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtSampleText = New System.Windows.Forms.RichTextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.MenuStrip1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenOutputFile
        '
        Me.btnOpenOutputFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenOutputFile.Location = New System.Drawing.Point(369, 80)
        Me.btnOpenOutputFile.Name = "btnOpenOutputFile"
        Me.btnOpenOutputFile.Size = New System.Drawing.Size(63, 54)
        Me.btnOpenOutputFile.TabIndex = 2
        Me.btnOpenOutputFile.Text = "ፋይሉን ክፈት"
        Me.btnOpenOutputFile.UseVisualStyleBackColor = True
        '
        'btnSearch
        '
        Me.btnSearch.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSearch.Location = New System.Drawing.Point(355, 41)
        Me.btnSearch.Name = "btnSearch"
        Me.btnSearch.Size = New System.Drawing.Size(81, 35)
        Me.btnSearch.TabIndex = 0
        Me.btnSearch.Text = "ፈልግ"
        Me.btnSearch.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nyala", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(86, 14)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(205, 25)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "እባክዎን መጠይቅዎን ያስገቡ"
        '
        'txtQuery
        '
        Me.txtQuery.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtQuery.Location = New System.Drawing.Point(24, 47)
        Me.txtQuery.MaxLength = 327670
        Me.txtQuery.Name = "txtQuery"
        Me.txtQuery.Size = New System.Drawing.Size(322, 22)
        Me.txtQuery.TabIndex = 28
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.Salmon
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ማስተካከያToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(511, 24)
        Me.MenuStrip1.TabIndex = 33
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IndexingToolStripMenuItem, Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.FileToolStripMenuItem.Text = "ፋይል"
        '
        'IndexingToolStripMenuItem
        '
        Me.IndexingToolStripMenuItem.Name = "IndexingToolStripMenuItem"
        Me.IndexingToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.IndexingToolStripMenuItem.Text = "ወደ ማውጫ አዘጋጅ"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.NewToolStripMenuItem.Text = "አዲስ"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(149, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(152, 22)
        Me.ExitToolStripMenuItem1.Text = "ዝጋና ውጣ"
        '
        'ማስተካከያToolStripMenuItem
        '
        Me.ማስተካከያToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ዋናፋይሎችንማስተካከያToolStripMenuItem})
        Me.ማስተካከያToolStripMenuItem.Name = "ማስተካከያToolStripMenuItem"
        Me.ማስተካከያToolStripMenuItem.Size = New System.Drawing.Size(59, 20)
        Me.ማስተካከያToolStripMenuItem.Text = "ማስተካከያ"
        '
        'ዋናፋይሎችንማስተካከያToolStripMenuItem
        '
        Me.ዋናፋይሎችንማስተካከያToolStripMenuItem.Name = "ዋናፋይሎችንማስተካከያToolStripMenuItem"
        Me.ዋናፋይሎችንማስተካከያToolStripMenuItem.Size = New System.Drawing.Size(170, 22)
        Me.ዋናፋይሎችንማስተካከያToolStripMenuItem.Text = "ዋና ፋይሎችን ማስተካከያ"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutTheProgammersToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(31, 20)
        Me.HelpToolStripMenuItem.Text = "ስለ"
        '
        'AboutTheProgammersToolStripMenuItem
        '
        Me.AboutTheProgammersToolStripMenuItem.Name = "AboutTheProgammersToolStripMenuItem"
        Me.AboutTheProgammersToolStripMenuItem.Size = New System.Drawing.Size(155, 22)
        Me.AboutTheProgammersToolStripMenuItem.Text = "ስለ ሶፍትዌሩ ሰሪዎች "
        '
        'lstBoxOutput
        '
        Me.lstBoxOutput.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstBoxOutput.FormattingEnabled = True
        Me.lstBoxOutput.ItemHeight = 16
        Me.lstBoxOutput.Location = New System.Drawing.Point(17, 50)
        Me.lstBoxOutput.Name = "lstBoxOutput"
        Me.lstBoxOutput.Size = New System.Drawing.Size(204, 164)
        Me.lstBoxOutput.TabIndex = 0
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.MediumSeaGreen
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.lstBoxCos)
        Me.GroupBox1.Controls.Add(Me.lstBoxOutput)
        Me.GroupBox1.Controls.Add(Me.btnOpenOutputFile)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(35, 126)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(447, 224)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "ለመጠይቅዎ ተስማሚ የሆኑ ውጤቶች"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Nyala", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(245, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 19)
        Me.Label2.TabIndex = 38
        Me.Label2.Text = "ኮሳይን ውጤት"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Nyala", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(63, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(71, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "የፋይሉ ስም"
        '
        'lstBoxCos
        '
        Me.lstBoxCos.ForeColor = System.Drawing.SystemColors.WindowText
        Me.lstBoxCos.FormattingEnabled = True
        Me.lstBoxCos.ItemHeight = 16
        Me.lstBoxCos.Location = New System.Drawing.Point(223, 50)
        Me.lstBoxCos.Name = "lstBoxCos"
        Me.lstBoxCos.Size = New System.Drawing.Size(134, 164)
        Me.lstBoxCos.TabIndex = 1
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.txtQuery)
        Me.GroupBox2.Controls.Add(Me.btnSearch)
        Me.GroupBox2.Location = New System.Drawing.Point(35, 32)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(447, 88)
        Me.GroupBox2.TabIndex = 0
        Me.GroupBox2.TabStop = False
        '
        'txtSampleText
        '
        Me.txtSampleText.Font = New System.Drawing.Font("Visual Geez Unicode", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSampleText.Location = New System.Drawing.Point(17, 22)
        Me.txtSampleText.MaxLength = 1500
        Me.txtSampleText.Name = "txtSampleText"
        Me.txtSampleText.Size = New System.Drawing.Size(415, 51)
        Me.txtSampleText.TabIndex = 34
        Me.txtSampleText.Text = ""
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txtSampleText)
        Me.GroupBox3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox3.Location = New System.Drawing.Point(35, 359)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(447, 88)
        Me.GroupBox3.TabIndex = 35
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "የመረጡት ፋይል በአጭሩ የሚከተለውን ይመስላል"
        '
        'frmSearching
        '
        Me.AcceptButton = Me.btnSearch
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.CornflowerBlue
        Me.ClientSize = New System.Drawing.Size(511, 454)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Location = New System.Drawing.Point(200, 200)
        Me.Name = "frmSearching"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "የአማርኛ ኢንፎርሜሽን ሪትሪቫል ሲስተም - መረጃ መፈለጊያ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenOutputFile As System.Windows.Forms.Button
    Friend WithEvents btnSearch As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtQuery As System.Windows.Forms.TextBox
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ማስተካከያToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ዋናፋይሎችንማስተካከያToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheProgammersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IndexingToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents lstBoxOutput As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents lstBoxCos As System.Windows.Forms.ListBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txtSampleText As System.Windows.Forms.RichTextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class

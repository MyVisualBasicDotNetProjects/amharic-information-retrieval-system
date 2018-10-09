<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmIndexing
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
        Me.btnPerformIRS = New System.Windows.Forms.Button()
        Me.btnBrowse = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtFolderSelected = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SearchToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripSeparator()
        Me.ExitToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ማስተካከያToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ዋናፋይሎችንማስተካከያToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutTheProgammersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btnOpenOutputFile
        '
        Me.btnOpenOutputFile.Enabled = False
        Me.btnOpenOutputFile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOpenOutputFile.Location = New System.Drawing.Point(218, 136)
        Me.btnOpenOutputFile.Name = "btnOpenOutputFile"
        Me.btnOpenOutputFile.Size = New System.Drawing.Size(129, 29)
        Me.btnOpenOutputFile.TabIndex = 2
        Me.btnOpenOutputFile.Text = "ፋይሎቹን ክፈት"
        Me.btnOpenOutputFile.UseVisualStyleBackColor = True
        '
        'btnPerformIRS
        '
        Me.btnPerformIRS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnPerformIRS.Location = New System.Drawing.Point(76, 136)
        Me.btnPerformIRS.Name = "btnPerformIRS"
        Me.btnPerformIRS.Size = New System.Drawing.Size(113, 33)
        Me.btnPerformIRS.TabIndex = 1
        Me.btnPerformIRS.Text = "ማውጫ አዘጋጅ"
        Me.btnPerformIRS.UseVisualStyleBackColor = True
        '
        'btnBrowse
        '
        Me.btnBrowse.BackColor = System.Drawing.SystemColors.Highlight
        Me.btnBrowse.Location = New System.Drawing.Point(463, 86)
        Me.btnBrowse.Name = "btnBrowse"
        Me.btnBrowse.Size = New System.Drawing.Size(34, 23)
        Me.btnBrowse.TabIndex = 0
        Me.btnBrowse.Text = "..."
        Me.btnBrowse.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nyala", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(84, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 25)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "እባክዎን ፋይሎቹ የሚገኙበትን ቦታ ይጠቁሙ:"
        '
        'txtFolderSelected
        '
        Me.txtFolderSelected.Location = New System.Drawing.Point(25, 89)
        Me.txtFolderSelected.Name = "txtFolderSelected"
        Me.txtFolderSelected.ReadOnly = True
        Me.txtFolderSelected.Size = New System.Drawing.Size(407, 20)
        Me.txtFolderSelected.TabIndex = 20
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ማስተካከያToolStripMenuItem, Me.HelpToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(537, 24)
        Me.MenuStrip1.TabIndex = 25
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SearchToolStripMenuItem, Me.NewToolStripMenuItem, Me.ExitToolStripMenuItem, Me.ExitToolStripMenuItem1})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(41, 20)
        Me.FileToolStripMenuItem.Text = "ፋይል"
        '
        'SearchToolStripMenuItem
        '
        Me.SearchToolStripMenuItem.Name = "SearchToolStripMenuItem"
        Me.SearchToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.SearchToolStripMenuItem.Text = "ወደ መረጃ መፈለጊያ"
        '
        'NewToolStripMenuItem
        '
        Me.NewToolStripMenuItem.Name = "NewToolStripMenuItem"
        Me.NewToolStripMenuItem.Size = New System.Drawing.Size(151, 22)
        Me.NewToolStripMenuItem.Text = "አዲስ"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(148, 6)
        '
        'ExitToolStripMenuItem1
        '
        Me.ExitToolStripMenuItem1.Name = "ExitToolStripMenuItem1"
        Me.ExitToolStripMenuItem1.Size = New System.Drawing.Size(151, 22)
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
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.LawnGreen
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label2.Location = New System.Drawing.Point(378, 156)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 64)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "1 ቢኒያም አስናቀ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "2 ግርማ አወቀ" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "3 ሙዘይን ከድር" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "4 ነጋሲ ገብረእግዚአብሔር"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Yellow
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.SystemColors.HotTrack
        Me.Label3.Location = New System.Drawing.Point(372, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 18)
        Me.Label3.TabIndex = 27
        Me.Label3.Text = "የቡድኑ አባላት ዝርዝር"
        '
        'frmIndexing
        '
        Me.AcceptButton = Me.btnPerformIRS
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(537, 241)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnOpenOutputFile)
        Me.Controls.Add(Me.btnPerformIRS)
        Me.Controls.Add(Me.btnBrowse)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtFolderSelected)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmIndexing"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "የአማርኛ ኢንፎርሜሽን ሪትሪቫል ሲስተም - ማውጫ አዘጋጅ"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnOpenOutputFile As System.Windows.Forms.Button
    Friend WithEvents btnPerformIRS As System.Windows.Forms.Button
    Friend WithEvents btnBrowse As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtFolderSelected As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents FileToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NewToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ExitToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents HelpToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AboutTheProgammersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ማስተካከያToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ዋናፋይሎችንማስተካከያToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SearchToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem

End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEdit
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
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnBrowseStopWord = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtStopWord = New System.Windows.Forms.TextBox()
        Me.btnBrowsePrefix = New System.Windows.Forms.Button()
        Me.txtPrefix = New System.Windows.Forms.TextBox()
        Me.btnBrowseSuffix = New System.Windows.Forms.Button()
        Me.txtSuffix = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.SuspendLayout()
        '
        'btnSave
        '
        Me.btnSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSave.Location = New System.Drawing.Point(277, 188)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(113, 33)
        Me.btnSave.TabIndex = 28
        Me.btnSave.Text = "አስቀምጥ"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnBrowseStopWord
        '
        Me.btnBrowseStopWord.Location = New System.Drawing.Point(34, 62)
        Me.btnBrowseStopWord.Name = "btnBrowseStopWord"
        Me.btnBrowseStopWord.Size = New System.Drawing.Size(152, 23)
        Me.btnBrowseStopWord.TabIndex = 27
        Me.btnBrowseStopWord.Text = "የ STOPWORD ፋይል ይምረጡ"
        Me.btnBrowseStopWord.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Nyala", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(167, 18)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(323, 25)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "እባክዎን ፋይሎቹ የሚገኙበትን ቦታ ይጠቁሙ:"
        '
        'txtStopWord
        '
        Me.txtStopWord.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtStopWord.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtStopWord.Location = New System.Drawing.Point(207, 65)
        Me.txtStopWord.Name = "txtStopWord"
        Me.txtStopWord.ReadOnly = True
        Me.txtStopWord.Size = New System.Drawing.Size(407, 20)
        Me.txtStopWord.TabIndex = 25
        '
        'btnBrowsePrefix
        '
        Me.btnBrowsePrefix.Location = New System.Drawing.Point(34, 145)
        Me.btnBrowsePrefix.Name = "btnBrowsePrefix"
        Me.btnBrowsePrefix.Size = New System.Drawing.Size(152, 23)
        Me.btnBrowsePrefix.TabIndex = 31
        Me.btnBrowsePrefix.Text = "የ PREFIX ፋይል ይምረጡ"
        Me.btnBrowsePrefix.UseVisualStyleBackColor = True
        '
        'txtPrefix
        '
        Me.txtPrefix.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtPrefix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtPrefix.Location = New System.Drawing.Point(207, 145)
        Me.txtPrefix.Name = "txtPrefix"
        Me.txtPrefix.ReadOnly = True
        Me.txtPrefix.Size = New System.Drawing.Size(407, 20)
        Me.txtPrefix.TabIndex = 30
        '
        'btnBrowseSuffix
        '
        Me.btnBrowseSuffix.Location = New System.Drawing.Point(34, 105)
        Me.btnBrowseSuffix.Name = "btnBrowseSuffix"
        Me.btnBrowseSuffix.Size = New System.Drawing.Size(152, 23)
        Me.btnBrowseSuffix.TabIndex = 33
        Me.btnBrowseSuffix.Text = "የ SUFFIX ፋይል ይምረጡ"
        Me.btnBrowseSuffix.UseVisualStyleBackColor = True
        '
        'txtSuffix
        '
        Me.txtSuffix.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtSuffix.ForeColor = System.Drawing.SystemColors.WindowText
        Me.txtSuffix.Location = New System.Drawing.Point(207, 108)
        Me.txtSuffix.Name = "txtSuffix"
        Me.txtSuffix.ReadOnly = True
        Me.txtSuffix.Size = New System.Drawing.Size(407, 20)
        Me.txtSuffix.TabIndex = 32
        '
        'FolderBrowserDialog1
        '
        Me.FolderBrowserDialog1.SelectedPath = " "
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'frmEdit
        '
        Me.AcceptButton = Me.btnSave
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Orange
        Me.ClientSize = New System.Drawing.Size(653, 237)
        Me.Controls.Add(Me.btnBrowseSuffix)
        Me.Controls.Add(Me.txtSuffix)
        Me.Controls.Add(Me.btnBrowsePrefix)
        Me.Controls.Add(Me.txtPrefix)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.btnBrowseStopWord)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStopWord)
        Me.Name = "frmEdit"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ማስተካከያ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnBrowseStopWord As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtStopWord As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowsePrefix As System.Windows.Forms.Button
    Friend WithEvents txtPrefix As System.Windows.Forms.TextBox
    Friend WithEvents btnBrowseSuffix As System.Windows.Forms.Button
    Friend WithEvents txtSuffix As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
End Class

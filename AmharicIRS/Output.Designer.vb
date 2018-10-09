<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOutput
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtVocabularyFile = New System.Windows.Forms.TextBox()
        Me.txtPostingFile = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(85, 6)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 25)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "የ ቮካብለሪ ፋይል"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(555, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 25)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "የ ፖስቲንግ ፋይል"
        '
        'txtVocabularyFile
        '
        Me.txtVocabularyFile.Location = New System.Drawing.Point(1, 37)
        Me.txtVocabularyFile.Multiline = True
        Me.txtVocabularyFile.Name = "txtVocabularyFile"
        Me.txtVocabularyFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtVocabularyFile.Size = New System.Drawing.Size(375, 503)
        Me.txtVocabularyFile.TabIndex = 8
        '
        'txtPostingFile
        '
        Me.txtPostingFile.Location = New System.Drawing.Point(382, 37)
        Me.txtPostingFile.Multiline = True
        Me.txtPostingFile.Name = "txtPostingFile"
        Me.txtPostingFile.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtPostingFile.Size = New System.Drawing.Size(645, 503)
        Me.txtPostingFile.TabIndex = 9
        '
        'frmOutput
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(1039, 549)
        Me.Controls.Add(Me.txtPostingFile)
        Me.Controls.Add(Me.txtVocabularyFile)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmOutput"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "የ ቮካቤለሪና ፖስቲንግ ፋይሎች"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtVocabularyFile As System.Windows.Forms.TextBox
    Friend WithEvents txtPostingFile As System.Windows.Forms.TextBox
End Class

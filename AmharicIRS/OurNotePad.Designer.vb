<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmOurNotePad
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
        Me.lblNotePadName = New System.Windows.Forms.Label()
        Me.txtNotePad2 = New System.Windows.Forms.TextBox()
        Me.txtNotePad = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'lblNotePadName
        '
        Me.lblNotePadName.AutoSize = True
        Me.lblNotePadName.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNotePadName.Location = New System.Drawing.Point(188, 9)
        Me.lblNotePadName.Name = "lblNotePadName"
        Me.lblNotePadName.Size = New System.Drawing.Size(134, 25)
        Me.lblNotePadName.TabIndex = 10
        Me.lblNotePadName.Text = "የመረጡት ፋይል"
        '
        'txtNotePad2
        '
        Me.txtNotePad2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotePad2.Location = New System.Drawing.Point(308, 130)
        Me.txtNotePad2.Multiline = True
        Me.txtNotePad2.Name = "txtNotePad2"
        Me.txtNotePad2.ScrollBars = System.Windows.Forms.ScrollBars.Both
        Me.txtNotePad2.Size = New System.Drawing.Size(61, 39)
        Me.txtNotePad2.TabIndex = 15
        '
        'txtNotePad
        '
        Me.txtNotePad.Font = New System.Drawing.Font("Visual Geez Unicode", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNotePad.Location = New System.Drawing.Point(0, 37)
        Me.txtNotePad.Name = "txtNotePad"
        Me.txtNotePad.Size = New System.Drawing.Size(558, 470)
        Me.txtNotePad.TabIndex = 16
        Me.txtNotePad.Text = ""
        '
        'frmOurNotePad
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(558, 507)
        Me.Controls.Add(Me.txtNotePad)
        Me.Controls.Add(Me.txtNotePad2)
        Me.Controls.Add(Me.lblNotePadName)
        Me.Name = "frmOurNotePad"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "የመረጡት ፋይል"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblNotePadName As System.Windows.Forms.Label
    Friend WithEvents txtNotePad2 As System.Windows.Forms.TextBox
    Friend WithEvents txtNotePad As System.Windows.Forms.RichTextBox
End Class

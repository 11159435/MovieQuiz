<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblmessage = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.Button2 = New System.Windows.Forms.Button
        Me.lstHighscore = New System.Windows.Forms.ListBox
        Me.SuspendLayout()
        '
        'lblmessage
        '
        Me.lblmessage.AutoSize = True
        Me.lblmessage.Font = New System.Drawing.Font("Georgia", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.Location = New System.Drawing.Point(12, 19)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(494, 18)
        Me.lblmessage.TabIndex = 1
        Me.lblmessage.Text = "Congratulations Your Score Will Be Added To The Hall Of Fame"
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(509, 265)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(153, 56)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Play Again"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(509, 327)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(153, 56)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'lstHighscore
        '
        Me.lstHighscore.FormattingEnabled = True
        Me.lstHighscore.Location = New System.Drawing.Point(30, 62)
        Me.lstHighscore.Name = "lstHighscore"
        Me.lstHighscore.Size = New System.Drawing.Size(454, 316)
        Me.lstHighscore.TabIndex = 4
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 405)
        Me.Controls.Add(Me.lstHighscore)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.lblmessage)
        Me.Name = "frmHighScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents lstHighscore As System.Windows.Forms.ListBox
End Class

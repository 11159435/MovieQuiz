<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmHighScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.lblMessage = New System.Windows.Forms.Label()
        Me.doScore = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnQuit.Location = New System.Drawing.Point(501, 332)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(173, 61)
        Me.btnQuit.TabIndex = 0
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'btnAgain
        '
        Me.btnAgain.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.btnAgain.Location = New System.Drawing.Point(501, 261)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(173, 61)
        Me.btnAgain.TabIndex = 1
        Me.btnAgain.Text = "Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'lblMessage
        '
        Me.lblMessage.AutoSize = True
        Me.lblMessage.Location = New System.Drawing.Point(19, 23)
        Me.lblMessage.Name = "lblMessage"
        Me.lblMessage.Size = New System.Drawing.Size(39, 13)
        Me.lblMessage.TabIndex = 2
        Me.lblMessage.Text = "Label1"
        '
        'doScore
        '
        Me.doScore.FormattingEnabled = True
        Me.doScore.Location = New System.Drawing.Point(45, 73)
        Me.doScore.Name = "doScore"
        Me.doScore.Size = New System.Drawing.Size(310, 212)
        Me.doScore.TabIndex = 3
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 405)
        Me.Controls.Add(Me.doScore)
        Me.Controls.Add(Me.lblMessage)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.btnQuit)
        Me.Name = "frmHighScore"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuit As Button
    Friend WithEvents btnAgain As Button
    Friend WithEvents lblMessage As Label
    Friend WithEvents doScore As ListBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion3
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
        Me.components = New System.ComponentModel.Container
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion3))
        Me.ProgressBarQ3 = New System.Windows.Forms.ProgressBar
        Me.btnNext = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.tmrQ3 = New System.Windows.Forms.Timer(Me.components)
        Me.picNicoleKidman = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picNicoleKidman, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarQ3
        '
        Me.ProgressBarQ3.Location = New System.Drawing.Point(39, 364)
        Me.ProgressBarQ3.Name = "ProgressBarQ3"
        Me.ProgressBarQ3.Size = New System.Drawing.Size(607, 39)
        Me.ProgressBarQ3.TabIndex = 11
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(511, 267)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(136, 42)
        Me.btnNext.TabIndex = 10
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Location = New System.Drawing.Point(47, 135)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 188)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Location = New System.Drawing.Point(23, 151)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer4.TabIndex = 3
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "1962"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Location = New System.Drawing.Point(23, 110)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer3.TabIndex = 2
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "1966"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Location = New System.Drawing.Point(23, 70)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer2.TabIndex = 1
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "1975"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Location = New System.Drawing.Point(23, 27)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(49, 17)
        Me.btnAnswer1.TabIndex = 0
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "1987"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(435, 62)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "What year was the first" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "James Bond film released? (Dr No)"
        '
        'tmrQ3
        '
        Me.tmrQ3.Interval = 1000
        '
        'picNicoleKidman
        '
        Me.picNicoleKidman.Image = CType(resources.GetObject("picNicoleKidman.Image"), System.Drawing.Image)
        Me.picNicoleKidman.Location = New System.Drawing.Point(494, 49)
        Me.picNicoleKidman.Name = "picNicoleKidman"
        Me.picNicoleKidman.Size = New System.Drawing.Size(180, 186)
        Me.picNicoleKidman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNicoleKidman.TabIndex = 12
        Me.picNicoleKidman.TabStop = False
        '
        'frmQuestion3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 440)
        Me.Controls.Add(Me.picNicoleKidman)
        Me.Controls.Add(Me.ProgressBarQ3)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuestion3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "James Bond"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picNicoleKidman, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBarQ3 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnswer4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrQ3 As System.Windows.Forms.Timer
    Friend WithEvents picNicoleKidman As System.Windows.Forms.PictureBox
End Class

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion1))
        Me.Label1 = New System.Windows.Forms.Label
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton
        Me.btnNext = New System.Windows.Forms.Button
        Me.ProgressBarQ1 = New System.Windows.Forms.ProgressBar
        Me.tmrQ1 = New System.Windows.Forms.Timer(Me.components)
        Me.picAudreyHepburn = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picAudreyHepburn, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(332, 62)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "What year was the original" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Jaws film released?"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnAnswer4)
        Me.GroupBox1.Controls.Add(Me.btnAnswer3)
        Me.GroupBox1.Controls.Add(Me.btnAnswer2)
        Me.GroupBox1.Controls.Add(Me.btnAnswer1)
        Me.GroupBox1.Location = New System.Drawing.Point(38, 144)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(349, 188)
        Me.GroupBox1.TabIndex = 1
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
        Me.btnAnswer4.Text = "1971"
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
        Me.btnAnswer3.Text = "1973"
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
        Me.btnAnswer1.Text = "1981"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(502, 276)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(136, 42)
        Me.btnNext.TabIndex = 2
        Me.btnNext.Text = "Next"
        Me.btnNext.UseVisualStyleBackColor = True
        '
        'ProgressBarQ1
        '
        Me.ProgressBarQ1.Location = New System.Drawing.Point(30, 373)
        Me.ProgressBarQ1.Name = "ProgressBarQ1"
        Me.ProgressBarQ1.Size = New System.Drawing.Size(607, 39)
        Me.ProgressBarQ1.TabIndex = 3
        '
        'tmrQ1
        '
        Me.tmrQ1.Interval = 1000
        '
        'picAudreyHepburn
        '
        Me.picAudreyHepburn.Image = CType(resources.GetObject("picAudreyHepburn.Image"), System.Drawing.Image)
        Me.picAudreyHepburn.Location = New System.Drawing.Point(441, 47)
        Me.picAudreyHepburn.Name = "picAudreyHepburn"
        Me.picAudreyHepburn.Size = New System.Drawing.Size(196, 202)
        Me.picAudreyHepburn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAudreyHepburn.TabIndex = 4
        Me.picAudreyHepburn.TabStop = False
        '
        'frmQuestion1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 440)
        Me.Controls.Add(Me.picAudreyHepburn)
        Me.Controls.Add(Me.ProgressBarQ1)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQuestion1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Jaws"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picAudreyHepburn, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnswer4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer1 As System.Windows.Forms.RadioButton
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents ProgressBarQ1 As System.Windows.Forms.ProgressBar
    Friend WithEvents tmrQ1 As System.Windows.Forms.Timer
    Friend WithEvents picAudreyHepburn As System.Windows.Forms.PictureBox
End Class

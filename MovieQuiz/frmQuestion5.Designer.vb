<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQuestion5
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmQuestion5))
        Me.ProgressBarQ5 = New System.Windows.Forms.ProgressBar
        Me.btnNext = New System.Windows.Forms.Button
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.btnAnswer4 = New System.Windows.Forms.RadioButton
        Me.btnAnswer3 = New System.Windows.Forms.RadioButton
        Me.btnAnswer2 = New System.Windows.Forms.RadioButton
        Me.btnAnswer1 = New System.Windows.Forms.RadioButton
        Me.Label1 = New System.Windows.Forms.Label
        Me.tmrQ5 = New System.Windows.Forms.Timer(Me.components)
        Me.picDarthVader = New System.Windows.Forms.PictureBox
        Me.GroupBox1.SuspendLayout()
        CType(Me.picDarthVader, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ProgressBarQ5
        '
        Me.ProgressBarQ5.Location = New System.Drawing.Point(39, 364)
        Me.ProgressBarQ5.Name = "ProgressBarQ5"
        Me.ProgressBarQ5.Size = New System.Drawing.Size(607, 39)
        Me.ProgressBarQ5.TabIndex = 15
        '
        'btnNext
        '
        Me.btnNext.Font = New System.Drawing.Font("Perpetua", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnNext.Location = New System.Drawing.Point(511, 267)
        Me.btnNext.Name = "btnNext"
        Me.btnNext.Size = New System.Drawing.Size(136, 42)
        Me.btnNext.TabIndex = 14
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
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'btnAnswer4
        '
        Me.btnAnswer4.AutoSize = True
        Me.btnAnswer4.Location = New System.Drawing.Point(23, 151)
        Me.btnAnswer4.Name = "btnAnswer4"
        Me.btnAnswer4.Size = New System.Drawing.Size(92, 17)
        Me.btnAnswer4.TabIndex = 3
        Me.btnAnswer4.TabStop = True
        Me.btnAnswer4.Text = "Russell Crowe"
        Me.btnAnswer4.UseVisualStyleBackColor = True
        '
        'btnAnswer3
        '
        Me.btnAnswer3.AutoSize = True
        Me.btnAnswer3.Location = New System.Drawing.Point(23, 110)
        Me.btnAnswer3.Name = "btnAnswer3"
        Me.btnAnswer3.Size = New System.Drawing.Size(65, 17)
        Me.btnAnswer3.TabIndex = 2
        Me.btnAnswer3.TabStop = True
        Me.btnAnswer3.Text = "Brad Pitt"
        Me.btnAnswer3.UseVisualStyleBackColor = True
        '
        'btnAnswer2
        '
        Me.btnAnswer2.AutoSize = True
        Me.btnAnswer2.Location = New System.Drawing.Point(23, 70)
        Me.btnAnswer2.Name = "btnAnswer2"
        Me.btnAnswer2.Size = New System.Drawing.Size(72, 17)
        Me.btnAnswer2.TabIndex = 1
        Me.btnAnswer2.TabStop = True
        Me.btnAnswer2.Text = "Vin Diesel"
        Me.btnAnswer2.UseVisualStyleBackColor = True
        '
        'btnAnswer1
        '
        Me.btnAnswer1.AutoSize = True
        Me.btnAnswer1.Location = New System.Drawing.Point(23, 27)
        Me.btnAnswer1.Name = "btnAnswer1"
        Me.btnAnswer1.Size = New System.Drawing.Size(95, 17)
        Me.btnAnswer1.TabIndex = 0
        Me.btnAnswer1.TabStop = True
        Me.btnAnswer1.Text = "Jason Statham"
        Me.btnAnswer1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(64, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(375, 31)
        Me.Label1.TabIndex = 16
        Me.Label1.Text = "Gladiator's main actor is who?"
        '
        'tmrQ5
        '
        Me.tmrQ5.Interval = 1000
        '
        'picDarthVader
        '
        Me.picDarthVader.Image = CType(resources.GetObject("picDarthVader.Image"), System.Drawing.Image)
        Me.picDarthVader.Location = New System.Drawing.Point(445, 34)
        Me.picDarthVader.Name = "picDarthVader"
        Me.picDarthVader.Size = New System.Drawing.Size(202, 204)
        Me.picDarthVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDarthVader.TabIndex = 17
        Me.picDarthVader.TabStop = False
        '
        'frmQuestion5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 440)
        Me.Controls.Add(Me.picDarthVader)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ProgressBarQ5)
        Me.Controls.Add(Me.btnNext)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "frmQuestion5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Gladiator"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.picDarthVader, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ProgressBarQ5 As System.Windows.Forms.ProgressBar
    Friend WithEvents btnNext As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnAnswer4 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer3 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer2 As System.Windows.Forms.RadioButton
    Friend WithEvents btnAnswer1 As System.Windows.Forms.RadioButton
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents tmrQ5 As System.Windows.Forms.Timer
    Friend WithEvents picDarthVader As System.Windows.Forms.PictureBox
End Class

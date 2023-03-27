<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.lblTitle = New System.Windows.Forms.Label
        Me.btnStart = New System.Windows.Forms.Button
        Me.picAudreyHepburn = New System.Windows.Forms.PictureBox
        Me.picArnoldSchwarzenegger = New System.Windows.Forms.PictureBox
        Me.picNicoleKidman = New System.Windows.Forms.PictureBox
        Me.pic101Dalmations = New System.Windows.Forms.PictureBox
        Me.picDarthVader = New System.Windows.Forms.PictureBox
        Me.wmpQuiz = New AxWMPLib.AxWindowsMediaPlayer
        Me.txtName = New System.Windows.Forms.TextBox
        Me.lblName = New System.Windows.Forms.Label
        Me.btnQuit = New System.Windows.Forms.Button
        CType(Me.picAudreyHepburn, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picArnoldSchwarzenegger, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picNicoleKidman, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pic101Dalmations, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picDarthVader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.wmpQuiz, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(176, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(173, 40)
        Me.lblTitle.TabIndex = 0
        Me.lblTitle.Text = "Movie Quiz"
        '
        'btnStart
        '
        Me.btnStart.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(516, 341)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(138, 47)
        Me.btnStart.TabIndex = 1
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'picAudreyHepburn
        '
        Me.picAudreyHepburn.Image = CType(resources.GetObject("picAudreyHepburn.Image"), System.Drawing.Image)
        Me.picAudreyHepburn.Location = New System.Drawing.Point(34, 79)
        Me.picAudreyHepburn.Name = "picAudreyHepburn"
        Me.picAudreyHepburn.Size = New System.Drawing.Size(100, 100)
        Me.picAudreyHepburn.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picAudreyHepburn.TabIndex = 2
        Me.picAudreyHepburn.TabStop = False
        '
        'picArnoldSchwarzenegger
        '
        Me.picArnoldSchwarzenegger.Image = CType(resources.GetObject("picArnoldSchwarzenegger.Image"), System.Drawing.Image)
        Me.picArnoldSchwarzenegger.Location = New System.Drawing.Point(161, 158)
        Me.picArnoldSchwarzenegger.Name = "picArnoldSchwarzenegger"
        Me.picArnoldSchwarzenegger.Size = New System.Drawing.Size(100, 100)
        Me.picArnoldSchwarzenegger.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picArnoldSchwarzenegger.TabIndex = 3
        Me.picArnoldSchwarzenegger.TabStop = False
        '
        'picNicoleKidman
        '
        Me.picNicoleKidman.Image = CType(resources.GetObject("picNicoleKidman.Image"), System.Drawing.Image)
        Me.picNicoleKidman.Location = New System.Drawing.Point(290, 79)
        Me.picNicoleKidman.Name = "picNicoleKidman"
        Me.picNicoleKidman.Size = New System.Drawing.Size(100, 100)
        Me.picNicoleKidman.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picNicoleKidman.TabIndex = 4
        Me.picNicoleKidman.TabStop = False
        '
        'pic101Dalmations
        '
        Me.pic101Dalmations.Image = CType(resources.GetObject("pic101Dalmations.Image"), System.Drawing.Image)
        Me.pic101Dalmations.Location = New System.Drawing.Point(420, 158)
        Me.pic101Dalmations.Name = "pic101Dalmations"
        Me.pic101Dalmations.Size = New System.Drawing.Size(100, 100)
        Me.pic101Dalmations.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.pic101Dalmations.TabIndex = 5
        Me.pic101Dalmations.TabStop = False
        '
        'picDarthVader
        '
        Me.picDarthVader.Image = CType(resources.GetObject("picDarthVader.Image"), System.Drawing.Image)
        Me.picDarthVader.Location = New System.Drawing.Point(554, 79)
        Me.picDarthVader.Name = "picDarthVader"
        Me.picDarthVader.Size = New System.Drawing.Size(100, 100)
        Me.picDarthVader.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picDarthVader.TabIndex = 6
        Me.picDarthVader.TabStop = False
        '
        'wmpQuiz
        '
        Me.wmpQuiz.Enabled = True
        Me.wmpQuiz.Location = New System.Drawing.Point(599, 9)
        Me.wmpQuiz.Name = "wmpQuiz"
        Me.wmpQuiz.OcxState = CType(resources.GetObject("wmpQuiz.OcxState"), System.Windows.Forms.AxHost.State)
        Me.wmpQuiz.Size = New System.Drawing.Size(75, 23)
        Me.wmpQuiz.TabIndex = 7
        Me.wmpQuiz.Visible = False
        '
        'txtName
        '
        Me.txtName.Font = New System.Drawing.Font("Comic Sans MS", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtName.Location = New System.Drawing.Point(189, 341)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(201, 34)
        Me.txtName.TabIndex = 8
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Font = New System.Drawing.Font("Comic Sans MS", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblName.Location = New System.Drawing.Point(29, 341)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(142, 30)
        Me.lblName.TabIndex = 9
        Me.lblName.Text = "Player Name"
        '
        'btnQuit
        '
        Me.btnQuit.Font = New System.Drawing.Font("Comic Sans MS", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(516, 288)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(138, 47)
        Me.btnQuit.TabIndex = 10
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(686, 405)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.wmpQuiz)
        Me.Controls.Add(Me.picDarthVader)
        Me.Controls.Add(Me.pic101Dalmations)
        Me.Controls.Add(Me.picNicoleKidman)
        Me.Controls.Add(Me.picArnoldSchwarzenegger)
        Me.Controls.Add(Me.picAudreyHepburn)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblTitle)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "My Movie Quiz"
        CType(Me.picAudreyHepburn, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picArnoldSchwarzenegger, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picNicoleKidman, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pic101Dalmations, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picDarthVader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.wmpQuiz, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents btnStart As System.Windows.Forms.Button
    Friend WithEvents picAudreyHepburn As System.Windows.Forms.PictureBox
    Friend WithEvents picArnoldSchwarzenegger As System.Windows.Forms.PictureBox
    Friend WithEvents picNicoleKidman As System.Windows.Forms.PictureBox
    Friend WithEvents pic101Dalmations As System.Windows.Forms.PictureBox
    Friend WithEvents picDarthVader As System.Windows.Forms.PictureBox
    Friend WithEvents wmpQuiz As AxWMPLib.AxWindowsMediaPlayer
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents btnQuit As System.Windows.Forms.Button

End Class

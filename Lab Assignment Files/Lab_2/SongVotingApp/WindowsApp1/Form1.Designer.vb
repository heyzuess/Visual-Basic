<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.GenreList = New System.Windows.Forms.ComboBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Song1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Song2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Song3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.VoteButton = New System.Windows.Forms.Button()
        Me.GenreVoteCount = New System.Windows.Forms.Label()
        Me.GenreVoteCountLabel = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GenreList
        '
        Me.GenreList.FormattingEnabled = True
        Me.GenreList.Location = New System.Drawing.Point(128, 19)
        Me.GenreList.Name = "GenreList"
        Me.GenreList.Size = New System.Drawing.Size(139, 21)
        Me.GenreList.TabIndex = 0
        '
        'PictureBox1
        '
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox1.Location = New System.Drawing.Point(24, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(287, 282)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 1
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Label1.Location = New System.Drawing.Point(32, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Select a genre:"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Song1
        '
        Me.Song1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Song1.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Song1.Location = New System.Drawing.Point(56, 108)
        Me.Song1.Name = "Song1"
        Me.Song1.Size = New System.Drawing.Size(234, 40)
        Me.Song1.TabIndex = 3
        Me.Song1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 108)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 40)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "1"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label3
        '
        Me.Label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 167)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(43, 40)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "2"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Song2
        '
        Me.Song2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Song2.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Song2.Location = New System.Drawing.Point(56, 167)
        Me.Song2.Name = "Song2"
        Me.Song2.Size = New System.Drawing.Size(234, 40)
        Me.Song2.TabIndex = 5
        Me.Song2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label5
        '
        Me.Label5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(7, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(43, 40)
        Me.Label5.TabIndex = 8
        Me.Label5.Text = "3"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Song3
        '
        Me.Song3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Song3.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Song3.Location = New System.Drawing.Point(56, 228)
        Me.Song3.Name = "Song3"
        Me.Song3.Size = New System.Drawing.Size(234, 40)
        Me.Song3.TabIndex = 7
        Me.Song3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.VoteButton)
        Me.GroupBox1.Controls.Add(Me.GenreVoteCount)
        Me.GroupBox1.Controls.Add(Me.GenreVoteCountLabel)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Song3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Song2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Song1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.GenreList)
        Me.GroupBox1.Location = New System.Drawing.Point(315, 6)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(299, 288)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        '
        'VoteButton
        '
        Me.VoteButton.Location = New System.Drawing.Point(193, 53)
        Me.VoteButton.Name = "VoteButton"
        Me.VoteButton.Size = New System.Drawing.Size(75, 23)
        Me.VoteButton.TabIndex = 11
        Me.VoteButton.Text = "Vote"
        Me.VoteButton.UseVisualStyleBackColor = True
        '
        'GenreVoteCount
        '
        Me.GenreVoteCount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.GenreVoteCount.Location = New System.Drawing.Point(128, 53)
        Me.GenreVoteCount.Name = "GenreVoteCount"
        Me.GenreVoteCount.Size = New System.Drawing.Size(48, 23)
        Me.GenreVoteCount.TabIndex = 10
        Me.GenreVoteCount.Text = "0"
        Me.GenreVoteCount.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'GenreVoteCountLabel
        '
        Me.GenreVoteCountLabel.Location = New System.Drawing.Point(11, 53)
        Me.GenreVoteCountLabel.Name = "GenreVoteCountLabel"
        Me.GenreVoteCountLabel.Size = New System.Drawing.Size(100, 23)
        Me.GenreVoteCountLabel.TabIndex = 9
        Me.GenreVoteCountLabel.Text = "Vote Count:"
        Me.GenreVoteCountLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(621, 322)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Name = "Form1"
        Me.Text = "Song Voting App"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GenreList As ComboBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Song1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Song2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Song3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents VoteButton As Button
    Friend WithEvents GenreVoteCount As Label
    Friend WithEvents GenreVoteCountLabel As Label
End Class

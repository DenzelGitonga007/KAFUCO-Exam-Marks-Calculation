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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.title_lbl = New System.Windows.Forms.Label()
        Me.cat1_marks_lbl = New System.Windows.Forms.Label()
        Me.cat2_marks_lbl = New System.Windows.Forms.Label()
        Me.assignment_lbl = New System.Windows.Forms.Label()
        Me.cat1_txt = New System.Windows.Forms.TextBox()
        Me.assignment_txt = New System.Windows.Forms.TextBox()
        Me.cat2_txt = New System.Windows.Forms.TextBox()
        Me.coursework_txt = New System.Windows.Forms.TextBox()
        Me.exam_lbl = New System.Windows.Forms.Label()
        Me.exam_txt = New System.Windows.Forms.TextBox()
        Me.total_score_btn = New System.Windows.Forms.Button()
        Me.total_score_txt = New System.Windows.Forms.TextBox()
        Me.reset_btn = New System.Windows.Forms.Button()
        Me.quit_btn = New System.Windows.Forms.Button()
        Me.course_work_lbl = New System.Windows.Forms.Label()
        Me.system_panel = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.system_panel.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'title_lbl
        '
        Me.title_lbl.AutoSize = True
        Me.title_lbl.Font = New System.Drawing.Font("Arial", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.title_lbl.ForeColor = System.Drawing.Color.White
        Me.title_lbl.Location = New System.Drawing.Point(77, 22)
        Me.title_lbl.Name = "title_lbl"
        Me.title_lbl.Size = New System.Drawing.Size(540, 34)
        Me.title_lbl.TabIndex = 0
        Me.title_lbl.Text = "KAFUCO EXAM MARKS PROCESSING"
        '
        'cat1_marks_lbl
        '
        Me.cat1_marks_lbl.AutoSize = True
        Me.cat1_marks_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cat1_marks_lbl.ForeColor = System.Drawing.Color.White
        Me.cat1_marks_lbl.Location = New System.Drawing.Point(88, 155)
        Me.cat1_marks_lbl.Name = "cat1_marks_lbl"
        Me.cat1_marks_lbl.Size = New System.Drawing.Size(200, 25)
        Me.cat1_marks_lbl.TabIndex = 1
        Me.cat1_marks_lbl.Text = "Enter CAT 1 Marks:"
        '
        'cat2_marks_lbl
        '
        Me.cat2_marks_lbl.AutoSize = True
        Me.cat2_marks_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.cat2_marks_lbl.ForeColor = System.Drawing.Color.White
        Me.cat2_marks_lbl.Location = New System.Drawing.Point(88, 208)
        Me.cat2_marks_lbl.Name = "cat2_marks_lbl"
        Me.cat2_marks_lbl.Size = New System.Drawing.Size(200, 25)
        Me.cat2_marks_lbl.TabIndex = 2
        Me.cat2_marks_lbl.Text = "Enter CAT 2 Marks:"
        '
        'assignment_lbl
        '
        Me.assignment_lbl.AutoSize = True
        Me.assignment_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.assignment_lbl.ForeColor = System.Drawing.Color.White
        Me.assignment_lbl.Location = New System.Drawing.Point(88, 262)
        Me.assignment_lbl.Name = "assignment_lbl"
        Me.assignment_lbl.Size = New System.Drawing.Size(252, 25)
        Me.assignment_lbl.TabIndex = 3
        Me.assignment_lbl.Text = "Enter Assignment Marks:"
        '
        'cat1_txt
        '
        Me.cat1_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cat1_txt.Location = New System.Drawing.Point(346, 155)
        Me.cat1_txt.Name = "cat1_txt"
        Me.cat1_txt.Size = New System.Drawing.Size(131, 29)
        Me.cat1_txt.TabIndex = 4
        '
        'assignment_txt
        '
        Me.assignment_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.assignment_txt.Location = New System.Drawing.Point(346, 260)
        Me.assignment_txt.Name = "assignment_txt"
        Me.assignment_txt.Size = New System.Drawing.Size(131, 29)
        Me.assignment_txt.TabIndex = 5
        '
        'cat2_txt
        '
        Me.cat2_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.cat2_txt.Location = New System.Drawing.Point(346, 208)
        Me.cat2_txt.Name = "cat2_txt"
        Me.cat2_txt.Size = New System.Drawing.Size(131, 29)
        Me.cat2_txt.TabIndex = 6
        '
        'coursework_txt
        '
        Me.coursework_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.coursework_txt.Location = New System.Drawing.Point(297, 362)
        Me.coursework_txt.Name = "coursework_txt"
        Me.coursework_txt.Size = New System.Drawing.Size(100, 29)
        Me.coursework_txt.TabIndex = 8
        '
        'exam_lbl
        '
        Me.exam_lbl.AutoSize = True
        Me.exam_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.exam_lbl.ForeColor = System.Drawing.Color.White
        Me.exam_lbl.Location = New System.Drawing.Point(88, 316)
        Me.exam_lbl.Name = "exam_lbl"
        Me.exam_lbl.Size = New System.Drawing.Size(194, 25)
        Me.exam_lbl.TabIndex = 9
        Me.exam_lbl.Text = "Enter Exam Marks:"
        '
        'exam_txt
        '
        Me.exam_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!)
        Me.exam_txt.Location = New System.Drawing.Point(346, 312)
        Me.exam_txt.Name = "exam_txt"
        Me.exam_txt.Size = New System.Drawing.Size(131, 29)
        Me.exam_txt.TabIndex = 10
        '
        'total_score_btn
        '
        Me.total_score_btn.BackColor = System.Drawing.Color.White
        Me.total_score_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_score_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.total_score_btn.Location = New System.Drawing.Point(136, 423)
        Me.total_score_btn.Name = "total_score_btn"
        Me.total_score_btn.Size = New System.Drawing.Size(124, 29)
        Me.total_score_btn.TabIndex = 11
        Me.total_score_btn.Text = "Total Score"
        Me.total_score_btn.UseVisualStyleBackColor = False
        '
        'total_score_txt
        '
        Me.total_score_txt.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.total_score_txt.Location = New System.Drawing.Point(297, 423)
        Me.total_score_txt.Name = "total_score_txt"
        Me.total_score_txt.Size = New System.Drawing.Size(100, 29)
        Me.total_score_txt.TabIndex = 12
        '
        'reset_btn
        '
        Me.reset_btn.BackColor = System.Drawing.Color.White
        Me.reset_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.reset_btn.Location = New System.Drawing.Point(179, 488)
        Me.reset_btn.Name = "reset_btn"
        Me.reset_btn.Size = New System.Drawing.Size(109, 35)
        Me.reset_btn.TabIndex = 13
        Me.reset_btn.Text = "Reset"
        Me.reset_btn.UseVisualStyleBackColor = False
        '
        'quit_btn
        '
        Me.quit_btn.BackColor = System.Drawing.Color.White
        Me.quit_btn.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.quit_btn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.quit_btn.Location = New System.Drawing.Point(303, 488)
        Me.quit_btn.Name = "quit_btn"
        Me.quit_btn.Size = New System.Drawing.Size(109, 35)
        Me.quit_btn.TabIndex = 14
        Me.quit_btn.Text = "Quit"
        Me.quit_btn.UseVisualStyleBackColor = False
        '
        'course_work_lbl
        '
        Me.course_work_lbl.AutoSize = True
        Me.course_work_lbl.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!)
        Me.course_work_lbl.ForeColor = System.Drawing.Color.White
        Me.course_work_lbl.Location = New System.Drawing.Point(131, 366)
        Me.course_work_lbl.Name = "course_work_lbl"
        Me.course_work_lbl.Size = New System.Drawing.Size(143, 25)
        Me.course_work_lbl.TabIndex = 15
        Me.course_work_lbl.Text = "Course Work:"
        '
        'system_panel
        '
        Me.system_panel.BackColor = System.Drawing.Color.Transparent
        Me.system_panel.Controls.Add(Me.PictureBox1)
        Me.system_panel.Controls.Add(Me.quit_btn)
        Me.system_panel.Controls.Add(Me.title_lbl)
        Me.system_panel.Controls.Add(Me.exam_lbl)
        Me.system_panel.Controls.Add(Me.course_work_lbl)
        Me.system_panel.Controls.Add(Me.reset_btn)
        Me.system_panel.Controls.Add(Me.total_score_txt)
        Me.system_panel.Controls.Add(Me.assignment_lbl)
        Me.system_panel.Controls.Add(Me.cat1_txt)
        Me.system_panel.Controls.Add(Me.cat2_marks_lbl)
        Me.system_panel.Controls.Add(Me.total_score_btn)
        Me.system_panel.Controls.Add(Me.exam_txt)
        Me.system_panel.Controls.Add(Me.coursework_txt)
        Me.system_panel.Controls.Add(Me.cat1_marks_lbl)
        Me.system_panel.Controls.Add(Me.cat2_txt)
        Me.system_panel.Controls.Add(Me.assignment_txt)
        Me.system_panel.Location = New System.Drawing.Point(68, 34)
        Me.system_panel.Name = "system_panel"
        Me.system_panel.Size = New System.Drawing.Size(663, 539)
        Me.system_panel.TabIndex = 16
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(297, 59)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(115, 86)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 16
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 601)
        Me.Controls.Add(Me.system_panel)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Kafuco Exam Marks Processing"
        Me.system_panel.ResumeLayout(False)
        Me.system_panel.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents title_lbl As Label
    Friend WithEvents cat1_marks_lbl As Label
    Friend WithEvents cat2_marks_lbl As Label
    Friend WithEvents assignment_lbl As Label
    Friend WithEvents cat1_txt As TextBox
    Friend WithEvents assignment_txt As TextBox
    Friend WithEvents cat2_txt As TextBox
    Friend WithEvents coursework_txt As TextBox
    Friend WithEvents exam_lbl As Label
    Friend WithEvents exam_txt As TextBox
    Friend WithEvents total_score_btn As Button
    Friend WithEvents total_score_txt As TextBox
    Friend WithEvents reset_btn As Button
    Friend WithEvents quit_btn As Button
    Friend WithEvents course_work_lbl As Label
    Friend WithEvents system_panel As Panel
    Friend WithEvents PictureBox1 As PictureBox
End Class

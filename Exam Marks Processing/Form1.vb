
Public Class Form1
    'Declaring global variables
    'Single is data type for a decimal value
    Dim Cat1 As Single
    Dim Cat2 As Single
    Dim Assignment As Single
    Dim Coursework As Single
    Dim Exam As Single
    Dim Total_Score As Single
    Private Sub main_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cat_1_marks_txt_TextChanged(sender As Object, e As EventArgs) Handles cat1_txt.TextChanged
        'Not to take values more that 30 marks.
        If cat1_txt.Text > 30 Then
            MessageBox.Show("Please enter marks less than 30.", "Excess Marks")


        End If

    End Sub

    Private Sub cat2_txt_TextChanged(sender As Object, e As EventArgs) Handles cat2_txt.TextChanged
        'Not to take values more that 30 marks.
        If cat2_txt.Text > 30 Then
            MessageBox.Show("Please enter marks less than 30.", "Excess Marks")


        End If
    End Sub

    Private Sub course_work_btn_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub cat_1_marks_lbl_Click(sender As Object, e As EventArgs) Handles cat1_marks_lbl.Click

    End Sub

    Private Sub quit_btn_Click(sender As Object, e As EventArgs) Handles quit_btn.Click
        'Quitting the system process.
        Dim quit As DialogResult
        quit = MessageBox.Show("Do you want to quit system?", "Exams", MessageBoxButtons.YesNo, MessageBoxIcon.Information)
        'Set the condition to check the user's selection
        If quit = vbYes Then
            Application.Exit()
        End If


    End Sub

    Private Sub assignment_txt_TextChanged(sender As Object, e As EventArgs) Handles assignment_txt.TextChanged
        'Not to take values more that 40 marks.
        If assignment_txt.Text > 40 Then
            MessageBox.Show("Please enter marks less than 40.", "Excess Marks")


        End If
    End Sub

    Private Sub coursework_txt_TextChanged(sender As Object, e As EventArgs) Handles coursework_txt.TextChanged


    End Sub

    Private Sub exam_txt_TextChanged(sender As Object, e As EventArgs) Handles exam_txt.TextChanged
        'Not to take values more that 70 marks.
        If exam_txt.Text > 70 Then
            MessageBox.Show("Please enter marks less than 70.", "Excess Marks")


        End If
    End Sub

    Private Sub total_score_txt_TextChanged(sender As Object, e As EventArgs) Handles total_score_txt.TextChanged

    End Sub

    Private Sub reset_btn_Click(sender As Object, e As EventArgs) Handles reset_btn.Click
        'Clearing the text_fields
        cat1_txt.Text = ""
        cat2_txt.Text = ""
        assignment_txt.Text = ""
        exam_txt.Text = ""
        coursework_txt.Text = ""
        total_score_txt.Text = ""
    End Sub

    Private Sub total_score_btn_Click(sender As Object, e As EventArgs) Handles total_score_btn.Click
        'Declaring the values for the text fields
        Exam = exam_txt.Text
        'The value for the total_score
        Total_Score = Coursework + Exam
        'Declaring the values for the text fields
        Cat1 = cat1_txt.Text
        Cat2 = cat2_txt.Text
        Assignment = assignment_txt.Text
        'The value for the coursework
        Coursework = (Cat1 + Cat2 + Assignment) * 0.3
        'Display the result in the coursework_txt field
        coursework_txt.Text = Coursework
        'Display the result in the total_score_txt field.
        total_score_txt.Text = Total_Score

    End Sub

    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles system_panel.Paint
        ''Background colour for the panel.
        'system_panel.BackColor = Color.Turquoise
        ''Background colour for the labels.
        'title_lbl.BackColor = Color.DarkTurquoise
        'cat1_marks_lbl.BackColor = Color.MediumTurquoise
        'cat2_marks_lbl.BackColor = Color.MediumTurquoise
        'assignment_lbl.BackColor = Color.MediumTurquoise
        'exam_lbl.BackColor = Color.MediumTurquoise
        'course_work_lbl.BackColor = Color.MediumTurquoise

        ''Font color for the labels.
        'title_lbl.ForeColor = Color.White
        'cat1_marks_lbl.ForeColor = Color.White
        'cat2_marks_lbl.ForeColor = Color.White
        'assignment_lbl.ForeColor = Color.White
        'exam_lbl.ForeColor = Color.White
        'course_work_lbl.ForeColor = Color.White

        ''Quit button color
        ''quit_btn.FlatStyle = FlatStyle.Flat

    End Sub
End Class

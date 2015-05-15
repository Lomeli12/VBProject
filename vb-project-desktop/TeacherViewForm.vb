Public Class TeacherViewForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CourseViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New SchoolClassesDataContext

        Dim query = From all_teachers In db.Teachers
            Select all_teachers

        dtvTeacher.DataSource = query
    End Sub
End Class
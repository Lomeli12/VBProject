Public Class CourseViewForm

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CourseViewForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim db As New SchoolClassesDataContext

        Dim query = From all_courses In db.Courses
            Select all_courses

        CourseDataView.DataSource = query
    End Sub
End Class
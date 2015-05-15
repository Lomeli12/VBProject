Public Class EducationList

    Public educationID As Integer = 0
    Private db As New SchoolClassesDataContext

    Private Sub CoursesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        EducationBindingSource.DataSource = From educationList In db.Educations
                                         Select educationList

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub CoursePrereqListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxEducations.SelectedIndexChanged
        educationID = lstboxEducations.SelectedIndex + 1
    End Sub
End Class
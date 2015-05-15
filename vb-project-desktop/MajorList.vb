Public Class MajorList

    Public majorID As Integer = 0
    Private db As New SchoolClassesDataContext

    Private Sub CoursesList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MajorBindingSource.DataSource = From majorList In db.Majors
                                         Select majorList
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub lstboxMajors_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxMajors.SelectedIndexChanged
        majorID = lstboxMajors.SelectedIndex + 1
    End Sub
End Class
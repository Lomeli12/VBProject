Public Class StudentForm

    Private db As New SchoolClassesDataContext
    Public state As String = "add"

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query = From aStudent In db.Students
                    Select aStudent

        StudentBindingSource.DataSource = query
        StudentBindingSource.DataSource = From studentList In db.Students
                                                Select studentList

        If state.ToLower = "add" OrElse state.ToLower = "update" Then
            BindingNavigatorDeleteItem.Enabled = False
            BindingNavigatorDeleteItem.Visible = False
        ElseIf state.ToLower = "delete" Then
            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorAddNewItem.Visible = False
            BindingNavigatorSaveItem.Enabled = False
            BindingNavigatorSaveItem.Visible = False
        Else
            Throw New Exception("State must be: Add, Update or Delete!")
        End If
    End Sub

    Private Sub BindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorSaveItem.Click
        Try
            StudentBindingSource.EndEdit()
            db.SubmitChanges()
            MessageBox.Show("Data has been updated!")

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim enrollment = From student In db.Enrollments Where student.StudentID = CInt(txtStudentID.Text)
                        Select student
                'Check students enrollment and remove from entollments table if exsists.
                If enrollment.Any Then
                    For Each Student As Enrollment In enrollment
                        db.Enrollments.DeleteOnSubmit(Student)
                    Next
                    db.SubmitChanges()
                    MsgBox("Removed students enrollment from enrollments table.")
                End If
                db.Students.DeleteOnSubmit(StudentBindingSource.Current)
                db.SubmitChanges()
                MessageBox.Show("Data has been deleted!")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        Else
            ' ?????
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub btnSelectEducation_Click(sender As Object, e As EventArgs) Handles btnSelectEducation.Click
        Dim educationListing As New EducationList
        educationListing.ShowDialog()
        txtEducationID.Text = educationListing.educationID

    End Sub

    Private Sub btnSelectMajor_Click(sender As Object, e As EventArgs) Handles btnSelectMajor.Click
        Dim majorListing As New MajorList
        majorListing.ShowDialog()
        txtMajorID.Text = majorListing.majorID

    End Sub
End Class
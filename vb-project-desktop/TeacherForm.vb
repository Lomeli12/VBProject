' Made by Kevin Wetsch

Public Class TeacherForm

    Private db As New SchoolClassesDataContext
    Public state As String = "add"
    Private rankID As Integer

    Private Sub CourseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim query = From aTeacher In db.Teachers
                    Select aTeacher

        Dim rankQuery = From aRank In db.Ranks
                        Select aRank

        TeacherBindingSource.DataSource = query
        RankBindingSource.DataSource = rankQuery

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
            TeacherBindingSource.EndEdit()
            db.SubmitChanges()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        MessageBox.Show("Data has been updated!")
    End Sub

    Private Sub BindingNavigatorDeleteItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorDeleteItem.Click
        If MessageBox.Show("Are you sure?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question
                           ) = Windows.Forms.DialogResult.Yes Then
            Try
                Dim courseSection = From section In db.CourseSections Where section.TeacherID = CInt(txtTeacherID.Text)
                        Select section
                'Checking if teacher's id is present in courseSection table.
                'Removing record if any matches are found.
                If courseSection.Any Then
                    For Each section As CourseSection In courseSection
                        db.CourseSections.DeleteOnSubmit(section)

                    Next
                    MsgBox("Teacher refrence removed from courseSection table")
                    db.SubmitChanges()
                End If
                db.Teachers.DeleteOnSubmit(TeacherBindingSource.Current)
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

    Private Sub btnSelectRank_Click(sender As Object, e As EventArgs) Handles btnSelectRank.Click
        Dim rankListing As New RankList
        rankListing.ShowDialog()
        txtRankID.Text = rankListing.RankID

    End Sub

End Class
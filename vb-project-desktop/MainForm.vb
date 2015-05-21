' Made by Kevin Wetsch

Public Class MainForm
    Private db As New SchoolClassesDataContext


    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            db.Connection.Open()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Me.Close()
        End Try
    End Sub

    Private Sub MainForm_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed
        Try
            db.Connection.Close()
        Catch ex As Exception
            MessageBox.Show("There was a problem closing the connection to the database." _
                            & vbNewLine & "Please contact your system administrator.", "Database Error!", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Try
    End Sub

    Private Sub ViewToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem.Click
        Dim courseView As New CourseViewForm
        courseView.Show()

    End Sub

    Private Sub ViewToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem3.Click
        Dim majorsView As New MajorsViewForm
        majorsView.Show()

    End Sub

    Private Sub ViewToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem1.Click
        Dim studentView As New StudentViewForm
        studentView.Show()
    End Sub

    Private Sub AddUpdateToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AddUpdateToolStripMenuItem.Click
        Dim studentAdd As New StudentForm
        studentAdd.state = "add"
        studentAdd.ShowDialog()
    End Sub

    Private Sub DeleteToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem1.Click
        Dim studentAdd As New StudentForm
        studentAdd.state = "delete"
        studentAdd.ShowDialog()

    End Sub

    Private Sub ViewToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles ViewToolStripMenuItem2.Click
        Dim teacersView As New TeacherViewForm
        teacersView.Show()
    End Sub

    Private Sub AddUpdateToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles AddUpdateToolStripMenuItem1.Click
        Dim teacherAdd As New TeacherForm
        teacherAdd.state = "add"
        teacherAdd.ShowDialog()

    End Sub

    Private Sub DeleteToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles DeleteToolStripMenuItem2.Click
        Dim teacherAdd As New TeacherForm
        teacherAdd.state = "delete"
        teacherAdd.ShowDialog()

    End Sub


End Class

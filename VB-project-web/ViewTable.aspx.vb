' Made by Anthony Lomeli
Public Class ViewTableGeneric
    Inherits System.Web.UI.Page
    Dim source As String
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        source = Request.QueryString("source")
        If String.IsNullOrEmpty(source) = False And String.IsNullOrEmpty(tableView.DataSourceID) Then
            Dim keys As String() = getTableKey()
            tableView.DataSourceID = source
            tableView.DataKeyNames = keys
            getColumnsForTable()
            Dim type As String = Request.QueryString("edit")
            If String.IsNullOrEmpty(type) = False Then
                If type.Equals("true") Then
                    If source.Equals("Courses") Then
                        editCourse.Visible = True
                    ElseIf source.Equals("Majors") Then
                        editMajor.Visible = True
                    End If
                ElseIf type.Equals("WHALE") Then
                    Response.Redirect("https://www.youtube.com/watch?v=eODDe5rZI-U")
                End If
            End If
        End If
    End Sub

    Private Function getTableKey() As String()
        Dim key As String = ""
        If String.IsNullOrEmpty(source) = False Then
            If source.Equals("Courses") Then
                key = "CourseID"
            ElseIf source.Equals("Majors") Then
                key = "MajorID"
            ElseIf source.Equals("Students") Then
                key = "StudentID"
            ElseIf source.Equals("Teachers") Then
                key = "TeacherID"
            End If
        End If
        Return {key}
    End Function

    Private Sub getColumnsForTable()
        Dim data As String = ""
        If String.IsNullOrEmpty(source) = False Then
            If source.Equals("Courses") Then
                data = "CourseID/Course ID;CourseName/Course Name;CoursePrereq/Prerequiste;CourseUnits/Units"
            ElseIf source.Equals("Majors") Then
                data = "MajorID/Major ID;Major"
            ElseIf source.Equals("Students") Then
                data = "StudentID/Student ID;Firstname/First Name;Lastname/Last Name;EducationID/Education ID;MajorID/Major ID;IsActive/Active?"
            ElseIf source.Equals("Teachers") Then
                data = "TeacherID/Teacher ID;Firstname/First Name;Lastname/Last Name;EducationID/Education ID;RankID/Rank;IsActive/Active?"
            End If
        End If
        If String.IsNullOrEmpty(data) = False Then
            dynColumns(data)
        End If
    End Sub

    Private Sub dynColumns(ByRef str As String)
        Dim data As String() = str.Split(New Char() {";"c})
        For Each entry As String In data
            Dim newColumn As New BoundField()
            Dim additonal As String() = entry.Split(New Char() {"/"c})
            If additonal.Length = 2 Then
                newColumn.DataField = additonal(0)
                newColumn.HeaderText = additonal(1)
            Else
                newColumn.DataField = entry
                newColumn.HeaderText = entry
            End If
            tableView.Columns.Add(newColumn)
        Next
    End Sub

    Sub refreshTable()
        tableView.DataBind()
        tableView.SelectRow(-1)
    End Sub

    Protected Sub updatedRow(sender As Object, e As DetailsViewUpdatedEventArgs) Handles editMajor.ItemUpdated, editCourse.ItemUpdated
        refreshTable()
    End Sub

    Protected Sub insertedRow(sender As Object, e As DetailsViewInsertedEventArgs) Handles editMajor.ItemInserted, editCourse.ItemInserted
        refreshTable()
    End Sub

    Protected Sub deletedRow(sender As Object, e As DetailsViewDeletedEventArgs) Handles editMajor.ItemDeleted, editCourse.ItemDeleted
        refreshTable()
    End Sub
End Class
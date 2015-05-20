Public Class ViewTableGeneric
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim source As String = Request.QueryString("sourceId")
        If String.IsNullOrEmpty(source) = False And String.IsNullOrEmpty(tableView.DataSourceID) Then
            tableView.DataSourceID = source
            tableView.DataKeyNames = getTableKey(source)
            getColumnsForTable(source)
            Dim type As String = Request.QueryString("type")
            If String.IsNullOrEmpty(type) = False Then
                If type.Equals("edit") Then
                    addBtn.Visible = True
                    Dim editButton As New CommandField()
                    editButton.EditText = "Edit"
                    editButton.ShowEditButton = True
                    tableView.Columns.Add(editButton)
                ElseIf type.Equals("delete") Then
                    Dim deleteButton As New CommandField()
                    deleteButton.DeleteText = "Delete"
                    deleteButton.ShowDeleteButton = True
                    tableView.Columns.Add(deleteButton)
                End If
            End If
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

    Sub ViewTable_Click(ByVal sender As Object, ByVal e As EventArgs) Handles addBtn.Click

    End Sub

    Private Function getTableKey(ByRef source As String) As String()
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

    Private Sub getColumnsForTable(ByRef source As String)
        Dim data As String = ""
        If String.IsNullOrEmpty(source) = False Then
            If source.Equals("Courses") Then
                data = "CourseID;CourseName;CoursePrereq/Prerequiste;CourseUnits/Units"
            ElseIf source.Equals("Majors") Then
                data = "MajorID;Major"
            ElseIf source.Equals("Students") Then
                data = "StudentID;Firstname/First Name;Lastname/Last Name;EducationID;MajorID;IsActive"
            ElseIf source.Equals("Teachers") Then
                data = "TeacherID;Firstname/First Name;Lastname/Last Name;EducationID;RankID/Rank;IsActive"
            End If
        End If
        If String.IsNullOrEmpty(data) = False Then
            dynColumns(data)
        End If
    End Sub

End Class
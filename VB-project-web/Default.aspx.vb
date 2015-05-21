' Made by Anthony Lomeli
Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Sub ViewTable_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim clickedButton As Button = sender
        Dim id As String = clickedButton.ID
        If id.Equals(viewCourse.ID) Then
            Response.Redirect("ViewTable.aspx?source=Courses", True)
        ElseIf id.Equals(viewMajor.ID) Then
            Response.Redirect("ViewTable.aspx?source=Majors", True)
        ElseIf id.Equals(viewStudent.ID) Then
            Response.Redirect("ViewTable.aspx?source=Students", True)
        ElseIf id.Equals(viewTeacher.ID) Then
            Response.Redirect("ViewTable.aspx?source=Teachers", True)
        ElseIf id.Equals(editCourse.ID) Then
            Response.Redirect("ViewTable.aspx?source=Courses&edit=true", True)
        ElseIf id.Equals(editMajor.ID) Then
            Response.Redirect("ViewTable.aspx?source=Majors&edit=true", True)
        End If
    End Sub

End Class
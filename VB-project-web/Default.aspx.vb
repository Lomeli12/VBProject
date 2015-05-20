Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
    End Sub

    Sub ViewTable_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim clickedButton As Button = sender
        Dim id As String = clickedButton.ID
        If id.Equals(viewCourse.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Courses", True)
        ElseIf id.Equals(viewMajor.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Majors", True)
        ElseIf id.Equals(viewStudent.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Students", True)
        ElseIf id.Equals(viewTeacher.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Teachers", True)
        ElseIf id.Equals(editCourse.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Courses&type=edit", True)
        ElseIf id.Equals(editMajor.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Majors&type=edit", True)
        ElseIf id.Equals(deleteCourse.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Courses&type=delete", True)
        ElseIf id.Equals(deleteMajor.ID) Then
            Response.Redirect("ViewTableGeneric.aspx?sourceId=Majors&type=delete", True)
        End If
    End Sub

End Class
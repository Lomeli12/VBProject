Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Sub ViewTable_Click(ByVal sender As Object, ByVal e As EventArgs)
        Dim clickedButton As Button = sender
        Dim id As String = clickedButton.ID
        If id.Equals("viewCourse") Then
            Response.Redirect("ViewTableGeneric.aspx?key=CourseID&sourceId=Courses&data=CourseID/Course ID;CourseName/Course Name;CoursePrereq/Prerequiste;CourseUnits/Units", True)
        ElseIf id.Equals("viewMajor") Then
            Response.Redirect("ViewTableGeneric.aspx?key=MajorID&sourceId=Majors&data=MajorID/Major ID;Major", True)
        ElseIf id.Equals("viewStudent") Then
            Response.Redirect("ViewTableGeneric.aspx?key=StudentID&sourceId=Students&data=StudentID/Student ID;Firstname/First Name;Lastname/Last Name;EducationID/Education ID;MajorID/Major Id;IsActive/Active?", True)
        ElseIf id.Equals("viewTeacher") Then
            Response.Redirect("ViewTableGeneric.aspx?key=TeacherID&sourceId=Teachers&data=TeacherID/Teacher ID;Firstname/First Name;Lastname/Last Name;EducationID/Education ID;RankID/Rank;IsActive/Active?", True)
        End If
    End Sub

End Class
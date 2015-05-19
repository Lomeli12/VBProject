Public Class ViewTableGeneric
    Inherits System.Web.UI.Page
    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Dim key As String = Request.QueryString("key")
        Dim source As String = Request.QueryString("sourceId")
        If String.IsNullOrEmpty(key) = False And String.IsNullOrEmpty(source) = False Then
            tableView.DataKeyNames = {key}
            tableView.DataSourceID = source
            Dim data As String = Request.QueryString("data")
            If String.IsNullOrEmpty(data) = False Then
                dynColumns(data)
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

End Class
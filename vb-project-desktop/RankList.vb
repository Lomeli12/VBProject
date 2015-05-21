' Made by Kevin Wetsch

Public Class RankList


    Public RankID As Integer = 0
    Private db As New SchoolClassesDataContext

    Private Sub RankList_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RankBindingSource.DataSource = From rankList In db.Ranks
                                         Select rankList


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub lstboxRank_SelectedIndexChanged(sender As Object, e As EventArgs) Handles lstboxRank.SelectedIndexChanged, lstboxRank.SelectedIndexChanged
        RankID = lstboxRank.SelectedIndex + 1
    End Sub
End Class
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RankList
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim CoursePrereqLabel As System.Windows.Forms.Label
        Me.lstboxRank = New System.Windows.Forms.ListBox()
        Me.RankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CoursePrereqLabel = New System.Windows.Forms.Label()
        CType(Me.RankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoursePrereqLabel
        '
        CoursePrereqLabel.AutoSize = True
        CoursePrereqLabel.Location = New System.Drawing.Point(48, 19)
        CoursePrereqLabel.Name = "CoursePrereqLabel"
        CoursePrereqLabel.Size = New System.Drawing.Size(38, 13)
        CoursePrereqLabel.TabIndex = 1
        CoursePrereqLabel.Text = "Ranks"
        '
        'lstboxRank
        '
        Me.lstboxRank.DataSource = Me.RankBindingSource
        Me.lstboxRank.DisplayMember = "Rank"
        Me.lstboxRank.FormattingEnabled = True
        Me.lstboxRank.Location = New System.Drawing.Point(92, 19)
        Me.lstboxRank.Name = "lstboxRank"
        Me.lstboxRank.Size = New System.Drawing.Size(120, 95)
        Me.lstboxRank.TabIndex = 2
        Me.lstboxRank.ValueMember = "CourseID"
        '
        'RankBindingSource
        '
        Me.RankBindingSource.DataSource = GetType(LinqAndSQL_2.Rank)
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(92, 121)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 3
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'RankList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CoursePrereqLabel)
        Me.Controls.Add(Me.lstboxRank)
        Me.Name = "RankList"
        Me.Text = "Rank List"
        CType(Me.RankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lstboxRank As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

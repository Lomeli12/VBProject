<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EducationList
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
        Me.lstboxEducations = New System.Windows.Forms.ListBox()
        Me.EducationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        CoursePrereqLabel = New System.Windows.Forms.Label()
        CType(Me.EducationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CoursePrereqLabel
        '
        CoursePrereqLabel.AutoSize = True
        CoursePrereqLabel.Location = New System.Drawing.Point(9, 19)
        CoursePrereqLabel.Name = "CoursePrereqLabel"
        CoursePrereqLabel.Size = New System.Drawing.Size(63, 13)
        CoursePrereqLabel.TabIndex = 1
        CoursePrereqLabel.Text = "Educations:"
        '
        'lstboxEducations
        '
        Me.lstboxEducations.DataSource = Me.EducationBindingSource
        Me.lstboxEducations.DisplayMember = "Education"
        Me.lstboxEducations.FormattingEnabled = True
        Me.lstboxEducations.Location = New System.Drawing.Point(92, 19)
        Me.lstboxEducations.Name = "lstboxEducations"
        Me.lstboxEducations.Size = New System.Drawing.Size(120, 95)
        Me.lstboxEducations.TabIndex = 2
        Me.lstboxEducations.ValueMember = "EducationID"
        '
        'EducationBindingSource
        '
        Me.EducationBindingSource.DataSource = GetType(LinqAndSQL_2.Education)
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataSource = GetType(LinqAndSQL_2.Course)
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
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataSource = GetType(LinqAndSQL_2.Student)
        '
        'EducationList
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(224, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(CoursePrereqLabel)
        Me.Controls.Add(Me.lstboxEducations)
        Me.Name = "EducationList"
        Me.Text = "Education List"
        CType(Me.EducationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents lstboxEducations As System.Windows.Forms.ListBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents EducationBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
End Class

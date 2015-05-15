<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class StudentViewForm
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
        Me.CourseDataView = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.StudentBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MajorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EducationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StudentIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.CourseDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourseDataView
        '
        Me.CourseDataView.AllowUserToAddRows = False
        Me.CourseDataView.AllowUserToDeleteRows = False
        Me.CourseDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.StudentIDDataGridViewTextBoxColumn, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.EducationIDDataGridViewTextBoxColumn, Me.MajorIDDataGridViewTextBoxColumn, Me.IsActiveDataGridViewCheckBoxColumn})
        Me.CourseDataView.Location = New System.Drawing.Point(12, 13)
        Me.CourseDataView.Name = "CourseDataView"
        Me.CourseDataView.ReadOnly = True
        Me.CourseDataView.Size = New System.Drawing.Size(459, 110)
        Me.CourseDataView.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(395, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Ok"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'StudentBindingSource
        '
        Me.StudentBindingSource.DataSource = GetType(LinqAndSQL_2.Student)
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        Me.IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'MajorIDDataGridViewTextBoxColumn
        '
        Me.MajorIDDataGridViewTextBoxColumn.DataPropertyName = "MajorID"
        Me.MajorIDDataGridViewTextBoxColumn.HeaderText = "MajorID"
        Me.MajorIDDataGridViewTextBoxColumn.Name = "MajorIDDataGridViewTextBoxColumn"
        Me.MajorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EducationIDDataGridViewTextBoxColumn
        '
        Me.EducationIDDataGridViewTextBoxColumn.DataPropertyName = "EducationID"
        Me.EducationIDDataGridViewTextBoxColumn.HeaderText = "EducationID"
        Me.EducationIDDataGridViewTextBoxColumn.Name = "EducationIDDataGridViewTextBoxColumn"
        Me.EducationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentIDDataGridViewTextBoxColumn
        '
        Me.StudentIDDataGridViewTextBoxColumn.DataPropertyName = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.HeaderText = "StudentID"
        Me.StudentIDDataGridViewTextBoxColumn.Name = "StudentIDDataGridViewTextBoxColumn"
        Me.StudentIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'StudentViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CourseDataView)
        Me.Name = "StudentViewForm"
        Me.Text = "Student View Form"
        CType(Me.CourseDataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.StudentBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CourseDataView As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents StudentIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EducationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MajorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
    Friend WithEvents StudentBindingSource As System.Windows.Forms.BindingSource
End Class

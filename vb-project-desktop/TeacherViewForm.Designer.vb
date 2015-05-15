<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherViewForm
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
        Me.dtvTeacher = New System.Windows.Forms.DataGridView()
        Me.TeacherID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FirstnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.LastnameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EducationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RankID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IsActiveDataGridViewCheckBoxColumn = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtvTeacher, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvTeacher
        '
        Me.dtvTeacher.AllowUserToAddRows = False
        Me.dtvTeacher.AllowUserToDeleteRows = False
        Me.dtvTeacher.AutoGenerateColumns = False
        Me.dtvTeacher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvTeacher.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.TeacherID, Me.FirstnameDataGridViewTextBoxColumn, Me.LastnameDataGridViewTextBoxColumn, Me.EducationIDDataGridViewTextBoxColumn, Me.RankID, Me.IsActiveDataGridViewCheckBoxColumn})
        Me.dtvTeacher.DataSource = Me.TeacherBindingSource
        Me.dtvTeacher.Location = New System.Drawing.Point(12, 13)
        Me.dtvTeacher.Name = "dtvTeacher"
        Me.dtvTeacher.ReadOnly = True
        Me.dtvTeacher.Size = New System.Drawing.Size(459, 110)
        Me.dtvTeacher.TabIndex = 0
        '
        'TeacherID
        '
        Me.TeacherID.DataPropertyName = "TeacherID"
        Me.TeacherID.HeaderText = "TeacherID"
        Me.TeacherID.Name = "TeacherID"
        Me.TeacherID.ReadOnly = True
        '
        'FirstnameDataGridViewTextBoxColumn
        '
        Me.FirstnameDataGridViewTextBoxColumn.DataPropertyName = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.HeaderText = "Firstname"
        Me.FirstnameDataGridViewTextBoxColumn.Name = "FirstnameDataGridViewTextBoxColumn"
        Me.FirstnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'LastnameDataGridViewTextBoxColumn
        '
        Me.LastnameDataGridViewTextBoxColumn.DataPropertyName = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.HeaderText = "Lastname"
        Me.LastnameDataGridViewTextBoxColumn.Name = "LastnameDataGridViewTextBoxColumn"
        Me.LastnameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'EducationIDDataGridViewTextBoxColumn
        '
        Me.EducationIDDataGridViewTextBoxColumn.DataPropertyName = "EducationID"
        Me.EducationIDDataGridViewTextBoxColumn.HeaderText = "EducationID"
        Me.EducationIDDataGridViewTextBoxColumn.Name = "EducationIDDataGridViewTextBoxColumn"
        Me.EducationIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'RankID
        '
        Me.RankID.DataPropertyName = "RankID"
        Me.RankID.HeaderText = "RankID"
        Me.RankID.Name = "RankID"
        Me.RankID.ReadOnly = True
        '
        'IsActiveDataGridViewCheckBoxColumn
        '
        Me.IsActiveDataGridViewCheckBoxColumn.DataPropertyName = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.HeaderText = "IsActive"
        Me.IsActiveDataGridViewCheckBoxColumn.Name = "IsActiveDataGridViewCheckBoxColumn"
        Me.IsActiveDataGridViewCheckBoxColumn.ReadOnly = True
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataSource = GetType(LinqAndSQL_2.Teacher)
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
        'TeacherViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtvTeacher)
        Me.Name = "TeacherViewForm"
        Me.Text = "Teacher View Form"
        CType(Me.dtvTeacher, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtvTeacher As System.Windows.Forms.DataGridView
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TeacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TeacherID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents FirstnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents LastnameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EducationIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RankID As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IsActiveDataGridViewCheckBoxColumn As System.Windows.Forms.DataGridViewCheckBoxColumn
End Class

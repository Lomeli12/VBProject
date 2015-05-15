<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CourseViewForm
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
        Me.CourseIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CoursePrereqDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseUnitsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CourseBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.CourseDataView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourseDataView
        '
        Me.CourseDataView.AllowUserToAddRows = False
        Me.CourseDataView.AllowUserToDeleteRows = False
        Me.CourseDataView.AutoGenerateColumns = False
        Me.CourseDataView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.CourseDataView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.CourseIDDataGridViewTextBoxColumn, Me.CourseNameDataGridViewTextBoxColumn, Me.CoursePrereqDataGridViewTextBoxColumn, Me.CourseUnitsDataGridViewTextBoxColumn})
        Me.CourseDataView.DataSource = Me.CourseBindingSource
        Me.CourseDataView.Location = New System.Drawing.Point(13, 13)
        Me.CourseDataView.Name = "CourseDataView"
        Me.CourseDataView.ReadOnly = True
        Me.CourseDataView.Size = New System.Drawing.Size(459, 110)
        Me.CourseDataView.TabIndex = 0
        '
        'CourseIDDataGridViewTextBoxColumn
        '
        Me.CourseIDDataGridViewTextBoxColumn.DataPropertyName = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.HeaderText = "CourseID"
        Me.CourseIDDataGridViewTextBoxColumn.Name = "CourseIDDataGridViewTextBoxColumn"
        Me.CourseIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseNameDataGridViewTextBoxColumn
        '
        Me.CourseNameDataGridViewTextBoxColumn.DataPropertyName = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.HeaderText = "CourseName"
        Me.CourseNameDataGridViewTextBoxColumn.Name = "CourseNameDataGridViewTextBoxColumn"
        Me.CourseNameDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CoursePrereqDataGridViewTextBoxColumn
        '
        Me.CoursePrereqDataGridViewTextBoxColumn.DataPropertyName = "CoursePrereq"
        Me.CoursePrereqDataGridViewTextBoxColumn.HeaderText = "CoursePrereq"
        Me.CoursePrereqDataGridViewTextBoxColumn.Name = "CoursePrereqDataGridViewTextBoxColumn"
        Me.CoursePrereqDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseUnitsDataGridViewTextBoxColumn
        '
        Me.CourseUnitsDataGridViewTextBoxColumn.DataPropertyName = "CourseUnits"
        Me.CourseUnitsDataGridViewTextBoxColumn.HeaderText = "CourseUnits"
        Me.CourseUnitsDataGridViewTextBoxColumn.Name = "CourseUnitsDataGridViewTextBoxColumn"
        Me.CourseUnitsDataGridViewTextBoxColumn.ReadOnly = True
        '
        'CourseBindingSource
        '
        Me.CourseBindingSource.DataSource = GetType(LinqAndSQL_2.Course)
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
        'CourseViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.CourseDataView)
        Me.Name = "CourseViewForm"
        Me.Text = "Course View Form"
        CType(Me.CourseDataView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CourseBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CourseDataView As System.Windows.Forms.DataGridView
    Friend WithEvents CourseIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseNameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CoursePrereqDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseUnitsDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CourseBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class

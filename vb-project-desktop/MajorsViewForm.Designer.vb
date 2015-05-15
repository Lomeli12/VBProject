<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MajorsViewForm
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
        Me.dtvMjors = New System.Windows.Forms.DataGridView()
        Me.MajorIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MajorsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.dtvMjors, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MajorsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dtvMjors
        '
        Me.dtvMjors.AllowUserToAddRows = False
        Me.dtvMjors.AllowUserToDeleteRows = False
        Me.dtvMjors.AutoGenerateColumns = False
        Me.dtvMjors.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dtvMjors.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.MajorIDDataGridViewTextBoxColumn, Me.MajorDataGridViewTextBoxColumn})
        Me.dtvMjors.DataSource = Me.MajorsBindingSource
        Me.dtvMjors.Location = New System.Drawing.Point(13, 13)
        Me.dtvMjors.Name = "dtvMjors"
        Me.dtvMjors.ReadOnly = True
        Me.dtvMjors.Size = New System.Drawing.Size(459, 110)
        Me.dtvMjors.TabIndex = 0
        '
        'MajorIDDataGridViewTextBoxColumn
        '
        Me.MajorIDDataGridViewTextBoxColumn.DataPropertyName = "MajorID"
        Me.MajorIDDataGridViewTextBoxColumn.HeaderText = "MajorID"
        Me.MajorIDDataGridViewTextBoxColumn.Name = "MajorIDDataGridViewTextBoxColumn"
        Me.MajorIDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MajorDataGridViewTextBoxColumn
        '
        Me.MajorDataGridViewTextBoxColumn.DataPropertyName = "Major"
        Me.MajorDataGridViewTextBoxColumn.HeaderText = "Major"
        Me.MajorDataGridViewTextBoxColumn.Name = "MajorDataGridViewTextBoxColumn"
        Me.MajorDataGridViewTextBoxColumn.ReadOnly = True
        '
        'MajorsBindingSource
        '
        Me.MajorsBindingSource.DataSource = GetType(LinqAndSQL_2.Major)
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
        'MajorsViewForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(482, 167)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.dtvMjors)
        Me.Name = "MajorsViewForm"
        Me.Text = "Majors View Form"
        CType(Me.dtvMjors, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MajorsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents dtvMjors As System.Windows.Forms.DataGridView
    Friend WithEvents MajorsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents MajorIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MajorDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
End Class

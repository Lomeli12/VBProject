﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TeacherForm
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
        Dim CourseNameLabel As System.Windows.Forms.Label
        Dim CourseIDLabel As System.Windows.Forms.Label
        Dim CoursePrereqLabel As System.Windows.Forms.Label
        Dim Label1 As System.Windows.Forms.Label
        Dim Label2 As System.Windows.Forms.Label
        Dim Label3 As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(TeacherForm))
        Me.TeacherBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtTeacherID = New System.Windows.Forms.TextBox()
        Me.TeacherBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEducationID = New System.Windows.Forms.TextBox()
        Me.txtRankID = New System.Windows.Forms.TextBox()
        Me.chkbATeacherActive = New System.Windows.Forms.CheckBox()
        Me.RankBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnSelectRank = New System.Windows.Forms.Button()
        Me.btnSelectEducation = New System.Windows.Forms.Button()
        CourseNameLabel = New System.Windows.Forms.Label()
        CourseIDLabel = New System.Windows.Forms.Label()
        CoursePrereqLabel = New System.Windows.Forms.Label()
        Label1 = New System.Windows.Forms.Label()
        Label2 = New System.Windows.Forms.Label()
        Label3 = New System.Windows.Forms.Label()
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TeacherBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TeacherBindingNavigator.SuspendLayout()
        CType(Me.RankBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CourseNameLabel
        '
        CourseNameLabel.AutoSize = True
        CourseNameLabel.Location = New System.Drawing.Point(14, 57)
        CourseNameLabel.Name = "CourseNameLabel"
        CourseNameLabel.Size = New System.Drawing.Size(60, 13)
        CourseNameLabel.TabIndex = 1
        CourseNameLabel.Text = "First Name:"
        '
        'CourseIDLabel
        '
        CourseIDLabel.AutoSize = True
        CourseIDLabel.Location = New System.Drawing.Point(31, 31)
        CourseIDLabel.Name = "CourseIDLabel"
        CourseIDLabel.Size = New System.Drawing.Size(64, 13)
        CourseIDLabel.TabIndex = 24
        CourseIDLabel.Text = "Teacher ID:"
        '
        'CoursePrereqLabel
        '
        CoursePrereqLabel.AutoSize = True
        CoursePrereqLabel.Location = New System.Drawing.Point(11, 84)
        CoursePrereqLabel.Name = "CoursePrereqLabel"
        CoursePrereqLabel.Size = New System.Drawing.Size(61, 13)
        CoursePrereqLabel.TabIndex = 28
        CoursePrereqLabel.Text = "Last Name:"
        '
        'Label1
        '
        Label1.AutoSize = True
        Label1.Location = New System.Drawing.Point(16, 117)
        Label1.Name = "Label1"
        Label1.Size = New System.Drawing.Size(72, 13)
        Label1.TabIndex = 23
        Label1.Text = "Education ID:"
        '
        'Label2
        '
        Label2.AutoSize = True
        Label2.Location = New System.Drawing.Point(19, 140)
        Label2.Name = "Label2"
        Label2.Size = New System.Drawing.Size(52, 13)
        Label2.TabIndex = 23
        Label2.Text = "Raink ID:"
        '
        'Label3
        '
        Label3.AutoSize = True
        Label3.Location = New System.Drawing.Point(17, 164)
        Label3.Name = "Label3"
        Label3.Size = New System.Drawing.Size(37, 13)
        Label3.TabIndex = 23
        Label3.Text = "Active"
        '
        'TeacherBindingSource
        '
        Me.TeacherBindingSource.DataSource = GetType(LinqAndSQL_2.Teacher)
        '
        'txtFirstName
        '
        Me.txtFirstName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherBindingSource, "Firstname", True))
        Me.txtFirstName.Location = New System.Drawing.Point(94, 54)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(100, 20)
        Me.txtFirstName.TabIndex = 2
        '
        'txtTeacherID
        '
        Me.txtTeacherID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherBindingSource, "TeacherID", True))
        Me.txtTeacherID.Location = New System.Drawing.Point(94, 28)
        Me.txtTeacherID.Name = "txtTeacherID"
        Me.txtTeacherID.Size = New System.Drawing.Size(100, 20)
        Me.txtTeacherID.TabIndex = 25
        '
        'TeacherBindingNavigator
        '
        Me.TeacherBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TeacherBindingNavigator.BindingSource = Me.TeacherBindingSource
        Me.TeacherBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TeacherBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TeacherBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.BindingNavigatorSaveItem})
        Me.TeacherBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TeacherBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TeacherBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TeacherBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TeacherBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TeacherBindingNavigator.Name = "TeacherBindingNavigator"
        Me.TeacherBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TeacherBindingNavigator.Size = New System.Drawing.Size(325, 25)
        Me.TeacherBindingNavigator.TabIndex = 27
        Me.TeacherBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorSaveItem
        '
        Me.BindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorSaveItem.Image = CType(resources.GetObject("BindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorSaveItem.Name = "BindingNavigatorSaveItem"
        Me.BindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorSaveItem.Text = "Save Data"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(212, 28)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Close"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'txtLastName
        '
        Me.txtLastName.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherBindingSource, "Lastname", True))
        Me.txtLastName.Location = New System.Drawing.Point(94, 81)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(100, 20)
        Me.txtLastName.TabIndex = 29
        '
        'txtEducationID
        '
        Me.txtEducationID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherBindingSource, "EducationID", True))
        Me.txtEducationID.Location = New System.Drawing.Point(94, 107)
        Me.txtEducationID.Name = "txtEducationID"
        Me.txtEducationID.Size = New System.Drawing.Size(100, 20)
        Me.txtEducationID.TabIndex = 24
        '
        'txtRankID
        '
        Me.txtRankID.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.TeacherBindingSource, "RankID", True))
        Me.txtRankID.Location = New System.Drawing.Point(94, 133)
        Me.txtRankID.Name = "txtRankID"
        Me.txtRankID.Size = New System.Drawing.Size(100, 20)
        Me.txtRankID.TabIndex = 24
        '
        'chkbATeacherActive
        '
        Me.chkbATeacherActive.AutoSize = True
        Me.chkbATeacherActive.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.TeacherBindingSource, "IsActive", True))
        Me.chkbATeacherActive.Location = New System.Drawing.Point(94, 159)
        Me.chkbATeacherActive.Name = "chkbATeacherActive"
        Me.chkbATeacherActive.Size = New System.Drawing.Size(15, 14)
        Me.chkbATeacherActive.TabIndex = 30
        Me.chkbATeacherActive.UseVisualStyleBackColor = True
        '
        'RankBindingSource
        '
        Me.RankBindingSource.DataSource = GetType(LinqAndSQL_2.Rank)
        '
        'btnSelectRank
        '
        Me.btnSelectRank.Location = New System.Drawing.Point(200, 140)
        Me.btnSelectRank.Name = "btnSelectRank"
        Me.btnSelectRank.Size = New System.Drawing.Size(32, 21)
        Me.btnSelectRank.TabIndex = 31
        Me.btnSelectRank.Text = "..."
        Me.btnSelectRank.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.btnSelectRank.UseVisualStyleBackColor = True
        '
        'btnSelectEducation
        '
        Me.btnSelectEducation.Location = New System.Drawing.Point(200, 107)
        Me.btnSelectEducation.Name = "btnSelectEducation"
        Me.btnSelectEducation.Size = New System.Drawing.Size(32, 22)
        Me.btnSelectEducation.TabIndex = 31
        Me.btnSelectEducation.Text = "..."
        Me.btnSelectEducation.UseVisualStyleBackColor = True
        '
        'TeacherForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.ClientSize = New System.Drawing.Size(325, 212)
        Me.Controls.Add(Me.btnSelectEducation)
        Me.Controls.Add(Me.btnSelectRank)
        Me.Controls.Add(Me.chkbATeacherActive)
        Me.Controls.Add(CoursePrereqLabel)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TeacherBindingNavigator)
        Me.Controls.Add(CourseIDLabel)
        Me.Controls.Add(Me.txtTeacherID)
        Me.Controls.Add(Label3)
        Me.Controls.Add(Label2)
        Me.Controls.Add(Label1)
        Me.Controls.Add(Me.txtRankID)
        Me.Controls.Add(Me.txtEducationID)
        Me.Controls.Add(CourseNameLabel)
        Me.Controls.Add(Me.txtFirstName)
        Me.Name = "TeacherForm"
        Me.Text = "Teacher Form"
        CType(Me.TeacherBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TeacherBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TeacherBindingNavigator.ResumeLayout(False)
        Me.TeacherBindingNavigator.PerformLayout()
        CType(Me.RankBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtTeacherID As System.Windows.Forms.TextBox
    Friend WithEvents TeacherBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEducationID As System.Windows.Forms.TextBox
    Friend WithEvents txtRankID As System.Windows.Forms.TextBox
    Friend WithEvents chkbATeacherActive As System.Windows.Forms.CheckBox
    Friend WithEvents TeacherBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents RankBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents btnSelectRank As System.Windows.Forms.Button
    Friend WithEvents btnSelectEducation As System.Windows.Forms.Button
End Class

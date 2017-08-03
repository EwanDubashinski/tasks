<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TaskItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.QuestionMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.IncidentMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlanTaskMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DevMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OtherMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ContextMenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.QuestionMenuItem, Me.IncidentMenuItem, Me.PlanTaskMenuItem, Me.DevMenuItem, Me.OtherMenuItem})
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(168, 136)
        '
        'QuestionMenuItem
        '
        Me.QuestionMenuItem.Name = "QuestionMenuItem"
        Me.QuestionMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.QuestionMenuItem.Text = "Вопрос"
        '
        'IncidentMenuItem
        '
        Me.IncidentMenuItem.Name = "IncidentMenuItem"
        Me.IncidentMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.IncidentMenuItem.Text = "Инцидент"
        '
        'PlanTaskMenuItem
        '
        Me.PlanTaskMenuItem.Name = "PlanTaskMenuItem"
        Me.PlanTaskMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.PlanTaskMenuItem.Text = "Плановая задача"
        '
        'DevMenuItem
        '
        Me.DevMenuItem.Name = "DevMenuItem"
        Me.DevMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.DevMenuItem.Text = "Разработка"
        '
        'OtherMenuItem
        '
        Me.OtherMenuItem.Name = "OtherMenuItem"
        Me.OtherMenuItem.Size = New System.Drawing.Size(167, 22)
        Me.OtherMenuItem.Text = "Другое"
        '
        'TaskItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Name = "TaskItem"
        Me.ContextMenuStrip1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents QuestionMenuItem As ToolStripMenuItem
    Friend WithEvents IncidentMenuItem As ToolStripMenuItem
    Friend WithEvents PlanTaskMenuItem As ToolStripMenuItem
    Friend WithEvents DevMenuItem As ToolStripMenuItem
    Friend WithEvents OtherMenuItem As ToolStripMenuItem
End Class

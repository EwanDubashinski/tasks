Public Class TaskItem
    'Inherits Panel
    Public WithEvents header As New Label
    Public WithEvents h2 As New Label
    Public WithEvents descr As New Label
    Public id As Integer
    Public active As Boolean
    Public selected As Boolean = False
    Dim tt As New ToolTip
    Public WithEvents h3 As New Label

    Dim fntA As New Font("Segoe UI", 9, FontStyle.Bold)
    Dim fntI As New Font("Segoe UI", 9, FontStyle.Regular)

    Public WithEvents bt As New Button

    Public Sub New(ByVal width As Integer, ByVal header As String, ByVal h2 As String, ByVal h3 As String, ByVal text As String, ByVal id As Integer, ByVal Optional active As Boolean = True)
        InitializeComponent()
        init(width)

        Me.header.Text = header
        Me.h2.Text = h2
        Me.id = id
        Me.active = active
        Me.descr.Text = text
        tt.SetToolTip(Me.header, header)
        Me.h3.Text = h3
        setStatus(active)
        Me.ContextMenuStrip = ContextMenuStrip1
        Me.header.ContextMenuStrip = ContextMenuStrip1
    End Sub

    Sub init(ByVal width As Integer)

        Size = New Size(width, 63)
        BackColor = Color.WhiteSmoke
        Anchor = AnchorStyles.Right Or AnchorStyles.Top Or AnchorStyles.Left

        Margin = New Padding(0)

        Controls.Add(header)
        header.Location = New Point(21, 4)
        header.Font = New Font("Segoe UI", 12)
        header.ForeColor = Color.Black
        header.AutoSize = False
        header.Size = New Size(266, 21)
        header.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        header.AutoEllipsis = True

        Controls.Add(h2)
        h2.Location = New Point(22, 25)
        'h2.Font = New Font("Segoe UI", 9, FontStyle.Bold)
        'h2.ForeColor = Color.RoyalBlue
        h2.AutoSize = False
        h2.Size = New Size(265, 16)
        h2.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        h2.AutoEllipsis = True

        Controls.Add(h3)
        h3.Location = New Point(291, 25)
        h3.AutoSize = False
        h3.Size = New Size(48, 16)
        h3.Anchor = AnchorStyles.Right


        Controls.Add(descr)
        descr.Location = New Point(22, 44)
        descr.Font = New Font("Segoe UI", 8)
        descr.ForeColor = Color.DimGray
        descr.AutoSize = False
        descr.Size = New Size(266, 16)
        'descr.BackColor = Color.WhiteSmoke
        descr.BorderStyle = BorderStyle.None
        descr.Anchor = AnchorStyles.Left Or AnchorStyles.Right
        descr.AutoEllipsis = True

        Controls.Add(bt)
        bt.BackColor = Color.RoyalBlue
        bt.FlatStyle = FlatStyle.Flat
        'bt.ForeColor = Color.RoyalBlue
        bt.Location = New Point(3, 0)
        bt.Size = New Size(13, 63)
        bt.UseVisualStyleBackColor = False
        bt.TabStop = True

    End Sub

    Public Sub setStatus() Handles bt.Click

        'Dim tact As Devart.Data.Oracle.OracleTransaction = NonQuery("update alltasks set completed = " & IIf(active, "0", "1") & " where at_id=" & id, Nothing)
        'tact.Commit()
        active = Not active
        setStatus(active)
        Tasks.setState(id)
    End Sub

    Sub setStatus(ByVal state As Boolean)
        If state Then
            h2.Font = fntI
            h2.ForeColor = Color.Black
            h3.Font = fntI
            h3.ForeColor = Color.Black
            bt.BackColor = Color.WhiteSmoke
            'active = True
        Else
            h2.Font = fntA
            h2.ForeColor = Color.RoyalBlue
            h3.Font = fntA
            h3.ForeColor = Color.RoyalBlue
            bt.BackColor = Color.RoyalBlue
            'active = False
        End If
    End Sub


    Private Sub TaskItem_Click(sender As Object, e As MouseEventArgs) Handles Me.MouseDown
        If selected Then
            selected = False
            CType(Parent, taskslistpanel).SelectedItem = Nothing
        Else
            selected = True
        End If
        setSelected()
        If e.Button = MouseButtons.Right Then
            ContextMenuStrip1.Show(MousePosition.X, MousePosition.Y)
        End If
        Me.DoDragDrop(id.ToString, DragDropEffects.Move)
    End Sub

    Private Sub descr_MouseDown(sender As Object, e As MouseEventArgs) Handles descr.MouseDown
        TaskItem_Click(sender, e)

    End Sub
    Private Sub h2_MouseDown(sender As Object, e As MouseEventArgs) Handles h2.MouseDown
        TaskItem_Click(sender, e)
    End Sub
    Private Sub h3_MouseDown(sender As Object, e As MouseEventArgs) Handles h3.MouseDown
        TaskItem_Click(sender, e)
    End Sub
    Private Sub header_MouseDown(sender As Object, e As MouseEventArgs) Handles header.MouseDown
        TaskItem_Click(sender, e)
    End Sub

    Sub setSelected()
        If selected Then
            Me.BackColor = Color.LightSteelBlue
            If CType(Parent, taskslistpanel).SelectedItem IsNot Nothing Then
                CType(Parent, taskslistpanel).SelectedItem.selected = False
                CType(Parent, taskslistpanel).SelectedItem.setSelected()
            End If
            CType(Parent, taskslistpanel).SelectedItem = Me
        Else
            Me.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Sub highlight() Handles Me.MouseEnter
        If Not selected Then
            Me.BackColor = Color.Lavender
        End If
    End Sub
    Sub highlight2() Handles Me.MouseLeave
        If Not selected Then
            Me.BackColor = Color.WhiteSmoke
        End If
    End Sub

    Private Sub header_MouseEnter(sender As Object, e As EventArgs) Handles header.MouseEnter
        highlight()
    End Sub
    Private Sub header_MouseLeave(sender As Object, e As EventArgs) Handles header.MouseLeave
        highlight2()
    End Sub

    Private Sub descr_MouseEnter(sender As Object, e As EventArgs) Handles descr.MouseEnter
        highlight()
    End Sub

    Private Sub descr_MouseLeave(sender As Object, e As EventArgs) Handles descr.MouseLeave
        highlight2()
    End Sub

    Private Sub h2_MouseLeave(sender As Object, e As EventArgs) Handles h2.MouseLeave
        highlight2()
    End Sub

    Private Sub h2_MouseEnter(sender As Object, e As EventArgs) Handles h2.MouseEnter
        highlight()
    End Sub

    Private Sub h3_MouseEnter(sender As Object, e As EventArgs) Handles h3.MouseEnter
        highlight()
    End Sub

    Private Sub h3_MouseLeave(sender As Object, e As EventArgs) Handles h3.MouseLeave
        highlight2()
    End Sub

    Private Sub bt_MouseEnter(sender As Object, e As EventArgs) Handles bt.MouseEnter
        highlight()
    End Sub

    Private Sub bt_MouseLeave(sender As Object, e As EventArgs) Handles bt.MouseLeave
        highlight2()
    End Sub

    Private Sub QuestionMenuItem_Click(sender As Object, e As EventArgs) Handles QuestionMenuItem.Click
        Tasks.setCategory(id, 0)
    End Sub

    Private Sub IncidentMenuItem_Click(sender As Object, e As EventArgs) Handles IncidentMenuItem.Click
        Tasks.setCategory(id, 1)
    End Sub

    Private Sub PlanTaskMenuItem_Click(sender As Object, e As EventArgs) Handles PlanTaskMenuItem.Click
        Tasks.setCategory(id, 2)
    End Sub

    Private Sub DevMenuItem_Click(sender As Object, e As EventArgs) Handles DevMenuItem.Click
        Tasks.setCategory(id, 3)
    End Sub

    Private Sub OtherMenuItem_Click(sender As Object, e As EventArgs) Handles OtherMenuItem.Click
        Tasks.setCategory(id, 4)
    End Sub
End Class

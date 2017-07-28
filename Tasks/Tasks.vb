Imports Oracle.ManagedDataAccess.Client
Imports System.Windows.Forms.Integration
Imports InveritasDB
Imports InveritasDB.StoredProcedures

Public Class Tasks
    Dim entity As Entities
    Dim conn As Connect
    ' Перетаскивание формы begin
    Dim newPoint As New Point()
    Dim WithEvents tb As New TextBox
    Dim editCtrl As Control
    Dim a As Integer
    Dim b As Integer

    Private Sub Form1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        a = MousePosition.X - Me.Location.X
        b = MousePosition.Y - Me.Location.Y
    End Sub
    Private Sub Form1_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs)
        If e.Button = MouseButtons.Left Then
            newPoint = MousePosition
            newPoint.X = newPoint.X - (a)
            newPoint.Y = newPoint.Y - (b)
            Location = newPoint
        End If
    End Sub
    ' Перетаскивание формы end

    Dim val As Integer
    Dim txt As String

    Dim IEnum As IEnumerable(Of DataRow)
    'Dim uitab As IQueryable(Of UI_TASKS)

    Dim tasks As DataTable
    Dim ds As DataSet
    Dim cnt As Integer
    Dim fnt As Font
    Dim tiLocation As New Point(0, 0)
    'Dim miLast As MailItem
    Dim miY As Integer

    Dim dsTasks As New DataSet
    Dim daTasks As New OracleDataAdapter
    Dim index As Integer = 0
    Dim ti As TaskItem
    Dim msgs As New msgUC.msgArea ' Почта

    Public Sub New()
        InitializeComponent()

        conn = New Connect
        conn.ShowDialog()
        entity = Adapter.entity

        Dim eh As New ElementHost
        eh.Dock = DockStyle.Fill
        Post.Controls.Add(eh)
        eh.Child = msgs

        dsTasks.Tables.Add("tasks")

        clearDetails()
        miY = Post.Size.Height
        'uitab = Populate("select ord, col from ui_tasks where login = user order by ord")




        'uitab = IEnum.CopyToDataTable()
        ds = New DataSet
        Dim dr As OracleDataAdapter
        'cnt = psf("task.getGrpCnt") ' Получим число группировок пользователя
        cnt = TASK.GETGRPCNT()

        'Dim params As New Dictionary(Of String, String)
        For i = 0 To cnt - 1
            'params.Clear()
            'params.Add("i", i)
            'dr = New OracleDataAdapter(psf("task.getSQL", params), HomeForm.conn)
            dr = New OracleDataAdapter(TASK.GETSQL(i), StoredProc.conn)
            'MsgBox("Command = " & dr.SelectCommand.CommandText)
            dr.Fill(ds, "t" & i)
            If i > 0 Then
                Dim pc(i - 1) As DataColumn ' Массив родителей
                Dim cc(i - 1) As DataColumn ' Массив детей
                For j = 1 To i
                    pc(j - 1) = ds.Tables("t" & (i - 1)).Columns(j - 1)
                    cc(j - 1) = ds.Tables("t" & i).Columns(j - 1)
                Next
                Dim rel As New DataRelation("rel" & i, pc, cc)
                ds.Relations.Add(rel)
            End If
        Next
        fnt = New Font("Segoe UI", 10)
        aggTree.Nodes.Clear()
        fillChild()
        taskState.ContextMenuStrip = StateMenu
    End Sub

    Sub fillChild(Optional ByVal i As Integer = 0, Optional ByRef nodes As TreeNodeCollection = Nothing, Optional ByRef pRow As DataRow = Nothing)
        If i = 0 Then
            nodes = aggTree.Nodes
            For Each cRow As DataRow In ds.Tables("t" & i).Rows
                Dim n As TreeNode = nodes.Add(cRow(0), cRow(1))
                If i < cnt Then
                    fillChild(i + 1, n.Nodes, cRow)
                End If
            Next
        Else
            For Each cRow As DataRow In pRow.GetChildRows("rel" & i)
                Dim n As TreeNode = nodes.Add(cRow(i), cRow(i + 1))
                n.NodeFont = fnt
                If i < cnt Then
                    fillChild(i + 1, n.Nodes, cRow)
                End If
            Next
        End If
    End Sub

    Private Sub NTree1_AfterSelect(sender As Object, e As TreeViewEventArgs) Handles aggTree.AfterSelect
        'TODO: дописать данный селект и сделать из него вьюху
        Dim str As String = "select name, text, product.GETBLOCKNAME(block), nvl(to_char(date_,'DD.MM'), '__:__'), at_id, COMPSTATE from v_tasks where "

        Dim node As TreeNode = e.Node
        'For i As Integer = e.Node.Level To 0 Step -1
        '    If i < e.Node.Level Then
        '        str += " and "
        '    End If
        '    'str += uitab.Rows(i)(1) & "='" & node.Name & "'"
        '    'str += uitab.ElementAt(i).COL

        '    node = node.Parent
        'Next
        Dim uitab = From c In entity.UI_TASKS Where c.LOGIN = Adapter.Username Select c
        For i As Integer = e.Node.Level To 0 Step -1
            If i < e.Node.Level Then
                str += " and "
            End If
            str += (From t In uitab Where t.ORD = i Select t.COL).First & "='" & node.Name & "'"
            node = node.Parent
        Next


        tasksPanel.Controls.Clear()
        tiLocation = New Point(0, 0)
        ti = Nothing
        'MsgBox(str)
        getTasks(str)
        index = 0
        fillTasks()

    End Sub

    Sub getTasks(ByVal selstr As String)
        dsTasks.Clear()
        daTasks = New OracleDataAdapter
        daTasks.SelectCommand = New OracleCommand()
        daTasks.SelectCommand.CommandText = selstr
        daTasks.SelectCommand.Connection = StoredProc.conn
    End Sub

    Private Sub fillTasks()
        dsTasks.Tables("tasks").Rows.Clear()
        daTasks.Fill(dsTasks, index, 20, "tasks")
        If ti IsNot Nothing Then
            tiLocation = ti.Location
        End If

        For Each cRow As DataRow In dsTasks.Tables("tasks").Rows
            Dim w As Integer = tasksPanel.Width

            'If Not tasksPanel.VerticalScroll.Visible Then
            '    w += 17
            'End If
            ti = New TaskItem(w, cRow(0),
                                            cRow(2),
                                            cRow(3),
                                            cRow(1),
                                            cRow(4),
                                            IIf(cRow(5) = 0, False, True))
            tasksPanel.Controls.Add(ti)
            ti.Location = tiLocation
            tiLocation = New Point(ti.Location.X, ti.Location.Y + 65)
            'index += 1
        Next
        index += dsTasks.Tables("tasks").Rows.Count - 1
        tasksPanel.Refresh()
    End Sub


    Private Sub Button7_Click(sender As Object, e As EventArgs)
        'tasksPanel.Controls.Item()
        MsgBox(If(tasksPanel.SelectedItem Is Nothing, "no val", tasksPanel.SelectedItem.Width) & " - " & tasksPanel.Width)
    End Sub

    Sub checkBottom()
        If tasksPanel.VerticalScroll.Value = tasksPanel.VerticalScroll.Maximum - tasksPanel.VerticalScroll.LargeChange + 1 Then
            fillTasks()
        End If
    End Sub

    Public Function getLogo(ByVal id As Integer) As Drawing.Bitmap
        Dim img As Drawing.Bitmap
        Select Case id
            Case 13
                img = My.Resources.cib
            Case 17
                img = My.Resources.vita
            Case 24
                img = My.Resources.inv
            Case 29
                img = My.Resources.pgb
            Case 38
                img = My.Resources.inv
            Case 150
                img = My.Resources.novobank
            Case Else
                img = My.Resources.no
        End Select
        img.Tag = id
        Return img
    End Function

    Private Sub tasksPanel_SelectedItemChanged() Handles tasksPanel.SelectedItemChanged ', MyBaselistpanel2.SelectedItemChanged
        getDetails()
        getWorks()
        getMail()
    End Sub

    Private Sub tasksPanel_Scroll(sender As Object, e As ScrollEventArgs) Handles tasksPanel.Scroll ', MyBaselistpanel2.Scroll
        checkBottom()
    End Sub

    Private Sub tasksPanel_MouseWheel(sender As Object, e As MouseEventArgs) Handles tasksPanel.MouseWheel ', MyBaselistpanel2.MouseWheel
        checkBottom()
    End Sub

    Private Sub getMail()
        If tasksPanel.SelectedItem IsNot Nothing Then
            Dim dt As New DataTable
            'dt = Populate("select ENTRY_ID,  
            '                 /*1*/TASK,      
            '                 /*2*/nvl(SUBJECT,' '),   
            '                 /*3*/nvl(task.getKeynote(task, num),' '), 
            '                 /*4*/SIDE, 
            '                 /*5*/NUM,
            '                 /*6*/nvl(to_char(DT,'HH24:MI DD.MM.RRRR'),' ') DT, 
            '                 /*7*/nvl(Person.GetPersonName(PERSON.GETPERBYEMAIL(SENDER),1),' ') SENDER,
            '                 /*8*/nvl(Person.GetPersonName(PERSON.GETPERBYEMAIL(RECIPIENT),1),' ') RECIPIENT,
            '                 /*9*/nvl((select 1 
            '                             from dual
            '                            where exists (select null
            '                                            from MAILATT a
            '                                           where a.task = t.task
            '                                             and a.num = t.num)),0) attach
            '                 from taskmail t
            '                where task=" & tasksPanel.SelectedItem.id & "order by dt")
            Dim mail = From c In entity.V_MAIL Where c.TASK = tasksPanel.SelectedItem.id Select c
            'dt = IEnum.CopyToDataTable()
            msgs.clearMsg()
            'For Each cRow As DataRow In dt.Rows
            '    msgs.insMsg(cRow(4) = 1, cRow(7) & " - " & cRow(8), cRow(3), cRow(6), cRow(9) = 1)
            'Next
            For Each item In mail
                msgs.insMsg(item.SIDE = 1, item.SENDER & " - " & item.RECIPIENT, item.GETKEYNOTE, item.DT, item.ATTACH = 1)
            Next

        End If
    End Sub

    Sub getDetails()
        If tasksPanel.SelectedItem IsNot Nothing Then
            'Dim dt As New DataTable
            'dt = Populate("select * from V_TASKS_DETAILS where at_id=" & tasksPanel.SelectedItem.id)
            Dim td = (From c In entity.V_TASKS_DETAILS Where c.AT_ID = tasksPanel.SelectedItem.id Select c).First
            'dt = IEnum.CopyToDataTable()
            clearDetails()
            'taskDate.Text = dt.Rows(0)(0)
            'taskCustomer.Text = dt.Rows(0)(1)
            'taskHeader.Text = dt.Rows(0)(2)
            'taskState.Text = dt.Rows(0)(3)
            'taskText.Text = dt.Rows(0)(4)
            'taskManager.Text = dt.Rows(0)(5)
            'taskType.Text = dt.Rows(0)(6)
            'taskProject.Text = dt.Rows(0)(7)
            'taskProduct.Text = dt.Rows(0)(8)
            'taskBlock.Text = dt.Rows(0)(9)
            'Customer.Image = getLogo(dt.Rows(0)(11))
            taskDate.Text = td.TDATE
            taskCustomer.Text = td.CLIENT
            taskHeader.Text = td.SUBJECT
            taskState.Text = td.STATE
            taskText.Text = td.NOTES
            taskManager.Text = td.EMP
            taskType.Text = td.TTYPE
            taskProject.Text = td.TPROJ
            taskProduct.Text = td.TPROD
            taskBlock.Text = td.TBLOCK
            Customer.Image = getLogo(td.CUSID)

        End If
    End Sub

    Sub getWorks()
        If tasksPanel.SelectedItem IsNot Nothing Then
            'Dim dt As New DataTable
            'dt = Populate("select details from allworks where task=" & tasksPanel.SelectedItem.id)
            Dim works = From c In entity.ALLWORKS Where c.TASK = tasksPanel.SelectedItem.id Select c

            ListWorks.Items.Clear()
            For Each work In works
                ListWorks.Items.Add(work.DETAILS)
            Next
        End If
    End Sub
    Sub clearDetails()
        msgs.clearMsg()
        taskDate.Text = ""
        taskCustomer.Text = ""
        taskHeader.Text = ""
        taskState.Text = ""
        taskText.Text = ""
        taskManager.Text = ""
        taskType.Text = ""
        taskProject.Text = ""
        taskProduct.Text = ""
        taskBlock.Text = ""
    End Sub

    Private Sub taskDate_Click(sender As Object, e As EventArgs) Handles taskDate.DoubleClick
        editCtrl = taskDate
        DateTimePicker1.Location = New Point(taskDate.Location)
        DateTimePicker1.Value = DateTime.Parse(taskDate.Text)
        DateTimePicker1.Visible = True
        Me.ActiveControl = DateTimePicker1
    End Sub

    Private Sub DateTimePicker1_KeyDown(sender As Object, e As KeyEventArgs) Handles DateTimePicker1.KeyDown
        If e.KeyCode = Keys.Enter Then
            editCtrl.Text = DateTimePicker1.Text
            DateTimePicker1.Visible = False
        ElseIf e.KeyCode = Keys.Escape Then
            DateTimePicker1.Visible = False
        End If
    End Sub


    Private Sub taskCustomer_Click(sender As Object, e As EventArgs) Handles taskCustomer.DoubleClick
        Dim edit As New EditboxForm(taskCustomer, val, txt)
        edit.ShowDialog()
        If Not edit.Cancel Then
            taskCustomer.Text = edit.Value
            taskCustomer.Tag = edit.Key
        End If
    End Sub

    Private Sub Customer_Click(sender As Object, e As EventArgs) Handles Customer.Click
        Dim edit As New EditboxForm(taskCustomer, val, txt)
        edit.ShowDialog()
        If Not edit.Cancel Then
            taskCustomer.Text = edit.Value
            taskCustomer.Tag = edit.Key
        End If
    End Sub

    Private Sub taskHeader_Click(sender As Object, e As EventArgs) Handles taskHeader.DoubleClick
        tb.Location = taskHeader.Location
        tb.Text = taskHeader.Text
        Description.Controls.Add(tb)
        tb.BringToFront()
        editCtrl = taskHeader
        tb.Size = editCtrl.Size
        tb.Visible = True
        Me.ActiveControl = tb
    End Sub

    Private Sub tb_KeyDown(sender As Object, e As KeyEventArgs) Handles tb.KeyDown
        If e.KeyCode = Keys.Enter Then
            editCtrl.Text = tb.Text
            tb.Visible = False
        ElseIf e.KeyCode = Keys.Escape Then
            tb.Visible = False
        End If
    End Sub

    Private Sub getTask_Click(sender As Object, e As EventArgs) Handles getTask.Click
        Dim edit As New EditboxForm(taskManager, val, txt)
        edit.ShowDialog()
        If Not edit.Cancel Then
            taskManager.Text = edit.Value
            taskManager.Tag = edit.Key
        End If
    End Sub

    Private Sub taskState_Click(sender As Object, e As EventArgs) Handles taskState.Click
        tasksPanel.SelectedItem.setStatus()
    End Sub

    Private Sub OpenTask_Click(sender As Object, e As EventArgs) Handles OpenTask.Click
        tasksPanel.SelectedItem.setStatus()
    End Sub

    Private Sub CloseTask_Click(sender As Object, e As EventArgs) Handles CloseTask.Click
        tasksPanel.SelectedItem.setStatus()
    End Sub

    Private Sub CancelTask_Click(sender As Object, e As EventArgs) Handles CancelTask.Click
        MsgBox("Пока тут заглушка")
    End Sub

    Private Sub SetTaskDeadline_Click(sender As Object, e As EventArgs) Handles SetTaskDeadline.Click
        editCtrl = taskState
        DateTimePicker1.Location = New Point(taskDate.Location)
        'DateTimePicker1.Value = DateTime.Parse(taskDate.Text)
        DateTimePicker1.Visible = True
        Me.ActiveControl = DateTimePicker1
    End Sub

    Private Sub ChangeTaskCloseDate_Click(sender As Object, e As EventArgs) Handles ChangeTaskCloseDate.Click
        editCtrl = taskState
        DateTimePicker1.Location = New Point(taskDate.Location)
        'DateTimePicker1.Value = DateTime.Parse(taskDate.Text)
        DateTimePicker1.Visible = True
        Me.ActiveControl = DateTimePicker1
    End Sub
End Class
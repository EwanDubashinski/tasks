<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Tasks
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tasks))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.aggTree = New ITasks.NTree()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tasksPanel = New ITasks.taskslistpanel()
        Me.Tab = New System.Windows.Forms.TabControl()
        Me.Description = New System.Windows.Forms.TabPage()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.getTask = New System.Windows.Forms.Button()
        Me.taskText = New System.Windows.Forms.TextBox()
        Me.taskManager = New System.Windows.Forms.Label()
        Me.taskState = New System.Windows.Forms.Button()
        Me.Customer = New System.Windows.Forms.Button()
        Me.taskHeader = New System.Windows.Forms.Label()
        Me.taskCustomer = New System.Windows.Forms.Label()
        Me.taskDate = New System.Windows.Forms.Label()
        Me.Works = New System.Windows.Forms.TabPage()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.ListWorks = New System.Windows.Forms.ListBox()
        Me.Post = New System.Windows.Forms.TabPage()
        Me.files = New System.Windows.Forms.TabPage()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.taskType = New System.Windows.Forms.ToolStripStatusLabel()
        Me.taskProject = New System.Windows.Forms.ToolStripStatusLabel()
        Me.taskProduct = New System.Windows.Forms.ToolStripStatusLabel()
        Me.taskBlock = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StateMenu = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.CloseTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.CancelTask = New System.Windows.Forms.ToolStripMenuItem()
        Me.SetTaskDeadline = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChangeTaskCloseDate = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.SavetoDB = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Tab.SuspendLayout()
        Me.Description.SuspendLayout()
        Me.Works.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.StateMenu.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer1.Location = New System.Drawing.Point(12, 28)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.aggTree)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1130, 561)
        Me.SplitContainer1.SplitterDistance = 362
        Me.SplitContainer1.TabIndex = 8
        '
        'aggTree
        '
        Me.aggTree.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.aggTree.BackColor = System.Drawing.Color.Gray
        Me.aggTree.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.aggTree.Font = New System.Drawing.Font("Segoe UI Semibold", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.aggTree.ForeColor = System.Drawing.Color.White
        Me.aggTree.FullRowSelect = True
        Me.aggTree.ItemHeight = 22
        Me.aggTree.Location = New System.Drawing.Point(3, 3)
        Me.aggTree.Name = "aggTree"
        Me.aggTree.ShowLines = False
        Me.aggTree.Size = New System.Drawing.Size(354, 553)
        Me.aggTree.TabIndex = 3
        '
        'SplitContainer2
        '
        Me.SplitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel4)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel3)
        Me.SplitContainer2.Panel1.Controls.Add(Me.tasksPanel)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Tab)
        Me.SplitContainer2.Size = New System.Drawing.Size(764, 561)
        Me.SplitContainer2.SplitterDistance = 363
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.Button4)
        Me.Panel2.Controls.Add(Me.TextBox1)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(4, 78)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(349, 63)
        Me.Panel2.TabIndex = 0
        Me.Panel2.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(291, 26)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(48, 15)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "14:59"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button4.Location = New System.Drawing.Point(3, 0)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(13, 63)
        Me.Button4.TabIndex = 3
        Me.Button4.UseVisualStyleBackColor = False
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox1.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox1.Location = New System.Drawing.Point(22, 44)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(263, 16)
        Me.TextBox1.TabIndex = 2
        Me.TextBox1.TabStop = False
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label2.Location = New System.Drawing.Point(22, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(263, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Инцидент"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label1.Location = New System.Drawing.Point(21, 4)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(264, 22)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Закрытие дня - Хулиганят РЕЗЕРВЫ ПО РКО"
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Lavender
        Me.Panel4.Controls.Add(Me.Label8)
        Me.Panel4.Controls.Add(Me.Button3)
        Me.Panel4.Controls.Add(Me.TextBox2)
        Me.Panel4.Controls.Add(Me.Label9)
        Me.Panel4.Controls.Add(Me.Label10)
        Me.Panel4.Location = New System.Drawing.Point(3, 210)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(350, 63)
        Me.Panel4.TabIndex = 0
        Me.Panel4.Visible = False
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(313, 26)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(34, 15)
        Me.Label8.TabIndex = 4
        Me.Label8.Text = "14:59"
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button3.Location = New System.Drawing.Point(3, 0)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(13, 63)
        Me.Button3.TabIndex = 3
        Me.Button3.UseVisualStyleBackColor = False
        '
        'TextBox2
        '
        Me.TextBox2.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TextBox2.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.TextBox2.ForeColor = System.Drawing.Color.DimGray
        Me.TextBox2.Location = New System.Drawing.Point(22, 44)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.ReadOnly = True
        Me.TextBox2.Size = New System.Drawing.Size(263, 16)
        Me.TextBox2.TabIndex = 2
        Me.TextBox2.TabStop = False
        '
        'Label9
        '
        Me.Label9.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label9.Location = New System.Drawing.Point(22, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(263, 15)
        Me.Label9.TabIndex = 1
        Me.Label9.Text = "Инцидент"
        '
        'Label10
        '
        Me.Label10.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label10.Location = New System.Drawing.Point(21, 4)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(264, 22)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "Закрытие дня - Хулиганят РЕЗЕРВЫ ПО РКО"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Panel3.Controls.Add(Me.Label7)
        Me.Panel3.Controls.Add(Me.Label4)
        Me.Panel3.Controls.Add(Me.Button2)
        Me.Panel3.Controls.Add(Me.Label5)
        Me.Panel3.Controls.Add(Me.Label6)
        Me.Panel3.Location = New System.Drawing.Point(3, 144)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(350, 63)
        Me.Panel3.TabIndex = 0
        Me.Panel3.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoEllipsis = True
        Me.Label7.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label7.ForeColor = System.Drawing.Color.DimGray
        Me.Label7.Location = New System.Drawing.Point(22, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(263, 15)
        Me.Label7.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(313, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(34, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "14:59"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.RoyalBlue
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Button2.Location = New System.Drawing.Point(3, 0)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(13, 63)
        Me.Button2.TabIndex = 3
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label5
        '
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.RoyalBlue
        Me.Label5.Location = New System.Drawing.Point(22, 26)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(263, 15)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Инцидент"
        '
        'Label6
        '
        Me.Label6.AutoEllipsis = True
        Me.Label6.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label6.Location = New System.Drawing.Point(21, 4)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(264, 22)
        Me.Label6.TabIndex = 0
        Me.Label6.Text = "Закрытие дня - Хулиганят РЕЗЕРВЫ ПО РКО"
        '
        'tasksPanel
        '
        Me.tasksPanel.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tasksPanel.AutoScroll = True
        Me.tasksPanel.BackColor = System.Drawing.Color.White
        Me.tasksPanel.Location = New System.Drawing.Point(3, 3)
        Me.tasksPanel.Name = "tasksPanel"
        Me.tasksPanel.SelectedItem = Nothing
        Me.tasksPanel.Size = New System.Drawing.Size(356, 553)
        Me.tasksPanel.TabIndex = 0
        '
        'Tab
        '
        Me.Tab.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Tab.Controls.Add(Me.Description)
        Me.Tab.Controls.Add(Me.Works)
        Me.Tab.Controls.Add(Me.Post)
        Me.Tab.Controls.Add(Me.files)
        Me.Tab.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Tab.ItemSize = New System.Drawing.Size(90, 25)
        Me.Tab.Location = New System.Drawing.Point(3, 3)
        Me.Tab.Name = "Tab"
        Me.Tab.SelectedIndex = 0
        Me.Tab.Size = New System.Drawing.Size(388, 553)
        Me.Tab.SizeMode = System.Windows.Forms.TabSizeMode.Fixed
        Me.Tab.TabIndex = 0
        '
        'Description
        '
        Me.Description.BackColor = System.Drawing.Color.Silver
        Me.Description.Controls.Add(Me.DateTimePicker1)
        Me.Description.Controls.Add(Me.getTask)
        Me.Description.Controls.Add(Me.taskText)
        Me.Description.Controls.Add(Me.taskManager)
        Me.Description.Controls.Add(Me.taskState)
        Me.Description.Controls.Add(Me.Customer)
        Me.Description.Controls.Add(Me.taskHeader)
        Me.Description.Controls.Add(Me.taskCustomer)
        Me.Description.Controls.Add(Me.taskDate)
        Me.Description.Location = New System.Drawing.Point(4, 29)
        Me.Description.Name = "Description"
        Me.Description.Padding = New System.Windows.Forms.Padding(3)
        Me.Description.Size = New System.Drawing.Size(380, 520)
        Me.Description.TabIndex = 0
        Me.Description.Text = "Описание"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.CustomFormat = "ddd dd.MM.yyyy hh:mm"
        Me.DateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.DateTimePicker1.Location = New System.Drawing.Point(110, 130)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(158, 25)
        Me.DateTimePicker1.TabIndex = 10
        Me.DateTimePicker1.Visible = False
        '
        'getTask
        '
        Me.getTask.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.getTask.Location = New System.Drawing.Point(267, 493)
        Me.getTask.Name = "getTask"
        Me.getTask.Size = New System.Drawing.Size(111, 26)
        Me.getTask.TabIndex = 8
        Me.getTask.Text = "Назначить"
        Me.getTask.UseVisualStyleBackColor = True
        '
        'taskText
        '
        Me.taskText.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taskText.Location = New System.Drawing.Point(3, 110)
        Me.taskText.Multiline = True
        Me.taskText.Name = "taskText"
        Me.taskText.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.taskText.Size = New System.Drawing.Size(378, 377)
        Me.taskText.TabIndex = 7
        '
        'taskManager
        '
        Me.taskManager.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taskManager.AutoEllipsis = True
        Me.taskManager.AutoSize = True
        Me.taskManager.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taskManager.Location = New System.Drawing.Point(6, 498)
        Me.taskManager.Name = "taskManager"
        Me.taskManager.Size = New System.Drawing.Size(262, 19)
        Me.taskManager.TabIndex = 6
        Me.taskManager.Text = "Над задачей работает: Дубашинский И."
        '
        'taskState
        '
        Me.taskState.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taskState.AutoEllipsis = True
        Me.taskState.Location = New System.Drawing.Point(0, 74)
        Me.taskState.Name = "taskState"
        Me.taskState.Size = New System.Drawing.Size(381, 30)
        Me.taskState.TabIndex = 5
        Me.taskState.Text = "Необходимо выполнить до конца дня"
        Me.taskState.UseVisualStyleBackColor = True
        '
        'Customer
        '
        Me.Customer.BackColor = System.Drawing.Color.Transparent
        Me.Customer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Customer.Location = New System.Drawing.Point(6, 6)
        Me.Customer.Name = "Customer"
        Me.Customer.Size = New System.Drawing.Size(41, 35)
        Me.Customer.TabIndex = 4
        Me.Customer.UseVisualStyleBackColor = False
        '
        'taskHeader
        '
        Me.taskHeader.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taskHeader.AutoEllipsis = True
        Me.taskHeader.BackColor = System.Drawing.Color.DarkGray
        Me.taskHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taskHeader.ForeColor = System.Drawing.Color.White
        Me.taskHeader.Location = New System.Drawing.Point(0, 46)
        Me.taskHeader.Name = "taskHeader"
        Me.taskHeader.Size = New System.Drawing.Size(381, 30)
        Me.taskHeader.TabIndex = 2
        Me.taskHeader.Text = "Очень страшно обновляться! Все время ошибки!"
        '
        'taskCustomer
        '
        Me.taskCustomer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taskCustomer.AutoEllipsis = True
        Me.taskCustomer.Font = New System.Drawing.Font("Segoe UI Semibold", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taskCustomer.Location = New System.Drawing.Point(53, 22)
        Me.taskCustomer.Name = "taskCustomer"
        Me.taskCustomer.Size = New System.Drawing.Size(328, 19)
        Me.taskCustomer.TabIndex = 2
        Me.taskCustomer.Text = "Михаил Ключко, СитиИнвест Банк"
        '
        'taskDate
        '
        Me.taskDate.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.taskDate.AutoEllipsis = True
        Me.taskDate.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.taskDate.Location = New System.Drawing.Point(54, 6)
        Me.taskDate.Name = "taskDate"
        Me.taskDate.Size = New System.Drawing.Size(324, 19)
        Me.taskDate.TabIndex = 1
        Me.taskDate.Text = "Вторник, 10 июля 2016 15:30"
        '
        'Works
        '
        Me.Works.Controls.Add(Me.Button5)
        Me.Works.Controls.Add(Me.ListWorks)
        Me.Works.Location = New System.Drawing.Point(4, 29)
        Me.Works.Name = "Works"
        Me.Works.Padding = New System.Windows.Forms.Padding(3)
        Me.Works.Size = New System.Drawing.Size(379, 518)
        Me.Works.TabIndex = 1
        Me.Works.Text = "Работы"
        Me.Works.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button5.Location = New System.Drawing.Point(0, 0)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(380, 35)
        Me.Button5.TabIndex = 1
        Me.Button5.Text = "Создать новую"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'ListWorks
        '
        Me.ListWorks.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.ListWorks.FormattingEnabled = True
        Me.ListWorks.ItemHeight = 17
        Me.ListWorks.Location = New System.Drawing.Point(0, 37)
        Me.ListWorks.Name = "ListWorks"
        Me.ListWorks.Size = New System.Drawing.Size(380, 425)
        Me.ListWorks.TabIndex = 0
        '
        'Post
        '
        Me.Post.AutoScroll = True
        Me.Post.Location = New System.Drawing.Point(4, 29)
        Me.Post.Name = "Post"
        Me.Post.Size = New System.Drawing.Size(380, 520)
        Me.Post.TabIndex = 2
        Me.Post.Text = "Письма"
        Me.Post.UseVisualStyleBackColor = True
        '
        'files
        '
        Me.files.Location = New System.Drawing.Point(4, 29)
        Me.files.Name = "files"
        Me.files.Padding = New System.Windows.Forms.Padding(3)
        Me.files.Size = New System.Drawing.Size(379, 518)
        Me.files.TabIndex = 3
        Me.files.Text = "Файлы"
        Me.files.UseVisualStyleBackColor = True
        '
        'StatusStrip1
        '
        Me.StatusStrip1.BackColor = System.Drawing.Color.LightSteelBlue
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.taskType, Me.taskProject, Me.taskProduct, Me.taskBlock})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 592)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1154, 22)
        Me.StatusStrip1.TabIndex = 12
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'taskType
        '
        Me.taskType.BackColor = System.Drawing.Color.Transparent
        Me.taskType.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.taskType.Margin = New System.Windows.Forms.Padding(0, 3, 10, 2)
        Me.taskType.Name = "taskType"
        Me.taskType.Size = New System.Drawing.Size(128, 17)
        Me.taskType.Text = "Тип задачи: Инцидент"
        '
        'taskProject
        '
        Me.taskProject.BackColor = System.Drawing.Color.Transparent
        Me.taskProject.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.taskProject.Margin = New System.Windows.Forms.Padding(0, 3, 10, 2)
        Me.taskProject.Name = "taskProject"
        Me.taskProject.Size = New System.Drawing.Size(125, 17)
        Me.taskProject.Text = "Проект: Сити сопр 16"
        '
        'taskProduct
        '
        Me.taskProduct.BackColor = System.Drawing.Color.Transparent
        Me.taskProduct.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.taskProduct.Margin = New System.Windows.Forms.Padding(0, 3, 10, 2)
        Me.taskProduct.Name = "taskProduct"
        Me.taskProduct.Size = New System.Drawing.Size(128, 17)
        Me.taskProduct.Text = "Продукт: ЦАБС 21 Век"
        '
        'taskBlock
        '
        Me.taskBlock.BackColor = System.Drawing.Color.Transparent
        Me.taskBlock.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.taskBlock.Margin = New System.Windows.Forms.Padding(0, 3, 10, 2)
        Me.taskBlock.Name = "taskBlock"
        Me.taskBlock.Size = New System.Drawing.Size(67, 17)
        Me.taskBlock.Text = "Блок: Ядро"
        '
        'StateMenu
        '
        Me.StateMenu.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CloseTask, Me.OpenTask, Me.CancelTask, Me.SetTaskDeadline, Me.ChangeTaskCloseDate})
        Me.StateMenu.Name = "StateMenu"
        Me.StateMenu.Size = New System.Drawing.Size(212, 114)
        '
        'CloseTask
        '
        Me.CloseTask.Name = "CloseTask"
        Me.CloseTask.Size = New System.Drawing.Size(211, 22)
        Me.CloseTask.Text = "Закрыть задачу"
        '
        'OpenTask
        '
        Me.OpenTask.Name = "OpenTask"
        Me.OpenTask.Size = New System.Drawing.Size(211, 22)
        Me.OpenTask.Text = "Открыть задачу"
        '
        'CancelTask
        '
        Me.CancelTask.Name = "CancelTask"
        Me.CancelTask.Size = New System.Drawing.Size(211, 22)
        Me.CancelTask.Text = "Отменить задачу"
        '
        'SetTaskDeadline
        '
        Me.SetTaskDeadline.Name = "SetTaskDeadline"
        Me.SetTaskDeadline.Size = New System.Drawing.Size(211, 22)
        Me.SetTaskDeadline.Text = "Задать срок выполнения"
        '
        'ChangeTaskCloseDate
        '
        Me.ChangeTaskCloseDate.Name = "ChangeTaskCloseDate"
        Me.ChangeTaskCloseDate.Size = New System.Drawing.Size(211, 22)
        Me.ChangeTaskCloseDate.Text = "Изменить дату закрытия"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SavetoDB})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1154, 25)
        Me.ToolStrip1.TabIndex = 13
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'SavetoDB
        '
        Me.SavetoDB.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SavetoDB.Image = Global.ITasks.My.Resources.Resources.save_16xLG
        Me.SavetoDB.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SavetoDB.Name = "SavetoDB"
        Me.SavetoDB.Size = New System.Drawing.Size(23, 22)
        Me.SavetoDB.Text = "Save"
        '
        'Tasks
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.LightSlateGray
        Me.ClientSize = New System.Drawing.Size(1154, 614)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Tasks"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Задачи"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Tab.ResumeLayout(False)
        Me.Description.ResumeLayout(False)
        Me.Description.PerformLayout()
        Me.Works.ResumeLayout(False)
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.StateMenu.ResumeLayout(False)
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents aggTree As NTree
    Friend WithEvents Button4 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label7 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label8 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents tasksPanel As taskslistpanel
    Friend WithEvents Tab As TabControl
    Friend WithEvents Description As TabPage
    Friend WithEvents Works As TabPage
    Friend WithEvents Post As TabPage
    Friend WithEvents taskDate As Label
    Friend WithEvents taskCustomer As Label
    Friend WithEvents Customer As Button
    Friend WithEvents taskHeader As Label
    Friend WithEvents taskState As Button
    Friend WithEvents taskText As TextBox
    Friend WithEvents taskManager As Label
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents taskType As ToolStripStatusLabel
    Friend WithEvents taskProject As ToolStripStatusLabel
    Friend WithEvents taskProduct As ToolStripStatusLabel
    Friend WithEvents taskBlock As ToolStripStatusLabel
    Friend WithEvents getTask As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents ListWorks As ListBox
    Friend WithEvents files As TabPage
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents StateMenu As ContextMenuStrip
    Friend WithEvents CloseTask As ToolStripMenuItem
    Friend WithEvents SetTaskDeadline As ToolStripMenuItem
    Friend WithEvents CancelTask As ToolStripMenuItem
    Friend WithEvents ChangeTaskCloseDate As ToolStripMenuItem
    Friend WithEvents OpenTask As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SavetoDB As ToolStripButton
End Class

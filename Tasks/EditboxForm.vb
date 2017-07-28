Imports InveritasDB

Public Class EditboxForm
    Dim source As String
    Dim ds As IEnumerable(Of SUPPLICANTS)
    'Dim IEnum As IEnumerable(Of DataRow)
    Dim val As Integer
    Dim txt As String
    Dim canc As Boolean = True
    Dim entity As Entities



    Public ReadOnly Property Cancel() As Boolean
        Get
            Return canc
        End Get
    End Property
    Public ReadOnly Property Key() As Integer
        Get
            Return val
        End Get
    End Property
    Public ReadOnly Property Value() As String
        Get
            Return txt
        End Get
    End Property


    Public Sub New(ByVal ctrl As Control, ByRef result As Integer, ByRef text As String)
        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        Me.source = source
        Me.val = result
        Me.txt = text
        asyncQuery()
        Me.ActiveControl = TextBox1
        Me.Location = New Point(Cursor.Position.X, Cursor.Position.Y)
        entity = Adapter.entity
    End Sub

    Private Function GetAbsolutePosition(ByVal ctrl As Control) As Point
        If ctrl.Parent Is Nothing Then
            Return ctrl.Location
        Else
            Dim newPoint As Point = New Point(GetAbsolutePosition(ctrl.Parent))
            newPoint.X += ctrl.Location.X
            newPoint.Y += ctrl.Location.Y
            Return newPoint
        End If
    End Function

    ''' <summary>
    ''' Пока еще не асинхронный запрос к базе
    ''' </summary>
    ''' <param name="template">текстовый фрагмент для поиска</param>
    Sub asyncQuery(Optional ByVal template As String = Nothing)
        If template Is Nothing Then
            'ds = Populate("select * from supplicants where rownum < 10")
            ds = (From c In entity.SUPPLICANTS Select c).Take(10)
        Else
            template = "*" & template & "*"
            ' TODO: добавить поиск по ID и сделать поиск по нескольким словам через split с приоритетом максимального совпадения
            'ds = Populate("select * 
            '                 from supplicants
            '                where rownum < 10
            '                  and (upper(SUP) like '%" & template.ToUpper & "%'
            '                    or to_char(p_id) like '%" & template.ToUpper & "%'
            '                    or to_char(c_id) like '%" & template.ToUpper & "%')")
            ds = (From c In entity.SUPPLICANTS Where c.SUP.ToUpper Like template.ToUpper Or
                                                   c.C_ID.ToString Like template Or
                                                   c.P_ID.ToString Like template Select c).Take(10)
        End If
        'ds = IEnum.CopyToDataTable()

    End Sub

    Private Sub TextBox1_Enter(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        asyncQuery(TextBox1.Text)
        ListBox1.DataSource = ds
        ListBox1.DisplayMember = "SUP"
        ListBox1.ValueMember = "P_ID"
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.Click
        If ListBox1.SelectedItem IsNot Nothing Then
            TextBox1.Text = CType(ListBox1.SelectedItem, DataRowView)(0)
            val = ListBox1.SelectedValue
            txt = TextBox1.Text
            'result = res
        End If

    End Sub

    'Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

    'End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            setParamsAndClose()
        ElseIf e.KeyCode = Keys.Down Then
            Me.ActiveControl = ListBox1
            ListBox1.SelectedIndex += 1
        ElseIf e.KeyCode = Keys.Up Then
            Me.ActiveControl = ListBox1
            ListBox1.SelectedIndex -= 1
        ElseIf e.KeyCode = Keys.Escape Then
            Me.Close()
        End If
    End Sub



    Private Sub ListBox1_DoubleClick(sender As Object, e As EventArgs) Handles ListBox1.DoubleClick
        setParamsAndClose()
    End Sub

    Private Sub setParamsAndClose()
        If ListBox1.SelectedItem IsNot Nothing Then
            TextBox1.Text = CType(ListBox1.SelectedItem, DataRowView)(0)
            val = ListBox1.SelectedValue
            txt = TextBox1.Text
            canc = False
            Me.Close()
        End If
    End Sub

    Private Sub ListBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles ListBox1.KeyDown
        If e.KeyCode = Keys.Escape Then
            Me.Close()
        ElseIf e.KeyCode = Keys.Enter Then
            setParamsAndClose()
        End If
    End Sub
End Class
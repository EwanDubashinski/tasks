Public Class MailItem

    Public Sub New(ByVal headertext As String, ByVal dateTime As String, ByVal mtext As String, ByVal haveAttach As Boolean, ByVal width As Integer, ByVal side As Byte)
        InitializeComponent()
        Me.Width = width
        If side = 1 Then
            Panel1.Location = New Point(width - Panel1.Width, 0)
            'Anchor = AnchorStyles.Right Or AnchorStyles.Bottom
        Else
            'Anchor = AnchorStyles.Left Or AnchorStyles.Bottom
        End If
        MailDate.Text = dateTime
        MailHeader.Text = headertext
        Mailtext.Text = mtext
        Attach.Visible = haveAttach
        Margin = New Padding(0)
        Anchor = AnchorStyles.Left Or AnchorStyles.Right Or AnchorStyles.Bottom
    End Sub
End Class

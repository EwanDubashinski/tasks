<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MailItem
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me.MailHeader = New System.Windows.Forms.Label()
        Me.MailDate = New System.Windows.Forms.Label()
        Me.Mailtext = New System.Windows.Forms.TextBox()
        Me.Attach = New System.Windows.Forms.PictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.Attach, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MailHeader
        '
        Me.MailHeader.AutoEllipsis = True
        Me.MailHeader.AutoSize = True
        Me.MailHeader.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MailHeader.ForeColor = System.Drawing.Color.DimGray
        Me.MailHeader.Location = New System.Drawing.Point(3, 3)
        Me.MailHeader.Name = "MailHeader"
        Me.MailHeader.Size = New System.Drawing.Size(215, 15)
        Me.MailHeader.TabIndex = 1
        Me.MailHeader.Text = "Иван Дубашинский Алине Зенькович:"
        '
        'MailDate
        '
        Me.MailDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MailDate.AutoSize = True
        Me.MailDate.Font = New System.Drawing.Font("Segoe UI Semilight", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.MailDate.ForeColor = System.Drawing.Color.DarkGray
        Me.MailDate.Location = New System.Drawing.Point(114, 543)
        Me.MailDate.Name = "MailDate"
        Me.MailDate.Size = New System.Drawing.Size(114, 15)
        Me.MailDate.TabIndex = 2
        Me.MailDate.Text = "10:21 15 июля 2016 г."
        '
        'Mailtext
        '
        Me.Mailtext.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Mailtext.BackColor = System.Drawing.Color.Lavender
        Me.Mailtext.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Mailtext.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Mailtext.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.Mailtext.Location = New System.Drawing.Point(3, 21)
        Me.Mailtext.Multiline = True
        Me.Mailtext.Name = "Mailtext"
        Me.Mailtext.ReadOnly = True
        Me.Mailtext.Size = New System.Drawing.Size(222, 515)
        Me.Mailtext.TabIndex = 4
        Me.Mailtext.Text = "Это ошибка, которая была исправлена в патче 600_104. " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Достаточно установить испр" &
    "авленный пакет (во вложении)." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "На базе oralin пакет уже стоит, пролонгация завод" &
    "ится." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Attach
        '
        Me.Attach.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Attach.Image = Global.InversionERP.My.Resources.Resources.att16
        Me.Attach.Location = New System.Drawing.Point(3, 542)
        Me.Attach.Name = "Attach"
        Me.Attach.Size = New System.Drawing.Size(16, 16)
        Me.Attach.TabIndex = 3
        Me.Attach.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.Lavender
        Me.Panel1.Controls.Add(Me.Attach)
        Me.Panel1.Controls.Add(Me.MailHeader)
        Me.Panel1.Controls.Add(Me.Mailtext)
        Me.Panel1.Controls.Add(Me.MailDate)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(231, 561)
        Me.Panel1.TabIndex = 5
        '
        'MailItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Name = "MailItem"
        Me.Size = New System.Drawing.Size(331, 561)
        CType(Me.Attach, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents MailHeader As Label
    Friend WithEvents MailDate As Label
    Friend WithEvents Attach As PictureBox
    Friend WithEvents Mailtext As TextBox
    Friend WithEvents Panel1 As Panel
End Class

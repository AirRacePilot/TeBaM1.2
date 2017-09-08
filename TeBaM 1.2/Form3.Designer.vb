<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Btn_del = New System.Windows.Forms.Button()
        Me.Btn_down = New System.Windows.Forms.Button()
        Me.Btn_up = New System.Windows.Forms.Button()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.Btn_addBookmark = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CB_iput = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Btn_del)
        Me.GroupBox1.Controls.Add(Me.Btn_down)
        Me.GroupBox1.Controls.Add(Me.Btn_up)
        Me.GroupBox1.Controls.Add(Me.ListBox1)
        Me.GroupBox1.Controls.Add(Me.Btn_addBookmark)
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.CB_iput)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4)
        Me.GroupBox1.Size = New System.Drawing.Size(657, 385)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Zuordnung der word Textmarken"
        '
        'Btn_del
        '
        Me.Btn_del.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_del.Location = New System.Drawing.Point(493, 340)
        Me.Btn_del.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_del.Name = "Btn_del"
        Me.Btn_del.Size = New System.Drawing.Size(147, 28)
        Me.Btn_del.TabIndex = 8
        Me.Btn_del.Text = "löschen"
        Me.Btn_del.UseVisualStyleBackColor = True
        '
        'Btn_down
        '
        Me.Btn_down.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_down.Location = New System.Drawing.Point(493, 144)
        Me.Btn_down.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_down.Name = "Btn_down"
        Me.Btn_down.Size = New System.Drawing.Size(147, 28)
        Me.Btn_down.TabIndex = 7
        Me.Btn_down.Text = "ab"
        Me.Btn_down.UseVisualStyleBackColor = True
        '
        'Btn_up
        '
        Me.Btn_up.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_up.Location = New System.Drawing.Point(493, 108)
        Me.Btn_up.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_up.Name = "Btn_up"
        Me.Btn_up.Size = New System.Drawing.Size(147, 28)
        Me.Btn_up.TabIndex = 6
        Me.Btn_up.Text = "auf"
        Me.Btn_up.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 16
        Me.ListBox1.Location = New System.Drawing.Point(16, 108)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(468, 260)
        Me.ListBox1.TabIndex = 5
        '
        'Btn_addBookmark
        '
        Me.Btn_addBookmark.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Btn_addBookmark.Location = New System.Drawing.Point(493, 32)
        Me.Btn_addBookmark.Margin = New System.Windows.Forms.Padding(4)
        Me.Btn_addBookmark.Name = "Btn_addBookmark"
        Me.Btn_addBookmark.Size = New System.Drawing.Size(147, 28)
        Me.Btn_addBookmark.TabIndex = 4
        Me.Btn_addBookmark.Text = "hinzufügen"
        Me.Btn_addBookmark.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(179, 74)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(305, 22)
        Me.TextBox1.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 77)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(108, 17)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "word Textmarke"
        '
        'CB_iput
        '
        Me.CB_iput.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CB_iput.FormattingEnabled = True
        Me.CB_iput.Items.AddRange(New Object() {"Firma1", "Firma2", "Ansprechpartner1", "Ansprechpartner2", "Anrede_Herr_Frau1", "Anrede_Herr_Frau2", "Strasse", "Postleitzahl", "Ort", "Angebotstitel", "Angebotsnummer", "Vertreter", "E-Mail", "Mobiltelefon"})
        Me.CB_iput.Location = New System.Drawing.Point(179, 32)
        Me.CB_iput.Margin = New System.Windows.Forms.Padding(4)
        Me.CB_iput.Name = "CB_iput"
        Me.CB_iput.Size = New System.Drawing.Size(305, 24)
        Me.CB_iput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(13, 35)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Eingabefeld"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(657, 385)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form3"
        Me.Text = "Textmarken definieren"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Btn_del As Button
    Friend WithEvents Btn_down As Button
    Friend WithEvents Btn_up As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents Btn_addBookmark As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CB_iput As ComboBox
    Friend WithEvents Label1 As Label
End Class

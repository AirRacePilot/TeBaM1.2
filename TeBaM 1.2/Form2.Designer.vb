<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Dim VertreternummerLabel As System.Windows.Forms.Label
        Dim AnredeLabel As System.Windows.Forms.Label
        Dim VornameLabel As System.Windows.Forms.Label
        Dim NachnameLabel As System.Windows.Forms.Label
        Dim TelefonnummerLabel As System.Windows.Forms.Label
        Dim AngezeigterNameLabel As System.Windows.Forms.Label
        Dim E_mailLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.DataSet2 = New TeBaM_1._2.DataSet2()
        Me.VertreterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.VertreterBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.VertreterBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.VertreternummerTextBox = New System.Windows.Forms.TextBox()
        Me.AnredeTextBox = New System.Windows.Forms.TextBox()
        Me.VornameTextBox = New System.Windows.Forms.TextBox()
        Me.NachnameTextBox = New System.Windows.Forms.TextBox()
        Me.TelefonnummerTextBox = New System.Windows.Forms.TextBox()
        Me.AngezeigterNameTextBox = New System.Windows.Forms.TextBox()
        Me.E_mailTextBox = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        VertreternummerLabel = New System.Windows.Forms.Label()
        AnredeLabel = New System.Windows.Forms.Label()
        VornameLabel = New System.Windows.Forms.Label()
        NachnameLabel = New System.Windows.Forms.Label()
        TelefonnummerLabel = New System.Windows.Forms.Label()
        AngezeigterNameLabel = New System.Windows.Forms.Label()
        E_mailLabel = New System.Windows.Forms.Label()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VertreterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.VertreterBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.VertreterBindingNavigator.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'VertreternummerLabel
        '
        VertreternummerLabel.AutoSize = True
        VertreternummerLabel.Location = New System.Drawing.Point(44, 34)
        VertreternummerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VertreternummerLabel.Name = "VertreternummerLabel"
        VertreternummerLabel.Size = New System.Drawing.Size(119, 17)
        VertreternummerLabel.TabIndex = 1
        VertreternummerLabel.Text = "Vertreternummer:"
        '
        'AnredeLabel
        '
        AnredeLabel.AutoSize = True
        AnredeLabel.Location = New System.Drawing.Point(44, 66)
        AnredeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AnredeLabel.Name = "AnredeLabel"
        AnredeLabel.Size = New System.Drawing.Size(58, 17)
        AnredeLabel.TabIndex = 3
        AnredeLabel.Text = "Anrede:"
        '
        'VornameLabel
        '
        VornameLabel.AutoSize = True
        VornameLabel.Location = New System.Drawing.Point(44, 98)
        VornameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        VornameLabel.Name = "VornameLabel"
        VornameLabel.Size = New System.Drawing.Size(69, 17)
        VornameLabel.TabIndex = 5
        VornameLabel.Text = "Vorname:"
        '
        'NachnameLabel
        '
        NachnameLabel.AutoSize = True
        NachnameLabel.Location = New System.Drawing.Point(44, 130)
        NachnameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        NachnameLabel.Name = "NachnameLabel"
        NachnameLabel.Size = New System.Drawing.Size(80, 17)
        NachnameLabel.TabIndex = 7
        NachnameLabel.Text = "Nachname:"
        '
        'TelefonnummerLabel
        '
        TelefonnummerLabel.AutoSize = True
        TelefonnummerLabel.Location = New System.Drawing.Point(44, 162)
        TelefonnummerLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        TelefonnummerLabel.Name = "TelefonnummerLabel"
        TelefonnummerLabel.Size = New System.Drawing.Size(111, 17)
        TelefonnummerLabel.TabIndex = 9
        TelefonnummerLabel.Text = "Telefonnummer:"
        '
        'AngezeigterNameLabel
        '
        AngezeigterNameLabel.AutoSize = True
        AngezeigterNameLabel.Location = New System.Drawing.Point(44, 194)
        AngezeigterNameLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        AngezeigterNameLabel.Name = "AngezeigterNameLabel"
        AngezeigterNameLabel.Size = New System.Drawing.Size(128, 17)
        AngezeigterNameLabel.TabIndex = 11
        AngezeigterNameLabel.Text = "angezeigter Name:"
        '
        'E_mailLabel
        '
        E_mailLabel.AutoSize = True
        E_mailLabel.Location = New System.Drawing.Point(44, 226)
        E_mailLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        E_mailLabel.Name = "E_mailLabel"
        E_mailLabel.Size = New System.Drawing.Size(49, 17)
        E_mailLabel.TabIndex = 13
        E_mailLabel.Text = "e mail:"
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'VertreterBindingSource
        '
        Me.VertreterBindingSource.DataMember = "Vertreter"
        Me.VertreterBindingSource.DataSource = Me.DataSet2
        '
        'VertreterBindingNavigator
        '
        Me.VertreterBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.VertreterBindingNavigator.BindingSource = Me.VertreterBindingSource
        Me.VertreterBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.VertreterBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.VertreterBindingNavigator.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.VertreterBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.VertreterBindingNavigatorSaveItem})
        Me.VertreterBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.VertreterBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.VertreterBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.VertreterBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.VertreterBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.VertreterBindingNavigator.Name = "VertreterBindingNavigator"
        Me.VertreterBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.VertreterBindingNavigator.Size = New System.Drawing.Size(560, 27)
        Me.VertreterBindingNavigator.TabIndex = 0
        Me.VertreterBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorAddNewItem.Text = "Neu hinzufügen"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(55, 24)
        Me.BindingNavigatorCountItem.Text = "von {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Die Gesamtanzahl der Elemente."
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorDeleteItem.Text = "Löschen"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveFirstItem.Text = "Erste verschieben"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMovePreviousItem.Text = "Vorherige verschieben"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(65, 27)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Aktuelle Position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveNextItem.Text = "Nächste verschieben"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(24, 24)
        Me.BindingNavigatorMoveLastItem.Text = "Letzte verschieben"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 27)
        '
        'VertreterBindingNavigatorSaveItem
        '
        Me.VertreterBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.VertreterBindingNavigatorSaveItem.Enabled = False
        Me.VertreterBindingNavigatorSaveItem.Image = CType(resources.GetObject("VertreterBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.VertreterBindingNavigatorSaveItem.Name = "VertreterBindingNavigatorSaveItem"
        Me.VertreterBindingNavigatorSaveItem.Size = New System.Drawing.Size(24, 24)
        Me.VertreterBindingNavigatorSaveItem.Text = "Daten speichern"
        '
        'VertreternummerTextBox
        '
        Me.VertreternummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "Vertreternummer", True))
        Me.VertreternummerTextBox.Location = New System.Drawing.Point(180, 31)
        Me.VertreternummerTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VertreternummerTextBox.Name = "VertreternummerTextBox"
        Me.VertreternummerTextBox.Size = New System.Drawing.Size(363, 22)
        Me.VertreternummerTextBox.TabIndex = 2
        '
        'AnredeTextBox
        '
        Me.AnredeTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "Anrede", True))
        Me.AnredeTextBox.Location = New System.Drawing.Point(180, 63)
        Me.AnredeTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AnredeTextBox.Name = "AnredeTextBox"
        Me.AnredeTextBox.Size = New System.Drawing.Size(363, 22)
        Me.AnredeTextBox.TabIndex = 4
        '
        'VornameTextBox
        '
        Me.VornameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "Vorname", True))
        Me.VornameTextBox.Location = New System.Drawing.Point(180, 95)
        Me.VornameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.VornameTextBox.Name = "VornameTextBox"
        Me.VornameTextBox.Size = New System.Drawing.Size(363, 22)
        Me.VornameTextBox.TabIndex = 6
        '
        'NachnameTextBox
        '
        Me.NachnameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "Nachname", True))
        Me.NachnameTextBox.Location = New System.Drawing.Point(180, 127)
        Me.NachnameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.NachnameTextBox.Name = "NachnameTextBox"
        Me.NachnameTextBox.Size = New System.Drawing.Size(363, 22)
        Me.NachnameTextBox.TabIndex = 8
        '
        'TelefonnummerTextBox
        '
        Me.TelefonnummerTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "Telefonnummer", True))
        Me.TelefonnummerTextBox.Location = New System.Drawing.Point(180, 159)
        Me.TelefonnummerTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.TelefonnummerTextBox.Name = "TelefonnummerTextBox"
        Me.TelefonnummerTextBox.Size = New System.Drawing.Size(363, 22)
        Me.TelefonnummerTextBox.TabIndex = 10
        '
        'AngezeigterNameTextBox
        '
        Me.AngezeigterNameTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "angezeigterName", True))
        Me.AngezeigterNameTextBox.Location = New System.Drawing.Point(180, 191)
        Me.AngezeigterNameTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.AngezeigterNameTextBox.Name = "AngezeigterNameTextBox"
        Me.AngezeigterNameTextBox.Size = New System.Drawing.Size(363, 22)
        Me.AngezeigterNameTextBox.TabIndex = 12
        '
        'E_mailTextBox
        '
        Me.E_mailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "e_mail", True))
        Me.E_mailTextBox.Location = New System.Drawing.Point(180, 223)
        Me.E_mailTextBox.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.E_mailTextBox.Name = "E_mailTextBox"
        Me.E_mailTextBox.Size = New System.Drawing.Size(363, 22)
        Me.E_mailTextBox.TabIndex = 14
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(VertreternummerLabel)
        Me.GroupBox1.Controls.Add(Me.E_mailTextBox)
        Me.GroupBox1.Controls.Add(Me.VertreternummerTextBox)
        Me.GroupBox1.Controls.Add(E_mailLabel)
        Me.GroupBox1.Controls.Add(AnredeLabel)
        Me.GroupBox1.Controls.Add(Me.AngezeigterNameTextBox)
        Me.GroupBox1.Controls.Add(Me.AnredeTextBox)
        Me.GroupBox1.Controls.Add(AngezeigterNameLabel)
        Me.GroupBox1.Controls.Add(VornameLabel)
        Me.GroupBox1.Controls.Add(Me.TelefonnummerTextBox)
        Me.GroupBox1.Controls.Add(Me.VornameTextBox)
        Me.GroupBox1.Controls.Add(TelefonnummerLabel)
        Me.GroupBox1.Controls.Add(NachnameLabel)
        Me.GroupBox1.Controls.Add(Me.NachnameTextBox)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 27)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(560, 267)
        Me.GroupBox1.TabIndex = 15
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "GroupBox1"
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(560, 294)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.VertreterBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form2"
        Me.Text = "Vertreter"
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VertreterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.VertreterBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.VertreterBindingNavigator.ResumeLayout(False)
        Me.VertreterBindingNavigator.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents VertreterBindingSource As BindingSource
    Friend WithEvents VertreterBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents VertreterBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents VertreternummerTextBox As TextBox
    Friend WithEvents AnredeTextBox As TextBox
    Friend WithEvents VornameTextBox As TextBox
    Friend WithEvents NachnameTextBox As TextBox
    Friend WithEvents TelefonnummerTextBox As TextBox
    Friend WithEvents AngezeigterNameTextBox As TextBox
    Friend WithEvents E_mailTextBox As TextBox
    Friend WithEvents GroupBox1 As GroupBox
End Class

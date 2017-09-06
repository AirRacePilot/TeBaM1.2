<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim KdNummerLabel As System.Windows.Forms.Label
        Dim Firma1Label As System.Windows.Forms.Label
        Dim Firma2Label As System.Windows.Forms.Label
        Dim Name1Label As System.Windows.Forms.Label
        Dim Name2Label As System.Windows.Forms.Label
        Dim StrasseLabel As System.Windows.Forms.Label
        Dim PLZLabel As System.Windows.Forms.Label
        Dim OrtLabel As System.Windows.Forms.Label
        Dim AngezeigterNameLabel As System.Windows.Forms.Label
        Dim HerstellerLabel As System.Windows.Forms.Label
        Dim ProduktTypLabel As System.Windows.Forms.Label
        Dim URLLabel As System.Windows.Forms.Label
        Dim ArtikelnrLabel As System.Windows.Forms.Label
        Dim RubrikLabel As System.Windows.Forms.Label
        Dim ArtikelkurztextLabel As System.Windows.Forms.Label
        Dim BeschreibungLabel As System.Windows.Forms.Label
        Dim EKPreisLabel As System.Windows.Forms.Label
        Dim VKPreisLabel As System.Windows.Forms.Label
        Dim FaktorLabel As System.Windows.Forms.Label
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AngebotIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KundennummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngebotURLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKKundeAngebotBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.KundeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet1 = New TeBaM_1._2.DataSet1()
        Me.Kunden = New System.Windows.Forms.Panel()
        Me.KundeGroupBox = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DokumentenvorlageComboBox = New System.Windows.Forms.ComboBox()
        Me.VertreterComboBox = New System.Windows.Forms.ComboBox()
        Me.VertreterBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSet2 = New TeBaM_1._2.DataSet2()
        Me.OrtTextBox = New System.Windows.Forms.TextBox()
        Me.KdNummerComboBox = New System.Windows.Forms.ComboBox()
        Me.PLZTextBox = New System.Windows.Forms.TextBox()
        Me.Firma1TextBox = New System.Windows.Forms.TextBox()
        Me.StrasseTextBox = New System.Windows.Forms.TextBox()
        Me.Firma2TextBox = New System.Windows.Forms.TextBox()
        Me.Name2TextBox = New System.Windows.Forms.TextBox()
        Me.Name1TextBox = New System.Windows.Forms.TextBox()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.AddCustomer = New System.Windows.Forms.ToolStripButton()
        Me.DelCustomer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.AddOffer = New System.Windows.Forms.ToolStripButton()
        Me.DelOffer = New System.Windows.Forms.ToolStripButton()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArtikelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.OptionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngebotsnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ArtikelIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKAngebotSpezOptionenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArtikelGroupBox = New System.Windows.Forms.GroupBox()
        Me.RubrikMaskedTextBox = New System.Windows.Forms.MaskedTextBox()
        Me.ButtonAddURL = New System.Windows.Forms.Button()
        Me.MaskedTextBoxArtikelnummer = New System.Windows.Forms.MaskedTextBox()
        Me.URLTextBox = New System.Windows.Forms.TextBox()
        Me.ArtikelkurztextTextBox = New System.Windows.Forms.TextBox()
        Me.BeschreibungTextBox = New System.Windows.Forms.TextBox()
        Me.EKPreisTextBox = New System.Windows.Forms.TextBox()
        Me.VKPreisTextBox = New System.Windows.Forms.TextBox()
        Me.FaktorTextBox = New System.Windows.Forms.TextBox()
        Me.ProduktgruppeGroupBox = New System.Windows.Forms.GroupBox()
        Me.HerstellerComboBox = New System.Windows.Forms.ComboBox()
        Me.HerstellerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ProduktTypComboBox = New System.Windows.Forms.ComboBox()
        Me.ProduktBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ToolStrip3 = New System.Windows.Forms.ToolStrip()
        Me.AddManufacturerNode = New System.Windows.Forms.ToolStripButton()
        Me.AddProductNode = New System.Windows.Forms.ToolStripButton()
        Me.AddArticleNode = New System.Windows.Forms.ToolStripButton()
        Me.DelNode = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktstrukturNeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktsrukturÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertreterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeBearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextmarkenDefinierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        KdNummerLabel = New System.Windows.Forms.Label()
        Firma1Label = New System.Windows.Forms.Label()
        Firma2Label = New System.Windows.Forms.Label()
        Name1Label = New System.Windows.Forms.Label()
        Name2Label = New System.Windows.Forms.Label()
        StrasseLabel = New System.Windows.Forms.Label()
        PLZLabel = New System.Windows.Forms.Label()
        OrtLabel = New System.Windows.Forms.Label()
        AngezeigterNameLabel = New System.Windows.Forms.Label()
        HerstellerLabel = New System.Windows.Forms.Label()
        ProduktTypLabel = New System.Windows.Forms.Label()
        URLLabel = New System.Windows.Forms.Label()
        ArtikelnrLabel = New System.Windows.Forms.Label()
        RubrikLabel = New System.Windows.Forms.Label()
        ArtikelkurztextLabel = New System.Windows.Forms.Label()
        BeschreibungLabel = New System.Windows.Forms.Label()
        EKPreisLabel = New System.Windows.Forms.Label()
        VKPreisLabel = New System.Windows.Forms.Label()
        FaktorLabel = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKKundeAngebotBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.KundeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Kunden.SuspendLayout()
        Me.KundeGroupBox.SuspendLayout()
        CType(Me.VertreterBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtikelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKAngebotSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.ArtikelGroupBox.SuspendLayout()
        Me.ProduktgruppeGroupBox.SuspendLayout()
        CType(Me.HerstellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KdNummerLabel
        '
        KdNummerLabel.AutoSize = True
        KdNummerLabel.Location = New System.Drawing.Point(18, 32)
        KdNummerLabel.Name = "KdNummerLabel"
        KdNummerLabel.Size = New System.Drawing.Size(86, 17)
        KdNummerLabel.TabIndex = 3
        KdNummerLabel.Text = "Kd Nummer:"
        '
        'Firma1Label
        '
        Firma1Label.AutoSize = True
        Firma1Label.Location = New System.Drawing.Point(18, 60)
        Firma1Label.Name = "Firma1Label"
        Firma1Label.Size = New System.Drawing.Size(55, 17)
        Firma1Label.TabIndex = 5
        Firma1Label.Text = "Firma1:"
        '
        'Firma2Label
        '
        Firma2Label.AutoSize = True
        Firma2Label.Location = New System.Drawing.Point(552, 60)
        Firma2Label.Name = "Firma2Label"
        Firma2Label.Size = New System.Drawing.Size(55, 17)
        Firma2Label.TabIndex = 7
        Firma2Label.Text = "Firma2:"
        '
        'Name1Label
        '
        Name1Label.AutoSize = True
        Name1Label.Location = New System.Drawing.Point(18, 88)
        Name1Label.Name = "Name1Label"
        Name1Label.Size = New System.Drawing.Size(57, 17)
        Name1Label.TabIndex = 9
        Name1Label.Text = "Name1:"
        '
        'Name2Label
        '
        Name2Label.AutoSize = True
        Name2Label.Location = New System.Drawing.Point(552, 88)
        Name2Label.Name = "Name2Label"
        Name2Label.Size = New System.Drawing.Size(57, 17)
        Name2Label.TabIndex = 11
        Name2Label.Text = "Name2:"
        '
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(18, 116)
        StrasseLabel.Name = "StrasseLabel"
        StrasseLabel.Size = New System.Drawing.Size(60, 17)
        StrasseLabel.TabIndex = 13
        StrasseLabel.Text = "Strasse:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(18, 144)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(38, 17)
        PLZLabel.TabIndex = 15
        PLZLabel.Text = "PLZ:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(218, 144)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(32, 17)
        OrtLabel.TabIndex = 17
        OrtLabel.Text = "Ort:"
        '
        'AngezeigterNameLabel
        '
        AngezeigterNameLabel.AutoSize = True
        AngezeigterNameLabel.Location = New System.Drawing.Point(18, 172)
        AngezeigterNameLabel.Name = "AngezeigterNameLabel"
        AngezeigterNameLabel.Size = New System.Drawing.Size(68, 17)
        AngezeigterNameLabel.TabIndex = 21
        AngezeigterNameLabel.Text = "Vertreter:"
        '
        'HerstellerLabel
        '
        HerstellerLabel.AutoSize = True
        HerstellerLabel.Location = New System.Drawing.Point(16, 26)
        HerstellerLabel.Name = "HerstellerLabel"
        HerstellerLabel.Size = New System.Drawing.Size(73, 17)
        HerstellerLabel.TabIndex = 4
        HerstellerLabel.Text = "Hersteller:"
        '
        'ProduktTypLabel
        '
        ProduktTypLabel.AutoSize = True
        ProduktTypLabel.Location = New System.Drawing.Point(400, 26)
        ProduktTypLabel.Name = "ProduktTypLabel"
        ProduktTypLabel.Size = New System.Drawing.Size(89, 17)
        ProduktTypLabel.TabIndex = 10
        ProduktTypLabel.Text = "Produkt Typ:"
        '
        'URLLabel
        '
        URLLabel.AutoSize = True
        URLLabel.Location = New System.Drawing.Point(11, 240)
        URLLabel.Name = "URLLabel"
        URLLabel.Size = New System.Drawing.Size(40, 17)
        URLLabel.TabIndex = 6
        URLLabel.Text = "URL:"
        '
        'ArtikelnrLabel
        '
        ArtikelnrLabel.AutoSize = True
        ArtikelnrLabel.Location = New System.Drawing.Point(11, 64)
        ArtikelnrLabel.Name = "ArtikelnrLabel"
        ArtikelnrLabel.Size = New System.Drawing.Size(64, 17)
        ArtikelnrLabel.TabIndex = 8
        ArtikelnrLabel.Text = "Artikelnr:"
        '
        'RubrikLabel
        '
        RubrikLabel.AutoSize = True
        RubrikLabel.Location = New System.Drawing.Point(11, 92)
        RubrikLabel.Name = "RubrikLabel"
        RubrikLabel.Size = New System.Drawing.Size(53, 17)
        RubrikLabel.TabIndex = 10
        RubrikLabel.Text = "Rubrik:"
        '
        'ArtikelkurztextLabel
        '
        ArtikelkurztextLabel.AutoSize = True
        ArtikelkurztextLabel.Location = New System.Drawing.Point(11, 33)
        ArtikelkurztextLabel.Name = "ArtikelkurztextLabel"
        ArtikelkurztextLabel.Size = New System.Drawing.Size(100, 17)
        ArtikelkurztextLabel.TabIndex = 12
        ArtikelkurztextLabel.Text = "Artikelkurztext:"
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Location = New System.Drawing.Point(11, 120)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(99, 17)
        BeschreibungLabel.TabIndex = 14
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'EKPreisLabel
        '
        EKPreisLabel.AutoSize = True
        EKPreisLabel.Location = New System.Drawing.Point(279, 61)
        EKPreisLabel.Name = "EKPreisLabel"
        EKPreisLabel.Size = New System.Drawing.Size(62, 17)
        EKPreisLabel.TabIndex = 16
        EKPreisLabel.Text = "EKPreis:"
        '
        'VKPreisLabel
        '
        VKPreisLabel.AutoSize = True
        VKPreisLabel.Location = New System.Drawing.Point(279, 92)
        VKPreisLabel.Name = "VKPreisLabel"
        VKPreisLabel.Size = New System.Drawing.Size(62, 17)
        VKPreisLabel.TabIndex = 18
        VKPreisLabel.Text = "VKPreis:"
        '
        'FaktorLabel
        '
        FaktorLabel.AutoSize = True
        FaktorLabel.Location = New System.Drawing.Point(552, 64)
        FaktorLabel.Name = "FaktorLabel"
        FaktorLabel.Size = New System.Drawing.Size(52, 17)
        FaktorLabel.TabIndex = 20
        FaktorLabel.Text = "Faktor:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 28)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1169, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 578)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(1169, 22)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 53)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1169, 525)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Kunden)
        Me.TabPage1.Location = New System.Drawing.Point(4, 25)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1161, 496)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kunden"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AngebotIDDataGridViewTextBoxColumn, Me.KundennummerDataGridViewTextBoxColumn, Me.AngebotURLDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.FKKundeAngebotBindingSource
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(3, 268)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(1155, 225)
        Me.DataGridView1.TabIndex = 1
        '
        'AngebotIDDataGridViewTextBoxColumn
        '
        Me.AngebotIDDataGridViewTextBoxColumn.DataPropertyName = "AngebotID"
        Me.AngebotIDDataGridViewTextBoxColumn.HeaderText = "AngebotID"
        Me.AngebotIDDataGridViewTextBoxColumn.Name = "AngebotIDDataGridViewTextBoxColumn"
        '
        'KundennummerDataGridViewTextBoxColumn
        '
        Me.KundennummerDataGridViewTextBoxColumn.DataPropertyName = "Kundennummer"
        Me.KundennummerDataGridViewTextBoxColumn.HeaderText = "Kundennummer"
        Me.KundennummerDataGridViewTextBoxColumn.Name = "KundennummerDataGridViewTextBoxColumn"
        '
        'AngebotURLDataGridViewTextBoxColumn
        '
        Me.AngebotURLDataGridViewTextBoxColumn.DataPropertyName = "AngebotURL"
        Me.AngebotURLDataGridViewTextBoxColumn.HeaderText = "AngebotURL"
        Me.AngebotURLDataGridViewTextBoxColumn.Name = "AngebotURLDataGridViewTextBoxColumn"
        '
        'FKKundeAngebotBindingSource
        '
        Me.FKKundeAngebotBindingSource.DataMember = "FK_Kunde_Angebot"
        Me.FKKundeAngebotBindingSource.DataSource = Me.KundeBindingSource
        '
        'KundeBindingSource
        '
        Me.KundeBindingSource.DataMember = "Kunde"
        Me.KundeBindingSource.DataSource = Me.DataSet1
        '
        'DataSet1
        '
        Me.DataSet1.DataSetName = "DataSet1"
        Me.DataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Kunden
        '
        Me.Kunden.Controls.Add(Me.KundeGroupBox)
        Me.Kunden.Controls.Add(Me.ToolStrip2)
        Me.Kunden.Dock = System.Windows.Forms.DockStyle.Top
        Me.Kunden.Location = New System.Drawing.Point(3, 3)
        Me.Kunden.Name = "Kunden"
        Me.Kunden.Size = New System.Drawing.Size(1155, 265)
        Me.Kunden.TabIndex = 0
        '
        'KundeGroupBox
        '
        Me.KundeGroupBox.Controls.Add(Me.Label1)
        Me.KundeGroupBox.Controls.Add(Me.DokumentenvorlageComboBox)
        Me.KundeGroupBox.Controls.Add(Me.VertreterComboBox)
        Me.KundeGroupBox.Controls.Add(KdNummerLabel)
        Me.KundeGroupBox.Controls.Add(AngezeigterNameLabel)
        Me.KundeGroupBox.Controls.Add(Me.OrtTextBox)
        Me.KundeGroupBox.Controls.Add(Me.KdNummerComboBox)
        Me.KundeGroupBox.Controls.Add(OrtLabel)
        Me.KundeGroupBox.Controls.Add(Me.PLZTextBox)
        Me.KundeGroupBox.Controls.Add(Firma1Label)
        Me.KundeGroupBox.Controls.Add(PLZLabel)
        Me.KundeGroupBox.Controls.Add(Me.Firma1TextBox)
        Me.KundeGroupBox.Controls.Add(Me.StrasseTextBox)
        Me.KundeGroupBox.Controls.Add(Firma2Label)
        Me.KundeGroupBox.Controls.Add(StrasseLabel)
        Me.KundeGroupBox.Controls.Add(Me.Firma2TextBox)
        Me.KundeGroupBox.Controls.Add(Me.Name2TextBox)
        Me.KundeGroupBox.Controls.Add(Name1Label)
        Me.KundeGroupBox.Controls.Add(Name2Label)
        Me.KundeGroupBox.Controls.Add(Me.Name1TextBox)
        Me.KundeGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.KundeGroupBox.Location = New System.Drawing.Point(0, 39)
        Me.KundeGroupBox.Name = "KundeGroupBox"
        Me.KundeGroupBox.Size = New System.Drawing.Size(1155, 226)
        Me.KundeGroupBox.TabIndex = 24
        Me.KundeGroupBox.TabStop = False
        Me.KundeGroupBox.Text = "Kunde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(474, 172)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(139, 17)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Dokumentenvorlage:"
        '
        'DokumentenvorlageComboBox
        '
        Me.DokumentenvorlageComboBox.FormattingEnabled = True
        Me.DokumentenvorlageComboBox.Location = New System.Drawing.Point(626, 169)
        Me.DokumentenvorlageComboBox.Name = "DokumentenvorlageComboBox"
        Me.DokumentenvorlageComboBox.Size = New System.Drawing.Size(385, 24)
        Me.DokumentenvorlageComboBox.TabIndex = 24
        '
        'VertreterComboBox
        '
        Me.VertreterComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.VertreterBindingSource, "angezeigterName", True))
        Me.VertreterComboBox.DataSource = Me.VertreterBindingSource
        Me.VertreterComboBox.FormattingEnabled = True
        Me.VertreterComboBox.Location = New System.Drawing.Point(118, 169)
        Me.VertreterComboBox.Name = "VertreterComboBox"
        Me.VertreterComboBox.Size = New System.Drawing.Size(319, 24)
        Me.VertreterComboBox.TabIndex = 23
        '
        'VertreterBindingSource
        '
        Me.VertreterBindingSource.DataMember = "Vertreter"
        Me.VertreterBindingSource.DataSource = Me.DataSet2
        '
        'DataSet2
        '
        Me.DataSet2.DataSetName = "DataSet2"
        Me.DataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'OrtTextBox
        '
        Me.OrtTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Ort", True))
        Me.OrtTextBox.Location = New System.Drawing.Point(256, 141)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(271, 22)
        Me.OrtTextBox.TabIndex = 18
        '
        'KdNummerComboBox
        '
        Me.KdNummerComboBox.DataSource = Me.KundeBindingSource
        Me.KdNummerComboBox.DisplayMember = "KdNummer"
        Me.KdNummerComboBox.FormattingEnabled = True
        Me.KdNummerComboBox.Location = New System.Drawing.Point(118, 29)
        Me.KdNummerComboBox.Name = "KdNummerComboBox"
        Me.KdNummerComboBox.Size = New System.Drawing.Size(167, 24)
        Me.KdNummerComboBox.TabIndex = 21
        Me.KdNummerComboBox.ValueMember = "KundenID"
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(118, 141)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(94, 22)
        Me.PLZTextBox.TabIndex = 16
        '
        'Firma1TextBox
        '
        Me.Firma1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Firma1", True))
        Me.Firma1TextBox.Location = New System.Drawing.Point(118, 57)
        Me.Firma1TextBox.Name = "Firma1TextBox"
        Me.Firma1TextBox.Size = New System.Drawing.Size(319, 22)
        Me.Firma1TextBox.TabIndex = 6
        '
        'StrasseTextBox
        '
        Me.StrasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Strasse", True))
        Me.StrasseTextBox.Location = New System.Drawing.Point(118, 113)
        Me.StrasseTextBox.Name = "StrasseTextBox"
        Me.StrasseTextBox.Size = New System.Drawing.Size(409, 22)
        Me.StrasseTextBox.TabIndex = 14
        '
        'Firma2TextBox
        '
        Me.Firma2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Firma2", True))
        Me.Firma2TextBox.Location = New System.Drawing.Point(626, 57)
        Me.Firma2TextBox.Name = "Firma2TextBox"
        Me.Firma2TextBox.Size = New System.Drawing.Size(385, 22)
        Me.Firma2TextBox.TabIndex = 8
        '
        'Name2TextBox
        '
        Me.Name2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Name2", True))
        Me.Name2TextBox.Location = New System.Drawing.Point(626, 85)
        Me.Name2TextBox.Name = "Name2TextBox"
        Me.Name2TextBox.Size = New System.Drawing.Size(385, 22)
        Me.Name2TextBox.TabIndex = 12
        '
        'Name1TextBox
        '
        Me.Name1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Name1", True))
        Me.Name1TextBox.Location = New System.Drawing.Point(118, 85)
        Me.Name1TextBox.Name = "Name1TextBox"
        Me.Name1TextBox.Size = New System.Drawing.Size(319, 22)
        Me.Name1TextBox.TabIndex = 10
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomer, Me.DelCustomer, Me.ToolStripSeparator1, Me.AddOffer, Me.DelOffer})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1155, 39)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'AddCustomer
        '
        Me.AddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddCustomer.Image = CType(resources.GetObject("AddCustomer.Image"), System.Drawing.Image)
        Me.AddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(36, 36)
        Me.AddCustomer.Text = "ToolStripButton1"
        Me.AddCustomer.ToolTipText = "Neuer Kunden"
        '
        'DelCustomer
        '
        Me.DelCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelCustomer.Image = CType(resources.GetObject("DelCustomer.Image"), System.Drawing.Image)
        Me.DelCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelCustomer.Name = "DelCustomer"
        Me.DelCustomer.Size = New System.Drawing.Size(36, 36)
        Me.DelCustomer.Text = "Kunde löschen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'AddOffer
        '
        Me.AddOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddOffer.Image = CType(resources.GetObject("AddOffer.Image"), System.Drawing.Image)
        Me.AddOffer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddOffer.Name = "AddOffer"
        Me.AddOffer.Size = New System.Drawing.Size(36, 36)
        Me.AddOffer.Text = "ToolStripButton1"
        Me.AddOffer.ToolTipText = "Neues Angebot"
        '
        'DelOffer
        '
        Me.DelOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelOffer.Image = CType(resources.GetObject("DelOffer.Image"), System.Drawing.Image)
        Me.DelOffer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelOffer.Name = "DelOffer"
        Me.DelOffer.Size = New System.Drawing.Size(36, 36)
        Me.DelOffer.Text = "ToolStripButton2"
        Me.DelOffer.ToolTipText = "Angebot löschen"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 25)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1161, 496)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Angebot"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1155, 490)
        Me.SplitContainer1.SplitterDistance = 383
        Me.SplitContainer1.TabIndex = 0
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "folder-document.ico")
        Me.ImageList1.Images.SetKeyName(1, "node.png")
        Me.ImageList1.Images.SetKeyName(2, "file-doc.ico")
        Me.ImageList1.Images.SetKeyName(3, "node_chain_broken.png")
        Me.ImageList1.Images.SetKeyName(4, "folder-open-2.ico")
        '
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.OptionIDDataGridViewTextBoxColumn, Me.AngebotsnummerDataGridViewTextBoxColumn, Me.ArtikelIDDataGridViewTextBoxColumn, Me.SortRowDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.FKAngebotSpezOptionenBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.Location = New System.Drawing.Point(0, 377)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.Size = New System.Drawing.Size(768, 113)
        Me.DataGridView2.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.DataPropertyName = "ArtikelID"
        Me.Column1.DataSource = Me.ArtikelBindingSource
        Me.Column1.DisplayMember = "Artikelkurztext"
        Me.Column1.HeaderText = "Artikelkurztext"
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.ValueMember = "ArtikelID"
        '
        'ArtikelBindingSource
        '
        Me.ArtikelBindingSource.DataMember = "Artikel"
        Me.ArtikelBindingSource.DataSource = Me.DataSet1
        '
        'OptionIDDataGridViewTextBoxColumn
        '
        Me.OptionIDDataGridViewTextBoxColumn.DataPropertyName = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn.HeaderText = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn.Name = "OptionIDDataGridViewTextBoxColumn"
        '
        'AngebotsnummerDataGridViewTextBoxColumn
        '
        Me.AngebotsnummerDataGridViewTextBoxColumn.DataPropertyName = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn.HeaderText = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn.Name = "AngebotsnummerDataGridViewTextBoxColumn"
        '
        'ArtikelIDDataGridViewTextBoxColumn
        '
        Me.ArtikelIDDataGridViewTextBoxColumn.DataPropertyName = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn.HeaderText = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn.Name = "ArtikelIDDataGridViewTextBoxColumn"
        '
        'SortRowDataGridViewTextBoxColumn
        '
        Me.SortRowDataGridViewTextBoxColumn.DataPropertyName = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn.HeaderText = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn.Name = "SortRowDataGridViewTextBoxColumn"
        '
        'FKAngebotSpezOptionenBindingSource
        '
        Me.FKAngebotSpezOptionenBindingSource.DataMember = "FK_Angebot_SpezOptionen"
        Me.FKAngebotSpezOptionenBindingSource.DataSource = Me.FKKundeAngebotBindingSource
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ArtikelGroupBox)
        Me.Panel1.Controls.Add(Me.ProduktgruppeGroupBox)
        Me.Panel1.Controls.Add(Me.ToolStrip3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(768, 377)
        Me.Panel1.TabIndex = 0
        '
        'ArtikelGroupBox
        '
        Me.ArtikelGroupBox.Controls.Add(Me.RubrikMaskedTextBox)
        Me.ArtikelGroupBox.Controls.Add(Me.ButtonAddURL)
        Me.ArtikelGroupBox.Controls.Add(Me.MaskedTextBoxArtikelnummer)
        Me.ArtikelGroupBox.Controls.Add(URLLabel)
        Me.ArtikelGroupBox.Controls.Add(Me.URLTextBox)
        Me.ArtikelGroupBox.Controls.Add(ArtikelnrLabel)
        Me.ArtikelGroupBox.Controls.Add(RubrikLabel)
        Me.ArtikelGroupBox.Controls.Add(ArtikelkurztextLabel)
        Me.ArtikelGroupBox.Controls.Add(Me.ArtikelkurztextTextBox)
        Me.ArtikelGroupBox.Controls.Add(BeschreibungLabel)
        Me.ArtikelGroupBox.Controls.Add(Me.BeschreibungTextBox)
        Me.ArtikelGroupBox.Controls.Add(EKPreisLabel)
        Me.ArtikelGroupBox.Controls.Add(Me.EKPreisTextBox)
        Me.ArtikelGroupBox.Controls.Add(VKPreisLabel)
        Me.ArtikelGroupBox.Controls.Add(Me.VKPreisTextBox)
        Me.ArtikelGroupBox.Controls.Add(FaktorLabel)
        Me.ArtikelGroupBox.Controls.Add(Me.FaktorTextBox)
        Me.ArtikelGroupBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ArtikelGroupBox.Location = New System.Drawing.Point(0, 107)
        Me.ArtikelGroupBox.Name = "ArtikelGroupBox"
        Me.ArtikelGroupBox.Size = New System.Drawing.Size(768, 270)
        Me.ArtikelGroupBox.TabIndex = 17
        Me.ArtikelGroupBox.TabStop = False
        Me.ArtikelGroupBox.Text = "Artikel"
        '
        'RubrikMaskedTextBox
        '
        Me.RubrikMaskedTextBox.Location = New System.Drawing.Point(117, 89)
        Me.RubrikMaskedTextBox.Mask = "00.00.00"
        Me.RubrikMaskedTextBox.Name = "RubrikMaskedTextBox"
        Me.RubrikMaskedTextBox.Size = New System.Drawing.Size(118, 22)
        Me.RubrikMaskedTextBox.TabIndex = 24
        '
        'ButtonAddURL
        '
        Me.ButtonAddURL.Location = New System.Drawing.Point(703, 237)
        Me.ButtonAddURL.Name = "ButtonAddURL"
        Me.ButtonAddURL.Size = New System.Drawing.Size(43, 23)
        Me.ButtonAddURL.TabIndex = 23
        Me.ButtonAddURL.Text = "..."
        Me.ButtonAddURL.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxArtikelnummer
        '
        Me.MaskedTextBoxArtikelnummer.Location = New System.Drawing.Point(116, 61)
        Me.MaskedTextBoxArtikelnummer.Mask = "00-0000-0000"
        Me.MaskedTextBoxArtikelnummer.Name = "MaskedTextBoxArtikelnummer"
        Me.MaskedTextBoxArtikelnummer.Size = New System.Drawing.Size(119, 22)
        Me.MaskedTextBoxArtikelnummer.TabIndex = 22
        '
        'URLTextBox
        '
        Me.URLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "URL", True))
        Me.URLTextBox.Location = New System.Drawing.Point(117, 237)
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(580, 22)
        Me.URLTextBox.TabIndex = 7
        '
        'ArtikelkurztextTextBox
        '
        Me.ArtikelkurztextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Artikelkurztext", True))
        Me.ArtikelkurztextTextBox.Location = New System.Drawing.Point(117, 30)
        Me.ArtikelkurztextTextBox.Name = "ArtikelkurztextTextBox"
        Me.ArtikelkurztextTextBox.Size = New System.Drawing.Size(630, 22)
        Me.ArtikelkurztextTextBox.TabIndex = 13
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(116, 117)
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(630, 114)
        Me.BeschreibungTextBox.TabIndex = 15
        '
        'EKPreisTextBox
        '
        Me.EKPreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "EKPreis", True))
        Me.EKPreisTextBox.Location = New System.Drawing.Point(385, 61)
        Me.EKPreisTextBox.Name = "EKPreisTextBox"
        Me.EKPreisTextBox.Size = New System.Drawing.Size(152, 22)
        Me.EKPreisTextBox.TabIndex = 17
        '
        'VKPreisTextBox
        '
        Me.VKPreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "VKPreis", True))
        Me.VKPreisTextBox.Location = New System.Drawing.Point(385, 89)
        Me.VKPreisTextBox.Name = "VKPreisTextBox"
        Me.VKPreisTextBox.Size = New System.Drawing.Size(152, 22)
        Me.VKPreisTextBox.TabIndex = 19
        '
        'FaktorTextBox
        '
        Me.FaktorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Faktor", True))
        Me.FaktorTextBox.Location = New System.Drawing.Point(643, 61)
        Me.FaktorTextBox.Name = "FaktorTextBox"
        Me.FaktorTextBox.Size = New System.Drawing.Size(104, 22)
        Me.FaktorTextBox.TabIndex = 21
        '
        'ProduktgruppeGroupBox
        '
        Me.ProduktgruppeGroupBox.Controls.Add(HerstellerLabel)
        Me.ProduktgruppeGroupBox.Controls.Add(Me.HerstellerComboBox)
        Me.ProduktgruppeGroupBox.Controls.Add(ProduktTypLabel)
        Me.ProduktgruppeGroupBox.Controls.Add(Me.ProduktTypComboBox)
        Me.ProduktgruppeGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProduktgruppeGroupBox.Location = New System.Drawing.Point(0, 39)
        Me.ProduktgruppeGroupBox.Name = "ProduktgruppeGroupBox"
        Me.ProduktgruppeGroupBox.Size = New System.Drawing.Size(768, 68)
        Me.ProduktgruppeGroupBox.TabIndex = 16
        Me.ProduktgruppeGroupBox.TabStop = False
        Me.ProduktgruppeGroupBox.Text = "Produktgruppe"
        '
        'HerstellerComboBox
        '
        Me.HerstellerComboBox.DataSource = Me.HerstellerBindingSource
        Me.HerstellerComboBox.DisplayMember = "Hersteller"
        Me.HerstellerComboBox.FormattingEnabled = True
        Me.HerstellerComboBox.Location = New System.Drawing.Point(117, 23)
        Me.HerstellerComboBox.Name = "HerstellerComboBox"
        Me.HerstellerComboBox.Size = New System.Drawing.Size(252, 24)
        Me.HerstellerComboBox.TabIndex = 5
        Me.HerstellerComboBox.ValueMember = "HerstellerID"
        '
        'HerstellerBindingSource
        '
        Me.HerstellerBindingSource.DataMember = "Hersteller"
        Me.HerstellerBindingSource.DataSource = Me.DataSet1
        '
        'ProduktTypComboBox
        '
        Me.ProduktTypComboBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ProduktBindingSource, "ProduktTyp", True))
        Me.ProduktTypComboBox.DataSource = Me.ProduktBindingSource
        Me.ProduktTypComboBox.DisplayMember = "ProduktTyp"
        Me.ProduktTypComboBox.FormattingEnabled = True
        Me.ProduktTypComboBox.Location = New System.Drawing.Point(495, 23)
        Me.ProduktTypComboBox.Name = "ProduktTypComboBox"
        Me.ProduktTypComboBox.Size = New System.Drawing.Size(252, 24)
        Me.ProduktTypComboBox.TabIndex = 11
        '
        'ProduktBindingSource
        '
        Me.ProduktBindingSource.DataMember = "Produkt"
        Me.ProduktBindingSource.DataSource = Me.DataSet1
        '
        'ToolStrip3
        '
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddManufacturerNode, Me.AddProductNode, Me.AddArticleNode, Me.DelNode})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(768, 39)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'AddManufacturerNode
        '
        Me.AddManufacturerNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddManufacturerNode.Image = Global.TeBaM_1._2.My.Resources.Resources.folder
        Me.AddManufacturerNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddManufacturerNode.Name = "AddManufacturerNode"
        Me.AddManufacturerNode.Size = New System.Drawing.Size(36, 36)
        Me.AddManufacturerNode.Text = "ToolStripButton1"
        Me.AddManufacturerNode.ToolTipText = "Hersteller hinzufügen"
        '
        'AddProductNode
        '
        Me.AddProductNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddProductNode.Image = Global.TeBaM_1._2.My.Resources.Resources.folder_document
        Me.AddProductNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddProductNode.Name = "AddProductNode"
        Me.AddProductNode.Size = New System.Drawing.Size(36, 36)
        Me.AddProductNode.Text = "ToolStripButton2"
        Me.AddProductNode.ToolTipText = "Produkt hinzufügen"
        '
        'AddArticleNode
        '
        Me.AddArticleNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddArticleNode.Image = Global.TeBaM_1._2.My.Resources.Resources.file_doc
        Me.AddArticleNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddArticleNode.Name = "AddArticleNode"
        Me.AddArticleNode.Size = New System.Drawing.Size(36, 36)
        Me.AddArticleNode.Text = "ToolStripButton3"
        Me.AddArticleNode.ToolTipText = "Artikel hinzufügen"
        '
        'DelNode
        '
        Me.DelNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelNode.Image = Global.TeBaM_1._2.My.Resources.Resources.delete
        Me.DelNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelNode.Name = "DelNode"
        Me.DelNode.Size = New System.Drawing.Size(36, 36)
        Me.DelNode.Text = "ToolStripButton4"
        Me.DelNode.ToolTipText = "Knoten löschen"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.VertreterToolStripMenuItem, Me.KonfigurationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1169, 28)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProduktstrukturNeuToolStripMenuItem, Me.ProduktsrukturÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.SpeichernUnterToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(57, 24)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ProduktstrukturNeuToolStripMenuItem
        '
        Me.ProduktstrukturNeuToolStripMenuItem.Name = "ProduktstrukturNeuToolStripMenuItem"
        Me.ProduktstrukturNeuToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.ProduktstrukturNeuToolStripMenuItem.Text = "Neu"
        '
        'ProduktsrukturÖffnenToolStripMenuItem
        '
        Me.ProduktsrukturÖffnenToolStripMenuItem.Name = "ProduktsrukturÖffnenToolStripMenuItem"
        Me.ProduktsrukturÖffnenToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.ProduktsrukturÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'SpeichernUnterToolStripMenuItem
        '
        Me.SpeichernUnterToolStripMenuItem.Name = "SpeichernUnterToolStripMenuItem"
        Me.SpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.SpeichernUnterToolStripMenuItem.Text = "Speichern unter"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(187, 26)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'VertreterToolStripMenuItem
        '
        Me.VertreterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeBearbeitenToolStripMenuItem})
        Me.VertreterToolStripMenuItem.Name = "VertreterToolStripMenuItem"
        Me.VertreterToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.VertreterToolStripMenuItem.Text = "Vertreter"
        '
        'ListeBearbeitenToolStripMenuItem
        '
        Me.ListeBearbeitenToolStripMenuItem.Name = "ListeBearbeitenToolStripMenuItem"
        Me.ListeBearbeitenToolStripMenuItem.Size = New System.Drawing.Size(190, 26)
        Me.ListeBearbeitenToolStripMenuItem.Text = "Liste bearbeiten"
        '
        'KonfigurationToolStripMenuItem
        '
        Me.KonfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextmarkenDefinierenToolStripMenuItem})
        Me.KonfigurationToolStripMenuItem.Name = "KonfigurationToolStripMenuItem"
        Me.KonfigurationToolStripMenuItem.Size = New System.Drawing.Size(112, 24)
        Me.KonfigurationToolStripMenuItem.Text = "Konfiguration"
        '
        'TextmarkenDefinierenToolStripMenuItem
        '
        Me.TextmarkenDefinierenToolStripMenuItem.Name = "TextmarkenDefinierenToolStripMenuItem"
        Me.TextmarkenDefinierenToolStripMenuItem.Size = New System.Drawing.Size(232, 26)
        Me.TextmarkenDefinierenToolStripMenuItem.Text = "Textmarken definieren"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1169, 600)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKKundeAngebotBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.KundeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Kunden.ResumeLayout(False)
        Me.Kunden.PerformLayout()
        Me.KundeGroupBox.ResumeLayout(False)
        Me.KundeGroupBox.PerformLayout()
        CType(Me.VertreterBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtikelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKAngebotSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ArtikelGroupBox.ResumeLayout(False)
        Me.ArtikelGroupBox.PerformLayout()
        Me.ProduktgruppeGroupBox.ResumeLayout(False)
        Me.ProduktgruppeGroupBox.PerformLayout()
        CType(Me.HerstellerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip3.ResumeLayout(False)
        Me.ToolStrip3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Kunden As Panel
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents Panel1 As Panel
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStrip3 As ToolStrip
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DateiToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktstrukturNeuToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProduktsrukturÖffnenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SpeichernUnterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BeendenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VertreterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ListeBearbeitenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents KonfigurationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TextmarkenDefinierenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddCustomer As ToolStripButton
    Friend WithEvents DelCustomer As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents AddOffer As ToolStripButton
    Friend WithEvents DelOffer As ToolStripButton
    Friend WithEvents AddManufacturerNode As ToolStripButton
    Friend WithEvents AddProductNode As ToolStripButton
    Friend WithEvents AddArticleNode As ToolStripButton
    Friend WithEvents DelNode As ToolStripButton
    Friend WithEvents KdNummerComboBox As ComboBox
    Friend WithEvents KundeBindingSource As BindingSource
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Firma1TextBox As TextBox
    Friend WithEvents Firma2TextBox As TextBox
    Friend WithEvents Name1TextBox As TextBox
    Friend WithEvents Name2TextBox As TextBox
    Friend WithEvents StrasseTextBox As TextBox
    Friend WithEvents PLZTextBox As TextBox
    Friend WithEvents OrtTextBox As TextBox
    Friend WithEvents VertreterComboBox As ComboBox
    Friend WithEvents VertreterBindingSource As BindingSource
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents KundeGroupBox As GroupBox
    Friend WithEvents HerstellerBindingSource As BindingSource
    Friend WithEvents HerstellerComboBox As ComboBox
    Friend WithEvents ProduktBindingSource As BindingSource
    Friend WithEvents ProduktTypComboBox As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AngebotstitelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents KundennummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotURLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FKKundeAngebotBindingSource As BindingSource
    Friend WithEvents ProduktgruppeGroupBox As GroupBox
    Friend WithEvents ArtikelGroupBox As GroupBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DokumentenvorlageComboBox As ComboBox
    Friend WithEvents URLTextBox As TextBox
    Friend WithEvents ArtikelBindingSource As BindingSource
    Friend WithEvents ArtikelkurztextTextBox As TextBox
    Friend WithEvents BeschreibungTextBox As TextBox
    Friend WithEvents EKPreisTextBox As TextBox
    Friend WithEvents VKPreisTextBox As TextBox
    Friend WithEvents FaktorTextBox As TextBox
    Friend WithEvents MaskedTextBoxArtikelnummer As MaskedTextBox
    Friend WithEvents ImageList1 As ImageList
    Friend WithEvents FKAngebotSpezOptionenBindingSource As BindingSource
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents OptionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotsnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ArtikelIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SortRowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ButtonAddURL As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RubrikMaskedTextBox As MaskedTextBox
End Class

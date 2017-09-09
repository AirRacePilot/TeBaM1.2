<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()>
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
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.NewStructure = New System.Windows.Forms.ToolStripButton()
        Me.OpenStucture = New System.Windows.Forms.ToolStripButton()
        Me.SafeStructure = New System.Windows.Forms.ToolStripButton()
        Me.SafeStructureUnder = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.GenerateOffer = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.SalesPartner = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator5 = New System.Windows.Forms.ToolStripSeparator()
        Me.TextmarkConfiguration = New System.Windows.Forms.ToolStripButton()
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.ToolStripProgressBar1 = New System.Windows.Forms.ToolStripProgressBar()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.AngebotsIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Angebotstitel = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.KundennummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngebotURLDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ContextMenuStripOfferTitle = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.TitelUmbennenenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.NewTreeView1 = New TeBaM_1._2.NewTreeView()
        Me.ContextMenuStrip_NewTreeView1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.UmbenennenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AnzeigenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Column1 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArtikelBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Column2 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.ArtikelIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OptionIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AngebotsnummerDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SortRowDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FKAngebotSpezOptionenBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.VKDL = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.VKMaschinenpreis = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ToolStrip4 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButtonUp = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripButtonDown = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.ArtikelGroupBox = New System.Windows.Forms.GroupBox()
        Me.PrintEnabledCheckBox = New System.Windows.Forms.CheckBox()
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
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ArtikelDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DateiToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktstrukturNeuToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProduktsrukturÖffnenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SpeichernUnterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BeendenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AngebotToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ErstellenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VertreterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ListeBearbeitenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.KonfigurationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TextmarkenDefinierenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.AGToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
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
        Me.ToolStrip1.SuspendLayout()
        Me.StatusStrip1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ContextMenuStripOfferTitle.SuspendLayout()
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
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.ContextMenuStrip_NewTreeView1.SuspendLayout()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArtikelBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FKAngebotSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.ToolStrip4.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.ArtikelGroupBox.SuspendLayout()
        Me.ProduktgruppeGroupBox.SuspendLayout()
        CType(Me.HerstellerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProduktBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip3.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        CType(Me.ArtikelDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'KdNummerLabel
        '
        KdNummerLabel.AutoSize = True
        KdNummerLabel.Location = New System.Drawing.Point(14, 26)
        KdNummerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        KdNummerLabel.Name = "KdNummerLabel"
        KdNummerLabel.Size = New System.Drawing.Size(65, 13)
        KdNummerLabel.TabIndex = 3
        KdNummerLabel.Text = "Kd Nummer:"
        '
        'Firma1Label
        '
        Firma1Label.AutoSize = True
        Firma1Label.Location = New System.Drawing.Point(14, 49)
        Firma1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Firma1Label.Name = "Firma1Label"
        Firma1Label.Size = New System.Drawing.Size(41, 13)
        Firma1Label.TabIndex = 5
        Firma1Label.Text = "Firma1:"
        '
        'Firma2Label
        '
        Firma2Label.AutoSize = True
        Firma2Label.Location = New System.Drawing.Point(414, 49)
        Firma2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Firma2Label.Name = "Firma2Label"
        Firma2Label.Size = New System.Drawing.Size(41, 13)
        Firma2Label.TabIndex = 7
        Firma2Label.Text = "Firma2:"
        '
        'Name1Label
        '
        Name1Label.AutoSize = True
        Name1Label.Location = New System.Drawing.Point(14, 72)
        Name1Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Name1Label.Name = "Name1Label"
        Name1Label.Size = New System.Drawing.Size(44, 13)
        Name1Label.TabIndex = 9
        Name1Label.Text = "Name1:"
        '
        'Name2Label
        '
        Name2Label.AutoSize = True
        Name2Label.Location = New System.Drawing.Point(414, 72)
        Name2Label.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Name2Label.Name = "Name2Label"
        Name2Label.Size = New System.Drawing.Size(44, 13)
        Name2Label.TabIndex = 11
        Name2Label.Text = "Name2:"
        '
        'StrasseLabel
        '
        StrasseLabel.AutoSize = True
        StrasseLabel.Location = New System.Drawing.Point(14, 94)
        StrasseLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        StrasseLabel.Name = "StrasseLabel"
        StrasseLabel.Size = New System.Drawing.Size(45, 13)
        StrasseLabel.TabIndex = 13
        StrasseLabel.Text = "Strasse:"
        '
        'PLZLabel
        '
        PLZLabel.AutoSize = True
        PLZLabel.Location = New System.Drawing.Point(14, 117)
        PLZLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        PLZLabel.Name = "PLZLabel"
        PLZLabel.Size = New System.Drawing.Size(30, 13)
        PLZLabel.TabIndex = 15
        PLZLabel.Text = "PLZ:"
        '
        'OrtLabel
        '
        OrtLabel.AutoSize = True
        OrtLabel.Location = New System.Drawing.Point(164, 117)
        OrtLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        OrtLabel.Name = "OrtLabel"
        OrtLabel.Size = New System.Drawing.Size(24, 13)
        OrtLabel.TabIndex = 17
        OrtLabel.Text = "Ort:"
        '
        'AngezeigterNameLabel
        '
        AngezeigterNameLabel.AutoSize = True
        AngezeigterNameLabel.Location = New System.Drawing.Point(14, 143)
        AngezeigterNameLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        AngezeigterNameLabel.Name = "AngezeigterNameLabel"
        AngezeigterNameLabel.Size = New System.Drawing.Size(50, 13)
        AngezeigterNameLabel.TabIndex = 21
        AngezeigterNameLabel.Text = "Vertreter:"
        '
        'HerstellerLabel
        '
        HerstellerLabel.AutoSize = True
        HerstellerLabel.Location = New System.Drawing.Point(12, 21)
        HerstellerLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        HerstellerLabel.Name = "HerstellerLabel"
        HerstellerLabel.Size = New System.Drawing.Size(54, 13)
        HerstellerLabel.TabIndex = 4
        HerstellerLabel.Text = "Hersteller:"
        '
        'ProduktTypLabel
        '
        ProduktTypLabel.AutoSize = True
        ProduktTypLabel.Location = New System.Drawing.Point(300, 21)
        ProduktTypLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ProduktTypLabel.Name = "ProduktTypLabel"
        ProduktTypLabel.Size = New System.Drawing.Size(68, 13)
        ProduktTypLabel.TabIndex = 10
        ProduktTypLabel.Text = "Produkt Typ:"
        '
        'URLLabel
        '
        URLLabel.AutoSize = True
        URLLabel.Location = New System.Drawing.Point(8, 195)
        URLLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        URLLabel.Name = "URLLabel"
        URLLabel.Size = New System.Drawing.Size(32, 13)
        URLLabel.TabIndex = 6
        URLLabel.Text = "URL:"
        '
        'ArtikelnrLabel
        '
        ArtikelnrLabel.AutoSize = True
        ArtikelnrLabel.Location = New System.Drawing.Point(8, 52)
        ArtikelnrLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ArtikelnrLabel.Name = "ArtikelnrLabel"
        ArtikelnrLabel.Size = New System.Drawing.Size(48, 13)
        ArtikelnrLabel.TabIndex = 8
        ArtikelnrLabel.Text = "Artikelnr:"
        '
        'RubrikLabel
        '
        RubrikLabel.AutoSize = True
        RubrikLabel.Location = New System.Drawing.Point(8, 75)
        RubrikLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        RubrikLabel.Name = "RubrikLabel"
        RubrikLabel.Size = New System.Drawing.Size(41, 13)
        RubrikLabel.TabIndex = 10
        RubrikLabel.Text = "Rubrik:"
        '
        'ArtikelkurztextLabel
        '
        ArtikelkurztextLabel.AutoSize = True
        ArtikelkurztextLabel.Location = New System.Drawing.Point(8, 27)
        ArtikelkurztextLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        ArtikelkurztextLabel.Name = "ArtikelkurztextLabel"
        ArtikelkurztextLabel.Size = New System.Drawing.Size(76, 13)
        ArtikelkurztextLabel.TabIndex = 12
        ArtikelkurztextLabel.Text = "Artikelkurztext:"
        '
        'BeschreibungLabel
        '
        BeschreibungLabel.AutoSize = True
        BeschreibungLabel.Location = New System.Drawing.Point(8, 98)
        BeschreibungLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        BeschreibungLabel.Name = "BeschreibungLabel"
        BeschreibungLabel.Size = New System.Drawing.Size(75, 13)
        BeschreibungLabel.TabIndex = 14
        BeschreibungLabel.Text = "Beschreibung:"
        '
        'EKPreisLabel
        '
        EKPreisLabel.AutoSize = True
        EKPreisLabel.Location = New System.Drawing.Point(209, 50)
        EKPreisLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        EKPreisLabel.Name = "EKPreisLabel"
        EKPreisLabel.Size = New System.Drawing.Size(47, 13)
        EKPreisLabel.TabIndex = 16
        EKPreisLabel.Text = "EKPreis:"
        '
        'VKPreisLabel
        '
        VKPreisLabel.AutoSize = True
        VKPreisLabel.Location = New System.Drawing.Point(209, 75)
        VKPreisLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        VKPreisLabel.Name = "VKPreisLabel"
        VKPreisLabel.Size = New System.Drawing.Size(47, 13)
        VKPreisLabel.TabIndex = 18
        VKPreisLabel.Text = "VKPreis:"
        '
        'FaktorLabel
        '
        FaktorLabel.AutoSize = True
        FaktorLabel.Location = New System.Drawing.Point(414, 52)
        FaktorLabel.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        FaktorLabel.Name = "FaktorLabel"
        FaktorLabel.Size = New System.Drawing.Size(40, 13)
        FaktorLabel.TabIndex = 20
        FaktorLabel.Text = "Faktor:"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NewStructure, Me.OpenStucture, Me.SafeStructure, Me.SafeStructureUnder, Me.ToolStripSeparator3, Me.GenerateOffer, Me.ToolStripSeparator4, Me.SalesPartner, Me.ToolStripSeparator5, Me.TextmarkConfiguration})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(989, 31)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'NewStructure
        '
        Me.NewStructure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.NewStructure.Image = CType(resources.GetObject("NewStructure.Image"), System.Drawing.Image)
        Me.NewStructure.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.NewStructure.Name = "NewStructure"
        Me.NewStructure.Size = New System.Drawing.Size(28, 28)
        Me.NewStructure.Text = "ToolStripButton2"
        Me.NewStructure.ToolTipText = "neu"
        '
        'OpenStucture
        '
        Me.OpenStucture.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.OpenStucture.Image = CType(resources.GetObject("OpenStucture.Image"), System.Drawing.Image)
        Me.OpenStucture.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.OpenStucture.Name = "OpenStucture"
        Me.OpenStucture.Size = New System.Drawing.Size(28, 28)
        Me.OpenStucture.Text = "ToolStripButton3"
        Me.OpenStucture.ToolTipText = "öffnen"
        '
        'SafeStructure
        '
        Me.SafeStructure.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SafeStructure.Image = CType(resources.GetObject("SafeStructure.Image"), System.Drawing.Image)
        Me.SafeStructure.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SafeStructure.Name = "SafeStructure"
        Me.SafeStructure.Size = New System.Drawing.Size(28, 28)
        Me.SafeStructure.Text = "ToolStripButton4"
        Me.SafeStructure.ToolTipText = "speichern"
        '
        'SafeStructureUnder
        '
        Me.SafeStructureUnder.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SafeStructureUnder.Image = CType(resources.GetObject("SafeStructureUnder.Image"), System.Drawing.Image)
        Me.SafeStructureUnder.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SafeStructureUnder.Name = "SafeStructureUnder"
        Me.SafeStructureUnder.Size = New System.Drawing.Size(28, 28)
        Me.SafeStructureUnder.Text = "ToolStripButton5"
        Me.SafeStructureUnder.ToolTipText = "speichern unter"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 31)
        '
        'GenerateOffer
        '
        Me.GenerateOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.GenerateOffer.Image = CType(resources.GetObject("GenerateOffer.Image"), System.Drawing.Image)
        Me.GenerateOffer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.GenerateOffer.Name = "GenerateOffer"
        Me.GenerateOffer.Size = New System.Drawing.Size(28, 28)
        Me.GenerateOffer.Text = "ToolStripButton6"
        Me.GenerateOffer.ToolTipText = "Angebot erstellen"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 31)
        '
        'SalesPartner
        '
        Me.SalesPartner.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.SalesPartner.Image = CType(resources.GetObject("SalesPartner.Image"), System.Drawing.Image)
        Me.SalesPartner.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.SalesPartner.Name = "SalesPartner"
        Me.SalesPartner.Size = New System.Drawing.Size(28, 28)
        Me.SalesPartner.Text = "ToolStripButton7"
        Me.SalesPartner.ToolTipText = "Vertreterliste"
        '
        'ToolStripSeparator5
        '
        Me.ToolStripSeparator5.Name = "ToolStripSeparator5"
        Me.ToolStripSeparator5.Size = New System.Drawing.Size(6, 31)
        '
        'TextmarkConfiguration
        '
        Me.TextmarkConfiguration.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TextmarkConfiguration.Image = CType(resources.GetObject("TextmarkConfiguration.Image"), System.Drawing.Image)
        Me.TextmarkConfiguration.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.TextmarkConfiguration.Name = "TextmarkConfiguration"
        Me.TextmarkConfiguration.Size = New System.Drawing.Size(28, 28)
        Me.TextmarkConfiguration.Text = "ToolStripButton8"
        Me.TextmarkConfiguration.ToolTipText = "Konfigurieren"
        '
        'StatusStrip1
        '
        Me.StatusStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripProgressBar1})
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 577)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Padding = New System.Windows.Forms.Padding(1, 0, 10, 0)
        Me.StatusStrip1.Size = New System.Drawing.Size(989, 26)
        Me.StatusStrip1.TabIndex = 1
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'ToolStripProgressBar1
        '
        Me.ToolStripProgressBar1.Name = "ToolStripProgressBar1"
        Me.ToolStripProgressBar1.Size = New System.Drawing.Size(200, 20)
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 55)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(989, 522)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.DataGridView1)
        Me.TabPage1.Controls.Add(Me.Kunden)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage1.Size = New System.Drawing.Size(981, 496)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Kunden"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        DataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        Me.DataGridView1.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle7
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.AngebotsIDDataGridViewTextBoxColumn, Me.Angebotstitel, Me.KundennummerDataGridViewTextBoxColumn, Me.AngebotURLDataGridViewTextBoxColumn})
        Me.DataGridView1.ContextMenuStrip = Me.ContextMenuStripOfferTitle
        Me.DataGridView1.DataSource = Me.FKKundeAngebotBindingSource
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle8
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView1.Location = New System.Drawing.Point(2, 217)
        Me.DataGridView1.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.RowTemplate.Height = 24
        Me.DataGridView1.Size = New System.Drawing.Size(977, 277)
        Me.DataGridView1.TabIndex = 1
        '
        'AngebotsIDDataGridViewTextBoxColumn
        '
        Me.AngebotsIDDataGridViewTextBoxColumn.DataPropertyName = "AngebotsID"
        Me.AngebotsIDDataGridViewTextBoxColumn.HeaderText = "AngebotsID"
        Me.AngebotsIDDataGridViewTextBoxColumn.Name = "AngebotsIDDataGridViewTextBoxColumn"
        '
        'Angebotstitel
        '
        Me.Angebotstitel.DataPropertyName = "Angebotstitel"
        Me.Angebotstitel.HeaderText = "Angebotstitel"
        Me.Angebotstitel.Name = "Angebotstitel"
        '
        'KundennummerDataGridViewTextBoxColumn
        '
        Me.KundennummerDataGridViewTextBoxColumn.DataPropertyName = "Kundennummer"
        Me.KundennummerDataGridViewTextBoxColumn.HeaderText = "Kundennummer"
        Me.KundennummerDataGridViewTextBoxColumn.Name = "KundennummerDataGridViewTextBoxColumn"
        Me.KundennummerDataGridViewTextBoxColumn.Visible = False
        '
        'AngebotURLDataGridViewTextBoxColumn
        '
        Me.AngebotURLDataGridViewTextBoxColumn.DataPropertyName = "AngebotURL"
        Me.AngebotURLDataGridViewTextBoxColumn.HeaderText = "AngebotURL"
        Me.AngebotURLDataGridViewTextBoxColumn.Name = "AngebotURLDataGridViewTextBoxColumn"
        Me.AngebotURLDataGridViewTextBoxColumn.Visible = False
        '
        'ContextMenuStripOfferTitle
        '
        Me.ContextMenuStripOfferTitle.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TitelUmbennenenToolStripMenuItem})
        Me.ContextMenuStripOfferTitle.Name = "ContextMenuStripOfferTitle"
        Me.ContextMenuStripOfferTitle.Size = New System.Drawing.Size(172, 26)
        '
        'TitelUmbennenenToolStripMenuItem
        '
        Me.TitelUmbennenenToolStripMenuItem.Name = "TitelUmbennenenToolStripMenuItem"
        Me.TitelUmbennenenToolStripMenuItem.Size = New System.Drawing.Size(171, 22)
        Me.TitelUmbennenenToolStripMenuItem.Text = "Titel umbennenen"
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
        Me.KundeBindingSource.Sort = "KdNummer"
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
        Me.Kunden.Location = New System.Drawing.Point(2, 2)
        Me.Kunden.Margin = New System.Windows.Forms.Padding(2)
        Me.Kunden.Name = "Kunden"
        Me.Kunden.Size = New System.Drawing.Size(977, 215)
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
        Me.KundeGroupBox.Location = New System.Drawing.Point(0, 27)
        Me.KundeGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.KundeGroupBox.Name = "KundeGroupBox"
        Me.KundeGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.KundeGroupBox.Size = New System.Drawing.Size(977, 188)
        Me.KundeGroupBox.TabIndex = 24
        Me.KundeGroupBox.TabStop = False
        Me.KundeGroupBox.Text = "Kunde"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(349, 143)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Dokumentenvorlage:"
        '
        'DokumentenvorlageComboBox
        '
        Me.DokumentenvorlageComboBox.FormattingEnabled = True
        Me.DokumentenvorlageComboBox.Location = New System.Drawing.Point(470, 140)
        Me.DokumentenvorlageComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.DokumentenvorlageComboBox.Name = "DokumentenvorlageComboBox"
        Me.DokumentenvorlageComboBox.Size = New System.Drawing.Size(290, 21)
        Me.DokumentenvorlageComboBox.TabIndex = 24
        '
        'VertreterComboBox
        '
        Me.VertreterComboBox.DataSource = Me.VertreterBindingSource
        Me.VertreterComboBox.DisplayMember = "angezeigterName"
        Me.VertreterComboBox.FormattingEnabled = True
        Me.VertreterComboBox.Location = New System.Drawing.Point(88, 140)
        Me.VertreterComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.VertreterComboBox.Name = "VertreterComboBox"
        Me.VertreterComboBox.Size = New System.Drawing.Size(240, 21)
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
        Me.OrtTextBox.Location = New System.Drawing.Point(192, 115)
        Me.OrtTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.OrtTextBox.Name = "OrtTextBox"
        Me.OrtTextBox.Size = New System.Drawing.Size(204, 20)
        Me.OrtTextBox.TabIndex = 18
        '
        'KdNummerComboBox
        '
        Me.KdNummerComboBox.DataSource = Me.KundeBindingSource
        Me.KdNummerComboBox.DisplayMember = "KdNummer"
        Me.KdNummerComboBox.FormattingEnabled = True
        Me.KdNummerComboBox.Location = New System.Drawing.Point(88, 24)
        Me.KdNummerComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.KdNummerComboBox.Name = "KdNummerComboBox"
        Me.KdNummerComboBox.Size = New System.Drawing.Size(126, 21)
        Me.KdNummerComboBox.TabIndex = 21
        Me.KdNummerComboBox.ValueMember = "KundenID"
        '
        'PLZTextBox
        '
        Me.PLZTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "PLZ", True))
        Me.PLZTextBox.Location = New System.Drawing.Point(88, 115)
        Me.PLZTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.PLZTextBox.Name = "PLZTextBox"
        Me.PLZTextBox.Size = New System.Drawing.Size(72, 20)
        Me.PLZTextBox.TabIndex = 16
        '
        'Firma1TextBox
        '
        Me.Firma1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Firma1", True))
        Me.Firma1TextBox.Location = New System.Drawing.Point(88, 46)
        Me.Firma1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Firma1TextBox.Name = "Firma1TextBox"
        Me.Firma1TextBox.Size = New System.Drawing.Size(240, 20)
        Me.Firma1TextBox.TabIndex = 6
        '
        'StrasseTextBox
        '
        Me.StrasseTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Strasse", True))
        Me.StrasseTextBox.Location = New System.Drawing.Point(88, 92)
        Me.StrasseTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.StrasseTextBox.Name = "StrasseTextBox"
        Me.StrasseTextBox.Size = New System.Drawing.Size(308, 20)
        Me.StrasseTextBox.TabIndex = 14
        '
        'Firma2TextBox
        '
        Me.Firma2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Firma2", True))
        Me.Firma2TextBox.Location = New System.Drawing.Point(470, 46)
        Me.Firma2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Firma2TextBox.Name = "Firma2TextBox"
        Me.Firma2TextBox.Size = New System.Drawing.Size(290, 20)
        Me.Firma2TextBox.TabIndex = 8
        '
        'Name2TextBox
        '
        Me.Name2TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Name2", True))
        Me.Name2TextBox.Location = New System.Drawing.Point(470, 69)
        Me.Name2TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Name2TextBox.Name = "Name2TextBox"
        Me.Name2TextBox.Size = New System.Drawing.Size(290, 20)
        Me.Name2TextBox.TabIndex = 12
        '
        'Name1TextBox
        '
        Me.Name1TextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.KundeBindingSource, "Name1", True))
        Me.Name1TextBox.Location = New System.Drawing.Point(88, 69)
        Me.Name1TextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.Name1TextBox.Name = "Name1TextBox"
        Me.Name1TextBox.Size = New System.Drawing.Size(240, 20)
        Me.Name1TextBox.TabIndex = 10
        '
        'ToolStrip2
        '
        Me.ToolStrip2.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddCustomer, Me.DelCustomer, Me.ToolStripSeparator1, Me.AddOffer, Me.DelOffer})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(977, 27)
        Me.ToolStrip2.TabIndex = 0
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'AddCustomer
        '
        Me.AddCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddCustomer.Image = CType(resources.GetObject("AddCustomer.Image"), System.Drawing.Image)
        Me.AddCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(24, 24)
        Me.AddCustomer.Text = "ToolStripButton1"
        Me.AddCustomer.ToolTipText = "Neuer Kunden"
        '
        'DelCustomer
        '
        Me.DelCustomer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelCustomer.Image = CType(resources.GetObject("DelCustomer.Image"), System.Drawing.Image)
        Me.DelCustomer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelCustomer.Name = "DelCustomer"
        Me.DelCustomer.Size = New System.Drawing.Size(24, 24)
        Me.DelCustomer.Text = "Kunde löschen"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 27)
        '
        'AddOffer
        '
        Me.AddOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddOffer.Image = CType(resources.GetObject("AddOffer.Image"), System.Drawing.Image)
        Me.AddOffer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddOffer.Name = "AddOffer"
        Me.AddOffer.Size = New System.Drawing.Size(24, 24)
        Me.AddOffer.Text = "ToolStripButton1"
        Me.AddOffer.ToolTipText = "Neues Angebot"
        '
        'DelOffer
        '
        Me.DelOffer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelOffer.Image = CType(resources.GetObject("DelOffer.Image"), System.Drawing.Image)
        Me.DelOffer.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelOffer.Name = "DelOffer"
        Me.DelOffer.Size = New System.Drawing.Size(24, 24)
        Me.DelOffer.Text = "ToolStripButton2"
        Me.DelOffer.ToolTipText = "Angebot löschen"
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer1)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Margin = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(2)
        Me.TabPage2.Size = New System.Drawing.Size(981, 496)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Angebot"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(2, 2)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(2)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.NewTreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.ToolStrip4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel1)
        Me.SplitContainer1.Size = New System.Drawing.Size(977, 492)
        Me.SplitContainer1.SplitterDistance = 320
        Me.SplitContainer1.SplitterWidth = 3
        Me.SplitContainer1.TabIndex = 0
        '
        'NewTreeView1
        '
        Me.NewTreeView1.AllowDrop = True
        Me.NewTreeView1.BackColor = System.Drawing.Color.Ivory
        Me.NewTreeView1.CheckBoxes = True
        Me.NewTreeView1.ContextMenuStrip = Me.ContextMenuStrip_NewTreeView1
        Me.NewTreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.NewTreeView1.ImageIndex = 0
        Me.NewTreeView1.ImageList = Me.ImageList1
        Me.NewTreeView1.Location = New System.Drawing.Point(0, 0)
        Me.NewTreeView1.Name = "NewTreeView1"
        Me.NewTreeView1.SelectedImageIndex = 0
        Me.NewTreeView1.Size = New System.Drawing.Size(320, 492)
        Me.NewTreeView1.TabIndex = 0
        '
        'ContextMenuStrip_NewTreeView1
        '
        Me.ContextMenuStrip_NewTreeView1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.ContextMenuStrip_NewTreeView1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.UmbenennenToolStripMenuItem, Me.AnzeigenToolStripMenuItem})
        Me.ContextMenuStrip_NewTreeView1.Name = "ContextMenuStrip_NewTreeView1"
        Me.ContextMenuStrip_NewTreeView1.Size = New System.Drawing.Size(146, 48)
        '
        'UmbenennenToolStripMenuItem
        '
        Me.UmbenennenToolStripMenuItem.Name = "UmbenennenToolStripMenuItem"
        Me.UmbenennenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.UmbenennenToolStripMenuItem.Text = "umbenennen"
        '
        'AnzeigenToolStripMenuItem
        '
        Me.AnzeigenToolStripMenuItem.Name = "AnzeigenToolStripMenuItem"
        Me.AnzeigenToolStripMenuItem.Size = New System.Drawing.Size(145, 22)
        Me.AnzeigenToolStripMenuItem.Text = "anzeigen"
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
        Me.DataGridView2.AllowUserToAddRows = False
        Me.DataGridView2.AllowUserToDeleteRows = False
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView2.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.ArtikelIDDataGridViewTextBoxColumn, Me.OptionIDDataGridViewTextBoxColumn, Me.AngebotsnummerDataGridViewTextBoxColumn, Me.SortRowDataGridViewTextBoxColumn})
        Me.DataGridView2.DataSource = Me.FKAngebotSpezOptionenBindingSource
        Me.DataGridView2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView2.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically
        Me.DataGridView2.Location = New System.Drawing.Point(0, 337)
        Me.DataGridView2.Margin = New System.Windows.Forms.Padding(2)
        Me.DataGridView2.MultiSelect = False
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.RowTemplate.Height = 24
        Me.DataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView2.Size = New System.Drawing.Size(654, 118)
        Me.DataGridView2.TabIndex = 1
        '
        'Column1
        '
        Me.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells
        Me.Column1.DataPropertyName = "ArtikelID"
        Me.Column1.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.Column1.DefaultCellStyle = DataGridViewCellStyle1
        Me.Column1.DisplayMember = "Artikelkurztext"
        Me.Column1.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column1.HeaderText = "Artikelkurztext"
        Me.Column1.MaxDropDownItems = 1
        Me.Column1.Name = "Column1"
        Me.Column1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column1.ValueMember = "ArtikelID"
        Me.Column1.Width = 98
        '
        'ArtikelBindingSource
        '
        Me.ArtikelBindingSource.DataMember = "Artikel"
        Me.ArtikelBindingSource.DataSource = Me.DataSet1
        '
        'Column2
        '
        Me.Column2.DataPropertyName = "ArtikelID"
        Me.Column2.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle2.Format = "00-0000-0000"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.Column2.DefaultCellStyle = DataGridViewCellStyle2
        Me.Column2.DisplayMember = "Artikelnr"
        Me.Column2.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column2.HeaderText = "Artikelnummer"
        Me.Column2.Name = "Column2"
        Me.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column2.ValueMember = "ArtikelID"
        '
        'Column3
        '
        Me.Column3.DataPropertyName = "ArtikelID"
        Me.Column3.DataSource = Me.ArtikelBindingSource
        Me.Column3.DisplayMember = "Rubrik"
        Me.Column3.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column3.HeaderText = "Rubrik"
        Me.Column3.Name = "Column3"
        Me.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column3.ValueMember = "ArtikelID"
        '
        'Column4
        '
        Me.Column4.DataPropertyName = "ArtikelID"
        Me.Column4.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle9.Format = "C2"
        DataGridViewCellStyle9.NullValue = Nothing
        Me.Column4.DefaultCellStyle = DataGridViewCellStyle9
        Me.Column4.DisplayMember = "EKPreis"
        Me.Column4.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column4.HeaderText = "EK-Preis"
        Me.Column4.Name = "Column4"
        Me.Column4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column4.ValueMember = "ArtikelID"
        '
        'Column5
        '
        Me.Column5.DataPropertyName = "ArtikelID"
        Me.Column5.DataSource = Me.ArtikelBindingSource
        DataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight
        DataGridViewCellStyle10.Format = "C2"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.Column5.DefaultCellStyle = DataGridViewCellStyle10
        Me.Column5.DisplayMember = "VKPreis"
        Me.Column5.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.[Nothing]
        Me.Column5.HeaderText = "VK-Preis"
        Me.Column5.Name = "Column5"
        Me.Column5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.Column5.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.Column5.ValueMember = "ArtikelID"
        '
        'ArtikelIDDataGridViewTextBoxColumn
        '
        Me.ArtikelIDDataGridViewTextBoxColumn.DataPropertyName = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn.HeaderText = "ArtikelID"
        Me.ArtikelIDDataGridViewTextBoxColumn.Name = "ArtikelIDDataGridViewTextBoxColumn"
        Me.ArtikelIDDataGridViewTextBoxColumn.Visible = False
        '
        'OptionIDDataGridViewTextBoxColumn
        '
        Me.OptionIDDataGridViewTextBoxColumn.DataPropertyName = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn.HeaderText = "OptionID"
        Me.OptionIDDataGridViewTextBoxColumn.Name = "OptionIDDataGridViewTextBoxColumn"
        Me.OptionIDDataGridViewTextBoxColumn.Visible = False
        '
        'AngebotsnummerDataGridViewTextBoxColumn
        '
        Me.AngebotsnummerDataGridViewTextBoxColumn.DataPropertyName = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn.HeaderText = "Angebotsnummer"
        Me.AngebotsnummerDataGridViewTextBoxColumn.Name = "AngebotsnummerDataGridViewTextBoxColumn"
        Me.AngebotsnummerDataGridViewTextBoxColumn.Visible = False
        '
        'SortRowDataGridViewTextBoxColumn
        '
        Me.SortRowDataGridViewTextBoxColumn.DataPropertyName = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn.HeaderText = "SortRow"
        Me.SortRowDataGridViewTextBoxColumn.Name = "SortRowDataGridViewTextBoxColumn"
        Me.SortRowDataGridViewTextBoxColumn.Visible = False
        '
        'FKAngebotSpezOptionenBindingSource
        '
        Me.FKAngebotSpezOptionenBindingSource.DataMember = "FK_Angebot_SpezOptionen"
        Me.FKAngebotSpezOptionenBindingSource.DataSource = Me.FKKundeAngebotBindingSource
        Me.FKAngebotSpezOptionenBindingSource.Sort = "Angebotsnummer, SortRow"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.VKDL)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Controls.Add(Me.VKMaschinenpreis)
        Me.Panel2.Controls.Add(Me.Label2)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 455)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(654, 37)
        Me.Panel2.TabIndex = 3
        '
        'VKDL
        '
        Me.VKDL.AutoSize = True
        Me.VKDL.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VKDL.Location = New System.Drawing.Point(412, 8)
        Me.VKDL.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VKDL.Name = "VKDL"
        Me.VKDL.Size = New System.Drawing.Size(34, 20)
        Me.VKDL.TabIndex = 3
        Me.VKDL.Text = "0 €"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(268, 8)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(149, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Dienstleistungen:"
        '
        'VKMaschinenpreis
        '
        Me.VKMaschinenpreis.AutoSize = True
        Me.VKMaschinenpreis.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.VKMaschinenpreis.Location = New System.Drawing.Point(148, 8)
        Me.VKMaschinenpreis.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.VKMaschinenpreis.Name = "VKMaschinenpreis"
        Me.VKMaschinenpreis.Size = New System.Drawing.Size(34, 20)
        Me.VKMaschinenpreis.TabIndex = 1
        Me.VKMaschinenpreis.Text = "0 €"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(10, 8)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 20)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Maschinenpreis: "
        '
        'ToolStrip4
        '
        Me.ToolStrip4.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip4.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip4.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButtonUp, Me.ToolStripButtonDown, Me.ToolStripLabel1, Me.ToolStripSeparator2, Me.ToolStripButton1})
        Me.ToolStrip4.Location = New System.Drawing.Point(0, 306)
        Me.ToolStrip4.Name = "ToolStrip4"
        Me.ToolStrip4.Size = New System.Drawing.Size(654, 31)
        Me.ToolStrip4.TabIndex = 2
        Me.ToolStrip4.Text = "ToolStrip4"
        Me.ToolTip1.SetToolTip(Me.ToolStrip4, "auf")
        '
        'ToolStripButtonUp
        '
        Me.ToolStripButtonUp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonUp.Image = CType(resources.GetObject("ToolStripButtonUp.Image"), System.Drawing.Image)
        Me.ToolStripButtonUp.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonUp.Name = "ToolStripButtonUp"
        Me.ToolStripButtonUp.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButtonUp.Text = "ToolStripButton1"
        '
        'ToolStripButtonDown
        '
        Me.ToolStripButtonDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButtonDown.Image = CType(resources.GetObject("ToolStripButtonDown.Image"), System.Drawing.Image)
        Me.ToolStripButtonDown.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButtonDown.Name = "ToolStripButtonDown"
        Me.ToolStripButtonDown.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButtonDown.Text = "ToolStripButton2"
        Me.ToolStripButtonDown.ToolTipText = "ab"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(89, 28)
        Me.ToolStripLabel1.Text = "ToolStripLabel1"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 31)
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(28, 28)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        Me.ToolStripButton1.ToolTipText = "Baustein öffnen/editieren"
        '
        'Panel1
        '
        Me.Panel1.AutoScroll = True
        Me.Panel1.Controls.Add(Me.ArtikelGroupBox)
        Me.Panel1.Controls.Add(Me.ProduktgruppeGroupBox)
        Me.Panel1.Controls.Add(Me.ToolStrip3)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(654, 306)
        Me.Panel1.TabIndex = 0
        '
        'ArtikelGroupBox
        '
        Me.ArtikelGroupBox.Controls.Add(Me.PrintEnabledCheckBox)
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
        Me.ArtikelGroupBox.Location = New System.Drawing.Point(0, 86)
        Me.ArtikelGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtikelGroupBox.Name = "ArtikelGroupBox"
        Me.ArtikelGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.ArtikelGroupBox.Size = New System.Drawing.Size(654, 220)
        Me.ArtikelGroupBox.TabIndex = 17
        Me.ArtikelGroupBox.TabStop = False
        Me.ArtikelGroupBox.Text = "Artikel"
        '
        'PrintEnabledCheckBox
        '
        Me.PrintEnabledCheckBox.AutoSize = True
        Me.PrintEnabledCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("Checked", Me.ArtikelBindingSource, "AGSelected", True))
        Me.PrintEnabledCheckBox.Location = New System.Drawing.Point(567, 193)
        Me.PrintEnabledCheckBox.Name = "PrintEnabledCheckBox"
        Me.PrintEnabledCheckBox.Size = New System.Drawing.Size(67, 17)
        Me.PrintEnabledCheckBox.TabIndex = 25
        Me.PrintEnabledCheckBox.Text = "Drucken"
        Me.PrintEnabledCheckBox.UseVisualStyleBackColor = True
        '
        'RubrikMaskedTextBox
        '
        Me.RubrikMaskedTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Rubrik", True))
        Me.RubrikMaskedTextBox.Location = New System.Drawing.Point(88, 72)
        Me.RubrikMaskedTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.RubrikMaskedTextBox.Mask = "00.00.00"
        Me.RubrikMaskedTextBox.Name = "RubrikMaskedTextBox"
        Me.RubrikMaskedTextBox.Size = New System.Drawing.Size(90, 20)
        Me.RubrikMaskedTextBox.TabIndex = 24
        '
        'ButtonAddURL
        '
        Me.ButtonAddURL.Image = Global.TeBaM_1._2.My.Resources.Resources.network_connect_3
        Me.ButtonAddURL.Location = New System.Drawing.Point(526, 182)
        Me.ButtonAddURL.Margin = New System.Windows.Forms.Padding(2)
        Me.ButtonAddURL.Name = "ButtonAddURL"
        Me.ButtonAddURL.Size = New System.Drawing.Size(36, 36)
        Me.ButtonAddURL.TabIndex = 23
        Me.ButtonAddURL.Text = "..."
        Me.ButtonAddURL.UseVisualStyleBackColor = True
        '
        'MaskedTextBoxArtikelnummer
        '
        Me.MaskedTextBoxArtikelnummer.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Artikelnr", True))
        Me.MaskedTextBoxArtikelnummer.Location = New System.Drawing.Point(87, 50)
        Me.MaskedTextBoxArtikelnummer.Margin = New System.Windows.Forms.Padding(2)
        Me.MaskedTextBoxArtikelnummer.Mask = "00-0000-0000"
        Me.MaskedTextBoxArtikelnummer.Name = "MaskedTextBoxArtikelnummer"
        Me.MaskedTextBoxArtikelnummer.Size = New System.Drawing.Size(90, 20)
        Me.MaskedTextBoxArtikelnummer.TabIndex = 22
        Me.MaskedTextBoxArtikelnummer.TextMaskFormat = System.Windows.Forms.MaskFormat.IncludePrompt
        '
        'URLTextBox
        '
        Me.URLTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "URL", True))
        Me.URLTextBox.Location = New System.Drawing.Point(88, 192)
        Me.URLTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.URLTextBox.Name = "URLTextBox"
        Me.URLTextBox.Size = New System.Drawing.Size(434, 20)
        Me.URLTextBox.TabIndex = 7
        '
        'ArtikelkurztextTextBox
        '
        Me.ArtikelkurztextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Artikelkurztext", True))
        Me.ArtikelkurztextTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Tag", Me.ArtikelBindingSource, "ArtikelID", True))
        Me.ArtikelkurztextTextBox.Location = New System.Drawing.Point(88, 24)
        Me.ArtikelkurztextTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ArtikelkurztextTextBox.Name = "ArtikelkurztextTextBox"
        Me.ArtikelkurztextTextBox.Size = New System.Drawing.Size(474, 20)
        Me.ArtikelkurztextTextBox.TabIndex = 13
        '
        'BeschreibungTextBox
        '
        Me.BeschreibungTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Beschreibung", True))
        Me.BeschreibungTextBox.Location = New System.Drawing.Point(87, 95)
        Me.BeschreibungTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.BeschreibungTextBox.Multiline = True
        Me.BeschreibungTextBox.Name = "BeschreibungTextBox"
        Me.BeschreibungTextBox.Size = New System.Drawing.Size(474, 83)
        Me.BeschreibungTextBox.TabIndex = 15
        '
        'EKPreisTextBox
        '
        Me.EKPreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "EKPreis", True))
        Me.EKPreisTextBox.Location = New System.Drawing.Point(289, 50)
        Me.EKPreisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.EKPreisTextBox.Name = "EKPreisTextBox"
        Me.EKPreisTextBox.Size = New System.Drawing.Size(115, 20)
        Me.EKPreisTextBox.TabIndex = 17
        '
        'VKPreisTextBox
        '
        Me.VKPreisTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "VKPreis", True))
        Me.VKPreisTextBox.Location = New System.Drawing.Point(289, 72)
        Me.VKPreisTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.VKPreisTextBox.Name = "VKPreisTextBox"
        Me.VKPreisTextBox.Size = New System.Drawing.Size(115, 20)
        Me.VKPreisTextBox.TabIndex = 19
        '
        'FaktorTextBox
        '
        Me.FaktorTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.ArtikelBindingSource, "Faktor", True))
        Me.FaktorTextBox.Location = New System.Drawing.Point(482, 50)
        Me.FaktorTextBox.Margin = New System.Windows.Forms.Padding(2)
        Me.FaktorTextBox.Name = "FaktorTextBox"
        Me.FaktorTextBox.Size = New System.Drawing.Size(79, 20)
        Me.FaktorTextBox.TabIndex = 21
        '
        'ProduktgruppeGroupBox
        '
        Me.ProduktgruppeGroupBox.Controls.Add(HerstellerLabel)
        Me.ProduktgruppeGroupBox.Controls.Add(Me.HerstellerComboBox)
        Me.ProduktgruppeGroupBox.Controls.Add(ProduktTypLabel)
        Me.ProduktgruppeGroupBox.Controls.Add(Me.ProduktTypComboBox)
        Me.ProduktgruppeGroupBox.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProduktgruppeGroupBox.Location = New System.Drawing.Point(0, 31)
        Me.ProduktgruppeGroupBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProduktgruppeGroupBox.Name = "ProduktgruppeGroupBox"
        Me.ProduktgruppeGroupBox.Padding = New System.Windows.Forms.Padding(2)
        Me.ProduktgruppeGroupBox.Size = New System.Drawing.Size(654, 55)
        Me.ProduktgruppeGroupBox.TabIndex = 16
        Me.ProduktgruppeGroupBox.TabStop = False
        Me.ProduktgruppeGroupBox.Text = "Produktgruppe"
        '
        'HerstellerComboBox
        '
        Me.HerstellerComboBox.DataSource = Me.HerstellerBindingSource
        Me.HerstellerComboBox.DisplayMember = "Hersteller"
        Me.HerstellerComboBox.FormattingEnabled = True
        Me.HerstellerComboBox.Location = New System.Drawing.Point(88, 19)
        Me.HerstellerComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.HerstellerComboBox.Name = "HerstellerComboBox"
        Me.HerstellerComboBox.Size = New System.Drawing.Size(190, 21)
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
        Me.ProduktTypComboBox.Location = New System.Drawing.Point(371, 19)
        Me.ProduktTypComboBox.Margin = New System.Windows.Forms.Padding(2)
        Me.ProduktTypComboBox.Name = "ProduktTypComboBox"
        Me.ProduktTypComboBox.Size = New System.Drawing.Size(190, 21)
        Me.ProduktTypComboBox.TabIndex = 11
        Me.ProduktTypComboBox.ValueMember = "ProduktID"
        '
        'ProduktBindingSource
        '
        Me.ProduktBindingSource.DataMember = "Produkt"
        Me.ProduktBindingSource.DataSource = Me.DataSet1
        '
        'ToolStrip3
        '
        Me.ToolStrip3.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip3.ImageScalingSize = New System.Drawing.Size(24, 24)
        Me.ToolStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddManufacturerNode, Me.AddProductNode, Me.AddArticleNode, Me.DelNode})
        Me.ToolStrip3.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip3.Name = "ToolStrip3"
        Me.ToolStrip3.Size = New System.Drawing.Size(654, 31)
        Me.ToolStrip3.TabIndex = 0
        Me.ToolStrip3.Text = "ToolStrip3"
        '
        'AddManufacturerNode
        '
        Me.AddManufacturerNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddManufacturerNode.Image = Global.TeBaM_1._2.My.Resources.Resources.folder
        Me.AddManufacturerNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddManufacturerNode.Name = "AddManufacturerNode"
        Me.AddManufacturerNode.Size = New System.Drawing.Size(28, 28)
        Me.AddManufacturerNode.Text = "ToolStripButton1"
        Me.AddManufacturerNode.ToolTipText = "Hersteller hinzufügen"
        '
        'AddProductNode
        '
        Me.AddProductNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddProductNode.Image = Global.TeBaM_1._2.My.Resources.Resources.folder_document
        Me.AddProductNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddProductNode.Name = "AddProductNode"
        Me.AddProductNode.Size = New System.Drawing.Size(28, 28)
        Me.AddProductNode.Text = "ToolStripButton2"
        Me.AddProductNode.ToolTipText = "Produkt hinzufügen"
        '
        'AddArticleNode
        '
        Me.AddArticleNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.AddArticleNode.Image = Global.TeBaM_1._2.My.Resources.Resources.file_doc
        Me.AddArticleNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.AddArticleNode.Name = "AddArticleNode"
        Me.AddArticleNode.Size = New System.Drawing.Size(28, 28)
        Me.AddArticleNode.Text = "ToolStripButton3"
        Me.AddArticleNode.ToolTipText = "Artikel hinzufügen"
        '
        'DelNode
        '
        Me.DelNode.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.DelNode.Image = Global.TeBaM_1._2.My.Resources.Resources.delete
        Me.DelNode.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.DelNode.Name = "DelNode"
        Me.DelNode.Size = New System.Drawing.Size(28, 28)
        Me.DelNode.Text = "ToolStripButton4"
        Me.DelNode.ToolTipText = "Knoten löschen"
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ArtikelDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(981, 496)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ArtikelDataGridView
        '
        Me.ArtikelDataGridView.AutoGenerateColumns = False
        Me.ArtikelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ArtikelDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewCheckBoxColumn1})
        Me.ArtikelDataGridView.DataSource = Me.ArtikelBindingSource
        Me.ArtikelDataGridView.Location = New System.Drawing.Point(63, 13)
        Me.ArtikelDataGridView.Name = "ArtikelDataGridView"
        Me.ArtikelDataGridView.Size = New System.Drawing.Size(842, 220)
        Me.ArtikelDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ArtikelID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ArtikelID"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "ProduktID"
        Me.DataGridViewTextBoxColumn2.HeaderText = "ProduktID"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "lfdNrPosAG"
        Me.DataGridViewTextBoxColumn3.HeaderText = "lfdNrPosAG"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "URL"
        Me.DataGridViewTextBoxColumn4.HeaderText = "URL"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Artikelnr"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Artikelnr"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Rubrik"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Rubrik"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Artikelkurztext"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Artikelkurztext"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Beschreibung"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Beschreibung"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "EKPreis"
        Me.DataGridViewTextBoxColumn9.HeaderText = "EKPreis"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "VKPreis"
        Me.DataGridViewTextBoxColumn10.HeaderText = "VKPreis"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Faktor"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Faktor"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "AGSelected"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "AGSelected"
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DateiToolStripMenuItem, Me.AngebotToolStripMenuItem, Me.VertreterToolStripMenuItem, Me.KonfigurationToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(4, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(989, 24)
        Me.MenuStrip1.TabIndex = 3
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DateiToolStripMenuItem
        '
        Me.DateiToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProduktstrukturNeuToolStripMenuItem, Me.ProduktsrukturÖffnenToolStripMenuItem, Me.SpeichernToolStripMenuItem, Me.SpeichernUnterToolStripMenuItem, Me.BeendenToolStripMenuItem})
        Me.DateiToolStripMenuItem.Name = "DateiToolStripMenuItem"
        Me.DateiToolStripMenuItem.Size = New System.Drawing.Size(46, 20)
        Me.DateiToolStripMenuItem.Text = "Datei"
        '
        'ProduktstrukturNeuToolStripMenuItem
        '
        Me.ProduktstrukturNeuToolStripMenuItem.Image = CType(resources.GetObject("ProduktstrukturNeuToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProduktstrukturNeuToolStripMenuItem.Name = "ProduktstrukturNeuToolStripMenuItem"
        Me.ProduktstrukturNeuToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProduktstrukturNeuToolStripMenuItem.Text = "Neu"
        '
        'ProduktsrukturÖffnenToolStripMenuItem
        '
        Me.ProduktsrukturÖffnenToolStripMenuItem.Image = CType(resources.GetObject("ProduktsrukturÖffnenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ProduktsrukturÖffnenToolStripMenuItem.Name = "ProduktsrukturÖffnenToolStripMenuItem"
        Me.ProduktsrukturÖffnenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ProduktsrukturÖffnenToolStripMenuItem.Text = "Öffnen"
        '
        'SpeichernToolStripMenuItem
        '
        Me.SpeichernToolStripMenuItem.Image = CType(resources.GetObject("SpeichernToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpeichernToolStripMenuItem.Name = "SpeichernToolStripMenuItem"
        Me.SpeichernToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SpeichernToolStripMenuItem.Text = "Speichern"
        '
        'SpeichernUnterToolStripMenuItem
        '
        Me.SpeichernUnterToolStripMenuItem.Image = CType(resources.GetObject("SpeichernUnterToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SpeichernUnterToolStripMenuItem.Name = "SpeichernUnterToolStripMenuItem"
        Me.SpeichernUnterToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.SpeichernUnterToolStripMenuItem.Text = "Speichern unter"
        '
        'BeendenToolStripMenuItem
        '
        Me.BeendenToolStripMenuItem.Image = CType(resources.GetObject("BeendenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.BeendenToolStripMenuItem.Name = "BeendenToolStripMenuItem"
        Me.BeendenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.BeendenToolStripMenuItem.Text = "Beenden"
        '
        'AngebotToolStripMenuItem
        '
        Me.AngebotToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ErstellenToolStripMenuItem})
        Me.AngebotToolStripMenuItem.Name = "AngebotToolStripMenuItem"
        Me.AngebotToolStripMenuItem.Size = New System.Drawing.Size(65, 20)
        Me.AngebotToolStripMenuItem.Text = "Angebot"
        '
        'ErstellenToolStripMenuItem
        '
        Me.ErstellenToolStripMenuItem.Image = CType(resources.GetObject("ErstellenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ErstellenToolStripMenuItem.Name = "ErstellenToolStripMenuItem"
        Me.ErstellenToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ErstellenToolStripMenuItem.Text = "erstellen"
        '
        'VertreterToolStripMenuItem
        '
        Me.VertreterToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ListeBearbeitenToolStripMenuItem})
        Me.VertreterToolStripMenuItem.Name = "VertreterToolStripMenuItem"
        Me.VertreterToolStripMenuItem.Size = New System.Drawing.Size(64, 20)
        Me.VertreterToolStripMenuItem.Text = "Vertreter"
        '
        'ListeBearbeitenToolStripMenuItem
        '
        Me.ListeBearbeitenToolStripMenuItem.Image = CType(resources.GetObject("ListeBearbeitenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.ListeBearbeitenToolStripMenuItem.Name = "ListeBearbeitenToolStripMenuItem"
        Me.ListeBearbeitenToolStripMenuItem.Size = New System.Drawing.Size(157, 22)
        Me.ListeBearbeitenToolStripMenuItem.Text = "Liste bearbeiten"
        '
        'KonfigurationToolStripMenuItem
        '
        Me.KonfigurationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TextmarkenDefinierenToolStripMenuItem, Me.AGToolStripMenuItem})
        Me.KonfigurationToolStripMenuItem.Name = "KonfigurationToolStripMenuItem"
        Me.KonfigurationToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.KonfigurationToolStripMenuItem.Text = "Konfiguration"
        '
        'TextmarkenDefinierenToolStripMenuItem
        '
        Me.TextmarkenDefinierenToolStripMenuItem.Image = CType(resources.GetObject("TextmarkenDefinierenToolStripMenuItem.Image"), System.Drawing.Image)
        Me.TextmarkenDefinierenToolStripMenuItem.Name = "TextmarkenDefinierenToolStripMenuItem"
        Me.TextmarkenDefinierenToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.TextmarkenDefinierenToolStripMenuItem.Text = "Textmarken definieren"
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'AGToolStripMenuItem
        '
        Me.AGToolStripMenuItem.Name = "AGToolStripMenuItem"
        Me.AGToolStripMenuItem.Size = New System.Drawing.Size(196, 26)
        Me.AGToolStripMenuItem.Text = "Alle drucken"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(989, 603)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ContextMenuStripOfferTitle.ResumeLayout(False)
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
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ContextMenuStrip_NewTreeView1.ResumeLayout(False)
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArtikelBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FKAngebotSpezOptionenBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ToolStrip4.ResumeLayout(False)
        Me.ToolStrip4.PerformLayout()
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
        Me.TabPage3.ResumeLayout(False)
        CType(Me.ArtikelDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents DataSet1 As DataSet1
    Friend WithEvents Firma1TextBox As TextBox
    Friend WithEvents Firma2TextBox As TextBox
    Friend WithEvents Name1TextBox As TextBox
    Friend WithEvents Name2TextBox As TextBox
    Friend WithEvents StrasseTextBox As TextBox
    Friend WithEvents PLZTextBox As TextBox
    Friend WithEvents OrtTextBox As TextBox
    Friend WithEvents VertreterComboBox As ComboBox
    Friend WithEvents DataSet2 As DataSet2
    Friend WithEvents KundeGroupBox As GroupBox
    Friend WithEvents HerstellerBindingSource As BindingSource
    Friend WithEvents HerstellerComboBox As ComboBox
    Friend WithEvents ProduktBindingSource As BindingSource
    Friend WithEvents ProduktTypComboBox As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents AngebotstitelDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
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
    Friend WithEvents ButtonAddURL As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents RubrikMaskedTextBox As MaskedTextBox
    Friend WithEvents NewTreeView1 As NewTreeView
    Friend WithEvents KundeBindingSource As BindingSource
    Friend WithEvents FKKundeAngebotBindingSource As BindingSource
    Friend WithEvents FKAngebotSpezOptionenBindingSource As BindingSource
    Friend WithEvents ContextMenuStrip_NewTreeView1 As ContextMenuStrip
    Friend WithEvents UmbenennenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AnzeigenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip4 As ToolStrip
    Friend WithEvents ToolStripButtonUp As ToolStripButton
    Friend WithEvents ToolStripButtonDown As ToolStripButton
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents VertreterBindingSource As BindingSource
    Friend WithEvents Panel2 As Panel
    Friend WithEvents VKMaschinenpreis As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents VKDL As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripProgressBar1 As ToolStripProgressBar
    Friend WithEvents AngebotToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ErstellenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents NewStructure As ToolStripButton
    Friend WithEvents OpenStucture As ToolStripButton
    Friend WithEvents SafeStructure As ToolStripButton
    Friend WithEvents SafeStructureUnder As ToolStripButton
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents GenerateOffer As ToolStripButton
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents SalesPartner As ToolStripButton
    Friend WithEvents ToolStripSeparator5 As ToolStripSeparator
    Friend WithEvents TextmarkConfiguration As ToolStripButton
    Friend WithEvents AngebotsIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Angebotstitel As DataGridViewTextBoxColumn
    Friend WithEvents KundennummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotURLDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewComboBoxColumn
    Friend WithEvents Column2 As DataGridViewComboBoxColumn
    Friend WithEvents Column3 As DataGridViewComboBoxColumn
    Friend WithEvents Column4 As DataGridViewComboBoxColumn
    Friend WithEvents Column5 As DataGridViewComboBoxColumn
    Friend WithEvents ArtikelIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents OptionIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AngebotsnummerDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents SortRowDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PrintEnabledCheckBox As CheckBox
    Friend WithEvents ContextMenuStripOfferTitle As ContextMenuStrip
    Friend WithEvents TitelUmbennenenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ArtikelDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents AGToolStripMenuItem As ToolStripMenuItem
End Class

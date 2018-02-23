Imports System
Imports System.IO
Imports System.Runtime.InteropServices
Imports System.Windows.Forms
Imports Microsoft.Office
Imports Microsoft.Office.Interop
Imports System.Collections.Generic
Imports System.Text
Imports System.Runtime.InteropServices.ComTypes
Imports System.Threading



Public Class Form1
    'NewTreeview1 aktualisiert
    Inherits System.Windows.Forms.Form
    Private NodeCount As Integer
    Private FolderCount As Integer
    Private NodeMap As String
    Private Const MAPSIZE As Integer = 128
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents save_XML As Button
    Friend WithEvents load_XML As Button
    Private NewNodeMap As New System.Text.StringBuilder(MAPSIZE)
    Friend WithEvents del_Node As Button
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem

    Dim VT_edit As Boolean = False
    Dim Edit_TBox_URL_Artikel = False
    Dim TBMOffer As Boolean = False
    Dim TBMStructure As Boolean = False
    Dim counter As Integer = 0
    Dim mySelectedNode As New TreeNode
    Dim XMLp As New XMLParser
    Dim SO_RW_XML As New XML_Offer_read_write
    Dim VT_DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml")
    Dim Dateiname_tree As String = ""

    Dim Vertreter_e_mail As String = ""
    Dim Vertreter_Mobilummer As String = ""
    Dim FilePath As String = "Server"

    Private mdrect As Rectangle
    Private mdindex As Integer

    Delegate Sub DelegateSafeData()
    Delegate Sub DelegateNTV1act()
    Delegate Sub DelegatePriceChange(ByVal textvalue As String)
    Delegate Sub InvokeDelegate(ByVal label As String, ByVal NodeTag As String, ByVal NodeNAme As String)

#Region "Programm und UserInterface initialisieren"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml") Then
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml", "")
        End If
        If Not File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini") Then
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini", "")
        End If
        With DataGridView1
            .RowsDefaultCellStyle.BackColor = Color.PowderBlue
            .AlternatingRowsDefaultCellStyle.BackColor = Color.LightCyan
        End With
        With DataGridView2
            .RowsDefaultCellStyle.BackColor = Color.Bisque
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        End With
        With DataGridView2.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(DataGridView2.Font, FontStyle.Regular)
        End With
        With DataGridView2.RowsDefaultCellStyle
            .Font = New Font(DataGridView2.Font, FontStyle.Regular)
        End With
        CenterAlignTitel()
        DataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        ToolStripProgressBar1.Visible = False
        ComboBox1.Visible = False

    End Sub

    Sub Vertreter_akt()
        If KdNummerComboBox.Text <> "" Then

            Me.Cursor = Cursors.WaitCursor


            Dim search As String
            search = "Firma1 Like '" & Firma1TextBox.Text & "'"
            Dim foundrows() As DataRow
            foundrows = DataSet1.Tables("Kunde").Select(search)
            'MsgBox(foundrows(0)(1))
            KdNummerComboBox.Text = foundrows(0)(1)
            Dim KDrow As DataSet1.KundeRow
            KDrow = DataSet1.Kunde.FindByKdNummer(foundrows(0)(1))
            VertreterComboBox.Text = KDrow.ZustVertreter
            DokumentenvorlageComboBox.Text = KDrow.DokVorlage
            BeginInvoke(New DelegateNTV1act(AddressOf TreeView_actualize))
            ComboBox1.Visible = False
            Button1.Enabled = True
        End If
        ComboBox1.Visible = False
        Button1.Enabled = True
        Me.Cursor = Cursors.Arrow
    End Sub

    Sub InitHMI()
        VT_edit = True
        'Form2.DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
        'Vorlagen Dokumente in Combobox laden
        Dim OrtEigeneDateien As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        Dim Dir As New DirectoryInfo(OrtEigeneDateien & "\Benutzerdefinierte Office-Vorlagen\")
        DokumentenvorlageComboBox.Items.Clear()
        For Each file As FileInfo In Dir.GetFiles
            If Microsoft.VisualBasic.Left(file.Name, 1) <> "~" Then
                DokumentenvorlageComboBox.Items.Add(file.Name)
            End If
        Next
        BeginInvoke(New DelegateNTV1act(AddressOf TreeView_actualize))
        ArtikelGroupBox.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")" 'Anzahl Artikel
        KundeGroupBox.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
        Dim tn As TreeNode = NewTreeView1.Nodes(0)
        NewTreeView1.SelectedNode = tn
        NewTreeView1.Select()
        NewTreeView1.Focus()



        'Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
#End Region

#Region "Programm beenden"
    Private Sub BeendenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BeendenToolStripMenuItem.Click
        Me.Visible = False

        Application.Exit()
        EndProgram()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Me.Visible = False
        Application.Exit()
        EndProgram()
    End Sub

    Sub EndProgram()
        If DataSet1.Kunde.Rows.Count > 0 Then
            If TBMStructure = True Then
                If Dateiname_tree = "" Then
                    Select Case MessageBox.Show("Die Produktstruktur ist noch nicht gespeichert!" _
                                 & vbCrLf & "Wollen Sie wirklich beenden ohne zu speichern?" _
                                 & vbCrLf & "Alle Daten gehen verloren!", "ohne speichern fortsetzen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                        Case DialogResult.Yes
                            ' beenden ohne zu speichern!
                        Case DialogResult.No
                            Save_product_structure_under()
                    End Select
                Else
                    Invoke(New DelegateSafeData(AddressOf Save_product_structure))
                End If
            End If
        End If
    End Sub
#End Region

#Region "Einzelne Äste des Baumes komplett ein- oder auschecken und in Angebotstabelle kopieren"
    Private Sub NewTreeView1_AfterCheck(sender As Object, e As TreeViewEventArgs) Handles NewTreeView1.AfterCheck
        If e.Action <> TreeViewAction.Unknown Then
            If e.Node.Tag <> "manufacturer" Then
                CheckAllChildNodes(e.Node)
            Else
                MsgBox("Es können nicht gleichzeitig alle Bausteine ausgewählt werden!", vbExclamation)
            End If
        End If
        'NewNumberOffer()
        PriceKalk()
    End Sub

    Sub PriceKalk()
        Dim SummeMaschine As Integer = 0
        Dim SummeDL As Integer = 0
        Dim PriceRow As DataSet1.ArtikelRow
        For i = 0 To DataGridView2.Rows.Count - 1
            PriceRow = DataSet1.Artikel.FindByArtikelID(DataGridView2.Rows(i).Cells(0).Value)
            Try
                If Microsoft.VisualBasic.Left(PriceRow.Rubrik, 2) <> "10" Then
                    'If PriceRow.VKPreis <> 0 Then
                    SummeMaschine += PriceRow.VKPreis
                    'End If
                Else
                    SummeDL += PriceRow.VKPreis
                End If
            Catch ex As Exception
                'keine Fehlermeldung ausgeben
            End Try
        Next
        VKMaschinenpreis.Text = String.Format("{0:C}", SummeMaschine)
        VKDL.Text = String.Format("{0:C}", SummeDL)
    End Sub


    Private Sub CheckAllChildNodes(treenode As TreeNode)
        Dim TBrow_edit As DataRow = Nothing
        If treenode.Tag = "article" Then
            SeleNodeCheck(treenode)
        Else
            For Each node In treenode.Nodes
                TBrow_edit = DataSet1.Artikel.FindByArtikelID(node.Name)
                If node.checked = False Then
                    node.checked = True
                Else
                    node.checked = False
                End If
                SeleNodeCheck(node)
                If node.Nodes.Count > 0 Then
                    Me.CheckAllChildNodes(node)
                End If
            Next
        End If
    End Sub

    Private Sub SeleNodeCheck(SelNode As TreeNode)
        Dim SpezRow As DataSet1.SpezOptionenRow = Nothing
        Dim InOffer As Boolean = False
        If DataGridView1.CurrentRow.Cells(0).Value <> "" Then
            SpezRow = DataSet1.SpezOptionen.NewSpezOptionenRow
            ' If SelNode IsNot Nothing Then
            If SelNode.Tag IsNot Nothing Then
                If SelNode.Checked = True Then
                    'If SelNode.Tag = "article" Then
                    'hier neue Artikel im Angebot einfügen
                    ' MsgBox(SelNode.Tag)
                    If SelNode.Tag = "article" Then
                        Dim ArtikelRow As DataSet1.ArtikelRow = DataSet1.Artikel.FindByArtikelID(SelNode.Name)
                        SpezRow.Angebotsnummer = DataGridView1.CurrentRow.Cells(0).Value
                        SpezRow.ArtikelID = SelNode.Name
                        SpezRow.OptionID = CStr(Guid.NewGuid.ToString)
                        If ArtikelRow.lfdNrPosAG <= 1 Then
                            SpezRow.SortRow = DataGridView2.Rows.Count + 1
                        Else
                            SpezRow.SortRow = ArtikelRow.lfdNrPosAG
                        End If
                        DataSet1.SpezOptionen.Rows.Add(SpezRow)
                    End If
                Else
                    If SelNode.Checked = False Then
                        'hier selektierten Artikel aus Angebot entfernen
                        For Each SpezRow In DataSet1.SpezOptionen.Select("ArtikelID = '" & SelNode.Name & "'")
                            If SpezRow.Angebotsnummer = DataGridView1.CurrentRow.Cells(0).Value Then
                                Dim ArtikelRow As DataSet1.ArtikelRow = DataSet1.Artikel.FindByArtikelID(SpezRow.ArtikelID)
                                ArtikelRow.lfdNrPosAG = CInt(SpezRow.SortRow)
                                SpezRow.Delete()
                            End If
                        Next
                    End If
                End If
            End If
            'NewNumberOffer()         
        End If

    End Sub
#End Region

#Region "Neuen Kunden einfügen oder löschen"
    Private Sub AddCustomer_Click(sender As Object, e As EventArgs) Handles AddCustomer.Click
        Try
            Dim prompt As String = String.Empty
            Dim title As String = String.Empty
            Dim defaultResponse As String = String.Empty
            Dim answer As Object
            prompt = "Kundennummer: "
            title = "Neue Kundennummer eingeben"
            defaultResponse = "xx-xxxxx"
            answer = InputBox(prompt, title, defaultResponse)
            KdNummerComboBox.Text = answer
            If answer IsNot "" Then
                'erst alle Felder leerräumen
                Firma1TextBox.Text = ""
                Firma2TextBox.Text = ""
                Name1TextBox.Text = ""
                Name2TextBox.Text = ""
                StrasseTextBox.Text = ""
                PLZTextBox.Text = ""
                OrtTextBox.Text = ""
                'neue Eingaben in Dataset übernehmen
                Dim NewKRow As DataSet1.KundeRow = Nothing
                NewKRow = DataSet1.Kunde.NewKundeRow
                NewKRow.KundenID = "KdID_" & Guid.NewGuid.ToString
                NewKRow.KdNummer = answer
                NewKRow.Firma1 = Firma1TextBox.Text
                NewKRow.Firma2 = Firma2TextBox.Text
                NewKRow.Name1 = Name1TextBox.Text
                NewKRow.Name2 = Name2TextBox.Text
                NewKRow.Strasse = StrasseTextBox.Text
                NewKRow.PLZ = PLZTextBox.Text
                NewKRow.Ort = OrtTextBox.Text
                DataSet1.Kunde.Rows.Add(NewKRow)
                TBMStructure = True
            End If
            KundeGroupBox.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
        Catch ex As Exception
            MsgBox("Diese Kundennummer ist bereits vorhanden!", vbExclamation)
        End Try
    End Sub

    Private Sub DelCustomer_Click(sender As Object, e As EventArgs) Handles DelCustomer.Click
        Dim KRow As DataSet1.KundeRow = Nothing
        KRow = DataSet1.Kunde.FindByKdNummer(KdNummerComboBox.Text)
        Select Case MessageBox.Show("Wollen Sie den Kunden wirklich löschen?", "Kunde löschen", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                KRow.Delete()
            Case DialogResult.No
                MsgBox("Löschen abgebrochen", vbExclamation)
        End Select
        KundeGroupBox.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
    End Sub
#End Region

#Region "Neues Angebot einfügen oder löschen"
    Private Sub AddOffer_Click(sender As Object, e As EventArgs) Handles AddOffer.Click
        Try
            Dim AddOfferDialog As New AddOfferDialog
            AddOfferDialog.Text = "Neues Angebot:"
            If AddOfferDialog.ShowDialog = DialogResult.OK Then
                Dim NewAGRow As DataSet1.AngebotRow = Nothing
                NewAGRow = DataSet1.Angebot.NewAngebotRow
                NewAGRow.AngebotsID = AddOfferDialog.TextBoxOfferNumber.Text
                NewAGRow.Angebotstitel = AddOfferDialog.TextBoxOfferTitle.Text
                NewAGRow.Kundennummer = KdNummerComboBox.Text
                NewAGRow.AngebotURL = "noch nicht definiert"
                DataSet1.Angebot.Rows.Add(NewAGRow)
            Else
                MsgBox("Es wird kein neues Angebot angelegt!", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Diese Angebotsnummer ist bereits vorhanden oder es ist noch kein Kunde angelegt!", vbExclamation)
        End Try
    End Sub

    Private Sub DelOffer_Click(sender As Object, e As EventArgs) Handles DelOffer.Click
        Dim AngRow As DataSet1.AngebotRow
        AngRow = DataSet1.Angebot.FindByAngebotsID(DataGridView1.CurrentRow.Cells(0).Value) 'Kundennummer
        Select Case MessageBox.Show("Wollen Sie das Angebot wirklich löschen?", "Angebot löschen", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                AngRow.Delete()
            Case DialogResult.No
                MsgBox("Löschen abgebrochen", vbExclamation)
        End Select
    End Sub
#End Region

#Region "Treeview entsprechend ausgewähltem Angebot aktualisieren"
    Private Sub TraverseChildNodes(nodes As TreeNodeCollection)
        For Each nd As TreeNode In nodes
            nd.Checked = False
            TraverseChildNodes(nd.Nodes)
        Next
    End Sub

    Private Sub DataGridView1_SelectionChanged(sender As Object, e As EventArgs) Handles DataGridView1.SelectionChanged
        BeginInvoke(New DelegateNTV1act(AddressOf TreeView_actualize))
    End Sub

    Private Sub Firma1TextBox_TextChanged(sender As Object, e As EventArgs) Handles Firma1TextBox.TextChanged
        Vertreter_akt()
    End Sub

    Sub TreeView_actualize()
        If DataGridView1.CurrentRow IsNot Nothing Then
            NewTreeView1.Enabled = True
            ToolStripLabel1.Text = DataGridView1.CurrentRow.Cells(0).Value
            Dim SpezRow As DataSet1.SpezOptionenRow = Nothing
            TraverseChildNodes(NewTreeView1.Nodes)
            For i = 0 To DataSet1.SpezOptionen.Rows.Count - 1
                SpezRow = DataSet1.SpezOptionen.Rows(i)
                If DataGridView1.CurrentRow.Cells(0).Value = SpezRow.Angebotsnummer Then
                    Dim Nodes As TreeNode() = Nothing
                    Nodes = NewTreeView1.Nodes.Find(SpezRow.ArtikelID, True)
                    For Each node As TreeNode In Nodes
                        node.Checked = True
                    Next
                End If
            Next
        Else
            NewTreeView1.Enabled = False
            ToolStripLabel1.Text = "kein Angebot ausgewählt"
        End If

    End Sub
#End Region

#Region "Hersteller, Produkt und Artikel im TreeView hinzufügen oder löschen; TSB=ToolStripButton"
    Private Sub AddManufacturerNode_Click(sender As Object, e As EventArgs) Handles AddManufacturerNode.Click
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim answer As Object
        ' If NewTreeView1.SelectedNode.Tag <> "document" Then
        prompt = "Hersteller:"
        title = "Herstellername eingeben"
        defaultResponse = "Hersteller Knoten"
        answer = InputBox(prompt, title, defaultResponse)
        If answer IsNot "" Then
            Dim newNode As TreeNode = New TreeNode(answer, 0, 0)
            System.Threading.Interlocked.Increment(Me.FolderCount)
            Me.NewTreeView1.Nodes.Add(newNode) 'Hersteller immer als Wurzelknoten einfügen
            newNode.Text = answer
            newNode.Name = "manufacturer_" & Guid.NewGuid.ToString
            newNode.Tag = "manufacturer"
            newNode.ImageIndex = 4
            newNode.SelectedImageIndex = 4
            'Datatable schreiben
            Dim NewHRow As DataSet1.HerstellerRow
            NewHRow = DataSet1.Hersteller.NewHerstellerRow()
            NewHRow.HerstellerID = newNode.Name
            NewHRow.Hersteller = newNode.Text
            DataSet1.Hersteller.Rows.Add(NewHRow)
            'TBox_NodeText.Text = newNode.Text
            'TBox_NodeName.Text = newNode.Name
            'TBox_NodeTag.Text = newNode.Tag
            'TBox_NodeImageIndex.Text = 4
            'TBox_NodeSelImageIndex.Text = 4
            TBMStructure = True
        End If
    End Sub

    Private Sub AddProductNode_Click(sender As Object, e As EventArgs) Handles AddProductNode.Click
        'MsgBox("add_Produkt")
        Dim prompt As String = String.Empty
        Dim title As String = String.Empty
        Dim defaultResponse As String = String.Empty
        Dim answer As Object
        ' If NewTreeView1.SelectedNode.Tag <> "document" Then
        prompt = "Produkt:"
        title = "Produktname eingeben"
        defaultResponse = "Produkt Knoten"
        answer = InputBox(prompt, title, defaultResponse)
        If answer IsNot "" Then
            Dim newNode As TreeNode = New TreeNode(answer, 0, 0)
            System.Threading.Interlocked.Increment(Me.FolderCount)
            If NewTreeView1.Nodes.Count = 0 Then
                Me.NewTreeView1.Nodes.Add(newNode)
            Else
                If NewTreeView1.SelectedNode IsNot Nothing Then
                    Me.NewTreeView1.SelectedNode.Nodes.Add(newNode)
                Else
                    MsgBox("kein Knoten ausgewählt", MsgBoxStyle.Exclamation)
                End If
            End If
            newNode.Text = answer
            newNode.Name = "product_" & Guid.NewGuid.ToString
            newNode.Tag = "product"
            newNode.ImageIndex = 0
            newNode.SelectedImageIndex = 0
            'Datatable schreiben
            Dim NewPRow As DataSet1.ProduktRow
            NewPRow = DataSet1.Produkt.NewProduktRow
            NewPRow.ProduktID = newNode.Name
            NewPRow.ProduktTyp = newNode.Text
            NewPRow.HerstellerID = HerstellerComboBox.SelectedValue 'Verknüpfung zum Hersteller erstellen
            DataSet1.Produkt.Rows.Add(NewPRow)
            'TBox_NodeText.Text = newNode.Text
            'TBox_NodeName.Text = newNode.Name
            'TBox_NodeTag.Text = newNode.Tag
            'TBox_NodeImageIndex.Text = 0
            'TBox_NodeSelImageIndex.Text = 0
            TBMStructure = True
        End If
    End Sub


    Private Sub AddArticleNode_Click(sender As Object, e As EventArgs) Handles AddArticleNode.Click
        Try
            If NewTreeView1.SelectedNode.Tag = "product" Then
                'MsgBox("add_Artikel")
                Dim prompt As String = String.Empty
                Dim title As String = String.Empty
                Dim defaultResponse As String = String.Empty
                Dim answer As Object
                prompt = "Artikel: "
                title = "Knotennamen des Artikels eingeben"
                defaultResponse = "Artikel Knoten"
                answer = InputBox(prompt, title, defaultResponse)
                If answer IsNot "" Then
                    Dim newNode As TreeNode = New TreeNode(answer, 2, 2)
                    System.Threading.Interlocked.Increment(Me.NodeCount)
                    If NewTreeView1.Nodes.Count = 0 Then
                        Me.NewTreeView1.Nodes.Add(newNode)
                    Else
                        Me.NewTreeView1.SelectedNode.Nodes.Add(newNode)
                    End If
                    newNode.Name = "article_" & Guid.NewGuid.ToString
                    newNode.Tag = "article"
                    newNode.ImageIndex = 1
                    newNode.SelectedImageIndex = 1
                    'Datatable schreiben
                    Dim NewARow As DataSet1.ArtikelRow

                    NewARow = DataSet1.Artikel.NewArtikelRow()
                    NewARow.ArtikelID = newNode.Name
                    'NewARow.ProduktID = ProduktTypComboBox.SelectedValue 'Verknüpfung zum Produkt erstellen
                    NewARow.ProduktID = NewTreeView1.SelectedNode.Name 'Verknüpfung zum Produkt erstellen
                    NewARow.lfdNrPosAG = 1
                    DataSet1.Artikel.Rows.Add(NewARow)
                    PrintEnabledCheckBox.Checked = False
                    'TBox_NodeText.Text = newNode.Text
                    'TBox_NodeName.Text = newNode.Name
                    'TBox_NodeTag.Text = newNode.Tag
                    'TBox_NodeImageIndex.Text = 1
                    'TBox_NodeSelImageIndex.Text = 1
                    TBMStructure = True
                    KundeGroupBox.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")"
                End If
            Else
                MsgBox("Hier kann kein Artikel eingefügt werden", vbExclamation)
            End If
        Catch ex As Exception
            MsgBox("Es existiert kein gültiger Wurzelknoten", vbExclamation)
        End Try
    End Sub

    Private Sub DelNode_Click(sender As Object, e As EventArgs) Handles DelNode.Click
        If NewTreeView1.Nodes.Count > 0 Then
            If NewTreeView1.SelectedNode.Checked = False Then
                Select Case MessageBox.Show("Wollen Sie den selektierten Knoten wirklich löschen?", "Knoten löschen", MessageBoxButtons.YesNo)
                    Case DialogResult.Yes
                        If NewTreeView1.SelectedNode.Tag = "article" Then
                            Dim ARowEdit As DataSet1.ArtikelRow
                            ARowEdit = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
                            If ARowEdit IsNot Nothing Then
                                ARowEdit.Delete()
                            End If
                        End If
                        If NewTreeView1.SelectedNode.Tag = "product" Then
                            Dim PRowEdit As DataSet1.ProduktRow
                            PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                            PRowEdit.Delete()
                        End If
                        NewTreeView1.Nodes.Remove(NewTreeView1.SelectedNode)
                    Case DialogResult.No
                        MsgBox("Löschen abgebrochen", vbExclamation)
                End Select
                KundeGroupBox.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")"
            Else
                MsgBox("Der Knoten ist noch im aktuellen Angebot enthalten!", vbExclamation)
            End If
        End If
    End Sub
#End Region

#Region "Produktstruktur und Dataset speichern oder speichern unter sowie öffnen"
    Private Sub ProduktstrukturNeuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktstrukturNeuToolStripMenuItem.Click
        TBMStructure = False
        NewTreeView1.Nodes.Clear()
        Dateiname_tree = ""
        DataSet1.Clear()
        CenterAlignTitel()
    End Sub

    Private Sub NewStructure_Click(sender As Object, e As EventArgs) Handles NewStructure.Click
        TBMStructure = False
        NewTreeView1.Nodes.Clear()
        Dateiname_tree = ""
        DataSet1.Clear()
        CenterAlignTitel()
    End Sub

    Private Sub ProduktsrukturÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktsrukturÖffnenToolStripMenuItem.Click
        Open_product_structure()
        BeginInvoke(New DelegateNTV1act(AddressOf TreeView_actualize))
    End Sub

    Private Sub OpenStucture_Click(sender As Object, e As EventArgs) Handles OpenStucture.Click
        Open_product_structure()
        BeginInvoke(New DelegateNTV1act(AddressOf TreeView_actualize))
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
        If TBMStructure = True Then
            Invoke(New DelegateSafeData(AddressOf Save_product_structure))
        Else
            MsgBox("keine Daten vorhanden")
        End If
    End Sub

    Private Sub SafeStructure_Click(sender As Object, e As EventArgs) Handles SafeStructure.Click
        If TBMStructure = True Then
            Invoke(New DelegateSafeData(AddressOf Save_product_structure))
        Else
            MsgBox("keine Daten vorhanden")
        End If
    End Sub

    Private Sub SpeichernUnterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernUnterToolStripMenuItem.Click
        If TBMStructure = True Then
            Save_product_structure_under()
        Else
            MsgBox("keine Daten vorhanden")
        End If
    End Sub

    Private Sub SafeStructureUnder_Click(sender As Object, e As EventArgs) Handles SafeStructureUnder.Click
        If TBMStructure = True Then
            Save_product_structure_under()
        Else
            MsgBox("keine Daten vorhanden")
        End If
    End Sub

    Private Sub Save_product_structure()
        If TBMStructure = True Then
            If Dateiname_tree <> "" Then
                Dim _DataTree As New FileInfo(Dateiname_tree)
                XMLp.exportTreeViewXML(NewTreeView1, _DataTree.FullName)
                Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data_" & Path.GetFileNameWithoutExtension(Dateiname_tree) & ".xml")
                'Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data.xml")
                DataSet1.WriteXml(_DataFile.FullName)
            Else
                Save_product_structure_under()
            End If
        Else
            MsgBox("Keine Daten zum speichern vorhanden!", vbExclamation)
        End If
    End Sub

    Private Sub Save_product_structure_under()
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.Filter = "Produktstruktur speichern unter|*.xml"
        saveFileDialog1.Title = "Produktstruktur speichern"
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            Dateiname_tree = saveFileDialog1.FileName
            Dim _DataTree As New FileInfo("neu.xml")
            Invoke(New DelegateSafeData(AddressOf Save_product_structure))
            TBMStructure = True
        End If
    End Sub

    Private Sub Open_product_structure()
        If TBMStructure = False Then
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Cursor Files|*.xml"
            openFileDialog1.Title = "Bitte eine Produktstruktur auswählen"
            If TBMStructure = True Then Invoke(New DelegateSafeData(AddressOf Save_product_structure)) ' bestehende Produktstruktur abspeichern!
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then

                Dateiname_tree = openFileDialog1.FileName
                Dim _DataTree As New FileInfo(Dateiname_tree)
                Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data_" & Path.GetFileNameWithoutExtension(Dateiname_tree) & ".xml")
                'Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data.xml")
                If Not _DataFile.Exists Then Return
                NewTreeView1.Nodes.Clear()
                DataSet1.ReadXml(_DataFile.FullName)
                DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
                XMLp.importTreeViewXML(NewTreeView1, _DataTree.FullName)
                If NewTreeView1.Nodes.Count > 0 Then
                    InitHMI()
                    TBMStructure = True
                End If
                CenterAlignTitel()
                Button1.Enabled = True
            End If
        Else
            Invoke(New DelegateSafeData(AddressOf Save_product_structure))
            TBMStructure = False
            DataSet1.Clear()
            Open_product_structure()
        End If
    End Sub

    Private Sub Form1_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.SizeChanged
        CenterAlignTitel()
    End Sub

    Sub CenterAlignTitel()
        Dim Titel As String
        If Dateiname_tree <> "" Then
            Titel = Path.GetFileName(Dateiname_tree) & " - TeBaM"
        Else
            Titel = "TeBaM"
        End If
        Dim g As Graphics = Me.CreateGraphics()

        Dim startingPoint As Double = ((Me.Width) / 2) - (g.MeasureString(Titel.Trim, Me.Font).Width / 2)
        Dim widthOfASpace As Double = g.MeasureString(" ", Me.Font).Width
        Dim tmp As String = " "
        Dim tmpWidth As Double = 0
        Do
            tmp += " "
            tmpWidth += widthOfASpace
        Loop While (tmpWidth + widthOfASpace) < startingPoint
        Me.Text = tmp & Titel.Trim & tmp
    End Sub
#End Region

#Region "Treeview Drag and Drop"
    Private Sub NewTreeView1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NewTreeView1.MouseDown
        NewTreeView1.LabelEdit = False
        Me.NewTreeView1.SelectedNode = Me.NewTreeView1.GetNodeAt(e.X, e.Y)
        mySelectedNode = Me.NewTreeView1.GetNodeAt(e.X, e.Y) ' wird zum Knoten editieren benötigt
    End Sub

    Private Sub NewTreeView1_ItemDrag(ByVal sender As Object, ByVal e As System.Windows.Forms.ItemDragEventArgs) Handles NewTreeView1.ItemDrag
        If Me.NewTreeView1.SelectedNode.Tag <> "manufacturer" Then
            DoDragDrop(e.Item, DragDropEffects.Move)
        End If
    End Sub

    Private Sub NewTreeView1_DragEnter(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles NewTreeView1.DragEnter
        e.Effect = DragDropEffects.Move
    End Sub

    Private Sub NewTreeView1_DragDrop(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles NewTreeView1.DragDrop
        If e.Data.GetDataPresent("System.Windows.Forms.TreeNode", False) AndAlso Not (Me.NodeMap = "") Then
            Dim MovingNode As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
            Dim NodeIndexes As String() = Me.NodeMap.Split("|"c)
            Dim InsertCollection As TreeNodeCollection = Me.NewTreeView1.Nodes
            Dim i As Integer = 0
            While i < NodeIndexes.Length - 1
                InsertCollection = InsertCollection(Int32.Parse(NodeIndexes(i))).Nodes
                System.Math.Min(System.Threading.Interlocked.Increment(i), i - 1)
            End While
            If Not (InsertCollection Is Nothing) Then
                InsertCollection.Insert(Int32.Parse(NodeIndexes(NodeIndexes.Length - 1)), CType(MovingNode.Clone, TreeNode))
                Me.NewTreeView1.SelectedNode = InsertCollection(Int32.Parse(NodeIndexes(NodeIndexes.Length - 1)))
                MovingNode.Remove()
            End If
        End If
        NewArticleBinding()
    End Sub

    Private Sub NewTreeView1_DragOver(ByVal sender As Object, ByVal e As System.Windows.Forms.DragEventArgs) Handles NewTreeView1.DragOver
        Dim NodeOver As TreeNode = Me.NewTreeView1.GetNodeAt(Me.NewTreeView1.PointToClient(Cursor.Position))
        Dim NodeMoving As TreeNode = CType(e.Data.GetData("System.Windows.Forms.TreeNode"), TreeNode)
        Dim TopTreeNode As TreeNode = NewTreeView1.TopNode
        If Not (NodeOver Is Nothing) AndAlso (Not (NodeOver Is NodeMoving) OrElse (Not (NodeOver.Parent Is Nothing) AndAlso NodeOver.Index = (NodeOver.Parent.Nodes.Count - 1))) Then
            If NodeOver IsNot TopTreeNode Then
                Dim OffsetY As Integer = Me.NewTreeView1.PointToClient(Cursor.Position).Y - NodeOver.Bounds.Top
                Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
                Dim g As Graphics = Me.NewTreeView1.CreateGraphics
                If NodeOver.ImageIndex = 1 Then
                    If OffsetY < (NodeOver.Bounds.Height / 2) Then
                        Dim tnParadox As TreeNode = NodeOver
                        While Not (tnParadox.Parent Is Nothing)
                            If tnParadox.Parent Is NodeMoving Then
                                Me.NodeMap = ""
                                Return
                            End If
                            tnParadox = tnParadox.Parent
                        End While
                        SetNewNodeMap(NodeOver, False)  ' ERROR!  Not sure why
                        If SetMapsEqual() = True Then
                            Return
                        End If
                        Me.Refresh()
                        Me.DrawLeafTopPlaceholders(NodeOver)
                    Else
                        Dim tnParadox As TreeNode = NodeOver
                        While Not (tnParadox.Parent Is Nothing)
                            If tnParadox.Parent Is NodeMoving Then
                                Me.NodeMap = ""
                                Return
                            End If
                            tnParadox = tnParadox.Parent
                        End While
                        Dim ParentDragDrop As TreeNode = Nothing
                        If Not (NodeOver.Parent Is Nothing) AndAlso NodeOver.Index = (NodeOver.Parent.Nodes.Count - 1) Then
                            Dim XPos As Integer = Me.NewTreeView1.PointToClient(Cursor.Position).X
                            If XPos < NodeOver.Bounds.Left Then
                                ParentDragDrop = NodeOver.Parent
                                If XPos < (ParentDragDrop.Bounds.Left - Me.NewTreeView1.ImageList.Images(ParentDragDrop.ImageIndex).Size.Width) Then
                                    If Not (ParentDragDrop.Parent Is Nothing) Then
                                        ParentDragDrop = ParentDragDrop.Parent
                                    End If
                                End If
                            End If
                        End If
                        SetNewNodeMap(Microsoft.VisualBasic.IIf(Not (ParentDragDrop Is Nothing), ParentDragDrop, NodeOver), True)
                        If SetMapsEqual() = True Then
                            Return
                        End If
                        Me.Refresh()
                        DrawLeafBottomPlaceholders(NodeOver, ParentDragDrop)
                    End If
                Else
                    If OffsetY < (NodeOver.Bounds.Height / 3) Then
                        Dim tnParadox As TreeNode = NodeOver
                        While Not (tnParadox.Parent Is Nothing)
                            If tnParadox.Parent Is NodeMoving Then
                                Me.NodeMap = ""
                                Return
                            End If
                            tnParadox = tnParadox.Parent
                        End While
                        SetNewNodeMap(NodeOver, False)
                        If SetMapsEqual() = True Then
                            Return
                        End If
                        Me.Refresh()
                        Me.DrawFolderTopPlaceholders(NodeOver)
                    Else
                        If (Not (NodeOver.Parent Is Nothing) AndAlso NodeOver.Index = 0) AndAlso (OffsetY > (NodeOver.Bounds.Height - (NodeOver.Bounds.Height / 3))) Then
                            Dim tnParadox As TreeNode = NodeOver
                            While Not (tnParadox.Parent Is Nothing)
                                If tnParadox.Parent Is NodeMoving Then
                                    Me.NodeMap = ""
                                    Return
                                End If
                                tnParadox = tnParadox.Parent
                            End While
                            SetNewNodeMap(NodeOver, True)
                            If SetMapsEqual() = True Then
                                Return
                            End If
                            Me.Refresh()
                            DrawFolderTopPlaceholders(NodeOver)
                        Else
                            If NodeOver.Nodes.Count > 0 Then
                                NodeOver.Expand()
                            Else
                                If NodeMoving Is NodeOver Then
                                    Return
                                End If
                                Dim tnParadox As TreeNode = NodeOver
                                While Not (tnParadox.Parent Is Nothing)
                                    If tnParadox.Parent Is NodeMoving Then
                                        Me.NodeMap = ""
                                        Return
                                    End If
                                    tnParadox = tnParadox.Parent
                                End While
                                SetNewNodeMap(NodeOver, False)
                                NewNodeMap = NewNodeMap.Insert(NewNodeMap.Length, "|0")
                                If SetMapsEqual() = True Then
                                    Return
                                End If
                                Me.Refresh()
                                DrawAddToFolderPlaceholder(NodeOver)
                            End If
                        End If
                    End If
                End If
            Else
                Me.DrawLeafTopPlaceholders(NodeOver)
            End If
        End If
    End Sub

    Private Sub DrawLeafTopPlaceholders(ByVal NodeOver As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
        Dim LeftPos As Integer = NodeOver.Bounds.Left - NodeOverImageWidth
        Dim RightPos As Integer = Me.NewTreeView1.Width - 4
        Dim LeftTriangle As Point() = New Point(4) {New Point(LeftPos, NodeOver.Bounds.Top - 4), New Point(LeftPos, NodeOver.Bounds.Top + 4), New Point(LeftPos + 4, NodeOver.Bounds.Y), New Point(LeftPos + 4, NodeOver.Bounds.Top - 1), New Point(LeftPos, NodeOver.Bounds.Top - 5)}
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Top - 4), New Point(RightPos, NodeOver.Bounds.Top + 4), New Point(RightPos - 4, NodeOver.Bounds.Y), New Point(RightPos - 4, NodeOver.Bounds.Top - 1), New Point(RightPos, NodeOver.Bounds.Top - 5)}
        g.FillPolygon(System.Drawing.Brushes.Black, LeftTriangle)
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
        g.DrawLine(New System.Drawing.Pen(Color.Black, 2), New Point(LeftPos, NodeOver.Bounds.Top), New Point(RightPos, NodeOver.Bounds.Top))
    End Sub

    Private Sub DrawLeafBottomPlaceholders(ByVal NodeOver As TreeNode, ByVal ParentDragDrop As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
        Dim LeftPos As Integer
        Dim RightPos As Integer
        If Not (ParentDragDrop Is Nothing) Then
            LeftPos = ParentDragDrop.Bounds.Left - (Me.NewTreeView1.ImageList.Images(ParentDragDrop.ImageIndex).Size.Width + 8)
        Else
            LeftPos = NodeOver.Bounds.Left - NodeOverImageWidth
        End If
        RightPos = Me.NewTreeView1.Width - 4
        Dim LeftTriangle As Point() = New Point(4) {New Point(LeftPos, NodeOver.Bounds.Bottom - 4), New Point(LeftPos, NodeOver.Bounds.Bottom + 4), New Point(LeftPos + 4, NodeOver.Bounds.Bottom), New Point(LeftPos + 4, NodeOver.Bounds.Bottom - 1), New Point(LeftPos, NodeOver.Bounds.Bottom - 5)}
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Bottom - 4), New Point(RightPos, NodeOver.Bounds.Bottom + 4), New Point(RightPos - 4, NodeOver.Bounds.Bottom), New Point(RightPos - 4, NodeOver.Bounds.Bottom - 1), New Point(RightPos, NodeOver.Bounds.Bottom - 5)}
        g.FillPolygon(System.Drawing.Brushes.Black, LeftTriangle)
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
        g.DrawLine(New System.Drawing.Pen(Color.Black, 2), New Point(LeftPos, NodeOver.Bounds.Bottom), New Point(RightPos, NodeOver.Bounds.Bottom))
    End Sub

    Private Sub DrawFolderTopPlaceholders(ByVal NodeOver As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim NodeOverImageWidth As Integer = Me.NewTreeView1.ImageList.Images(NodeOver.ImageIndex).Size.Width + 8
        Dim LeftPos As Integer
        Dim RightPos As Integer
        LeftPos = NodeOver.Bounds.Left - NodeOverImageWidth
        RightPos = Me.NewTreeView1.Width - 4
        Dim LeftTriangle As Point() = New Point(4) {New Point(LeftPos, NodeOver.Bounds.Top - 4), New Point(LeftPos, NodeOver.Bounds.Top + 4), New Point(LeftPos + 4, NodeOver.Bounds.Y), New Point(LeftPos + 4, NodeOver.Bounds.Top - 1), New Point(LeftPos, NodeOver.Bounds.Top - 5)}
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Top - 4), New Point(RightPos, NodeOver.Bounds.Top + 4), New Point(RightPos - 4, NodeOver.Bounds.Y), New Point(RightPos - 4, NodeOver.Bounds.Top - 1), New Point(RightPos, NodeOver.Bounds.Top - 5)}
        g.FillPolygon(System.Drawing.Brushes.Black, LeftTriangle)
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
        g.DrawLine(New System.Drawing.Pen(Color.Black, 2), New Point(LeftPos, NodeOver.Bounds.Top), New Point(RightPos, NodeOver.Bounds.Top))
    End Sub

    Private Sub DrawAddToFolderPlaceholder(ByVal NodeOver As TreeNode)
        Dim g As Graphics = Me.NewTreeView1.CreateGraphics
        Dim RightPos As Integer = NodeOver.Bounds.Right + 6
        Dim RightTriangle As Point() = New Point(4) {New Point(RightPos, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) + 4), New Point(RightPos, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) + 4), New Point(RightPos - 4, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2)), New Point(RightPos - 4, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) - 1), New Point(RightPos, NodeOver.Bounds.Y + (NodeOver.Bounds.Height / 2) - 5)}
        Me.Refresh()
        g.FillPolygon(System.Drawing.Brushes.Black, RightTriangle)
    End Sub

    Private Sub SetNewNodeMap(ByVal tnNode As TreeNode, ByVal boolBelowNode As Boolean)
        NewNodeMap.Length = 0
        If boolBelowNode Then
            NewNodeMap.Insert(0, CType(tnNode.Index, Integer) + 1)
        Else
            NewNodeMap.Insert(0, CType(tnNode.Index, Integer))
        End If
        Dim tnCurNode As TreeNode = tnNode
        While Not (tnCurNode.Parent Is Nothing)
            tnCurNode = tnCurNode.Parent
            If NewNodeMap.Length = 0 AndAlso boolBelowNode = True Then
                NewNodeMap.Insert(0, CStr(tnCurNode.Index + 1) + "|")
            Else
                NewNodeMap.Insert(0, CStr(tnCurNode.Index) + "|")
            End If
        End While
    End Sub

    Private Function SetMapsEqual() As Boolean
        If Me.NewNodeMap.ToString = Me.NodeMap Then
            Return True
        Else
            Me.NodeMap = Me.NewNodeMap.ToString
            Return False
        End If
    End Function

    Sub NewArticleBinding()
        Try
            If NewTreeView1.SelectedNode.Tag = "article" Then
                Dim PRowEdit As DataSet1.ProduktRow
                PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Parent.Name)
                Dim ARowEdit As DataSet1.ArtikelRow
                ARowEdit = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
                ARowEdit.ProduktID = NewTreeView1.SelectedNode.Parent.Name
            End If
            If NewTreeView1.SelectedNode.Tag = "product" Then
                If NewTreeView1.SelectedNode.Parent IsNot Nothing Then
                    If NewTreeView1.SelectedNode.Parent.Tag = "manufacturer" Then
                        If NewTreeView1.SelectedNode.Parent.Name IsNot Nothing Then
                            Dim HRowEdit As DataSet1.HerstellerRow
                            HRowEdit = DataSet1.Hersteller.FindByHerstellerID(NewTreeView1.SelectedNode.Parent.Name)
                            Dim PRowEdit As DataSet1.ProduktRow
                            PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                            PRowEdit.HerstellerID = NewTreeView1.SelectedNode.Parent.Name
                            'MsgBox(HRowEdit.HerstellerID)
                        Else
                            Dim HRowEdit As DataSet1.HerstellerRow
                            HRowEdit = DataSet1.Hersteller.FindByHerstellerID(NewTreeView1.TopNode.Name)
                            Dim PRowEdit As DataSet1.ProduktRow
                            PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                            PRowEdit.HerstellerID = NewTreeView1.TopNode.Name
                            'MsgBox(HRowEdit.HerstellerID)
                        End If
                    Else
                        Dim PRowEdit As DataSet1.ProduktRow
                        PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Parent.Name)
                        PRowEdit.ProduktID = NewTreeView1.SelectedNode.Parent.Name
                    End If
                    NewTreeView1.SelectedNode.ImageIndex = 0
                    NewTreeView1.SelectedNode.SelectedImageIndex = 0
                Else
                    Dim PRowEdit As DataSet1.ProduktRow
                    PRowEdit = DataSet1.Produkt.FindByProduktID(NewTreeView1.SelectedNode.Name)
                    PRowEdit.HerstellerID = "undefined"
                    NewTreeView1.SelectedNode.ImageIndex = 5
                    NewTreeView1.SelectedNode.SelectedImageIndex = 5
                End If
            End If
        Catch ex As Exception
            MsgBox("Es existiert kein gültiger Wurzelknoten", vbExclamation)
        End Try
    End Sub
#End Region

#Region "Artikelfenster Daten updaten"
    Private Sub NewTreeView1_AfterSelect(sender As Object, e As System.Windows.Forms.TreeViewEventArgs) Handles NewTreeView1.AfterSelect
        Dim currentNode As TreeNode = Nothing
        ArticleHMI(NewTreeView1.SelectedNode.Tag)
        currentNode = e.Node
        If currentNode.Parent IsNot Nothing Then
            SelectedNodeChanged()
        End If
        Dim WurzelKnoten As String = ""
        If NewTreeView1.SelectedNode.Tag = "article" Then
            WurzelKnoten = FindManufacturerNode(currentNode)
            HerstellerComboBox.Text = WurzelKnoten
            ProduktTypComboBox.Text = currentNode.Parent.Text
        End If
        If NewTreeView1.SelectedNode.Tag = "product" Then
            WurzelKnoten = FindManufacturerNode(currentNode)
            HerstellerComboBox.Text = WurzelKnoten
            ProduktTypComboBox.Text = currentNode.Parent.Text
        End If
        If NewTreeView1.SelectedNode.Tag = "manufacturer" Then
            HerstellerComboBox.Text = NewTreeView1.SelectedNode.Text
            ProduktTypComboBox.Text = ""
        End If
        EKPreisTextBox.BeginInvoke(New DelegatePriceChange(AddressOf TM_ChangeEK), EKPreisTextBox.Text)
        VKPreisTextBox.BeginInvoke(New DelegatePriceChange(AddressOf TM_ChangeVK), VKPreisTextBox.Text)
    End Sub

    Private Function FindManufacturerNode(node As TreeNode)
        While node IsNot Nothing
            If node.Tag = "manufacturer" Then
                Return node.Text
            Else
                node = node.Parent
            End If
        End While
    End Function

    Sub ArticleHMI(NodeTag As String)
        If NodeTag = "article" Then
            ArtikelGroupBox.Enabled = True
        Else
            ArtikelGroupBox.Enabled = False
        End If
    End Sub

    Sub SelectedNodeChanged()
        'Beim Click auf NewTreeView1 Zeile im Datagrid  selektieren
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Rows(i).Cells(0).Value = NewTreeView1.SelectedNode.Name.ToString() Then
                'markiert die Zeile
                DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
                DataGridView2.Rows(i).Selected = True
                'DataGridView5.FirstDisplayedScrollingRowIndex = i
            End If
        Next
        'fertig
        If NewTreeView1.SelectedNode.Tag = "article" Then
            Dim PRowindex = ProduktBindingSource.Find("ProduktID", NewTreeView1.SelectedNode.Parent.Name)
            If NewTreeView1.SelectedNode.Parent.Tag <> "manufacturer" Then
                If PRowindex <> -1 Then
                    ProduktBindingSource.Position = PRowindex
                End If
            End If
        End If
        Dim ARowindex = ArtikelBindingSource.Find("ArtikelID", NewTreeView1.SelectedNode.Name)
        If ARowindex <> -1 Then
            ArtikelBindingSource.Position = ARowindex
            Dim rowIndex As Integer = -1
            For Each row As DataGridViewRow In DataGridView2.Rows
                If row.Cells(0).Value.ToString().Equals(NewTreeView1.SelectedNode.Name) Then
                    rowIndex = row.Index
                    Exit For
                End If
            Next
        End If
    End Sub

    Private Sub DataGridView2_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellClick
        Dim ArtikelID As String = ""
        Dim node As TreeNode = Nothing
        If DataGridView2.Rows.Count > 0 Then
            ArtikelID = DataGridView2.CurrentRow.Cells(0).Value
            If TBMStructure = True And ArtikelID <> "" Then
                NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(ArtikelID, True)(0)
                NewTreeView1.Select()
                NewTreeView1.SelectedNode.Expand()
            End If
        End If
    End Sub

    Private Sub HerstellerComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles HerstellerComboBox.DropDownClosed
        NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(HerstellerComboBox.SelectedValue, True)(0)
        NewTreeView1.Select()
        NewTreeView1.SelectedNode.Expand()
        ' Me.DataGridView2.Sort(Me.DataGridView2.Columns(8), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ProduktTypComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles ProduktTypComboBox.DropDownClosed
        NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(ProduktTypComboBox.SelectedValue, True)(0)
        NewTreeView1.Select()
        NewTreeView1.SelectedNode.Expand()
        'Me.DataGridView2.Sort(Me.DataGridView2.Columns(8), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ButtonAddURL_Click(sender As Object, e As EventArgs) Handles ButtonAddURL.Click
        URL_ArticleCheck()
    End Sub

    Sub URL_ArticleCheck()
        Dim row As DataSet1.ArtikelRow = Nothing
        Dim strFile As String = ""
        OpenFileDialog1.FileName = ""
        If NewTreeView1.SelectedNode IsNot Nothing Then
            If OpenFileDialog1.ShowDialog() = DialogResult.OK Then
                strFile = OpenFileDialog1.FileName.ToString
                URLTextBox.Text = strFile
                If File.Exists(URLTextBox.Text) Then
                    NewTreeView1.SelectedNode.ImageIndex = 2
                    NewTreeView1.SelectedNode.SelectedImageIndex = 2
                Else
                    NewTreeView1.SelectedNode.ImageIndex = 3
                    NewTreeView1.SelectedNode.SelectedImageIndex = 3
                End If
            Else
                MsgBox("Aktion durch Benutzer abgebrochen!", vbExclamation)
            End If
        End If
    End Sub
#End Region

#Region "Texbox Formatierungen erstellen"


    Sub TM_ChangeEK(ByVal input As String)
        If EKPreisTextBox.Text <> "" Then
            EKPreisTextBox.Text = String.Format("{0:C2}", CDbl(EKPreisTextBox.Text)) 'Formatierung mit Währungszeichen
        Else
            EKPreisTextBox.Text = "0,00 €"
        End If
        PriceKalk()
    End Sub

    Sub TM_ChangeVK(ByVal input As String)
        If VKPreisTextBox.Text <> "" Then
            VKPreisTextBox.Text = String.Format("{0:C2}", CDbl(VKPreisTextBox.Text)) 'Formatierung mit Währungszeichen
        Else
            VKPreisTextBox.Text = "0,00 €"
        End If
        PriceKalk()
    End Sub

    Private Sub MaskedTBox_EK_Leave(sender As Object, e As EventArgs) Handles EKPreisTextBox.Leave
        EKPreisTextBox.BeginInvoke(New DelegatePriceChange(AddressOf TM_ChangeEK), EKPreisTextBox.Text)
    End Sub

    Private Sub MaskedTBox_VK_Leave(sender As Object, e As EventArgs) Handles VKPreisTextBox.Leave
        VKPreisTextBox.BeginInvoke(New DelegatePriceChange(AddressOf TM_ChangeVK), VKPreisTextBox.Text)
    End Sub

    Private Sub MaskedTBox_EK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles EKPreisTextBox.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 44
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub MaskedTBox_VK_KeyPress(sender As Object, e As KeyPressEventArgs) Handles VKPreisTextBox.KeyPress
        Select Case Asc(e.KeyChar)
            Case 48 To 57, 8, 44
            Case Else
                e.Handled = True
        End Select
    End Sub

    Private Sub MaskedTBox_Artikelnummer_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles MaskedTextBoxArtikelnummer.MaskInputRejected
        ToolTip1.ToolTipTitle = "falsche Eingabe"
        ToolTip1.Show("nur Zahlen sind zulässig!", MaskedTextBoxArtikelnummer, 3000)
    End Sub
#End Region

#Region "NewTreeView1 Icons entsprechend Ihres Zustandes aktualisieren"
    Private Sub TBox_URL_Artikel_KeyUp(sender As Object, e As KeyEventArgs) Handles URLTextBox.KeyUp
        If Edit_TBox_URL_Artikel = True Then
            ArtikelBindingSource.EndEdit()
            UpdateTreeIcon()
        End If
    End Sub

    Private Sub URLTextBox_TextChanged(sender As Object, e As EventArgs) Handles URLTextBox.TextChanged
        If URLTextBox.Text = "" Then
            NewTreeView1.SelectedNode.ImageIndex = 1
            NewTreeView1.SelectedNode.SelectedImageIndex = 1
        End If
    End Sub

    Sub UpdateTreeIcon()
        Dim row As DataSet1.ArtikelRow = Nothing
        row = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
        If row.URL <> "" Then
            If File.Exists(row.URL) And URLTextBox.Text <> "" Then
                NewTreeView1.SelectedNode.ImageIndex = 2
                NewTreeView1.SelectedNode.SelectedImageIndex = 2
            Else
                NewTreeView1.SelectedNode.ImageIndex = 3
                NewTreeView1.SelectedNode.SelectedImageIndex = 3
            End If
        End If

    End Sub

    Private Sub CheckTBArticle() 'muss nach dem öffnen einer Struktur ausgeführt werden um alle Icons zu aktualisieren
        Dim row As DataSet1.ArtikelRow = Nothing
        For i = 0 To DataSet1.Artikel.Count - 1
            row = DataSet1.Artikel.Rows(i)
            NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(row.ArtikelID, True)(0)
            If row.URL <> "" Then
                If File.Exists(row.URL) = True And URLTextBox.Text <> "" Then
                    NewTreeView1.SelectedNode.ImageIndex = 2
                    NewTreeView1.SelectedNode.SelectedImageIndex = 2
                Else
                    NewTreeView1.SelectedNode.ImageIndex = 3
                    NewTreeView1.SelectedNode.SelectedImageIndex = 3
                End If
            Else
                NewTreeView1.SelectedNode.ImageIndex = 1
                NewTreeView1.SelectedNode.SelectedImageIndex = 1
            End If
        Next
    End Sub

    Private Sub TBox_URL_Artikel_lostfocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles URLTextBox.LostFocus
        Edit_TBox_URL_Artikel = False
    End Sub

    Private Sub TBox_URL_Artikel_MouseClick(sender As Object, e As MouseEventArgs) Handles URLTextBox.MouseClick
        Edit_TBox_URL_Artikel = True
    End Sub
#End Region

#Region "Knotennamen editieren"
    Private Sub UmbenennenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UmbenennenToolStripMenuItem.Click
        If Not (mySelectedNode Is Nothing) Then
            NewTreeView1.SelectedNode = mySelectedNode
            NewTreeView1.LabelEdit = True
            If Not mySelectedNode.IsEditing Then
                mySelectedNode.BeginEdit()
            End If
        End If
    End Sub

    Private Sub AfterLabelEdit(ByVal text As String, ByVal tag As String, ByVal name As String)
        If tag = "manufacturer" Then
            Dim NewHerstellerRow As DataSet1.HerstellerRow
            NewHerstellerRow = DataSet1.Hersteller.FindByHerstellerID(name)
            NewHerstellerRow.Hersteller = text
            ' CBox_Hersteller.Text = text
        End If
        If tag = "product" Then
            Dim NewProduktRow As DataSet1.ProduktRow
            NewProduktRow = DataSet1.Produkt.FindByProduktID(name)
            NewProduktRow.ProduktTyp = text
        End If
    End Sub



    Private Sub NewTreeView1_AfterLabelEdit_1(sender As Object, e As NodeLabelEditEventArgs) Handles NewTreeView1.AfterLabelEdit
        Dim NodeTag As String = NewTreeView1.SelectedNode.Tag
        Dim NodeName As String = NewTreeView1.SelectedNode.Name
        If Not (e.Label Is Nothing) Then
            If e.Label.Length > 0 Then
                If e.Label.IndexOfAny(New Char() {"@"c, "."c, ","c, "!"c}) = -1 Then
                    ' Stop editing without canceling the label change.
                    NewTreeView1.BeginInvoke(New InvokeDelegate(AddressOf AfterLabelEdit), e.Label, NodeTag, NodeName)
                    e.Node.EndEdit(False)
                Else
                    ' Cancel the label edit action, inform the user, and
                    ' place the node in edit mode again. 
                    e.CancelEdit = True
                    MessageBox.Show("Invalid tree node label." & Microsoft.VisualBasic.ControlChars.Cr & "The invalid characters are '@','.', ',', '!'", "Node Label Edit")
                    e.Node.BeginEdit()
                End If
            Else
                ' Cancel the label edit action, inform the user, and
                ' place the node in edit mode again. 
                e.CancelEdit = True
                MessageBox.Show("Invalid tree node label." & Microsoft.VisualBasic.ControlChars.Cr & "The label cannot be blank", "Node Label Edit")
                e.Node.BeginEdit()
            End If
        End If
    End Sub
#End Region

#Region "Vertreterdaten in ComboBox einlesen bzw. editieren"
    Private Sub ListeBearbeitenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ListeBearbeitenToolStripMenuItem.Click
        VT_edit = True
        Form2.Show()
    End Sub

    Private Sub SalesPartner_Click(sender As Object, e As EventArgs) Handles SalesPartner.Click
        VT_edit = True
        Form2.Show()
    End Sub

    Private Sub VertreterComboBox_Click(sender As Object, e As EventArgs) Handles VertreterComboBox.Click
        If VT_edit = True Then
            DataSet2.Vertreter.Clear()
            DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
            VT_edit = False
        End If
    End Sub

    Private Sub TextmarkenDefinierenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TextmarkenDefinierenToolStripMenuItem.Click
        Form3.Show()
    End Sub

    Private Sub TextmarkConfiguration_Click(sender As Object, e As EventArgs) Handles TextmarkConfiguration.Click
        Form3.Show()
    End Sub
#End Region

#Region "Word Textmarken Verknüpfungen erstellen/ändern"
    Private Sub ToolStripButtonUp_Click(sender As Object, e As EventArgs) Handles ToolStripButtonUp.Click
        'Me.DataGridView2.Sort(Me.DataGridView2.Columns(8), System.ComponentModel.ListSortDirection.Ascending)
        'massive Performance Verbesserung ohne sortieren!
        Dim Idx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position).row
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If DataGridView2.CurrentRow.Index > 0 Then
            Dim DRx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position - 1).row
            Dim Index_DRx As Integer
            Dim Index_Idx As Integer
            If Idx.SortRow = DRx.SortRow Then
                If DRx.SortRow >= 1 Then
                    DRx.SortRow = DRx.SortRow - 1
                End If
            End If
            Index_DRx = DRx.SortRow
            Index_Idx = Idx.SortRow
            DRx.SortRow = Index_Idx
            Idx.SortRow = Index_DRx
        End If
    End Sub

    Private Sub ToolStripButtonDown_Click(sender As Object, e As EventArgs) Handles ToolStripButtonDown.Click
        'Me.DataGridView2.Sort(Me.DataGridView2.Columns(8), System.ComponentModel.ListSortDirection.Ascending)
        'massive Performance Verbesserung ohne sortieren!
        Dim Idx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position).row
        DataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        If DataGridView2.CurrentRow.Index < DataGridView2.Rows.Count - 1 Then
            Dim DRx As DataSet1.SpezOptionenRow = FKAngebotSpezOptionenBindingSource.Item(FKAngebotSpezOptionenBindingSource.Position + 1).row
            Dim Index_DRx As Integer
            Dim Index_Idx As Integer
            If Idx.SortRow = DRx.SortRow Then
                If DRx.SortRow >= 1 Then
                    DRx.SortRow = DRx.SortRow + 1
                End If
            End If
            Index_DRx = DRx.SortRow
            Index_Idx = Idx.SortRow
            DRx.SortRow = Index_Idx
            Idx.SortRow = Index_DRx
        End If
    End Sub
#End Region

#Region "word Angebot erstellen"
    Private Sub ErstellenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ErstellenToolStripMenuItem.Click
        GenerateWordOffer()
    End Sub

    Private Sub GenerateOffer_Click(sender As Object, e As EventArgs) Handles GenerateOffer.Click
        GenerateWordOffer()
    End Sub

    Private Sub GenerateWordOffer()
        'ToolStripStatusLabel1.Visible = True
        If TBMStructure = False Then
            MsgBox("Keine Produktstruktur oder Angebot geladen!", vbExclamation)
        Else
            Dim foundVT_row As DataSet2.VertreterRow
            foundVT_row = DataSet2.Vertreter.FindByangezeigterName(VertreterComboBox.Text)
            If foundVT_row IsNot Nothing Then
                Vertreter_e_mail = foundVT_row.e_mail
                Vertreter_Mobilummer = foundVT_row.Telefonnummer
                GenerateWordDocument.Winword_open(Vertreter_e_mail, Vertreter_Mobilummer)
            Else
                MsgBox("Kein Vertreter ausgewählt!", vbExclamation)
            End If
        End If
        ToolStripProgressBar1.Visible = False
    End Sub
#End Region

#Region "Textbaustein aus der Anwendung heraus anzeigen"
    Private Sub AnzeigenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AnzeigenToolStripMenuItem.Click
        Dim ArticleRow As DataSet1.ArtikelRow
        ArticleRow = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
        Dim openFileInfo As String = ArticleRow.URL
        If ArticleRow.URL <> "" Then
            ShowTextModul(openFileInfo)
        End If
    End Sub

    Private Sub ToolStripButton1_Click(sender As Object, e As EventArgs) Handles ToolStripButton1.Click
        Dim ArticleRow As DataSet1.ArtikelRow
        'ArticleRow = DataSet1.Artikel.FindByArtikelID(DataGridView2.CurrentRow.Cells(0).Value)
        ArticleRow = DataSet1.Artikel.FindByArtikelID(NewTreeView1.SelectedNode.Name)
        Dim openFileInfo As String = ArticleRow.URL
        If ArticleRow.URL <> "" Then
            ShowTextModul(openFileInfo)
        End If
    End Sub

    Private Sub ShowTextModul(ModulFilename As String)
        Dim TB_extension As String = (Path.GetExtension(ModulFilename))
        Dim TB_FileName As String = Path.GetFileName(ModulFilename)
        Dim document As String = Microsoft.VisualBasic.Left(TB_FileName, (CInt(Len(TB_FileName)) - CInt(Len(TB_extension))))
        If File.Exists(ModulFilename) Then
            If TB_extension = ".docx" Or TB_extension = ".doc" Then
                GenerateWordDocument.Textbaustein_open_word(ModulFilename)
                'Microsoft.VisualBasic.Interaction.AppActivate(document & ".docx - Word")
            End If
            If TB_extension = ".xlsx" Or TB_extension = ".xls" Or TB_extension = ".xlsm" Then
                GenerateWordDocument.Textbaustein_open_excel(ModulFilename)
                'Microsoft.VisualBasic.Interaction.AppActivate(document & ".xlsx - Excel")
            End If
        End If
    End Sub

    Private Sub VertreterComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles VertreterComboBox.SelectedValueChanged
        If VertreterComboBox.Text <> "" Then
            Dim KDrow As DataSet1.KundeRow
            KDrow = DataSet1.Kunde.FindByKdNummer(KdNummerComboBox.Text)
            KDrow.ZustVertreter = VertreterComboBox.Text
        End If
    End Sub

    Private Sub DokumentenvorlageComboBox_SelectedValueChanged(sender As Object, e As EventArgs) Handles DokumentenvorlageComboBox.SelectedValueChanged
        If DokumentenvorlageComboBox.Text <> "" Then
            Dim KDrow As DataSet1.KundeRow
            KDrow = DataSet1.Kunde.FindByKdNummer(KdNummerComboBox.Text)
            KDrow.DokVorlage = DokumentenvorlageComboBox.Text
        End If
    End Sub



#End Region

    Private Sub ContextMenuStripOfferTitle_Click(sender As Object, e As EventArgs) Handles ContextMenuStripOfferTitle.Click
        AddOfferDialog.TextBoxOfferNumber.Enabled = False
        AddOfferDialog.Text = "Angebotstitel ändern:"
        'AddOfferDialog.ShowDialog.t= "Angebotstitel ändern"
        Dim AngebotRow As DataSet1.AngebotRow
        AngebotRow = DataSet1.Angebot.FindByAngebotsID(DataGridView1.CurrentRow.Cells(0).Value)
        AddOfferDialog.TextBoxOfferTitle.Text = AngebotRow.Angebotstitel
        If AddOfferDialog.ShowDialog = DialogResult.OK Then
            AngebotRow.Angebotstitel = AddOfferDialog.TextBoxOfferTitle.Text
        Else
            MsgBox("Es wird nichts umbenannt!", vbExclamation)
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ComboBox1.Visible = True
        Button1.Enabled = False
    End Sub

    Private Sub InfoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles InfoToolStripMenuItem.Click
        Dim InfoForm As New Form4()
        InfoForm.ShowDialog(Me)
    End Sub

    'nur Hilfsfunktion - wird wieder entfernt
    Private Sub AGToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AGToolStripMenuItem.Click
        Dim ArticleRow As DataSet1.ArtikelRow
        For Each ArticleRow In DataSet1.Artikel.Rows
            ArticleRow.AGSelected = True
        Next
    End Sub

    Private Sub KdNummerComboBox_TextChanged(sender As Object, e As EventArgs) Handles KdNummerComboBox.TextChanged
        Vertreter_akt()
    End Sub

    'Ende der Hilfsfunktion


End Class

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

#Region "Programm und UserInterface initialisieren"
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml") Then
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Vertreter.xml", "")
        End If
        If Not File.Exists(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini") Then
            File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini", "")
        End If
        With DataGridView2.ColumnHeadersDefaultCellStyle
            '.BackColor = Color.Navy
            '.ForeColor = Color.White
            .Font = New Font(DataGridView2.Font, FontStyle.Regular)
        End With
        With DataGridView2.RowsDefaultCellStyle
            .Font = New Font(DataGridView2.Font, FontStyle.Regular)
        End With
        CenterAlignTitel()
    End Sub

    Sub InitHMI()
        VT_edit = True
        'Form2.DataSet2.Vertreter.ReadXml(VT_DataFile.FullName)
        With DataGridView2
            .RowsDefaultCellStyle.BackColor = Color.Bisque
            .AlternatingRowsDefaultCellStyle.BackColor = Color.Beige
        End With
        'Vorlagen Dokumente in Combobox laden
        Dim OrtEigeneDateien As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        Dim Dir As New DirectoryInfo(OrtEigeneDateien & "\Benutzerdefinierte Office-Vorlagen\")
        DokumentenvorlageComboBox.Items.Clear()
        For Each file As FileInfo In Dir.GetFiles
            If Microsoft.VisualBasic.Left(file.Name, 1) <> "~" Then
                DokumentenvorlageComboBox.Items.Add(file.Name)
            End If
        Next
        'TreeView_actualize()
        ' GroupBox2.Text = "Artikel (" & DataSet1.Artikel.Rows.Count & ")" 'Anzahl Artikel
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
        EndProgram()
    End Sub

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        EndProgram()
    End Sub

    Sub EndProgram()
        If TBMStructure = True Then
            If Dateiname_tree = "" Then
                Select Case MessageBox.Show("Die Produktstruktur ist noch nicht gespeichert!" _
                             & vbCrLf & "Wollen Sie wirklich beenden ohne zu speichern?" _
                             & vbCrLf & "Alle Daten gehen verloren!", "ohne speichern fortsetzen?", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
                    Case DialogResult.Yes
                        'beenden ohne zu sichern
                    Case DialogResult.No
                        Save_product_structure_under()
                End Select
            Else
                Save_product_structure()
            End If
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
            Dim prompt As String = String.Empty
            Dim title As String = String.Empty
            Dim defaultResponse As String = String.Empty
            Dim answer As Object
            prompt = "Angebotsnummer: "
            title = "Neue Angebotsnummer eingeben"
            defaultResponse = "wmXXX-XX"
            answer = InputBox(prompt, title, defaultResponse)
            If answer IsNot "" Then
                Dim NewAGRow As DataSet1.AngebotRow = Nothing
                NewAGRow = DataSet1.Angebot.NewAngebotRow
                NewAGRow.AngebotID = answer
                NewAGRow.Kundennummer = KdNummerComboBox.Text
                NewAGRow.AngebotURL = "noch nicht definiert"
                DataSet1.Angebot.Rows.Add(NewAGRow)
            End If
        Catch ex As Exception
            MsgBox("Diese Angebotsnummer ist bereits vorhanden!", vbExclamation)
        End Try
    End Sub

    Private Sub DelOffer_Click(sender As Object, e As EventArgs) Handles DelOffer.Click
        Dim AngRow As DataSet1.AngebotRow
        AngRow = DataSet1.Angebot.FindByAngebotID(KdNummerComboBox.Text)
        Select Case MessageBox.Show("Wollen Sie das Angebot wirklich löschen?", "Angebot löschen", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                AngRow.Delete()
            Case DialogResult.No
                MsgBox("Löschen abgebrochen", vbExclamation)
        End Select
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

                    NewARow.ProduktID = ProduktTypComboBox.SelectedValue 'Verknüpfung zum Produkt erstellen
                    DataSet1.Artikel.Rows.Add(NewARow)
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
                            ARowEdit.Delete()
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

    Private Sub ProduktsrukturÖffnenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProduktsrukturÖffnenToolStripMenuItem.Click
        Open_product_structure()
    End Sub

    Private Sub SpeichernToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SpeichernToolStripMenuItem.Click
        If TBMStructure = True Then
            Save_product_structure()
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

    Private Sub Save_product_structure()
        If TBMStructure = True Then
            If Dateiname_tree <> "" Then
                Dim _DataTree As New FileInfo(Dateiname_tree)
                XMLp.exportTreeViewXML(NewTreeView1, _DataTree.FullName)
                Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data_" & Path.GetFileNameWithoutExtension(Dateiname_tree) & ".xml")
                'Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data.xml")
                DataSet1.WriteXml(_DataFile.FullName)
                Me.Text = Path.GetFileName(Dateiname_tree) & " - TeBaM"
                CenterAlignTitel()
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
            Save_product_structure()
            TBMStructure = True
        End If
    End Sub

    Private Sub Open_product_structure()
        If TBMStructure = False Then
            Dim openFileDialog1 As New OpenFileDialog()
            openFileDialog1.Filter = "Cursor Files|*.xml"
            openFileDialog1.Title = "Bitte eine Produktstruktur auswählen"
            If TBMStructure = True Then Save_product_structure() ' bestehende Produktstruktur abspeichern!
            If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dateiname_tree = openFileDialog1.FileName
                Dim _DataTree As New FileInfo(Dateiname_tree)
                Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data_" & Path.GetFileNameWithoutExtension(Dateiname_tree) & ".xml")
                'Dim _DataFile As New FileInfo(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\Data.xml")
                If Not _DataFile.Exists Then Return
                NewTreeView1.Nodes.Clear()
                DataSet1.ReadXml(_DataFile.FullName)
                XMLp.importTreeViewXML(NewTreeView1, _DataTree.FullName)
                If NewTreeView1.Nodes.Count > 0 Then
                    InitHMI()
                    TBMStructure = True
                End If
                CenterAlignTitel()
            End If
        Else
            Save_product_structure()
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

        Dim startingPoint As Double = (Me.Width / 2) - (g.MeasureString(Titel.Trim, Me.Font).Width / 2)
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

#Region "Texbox Formatierungen erstellen"
    Delegate Sub DelegatePriceChange(ByVal textvalue As String)

    Sub TM_ChangeEK(ByVal input As String)
        If EKPreisTextBox.Text <> "" Then
            EKPreisTextBox.Text = String.Format("{0:C2}", CDbl(EKPreisTextBox.Text)) 'Formatierung mit Währungszeichen
        Else
            EKPreisTextBox.Text = "0,00 €"
        End If
    End Sub

    Sub TM_ChangeVK(ByVal input As String)
        If VKPreisTextBox.Text <> "" Then
            VKPreisTextBox.Text = String.Format("{0:C2}", CDbl(VKPreisTextBox.Text)) 'Formatierung mit Währungszeichen
        Else
            VKPreisTextBox.Text = "0,00 €"
        End If
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
    Private Sub TBox_URL_Artikel_KeyUp(sender As Object, e As KeyEventArgs) Handles TBox_URL_Artikel.KeyUp
        If Edit_TBox_URL_Artikel = True Then
            ArtikelBindingSource.EndEdit()
            UpdateTreeIcon()
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
        Else
            NewTreeView1.SelectedNode.ImageIndex = 1
            NewTreeView1.SelectedNode.SelectedImageIndex = 1
        End If

    End Sub

    Private Sub CheckTBArticle() 'muss nach dem öffnen einer Struktur ausgeführt werden um alle Icons zu aktualisieren
        Dim row As DataSet1.ArtikelRow = Nothing
        For i = 0 To DataSet1.Artikel.Count - 1
            row = DataSet1.Artikel.Rows(i)
            NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(row.ArtikelID, True)(0)
            If row.URL <> "" Then
                If File.Exists(row.URL) And URLTextBox.Text <> "" Then
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

        ' If NewTreeView1.SelectedNode.Tag = "product" Then CBox_Produkt.Text = NewTreeView1.SelectedNode.Text
        'TBox_NodeText.Text = NewTreeView1.SelectedNode.Text
        'TBox_NodeName.Text = NewTreeView1.SelectedNode.Name
        'TBox_NodeTag.Text = NewTreeView1.SelectedNode.Tag
        'TBox_NodeImageIndex.Text = CStr(NewTreeView1.SelectedNode.ImageIndex)
        'TBox_NodeSelImageIndex.Text = CStr(NewTreeView1.SelectedNode.SelectedImageIndex)
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
        'Beim Click auf NewTreeView1 Zeile im Datagrid 5 selektieren
        For i As Integer = 0 To DataGridView2.Rows.Count - 1
            If DataGridView2.Rows(i).Cells(1).Value.ToString = NewTreeView1.SelectedNode.Name.ToString() Then
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
        If DataGridView2.Rows.Count > 0 Then
            Dim ArtikelID As String = ""
            Dim node As TreeNode = Nothing
            ArtikelID = DataGridView2.CurrentRow.Cells(1).Value
            If TBMStructure = True And ArtikelID <> "" Then
                NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(ArtikelID, True)(0)
                NewTreeView1.Select()
                NewTreeView1.SelectedNode.Expand()
            End If
        End If
    End Sub

    Private Sub HerstellerComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles HerstellerComboBox.DropDownClosed
        NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(ProduktTypComboBox.SelectedValue, True)(0)
        NewTreeView1.Select()
        NewTreeView1.SelectedNode.Expand()
        'Me.DataGridView2.Sort(Me.DataGridView2.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub

    Private Sub ProduktTypComboBox_DropDownClosed(sender As Object, e As EventArgs) Handles ProduktTypComboBox.DropDownClosed
        NewTreeView1.SelectedNode = NewTreeView1.Nodes.Find(HerstellerComboBox.SelectedValue, True)(0)
        NewTreeView1.Select()
        NewTreeView1.SelectedNode.Expand()
        ' Me.DataGridView2.Sort(Me.DataGridView2.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
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

End Class

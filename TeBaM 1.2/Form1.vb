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
        GroupBox2.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
        Dim tn As TreeNode = NewTreeView1.Nodes(0)
        NewTreeView1.SelectedNode = tn
        NewTreeView1.Select()
        NewTreeView1.Focus()
        'Me.DataGridView5.Sort(Me.DataGridView5.Columns(7), System.ComponentModel.ListSortDirection.Ascending)
    End Sub
#End Region

#Region "Programm beenden"

    Private Sub Form1_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
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
    Private Sub DelCustomer_Click(sender As Object, e As EventArgs) Handles DelCustomer.Click
        Dim KRow As DataSet1.KundeRow = Nothing
        KRow = DataSet1.Kunde.FindByKdNummer(KdNummerComboBox.Text)
        Select Case MessageBox.Show("Wollen Sie den Kunden wirklich löschen?", "Kunde löschen", MessageBoxButtons.YesNo)
            Case DialogResult.Yes
                KRow.Delete()
            Case DialogResult.No
                MsgBox("Löschen abgebrochen", vbExclamation)
        End Select
        GroupBox2.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
    End Sub

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
            GroupBox2.Text = "Kunde (" & DataSet1.Kunde.Rows.Count & ")" 'Anzahl Kunden
        Catch ex As Exception
            MsgBox("Diese Kundennummer ist bereits vorhanden!", vbExclamation)
        End Try
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




End Class

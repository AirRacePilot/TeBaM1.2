'Author: Sebastian Gross
'Web: www.bigbasti.com
'Blog: blog.bigbasti.com
'E-mail: kontakt@bigbasti.com

'XMLParser Version 1.1

'LIZENZ: Sie können diesen Code gerne in Ihren eigenen Projekten verwenden
'sowie modifizieren und weiterentwickeln. Gerne können Sie mir auch Wünsche,
'Änderungen üder Fehler mailen.

'Ich würde mich freuen wenn Sie mir eine Kurze mail schreiben, und Ihr Projekt
'beschreiben in dem Sie diesen Code verwenden. Ich würde dann einen Back-Link
'auf meiner Homepage zu ihrem Projekt erstellen!

'Für weitere Tipps & Tricks sowie Beispiele besuchen Sie meine o.g. Homepage.

#Region "Changelog"
'Changelog:
'------------------------------------------------------------------------------
'v. 1.1 01.09.2009
'------------------------------------------------------------------------------
'* Funktionen zum exportieren & importieren von TreeViews hinzugefügt
'* Funktions-beschreibungen hinzugefügt
'* Regionen hinzugefügt
'* FIX: Die XMLNode Namen werden nun richtig gespeichert und gelesen
'* Funktionsbeschreibungen hinzugefügt
'------------------------------------------------------------------------------
'v. 1.0 21.08.2009
'------------------------------------------------------------------------------
#End Region

Imports System.IO
Imports System.Xml

Public Class XMLParser
    'Klassenvariablen
    '---
    Dim writer As XmlWriter
    Dim retNode As TreeNode
    Dim retTree As TreeView
    Dim xmlDoc As New XmlDocument
    '---

    Public Sub New()
        'Konstruktor wird nicht benötigt
    End Sub

    ''' <summary>
    ''' Diese Funktion geht rekursiv durch alle Einträge der TreeNode
    ''' </summary>
    ''' <param name="startNode">Der TreeNode, in dem nach Weiteren Nodes gescht werden soll</param>
    Private Sub writeNewTreeNode(ByVal startNode As TreeNode)
        For Each tn As TreeNode In startNode.Nodes
            If tn.Nodes.Count < 1 Then
                'Wenn tn ein End-element ist, also keine Unterelemente hat
                'Neues Element erstellen
                If tn.Text = "" Then tn.Text = "ohne Namen!"
                writer.WriteStartElement(XmlConvert.EncodeName(tn.Text))
                'Weitere Attribute anhängen
                writer.WriteAttributeString("ProduktID", tn.Name)
                writer.WriteAttributeString("ArtikelID", tn.Tag)
                writer.WriteAttributeString("ImageIndex", tn.ImageIndex)
                writer.WriteAttributeString("SelImageIndex", tn.SelectedImageIndex)
                '---
                'writer.WriteAttributeString("MeinAttribut", "Wert")
                'Die bezeichnung der node einfügen
                'writer.WriteString(tn.Text)
                '---
                'Element schließen
                writer.WriteEndElement()
            Else
                'Wenn tn ein Node mit unternodes ist
                'Neues Element erstellen
                writer.WriteStartElement(XmlConvert.EncodeName(tn.Text))
                writer.WriteAttributeString("ProduktID", tn.Name)
                writer.WriteAttributeString("ArtikelID", tn.Tag)
                writer.WriteAttributeString("ImageIndex", tn.ImageIndex)
                writer.WriteAttributeString("SelImageIndex", tn.SelectedImageIndex)
                writeNewTreeNode(tn)
                'Element schließen
                writer.WriteEndElement()
            End If
        Next
    End Sub

    ''' <summary>
    ''' Diese Funktion Liest eine XML-Datei ein und wandelt diese in ein TreeNode um
    ''' </summary>
    ''' <param name="path">Der Pfad zu der XML-Datei, die in eine TreeNode eingelesen werden soll.</param>
    Public Function importTreeNodeXML(ByVal path As String) As TreeNode
        'Try
        If File.Exists(path) Then
            xmlDoc.Load(path)
            Try
                'Lädt man ein altes Default.xml wird es einen Fehler geben
                retNode = New TreeNode(XmlConvert.DecodeName(xmlDoc.ChildNodes(1).Name))
            Catch ex As Exception
                'Wegen abwärtskompabilität:
                retNode = New TreeNode(XmlConvert.DecodeName(xmlDoc.FirstChild.Name))
            End Try
            readNewTreeNode(retNode.Nodes, xmlDoc.DocumentElement)
        End If
        'Catch ex As Exception
        'MessageBox.Show(ex.Message, "XMLParser Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        'End Try
        Return retNode
    End Function

    ''' <summary>
    ''' Diese Funktion geht rekursiv durch alle Einträge der XML-Datei
    ''' </summary>
    ''' <param name="node">Der Treenode an den die Ausgelesenenen XML-Nodes gehängst werden sollen</param>
    ''' <param name="xmln">Die XML-Node aus der die Unterbereiche ausgelesen werden sollen</param>
    Private Function readNewTreeNode(ByVal node As TreeNodeCollection, ByVal xmln As XmlNode) As TreeNode
        Dim nn As TreeNode = Nothing
        For Each xn As XmlNode In xmln.ChildNodes
            If xn.Name.Equals("#text") Then
                nn = node.Add(XmlConvert.DecodeName(xn.Value))
            Else
                nn = node.Add(XmlConvert.DecodeName(xn.Name))
            End If
            readNewTreeNode(nn.Nodes, xn)
            Try
                nn.Name = xn.Attributes("ProduktID").Value()
                nn.Tag = xn.Attributes("ArtikelID").Value()
                nn.ImageIndex = xn.Attributes("ImageIndex").Value()
                nn.SelectedImageIndex = xn.Attributes("SelImageIndex").Value()
            Catch ex As Exception
                ' keine Fehlermeldung eingegeben
            End Try
        Next
        Return nn
    End Function

#Region "exportTreeView"
    ''' <summary>
    ''' Diese Funktion speichert die Angegebene TreeView im XML Format ab
    ''' </summary>
    ''' <param name="trv">Die TreeView, die als XML Datei exportiert werden soll</param>
    ''' <param name="path">Der Pfad, unter dem die XML-Datei gespeichert werden soll</param>
    Public Sub exportTreeViewXML(ByVal trv As TreeView, ByVal path As String)
        'Prüfen, ob Zieldatei bereits exestiert, wenn ja Löschen
        If File.Exists(path) Then File.Delete(path)
        Dim settings As New XmlWriterSettings()
        settings.Indent = True
        settings.CheckCharacters = False
        settings.ConformanceLevel = ConformanceLevel.Auto
        'Die gewünschte Datei neu erstellen
        writer = XmlWriter.Create(path, settings)

        'Da man in einem XML Dokument nicht mehrere Root-Elemente haben kann, 
        'eine Treeview aber mehrere enthalten kann müssen wir eine neue Node
        'um die anderen packen, die man beim einlesen wieder entfernen muss
        Dim myNode As TreeNode = New TreeNode("rootNode")
        For Each n As TreeNode In trv.Nodes
            myNode.Nodes.Add(n.Clone)
        Next
        writer.WriteStartDocument()
        With writer
            .WriteStartElement(XmlConvert.EncodeName(myNode.Text))
            writeNewTreeNode(myNode)
            .WriteEndElement()
        End With
        writer.WriteEndDocument()
        writer.Close()
    End Sub

    ''' <summary>
    ''' Diese Funktion lädt eine TreeView aus einer XML-Datei.
    ''' </summary>
    ''' <param name="trv">Die TreeView, in die die XML-Datei importiert werden soll</param>
    ''' <param name="path">Der Pfad, unter dem die XML-Datei gespeichert ist</param>
    Public Sub importTreeViewXML(ByVal trv As TreeView, ByVal path As String)
        If File.Exists(path) Then
            xmlDoc.Load(path)
            Try
                'Lädt man ein altes Default.xml wird es einen Fehler geben
                retNode = New TreeNode(XmlConvert.DecodeName(xmlDoc.ChildNodes(1).Name))
            Catch ex As Exception
                'Wegen abwärtskompabilität:
                retNode = New TreeNode(XmlConvert.DecodeName(xmlDoc.FirstChild.Name))
            End Try
            readNewTreeNode(retNode.Nodes, xmlDoc.DocumentElement)
            For Each n As TreeNode In retNode.Nodes
                trv.Nodes.Add(n)
            Next
        End If
    End Sub
#End Region

End Class

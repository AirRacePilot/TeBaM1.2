Imports System.IO
Imports System.Xml

Public Class XML_Offer_read_write
    Dim root As XmlNode = Nothing
    Dim node As XmlNode = Nothing
    Dim num As Integer = 0

#Region "XML-Datei Angebotskonfiguration speichern"
    Public Sub Save_offer_xml(ByVal sDataFile As String)
        If Form1.NewTreeView1.Nodes IsNot Nothing Then
            Form1.Cursor = Cursors.WaitCursor
            Dim xmlDoc As New XmlDocument()
            root = xmlDoc.CreateElement(XMLText(Form1.NewTreeView1.Nodes(0).Text)) 'Hier muss der gleich Name wie im Treeview root Knoten stehen!
            xmlDoc.AppendChild(root)
            node = xmlDoc.CreateElement("Firmenadresse")
            root.AppendChild(node)
            TV1_TraverseCollectionOut(Form1.NewTreeView1.Nodes, xmlDoc)
            xmlDoc.Save(sDataFile)
            num = 0
            Form1.Cursor = Cursors.Default
        End If
    End Sub

    Private Sub TV1_TraverseCollectionOut(nodes As TreeNodeCollection, xmldoc As XmlDocument)
        Dim node As XmlNode = Nothing
        For Each nd As TreeNode In nodes
            If nd.Checked = True Then
                node = xmldoc.CreateElement("Textbausteine")
                root.AppendChild(node)
                node.AppendChild(xmldoc.CreateElement("Product_ID_" & CStr(num))).InnerText = XMLText(nd.Name)
                node.AppendChild(xmldoc.CreateElement("Articel_ID_" & CStr(num))).InnerText = XMLText(nd.Tag)
                node.AppendChild(xmldoc.CreateElement("AG_selected_" & CStr(num))).InnerText = 1
                num = num + 1
            End If
            TV1_TraverseCollectionOut(nd.Nodes, xmldoc)
        Next
    End Sub

    Function XMLText(Text As String) As String
        XMLText = Replace(Text, " ", "xx_leer_xx")
        XMLText = Replace(Text, "#", "xx_Nummer_xx")
    End Function
#End Region

#Region "XML-Datei Angebotskonfiguration öffnen"
    Public Sub Load_offer_xml(ByVal SDataFile As String)
        Form1.NewTreeView1.CollapseAll()
        Dim xmlDoc As New XmlDocument()
        Dim num As Integer = 0
        Dim Treeview_root_node As String = ""
        xmlDoc.Load(SDataFile)
        root = xmlDoc.DocumentElement
        Dim node As XmlNode = Nothing
        Dim DocTag As String
        For Each node In xmlDoc.SelectNodes("/" & root.Name & "/Textbausteine") 'Angebot einlesen
            DocTag = xmlDoc.SelectSingleNode("/" & root.Name & "/Textbausteine/TB_Tag_" & CStr(num)).InnerText
            Dim Nodes As TreeNode() = Form1.NewTreeView1.Nodes.Find(xmlDoc.SelectSingleNode("/" & root.Name & "/Textbausteine/TB_Index_" & CStr(num)).InnerText, True)
            Dim node_find As TreeNode = Nothing
            For Each node_find In Nodes
                If node_find.Name <> "Produktknoten" Then
                    If DocTag = node_find.Tag Then
                        'node_find.Checked = True
                        Form1.NewTreeView1.SelectedNode = node_find
                        Form1.NewTreeView1.SelectedNode.Checked = True
                    End If
                End If
            Next
            num = num + 1
        Next
    End Sub
#End Region




End Class

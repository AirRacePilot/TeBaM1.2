Imports System.IO
Imports Microsoft.Office.Interop


Public Class GenerateWordDocument
    Shared oWord As Word.Application
    Shared oExcel As New Excel.Application
    Shared oDoc As Word.Document


#Region "Angebot in Microsoft Word erstellen"
    Shared Sub Winword_open(ByVal Email As String, ByVal Telefon As String)
        Dim ArticleRow As DataSet1.ArtikelRow
        Dim TSPB_Step As Integer = (85 / (Form1.DataGridView2.Rows.Count - 1))
        Dim OrtEigeneDateien As String = Environment.GetFolderPath(Environment.SpecialFolder.Personal)
        Dim extension As String
        Dim druckbereich As String
        Dim Document_URL As String

        If Form1.DokumentenvorlageComboBox.Text <> "" Then 'wenn keine Dokumentenvorlage ausgewähl ist wird sofort unerbrochen!
            Form1.Cursor = Cursors.WaitCursor
            If Form1.DataGridView2.Rows.Count > 1 Then
                Form1.ToolStripProgressBar1.Value = 10
                oWord = CreateObject("Word.Application")
                oWord.Visible = False
                oExcel.Application.DisplayAlerts = False
                oWord.Documents.Add(OrtEigeneDateien & "\Benutzerdefinierte Office-Vorlagen\" & Form1.DokumentenvorlageComboBox.Text)
                For i = 0 To Form1.DataGridView2.Rows.Count - 1
                    If Form1.ToolStripProgressBar1.Value + TSPB_Step < 100 Then
                        Form1.ToolStripProgressBar1.Value = Form1.ToolStripProgressBar1.Value + TSPB_Step
                    Else
                        Form1.ToolStripProgressBar1.Value = 100
                    End If

                    ArticleRow = Form1.DataSet1.Artikel.FindByArtikelID(Form1.DataGridView2.Rows(i).Cells(0).Value)
                    Document_URL = ArticleRow.URL

                    If File.Exists(Document_URL) Then
                        extension = Path.GetExtension(Document_URL)
                        If extension = ".xls" Or extension = ".xlsx" Then
                            oExcel.Workbooks.Open(Document_URL)
                            oExcel.ActiveWorkbook.ActiveSheet.select
                            druckbereich = oExcel.ActiveSheet.PageSetup.printArea
                            oExcel.ActiveSheet.range(druckbereich).copy
                            oWord.Selection.PasteExcelTable(False, False, False)
                            'Clipboard.Clear()
                            oExcel.ActiveWorkbook.Close(False, Document_URL)
                            oExcel.Quit()
                            oWord.Selection.InsertBreak()
                        End If
                        If extension = ".doc" Or extension = ".docx" Then
                            oWord.Selection.InsertFile(FileName:=Document_URL, Range:="", ConfirmConversions:=False, Link:=False, Attachment:=False)
                            oWord.Selection.EndKey(Unit:=Word.WdUnits.wdStory, Extend:=Word.WdMovementType.wdExtend)
                            oWord.Selection.Delete(Unit:=Word.WdUnits.wdCharacter, Count:=1)
                        End If
                    Else
                        oWord.Selection.Font.Size = 14
                        oWord.Selection.Font.Bold = True
                        oWord.Selection.Text = vbCrLf & "Textbaustein " & Document_URL & " fehlt!" & vbCrLf & vbCrLf
                        oWord.Selection.EndKey(Word.WdUnits.wdStory)
                    End If
                Next
            End If
            Dim TSPB_value = Form1.ToolStripProgressBar1.Value
            Fill_bookmarks(Email, Telefon, TSPB_value)
            oWord.Visible = True
            oWord.Activate()
            Form1.ToolStripProgressBar1.Visible = False
            'Form1.ToolStripStatusLabel1.Visible = False
        Else
            MsgBox("Sie haben keine Dokumentenvorlage ausgewählt!", vbExclamation)
        End If
        Form1.Cursor = Cursors.Default
    End Sub

    Shared Sub Fill_bookmarks(ByVal Email As String, ByVal Telefon As String, TSPBValue As Integer)
        Dim Angebotsnummer As String = Form1.DataGridView1.CurrentRow.Cells(0).Value
        Dim UserInputString As String = ""
        Dim Input_Variable As String
        Dim BookMark As String = ""
        Form1.ToolStripProgressBar1.Value = TSPBValue
        Form3.ListBox1.Items.Clear()
        For Each row As String In IO.File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini")
            Form3.ListBox1.Items.Add(row)
        Next
        Dim TSPB_Step As Integer = (5 / (Form3.ListBox1.Items.Count))
        For n = 0 To Form3.ListBox1.Items.Count - 1
            If Form1.ToolStripProgressBar1.Value + TSPB_Step < 100 Then
                Form1.ToolStripProgressBar1.Value = Form1.ToolStripProgressBar1.Value + TSPB_Step
            Else
                Form1.ToolStripProgressBar1.Value = 100
            End If
            Dim splitstring = Form3.ListBox1.Items(n)
            Dim split_array() As String = splitstring.Split(" = ")
            Input_Variable = split_array(0)
            BookMark = split_array(2)
            Select Case Input_Variable
                Case "Firma1"
                    UserInputString = Form1.Firma1TextBox.Text
                Case "Firma2"
                    UserInputString = Form1.Firma2TextBox.Text
                Case "Ansprechpartner1"
                    UserInputString = Form1.Name1TextBox.Text
                Case "Anrede_Herr_Frau1"
                    UserInputString = Form1.Name1TextBox.Text
                    If UserInputString <> "" Then
                        Dim sSplit() As String
                        sSplit = UserInputString.Split(CChar(" "))
                        If sSplit(0) = "Frau" Then
                            UserInputString = "Sehr geehrte " & Form1.Name1TextBox.Text
                        Else
                            UserInputString = "Sehr geehrter " & Form1.Name1TextBox.Text
                        End If
                    End If
                Case "Ansprechpartner2"
                    UserInputString = Form1.Name2TextBox.Text
                Case "Anrede_Herr_Frau2"
                    UserInputString = Form1.Name2TextBox.Text
                    If UserInputString <> "" Then
                        Dim sSplit() As String
                        sSplit = UserInputString.Split(CChar(" "))
                        If sSplit(0) = "Frau" Then
                            UserInputString = "Sehr geehrte " & Form1.Name2TextBox.Text
                        Else
                            UserInputString = "Sehr geehrter " & Form1.Name2TextBox.Text
                        End If
                    End If
                Case "Strasse"
                    UserInputString = Form1.StrasseTextBox.Text
                Case "Postleitzahl"
                    UserInputString = Form1.PLZTextBox.Text
                Case "Ort"
                    UserInputString = Form1.OrtTextBox.Text
                Case "Angebotstitel"
                    UserInputString = Form1.DataGridView1.CurrentRow.Cells(1).ToString
                Case "Angebotsnummer"
                    UserInputString = Form1.DataGridView1.CurrentRow.Cells(0).ToString
                Case "Vertreter"
                    UserInputString = Form1.VertreterComboBox.Text
                Case "Mobiltelefon"
                    UserInputString = Telefon
                Case "E-Mail"
                    UserInputString = Email
            End Select
            Insert_bookmark(BookMark, UserInputString)
        Next
    End Sub
#End Region

#Region "Textbaustein in word oder excel anzeigen"
    Shared Sub Insert_bookmark(ByVal Bookmark As String, ByVal UserInputString As String)
        If oWord.ActiveDocument.Bookmarks.Exists(Bookmark) = True Then oWord.ActiveDocument.Bookmarks(Bookmark).Range.Text = UserInputString
    End Sub

    Shared Sub Textbaustein_open_word(ByVal Document As String)
        Try
            oWord = CreateObject("Word.Application")
            With oWord
                .Application.Documents.Open(FileName:=Document, ReadOnly:=False)
                .Visible = True
                .Application.Activate()
                .ActiveDocument.Windows.Application.WindowState = Word.WdWindowState.wdWindowStateMaximize
                .Activate()
            End With
        Catch ex As Exception
            MsgBox("Microsoft Word ist nicht auf diesem Computer nicht installiert", vbExclamation)
        End Try
    End Sub

    Shared Sub Textbaustein_open_excel(ByVal Document As String)
        Try
            oExcel = CreateObject("Excel.Application")
            With oExcel
                .Workbooks.Open(Filename:=Document, ReadOnly:=False)
                .Visible = True
                '.ActiveWindow.Application.WindowState = Excel.XlWindowState.xlMaximized
                '.Activate()
            End With
        Catch ex As Exception
            MsgBox("Microsoft Excel ist nicht auf diesem Computer nicht installiert", vbExclamation)
        End Try
    End Sub
#End Region

End Class

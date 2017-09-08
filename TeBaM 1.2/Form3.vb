Option Explicit On
Imports System.IO

Public Class Form3
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ListBox1.Items.Clear()
        For Each row As String In IO.File.ReadAllLines(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini")
            ListBox1.Items.Add(row)
        Next
    End Sub

    Private Sub Form3_FormClosed(sender As Object, e As FormClosedEventArgs) Handles Me.FormClosed
        Dim text As String = ""
        For Each zeile_item As String In ListBox1.Items
            If zeile_item <> "" Then
                text &= zeile_item & vbCrLf
            End If
        Next
        IO.File.WriteAllText(My.Computer.FileSystem.SpecialDirectories.CurrentUserApplicationData & "\TextBausteinManager.ini", text)
    End Sub

    Private Sub Btn_addBookmark_Click(sender As Object, e As EventArgs) Handles Btn_addBookmark.Click
        If TextBox1.Text <> "" Then
            ListBox1.Items.Add(CB_iput.Text & " = " & TextBox1.Text)
        Else
            MsgBox("Sie haben kein Bookmark angegeben!", vbExclamation)
        End If
    End Sub

    Private Sub Btn_del_Click(sender As Object, e As EventArgs) Handles Btn_del.Click
        ListBox1.Items.Remove(ListBox1.SelectedItem)
    End Sub

    Private Sub Btn_up_Click(sender As Object, e As EventArgs) Handles Btn_up.Click
        Dim index As Integer = ListBox1.SelectedIndex
        If index > 0 Then
            Dim oTemp As Object = ListBox1.SelectedItem
            ListBox1.Items.RemoveAt(index)
            ListBox1.Items.Insert(index - 1, oTemp)
            ListBox1.SelectedIndex = index - 1
        End If
    End Sub

    Private Sub Btn_down_Click(sender As Object, e As EventArgs) Handles Btn_down.Click
        Dim index As Integer = ListBox1.SelectedIndex
        If index < ListBox1.Items.Count - 1 Then
            Dim oTemp As Object = ListBox1.SelectedItem
            ListBox1.Items.RemoveAt(index)
            ListBox1.Items.Insert(index + 1, oTemp)
            ListBox1.SelectedIndex = index + 1
        End If
    End Sub


End Class
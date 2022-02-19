'Nsme
'Details
Imports System.IO
Public Class Form1
    ' Variable declaration

    Dim input As String
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        ' Add the data in the  textbox into the list box

        input = txtlpNum.Text & " " + txtOwnname.Text & " " & txtOwnphoNo.Text

        If (input <> "") Then

            listData.Items.Add(input)

        End If

        listData.Sorted = True
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        ' Delete  selected item(s) from a list box

        If (listData.SelectedIndex > 0) Then

            listData.Items.Remove(listData.SelectedItem.ToString)
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        ' Reading  list box data and writing it into text file

        Dim s As String

        Using sw As StreamWriter = New StreamWriter("DMVDatabase.txt")

            For Each s In listData.Items

                sw.WriteLine(s)

            Next s

        End Using

        MsgBox("Data saved into file!")
    End Sub

    Private Sub btnLoad_Click(sender As Object, e As EventArgs) Handles btnLoad.Click
        ' Clear the list box

        listData.Items.Clear()

        ' Read  data from text file and writing it into list box

        Using sr As StreamReader = New StreamReader("DMVDatabase.txt")

            Dim line As String

            ' Read and lines from the file

            line = sr.ReadLine()

            While (line <> Nothing)

                listData.Items.Add(line)

                line = sr.ReadLine()

            End While

        End Using
    End Sub
End Class

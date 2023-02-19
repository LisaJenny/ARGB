Imports System.IO
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MyDialog As New ColorDialog()
        ' Keeps the user from selecting a custom color.
        MyDialog.AllowFullOpen = True
        ' Allows the user to get help. (The default is false.)
        MyDialog.ShowHelp = True
        ' Sets the initial color select to the current text color,
        MyDialog.Color = Color.AliceBlue

        ' Update the text box color if the user clicks OK 
        If (MyDialog.ShowDialog() = Windows.Forms.DialogResult.OK) Then
            ComboBoxRGBITEMS.Items.Add(MyDialog.Color.ToString())
            ComboBoxName_HEX.Items.Add(MyDialog.Color.Name.ToString())
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim myStream As Stream
        Dim saveFileDialog1 As New SaveFileDialog()
        saveFileDialog1.InitialDirectory = "f:\color\"
        saveFileDialog1.Filter = "Color files (*.col)|*.col"
        saveFileDialog1.FilterIndex = 2
        saveFileDialog1.RestoreDirectory = True
        saveFileDialog1.FileName = ComboBoxName_HEX.Text.ToString()
        If saveFileDialog1.ShowDialog() = DialogResult.OK Then
            myStream = saveFileDialog1.OpenFile()
            If (myStream IsNot Nothing) Then
                ' Code to write the stream goes here.
                Dim streamwriter As StreamWriter = New StreamWriter(myStream)
                streamwriter.WriteLine("ARGB:" + ComboBoxRGBITEMS.Text.ToString())
                streamwriter.WriteLine("Name/HEX:" + ComboBoxName_HEX.Text.ToString())
                streamwriter.Close()
                myStream.Close()
            End If
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim myStream As Stream = Nothing
        Dim openFileDialog1 As New OpenFileDialog()
        Dim fileContext As String
        openFileDialog1.InitialDirectory = "c:\"
        openFileDialog1.Filter = "Color files (*.col)|*.col"
        openFileDialog1.FilterIndex = 2
        openFileDialog1.RestoreDirectory = True

        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            Try
                myStream = openFileDialog1.OpenFile()
                If (myStream IsNot Nothing) Then
                    ' Insert code to read the stream here.
                    Dim sr As StreamReader = New StreamReader(myStream)
                    fileContext = sr.ReadToEnd().ToString()
                    MessageBox.Show(fileContext, "Color")
                    RichTextBoxSeeColor.Text = fileContext.ToString()
                End If
            Catch Ex As Exception
                MessageBox.Show("Cannot read file from disk. Original error: " & Ex.Message)
            Finally
                ' Check this again, since we need to make sure we didn't throw an exception on open.
                If (myStream IsNot Nothing) Then
                    myStream.Close()
                End If
            End Try
        End If

    End Sub
End Class

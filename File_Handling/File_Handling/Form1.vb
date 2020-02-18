Imports System.IO
Imports System.Xml
Imports Newtonsoft.Json

Public Class Form1

    Dim name1 As String
    Dim age As String
    Dim Address As String
    Dim file_name As String

    Dim ser As JsonSerializer = New JsonSerializer()

    Private Sub tbName_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles tbName.KeyPress

        e.Handled = True

        If e.KeyChar Like "[A-z]" Or e.KeyChar = "." Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Then

            e.Handled = False

        End If

    End Sub

    Private Sub tbAge_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles tbAge.KeyPress

        e.Handled = True

        If IsNumeric(e.KeyChar) Or e.KeyChar = Chr(8) Then

            e.Handled = False

        End If

    End Sub
    Private Sub tbAddress_KeyPress(Sender As Object, e As KeyPressEventArgs) Handles tbAddress.KeyPress

        e.Handled = True

        If e.KeyChar Like "[A-z]" Or e.KeyChar = "." Or e.KeyChar = "," Or e.KeyChar = Chr(8) Or e.KeyChar = Chr(32) Then

            e.Handled = False

        End If

    End Sub

    Private Sub btnTxt_Click(sender As Object, e As EventArgs) Handles btnTxt.Click

        If tbAge.Text.Length >= 255 Then

            MessageBox.Show("Youhave exceeded the maximum value of 255")

        End If

        name1 = tbName.Text
        age = tbAge.Text
        Address = tbAddress.Text

        file_name = name1 + ".txt"

        Try

            Using file_write As StreamWriter = New StreamWriter(file_name)

                file_write.WriteLine("Name: " + name1)
                file_write.WriteLine("Age: " + age)
                file_write.WriteLine("Address: " + Address)

            End Using

            MessageBox.Show("TXT file saved")

        Catch ex As Exception

            Dim error_key As String = ex.ToString
            MessageBox.Show("The file can't be processed " + error_key)

        End Try

    End Sub

    Private Sub btnXml_Click(sender As Object, e As EventArgs) Handles btnXml.Click

        If tbAge.Text.Length >= 255 Then

            MessageBox.Show("Youhave exceeded the maximum value of 255")

        End If

        file_name = tbName.Text + ".xml"

        Dim settings As New XmlWriterSettings()
        settings.Indent = True

        ' Initialize the XmlWriter
        Dim xml_write As XmlWriter = XmlWriter.Create(file_name, settings)

        With xml_write

            ' Write the xml declaration
            .WriteStartDocument()

            ' Write a comment
            .WriteComment("XML Data")

            ' Write the root element
            ' .WriteStartElement("Data")

            ' Start first person
            .WriteStartElement("Person")

            ' Person node
            .WriteStartElement("Name")
            .WriteString(tbName.Text.ToString)
            .WriteEndElement()

            .WriteStartElement("Age")
            .WriteString(tbAge.Text.ToString)
            .WriteEndElement()

            .WriteStartElement("Address")
            .WriteString(tbAddress.Text.ToString)
            .WriteEndElement()

            ' End of person
            .WriteEndElement()

            ' Close the XmlTextWriter
            .WriteEndDocument()
            .Close()

        End With

        MessageBox.Show("XML file saved")

    End Sub

    Private Sub btnJson_Click(sender As Object, e As EventArgs) Handles btnJson.Click

        ' Create Person class
        Dim person As Person = New Person()

        person.Name = tbName.Text
        person.Age = tbAge.Text
        person.Address = tbAddress.Text

        file_name = tbName.Text + ".json"

        Dim json_write As String = JsonConvert.SerializeObject(person)
        File.WriteAllText(file_name, json_write)

        MessageBox.Show("JSON file saved")

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub tbName_TextChanged(sender As Object, e As EventArgs) Handles tbName.TextChanged

    End Sub
End Class

Class Person

    Public Property Name As String
    Public Property Age As String
    Public Property Address As String

End Class



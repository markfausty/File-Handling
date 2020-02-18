<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.tbName = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.tbAddress = New System.Windows.Forms.TextBox()
        Me.tbAge = New System.Windows.Forms.TextBox()
        Me.btnTxt = New System.Windows.Forms.Button()
        Me.btnJson = New System.Windows.Forms.Button()
        Me.btnXml = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'tbName
        '
        Me.tbName.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbName.Location = New System.Drawing.Point(171, 64)
        Me.tbName.Margin = New System.Windows.Forms.Padding(2)
        Me.tbName.Multiline = True
        Me.tbName.Name = "tbName"
        Me.tbName.Size = New System.Drawing.Size(205, 24)
        Me.tbName.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(68, 67)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(58, 23)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(68, 130)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(77, 23)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Address"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(68, 98)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 23)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Age"
        '
        'tbAddress
        '
        Me.tbAddress.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAddress.Location = New System.Drawing.Point(171, 130)
        Me.tbAddress.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAddress.Multiline = True
        Me.tbAddress.Name = "tbAddress"
        Me.tbAddress.Size = New System.Drawing.Size(205, 24)
        Me.tbAddress.TabIndex = 4
        '
        'tbAge
        '
        Me.tbAge.Font = New System.Drawing.Font("Consolas", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbAge.Location = New System.Drawing.Point(171, 98)
        Me.tbAge.Margin = New System.Windows.Forms.Padding(2)
        Me.tbAge.Multiline = True
        Me.tbAge.Name = "tbAge"
        Me.tbAge.Size = New System.Drawing.Size(60, 24)
        Me.tbAge.TabIndex = 5
        '
        'btnTxt
        '
        Me.btnTxt.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTxt.Location = New System.Drawing.Point(82, 188)
        Me.btnTxt.Margin = New System.Windows.Forms.Padding(2)
        Me.btnTxt.Name = "btnTxt"
        Me.btnTxt.Size = New System.Drawing.Size(70, 37)
        Me.btnTxt.TabIndex = 7
        Me.btnTxt.Text = "TXT"
        Me.btnTxt.UseVisualStyleBackColor = True
        '
        'btnJson
        '
        Me.btnJson.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnJson.Location = New System.Drawing.Point(286, 188)
        Me.btnJson.Margin = New System.Windows.Forms.Padding(2)
        Me.btnJson.Name = "btnJson"
        Me.btnJson.Size = New System.Drawing.Size(70, 37)
        Me.btnJson.TabIndex = 8
        Me.btnJson.Text = "JSON"
        Me.btnJson.UseVisualStyleBackColor = True
        '
        'btnXml
        '
        Me.btnXml.Font = New System.Drawing.Font("Constantia", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnXml.Location = New System.Drawing.Point(185, 188)
        Me.btnXml.Margin = New System.Windows.Forms.Padding(2)
        Me.btnXml.Name = "btnXml"
        Me.btnXml.Size = New System.Drawing.Size(70, 37)
        Me.btnXml.TabIndex = 9
        Me.btnXml.Text = "XML"
        Me.btnXml.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(450, 275)
        Me.Controls.Add(Me.btnXml)
        Me.Controls.Add(Me.btnJson)
        Me.Controls.Add(Me.btnTxt)
        Me.Controls.Add(Me.tbAge)
        Me.Controls.Add(Me.tbAddress)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tbName)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.Text = "File Handling"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tbName As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents tbAddress As TextBox
    Friend WithEvents tbAge As TextBox
    Friend WithEvents btnTxt As Button
    Friend WithEvents btnJson As Button
    Friend WithEvents btnXml As Button
End Class
